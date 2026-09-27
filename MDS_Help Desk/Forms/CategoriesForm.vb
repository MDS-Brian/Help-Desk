Imports Microsoft.Data.SqlClient

''' <summary>
''' Maintain the lookup lists in dbo.MDS_HelpDesk_Categories (frmHelpDesk_Categories in Access).
''' Entries used by tickets cannot be deleted, and IDs of saved entries cannot be changed,
''' because tickets store the ID.
''' </summary>
Public Class CategoriesForm

    Private Const Caption As String = "Categories"

    Private _category As String
    Private _entries As DataTable

    Private Sub CategoriesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim names = ItAdmin.CategoryNames()
            lstCategories.DisplayMember = "Display"
            lstCategories.ValueMember = "Value"
            lstCategories.DataSource = names
        Catch ex As SqlException
            MessageBox.Show("Could not load the categories from SQL Server." & vbCrLf & vbCrLf & ex.Message,
                            Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginInvoke(Sub() Close())
        End Try
    End Sub

    Private Sub lstCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCategories.SelectedIndexChanged
        If lstCategories.SelectedIndex < 0 OrElse lstCategories.SelectedValue Is Nothing Then Return
        Dim category = lstCategories.SelectedValue.ToString()
        If category = _category Then Return
        If Not ConfirmDiscard() Then
            BeginInvoke(Sub() lstCategories.SelectedValue = _category)
            Return
        End If
        LoadEntries(category)
    End Sub

    Private Sub LoadEntries(category As String)
        Try
            _entries = ItAdmin.CategoryEntries(category)
        Catch ex As SqlException
            MessageBox.Show("Could not load the entries." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        For Each col As DataColumn In _entries.Columns
            col.ReadOnly = False
            col.AllowDBNull = True
        Next
        _category = category
        dgvEntries.DataSource = _entries
        dgvEntries.Columns("ID").Width = 70
        dgvEntries.Columns("Description").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvEntries.Columns("SortOrder").HeaderText = "Sort Order"
        dgvEntries.Columns("SortOrder").Width = 90
        lblEntries.Text = $"Entries in {category}"
        cmdAdd.Enabled = True
        cmdSave.Enabled = True
        cmdDelete.Enabled = True
    End Sub

    ''' <summary>The ID of a saved entry is fixed; only new rows can have their ID typed in.</summary>
    Private Sub dgvEntries_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvEntries.CellBeginEdit
        If dgvEntries.Columns(e.ColumnIndex).Name <> "ID" Then Return
        Dim row = TryCast(dgvEntries.Rows(e.RowIndex).DataBoundItem, DataRowView)
        If row IsNot Nothing AndAlso row.Row.RowState <> DataRowState.Added Then e.Cancel = True
    End Sub

    Private Sub dgvEntries_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvEntries.DataError
        MessageBox.Show("Enter a whole number.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        e.Cancel = True
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If _entries Is Nothing Then Return
        Dim nextId = 1
        For Each r As DataRow In _entries.Rows
            If r.RowState <> DataRowState.Deleted AndAlso r("ID") IsNot DBNull.Value Then nextId = Math.Max(nextId, CInt(r("ID")) + 1)
        Next
        Dim row = _entries.NewRow()
        row("ID") = nextId
        row("SortOrder") = 1
        _entries.Rows.Add(row)
        Dim gridRow = dgvEntries.Rows(dgvEntries.Rows.Count - 1)
        dgvEntries.CurrentCell = gridRow.Cells("Description")
        dgvEntries.BeginEdit(True)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If _entries Is Nothing Then Return
        dgvEntries.EndEdit()
        BindingContext(_entries).EndCurrentEdit()

        ' Check everything before writing anything.
        Dim ids As New HashSet(Of Integer)
        For Each r As DataRow In _entries.Rows
            If r.RowState = DataRowState.Deleted Then Continue For
            If r("ID") Is DBNull.Value Then
                MessageBox.Show("Every entry needs an ID.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If Not ids.Add(CInt(r("ID"))) Then
                MessageBox.Show($"ID {r("ID")} is used twice in {_category}.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If String.IsNullOrWhiteSpace(r("Description").ToString()) Then
                MessageBox.Show($"Entry {r("ID")} needs a description.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Next

        Try
            For Each r As DataRow In _entries.Rows
                Dim sortOrder = If(r.RowState = DataRowState.Deleted OrElse r("SortOrder") Is DBNull.Value, CType(Nothing, Integer?), CInt(r("SortOrder")))
                Select Case r.RowState
                    Case DataRowState.Added
                        ItAdmin.AddCategoryEntry(_category, CInt(r("ID")), r("Description").ToString().Trim(), sortOrder)
                    Case DataRowState.Modified
                        ItAdmin.UpdateCategoryEntry(_category, CInt(r("ID")), r("Description").ToString().Trim(), sortOrder)
                End Select
            Next
        Catch ex As SqlException
            MessageBox.Show("Not all changes were saved." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoadEntries(_category)
            Return
        End Try

        LoadEntries(_category)
        MessageBox.Show("Changes saved.", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim rowView = TryCast(dgvEntries.CurrentRow?.DataBoundItem, DataRowView)
        If rowView Is Nothing Then Return
        Dim row = rowView.Row

        ' A new, unsaved row can just be dropped.
        If row.RowState = DataRowState.Added Then
            _entries.Rows.Remove(row)
            Return
        End If

        Dim id = CInt(row("ID"))
        Try
            Dim used = ItAdmin.TicketsUsingCategory(_category, id)
            If used > 0 Then
                MessageBox.Show($"{row("Description")} is used by {used} ticket(s), so it cannot be deleted.",
                                Caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If MessageBox.Show($"Delete {_category} entry {id} ({row("Description")})?", Caption,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then Return
            ItAdmin.DeleteCategoryEntry(_category, id)
        Catch ex As SqlException
            MessageBox.Show("The entry was not deleted." & vbCrLf & vbCrLf & ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        row.Delete()
        row.AcceptChanges()
    End Sub

    Private Function HasChanges() As Boolean
        If _entries Is Nothing Then Return False
        dgvEntries.EndEdit()
        BindingContext(_entries).EndCurrentEdit()
        Return _entries.GetChanges() IsNot Nothing
    End Function

    Private Function ConfirmDiscard() As Boolean
        If Not HasChanges() Then Return True
        Return MessageBox.Show($"The changes to {_category} were not saved. Discard them?", Caption,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes
    End Function

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub CategoriesForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmDiscard() Then e.Cancel = True
    End Sub

End Class

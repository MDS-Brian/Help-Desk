''' <summary>
''' Helpers for combo boxes bound to lookup tables with Value / Display columns.
''' </summary>
Public Module ComboHelpers

    Public Sub Bind(cbo As ComboBox, data As DataTable)
        cbo.DisplayMember = "Display"
        cbo.ValueMember = "Value"
        cbo.DataSource = data
        cbo.SelectedIndex = -1
    End Sub

    ''' <summary>Adds an "(any)" row with no value at the top of a lookup table, for optional filters.</summary>
    Public Function WithAnyRow(data As DataTable) As DataTable
        For Each col As DataColumn In data.Columns
            col.AllowDBNull = True
        Next
        Dim row = data.NewRow()
        row("Display") = "(any)"
        data.Rows.InsertAt(row, 0)
        Return data
    End Function

    Public Function SelectedInt(cbo As ComboBox) As Integer?
        If cbo.SelectedIndex < 0 OrElse cbo.SelectedValue Is Nothing OrElse cbo.SelectedValue Is DBNull.Value Then Return Nothing
        Return Convert.ToInt32(cbo.SelectedValue)
    End Function

    ''' <summary>
    ''' The selected value as text. If the user typed a value or display text that exists
    ''' in the list it is matched and selected.
    ''' </summary>
    Public Function SelectedText(cbo As ComboBox) As String
        If cbo.SelectedIndex >= 0 AndAlso cbo.SelectedValue IsNot Nothing Then
            If cbo.SelectedValue Is DBNull.Value Then Return Nothing
            Return cbo.SelectedValue.ToString().Trim()
        End If
        Dim typed = cbo.Text.Trim()
        Dim data = TryCast(cbo.DataSource, DataTable)
        If typed.Length = 0 OrElse data Is Nothing Then Return Nothing
        For i = 0 To data.Rows.Count - 1
            Dim row = data.Rows(i)
            If String.Equals(row("Value").ToString().Trim(), typed, StringComparison.OrdinalIgnoreCase) OrElse
               String.Equals(row("Display").ToString().Trim(), typed, StringComparison.OrdinalIgnoreCase) Then
                cbo.SelectedIndex = i
                Return row("Value").ToString().Trim()
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Selects a stored value. A value that is no longer in the list (for example a user who
    ''' left, or an old category) is added so saving the ticket does not wipe it out.
    ''' </summary>
    Public Sub SelectValue(cbo As ComboBox, value As Object, Optional missingDisplay As String = Nothing)
        If value Is Nothing Then
            cbo.SelectedIndex = -1
            If cbo.DropDownStyle <> ComboBoxStyle.DropDownList Then cbo.Text = ""
            Return
        End If
        cbo.SelectedValue = value
        If cbo.SelectedIndex >= 0 Then Return

        Dim data = TryCast(cbo.DataSource, DataTable)
        If data Is Nothing Then Return
        Dim row = data.NewRow()
        row("Value") = Convert.ChangeType(value, data.Columns("Value").DataType)
        row("Display") = If(missingDisplay, value.ToString())
        data.Rows.Add(row)
        cbo.SelectedValue = row("Value")
    End Sub

    ''' <summary>LoginName@domain for the selected user, when the list has a LoginName column.</summary>
    Public Function SelectedEmail(cbo As ComboBox) As String
        Dim row = TryCast(cbo.SelectedItem, DataRowView)
        If row Is Nothing OrElse Not row.DataView.Table.Columns.Contains("LoginName") Then Return Nothing
        Dim login = row("LoginName").ToString().Trim()
        If login.Length = 0 Then Return Nothing
        Return login & "@" & AppConfig.EmailDomain
    End Function

    Public Function NullIfBlank(value As String) As String
        Dim trimmed = value?.Trim()
        Return If(String.IsNullOrEmpty(trimmed), Nothing, trimmed)
    End Function

End Module

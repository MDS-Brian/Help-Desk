''' <summary>Small helpers shared by the list-and-editor screens (Computers, Printers).</summary>
Public Module EditorChanges

    ''' <summary>Calls <paramref name="onChange"/> whenever a field inside <paramref name="parent"/> is edited.</summary>
    Public Sub Track(parent As Control, onChange As Action)
        Dim handler As EventHandler = Sub(s, e) onChange()
        For Each c As Control In parent.Controls
            If TypeOf c Is TextBox Then
                AddHandler c.TextChanged, handler
            ElseIf TypeOf c Is ComboBox Then
                AddHandler DirectCast(c, ComboBox).SelectedIndexChanged, handler
                AddHandler c.TextChanged, handler
            ElseIf TypeOf c Is DateTimePicker Then
                AddHandler DirectCast(c, DateTimePicker).ValueChanged, handler
            End If
        Next
    End Sub

    ''' <summary>Shows a stored value in an item-list combo, adding it if it is not one of the choices.</summary>
    Public Sub SetText(cbo As ComboBox, value As String)
        value = If(value, "").Trim()
        Dim index = -1
        For i = 0 To cbo.Items.Count - 1
            If String.Equals(cbo.Items(i).ToString(), value, StringComparison.OrdinalIgnoreCase) Then index = i : Exit For
        Next
        If index < 0 Then index = cbo.Items.Add(value)
        cbo.SelectedIndex = index
        If cbo.DropDownStyle <> ComboBoxStyle.DropDownList Then cbo.Text = value
    End Sub

    ''' <summary>Selects the grid row whose <paramref name="column"/> equals <paramref name="value"/>.</summary>
    Public Sub SelectRow(grid As DataGridView, column As String, value As String)
        For Each row As DataGridViewRow In grid.Rows
            If String.Equals(row.Cells(column).Value?.ToString(), value, StringComparison.OrdinalIgnoreCase) Then
                grid.CurrentCell = row.Cells(column)
                row.Selected = True
                Return
            End If
        Next
    End Sub

End Module

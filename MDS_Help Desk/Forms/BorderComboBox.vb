Imports System.ComponentModel

''' <summary>
''' A ComboBox with a solid border in BorderColor. It draws its own items so BackColor
''' fills the whole field, including drop-down-list style boxes, which Windows otherwise
''' paints white.
''' </summary>
Public Class BorderedComboBox
    Inherits ComboBox

    Private Const WM_PAINT As Integer = &HF

    Public Sub New()
        DrawMode = DrawMode.OwnerDrawFixed
    End Sub

    <DefaultValue(GetType(Color), "Black")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderColor As Color = Color.Black

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        Dim selected = (e.State And DrawItemState.Selected) = DrawItemState.Selected
        Dim back = If(selected, SystemColors.Highlight, If(Enabled, BackColor, SystemColors.Control))
        Dim fore = If(selected, SystemColors.HighlightText, If(Enabled, ForeColor, SystemColors.GrayText))

        Using brush As New SolidBrush(back)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using
        If e.Index >= 0 Then
            TextRenderer.DrawText(e.Graphics, GetItemText(Items(e.Index)), Font, e.Bounds, fore,
                                  TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or
                                  TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix)
        End If
        MyBase.OnDrawItem(e)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_PAINT Then
            Using g = Graphics.FromHwnd(Handle), pen As New Pen(BorderColor)
                g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1)
            End Using
        End If
    End Sub

End Class

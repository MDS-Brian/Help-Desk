Imports System.Drawing.Printing

''' <summary>
''' A simple paged report: a title and date on every page, a list of blocks laid out top to
''' bottom, and "Page x of y" at the bottom. Replaces the Access reports.
''' </summary>
Public Class ReportDocument
    Inherits PrintDocument

    Friend Shared ReadOnly TitleFont As New Font("Calibri", 16.0!, FontStyle.Bold)
    Friend Shared ReadOnly SubtitleFont As New Font("Calibri", 10.0!, FontStyle.Regular)
    Friend Shared ReadOnly LabelFont As New Font("Calibri", 8.0!, FontStyle.Bold)
    Friend Shared ReadOnly ValueFont As New Font("Calibri", 10.0!, FontStyle.Regular)
    Friend Shared ReadOnly HeadingFont As New Font("Calibri", 11.0!, FontStyle.Bold)
    Friend Shared ReadOnly FooterFont As New Font("Calibri", 8.0!, FontStyle.Regular)
    Friend Shared ReadOnly LabelBrush As Brush = New SolidBrush(Color.FromArgb(96, 96, 96))
    Friend Shared ReadOnly RulePen As New Pen(Color.FromArgb(160, 160, 160), 1)

    Public Property Title As String
    Public Property Subtitle As String
    Public ReadOnly Property Blocks As New List(Of ReportBlock)
    ''' <summary>Drawn under the title on every page, e.g. table column headings.</summary>
    Public Property RepeatHeader As ReportBlock

    Private _pages As List(Of List(Of ReportBlock))
    Private _pageIndex As Integer
    Private ReadOnly _printedAt As Date = Date.Now

    Public Sub New(title As String)
        Me.Title = title
        DocumentName = title
        DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)
    End Sub

    Protected Overrides Sub OnBeginPrint(e As PrintEventArgs)
        MyBase.OnBeginPrint(e)
        _pages = Nothing
        _pageIndex = 0
    End Sub

    Protected Overrides Sub OnPrintPage(e As PrintPageEventArgs)
        MyBase.OnPrintPage(e)
        Dim g = e.Graphics
        Dim area As RectangleF = e.MarginBounds
        Dim footerHeight = FooterFont.GetHeight(g) + 6

        If _pages Is Nothing Then _pages = Paginate(g, area.Width, area.Height - HeaderHeight(g, area.Width) - footerHeight)

        Dim y = DrawHeader(g, area)
        For Each block In _pages(_pageIndex)
            block.Draw(g, area.Left, y, area.Width)
            y += block.Measure(g, area.Width) + block.SpaceAfter
        Next

        Dim footer = $"Page {_pageIndex + 1} of {_pages.Count}"
        Using fmt As New StringFormat With {.Alignment = StringAlignment.Center}
            g.DrawString(footer, FooterFont, Brushes.Black, New RectangleF(area.Left, area.Bottom - footerHeight + 6, area.Width, footerHeight), fmt)
        End Using

        _pageIndex += 1
        e.HasMorePages = _pageIndex < _pages.Count
    End Sub

    Private Function HeaderHeight(g As Graphics, width As Single) As Single
        Dim h = TitleFont.GetHeight(g) + 4
        If Not String.IsNullOrEmpty(Subtitle) Then h += g.MeasureString(Subtitle, SubtitleFont, CInt(width)).Height
        h += 8
        If RepeatHeader IsNot Nothing Then h += RepeatHeader.Measure(g, width) + RepeatHeader.SpaceAfter
        Return h
    End Function

    Private Function DrawHeader(g As Graphics, area As RectangleF) As Single
        Dim y = area.Top
        g.DrawString(Title, TitleFont, Brushes.Black, area.Left, y)
        Using fmt As New StringFormat With {.Alignment = StringAlignment.Far}
            g.DrawString(_printedAt.ToString("D"), SubtitleFont, Brushes.Black, New RectangleF(area.Left, y + 6, area.Width, 20), fmt)
        End Using
        y += TitleFont.GetHeight(g) + 4
        If Not String.IsNullOrEmpty(Subtitle) Then
            Dim h = g.MeasureString(Subtitle, SubtitleFont, CInt(area.Width)).Height
            g.DrawString(Subtitle, SubtitleFont, LabelBrush, New RectangleF(area.Left, y, area.Width, h))
            y += h
        End If
        y += 4
        g.DrawLine(Pens.Black, area.Left, y, area.Right, y)
        y += 4
        If RepeatHeader IsNot Nothing Then
            RepeatHeader.Draw(g, area.Left, y, area.Width)
            y += RepeatHeader.Measure(g, area.Width) + RepeatHeader.SpaceAfter
        End If
        Return y
    End Function

    ''' <summary>Splits the blocks into pages. A block taller than a page gets a page to itself.</summary>
    Private Function Paginate(g As Graphics, width As Single, available As Single) As List(Of List(Of ReportBlock))
        Dim pages As New List(Of List(Of ReportBlock)) From {New List(Of ReportBlock)}
        Dim used As Single = 0
        For Each block In Blocks
            Dim h = block.Measure(g, width)
            If used + h > available AndAlso pages.Last().Count > 0 Then
                pages.Add(New List(Of ReportBlock))
                used = 0
            End If
            pages.Last().Add(block)
            used += h + block.SpaceAfter
        Next
        Return pages
    End Function

End Class

''' <summary>Something drawn on a report page.</summary>
Public MustInherit Class ReportBlock
    Public Property SpaceAfter As Single = 6
    Public MustOverride Function Measure(g As Graphics, width As Single) As Single
    Public MustOverride Sub Draw(g As Graphics, x As Single, y As Single, width As Single)
End Class

''' <summary>A captioned value in a <see cref="FieldGridBlock"/>.</summary>
Public Class ReportField
    Public Sub New(label As String, value As Object, Optional span As Integer = 1)
        Me.Label = label
        Me.Value = FormatValue(value)
        Me.Span = span
    End Sub

    Public ReadOnly Property Label As String
    Public ReadOnly Property Value As String
    Public ReadOnly Property Span As Integer

    Private Shared Function FormatValue(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return ""
        If TypeOf value Is Date Then
            Dim d = CDate(value)
            Return If(d.TimeOfDay = TimeSpan.Zero, d.ToShortDateString(), d.ToString("g"))
        End If
        Return value.ToString().Trim()
    End Function
End Class

''' <summary>Fields laid out in a grid of columns, each with a small caption above its value.</summary>
Public Class FieldGridBlock
    Inherits ReportBlock

    Private Const Gap As Single = 8

    Public Sub New(columns As Integer, Optional ruleAbove As Boolean = False)
        Me.Columns = columns
        Me.RuleAbove = ruleAbove
    End Sub

    Public ReadOnly Property Columns As Integer
    Public ReadOnly Property RuleAbove As Boolean
    Public ReadOnly Property Fields As New List(Of ReportField)

    Public Function Add(label As String, value As Object, Optional span As Integer = 1) As FieldGridBlock
        Fields.Add(New ReportField(label, value, Math.Min(span, Columns)))
        Return Me
    End Function

    ''' <summary>Rows of (field, starting column).</summary>
    Private Function Rows() As List(Of List(Of (Field As ReportField, Col As Integer)))
        Dim result As New List(Of List(Of (Field As ReportField, Col As Integer)))
        Dim current As New List(Of (Field As ReportField, Col As Integer))
        Dim col = 0
        For Each f In Fields
            If col + f.Span > Columns Then
                result.Add(current)
                current = New List(Of (Field As ReportField, Col As Integer))
                col = 0
            End If
            current.Add((f, col))
            col += f.Span
        Next
        If current.Count > 0 Then result.Add(current)
        Return result
    End Function

    Private Function CellWidth(width As Single, span As Integer) As Single
        Return width / Columns * span - Gap
    End Function

    Private Function RowHeight(g As Graphics, row As List(Of (Field As ReportField, Col As Integer)), width As Single) As Single
        Dim h As Single = 0
        For Each cell In row
            Dim valueH = If(cell.Field.Value.Length = 0, ReportDocument.ValueFont.GetHeight(g),
                            g.MeasureString(cell.Field.Value, ReportDocument.ValueFont, CInt(CellWidth(width, cell.Field.Span))).Height)
            h = Math.Max(h, ReportDocument.LabelFont.GetHeight(g) + valueH)
        Next
        Return h + 2
    End Function

    Public Overrides Function Measure(g As Graphics, width As Single) As Single
        Dim h As Single = If(RuleAbove, 6, 0)
        For Each row In Rows()
            h += RowHeight(g, row, width)
        Next
        Return h
    End Function

    Public Overrides Sub Draw(g As Graphics, x As Single, y As Single, width As Single)
        If RuleAbove Then
            g.DrawLine(ReportDocument.RulePen, x, y + 2, x + width, y + 2)
            y += 6
        End If
        Dim labelH = ReportDocument.LabelFont.GetHeight(g)
        For Each row In Rows()
            Dim h = RowHeight(g, row, width)
            For Each cell In row
                Dim cx = x + width / Columns * cell.Col
                Dim cw = CellWidth(width, cell.Field.Span)
                g.DrawString(cell.Field.Label.ToUpperInvariant(), ReportDocument.LabelFont, ReportDocument.LabelBrush, cx, y)
                g.DrawString(cell.Field.Value, ReportDocument.ValueFont, Brushes.Black, New RectangleF(cx, y + labelH, cw, h - labelH))
            Next
            y += h
        Next
    End Sub
End Class

''' <summary>A column in a <see cref="TableRowBlock"/>; Width is a share of the page width.</summary>
Public Class TableColumn
    Public Sub New(header As String, width As Single, Optional alignRight As Boolean = False)
        Me.Header = header
        Me.Width = width
        Me.AlignRight = alignRight
    End Sub

    Public ReadOnly Property Header As String
    Public ReadOnly Property Width As Single
    Public ReadOnly Property AlignRight As Boolean
End Class

''' <summary>One table row, or the heading row when <c>IsHeader</c> is set.</summary>
Public Class TableRowBlock
    Inherits ReportBlock

    Public Sub New(columns As IList(Of TableColumn), values As IList(Of String), Optional isHeader As Boolean = False, Optional ruled As Boolean = False)
        Me.Columns = columns
        Me.Values = values
        Me.IsHeader = isHeader
        Me.Ruled = ruled
        SpaceAfter = 2
    End Sub

    Public Shared Function Header(columns As IList(Of TableColumn)) As TableRowBlock
        Return New TableRowBlock(columns, columns.Select(Function(c) c.Header).ToList(), isHeader:=True)
    End Function

    Public ReadOnly Property Columns As IList(Of TableColumn)
    Public ReadOnly Property Values As IList(Of String)
    Public ReadOnly Property IsHeader As Boolean
    ''' <summary>Draws a line under the row (blank rows for writing in).</summary>
    Public ReadOnly Property Ruled As Boolean

    Private ReadOnly Property RowFont As Font
        Get
            Return If(IsHeader, ReportDocument.HeadingFont, ReportDocument.ValueFont)
        End Get
    End Property

    Private Function Total() As Single
        Return Columns.Sum(Function(c) c.Width)
    End Function

    Public Overrides Function Measure(g As Graphics, width As Single) As Single
        Dim h = RowFont.GetHeight(g)
        For i = 0 To Columns.Count - 1
            Dim cw = width * Columns(i).Width / Total() - 6
            h = Math.Max(h, g.MeasureString(If(Values(i), ""), RowFont, CInt(cw)).Height)
        Next
        If Ruled Then h = Math.Max(h, 26)
        Return h + If(IsHeader, 4, 0)
    End Function

    Public Overrides Sub Draw(g As Graphics, x As Single, y As Single, width As Single)
        Dim h = Measure(g, width)
        Dim cx = x
        For i = 0 To Columns.Count - 1
            Dim cw = width * Columns(i).Width / Total()
            Using fmt As New StringFormat With {.Alignment = If(Columns(i).AlignRight, StringAlignment.Far, StringAlignment.Near)}
                g.DrawString(If(Values(i), ""), RowFont, Brushes.Black, New RectangleF(cx, y, cw - 6, h), fmt)
            End Using
            cx += cw
        Next
        If IsHeader OrElse Ruled Then
            g.DrawLine(If(IsHeader, Pens.Black, ReportDocument.RulePen), x, y + h - 1, x + width, y + h - 1)
        End If
    End Sub
End Class

''' <summary>A line of text, e.g. a section heading.</summary>
Public Class TextBlock
    Inherits ReportBlock

    Public Sub New(text As String, Optional heading As Boolean = False)
        Me.Text = text
        Me.Heading = heading
    End Sub

    Public ReadOnly Property Text As String
    Public ReadOnly Property Heading As Boolean

    Private ReadOnly Property TextFont As Font
        Get
            Return If(Heading, ReportDocument.HeadingFont, ReportDocument.ValueFont)
        End Get
    End Property

    Public Overrides Function Measure(g As Graphics, width As Single) As Single
        Return g.MeasureString(Text, TextFont, CInt(width)).Height
    End Function

    Public Overrides Sub Draw(g As Graphics, x As Single, y As Single, width As Single)
        g.DrawString(Text, TextFont, Brushes.Black, New RectangleF(x, y, width, Measure(g, width)))
    End Sub
End Class

Public Module ReportPreview

    ''' <summary>Shows the report in print preview; printing is done from the preview window.</summary>
    Public Sub Show(owner As IWin32Window, doc As ReportDocument)
        Try
            Using dlg As New PrintPreviewDialog With {
                .Document = doc,
                .Width = 1000,
                .Height = 800,
                .UseAntiAlias = True,
                .Text = doc.Title
            }
                dlg.ShowDialog(owner)
            End Using
        Catch ex As InvalidPrinterException
            MessageBox.Show("No printer is set up on this computer, so the report cannot be previewed." & vbCrLf & vbCrLf & ex.Message,
                            "Help Desk", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Module

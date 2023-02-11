Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class DarkTheme : Inherits ContainerControl

    Private _Down As Boolean = False
    Private ReadOnly _Header As Integer = 36
    Private _Point As Point
    Public Property Movible As Boolean = False

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        If Movible Then _Down = False
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If Movible Then
            If e.Y < _Header AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
                _Point = e.Location
                _Down = True
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If Movible Then
            If _Down = True Then
                ParentForm.Location = MousePosition - _Point
            End If
        End If
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        ParentForm.FormBorderStyle = FormBorderStyle.None
        ParentForm.TransparencyKey = Color.Fuchsia
        Dock = DockStyle.Fill
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(44, 51, 62))
        G.FillRectangle(New SolidBrush(Color.FromArgb(29, 36, 44)), New Rectangle(0, 0, Width, _Header))

        G.FillRectangle(Brushes.Fuchsia, New Rectangle(0, 0, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(1, 0, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(0, 1, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(Width - 1, 0, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(Width - 1, 1, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(Width - 2, 0, 1, 1))

        Dim _StringF As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center
        }
        G.DrawString(Text, New Font("Segoe UI", 12), New SolidBrush(Color.FromArgb(33, 189, 255)), New RectangleF(5, 0, Width, _Header), _StringF)
    End Sub

End Class

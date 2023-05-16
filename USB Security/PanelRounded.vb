Imports System.Drawing.Drawing2D

Public Class PanelRounded : Inherits Panel

    Public Property Diameter As Integer = 10

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(44, 51, 62))

        Dim r = New Rectangle(0, 0, Width, Height)

        Dim path As New GraphicsPath

        path.AddLine(r.Left + Diameter, r.Top, r.Right - Diameter, r.Top)
        path.AddArc(Rectangle.FromLTRB(r.Right - Diameter, r.Top, r.Right, r.Top + Diameter), -90, 90)
        path.AddLine(r.Right, r.Top + Diameter, r.Right, r.Bottom - Diameter)
        path.AddArc(Rectangle.FromLTRB(r.Right - Diameter, r.Bottom - Diameter, r.Right, r.Bottom), 0, 90)
        path.AddLine(r.Right - Diameter, r.Bottom, r.Left + Diameter, r.Bottom)
        path.AddArc(Rectangle.FromLTRB(r.Left, r.Bottom - Diameter, r.Left + Diameter, r.Bottom), 90, 90)
        path.AddLine(r.Left, r.Bottom - Diameter, r.Left, r.Top + Diameter)
        path.AddArc(Rectangle.FromLTRB(r.Left, r.Top, r.Left + Diameter, r.Top + Diameter), 180, 90)
        path.CloseFigure()

        G.FillPath(New SolidBrush(Color.FromArgb(29, 36, 44)), path)
    End Sub

End Class

Imports System.Drawing.Drawing2D

Public Class PanelRounded : Inherits Panel

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(44, 51, 62))

        RoundedRectangle(G, New Rectangle(0, 0, Width, Height), 20)
    End Sub

    Public Sub RoundedRectangle(ByVal objGraphics As Graphics, ByVal r As Rectangle, ByVal d As Integer)
        Dim path As New GraphicsPath

        path.AddLine(r.Left + d, r.Top, r.Right - d, r.Top)
        path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Top, r.Right, r.Top + d), -90, 90)
        path.AddLine(r.Right, r.Top + d, r.Right, r.Bottom - d)
        path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Bottom - d, r.Right, r.Bottom), 0, 90)
        path.AddLine(r.Right - d, r.Bottom, r.Left + d, r.Bottom)
        path.AddArc(Rectangle.FromLTRB(r.Left, r.Bottom - d, r.Left + d, r.Bottom), 90, 90)
        path.AddLine(r.Left, r.Bottom - d, r.Left, r.Top + d)
        path.AddArc(Rectangle.FromLTRB(r.Left, r.Top, r.Left + d, r.Top + d), 180, 90)
        path.CloseFigure()

        objGraphics.FillPath(New SolidBrush(Color.FromArgb(28, 28, 28)), path)
    End Sub

End Class

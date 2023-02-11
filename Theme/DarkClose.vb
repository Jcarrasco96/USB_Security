Imports System.Windows.Forms

Public Class DarkClose : Inherits MyControl

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(24, 24)
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(24, 24)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        BackColor = Color.Transparent

        Dim _StringF As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(8, 161, 248)), 2), 5, 5, Width - 5, Height - 5)
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(8, 161, 248)), 2), 5, Height - 5, Width - 5, 5)

        Select Case _State
            Case MouseState.Over
                G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(40, Color.DarkBlue)), 2), 5, 5, Width - 5, Height - 5)
                G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(40, Color.DarkBlue)), 2), 5, Height - 5, Width - 5, 5)
            Case MouseState.Down
                G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(80, Color.DarkBlue)), 2), 5, 5, Width - 5, Height - 5)
                G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(80, Color.DarkBlue)), 2), 5, Height - 5, Width - 5, 5)
        End Select

    End Sub

End Class

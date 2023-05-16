Imports System.Windows.Forms

Public Class DarkButton : Inherits MyControl

    Sub New()
        Size = New Size(85, 85)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(66, 219, 183))
        G.FillRectangle(New SolidBrush(Color.FromArgb(8, 161, 248)), New Rectangle(0, 0, Width, Height))

        If Not Enabled Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(200, Color.Black)), New Rectangle(0, 0, Width, Height))
        Else
            Select Case _State
                Case MouseState.Over
                    G.FillRectangle(New SolidBrush(Color.FromArgb(40, Color.White)), New Rectangle(0, 0, Width, Height))
                Case MouseState.Down
                    G.FillRectangle(New SolidBrush(Color.FromArgb(80, Color.Black)), New Rectangle(0, 0, Width, Height))
            End Select
        End If

        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(0, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(1, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(0, 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 1, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 1, 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 2, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(0, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(1, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(0, Height - 2, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 1, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 1, Height - 2, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 2, Height - 1, 1, 1))

        If Text = vbNullString And Not IsNothing(BackgroundImage) Then
            G.DrawImage(BackgroundImage, New Rectangle(2, 2, Width - 4, Height - 4))
        Else
            Dim _StringF As New StringFormat With {
                .Alignment = StringAlignment.Center,
                .LineAlignment = StringAlignment.Center
            }
            G.DrawString(Text, Me.Font, Brushes.White, New RectangleF(0, 0, Width - 1, Height - 1), _StringF)
        End If
    End Sub

End Class
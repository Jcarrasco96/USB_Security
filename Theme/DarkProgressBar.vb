Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class DarkProgressBar : Inherits ProgressBar

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.PixelOffsetMode = PixelOffsetMode.HighQuality
        G.Clear(Color.FromArgb(32, 37, 41))

        Dim _Progress As Integer = 0

        Try
            _Progress = CInt(Value / Maximum * Width)
        Catch ex As Exception

        End Try

        G.FillRectangle(New SolidBrush(Color.FromArgb(33, 189, 255)), New Rectangle(0, 0, _Progress - 1, Height))
        G.FillRectangle(New SolidBrush(Color.FromArgb(32, 37, 41)), New Rectangle(_Progress - 1, 0, Width - _Progress, Height))

        G.InterpolationMode = InterpolationMode.HighQualityBicubic
    End Sub

End Class

Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

<DefaultEvent("CheckedChanged")>
Public Class DarkCheckBox : Inherits MyControl

    Private _Checked As Boolean

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(sender As Object)

    Protected Overrides Sub OnClick(e As EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 16
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(35, 35, 35))
        G.DrawLine(New Pen(Color.FromArgb(26, 29, 33)), New Point(0, 0), New Point(0, 14))
        G.DrawLine(New Pen(Color.FromArgb(26, 29, 33)), New Point(0, 0), New Point(14, 0))

        If Checked Then
            G.FillRectangle(New LinearGradientBrush(New Point(3, 3), New Point(3, 13), Color.FromArgb(33, 189, 255), Color.FromArgb(33, 189, 255)), New Rectangle(3, 3, 9, 9))
            G.FillRectangle(New LinearGradientBrush(New Point(4, 4), New Point(4, 11), Color.FromArgb(33, 189, 255), Color.FromArgb(21, 30, 73)), New Rectangle(4, 4, 7, 7))
            'G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New Point(18, -1))
        End If

        Select Case _State
            Case MouseState.None
                G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), New SolidBrush(Color.White), New Point(18, -1))
            Case MouseState.Over
                G.DrawRectangle(New Pen(Color.FromArgb(33, 189, 255), 2), New Rectangle(1, 1, 13, 13))
                G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.WhiteSmoke, New Point(18, -1))
            Case MouseState.Down
                G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.WhiteSmoke, New Point(18, -1))
        End Select
    End Sub

End Class

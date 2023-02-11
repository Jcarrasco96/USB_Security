Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

<DefaultEvent("CheckedChanged")>
Public Class DarkRadioButton : Inherits MyControl

    Private _Checked As Boolean

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(sender As Object)

    Protected Overrides Sub OnClick(e As EventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnClick(e)
    End Sub

    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return
        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is DarkRadioButton Then
                DirectCast(C, DarkRadioButton).Checked = False
                Invalidate()
            End If
        Next
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        InvalidateControls()
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 16
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        If Not _Checked Then Checked = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.SmoothingMode = 2
        G.TextRenderingHint = 5
        G.Clear(Color.FromArgb(44, 51, 62))
        G.FillEllipse(New SolidBrush(Color.FromArgb(36, 39, 46)), New Rectangle(0, 0, 15, 15))
        G.DrawEllipse(New Pen(Color.FromArgb(26, 29, 33)), New Rectangle(0, 0, 15, 15))
        If Checked Then
            G.FillEllipse(New LinearGradientBrush(New Point(3, 3), New Point(3, 12), Color.FromArgb(123, 255, 201), Color.FromArgb(41, 131, 113)), New Rectangle(3, 3, 9, 9))
            G.FillEllipse(New LinearGradientBrush(New Point(4, 4), New Point(4, 11), Color.FromArgb(9, 204, 157), Color.FromArgb(41, 131, 113)), New Rectangle(4, 4, 7, 7))
            G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New Point(18, -1))
        Else
            Select Case _State
                Case MouseState.None
                    G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), New SolidBrush(Color.FromArgb(121, 131, 141)), New Point(18, -1))
                Case MouseState.Over
                    G.DrawEllipse(New Pen(Color.FromArgb(0, 205, 155), 2), New Rectangle(1, 1, 13, 13))
                    G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New Point(18, -1))
                Case MouseState.Down
                    G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New Point(18, -1))
            End Select
        End If
    End Sub

End Class
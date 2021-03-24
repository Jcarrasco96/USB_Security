﻿Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Text

Enum MouseState
    None = 0
    Over = 1
    Down = 2
End Enum

Class MysticTheme
    Inherits ContainerControl

#Region " Declarations "
    Private _Down As Boolean = False
    Private _Header As Integer = 36
    Private _Point As Point
#End Region

#Region " Mouse States "

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _Down = False
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Y < _Header AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            _Point = e.Location
            _Down = True
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If _Down = True Then
            ParentForm.Location = MousePosition - _Point
        End If
    End Sub

#End Region

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
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, _Header), Color.FromArgb(29, 36, 44), Color.FromArgb(22, 29, 35)), New Rectangle(0, 0, Width, _Header))

        G.FillRectangle(Brushes.Fuchsia, New Rectangle(0, 0, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(1, 0, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(0, 1, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(Width - 1, 0, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(Width - 1, 1, 1, 1))
        G.FillRectangle(Brushes.Fuchsia, New Rectangle(Width - 2, 0, 1, 1))

        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Near
        _StringF.LineAlignment = StringAlignment.Center
        G.DrawString(Text, New Font("Segoe UI", 11), New SolidBrush(Color.FromArgb(33, 189, 255)), New RectangleF(10, 0, Width, _Header), _StringF)

    End Sub

End Class

Class MysticButton
    Inherits Control

#Region " Declarations "
    Private _State As MouseState = MouseState.None
#End Region

#Region " Mouse States "

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub

#End Region

    Sub New()
        Size = New Size(85, 85)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(66, 219, 183))
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(33, 189, 255), Color.FromArgb(21, 30, 73)), New Rectangle(0, 0, Width, Height))

        Select Case _State
            Case MouseState.Over
                G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), New Rectangle(0, 0, Width, Height))
            Case MouseState.Down
                G.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), New Rectangle(0, 0, Width, Height))
        End Select

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

        If Text = vbNullString Then
            G.DrawImage(BackgroundImage, New Point(0, 0))
        Else
            Dim _StringF As New StringFormat
            _StringF.Alignment = StringAlignment.Center
            _StringF.LineAlignment = StringAlignment.Center
            G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New RectangleF(0, 0, Width - 1, Height - 1), _StringF)
        End If

    End Sub

End Class

<DefaultEvent("CheckedChanged")>
Class MysticRadioButton
    Inherits Control

#Region " Variables "
    Private _State As MouseState = MouseState.None
    Private _Checked As Boolean
#End Region

#Region " Properties "
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
    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(e As EventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnClick(e)
    End Sub
    Private Sub InvalidateControls()
        If Not IsHandleCreated OrElse Not _Checked Then Return
        For Each C As Control In Parent.Controls
            If C IsNot Me AndAlso TypeOf C Is MysticRadioButton Then
                DirectCast(C, MysticRadioButton).Checked = False
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

#Region " Mouse States "

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        If Not _Checked Then Checked = True
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

#End Region
#End Region

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

<DefaultEvent("CheckedChanged")>
Class MysticCheckBox
    Inherits Control

#Region " Variables "
    Private _State As MouseState = MouseState.None
    Private _Checked As Boolean
#End Region

#Region " Properties "
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property

    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 16
    End Sub

#End Region

#Region " Mouse States "

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

#End Region

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(44, 51, 62))
        G.DrawLine(New Pen(Color.FromArgb(26, 29, 33)), New Point(0, 0), New Point(0, 14))
        G.DrawLine(New Pen(Color.FromArgb(26, 29, 33)), New Point(0, 0), New Point(14, 0))
        If Checked Then
            G.FillRectangle(New LinearGradientBrush(New Point(3, 3), New Point(3, 13), Color.FromArgb(33, 189, 255), Color.FromArgb(33, 189, 255)), New Rectangle(3, 3, 9, 9))
            G.FillRectangle(New LinearGradientBrush(New Point(4, 4), New Point(4, 11), Color.FromArgb(33, 189, 255), Color.FromArgb(21, 30, 73)), New Rectangle(4, 4, 7, 7))
            G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New Point(18, -1))
        Else
            Select Case _State
                Case MouseState.None
                    G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), New SolidBrush(Color.FromArgb(121, 131, 141)), New Point(18, -1))
                Case MouseState.Over
                    G.DrawRectangle(New Pen(Color.FromArgb(33, 189, 255), 2), New Rectangle(1, 1, 13, 13))
                    G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New Point(18, -1))
                Case MouseState.Down
                    G.DrawString(Text, New Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, New Point(18, -1))
            End Select
        End If
    End Sub
End Class

<DefaultEvent("TextChanged")>
Class MysticTextBox
    Inherits Control

#Region " Variables "

    Private _State As MouseState = MouseState.None
    Private WithEvents _TextBox As Windows.Forms.TextBox
    Private _Focus As Boolean = False
#End Region

#Region " Properties "

#Region " TextBox Properties "

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    <Category("Options")> _
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            If _TextBox IsNot Nothing Then
                _TextBox.TextAlign = value
            End If
        End Set
    End Property
    Private _MaxLength As Integer = 32767
    <Category("Options")> _
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(ByVal value As Integer)
            _MaxLength = value
            If _TextBox IsNot Nothing Then
                _TextBox.MaxLength = value
            End If
        End Set
    End Property
    Private _ReadOnly As Boolean
    <Category("Options")> _
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
            If _TextBox IsNot Nothing Then
                _TextBox.ReadOnly = value
            End If
        End Set
    End Property
    Private _UseSystemPasswordChar As Boolean
    <Category("Options")> _
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _UseSystemPasswordChar = value
            If _TextBox IsNot Nothing Then
                _TextBox.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    Private _Multiline As Boolean
    <Category("Options")> _
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(ByVal value As Boolean)
            _Multiline = value
            If _TextBox IsNot Nothing Then
                _TextBox.Multiline = value

                If value Then
                    _TextBox.Height = Height - 11
                Else
                    Height = _TextBox.Height + 11
                End If

            End If
        End Set
    End Property
    <Category("Options")> _
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            MyBase.Text = value
            If _TextBox IsNot Nothing Then
                _TextBox.Text = value
            End If
        End Set
    End Property
    <Category("Options")> _
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            If _TextBox IsNot Nothing Then
                _TextBox.Font = value
                _TextBox.Location = New Point(3, 5)
                _TextBox.Width = Width - 6

                If Not _Multiline Then
                    Height = _TextBox.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(_TextBox) Then
            Controls.Add(_TextBox)
        End If
    End Sub
    Private Sub OnBaseTextChanged(ByVal s As Object, ByVal e As EventArgs)
        Text = _TextBox.Text
    End Sub
    Private Sub OnBaseKeyDown(ByVal s As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            _TextBox.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            _TextBox.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        _TextBox.Location = New Point(5, 5)
        _TextBox.Width = Width - 10

        If _Multiline Then
            _TextBox.Height = Height - 11
        Else
            Height = _TextBox.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        _Focus = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)
        _Focus = False
        Invalidate()
    End Sub

#End Region

#Region " Mouse States "

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        _TextBox.Focus()
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        _TextBox.Focus()
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

#End Region

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True

        BackColor = Color.Transparent

        _TextBox = New Windows.Forms.TextBox
        _TextBox.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        _TextBox.Text = Text
        _TextBox.BackColor = Color.FromArgb(34, 37, 44)
        _TextBox.ForeColor = Color.White
        _TextBox.MaxLength = _MaxLength
        _TextBox.Multiline = _Multiline
        _TextBox.ReadOnly = _ReadOnly
        _TextBox.UseSystemPasswordChar = _UseSystemPasswordChar
        _TextBox.BorderStyle = BorderStyle.None
        _TextBox.Location = New Point(5, 5)
        _TextBox.Width = Width - 10

        _TextBox.Cursor = Cursors.IBeam

        If _Multiline Then
            _TextBox.Height = Height - 11
        Else
            Height = _TextBox.Height + 11
        End If

        AddHandler _TextBox.TextChanged, AddressOf OnBaseTextChanged
        AddHandler _TextBox.KeyDown, AddressOf OnBaseKeyDown
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(34, 37, 44))

        G.DrawRectangle(New Pen(Color.FromArgb(0, 206, 153), 2), New Rectangle(1, 1, Width - 2, Height - 2))

        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(0, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 1, 0, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(0, Height - 1, 1, 1))
        G.FillRectangle(New SolidBrush(Color.FromArgb(44, 51, 62)), New Rectangle(Width - 1, Height - 1, 1, 1))
    End Sub

End Class

Class MysticClose
    Inherits Control

#Region " Declarations "
    Private _State As MouseState
#End Region

#Region " Mouse States "
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        _State = MouseState.None
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _State = MouseState.Down
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _State = MouseState.Over
        Invalidate()
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        'Environment.Exit(0)
    End Sub
#End Region

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(12, 12)
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(12, 12)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        BackColor = Color.Transparent

        Dim _StringF As New StringFormat
        _StringF.Alignment = StringAlignment.Center
        _StringF.LineAlignment = StringAlignment.Center

        G.DrawString("r", New Font("Marlett", 11), New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(33, 189, 255), Color.FromArgb(33, 189, 255)), New RectangleF(0, 0, Width, Height), _StringF)

        Select Case _State
            Case MouseState.Down
                G.DrawString("r", New Font("Marlett", 11), New SolidBrush(Color.FromArgb(40, Color.Black)), New RectangleF(0, 0, Width, Height), _StringF)
        End Select

    End Sub

End Class

Class ProgressB
    Inherits ProgressBar

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
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(80, Color.White), Color.FromArgb(100, Color.Black)), New Rectangle(0, 0, _Progress - 1, Height))
        G.FillRectangle(New SolidBrush(Color.FromArgb(32, 37, 41)), New Rectangle(_Progress - 1, 0, Width - _Progress, Height))

        G.InterpolationMode = InterpolationMode.HighQualityBicubic
    End Sub

End Class


Imports System.ComponentModel
Imports System.Windows.Forms

<DefaultEvent("TextChanged")>
Public Class DarkTextBox : Inherits Control

    Private WithEvents TextBox As TextBox

    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left

    <Category("Options")>
    Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(value As HorizontalAlignment)
            _TextAlign = value
            If TextBox IsNot Nothing Then
                TextBox.TextAlign = value
            End If
        End Set
    End Property

    Private _MaxLength As Integer = 32767

    <Category("Options")>
    Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(value As Integer)
            _MaxLength = value
            If TextBox IsNot Nothing Then
                TextBox.MaxLength = value
            End If
        End Set
    End Property

    Private _ReadOnly As Boolean

    <Category("Options")>
    Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(value As Boolean)
            _ReadOnly = value
            If TextBox IsNot Nothing Then
                TextBox.ReadOnly = value
            End If
        End Set
    End Property

    Private _UseSystemPasswordChar As Boolean

    <Category("Options")>
    Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            _UseSystemPasswordChar = value
            If TextBox IsNot Nothing Then
                TextBox.UseSystemPasswordChar = value
            End If
        End Set
    End Property

    Private _Multiline As Boolean

    <Category("Options")>
    Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(value As Boolean)
            _Multiline = value
            If TextBox IsNot Nothing Then
                TextBox.Multiline = value

                If value Then
                    TextBox.Height = Height - 11
                Else
                    Height = TextBox.Height + 11
                End If
            End If
        End Set
    End Property

    <Category("Options")>
    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            If TextBox IsNot Nothing Then
                TextBox.Text = value
            End If
        End Set
    End Property

    <Category("Options")>
    Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            If TextBox IsNot Nothing Then
                TextBox.Font = value
                TextBox.Location = New Point(3, 5)
                TextBox.Width = Width - 6

                If Not _Multiline Then
                    Height = TextBox.Height + 11
                End If
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(TextBox) Then
            Controls.Add(TextBox)
        End If
    End Sub
    Private Sub OnBaseTextChanged(s As Object, e As EventArgs)
        Text = TextBox.Text
    End Sub

    Private Sub OnBaseKeyDown(s As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TextBox.SelectAll()
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            TextBox.Copy()
            e.SuppressKeyPress = True
        End If
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        TextBox.Location = New Point(5, 5)
        TextBox.Width = Width - 10

        If _Multiline Then
            TextBox.Height = Height - 11
        Else
            Height = TextBox.Height + 11
        End If

        MyBase.OnResize(e)
    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True

        BackColor = Color.Transparent

        TextBox = New TextBox With {
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .Text = Text,
            .BackColor = Color.FromArgb(34, 37, 44),
            .ForeColor = Color.White,
            .MaxLength = _MaxLength,
            .Multiline = _Multiline,
            .ReadOnly = _ReadOnly,
            .UseSystemPasswordChar = _UseSystemPasswordChar,
            .BorderStyle = BorderStyle.None,
            .Location = New Point(5, 5),
            .Width = Width - 10,
            .Cursor = Cursors.IBeam
        }

        If _Multiline Then
            TextBox.Height = Height - 11
        Else
            Height = TextBox.Height + 11
        End If

        AddHandler TextBox.TextChanged, AddressOf OnBaseTextChanged
        AddHandler TextBox.KeyDown, AddressOf OnBaseKeyDown
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G = e.Graphics
        G.Clear(Color.FromArgb(34, 37, 44))
        G.DrawRectangle(New Pen(Color.FromArgb(33, 189, 255), 2), New Rectangle(1, 1, Width - 2, Height - 2))
    End Sub

End Class

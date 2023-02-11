﻿Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class DarkComboBox : Inherits ComboBox

    Private _AccentColor As Color
    Private _StartIndex As Integer = 0

    Public Property AccentColor() As Color
        Get
            Return _AccentColor
        End Get
        Set(value As Color)
            _AccentColor = value
            Invalidate()
        End Set
    End Property

    Private Property StartIndex As Integer
        Get
            Return _StartIndex
        End Get
        Set(value As Integer)
            _StartIndex = value
            Try
                SelectedIndex = value
            Catch
            End Try
            Invalidate()
        End Set
    End Property

    Sub ReplaceItem(sender As Object, e As DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()
        Try
            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(New SolidBrush(_AccentColor), e.Bounds)
            Else
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(35, 35, 35)), e.Bounds)
            End If
            e.Graphics.DrawString(GetItemText(Items(e.Index)), e.Font, Brushes.White, e.Bounds)
        Catch
        End Try
    End Sub

    Protected Sub DrawTriangle(Clr As Color, FirstPoint As Point, SecondPoint As Point, ThirdPoint As Point, G As Graphics)
        Dim points As New List(Of Point) From {
            FirstPoint,
            SecondPoint,
            ThirdPoint
        }
        G.FillPolygon(New SolidBrush(Clr), points.ToArray())
    End Sub

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DrawMode = DrawMode.OwnerDrawFixed
        BackColor = Color.FromArgb(50, 50, 50)
        ForeColor = Color.White
        AccentColor = Color.DodgerBlue
        DropDownStyle = ComboBoxStyle.DropDownList
        Font = New Font("Segoe UI Semilight", 9.75F)
        StartIndex = 0
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        G.SmoothingMode = SmoothingMode.HighQuality

        G.Clear(Color.FromArgb(50, 50, 50))
        G.DrawLine(New Pen(Color.White, 2), New Point(Width - 18, 10), New Point(Width - 14, 14))
        G.DrawLine(New Pen(Color.White, 2), New Point(Width - 14, 14), New Point(Width - 10, 10))
        G.DrawLine(New Pen(Color.White), New Point(Width - 14, 15), New Point(Width - 14, 14))
        G.DrawRectangle(New Pen(Color.FromArgb(100, 100, 100)), New Rectangle(0, 0, Width - 1, Height - 1))

        Try
            G.DrawString(Text, Font, Brushes.White, New Rectangle(7, 0, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
        Catch

        End Try

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()
    End Sub

End Class

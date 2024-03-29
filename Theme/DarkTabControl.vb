﻿Imports System.Windows.Forms

Public Class DarkTabControl : Inherits TabControl

    Private ReadOnly AccentColor As Color = Color.FromArgb(33, 189, 255)
    Private ReadOnly MainColor As Color = Color.FromArgb(35, 35, 35)
    Public Property TabTextColor As Color = Color.Black

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True

        BackColor = Color.FromArgb(250, 50, 50)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics

        Try : SelectedTab.BackColor = MainColor : Catch : End Try
        G.Clear(Color.FromArgb(44, 51, 62))

        Dim sf As New StringFormat With {
            .LineAlignment = StringAlignment.Center,
            .Alignment = StringAlignment.Center
        }

        For i As Integer = 0 To TabPages.Count - 1
            If Not i = SelectedIndex Then
                Dim TabRect As New Rectangle(GetTabRect(i).X, GetTabRect(i).Y, GetTabRect(i).Width, GetTabRect(i).Height)
                G.FillRectangle(New SolidBrush(MainColor), TabRect)
                G.DrawString(TabPages(i).Text, New Font("Segoe UI", 9.75F), New SolidBrush(TabTextColor), TabRect, sf)
            End If
        Next

        G.FillRectangle(New SolidBrush(MainColor), 0, ItemSize.Height, Width, Height)

        If Not SelectedIndex = -1 Then
            Dim TabRect As New Rectangle(GetTabRect(SelectedIndex).X - 2, GetTabRect(SelectedIndex).Y, GetTabRect(SelectedIndex).Width + 4, GetTabRect(SelectedIndex).Height)
            G.FillRectangle(New SolidBrush(AccentColor), TabRect)
            G.DrawString(TabPages(SelectedIndex).Text, New Font("Segoe UI", 9.75F), New SolidBrush(TabTextColor), TabRect, sf)
        End If

    End Sub

End Class

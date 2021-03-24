Public Module Messages

    Public Declare Function ShowWindowA Lib "user32" Alias "ShowWindow" (ByVal hwnd As Long, ByVal nCmdShow As Long) As Integer
    Public Declare Function SendMessageA Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As Integer) As Integer
    Public Declare Function FindWindowA Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function GetActiveWindowA Lib "user32" Alias "GetActiveWindow" () As Integer

    Public Function IsWinFocus(ByVal handle As Integer) As Boolean
        Return GetActiveWindowA() = handle
    End Function

    Public Function ShowWindow(ByVal hwnd As Long, ByVal nCmdShow As Long) As Integer
        Return ShowWindowA(hwnd, nCmdShow)
    End Function

    Public Function SendMessage(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As Integer) As Integer
        Return SendMessageA(hwnd, wMsg, wParam, lParam)
    End Function

    Public Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
        Return FindWindowA(lpClassName, lpWindowName)
    End Function

End Module

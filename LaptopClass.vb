Public Class LaptopClass
    Inherits ComputerClass

    Private TouchScreen As Boolean
    Private RemovableScreen As Boolean
    Private TabletMode As Boolean
    Private USBport As Integer

    Public Sub New(ByVal C As String, ByVal Wid As Single, ByVal H As Single, ByVal Wei As Single, ByVal M As String, ByVal P As String, _
                   ByVal RS As String, ByVal SS As String, ByVal TS As Boolean, ByVal RemScreen As Boolean, ByVal TM As Boolean, ByVal U As Integer)

        MyBase.New(C, Wid, H, Wei, M, P, RS, SS)
        Me.TouchScreen = TS
        Me.RemovableScreen = RemScreen
        Me.TabletMode = TM
        Me.USBport = U

    End Sub

    Public Function getTouchScreen() As Boolean
        Return Me.TouchScreen
    End Function

    Public Function getRemovableScreen() As Boolean
        Return Me.RemovableScreen
    End Function

    Public Function getTabletMode() As Boolean
        Return Me.TabletMode
    End Function

    Public Function getUSBport() As Integer
        Return Me.USBport
    End Function

    Public Sub setTouchScreen(ByVal Value As Boolean)
        Me.TouchScreen = Value
    End Sub

    Public Sub setRemovableScreen(ByVal Value As Boolean)
        Me.RemovableScreen = Value
    End Sub

    Public Sub setTabletMode(ByVal Value As Boolean)
        Me.TabletMode = Value
    End Sub

    Public Sub setUSBport(ByVal Value As Integer)
        Me.USBport = Value
    End Sub

End Class

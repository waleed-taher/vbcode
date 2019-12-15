Public Class MobilePhoneClass
    Inherits ComputerClass

    Private Camera As Boolean
    Private Net3G As Boolean
    Private Net4G As Boolean
    Private Network As String

    Public Sub New(ByVal C As String, ByVal Wid As Single, ByVal H As Single, ByVal Wei As Single, ByVal M As String, ByVal P As String, _
                   ByVal RS As String, ByVal SS As String, ByVal Cam As Boolean, ByVal N3G As Boolean, ByVal N4G As Boolean, ByVal Net As String)

        MyBase.New(C, Wid, H, Wei, M, P, RS, SS)
        Me.Camera = Cam
        Me.Net3G = N3G
        Me.Net4G = N4G
        Me.Network = Net

    End Sub

    Public Function getCamera() As Boolean
        Return Me.Camera
    End Function

    Public Function getNet3G() As Boolean
        Return Me.Net3G
    End Function

    Public Function getNet4G() As Boolean
        Return Me.Net4G
    End Function

    Public Function getNetwork() As String
        Return Me.Network
    End Function

    Public Sub setCamera(ByVal Value As Boolean)
        Me.Camera = Value
    End Sub

    Public Sub setNet3G(ByVal Value As Boolean)
        Me.Net3G = Value
    End Sub

    Public Sub setNet4G(ByVal Value As Boolean)
        Me.Net4G = Value
    End Sub

    Public Sub setNetwork(ByVal Value As Boolean)
        Me.Network = Value
    End Sub
End Class

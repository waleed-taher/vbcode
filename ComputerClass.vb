Public Class ComputerClass
    Private Code As String
    Private ComputerWidth As Single
    Private Height As Single
    Private ComputerWeight As Single
    Private Make As String
    Private Processor As String
    Private RamSize As String
    Private StorageSize As String

    Public Sub New(ByVal C As String, ByVal Wid As Single, ByVal H As Single, ByVal Wei As Single, ByVal M As String, ByVal P As String, ByVal RS As String, ByVal SS As String)
        Me.Code = C
        Me.ComputerWidth = Wid
        Me.Height = H
        Me.ComputerWidth = Wei
        Me.Make = M
        Me.Processor = P
        Me.RamSize = RS
        Me.StorageSize = SS
    End Sub

    Public Function getCode() As String
        Return Me.Code
    End Function

    Public Function getComputerWidth() As Single
        Return Me.ComputerWidth
    End Function

    Public Function getHeight() As Single
        Return Me.Height
    End Function

    Public Function getComputerWeight() As Single
        Return Me.ComputerWeight
    End Function

    Public Function getMake() As String
        Return Me.Make
    End Function

    Public Function getProcessor() As String
        Return Me.Processor
    End Function

    Public Function getRamSize() As String
        Return Me.RamSize
    End Function

    Public Function getStorageSize() As String
        Return Me.StorageSize
    End Function

    Public Sub setCode(ByVal Value As String)
        Me.Code = Value
    End Sub
    Public Sub setComputerWidth(ByVal Value As Single)
        Me.ComputerWidth = Value
    End Sub
    Public Sub setHeight(ByVal Value As Single)
        Me.Height = Value
    End Sub
    Public Sub setComputerWeight(ByVal Value As Single)
        Me.ComputerWeight = Value
    End Sub
    Public Sub setMake(ByVal Value As String)
        Me.Make = Value
    End Sub
    Public Sub setProcessor(ByVal Value As String)
        Me.Processor = Value
    End Sub
    Public Sub setRamSize(ByVal Value As String)
        Me.RamSize = Value
    End Sub
    Public Sub seStorageSize(ByVal Value As String)
        Me.StorageSize = Value
    End Sub
End Class

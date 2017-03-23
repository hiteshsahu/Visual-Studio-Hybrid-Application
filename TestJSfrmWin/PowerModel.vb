Imports System.Security.Permissions
<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
<System.Runtime.InteropServices.ComVisibleAttribute(True)>
Public Class PowerModel

    Public Sub New(ByVal firstName As String, _
           ByVal lastName As String)
        Me.year = firstName
        Me.value = lastName
    End Sub

    Private year As String
    Private value As String

    Public Function getYear() As String
        Return Me.year
    End Function

    Public Function getValue() As String
        Return Me.value
    End Function

End Class

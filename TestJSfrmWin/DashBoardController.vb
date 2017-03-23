Imports System.Security.Permissions

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
<System.Runtime.InteropServices.ComVisibleAttribute(True)>
Public Class DashBoardController

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.WebBrowser1.Document.InvokeScript("showJavascriptHelloWorld")
        Me.WebBrowser1.Document.InvokeScript("showJavascriptHelloWorld", New String() {"Message from vb.net to javascript"})
    End Sub

    Public Sub showVbHelloWorld()
        MsgBox("Function of WinForm called from Javascript")
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.WebBrowser1.ObjectForScripting = Me
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.WebBrowser1.Document.InvokeScript("sendPerson", New PowerModel() {New PowerModel("Parag", "Smith")})
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


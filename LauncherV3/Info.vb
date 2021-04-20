Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Info
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Info_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim box = New Form1()
        box.Show()
        Me.Hide()
    End Sub
End Class
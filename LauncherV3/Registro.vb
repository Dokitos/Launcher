Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient

Public Class Registro
    Dim objconn = New MySqlConnection

    '=============== REF Check for empty ===============
    '===================================================














    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        objconn.ConnectionString = "server=127.0.0.1;user id=root;password=;database=launcher"
        objconn.Open()
        Dim objcmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO usuario(id,data_reg,USUARIO,SENHA)VALUES(@field1,@field2,@field3,@field4)", objconn)
        With objcmd
            .Parameters.AddWithValue("@field1", "1")
            .Parameters.AddWithValue("@field2", Date.Today)
            .Parameters.AddWithValue("@field3", txt_user.Text)
            .Parameters.AddWithValue("@field4", txt_pass.Text)
        End With
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()


    End Sub













    Private Sub Registro_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim box = New Form1()
        box.Show()
        Me.Hide()
    End Sub


End Class
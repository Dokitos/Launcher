Imports System.Threading
Imports System.Net
Imports System.IO
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form1

    '============== --------------------------------------------  ==============
    '============== REF TABELA- Faz login. / Host, User, pass, DB ==============
    '============== --------------------------------------------  ==============
    Private Sub AcessarTabela()
        Dim MySQLConnection As MySqlConnection
        MySQLConnection = New MySqlConnection
        MySQLConnection.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=launcher;" 'servidor/usuario de login/senha/banco de dados
        MySQLConnection.Open()
        Dim MyAdapter As New MySqlDataAdapter
        Dim SqlQuary = "SELECT * From usuario WHERE USUARIO='" & txt_user.Text & "' AND SENHA= '" & txt_pass.Text & "';" 'Informar tabela e dados a serem verificados
        Dim Command As New MySqlCommand
        Command.Connection = MySQLConnection
        Command.CommandText = SqlQuary
        MyAdapter.SelectCommand = Command
        Dim Mydata As MySqlDataReader
        Mydata = Command.ExecuteReader
        If Mydata.HasRows = 0 Then
            txt_status.Text = "Usuário/Senha invalido[s]!" 'Dados incorretos ou n existem
            txt_status.ForeColor = Color.Red
        Else
            txt_status.Text = "Login/Comando aceitos!" 'Dados confirmados
            txt_status.ForeColor = Color.Green

            Me.Close()
        End If
        '======FECHAR CONEXÃO E DESCARREGAR RAM===
        MySQLConnection.Close()
        MySQLConnection.Dispose()
        MyAdapter.Dispose()
        Command.Dispose()
        '=========================================
    End Sub 'Acessar tabela




    '============== --------------------------------------------  ==============
    '============== REF ICONS- Info, DC, Web, Checkbox PW         ==============
    '============== --------------------------------------------  ==============
    Private Sub NsCheckBox2_CheckedChanged(sender As Object) Handles NsCheckBox2.CheckedChanged
        txt_pass.UseSystemPasswordChar = Not NsCheckBox2.Checked
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        System.Diagnostics.Process.Start("http://discord.com")
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        System.Diagnostics.Process.Start("http://dokdev.xyz")
    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
        Dim box = New Info()
        box.Show()
        Me.Hide()

    End Sub



    '============== --------------------------------------------  ==============
    '==============      REF Buttons - Login/Register             ==============
    '============== --------------------------------------------  ==============


    '============= Registro
    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        Dim reg = New Registro()
        reg.Show()
        Me.Hide()
    End Sub

    '============= LOGIN
    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        If txt_user.Text = "" Or txt_user.Text = "" Then 'Verifica se as caixas de texto estão vazias
            txt_status.Text = "Informe usuário e senha!"
            txt_status.ForeColor = Color.Red 'FIM
        Else 'Conexão como o servidor sql/verificar dados
            AcessarTabela()
            '=
            '= Dim box = New Info()
            '= box.Show()
            '= Me.Hide()
        End If
    End Sub


End Class

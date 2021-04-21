Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net, System.IO
Imports System.Management
Imports System.Net.Mail

Public Class Registro
    Dim objconn = New MySqlConnection

    '=============== REF Check for empty ===============
    '===================================================


    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click



        Dim txtuser As String = txt_user.Text
        Dim txtpass As String = txt_pass.Text
        Dim txtemail As String = txt_email.Text
        Dim txtref As String = txt_ref.Text

        If txtuser = "" Then
            MsgBox("Preencha o campo de Usuário para se registrar", MsgBoxStyle.Information, Title:="Atenção")
        Else
            If txtpass = "" Then
                MsgBox("Preencha o campo de Senha para se registrar", MsgBoxStyle.Information, Title:="Atenção")
            Else
                If txtemail = "" Then
                    MsgBox("Preencha o campo de E-mail para se registrar", MsgBoxStyle.Information, Title:="Atenção")

                Else

                    Try
                        Dim testAddress = New MailAddress(txt_email.Text)
                    Catch ex As FormatException
                        ' not a valid email address
                    End Try

                    objconn.ConnectionString = "server=127.0.0.1;user id=root;password=;database=launcher"
                    objconn.Open()
                    Dim objcmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO usuario(hwid,data_reg,USUARIO,SENHA,email,ref)VALUES(@field5,@field2,@field3,@field4,@field6,@field7)", objconn)
                    With objcmd

                        .Parameters.AddWithValue("@field2", Date.Today)
                        .Parameters.AddWithValue("@field3", txt_user.Text)
                        .Parameters.AddWithValue("@field4", txt_pass.Text)
                        .Parameters.AddWithValue("@field5", txt_hwid.Text)
                        .Parameters.AddWithValue("@field6", txt_email.Text)
                        .Parameters.AddWithValue("@field7", txt_ref.Text)
                    End With
                    objcmd.ExecuteNonQuery()
                    objcmd.Dispose()
                    MsgBox("Registrado com sucesso!", MsgBoxStyle.Information, Title:="Atenção")
                    Me.Close()
                End If
            End If
        End If



    End Sub













    Private Sub Registro_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim box = New Form1()
        box.Show()
        Me.Hide()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_hwid.Text = Hwid.GetID
        btn_register.Enabled = False

    End Sub

    'Sistema de HWID
    Public Function GetID() As String
        Dim HWID As String = SystemSerialNumber() & GetCPUID()
        If HWID.Contains(" ") Then HWID = HWID.Replace(" ", "")
        Return Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(HWID))
    End Function
    Private Function GetCPUID()
        Dim cpuInfo As String = String.Empty
        Dim mc As New ManagementClass("win32_processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            cpuInfo = mo.Properties("processorID").Value.ToString()
        Next
        Return cpuInfo
    End Function
    Private Function SystemSerialNumber() As String
        Try
            Dim wmi As Object = GetObject("WinMgmts:")
            Dim serial_numbers As String = String.Empty
            Dim mother_boards As Object = wmi.InstancesOf("Win32_BaseBoard")
            For Each board As Object In mother_boards
                serial_numbers &= board.SerialNumber
            Next board
            Return serial_numbers
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim txtuser As String = txt_user.Text
        Dim txthwid As String = txt_hwid.Text

        If txtuser = "" Then
            MsgBox("Preencha o campo de Usuário para se registrar", MsgBoxStyle.Information, Title:="Atenção")

        Else
            Dim CONEXAO As MySqlConnection = New MySqlConnection("SERVER=127.0.0.1;USERID=root;DATABASE=launcher;Password=")
            CONEXAO.Open()
            Dim COMMAND As MySqlCommand = New MySqlCommand("SELECT * FROM usuario WHERE USUARIO & hwid = '" & txtuser & txthwid & "'", CONEXAO)



            Dim dr As MySqlDataReader


            dr = COMMAND.ExecuteReader()


            dr.Read()


            If dr.HasRows Then
                MsgBox("Nome de usuário já cadastrado ou ID único já registrado.", MsgBoxStyle.Information, Title:="Mensagem")
            Else
                MsgBox("Nome de usuário Disponível.", MsgBoxStyle.Information, Title:="Mensagem")
                btn_register.Enabled = True
            End If
            CONEXAO.Close()
        End If

    End Sub

    Private Sub btn_verify_Click(sender As Object, e As EventArgs) Handles btn_verify.Click
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
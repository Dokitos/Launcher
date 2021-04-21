Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net, System.IO
Imports System.Management

Public Class Registro
    Dim objconn = New MySqlConnection

    '=============== REF Check for empty ===============
    '===================================================














    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        objconn.ConnectionString = "server=127.0.0.1;user id=root;password=;database=launcher"
        objconn.Open()
        Dim objcmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO usuario(hwid,data_reg,USUARIO,SENHA)VALUES(@field5,@field2,@field3,@field4)", objconn)
        With objcmd

            .Parameters.AddWithValue("@field2", Date.Today)
            .Parameters.AddWithValue("@field3", txt_user.Text)
            .Parameters.AddWithValue("@field4", txt_pass.Text)
            .Parameters.AddWithValue("@field5", txt_hwid.Text)
        End With
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()


    End Sub













    Private Sub Registro_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim box = New Form1()
        box.Show()
        Me.Hide()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_hwid.Text = Hwid.GetID
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

End Class
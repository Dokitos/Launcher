Imports System.Net, System.IO, System.Management, System, System.Security.Cryptography, System.Text
'------------------------------------
'Criado dia 11/9/2015 as 00:20
'Creditos AugmentedSkillsBR
'WebSite www.developerscheatsbr.com
'E-mail: krsolucoesweb@gmail.com
'-----------------------------------
Public Module Hwid





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
    Public Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function
End Module

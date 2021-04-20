<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Me.NsTheme1 = New LauncherV3.NSTheme()
        Me.txt_status = New System.Windows.Forms.Label()
        Me.NsControlButton2 = New LauncherV3.NSControlButton()
        Me.NsControlButton1 = New LauncherV3.NSControlButton()
        Me.btn_register = New LauncherV3.NSButton()
        Me.txt_ref = New LauncherV3.NSTextBox()
        Me.NsLabel3 = New LauncherV3.NSLabel()
        Me.txt_hwid = New LauncherV3.NSTextBox()
        Me.NsLabel2 = New LauncherV3.NSLabel()
        Me.txt_email = New LauncherV3.NSTextBox()
        Me.NsLabel1 = New LauncherV3.NSLabel()
        Me.btn_verify = New LauncherV3.NSButton()
        Me.txt_pass = New LauncherV3.NSTextBox()
        Me.senha = New LauncherV3.NSLabel()
        Me.txt_user = New LauncherV3.NSTextBox()
        Me.user = New LauncherV3.NSLabel()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NsTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.Image = Global.LauncherV3.My.Resources.Resources.wave2
        PictureBox1.Location = New System.Drawing.Point(766, 392)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(800, 427)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New LauncherV3.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.txt_status)
        Me.NsTheme1.Controls.Add(Me.NsControlButton2)
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Controls.Add(Me.btn_register)
        Me.NsTheme1.Controls.Add(Me.txt_ref)
        Me.NsTheme1.Controls.Add(Me.NsLabel3)
        Me.NsTheme1.Controls.Add(Me.txt_hwid)
        Me.NsTheme1.Controls.Add(Me.NsLabel2)
        Me.NsTheme1.Controls.Add(Me.txt_email)
        Me.NsTheme1.Controls.Add(Me.NsLabel1)
        Me.NsTheme1.Controls.Add(Me.btn_verify)
        Me.NsTheme1.Controls.Add(Me.txt_pass)
        Me.NsTheme1.Controls.Add(Me.senha)
        Me.NsTheme1.Controls.Add(Me.txt_user)
        Me.NsTheme1.Controls.Add(Me.user)
        Me.NsTheme1.Controls.Add(PictureBox1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(800, 450)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Registro"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'txt_status
        '
        Me.txt_status.AutoSize = True
        Me.txt_status.Location = New System.Drawing.Point(392, 398)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(19, 13)
        Me.txt_status.TabIndex = 15
        Me.txt_status.Text = "..."
        '
        'NsControlButton2
        '
        Me.NsControlButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton2.ControlButton = LauncherV3.NSControlButton.Button.Close
        Me.NsControlButton2.Location = New System.Drawing.Point(781, 0)
        Me.NsControlButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton2.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton2.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton2.Name = "NsControlButton2"
        Me.NsControlButton2.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton2.TabIndex = 14
        Me.NsControlButton2.Text = "NsControlButton2"
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = LauncherV3.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(1582, 0)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 12
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'btn_register
        '
        Me.btn_register.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_register.Location = New System.Drawing.Point(0, 414)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(800, 36)
        Me.btn_register.TabIndex = 11
        Me.btn_register.Text = "REGISTRAR"
        '
        'txt_ref
        '
        Me.txt_ref.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ref.Location = New System.Drawing.Point(325, 344)
        Me.txt_ref.MaxLength = 20
        Me.txt_ref.Multiline = False
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.ReadOnly = False
        Me.txt_ref.Size = New System.Drawing.Size(248, 23)
        Me.txt_ref.TabIndex = 10
        Me.txt_ref.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ref.UseSystemPasswordChar = False
        '
        'NsLabel3
        '
        Me.NsLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NsLabel3.Location = New System.Drawing.Point(208, 344)
        Me.NsLabel3.Name = "NsLabel3"
        Me.NsLabel3.Size = New System.Drawing.Size(111, 23)
        Me.NsLabel3.TabIndex = 9
        Me.NsLabel3.Text = "NsLabel3"
        Me.NsLabel3.Value1 = "-"
        Me.NsLabel3.Value2 = "REFERENCIA:"
        '
        'txt_hwid
        '
        Me.txt_hwid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_hwid.Location = New System.Drawing.Point(325, 286)
        Me.txt_hwid.MaxLength = 32767
        Me.txt_hwid.Multiline = False
        Me.txt_hwid.Name = "txt_hwid"
        Me.txt_hwid.ReadOnly = True
        Me.txt_hwid.Size = New System.Drawing.Size(248, 23)
        Me.txt_hwid.TabIndex = 8
        Me.txt_hwid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_hwid.UseSystemPasswordChar = False
        '
        'NsLabel2
        '
        Me.NsLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NsLabel2.Location = New System.Drawing.Point(208, 286)
        Me.NsLabel2.Name = "NsLabel2"
        Me.NsLabel2.Size = New System.Drawing.Size(75, 23)
        Me.NsLabel2.TabIndex = 7
        Me.NsLabel2.Text = "NsLabel2"
        Me.NsLabel2.Value1 = "-"
        Me.NsLabel2.Value2 = "ID FIXO:"
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Location = New System.Drawing.Point(325, 220)
        Me.txt_email.MaxLength = 100
        Me.txt_email.Multiline = False
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = False
        Me.txt_email.Size = New System.Drawing.Size(248, 21)
        Me.txt_email.TabIndex = 6
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_email.UseSystemPasswordChar = False
        '
        'NsLabel1
        '
        Me.NsLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NsLabel1.Location = New System.Drawing.Point(208, 220)
        Me.NsLabel1.Name = "NsLabel1"
        Me.NsLabel1.Size = New System.Drawing.Size(74, 23)
        Me.NsLabel1.TabIndex = 5
        Me.NsLabel1.Text = "NsLabel1"
        Me.NsLabel1.Value1 = "*"
        Me.NsLabel1.Value2 = "E-MAIL:"
        '
        'btn_verify
        '
        Me.btn_verify.Location = New System.Drawing.Point(580, 89)
        Me.btn_verify.Name = "btn_verify"
        Me.btn_verify.Size = New System.Drawing.Size(75, 23)
        Me.btn_verify.TabIndex = 4
        Me.btn_verify.Text = "VERIFICAR"
        '
        'txt_pass
        '
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.Location = New System.Drawing.Point(325, 150)
        Me.txt_pass.MaxLength = 100
        Me.txt_pass.Multiline = False
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.ReadOnly = False
        Me.txt_pass.Size = New System.Drawing.Size(248, 23)
        Me.txt_pass.TabIndex = 3
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_pass.UseSystemPasswordChar = False
        '
        'senha
        '
        Me.senha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.senha.Location = New System.Drawing.Point(208, 150)
        Me.senha.Name = "senha"
        Me.senha.Size = New System.Drawing.Size(75, 23)
        Me.senha.TabIndex = 2
        Me.senha.Text = "NsLabel1"
        Me.senha.Value1 = "*"
        Me.senha.Value2 = "SENHA:"
        '
        'txt_user
        '
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Location = New System.Drawing.Point(325, 89)
        Me.txt_user.MaxLength = 20
        Me.txt_user.Multiline = False
        Me.txt_user.Name = "txt_user"
        Me.txt_user.ReadOnly = False
        Me.txt_user.Size = New System.Drawing.Size(248, 23)
        Me.txt_user.TabIndex = 1
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_user.UseSystemPasswordChar = False
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user.Location = New System.Drawing.Point(208, 89)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(58, 23)
        Me.user.TabIndex = 0
        Me.user.Text = "NsLabel1"
        Me.user.Value1 = "*"
        Me.user.Value2 = "USER:"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NsTheme1.ResumeLayout(False)
        Me.NsTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents btn_register As NSButton
    Friend WithEvents txt_ref As NSTextBox
    Friend WithEvents NsLabel3 As NSLabel
    Friend WithEvents txt_hwid As NSTextBox
    Friend WithEvents NsLabel2 As NSLabel
    Friend WithEvents txt_email As NSTextBox
    Friend WithEvents NsLabel1 As NSLabel
    Friend WithEvents btn_verify As NSButton
    Friend WithEvents txt_pass As NSTextBox
    Friend WithEvents senha As NSLabel
    Friend WithEvents txt_user As NSTextBox
    Friend WithEvents user As NSLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NsControlButton1 As NSControlButton
    Friend WithEvents NsControlButton2 As NSControlButton
    Friend WithEvents txt_status As Label
End Class

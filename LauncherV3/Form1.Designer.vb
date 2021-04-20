<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NsTheme1 = New LauncherV3.NSTheme()
        Me.txt_status = New System.Windows.Forms.Label()
        Me.NsCheckBox2 = New LauncherV3.NSCheckBox()
        Me.NsCheckBox1 = New LauncherV3.NSCheckBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.txt_pass = New LauncherV3.NSTextBox()
        Me.NsLabel2 = New LauncherV3.NSLabel()
        Me.txt_user = New LauncherV3.NSTextBox()
        Me.NsLabel1 = New LauncherV3.NSLabel()
        Me.NsButton2 = New LauncherV3.NSButton()
        Me.NsButton1 = New LauncherV3.NSButton()
        Me.NsControlButton1 = New LauncherV3.NSControlButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NsContextMenu1 = New LauncherV3.NSContextMenu()
        Me.NsTheme1.SuspendLayout()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New LauncherV3.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.txt_status)
        Me.NsTheme1.Controls.Add(Me.NsCheckBox2)
        Me.NsTheme1.Controls.Add(Me.NsCheckBox1)
        Me.NsTheme1.Controls.Add(Me.IconPictureBox4)
        Me.NsTheme1.Controls.Add(Me.IconPictureBox3)
        Me.NsTheme1.Controls.Add(Me.IconPictureBox2)
        Me.NsTheme1.Controls.Add(Me.IconPictureBox1)
        Me.NsTheme1.Controls.Add(Me.txt_pass)
        Me.NsTheme1.Controls.Add(Me.NsLabel2)
        Me.NsTheme1.Controls.Add(Me.txt_user)
        Me.NsTheme1.Controls.Add(Me.NsLabel1)
        Me.NsTheme1.Controls.Add(Me.NsButton2)
        Me.NsTheme1.Controls.Add(Me.NsButton1)
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Controls.Add(Me.PictureBox1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = False
        Me.NsTheme1.Size = New System.Drawing.Size(800, 450)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "DarkRust"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'txt_status
        '
        Me.txt_status.AutoSize = True
        Me.txt_status.ForeColor = System.Drawing.Color.White
        Me.txt_status.Location = New System.Drawing.Point(507, 112)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(55, 13)
        Me.txt_status.TabIndex = 14
        Me.txt_status.Text = "Status..."
        '
        'NsCheckBox2
        '
        Me.NsCheckBox2.Checked = False
        Me.NsCheckBox2.Location = New System.Drawing.Point(745, 196)
        Me.NsCheckBox2.Name = "NsCheckBox2"
        Me.NsCheckBox2.Size = New System.Drawing.Size(27, 23)
        Me.NsCheckBox2.TabIndex = 13
        '
        'NsCheckBox1
        '
        Me.NsCheckBox1.Checked = False
        Me.NsCheckBox1.Location = New System.Drawing.Point(507, 306)
        Me.NsCheckBox1.Name = "NsCheckBox1"
        Me.NsCheckBox1.Size = New System.Drawing.Size(75, 18)
        Me.NsCheckBox1.TabIndex = 12
        Me.NsCheckBox1.Text = "Lembrar?"
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.IconPictureBox4.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 23
        Me.IconPictureBox4.Location = New System.Drawing.Point(724, 197)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(23, 23)
        Me.IconPictureBox4.TabIndex = 11
        Me.IconPictureBox4.TabStop = False
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.IconPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.IconPictureBox3.IconColor = System.Drawing.Color.DeepSkyBlue
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.Location = New System.Drawing.Point(164, 406)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 10
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.IconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.IconPictureBox2.IconColor = System.Drawing.Color.DeepSkyBlue
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.Location = New System.Drawing.Point(106, 406)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.TabIndex = 9
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Discord
        Me.IconPictureBox1.IconColor = System.Drawing.Color.DeepSkyBlue
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(48, 406)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 8
        Me.IconPictureBox1.TabStop = False
        '
        'txt_pass
        '
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.Location = New System.Drawing.Point(507, 225)
        Me.txt_pass.MaxLength = 100
        Me.txt_pass.Multiline = False
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.ReadOnly = False
        Me.txt_pass.Size = New System.Drawing.Size(265, 21)
        Me.txt_pass.TabIndex = 7
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'NsLabel2
        '
        Me.NsLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NsLabel2.Location = New System.Drawing.Point(507, 196)
        Me.NsLabel2.Name = "NsLabel2"
        Me.NsLabel2.Size = New System.Drawing.Size(75, 23)
        Me.NsLabel2.TabIndex = 6
        Me.NsLabel2.Text = "NsLabel2"
        Me.NsLabel2.Value1 = "-"
        Me.NsLabel2.Value2 = "SENHA:"
        '
        'txt_user
        '
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Location = New System.Drawing.Point(507, 158)
        Me.txt_user.MaxLength = 100
        Me.txt_user.Multiline = False
        Me.txt_user.Name = "txt_user"
        Me.txt_user.ReadOnly = False
        Me.txt_user.Size = New System.Drawing.Size(265, 23)
        Me.txt_user.TabIndex = 5
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_user.UseSystemPasswordChar = False
        '
        'NsLabel1
        '
        Me.NsLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NsLabel1.Location = New System.Drawing.Point(507, 128)
        Me.NsLabel1.Name = "NsLabel1"
        Me.NsLabel1.Size = New System.Drawing.Size(75, 23)
        Me.NsLabel1.TabIndex = 4
        Me.NsLabel1.Text = "NsLabel1"
        Me.NsLabel1.Value1 = "-"
        Me.NsLabel1.Value2 = "USER:"
        '
        'NsButton2
        '
        Me.NsButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NsButton2.Location = New System.Drawing.Point(642, 271)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(129, 29)
        Me.NsButton2.TabIndex = 3
        Me.NsButton2.Text = "REGISTRAR"
        '
        'NsButton1
        '
        Me.NsButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NsButton1.Location = New System.Drawing.Point(507, 271)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(129, 29)
        Me.NsButton1.TabIndex = 2
        Me.NsButton1.Text = "LOGAR"
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = LauncherV3.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(770, 0)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 0
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LauncherV3.My.Resources.Resources.wave2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 430)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'NsContextMenu1
        '
        Me.NsContextMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.NsContextMenu1.Name = "NsContextMenu1"
        Me.NsContextMenu1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.NsTheme1.ResumeLayout(False)
        Me.NsTheme1.PerformLayout()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents NsControlButton1 As NSControlButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_pass As NSTextBox
    Friend WithEvents NsLabel2 As NSLabel
    Friend WithEvents txt_user As NSTextBox
    Friend WithEvents NsLabel1 As NSLabel
    Friend WithEvents NsButton2 As NSButton
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents NsContextMenu1 As NSContextMenu
    Friend WithEvents NsCheckBox1 As NSCheckBox
    Friend WithEvents NsCheckBox2 As NSCheckBox
    Friend WithEvents txt_status As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.gpxLogin = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAcesso = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gpxAcesso = New System.Windows.Forms.GroupBox()
        Me.kbtnSair = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.kbtnEntrar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.gpxLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxAcesso.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.White
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(18, 41)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(52, 20)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.White
        Me.lblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.Location = New System.Drawing.Point(12, 94)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(60, 20)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Senha:"
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(76, 38)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(255, 26)
        Me.txtLogin.TabIndex = 2
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(76, 88)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(255, 26)
        Me.txtSenha.TabIndex = 3
        '
        'gpxLogin
        '
        Me.gpxLogin.BackColor = System.Drawing.Color.White
        Me.gpxLogin.Controls.Add(Me.PictureBox1)
        Me.gpxLogin.Controls.Add(Me.lblLogin)
        Me.gpxLogin.Controls.Add(Me.lblSenha)
        Me.gpxLogin.Controls.Add(Me.txtLogin)
        Me.gpxLogin.Controls.Add(Me.txtSenha)
        Me.gpxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpxLogin.ForeColor = System.Drawing.Color.Black
        Me.gpxLogin.Location = New System.Drawing.Point(39, 95)
        Me.gpxLogin.Name = "gpxLogin"
        Me.gpxLogin.Size = New System.Drawing.Size(349, 146)
        Me.gpxLogin.TabIndex = 6
        Me.gpxLogin.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.TrabalhoG2_VB.My.Resources.Resources.Keys
        Me.PictureBox1.Location = New System.Drawing.Point(16, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lblAcesso
        '
        Me.lblAcesso.AutoSize = True
        Me.lblAcesso.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcesso.ForeColor = System.Drawing.Color.White
        Me.lblAcesso.Location = New System.Drawing.Point(103, 49)
        Me.lblAcesso.Name = "lblAcesso"
        Me.lblAcesso.Size = New System.Drawing.Size(194, 26)
        Me.lblAcesso.TabIndex = 7
        Me.lblAcesso.Text = "Acesso ao sistema:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(151, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'gpxAcesso
        '
        Me.gpxAcesso.Controls.Add(Me.kbtnSair)
        Me.gpxAcesso.Controls.Add(Me.kbtnEntrar)
        Me.gpxAcesso.Location = New System.Drawing.Point(30, 78)
        Me.gpxAcesso.Name = "gpxAcesso"
        Me.gpxAcesso.Size = New System.Drawing.Size(366, 210)
        Me.gpxAcesso.TabIndex = 9
        Me.gpxAcesso.TabStop = False
        '
        'kbtnSair
        '
        Me.kbtnSair.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack
        Me.kbtnSair.Location = New System.Drawing.Point(188, 169)
        Me.kbtnSair.Name = "kbtnSair"
        Me.kbtnSair.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kbtnSair.Size = New System.Drawing.Size(170, 35)
        Me.kbtnSair.TabIndex = 10
        Me.kbtnSair.Values.Text = "                    Sair"
        '
        'kbtnEntrar
        '
        Me.kbtnEntrar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack
        Me.kbtnEntrar.Location = New System.Drawing.Point(9, 169)
        Me.kbtnEntrar.Name = "kbtnEntrar"
        Me.kbtnEntrar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kbtnEntrar.Size = New System.Drawing.Size(170, 35)
        Me.kbtnEntrar.TabIndex = 9
        Me.kbtnEntrar.Values.Text = "                 Entrar"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblAcesso)
        Me.Controls.Add(Me.gpxLogin)
        Me.Controls.Add(Me.gpxAcesso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.gpxLogin.ResumeLayout(False)
        Me.gpxLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxAcesso.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents gpxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents lblAcesso As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents gpxAcesso As System.Windows.Forms.GroupBox
    Friend WithEvents kbtnEntrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnSair As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager

End Class

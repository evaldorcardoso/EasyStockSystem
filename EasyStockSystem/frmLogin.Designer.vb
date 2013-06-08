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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.gpxLoginSenha = New System.Windows.Forms.GroupBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.rdbVendedor = New System.Windows.Forms.RadioButton()
        Me.rdbAdministrador = New System.Windows.Forms.RadioButton()
        Me.gpxLoginSenha.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(64, 59)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(228, 19)
        Me.txtLogin.TabIndex = 0
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(76, 151)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(228, 19)
        Me.txtSenha.TabIndex = 1
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(64, 142)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(95, 30)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(194, 142)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(95, 30)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(60, 36)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(52, 20)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Login:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.White
        Me.lblSenha.Location = New System.Drawing.Point(72, 128)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(56, 20)
        Me.lblSenha.TabIndex = 5
        Me.lblSenha.Text = "Senha"
        '
        'gpxLoginSenha
        '
        Me.gpxLoginSenha.BackColor = System.Drawing.Color.Transparent
        Me.gpxLoginSenha.Controls.Add(Me.rdbAdministrador)
        Me.gpxLoginSenha.Controls.Add(Me.rdbVendedor)
        Me.gpxLoginSenha.Controls.Add(Me.btnEntrar)
        Me.gpxLoginSenha.Controls.Add(Me.btnSair)
        Me.gpxLoginSenha.Controls.Add(Me.lblLogin)
        Me.gpxLoginSenha.Controls.Add(Me.txtLogin)
        Me.gpxLoginSenha.Location = New System.Drawing.Point(12, 47)
        Me.gpxLoginSenha.Name = "gpxLoginSenha"
        Me.gpxLoginSenha.Size = New System.Drawing.Size(360, 182)
        Me.gpxLoginSenha.TabIndex = 6
        Me.gpxLoginSenha.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.EasyStockSystem.My.Resources.Resources.Logo
        Me.pbxLogo.Location = New System.Drawing.Point(137, 3)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(94, 48)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 7
        Me.pbxLogo.TabStop = False
        '
        'rdbVendedor
        '
        Me.rdbVendedor.AutoSize = True
        Me.rdbVendedor.Checked = True
        Me.rdbVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVendedor.ForeColor = System.Drawing.Color.White
        Me.rdbVendedor.Location = New System.Drawing.Point(64, 16)
        Me.rdbVendedor.Name = "rdbVendedor"
        Me.rdbVendedor.Size = New System.Drawing.Size(88, 21)
        Me.rdbVendedor.TabIndex = 5
        Me.rdbVendedor.TabStop = True
        Me.rdbVendedor.Text = "Vendedor"
        Me.rdbVendedor.UseVisualStyleBackColor = True
        '
        'rdbAdministrador
        '
        Me.rdbAdministrador.AutoSize = True
        Me.rdbAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdministrador.ForeColor = System.Drawing.Color.White
        Me.rdbAdministrador.Location = New System.Drawing.Point(178, 16)
        Me.rdbAdministrador.Name = "rdbAdministrador"
        Me.rdbAdministrador.Size = New System.Drawing.Size(113, 21)
        Me.rdbAdministrador.TabIndex = 6
        Me.rdbAdministrador.Text = "Administrador"
        Me.rdbAdministrador.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.gpxLoginSenha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.gpxLoginSenha.ResumeLayout(False)
        Me.gpxLoginSenha.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents gpxLoginSenha As System.Windows.Forms.GroupBox
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents rdbAdministrador As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVendedor As System.Windows.Forms.RadioButton
End Class

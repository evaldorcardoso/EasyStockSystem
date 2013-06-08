<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendedores))
        Me.lblVendedores = New System.Windows.Forms.Label()
        Me.gpxAcoes = New System.Windows.Forms.GroupBox()
        Me.gpxAlteracoes = New System.Windows.Forms.GroupBox()
        Me.dgvVendedores = New System.Windows.Forms.DataGridView()
        Me.txtSenha2 = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblSenha2 = New System.Windows.Forms.Label()
        Me.lblSenha1 = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.gpxBotoes = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.pbxVendedores = New System.Windows.Forms.PictureBox()
        Me.gpxAcoes.SuspendLayout()
        Me.gpxAlteracoes.SuspendLayout()
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxBotoes.SuspendLayout()
        CType(Me.pbxVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVendedores
        '
        Me.lblVendedores.AutoSize = True
        Me.lblVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedores.Location = New System.Drawing.Point(25, 2)
        Me.lblVendedores.Name = "lblVendedores"
        Me.lblVendedores.Size = New System.Drawing.Size(123, 20)
        Me.lblVendedores.TabIndex = 0
        Me.lblVendedores.Text = "VENDEDORES"
        '
        'gpxAcoes
        '
        Me.gpxAcoes.Controls.Add(Me.btnExcluir)
        Me.gpxAcoes.Controls.Add(Me.btnEditar)
        Me.gpxAcoes.Controls.Add(Me.btnNovo)
        Me.gpxAcoes.Location = New System.Drawing.Point(180, 1)
        Me.gpxAcoes.Name = "gpxAcoes"
        Me.gpxAcoes.Size = New System.Drawing.Size(376, 90)
        Me.gpxAcoes.TabIndex = 2
        Me.gpxAcoes.TabStop = False
        '
        'gpxAlteracoes
        '
        Me.gpxAlteracoes.Controls.Add(Me.dgvVendedores)
        Me.gpxAlteracoes.Controls.Add(Me.txtSenha2)
        Me.gpxAlteracoes.Controls.Add(Me.txtSenha)
        Me.gpxAlteracoes.Controls.Add(Me.txtLogin)
        Me.gpxAlteracoes.Controls.Add(Me.txtEmail)
        Me.gpxAlteracoes.Controls.Add(Me.mskTelefone)
        Me.gpxAlteracoes.Controls.Add(Me.txtCidade)
        Me.gpxAlteracoes.Controls.Add(Me.txtEndereco)
        Me.gpxAlteracoes.Controls.Add(Me.txtNome)
        Me.gpxAlteracoes.Controls.Add(Me.lblSenha2)
        Me.gpxAlteracoes.Controls.Add(Me.lblSenha1)
        Me.gpxAlteracoes.Controls.Add(Me.lblCidade)
        Me.gpxAlteracoes.Controls.Add(Me.lblEmail)
        Me.gpxAlteracoes.Controls.Add(Me.lblTelefone)
        Me.gpxAlteracoes.Controls.Add(Me.lblLogin)
        Me.gpxAlteracoes.Controls.Add(Me.lblEndereco)
        Me.gpxAlteracoes.Controls.Add(Me.lblNome)
        Me.gpxAlteracoes.Location = New System.Drawing.Point(12, 97)
        Me.gpxAlteracoes.Name = "gpxAlteracoes"
        Me.gpxAlteracoes.Size = New System.Drawing.Size(544, 232)
        Me.gpxAlteracoes.TabIndex = 3
        Me.gpxAlteracoes.TabStop = False
        '
        'dgvVendedores
        '
        Me.dgvVendedores.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendedores.Location = New System.Drawing.Point(17, 15)
        Me.dgvVendedores.Name = "dgvVendedores"
        Me.dgvVendedores.Size = New System.Drawing.Size(515, 211)
        Me.dgvVendedores.TabIndex = 16
        '
        'txtSenha2
        '
        Me.txtSenha2.Location = New System.Drawing.Point(421, 193)
        Me.txtSenha2.Name = "txtSenha2"
        Me.txtSenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha2.Size = New System.Drawing.Size(111, 20)
        Me.txtSenha2.TabIndex = 15
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(302, 194)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(106, 20)
        Me.txtSenha.TabIndex = 14
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(302, 145)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(106, 20)
        Me.txtLogin.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(302, 98)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 20)
        Me.txtEmail.TabIndex = 12
        '
        'mskTelefone
        '
        Me.mskTelefone.Location = New System.Drawing.Point(10, 195)
        Me.mskTelefone.Name = "mskTelefone"
        Me.mskTelefone.Size = New System.Drawing.Size(207, 20)
        Me.mskTelefone.TabIndex = 11
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(10, 149)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(207, 20)
        Me.txtCidade.TabIndex = 10
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(10, 98)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(207, 20)
        Me.txtEndereco.TabIndex = 9
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(10, 51)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(398, 20)
        Me.txtNome.TabIndex = 8
        '
        'lblSenha2
        '
        Me.lblSenha2.AutoSize = True
        Me.lblSenha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha2.ForeColor = System.Drawing.Color.White
        Me.lblSenha2.Location = New System.Drawing.Point(417, 172)
        Me.lblSenha2.Name = "lblSenha2"
        Me.lblSenha2.Size = New System.Drawing.Size(121, 20)
        Me.lblSenha2.TabIndex = 7
        Me.lblSenha2.Text = "Repita a senha:"
        '
        'lblSenha1
        '
        Me.lblSenha1.AutoSize = True
        Me.lblSenha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha1.ForeColor = System.Drawing.Color.White
        Me.lblSenha1.Location = New System.Drawing.Point(298, 172)
        Me.lblSenha1.Name = "lblSenha1"
        Me.lblSenha1.Size = New System.Drawing.Size(60, 20)
        Me.lblSenha1.TabIndex = 6
        Me.lblSenha1.Text = "Senha:"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.ForeColor = System.Drawing.Color.White
        Me.lblCidade.Location = New System.Drawing.Point(6, 121)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(63, 20)
        Me.lblCidade.TabIndex = 5
        Me.lblCidade.Text = "Cidade:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(298, 75)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 20)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email:"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.ForeColor = System.Drawing.Color.White
        Me.lblTelefone.Location = New System.Drawing.Point(6, 172)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefone.TabIndex = 3
        Me.lblTelefone.Text = "Telefone:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(298, 121)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(52, 20)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.ForeColor = System.Drawing.Color.White
        Me.lblEndereco.Location = New System.Drawing.Point(6, 75)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(82, 20)
        Me.lblEndereco.TabIndex = 1
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.White
        Me.lblNome.Location = New System.Drawing.Point(6, 28)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(55, 20)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'gpxBotoes
        '
        Me.gpxBotoes.Controls.Add(Me.Button2)
        Me.gpxBotoes.Controls.Add(Me.btnConfirmar)
        Me.gpxBotoes.Location = New System.Drawing.Point(12, 336)
        Me.gpxBotoes.Name = "gpxBotoes"
        Me.gpxBotoes.Size = New System.Drawing.Size(544, 113)
        Me.gpxBotoes.TabIndex = 4
        Me.gpxBotoes.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(7, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(531, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Green
        Me.btnConfirmar.Location = New System.Drawing.Point(7, 19)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(531, 34)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.SlateGray
        Me.btnExcluir.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.vendedor_delete
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(258, 11)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(106, 66)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SlateGray
        Me.btnEditar.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.vendedor_edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(134, 11)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(106, 66)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.SlateGray
        Me.btnNovo.BackgroundImage = Global.EasyStockSystem.My.Resources.Resources.vendedor_add
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Location = New System.Drawing.Point(6, 11)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(106, 66)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'pbxVendedores
        '
        Me.pbxVendedores.Image = Global.EasyStockSystem.My.Resources.Resources.vendedor
        Me.pbxVendedores.Location = New System.Drawing.Point(40, 25)
        Me.pbxVendedores.Name = "pbxVendedores"
        Me.pbxVendedores.Size = New System.Drawing.Size(91, 66)
        Me.pbxVendedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxVendedores.TabIndex = 1
        Me.pbxVendedores.TabStop = False
        '
        'frmVendedores
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.gpxBotoes)
        Me.Controls.Add(Me.gpxAlteracoes)
        Me.Controls.Add(Me.gpxAcoes)
        Me.Controls.Add(Me.pbxVendedores)
        Me.Controls.Add(Me.lblVendedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVendedores"
        Me.Text = "Vendedores"
        Me.gpxAcoes.ResumeLayout(False)
        Me.gpxAlteracoes.ResumeLayout(False)
        Me.gpxAlteracoes.PerformLayout()
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxBotoes.ResumeLayout(False)
        CType(Me.pbxVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVendedores As System.Windows.Forms.Label
    Friend WithEvents pbxVendedores As System.Windows.Forms.PictureBox
    Friend WithEvents gpxAcoes As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents gpxAlteracoes As System.Windows.Forms.GroupBox
    Friend WithEvents lblSenha2 As System.Windows.Forms.Label
    Friend WithEvents lblSenha1 As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtSenha2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents mskTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents gpxBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents dgvVendedores As System.Windows.Forms.DataGridView
End Class

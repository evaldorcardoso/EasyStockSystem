<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracoes))
        Me.gpxDadosAcesso = New System.Windows.Forms.GroupBox()
        Me.btnSalvarDadosAcesso = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.gpxPorcentagem = New System.Windows.Forms.GroupBox()
        Me.btnSalvarPorcentagem = New System.Windows.Forms.Button()
        Me.txtPorcentagem = New System.Windows.Forms.TextBox()
        Me.lblPorcentagemDesconto = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.gpxDadosAcesso.SuspendLayout()
        Me.gpxPorcentagem.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpxDadosAcesso
        '
        Me.gpxDadosAcesso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxDadosAcesso.Controls.Add(Me.btnSalvarDadosAcesso)
        Me.gpxDadosAcesso.Controls.Add(Me.txtSenha)
        Me.gpxDadosAcesso.Controls.Add(Me.txtLogin)
        Me.gpxDadosAcesso.Controls.Add(Me.lblSenha)
        Me.gpxDadosAcesso.Controls.Add(Me.lblLogin)
        Me.gpxDadosAcesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxDadosAcesso.ForeColor = System.Drawing.Color.White
        Me.gpxDadosAcesso.Location = New System.Drawing.Point(58, 13)
        Me.gpxDadosAcesso.Name = "gpxDadosAcesso"
        Me.gpxDadosAcesso.Size = New System.Drawing.Size(614, 118)
        Me.gpxDadosAcesso.TabIndex = 0
        Me.gpxDadosAcesso.TabStop = False
        Me.gpxDadosAcesso.Text = "Dados de Acesso:"
        '
        'btnSalvarDadosAcesso
        '
        Me.btnSalvarDadosAcesso.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSalvarDadosAcesso.BackgroundImage = CType(resources.GetObject("btnSalvarDadosAcesso.BackgroundImage"), System.Drawing.Image)
        Me.btnSalvarDadosAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvarDadosAcesso.FlatAppearance.BorderSize = 0
        Me.btnSalvarDadosAcesso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalvarDadosAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarDadosAcesso.Location = New System.Drawing.Point(535, 47)
        Me.btnSalvarDadosAcesso.Name = "btnSalvarDadosAcesso"
        Me.btnSalvarDadosAcesso.Size = New System.Drawing.Size(60, 50)
        Me.btnSalvarDadosAcesso.TabIndex = 4
        Me.btnSalvarDadosAcesso.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(360, 47)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(169, 19)
        Me.txtSenha.TabIndex = 3
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.SystemColors.Window
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(101, 47)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(178, 19)
        Me.txtLogin.TabIndex = 2
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.Black
        Me.lblSenha.Location = New System.Drawing.Point(356, 23)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(60, 20)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Senha:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(97, 23)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(52, 20)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login:"
        '
        'gpxPorcentagem
        '
        Me.gpxPorcentagem.Controls.Add(Me.btnSalvarPorcentagem)
        Me.gpxPorcentagem.Controls.Add(Me.txtPorcentagem)
        Me.gpxPorcentagem.Controls.Add(Me.lblPorcentagemDesconto)
        Me.gpxPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxPorcentagem.ForeColor = System.Drawing.Color.White
        Me.gpxPorcentagem.Location = New System.Drawing.Point(58, 158)
        Me.gpxPorcentagem.Name = "gpxPorcentagem"
        Me.gpxPorcentagem.Size = New System.Drawing.Size(614, 123)
        Me.gpxPorcentagem.TabIndex = 1
        Me.gpxPorcentagem.TabStop = False
        Me.gpxPorcentagem.Text = "% de Desconto permitida:"
        '
        'btnSalvarPorcentagem
        '
        Me.btnSalvarPorcentagem.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSalvarPorcentagem.BackgroundImage = CType(resources.GetObject("btnSalvarPorcentagem.BackgroundImage"), System.Drawing.Image)
        Me.btnSalvarPorcentagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvarPorcentagem.FlatAppearance.BorderSize = 0
        Me.btnSalvarPorcentagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalvarPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarPorcentagem.Location = New System.Drawing.Point(535, 67)
        Me.btnSalvarPorcentagem.Name = "btnSalvarPorcentagem"
        Me.btnSalvarPorcentagem.Size = New System.Drawing.Size(60, 50)
        Me.btnSalvarPorcentagem.TabIndex = 2
        Me.btnSalvarPorcentagem.UseVisualStyleBackColor = False
        '
        'txtPorcentagem
        '
        Me.txtPorcentagem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentagem.Location = New System.Drawing.Point(508, 22)
        Me.txtPorcentagem.Name = "txtPorcentagem"
        Me.txtPorcentagem.Size = New System.Drawing.Size(52, 19)
        Me.txtPorcentagem.TabIndex = 1
        '
        'lblPorcentagemDesconto
        '
        Me.lblPorcentagemDesconto.AutoSize = True
        Me.lblPorcentagemDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentagemDesconto.ForeColor = System.Drawing.Color.Black
        Me.lblPorcentagemDesconto.Location = New System.Drawing.Point(41, 19)
        Me.lblPorcentagemDesconto.Name = "lblPorcentagemDesconto"
        Me.lblPorcentagemDesconto.Size = New System.Drawing.Size(447, 20)
        Me.lblPorcentagemDesconto.TabIndex = 0
        Me.lblPorcentagemDesconto.Text = "Porcentagem de desconto permitida para os Vendedores:    %"
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVoltar.BackgroundImage = CType(resources.GetObject("btnVoltar.BackgroundImage"), System.Drawing.Image)
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(13, 300)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(60, 60)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'frmConfiguracoes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(684, 441)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.gpxPorcentagem)
        Me.Controls.Add(Me.gpxDadosAcesso)
        Me.MinimumSize = New System.Drawing.Size(700, 480)
        Me.Name = "frmConfiguracoes"
        Me.Text = "Configurações"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpxDadosAcesso.ResumeLayout(False)
        Me.gpxDadosAcesso.PerformLayout()
        Me.gpxPorcentagem.ResumeLayout(False)
        Me.gpxPorcentagem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpxDadosAcesso As System.Windows.Forms.GroupBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents btnSalvarDadosAcesso As System.Windows.Forms.Button
    Friend WithEvents gpxPorcentagem As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvarPorcentagem As System.Windows.Forms.Button
    Friend WithEvents txtPorcentagem As System.Windows.Forms.TextBox
    Friend WithEvents lblPorcentagemDesconto As System.Windows.Forms.Label
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
End Class

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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenhPorcent = New System.Windows.Forms.TextBox()
        Me.lblRepitaSenha = New System.Windows.Forms.Label()
        Me.txtSenha2 = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpxBotoes = New System.Windows.Forms.GroupBox()
        Me.gpxAlteracoes = New System.Windows.Forms.GroupBox()
        Me.cbxVendedores = New System.Windows.Forms.ComboBox()
        Me.gpxBotoes.SuspendLayout()
        Me.gpxAlteracoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(28, 37)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(136, 20)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Nome de Usuário:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.White
        Me.lblSenha.Location = New System.Drawing.Point(267, 37)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(139, 20)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Senha de Acesso:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(32, 61)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(177, 26)
        Me.txtUsuario.TabIndex = 2
        '
        'txtSenhPorcent
        '
        Me.txtSenhPorcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhPorcent.Location = New System.Drawing.Point(271, 61)
        Me.txtSenhPorcent.Name = "txtSenhPorcent"
        Me.txtSenhPorcent.Size = New System.Drawing.Size(107, 26)
        Me.txtSenhPorcent.TabIndex = 3
        '
        'lblRepitaSenha
        '
        Me.lblRepitaSenha.AutoSize = True
        Me.lblRepitaSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepitaSenha.ForeColor = System.Drawing.Color.White
        Me.lblRepitaSenha.Location = New System.Drawing.Point(431, 37)
        Me.lblRepitaSenha.Name = "lblRepitaSenha"
        Me.lblRepitaSenha.Size = New System.Drawing.Size(124, 20)
        Me.lblRepitaSenha.TabIndex = 4
        Me.lblRepitaSenha.Text = "Repita a Senha:"
        '
        'txtSenha2
        '
        Me.txtSenha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha2.Location = New System.Drawing.Point(435, 61)
        Me.txtSenha2.Name = "txtSenha2"
        Me.txtSenha2.Size = New System.Drawing.Size(107, 26)
        Me.txtSenha2.TabIndex = 5
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Green
        Me.btnConfirmar.Location = New System.Drawing.Point(6, 18)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(547, 34)
        Me.btnConfirmar.TabIndex = 6
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Location = New System.Drawing.Point(6, 59)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(547, 34)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gpxBotoes
        '
        Me.gpxBotoes.Controls.Add(Me.btnCancelar)
        Me.gpxBotoes.Controls.Add(Me.btnConfirmar)
        Me.gpxBotoes.Location = New System.Drawing.Point(13, 136)
        Me.gpxBotoes.Name = "gpxBotoes"
        Me.gpxBotoes.Size = New System.Drawing.Size(559, 102)
        Me.gpxBotoes.TabIndex = 8
        Me.gpxBotoes.TabStop = False
        '
        'gpxAlteracoes
        '
        Me.gpxAlteracoes.Controls.Add(Me.cbxVendedores)
        Me.gpxAlteracoes.Location = New System.Drawing.Point(13, 13)
        Me.gpxAlteracoes.Name = "gpxAlteracoes"
        Me.gpxAlteracoes.Size = New System.Drawing.Size(559, 100)
        Me.gpxAlteracoes.TabIndex = 9
        Me.gpxAlteracoes.TabStop = False
        '
        'cbxVendedores
        '
        Me.cbxVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxVendedores.FormattingEnabled = True
        Me.cbxVendedores.Location = New System.Drawing.Point(19, 48)
        Me.cbxVendedores.Name = "cbxVendedores"
        Me.cbxVendedores.Size = New System.Drawing.Size(177, 28)
        Me.cbxVendedores.TabIndex = 0
        '
        'frmConfiguracoes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(584, 250)
        Me.Controls.Add(Me.txtSenha2)
        Me.Controls.Add(Me.lblRepitaSenha)
        Me.Controls.Add(Me.txtSenhPorcent)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.gpxBotoes)
        Me.Controls.Add(Me.gpxAlteracoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracoes"
        Me.Text = "Configurações"
        Me.gpxBotoes.ResumeLayout(False)
        Me.gpxAlteracoes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhPorcent As System.Windows.Forms.TextBox
    Friend WithEvents lblRepitaSenha As System.Windows.Forms.Label
    Friend WithEvents txtSenha2 As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gpxBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAlteracoes As System.Windows.Forms.GroupBox
    Friend WithEvents cbxVendedores As System.Windows.Forms.ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConexao
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
        Me.txtNomeBD = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNomeBD
        '
        Me.txtNomeBD.Location = New System.Drawing.Point(53, 43)
        Me.txtNomeBD.Name = "txtNomeBD"
        Me.txtNomeBD.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeBD.TabIndex = 0
        Me.txtNomeBD.Text = "EasyStockSystem"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(12, 87)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(116, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Abrir Conexão"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(156, 87)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(116, 23)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = "Fechar Conexão"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmConexao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtNomeBD)
        Me.Name = "frmConexao"
        Me.Text = "frmConexao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomeBD As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class

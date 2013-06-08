<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoque
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
        Me.dgvEstoque = New System.Windows.Forms.DataGridView()
        Me.gpxPesquisarEstoque = New System.Windows.Forms.GroupBox()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxPesquisarEstoque.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEstoque
        '
        Me.dgvEstoque.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstoque.Location = New System.Drawing.Point(13, 96)
        Me.dgvEstoque.Name = "dgvEstoque"
        Me.dgvEstoque.Size = New System.Drawing.Size(559, 353)
        Me.dgvEstoque.TabIndex = 0
        '
        'gpxPesquisarEstoque
        '
        Me.gpxPesquisarEstoque.Controls.Add(Me.txtPesquisa)
        Me.gpxPesquisarEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxPesquisarEstoque.ForeColor = System.Drawing.Color.White
        Me.gpxPesquisarEstoque.Location = New System.Drawing.Point(13, 4)
        Me.gpxPesquisarEstoque.Name = "gpxPesquisarEstoque"
        Me.gpxPesquisarEstoque.Size = New System.Drawing.Size(559, 86)
        Me.gpxPesquisarEstoque.TabIndex = 1
        Me.gpxPesquisarEstoque.TabStop = False
        Me.gpxPesquisarEstoque.Text = "Pesquisar estoque:"
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisa.Location = New System.Drawing.Point(7, 38)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(546, 19)
        Me.txtPesquisa.TabIndex = 0
        '
        'frmEstoque
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.gpxPesquisarEstoque)
        Me.Controls.Add(Me.dgvEstoque)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmEstoque"
        Me.Text = "Estoque"
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxPesquisarEstoque.ResumeLayout(False)
        Me.gpxPesquisarEstoque.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEstoque As System.Windows.Forms.DataGridView
    Friend WithEvents gpxPesquisarEstoque As System.Windows.Forms.GroupBox
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
End Class

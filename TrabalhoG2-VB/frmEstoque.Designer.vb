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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoque))
        Me.dgvEstoque = New System.Windows.Forms.DataGridView()
        Me.gpxPesquisar = New System.Windows.Forms.GroupBox()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxPesquisar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEstoque
        '
        Me.dgvEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEstoque.BackgroundColor = System.Drawing.Color.White
        Me.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstoque.Location = New System.Drawing.Point(87, 89)
        Me.dgvEstoque.Name = "dgvEstoque"
        Me.dgvEstoque.Size = New System.Drawing.Size(585, 340)
        Me.dgvEstoque.TabIndex = 0
        '
        'gpxPesquisar
        '
        Me.gpxPesquisar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxPesquisar.Controls.Add(Me.txtPesquisar)
        Me.gpxPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpxPesquisar.ForeColor = System.Drawing.Color.White
        Me.gpxPesquisar.Location = New System.Drawing.Point(87, 4)
        Me.gpxPesquisar.Name = "gpxPesquisar"
        Me.gpxPesquisar.Size = New System.Drawing.Size(585, 79)
        Me.gpxPesquisar.TabIndex = 1
        Me.gpxPesquisar.TabStop = False
        Me.gpxPesquisar.Text = "Pesquisar produto:"
        '
        'txtPesquisar
        '
        Me.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisar.Location = New System.Drawing.Point(6, 23)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(540, 19)
        Me.txtPesquisar.TabIndex = 0
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVoltar.BackgroundImage = CType(resources.GetObject("btnVoltar.BackgroundImage"), System.Drawing.Image)
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(12, 353)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(60, 60)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'frmEstoque
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(684, 441)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.dgvEstoque)
        Me.Controls.Add(Me.gpxPesquisar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 480)
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Estoque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxPesquisar.ResumeLayout(False)
        Me.gpxPesquisar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEstoque As System.Windows.Forms.DataGridView
    Friend WithEvents gpxPesquisar As System.Windows.Forms.GroupBox
    Friend WithEvents txtPesquisar As System.Windows.Forms.TextBox
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
End Class

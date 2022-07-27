<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRegistrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.dtpIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpTermino = New System.Windows.Forms.DateTimePicker()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmRegistrar, Me.tsmModificar, Me.tsmEliminar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmNuevo
        '
        Me.tsmNuevo.Name = "tsmNuevo"
        Me.tsmNuevo.Size = New System.Drawing.Size(54, 20)
        Me.tsmNuevo.Text = "Nuevo"
        '
        'tsmRegistrar
        '
        Me.tsmRegistrar.Name = "tsmRegistrar"
        Me.tsmRegistrar.Size = New System.Drawing.Size(65, 20)
        Me.tsmRegistrar.Text = "Registrar"
        '
        'tsmModificar
        '
        Me.tsmModificar.Name = "tsmModificar"
        Me.tsmModificar.Size = New System.Drawing.Size(70, 20)
        Me.tsmModificar.Text = "Modificar"
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.Size = New System.Drawing.Size(62, 20)
        Me.tsmEliminar.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.dtpTermino)
        Me.GroupBox1.Controls.Add(Me.dtpIngreso)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvDatos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(872, 288)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 31)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(38, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "E0000"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(24, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(195, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(24, 80)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(195, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(225, 28)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 3
        '
        'dtpIngreso
        '
        Me.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIngreso.Location = New System.Drawing.Point(225, 54)
        Me.dtpIngreso.Name = "dtpIngreso"
        Me.dtpIngreso.Size = New System.Drawing.Size(200, 20)
        Me.dtpIngreso.TabIndex = 4
        '
        'dtpTermino
        '
        Me.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermino.Location = New System.Drawing.Point(225, 80)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(200, 20)
        Me.dtpTermino.TabIndex = 5
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatos.Location = New System.Drawing.Point(3, 16)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(866, 269)
        Me.dgvDatos.TabIndex = 0
        '
        'cboArea
        '
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(331, 27)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(121, 21)
        Me.cboArea.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Formulario de Empleados"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmNuevo As ToolStripMenuItem
    Friend WithEvents tsmRegistrar As ToolStripMenuItem
    Friend WithEvents tsmModificar As ToolStripMenuItem
    Friend WithEvents tsmEliminar As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpTermino As DateTimePicker
    Friend WithEvents dtpIngreso As DateTimePicker
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents cboArea As ComboBox
End Class

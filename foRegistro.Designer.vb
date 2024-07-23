<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foRegistro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foRegistro))
        Me.MenuStripReg = New System.Windows.Forms.MenuStrip()
        Me.tsmiGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEmail = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpDatos = New System.Windows.Forms.GroupBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnEnviarEmail = New System.Windows.Forms.Button()
        Me.txtEmailOrigen = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.txtLicencia = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.StatusStripReg = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTipReg = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblRutaArchivo = New System.Windows.Forms.Label()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.btnAbrirArchivo = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEmail = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.lblRu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStripReg.SuspendLayout()
        Me.gpDatos.SuspendLayout()
        Me.StatusStripReg.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripReg
        '
        Me.MenuStripReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStripReg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiGuardar, Me.tsmiEmail, Me.tsmiSalir})
        Me.MenuStripReg.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripReg.Name = "MenuStripReg"
        Me.MenuStripReg.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStripReg.Size = New System.Drawing.Size(725, 25)
        Me.MenuStripReg.TabIndex = 0
        Me.MenuStripReg.Text = "MenuStrip1"
        '
        'tsmiGuardar
        '
        Me.tsmiGuardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiGuardar.Name = "tsmiGuardar"
        Me.tsmiGuardar.Size = New System.Drawing.Size(74, 21)
        Me.tsmiGuardar.Text = "Guardar"
        '
        'tsmiEmail
        '
        Me.tsmiEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiEmail.Name = "tsmiEmail"
        Me.tsmiEmail.Size = New System.Drawing.Size(55, 21)
        Me.tsmiEmail.Text = "Email"
        '
        'tsmiSalir
        '
        Me.tsmiSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiSalir.Name = "tsmiSalir"
        Me.tsmiSalir.Size = New System.Drawing.Size(45, 21)
        Me.tsmiSalir.Text = "Salir"
        '
        'gpDatos
        '
        Me.gpDatos.Controls.Add(Me.dtpNacimiento)
        Me.gpDatos.Controls.Add(Me.btnEnviarEmail)
        Me.gpDatos.Controls.Add(Me.txtEmailOrigen)
        Me.gpDatos.Controls.Add(Me.lblEmail)
        Me.gpDatos.Controls.Add(Me.lblNacimiento)
        Me.gpDatos.Controls.Add(Me.txtLicencia)
        Me.gpDatos.Controls.Add(Me.lblID)
        Me.gpDatos.Location = New System.Drawing.Point(26, 144)
        Me.gpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.gpDatos.Name = "gpDatos"
        Me.gpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.gpDatos.Size = New System.Drawing.Size(686, 191)
        Me.gpDatos.TabIndex = 1
        Me.gpDatos.TabStop = False
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpNacimiento.CustomFormat = "dd/mm/yyyy"
        Me.dtpNacimiento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(32, 90)
        Me.dtpNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpNacimiento.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(111, 23)
        Me.dtpNacimiento.TabIndex = 1
        Me.ToolTipReg.SetToolTip(Me.dtpNacimiento, "Fecha de nacimiento del usuario")
        Me.dtpNacimiento.Value = New Date(2022, 8, 1, 0, 0, 0, 0)
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Image = CType(resources.GetObject("btnEnviarEmail.Image"), System.Drawing.Image)
        Me.btnEnviarEmail.Location = New System.Drawing.Point(632, 128)
        Me.btnEnviarEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(37, 44)
        Me.btnEnviarEmail.TabIndex = 4
        Me.ToolTipReg.SetToolTip(Me.btnEnviarEmail, "Envia Email para Generación de Licencia")
        Me.btnEnviarEmail.UseVisualStyleBackColor = True
        Me.btnEnviarEmail.Visible = False
        '
        'txtEmailOrigen
        '
        Me.txtEmailOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmailOrigen.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailOrigen.ForeColor = System.Drawing.Color.Blue
        Me.txtEmailOrigen.Location = New System.Drawing.Point(31, 136)
        Me.txtEmailOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailOrigen.Name = "txtEmailOrigen"
        Me.txtEmailOrigen.Size = New System.Drawing.Size(593, 26)
        Me.txtEmailOrigen.TabIndex = 2
        Me.txtEmailOrigen.Text = "Ingrese su Email o Correo Electrónico"
        Me.txtEmailOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEmailOrigen.Visible = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Blue
        Me.lblEmail.Location = New System.Drawing.Point(29, 117)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 15)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.Visible = False
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.Color.Blue
        Me.lblNacimiento.Location = New System.Drawing.Point(29, 71)
        Me.lblNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(72, 15)
        Me.lblNacimiento.TabIndex = 2
        Me.lblNacimiento.Text = "Nacimiento:"
        '
        'txtLicencia
        '
        Me.txtLicencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLicencia.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicencia.ForeColor = System.Drawing.Color.Red
        Me.txtLicencia.Location = New System.Drawing.Point(31, 41)
        Me.txtLicencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.Size = New System.Drawing.Size(593, 26)
        Me.txtLicencia.TabIndex = 0
        Me.txtLicencia.TabStop = False
        Me.txtLicencia.Text = "Licencia"
        Me.txtLicencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipReg.SetToolTip(Me.txtLicencia, "Clave de id CPU")
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Blue
        Me.lblID.Location = New System.Drawing.Point(28, 21)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(80, 15)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID de Sistema:"
        '
        'StatusStripReg
        '
        Me.StatusStripReg.AutoSize = False
        Me.StatusStripReg.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStripReg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.StatusStripReg.Location = New System.Drawing.Point(0, 65)
        Me.StatusStripReg.Name = "StatusStripReg"
        Me.StatusStripReg.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStripReg.Size = New System.Drawing.Size(725, 35)
        Me.StatusStripReg.TabIndex = 2
        Me.StatusStripReg.Text = "StatusStrip1"
        '
        'tsslMensaje
        '
        Me.tsslMensaje.AutoSize = False
        Me.tsslMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.tsslMensaje.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslMensaje.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslMensaje.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslMensaje.Name = "tsslMensaje"
        Me.tsslMensaje.Size = New System.Drawing.Size(705, 30)
        Me.tsslMensaje.Text = "Mensaje"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'lblRutaArchivo
        '
        Me.lblRutaArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRutaArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblRutaArchivo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutaArchivo.ForeColor = System.Drawing.Color.Blue
        Me.lblRutaArchivo.Location = New System.Drawing.Point(13, 366)
        Me.lblRutaArchivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRutaArchivo.Name = "lblRutaArchivo"
        Me.lblRutaArchivo.Size = New System.Drawing.Size(380, 31)
        Me.lblRutaArchivo.TabIndex = 5
        Me.lblRutaArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipReg.SetToolTip(Me.lblRutaArchivo, "Ubicación del archivo con clave")
        '
        'lblArchivo
        '
        Me.lblArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblArchivo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchivo.ForeColor = System.Drawing.Color.Blue
        Me.lblArchivo.Location = New System.Drawing.Point(400, 366)
        Me.lblArchivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(278, 31)
        Me.lblArchivo.TabIndex = 6
        Me.lblArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipReg.SetToolTip(Me.lblArchivo, "Nombre del archivo con clave")
        '
        'btnAbrirArchivo
        '
        Me.btnAbrirArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbrirArchivo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirArchivo.Location = New System.Drawing.Point(685, 364)
        Me.btnAbrirArchivo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbrirArchivo.Name = "btnAbrirArchivo"
        Me.btnAbrirArchivo.Size = New System.Drawing.Size(36, 34)
        Me.btnAbrirArchivo.TabIndex = 13
        Me.btnAbrirArchivo.Text = "..."
        Me.btnAbrirArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipReg.SetToolTip(Me.btnAbrirArchivo, "Abrir Archivo con Info Clave Generada")
        Me.btnAbrirArchivo.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 100)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(729, 30)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsMenu
        '
        Me.tsMenu.AutoSize = False
        Me.tsMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbEmail, Me.tsbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 25)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(725, 40)
        Me.tsMenu.TabIndex = 4
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.AutoSize = False
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(40, 40)
        Me.tsbGuardar.Text = "Guardar"
        Me.tsbGuardar.ToolTipText = "Guarda Archivo con Info Registro"
        '
        'tsbEmail
        '
        Me.tsbEmail.AutoSize = False
        Me.tsbEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEmail.Image = CType(resources.GetObject("tsbEmail.Image"), System.Drawing.Image)
        Me.tsbEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEmail.Name = "tsbEmail"
        Me.tsbEmail.Size = New System.Drawing.Size(40, 40)
        Me.tsbEmail.Text = "Email"
        Me.tsbEmail.ToolTipText = "Envia Email Registro"
        '
        'tsbSalir
        '
        Me.tsbSalir.AutoSize = False
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(40, 40)
        Me.tsbSalir.Text = "Salir"
        '
        'lblRu
        '
        Me.lblRu.AutoSize = True
        Me.lblRu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRu.ForeColor = System.Drawing.Color.Blue
        Me.lblRu.Location = New System.Drawing.Point(13, 339)
        Me.lblRu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRu.Name = "lblRu"
        Me.lblRu.Size = New System.Drawing.Size(62, 15)
        Me.lblRu.TabIndex = 11
        Me.lblRu.Text = "Ubicación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(400, 339)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Archivo"
        '
        'foRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(725, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAbrirArchivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRu)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.lblRutaArchivo)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.StatusStripReg)
        Me.Controls.Add(Me.gpDatos)
        Me.Controls.Add(Me.MenuStripReg)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripReg
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de información para registro de la aplicación"
        Me.MenuStripReg.ResumeLayout(False)
        Me.MenuStripReg.PerformLayout()
        Me.gpDatos.ResumeLayout(False)
        Me.gpDatos.PerformLayout()
        Me.StatusStripReg.ResumeLayout(False)
        Me.StatusStripReg.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripReg As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEmail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents txtLicencia As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtEmailOrigen As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents StatusStripReg As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTipReg As System.Windows.Forms.ToolTip
    Friend WithEvents btnEnviarEmail As System.Windows.Forms.Button
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEmail As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblRutaArchivo As System.Windows.Forms.Label
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents lblRu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAbrirArchivo As System.Windows.Forms.Button
End Class

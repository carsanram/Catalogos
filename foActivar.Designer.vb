<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foActivar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foActivar))
        Me.mnMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuActivar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrueba = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegistrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIBitacora = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ssEstatus = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbValidar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbActivar = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrueba = New System.Windows.Forms.ToolStripButton()
        Me.tsbRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.im = New System.Windows.Forms.PictureBox()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdMaquina = New System.Windows.Forms.TextBox()
        Me.lbNacimiento = New System.Windows.Forms.Label()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.lbPropietario = New System.Windows.Forms.Label()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.txtCodigoActivacion = New System.Windows.Forms.TextBox()
        Me.lbCodActivacion = New System.Windows.Forms.Label()
        Me.txtDat = New System.Windows.Forms.TextBox()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnMenu.SuspendLayout()
        Me.ssEstatus.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        CType(Me.im, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUser.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnMenu
        '
        Me.mnMenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.mnMenu.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuActivar, Me.mnuPrueba, Me.mnuRegistrar, Me.ConfiguracionToolStripMenuItem, Me.mnuSalir})
        Me.mnMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnMenu.Name = "mnMenu"
        Me.mnMenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnMenu.Size = New System.Drawing.Size(491, 25)
        Me.mnMenu.TabIndex = 0
        Me.mnMenu.Text = "MenuStrip1"
        '
        'mnuActivar
        '
        Me.mnuActivar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuActivar.Name = "mnuActivar"
        Me.mnuActivar.Size = New System.Drawing.Size(66, 21)
        Me.mnuActivar.Text = "&Activar"
        '
        'mnuPrueba
        '
        Me.mnuPrueba.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPrueba.Name = "mnuPrueba"
        Me.mnuPrueba.Size = New System.Drawing.Size(66, 21)
        Me.mnuPrueba.Text = "&Prueba"
        '
        'mnuRegistrar
        '
        Me.mnuRegistrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRegistrar.Name = "mnuRegistrar"
        Me.mnuRegistrar.Size = New System.Drawing.Size(75, 21)
        Me.mnuRegistrar.Text = "&Registrar"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIBitacora})
        Me.ConfiguracionToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(113, 21)
        Me.ConfiguracionToolStripMenuItem.Text = "&Configuracion"
        '
        'TSMIBitacora
        '
        Me.TSMIBitacora.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TSMIBitacora.Checked = True
        Me.TSMIBitacora.CheckOnClick = True
        Me.TSMIBitacora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TSMIBitacora.Name = "TSMIBitacora"
        Me.TSMIBitacora.Size = New System.Drawing.Size(130, 22)
        Me.TSMIBitacora.Text = "Bitácora"
        '
        'mnuSalir
        '
        Me.mnuSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(45, 21)
        Me.mnuSalir.Text = "&Salir"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 100)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(491, 30)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ssEstatus
        '
        Me.ssEstatus.AutoSize = False
        Me.ssEstatus.Dock = System.Windows.Forms.DockStyle.None
        Me.ssEstatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.ssEstatus.Location = New System.Drawing.Point(0, 65)
        Me.ssEstatus.Name = "ssEstatus"
        Me.ssEstatus.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.ssEstatus.Size = New System.Drawing.Size(491, 35)
        Me.ssEstatus.TabIndex = 5
        Me.ssEstatus.Text = "StatusStrip1"
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
        Me.tsslMensaje.Size = New System.Drawing.Size(466, 30)
        Me.tsslMensaje.Text = "Mensajes"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Mensajes de la Aplicación"
        '
        'tsMenu
        '
        Me.tsMenu.AutoSize = False
        Me.tsMenu.BackColor = System.Drawing.SystemColors.Control
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator1, Me.tsbActivar, Me.tsbPrueba, Me.tsbRegistrar, Me.ToolStripSeparator3, Me.tsbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 25)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(491, 40)
        Me.tsMenu.TabIndex = 6
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbValidar
        '
        Me.tsbValidar.AutoSize = False
        Me.tsbValidar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbValidar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbValidar.Image = CType(resources.GetObject("tsbValidar.Image"), System.Drawing.Image)
        Me.tsbValidar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbValidar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbValidar.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbValidar.Name = "tsbValidar"
        Me.tsbValidar.Size = New System.Drawing.Size(40, 40)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(24, 57)
        '
        'tsbActivar
        '
        Me.tsbActivar.AutoSize = False
        Me.tsbActivar.BackColor = System.Drawing.Color.Transparent
        Me.tsbActivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbActivar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbActivar.Image = CType(resources.GetObject("tsbActivar.Image"), System.Drawing.Image)
        Me.tsbActivar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbActivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActivar.Name = "tsbActivar"
        Me.tsbActivar.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbActivar.Size = New System.Drawing.Size(40, 40)
        '
        'tsbPrueba
        '
        Me.tsbPrueba.AutoSize = False
        Me.tsbPrueba.BackColor = System.Drawing.Color.Transparent
        Me.tsbPrueba.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrueba.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbPrueba.Image = CType(resources.GetObject("tsbPrueba.Image"), System.Drawing.Image)
        Me.tsbPrueba.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPrueba.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrueba.Name = "tsbPrueba"
        Me.tsbPrueba.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbPrueba.Size = New System.Drawing.Size(40, 40)
        '
        'tsbRegistrar
        '
        Me.tsbRegistrar.AutoSize = False
        Me.tsbRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.tsbRegistrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRegistrar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbRegistrar.Image = CType(resources.GetObject("tsbRegistrar.Image"), System.Drawing.Image)
        Me.tsbRegistrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegistrar.Name = "tsbRegistrar"
        Me.tsbRegistrar.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbRegistrar.Size = New System.Drawing.Size(40, 40)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(24, 57)
        '
        'tsbSalir
        '
        Me.tsbSalir.AutoSize = False
        Me.tsbSalir.BackColor = System.Drawing.Color.Transparent
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Padding = New System.Windows.Forms.Padding(2)
        Me.tsbSalir.Size = New System.Drawing.Size(40, 40)
        '
        'im
        '
        Me.im.BackgroundImage = Global.Catalogos.My.Resources.Resources.Logo_SF
        Me.im.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.im.InitialImage = CType(resources.GetObject("im.InitialImage"), System.Drawing.Image)
        Me.im.Location = New System.Drawing.Point(151, 144)
        Me.im.Margin = New System.Windows.Forms.Padding(4)
        Me.im.Name = "im"
        Me.im.Size = New System.Drawing.Size(190, 130)
        Me.im.TabIndex = 7
        Me.im.TabStop = False
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.dtpNacimiento)
        Me.gbUser.Controls.Add(Me.Label2)
        Me.gbUser.Controls.Add(Me.txtIdMaquina)
        Me.gbUser.Controls.Add(Me.lbNacimiento)
        Me.gbUser.Controls.Add(Me.txtPropietario)
        Me.gbUser.Controls.Add(Me.lbPropietario)
        Me.gbUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbUser.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUser.ForeColor = System.Drawing.Color.Maroon
        Me.gbUser.Location = New System.Drawing.Point(40, 284)
        Me.gbUser.Margin = New System.Windows.Forms.Padding(4)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Padding = New System.Windows.Forms.Padding(4)
        Me.gbUser.Size = New System.Drawing.Size(431, 171)
        Me.gbUser.TabIndex = 8
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "Datos del Registro del Propietario"
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtpNacimiento.CustomFormat = "dd/mm/yyyy"
        Me.dtpNacimiento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(22, 93)
        Me.dtpNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpNacimiento.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(111, 21)
        Me.dtpNacimiento.TabIndex = 11
        Me.tt.SetToolTip(Me.dtpNacimiento, "Fecha de Nacimiento de Propietario")
        Me.dtpNacimiento.Value = New Date(2022, 11, 21, 17, 36, 17, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(19, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID Sistema"
        '
        'txtIdMaquina
        '
        Me.txtIdMaquina.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdMaquina.CausesValidation = False
        Me.txtIdMaquina.ForeColor = System.Drawing.Color.Red
        Me.txtIdMaquina.Location = New System.Drawing.Point(20, 135)
        Me.txtIdMaquina.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdMaquina.MaxLength = 50
        Me.txtIdMaquina.Name = "txtIdMaquina"
        Me.txtIdMaquina.ReadOnly = True
        Me.txtIdMaquina.Size = New System.Drawing.Size(163, 22)
        Me.txtIdMaquina.TabIndex = 9
        Me.txtIdMaquina.TabStop = False
        Me.txtIdMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tt.SetToolTip(Me.txtIdMaquina, "ID del CPU del Equipo")
        '
        'lbNacimiento
        '
        Me.lbNacimiento.AutoSize = True
        Me.lbNacimiento.ForeColor = System.Drawing.Color.Red
        Me.lbNacimiento.Location = New System.Drawing.Point(17, 76)
        Me.lbNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNacimiento.Name = "lbNacimiento"
        Me.lbNacimiento.Size = New System.Drawing.Size(75, 16)
        Me.lbNacimiento.TabIndex = 6
        Me.lbNacimiento.Text = "Nacimiento"
        '
        'txtPropietario
        '
        Me.txtPropietario.BackColor = System.Drawing.Color.White
        Me.txtPropietario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.Location = New System.Drawing.Point(20, 51)
        Me.txtPropietario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(395, 21)
        Me.txtPropietario.TabIndex = 5
        Me.txtPropietario.Text = "Nombre"
        Me.tt.SetToolTip(Me.txtPropietario, "Nombre del Propietario de la Licencia de Uso")
        '
        'lbPropietario
        '
        Me.lbPropietario.AutoSize = True
        Me.lbPropietario.ForeColor = System.Drawing.Color.Red
        Me.lbPropietario.Location = New System.Drawing.Point(17, 34)
        Me.lbPropietario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPropietario.Name = "lbPropietario"
        Me.lbPropietario.Size = New System.Drawing.Size(71, 16)
        Me.lbPropietario.TabIndex = 4
        Me.lbPropietario.Text = "Propietario"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.txtCodigoActivacion)
        Me.gbInfo.Controls.Add(Me.lbCodActivacion)
        Me.gbInfo.Controls.Add(Me.txtDat)
        Me.gbInfo.Location = New System.Drawing.Point(41, 463)
        Me.gbInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInfo.Size = New System.Drawing.Size(430, 150)
        Me.gbInfo.TabIndex = 9
        Me.gbInfo.TabStop = False
        '
        'txtCodigoActivacion
        '
        Me.txtCodigoActivacion.BackColor = System.Drawing.Color.White
        Me.txtCodigoActivacion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoActivacion.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigoActivacion.Location = New System.Drawing.Point(19, 104)
        Me.txtCodigoActivacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoActivacion.Name = "txtCodigoActivacion"
        Me.txtCodigoActivacion.Size = New System.Drawing.Size(396, 26)
        Me.txtCodigoActivacion.TabIndex = 12
        Me.txtCodigoActivacion.Text = "Codigo de Activación"
        Me.txtCodigoActivacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tt.SetToolTip(Me.txtCodigoActivacion, "Codigo para Utilizar la Licencia  de la Aplicación")
        '
        'lbCodActivacion
        '
        Me.lbCodActivacion.AutoSize = True
        Me.lbCodActivacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodActivacion.ForeColor = System.Drawing.Color.Black
        Me.lbCodActivacion.Location = New System.Drawing.Point(16, 76)
        Me.lbCodActivacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodActivacion.Name = "lbCodActivacion"
        Me.lbCodActivacion.Size = New System.Drawing.Size(198, 16)
        Me.lbCodActivacion.TabIndex = 11
        Me.lbCodActivacion.Text = "Ingrese el Código de Activación"
        '
        'txtDat
        '
        Me.txtDat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDat.Location = New System.Drawing.Point(22, 23)
        Me.txtDat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDat.Multiline = True
        Me.txtDat.Name = "txtDat"
        Me.txtDat.ReadOnly = True
        Me.txtDat.Size = New System.Drawing.Size(396, 44)
        Me.txtDat.TabIndex = 6
        Me.txtDat.Text = "Para obtener el código de activación llamar al número  55-2560-9617 o email: cars" &
    "anram@gmail.com"
        Me.txtDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foActivar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(491, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.gbUser)
        Me.Controls.Add(Me.im)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.ssEstatus)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mnMenu)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "foActivar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activar Aplicación"
        Me.mnMenu.ResumeLayout(False)
        Me.mnMenu.PerformLayout()
        Me.ssEstatus.ResumeLayout(False)
        Me.ssEstatus.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.im, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuActivar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrueba As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegistrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents ssEstatus As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbActivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrueba As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRegistrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents im As System.Windows.Forms.PictureBox
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdMaquina As System.Windows.Forms.TextBox
    Friend WithEvents lbNacimiento As System.Windows.Forms.Label
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lbPropietario As System.Windows.Forms.Label
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigoActivacion As System.Windows.Forms.TextBox
    Friend WithEvents lbCodActivacion As System.Windows.Forms.Label
    Friend WithEvents txtDat As System.Windows.Forms.TextBox
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIBitacora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tt As ToolTip
    Friend WithEvents tsbSalir As ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foMod33
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
        Dim lbl02 As System.Windows.Forms.Label
        Dim lbl03 As System.Windows.Forms.Label
        Dim lbl04 As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foMod33))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsBotones = New System.Windows.Forms.ToolStrip()
        Me.tsbValidar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tss01 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPrimero = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrevio = New System.Windows.Forms.ToolStripButton()
        Me.tsbSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.tsbUltimo = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsFiltros = New System.Windows.Forms.ToolStrip()
        Me.lbl5 = New System.Windows.Forms.ToolStripLabel()
        Me.txtAñoBus = New System.Windows.Forms.ToolStripTextBox()
        Me.lbl6 = New System.Windows.Forms.ToolStripLabel()
        Me.cobEdadIniBus = New System.Windows.Forms.ToolStripComboBox()
        Me.btnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbAfores = New System.Windows.Forms.GroupBox()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.bsMod33 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.cobEdadFin = New System.Windows.Forms.ComboBox()
        Me.cobEdadIni = New System.Windows.Forms.ComboBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.dsMod33 = New System.Windows.Forms.DataGridView()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimInfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimSupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modalidad33TableAdapter = New Catalogos.dsCatalogosTableAdapters.Modalidad33TableAdapter()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        lbl02 = New System.Windows.Forms.Label()
        lbl03 = New System.Windows.Forms.Label()
        lbl04 = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.tsFiltros.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        Me.gbAfores.SuspendLayout()
        CType(Me.bsMod33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsMod33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl02
        '
        lbl02.AutoSize = True
        lbl02.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl02.ForeColor = System.Drawing.Color.Red
        lbl02.Location = New System.Drawing.Point(120, 28)
        lbl02.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        lbl02.Name = "lbl02"
        lbl02.Size = New System.Drawing.Size(80, 15)
        lbl02.TabIndex = 13
        lbl02.Text = "Limite Inferior:"
        '
        'lbl03
        '
        lbl03.AutoSize = True
        lbl03.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl03.ForeColor = System.Drawing.Color.Red
        lbl03.Location = New System.Drawing.Point(120, 57)
        lbl03.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        lbl03.Name = "lbl03"
        lbl03.Size = New System.Drawing.Size(88, 15)
        lbl03.TabIndex = 11
        lbl03.Text = "Limite Superior:"
        '
        'lbl04
        '
        lbl04.AutoSize = True
        lbl04.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl04.ForeColor = System.Drawing.Color.Red
        lbl04.Location = New System.Drawing.Point(266, 28)
        lbl04.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        lbl04.Name = "lbl04"
        lbl04.Size = New System.Drawing.Size(39, 15)
        lbl04.TabIndex = 19
        lbl04.Text = "Cuota"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.ForeColor = System.Drawing.Color.Red
        AñoLabel.Location = New System.Drawing.Point(22, 33)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(32, 15)
        AñoLabel.TabIndex = 19
        AñoLabel.Text = "Año:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(545, 49)
        Me.tsBotones.TabIndex = 7
        Me.tsBotones.Text = "ToolStrip1"
        '
        'tsbValidar
        '
        Me.tsbValidar.AutoSize = False
        Me.tsbValidar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsbValidar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbValidar.Image = CType(resources.GetObject("tsbValidar.Image"), System.Drawing.Image)
        Me.tsbValidar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbValidar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbValidar.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbValidar.Name = "tsbValidar"
        Me.tsbValidar.Size = New System.Drawing.Size(40, 40)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(12, 50)
        '
        'tsbAgregar
        '
        Me.tsbAgregar.AutoSize = False
        Me.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregar.Image = CType(resources.GetObject("tsbAgregar.Image"), System.Drawing.Image)
        Me.tsbAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(40, 40)
        Me.tsbAgregar.Text = "L"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.AutoSize = False
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(40, 40)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.AutoSize = False
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(40, 40)
        Me.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'tsbBorrar
        '
        Me.tsbBorrar.AutoSize = False
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(40, 40)
        '
        'tss01
        '
        Me.tss01.AutoSize = False
        Me.tss01.Name = "tss01"
        Me.tss01.Size = New System.Drawing.Size(12, 50)
        '
        'tsbPrimero
        '
        Me.tsbPrimero.AutoSize = False
        Me.tsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrimero.Image = CType(resources.GetObject("tsbPrimero.Image"), System.Drawing.Image)
        Me.tsbPrimero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrimero.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbPrimero.Name = "tsbPrimero"
        Me.tsbPrimero.Size = New System.Drawing.Size(40, 40)
        '
        'tsbPrevio
        '
        Me.tsbPrevio.AutoSize = False
        Me.tsbPrevio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrevio.Image = CType(resources.GetObject("tsbPrevio.Image"), System.Drawing.Image)
        Me.tsbPrevio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPrevio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrevio.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbPrevio.Name = "tsbPrevio"
        Me.tsbPrevio.Size = New System.Drawing.Size(40, 40)
        '
        'tsbSiguiente
        '
        Me.tsbSiguiente.AutoSize = False
        Me.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSiguiente.Image = CType(resources.GetObject("tsbSiguiente.Image"), System.Drawing.Image)
        Me.tsbSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSiguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbSiguiente.Name = "tsbSiguiente"
        Me.tsbSiguiente.Size = New System.Drawing.Size(40, 40)
        '
        'tsbUltimo
        '
        Me.tsbUltimo.AutoSize = False
        Me.tsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbUltimo.Image = CType(resources.GetObject("tsbUltimo.Image"), System.Drawing.Image)
        Me.tsbUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUltimo.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbUltimo.Name = "tsbUltimo"
        Me.tsbUltimo.Size = New System.Drawing.Size(40, 40)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.AutoSize = False
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(40, 40)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(12, 50)
        '
        'tsbSalir
        '
        Me.tsbSalir.AutoSize = False
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Margin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(40, 40)
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'tsFiltros
        '
        Me.tsFiltros.AutoSize = False
        Me.tsFiltros.BackColor = System.Drawing.Color.SkyBlue
        Me.tsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl5, Me.txtAñoBus, Me.lbl6, Me.cobEdadIniBus, Me.btnFiltro})
        Me.tsFiltros.Location = New System.Drawing.Point(0, 49)
        Me.tsFiltros.Name = "tsFiltros"
        Me.tsFiltros.Size = New System.Drawing.Size(545, 35)
        Me.tsFiltros.TabIndex = 29
        Me.tsFiltros.Text = "FillByNombreToolStrip"
        '
        'lbl5
        '
        Me.lbl5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Blue
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(34, 32)
        Me.lbl5.Text = "Año:"
        '
        'txtAñoBus
        '
        Me.txtAñoBus.AutoSize = False
        Me.txtAñoBus.BackColor = System.Drawing.Color.White
        Me.txtAñoBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAñoBus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñoBus.Name = "txtAñoBus"
        Me.txtAñoBus.Size = New System.Drawing.Size(50, 22)
        Me.txtAñoBus.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAñoBus.ToolTipText = "Búsqueda por Rango Inferior"
        '
        'lbl6
        '
        Me.lbl6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.Blue
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(76, 32)
        Me.lbl6.Text = "Edad Inicio:"
        '
        'cobEdadIniBus
        '
        Me.cobEdadIniBus.AutoSize = False
        Me.cobEdadIniBus.Items.AddRange(New Object() {"0", "20", "30", "40", "50", "60", "70", "80"})
        Me.cobEdadIniBus.Name = "cobEdadIniBus"
        Me.cobEdadIniBus.Size = New System.Drawing.Size(50, 23)
        '
        'btnFiltro
        '
        Me.btnFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltro.Image = Global.Catalogos.My.Resources.Resources.Buscar
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(23, 32)
        Me.btnFiltro.ToolTipText = "Filtros x Rango Inferior y Rango Superior"
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 84)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(545, 35)
        Me.SSMensaje.TabIndex = 30
        Me.SSMensaje.Text = "StatusStrip1"
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
        Me.tsslMensaje.Size = New System.Drawing.Size(525, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 119)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(545, 37)
        Me.lblTitulo.TabIndex = 31
        Me.lblTitulo.Text = "Catálogo: Cuotas del Seguro para la Familia  (M33)"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbAfores
        '
        Me.gbAfores.Controls.Add(Me.txtCuota)
        Me.gbAfores.Controls.Add(Me.cobEdadFin)
        Me.gbAfores.Controls.Add(Me.cobEdadIni)
        Me.gbAfores.Controls.Add(AñoLabel)
        Me.gbAfores.Controls.Add(Me.txtAño)
        Me.gbAfores.Controls.Add(lbl04)
        Me.gbAfores.Controls.Add(lbl02)
        Me.gbAfores.Controls.Add(lbl03)
        Me.gbAfores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbAfores.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAfores.ForeColor = System.Drawing.Color.Maroon
        Me.gbAfores.Location = New System.Drawing.Point(74, 161)
        Me.gbAfores.Margin = New System.Windows.Forms.Padding(5)
        Me.gbAfores.Name = "gbAfores"
        Me.gbAfores.Padding = New System.Windows.Forms.Padding(5)
        Me.gbAfores.Size = New System.Drawing.Size(395, 84)
        Me.gbAfores.TabIndex = 32
        Me.gbAfores.TabStop = False
        Me.gbAfores.Text = "Cuotas del Seguro para la Familia  (M33)"
        '
        'txtCuota
        '
        Me.txtCuota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMod33, "Cuota", True))
        Me.txtCuota.Location = New System.Drawing.Point(313, 25)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(66, 21)
        Me.txtCuota.TabIndex = 25
        '
        'bsMod33
        '
        Me.bsMod33.DataMember = "Modalidad33"
        Me.bsMod33.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cobEdadFin
        '
        Me.cobEdadFin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMod33, "LimSup", True))
        Me.cobEdadFin.FormattingEnabled = True
        Me.cobEdadFin.Items.AddRange(New Object() {"19", "29", "39", "49", "59", "69", "79", "100"})
        Me.cobEdadFin.Location = New System.Drawing.Point(208, 51)
        Me.cobEdadFin.Name = "cobEdadFin"
        Me.cobEdadFin.Size = New System.Drawing.Size(50, 23)
        Me.cobEdadFin.TabIndex = 24
        '
        'cobEdadIni
        '
        Me.cobEdadIni.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMod33, "LimInf", True))
        Me.cobEdadIni.FormattingEnabled = True
        Me.cobEdadIni.Items.AddRange(New Object() {"0", "20", "30", "40", "50", "60", "70", "80"})
        Me.cobEdadIni.Location = New System.Drawing.Point(208, 22)
        Me.cobEdadIni.Name = "cobEdadIni"
        Me.cobEdadIni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cobEdadIni.Size = New System.Drawing.Size(50, 23)
        Me.cobEdadIni.TabIndex = 21
        Me.cobEdadIni.Text = "0"
        '
        'txtAño
        '
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsMod33, "Año", True))
        Me.txtAño.Location = New System.Drawing.Point(60, 30)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(37, 21)
        Me.txtAño.TabIndex = 20
        '
        'dsMod33
        '
        Me.dsMod33.AllowUserToAddRows = False
        Me.dsMod33.AllowUserToDeleteRows = False
        Me.dsMod33.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dsMod33.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dsMod33.AutoGenerateColumns = False
        Me.dsMod33.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dsMod33.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dsMod33.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dsMod33.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dsMod33.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AñoDataGridViewTextBoxColumn, Me.LimInfDataGridViewTextBoxColumn, Me.LimSupDataGridViewTextBoxColumn, Me.CuotaDataGridViewTextBoxColumn})
        Me.dsMod33.DataSource = Me.bsMod33
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dsMod33.DefaultCellStyle = DataGridViewCellStyle7
        Me.dsMod33.EnableHeadersVisualStyles = False
        Me.dsMod33.GridColor = System.Drawing.Color.SteelBlue
        Me.dsMod33.Location = New System.Drawing.Point(112, 254)
        Me.dsMod33.Margin = New System.Windows.Forms.Padding(4)
        Me.dsMod33.Name = "dsMod33"
        Me.dsMod33.ReadOnly = True
        Me.dsMod33.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dsMod33.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dsMod33.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dsMod33.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dsMod33.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dsMod33.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dsMod33.Size = New System.Drawing.Size(332, 170)
        Me.dsMod33.TabIndex = 33
        Me.dsMod33.TabStop = False
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AñoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AñoDataGridViewTextBoxColumn.Width = 60
        '
        'LimInfDataGridViewTextBoxColumn
        '
        Me.LimInfDataGridViewTextBoxColumn.DataPropertyName = "LimInf"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LimInfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.LimInfDataGridViewTextBoxColumn.HeaderText = "Edad Ini"
        Me.LimInfDataGridViewTextBoxColumn.Name = "LimInfDataGridViewTextBoxColumn"
        Me.LimInfDataGridViewTextBoxColumn.ReadOnly = True
        Me.LimInfDataGridViewTextBoxColumn.Width = 80
        '
        'LimSupDataGridViewTextBoxColumn
        '
        Me.LimSupDataGridViewTextBoxColumn.DataPropertyName = "LimSup"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LimSupDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.LimSupDataGridViewTextBoxColumn.HeaderText = "Edad Fin"
        Me.LimSupDataGridViewTextBoxColumn.Name = "LimSupDataGridViewTextBoxColumn"
        Me.LimSupDataGridViewTextBoxColumn.ReadOnly = True
        Me.LimSupDataGridViewTextBoxColumn.Width = 80
        '
        'CuotaDataGridViewTextBoxColumn
        '
        Me.CuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.CuotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CuotaDataGridViewTextBoxColumn.HeaderText = "Cuota"
        Me.CuotaDataGridViewTextBoxColumn.Name = "CuotaDataGridViewTextBoxColumn"
        Me.CuotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Modalidad33TableAdapter
        '
        Me.Modalidad33TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActividadesTITableAdapter = Nothing
        Me.TableAdapterManager.AforesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuantiasLey1973arTableAdapter = Nothing
        Me.TableAdapterManager.CuantiasLey1973TableAdapter = Nothing
        Me.TableAdapterManager.CuantiasLey1997TableAdapter = Nothing
        Me.TableAdapterManager.DespachoTableAdapter = Nothing
        Me.TableAdapterManager.EstadosMxTableAdapter = Nothing
        Me.TableAdapterManager.InflacionAnualTableAdapter = Nothing
        Me.TableAdapterManager.INPCTableAdapter = Nothing
        Me.TableAdapterManager.ISRTableAdapter = Nothing
        Me.TableAdapterManager.LeyIMSSTableAdapter = Nothing
        Me.TableAdapterManager.LeySegPenTableAdapter = Nothing
        Me.TableAdapterManager.Modalidad33TableAdapter = Me.Modalidad33TableAdapter
        Me.TableAdapterManager.PctSegurosM40TableAdapter = Nothing
        Me.TableAdapterManager.PensionTableAdapter = Nothing
        Me.TableAdapterManager.PrimaRiesgoTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.RegimenIMSSTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.SubActividadesTITableAdapter = Nothing
        Me.TableAdapterManager.TopadoSMG_UMATableAdapter = Nothing
        Me.TableAdapterManager.UMATableAdapter = Nothing
        Me.TableAdapterManager.UMFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'foMod33
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(545, 437)
        Me.Controls.Add(Me.dsMod33)
        Me.Controls.Add(Me.gbAfores)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.tsFiltros)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "foMod33"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuotas Seguro de la Familia (Mod 33)"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.tsFiltros.ResumeLayout(False)
        Me.tsFiltros.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.gbAfores.ResumeLayout(False)
        Me.gbAfores.PerformLayout()
        CType(Me.bsMod33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsMod33, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbAgregar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents tss01 As ToolStripSeparator
    Friend WithEvents tsbPrimero As ToolStripButton
    Friend WithEvents tsbPrevio As ToolStripButton
    Friend WithEvents tsbSiguiente As ToolStripButton
    Friend WithEvents tsbUltimo As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents tsFiltros As ToolStrip
    Friend WithEvents lbl5 As ToolStripLabel
    Friend WithEvents txtAñoBus As ToolStripTextBox
    Friend WithEvents btnFiltro As ToolStripButton
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbAfores As GroupBox
    Friend WithEvents dsMod33 As DataGridView
    Friend WithEvents bsMod33 As BindingSource
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents Modalidad33TableAdapter As dsCatalogosTableAdapters.Modalidad33TableAdapter
    Friend WithEvents cobEdadFin As ComboBox
    Friend WithEvents cobEdadIni As ComboBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents txtCuota As TextBox
    Friend WithEvents lbl6 As ToolStripLabel
    Friend WithEvents cobEdadIniBus As ToolStripComboBox
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimInfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimSupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

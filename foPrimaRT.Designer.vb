<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foPrimaRT
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
        Dim llblCuantiaBase As System.Windows.Forms.Label
        Dim llblCuantiaAdicional As System.Windows.Forms.Label
        Dim lblSalFinal As System.Windows.Forms.Label
        Dim lblSalInicial As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foPrimaRT))
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
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
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbAfores = New System.Windows.Forms.GroupBox()
        Me.cboClase = New System.Windows.Forms.ComboBox()
        Me.bsPrimaRT = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCatalogos = New Catalogos.dsCatalogos()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPrima = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.dsPrima = New System.Windows.Forms.DataGridView()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsFiltros = New System.Windows.Forms.ToolStrip()
        Me.tslLimInf = New System.Windows.Forms.ToolStripLabel()
        Me.txtAñoBus = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.PrimaRiesgoTrabajoTableAdapter = New Catalogos.dsCatalogosTableAdapters.PrimaRiesgoTrabajoTableAdapter()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        Me.gpCopia = New System.Windows.Forms.GroupBox()
        Me.nudOrigen = New System.Windows.Forms.NumericUpDown()
        Me.nudDestino = New System.Windows.Forms.NumericUpDown()
        Me.btnActualizar = New System.Windows.Forms.Button()
        llblCuantiaBase = New System.Windows.Forms.Label()
        llblCuantiaAdicional = New System.Windows.Forms.Label()
        lblSalFinal = New System.Windows.Forms.Label()
        lblSalInicial = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        Me.gbAfores.SuspendLayout()
        CType(Me.bsPrimaRT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsFiltros.SuspendLayout()
        Me.gpCopia.SuspendLayout()
        CType(Me.nudOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'llblCuantiaBase
        '
        llblCuantiaBase.AutoSize = True
        llblCuantiaBase.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        llblCuantiaBase.ForeColor = System.Drawing.Color.Red
        llblCuantiaBase.Location = New System.Drawing.Point(255, 33)
        llblCuantiaBase.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        llblCuantiaBase.Name = "llblCuantiaBase"
        llblCuantiaBase.Size = New System.Drawing.Size(40, 15)
        llblCuantiaBase.TabIndex = 13
        llblCuantiaBase.Text = "Clase:"
        '
        'llblCuantiaAdicional
        '
        llblCuantiaAdicional.AutoSize = True
        llblCuantiaAdicional.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        llblCuantiaAdicional.ForeColor = System.Drawing.Color.Blue
        llblCuantiaAdicional.Location = New System.Drawing.Point(9, 66)
        llblCuantiaAdicional.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        llblCuantiaAdicional.Name = "llblCuantiaAdicional"
        llblCuantiaAdicional.Size = New System.Drawing.Size(75, 15)
        llblCuantiaAdicional.TabIndex = 12
        llblCuantiaAdicional.Text = "Descripción:"
        '
        'lblSalFinal
        '
        lblSalFinal.AutoSize = True
        lblSalFinal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSalFinal.ForeColor = System.Drawing.Color.Red
        lblSalFinal.Location = New System.Drawing.Point(385, 33)
        lblSalFinal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        lblSalFinal.Name = "lblSalFinal"
        lblSalFinal.Size = New System.Drawing.Size(40, 15)
        lblSalFinal.TabIndex = 11
        lblSalFinal.Text = "Prima:"
        '
        'lblSalInicial
        '
        lblSalInicial.AutoSize = True
        lblSalInicial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSalInicial.ForeColor = System.Drawing.Color.Red
        lblSalInicial.Location = New System.Drawing.Point(136, 33)
        lblSalInicial.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        lblSalInicial.Name = "lblSalInicial"
        lblSalInicial.Size = New System.Drawing.Size(32, 15)
        lblSalInicial.TabIndex = 10
        lblSalInicial.Text = "Año:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(882, 49)
        Me.tsBotones.TabIndex = 6
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
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 85)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(882, 35)
        Me.SSMensaje.TabIndex = 25
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
        Me.tsslMensaje.Size = New System.Drawing.Size(857, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 120)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(882, 37)
        Me.lblTitulo.TabIndex = 26
        Me.lblTitulo.Text = "Catálogo: Primas de Riesgo de Trabajo TI"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbAfores
        '
        Me.gbAfores.Controls.Add(Me.cboClase)
        Me.gbAfores.Controls.Add(Me.txtDescripcion)
        Me.gbAfores.Controls.Add(Me.txtPrima)
        Me.gbAfores.Controls.Add(Me.txtAño)
        Me.gbAfores.Controls.Add(llblCuantiaBase)
        Me.gbAfores.Controls.Add(llblCuantiaAdicional)
        Me.gbAfores.Controls.Add(lblSalFinal)
        Me.gbAfores.Controls.Add(lblSalInicial)
        Me.gbAfores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbAfores.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAfores.ForeColor = System.Drawing.Color.Maroon
        Me.gbAfores.Location = New System.Drawing.Point(14, 162)
        Me.gbAfores.Margin = New System.Windows.Forms.Padding(5)
        Me.gbAfores.Name = "gbAfores"
        Me.gbAfores.Padding = New System.Windows.Forms.Padding(5)
        Me.gbAfores.Size = New System.Drawing.Size(574, 104)
        Me.gbAfores.TabIndex = 27
        Me.gbAfores.TabStop = False
        Me.gbAfores.Text = "Prima de Riesgos de Trabajo Trabajador Independiente"
        '
        'cboClase
        '
        Me.cboClase.AutoCompleteCustomSource.AddRange(New String() {"I", "II", "III", "IV", "V"})
        Me.cboClase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrimaRT, "Clase", True))
        Me.cboClase.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClase.FormattingEnabled = True
        Me.cboClase.Items.AddRange(New Object() {"I", "II", "III", "IV", "V"})
        Me.cboClase.Location = New System.Drawing.Point(303, 30)
        Me.cboClase.Name = "cboClase"
        Me.cboClase.Size = New System.Drawing.Size(57, 24)
        Me.cboClase.TabIndex = 18
        '
        'bsPrimaRT
        '
        Me.bsPrimaRT.DataMember = "PrimaRiesgoTrabajo"
        Me.bsPrimaRT.DataSource = Me.dsCatalogos
        '
        'dsCatalogos
        '
        Me.dsCatalogos.DataSetName = "dsCatalogos"
        Me.dsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrimaRT, "Descripcion", True))
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(92, 63)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(441, 21)
        Me.txtDescripcion.TabIndex = 17
        '
        'txtPrima
        '
        Me.txtPrima.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrimaRT, "Prima", True))
        Me.txtPrima.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrima.Location = New System.Drawing.Point(433, 30)
        Me.txtPrima.Name = "txtPrima"
        Me.txtPrima.Size = New System.Drawing.Size(100, 22)
        Me.txtPrima.TabIndex = 16
        Me.txtPrima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAño
        '
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrimaRT, "Año", True))
        Me.txtAño.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(176, 30)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(61, 22)
        Me.txtAño.TabIndex = 14
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dsPrima
        '
        Me.dsPrima.AllowUserToAddRows = False
        Me.dsPrima.AllowUserToDeleteRows = False
        Me.dsPrima.AllowUserToOrderColumns = True
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dsPrima.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dsPrima.AutoGenerateColumns = False
        Me.dsPrima.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dsPrima.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dsPrima.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dsPrima.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dsPrima.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AñoDataGridViewTextBoxColumn, Me.ClaseDataGridViewTextBoxColumn, Me.PrimaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dsPrima.DataSource = Me.bsPrimaRT
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dsPrima.DefaultCellStyle = DataGridViewCellStyle30
        Me.dsPrima.EnableHeadersVisualStyles = False
        Me.dsPrima.GridColor = System.Drawing.Color.SteelBlue
        Me.dsPrima.Location = New System.Drawing.Point(134, 275)
        Me.dsPrima.Margin = New System.Windows.Forms.Padding(4)
        Me.dsPrima.Name = "dsPrima"
        Me.dsPrima.ReadOnly = True
        Me.dsPrima.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dsPrima.RowHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.dsPrima.RowHeadersVisible = False
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White
        Me.dsPrima.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.dsPrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dsPrima.Size = New System.Drawing.Size(575, 151)
        Me.dsPrima.TabIndex = 24
        Me.dsPrima.TabStop = False
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AñoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AñoDataGridViewTextBoxColumn.Width = 50
        '
        'ClaseDataGridViewTextBoxColumn
        '
        Me.ClaseDataGridViewTextBoxColumn.DataPropertyName = "Clase"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClaseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle28
        Me.ClaseDataGridViewTextBoxColumn.HeaderText = "Clase"
        Me.ClaseDataGridViewTextBoxColumn.Name = "ClaseDataGridViewTextBoxColumn"
        Me.ClaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClaseDataGridViewTextBoxColumn.Width = 50
        '
        'PrimaDataGridViewTextBoxColumn
        '
        Me.PrimaDataGridViewTextBoxColumn.DataPropertyName = "Prima"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PrimaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle29
        Me.PrimaDataGridViewTextBoxColumn.HeaderText = "Prima"
        Me.PrimaDataGridViewTextBoxColumn.Name = "PrimaDataGridViewTextBoxColumn"
        Me.PrimaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 350
        '
        'tsFiltros
        '
        Me.tsFiltros.AutoSize = False
        Me.tsFiltros.BackColor = System.Drawing.Color.SkyBlue
        Me.tsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslLimInf, Me.txtAñoBus, Me.btnFiltro})
        Me.tsFiltros.Location = New System.Drawing.Point(0, 49)
        Me.tsFiltros.Name = "tsFiltros"
        Me.tsFiltros.Size = New System.Drawing.Size(882, 35)
        Me.tsFiltros.TabIndex = 28
        Me.tsFiltros.Text = "FillByNombreToolStrip"
        '
        'tslLimInf
        '
        Me.tslLimInf.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslLimInf.ForeColor = System.Drawing.Color.Blue
        Me.tslLimInf.Name = "tslLimInf"
        Me.tslLimInf.Size = New System.Drawing.Size(34, 32)
        Me.tslLimInf.Text = "Año:"
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
        'btnFiltro
        '
        Me.btnFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltro.Image = Global.Catalogos.My.Resources.Resources.Buscar
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(23, 32)
        Me.btnFiltro.ToolTipText = "Filtros x Rango Inferior y Rango Superior"
        '
        'PrimaRiesgoTrabajoTableAdapter
        '
        Me.PrimaRiesgoTrabajoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Modalidad33TableAdapter = Nothing
        Me.TableAdapterManager.PctSegurosM40TableAdapter = Nothing
        Me.TableAdapterManager.PensionTableAdapter = Nothing
        Me.TableAdapterManager.PrimaRiesgoTrabajoTableAdapter = Me.PrimaRiesgoTrabajoTableAdapter
        Me.TableAdapterManager.RegimenIMSSTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.SubActividadesTITableAdapter = Nothing
        Me.TableAdapterManager.TopadoSMG_UMATableAdapter = Nothing
        Me.TableAdapterManager.UMATableAdapter = Nothing
        Me.TableAdapterManager.UMFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'gpCopia
        '
        Me.gpCopia.Controls.Add(Me.btnActualizar)
        Me.gpCopia.Controls.Add(Label2)
        Me.gpCopia.Controls.Add(Me.nudDestino)
        Me.gpCopia.Controls.Add(Label1)
        Me.gpCopia.Controls.Add(Me.nudOrigen)
        Me.gpCopia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCopia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gpCopia.Location = New System.Drawing.Point(609, 162)
        Me.gpCopia.Name = "gpCopia"
        Me.gpCopia.Size = New System.Drawing.Size(261, 104)
        Me.gpCopia.TabIndex = 29
        Me.gpCopia.TabStop = False
        Me.gpCopia.Text = "Copiar Primas"
        '
        'nudOrigen
        '
        Me.nudOrigen.Location = New System.Drawing.Point(63, 26)
        Me.nudOrigen.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nudOrigen.Name = "nudOrigen"
        Me.nudOrigen.Size = New System.Drawing.Size(59, 22)
        Me.nudOrigen.TabIndex = 0
        Me.nudOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Red
        Label1.Location = New System.Drawing.Point(8, 29)
        Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(47, 15)
        Label1.TabIndex = 12
        Label1.Text = "Origen:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Red
        Label2.Location = New System.Drawing.Point(8, 66)
        Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 15)
        Label2.TabIndex = 14
        Label2.Text = "Destino:"
        '
        'nudDestino
        '
        Me.nudDestino.Location = New System.Drawing.Point(63, 63)
        Me.nudDestino.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nudDestino.Name = "nudDestino"
        Me.nudDestino.Size = New System.Drawing.Size(59, 22)
        Me.nudDestino.TabIndex = 13
        Me.nudDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(139, 34)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(105, 40)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'foPrimaRT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(882, 439)
        Me.Controls.Add(Me.gpCopia)
        Me.Controls.Add(Me.tsFiltros)
        Me.Controls.Add(Me.dsPrima)
        Me.Controls.Add(Me.gbAfores)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "foPrimaRT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Primas de Riesgos de Trabajo TI"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.gbAfores.ResumeLayout(False)
        Me.gbAfores.PerformLayout()
        CType(Me.bsPrimaRT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPrima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsFiltros.ResumeLayout(False)
        Me.tsFiltros.PerformLayout()
        Me.gpCopia.ResumeLayout(False)
        Me.gpCopia.PerformLayout()
        CType(Me.nudOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDestino, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbAfores As GroupBox
    Friend WithEvents dsCatalogos As dsCatalogos
    Friend WithEvents bsPrimaRT As BindingSource
    Friend WithEvents PrimaRiesgoTrabajoTableAdapter As dsCatalogosTableAdapters.PrimaRiesgoTrabajoTableAdapter
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrima As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents dsPrima As DataGridView
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cboClase As ComboBox
    Friend WithEvents tsFiltros As ToolStrip
    Friend WithEvents tslLimInf As ToolStripLabel
    Friend WithEvents txtAñoBus As ToolStripTextBox
    Friend WithEvents btnFiltro As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents gpCopia As GroupBox
    Friend WithEvents nudDestino As NumericUpDown
    Friend WithEvents nudOrigen As NumericUpDown
    Friend WithEvents btnActualizar As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foCuantias97
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
        Dim lblEdadPen As System.Windows.Forms.Label
        Dim lblPension As System.Windows.Forms.Label
        Dim lblAño As System.Windows.Forms.Label
        Dim lblLimInf As System.Windows.Forms.Label
        Dim lblLimSup As System.Windows.Forms.Label
        Dim lblSemCotInf As System.Windows.Forms.Label
        Dim lblSemCotSup As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foCuantias97))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbCuantia97 = New System.Windows.Forms.GroupBox()
        Me.txtPensionGarantizada = New System.Windows.Forms.TextBox()
        Me.bsCuantia97 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.txtEdadPension = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtSemCotSup = New System.Windows.Forms.TextBox()
        Me.txtSemCotInf = New System.Windows.Forms.TextBox()
        Me.txtLimSuperior = New System.Windows.Forms.TextBox()
        Me.txtLimInferior = New System.Windows.Forms.TextBox()
        Me.dgCuantia1997 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FillByAñoPenToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tslAños = New System.Windows.Forms.ToolStripLabel()
        Me.txtFiltroAño = New System.Windows.Forms.ToolStripTextBox()
        Me.tslAñosPension = New System.Windows.Forms.ToolStripLabel()
        Me.txtFiltroAñoPension = New System.Windows.Forms.ToolStripTextBox()
        Me.tslLiimite = New System.Windows.Forms.ToolStripLabel()
        Me.txtFiltroLimite = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.CuantiasLey1997TableAdapter = New Catalogos.dsCatalogosTableAdapters.CuantiasLey1997TableAdapter()
        Me.gbSC = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        lblEdadPen = New System.Windows.Forms.Label()
        lblPension = New System.Windows.Forms.Label()
        lblAño = New System.Windows.Forms.Label()
        lblLimInf = New System.Windows.Forms.Label()
        lblLimSup = New System.Windows.Forms.Label()
        lblSemCotInf = New System.Windows.Forms.Label()
        lblSemCotSup = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.gbCuantia97.SuspendLayout()
        CType(Me.bsCuantia97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuantia1997, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSMensaje.SuspendLayout()
        Me.FillByAñoPenToolStrip.SuspendLayout()
        Me.gbSC.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEdadPen
        '
        lblEdadPen.AutoSize = True
        lblEdadPen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEdadPen.ForeColor = System.Drawing.Color.Red
        lblEdadPen.Location = New System.Drawing.Point(64, 47)
        lblEdadPen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblEdadPen.Name = "lblEdadPen"
        lblEdadPen.Size = New System.Drawing.Size(100, 15)
        lblEdadPen.TabIndex = 12
        lblEdadPen.Text = "Edad de Pensión:"
        '
        'lblPension
        '
        lblPension.AutoSize = True
        lblPension.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPension.ForeColor = System.Drawing.Color.Red
        lblPension.Location = New System.Drawing.Point(13, 79)
        lblPension.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblPension.Name = "lblPension"
        lblPension.Size = New System.Drawing.Size(151, 15)
        lblPension.TabIndex = 11
        lblPension.Text = "Pensión Garantizada Base:"
        '
        'lblAño
        '
        lblAño.AutoSize = True
        lblAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAño.ForeColor = System.Drawing.Color.Red
        lblAño.Location = New System.Drawing.Point(132, 18)
        lblAño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblAño.Name = "lblAño"
        lblAño.Size = New System.Drawing.Size(32, 15)
        lblAño.TabIndex = 10
        lblAño.Text = "Año:"
        '
        'lblLimInf
        '
        lblLimInf.AutoSize = True
        lblLimInf.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLimInf.ForeColor = System.Drawing.Color.Red
        lblLimInf.Location = New System.Drawing.Point(23, 24)
        lblLimInf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLimInf.Name = "lblLimInf"
        lblLimInf.Size = New System.Drawing.Size(104, 15)
        lblLimInf.TabIndex = 15
        lblLimInf.Text = "Limite Inferior SBC:"
        '
        'lblLimSup
        '
        lblLimSup.AutoSize = True
        lblLimSup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLimSup.ForeColor = System.Drawing.Color.Red
        lblLimSup.Location = New System.Drawing.Point(15, 53)
        lblLimSup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLimSup.Name = "lblLimSup"
        lblLimSup.Size = New System.Drawing.Size(112, 15)
        lblLimSup.TabIndex = 16
        lblLimSup.Text = "Limite Superior SBC:"
        '
        'lblSemCotInf
        '
        lblSemCotInf.AutoSize = True
        lblSemCotInf.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSemCotInf.ForeColor = System.Drawing.Color.Red
        lblSemCotInf.Location = New System.Drawing.Point(27, 21)
        lblSemCotInf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSemCotInf.Name = "lblSemCotInf"
        lblSemCotInf.Size = New System.Drawing.Size(150, 15)
        lblSemCotInf.TabIndex = 20
        lblSemCotInf.Text = "Semanas Cotizadas Inferior"
        '
        'lblSemCotSup
        '
        lblSemCotSup.AutoSize = True
        lblSemCotSup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSemCotSup.ForeColor = System.Drawing.Color.Red
        lblSemCotSup.Location = New System.Drawing.Point(19, 50)
        lblSemCotSup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSemCotSup.Name = "lblSemCotSup"
        lblSemCotSup.Size = New System.Drawing.Size(158, 15)
        lblSemCotSup.TabIndex = 21
        lblSemCotSup.Text = "Semanas Cotizadas Superior"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(746, 40)
        Me.tsBotones.TabIndex = 29
        Me.tsBotones.Text = "tsLey97"
        '
        'tsbValidar
        '
        Me.tsbValidar.AutoSize = False
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
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 115)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(746, 30)
        Me.lblTitulo.TabIndex = 30
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbCuantia97
        '
        Me.gbCuantia97.Controls.Add(Me.txtPensionGarantizada)
        Me.gbCuantia97.Controls.Add(Me.txtEdadPension)
        Me.gbCuantia97.Controls.Add(Me.txtAño)
        Me.gbCuantia97.Controls.Add(lblEdadPen)
        Me.gbCuantia97.Controls.Add(lblPension)
        Me.gbCuantia97.Controls.Add(lblAño)
        Me.gbCuantia97.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbCuantia97.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCuantia97.ForeColor = System.Drawing.Color.Maroon
        Me.gbCuantia97.Location = New System.Drawing.Point(14, 158)
        Me.gbCuantia97.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCuantia97.Name = "gbCuantia97"
        Me.gbCuantia97.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCuantia97.Size = New System.Drawing.Size(261, 107)
        Me.gbCuantia97.TabIndex = 31
        Me.gbCuantia97.TabStop = False
        Me.gbCuantia97.Text = "Año y Pensión Garantizada"
        '
        'txtPensionGarantizada
        '
        Me.txtPensionGarantizada.BackColor = System.Drawing.Color.White
        Me.txtPensionGarantizada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantia97, "PensionGarantizada", True))
        Me.txtPensionGarantizada.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPensionGarantizada.Location = New System.Drawing.Point(172, 73)
        Me.txtPensionGarantizada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPensionGarantizada.Name = "txtPensionGarantizada"
        Me.txtPensionGarantizada.Size = New System.Drawing.Size(72, 21)
        Me.txtPensionGarantizada.TabIndex = 3
        Me.txtPensionGarantizada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bsCuantia97
        '
        Me.bsCuantia97.DataMember = "CuantiasLey1997"
        Me.bsCuantia97.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEdadPension
        '
        Me.txtEdadPension.BackColor = System.Drawing.Color.White
        Me.txtEdadPension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantia97, "AñosPension", True))
        Me.txtEdadPension.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdadPension.Location = New System.Drawing.Point(172, 44)
        Me.txtEdadPension.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEdadPension.Name = "txtEdadPension"
        Me.txtEdadPension.Size = New System.Drawing.Size(51, 21)
        Me.txtEdadPension.TabIndex = 2
        Me.txtEdadPension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.Color.White
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantia97, "Año", True))
        Me.txtAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(172, 15)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(51, 21)
        Me.txtAño.TabIndex = 1
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSemCotSup
        '
        Me.txtSemCotSup.BackColor = System.Drawing.Color.White
        Me.txtSemCotSup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantia97, "SemCotSupeior", True))
        Me.txtSemCotSup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemCotSup.Location = New System.Drawing.Point(185, 47)
        Me.txtSemCotSup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSemCotSup.Name = "txtSemCotSup"
        Me.txtSemCotSup.Size = New System.Drawing.Size(51, 21)
        Me.txtSemCotSup.TabIndex = 5
        Me.txtSemCotSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSemCotInf
        '
        Me.txtSemCotInf.BackColor = System.Drawing.Color.White
        Me.txtSemCotInf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantia97, "SemCotInferior", True))
        Me.txtSemCotInf.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemCotInf.Location = New System.Drawing.Point(185, 18)
        Me.txtSemCotInf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSemCotInf.Name = "txtSemCotInf"
        Me.txtSemCotInf.Size = New System.Drawing.Size(51, 21)
        Me.txtSemCotInf.TabIndex = 4
        Me.txtSemCotInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLimSuperior
        '
        Me.txtLimSuperior.BackColor = System.Drawing.Color.White
        Me.txtLimSuperior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantia97, "LimSuperior", True))
        Me.txtLimSuperior.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimSuperior.Location = New System.Drawing.Point(135, 50)
        Me.txtLimSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimSuperior.Name = "txtLimSuperior"
        Me.txtLimSuperior.Size = New System.Drawing.Size(51, 21)
        Me.txtLimSuperior.TabIndex = 7
        Me.txtLimSuperior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLimInferior
        '
        Me.txtLimInferior.BackColor = System.Drawing.Color.White
        Me.txtLimInferior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantia97, "LimInferior", True))
        Me.txtLimInferior.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimInferior.Location = New System.Drawing.Point(135, 21)
        Me.txtLimInferior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimInferior.Name = "txtLimInferior"
        Me.txtLimInferior.Size = New System.Drawing.Size(51, 21)
        Me.txtLimInferior.TabIndex = 6
        Me.txtLimInferior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgCuantia1997
        '
        Me.dgCuantia1997.AllowUserToAddRows = False
        Me.dgCuantia1997.AllowUserToDeleteRows = False
        Me.dgCuantia1997.AllowUserToOrderColumns = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgCuantia1997.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgCuantia1997.AutoGenerateColumns = False
        Me.dgCuantia1997.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgCuantia1997.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCuantia1997.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuantia1997.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgCuantia1997.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuantia1997.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgCuantia1997.DataSource = Me.bsCuantia97
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuantia1997.DefaultCellStyle = DataGridViewCellStyle22
        Me.dgCuantia1997.EnableHeadersVisualStyles = False
        Me.dgCuantia1997.GridColor = System.Drawing.Color.SkyBlue
        Me.dgCuantia1997.Location = New System.Drawing.Point(20, 273)
        Me.dgCuantia1997.Margin = New System.Windows.Forms.Padding(4)
        Me.dgCuantia1997.Name = "dgCuantia1997"
        Me.dgCuantia1997.ReadOnly = True
        Me.dgCuantia1997.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuantia1997.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgCuantia1997.RowHeadersVisible = False
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.dgCuantia1997.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.dgCuantia1997.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuantia1997.Size = New System.Drawing.Size(714, 150)
        Me.dgCuantia1997.TabIndex = 32
        Me.dgCuantia1997.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Año"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn2.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AñosPension"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pensión (Años)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LimInferior"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn4.HeaderText = "Limite Inferior"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LimSuperior"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn5.HeaderText = "Limite Superior"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PensionGarantizada"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Format = "C2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pensión Garantizada"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SemCotInferior"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn7.HeaderText = "Semanas Cotizadas Inferior"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SemCotSupeior"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn8.HeaderText = "Semanas Cotizadas Superior"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 80)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(746, 35)
        Me.SSMensaje.TabIndex = 33
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
        Me.tsslMensaje.Size = New System.Drawing.Size(725, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'FillByAñoPenToolStrip
        '
        Me.FillByAñoPenToolStrip.AutoSize = False
        Me.FillByAñoPenToolStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.FillByAñoPenToolStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillByAñoPenToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslAños, Me.txtFiltroAño, Me.tslAñosPension, Me.txtFiltroAñoPension, Me.tslLiimite, Me.txtFiltroLimite, Me.btnFiltro})
        Me.FillByAñoPenToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByAñoPenToolStrip.Name = "FillByAñoPenToolStrip"
        Me.FillByAñoPenToolStrip.Size = New System.Drawing.Size(746, 40)
        Me.FillByAñoPenToolStrip.TabIndex = 34
        Me.FillByAñoPenToolStrip.Text = "FillByAñoPenToolStrip"
        '
        'tslAños
        '
        Me.tslAños.ForeColor = System.Drawing.Color.Blue
        Me.tslAños.Name = "tslAños"
        Me.tslAños.Size = New System.Drawing.Size(32, 37)
        Me.tslAños.Text = "Año:"
        '
        'txtFiltroAño
        '
        Me.txtFiltroAño.AutoSize = False
        Me.txtFiltroAño.BackColor = System.Drawing.Color.White
        Me.txtFiltroAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroAño.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAño.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFiltroAño.Name = "txtFiltroAño"
        Me.txtFiltroAño.Size = New System.Drawing.Size(58, 22)
        Me.txtFiltroAño.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFiltroAño.ToolTipText = "Filtro x Año"
        '
        'tslAñosPension
        '
        Me.tslAñosPension.ForeColor = System.Drawing.Color.Blue
        Me.tslAñosPension.Name = "tslAñosPension"
        Me.tslAñosPension.Size = New System.Drawing.Size(104, 37)
        Me.tslAñosPension.Text = "  Años de Pensión:"
        '
        'txtFiltroAñoPension
        '
        Me.txtFiltroAñoPension.AutoSize = False
        Me.txtFiltroAñoPension.BackColor = System.Drawing.Color.White
        Me.txtFiltroAñoPension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroAñoPension.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAñoPension.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFiltroAñoPension.Name = "txtFiltroAñoPension"
        Me.txtFiltroAñoPension.Size = New System.Drawing.Size(58, 22)
        Me.txtFiltroAñoPension.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFiltroAñoPension.ToolTipText = "Filtro x Años a Pensionarse"
        '
        'tslLiimite
        '
        Me.tslLiimite.ForeColor = System.Drawing.Color.Blue
        Me.tslLiimite.Name = "tslLiimite"
        Me.tslLiimite.Size = New System.Drawing.Size(83, 37)
        Me.tslLiimite.Text = "Límite Inferior:"
        '
        'txtFiltroLimite
        '
        Me.txtFiltroLimite.AutoSize = False
        Me.txtFiltroLimite.BackColor = System.Drawing.Color.White
        Me.txtFiltroLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroLimite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroLimite.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFiltroLimite.Name = "txtFiltroLimite"
        Me.txtFiltroLimite.Size = New System.Drawing.Size(58, 22)
        Me.txtFiltroLimite.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFiltroLimite.ToolTipText = "FIltro x Limite Inferior"
        '
        'btnFiltro
        '
        Me.btnFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltro.Image = CType(resources.GetObject("btnFiltro.Image"), System.Drawing.Image)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(23, 37)
        Me.btnFiltro.Text = "FillByAñoPen"
        Me.btnFiltro.ToolTipText = "Filtros x Año, Años de Pensión y Limite Inferior"
        '
        'CuantiasLey1997TableAdapter
        '
        Me.CuantiasLey1997TableAdapter.ClearBeforeFill = True
        '
        'gbSC
        '
        Me.gbSC.Controls.Add(Me.txtSemCotSup)
        Me.gbSC.Controls.Add(lblSemCotInf)
        Me.gbSC.Controls.Add(Me.txtSemCotInf)
        Me.gbSC.Controls.Add(lblSemCotSup)
        Me.gbSC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSC.ForeColor = System.Drawing.Color.Maroon
        Me.gbSC.Location = New System.Drawing.Point(282, 158)
        Me.gbSC.Name = "gbSC"
        Me.gbSC.Size = New System.Drawing.Size(251, 107)
        Me.gbSC.TabIndex = 35
        Me.gbSC.TabStop = False
        Me.gbSC.Text = "Semanas Cotizadas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(lblLimInf)
        Me.GroupBox1.Controls.Add(Me.txtLimSuperior)
        Me.GroupBox1.Controls.Add(lblLimSup)
        Me.GroupBox1.Controls.Add(Me.txtLimInferior)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(539, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 107)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salario Base Cotización"
        '
        'foCuantias97
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(746, 430)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSC)
        Me.Controls.Add(Me.FillByAñoPenToolStrip)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.dgCuantia1997)
        Me.Controls.Add(Me.gbCuantia97)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foCuantias97"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo Cuantías Ley 1997"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.gbCuantia97.ResumeLayout(False)
        Me.gbCuantia97.PerformLayout()
        CType(Me.bsCuantia97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuantia1997, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.FillByAñoPenToolStrip.ResumeLayout(False)
        Me.FillByAñoPenToolStrip.PerformLayout()
        Me.gbSC.ResumeLayout(False)
        Me.gbSC.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents tsbAgregar As ToolStripButton
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
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbCuantia97 As GroupBox
    Friend WithEvents dgCuantia1997 As DataGridView
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtSemCotSup As TextBox
    Friend WithEvents txtSemCotInf As TextBox
    Friend WithEvents txtPensionGarantizada As TextBox
    Friend WithEvents txtLimSuperior As TextBox
    Friend WithEvents txtLimInferior As TextBox
    Friend WithEvents txtEdadPension As TextBox
    'Friend WithEvents dsCuantia97 As dsCuantia1997
    Friend WithEvents bsCuantia97 As BindingSource
    'Friend WithEvents CuantiasLey1997TableAdapter As dsCuantia1997TableAdapters.CuantiasLey1997TableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñosPensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimInferiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimSuperiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemCotInferiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemCotSupeiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PensionGarantizadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillByAñoPenToolStrip As ToolStrip
    Friend WithEvents tslAños As ToolStripLabel
    Friend WithEvents txtFiltroAño As ToolStripTextBox
    Friend WithEvents tslAñosPension As ToolStripLabel
    Friend WithEvents txtFiltroAñoPension As ToolStripTextBox
    Friend WithEvents btnFiltro As ToolStripButton
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents CuantiasLey1997TableAdapter As dsCatalogosTableAdapters.CuantiasLey1997TableAdapter
    Friend WithEvents tslLiimite As ToolStripLabel
    Friend WithEvents txtFiltroLimite As ToolStripTextBox
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents gbSC As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class

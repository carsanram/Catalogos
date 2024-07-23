<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foCuantias73
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim llblCuantiaBase As System.Windows.Forms.Label
        Dim llblCuantiaAdicional As System.Windows.Forms.Label
        Dim lblLimSuperior As System.Windows.Forms.Label
        Dim lblLimInferior As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foCuantias73))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.gbCuantiasL73 = New System.Windows.Forms.GroupBox()
        Me.txtCuantiaBase = New System.Windows.Forms.TextBox()
        Me.bsCuantiasLey1973 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.txtCuantiaAdicional = New System.Windows.Forms.TextBox()
        Me.txtLimSuperior = New System.Windows.Forms.TextBox()
        Me.txtLimInferior = New System.Windows.Forms.TextBox()
        Me.dgCuantia73 = New System.Windows.Forms.DataGridView()
        Me.LimInferior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimSuperiorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaBaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LimInferiorToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFiltroLimInf = New System.Windows.Forms.ToolStripButton()
        Me.tsFiltros = New System.Windows.Forms.ToolStrip()
        Me.tslLimInf = New System.Windows.Forms.ToolStripLabel()
        Me.txtRangoIni = New System.Windows.Forms.ToolStripTextBox()
        Me.tslLimSup = New System.Windows.Forms.ToolStripLabel()
        Me.txtRangoFin = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.CuantiasLey1973TableAdapter = New Catalogos.dsCatalogosTableAdapters.CuantiasLey1973TableAdapter()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        llblCuantiaBase = New System.Windows.Forms.Label()
        llblCuantiaAdicional = New System.Windows.Forms.Label()
        lblLimSuperior = New System.Windows.Forms.Label()
        lblLimInferior = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.gbCuantiasL73.SuspendLayout()
        CType(Me.bsCuantiasLey1973, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuantia73, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSMensaje.SuspendLayout()
        Me.tsFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'llblCuantiaBase
        '
        llblCuantiaBase.AutoSize = True
        llblCuantiaBase.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        llblCuantiaBase.ForeColor = System.Drawing.Color.Red
        llblCuantiaBase.Location = New System.Drawing.Point(20, 57)
        llblCuantiaBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        llblCuantiaBase.Name = "llblCuantiaBase"
        llblCuantiaBase.Size = New System.Drawing.Size(93, 15)
        llblCuantiaBase.TabIndex = 13
        llblCuantiaBase.Text = "% Cuantia Base:"
        '
        'llblCuantiaAdicional
        '
        llblCuantiaAdicional.AutoSize = True
        llblCuantiaAdicional.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        llblCuantiaAdicional.ForeColor = System.Drawing.Color.Red
        llblCuantiaAdicional.Location = New System.Drawing.Point(229, 57)
        llblCuantiaAdicional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        llblCuantiaAdicional.Name = "llblCuantiaAdicional"
        llblCuantiaAdicional.Size = New System.Drawing.Size(119, 15)
        llblCuantiaAdicional.TabIndex = 12
        llblCuantiaAdicional.Text = "% Cuantia Adicional:"
        '
        'lblLimSuperior
        '
        lblLimSuperior.AutoSize = True
        lblLimSuperior.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLimSuperior.ForeColor = System.Drawing.Color.Red
        lblLimSuperior.Location = New System.Drawing.Point(260, 28)
        lblLimSuperior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLimSuperior.Name = "lblLimSuperior"
        lblLimSuperior.Size = New System.Drawing.Size(88, 15)
        lblLimSuperior.TabIndex = 11
        lblLimSuperior.Text = "Limite Superior:"
        '
        'lblLimInferior
        '
        lblLimInferior.AutoSize = True
        lblLimInferior.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLimInferior.ForeColor = System.Drawing.Color.Red
        lblLimInferior.Location = New System.Drawing.Point(33, 28)
        lblLimInferior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLimInferior.Name = "lblLimInferior"
        lblLimInferior.Size = New System.Drawing.Size(80, 15)
        lblLimInferior.TabIndex = 10
        lblLimInferior.Text = "Limite Inferior:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(555, 40)
        Me.tsBotones.TabIndex = 6
        Me.tsBotones.Text = "tsLey73"
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
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 115)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(555, 30)
        Me.lblTitulo.TabIndex = 14
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbCuantiasL73
        '
        Me.gbCuantiasL73.Controls.Add(Me.txtCuantiaBase)
        Me.gbCuantiasL73.Controls.Add(Me.txtCuantiaAdicional)
        Me.gbCuantiasL73.Controls.Add(Me.txtLimSuperior)
        Me.gbCuantiasL73.Controls.Add(Me.txtLimInferior)
        Me.gbCuantiasL73.Controls.Add(llblCuantiaBase)
        Me.gbCuantiasL73.Controls.Add(llblCuantiaAdicional)
        Me.gbCuantiasL73.Controls.Add(lblLimSuperior)
        Me.gbCuantiasL73.Controls.Add(lblLimInferior)
        Me.gbCuantiasL73.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbCuantiasL73.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCuantiasL73.ForeColor = System.Drawing.Color.Maroon
        Me.gbCuantiasL73.Location = New System.Drawing.Point(32, 159)
        Me.gbCuantiasL73.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCuantiasL73.Name = "gbCuantiasL73"
        Me.gbCuantiasL73.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCuantiasL73.Size = New System.Drawing.Size(474, 92)
        Me.gbCuantiasL73.TabIndex = 23
        Me.gbCuantiasL73.TabStop = False
        Me.gbCuantiasL73.Text = "Cuantías Ley 73"
        '
        'txtCuantiaBase
        '
        Me.txtCuantiaBase.BackColor = System.Drawing.Color.White
        Me.txtCuantiaBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantiasLey1973, "pctCuantiaBase", True))
        Me.txtCuantiaBase.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuantiaBase.Location = New System.Drawing.Point(121, 54)
        Me.txtCuantiaBase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuantiaBase.Name = "txtCuantiaBase"
        Me.txtCuantiaBase.Size = New System.Drawing.Size(93, 21)
        Me.txtCuantiaBase.TabIndex = 3
        Me.txtCuantiaBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bsCuantiasLey1973
        '
        Me.bsCuantiasLey1973.DataMember = "CuantiasLey1973"
        Me.bsCuantiasLey1973.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCuantiaAdicional
        '
        Me.txtCuantiaAdicional.BackColor = System.Drawing.Color.White
        Me.txtCuantiaAdicional.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantiasLey1973, "pctCuantiaAdicional", True))
        Me.txtCuantiaAdicional.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuantiaAdicional.Location = New System.Drawing.Point(356, 54)
        Me.txtCuantiaAdicional.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuantiaAdicional.Name = "txtCuantiaAdicional"
        Me.txtCuantiaAdicional.Size = New System.Drawing.Size(93, 21)
        Me.txtCuantiaAdicional.TabIndex = 4
        Me.txtCuantiaAdicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLimSuperior
        '
        Me.txtLimSuperior.BackColor = System.Drawing.Color.White
        Me.txtLimSuperior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantiasLey1973, "LimSuperior", True))
        Me.txtLimSuperior.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimSuperior.Location = New System.Drawing.Point(356, 25)
        Me.txtLimSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimSuperior.Name = "txtLimSuperior"
        Me.txtLimSuperior.Size = New System.Drawing.Size(93, 21)
        Me.txtLimSuperior.TabIndex = 2
        Me.txtLimSuperior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLimInferior
        '
        Me.txtLimInferior.BackColor = System.Drawing.Color.White
        Me.txtLimInferior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantiasLey1973, "LimInferior", True))
        Me.txtLimInferior.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimInferior.Location = New System.Drawing.Point(121, 25)
        Me.txtLimInferior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimInferior.Name = "txtLimInferior"
        Me.txtLimInferior.Size = New System.Drawing.Size(93, 21)
        Me.txtLimInferior.TabIndex = 1
        Me.txtLimInferior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgCuantia73
        '
        Me.dgCuantia73.AllowUserToAddRows = False
        Me.dgCuantia73.AllowUserToDeleteRows = False
        Me.dgCuantia73.AllowUserToOrderColumns = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgCuantia73.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgCuantia73.AutoGenerateColumns = False
        Me.dgCuantia73.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgCuantia73.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCuantia73.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuantia73.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgCuantia73.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LimInferior, Me.LimSuperiorDataGridViewTextBoxColumn, Me.PctCuantiaBaseDataGridViewTextBoxColumn, Me.PctCuantiaAdicionalDataGridViewTextBoxColumn})
        Me.dgCuantia73.DataSource = Me.bsCuantiasLey1973
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuantia73.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgCuantia73.EnableHeadersVisualStyles = False
        Me.dgCuantia73.GridColor = System.Drawing.Color.SteelBlue
        Me.dgCuantia73.Location = New System.Drawing.Point(55, 266)
        Me.dgCuantia73.Margin = New System.Windows.Forms.Padding(4)
        Me.dgCuantia73.Name = "dgCuantia73"
        Me.dgCuantia73.ReadOnly = True
        Me.dgCuantia73.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuantia73.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgCuantia73.RowHeadersVisible = False
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.dgCuantia73.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgCuantia73.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuantia73.Size = New System.Drawing.Size(437, 125)
        Me.dgCuantia73.TabIndex = 24
        Me.dgCuantia73.TabStop = False
        '
        'LimInferior
        '
        Me.LimInferior.DataPropertyName = "LimInferior"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LimInferior.DefaultCellStyle = DataGridViewCellStyle12
        Me.LimInferior.HeaderText = "Inferior"
        Me.LimInferior.Name = "LimInferior"
        Me.LimInferior.ReadOnly = True
        Me.LimInferior.Width = 70
        '
        'LimSuperiorDataGridViewTextBoxColumn
        '
        Me.LimSuperiorDataGridViewTextBoxColumn.DataPropertyName = "LimSuperior"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LimSuperiorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.LimSuperiorDataGridViewTextBoxColumn.HeaderText = "Superior"
        Me.LimSuperiorDataGridViewTextBoxColumn.Name = "LimSuperiorDataGridViewTextBoxColumn"
        Me.LimSuperiorDataGridViewTextBoxColumn.ReadOnly = True
        Me.LimSuperiorDataGridViewTextBoxColumn.Width = 70
        '
        'PctCuantiaBaseDataGridViewTextBoxColumn
        '
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.DataPropertyName = "pctCuantiaBase"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.HeaderText = "% Cuantia Base"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.Name = "PctCuantiaBaseDataGridViewTextBoxColumn"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.Width = 120
        '
        'PctCuantiaAdicionalDataGridViewTextBoxColumn
        '
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.DataPropertyName = "pctCuantiaAdicional"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.HeaderText = "% Cuantia Adicional"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.Name = "PctCuantiaAdicionalDataGridViewTextBoxColumn"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.Width = 150
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 80)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(555, 35)
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
        Me.tsslMensaje.Size = New System.Drawing.Size(530, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'LimInferiorToolStripTextBox
        '
        Me.LimInferiorToolStripTextBox.AutoSize = False
        Me.LimInferiorToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LimInferiorToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LimInferiorToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimInferiorToolStripTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LimInferiorToolStripTextBox.Name = "LimInferiorToolStripTextBox"
        Me.LimInferiorToolStripTextBox.Size = New System.Drawing.Size(60, 23)
        Me.LimInferiorToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFiltroLimInf
        '
        Me.btnFiltroLimInf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltroLimInf.Image = CType(resources.GetObject("btnFiltroLimInf.Image"), System.Drawing.Image)
        Me.btnFiltroLimInf.Name = "btnFiltroLimInf"
        Me.btnFiltroLimInf.Size = New System.Drawing.Size(23, 24)
        '
        'tsFiltros
        '
        Me.tsFiltros.AutoSize = False
        Me.tsFiltros.BackColor = System.Drawing.Color.SkyBlue
        Me.tsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslLimInf, Me.txtRangoIni, Me.tslLimSup, Me.txtRangoFin, Me.btnFiltro})
        Me.tsFiltros.Location = New System.Drawing.Point(0, 40)
        Me.tsFiltros.Name = "tsFiltros"
        Me.tsFiltros.Size = New System.Drawing.Size(555, 40)
        Me.tsFiltros.TabIndex = 26
        Me.tsFiltros.Text = "FillByNombreToolStrip"
        '
        'tslLimInf
        '
        Me.tslLimInf.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslLimInf.ForeColor = System.Drawing.Color.Blue
        Me.tslLimInf.Name = "tslLimInf"
        Me.tslLimInf.Size = New System.Drawing.Size(92, 37)
        Me.tslLimInf.Text = "Rango Inferior:"
        '
        'txtRangoIni
        '
        Me.txtRangoIni.AutoSize = False
        Me.txtRangoIni.BackColor = System.Drawing.Color.White
        Me.txtRangoIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRangoIni.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRangoIni.Name = "txtRangoIni"
        Me.txtRangoIni.Size = New System.Drawing.Size(50, 22)
        Me.txtRangoIni.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRangoIni.ToolTipText = "Búsqueda por Rango Inferior"
        '
        'tslLimSup
        '
        Me.tslLimSup.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslLimSup.ForeColor = System.Drawing.Color.Blue
        Me.tslLimSup.Name = "tslLimSup"
        Me.tslLimSup.Size = New System.Drawing.Size(99, 37)
        Me.tslLimSup.Text = "Rango Superior:"
        '
        'txtRangoFin
        '
        Me.txtRangoFin.AutoSize = False
        Me.txtRangoFin.BackColor = System.Drawing.Color.White
        Me.txtRangoFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRangoFin.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRangoFin.Name = "txtRangoFin"
        Me.txtRangoFin.Size = New System.Drawing.Size(50, 22)
        Me.txtRangoFin.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRangoFin.ToolTipText = "Búsqueda por Rango Superior"
        '
        'btnFiltro
        '
        Me.btnFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltro.Image = Global.Catalogos.My.Resources.Resources.Buscar
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(23, 37)
        Me.btnFiltro.ToolTipText = "Filtros x Rango Inferior y Rango Superior"
        '
        'CuantiasLey1973TableAdapter
        '
        Me.CuantiasLey1973TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AforesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuantiasLey1973arTableAdapter = Nothing
        Me.TableAdapterManager.CuantiasLey1973TableAdapter = Me.CuantiasLey1973TableAdapter
        Me.TableAdapterManager.CuantiasLey1997TableAdapter = Nothing
        Me.TableAdapterManager.DespachoTableAdapter = Nothing
        Me.TableAdapterManager.EstadosMxTableAdapter = Nothing
        Me.TableAdapterManager.InflacionAnualTableAdapter = Nothing
        Me.TableAdapterManager.INPCTableAdapter = Nothing
        Me.TableAdapterManager.ISRTableAdapter = Nothing
        Me.TableAdapterManager.LeyIMSSTableAdapter = Nothing
        Me.TableAdapterManager.LeySegPenTableAdapter = Nothing
        Me.TableAdapterManager.PctSegurosM40TableAdapter = Nothing
        Me.TableAdapterManager.PensionTableAdapter = Nothing
        Me.TableAdapterManager.RegimenIMSSTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.TopadoSMG_UMATableAdapter = Nothing
        Me.TableAdapterManager.UMATableAdapter = Nothing
        Me.TableAdapterManager.UMFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'foCuantias73
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(555, 404)
        Me.Controls.Add(Me.tsFiltros)
        Me.Controls.Add(Me.gbCuantiasL73)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.dgCuantia73)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foCuantias73"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo Cuantías Ley 1973"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.gbCuantiasL73.ResumeLayout(False)
        Me.gbCuantiasL73.PerformLayout()
        CType(Me.bsCuantiasLey1973, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuantia73, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.tsFiltros.ResumeLayout(False)
        Me.tsFiltros.PerformLayout()
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
    Friend WithEvents gbCuantiasL73 As GroupBox
    Friend WithEvents txtCuantiaBase As TextBox
    Friend WithEvents txtCuantiaAdicional As TextBox
    Friend WithEvents txtLimSuperior As TextBox
    Friend WithEvents txtLimInferior As TextBox
    Friend WithEvents dgCuantia73 As DataGridView
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    'Friend WithEvents CuantiasLey1973TableAdapter As CatalogosDataSetTableAdapters.CuantiasLey1973TableAdapter
    'Friend WithEvents FillLimInferiorToolStrip As ToolStrip
    'Friend WithEvents LimInferiorToolStripLabel As ToolStripLabel
    Friend WithEvents LimInferiorToolStripTextBox As ToolStripTextBox
    Friend WithEvents btnFiltroLimInf As ToolStripButton
    Friend WithEvents bsCuantiasLey1973 As BindingSource
    Friend WithEvents CuantiasLey1973TableAdapter As dsCatalogosTableAdapters.CuantiasLey1973TableAdapter
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents tsFiltros As ToolStrip
    Friend WithEvents tslLimSup As ToolStripLabel
    Friend WithEvents txtRangoFin As ToolStripTextBox
    Friend WithEvents btnFiltro As ToolStripButton
    Friend WithEvents tslLimInf As ToolStripLabel
    Friend WithEvents txtRangoIni As ToolStripTextBox
    Friend WithEvents LimInferior As DataGridViewTextBoxColumn
    Friend WithEvents LimSuperiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaBaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaAdicionalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
End Class

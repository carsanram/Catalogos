<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foINPC
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
        Dim lblAño As System.Windows.Forms.Label
        Dim lblID As System.Windows.Forms.Label
        Dim lblMes As System.Windows.Forms.Label
        Dim lblINPC As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foINPC))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsBotones = New System.Windows.Forms.ToolStrip()
        Me.tsbValidar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.tsbINPC = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GBEdos = New System.Windows.Forms.GroupBox()
        Me.txtTasaRecargo = New System.Windows.Forms.TextBox()
        Me.bsINPC = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCatalogos = New Catalogos.dsCatalogos()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.txtINPC = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.dgINPC = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorRecargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stFiltros = New System.Windows.Forms.ToolStrip()
        Me.IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtIDFiltro = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFillID = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        Me.INPCTableAdapter = New Catalogos.dsCatalogosTableAdapters.INPCTableAdapter()
        Me.INPCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        lblAño = New System.Windows.Forms.Label()
        lblID = New System.Windows.Forms.Label()
        lblMes = New System.Windows.Forms.Label()
        lblINPC = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.GBEdos.SuspendLayout()
        CType(Me.bsINPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgINPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSMensaje.SuspendLayout()
        Me.stFiltros.SuspendLayout()
        CType(Me.INPCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAño
        '
        lblAño.AutoSize = True
        lblAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAño.ForeColor = System.Drawing.Color.Red
        lblAño.Location = New System.Drawing.Point(118, 37)
        lblAño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblAño.Name = "lblAño"
        lblAño.Size = New System.Drawing.Size(32, 15)
        lblAño.TabIndex = 11
        lblAño.Text = "Año:"
        '
        'lblID
        '
        lblID.AutoSize = True
        lblID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblID.ForeColor = System.Drawing.Color.Blue
        lblID.Location = New System.Drawing.Point(12, 37)
        lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblID.Name = "lblID"
        lblID.Size = New System.Drawing.Size(20, 15)
        lblID.TabIndex = 10
        lblID.Text = "ID:"
        '
        'lblMes
        '
        lblMes.AutoSize = True
        lblMes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMes.ForeColor = System.Drawing.Color.Red
        lblMes.Location = New System.Drawing.Point(217, 37)
        lblMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblMes.Name = "lblMes"
        lblMes.Size = New System.Drawing.Size(32, 15)
        lblMes.TabIndex = 12
        lblMes.Text = "Mes:"
        '
        'lblINPC
        '
        lblINPC.AutoSize = True
        lblINPC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblINPC.ForeColor = System.Drawing.Color.Red
        lblINPC.Location = New System.Drawing.Point(313, 37)
        lblINPC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblINPC.Name = "lblINPC"
        lblINPC.Size = New System.Drawing.Size(36, 15)
        lblINPC.TabIndex = 13
        lblINPC.Text = "INPC:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Red
        Label1.Location = New System.Drawing.Point(425, 37)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(100, 15)
        Label1.TabIndex = 15
        Label1.Text = "Taza de Recargo:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator3, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbINPC, Me.ToolStripSeparator2, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(629, 40)
        Me.tsBotones.TabIndex = 3
        Me.tsBotones.Text = "ToolStrip1"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 50)
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
        Me.tss01.Size = New System.Drawing.Size(6, 50)
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
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'tsbINPC
        '
        Me.tsbINPC.AutoSize = False
        Me.tsbINPC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbINPC.Image = CType(resources.GetObject("tsbINPC.Image"), System.Drawing.Image)
        Me.tsbINPC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbINPC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbINPC.Margin = New System.Windows.Forms.Padding(2)
        Me.tsbINPC.Name = "tsbINPC"
        Me.tsbINPC.Size = New System.Drawing.Size(60, 40)
        Me.tsbINPC.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
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
        Me.lblTitulo.Location = New System.Drawing.Point(0, 110)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(629, 30)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBEdos
        '
        Me.GBEdos.Controls.Add(Me.txtTasaRecargo)
        Me.GBEdos.Controls.Add(Label1)
        Me.GBEdos.Controls.Add(Me.cboMes)
        Me.GBEdos.Controls.Add(Me.txtINPC)
        Me.GBEdos.Controls.Add(lblINPC)
        Me.GBEdos.Controls.Add(lblMes)
        Me.GBEdos.Controls.Add(Me.txtID)
        Me.GBEdos.Controls.Add(Me.txtAño)
        Me.GBEdos.Controls.Add(lblAño)
        Me.GBEdos.Controls.Add(lblID)
        Me.GBEdos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEdos.ForeColor = System.Drawing.Color.Maroon
        Me.GBEdos.Location = New System.Drawing.Point(13, 155)
        Me.GBEdos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBEdos.Name = "GBEdos"
        Me.GBEdos.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBEdos.Size = New System.Drawing.Size(607, 79)
        Me.GBEdos.TabIndex = 15
        Me.GBEdos.TabStop = False
        Me.GBEdos.Text = "Inflación INPC Mensual"
        '
        'txtTasaRecargo
        '
        Me.txtTasaRecargo.BackColor = System.Drawing.Color.White
        Me.txtTasaRecargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsINPC, "FactorRecargo", True))
        Me.txtTasaRecargo.Location = New System.Drawing.Point(533, 35)
        Me.txtTasaRecargo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTasaRecargo.Name = "txtTasaRecargo"
        Me.txtTasaRecargo.Size = New System.Drawing.Size(60, 21)
        Me.txtTasaRecargo.TabIndex = 14
        Me.txtTasaRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bsINPC
        '
        Me.bsINPC.DataMember = "INPC"
        Me.bsINPC.DataSource = Me.dsCatalogos
        '
        'dsCatalogos
        '
        Me.dsCatalogos.DataSetName = "CatalogosDataSet"
        Me.dsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboMes
        '
        Me.cboMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsINPC, "Mes", True))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cboMes.Location = New System.Drawing.Point(256, 34)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(50, 23)
        Me.cboMes.TabIndex = 3
        '
        'txtINPC
        '
        Me.txtINPC.BackColor = System.Drawing.Color.White
        Me.txtINPC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsINPC, "INPC", True))
        Me.txtINPC.Location = New System.Drawing.Point(357, 35)
        Me.txtINPC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtINPC.Name = "txtINPC"
        Me.txtINPC.Size = New System.Drawing.Size(60, 21)
        Me.txtINPC.TabIndex = 4
        Me.txtINPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsINPC, "ID", True))
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(40, 34)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(70, 22)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.Color.White
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsINPC, "Years", True))
        Me.txtAño.Location = New System.Drawing.Point(158, 34)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(51, 21)
        Me.txtAño.TabIndex = 2
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgINPC
        '
        Me.dgINPC.AllowUserToAddRows = False
        Me.dgINPC.AllowUserToDeleteRows = False
        Me.dgINPC.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgINPC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgINPC.AutoGenerateColumns = False
        Me.dgINPC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgINPC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgINPC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgINPC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgINPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgINPC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.YearsDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.INPCDataGridViewTextBoxColumn, Me.FactorRecargoDataGridViewTextBoxColumn})
        Me.dgINPC.DataSource = Me.bsINPC
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgINPC.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgINPC.EnableHeadersVisualStyles = False
        Me.dgINPC.GridColor = System.Drawing.Color.SkyBlue
        Me.dgINPC.Location = New System.Drawing.Point(53, 240)
        Me.dgINPC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgINPC.Name = "dgINPC"
        Me.dgINPC.ReadOnly = True
        Me.dgINPC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgINPC.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgINPC.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgINPC.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgINPC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgINPC.Size = New System.Drawing.Size(525, 130)
        Me.dgINPC.TabIndex = 16
        Me.dgINPC.TabStop = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearsDataGridViewTextBoxColumn
        '
        Me.YearsDataGridViewTextBoxColumn.DataPropertyName = "Years"
        Me.YearsDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.YearsDataGridViewTextBoxColumn.Name = "YearsDataGridViewTextBoxColumn"
        Me.YearsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        Me.MesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INPCDataGridViewTextBoxColumn
        '
        Me.INPCDataGridViewTextBoxColumn.DataPropertyName = "INPC"
        Me.INPCDataGridViewTextBoxColumn.HeaderText = "INPC"
        Me.INPCDataGridViewTextBoxColumn.Name = "INPCDataGridViewTextBoxColumn"
        Me.INPCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FactorRecargoDataGridViewTextBoxColumn
        '
        Me.FactorRecargoDataGridViewTextBoxColumn.DataPropertyName = "FactorRecargo"
        Me.FactorRecargoDataGridViewTextBoxColumn.HeaderText = "FactorRecargo"
        Me.FactorRecargoDataGridViewTextBoxColumn.Name = "FactorRecargoDataGridViewTextBoxColumn"
        Me.FactorRecargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 75)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(629, 35)
        Me.SSMensaje.TabIndex = 17
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
        Me.tsslMensaje.Size = New System.Drawing.Size(605, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'stFiltros
        '
        Me.stFiltros.AutoSize = False
        Me.stFiltros.BackColor = System.Drawing.Color.SkyBlue
        Me.stFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripLabel, Me.txtIDFiltro, Me.btnFillID})
        Me.stFiltros.Location = New System.Drawing.Point(0, 40)
        Me.stFiltros.Name = "stFiltros"
        Me.stFiltros.Size = New System.Drawing.Size(629, 40)
        Me.stFiltros.TabIndex = 18
        Me.stFiltros.Text = "FillByIDToolStrip"
        '
        'IDToolStripLabel
        '
        Me.IDToolStripLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDToolStripLabel.ForeColor = System.Drawing.Color.Blue
        Me.IDToolStripLabel.Name = "IDToolStripLabel"
        Me.IDToolStripLabel.Size = New System.Drawing.Size(22, 37)
        Me.IDToolStripLabel.Text = "ID:"
        '
        'txtIDFiltro
        '
        Me.txtIDFiltro.AutoSize = False
        Me.txtIDFiltro.BackColor = System.Drawing.Color.White
        Me.txtIDFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDFiltro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDFiltro.Name = "txtIDFiltro"
        Me.txtIDFiltro.Size = New System.Drawing.Size(70, 21)
        Me.txtIDFiltro.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIDFiltro.ToolTipText = "Filtro x ID (AñoMes)"
        '
        'btnFillID
        '
        Me.btnFillID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFillID.Image = CType(resources.GetObject("btnFillID.Image"), System.Drawing.Image)
        Me.btnFillID.Name = "btnFillID"
        Me.btnFillID.Size = New System.Drawing.Size(23, 37)
        Me.btnFillID.Text = "FillByID"
        Me.btnFillID.ToolTipText = "Flitro x ID"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AforesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.PctSegurosM40TableAdapter = Nothing
        Me.TableAdapterManager.PensionTableAdapter = Nothing
        Me.TableAdapterManager.RegimenIMSSTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.TopadoSMG_UMATableAdapter = Nothing
        Me.TableAdapterManager.UMATableAdapter = Nothing
        Me.TableAdapterManager.UMFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'INPCTableAdapter
        '
        Me.INPCTableAdapter.ClearBeforeFill = True
        '
        'INPCBindingSource
        '
        Me.INPCBindingSource.DataMember = "INPC"
        Me.INPCBindingSource.DataSource = Me.dsCatalogos
        '
        'foINPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 392)
        Me.Controls.Add(Me.stFiltros)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.dgINPC)
        Me.Controls.Add(Me.GBEdos)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "foINPC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Indices de Inflación Mensual (INPC) y Factores de Recargo"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.GBEdos.ResumeLayout(False)
        Me.GBEdos.PerformLayout()
        CType(Me.bsINPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgINPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.stFiltros.ResumeLayout(False)
        Me.stFiltros.PerformLayout()
        CType(Me.INPCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GBEdos As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents dgINPC As DataGridView
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents dsCatalogos As dsCatalogos
    Friend WithEvents stFiltros As ToolStrip
    Friend WithEvents IDToolStripLabel As ToolStripLabel
    Friend WithEvents txtIDFiltro As ToolStripTextBox
    Friend WithEvents btnFillID As ToolStripButton
    Friend WithEvents txtINPC As TextBox
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents tsbINPC As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cboMes As ComboBox
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents txtTasaRecargo As TextBox
    Friend WithEvents INPCTableAdapter As dsCatalogosTableAdapters.INPCTableAdapter
    Friend WithEvents bsINPC As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INPCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FactorRecargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INPCBindingSource As BindingSource
End Class

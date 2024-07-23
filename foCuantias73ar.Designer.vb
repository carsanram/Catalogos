<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foCuantias73ar
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
        Dim lblSalFinal As System.Windows.Forms.Label
        Dim lblSalInicial As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foCuantias73ar))
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbAfores = New System.Windows.Forms.GroupBox()
        Me.txtCuantiaBase = New System.Windows.Forms.TextBox()
        Me.bsCuantias73ar = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.txtCuantiaAdicional = New System.Windows.Forms.TextBox()
        Me.txtSalFinal = New System.Windows.Forms.TextBox()
        Me.txtSalInicial = New System.Windows.Forms.TextBox()
        Me.dgCuantia73ar = New System.Windows.Forms.DataGridView()
        Me.SalarioInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaBaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.CuantiasLey1973arTableAdapter = New Catalogos.dsCatalogosTableAdapters.CuantiasLey1973arTableAdapter()
        llblCuantiaBase = New System.Windows.Forms.Label()
        llblCuantiaAdicional = New System.Windows.Forms.Label()
        lblSalFinal = New System.Windows.Forms.Label()
        lblSalInicial = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.gbAfores.SuspendLayout()
        CType(Me.bsCuantias73ar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuantia73ar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSMensaje.SuspendLayout()
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
        'lblSalFinal
        '
        lblSalFinal.AutoSize = True
        lblSalFinal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSalFinal.ForeColor = System.Drawing.Color.Red
        lblSalFinal.Location = New System.Drawing.Point(272, 28)
        lblSalFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSalFinal.Name = "lblSalFinal"
        lblSalFinal.Size = New System.Drawing.Size(76, 15)
        lblSalFinal.TabIndex = 11
        lblSalFinal.Text = "Salario Final:"
        '
        'lblSalInicial
        '
        lblSalInicial.AutoSize = True
        lblSalInicial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSalInicial.ForeColor = System.Drawing.Color.Red
        lblSalInicial.Location = New System.Drawing.Point(31, 28)
        lblSalInicial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSalInicial.Name = "lblSalInicial"
        lblSalInicial.Size = New System.Drawing.Size(82, 15)
        lblSalInicial.TabIndex = 10
        lblSalInicial.Text = "Salario Inicial:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(508, 40)
        Me.tsBotones.TabIndex = 5
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
        'gbAfores
        '
        Me.gbAfores.Controls.Add(Me.txtCuantiaBase)
        Me.gbAfores.Controls.Add(Me.txtCuantiaAdicional)
        Me.gbAfores.Controls.Add(Me.txtSalFinal)
        Me.gbAfores.Controls.Add(Me.txtSalInicial)
        Me.gbAfores.Controls.Add(llblCuantiaBase)
        Me.gbAfores.Controls.Add(llblCuantiaAdicional)
        Me.gbAfores.Controls.Add(lblSalFinal)
        Me.gbAfores.Controls.Add(lblSalInicial)
        Me.gbAfores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbAfores.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAfores.ForeColor = System.Drawing.Color.Maroon
        Me.gbAfores.Location = New System.Drawing.Point(13, 119)
        Me.gbAfores.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAfores.Name = "gbAfores"
        Me.gbAfores.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAfores.Size = New System.Drawing.Size(474, 92)
        Me.gbAfores.TabIndex = 22
        Me.gbAfores.TabStop = False
        Me.gbAfores.Text = "Cuantia IMSS 73 Antes Reforma 1990"
        '
        'txtCuantiaBase
        '
        Me.txtCuantiaBase.BackColor = System.Drawing.Color.White
        Me.txtCuantiaBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantias73ar, "pctCuantiaBase", True))
        Me.txtCuantiaBase.Location = New System.Drawing.Point(121, 54)
        Me.txtCuantiaBase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuantiaBase.Name = "txtCuantiaBase"
        Me.txtCuantiaBase.Size = New System.Drawing.Size(93, 21)
        Me.txtCuantiaBase.TabIndex = 3
        Me.txtCuantiaBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bsCuantias73ar
        '
        Me.bsCuantias73ar.DataMember = "CuantiasLey1973ar"
        Me.bsCuantias73ar.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCuantiaAdicional
        '
        Me.txtCuantiaAdicional.BackColor = System.Drawing.Color.White
        Me.txtCuantiaAdicional.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantias73ar, "pctCuantiaAdicional", True))
        Me.txtCuantiaAdicional.Location = New System.Drawing.Point(356, 54)
        Me.txtCuantiaAdicional.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuantiaAdicional.Name = "txtCuantiaAdicional"
        Me.txtCuantiaAdicional.Size = New System.Drawing.Size(93, 21)
        Me.txtCuantiaAdicional.TabIndex = 4
        Me.txtCuantiaAdicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalFinal
        '
        Me.txtSalFinal.BackColor = System.Drawing.Color.White
        Me.txtSalFinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantias73ar, "SalarioFinal", True))
        Me.txtSalFinal.Location = New System.Drawing.Point(356, 25)
        Me.txtSalFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalFinal.Name = "txtSalFinal"
        Me.txtSalFinal.Size = New System.Drawing.Size(93, 21)
        Me.txtSalFinal.TabIndex = 2
        Me.txtSalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalInicial
        '
        Me.txtSalInicial.BackColor = System.Drawing.Color.White
        Me.txtSalInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCuantias73ar, "SalarioInicial", True))
        Me.txtSalInicial.Location = New System.Drawing.Point(121, 25)
        Me.txtSalInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalInicial.Name = "txtSalInicial"
        Me.txtSalInicial.Size = New System.Drawing.Size(93, 21)
        Me.txtSalInicial.TabIndex = 1
        Me.txtSalInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgCuantia73ar
        '
        Me.dgCuantia73ar.AllowUserToAddRows = False
        Me.dgCuantia73ar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgCuantia73ar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCuantia73ar.AutoGenerateColumns = False
        Me.dgCuantia73ar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgCuantia73ar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCuantia73ar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuantia73ar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgCuantia73ar.ColumnHeadersHeight = 20
        Me.dgCuantia73ar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCuantia73ar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalarioInicialDataGridViewTextBoxColumn, Me.SalarioFinalDataGridViewTextBoxColumn, Me.PctCuantiaBaseDataGridViewTextBoxColumn, Me.PctCuantiaAdicionalDataGridViewTextBoxColumn})
        Me.dgCuantia73ar.DataSource = Me.bsCuantias73ar
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuantia73ar.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgCuantia73ar.EnableHeadersVisualStyles = False
        Me.dgCuantia73ar.GridColor = System.Drawing.Color.SteelBlue
        Me.dgCuantia73ar.Location = New System.Drawing.Point(13, 219)
        Me.dgCuantia73ar.Margin = New System.Windows.Forms.Padding(4)
        Me.dgCuantia73ar.Name = "dgCuantia73ar"
        Me.dgCuantia73ar.ReadOnly = True
        Me.dgCuantia73ar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuantia73ar.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgCuantia73ar.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgCuantia73ar.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgCuantia73ar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuantia73ar.Size = New System.Drawing.Size(474, 116)
        Me.dgCuantia73ar.TabIndex = 23
        Me.dgCuantia73ar.TabStop = False
        '
        'SalarioInicialDataGridViewTextBoxColumn
        '
        Me.SalarioInicialDataGridViewTextBoxColumn.DataPropertyName = "SalarioInicial"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SalarioInicialDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SalarioInicialDataGridViewTextBoxColumn.HeaderText = "Salario Inicial"
        Me.SalarioInicialDataGridViewTextBoxColumn.Name = "SalarioInicialDataGridViewTextBoxColumn"
        Me.SalarioInicialDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalarioInicialDataGridViewTextBoxColumn.Width = 110
        '
        'SalarioFinalDataGridViewTextBoxColumn
        '
        Me.SalarioFinalDataGridViewTextBoxColumn.DataPropertyName = "SalarioFinal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SalarioFinalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SalarioFinalDataGridViewTextBoxColumn.HeaderText = "Salario Final"
        Me.SalarioFinalDataGridViewTextBoxColumn.Name = "SalarioFinalDataGridViewTextBoxColumn"
        Me.SalarioFinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalarioFinalDataGridViewTextBoxColumn.Width = 110
        '
        'PctCuantiaBaseDataGridViewTextBoxColumn
        '
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.DataPropertyName = "pctCuantiaBase"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.HeaderText = "% Cuantía Base"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.Name = "PctCuantiaBaseDataGridViewTextBoxColumn"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.Width = 110
        '
        'PctCuantiaAdicionalDataGridViewTextBoxColumn
        '
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.DataPropertyName = "pctCuantiaAdicional"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.HeaderText = "% Cuantía Adicional"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.Name = "PctCuantiaAdicionalDataGridViewTextBoxColumn"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.Width = 130
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
        Me.tsslMensaje.Size = New System.Drawing.Size(485, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 40)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(508, 35)
        Me.SSMensaje.TabIndex = 24
        Me.SSMensaje.Text = "StatusStrip1"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 75)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(508, 30)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CuantiasLey1973arTableAdapter
        '
        Me.CuantiasLey1973arTableAdapter.ClearBeforeFill = True
        '
        'foCuantias73ar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(508, 345)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.dgCuantia73ar)
        Me.Controls.Add(Me.gbAfores)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foCuantias73ar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo Cuantías Ley 73 Antes Refroma 1990"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.gbAfores.ResumeLayout(False)
        Me.gbAfores.PerformLayout()
        CType(Me.bsCuantias73ar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuantia73ar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents gbAfores As GroupBox
    Friend WithEvents txtSalInicial As TextBox
    Friend WithEvents dgCuantia73ar As DataGridView
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents txtSalFinal As TextBox
    Friend WithEvents txtCuantiaBase As TextBox
    Friend WithEvents txtCuantiaAdicional As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents CuantiasLey1973arTableAdapter As dsCatalogosTableAdapters.CuantiasLey1973arTableAdapter
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents bsCuantias73ar As BindingSource
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents SalarioInicialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioFinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaBaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaAdicionalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

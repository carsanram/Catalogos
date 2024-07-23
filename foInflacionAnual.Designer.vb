<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foInflacionAnual
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
        Dim lblInfAnual As System.Windows.Forms.Label
        Dim lblAño As System.Windows.Forms.Label
        Dim lblEstimada As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foInflacionAnual))
        Me.dgInfAnual = New System.Windows.Forms.DataGridView()
        Me.bsInflacionAnual = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
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
        Me.gbInflacion = New System.Windows.Forms.GroupBox()
        Me.cboEstimada = New System.Windows.Forms.ComboBox()
        Me.txtInfAnual = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsFiltros = New System.Windows.Forms.ToolStrip()
        Me.AñoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtFiltroAño = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscaAño = New System.Windows.Forms.ToolStripButton()
        Me.InflacionAnualTableAdapter = New Catalogos.dsCatalogosTableAdapters.InflacionAnualTableAdapter()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estimada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        lblInfAnual = New System.Windows.Forms.Label()
        lblAño = New System.Windows.Forms.Label()
        lblEstimada = New System.Windows.Forms.Label()
        CType(Me.dgInfAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInflacionAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBotones.SuspendLayout()
        Me.gbInflacion.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        Me.tsFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfAnual
        '
        lblInfAnual.AutoSize = True
        lblInfAnual.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblInfAnual.ForeColor = System.Drawing.Color.Red
        lblInfAnual.Location = New System.Drawing.Point(121, 36)
        lblInfAnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblInfAnual.Name = "lblInfAnual"
        lblInfAnual.Size = New System.Drawing.Size(103, 15)
        lblInfAnual.TabIndex = 11
        lblInfAnual.Text = "% Inflación Anual:"
        '
        'lblAño
        '
        lblAño.AutoSize = True
        lblAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAño.ForeColor = System.Drawing.Color.Red
        lblAño.Location = New System.Drawing.Point(15, 36)
        lblAño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblAño.Name = "lblAño"
        lblAño.Size = New System.Drawing.Size(32, 15)
        lblAño.TabIndex = 10
        lblAño.Text = "Año:"
        '
        'lblEstimada
        '
        lblEstimada.AutoSize = True
        lblEstimada.ForeColor = System.Drawing.Color.Blue
        lblEstimada.Location = New System.Drawing.Point(308, 36)
        lblEstimada.Name = "lblEstimada"
        lblEstimada.Size = New System.Drawing.Size(57, 15)
        lblEstimada.TabIndex = 11
        lblEstimada.Text = "Estimada:"
        '
        'dgInfAnual
        '
        Me.dgInfAnual.AllowUserToAddRows = False
        Me.dgInfAnual.AllowUserToDeleteRows = False
        Me.dgInfAnual.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgInfAnual.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInfAnual.AutoGenerateColumns = False
        Me.dgInfAnual.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgInfAnual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInfAnual.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInfAnual.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgInfAnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInfAnual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Estimada})
        Me.dgInfAnual.DataSource = Me.bsInflacionAnual
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInfAnual.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgInfAnual.EnableHeadersVisualStyles = False
        Me.dgInfAnual.GridColor = System.Drawing.Color.SkyBlue
        Me.dgInfAnual.Location = New System.Drawing.Point(117, 224)
        Me.dgInfAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.dgInfAnual.Name = "dgInfAnual"
        Me.dgInfAnual.ReadOnly = True
        Me.dgInfAnual.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInfAnual.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgInfAnual.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgInfAnual.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgInfAnual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInfAnual.Size = New System.Drawing.Size(323, 150)
        Me.dgInfAnual.TabIndex = 25
        Me.dgInfAnual.TabStop = False
        '
        'bsInflacionAnual
        '
        Me.bsInflacionAnual.DataMember = "InflacionAnual"
        Me.bsInflacionAnual.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(549, 40)
        Me.tsBotones.TabIndex = 26
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
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(1, 110)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(548, 30)
        Me.lblTitulo.TabIndex = 27
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbInflacion
        '
        Me.gbInflacion.Controls.Add(Me.cboEstimada)
        Me.gbInflacion.Controls.Add(lblEstimada)
        Me.gbInflacion.Controls.Add(Me.txtInfAnual)
        Me.gbInflacion.Controls.Add(Me.txtAño)
        Me.gbInflacion.Controls.Add(lblInfAnual)
        Me.gbInflacion.Controls.Add(lblAño)
        Me.gbInflacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbInflacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInflacion.ForeColor = System.Drawing.Color.Maroon
        Me.gbInflacion.Location = New System.Drawing.Point(48, 148)
        Me.gbInflacion.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInflacion.Name = "gbInflacion"
        Me.gbInflacion.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInflacion.Size = New System.Drawing.Size(443, 68)
        Me.gbInflacion.TabIndex = 28
        Me.gbInflacion.TabStop = False
        Me.gbInflacion.Text = "Inflación Anual"
        '
        'cboEstimada
        '
        Me.cboEstimada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsInflacionAnual, "Estimada", True))
        Me.cboEstimada.FormattingEnabled = True
        Me.cboEstimada.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboEstimada.Location = New System.Drawing.Point(371, 31)
        Me.cboEstimada.Name = "cboEstimada"
        Me.cboEstimada.Size = New System.Drawing.Size(44, 23)
        Me.cboEstimada.TabIndex = 12
        '
        'txtInfAnual
        '
        Me.txtInfAnual.BackColor = System.Drawing.Color.White
        Me.txtInfAnual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsInflacionAnual, "Inflacion", True))
        Me.txtInfAnual.Location = New System.Drawing.Point(232, 33)
        Me.txtInfAnual.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInfAnual.Name = "txtInfAnual"
        Me.txtInfAnual.Size = New System.Drawing.Size(69, 21)
        Me.txtInfAnual.TabIndex = 2
        Me.txtInfAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.Color.White
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsInflacionAnual, "Año", True))
        Me.txtAño.Location = New System.Drawing.Point(55, 33)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(58, 21)
        Me.txtAño.TabIndex = 1
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 75)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(549, 35)
        Me.SSMensaje.TabIndex = 29
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
        'tsFiltros
        '
        Me.tsFiltros.AutoSize = False
        Me.tsFiltros.BackColor = System.Drawing.Color.SkyBlue
        Me.tsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñoToolStripLabel, Me.txtFiltroAño, Me.btnBuscaAño})
        Me.tsFiltros.Location = New System.Drawing.Point(0, 40)
        Me.tsFiltros.Name = "tsFiltros"
        Me.tsFiltros.Size = New System.Drawing.Size(549, 40)
        Me.tsFiltros.TabIndex = 30
        Me.tsFiltros.Text = "FillByAñoToolStrip"
        '
        'AñoToolStripLabel
        '
        Me.AñoToolStripLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñoToolStripLabel.ForeColor = System.Drawing.Color.Blue
        Me.AñoToolStripLabel.Name = "AñoToolStripLabel"
        Me.AñoToolStripLabel.Size = New System.Drawing.Size(34, 37)
        Me.AñoToolStripLabel.Text = "Año:"
        '
        'txtFiltroAño
        '
        Me.txtFiltroAño.AutoSize = False
        Me.txtFiltroAño.BackColor = System.Drawing.Color.White
        Me.txtFiltroAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroAño.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroAño.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFiltroAño.Name = "txtFiltroAño"
        Me.txtFiltroAño.Size = New System.Drawing.Size(70, 22)
        Me.txtFiltroAño.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFiltroAño.ToolTipText = "Filtro x Año"
        '
        'btnBuscaAño
        '
        Me.btnBuscaAño.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscaAño.Image = CType(resources.GetObject("btnBuscaAño.Image"), System.Drawing.Image)
        Me.btnBuscaAño.Name = "btnBuscaAño"
        Me.btnBuscaAño.Size = New System.Drawing.Size(23, 37)
        Me.btnBuscaAño.Text = "FillByAño"
        Me.btnBuscaAño.ToolTipText = "Filtro x Año"
        '
        'InflacionAnualTableAdapter
        '
        Me.InflacionAnualTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AforesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuantiasLey1973arTableAdapter = Nothing
        Me.TableAdapterManager.CuantiasLey1973TableAdapter = Nothing
        Me.TableAdapterManager.CuantiasLey1997TableAdapter = Nothing
        Me.TableAdapterManager.DespachoTableAdapter = Nothing
        Me.TableAdapterManager.EstadosMxTableAdapter = Nothing
        Me.TableAdapterManager.InflacionAnualTableAdapter = Me.InflacionAnualTableAdapter
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
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.ForeColor = System.Drawing.Color.Blue
        Me.lblNota.Location = New System.Drawing.Point(45, 390)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(444, 30)
        Me.lblNota.TabIndex = 31
        Me.lblNota.Text = "Nota: Inflación del Año Pasado que se Aplica en el Año Seleccionado a partir de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Febrero"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Inflacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "% Inflación"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Estimada
        '
        Me.Estimada.DataPropertyName = "Estimada"
        Me.Estimada.HeaderText = "Estimada"
        Me.Estimada.Name = "Estimada"
        Me.Estimada.ReadOnly = True
        '
        'foInflacionAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(549, 445)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.tsFiltros)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.gbInflacion)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Controls.Add(Me.dgInfAnual)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foInflacionAnual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Inflación Anual"
        CType(Me.dgInfAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInflacionAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.gbInflacion.ResumeLayout(False)
        Me.gbInflacion.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.tsFiltros.ResumeLayout(False)
        Me.tsFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgInfAnual As DataGridView
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
    Friend WithEvents gbInflacion As GroupBox
    Friend WithEvents txtInfAnual As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    'Friend WithEvents DsInflacionAnual As dsInflacionAnual
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InflacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    'Friend WithEvents InflacionAnualTableAdapter As dsInflacionAnualTableAdapters.InflacionAnualTableAdapter
    Friend WithEvents tsFiltros As ToolStrip
    Friend WithEvents AñoToolStripLabel As ToolStripLabel
    Friend WithEvents txtFiltroAño As ToolStripTextBox
    Friend WithEvents btnBuscaAño As ToolStripButton
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents InflacionAnualTableAdapter As dsCatalogosTableAdapters.InflacionAnualTableAdapter
    Friend WithEvents bsInflacionAnual As BindingSource
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents cboEstimada As ComboBox
    Friend WithEvents lblNota As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Estimada As DataGridViewTextBoxColumn
End Class

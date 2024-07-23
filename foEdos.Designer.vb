<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoEdos
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
        Dim lblCve As System.Windows.Forms.Label
        Dim lblEstado As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoEdos))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.bsEdos = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.dgEstados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBEdos = New System.Windows.Forms.GroupBox()
        Me.txtCve = New System.Windows.Forms.TextBox()
        Me.ttAyuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.FillByCveToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CveToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtCveFiltro = New System.Windows.Forms.ToolStripTextBox()
        Me.BtnFillCve = New System.Windows.Forms.ToolStripButton()
        Me.EstadosMxTableAdapter = New Catalogos.dsCatalogosTableAdapters.EstadosMxTableAdapter()
        lblCve = New System.Windows.Forms.Label()
        lblEstado = New System.Windows.Forms.Label()
        Me.SSMensaje.SuspendLayout()
        Me.tsBotones.SuspendLayout()
        CType(Me.bsEdos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEdos.SuspendLayout()
        Me.FillByCveToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCve
        '
        lblCve.AutoSize = True
        lblCve.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCve.ForeColor = System.Drawing.Color.Red
        lblCve.Location = New System.Drawing.Point(40, 26)
        lblCve.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblCve.Name = "lblCve"
        lblCve.Size = New System.Drawing.Size(31, 15)
        lblCve.TabIndex = 10
        lblCve.Text = "Cve:"
        '
        'lblEstado
        '
        lblEstado.AutoSize = True
        lblEstado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEstado.ForeColor = System.Drawing.Color.Red
        lblEstado.Location = New System.Drawing.Point(141, 26)
        lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New System.Drawing.Size(45, 15)
        lblEstado.TabIndex = 11
        lblEstado.Text = "Estado:"
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 80)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(547, 35)
        Me.SSMensaje.TabIndex = 1
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
        Me.tsslMensaje.ForeColor = System.Drawing.Color.Black
        Me.tsslMensaje.Name = "tsslMensaje"
        Me.tsslMensaje.Size = New System.Drawing.Size(520, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(547, 40)
        Me.tsBotones.TabIndex = 2
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
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 115)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(547, 30)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.White
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEdos, "Estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(205, 22)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(153, 21)
        Me.txtEstado.TabIndex = 2
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtEstado, "Nombre del Estado")
        '
        'bsEdos
        '
        Me.bsEdos.DataMember = "EstadosMx"
        Me.bsEdos.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgEstados
        '
        Me.dgEstados.AllowUserToAddRows = False
        Me.dgEstados.AllowUserToDeleteRows = False
        Me.dgEstados.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgEstados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgEstados.AutoGenerateColumns = False
        Me.dgEstados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgEstados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEstados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEstados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgEstados.DataSource = Me.bsEdos
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEstados.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgEstados.EnableHeadersVisualStyles = False
        Me.dgEstados.GridColor = System.Drawing.Color.SkyBlue
        Me.dgEstados.Location = New System.Drawing.Point(149, 222)
        Me.dgEstados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEstados.Name = "dgEstados"
        Me.dgEstados.ReadOnly = True
        Me.dgEstados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstados.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgEstados.RowHeadersVisible = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.dgEstados.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstados.Size = New System.Drawing.Size(231, 131)
        Me.dgEstados.TabIndex = 3
        Me.dgEstados.TabStop = False
        Me.ttAyuda.SetToolTip(Me.dgEstados, "Nombres y claves de los Estados de México")
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cve"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cve"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'GBEdos
        '
        Me.GBEdos.Controls.Add(Me.txtCve)
        Me.GBEdos.Controls.Add(Me.txtEstado)
        Me.GBEdos.Controls.Add(lblEstado)
        Me.GBEdos.Controls.Add(lblCve)
        Me.GBEdos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEdos.ForeColor = System.Drawing.Color.Maroon
        Me.GBEdos.Location = New System.Drawing.Point(89, 159)
        Me.GBEdos.Margin = New System.Windows.Forms.Padding(4)
        Me.GBEdos.Name = "GBEdos"
        Me.GBEdos.Padding = New System.Windows.Forms.Padding(4)
        Me.GBEdos.Size = New System.Drawing.Size(371, 55)
        Me.GBEdos.TabIndex = 14
        Me.GBEdos.TabStop = False
        Me.GBEdos.Text = "Estados"
        '
        'txtCve
        '
        Me.txtCve.BackColor = System.Drawing.Color.White
        Me.txtCve.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEdos, "Cve", True))
        Me.txtCve.Location = New System.Drawing.Point(84, 22)
        Me.txtCve.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCve.Name = "txtCve"
        Me.txtCve.Size = New System.Drawing.Size(50, 21)
        Me.txtCve.TabIndex = 1
        '
        'FillByCveToolStrip
        '
        Me.FillByCveToolStrip.AutoSize = False
        Me.FillByCveToolStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.FillByCveToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CveToolStripLabel, Me.txtCveFiltro, Me.BtnFillCve})
        Me.FillByCveToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByCveToolStrip.Name = "FillByCveToolStrip"
        Me.FillByCveToolStrip.Size = New System.Drawing.Size(547, 40)
        Me.FillByCveToolStrip.TabIndex = 18
        Me.FillByCveToolStrip.Text = "FillByCveToolStrip"
        '
        'CveToolStripLabel
        '
        Me.CveToolStripLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CveToolStripLabel.ForeColor = System.Drawing.Color.Blue
        Me.CveToolStripLabel.Name = "CveToolStripLabel"
        Me.CveToolStripLabel.Size = New System.Drawing.Size(41, 37)
        Me.CveToolStripLabel.Text = "Clave:"
        '
        'txtCveFiltro
        '
        Me.txtCveFiltro.BackColor = System.Drawing.Color.White
        Me.txtCveFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCveFiltro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCveFiltro.Name = "txtCveFiltro"
        Me.txtCveFiltro.Size = New System.Drawing.Size(35, 40)
        Me.txtCveFiltro.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCveFiltro.ToolTipText = "Filtro x Clave del Estado"
        '
        'BtnFillCve
        '
        Me.BtnFillCve.AutoSize = False
        Me.BtnFillCve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFillCve.Image = CType(resources.GetObject("BtnFillCve.Image"), System.Drawing.Image)
        Me.BtnFillCve.Name = "BtnFillCve"
        Me.BtnFillCve.Size = New System.Drawing.Size(30, 22)
        Me.BtnFillCve.Text = "FillByCve"
        Me.BtnFillCve.ToolTipText = "Filtro x Clave del Estado"
        '
        'EstadosMxTableAdapter
        '
        Me.EstadosMxTableAdapter.ClearBeforeFill = True
        '
        'FoEdos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(547, 364)
        Me.Controls.Add(Me.FillByCveToolStrip)
        Me.Controls.Add(Me.GBEdos)
        Me.Controls.Add(Me.dgEstados)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Controls.Add(Me.SSMensaje)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FoEdos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estados de la República Mexicana"
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        CType(Me.bsEdos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEdos.ResumeLayout(False)
        Me.GBEdos.PerformLayout()
        Me.FillByCveToolStrip.ResumeLayout(False)
        Me.FillByCveToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SSMensaje As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsBotones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrevio As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    'Friend WithEvents DSCatalogos As Catalogos.dsCatalogos
    'Friend WithEvents TAEstados As dsCatalogosTableAdapters.EstadosMxTableAdapter
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents dgEstados As System.Windows.Forms.DataGridView
    Friend WithEvents GBEdos As System.Windows.Forms.GroupBox
    Friend WithEvents ttAyuda As System.Windows.Forms.ToolTip
    Friend WithEvents CveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents CatalogosDataSet As Catalogos.dsCatalogos
    'Friend WithEvents TAEstadosMx As dsCatalogosTableAdapters.EstadosMxTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents dsEstados As Catalogos.dsCatalogos
    'Friend WithEvents EstadosMxTableAdapter As dsCatalogosTableAdapters.EstadosMxTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCve As System.Windows.Forms.TextBox
    Friend WithEvents tsbRefrescar As ToolStripButton
    'Friend WithEvents taEstadosMx As CatalogosDataSetTableAdapters.EstadosMxTableAdapter
    Friend WithEvents FillByCveToolStrip As ToolStrip
    Friend WithEvents CveToolStripLabel As ToolStripLabel
    Friend WithEvents txtCveFiltro As ToolStripTextBox
    Friend WithEvents BtnFillCve As ToolStripButton
    Friend WithEvents EstadosMxTableAdapter As dsCatalogosTableAdapters.EstadosMxTableAdapter
    Friend WithEvents bsEdos As BindingSource
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
End Class

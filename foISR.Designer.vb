<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foISR
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
        Dim lblLimSup As System.Windows.Forms.Label
        Dim lblLimInf As System.Windows.Forms.Label
        Dim lblCuotaFija As System.Windows.Forms.Label
        Dim lblPctExcLimInf As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foISR))
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
        Me.gbAfores = New System.Windows.Forms.GroupBox()
        Me.txtPctExeLI = New System.Windows.Forms.TextBox()
        Me.bsISR = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.txtCuotaFija = New System.Windows.Forms.TextBox()
        Me.txtLimSup = New System.Windows.Forms.TextBox()
        Me.txtLimInf = New System.Windows.Forms.TextBox()
        Me.dgISR = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ISRTableAdapter = New Catalogos.dsCatalogosTableAdapters.ISRTableAdapter()
        lblLimSup = New System.Windows.Forms.Label()
        lblLimInf = New System.Windows.Forms.Label()
        lblCuotaFija = New System.Windows.Forms.Label()
        lblPctExcLimInf = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.gbAfores.SuspendLayout()
        CType(Me.bsISR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgISR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSMensaje.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLimSup
        '
        lblLimSup.AutoSize = True
        lblLimSup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLimSup.ForeColor = System.Drawing.Color.Red
        lblLimSup.Location = New System.Drawing.Point(209, 29)
        lblLimSup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLimSup.Name = "lblLimSup"
        lblLimSup.Size = New System.Drawing.Size(88, 15)
        lblLimSup.TabIndex = 11
        lblLimSup.Text = "Limite Superior:"
        '
        'lblLimInf
        '
        lblLimInf.AutoSize = True
        lblLimInf.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLimInf.ForeColor = System.Drawing.Color.Red
        lblLimInf.Location = New System.Drawing.Point(34, 29)
        lblLimInf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLimInf.Name = "lblLimInf"
        lblLimInf.Size = New System.Drawing.Size(80, 15)
        lblLimInf.TabIndex = 10
        lblLimInf.Text = "Limite Inferior:"
        '
        'lblCuotaFija
        '
        lblCuotaFija.AutoSize = True
        lblCuotaFija.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCuotaFija.ForeColor = System.Drawing.Color.Red
        lblCuotaFija.Location = New System.Drawing.Point(50, 58)
        lblCuotaFija.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblCuotaFija.Name = "lblCuotaFija"
        lblCuotaFija.Size = New System.Drawing.Size(64, 15)
        lblCuotaFija.TabIndex = 12
        lblCuotaFija.Text = "Cuota Fija:"
        '
        'lblPctExcLimInf
        '
        lblPctExcLimInf.AutoSize = True
        lblPctExcLimInf.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPctExcLimInf.ForeColor = System.Drawing.Color.Red
        lblPctExcLimInf.Location = New System.Drawing.Point(218, 58)
        lblPctExcLimInf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblPctExcLimInf.Name = "lblPctExcLimInf"
        lblPctExcLimInf.Size = New System.Drawing.Size(79, 15)
        lblPctExcLimInf.TabIndex = 14
        lblPctExcLimInf.Text = "% Excedente:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(539, 40)
        Me.tsBotones.TabIndex = 27
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
        Me.lblTitulo.Location = New System.Drawing.Point(0, 75)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(539, 30)
        Me.lblTitulo.TabIndex = 28
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbAfores
        '
        Me.gbAfores.Controls.Add(Me.txtPctExeLI)
        Me.gbAfores.Controls.Add(lblPctExcLimInf)
        Me.gbAfores.Controls.Add(Me.txtCuotaFija)
        Me.gbAfores.Controls.Add(lblCuotaFija)
        Me.gbAfores.Controls.Add(Me.txtLimSup)
        Me.gbAfores.Controls.Add(Me.txtLimInf)
        Me.gbAfores.Controls.Add(lblLimSup)
        Me.gbAfores.Controls.Add(lblLimInf)
        Me.gbAfores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbAfores.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAfores.ForeColor = System.Drawing.Color.Maroon
        Me.gbAfores.Location = New System.Drawing.Point(85, 109)
        Me.gbAfores.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAfores.Name = "gbAfores"
        Me.gbAfores.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAfores.Size = New System.Drawing.Size(398, 89)
        Me.gbAfores.TabIndex = 29
        Me.gbAfores.TabStop = False
        Me.gbAfores.Text = "ISR Tabla de Impuestos"
        '
        'txtPctExeLI
        '
        Me.txtPctExeLI.BackColor = System.Drawing.Color.White
        Me.txtPctExeLI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsISR, "PctExeLimInf", True))
        Me.txtPctExeLI.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPctExeLI.Location = New System.Drawing.Point(305, 55)
        Me.txtPctExeLI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPctExeLI.Name = "txtPctExeLI"
        Me.txtPctExeLI.Size = New System.Drawing.Size(70, 21)
        Me.txtPctExeLI.TabIndex = 15
        Me.txtPctExeLI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bsISR
        '
        Me.bsISR.DataMember = "ISR"
        Me.bsISR.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCuotaFija
        '
        Me.txtCuotaFija.BackColor = System.Drawing.Color.White
        Me.txtCuotaFija.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsISR, "CuotaFija", True))
        Me.txtCuotaFija.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaFija.Location = New System.Drawing.Point(121, 55)
        Me.txtCuotaFija.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuotaFija.Name = "txtCuotaFija"
        Me.txtCuotaFija.Size = New System.Drawing.Size(70, 21)
        Me.txtCuotaFija.TabIndex = 13
        Me.txtCuotaFija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLimSup
        '
        Me.txtLimSup.BackColor = System.Drawing.Color.White
        Me.txtLimSup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsISR, "LimSuperior", True))
        Me.txtLimSup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimSup.Location = New System.Drawing.Point(305, 26)
        Me.txtLimSup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimSup.Name = "txtLimSup"
        Me.txtLimSup.Size = New System.Drawing.Size(70, 21)
        Me.txtLimSup.TabIndex = 2
        Me.txtLimSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLimInf
        '
        Me.txtLimInf.BackColor = System.Drawing.Color.White
        Me.txtLimInf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsISR, "LimInferior", True))
        Me.txtLimInf.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimInf.Location = New System.Drawing.Point(121, 26)
        Me.txtLimInf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimInf.Name = "txtLimInf"
        Me.txtLimInf.Size = New System.Drawing.Size(70, 21)
        Me.txtLimInf.TabIndex = 1
        Me.txtLimInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgISR
        '
        Me.dgISR.AllowUserToAddRows = False
        Me.dgISR.AllowUserToDeleteRows = False
        Me.dgISR.AllowUserToOrderColumns = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgISR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgISR.AutoGenerateColumns = False
        Me.dgISR.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgISR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgISR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgISR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgISR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgISR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgISR.DataSource = Me.bsISR
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgISR.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgISR.EnableHeadersVisualStyles = False
        Me.dgISR.GridColor = System.Drawing.Color.SkyBlue
        Me.dgISR.Location = New System.Drawing.Point(32, 221)
        Me.dgISR.Margin = New System.Windows.Forms.Padding(4)
        Me.dgISR.MultiSelect = False
        Me.dgISR.Name = "dgISR"
        Me.dgISR.ReadOnly = True
        Me.dgISR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgISR.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgISR.RowHeadersVisible = False
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.dgISR.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgISR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgISR.Size = New System.Drawing.Size(496, 130)
        Me.dgISR.TabIndex = 30
        Me.dgISR.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LimInferior"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn2.HeaderText = "Límite Inferior"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LimSuperior"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn3.HeaderText = "Límite Superior"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CuotaFija"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cuota Fija"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PctExeLimInf"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn5.HeaderText = "% Exece Límite Inferior"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 40)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(539, 35)
        Me.SSMensaje.TabIndex = 31
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
        Me.tsslMensaje.Size = New System.Drawing.Size(510, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'ISRTableAdapter
        '
        Me.ISRTableAdapter.ClearBeforeFill = True
        '
        'foISR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(539, 362)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.dgISR)
        Me.Controls.Add(Me.gbAfores)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foISR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Impuestos ISR (SAT)"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.gbAfores.ResumeLayout(False)
        Me.gbAfores.PerformLayout()
        CType(Me.bsISR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgISR, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbAfores As GroupBox
    Friend WithEvents txtLimSup As TextBox
    Friend WithEvents txtLimInf As TextBox
    Friend WithEvents dgISR As DataGridView
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents txtPctExeLI As TextBox
    Friend WithEvents txtCuotaFija As TextBox
    'Friend WithEvents DsISR As dsISR
    Friend WithEvents bsISR As BindingSource
    'Friend WithEvents ISRTableAdapter As dsISRTableAdapters.ISRTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimInferiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimSuperiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaFijaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctExeLimInfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents ISRTableAdapter As dsCatalogosTableAdapters.ISRTableAdapter
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
End Class

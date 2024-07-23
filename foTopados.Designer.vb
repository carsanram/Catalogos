<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foTopados
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
        Dim AñoLabel As System.Windows.Forms.Label
        Dim SeguroLabel As System.Windows.Forms.Label
        Dim TopadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foTopados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cobSeguro = New System.Windows.Forms.ComboBox()
        Me.bsTopadoSMG_UMA = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.txtTopado = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.dgTopados = New System.Windows.Forms.DataGridView()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByCveToolStrip = New System.Windows.Forms.ToolStrip()
        Me.lbFilAño = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilAño = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFilAño = New System.Windows.Forms.ToolStripButton()
        Me.lbFilSeguro = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilSeguro = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFilSeguro = New System.Windows.Forms.ToolStripButton()
        Me.lbFilTopado = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilTopado = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFilTopado = New System.Windows.Forms.ToolStripButton()
        Me.TopadoSMG_UMATableAdapter = New Catalogos.dsCatalogosTableAdapters.TopadoSMG_UMATableAdapter()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        AñoLabel = New System.Windows.Forms.Label()
        SeguroLabel = New System.Windows.Forms.Label()
        TopadoLabel = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsTopadoSMG_UMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTopados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByCveToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.ForeColor = System.Drawing.Color.Blue
        AñoLabel.Location = New System.Drawing.Point(16, 34)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(32, 15)
        AñoLabel.TabIndex = 0
        AñoLabel.Text = "Año:"
        '
        'SeguroLabel
        '
        SeguroLabel.AutoSize = True
        SeguroLabel.ForeColor = System.Drawing.Color.Blue
        SeguroLabel.Location = New System.Drawing.Point(118, 34)
        SeguroLabel.Name = "SeguroLabel"
        SeguroLabel.Size = New System.Drawing.Size(48, 15)
        SeguroLabel.TabIndex = 2
        SeguroLabel.Text = "Seguro:"
        '
        'TopadoLabel
        '
        TopadoLabel.AutoSize = True
        TopadoLabel.ForeColor = System.Drawing.Color.Blue
        TopadoLabel.Location = New System.Drawing.Point(239, 34)
        TopadoLabel.Name = "TopadoLabel"
        TopadoLabel.Size = New System.Drawing.Size(50, 15)
        TopadoLabel.TabIndex = 4
        TopadoLabel.Text = "Topado:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(545, 40)
        Me.tsBotones.TabIndex = 4
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
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 113)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(545, 30)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Salarios Topados por Año"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 75)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(545, 35)
        Me.SSMensaje.TabIndex = 13
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
        Me.tsslMensaje.Size = New System.Drawing.Size(520, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cobSeguro)
        Me.GroupBox1.Controls.Add(TopadoLabel)
        Me.GroupBox1.Controls.Add(Me.txtTopado)
        Me.GroupBox1.Controls.Add(SeguroLabel)
        Me.GroupBox1.Controls.Add(AñoLabel)
        Me.GroupBox1.Controls.Add(Me.txtAño)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(107, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 71)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Topados"
        '
        'cobSeguro
        '
        Me.cobSeguro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTopadoSMG_UMA, "Seguro", True))
        Me.cobSeguro.FormattingEnabled = True
        Me.cobSeguro.Items.AddRange(New Object() {"RT", "EM", "R", "G", "IV", "CEAV"})
        Me.cobSeguro.Location = New System.Drawing.Point(172, 31)
        Me.cobSeguro.Name = "cobSeguro"
        Me.cobSeguro.Size = New System.Drawing.Size(61, 23)
        Me.cobSeguro.TabIndex = 20
        '
        'bsTopadoSMG_UMA
        '
        Me.bsTopadoSMG_UMA.DataMember = "TopadoSMG-UMA"
        Me.bsTopadoSMG_UMA.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTopado
        '
        Me.txtTopado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTopadoSMG_UMA, "Topado", True))
        Me.txtTopado.Location = New System.Drawing.Point(295, 31)
        Me.txtTopado.Name = "txtTopado"
        Me.txtTopado.Size = New System.Drawing.Size(52, 21)
        Me.txtTopado.TabIndex = 5
        Me.txtTopado.Text = "0"
        Me.txtTopado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño
        '
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsTopadoSMG_UMA, "Año", True))
        Me.txtAño.Location = New System.Drawing.Point(54, 31)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(58, 21)
        Me.txtAño.TabIndex = 1
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgTopados
        '
        Me.dgTopados.AllowUserToAddRows = False
        Me.dgTopados.AllowUserToDeleteRows = False
        Me.dgTopados.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgTopados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTopados.AutoGenerateColumns = False
        Me.dgTopados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgTopados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTopados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTopados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTopados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTopados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AñoDataGridViewTextBoxColumn, Me.SeguroDataGridViewTextBoxColumn, Me.TopadoDataGridViewTextBoxColumn})
        Me.dgTopados.DataSource = Me.bsTopadoSMG_UMA
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTopados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgTopados.EnableHeadersVisualStyles = False
        Me.dgTopados.GridColor = System.Drawing.Color.SkyBlue
        Me.dgTopados.Location = New System.Drawing.Point(126, 234)
        Me.dgTopados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgTopados.Name = "dgTopados"
        Me.dgTopados.ReadOnly = True
        Me.dgTopados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTopados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgTopados.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgTopados.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgTopados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTopados.Size = New System.Drawing.Size(326, 130)
        Me.dgTopados.TabIndex = 16
        Me.dgTopados.TabStop = False
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeguroDataGridViewTextBoxColumn
        '
        Me.SeguroDataGridViewTextBoxColumn.DataPropertyName = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.HeaderText = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.Name = "SeguroDataGridViewTextBoxColumn"
        Me.SeguroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TopadoDataGridViewTextBoxColumn
        '
        Me.TopadoDataGridViewTextBoxColumn.DataPropertyName = "Topado"
        Me.TopadoDataGridViewTextBoxColumn.HeaderText = "Topado"
        Me.TopadoDataGridViewTextBoxColumn.Name = "TopadoDataGridViewTextBoxColumn"
        Me.TopadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FillByCveToolStrip
        '
        Me.FillByCveToolStrip.AutoSize = False
        Me.FillByCveToolStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.FillByCveToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbFilAño, Me.txtFilAño, Me.btnFilAño, Me.lbFilSeguro, Me.txtFilSeguro, Me.btnFilSeguro, Me.lbFilTopado, Me.txtFilTopado, Me.btnFilTopado})
        Me.FillByCveToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByCveToolStrip.Name = "FillByCveToolStrip"
        Me.FillByCveToolStrip.Size = New System.Drawing.Size(545, 40)
        Me.FillByCveToolStrip.TabIndex = 19
        Me.FillByCveToolStrip.Text = "FillByCveToolStrip"
        '
        'lbFilAño
        '
        Me.lbFilAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFilAño.ForeColor = System.Drawing.Color.Blue
        Me.lbFilAño.Name = "lbFilAño"
        Me.lbFilAño.Size = New System.Drawing.Size(32, 37)
        Me.lbFilAño.Text = "Año:"
        '
        'txtFilAño
        '
        Me.txtFilAño.BackColor = System.Drawing.Color.White
        Me.txtFilAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilAño.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilAño.Name = "txtFilAño"
        Me.txtFilAño.Size = New System.Drawing.Size(35, 40)
        Me.txtFilAño.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilAño.ToolTipText = "Filtro x Año"
        '
        'btnFilAño
        '
        Me.btnFilAño.AutoSize = False
        Me.btnFilAño.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFilAño.Image = CType(resources.GetObject("btnFilAño.Image"), System.Drawing.Image)
        Me.btnFilAño.Name = "btnFilAño"
        Me.btnFilAño.Size = New System.Drawing.Size(30, 22)
        Me.btnFilAño.Text = "FillByCve"
        Me.btnFilAño.ToolTipText = "Filtro x Año"
        '
        'lbFilSeguro
        '
        Me.lbFilSeguro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFilSeguro.ForeColor = System.Drawing.Color.Blue
        Me.lbFilSeguro.Name = "lbFilSeguro"
        Me.lbFilSeguro.Size = New System.Drawing.Size(48, 37)
        Me.lbFilSeguro.Text = "Seguro:"
        '
        'txtFilSeguro
        '
        Me.txtFilSeguro.BackColor = System.Drawing.Color.White
        Me.txtFilSeguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilSeguro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilSeguro.Name = "txtFilSeguro"
        Me.txtFilSeguro.Size = New System.Drawing.Size(35, 40)
        Me.txtFilSeguro.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilSeguro.ToolTipText = "Filtro x Seguro"
        '
        'btnFilSeguro
        '
        Me.btnFilSeguro.AutoSize = False
        Me.btnFilSeguro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFilSeguro.Image = CType(resources.GetObject("btnFilSeguro.Image"), System.Drawing.Image)
        Me.btnFilSeguro.Name = "btnFilSeguro"
        Me.btnFilSeguro.Size = New System.Drawing.Size(30, 22)
        Me.btnFilSeguro.Text = "FillByCve"
        Me.btnFilSeguro.ToolTipText = "FIltro x Seguro"
        '
        'lbFilTopado
        '
        Me.lbFilTopado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFilTopado.ForeColor = System.Drawing.Color.Blue
        Me.lbFilTopado.Name = "lbFilTopado"
        Me.lbFilTopado.Size = New System.Drawing.Size(50, 37)
        Me.lbFilTopado.Text = "Topado:"
        Me.lbFilTopado.ToolTipText = "Ejecuta la Búsqueda Por Filtros"
        '
        'txtFilTopado
        '
        Me.txtFilTopado.BackColor = System.Drawing.Color.White
        Me.txtFilTopado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilTopado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilTopado.Name = "txtFilTopado"
        Me.txtFilTopado.Size = New System.Drawing.Size(35, 40)
        Me.txtFilTopado.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilTopado.ToolTipText = "Filtro x Vallor Topado"
        '
        'btnFilTopado
        '
        Me.btnFilTopado.AutoSize = False
        Me.btnFilTopado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFilTopado.Image = CType(resources.GetObject("btnFilTopado.Image"), System.Drawing.Image)
        Me.btnFilTopado.Name = "btnFilTopado"
        Me.btnFilTopado.Size = New System.Drawing.Size(30, 22)
        Me.btnFilTopado.Text = "FillByCve"
        Me.btnFilTopado.ToolTipText = "Filtro x Topado"
        '
        'TopadoSMG_UMATableAdapter
        '
        Me.TopadoSMG_UMATableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.InflacionAnualTableAdapter = Nothing
        Me.TableAdapterManager.INPCTableAdapter = Nothing
        Me.TableAdapterManager.ISRTableAdapter = Nothing
        Me.TableAdapterManager.LeyIMSSTableAdapter = Nothing
        Me.TableAdapterManager.LeySegPenTableAdapter = Nothing
        Me.TableAdapterManager.PctSegurosM40TableAdapter = Nothing
        Me.TableAdapterManager.PensionTableAdapter = Nothing
        Me.TableAdapterManager.RegimenIMSSTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.TopadoSMG_UMATableAdapter = Me.TopadoSMG_UMATableAdapter
        Me.TableAdapterManager.UMATableAdapter = Nothing
        Me.TableAdapterManager.UMFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'foTopados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(545, 376)
        Me.Controls.Add(Me.FillByCveToolStrip)
        Me.Controls.Add(Me.dgTopados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foTopados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguros Topados por Años"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsTopadoSMG_UMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTopados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByCveToolStrip.ResumeLayout(False)
        Me.FillByCveToolStrip.PerformLayout()
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
    Friend WithEvents lblTitulo As Label
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents bsTopadoSMG_UMA As BindingSource
    Friend WithEvents TopadoSMG_UMATableAdapter As dsCatalogosTableAdapters.TopadoSMG_UMATableAdapter
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents txtTopado As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents dgTopados As DataGridView
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeguroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TopadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillByCveToolStrip As ToolStrip
    Friend WithEvents lbFilTopado As ToolStripLabel
    Friend WithEvents txtFilTopado As ToolStripTextBox
    Friend WithEvents btnFilTopado As ToolStripButton
    Friend WithEvents lbFilAño As ToolStripLabel
    Friend WithEvents txtFilAño As ToolStripTextBox
    Friend WithEvents btnFilAño As ToolStripButton
    Friend WithEvents lbFilSeguro As ToolStripLabel
    Friend WithEvents txtFilSeguro As ToolStripTextBox
    Friend WithEvents btnFilSeguro As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents cobSeguro As ComboBox
End Class

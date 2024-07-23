<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foSegyPen
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
        Dim lblSeguro As System.Windows.Forms.Label
        Dim lblPension As System.Windows.Forms.Label
        Dim lblLey As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foSegyPen))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.gbSP = New System.Windows.Forms.GroupBox()
        Me.cboPension = New System.Windows.Forms.ComboBox()
        Me.bsLeySegPen = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.cboSeguro = New System.Windows.Forms.ComboBox()
        Me.cboLey = New System.Windows.Forms.ComboBox()
        Me.dgLeySegPen = New System.Windows.Forms.DataGridView()
        Me.LeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FillByLeyToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LeyToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtFillLey = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFillLey = New System.Windows.Forms.ToolStripButton()
        Me.LeySegPenTableAdapter = New Catalogos.dsCatalogosTableAdapters.LeySegPenTableAdapter()
        lblSeguro = New System.Windows.Forms.Label()
        lblPension = New System.Windows.Forms.Label()
        lblLey = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.gbSP.SuspendLayout()
        CType(Me.bsLeySegPen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLeySegPen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSMensaje.SuspendLayout()
        Me.FillByLeyToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSeguro
        '
        lblSeguro.AutoSize = True
        lblSeguro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSeguro.ForeColor = System.Drawing.Color.Red
        lblSeguro.Location = New System.Drawing.Point(165, 26)
        lblSeguro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSeguro.Name = "lblSeguro"
        lblSeguro.Size = New System.Drawing.Size(48, 15)
        lblSeguro.TabIndex = 12
        lblSeguro.Text = "Seguro:"
        '
        'lblPension
        '
        lblPension.AutoSize = True
        lblPension.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPension.ForeColor = System.Drawing.Color.Red
        lblPension.Location = New System.Drawing.Point(160, 58)
        lblPension.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblPension.Name = "lblPension"
        lblPension.Size = New System.Drawing.Size(53, 15)
        lblPension.TabIndex = 11
        lblPension.Text = "Pensión:"
        '
        'lblLey
        '
        lblLey.AutoSize = True
        lblLey.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLey.ForeColor = System.Drawing.Color.Red
        lblLey.Location = New System.Drawing.Point(18, 26)
        lblLey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLey.Name = "lblLey"
        lblLey.Size = New System.Drawing.Size(28, 15)
        lblLey.TabIndex = 10
        lblLey.Text = "Ley:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(697, 40)
        Me.tsBotones.TabIndex = 28
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
        Me.lblTitulo.Location = New System.Drawing.Point(0, 110)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(697, 40)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbSP
        '
        Me.gbSP.Controls.Add(Me.cboPension)
        Me.gbSP.Controls.Add(Me.cboSeguro)
        Me.gbSP.Controls.Add(Me.cboLey)
        Me.gbSP.Controls.Add(lblSeguro)
        Me.gbSP.Controls.Add(lblPension)
        Me.gbSP.Controls.Add(lblLey)
        Me.gbSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSP.ForeColor = System.Drawing.Color.Maroon
        Me.gbSP.Location = New System.Drawing.Point(66, 164)
        Me.gbSP.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSP.Name = "gbSP"
        Me.gbSP.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSP.Size = New System.Drawing.Size(541, 88)
        Me.gbSP.TabIndex = 30
        Me.gbSP.TabStop = False
        Me.gbSP.Text = "Ley - Seguro - Pensiones"
        '
        'cboPension
        '
        Me.cboPension.BackColor = System.Drawing.Color.White
        Me.cboPension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLeySegPen, "Pension", True))
        Me.cboPension.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPension.FormattingEnabled = True
        Me.cboPension.Location = New System.Drawing.Point(221, 54)
        Me.cboPension.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPension.Name = "cboPension"
        Me.cboPension.Size = New System.Drawing.Size(305, 23)
        Me.cboPension.TabIndex = 16
        '
        'bsLeySegPen
        '
        Me.bsLeySegPen.DataMember = "LeySegPen"
        Me.bsLeySegPen.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboSeguro
        '
        Me.cboSeguro.BackColor = System.Drawing.Color.White
        Me.cboSeguro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLeySegPen, "Seguro", True))
        Me.cboSeguro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeguro.FormattingEnabled = True
        Me.cboSeguro.Location = New System.Drawing.Point(221, 22)
        Me.cboSeguro.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSeguro.Name = "cboSeguro"
        Me.cboSeguro.Size = New System.Drawing.Size(305, 23)
        Me.cboSeguro.TabIndex = 15
        '
        'cboLey
        '
        Me.cboLey.BackColor = System.Drawing.Color.White
        Me.cboLey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLeySegPen, "Ley", True))
        Me.cboLey.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLey.FormattingEnabled = True
        Me.cboLey.Location = New System.Drawing.Point(54, 22)
        Me.cboLey.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLey.Name = "cboLey"
        Me.cboLey.Size = New System.Drawing.Size(84, 23)
        Me.cboLey.TabIndex = 14
        '
        'dgLeySegPen
        '
        Me.dgLeySegPen.AllowUserToAddRows = False
        Me.dgLeySegPen.AllowUserToDeleteRows = False
        Me.dgLeySegPen.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgLeySegPen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgLeySegPen.AutoGenerateColumns = False
        Me.dgLeySegPen.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgLeySegPen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLeySegPen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLeySegPen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgLeySegPen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLeySegPen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LeyDataGridViewTextBoxColumn, Me.SeguroDataGridViewTextBoxColumn, Me.PensionDataGridViewTextBoxColumn})
        Me.dgLeySegPen.DataSource = Me.bsLeySegPen
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLeySegPen.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgLeySegPen.EnableHeadersVisualStyles = False
        Me.dgLeySegPen.GridColor = System.Drawing.Color.SkyBlue
        Me.dgLeySegPen.Location = New System.Drawing.Point(12, 260)
        Me.dgLeySegPen.Margin = New System.Windows.Forms.Padding(4)
        Me.dgLeySegPen.Name = "dgLeySegPen"
        Me.dgLeySegPen.ReadOnly = True
        Me.dgLeySegPen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLeySegPen.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgLeySegPen.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgLeySegPen.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgLeySegPen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLeySegPen.Size = New System.Drawing.Size(668, 132)
        Me.dgLeySegPen.TabIndex = 31
        Me.dgLeySegPen.TabStop = False
        '
        'LeyDataGridViewTextBoxColumn
        '
        Me.LeyDataGridViewTextBoxColumn.DataPropertyName = "Ley"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LeyDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.LeyDataGridViewTextBoxColumn.HeaderText = "Ley"
        Me.LeyDataGridViewTextBoxColumn.Name = "LeyDataGridViewTextBoxColumn"
        Me.LeyDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeyDataGridViewTextBoxColumn.Width = 50
        '
        'SeguroDataGridViewTextBoxColumn
        '
        Me.SeguroDataGridViewTextBoxColumn.DataPropertyName = "Seguro"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SeguroDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SeguroDataGridViewTextBoxColumn.HeaderText = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.Name = "SeguroDataGridViewTextBoxColumn"
        Me.SeguroDataGridViewTextBoxColumn.ReadOnly = True
        Me.SeguroDataGridViewTextBoxColumn.Width = 310
        '
        'PensionDataGridViewTextBoxColumn
        '
        Me.PensionDataGridViewTextBoxColumn.DataPropertyName = "Pension"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PensionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PensionDataGridViewTextBoxColumn.HeaderText = "Pension"
        Me.PensionDataGridViewTextBoxColumn.Name = "PensionDataGridViewTextBoxColumn"
        Me.PensionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PensionDataGridViewTextBoxColumn.Width = 280
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 75)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(697, 35)
        Me.SSMensaje.TabIndex = 32
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
        Me.tsslMensaje.Size = New System.Drawing.Size(675, 30)
        Me.tsslMensaje.Text = "Mensaje"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'FillByLeyToolStrip
        '
        Me.FillByLeyToolStrip.AutoSize = False
        Me.FillByLeyToolStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.FillByLeyToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeyToolStripLabel, Me.txtFillLey, Me.btnFillLey})
        Me.FillByLeyToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByLeyToolStrip.Name = "FillByLeyToolStrip"
        Me.FillByLeyToolStrip.Size = New System.Drawing.Size(697, 40)
        Me.FillByLeyToolStrip.TabIndex = 33
        Me.FillByLeyToolStrip.Text = "FillByLeyToolStrip"
        '
        'LeyToolStripLabel
        '
        Me.LeyToolStripLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeyToolStripLabel.ForeColor = System.Drawing.Color.Blue
        Me.LeyToolStripLabel.Name = "LeyToolStripLabel"
        Me.LeyToolStripLabel.Size = New System.Drawing.Size(30, 37)
        Me.LeyToolStripLabel.Text = "Ley:"
        '
        'txtFillLey
        '
        Me.txtFillLey.AutoSize = False
        Me.txtFillLey.BackColor = System.Drawing.Color.White
        Me.txtFillLey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFillLey.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFillLey.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFillLey.Name = "txtFillLey"
        Me.txtFillLey.Size = New System.Drawing.Size(70, 23)
        Me.txtFillLey.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFillLey.ToolTipText = "Filtro x Ley"
        '
        'btnFillLey
        '
        Me.btnFillLey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFillLey.Image = CType(resources.GetObject("btnFillLey.Image"), System.Drawing.Image)
        Me.btnFillLey.Name = "btnFillLey"
        Me.btnFillLey.Size = New System.Drawing.Size(23, 37)
        Me.btnFillLey.Text = "FillByLey"
        Me.btnFillLey.ToolTipText = "FIltro x Ley"
        '
        'LeySegPenTableAdapter
        '
        Me.LeySegPenTableAdapter.ClearBeforeFill = True
        '
        'foSegyPen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(697, 403)
        Me.Controls.Add(Me.FillByLeyToolStrip)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.dgLeySegPen)
        Me.Controls.Add(Me.gbSP)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foSegyPen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Seguros y pensiones IMSS"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.gbSP.ResumeLayout(False)
        Me.gbSP.PerformLayout()
        CType(Me.bsLeySegPen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLeySegPen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.FillByLeyToolStrip.ResumeLayout(False)
        Me.FillByLeyToolStrip.PerformLayout()
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
    Friend WithEvents gbSP As GroupBox
    Friend WithEvents dgLeySegPen As DataGridView
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents cboLey As ComboBox
    Friend WithEvents FillByLeyToolStrip As ToolStrip
    Friend WithEvents LeyToolStripLabel As ToolStripLabel
    Friend WithEvents txtFillLey As ToolStripTextBox
    Friend WithEvents btnFillLey As ToolStripButton
    Friend WithEvents cboPension As ComboBox
    Friend WithEvents cboSeguro As ComboBox
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents bsLeySegPen As BindingSource
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents LeySegPenTableAdapter As dsCatalogosTableAdapters.LeySegPenTableAdapter
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents LeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeguroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

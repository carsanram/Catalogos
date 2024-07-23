<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foActividadesTI
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
        Dim lbl02 As System.Windows.Forms.Label
        Dim lbl04 As System.Windows.Forms.Label
        Dim lbl03 As System.Windows.Forms.Label
        Dim lbl01 As System.Windows.Forms.Label
        Dim lbl05 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foActividadesTI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsBotones = New System.Windows.Forms.ToolStrip()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtPctRT = New System.Windows.Forms.TextBox()
        Me.txtClase = New System.Windows.Forms.TextBox()
        Me.ActividadesTISubActividadesTIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsActividadesTI = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.txtSubActividad = New System.Windows.Forms.TextBox()
        Me.txtActividad = New System.Windows.Forms.TextBox()
        Me.dgSubActividadTI = New System.Windows.Forms.DataGridView()
        Me.Actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgActividadTI = New System.Windows.Forms.DataGridView()
        Me.SubActividadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadesTITableAdapter = New Catalogos.dsCatalogosTableAdapters.ActividadesTITableAdapter()
        Me.bsSubActividad = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubActividadesTITableAdapter = New Catalogos.dsCatalogosTableAdapters.SubActividadesTITableAdapter()
        Me.nudAño = New System.Windows.Forms.NumericUpDown()
        Me.txtSeveridad = New System.Windows.Forms.TextBox()
        Me.bnDivision = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bnGpoPrincipal = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        lbl02 = New System.Windows.Forms.Label()
        lbl04 = New System.Windows.Forms.Label()
        lbl03 = New System.Windows.Forms.Label()
        lbl01 = New System.Windows.Forms.Label()
        lbl05 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        CType(Me.ActividadesTISubActividadesTIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsActividadesTI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSubActividadTI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgActividadTI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSubActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnDivision.SuspendLayout()
        CType(Me.bnGpoPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnGpoPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl02
        '
        lbl02.AutoSize = True
        lbl02.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl02.ForeColor = System.Drawing.Color.Blue
        lbl02.Location = New System.Drawing.Point(9, 162)
        lbl02.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lbl02.Name = "lbl02"
        lbl02.Size = New System.Drawing.Size(72, 15)
        lbl02.TabIndex = 13
        lbl02.Text = "% Seguro RT"
        '
        'lbl04
        '
        lbl04.AutoSize = True
        lbl04.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl04.ForeColor = System.Drawing.Color.Blue
        lbl04.Location = New System.Drawing.Point(93, 109)
        lbl04.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lbl04.Name = "lbl04"
        lbl04.Size = New System.Drawing.Size(37, 15)
        lbl04.TabIndex = 12
        lbl04.Text = "Clase"
        '
        'lbl03
        '
        lbl03.AutoSize = True
        lbl03.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl03.ForeColor = System.Drawing.Color.Blue
        lbl03.Location = New System.Drawing.Point(177, 167)
        lbl03.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lbl03.Name = "lbl03"
        lbl03.Size = New System.Drawing.Size(95, 15)
        lbl03.TabIndex = 11
        lbl03.Text = "Grupo Principal:"
        '
        'lbl01
        '
        lbl01.AutoSize = True
        lbl01.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl01.ForeColor = System.Drawing.Color.Blue
        lbl01.Location = New System.Drawing.Point(220, 115)
        lbl01.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lbl01.Name = "lbl01"
        lbl01.Size = New System.Drawing.Size(52, 15)
        lbl01.TabIndex = 10
        lbl01.Text = "División;"
        '
        'lbl05
        '
        lbl05.AutoSize = True
        lbl05.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl05.ForeColor = System.Drawing.Color.Blue
        lbl05.Location = New System.Drawing.Point(10, 110)
        lbl05.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lbl05.Name = "lbl05"
        lbl05.Size = New System.Drawing.Size(29, 15)
        lbl05.TabIndex = 14
        lbl05.Text = "Año"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(324, 199)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 15)
        Label1.TabIndex = 34
        Label1.Text = "División"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Blue
        Label2.Location = New System.Drawing.Point(302, 275)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(95, 15)
        Label2.TabIndex = 35
        Label2.Text = "Grupo Principal:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Blue
        Label3.Location = New System.Drawing.Point(93, 158)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 15)
        Label3.TabIndex = 37
        Label3.Text = "Severidad"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(819, 40)
        Me.tsBotones.TabIndex = 7
        Me.tsBotones.Text = "tsLey73"
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
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 40)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(819, 35)
        Me.SSMensaje.TabIndex = 28
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
        Me.tsslMensaje.Size = New System.Drawing.Size(800, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 75)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(819, 30)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Catálogo: Actividades Trabajadores Independientes Modalidad 10"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPctRT
        '
        Me.txtPctRT.BackColor = System.Drawing.Color.White
        Me.txtPctRT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPctRT.Location = New System.Drawing.Point(12, 177)
        Me.txtPctRT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPctRT.Name = "txtPctRT"
        Me.txtPctRT.ReadOnly = True
        Me.txtPctRT.Size = New System.Drawing.Size(54, 21)
        Me.txtPctRT.TabIndex = 3
        Me.txtPctRT.TabStop = False
        Me.txtPctRT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClase
        '
        Me.txtClase.BackColor = System.Drawing.Color.White
        Me.txtClase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActividadesTISubActividadesTIBindingSource, "Clase", True))
        Me.txtClase.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClase.Location = New System.Drawing.Point(91, 126)
        Me.txtClase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClase.Name = "txtClase"
        Me.txtClase.ReadOnly = True
        Me.txtClase.Size = New System.Drawing.Size(54, 23)
        Me.txtClase.TabIndex = 4
        Me.txtClase.TabStop = False
        Me.txtClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ActividadesTISubActividadesTIBindingSource
        '
        Me.ActividadesTISubActividadesTIBindingSource.DataMember = "ActividadesTISubActividadesTI"
        Me.ActividadesTISubActividadesTIBindingSource.DataSource = Me.bsActividadesTI
        '
        'bsActividadesTI
        '
        Me.bsActividadesTI.DataMember = "ActividadesTI"
        Me.bsActividadesTI.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSubActividad
        '
        Me.txtSubActividad.BackColor = System.Drawing.Color.White
        Me.txtSubActividad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActividadesTISubActividadesTIBindingSource, "SubActividad", True))
        Me.txtSubActividad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubActividad.Location = New System.Drawing.Point(280, 155)
        Me.txtSubActividad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubActividad.Multiline = True
        Me.txtSubActividad.Name = "txtSubActividad"
        Me.txtSubActividad.ReadOnly = True
        Me.txtSubActividad.Size = New System.Drawing.Size(526, 40)
        Me.txtSubActividad.TabIndex = 2
        Me.txtSubActividad.TabStop = False
        '
        'txtActividad
        '
        Me.txtActividad.BackColor = System.Drawing.Color.White
        Me.txtActividad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsActividadesTI, "Actividad", True))
        Me.txtActividad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividad.Location = New System.Drawing.Point(280, 110)
        Me.txtActividad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActividad.Multiline = True
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.ReadOnly = True
        Me.txtActividad.Size = New System.Drawing.Size(526, 40)
        Me.txtActividad.TabIndex = 1
        Me.txtActividad.TabStop = False
        '
        'dgSubActividadTI
        '
        Me.dgSubActividadTI.AllowUserToAddRows = False
        Me.dgSubActividadTI.AllowUserToDeleteRows = False
        Me.dgSubActividadTI.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgSubActividadTI.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSubActividadTI.AutoGenerateColumns = False
        Me.dgSubActividadTI.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgSubActividadTI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSubActividadTI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSubActividadTI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSubActividadTI.ColumnHeadersVisible = False
        Me.dgSubActividadTI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Actividad, Me.IdDataGridViewTextBoxColumn, Me.ActividadDataGridViewTextBoxColumn})
        Me.dgSubActividadTI.DataSource = Me.bsActividadesTI
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSubActividadTI.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSubActividadTI.GridColor = System.Drawing.Color.SteelBlue
        Me.dgSubActividadTI.Location = New System.Drawing.Point(12, 218)
        Me.dgSubActividadTI.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSubActividadTI.Name = "dgSubActividadTI"
        Me.dgSubActividadTI.ReadOnly = True
        Me.dgSubActividadTI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgSubActividadTI.RowHeadersVisible = False
        Me.dgSubActividadTI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgSubActividadTI.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgSubActividadTI.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgSubActividadTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSubActividadTI.Size = New System.Drawing.Size(794, 25)
        Me.dgSubActividadTI.TabIndex = 2
        Me.dgSubActividadTI.TabStop = False
        '
        'Actividad
        '
        Me.Actividad.DataPropertyName = "Actividad"
        Me.Actividad.HeaderText = "Actividad"
        Me.Actividad.Name = "Actividad"
        Me.Actividad.ReadOnly = True
        Me.Actividad.Width = 850
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActividadDataGridViewTextBoxColumn
        '
        Me.ActividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.HeaderText = "Actividad"
        Me.ActividadDataGridViewTextBoxColumn.Name = "ActividadDataGridViewTextBoxColumn"
        Me.ActividadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dgActividadTI
        '
        Me.dgActividadTI.AllowUserToAddRows = False
        Me.dgActividadTI.AllowUserToDeleteRows = False
        Me.dgActividadTI.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgActividadTI.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgActividadTI.AutoGenerateColumns = False
        Me.dgActividadTI.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgActividadTI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgActividadTI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgActividadTI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgActividadTI.ColumnHeadersVisible = False
        Me.dgActividadTI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubActividadDataGridViewTextBoxColumn1})
        Me.dgActividadTI.DataSource = Me.ActividadesTISubActividadesTIBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgActividadTI.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgActividadTI.GridColor = System.Drawing.Color.SteelBlue
        Me.dgActividadTI.Location = New System.Drawing.Point(12, 294)
        Me.dgActividadTI.Margin = New System.Windows.Forms.Padding(4)
        Me.dgActividadTI.Name = "dgActividadTI"
        Me.dgActividadTI.ReadOnly = True
        Me.dgActividadTI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgActividadTI.RowHeadersVisible = False
        Me.dgActividadTI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.dgActividadTI.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgActividadTI.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgActividadTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgActividadTI.Size = New System.Drawing.Size(794, 130)
        Me.dgActividadTI.TabIndex = 3
        Me.dgActividadTI.TabStop = False
        '
        'SubActividadDataGridViewTextBoxColumn1
        '
        Me.SubActividadDataGridViewTextBoxColumn1.DataPropertyName = "SubActividad"
        Me.SubActividadDataGridViewTextBoxColumn1.HeaderText = "SubActividad"
        Me.SubActividadDataGridViewTextBoxColumn1.Name = "SubActividadDataGridViewTextBoxColumn1"
        Me.SubActividadDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SubActividadDataGridViewTextBoxColumn1.Width = 790
        '
        'ActividadesTITableAdapter
        '
        Me.ActividadesTITableAdapter.ClearBeforeFill = True
        '
        'bsSubActividad
        '
        Me.bsSubActividad.DataMember = "SubActividadesTI"
        Me.bsSubActividad.DataSource = Me.DsCatalogos
        '
        'SubActividadesTITableAdapter
        '
        Me.SubActividadesTITableAdapter.ClearBeforeFill = True
        '
        'nudAño
        '
        Me.nudAño.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAño.Location = New System.Drawing.Point(12, 128)
        Me.nudAño.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudAño.Minimum = New Decimal(New Integer() {2024, 0, 0, 0})
        Me.nudAño.Name = "nudAño"
        Me.nudAño.Size = New System.Drawing.Size(72, 22)
        Me.nudAño.TabIndex = 1
        Me.nudAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudAño.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        '
        'txtSeveridad
        '
        Me.txtSeveridad.BackColor = System.Drawing.Color.Red
        Me.txtSeveridad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeveridad.Location = New System.Drawing.Point(92, 177)
        Me.txtSeveridad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeveridad.Multiline = True
        Me.txtSeveridad.Name = "txtSeveridad"
        Me.txtSeveridad.ReadOnly = True
        Me.txtSeveridad.Size = New System.Drawing.Size(69, 30)
        Me.txtSeveridad.TabIndex = 36
        Me.txtSeveridad.TabStop = False
        Me.txtSeveridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bnDivision
        '
        Me.bnDivision.AddNewItem = Nothing
        Me.bnDivision.AutoSize = False
        Me.bnDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bnDivision.BindingSource = Me.bsActividadesTI
        Me.bnDivision.CountItem = Me.BindingNavigatorCountItem
        Me.bnDivision.DeleteItem = Nothing
        Me.bnDivision.Dock = System.Windows.Forms.DockStyle.None
        Me.bnDivision.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnDivision.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.bnDivision.Location = New System.Drawing.Point(13, 245)
        Me.bnDivision.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnDivision.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnDivision.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnDivision.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnDivision.Name = "bnDivision"
        Me.bnDivision.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnDivision.Size = New System.Drawing.Size(793, 25)
        Me.bnDivision.TabIndex = 38
        Me.bnDivision.Text = "Division"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'bnGpoPrincipal
        '
        Me.bnGpoPrincipal.AddNewItem = Nothing
        Me.bnGpoPrincipal.AutoSize = False
        Me.bnGpoPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bnGpoPrincipal.BindingSource = Me.ActividadesTISubActividadesTIBindingSource
        Me.bnGpoPrincipal.CountItem = Me.ToolStripLabel1
        Me.bnGpoPrincipal.DeleteItem = Nothing
        Me.bnGpoPrincipal.Dock = System.Windows.Forms.DockStyle.None
        Me.bnGpoPrincipal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnGpoPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator5})
        Me.bnGpoPrincipal.Location = New System.Drawing.Point(12, 427)
        Me.bnGpoPrincipal.MoveFirstItem = Me.ToolStripButton1
        Me.bnGpoPrincipal.MoveLastItem = Me.ToolStripButton4
        Me.bnGpoPrincipal.MoveNextItem = Me.ToolStripButton3
        Me.bnGpoPrincipal.MovePreviousItem = Me.ToolStripButton2
        Me.bnGpoPrincipal.Name = "bnGpoPrincipal"
        Me.bnGpoPrincipal.PositionItem = Me.ToolStripTextBox1
        Me.bnGpoPrincipal.Size = New System.Drawing.Size(794, 25)
        Me.bnGpoPrincipal.TabIndex = 39
        Me.bnGpoPrincipal.Text = "Division"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Mover anterior"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Mover siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Mover último"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'foActividadesTI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(819, 465)
        Me.Controls.Add(Me.bnGpoPrincipal)
        Me.Controls.Add(Me.bnDivision)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtSeveridad)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.nudAño)
        Me.Controls.Add(Me.dgActividadTI)
        Me.Controls.Add(lbl05)
        Me.Controls.Add(Me.dgSubActividadTI)
        Me.Controls.Add(Me.txtPctRT)
        Me.Controls.Add(lbl02)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtActividad)
        Me.Controls.Add(lbl01)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.txtClase)
        Me.Controls.Add(Me.tsBotones)
        Me.Controls.Add(lbl03)
        Me.Controls.Add(lbl04)
        Me.Controls.Add(Me.txtSubActividad)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foActividadesTI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actividades Trabajadores Independientes Modalidad 10"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        CType(Me.ActividadesTISubActividadesTIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsActividadesTI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSubActividadTI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgActividadTI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSubActividad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnDivision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnDivision.ResumeLayout(False)
        Me.bnDivision.PerformLayout()
        CType(Me.bnGpoPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnGpoPrincipal.ResumeLayout(False)
        Me.bnGpoPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtPctRT As TextBox
    Friend WithEvents txtClase As TextBox
    Friend WithEvents txtSubActividad As TextBox
    Friend WithEvents txtActividad As TextBox
    Friend WithEvents dgSubActividadTI As DataGridView
    Friend WithEvents bsActividadesTI As BindingSource
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents ActividadesTITableAdapter As dsCatalogosTableAdapters.ActividadesTITableAdapter
    Friend WithEvents dgActividadTI As DataGridView
    Friend WithEvents bsSubActividad As BindingSource
    Friend WithEvents SubActividadesTITableAdapter As dsCatalogosTableAdapters.SubActividadesTITableAdapter
    Friend WithEvents ActividadesTISubActividadesTIBindingSource As BindingSource
    Friend WithEvents nudAño As NumericUpDown
    Friend WithEvents txtSeveridad As TextBox
    Friend WithEvents bnDivision As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents bnGpoPrincipal As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Actividad As DataGridViewTextBoxColumn
    Friend WithEvents SubActividadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActividadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foAfores
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
        Dim lblWeb As System.Windows.Forms.Label
        Dim lblTelefono As System.Windows.Forms.Label
        Dim lblDireccion As System.Windows.Forms.Label
        Dim lblNombre As System.Windows.Forms.Label
        Dim lblContacto As System.Windows.Forms.Label
        Dim lblNotas As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foAfores))
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
        Me.dgAfores = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAfores = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.tsFiltros = New System.Windows.Forms.ToolStrip()
        Me.NombreToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtNombreFiltro = New System.Windows.Forms.ToolStripTextBox()
        Me.BtnFillNombre = New System.Windows.Forms.ToolStripButton()
        Me.mtxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.AforesTableAdapter = New Catalogos.dsCatalogosTableAdapters.AforesTableAdapter()
        lblWeb = New System.Windows.Forms.Label()
        lblTelefono = New System.Windows.Forms.Label()
        lblDireccion = New System.Windows.Forms.Label()
        lblNombre = New System.Windows.Forms.Label()
        lblContacto = New System.Windows.Forms.Label()
        lblNotas = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        CType(Me.dgAfores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAfores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWeb
        '
        lblWeb.AutoSize = True
        lblWeb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWeb.ForeColor = System.Drawing.Color.Blue
        lblWeb.Location = New System.Drawing.Point(64, 231)
        lblWeb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblWeb.Name = "lblWeb"
        lblWeb.Size = New System.Drawing.Size(59, 15)
        lblWeb.TabIndex = 13
        lblWeb.Text = "Sitio Web:"
        '
        'lblTelefono
        '
        lblTelefono.AutoSize = True
        lblTelefono.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTelefono.ForeColor = System.Drawing.Color.Blue
        lblTelefono.Location = New System.Drawing.Point(67, 289)
        lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New System.Drawing.Size(56, 15)
        lblTelefono.TabIndex = 12
        lblTelefono.Text = "Telefono:"
        '
        'lblDireccion
        '
        lblDireccion.AutoSize = True
        lblDireccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDireccion.ForeColor = System.Drawing.Color.Blue
        lblDireccion.Location = New System.Drawing.Point(60, 186)
        lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New System.Drawing.Size(63, 15)
        lblDireccion.TabIndex = 11
        lblDireccion.Text = "Dirección:"
        '
        'lblNombre
        '
        lblNombre.AutoSize = True
        lblNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNombre.ForeColor = System.Drawing.Color.DarkRed
        lblNombre.Location = New System.Drawing.Point(66, 157)
        lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New System.Drawing.Size(53, 15)
        lblNombre.TabIndex = 10
        lblNombre.Text = "Nombre:"
        '
        'lblContacto
        '
        lblContacto.AutoSize = True
        lblContacto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblContacto.ForeColor = System.Drawing.Color.Blue
        lblContacto.Location = New System.Drawing.Point(66, 260)
        lblContacto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblContacto.Name = "lblContacto"
        lblContacto.Size = New System.Drawing.Size(59, 15)
        lblContacto.TabIndex = 16
        lblContacto.Text = "Contacto:"
        '
        'lblNotas
        '
        lblNotas.AutoSize = True
        lblNotas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNotas.ForeColor = System.Drawing.Color.Blue
        lblNotas.Location = New System.Drawing.Point(66, 323)
        lblNotas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblNotas.Name = "lblNotas"
        lblNotas.Size = New System.Drawing.Size(41, 15)
        lblNotas.TabIndex = 18
        lblNotas.Text = "Notas:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(781, 40)
        Me.tsBotones.TabIndex = 4
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
        Me.lblTitulo.Size = New System.Drawing.Size(780, 30)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(2, 80)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(778, 35)
        Me.SSMensaje.TabIndex = 18
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
        Me.tsslMensaje.Size = New System.Drawing.Size(750, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'dgAfores
        '
        Me.dgAfores.AllowUserToAddRows = False
        Me.dgAfores.AllowUserToDeleteRows = False
        Me.dgAfores.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAfores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAfores.AutoGenerateColumns = False
        Me.dgAfores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgAfores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgAfores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAfores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgAfores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAfores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.WebDataGridViewTextBoxColumn})
        Me.dgAfores.DataSource = Me.bsAfores
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAfores.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgAfores.EnableHeadersVisualStyles = False
        Me.dgAfores.GridColor = System.Drawing.Color.SteelBlue
        Me.dgAfores.Location = New System.Drawing.Point(13, 346)
        Me.dgAfores.Margin = New System.Windows.Forms.Padding(4)
        Me.dgAfores.Name = "dgAfores"
        Me.dgAfores.ReadOnly = True
        Me.dgAfores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAfores.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgAfores.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgAfores.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgAfores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAfores.Size = New System.Drawing.Size(749, 89)
        Me.dgAfores.TabIndex = 19
        Me.dgAfores.TabStop = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 250
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 110
        '
        'WebDataGridViewTextBoxColumn
        '
        Me.WebDataGridViewTextBoxColumn.DataPropertyName = "Web"
        Me.WebDataGridViewTextBoxColumn.HeaderText = "Web"
        Me.WebDataGridViewTextBoxColumn.Name = "WebDataGridViewTextBoxColumn"
        Me.WebDataGridViewTextBoxColumn.ReadOnly = True
        Me.WebDataGridViewTextBoxColumn.Width = 280
        '
        'bsAfores
        '
        Me.bsAfores.DataMember = "Afores"
        Me.bsAfores.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tsFiltros
        '
        Me.tsFiltros.AutoSize = False
        Me.tsFiltros.BackColor = System.Drawing.Color.SkyBlue
        Me.tsFiltros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreToolStripLabel, Me.txtNombreFiltro, Me.BtnFillNombre})
        Me.tsFiltros.Location = New System.Drawing.Point(0, 40)
        Me.tsFiltros.Name = "tsFiltros"
        Me.tsFiltros.Size = New System.Drawing.Size(781, 40)
        Me.tsFiltros.TabIndex = 20
        Me.tsFiltros.Text = "FillByNombreToolStrip"
        '
        'NombreToolStripLabel
        '
        Me.NombreToolStripLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreToolStripLabel.ForeColor = System.Drawing.Color.Blue
        Me.NombreToolStripLabel.Name = "NombreToolStripLabel"
        Me.NombreToolStripLabel.Size = New System.Drawing.Size(42, 37)
        Me.NombreToolStripLabel.Text = "Afore:"
        '
        'txtNombreFiltro
        '
        Me.txtNombreFiltro.AutoSize = False
        Me.txtNombreFiltro.BackColor = System.Drawing.Color.White
        Me.txtNombreFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreFiltro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombreFiltro.Name = "txtNombreFiltro"
        Me.txtNombreFiltro.Size = New System.Drawing.Size(116, 23)
        Me.txtNombreFiltro.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNombreFiltro.ToolTipText = "Filltro x Nombre"
        '
        'BtnFillNombre
        '
        Me.BtnFillNombre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFillNombre.Image = Global.Catalogos.My.Resources.Resources.Buscar
        Me.BtnFillNombre.Name = "BtnFillNombre"
        Me.BtnFillNombre.Size = New System.Drawing.Size(23, 37)
        Me.BtnFillNombre.Text = "FillByNombre"
        Me.BtnFillNombre.ToolTipText = "Filtro x Afore"
        '
        'mtxtTelefono
        '
        Me.mtxtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAfores, "Telefono", True))
        Me.mtxtTelefono.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTelefono.Location = New System.Drawing.Point(130, 285)
        Me.mtxtTelefono.Mask = "00-0000-0000"
        Me.mtxtTelefono.Name = "mtxtTelefono"
        Me.mtxtTelefono.Size = New System.Drawing.Size(95, 21)
        Me.mtxtTelefono.TabIndex = 5
        Me.mtxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNotas
        '
        Me.txtNotas.BackColor = System.Drawing.Color.White
        Me.txtNotas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAfores, "Notas", True))
        Me.txtNotas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotas.Location = New System.Drawing.Point(130, 312)
        Me.txtNotas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(587, 26)
        Me.txtNotas.TabIndex = 6
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.Color.White
        Me.txtContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAfores, "Contacto", True))
        Me.txtContacto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(127, 257)
        Me.txtContacto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(590, 21)
        Me.txtContacto.TabIndex = 4
        Me.txtContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAfores, "Nombre", True))
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(127, 154)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(590, 21)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeb
        '
        Me.txtWeb.BackColor = System.Drawing.Color.White
        Me.txtWeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAfores, "Web", True))
        Me.txtWeb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.Location = New System.Drawing.Point(127, 228)
        Me.txtWeb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(590, 21)
        Me.txtWeb.TabIndex = 3
        Me.txtWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAfores, "Direccion", True))
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(127, 183)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(590, 37)
        Me.txtDireccion.TabIndex = 2
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AforesTableAdapter
        '
        Me.AforesTableAdapter.ClearBeforeFill = True
        '
        'foAfores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(781, 457)
        Me.Controls.Add(Me.mtxtTelefono)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.tsFiltros)
        Me.Controls.Add(lblNotas)
        Me.Controls.Add(Me.dgAfores)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(lblContacto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.tsBotones)
        Me.Controls.Add(Me.txtWeb)
        Me.Controls.Add(lblNombre)
        Me.Controls.Add(lblWeb)
        Me.Controls.Add(lblDireccion)
        Me.Controls.Add(lblTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foAfores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Afores"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        CType(Me.dgAfores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAfores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsFiltros.ResumeLayout(False)
        Me.tsFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents dgAfores As DataGridView
    'Friend WithEvents AforesTableAdapter As CatalogosDataSetTableAdapters.AforesTableAdapter
    Friend WithEvents tsFiltros As ToolStrip
    Friend WithEvents NombreToolStripLabel As ToolStripLabel
    Friend WithEvents txtNombreFiltro As ToolStripTextBox
    Friend WithEvents BtnFillNombre As ToolStripButton
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtWeb As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents bsAfores As BindingSource
    Friend WithEvents AforesTableAdapter As dsCatalogosTableAdapters.AforesTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents mtxtTelefono As MaskedTextBox
End Class

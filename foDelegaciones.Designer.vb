<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foDelegaciones
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
        Dim lblSubdelegacion As System.Windows.Forms.Label
        Dim lblUMF As System.Windows.Forms.Label
        Dim lblDelegacion As System.Windows.Forms.Label
        Dim lblEstado As System.Windows.Forms.Label
        Dim lblMunicipio As System.Windows.Forms.Label
        Dim lblLocalidad As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foDelegaciones))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.bsUMF = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.bsEstadosMx = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtSubdelegacion = New System.Windows.Forms.TextBox()
        Me.txtUMF = New System.Windows.Forms.TextBox()
        Me.txtDelegacion = New System.Windows.Forms.TextBox()
        Me.dgUMF = New System.Windows.Forms.DataGridView()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelegacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubdelegacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtFiltroDelegacion = New System.Windows.Forms.ToolStrip()
        Me.tslDelegacion = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilltroDelegacion = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFiltroDelegacion = New System.Windows.Forms.ToolStripButton()
        Me.tslSubDelegacion = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilltroSubDelegacion = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFiltroSubDelegacion = New System.Windows.Forms.ToolStripButton()
        Me.tslUMF = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilltroUMF = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFiltroUMF = New System.Windows.Forms.ToolStripButton()
        Me.UMFTableAdapter = New Catalogos.dsCatalogosTableAdapters.UMFTableAdapter()
        Me.EstadosMxTableAdapter = New Catalogos.dsCatalogosTableAdapters.EstadosMxTableAdapter()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        lblSubdelegacion = New System.Windows.Forms.Label()
        lblUMF = New System.Windows.Forms.Label()
        lblDelegacion = New System.Windows.Forms.Label()
        lblEstado = New System.Windows.Forms.Label()
        lblMunicipio = New System.Windows.Forms.Label()
        lblLocalidad = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        CType(Me.bsUMF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEstadosMx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUMF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SSMensaje.SuspendLayout()
        Me.txtFiltroDelegacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubdelegacion
        '
        lblSubdelegacion.AutoSize = True
        lblSubdelegacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSubdelegacion.ForeColor = System.Drawing.Color.Red
        lblSubdelegacion.Location = New System.Drawing.Point(152, 226)
        lblSubdelegacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSubdelegacion.Name = "lblSubdelegacion"
        lblSubdelegacion.Size = New System.Drawing.Size(92, 15)
        lblSubdelegacion.TabIndex = 13
        lblSubdelegacion.Text = "Subdelegación:"
        '
        'lblUMF
        '
        lblUMF.AutoSize = True
        lblUMF.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUMF.ForeColor = System.Drawing.Color.Red
        lblUMF.Location = New System.Drawing.Point(80, 255)
        lblUMF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblUMF.Name = "lblUMF"
        lblUMF.Size = New System.Drawing.Size(164, 15)
        lblUMF.TabIndex = 12
        lblUMF.Text = "Unidad de Medicina Familiar:"
        '
        'lblDelegacion
        '
        lblDelegacion.AutoSize = True
        lblDelegacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDelegacion.ForeColor = System.Drawing.Color.Red
        lblDelegacion.Location = New System.Drawing.Point(171, 197)
        lblDelegacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDelegacion.Name = "lblDelegacion"
        lblDelegacion.Size = New System.Drawing.Size(73, 15)
        lblDelegacion.TabIndex = 11
        lblDelegacion.Text = "Delegación:"
        '
        'lblEstado
        '
        lblEstado.AutoSize = True
        lblEstado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEstado.ForeColor = System.Drawing.Color.Red
        lblEstado.Location = New System.Drawing.Point(199, 166)
        lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New System.Drawing.Size(45, 15)
        lblEstado.TabIndex = 10
        lblEstado.Text = "Estado:"
        '
        'lblMunicipio
        '
        lblMunicipio.AutoSize = True
        lblMunicipio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMunicipio.ForeColor = System.Drawing.Color.Blue
        lblMunicipio.Location = New System.Drawing.Point(181, 284)
        lblMunicipio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblMunicipio.Name = "lblMunicipio"
        lblMunicipio.Size = New System.Drawing.Size(64, 15)
        lblMunicipio.TabIndex = 14
        lblMunicipio.Text = "Municipio:"
        '
        'lblLocalidad
        '
        lblLocalidad.AutoSize = True
        lblLocalidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLocalidad.ForeColor = System.Drawing.Color.Blue
        lblLocalidad.Location = New System.Drawing.Point(181, 313)
        lblLocalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLocalidad.Name = "lblLocalidad"
        lblLocalidad.Size = New System.Drawing.Size(63, 15)
        lblLocalidad.TabIndex = 16
        lblLocalidad.Text = "Localidad:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(756, 40)
        Me.tsBotones.TabIndex = 7
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
        Me.lblTitulo.Location = New System.Drawing.Point(3, 115)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(753, 30)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUMF, "Estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(395, 163)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(64, 21)
        Me.txtEstado.TabIndex = 28
        Me.txtEstado.Text = "Estado"
        Me.txtEstado.Visible = False
        '
        'bsUMF
        '
        Me.bsUMF.DataMember = "UMF"
        Me.bsUMF.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboEstado
        '
        Me.cboEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUMF, "Estado", True))
        Me.cboEstado.DataSource = Me.bsEstadosMx
        Me.cboEstado.DisplayMember = "Estado"
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(251, 163)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(138, 24)
        Me.cboEstado.TabIndex = 18
        '
        'bsEstadosMx
        '
        Me.bsEstadosMx.DataMember = "EstadosMx"
        Me.bsEstadosMx.DataSource = Me.DsCatalogos
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.White
        Me.txtLocalidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUMF, "Localidad", True))
        Me.txtLocalidad.Location = New System.Drawing.Point(252, 310)
        Me.txtLocalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(372, 21)
        Me.txtLocalidad.TabIndex = 17
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BackColor = System.Drawing.Color.White
        Me.txtMunicipio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUMF, "Municipio", True))
        Me.txtMunicipio.Location = New System.Drawing.Point(252, 281)
        Me.txtMunicipio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(372, 21)
        Me.txtMunicipio.TabIndex = 15
        '
        'txtSubdelegacion
        '
        Me.txtSubdelegacion.BackColor = System.Drawing.Color.White
        Me.txtSubdelegacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUMF, "Subdelegacion", True))
        Me.txtSubdelegacion.Location = New System.Drawing.Point(252, 223)
        Me.txtSubdelegacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubdelegacion.Name = "txtSubdelegacion"
        Me.txtSubdelegacion.Size = New System.Drawing.Size(372, 21)
        Me.txtSubdelegacion.TabIndex = 3
        '
        'txtUMF
        '
        Me.txtUMF.BackColor = System.Drawing.Color.White
        Me.txtUMF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUMF, "UMF", True))
        Me.txtUMF.Location = New System.Drawing.Point(252, 252)
        Me.txtUMF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUMF.Name = "txtUMF"
        Me.txtUMF.Size = New System.Drawing.Size(372, 21)
        Me.txtUMF.TabIndex = 4
        '
        'txtDelegacion
        '
        Me.txtDelegacion.BackColor = System.Drawing.Color.White
        Me.txtDelegacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsUMF, "Delegacion", True))
        Me.txtDelegacion.Location = New System.Drawing.Point(252, 194)
        Me.txtDelegacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDelegacion.Name = "txtDelegacion"
        Me.txtDelegacion.Size = New System.Drawing.Size(372, 21)
        Me.txtDelegacion.TabIndex = 2
        '
        'dgUMF
        '
        Me.dgUMF.AllowUserToAddRows = False
        Me.dgUMF.AllowUserToDeleteRows = False
        Me.dgUMF.AllowUserToOrderColumns = True
        Me.dgUMF.AutoGenerateColumns = False
        Me.dgUMF.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgUMF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUMF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUMF.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgUMF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EstadoDataGridViewTextBoxColumn, Me.DelegacionDataGridViewTextBoxColumn, Me.SubdelegacionDataGridViewTextBoxColumn, Me.UMFDataGridViewTextBoxColumn})
        Me.dgUMF.DataSource = Me.bsUMF
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUMF.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgUMF.EnableHeadersVisualStyles = False
        Me.dgUMF.GridColor = System.Drawing.Color.SkyBlue
        Me.dgUMF.Location = New System.Drawing.Point(31, 339)
        Me.dgUMF.Margin = New System.Windows.Forms.Padding(4)
        Me.dgUMF.Name = "dgUMF"
        Me.dgUMF.ReadOnly = True
        Me.dgUMF.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUMF.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgUMF.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgUMF.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgUMF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUMF.Size = New System.Drawing.Size(712, 105)
        Me.dgUMF.TabIndex = 25
        Me.dgUMF.TabStop = False
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 150
        '
        'DelegacionDataGridViewTextBoxColumn
        '
        Me.DelegacionDataGridViewTextBoxColumn.DataPropertyName = "Delegacion"
        Me.DelegacionDataGridViewTextBoxColumn.HeaderText = "Delegacion"
        Me.DelegacionDataGridViewTextBoxColumn.Name = "DelegacionDataGridViewTextBoxColumn"
        Me.DelegacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DelegacionDataGridViewTextBoxColumn.Width = 150
        '
        'SubdelegacionDataGridViewTextBoxColumn
        '
        Me.SubdelegacionDataGridViewTextBoxColumn.DataPropertyName = "Subdelegacion"
        Me.SubdelegacionDataGridViewTextBoxColumn.HeaderText = "Subdelegacion"
        Me.SubdelegacionDataGridViewTextBoxColumn.Name = "SubdelegacionDataGridViewTextBoxColumn"
        Me.SubdelegacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubdelegacionDataGridViewTextBoxColumn.Width = 200
        '
        'UMFDataGridViewTextBoxColumn
        '
        Me.UMFDataGridViewTextBoxColumn.DataPropertyName = "UMF"
        Me.UMFDataGridViewTextBoxColumn.HeaderText = "UMF"
        Me.UMFDataGridViewTextBoxColumn.Name = "UMFDataGridViewTextBoxColumn"
        Me.UMFDataGridViewTextBoxColumn.ReadOnly = True
        Me.UMFDataGridViewTextBoxColumn.Width = 250
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 80)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(756, 35)
        Me.SSMensaje.TabIndex = 26
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
        Me.tsslMensaje.Size = New System.Drawing.Size(730, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'txtFiltroDelegacion
        '
        Me.txtFiltroDelegacion.AutoSize = False
        Me.txtFiltroDelegacion.BackColor = System.Drawing.Color.SkyBlue
        Me.txtFiltroDelegacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroDelegacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslDelegacion, Me.txtFilltroDelegacion, Me.btnFiltroDelegacion, Me.tslSubDelegacion, Me.txtFilltroSubDelegacion, Me.btnFiltroSubDelegacion, Me.tslUMF, Me.txtFilltroUMF, Me.btnFiltroUMF})
        Me.txtFiltroDelegacion.Location = New System.Drawing.Point(0, 40)
        Me.txtFiltroDelegacion.Name = "txtFiltroDelegacion"
        Me.txtFiltroDelegacion.Size = New System.Drawing.Size(756, 40)
        Me.txtFiltroDelegacion.TabIndex = 27
        Me.txtFiltroDelegacion.Text = "FillByEstadoToolStrip"
        '
        'tslDelegacion
        '
        Me.tslDelegacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslDelegacion.ForeColor = System.Drawing.Color.Blue
        Me.tslDelegacion.Name = "tslDelegacion"
        Me.tslDelegacion.Size = New System.Drawing.Size(73, 37)
        Me.tslDelegacion.Text = "Delegación:"
        '
        'txtFilltroDelegacion
        '
        Me.txtFilltroDelegacion.AutoSize = False
        Me.txtFilltroDelegacion.BackColor = System.Drawing.Color.White
        Me.txtFilltroDelegacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilltroDelegacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilltroDelegacion.Name = "txtFilltroDelegacion"
        Me.txtFilltroDelegacion.Size = New System.Drawing.Size(120, 23)
        Me.txtFilltroDelegacion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilltroDelegacion.ToolTipText = "Filtro x Delegación"
        '
        'btnFiltroDelegacion
        '
        Me.btnFiltroDelegacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltroDelegacion.Image = CType(resources.GetObject("btnFiltroDelegacion.Image"), System.Drawing.Image)
        Me.btnFiltroDelegacion.Name = "btnFiltroDelegacion"
        Me.btnFiltroDelegacion.Size = New System.Drawing.Size(23, 37)
        Me.btnFiltroDelegacion.Text = "FillByEstado"
        Me.btnFiltroDelegacion.ToolTipText = "Filtro x Delegación"
        '
        'tslSubDelegacion
        '
        Me.tslSubDelegacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslSubDelegacion.ForeColor = System.Drawing.Color.Blue
        Me.tslSubDelegacion.Name = "tslSubDelegacion"
        Me.tslSubDelegacion.Size = New System.Drawing.Size(93, 37)
        Me.tslSubDelegacion.Text = "SubDelegación:"
        '
        'txtFilltroSubDelegacion
        '
        Me.txtFilltroSubDelegacion.AutoSize = False
        Me.txtFilltroSubDelegacion.BackColor = System.Drawing.Color.White
        Me.txtFilltroSubDelegacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilltroSubDelegacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilltroSubDelegacion.Name = "txtFilltroSubDelegacion"
        Me.txtFilltroSubDelegacion.Size = New System.Drawing.Size(120, 23)
        Me.txtFilltroSubDelegacion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilltroSubDelegacion.ToolTipText = "Filtro x Subdelegación"
        '
        'btnFiltroSubDelegacion
        '
        Me.btnFiltroSubDelegacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltroSubDelegacion.Image = CType(resources.GetObject("btnFiltroSubDelegacion.Image"), System.Drawing.Image)
        Me.btnFiltroSubDelegacion.Name = "btnFiltroSubDelegacion"
        Me.btnFiltroSubDelegacion.Size = New System.Drawing.Size(23, 37)
        Me.btnFiltroSubDelegacion.Text = "FillByEstado"
        Me.btnFiltroSubDelegacion.ToolTipText = "Filtro x Subdelegación"
        '
        'tslUMF
        '
        Me.tslUMF.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslUMF.ForeColor = System.Drawing.Color.Blue
        Me.tslUMF.Name = "tslUMF"
        Me.tslUMF.Size = New System.Drawing.Size(33, 37)
        Me.tslUMF.Text = "UMF:"
        '
        'txtFilltroUMF
        '
        Me.txtFilltroUMF.AutoSize = False
        Me.txtFilltroUMF.BackColor = System.Drawing.Color.White
        Me.txtFilltroUMF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilltroUMF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilltroUMF.Name = "txtFilltroUMF"
        Me.txtFilltroUMF.Size = New System.Drawing.Size(120, 23)
        Me.txtFilltroUMF.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFilltroUMF.ToolTipText = "Filtro x Unidad de Medicina Familiar"
        '
        'btnFiltroUMF
        '
        Me.btnFiltroUMF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFiltroUMF.Image = CType(resources.GetObject("btnFiltroUMF.Image"), System.Drawing.Image)
        Me.btnFiltroUMF.Name = "btnFiltroUMF"
        Me.btnFiltroUMF.Size = New System.Drawing.Size(23, 37)
        Me.btnFiltroUMF.Text = "FillByEstado"
        Me.btnFiltroUMF.ToolTipText = "Filtro x UMF"
        '
        'UMFTableAdapter
        '
        Me.UMFTableAdapter.ClearBeforeFill = True
        '
        'EstadosMxTableAdapter
        '
        Me.EstadosMxTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AforesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuantiasLey1973arTableAdapter = Nothing
        Me.TableAdapterManager.CuantiasLey1973TableAdapter = Nothing
        Me.TableAdapterManager.CuantiasLey1997TableAdapter = Nothing
        Me.TableAdapterManager.DespachoTableAdapter = Nothing
        Me.TableAdapterManager.EstadosMxTableAdapter = Me.EstadosMxTableAdapter
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
        Me.TableAdapterManager.UMFTableAdapter = Me.UMFTableAdapter
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'foDelegaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(756, 457)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtFiltroDelegacion)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.dgUMF)
        Me.Controls.Add(lblLocalidad)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(lblMunicipio)
        Me.Controls.Add(Me.tsBotones)
        Me.Controls.Add(Me.txtSubdelegacion)
        Me.Controls.Add(lblEstado)
        Me.Controls.Add(Me.txtUMF)
        Me.Controls.Add(lblDelegacion)
        Me.Controls.Add(Me.txtDelegacion)
        Me.Controls.Add(lblUMF)
        Me.Controls.Add(lblSubdelegacion)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foDelegaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo Delegaciones, Subdelegaciones y Clinicas"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        CType(Me.bsUMF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEstadosMx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUMF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.txtFiltroDelegacion.ResumeLayout(False)
        Me.txtFiltroDelegacion.PerformLayout()
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
    Friend WithEvents txtSubdelegacion As TextBox
    Friend WithEvents txtUMF As TextBox
    Friend WithEvents txtDelegacion As TextBox
    Friend WithEvents dgUMF As DataGridView
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtLocalidad As TextBox
    'Friend WithEvents UMFTableAdapter As CatalogosDataSetTableAdapters.UMFTableAdapter
    Friend WithEvents txtFiltroDelegacion As ToolStrip
    Friend WithEvents tslDelegacion As ToolStripLabel
    Friend WithEvents txtFilltroDelegacion As ToolStripTextBox
    Friend WithEvents btnFiltroDelegacion As ToolStripButton
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents bsUMF As BindingSource
    Friend WithEvents UMFTableAdapter As dsCatalogosTableAdapters.UMFTableAdapter
    Friend WithEvents tslSubDelegacion As ToolStripLabel
    Friend WithEvents txtFilltroSubDelegacion As ToolStripTextBox
    Friend WithEvents btnFiltroSubDelegacion As ToolStripButton
    Friend WithEvents tslUMF As ToolStripLabel
    Friend WithEvents txtFilltroUMF As ToolStripTextBox
    Friend WithEvents btnFiltroUMF As ToolStripButton
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelegacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubdelegacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UMFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsEstadosMx As BindingSource
    Friend WithEvents EstadosMxTableAdapter As dsCatalogosTableAdapters.EstadosMxTableAdapter
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
End Class

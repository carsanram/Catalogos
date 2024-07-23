<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foModalidades
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
        Dim TipoRegimenLabel As System.Windows.Forms.Label
        Dim ModalidadLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim S_RTLabel As System.Windows.Forms.Label
        Dim S_ELabel As System.Windows.Forms.Label
        Dim S_MLabel As System.Windows.Forms.Label
        Dim S_ILabel As System.Windows.Forms.Label
        Dim S_VLabel As System.Windows.Forms.Label
        Dim S_RLabel As System.Windows.Forms.Label
        Dim S_CLabel As System.Windows.Forms.Label
        Dim S_VeLabel As System.Windows.Forms.Label
        Dim S_GLabel As System.Windows.Forms.Label
        Dim S_PSLabel As System.Windows.Forms.Label
        Dim DS_ELabel As System.Windows.Forms.Label
        Dim DS_MLabel As System.Windows.Forms.Label
        Dim DS_RTLabel As System.Windows.Forms.Label
        Dim AplicaPensionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foModalidades))
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
        Me.FillByModalidadToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ModalidadToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtModalidadFind = New System.Windows.Forms.ToolStripTextBox()
        Me.btnModalidadFiltro = New System.Windows.Forms.ToolStripButton()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgRegimenIMSS = New System.Windows.Forms.DataGridView()
        Me.TipoRegimenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SVeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DSMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DSRTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AplicaPensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsRegimen = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.RegimenIMSSTableAdapter = New Catalogos.dsCatalogosTableAdapters.RegimenIMSSTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        Me.cboTipoRegimen = New System.Windows.Forms.ComboBox()
        Me.txtModalidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboS_RT = New System.Windows.Forms.ComboBox()
        Me.cboS_E = New System.Windows.Forms.ComboBox()
        Me.cboS_M = New System.Windows.Forms.ComboBox()
        Me.cboS_I = New System.Windows.Forms.ComboBox()
        Me.cboS_V = New System.Windows.Forms.ComboBox()
        Me.cboS_R = New System.Windows.Forms.ComboBox()
        Me.cboS_C = New System.Windows.Forms.ComboBox()
        Me.cboS_Ve = New System.Windows.Forms.ComboBox()
        Me.cboS_G = New System.Windows.Forms.ComboBox()
        Me.cboS_PS = New System.Windows.Forms.ComboBox()
        Me.cboDS_E = New System.Windows.Forms.ComboBox()
        Me.cboDS_M = New System.Windows.Forms.ComboBox()
        Me.cboDS_RT = New System.Windows.Forms.ComboBox()
        Me.txtAplicaPension = New System.Windows.Forms.TextBox()
        TipoRegimenLabel = New System.Windows.Forms.Label()
        ModalidadLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        S_RTLabel = New System.Windows.Forms.Label()
        S_ELabel = New System.Windows.Forms.Label()
        S_MLabel = New System.Windows.Forms.Label()
        S_ILabel = New System.Windows.Forms.Label()
        S_VLabel = New System.Windows.Forms.Label()
        S_RLabel = New System.Windows.Forms.Label()
        S_CLabel = New System.Windows.Forms.Label()
        S_VeLabel = New System.Windows.Forms.Label()
        S_GLabel = New System.Windows.Forms.Label()
        S_PSLabel = New System.Windows.Forms.Label()
        DS_ELabel = New System.Windows.Forms.Label()
        DS_MLabel = New System.Windows.Forms.Label()
        DS_RTLabel = New System.Windows.Forms.Label()
        AplicaPensionLabel = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.FillByModalidadToolStrip.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        CType(Me.dgRegimenIMSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRegimen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoRegimenLabel
        '
        TipoRegimenLabel.AutoSize = True
        TipoRegimenLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoRegimenLabel.ForeColor = System.Drawing.Color.Maroon
        TipoRegimenLabel.Location = New System.Drawing.Point(48, 156)
        TipoRegimenLabel.Name = "TipoRegimenLabel"
        TipoRegimenLabel.Size = New System.Drawing.Size(57, 15)
        TipoRegimenLabel.TabIndex = 27
        TipoRegimenLabel.Text = "Regimen:"
        '
        'ModalidadLabel
        '
        ModalidadLabel.AutoSize = True
        ModalidadLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModalidadLabel.ForeColor = System.Drawing.Color.Maroon
        ModalidadLabel.Location = New System.Drawing.Point(204, 157)
        ModalidadLabel.Name = "ModalidadLabel"
        ModalidadLabel.Size = New System.Drawing.Size(68, 15)
        ModalidadLabel.TabIndex = 28
        ModalidadLabel.Text = "Modalidad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.ForeColor = System.Drawing.Color.Blue
        DescripcionLabel.Location = New System.Drawing.Point(335, 157)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(75, 15)
        DescripcionLabel.TabIndex = 29
        DescripcionLabel.Text = "Descripcion:"
        '
        'S_RTLabel
        '
        S_RTLabel.AutoSize = True
        S_RTLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_RTLabel.ForeColor = System.Drawing.Color.Blue
        S_RTLabel.Location = New System.Drawing.Point(48, 187)
        S_RTLabel.Name = "S_RTLabel"
        S_RTLabel.Size = New System.Drawing.Size(108, 15)
        S_RTLabel.TabIndex = 30
        S_RTLabel.Text = "Riesgos de Trabajo"
        '
        'S_ELabel
        '
        S_ELabel.AutoSize = True
        S_ELabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_ELabel.ForeColor = System.Drawing.Color.Blue
        S_ELabel.Location = New System.Drawing.Point(208, 187)
        S_ELabel.Name = "S_ELabel"
        S_ELabel.Size = New System.Drawing.Size(74, 15)
        S_ELabel.TabIndex = 31
        S_ELabel.Text = "Enfermedad:"
        '
        'S_MLabel
        '
        S_MLabel.AutoSize = True
        S_MLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_MLabel.ForeColor = System.Drawing.Color.Blue
        S_MLabel.Location = New System.Drawing.Point(334, 187)
        S_MLabel.Name = "S_MLabel"
        S_MLabel.Size = New System.Drawing.Size(72, 15)
        S_MLabel.TabIndex = 32
        S_MLabel.Text = "Maternidad:"
        '
        'S_ILabel
        '
        S_ILabel.AutoSize = True
        S_ILabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_ILabel.ForeColor = System.Drawing.Color.Blue
        S_ILabel.Location = New System.Drawing.Point(458, 187)
        S_ILabel.Name = "S_ILabel"
        S_ILabel.Size = New System.Drawing.Size(57, 15)
        S_ILabel.TabIndex = 33
        S_ILabel.Text = "Invalidez:"
        '
        'S_VLabel
        '
        S_VLabel.AutoSize = True
        S_VLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_VLabel.ForeColor = System.Drawing.Color.Blue
        S_VLabel.Location = New System.Drawing.Point(567, 187)
        S_VLabel.Name = "S_VLabel"
        S_VLabel.Size = New System.Drawing.Size(35, 15)
        S_VLabel.TabIndex = 34
        S_VLabel.Text = "Vida;"
        '
        'S_RLabel
        '
        S_RLabel.AutoSize = True
        S_RLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_RLabel.ForeColor = System.Drawing.Color.Blue
        S_RLabel.Location = New System.Drawing.Point(654, 187)
        S_RLabel.Name = "S_RLabel"
        S_RLabel.Size = New System.Drawing.Size(41, 15)
        S_RLabel.TabIndex = 35
        S_RLabel.Text = "Retiro:"
        '
        'S_CLabel
        '
        S_CLabel.AutoSize = True
        S_CLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_CLabel.ForeColor = System.Drawing.Color.Blue
        S_CLabel.Location = New System.Drawing.Point(747, 187)
        S_CLabel.Name = "S_CLabel"
        S_CLabel.Size = New System.Drawing.Size(57, 15)
        S_CLabel.TabIndex = 36
        S_CLabel.Text = "Cesantia:"
        '
        'S_VeLabel
        '
        S_VeLabel.AutoSize = True
        S_VeLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_VeLabel.ForeColor = System.Drawing.Color.Blue
        S_VeLabel.Location = New System.Drawing.Point(856, 186)
        S_VeLabel.Name = "S_VeLabel"
        S_VeLabel.Size = New System.Drawing.Size(40, 15)
        S_VeLabel.TabIndex = 37
        S_VeLabel.Text = "Vejez:"
        '
        'S_GLabel
        '
        S_GLabel.AutoSize = True
        S_GLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_GLabel.ForeColor = System.Drawing.Color.Blue
        S_GLabel.Location = New System.Drawing.Point(948, 187)
        S_GLabel.Name = "S_GLabel"
        S_GLabel.Size = New System.Drawing.Size(65, 15)
        S_GLabel.TabIndex = 38
        S_GLabel.Text = "Guarderia:"
        '
        'S_PSLabel
        '
        S_PSLabel.AutoSize = True
        S_PSLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        S_PSLabel.ForeColor = System.Drawing.Color.Blue
        S_PSLabel.Location = New System.Drawing.Point(1064, 187)
        S_PSLabel.Name = "S_PSLabel"
        S_PSLabel.Size = New System.Drawing.Size(127, 15)
        S_PSLabel.TabIndex = 39
        S_PSLabel.Text = "Prestaciones Sociales:"
        '
        'DS_ELabel
        '
        DS_ELabel.AutoSize = True
        DS_ELabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DS_ELabel.ForeColor = System.Drawing.Color.Blue
        DS_ELabel.Location = New System.Drawing.Point(48, 222)
        DS_ELabel.Name = "DS_ELabel"
        DS_ELabel.Size = New System.Drawing.Size(122, 15)
        DS_ELabel.TabIndex = 40
        DS_ELabel.Text = "Sunsidio Enfermedad:"
        '
        'DS_MLabel
        '
        DS_MLabel.AutoSize = True
        DS_MLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DS_MLabel.ForeColor = System.Drawing.Color.Blue
        DS_MLabel.Location = New System.Drawing.Point(222, 222)
        DS_MLabel.Name = "DS_MLabel"
        DS_MLabel.Size = New System.Drawing.Size(120, 15)
        DS_MLabel.TabIndex = 41
        DS_MLabel.Text = "Subsidio Maternidad:"
        '
        'DS_RTLabel
        '
        DS_RTLabel.AutoSize = True
        DS_RTLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DS_RTLabel.ForeColor = System.Drawing.Color.Blue
        DS_RTLabel.Location = New System.Drawing.Point(394, 222)
        DS_RTLabel.Name = "DS_RTLabel"
        DS_RTLabel.Size = New System.Drawing.Size(159, 15)
        DS_RTLabel.TabIndex = 42
        DS_RTLabel.Text = "Subsidio Riesgos de Trabajo:"
        '
        'AplicaPensionLabel
        '
        AplicaPensionLabel.AutoSize = True
        AplicaPensionLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AplicaPensionLabel.ForeColor = System.Drawing.Color.Blue
        AplicaPensionLabel.Location = New System.Drawing.Point(605, 222)
        AplicaPensionLabel.Name = "AplicaPensionLabel"
        AplicaPensionLabel.Size = New System.Drawing.Size(91, 15)
        AplicaPensionLabel.TabIndex = 43
        AplicaPensionLabel.Text = "Aplica Pension:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(1286, 40)
        Me.tsBotones.TabIndex = 6
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
        'FillByModalidadToolStrip
        '
        Me.FillByModalidadToolStrip.AutoSize = False
        Me.FillByModalidadToolStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.FillByModalidadToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModalidadToolStripLabel, Me.txtModalidadFind, Me.btnModalidadFiltro})
        Me.FillByModalidadToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByModalidadToolStrip.Name = "FillByModalidadToolStrip"
        Me.FillByModalidadToolStrip.Size = New System.Drawing.Size(1286, 40)
        Me.FillByModalidadToolStrip.TabIndex = 23
        Me.FillByModalidadToolStrip.Text = "FillByModalidadToolStrip"
        '
        'ModalidadToolStripLabel
        '
        Me.ModalidadToolStripLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModalidadToolStripLabel.ForeColor = System.Drawing.Color.Blue
        Me.ModalidadToolStripLabel.Name = "ModalidadToolStripLabel"
        Me.ModalidadToolStripLabel.Size = New System.Drawing.Size(68, 37)
        Me.ModalidadToolStripLabel.Text = "Modalidad:"
        '
        'txtModalidadFind
        '
        Me.txtModalidadFind.AutoSize = False
        Me.txtModalidadFind.BackColor = System.Drawing.Color.White
        Me.txtModalidadFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModalidadFind.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtModalidadFind.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModalidadFind.Name = "txtModalidadFind"
        Me.txtModalidadFind.Padding = New System.Windows.Forms.Padding(2)
        Me.txtModalidadFind.Size = New System.Drawing.Size(30, 23)
        Me.txtModalidadFind.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtModalidadFind.ToolTipText = "Filtro x Modalidad"
        '
        'btnModalidadFiltro
        '
        Me.btnModalidadFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnModalidadFiltro.Image = CType(resources.GetObject("btnModalidadFiltro.Image"), System.Drawing.Image)
        Me.btnModalidadFiltro.Name = "btnModalidadFiltro"
        Me.btnModalidadFiltro.Size = New System.Drawing.Size(23, 37)
        Me.btnModalidadFiltro.Text = "FillByModalidad"
        Me.btnModalidadFiltro.ToolTipText = "Filtro x Modalidad"
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 80)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(1286, 35)
        Me.SSMensaje.TabIndex = 24
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
        Me.tsslMensaje.Size = New System.Drawing.Size(1240, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 115)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1286, 30)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgRegimenIMSS
        '
        Me.dgRegimenIMSS.AllowUserToAddRows = False
        Me.dgRegimenIMSS.AllowUserToDeleteRows = False
        Me.dgRegimenIMSS.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRegimenIMSS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgRegimenIMSS.AutoGenerateColumns = False
        Me.dgRegimenIMSS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgRegimenIMSS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRegimenIMSS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgRegimenIMSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegimenIMSS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoRegimenDataGridViewTextBoxColumn, Me.ModalidadDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.SRTDataGridViewTextBoxColumn, Me.SEDataGridViewTextBoxColumn, Me.SMDataGridViewTextBoxColumn, Me.SIDataGridViewTextBoxColumn, Me.SVDataGridViewTextBoxColumn, Me.SRDataGridViewTextBoxColumn, Me.SCDataGridViewTextBoxColumn, Me.SVeDataGridViewTextBoxColumn, Me.SGDataGridViewTextBoxColumn, Me.SPSDataGridViewTextBoxColumn, Me.DSEDataGridViewTextBoxColumn, Me.DSMDataGridViewTextBoxColumn, Me.DSRTDataGridViewTextBoxColumn, Me.AplicaPensionDataGridViewTextBoxColumn})
        Me.dgRegimenIMSS.DataSource = Me.bsRegimen
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRegimenIMSS.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgRegimenIMSS.EnableHeadersVisualStyles = False
        Me.dgRegimenIMSS.GridColor = System.Drawing.Color.SteelBlue
        Me.dgRegimenIMSS.Location = New System.Drawing.Point(13, 251)
        Me.dgRegimenIMSS.Margin = New System.Windows.Forms.Padding(4)
        Me.dgRegimenIMSS.Name = "dgRegimenIMSS"
        Me.dgRegimenIMSS.ReadOnly = True
        Me.dgRegimenIMSS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRegimenIMSS.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgRegimenIMSS.RowHeadersVisible = False
        Me.dgRegimenIMSS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRegimenIMSS.Size = New System.Drawing.Size(1260, 193)
        Me.dgRegimenIMSS.TabIndex = 26
        '
        'TipoRegimenDataGridViewTextBoxColumn
        '
        Me.TipoRegimenDataGridViewTextBoxColumn.DataPropertyName = "TipoRegimen"
        Me.TipoRegimenDataGridViewTextBoxColumn.HeaderText = "Regimen"
        Me.TipoRegimenDataGridViewTextBoxColumn.Name = "TipoRegimenDataGridViewTextBoxColumn"
        Me.TipoRegimenDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoRegimenDataGridViewTextBoxColumn.Width = 70
        '
        'ModalidadDataGridViewTextBoxColumn
        '
        Me.ModalidadDataGridViewTextBoxColumn.DataPropertyName = "Modalidad"
        Me.ModalidadDataGridViewTextBoxColumn.HeaderText = "Modalidad"
        Me.ModalidadDataGridViewTextBoxColumn.Name = "ModalidadDataGridViewTextBoxColumn"
        Me.ModalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModalidadDataGridViewTextBoxColumn.Width = 75
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 250
        '
        'SRTDataGridViewTextBoxColumn
        '
        Me.SRTDataGridViewTextBoxColumn.DataPropertyName = "S-RT"
        Me.SRTDataGridViewTextBoxColumn.HeaderText = "Riesgos de Trabajo"
        Me.SRTDataGridViewTextBoxColumn.Name = "SRTDataGridViewTextBoxColumn"
        Me.SRTDataGridViewTextBoxColumn.ReadOnly = True
        Me.SRTDataGridViewTextBoxColumn.Width = 70
        '
        'SEDataGridViewTextBoxColumn
        '
        Me.SEDataGridViewTextBoxColumn.DataPropertyName = "S-E"
        Me.SEDataGridViewTextBoxColumn.HeaderText = "Enfermedad"
        Me.SEDataGridViewTextBoxColumn.Name = "SEDataGridViewTextBoxColumn"
        Me.SEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SEDataGridViewTextBoxColumn.Width = 80
        '
        'SMDataGridViewTextBoxColumn
        '
        Me.SMDataGridViewTextBoxColumn.DataPropertyName = "S-M"
        Me.SMDataGridViewTextBoxColumn.HeaderText = "Maternidad"
        Me.SMDataGridViewTextBoxColumn.Name = "SMDataGridViewTextBoxColumn"
        Me.SMDataGridViewTextBoxColumn.ReadOnly = True
        Me.SMDataGridViewTextBoxColumn.Width = 75
        '
        'SIDataGridViewTextBoxColumn
        '
        Me.SIDataGridViewTextBoxColumn.DataPropertyName = "S-I"
        Me.SIDataGridViewTextBoxColumn.HeaderText = "Invalidez"
        Me.SIDataGridViewTextBoxColumn.Name = "SIDataGridViewTextBoxColumn"
        Me.SIDataGridViewTextBoxColumn.ReadOnly = True
        Me.SIDataGridViewTextBoxColumn.Width = 70
        '
        'SVDataGridViewTextBoxColumn
        '
        Me.SVDataGridViewTextBoxColumn.DataPropertyName = "S-V"
        Me.SVDataGridViewTextBoxColumn.HeaderText = "Vida"
        Me.SVDataGridViewTextBoxColumn.Name = "SVDataGridViewTextBoxColumn"
        Me.SVDataGridViewTextBoxColumn.ReadOnly = True
        Me.SVDataGridViewTextBoxColumn.Width = 50
        '
        'SRDataGridViewTextBoxColumn
        '
        Me.SRDataGridViewTextBoxColumn.DataPropertyName = "S-R"
        Me.SRDataGridViewTextBoxColumn.HeaderText = "Retiro"
        Me.SRDataGridViewTextBoxColumn.Name = "SRDataGridViewTextBoxColumn"
        Me.SRDataGridViewTextBoxColumn.ReadOnly = True
        Me.SRDataGridViewTextBoxColumn.Width = 50
        '
        'SCDataGridViewTextBoxColumn
        '
        Me.SCDataGridViewTextBoxColumn.DataPropertyName = "S-C"
        Me.SCDataGridViewTextBoxColumn.HeaderText = "Cesantía"
        Me.SCDataGridViewTextBoxColumn.Name = "SCDataGridViewTextBoxColumn"
        Me.SCDataGridViewTextBoxColumn.ReadOnly = True
        Me.SCDataGridViewTextBoxColumn.Width = 60
        '
        'SVeDataGridViewTextBoxColumn
        '
        Me.SVeDataGridViewTextBoxColumn.DataPropertyName = "S-Ve"
        Me.SVeDataGridViewTextBoxColumn.HeaderText = "Vejez"
        Me.SVeDataGridViewTextBoxColumn.Name = "SVeDataGridViewTextBoxColumn"
        Me.SVeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SVeDataGridViewTextBoxColumn.Width = 50
        '
        'SGDataGridViewTextBoxColumn
        '
        Me.SGDataGridViewTextBoxColumn.DataPropertyName = "S-G"
        Me.SGDataGridViewTextBoxColumn.HeaderText = "Guarderias"
        Me.SGDataGridViewTextBoxColumn.Name = "SGDataGridViewTextBoxColumn"
        Me.SGDataGridViewTextBoxColumn.ReadOnly = True
        Me.SGDataGridViewTextBoxColumn.Width = 75
        '
        'SPSDataGridViewTextBoxColumn
        '
        Me.SPSDataGridViewTextBoxColumn.DataPropertyName = "S-PS"
        Me.SPSDataGridViewTextBoxColumn.HeaderText = "Prestaciones Sociales"
        Me.SPSDataGridViewTextBoxColumn.Name = "SPSDataGridViewTextBoxColumn"
        Me.SPSDataGridViewTextBoxColumn.ReadOnly = True
        Me.SPSDataGridViewTextBoxColumn.Width = 90
        '
        'DSEDataGridViewTextBoxColumn
        '
        Me.DSEDataGridViewTextBoxColumn.DataPropertyName = "DS-E"
        Me.DSEDataGridViewTextBoxColumn.HeaderText = "Subsidio Enfermedad"
        Me.DSEDataGridViewTextBoxColumn.Name = "DSEDataGridViewTextBoxColumn"
        Me.DSEDataGridViewTextBoxColumn.ReadOnly = True
        Me.DSEDataGridViewTextBoxColumn.Width = 80
        '
        'DSMDataGridViewTextBoxColumn
        '
        Me.DSMDataGridViewTextBoxColumn.DataPropertyName = "DS-M"
        Me.DSMDataGridViewTextBoxColumn.HeaderText = "Subsidio Maternidad"
        Me.DSMDataGridViewTextBoxColumn.Name = "DSMDataGridViewTextBoxColumn"
        Me.DSMDataGridViewTextBoxColumn.ReadOnly = True
        Me.DSMDataGridViewTextBoxColumn.Width = 75
        '
        'DSRTDataGridViewTextBoxColumn
        '
        Me.DSRTDataGridViewTextBoxColumn.DataPropertyName = "DS-RT"
        Me.DSRTDataGridViewTextBoxColumn.HeaderText = "Subsidio Riesgos de Trabajo"
        Me.DSRTDataGridViewTextBoxColumn.Name = "DSRTDataGridViewTextBoxColumn"
        Me.DSRTDataGridViewTextBoxColumn.ReadOnly = True
        Me.DSRTDataGridViewTextBoxColumn.Width = 90
        '
        'AplicaPensionDataGridViewTextBoxColumn
        '
        Me.AplicaPensionDataGridViewTextBoxColumn.DataPropertyName = "AplicaPension"
        Me.AplicaPensionDataGridViewTextBoxColumn.HeaderText = "Aplica Pension"
        Me.AplicaPensionDataGridViewTextBoxColumn.Name = "AplicaPensionDataGridViewTextBoxColumn"
        Me.AplicaPensionDataGridViewTextBoxColumn.ReadOnly = True
        Me.AplicaPensionDataGridViewTextBoxColumn.Width = 250
        '
        'bsRegimen
        '
        Me.bsRegimen.DataMember = "RegimenIMSS"
        Me.bsRegimen.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegimenIMSSTableAdapter
        '
        Me.RegimenIMSSTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 27
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
        Me.TableAdapterManager.RegimenIMSSTableAdapter = Me.RegimenIMSSTableAdapter
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.TopadoSMG_UMATableAdapter = Nothing
        Me.TableAdapterManager.UMATableAdapter = Nothing
        Me.TableAdapterManager.UMFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cboTipoRegimen
        '
        Me.cboTipoRegimen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "TipoRegimen", True))
        Me.cboTipoRegimen.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoRegimen.FormattingEnabled = True
        Me.cboTipoRegimen.Items.AddRange(New Object() {"Obligatorio", "Voluntario"})
        Me.cboTipoRegimen.Location = New System.Drawing.Point(111, 153)
        Me.cboTipoRegimen.Name = "cboTipoRegimen"
        Me.cboTipoRegimen.Size = New System.Drawing.Size(83, 23)
        Me.cboTipoRegimen.TabIndex = 28
        '
        'txtModalidad
        '
        Me.txtModalidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "Modalidad", True))
        Me.txtModalidad.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModalidad.Location = New System.Drawing.Point(278, 154)
        Me.txtModalidad.Name = "txtModalidad"
        Me.txtModalidad.Size = New System.Drawing.Size(35, 21)
        Me.txtModalidad.TabIndex = 29
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "Descripcion", True))
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(418, 154)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(819, 21)
        Me.txtDescripcion.TabIndex = 30
        '
        'cboS_RT
        '
        Me.cboS_RT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-RT", True))
        Me.cboS_RT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_RT.ForeColor = System.Drawing.Color.Black
        Me.cboS_RT.FormattingEnabled = True
        Me.cboS_RT.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_RT.Location = New System.Drawing.Point(162, 184)
        Me.cboS_RT.Name = "cboS_RT"
        Me.cboS_RT.Size = New System.Drawing.Size(40, 23)
        Me.cboS_RT.TabIndex = 31
        '
        'cboS_E
        '
        Me.cboS_E.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-E", True))
        Me.cboS_E.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_E.FormattingEnabled = True
        Me.cboS_E.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_E.Location = New System.Drawing.Point(288, 184)
        Me.cboS_E.Name = "cboS_E"
        Me.cboS_E.Size = New System.Drawing.Size(40, 23)
        Me.cboS_E.TabIndex = 32
        '
        'cboS_M
        '
        Me.cboS_M.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-M", True))
        Me.cboS_M.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_M.FormattingEnabled = True
        Me.cboS_M.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_M.Location = New System.Drawing.Point(412, 184)
        Me.cboS_M.Name = "cboS_M"
        Me.cboS_M.Size = New System.Drawing.Size(40, 23)
        Me.cboS_M.TabIndex = 33
        '
        'cboS_I
        '
        Me.cboS_I.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-I", True))
        Me.cboS_I.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_I.FormattingEnabled = True
        Me.cboS_I.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_I.Location = New System.Drawing.Point(521, 184)
        Me.cboS_I.Name = "cboS_I"
        Me.cboS_I.Size = New System.Drawing.Size(40, 23)
        Me.cboS_I.TabIndex = 34
        '
        'cboS_V
        '
        Me.cboS_V.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-V", True))
        Me.cboS_V.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_V.FormattingEnabled = True
        Me.cboS_V.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_V.Location = New System.Drawing.Point(608, 184)
        Me.cboS_V.Name = "cboS_V"
        Me.cboS_V.Size = New System.Drawing.Size(40, 23)
        Me.cboS_V.TabIndex = 35
        '
        'cboS_R
        '
        Me.cboS_R.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-R", True))
        Me.cboS_R.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_R.FormattingEnabled = True
        Me.cboS_R.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_R.Location = New System.Drawing.Point(701, 184)
        Me.cboS_R.Name = "cboS_R"
        Me.cboS_R.Size = New System.Drawing.Size(40, 23)
        Me.cboS_R.TabIndex = 36
        '
        'cboS_C
        '
        Me.cboS_C.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-C", True))
        Me.cboS_C.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_C.FormattingEnabled = True
        Me.cboS_C.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_C.Location = New System.Drawing.Point(810, 184)
        Me.cboS_C.Name = "cboS_C"
        Me.cboS_C.Size = New System.Drawing.Size(40, 23)
        Me.cboS_C.TabIndex = 37
        '
        'cboS_Ve
        '
        Me.cboS_Ve.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-Ve", True))
        Me.cboS_Ve.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_Ve.FormattingEnabled = True
        Me.cboS_Ve.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_Ve.Location = New System.Drawing.Point(902, 183)
        Me.cboS_Ve.Name = "cboS_Ve"
        Me.cboS_Ve.Size = New System.Drawing.Size(40, 23)
        Me.cboS_Ve.TabIndex = 38
        '
        'cboS_G
        '
        Me.cboS_G.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-G", True))
        Me.cboS_G.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_G.FormattingEnabled = True
        Me.cboS_G.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_G.Location = New System.Drawing.Point(1019, 184)
        Me.cboS_G.Name = "cboS_G"
        Me.cboS_G.Size = New System.Drawing.Size(40, 23)
        Me.cboS_G.TabIndex = 39
        '
        'cboS_PS
        '
        Me.cboS_PS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "S-PS", True))
        Me.cboS_PS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboS_PS.FormattingEnabled = True
        Me.cboS_PS.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboS_PS.Location = New System.Drawing.Point(1197, 184)
        Me.cboS_PS.Name = "cboS_PS"
        Me.cboS_PS.Size = New System.Drawing.Size(40, 23)
        Me.cboS_PS.TabIndex = 40
        '
        'cboDS_E
        '
        Me.cboDS_E.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "DS-E", True))
        Me.cboDS_E.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDS_E.FormattingEnabled = True
        Me.cboDS_E.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboDS_E.Location = New System.Drawing.Point(176, 217)
        Me.cboDS_E.Name = "cboDS_E"
        Me.cboDS_E.Size = New System.Drawing.Size(40, 23)
        Me.cboDS_E.TabIndex = 41
        '
        'cboDS_M
        '
        Me.cboDS_M.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "DS-M", True))
        Me.cboDS_M.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDS_M.FormattingEnabled = True
        Me.cboDS_M.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboDS_M.Location = New System.Drawing.Point(348, 219)
        Me.cboDS_M.Name = "cboDS_M"
        Me.cboDS_M.Size = New System.Drawing.Size(40, 23)
        Me.cboDS_M.TabIndex = 42
        '
        'cboDS_RT
        '
        Me.cboDS_RT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "DS-RT", True))
        Me.cboDS_RT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDS_RT.FormattingEnabled = True
        Me.cboDS_RT.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboDS_RT.Location = New System.Drawing.Point(559, 219)
        Me.cboDS_RT.Name = "cboDS_RT"
        Me.cboDS_RT.Size = New System.Drawing.Size(40, 23)
        Me.cboDS_RT.TabIndex = 43
        '
        'txtAplicaPension
        '
        Me.txtAplicaPension.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAplicaPension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRegimen, "AplicaPension", True))
        Me.txtAplicaPension.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAplicaPension.Location = New System.Drawing.Point(702, 219)
        Me.txtAplicaPension.Name = "txtAplicaPension"
        Me.txtAplicaPension.ReadOnly = True
        Me.txtAplicaPension.Size = New System.Drawing.Size(357, 21)
        Me.txtAplicaPension.TabIndex = 44
        '
        'foModalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1286, 457)
        Me.Controls.Add(AplicaPensionLabel)
        Me.Controls.Add(Me.txtAplicaPension)
        Me.Controls.Add(DS_RTLabel)
        Me.Controls.Add(Me.cboDS_RT)
        Me.Controls.Add(DS_MLabel)
        Me.Controls.Add(Me.cboDS_M)
        Me.Controls.Add(DS_ELabel)
        Me.Controls.Add(Me.cboDS_E)
        Me.Controls.Add(S_PSLabel)
        Me.Controls.Add(Me.cboS_PS)
        Me.Controls.Add(S_GLabel)
        Me.Controls.Add(Me.cboS_G)
        Me.Controls.Add(S_VeLabel)
        Me.Controls.Add(Me.cboS_Ve)
        Me.Controls.Add(S_CLabel)
        Me.Controls.Add(Me.cboS_C)
        Me.Controls.Add(S_RLabel)
        Me.Controls.Add(Me.cboS_R)
        Me.Controls.Add(S_VLabel)
        Me.Controls.Add(Me.cboS_V)
        Me.Controls.Add(S_ILabel)
        Me.Controls.Add(Me.cboS_I)
        Me.Controls.Add(S_MLabel)
        Me.Controls.Add(Me.cboS_M)
        Me.Controls.Add(S_ELabel)
        Me.Controls.Add(Me.cboS_E)
        Me.Controls.Add(S_RTLabel)
        Me.Controls.Add(Me.cboS_RT)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(ModalidadLabel)
        Me.Controls.Add(Me.txtModalidad)
        Me.Controls.Add(TipoRegimenLabel)
        Me.Controls.Add(Me.cboTipoRegimen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgRegimenIMSS)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.FillByModalidadToolStrip)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "foModalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modalidades IMSS"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.FillByModalidadToolStrip.ResumeLayout(False)
        Me.FillByModalidadToolStrip.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        CType(Me.dgRegimenIMSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRegimen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents tsbPrimero As ToolStripButton
    Friend WithEvents tsbPrevio As ToolStripButton
    Friend WithEvents tsbSiguiente As ToolStripButton
    Friend WithEvents tsbUltimo As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents FillByModalidadToolStrip As ToolStrip
    Friend WithEvents ModalidadToolStripLabel As ToolStripLabel
    Friend WithEvents txtModalidadFind As ToolStripTextBox
    Friend WithEvents btnModalidadFiltro As ToolStripButton
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgRegimenIMSS As DataGridView
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbAgregar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents tss01 As ToolStripSeparator
    Friend WithEvents bsRegimen As BindingSource
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents RegimenIMSSTableAdapter As dsCatalogosTableAdapters.RegimenIMSSTableAdapter
    Friend WithEvents TipoRegimenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SRTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SVeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DSEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DSMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DSRTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AplicaPensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents cboTipoRegimen As ComboBox
    Friend WithEvents txtModalidad As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cboS_RT As ComboBox
    Friend WithEvents cboS_E As ComboBox
    Friend WithEvents cboS_M As ComboBox
    Friend WithEvents cboS_I As ComboBox
    Friend WithEvents cboS_V As ComboBox
    Friend WithEvents cboS_R As ComboBox
    Friend WithEvents cboS_C As ComboBox
    Friend WithEvents cboS_Ve As ComboBox
    Friend WithEvents cboS_G As ComboBox
    Friend WithEvents cboS_PS As ComboBox
    Friend WithEvents cboDS_E As ComboBox
    Friend WithEvents cboDS_M As ComboBox
    Friend WithEvents cboDS_RT As ComboBox
    Friend WithEvents txtAplicaPension As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foPctM40
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
        Dim lblSBSs As System.Windows.Forms.Label
        Dim lblSBSi As System.Windows.Forms.Label
        Dim lblAño As System.Windows.Forms.Label
        Dim lblRetiro As System.Windows.Forms.Label
        Dim lblCAVp As System.Windows.Forms.Label
        Dim lblCAVt As System.Windows.Forms.Label
        Dim lblIVp As System.Windows.Forms.Label
        Dim lblIVt As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim lbl As System.Windows.Forms.Label
        Dim lblPct01 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foPctM40))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.gbRetiro = New System.Windows.Forms.GroupBox()
        Me.txtRetiro = New System.Windows.Forms.TextBox()
        Me.bsPctMod40 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.dgPctM40 = New System.Windows.Forms.DataGridView()
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBCinfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpRetiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcteCAVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpCAVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcteIVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpIVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcteGMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpGMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttAyuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtSBCSup = New System.Windows.Forms.TextBox()
        Me.txtSBCInf = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtCAVp = New System.Windows.Forms.TextBox()
        Me.txtCAVt = New System.Windows.Forms.TextBox()
        Me.txtIVp = New System.Windows.Forms.TextBox()
        Me.txtIVt = New System.Windows.Forms.TextBox()
        Me.txtGMp = New System.Windows.Forms.TextBox()
        Me.txtGMt = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.gbAño = New System.Windows.Forms.GroupBox()
        Me.gpCAV = New System.Windows.Forms.GroupBox()
        Me.gpIV = New System.Windows.Forms.GroupBox()
        Me.gpGM = New System.Windows.Forms.GroupBox()
        Me.FillByAñoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AnoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtAñoFiltro = New System.Windows.Forms.ToolStripTextBox()
        Me.BtnFillAño = New System.Windows.Forms.ToolStripButton()
        Me.PctSegurosM40TableAdapter = New Catalogos.dsCatalogosTableAdapters.PctSegurosM40TableAdapter()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        lblSBSs = New System.Windows.Forms.Label()
        lblSBSi = New System.Windows.Forms.Label()
        lblAño = New System.Windows.Forms.Label()
        lblRetiro = New System.Windows.Forms.Label()
        lblCAVp = New System.Windows.Forms.Label()
        lblCAVt = New System.Windows.Forms.Label()
        lblIVp = New System.Windows.Forms.Label()
        lblIVt = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        lbl = New System.Windows.Forms.Label()
        lblPct01 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.gbRetiro.SuspendLayout()
        CType(Me.bsPctMod40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPctM40, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAño.SuspendLayout()
        Me.gpCAV.SuspendLayout()
        Me.gpIV.SuspendLayout()
        Me.gpGM.SuspendLayout()
        Me.FillByAñoToolStrip.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSBSs
        '
        lblSBSs.AutoSize = True
        lblSBSs.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSBSs.ForeColor = System.Drawing.Color.Red
        lblSBSs.Location = New System.Drawing.Point(9, 79)
        lblSBSs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSBSs.Name = "lblSBSs"
        lblSBSs.Size = New System.Drawing.Size(79, 15)
        lblSBSs.TabIndex = 13
        lblSBSs.Text = "SBC Superior:"
        '
        'lblSBSi
        '
        lblSBSi.AutoSize = True
        lblSBSi.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSBSi.ForeColor = System.Drawing.Color.Red
        lblSBSi.Location = New System.Drawing.Point(17, 50)
        lblSBSi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblSBSi.Name = "lblSBSi"
        lblSBSi.Size = New System.Drawing.Size(71, 15)
        lblSBSi.TabIndex = 11
        lblSBSi.Text = "SBC Inferior:"
        '
        'lblAño
        '
        lblAño.AutoSize = True
        lblAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAño.ForeColor = System.Drawing.Color.Red
        lblAño.Location = New System.Drawing.Point(56, 21)
        lblAño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblAño.Name = "lblAño"
        lblAño.Size = New System.Drawing.Size(32, 15)
        lblAño.TabIndex = 10
        lblAño.Text = "Año:"
        '
        'lblRetiro
        '
        lblRetiro.AutoSize = True
        lblRetiro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRetiro.ForeColor = System.Drawing.Color.Red
        lblRetiro.Location = New System.Drawing.Point(19, 28)
        lblRetiro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblRetiro.Name = "lblRetiro"
        lblRetiro.Size = New System.Drawing.Size(45, 15)
        lblRetiro.TabIndex = 11
        lblRetiro.Text = "Patrón:"
        '
        'lblCAVp
        '
        lblCAVp.AutoSize = True
        lblCAVp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCAVp.ForeColor = System.Drawing.Color.Red
        lblCAVp.Location = New System.Drawing.Point(33, 60)
        lblCAVp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblCAVp.Name = "lblCAVp"
        lblCAVp.Size = New System.Drawing.Size(45, 15)
        lblCAVp.TabIndex = 29
        lblCAVp.Text = "Patrón:"
        '
        'lblCAVt
        '
        lblCAVt.AutoSize = True
        lblCAVt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCAVt.ForeColor = System.Drawing.Color.Red
        lblCAVt.Location = New System.Drawing.Point(10, 31)
        lblCAVt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblCAVt.Name = "lblCAVt"
        lblCAVt.Size = New System.Drawing.Size(68, 15)
        lblCAVt.TabIndex = 26
        lblCAVt.Text = "Trabajador:"
        '
        'lblIVp
        '
        lblIVp.AutoSize = True
        lblIVp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIVp.ForeColor = System.Drawing.Color.Red
        lblIVp.Location = New System.Drawing.Point(40, 57)
        lblIVp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblIVp.Name = "lblIVp"
        lblIVp.Size = New System.Drawing.Size(45, 15)
        lblIVp.TabIndex = 30
        lblIVp.Text = "Patrón:"
        '
        'lblIVt
        '
        lblIVt.AutoSize = True
        lblIVt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIVt.ForeColor = System.Drawing.Color.Red
        lblIVt.Location = New System.Drawing.Point(17, 28)
        lblIVt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblIVt.Name = "lblIVt"
        lblIVt.Size = New System.Drawing.Size(68, 15)
        lblIVt.TabIndex = 27
        lblIVt.Text = "Trabajador:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Red
        Label1.Location = New System.Drawing.Point(43, 54)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 15)
        Label1.TabIndex = 27
        Label1.Text = "Patrón:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Red
        Label2.Location = New System.Drawing.Point(20, 25)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(68, 15)
        Label2.TabIndex = 24
        Label2.Text = "Trabajador:"
        '
        'lbl
        '
        lbl.AutoSize = True
        lbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl.ForeColor = System.Drawing.Color.Blue
        lbl.Location = New System.Drawing.Point(200, 248)
        lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lbl.Name = "lbl"
        lbl.Size = New System.Drawing.Size(42, 16)
        lbl.TabIndex = 26
        lbl.Text = "Total:"
        '
        'lblPct01
        '
        lblPct01.AutoSize = True
        lblPct01.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPct01.ForeColor = System.Drawing.Color.Blue
        lblPct01.Location = New System.Drawing.Point(145, 27)
        lblPct01.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblPct01.Name = "lblPct01"
        lblPct01.Size = New System.Drawing.Size(16, 16)
        lblPct01.TabIndex = 27
        lblPct01.Text = "%"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Blue
        Label3.Location = New System.Drawing.Point(157, 31)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(16, 16)
        Label3.TabIndex = 30
        Label3.Text = "%"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Blue
        Label4.Location = New System.Drawing.Point(157, 60)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(16, 16)
        Label4.TabIndex = 31
        Label4.Text = "%"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.Blue
        Label5.Location = New System.Drawing.Point(338, 248)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(16, 16)
        Label5.TabIndex = 32
        Label5.Text = "%"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Blue
        Label6.Location = New System.Drawing.Point(164, 28)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(16, 16)
        Label6.TabIndex = 33
        Label6.Text = "%"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.Blue
        Label7.Location = New System.Drawing.Point(164, 59)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(16, 16)
        Label7.TabIndex = 34
        Label7.Text = "%"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.Blue
        Label8.Location = New System.Drawing.Point(167, 25)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(16, 16)
        Label8.TabIndex = 34
        Label8.Text = "%"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.Blue
        Label9.Location = New System.Drawing.Point(167, 54)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(16, 16)
        Label9.TabIndex = 35
        Label9.Text = "%"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.tsbRefrescar, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(1017, 40)
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
        Me.tsbSalir.Margin = New System.Windows.Forms.Padding(22, 2, 2, 2)
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
        Me.lblTitulo.Size = New System.Drawing.Size(1020, 30)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbRetiro
        '
        Me.gbRetiro.Controls.Add(lblPct01)
        Me.gbRetiro.Controls.Add(lblRetiro)
        Me.gbRetiro.Controls.Add(Me.txtRetiro)
        Me.gbRetiro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRetiro.ForeColor = System.Drawing.Color.Maroon
        Me.gbRetiro.Location = New System.Drawing.Point(195, 158)
        Me.gbRetiro.Margin = New System.Windows.Forms.Padding(4)
        Me.gbRetiro.Name = "gbRetiro"
        Me.gbRetiro.Padding = New System.Windows.Forms.Padding(4)
        Me.gbRetiro.Size = New System.Drawing.Size(174, 71)
        Me.gbRetiro.TabIndex = 5
        Me.gbRetiro.TabStop = False
        Me.gbRetiro.Text = "Retiro"
        '
        'txtRetiro
        '
        Me.txtRetiro.BackColor = System.Drawing.Color.White
        Me.txtRetiro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pctpRetiro", True))
        Me.txtRetiro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetiro.Location = New System.Drawing.Point(72, 27)
        Me.txtRetiro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetiro.Name = "txtRetiro"
        Me.txtRetiro.Size = New System.Drawing.Size(63, 21)
        Me.txtRetiro.TabIndex = 6
        Me.txtRetiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtRetiro, "Valor de la UMA al dia")
        '
        'bsPctMod40
        '
        Me.bsPctMod40.DataMember = "PctSegurosM40"
        Me.bsPctMod40.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgPctM40
        '
        Me.dgPctM40.AllowUserToAddRows = False
        Me.dgPctM40.AllowUserToDeleteRows = False
        Me.dgPctM40.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgPctM40.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPctM40.AutoGenerateColumns = False
        Me.dgPctM40.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgPctM40.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPctM40.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPctM40.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPctM40.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPctM40.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnoDataGridViewTextBoxColumn, Me.SBCinfDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.PctpRetiroDataGridViewTextBoxColumn, Me.PcteCAVDataGridViewTextBoxColumn, Me.PctpCAVDataGridViewTextBoxColumn, Me.PcteIVDataGridViewTextBoxColumn, Me.PctpIVDataGridViewTextBoxColumn, Me.PcteGMDataGridViewTextBoxColumn, Me.PctpGMDataGridViewTextBoxColumn, Me.PctTotalDataGridViewTextBoxColumn})
        Me.dgPctM40.DataSource = Me.bsPctMod40
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPctM40.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgPctM40.EnableHeadersVisualStyles = False
        Me.dgPctM40.GridColor = System.Drawing.Color.SkyBlue
        Me.dgPctM40.Location = New System.Drawing.Point(13, 294)
        Me.dgPctM40.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPctM40.MultiSelect = False
        Me.dgPctM40.Name = "dgPctM40"
        Me.dgPctM40.ReadOnly = True
        Me.dgPctM40.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPctM40.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgPctM40.RowHeadersVisible = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.dgPctM40.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgPctM40.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPctM40.Size = New System.Drawing.Size(981, 149)
        Me.dgPctM40.TabIndex = 15
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "Ano"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.AnoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "Ano"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        Me.AnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnoDataGridViewTextBoxColumn.Width = 60
        '
        'SBCinfDataGridViewTextBoxColumn
        '
        Me.SBCinfDataGridViewTextBoxColumn.DataPropertyName = "SBCinf"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SBCinfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SBCinfDataGridViewTextBoxColumn.HeaderText = "SBC Inferior"
        Me.SBCinfDataGridViewTextBoxColumn.Name = "SBCinfDataGridViewTextBoxColumn"
        Me.SBCinfDataGridViewTextBoxColumn.ReadOnly = True
        Me.SBCinfDataGridViewTextBoxColumn.Width = 90
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SBCsup"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn1.HeaderText = "SBC Superior"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'PctpRetiroDataGridViewTextBoxColumn
        '
        Me.PctpRetiroDataGridViewTextBoxColumn.DataPropertyName = "pctpRetiro"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PctpRetiroDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PctpRetiroDataGridViewTextBoxColumn.HeaderText = "% Retiro Patrón"
        Me.PctpRetiroDataGridViewTextBoxColumn.Name = "PctpRetiroDataGridViewTextBoxColumn"
        Me.PctpRetiroDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctpRetiroDataGridViewTextBoxColumn.Width = 90
        '
        'PcteCAVDataGridViewTextBoxColumn
        '
        Me.PcteCAVDataGridViewTextBoxColumn.DataPropertyName = "pcteCAV"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N3"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PcteCAVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PcteCAVDataGridViewTextBoxColumn.HeaderText = "% CEV Trabajador"
        Me.PcteCAVDataGridViewTextBoxColumn.Name = "PcteCAVDataGridViewTextBoxColumn"
        Me.PcteCAVDataGridViewTextBoxColumn.ReadOnly = True
        Me.PcteCAVDataGridViewTextBoxColumn.Width = 90
        '
        'PctpCAVDataGridViewTextBoxColumn
        '
        Me.PctpCAVDataGridViewTextBoxColumn.DataPropertyName = "pctpCAV"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N3"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PctpCAVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PctpCAVDataGridViewTextBoxColumn.HeaderText = "% CEV Patrón"
        Me.PctpCAVDataGridViewTextBoxColumn.Name = "PctpCAVDataGridViewTextBoxColumn"
        Me.PctpCAVDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctpCAVDataGridViewTextBoxColumn.Width = 90
        '
        'PcteIVDataGridViewTextBoxColumn
        '
        Me.PcteIVDataGridViewTextBoxColumn.DataPropertyName = "pcteIV"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N3"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.PcteIVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PcteIVDataGridViewTextBoxColumn.HeaderText = "% IV Trabajador"
        Me.PcteIVDataGridViewTextBoxColumn.Name = "PcteIVDataGridViewTextBoxColumn"
        Me.PcteIVDataGridViewTextBoxColumn.ReadOnly = True
        Me.PcteIVDataGridViewTextBoxColumn.Width = 90
        '
        'PctpIVDataGridViewTextBoxColumn
        '
        Me.PctpIVDataGridViewTextBoxColumn.DataPropertyName = "pctpIV"
        DataGridViewCellStyle10.Format = "N3"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PctpIVDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.PctpIVDataGridViewTextBoxColumn.HeaderText = "% IV Patrón"
        Me.PctpIVDataGridViewTextBoxColumn.Name = "PctpIVDataGridViewTextBoxColumn"
        Me.PctpIVDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctpIVDataGridViewTextBoxColumn.Width = 90
        '
        'PcteGMDataGridViewTextBoxColumn
        '
        Me.PcteGMDataGridViewTextBoxColumn.DataPropertyName = "pcteGM"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "N3"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.PcteGMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.PcteGMDataGridViewTextBoxColumn.HeaderText = "% GM Trabajador"
        Me.PcteGMDataGridViewTextBoxColumn.Name = "PcteGMDataGridViewTextBoxColumn"
        Me.PcteGMDataGridViewTextBoxColumn.ReadOnly = True
        Me.PcteGMDataGridViewTextBoxColumn.Width = 90
        '
        'PctpGMDataGridViewTextBoxColumn
        '
        Me.PctpGMDataGridViewTextBoxColumn.DataPropertyName = "pctpGM"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N3"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.PctpGMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.PctpGMDataGridViewTextBoxColumn.HeaderText = "% GM Patrón"
        Me.PctpGMDataGridViewTextBoxColumn.Name = "PctpGMDataGridViewTextBoxColumn"
        Me.PctpGMDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctpGMDataGridViewTextBoxColumn.Width = 90
        '
        'PctTotalDataGridViewTextBoxColumn
        '
        Me.PctTotalDataGridViewTextBoxColumn.DataPropertyName = "pctTotal"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N3"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.PctTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.PctTotalDataGridViewTextBoxColumn.HeaderText = "% Total"
        Me.PctTotalDataGridViewTextBoxColumn.Name = "PctTotalDataGridViewTextBoxColumn"
        Me.PctTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PctTotalDataGridViewTextBoxColumn.Width = 90
        '
        'txtSBCSup
        '
        Me.txtSBCSup.BackColor = System.Drawing.Color.White
        Me.txtSBCSup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "SBCsup", True))
        Me.txtSBCSup.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBCSup.Location = New System.Drawing.Point(96, 76)
        Me.txtSBCSup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSBCSup.Name = "txtSBCSup"
        Me.txtSBCSup.Size = New System.Drawing.Size(63, 21)
        Me.txtSBCSup.TabIndex = 4
        Me.txtSBCSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtSBCSup, "Valor del SMG al dia")
        '
        'txtSBCInf
        '
        Me.txtSBCInf.BackColor = System.Drawing.Color.White
        Me.txtSBCInf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "SBCinf", True))
        Me.txtSBCInf.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBCInf.Location = New System.Drawing.Point(96, 47)
        Me.txtSBCInf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSBCInf.Name = "txtSBCInf"
        Me.txtSBCInf.Size = New System.Drawing.Size(63, 21)
        Me.txtSBCInf.TabIndex = 3
        Me.txtSBCInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtSBCInf, "Valor de la UMA al dia")
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.Color.White
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "Ano", True))
        Me.txtAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(96, 18)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAño.MaxLength = 5
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(63, 21)
        Me.txtAño.TabIndex = 2
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtAño, "Año de la UMA/SMG")
        '
        'txtCAVp
        '
        Me.txtCAVp.BackColor = System.Drawing.Color.White
        Me.txtCAVp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pctpCAV", True))
        Me.txtCAVp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAVp.Location = New System.Drawing.Point(85, 57)
        Me.txtCAVp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCAVp.Name = "txtCAVp"
        Me.txtCAVp.Size = New System.Drawing.Size(63, 21)
        Me.txtCAVp.TabIndex = 9
        Me.txtCAVp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtCAVp, "Valor de la UMA al dia")
        '
        'txtCAVt
        '
        Me.txtCAVt.BackColor = System.Drawing.Color.White
        Me.txtCAVt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pcteCAV", True))
        Me.txtCAVt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAVt.Location = New System.Drawing.Point(86, 28)
        Me.txtCAVt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCAVt.Name = "txtCAVt"
        Me.txtCAVt.Size = New System.Drawing.Size(63, 21)
        Me.txtCAVt.TabIndex = 8
        Me.txtCAVt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtCAVt, "Valor de la UMA al dia")
        '
        'txtIVp
        '
        Me.txtIVp.BackColor = System.Drawing.Color.White
        Me.txtIVp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pctpIV", True))
        Me.txtIVp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVp.Location = New System.Drawing.Point(93, 54)
        Me.txtIVp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIVp.Name = "txtIVp"
        Me.txtIVp.Size = New System.Drawing.Size(63, 21)
        Me.txtIVp.TabIndex = 12
        Me.txtIVp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtIVp, "Valor de la UMA al dia")
        '
        'txtIVt
        '
        Me.txtIVt.BackColor = System.Drawing.Color.White
        Me.txtIVt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pcteIV", True))
        Me.txtIVt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVt.Location = New System.Drawing.Point(93, 25)
        Me.txtIVt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIVt.Name = "txtIVt"
        Me.txtIVt.Size = New System.Drawing.Size(63, 21)
        Me.txtIVt.TabIndex = 11
        Me.txtIVt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtIVt, "Valor de la UMA al dia")
        '
        'txtGMp
        '
        Me.txtGMp.BackColor = System.Drawing.Color.White
        Me.txtGMp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pctpGM", True))
        Me.txtGMp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGMp.Location = New System.Drawing.Point(96, 51)
        Me.txtGMp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGMp.Name = "txtGMp"
        Me.txtGMp.Size = New System.Drawing.Size(63, 21)
        Me.txtGMp.TabIndex = 15
        Me.txtGMp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtGMp, "Valor de la UMA al dia")
        '
        'txtGMt
        '
        Me.txtGMt.BackColor = System.Drawing.Color.White
        Me.txtGMt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pcteGM", True))
        Me.txtGMt.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGMt.Location = New System.Drawing.Point(96, 22)
        Me.txtGMt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGMt.Name = "txtGMt"
        Me.txtGMt.Size = New System.Drawing.Size(63, 21)
        Me.txtGMt.TabIndex = 14
        Me.txtGMt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtGMt, "Valor de la UMA al dia")
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPctMod40, "pctTotal", True))
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(250, 244)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(80, 23)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttAyuda.SetToolTip(Me.txtTotal, "Valor de la UMA al dia")
        '
        'gbAño
        '
        Me.gbAño.Controls.Add(Me.txtSBCSup)
        Me.gbAño.Controls.Add(lblSBSs)
        Me.gbAño.Controls.Add(Me.txtSBCInf)
        Me.gbAño.Controls.Add(Me.txtAño)
        Me.gbAño.Controls.Add(lblSBSi)
        Me.gbAño.Controls.Add(lblAño)
        Me.gbAño.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAño.ForeColor = System.Drawing.Color.Maroon
        Me.gbAño.Location = New System.Drawing.Point(13, 158)
        Me.gbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAño.Name = "gbAño"
        Me.gbAño.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAño.Size = New System.Drawing.Size(174, 105)
        Me.gbAño.TabIndex = 1
        Me.gbAño.TabStop = False
        Me.gbAño.Text = "Año"
        '
        'gpCAV
        '
        Me.gpCAV.Controls.Add(Label4)
        Me.gpCAV.Controls.Add(Label3)
        Me.gpCAV.Controls.Add(lblCAVp)
        Me.gpCAV.Controls.Add(Me.txtCAVp)
        Me.gpCAV.Controls.Add(Me.txtCAVt)
        Me.gpCAV.Controls.Add(lblCAVt)
        Me.gpCAV.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCAV.ForeColor = System.Drawing.Color.Maroon
        Me.gpCAV.Location = New System.Drawing.Point(379, 158)
        Me.gpCAV.Margin = New System.Windows.Forms.Padding(4)
        Me.gpCAV.Name = "gpCAV"
        Me.gpCAV.Padding = New System.Windows.Forms.Padding(4)
        Me.gpCAV.Size = New System.Drawing.Size(181, 105)
        Me.gpCAV.TabIndex = 7
        Me.gpCAV.TabStop = False
        Me.gpCAV.Text = "Cesantía Avanzada y Vejez"
        '
        'gpIV
        '
        Me.gpIV.Controls.Add(Label7)
        Me.gpIV.Controls.Add(Label6)
        Me.gpIV.Controls.Add(lblIVp)
        Me.gpIV.Controls.Add(Me.txtIVp)
        Me.gpIV.Controls.Add(Me.txtIVt)
        Me.gpIV.Controls.Add(lblIVt)
        Me.gpIV.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpIV.ForeColor = System.Drawing.Color.Maroon
        Me.gpIV.Location = New System.Drawing.Point(568, 160)
        Me.gpIV.Margin = New System.Windows.Forms.Padding(4)
        Me.gpIV.Name = "gpIV"
        Me.gpIV.Padding = New System.Windows.Forms.Padding(4)
        Me.gpIV.Size = New System.Drawing.Size(200, 103)
        Me.gpIV.TabIndex = 10
        Me.gpIV.TabStop = False
        Me.gpIV.Text = "Invalidez y vida"
        '
        'gpGM
        '
        Me.gpGM.Controls.Add(Label9)
        Me.gpGM.Controls.Add(Label8)
        Me.gpGM.Controls.Add(Label1)
        Me.gpGM.Controls.Add(Me.txtGMp)
        Me.gpGM.Controls.Add(Me.txtGMt)
        Me.gpGM.Controls.Add(Label2)
        Me.gpGM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpGM.ForeColor = System.Drawing.Color.Maroon
        Me.gpGM.Location = New System.Drawing.Point(776, 161)
        Me.gpGM.Margin = New System.Windows.Forms.Padding(4)
        Me.gpGM.Name = "gpGM"
        Me.gpGM.Padding = New System.Windows.Forms.Padding(4)
        Me.gpGM.Size = New System.Drawing.Size(199, 103)
        Me.gpGM.TabIndex = 13
        Me.gpGM.TabStop = False
        Me.gpGM.Text = "Enfermedades y Maternidad"
        '
        'FillByAñoToolStrip
        '
        Me.FillByAñoToolStrip.AutoSize = False
        Me.FillByAñoToolStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.FillByAñoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnoToolStripLabel, Me.txtAñoFiltro, Me.BtnFillAño})
        Me.FillByAñoToolStrip.Location = New System.Drawing.Point(0, 40)
        Me.FillByAñoToolStrip.Name = "FillByAñoToolStrip"
        Me.FillByAñoToolStrip.Size = New System.Drawing.Size(1017, 40)
        Me.FillByAñoToolStrip.TabIndex = 26
        Me.FillByAñoToolStrip.Text = "FillByAñoToolStrip"
        '
        'AnoToolStripLabel
        '
        Me.AnoToolStripLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoToolStripLabel.ForeColor = System.Drawing.Color.Blue
        Me.AnoToolStripLabel.Name = "AnoToolStripLabel"
        Me.AnoToolStripLabel.Size = New System.Drawing.Size(32, 37)
        Me.AnoToolStripLabel.Text = "Año:"
        '
        'txtAñoFiltro
        '
        Me.txtAñoFiltro.AutoSize = False
        Me.txtAñoFiltro.BackColor = System.Drawing.Color.White
        Me.txtAñoFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAñoFiltro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñoFiltro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAñoFiltro.MaxLength = 4
        Me.txtAñoFiltro.Name = "txtAñoFiltro"
        Me.txtAñoFiltro.Size = New System.Drawing.Size(58, 23)
        Me.txtAñoFiltro.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAñoFiltro.ToolTipText = "Filtro x Año"
        '
        'BtnFillAño
        '
        Me.BtnFillAño.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFillAño.Image = CType(resources.GetObject("BtnFillAño.Image"), System.Drawing.Image)
        Me.BtnFillAño.Name = "BtnFillAño"
        Me.BtnFillAño.Size = New System.Drawing.Size(23, 37)
        Me.BtnFillAño.Text = "FillByAño"
        Me.BtnFillAño.ToolTipText = "Filtro x Año"
        '
        'PctSegurosM40TableAdapter
        '
        Me.PctSegurosM40TableAdapter.ClearBeforeFill = True
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.None
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 80)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(1017, 35)
        Me.SSMensaje.TabIndex = 27
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
        Me.tsslMensaje.Size = New System.Drawing.Size(1000, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'foPctM40
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1017, 452)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.FillByAñoToolStrip)
        Me.Controls.Add(lbl)
        Me.Controls.Add(Me.gpGM)
        Me.Controls.Add(Me.gpIV)
        Me.Controls.Add(Me.gpCAV)
        Me.Controls.Add(Me.gbAño)
        Me.Controls.Add(Me.dgPctM40)
        Me.Controls.Add(Me.gbRetiro)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foPctM40"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de % Seguros en Modalidad 40"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.gbRetiro.ResumeLayout(False)
        Me.gbRetiro.PerformLayout()
        CType(Me.bsPctMod40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPctM40, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAño.ResumeLayout(False)
        Me.gbAño.PerformLayout()
        Me.gpCAV.ResumeLayout(False)
        Me.gpCAV.PerformLayout()
        Me.gpIV.ResumeLayout(False)
        Me.gpIV.PerformLayout()
        Me.gpGM.ResumeLayout(False)
        Me.gpGM.PerformLayout()
        Me.FillByAñoToolStrip.ResumeLayout(False)
        Me.FillByAñoToolStrip.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsBotones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrevio As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents gbRetiro As System.Windows.Forms.GroupBox
    Friend WithEvents dgPctM40 As System.Windows.Forms.DataGridView
    Friend WithEvents ttAyuda As System.Windows.Forms.ToolTip
    Friend WithEvents gbAño As System.Windows.Forms.GroupBox
    Friend WithEvents txtSBCSup As System.Windows.Forms.TextBox
    Friend WithEvents txtSBCInf As System.Windows.Forms.TextBox
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents txtRetiro As System.Windows.Forms.TextBox
    Friend WithEvents gpCAV As System.Windows.Forms.GroupBox
    Friend WithEvents txtCAVp As System.Windows.Forms.TextBox
    Friend WithEvents txtCAVt As System.Windows.Forms.TextBox
    Friend WithEvents gpIV As System.Windows.Forms.GroupBox
    Friend WithEvents txtIVp As System.Windows.Forms.TextBox
    Friend WithEvents txtIVt As System.Windows.Forms.TextBox
    Friend WithEvents gpGM As System.Windows.Forms.GroupBox
    Friend WithEvents txtGMp As System.Windows.Forms.TextBox
    Friend WithEvents txtGMt As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents SBCSupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsPctMod40 As BindingSource
    Friend WithEvents FillByAñoToolStrip As ToolStrip
    Friend WithEvents AnoToolStripLabel As ToolStripLabel
    Friend WithEvents txtAñoFiltro As ToolStripTextBox
    Friend WithEvents BtnFillAño As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents PctSegurosM40TableAdapter As dsCatalogosTableAdapters.PctSegurosM40TableAdapter
    Friend WithEvents AnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SBCinfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PctpRetiroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcteCAVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctpCAVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcteIVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctpIVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcteGMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctpGMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
End Class

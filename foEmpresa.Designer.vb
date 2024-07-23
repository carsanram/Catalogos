<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foEmpresa
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
        Dim RazonSocialLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim TelOficinaLabel As System.Windows.Forms.Label
        Dim TelCelularLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim SloganLabel As System.Windows.Forms.Label
        Dim HorarioLabel As System.Windows.Forms.Label
        Dim DiasLaboralesLabel As System.Windows.Forms.Label
        Dim CPLabel As System.Windows.Forms.Label
        Dim WhatsAppLabel As System.Windows.Forms.Label
        Dim YoutubeLabel As System.Windows.Forms.Label
        Dim FacebookLabel As System.Windows.Forms.Label
        Dim InstagramLabel As System.Windows.Forms.Label
        Dim TikTokLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foEmpresa))
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SSMensaje = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.bsDespacho = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPensiones = New Catalogos.dsPensiones()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtHorario = New System.Windows.Forms.TextBox()
        Me.txtDiasLaborales = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.gbDespacho = New System.Windows.Forms.GroupBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtActiva = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtSlogan = New System.Windows.Forms.TextBox()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.bsEstadosMx = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtYoutube = New System.Windows.Forms.TextBox()
        Me.txtFacebook = New System.Windows.Forms.TextBox()
        Me.txtInstagram = New System.Windows.Forms.TextBox()
        Me.txtTikTok = New System.Windows.Forms.TextBox()
        Me.gbRedes = New System.Windows.Forms.GroupBox()
        Me.txtWhatsApp = New System.Windows.Forms.MaskedTextBox()
        Me.EstadosMxTableAdapter = New Catalogos.dsCatalogosTableAdapters.EstadosMxTableAdapter()
        Me.TableAdapterManager1 = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        Me.DespachoTableAdapter = New Catalogos.dsPensionesTableAdapters.DespachoTableAdapter()
        Me.TableAdapterManager = New Catalogos.dsPensionesTableAdapters.TableAdapterManager()
        Me.NotasTextBox = New System.Windows.Forms.TextBox()
        RazonSocialLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        TelOficinaLabel = New System.Windows.Forms.Label()
        TelCelularLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        WebLabel = New System.Windows.Forms.Label()
        SloganLabel = New System.Windows.Forms.Label()
        HorarioLabel = New System.Windows.Forms.Label()
        DiasLaboralesLabel = New System.Windows.Forms.Label()
        CPLabel = New System.Windows.Forms.Label()
        WhatsAppLabel = New System.Windows.Forms.Label()
        YoutubeLabel = New System.Windows.Forms.Label()
        FacebookLabel = New System.Windows.Forms.Label()
        InstagramLabel = New System.Windows.Forms.Label()
        TikTokLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NotasLabel = New System.Windows.Forms.Label()
        Me.tsBotones.SuspendLayout()
        Me.SSMensaje.SuspendLayout()
        CType(Me.bsDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPensiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDespacho.SuspendLayout()
        CType(Me.bsEstadosMx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRedes.SuspendLayout()
        Me.SuspendLayout()
        '
        'RazonSocialLabel
        '
        RazonSocialLabel.AutoSize = True
        RazonSocialLabel.ForeColor = System.Drawing.Color.Red
        RazonSocialLabel.Location = New System.Drawing.Point(5, 24)
        RazonSocialLabel.Name = "RazonSocialLabel"
        RazonSocialLabel.Size = New System.Drawing.Size(79, 15)
        RazonSocialLabel.TabIndex = 0
        RazonSocialLabel.Text = "Razon Social:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.ForeColor = System.Drawing.Color.Blue
        DireccionLabel.Location = New System.Drawing.Point(21, 51)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(63, 15)
        DireccionLabel.TabIndex = 2
        DireccionLabel.Text = "Direccion:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.ForeColor = System.Drawing.Color.Blue
        NumeroLabel.Location = New System.Drawing.Point(403, 24)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(53, 15)
        NumeroLabel.TabIndex = 4
        NumeroLabel.Text = "Numero:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.ForeColor = System.Drawing.Color.Blue
        ColoniaLabel.Location = New System.Drawing.Point(32, 78)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(52, 15)
        ColoniaLabel.TabIndex = 6
        ColoniaLabel.Text = "Colonia:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.ForeColor = System.Drawing.Color.Blue
        EstadoLabel.Location = New System.Drawing.Point(39, 105)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(45, 15)
        EstadoLabel.TabIndex = 8
        EstadoLabel.Text = "Estado:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.ForeColor = System.Drawing.Color.Blue
        PaisLabel.Location = New System.Drawing.Point(424, 78)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(32, 15)
        PaisLabel.TabIndex = 10
        PaisLabel.Text = "Pais:"
        '
        'TelOficinaLabel
        '
        TelOficinaLabel.AutoSize = True
        TelOficinaLabel.ForeColor = System.Drawing.Color.Blue
        TelOficinaLabel.Location = New System.Drawing.Point(17, 135)
        TelOficinaLabel.Name = "TelOficinaLabel"
        TelOficinaLabel.Size = New System.Drawing.Size(67, 15)
        TelOficinaLabel.TabIndex = 12
        TelOficinaLabel.Text = "Tel Oficina:"
        '
        'TelCelularLabel
        '
        TelCelularLabel.AutoSize = True
        TelCelularLabel.ForeColor = System.Drawing.Color.Blue
        TelCelularLabel.Location = New System.Drawing.Point(214, 135)
        TelCelularLabel.Name = "TelCelularLabel"
        TelCelularLabel.Size = New System.Drawing.Size(67, 15)
        TelCelularLabel.TabIndex = 14
        TelCelularLabel.Text = "Tel Celular:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.ForeColor = System.Drawing.Color.Blue
        EmailLabel.Location = New System.Drawing.Point(46, 163)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 15)
        EmailLabel.TabIndex = 16
        EmailLabel.Text = "Email:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.ForeColor = System.Drawing.Color.Blue
        WebLabel.Location = New System.Drawing.Point(50, 190)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(34, 15)
        WebLabel.TabIndex = 18
        WebLabel.Text = "Web:"
        '
        'SloganLabel
        '
        SloganLabel.AutoSize = True
        SloganLabel.ForeColor = System.Drawing.Color.Blue
        SloganLabel.Location = New System.Drawing.Point(37, 217)
        SloganLabel.Name = "SloganLabel"
        SloganLabel.Size = New System.Drawing.Size(47, 15)
        SloganLabel.TabIndex = 20
        SloganLabel.Text = "Slogan:"
        '
        'HorarioLabel
        '
        HorarioLabel.AutoSize = True
        HorarioLabel.ForeColor = System.Drawing.Color.Blue
        HorarioLabel.Location = New System.Drawing.Point(34, 244)
        HorarioLabel.Name = "HorarioLabel"
        HorarioLabel.Size = New System.Drawing.Size(50, 15)
        HorarioLabel.TabIndex = 22
        HorarioLabel.Text = "Horario:"
        '
        'DiasLaboralesLabel
        '
        DiasLaboralesLabel.AutoSize = True
        DiasLaboralesLabel.ForeColor = System.Drawing.Color.Blue
        DiasLaboralesLabel.Location = New System.Drawing.Point(206, 244)
        DiasLaboralesLabel.Name = "DiasLaboralesLabel"
        DiasLaboralesLabel.Size = New System.Drawing.Size(88, 15)
        DiasLaboralesLabel.TabIndex = 24
        DiasLaboralesLabel.Text = "Dias Laborales:"
        '
        'CPLabel
        '
        CPLabel.AutoSize = True
        CPLabel.ForeColor = System.Drawing.Color.Blue
        CPLabel.Location = New System.Drawing.Point(431, 51)
        CPLabel.Name = "CPLabel"
        CPLabel.Size = New System.Drawing.Size(25, 15)
        CPLabel.TabIndex = 26
        CPLabel.Text = "CP:"
        '
        'WhatsAppLabel
        '
        WhatsAppLabel.AutoSize = True
        WhatsAppLabel.ForeColor = System.Drawing.Color.Blue
        WhatsAppLabel.Location = New System.Drawing.Point(53, 27)
        WhatsAppLabel.Name = "WhatsAppLabel"
        WhatsAppLabel.Size = New System.Drawing.Size(67, 15)
        WhatsAppLabel.TabIndex = 0
        WhatsAppLabel.Text = "Whats App:"
        '
        'YoutubeLabel
        '
        YoutubeLabel.AutoSize = True
        YoutubeLabel.ForeColor = System.Drawing.Color.Blue
        YoutubeLabel.Location = New System.Drawing.Point(65, 54)
        YoutubeLabel.Name = "YoutubeLabel"
        YoutubeLabel.Size = New System.Drawing.Size(55, 15)
        YoutubeLabel.TabIndex = 2
        YoutubeLabel.Text = "Youtube:"
        '
        'FacebookLabel
        '
        FacebookLabel.AutoSize = True
        FacebookLabel.ForeColor = System.Drawing.Color.Blue
        FacebookLabel.Location = New System.Drawing.Point(56, 81)
        FacebookLabel.Name = "FacebookLabel"
        FacebookLabel.Size = New System.Drawing.Size(64, 15)
        FacebookLabel.TabIndex = 4
        FacebookLabel.Text = "Facebook:"
        '
        'InstagramLabel
        '
        InstagramLabel.AutoSize = True
        InstagramLabel.ForeColor = System.Drawing.Color.Blue
        InstagramLabel.Location = New System.Drawing.Point(59, 108)
        InstagramLabel.Name = "InstagramLabel"
        InstagramLabel.Size = New System.Drawing.Size(61, 15)
        InstagramLabel.TabIndex = 6
        InstagramLabel.Text = "Instagram:"
        '
        'TikTokLabel
        '
        TikTokLabel.AutoSize = True
        TikTokLabel.ForeColor = System.Drawing.Color.Blue
        TikTokLabel.Location = New System.Drawing.Point(75, 135)
        TikTokLabel.Name = "TikTokLabel"
        TikTokLabel.Size = New System.Drawing.Size(45, 15)
        TikTokLabel.TabIndex = 8
        TikTokLabel.Text = "Tik Tok:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(408, 105)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 15)
        Label1.TabIndex = 33
        Label1.Text = "Default:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotasLabel.ForeColor = System.Drawing.Color.Blue
        NotasLabel.Location = New System.Drawing.Point(566, 287)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(41, 15)
        NotasLabel.TabIndex = 43
        NotasLabel.Text = "Notas:"
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbValidar, Me.ToolStripSeparator2, Me.tsbAgregar, Me.tsbCancelar, Me.tsbGuardar, Me.tsbBorrar, Me.tss01, Me.tsbPrimero, Me.tsbPrevio, Me.tsbSiguiente, Me.tsbUltimo, Me.ToolStripSeparator1, Me.tsbSalir})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(922, 40)
        Me.tsBotones.TabIndex = 3
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
        Me.tsbSiguiente.ToolTipText = " "
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
        Me.lblTitulo.Location = New System.Drawing.Point(0, 75)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(922, 30)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Catalogo: Datos Generales Despacho de Asesoría en Pensiones"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SSMensaje
        '
        Me.SSMensaje.AutoSize = False
        Me.SSMensaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.SSMensaje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.SSMensaje.Location = New System.Drawing.Point(0, 40)
        Me.SSMensaje.Name = "SSMensaje"
        Me.SSMensaje.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SSMensaje.Size = New System.Drawing.Size(922, 35)
        Me.SSMensaje.TabIndex = 12
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
        Me.tsslMensaje.Size = New System.Drawing.Size(895, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsslMensaje.ToolTipText = "Barra de Mensajes"
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Direccion", True))
        Me.txtDireccion.Location = New System.Drawing.Point(90, 48)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(307, 21)
        Me.txtDireccion.TabIndex = 3
        '
        'bsDespacho
        '
        Me.bsDespacho.DataMember = "Despacho"
        Me.bsDespacho.DataSource = Me.DsPensiones
        '
        'DsPensiones
        '
        Me.DsPensiones.DataSetName = "dsPensiones"
        Me.DsPensiones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtColonia
        '
        Me.txtColonia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Colonia", True))
        Me.txtColonia.Location = New System.Drawing.Point(90, 75)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(307, 21)
        Me.txtColonia.TabIndex = 7
        '
        'txtHorario
        '
        Me.txtHorario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Horario", True))
        Me.txtHorario.Location = New System.Drawing.Point(90, 241)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(100, 21)
        Me.txtHorario.TabIndex = 23
        Me.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiasLaborales
        '
        Me.txtDiasLaborales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "DiasLaborales", True))
        Me.txtDiasLaborales.Location = New System.Drawing.Point(297, 241)
        Me.txtDiasLaborales.Name = "txtDiasLaborales"
        Me.txtDiasLaborales.Size = New System.Drawing.Size(100, 21)
        Me.txtDiasLaborales.TabIndex = 25
        Me.txtDiasLaborales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.White
        Me.txtCelular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "TelCelular", True))
        Me.txtCelular.Location = New System.Drawing.Point(281, 132)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCelular.Mask = "00-0000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(116, 21)
        Me.txtCelular.TabIndex = 29
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "TelOficina", True))
        Me.txtTel.Location = New System.Drawing.Point(90, 132)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTel.Mask = "00-0000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(116, 21)
        Me.txtTel.TabIndex = 30
        Me.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbDespacho
        '
        Me.gbDespacho.Controls.Add(Me.txtCP)
        Me.gbDespacho.Controls.Add(Me.txtActiva)
        Me.gbDespacho.Controls.Add(Me.txtPais)
        Me.gbDespacho.Controls.Add(Me.txtNumero)
        Me.gbDespacho.Controls.Add(Me.txtSlogan)
        Me.gbDespacho.Controls.Add(Me.txtWeb)
        Me.gbDespacho.Controls.Add(Me.txtEmail)
        Me.gbDespacho.Controls.Add(Me.cboEstado)
        Me.gbDespacho.Controls.Add(Me.txtRazonSocial)
        Me.gbDespacho.Controls.Add(Label1)
        Me.gbDespacho.Controls.Add(Me.txtTel)
        Me.gbDespacho.Controls.Add(Me.txtCelular)
        Me.gbDespacho.Controls.Add(CPLabel)
        Me.gbDespacho.Controls.Add(DiasLaboralesLabel)
        Me.gbDespacho.Controls.Add(Me.txtDiasLaborales)
        Me.gbDespacho.Controls.Add(HorarioLabel)
        Me.gbDespacho.Controls.Add(Me.txtHorario)
        Me.gbDespacho.Controls.Add(SloganLabel)
        Me.gbDespacho.Controls.Add(WebLabel)
        Me.gbDespacho.Controls.Add(EmailLabel)
        Me.gbDespacho.Controls.Add(TelCelularLabel)
        Me.gbDespacho.Controls.Add(TelOficinaLabel)
        Me.gbDespacho.Controls.Add(PaisLabel)
        Me.gbDespacho.Controls.Add(EstadoLabel)
        Me.gbDespacho.Controls.Add(ColoniaLabel)
        Me.gbDespacho.Controls.Add(Me.txtColonia)
        Me.gbDespacho.Controls.Add(NumeroLabel)
        Me.gbDespacho.Controls.Add(DireccionLabel)
        Me.gbDespacho.Controls.Add(Me.txtDireccion)
        Me.gbDespacho.Controls.Add(RazonSocialLabel)
        Me.gbDespacho.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDespacho.ForeColor = System.Drawing.Color.Maroon
        Me.gbDespacho.Location = New System.Drawing.Point(6, 118)
        Me.gbDespacho.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDespacho.Name = "gbDespacho"
        Me.gbDespacho.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDespacho.Size = New System.Drawing.Size(553, 282)
        Me.gbDespacho.TabIndex = 13
        Me.gbDespacho.TabStop = False
        Me.gbDespacho.Text = "Despacho"
        '
        'txtCP
        '
        Me.txtCP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "CP", True))
        Me.txtCP.Location = New System.Drawing.Point(462, 48)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(84, 21)
        Me.txtCP.TabIndex = 43
        '
        'txtActiva
        '
        Me.txtActiva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Activa", True))
        Me.txtActiva.Location = New System.Drawing.Point(462, 102)
        Me.txtActiva.Name = "txtActiva"
        Me.txtActiva.Size = New System.Drawing.Size(33, 21)
        Me.txtActiva.TabIndex = 42
        Me.txtActiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPais
        '
        Me.txtPais.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Pais", True))
        Me.txtPais.Location = New System.Drawing.Point(462, 75)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(84, 21)
        Me.txtPais.TabIndex = 41
        '
        'txtNumero
        '
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Numero", True))
        Me.txtNumero.Location = New System.Drawing.Point(462, 21)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(84, 21)
        Me.txtNumero.TabIndex = 39
        '
        'txtSlogan
        '
        Me.txtSlogan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Slogan", True))
        Me.txtSlogan.Location = New System.Drawing.Point(90, 214)
        Me.txtSlogan.Name = "txtSlogan"
        Me.txtSlogan.Size = New System.Drawing.Size(307, 21)
        Me.txtSlogan.TabIndex = 38
        '
        'txtWeb
        '
        Me.txtWeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Web", True))
        Me.txtWeb.Location = New System.Drawing.Point(90, 187)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(307, 21)
        Me.txtWeb.TabIndex = 37
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(90, 160)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 21)
        Me.txtEmail.TabIndex = 36
        '
        'cboEstado
        '
        Me.cboEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Estado", True))
        Me.cboEstado.DataSource = Me.bsEstadosMx
        Me.cboEstado.DisplayMember = "Estado"
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(90, 102)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(307, 23)
        Me.cboEstado.TabIndex = 35
        '
        'bsEstadosMx
        '
        Me.bsEstadosMx.DataMember = "EstadosMx"
        Me.bsEstadosMx.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "RazonSocial", True))
        Me.txtRazonSocial.Location = New System.Drawing.Point(90, 21)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(307, 21)
        Me.txtRazonSocial.TabIndex = 34
        '
        'txtYoutube
        '
        Me.txtYoutube.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Youtube", True))
        Me.txtYoutube.Location = New System.Drawing.Point(126, 51)
        Me.txtYoutube.Name = "txtYoutube"
        Me.txtYoutube.Size = New System.Drawing.Size(152, 21)
        Me.txtYoutube.TabIndex = 3
        '
        'txtFacebook
        '
        Me.txtFacebook.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Facebook", True))
        Me.txtFacebook.Location = New System.Drawing.Point(126, 78)
        Me.txtFacebook.Name = "txtFacebook"
        Me.txtFacebook.Size = New System.Drawing.Size(152, 21)
        Me.txtFacebook.TabIndex = 5
        '
        'txtInstagram
        '
        Me.txtInstagram.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Instagram", True))
        Me.txtInstagram.Location = New System.Drawing.Point(126, 105)
        Me.txtInstagram.Name = "txtInstagram"
        Me.txtInstagram.Size = New System.Drawing.Size(152, 21)
        Me.txtInstagram.TabIndex = 7
        '
        'txtTikTok
        '
        Me.txtTikTok.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "TikTok", True))
        Me.txtTikTok.Location = New System.Drawing.Point(126, 132)
        Me.txtTikTok.Name = "txtTikTok"
        Me.txtTikTok.Size = New System.Drawing.Size(152, 21)
        Me.txtTikTok.TabIndex = 9
        '
        'gbRedes
        '
        Me.gbRedes.Controls.Add(Me.txtWhatsApp)
        Me.gbRedes.Controls.Add(TikTokLabel)
        Me.gbRedes.Controls.Add(Me.txtTikTok)
        Me.gbRedes.Controls.Add(InstagramLabel)
        Me.gbRedes.Controls.Add(Me.txtInstagram)
        Me.gbRedes.Controls.Add(FacebookLabel)
        Me.gbRedes.Controls.Add(Me.txtFacebook)
        Me.gbRedes.Controls.Add(YoutubeLabel)
        Me.gbRedes.Controls.Add(Me.txtYoutube)
        Me.gbRedes.Controls.Add(WhatsAppLabel)
        Me.gbRedes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRedes.ForeColor = System.Drawing.Color.Maroon
        Me.gbRedes.Location = New System.Drawing.Point(569, 118)
        Me.gbRedes.Name = "gbRedes"
        Me.gbRedes.Size = New System.Drawing.Size(341, 169)
        Me.gbRedes.TabIndex = 15
        Me.gbRedes.TabStop = False
        Me.gbRedes.Text = "Redes Sociales"
        '
        'txtWhatsApp
        '
        Me.txtWhatsApp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "WhatsApp", True))
        Me.txtWhatsApp.Location = New System.Drawing.Point(126, 24)
        Me.txtWhatsApp.Mask = "00-0000-0000"
        Me.txtWhatsApp.Name = "txtWhatsApp"
        Me.txtWhatsApp.Size = New System.Drawing.Size(152, 21)
        Me.txtWhatsApp.TabIndex = 10
        Me.txtWhatsApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EstadosMxTableAdapter
        '
        Me.EstadosMxTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ActividadesTITableAdapter = Nothing
        Me.TableAdapterManager1.AforesTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CuantiasLey1973arTableAdapter = Nothing
        Me.TableAdapterManager1.CuantiasLey1973TableAdapter = Nothing
        Me.TableAdapterManager1.CuantiasLey1997TableAdapter = Nothing
        Me.TableAdapterManager1.DespachoTableAdapter = Nothing
        Me.TableAdapterManager1.EstadosMxTableAdapter = Me.EstadosMxTableAdapter
        Me.TableAdapterManager1.InflacionAnualTableAdapter = Nothing
        Me.TableAdapterManager1.INPCTableAdapter = Nothing
        Me.TableAdapterManager1.ISRTableAdapter = Nothing
        Me.TableAdapterManager1.LeyIMSSTableAdapter = Nothing
        Me.TableAdapterManager1.LeySegPenTableAdapter = Nothing
        Me.TableAdapterManager1.Modalidad33TableAdapter = Nothing
        Me.TableAdapterManager1.PctSegurosM40TableAdapter = Nothing
        Me.TableAdapterManager1.PensionTableAdapter = Nothing
        Me.TableAdapterManager1.PrimaRiesgoTrabajoTableAdapter = Nothing
        Me.TableAdapterManager1.RegimenIMSSTableAdapter = Nothing
        Me.TableAdapterManager1.SeguroTableAdapter = Nothing
        Me.TableAdapterManager1.SubActividadesTITableAdapter = Nothing
        Me.TableAdapterManager1.TopadoSMG_UMATableAdapter = Nothing
        Me.TableAdapterManager1.UMATableAdapter = Nothing
        Me.TableAdapterManager1.UMFTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DespachoTableAdapter
        '
        Me.DespachoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DespachoTableAdapter = Me.DespachoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsPensionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDespacho, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(569, 300)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(341, 100)
        Me.NotasTextBox.TabIndex = 44
        '
        'foEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(922, 417)
        Me.Controls.Add(NotasLabel)
        Me.Controls.Add(Me.gbRedes)
        Me.Controls.Add(Me.NotasTextBox)
        Me.Controls.Add(Me.gbDespacho)
        Me.Controls.Add(Me.SSMensaje)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Despacho"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.SSMensaje.ResumeLayout(False)
        Me.SSMensaje.PerformLayout()
        CType(Me.bsDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPensiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDespacho.ResumeLayout(False)
        Me.gbDespacho.PerformLayout()
        CType(Me.bsEstadosMx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRedes.ResumeLayout(False)
        Me.gbRedes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents tsbValidar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbAgregar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbBorrar As ToolStripButton
    Friend WithEvents tss01 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents SSMensaje As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents tsbPrimero As ToolStripButton
    Friend WithEvents tsbPrevio As ToolStripButton
    Friend WithEvents tsbSiguiente As ToolStripButton
    Friend WithEvents tsbUltimo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtHorario As TextBox
    Friend WithEvents txtDiasLaborales As TextBox
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents gbDespacho As GroupBox
    Friend WithEvents txtYoutube As TextBox
    Friend WithEvents txtFacebook As TextBox
    Friend WithEvents txtInstagram As TextBox
    Friend WithEvents txtTikTok As TextBox
    Friend WithEvents gbRedes As GroupBox
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents bsEstadosMx As BindingSource
    Friend WithEvents EstadosMxTableAdapter As dsCatalogosTableAdapters.EstadosMxTableAdapter
    Friend WithEvents DsPensiones As dsPensiones
    Friend WithEvents bsDespacho As BindingSource
    Friend WithEvents DespachoTableAdapter As dsPensionesTableAdapters.DespachoTableAdapter
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents TableAdapterManager As dsPensionesTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager1 As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtSlogan As TextBox
    Friend WithEvents txtWeb As TextBox
    Friend WithEvents txtActiva As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtWhatsApp As MaskedTextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents NotasTextBox As TextBox
End Class

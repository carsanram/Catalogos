<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class foExportaCatalogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foExportaCatalogos))
        Me.tsBotones = New System.Windows.Forms.ToolStrip()
        Me.tsbExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.pbProceso = New System.Windows.Forms.ToolStripProgressBar()
        Me.stBotones = New System.Windows.Forms.StatusStrip()
        Me.tsslMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkM33 = New System.Windows.Forms.CheckBox()
        Me.chkActividadesTI = New System.Windows.Forms.CheckBox()
        Me.chkRTPrima = New System.Windows.Forms.CheckBox()
        Me.chkSegPen = New System.Windows.Forms.CheckBox()
        Me.chkModalidades = New System.Windows.Forms.CheckBox()
        Me.chkDespacho = New System.Windows.Forms.CheckBox()
        Me.chkUMA = New System.Windows.Forms.CheckBox()
        Me.chkPctM40 = New System.Windows.Forms.CheckBox()
        Me.chkINEGI = New System.Windows.Forms.CheckBox()
        Me.chkISR = New System.Windows.Forms.CheckBox()
        Me.chkINPC = New System.Windows.Forms.CheckBox()
        Me.chkEstados = New System.Windows.Forms.CheckBox()
        Me.chkDelegacion = New System.Windows.Forms.CheckBox()
        Me.chkTopados = New System.Windows.Forms.CheckBox()
        Me.chkCuantias97 = New System.Windows.Forms.CheckBox()
        Me.chkCuantias73AR = New System.Windows.Forms.CheckBox()
        Me.chkCuantias73 = New System.Windows.Forms.CheckBox()
        Me.chkAfores = New System.Windows.Forms.CheckBox()
        Me.AforesTableAdapter = New Catalogos.dsCatalogosTableAdapters.AforesTableAdapter()
        Me.bsAfores = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New Catalogos.dsCatalogos()
        Me.bsCuantia73ar = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuantiasLey1973arTableAdapter = New Catalogos.dsCatalogosTableAdapters.CuantiasLey1973arTableAdapter()
        Me.bsCuantia73 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuantiasLey1973TableAdapter = New Catalogos.dsCatalogosTableAdapters.CuantiasLey1973TableAdapter()
        Me.bsCuantias97 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuantiasLey1997TableAdapter = New Catalogos.dsCatalogosTableAdapters.CuantiasLey1997TableAdapter()
        Me.bsEstados = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadosMxTableAdapter = New Catalogos.dsCatalogosTableAdapters.EstadosMxTableAdapter()
        Me.bsTopados = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopadoSMG_UMATableAdapter = New Catalogos.dsCatalogosTableAdapters.TopadoSMG_UMATableAdapter()
        Me.bsDelegacdiones = New System.Windows.Forms.BindingSource(Me.components)
        Me.UMFTableAdapter = New Catalogos.dsCatalogosTableAdapters.UMFTableAdapter()
        Me.bsINPC = New System.Windows.Forms.BindingSource(Me.components)
        Me.INPCTableAdapter = New Catalogos.dsCatalogosTableAdapters.INPCTableAdapter()
        Me.bsINEGI = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsISR = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISRTableAdapter = New Catalogos.dsCatalogosTableAdapters.ISRTableAdapter()
        Me.bsPctM40 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PctSegurosM40TableAdapter = New Catalogos.dsCatalogosTableAdapters.PctSegurosM40TableAdapter()
        Me.bsSeuyPen = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeySegPenTableAdapter = New Catalogos.dsCatalogosTableAdapters.LeySegPenTableAdapter()
        Me.bsUMA = New System.Windows.Forms.BindingSource(Me.components)
        Me.UMATableAdapter = New Catalogos.dsCatalogosTableAdapters.UMATableAdapter()
        Me.bsDespacho = New System.Windows.Forms.BindingSource(Me.components)
        Me.DespachoTableAdapter = New Catalogos.dsCatalogosTableAdapters.DespachoTableAdapter()
        Me.bsModdalidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegimenIMSSTableAdapter = New Catalogos.dsCatalogosTableAdapters.RegimenIMSSTableAdapter()
        Me.InflacionAnualTableAdapter = New Catalogos.dsCatalogosTableAdapters.InflacionAnualTableAdapter()
        Me.dgAfores = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sfdExportar = New System.Windows.Forms.SaveFileDialog()
        Me.dgCuantia73AR = New System.Windows.Forms.DataGridView()
        Me.SalarioInicialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaBaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCuantia73 = New System.Windows.Forms.DataGridView()
        Me.LimInferior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimSuperior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pctCuantiaBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pctCuantiaAdicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimInferiorDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimSuperiorDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaBaseDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCuantia97 = New System.Windows.Forms.DataGridView()
        Me.Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñosPension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PensionGarantizada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemCotInferior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemCotSupeior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñosPensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimInferiorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimSuperiorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PensionGarantizadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemCotInferiorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemCotSupeiorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgEstados = New System.Windows.Forms.DataGridView()
        Me.Cve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTopados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Topado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDelegaciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delegacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subdelegacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelegacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubdelegacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MunicipioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgINPC = New System.Windows.Forms.DataGridView()
        Me.YearsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorRecargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgINEGI = New System.Windows.Forms.DataGridView()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InflacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgISR = New System.Windows.Forms.DataGridView()
        Me.LimInferiorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimSuperiorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaFijaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctExeLimInfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgPctM40 = New System.Windows.Forms.DataGridView()
        Me.AnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBCinfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBCsupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpRetiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcteCAVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpCAVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcteIVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpIVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcteGMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctpGMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSeguros = New System.Windows.Forms.DataGridView()
        Me.LeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgUMA = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMADia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMAMensual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMAAnual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMGDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMGMensual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMGAnual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelUMA_SMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estimada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMADiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMAMensualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMAAnualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMGDiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMGMensualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SMGAnualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelUMASMGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimadaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDespacho = New System.Windows.Forms.DataGridView()
        Me.SloganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelOficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelCelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasLaboralesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhatsAppDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YoutubeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacebookDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstagramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TikTokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgModalidades = New System.Windows.Forms.DataGridView()
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
        Me.chkSeleccion = New System.Windows.Forms.CheckBox()
        Me.bsRTPrima = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimaRiesgoTrabajoTableAdapter = New Catalogos.dsCatalogosTableAdapters.PrimaRiesgoTrabajoTableAdapter()
        Me.dgRTPrima = New System.Windows.Forms.DataGridView()
        Me.dgM33 = New System.Windows.Forms.DataGridView()
        Me.bsM33 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modalidad33TableAdapter = New Catalogos.dsCatalogosTableAdapters.Modalidad33TableAdapter()
        Me.TableAdapterManager = New Catalogos.dsCatalogosTableAdapters.TableAdapterManager()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActividadesTableAdapter = New Catalogos.dsCatalogosTableAdapters.ActividadesTableAdapter()
        Me.dgActividades = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimInf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimSup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsBotones.SuspendLayout()
        Me.stBotones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsAfores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCuantia73ar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCuantia73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCuantias97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTopados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDelegacdiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsINPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsINEGI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsISR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPctM40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSeuyPen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsModdalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAfores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuantia73AR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuantia73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuantia97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTopados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDelegaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgINPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgINEGI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgISR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPctM40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgModalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRTPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRTPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgM33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsM33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsBotones
        '
        Me.tsBotones.AutoSize = False
        Me.tsBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tsBotones.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExcel, Me.ToolStripSeparator1, Me.tsbSalir, Me.pbProceso})
        Me.tsBotones.Location = New System.Drawing.Point(0, 0)
        Me.tsBotones.Name = "tsBotones"
        Me.tsBotones.Size = New System.Drawing.Size(433, 40)
        Me.tsBotones.TabIndex = 3
        Me.tsBotones.Text = "Acciones"
        '
        'tsbExcel
        '
        Me.tsbExcel.AutoSize = False
        Me.tsbExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExcel.Image = CType(resources.GetObject("tsbExcel.Image"), System.Drawing.Image)
        Me.tsbExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExcel.Margin = New System.Windows.Forms.Padding(2, 1, 1, 1)
        Me.tsbExcel.Name = "tsbExcel"
        Me.tsbExcel.Size = New System.Drawing.Size(40, 40)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(20, 50)
        '
        'tsbSalir
        '
        Me.tsbSalir.AutoSize = False
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Margin = New System.Windows.Forms.Padding(2, 1, 1, 1)
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(40, 40)
        '
        'pbProceso
        '
        Me.pbProceso.AutoSize = False
        Me.pbProceso.Name = "pbProceso"
        Me.pbProceso.Size = New System.Drawing.Size(150, 15)
        '
        'stBotones
        '
        Me.stBotones.AutoSize = False
        Me.stBotones.BackColor = System.Drawing.SystemColors.Control
        Me.stBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.stBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMensaje})
        Me.stBotones.Location = New System.Drawing.Point(0, 40)
        Me.stBotones.Name = "stBotones"
        Me.stBotones.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.stBotones.Size = New System.Drawing.Size(433, 35)
        Me.stBotones.TabIndex = 20
        Me.stBotones.Text = "StatusStrip"
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
        Me.tsslMensaje.Size = New System.Drawing.Size(410, 30)
        Me.tsslMensaje.Text = "Seleccione la Opción Deseada"
        Me.tsslMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitulo.Location = New System.Drawing.Point(0, 75)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(432, 30)
        Me.lblTitulo.TabIndex = 21
        Me.lblTitulo.Text = "Exportar Catalogos a Excel"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkM33)
        Me.GroupBox1.Controls.Add(Me.chkActividadesTI)
        Me.GroupBox1.Controls.Add(Me.chkRTPrima)
        Me.GroupBox1.Controls.Add(Me.chkSegPen)
        Me.GroupBox1.Controls.Add(Me.chkModalidades)
        Me.GroupBox1.Controls.Add(Me.chkDespacho)
        Me.GroupBox1.Controls.Add(Me.chkUMA)
        Me.GroupBox1.Controls.Add(Me.chkPctM40)
        Me.GroupBox1.Controls.Add(Me.chkINEGI)
        Me.GroupBox1.Controls.Add(Me.chkISR)
        Me.GroupBox1.Controls.Add(Me.chkINPC)
        Me.GroupBox1.Controls.Add(Me.chkEstados)
        Me.GroupBox1.Controls.Add(Me.chkDelegacion)
        Me.GroupBox1.Controls.Add(Me.chkTopados)
        Me.GroupBox1.Controls.Add(Me.chkCuantias97)
        Me.GroupBox1.Controls.Add(Me.chkCuantias73AR)
        Me.GroupBox1.Controls.Add(Me.chkCuantias73)
        Me.GroupBox1.Controls.Add(Me.chkAfores)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 209)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'chkM33
        '
        Me.chkM33.AutoSize = True
        Me.chkM33.ForeColor = System.Drawing.Color.Blue
        Me.chkM33.Location = New System.Drawing.Point(279, 104)
        Me.chkM33.Name = "chkM33"
        Me.chkM33.Size = New System.Drawing.Size(88, 19)
        Me.chkM33.TabIndex = 17
        Me.chkM33.Text = "Cuotas M33"
        Me.chkM33.UseVisualStyleBackColor = True
        '
        'chkActividadesTI
        '
        Me.chkActividadesTI.AutoSize = True
        Me.chkActividadesTI.ForeColor = System.Drawing.Color.Blue
        Me.chkActividadesTI.Location = New System.Drawing.Point(279, 79)
        Me.chkActividadesTI.Name = "chkActividadesTI"
        Me.chkActividadesTI.Size = New System.Drawing.Size(99, 19)
        Me.chkActividadesTI.TabIndex = 16
        Me.chkActividadesTI.Text = "Actividades TI"
        Me.chkActividadesTI.UseVisualStyleBackColor = True
        '
        'chkRTPrima
        '
        Me.chkRTPrima.AutoSize = True
        Me.chkRTPrima.ForeColor = System.Drawing.Color.Blue
        Me.chkRTPrima.Location = New System.Drawing.Point(279, 54)
        Me.chkRTPrima.Name = "chkRTPrima"
        Me.chkRTPrima.Size = New System.Drawing.Size(81, 19)
        Me.chkRTPrima.TabIndex = 15
        Me.chkRTPrima.Text = "Prima RT TI"
        Me.chkRTPrima.UseVisualStyleBackColor = True
        '
        'chkSegPen
        '
        Me.chkSegPen.AutoSize = True
        Me.chkSegPen.ForeColor = System.Drawing.Color.Blue
        Me.chkSegPen.Location = New System.Drawing.Point(138, 129)
        Me.chkSegPen.Name = "chkSegPen"
        Me.chkSegPen.Size = New System.Drawing.Size(136, 19)
        Me.chkSegPen.TabIndex = 14
        Me.chkSegPen.Text = "Seguros y Pensiones"
        Me.chkSegPen.UseVisualStyleBackColor = True
        '
        'chkModalidades
        '
        Me.chkModalidades.AutoSize = True
        Me.chkModalidades.ForeColor = System.Drawing.Color.Blue
        Me.chkModalidades.Location = New System.Drawing.Point(279, 29)
        Me.chkModalidades.Name = "chkModalidades"
        Me.chkModalidades.Size = New System.Drawing.Size(103, 19)
        Me.chkModalidades.TabIndex = 13
        Me.chkModalidades.Text = "Moddalidades"
        Me.chkModalidades.UseVisualStyleBackColor = True
        '
        'chkDespacho
        '
        Me.chkDespacho.AutoSize = True
        Me.chkDespacho.ForeColor = System.Drawing.Color.Blue
        Me.chkDespacho.Location = New System.Drawing.Point(138, 179)
        Me.chkDespacho.Name = "chkDespacho"
        Me.chkDespacho.Size = New System.Drawing.Size(132, 19)
        Me.chkDespacho.TabIndex = 12
        Me.chkDespacho.Text = "Despacho Asesores"
        Me.chkDespacho.UseVisualStyleBackColor = True
        '
        'chkUMA
        '
        Me.chkUMA.AutoSize = True
        Me.chkUMA.ForeColor = System.Drawing.Color.Blue
        Me.chkUMA.Location = New System.Drawing.Point(138, 154)
        Me.chkUMA.Name = "chkUMA"
        Me.chkUMA.Size = New System.Drawing.Size(88, 19)
        Me.chkUMA.TabIndex = 11
        Me.chkUMA.Text = "UMA y SMG"
        Me.chkUMA.UseVisualStyleBackColor = True
        '
        'chkPctM40
        '
        Me.chkPctM40.AutoSize = True
        Me.chkPctM40.ForeColor = System.Drawing.Color.Blue
        Me.chkPctM40.Location = New System.Drawing.Point(138, 104)
        Me.chkPctM40.Name = "chkPctM40"
        Me.chkPctM40.Size = New System.Drawing.Size(106, 19)
        Me.chkPctM40.TabIndex = 10
        Me.chkPctM40.Text = "% Seguros M40"
        Me.chkPctM40.UseVisualStyleBackColor = True
        '
        'chkINEGI
        '
        Me.chkINEGI.AutoSize = True
        Me.chkINEGI.ForeColor = System.Drawing.Color.Blue
        Me.chkINEGI.Location = New System.Drawing.Point(138, 54)
        Me.chkINEGI.Name = "chkINEGI"
        Me.chkINEGI.Size = New System.Drawing.Size(107, 19)
        Me.chkINEGI.TabIndex = 9
        Me.chkINEGI.Text = "Inflación Anual"
        Me.chkINEGI.UseVisualStyleBackColor = True
        '
        'chkISR
        '
        Me.chkISR.AutoSize = True
        Me.chkISR.ForeColor = System.Drawing.Color.Blue
        Me.chkISR.Location = New System.Drawing.Point(138, 79)
        Me.chkISR.Name = "chkISR"
        Me.chkISR.Size = New System.Drawing.Size(41, 19)
        Me.chkISR.TabIndex = 8
        Me.chkISR.Text = "ISR"
        Me.chkISR.UseVisualStyleBackColor = True
        '
        'chkINPC
        '
        Me.chkINPC.AutoSize = True
        Me.chkINPC.ForeColor = System.Drawing.Color.Blue
        Me.chkINPC.Location = New System.Drawing.Point(138, 29)
        Me.chkINPC.Name = "chkINPC"
        Me.chkINPC.Size = New System.Drawing.Size(93, 19)
        Me.chkINPC.TabIndex = 7
        Me.chkINPC.Text = "Indices INPC"
        Me.chkINPC.UseVisualStyleBackColor = True
        '
        'chkEstados
        '
        Me.chkEstados.AutoSize = True
        Me.chkEstados.ForeColor = System.Drawing.Color.Blue
        Me.chkEstados.Location = New System.Drawing.Point(28, 179)
        Me.chkEstados.Name = "chkEstados"
        Me.chkEstados.Size = New System.Drawing.Size(66, 19)
        Me.chkEstados.TabIndex = 6
        Me.chkEstados.Text = "Estados"
        Me.chkEstados.UseVisualStyleBackColor = True
        '
        'chkDelegacion
        '
        Me.chkDelegacion.AutoSize = True
        Me.chkDelegacion.ForeColor = System.Drawing.Color.Blue
        Me.chkDelegacion.Location = New System.Drawing.Point(28, 154)
        Me.chkDelegacion.Name = "chkDelegacion"
        Me.chkDelegacion.Size = New System.Drawing.Size(101, 19)
        Me.chkDelegacion.TabIndex = 5
        Me.chkDelegacion.Text = "Delegaciones"
        Me.chkDelegacion.UseVisualStyleBackColor = True
        '
        'chkTopados
        '
        Me.chkTopados.AutoSize = True
        Me.chkTopados.ForeColor = System.Drawing.Color.Blue
        Me.chkTopados.Location = New System.Drawing.Point(28, 129)
        Me.chkTopados.Name = "chkTopados"
        Me.chkTopados.Size = New System.Drawing.Size(95, 19)
        Me.chkTopados.TabIndex = 4
        Me.chkTopados.Text = "SBC Topados"
        Me.chkTopados.UseVisualStyleBackColor = True
        '
        'chkCuantias97
        '
        Me.chkCuantias97.AutoSize = True
        Me.chkCuantias97.ForeColor = System.Drawing.Color.Blue
        Me.chkCuantias97.Location = New System.Drawing.Point(28, 104)
        Me.chkCuantias97.Name = "chkCuantias97"
        Me.chkCuantias97.Size = New System.Drawing.Size(88, 19)
        Me.chkCuantias97.TabIndex = 3
        Me.chkCuantias97.Text = "Cuantias 97"
        Me.chkCuantias97.UseVisualStyleBackColor = True
        '
        'chkCuantias73AR
        '
        Me.chkCuantias73AR.AutoSize = True
        Me.chkCuantias73AR.ForeColor = System.Drawing.Color.Blue
        Me.chkCuantias73AR.Location = New System.Drawing.Point(28, 54)
        Me.chkCuantias73AR.Name = "chkCuantias73AR"
        Me.chkCuantias73AR.Size = New System.Drawing.Size(106, 19)
        Me.chkCuantias73AR.TabIndex = 2
        Me.chkCuantias73AR.Text = "Cuantias 73 AR"
        Me.chkCuantias73AR.UseVisualStyleBackColor = True
        '
        'chkCuantias73
        '
        Me.chkCuantias73.AutoSize = True
        Me.chkCuantias73.ForeColor = System.Drawing.Color.Blue
        Me.chkCuantias73.Location = New System.Drawing.Point(28, 79)
        Me.chkCuantias73.Name = "chkCuantias73"
        Me.chkCuantias73.Size = New System.Drawing.Size(85, 19)
        Me.chkCuantias73.TabIndex = 1
        Me.chkCuantias73.Text = "Cuantias73"
        Me.chkCuantias73.UseVisualStyleBackColor = True
        '
        'chkAfores
        '
        Me.chkAfores.AutoSize = True
        Me.chkAfores.ForeColor = System.Drawing.Color.Blue
        Me.chkAfores.Location = New System.Drawing.Point(28, 29)
        Me.chkAfores.Name = "chkAfores"
        Me.chkAfores.Size = New System.Drawing.Size(60, 19)
        Me.chkAfores.TabIndex = 0
        Me.chkAfores.Text = "Afores"
        Me.chkAfores.UseVisualStyleBackColor = True
        '
        'AforesTableAdapter
        '
        Me.AforesTableAdapter.ClearBeforeFill = True
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
        'bsCuantia73ar
        '
        Me.bsCuantia73ar.DataMember = "CuantiasLey1973ar"
        Me.bsCuantia73ar.DataSource = Me.DsCatalogos
        '
        'CuantiasLey1973arTableAdapter
        '
        Me.CuantiasLey1973arTableAdapter.ClearBeforeFill = True
        '
        'bsCuantia73
        '
        Me.bsCuantia73.DataMember = "CuantiasLey1973"
        Me.bsCuantia73.DataSource = Me.DsCatalogos
        '
        'CuantiasLey1973TableAdapter
        '
        Me.CuantiasLey1973TableAdapter.ClearBeforeFill = True
        '
        'bsCuantias97
        '
        Me.bsCuantias97.DataMember = "CuantiasLey1997"
        Me.bsCuantias97.DataSource = Me.DsCatalogos
        '
        'CuantiasLey1997TableAdapter
        '
        Me.CuantiasLey1997TableAdapter.ClearBeforeFill = True
        '
        'bsEstados
        '
        Me.bsEstados.DataMember = "EstadosMx"
        Me.bsEstados.DataSource = Me.DsCatalogos
        '
        'EstadosMxTableAdapter
        '
        Me.EstadosMxTableAdapter.ClearBeforeFill = True
        '
        'bsTopados
        '
        Me.bsTopados.DataMember = "TopadoSMG-UMA"
        Me.bsTopados.DataSource = Me.DsCatalogos
        '
        'TopadoSMG_UMATableAdapter
        '
        Me.TopadoSMG_UMATableAdapter.ClearBeforeFill = True
        '
        'bsDelegacdiones
        '
        Me.bsDelegacdiones.DataMember = "UMF"
        Me.bsDelegacdiones.DataSource = Me.DsCatalogos
        '
        'UMFTableAdapter
        '
        Me.UMFTableAdapter.ClearBeforeFill = True
        '
        'bsINPC
        '
        Me.bsINPC.DataMember = "INPC"
        Me.bsINPC.DataSource = Me.DsCatalogos
        '
        'INPCTableAdapter
        '
        Me.INPCTableAdapter.ClearBeforeFill = True
        '
        'bsINEGI
        '
        Me.bsINEGI.DataMember = "InflacionAnual"
        Me.bsINEGI.DataSource = Me.DsCatalogos
        '
        'bsISR
        '
        Me.bsISR.DataMember = "ISR"
        Me.bsISR.DataSource = Me.DsCatalogos
        '
        'ISRTableAdapter
        '
        Me.ISRTableAdapter.ClearBeforeFill = True
        '
        'bsPctM40
        '
        Me.bsPctM40.DataMember = "PctSegurosM40"
        Me.bsPctM40.DataSource = Me.DsCatalogos
        '
        'PctSegurosM40TableAdapter
        '
        Me.PctSegurosM40TableAdapter.ClearBeforeFill = True
        '
        'bsSeuyPen
        '
        Me.bsSeuyPen.DataMember = "LeySegPen"
        Me.bsSeuyPen.DataSource = Me.DsCatalogos
        '
        'LeySegPenTableAdapter
        '
        Me.LeySegPenTableAdapter.ClearBeforeFill = True
        '
        'bsUMA
        '
        Me.bsUMA.DataMember = "UMA"
        Me.bsUMA.DataSource = Me.DsCatalogos
        '
        'UMATableAdapter
        '
        Me.UMATableAdapter.ClearBeforeFill = True
        '
        'bsDespacho
        '
        Me.bsDespacho.DataMember = "Despacho"
        Me.bsDespacho.DataSource = Me.DsCatalogos
        '
        'DespachoTableAdapter
        '
        Me.DespachoTableAdapter.ClearBeforeFill = True
        '
        'bsModdalidades
        '
        Me.bsModdalidades.DataMember = "RegimenIMSS"
        Me.bsModdalidades.DataSource = Me.DsCatalogos
        '
        'RegimenIMSSTableAdapter
        '
        Me.RegimenIMSSTableAdapter.ClearBeforeFill = True
        '
        'InflacionAnualTableAdapter
        '
        Me.InflacionAnualTableAdapter.ClearBeforeFill = True
        '
        'dgAfores
        '
        Me.dgAfores.AutoGenerateColumns = False
        Me.dgAfores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAfores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.WebDataGridViewTextBoxColumn, Me.ContactoDataGridViewTextBoxColumn, Me.NotasDataGridViewTextBoxColumn})
        Me.dgAfores.DataSource = Me.bsAfores
        Me.dgAfores.Location = New System.Drawing.Point(439, 78)
        Me.dgAfores.Name = "dgAfores"
        Me.dgAfores.Size = New System.Drawing.Size(406, 62)
        Me.dgAfores.TabIndex = 15
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'WebDataGridViewTextBoxColumn
        '
        Me.WebDataGridViewTextBoxColumn.DataPropertyName = "Web"
        Me.WebDataGridViewTextBoxColumn.HeaderText = "Web"
        Me.WebDataGridViewTextBoxColumn.Name = "WebDataGridViewTextBoxColumn"
        '
        'ContactoDataGridViewTextBoxColumn
        '
        Me.ContactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto"
        Me.ContactoDataGridViewTextBoxColumn.HeaderText = "Contacto"
        Me.ContactoDataGridViewTextBoxColumn.Name = "ContactoDataGridViewTextBoxColumn"
        '
        'NotasDataGridViewTextBoxColumn
        '
        Me.NotasDataGridViewTextBoxColumn.DataPropertyName = "Notas"
        Me.NotasDataGridViewTextBoxColumn.HeaderText = "Notas"
        Me.NotasDataGridViewTextBoxColumn.Name = "NotasDataGridViewTextBoxColumn"
        '
        'dgCuantia73AR
        '
        Me.dgCuantia73AR.AutoGenerateColumns = False
        Me.dgCuantia73AR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuantia73AR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalarioInicialDataGridViewTextBoxColumn, Me.SalarioFinalDataGridViewTextBoxColumn, Me.PctCuantiaBaseDataGridViewTextBoxColumn, Me.PctCuantiaAdicionalDataGridViewTextBoxColumn})
        Me.dgCuantia73AR.DataSource = Me.bsCuantia73ar
        Me.dgCuantia73AR.Location = New System.Drawing.Point(439, 81)
        Me.dgCuantia73AR.Name = "dgCuantia73AR"
        Me.dgCuantia73AR.Size = New System.Drawing.Size(406, 62)
        Me.dgCuantia73AR.TabIndex = 23
        '
        'SalarioInicialDataGridViewTextBoxColumn
        '
        Me.SalarioInicialDataGridViewTextBoxColumn.DataPropertyName = "SalarioInicial"
        Me.SalarioInicialDataGridViewTextBoxColumn.HeaderText = "Salario Inicial"
        Me.SalarioInicialDataGridViewTextBoxColumn.Name = "SalarioInicialDataGridViewTextBoxColumn"
        '
        'SalarioFinalDataGridViewTextBoxColumn
        '
        Me.SalarioFinalDataGridViewTextBoxColumn.DataPropertyName = "SalarioFinal"
        Me.SalarioFinalDataGridViewTextBoxColumn.HeaderText = "Salario Final"
        Me.SalarioFinalDataGridViewTextBoxColumn.Name = "SalarioFinalDataGridViewTextBoxColumn"
        '
        'PctCuantiaBaseDataGridViewTextBoxColumn
        '
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.DataPropertyName = "pctCuantiaBase"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.HeaderText = "% Cuantia Base"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn.Name = "PctCuantiaBaseDataGridViewTextBoxColumn"
        '
        'PctCuantiaAdicionalDataGridViewTextBoxColumn
        '
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.DataPropertyName = "pctCuantiaAdicional"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.HeaderText = "% Cuantia Adicional"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn.Name = "PctCuantiaAdicionalDataGridViewTextBoxColumn"
        '
        'dgCuantia73
        '
        Me.dgCuantia73.AutoGenerateColumns = False
        Me.dgCuantia73.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuantia73.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LimInferior, Me.LimSuperior, Me.pctCuantiaBase, Me.pctCuantiaAdicional, Me.IdDataGridViewTextBoxColumn3, Me.LimInferiorDataGridViewTextBoxColumn2, Me.LimSuperiorDataGridViewTextBoxColumn2, Me.PctCuantiaBaseDataGridViewTextBoxColumn1, Me.PctCuantiaAdicionalDataGridViewTextBoxColumn1})
        Me.dgCuantia73.DataSource = Me.bsCuantia73
        Me.dgCuantia73.Location = New System.Drawing.Point(439, 81)
        Me.dgCuantia73.Name = "dgCuantia73"
        Me.dgCuantia73.Size = New System.Drawing.Size(487, 62)
        Me.dgCuantia73.TabIndex = 24
        '
        'LimInferior
        '
        Me.LimInferior.DataPropertyName = "LimInferior"
        Me.LimInferior.HeaderText = "Limite Inferior"
        Me.LimInferior.Name = "LimInferior"
        '
        'LimSuperior
        '
        Me.LimSuperior.DataPropertyName = "LimSuperior"
        Me.LimSuperior.HeaderText = "Limite Superior"
        Me.LimSuperior.Name = "LimSuperior"
        '
        'pctCuantiaBase
        '
        Me.pctCuantiaBase.DataPropertyName = "pctCuantiaBase"
        Me.pctCuantiaBase.HeaderText = "% Cuantia Base"
        Me.pctCuantiaBase.Name = "pctCuantiaBase"
        '
        'pctCuantiaAdicional
        '
        Me.pctCuantiaAdicional.DataPropertyName = "pctCuantiaAdicional"
        Me.pctCuantiaAdicional.HeaderText = "% Cuantia Adicional"
        Me.pctCuantiaAdicional.Name = "pctCuantiaAdicional"
        '
        'IdDataGridViewTextBoxColumn3
        '
        Me.IdDataGridViewTextBoxColumn3.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn3.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn3.Name = "IdDataGridViewTextBoxColumn3"
        '
        'LimInferiorDataGridViewTextBoxColumn2
        '
        Me.LimInferiorDataGridViewTextBoxColumn2.DataPropertyName = "LimInferior"
        Me.LimInferiorDataGridViewTextBoxColumn2.HeaderText = "LimInferior"
        Me.LimInferiorDataGridViewTextBoxColumn2.Name = "LimInferiorDataGridViewTextBoxColumn2"
        '
        'LimSuperiorDataGridViewTextBoxColumn2
        '
        Me.LimSuperiorDataGridViewTextBoxColumn2.DataPropertyName = "LimSuperior"
        Me.LimSuperiorDataGridViewTextBoxColumn2.HeaderText = "LimSuperior"
        Me.LimSuperiorDataGridViewTextBoxColumn2.Name = "LimSuperiorDataGridViewTextBoxColumn2"
        '
        'PctCuantiaBaseDataGridViewTextBoxColumn1
        '
        Me.PctCuantiaBaseDataGridViewTextBoxColumn1.DataPropertyName = "pctCuantiaBase"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn1.HeaderText = "pctCuantiaBase"
        Me.PctCuantiaBaseDataGridViewTextBoxColumn1.Name = "PctCuantiaBaseDataGridViewTextBoxColumn1"
        '
        'PctCuantiaAdicionalDataGridViewTextBoxColumn1
        '
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn1.DataPropertyName = "pctCuantiaAdicional"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn1.HeaderText = "pctCuantiaAdicional"
        Me.PctCuantiaAdicionalDataGridViewTextBoxColumn1.Name = "PctCuantiaAdicionalDataGridViewTextBoxColumn1"
        '
        'dgCuantia97
        '
        Me.dgCuantia97.AutoGenerateColumns = False
        Me.dgCuantia97.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuantia97.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Año, Me.AñosPension, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.PensionGarantizada, Me.SemCotInferior, Me.SemCotSupeior, Me.IdDataGridViewTextBoxColumn2, Me.AñoDataGridViewTextBoxColumn3, Me.AñosPensionDataGridViewTextBoxColumn, Me.LimInferiorDataGridViewTextBoxColumn1, Me.LimSuperiorDataGridViewTextBoxColumn1, Me.PensionGarantizadaDataGridViewTextBoxColumn, Me.SemCotInferiorDataGridViewTextBoxColumn, Me.SemCotSupeiorDataGridViewTextBoxColumn})
        Me.dgCuantia97.DataSource = Me.bsCuantias97
        Me.dgCuantia97.Location = New System.Drawing.Point(439, 80)
        Me.dgCuantia97.Name = "dgCuantia97"
        Me.dgCuantia97.Size = New System.Drawing.Size(487, 87)
        Me.dgCuantia97.TabIndex = 25
        '
        'Año
        '
        Me.Año.DataPropertyName = "Año"
        Me.Año.HeaderText = "Año"
        Me.Año.Name = "Año"
        '
        'AñosPension
        '
        Me.AñosPension.DataPropertyName = "AñosPension"
        Me.AñosPension.HeaderText = "Años Para Pension"
        Me.AñosPension.Name = "AñosPension"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LimInferior"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Limite Inferior"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LimSuperior"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Limite Superior"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'PensionGarantizada
        '
        Me.PensionGarantizada.DataPropertyName = "PensionGarantizada"
        Me.PensionGarantizada.HeaderText = "Pension Garantizada"
        Me.PensionGarantizada.Name = "PensionGarantizada"
        '
        'SemCotInferior
        '
        Me.SemCotInferior.DataPropertyName = "SemCotInferior"
        Me.SemCotInferior.HeaderText = "Semanas Cotizadas Inferior"
        Me.SemCotInferior.Name = "SemCotInferior"
        '
        'SemCotSupeior
        '
        Me.SemCotSupeior.DataPropertyName = "SemCotSupeior"
        Me.SemCotSupeior.HeaderText = "Semanas Cotizadas Supeior"
        Me.SemCotSupeior.Name = "SemCotSupeior"
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        '
        'AñoDataGridViewTextBoxColumn3
        '
        Me.AñoDataGridViewTextBoxColumn3.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn3.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn3.Name = "AñoDataGridViewTextBoxColumn3"
        '
        'AñosPensionDataGridViewTextBoxColumn
        '
        Me.AñosPensionDataGridViewTextBoxColumn.DataPropertyName = "AñosPension"
        Me.AñosPensionDataGridViewTextBoxColumn.HeaderText = "AñosPension"
        Me.AñosPensionDataGridViewTextBoxColumn.Name = "AñosPensionDataGridViewTextBoxColumn"
        '
        'LimInferiorDataGridViewTextBoxColumn1
        '
        Me.LimInferiorDataGridViewTextBoxColumn1.DataPropertyName = "LimInferior"
        Me.LimInferiorDataGridViewTextBoxColumn1.HeaderText = "LimInferior"
        Me.LimInferiorDataGridViewTextBoxColumn1.Name = "LimInferiorDataGridViewTextBoxColumn1"
        '
        'LimSuperiorDataGridViewTextBoxColumn1
        '
        Me.LimSuperiorDataGridViewTextBoxColumn1.DataPropertyName = "LimSuperior"
        Me.LimSuperiorDataGridViewTextBoxColumn1.HeaderText = "LimSuperior"
        Me.LimSuperiorDataGridViewTextBoxColumn1.Name = "LimSuperiorDataGridViewTextBoxColumn1"
        '
        'PensionGarantizadaDataGridViewTextBoxColumn
        '
        Me.PensionGarantizadaDataGridViewTextBoxColumn.DataPropertyName = "PensionGarantizada"
        Me.PensionGarantizadaDataGridViewTextBoxColumn.HeaderText = "PensionGarantizada"
        Me.PensionGarantizadaDataGridViewTextBoxColumn.Name = "PensionGarantizadaDataGridViewTextBoxColumn"
        '
        'SemCotInferiorDataGridViewTextBoxColumn
        '
        Me.SemCotInferiorDataGridViewTextBoxColumn.DataPropertyName = "SemCotInferior"
        Me.SemCotInferiorDataGridViewTextBoxColumn.HeaderText = "SemCotInferior"
        Me.SemCotInferiorDataGridViewTextBoxColumn.Name = "SemCotInferiorDataGridViewTextBoxColumn"
        '
        'SemCotSupeiorDataGridViewTextBoxColumn
        '
        Me.SemCotSupeiorDataGridViewTextBoxColumn.DataPropertyName = "SemCotSupeior"
        Me.SemCotSupeiorDataGridViewTextBoxColumn.HeaderText = "SemCotSupeior"
        Me.SemCotSupeiorDataGridViewTextBoxColumn.Name = "SemCotSupeiorDataGridViewTextBoxColumn"
        '
        'dgEstados
        '
        Me.dgEstados.AutoGenerateColumns = False
        Me.dgEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEstados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cve, Me.Estado, Me.CveDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn2})
        Me.dgEstados.DataSource = Me.bsEstados
        Me.dgEstados.Location = New System.Drawing.Point(439, 84)
        Me.dgEstados.Name = "dgEstados"
        Me.dgEstados.Size = New System.Drawing.Size(457, 62)
        Me.dgEstados.TabIndex = 26
        '
        'Cve
        '
        Me.Cve.DataPropertyName = "Cve"
        Me.Cve.HeaderText = "Clave"
        Me.Cve.Name = "Cve"
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'CveDataGridViewTextBoxColumn
        '
        Me.CveDataGridViewTextBoxColumn.DataPropertyName = "Cve"
        Me.CveDataGridViewTextBoxColumn.HeaderText = "Cve"
        Me.CveDataGridViewTextBoxColumn.Name = "CveDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn2
        '
        Me.EstadoDataGridViewTextBoxColumn2.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn2.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn2.Name = "EstadoDataGridViewTextBoxColumn2"
        '
        'dgTopados
        '
        Me.dgTopados.AutoGenerateColumns = False
        Me.dgTopados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTopados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Seguro, Me.Topado, Me.IdDataGridViewTextBoxColumn1, Me.AñoDataGridViewTextBoxColumn2, Me.SeguroDataGridViewTextBoxColumn1, Me.TopadoDataGridViewTextBoxColumn})
        Me.dgTopados.DataSource = Me.bsTopados
        Me.dgTopados.Location = New System.Drawing.Point(439, 72)
        Me.dgTopados.Name = "dgTopados"
        Me.dgTopados.Size = New System.Drawing.Size(442, 62)
        Me.dgTopados.TabIndex = 27
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Seguro
        '
        Me.Seguro.DataPropertyName = "Seguro"
        Me.Seguro.HeaderText = "Seguro"
        Me.Seguro.Name = "Seguro"
        '
        'Topado
        '
        Me.Topado.DataPropertyName = "Topado"
        Me.Topado.HeaderText = "Topado"
        Me.Topado.Name = "Topado"
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'AñoDataGridViewTextBoxColumn2
        '
        Me.AñoDataGridViewTextBoxColumn2.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn2.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn2.Name = "AñoDataGridViewTextBoxColumn2"
        '
        'SeguroDataGridViewTextBoxColumn1
        '
        Me.SeguroDataGridViewTextBoxColumn1.DataPropertyName = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn1.HeaderText = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn1.Name = "SeguroDataGridViewTextBoxColumn1"
        '
        'TopadoDataGridViewTextBoxColumn
        '
        Me.TopadoDataGridViewTextBoxColumn.DataPropertyName = "Topado"
        Me.TopadoDataGridViewTextBoxColumn.HeaderText = "Topado"
        Me.TopadoDataGridViewTextBoxColumn.Name = "TopadoDataGridViewTextBoxColumn"
        '
        'dgDelegaciones
        '
        Me.dgDelegaciones.AutoGenerateColumns = False
        Me.dgDelegaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDelegaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Delegacion, Me.Subdelegacion, Me.UMF, Me.Municipio, Me.Localidad, Me.IdDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn1, Me.DelegacionDataGridViewTextBoxColumn, Me.SubdelegacionDataGridViewTextBoxColumn, Me.UMFDataGridViewTextBoxColumn, Me.MunicipioDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn})
        Me.dgDelegaciones.DataSource = Me.bsDelegacdiones
        Me.dgDelegaciones.Location = New System.Drawing.Point(439, 75)
        Me.dgDelegaciones.Name = "dgDelegaciones"
        Me.dgDelegaciones.Size = New System.Drawing.Size(442, 62)
        Me.dgDelegaciones.TabIndex = 28
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Delegacion
        '
        Me.Delegacion.DataPropertyName = "Delegacion"
        Me.Delegacion.HeaderText = "Delegacion"
        Me.Delegacion.Name = "Delegacion"
        '
        'Subdelegacion
        '
        Me.Subdelegacion.DataPropertyName = "Subdelegacion"
        Me.Subdelegacion.HeaderText = "Subdelegacion"
        Me.Subdelegacion.Name = "Subdelegacion"
        '
        'UMF
        '
        Me.UMF.DataPropertyName = "UMF"
        Me.UMF.HeaderText = "UMF"
        Me.UMF.Name = "UMF"
        '
        'Municipio
        '
        Me.Municipio.DataPropertyName = "Municipio"
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        '
        'Localidad
        '
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn1
        '
        Me.EstadoDataGridViewTextBoxColumn1.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn1.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn1.Name = "EstadoDataGridViewTextBoxColumn1"
        '
        'DelegacionDataGridViewTextBoxColumn
        '
        Me.DelegacionDataGridViewTextBoxColumn.DataPropertyName = "Delegacion"
        Me.DelegacionDataGridViewTextBoxColumn.HeaderText = "Delegacion"
        Me.DelegacionDataGridViewTextBoxColumn.Name = "DelegacionDataGridViewTextBoxColumn"
        '
        'SubdelegacionDataGridViewTextBoxColumn
        '
        Me.SubdelegacionDataGridViewTextBoxColumn.DataPropertyName = "Subdelegacion"
        Me.SubdelegacionDataGridViewTextBoxColumn.HeaderText = "Subdelegacion"
        Me.SubdelegacionDataGridViewTextBoxColumn.Name = "SubdelegacionDataGridViewTextBoxColumn"
        '
        'UMFDataGridViewTextBoxColumn
        '
        Me.UMFDataGridViewTextBoxColumn.DataPropertyName = "UMF"
        Me.UMFDataGridViewTextBoxColumn.HeaderText = "UMF"
        Me.UMFDataGridViewTextBoxColumn.Name = "UMFDataGridViewTextBoxColumn"
        '
        'MunicipioDataGridViewTextBoxColumn
        '
        Me.MunicipioDataGridViewTextBoxColumn.DataPropertyName = "Municipio"
        Me.MunicipioDataGridViewTextBoxColumn.HeaderText = "Municipio"
        Me.MunicipioDataGridViewTextBoxColumn.Name = "MunicipioDataGridViewTextBoxColumn"
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        '
        'dgINPC
        '
        Me.dgINPC.AutoGenerateColumns = False
        Me.dgINPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgINPC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YearsDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.INPCDataGridViewTextBoxColumn, Me.FactorRecargoDataGridViewTextBoxColumn})
        Me.dgINPC.DataSource = Me.bsINPC
        Me.dgINPC.Location = New System.Drawing.Point(448, 72)
        Me.dgINPC.Name = "dgINPC"
        Me.dgINPC.Size = New System.Drawing.Size(442, 62)
        Me.dgINPC.TabIndex = 29
        '
        'YearsDataGridViewTextBoxColumn
        '
        Me.YearsDataGridViewTextBoxColumn.DataPropertyName = "Years"
        Me.YearsDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.YearsDataGridViewTextBoxColumn.Name = "YearsDataGridViewTextBoxColumn"
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        '
        'INPCDataGridViewTextBoxColumn
        '
        Me.INPCDataGridViewTextBoxColumn.DataPropertyName = "INPC"
        Me.INPCDataGridViewTextBoxColumn.HeaderText = "INPC"
        Me.INPCDataGridViewTextBoxColumn.Name = "INPCDataGridViewTextBoxColumn"
        '
        'FactorRecargoDataGridViewTextBoxColumn
        '
        Me.FactorRecargoDataGridViewTextBoxColumn.DataPropertyName = "FactorRecargo"
        Me.FactorRecargoDataGridViewTextBoxColumn.HeaderText = "Factor de Recargo"
        Me.FactorRecargoDataGridViewTextBoxColumn.Name = "FactorRecargoDataGridViewTextBoxColumn"
        '
        'dgINEGI
        '
        Me.dgINEGI.AutoGenerateColumns = False
        Me.dgINEGI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgINEGI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AñoDataGridViewTextBoxColumn, Me.InflacionDataGridViewTextBoxColumn, Me.EstimadaDataGridViewTextBoxColumn})
        Me.dgINEGI.DataSource = Me.bsINEGI
        Me.dgINEGI.Location = New System.Drawing.Point(439, 80)
        Me.dgINEGI.Name = "dgINEGI"
        Me.dgINEGI.Size = New System.Drawing.Size(353, 62)
        Me.dgINEGI.TabIndex = 30
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        '
        'InflacionDataGridViewTextBoxColumn
        '
        Me.InflacionDataGridViewTextBoxColumn.DataPropertyName = "Inflacion"
        Me.InflacionDataGridViewTextBoxColumn.HeaderText = "Inflacion"
        Me.InflacionDataGridViewTextBoxColumn.Name = "InflacionDataGridViewTextBoxColumn"
        '
        'EstimadaDataGridViewTextBoxColumn
        '
        Me.EstimadaDataGridViewTextBoxColumn.DataPropertyName = "Estimada"
        Me.EstimadaDataGridViewTextBoxColumn.HeaderText = "Estimada"
        Me.EstimadaDataGridViewTextBoxColumn.Name = "EstimadaDataGridViewTextBoxColumn"
        '
        'dgISR
        '
        Me.dgISR.AutoGenerateColumns = False
        Me.dgISR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgISR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LimInferiorDataGridViewTextBoxColumn, Me.LimSuperiorDataGridViewTextBoxColumn, Me.CuotaFijaDataGridViewTextBoxColumn, Me.PctExeLimInfDataGridViewTextBoxColumn})
        Me.dgISR.DataSource = Me.bsISR
        Me.dgISR.Location = New System.Drawing.Point(448, 72)
        Me.dgISR.Name = "dgISR"
        Me.dgISR.Size = New System.Drawing.Size(442, 62)
        Me.dgISR.TabIndex = 31
        '
        'LimInferiorDataGridViewTextBoxColumn
        '
        Me.LimInferiorDataGridViewTextBoxColumn.DataPropertyName = "LimInferior"
        Me.LimInferiorDataGridViewTextBoxColumn.HeaderText = "Limite Inferior"
        Me.LimInferiorDataGridViewTextBoxColumn.Name = "LimInferiorDataGridViewTextBoxColumn"
        '
        'LimSuperiorDataGridViewTextBoxColumn
        '
        Me.LimSuperiorDataGridViewTextBoxColumn.DataPropertyName = "LimSuperior"
        Me.LimSuperiorDataGridViewTextBoxColumn.HeaderText = "Limite Superior"
        Me.LimSuperiorDataGridViewTextBoxColumn.Name = "LimSuperiorDataGridViewTextBoxColumn"
        '
        'CuotaFijaDataGridViewTextBoxColumn
        '
        Me.CuotaFijaDataGridViewTextBoxColumn.DataPropertyName = "CuotaFija"
        Me.CuotaFijaDataGridViewTextBoxColumn.HeaderText = "Cuota Fija"
        Me.CuotaFijaDataGridViewTextBoxColumn.Name = "CuotaFijaDataGridViewTextBoxColumn"
        '
        'PctExeLimInfDataGridViewTextBoxColumn
        '
        Me.PctExeLimInfDataGridViewTextBoxColumn.DataPropertyName = "PctExeLimInf"
        Me.PctExeLimInfDataGridViewTextBoxColumn.HeaderText = "% Execente Limite Inferior"
        Me.PctExeLimInfDataGridViewTextBoxColumn.Name = "PctExeLimInfDataGridViewTextBoxColumn"
        '
        'dgPctM40
        '
        Me.dgPctM40.AutoGenerateColumns = False
        Me.dgPctM40.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPctM40.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnoDataGridViewTextBoxColumn, Me.SBCinfDataGridViewTextBoxColumn, Me.SBCsupDataGridViewTextBoxColumn, Me.PctpRetiroDataGridViewTextBoxColumn, Me.PcteCAVDataGridViewTextBoxColumn, Me.PctpCAVDataGridViewTextBoxColumn, Me.PcteIVDataGridViewTextBoxColumn, Me.PctpIVDataGridViewTextBoxColumn, Me.PcteGMDataGridViewTextBoxColumn, Me.PctpGMDataGridViewTextBoxColumn, Me.PctTotalDataGridViewTextBoxColumn})
        Me.dgPctM40.DataSource = Me.bsPctM40
        Me.dgPctM40.Location = New System.Drawing.Point(439, 75)
        Me.dgPctM40.Name = "dgPctM40"
        Me.dgPctM40.Size = New System.Drawing.Size(442, 59)
        Me.dgPctM40.TabIndex = 33
        '
        'AnoDataGridViewTextBoxColumn
        '
        Me.AnoDataGridViewTextBoxColumn.DataPropertyName = "Ano"
        Me.AnoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AnoDataGridViewTextBoxColumn.Name = "AnoDataGridViewTextBoxColumn"
        '
        'SBCinfDataGridViewTextBoxColumn
        '
        Me.SBCinfDataGridViewTextBoxColumn.DataPropertyName = "SBCinf"
        Me.SBCinfDataGridViewTextBoxColumn.HeaderText = "Rel SBC/UMA Inferior"
        Me.SBCinfDataGridViewTextBoxColumn.Name = "SBCinfDataGridViewTextBoxColumn"
        '
        'SBCsupDataGridViewTextBoxColumn
        '
        Me.SBCsupDataGridViewTextBoxColumn.DataPropertyName = "SBCsup"
        Me.SBCsupDataGridViewTextBoxColumn.HeaderText = "Rel SBC/UMA Superior"
        Me.SBCsupDataGridViewTextBoxColumn.Name = "SBCsupDataGridViewTextBoxColumn"
        '
        'PctpRetiroDataGridViewTextBoxColumn
        '
        Me.PctpRetiroDataGridViewTextBoxColumn.DataPropertyName = "pctpRetiro"
        Me.PctpRetiroDataGridViewTextBoxColumn.HeaderText = "% Retiro"
        Me.PctpRetiroDataGridViewTextBoxColumn.Name = "PctpRetiroDataGridViewTextBoxColumn"
        '
        'PcteCAVDataGridViewTextBoxColumn
        '
        Me.PcteCAVDataGridViewTextBoxColumn.DataPropertyName = "pcteCAV"
        Me.PcteCAVDataGridViewTextBoxColumn.HeaderText = "% Trabajador CAV"
        Me.PcteCAVDataGridViewTextBoxColumn.Name = "PcteCAVDataGridViewTextBoxColumn"
        '
        'PctpCAVDataGridViewTextBoxColumn
        '
        Me.PctpCAVDataGridViewTextBoxColumn.DataPropertyName = "pctpCAV"
        Me.PctpCAVDataGridViewTextBoxColumn.HeaderText = "% Patron CAV"
        Me.PctpCAVDataGridViewTextBoxColumn.Name = "PctpCAVDataGridViewTextBoxColumn"
        '
        'PcteIVDataGridViewTextBoxColumn
        '
        Me.PcteIVDataGridViewTextBoxColumn.DataPropertyName = "pcteIV"
        Me.PcteIVDataGridViewTextBoxColumn.HeaderText = "% Trabajador IV"
        Me.PcteIVDataGridViewTextBoxColumn.Name = "PcteIVDataGridViewTextBoxColumn"
        '
        'PctpIVDataGridViewTextBoxColumn
        '
        Me.PctpIVDataGridViewTextBoxColumn.DataPropertyName = "pctpIV"
        Me.PctpIVDataGridViewTextBoxColumn.HeaderText = "% Patron IV"
        Me.PctpIVDataGridViewTextBoxColumn.Name = "PctpIVDataGridViewTextBoxColumn"
        '
        'PcteGMDataGridViewTextBoxColumn
        '
        Me.PcteGMDataGridViewTextBoxColumn.DataPropertyName = "pcteGM"
        Me.PcteGMDataGridViewTextBoxColumn.HeaderText = "% Trabajador GM"
        Me.PcteGMDataGridViewTextBoxColumn.Name = "PcteGMDataGridViewTextBoxColumn"
        '
        'PctpGMDataGridViewTextBoxColumn
        '
        Me.PctpGMDataGridViewTextBoxColumn.DataPropertyName = "pctpGM"
        Me.PctpGMDataGridViewTextBoxColumn.HeaderText = "% Patron GM"
        Me.PctpGMDataGridViewTextBoxColumn.Name = "PctpGMDataGridViewTextBoxColumn"
        '
        'PctTotalDataGridViewTextBoxColumn
        '
        Me.PctTotalDataGridViewTextBoxColumn.DataPropertyName = "pctTotal"
        Me.PctTotalDataGridViewTextBoxColumn.HeaderText = "% Total"
        Me.PctTotalDataGridViewTextBoxColumn.Name = "PctTotalDataGridViewTextBoxColumn"
        '
        'dgSeguros
        '
        Me.dgSeguros.AutoGenerateColumns = False
        Me.dgSeguros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSeguros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LeyDataGridViewTextBoxColumn, Me.SeguroDataGridViewTextBoxColumn, Me.PensionDataGridViewTextBoxColumn})
        Me.dgSeguros.DataSource = Me.bsSeuyPen
        Me.dgSeguros.Location = New System.Drawing.Point(448, 84)
        Me.dgSeguros.Name = "dgSeguros"
        Me.dgSeguros.Size = New System.Drawing.Size(442, 59)
        Me.dgSeguros.TabIndex = 34
        '
        'LeyDataGridViewTextBoxColumn
        '
        Me.LeyDataGridViewTextBoxColumn.DataPropertyName = "Ley"
        Me.LeyDataGridViewTextBoxColumn.HeaderText = "Ley"
        Me.LeyDataGridViewTextBoxColumn.Name = "LeyDataGridViewTextBoxColumn"
        '
        'SeguroDataGridViewTextBoxColumn
        '
        Me.SeguroDataGridViewTextBoxColumn.DataPropertyName = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.HeaderText = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.Name = "SeguroDataGridViewTextBoxColumn"
        '
        'PensionDataGridViewTextBoxColumn
        '
        Me.PensionDataGridViewTextBoxColumn.DataPropertyName = "Pension"
        Me.PensionDataGridViewTextBoxColumn.HeaderText = "Pension"
        Me.PensionDataGridViewTextBoxColumn.Name = "PensionDataGridViewTextBoxColumn"
        '
        'dgUMA
        '
        Me.dgUMA.AutoGenerateColumns = False
        Me.dgUMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUMA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.UMADia, Me.UMAMensual, Me.UMAAnual, Me.SMGDia, Me.SMGMensual, Me.SMGAnual, Me.RelUMA_SMG, Me.Estimada, Me.AñoDataGridViewTextBoxColumn1, Me.UMADiaDataGridViewTextBoxColumn, Me.UMAMensualDataGridViewTextBoxColumn, Me.UMAAnualDataGridViewTextBoxColumn, Me.SMGDiaDataGridViewTextBoxColumn, Me.SMGMensualDataGridViewTextBoxColumn, Me.SMGAnualDataGridViewTextBoxColumn, Me.RelUMASMGDataGridViewTextBoxColumn, Me.EstimadaDataGridViewTextBoxColumn1})
        Me.dgUMA.DataSource = Me.bsUMA
        Me.dgUMA.Location = New System.Drawing.Point(448, 84)
        Me.dgUMA.Name = "dgUMA"
        Me.dgUMA.Size = New System.Drawing.Size(406, 59)
        Me.dgUMA.TabIndex = 35
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'UMADia
        '
        Me.UMADia.DataPropertyName = "UMADia"
        Me.UMADia.HeaderText = "UMA Dia"
        Me.UMADia.Name = "UMADia"
        '
        'UMAMensual
        '
        Me.UMAMensual.DataPropertyName = "UMAMensual"
        Me.UMAMensual.HeaderText = "UMA Mensual"
        Me.UMAMensual.Name = "UMAMensual"
        '
        'UMAAnual
        '
        Me.UMAAnual.DataPropertyName = "UMAAnual"
        Me.UMAAnual.HeaderText = "UMA Anual"
        Me.UMAAnual.Name = "UMAAnual"
        '
        'SMGDia
        '
        Me.SMGDia.DataPropertyName = "SMGDia"
        Me.SMGDia.HeaderText = "SMG Dia"
        Me.SMGDia.Name = "SMGDia"
        '
        'SMGMensual
        '
        Me.SMGMensual.DataPropertyName = "SMGMensual"
        Me.SMGMensual.HeaderText = "SMG Mensual"
        Me.SMGMensual.Name = "SMGMensual"
        '
        'SMGAnual
        '
        Me.SMGAnual.DataPropertyName = "SMGAnual"
        Me.SMGAnual.HeaderText = "SMG Anual"
        Me.SMGAnual.Name = "SMGAnual"
        '
        'RelUMA_SMG
        '
        Me.RelUMA_SMG.DataPropertyName = "RelUMA_SMG"
        Me.RelUMA_SMG.HeaderText = "Relacion UMA/SMG"
        Me.RelUMA_SMG.Name = "RelUMA_SMG"
        '
        'Estimada
        '
        Me.Estimada.DataPropertyName = "Estimada"
        Me.Estimada.HeaderText = "Estimada"
        Me.Estimada.Name = "Estimada"
        '
        'AñoDataGridViewTextBoxColumn1
        '
        Me.AñoDataGridViewTextBoxColumn1.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn1.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn1.Name = "AñoDataGridViewTextBoxColumn1"
        '
        'UMADiaDataGridViewTextBoxColumn
        '
        Me.UMADiaDataGridViewTextBoxColumn.DataPropertyName = "UMADia"
        Me.UMADiaDataGridViewTextBoxColumn.HeaderText = "UMADia"
        Me.UMADiaDataGridViewTextBoxColumn.Name = "UMADiaDataGridViewTextBoxColumn"
        '
        'UMAMensualDataGridViewTextBoxColumn
        '
        Me.UMAMensualDataGridViewTextBoxColumn.DataPropertyName = "UMAMensual"
        Me.UMAMensualDataGridViewTextBoxColumn.HeaderText = "UMAMensual"
        Me.UMAMensualDataGridViewTextBoxColumn.Name = "UMAMensualDataGridViewTextBoxColumn"
        '
        'UMAAnualDataGridViewTextBoxColumn
        '
        Me.UMAAnualDataGridViewTextBoxColumn.DataPropertyName = "UMAAnual"
        Me.UMAAnualDataGridViewTextBoxColumn.HeaderText = "UMAAnual"
        Me.UMAAnualDataGridViewTextBoxColumn.Name = "UMAAnualDataGridViewTextBoxColumn"
        '
        'SMGDiaDataGridViewTextBoxColumn
        '
        Me.SMGDiaDataGridViewTextBoxColumn.DataPropertyName = "SMGDia"
        Me.SMGDiaDataGridViewTextBoxColumn.HeaderText = "SMGDia"
        Me.SMGDiaDataGridViewTextBoxColumn.Name = "SMGDiaDataGridViewTextBoxColumn"
        '
        'SMGMensualDataGridViewTextBoxColumn
        '
        Me.SMGMensualDataGridViewTextBoxColumn.DataPropertyName = "SMGMensual"
        Me.SMGMensualDataGridViewTextBoxColumn.HeaderText = "SMGMensual"
        Me.SMGMensualDataGridViewTextBoxColumn.Name = "SMGMensualDataGridViewTextBoxColumn"
        '
        'SMGAnualDataGridViewTextBoxColumn
        '
        Me.SMGAnualDataGridViewTextBoxColumn.DataPropertyName = "SMGAnual"
        Me.SMGAnualDataGridViewTextBoxColumn.HeaderText = "SMGAnual"
        Me.SMGAnualDataGridViewTextBoxColumn.Name = "SMGAnualDataGridViewTextBoxColumn"
        '
        'RelUMASMGDataGridViewTextBoxColumn
        '
        Me.RelUMASMGDataGridViewTextBoxColumn.DataPropertyName = "RelUMA_SMG"
        Me.RelUMASMGDataGridViewTextBoxColumn.HeaderText = "RelUMA_SMG"
        Me.RelUMASMGDataGridViewTextBoxColumn.Name = "RelUMASMGDataGridViewTextBoxColumn"
        '
        'EstimadaDataGridViewTextBoxColumn1
        '
        Me.EstimadaDataGridViewTextBoxColumn1.DataPropertyName = "Estimada"
        Me.EstimadaDataGridViewTextBoxColumn1.HeaderText = "Estimada"
        Me.EstimadaDataGridViewTextBoxColumn1.Name = "EstimadaDataGridViewTextBoxColumn1"
        '
        'dgDespacho
        '
        Me.dgDespacho.AutoGenerateColumns = False
        Me.dgDespacho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDespacho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SloganDataGridViewTextBoxColumn, Me.RazonSocialDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn1, Me.NumeroDataGridViewTextBoxColumn, Me.CPDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn, Me.TelOficinaDataGridViewTextBoxColumn, Me.TelCelularDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.HorarioDataGridViewTextBoxColumn, Me.DiasLaboralesDataGridViewTextBoxColumn, Me.WebDataGridViewTextBoxColumn1, Me.WhatsAppDataGridViewTextBoxColumn, Me.YoutubeDataGridViewTextBoxColumn, Me.FacebookDataGridViewTextBoxColumn, Me.InstagramDataGridViewTextBoxColumn, Me.TikTokDataGridViewTextBoxColumn})
        Me.dgDespacho.DataSource = Me.bsDespacho
        Me.dgDespacho.Location = New System.Drawing.Point(439, 84)
        Me.dgDespacho.Name = "dgDespacho"
        Me.dgDespacho.Size = New System.Drawing.Size(406, 59)
        Me.dgDespacho.TabIndex = 36
        '
        'SloganDataGridViewTextBoxColumn
        '
        Me.SloganDataGridViewTextBoxColumn.DataPropertyName = "Slogan"
        Me.SloganDataGridViewTextBoxColumn.HeaderText = "Slogan"
        Me.SloganDataGridViewTextBoxColumn.Name = "SloganDataGridViewTextBoxColumn"
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razon Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn1
        '
        Me.DireccionDataGridViewTextBoxColumn1.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn1.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn1.Name = "DireccionDataGridViewTextBoxColumn1"
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        '
        'CPDataGridViewTextBoxColumn
        '
        Me.CPDataGridViewTextBoxColumn.DataPropertyName = "CP"
        Me.CPDataGridViewTextBoxColumn.HeaderText = "CP"
        Me.CPDataGridViewTextBoxColumn.Name = "CPDataGridViewTextBoxColumn"
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'PaisDataGridViewTextBoxColumn
        '
        Me.PaisDataGridViewTextBoxColumn.DataPropertyName = "Pais"
        Me.PaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.PaisDataGridViewTextBoxColumn.Name = "PaisDataGridViewTextBoxColumn"
        '
        'TelOficinaDataGridViewTextBoxColumn
        '
        Me.TelOficinaDataGridViewTextBoxColumn.DataPropertyName = "TelOficina"
        Me.TelOficinaDataGridViewTextBoxColumn.HeaderText = "Tel Oficina"
        Me.TelOficinaDataGridViewTextBoxColumn.Name = "TelOficinaDataGridViewTextBoxColumn"
        '
        'TelCelularDataGridViewTextBoxColumn
        '
        Me.TelCelularDataGridViewTextBoxColumn.DataPropertyName = "TelCelular"
        Me.TelCelularDataGridViewTextBoxColumn.HeaderText = "Tel Celular"
        Me.TelCelularDataGridViewTextBoxColumn.Name = "TelCelularDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'HorarioDataGridViewTextBoxColumn
        '
        Me.HorarioDataGridViewTextBoxColumn.DataPropertyName = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.HeaderText = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.Name = "HorarioDataGridViewTextBoxColumn"
        '
        'DiasLaboralesDataGridViewTextBoxColumn
        '
        Me.DiasLaboralesDataGridViewTextBoxColumn.DataPropertyName = "DiasLaborales"
        Me.DiasLaboralesDataGridViewTextBoxColumn.HeaderText = "Dias Laborales"
        Me.DiasLaboralesDataGridViewTextBoxColumn.Name = "DiasLaboralesDataGridViewTextBoxColumn"
        '
        'WebDataGridViewTextBoxColumn1
        '
        Me.WebDataGridViewTextBoxColumn1.DataPropertyName = "Web"
        Me.WebDataGridViewTextBoxColumn1.HeaderText = "Web"
        Me.WebDataGridViewTextBoxColumn1.Name = "WebDataGridViewTextBoxColumn1"
        '
        'WhatsAppDataGridViewTextBoxColumn
        '
        Me.WhatsAppDataGridViewTextBoxColumn.DataPropertyName = "WhatsApp"
        Me.WhatsAppDataGridViewTextBoxColumn.HeaderText = "WhatsApp"
        Me.WhatsAppDataGridViewTextBoxColumn.Name = "WhatsAppDataGridViewTextBoxColumn"
        '
        'YoutubeDataGridViewTextBoxColumn
        '
        Me.YoutubeDataGridViewTextBoxColumn.DataPropertyName = "Youtube"
        Me.YoutubeDataGridViewTextBoxColumn.HeaderText = "Youtube"
        Me.YoutubeDataGridViewTextBoxColumn.Name = "YoutubeDataGridViewTextBoxColumn"
        '
        'FacebookDataGridViewTextBoxColumn
        '
        Me.FacebookDataGridViewTextBoxColumn.DataPropertyName = "Facebook"
        Me.FacebookDataGridViewTextBoxColumn.HeaderText = "Facebook"
        Me.FacebookDataGridViewTextBoxColumn.Name = "FacebookDataGridViewTextBoxColumn"
        '
        'InstagramDataGridViewTextBoxColumn
        '
        Me.InstagramDataGridViewTextBoxColumn.DataPropertyName = "Instagram"
        Me.InstagramDataGridViewTextBoxColumn.HeaderText = "Instagram"
        Me.InstagramDataGridViewTextBoxColumn.Name = "InstagramDataGridViewTextBoxColumn"
        '
        'TikTokDataGridViewTextBoxColumn
        '
        Me.TikTokDataGridViewTextBoxColumn.DataPropertyName = "TikTok"
        Me.TikTokDataGridViewTextBoxColumn.HeaderText = "TikTok"
        Me.TikTokDataGridViewTextBoxColumn.Name = "TikTokDataGridViewTextBoxColumn"
        '
        'dgModalidades
        '
        Me.dgModalidades.AutoGenerateColumns = False
        Me.dgModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgModalidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoRegimenDataGridViewTextBoxColumn, Me.ModalidadDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.SRTDataGridViewTextBoxColumn, Me.SEDataGridViewTextBoxColumn, Me.SMDataGridViewTextBoxColumn, Me.SIDataGridViewTextBoxColumn, Me.SVDataGridViewTextBoxColumn, Me.SRDataGridViewTextBoxColumn, Me.SCDataGridViewTextBoxColumn, Me.SVeDataGridViewTextBoxColumn, Me.SGDataGridViewTextBoxColumn, Me.SPSDataGridViewTextBoxColumn, Me.DSEDataGridViewTextBoxColumn, Me.DSMDataGridViewTextBoxColumn, Me.DSRTDataGridViewTextBoxColumn, Me.AplicaPensionDataGridViewTextBoxColumn})
        Me.dgModalidades.DataSource = Me.bsModdalidades
        Me.dgModalidades.Location = New System.Drawing.Point(439, 78)
        Me.dgModalidades.Name = "dgModalidades"
        Me.dgModalidades.Size = New System.Drawing.Size(406, 59)
        Me.dgModalidades.TabIndex = 37
        '
        'TipoRegimenDataGridViewTextBoxColumn
        '
        Me.TipoRegimenDataGridViewTextBoxColumn.DataPropertyName = "TipoRegimen"
        Me.TipoRegimenDataGridViewTextBoxColumn.HeaderText = "Regimen"
        Me.TipoRegimenDataGridViewTextBoxColumn.Name = "TipoRegimenDataGridViewTextBoxColumn"
        '
        'ModalidadDataGridViewTextBoxColumn
        '
        Me.ModalidadDataGridViewTextBoxColumn.DataPropertyName = "Modalidad"
        Me.ModalidadDataGridViewTextBoxColumn.HeaderText = "Modalidad"
        Me.ModalidadDataGridViewTextBoxColumn.Name = "ModalidadDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'SRTDataGridViewTextBoxColumn
        '
        Me.SRTDataGridViewTextBoxColumn.DataPropertyName = "S-RT"
        Me.SRTDataGridViewTextBoxColumn.HeaderText = "Riesgos de Trabajo"
        Me.SRTDataGridViewTextBoxColumn.Name = "SRTDataGridViewTextBoxColumn"
        '
        'SEDataGridViewTextBoxColumn
        '
        Me.SEDataGridViewTextBoxColumn.DataPropertyName = "S-E"
        Me.SEDataGridViewTextBoxColumn.HeaderText = "Enfermedad"
        Me.SEDataGridViewTextBoxColumn.Name = "SEDataGridViewTextBoxColumn"
        '
        'SMDataGridViewTextBoxColumn
        '
        Me.SMDataGridViewTextBoxColumn.DataPropertyName = "S-M"
        Me.SMDataGridViewTextBoxColumn.HeaderText = "Maternidad"
        Me.SMDataGridViewTextBoxColumn.Name = "SMDataGridViewTextBoxColumn"
        '
        'SIDataGridViewTextBoxColumn
        '
        Me.SIDataGridViewTextBoxColumn.DataPropertyName = "S-I"
        Me.SIDataGridViewTextBoxColumn.HeaderText = "Invalidez"
        Me.SIDataGridViewTextBoxColumn.Name = "SIDataGridViewTextBoxColumn"
        '
        'SVDataGridViewTextBoxColumn
        '
        Me.SVDataGridViewTextBoxColumn.DataPropertyName = "S-V"
        Me.SVDataGridViewTextBoxColumn.HeaderText = "Vida"
        Me.SVDataGridViewTextBoxColumn.Name = "SVDataGridViewTextBoxColumn"
        '
        'SRDataGridViewTextBoxColumn
        '
        Me.SRDataGridViewTextBoxColumn.DataPropertyName = "S-R"
        Me.SRDataGridViewTextBoxColumn.HeaderText = "Retiro"
        Me.SRDataGridViewTextBoxColumn.Name = "SRDataGridViewTextBoxColumn"
        '
        'SCDataGridViewTextBoxColumn
        '
        Me.SCDataGridViewTextBoxColumn.DataPropertyName = "S-C"
        Me.SCDataGridViewTextBoxColumn.HeaderText = "Cesantia en Edad Avanzada"
        Me.SCDataGridViewTextBoxColumn.Name = "SCDataGridViewTextBoxColumn"
        '
        'SVeDataGridViewTextBoxColumn
        '
        Me.SVeDataGridViewTextBoxColumn.DataPropertyName = "S-Ve"
        Me.SVeDataGridViewTextBoxColumn.HeaderText = "Vejez"
        Me.SVeDataGridViewTextBoxColumn.Name = "SVeDataGridViewTextBoxColumn"
        '
        'SGDataGridViewTextBoxColumn
        '
        Me.SGDataGridViewTextBoxColumn.DataPropertyName = "S-G"
        Me.SGDataGridViewTextBoxColumn.HeaderText = "Guarderias"
        Me.SGDataGridViewTextBoxColumn.Name = "SGDataGridViewTextBoxColumn"
        '
        'SPSDataGridViewTextBoxColumn
        '
        Me.SPSDataGridViewTextBoxColumn.DataPropertyName = "S-PS"
        Me.SPSDataGridViewTextBoxColumn.HeaderText = "Prestaciones Sociales"
        Me.SPSDataGridViewTextBoxColumn.Name = "SPSDataGridViewTextBoxColumn"
        '
        'DSEDataGridViewTextBoxColumn
        '
        Me.DSEDataGridViewTextBoxColumn.DataPropertyName = "DS-E"
        Me.DSEDataGridViewTextBoxColumn.HeaderText = "Subsidio Enfermedad"
        Me.DSEDataGridViewTextBoxColumn.Name = "DSEDataGridViewTextBoxColumn"
        '
        'DSMDataGridViewTextBoxColumn
        '
        Me.DSMDataGridViewTextBoxColumn.DataPropertyName = "DS-M"
        Me.DSMDataGridViewTextBoxColumn.HeaderText = "Subsidio Maternidad"
        Me.DSMDataGridViewTextBoxColumn.Name = "DSMDataGridViewTextBoxColumn"
        '
        'DSRTDataGridViewTextBoxColumn
        '
        Me.DSRTDataGridViewTextBoxColumn.DataPropertyName = "DS-RT"
        Me.DSRTDataGridViewTextBoxColumn.HeaderText = "Subsidio Riesgos de Trabajo"
        Me.DSRTDataGridViewTextBoxColumn.Name = "DSRTDataGridViewTextBoxColumn"
        '
        'AplicaPensionDataGridViewTextBoxColumn
        '
        Me.AplicaPensionDataGridViewTextBoxColumn.DataPropertyName = "AplicaPension"
        Me.AplicaPensionDataGridViewTextBoxColumn.HeaderText = "Aplica Pension de"
        Me.AplicaPensionDataGridViewTextBoxColumn.Name = "AplicaPensionDataGridViewTextBoxColumn"
        '
        'chkSeleccion
        '
        Me.chkSeleccion.AutoSize = True
        Me.chkSeleccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeleccion.ForeColor = System.Drawing.Color.Blue
        Me.chkSeleccion.Location = New System.Drawing.Point(23, 120)
        Me.chkSeleccion.Name = "chkSeleccion"
        Me.chkSeleccion.Size = New System.Drawing.Size(120, 19)
        Me.chkSeleccion.TabIndex = 38
        Me.chkSeleccion.Text = "Seleccionar Todo"
        Me.chkSeleccion.UseVisualStyleBackColor = True
        '
        'bsRTPrima
        '
        Me.bsRTPrima.DataMember = "PrimaRiesgoTrabajo"
        Me.bsRTPrima.DataSource = Me.DsCatalogos
        '
        'PrimaRiesgoTrabajoTableAdapter
        '
        Me.PrimaRiesgoTrabajoTableAdapter.ClearBeforeFill = True
        '
        'dgRTPrima
        '
        Me.dgRTPrima.AutoGenerateColumns = False
        Me.dgRTPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRTPrima.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.Clase, Me.Prima, Me.Descripcion})
        Me.dgRTPrima.DataSource = Me.bsRTPrima
        Me.dgRTPrima.Location = New System.Drawing.Point(439, 173)
        Me.dgRTPrima.Name = "dgRTPrima"
        Me.dgRTPrima.Size = New System.Drawing.Size(485, 59)
        Me.dgRTPrima.TabIndex = 39
        '
        'dgM33
        '
        Me.dgM33.AutoGenerateColumns = False
        Me.dgM33.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgM33.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.LimInf, Me.LimSup, Me.Cuota})
        Me.dgM33.DataSource = Me.bsM33
        Me.dgM33.Location = New System.Drawing.Point(439, 281)
        Me.dgM33.Name = "dgM33"
        Me.dgM33.Size = New System.Drawing.Size(485, 62)
        Me.dgM33.TabIndex = 40
        '
        'bsM33
        '
        Me.bsM33.DataMember = "Modalidad33"
        Me.bsM33.DataSource = Me.DsCatalogos
        '
        'Modalidad33TableAdapter
        '
        Me.Modalidad33TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActividadesTITableAdapter = Nothing
        Me.TableAdapterManager.AforesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.Modalidad33TableAdapter = Nothing
        Me.TableAdapterManager.PctSegurosM40TableAdapter = Nothing
        Me.TableAdapterManager.PensionTableAdapter = Nothing
        Me.TableAdapterManager.PrimaRiesgoTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.RegimenIMSSTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.SubActividadesTITableAdapter = Nothing
        Me.TableAdapterManager.TopadoSMG_UMATableAdapter = Nothing
        Me.TableAdapterManager.UMATableAdapter = Nothing
        Me.TableAdapterManager.UMFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Catalogos.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "Actividades"
        Me.ActividadesBindingSource.DataSource = Me.DsCatalogos
        '
        'ActividadesTableAdapter
        '
        Me.ActividadesTableAdapter.ClearBeforeFill = True
        '
        'dgActividades
        '
        Me.dgActividades.AutoGenerateColumns = False
        Me.dgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.dgActividades.DataSource = Me.ActividadesBindingSource
        Me.dgActividades.Location = New System.Drawing.Point(439, 224)
        Me.dgActividades.Name = "dgActividades"
        Me.dgActividades.Size = New System.Drawing.Size(453, 70)
        Me.dgActividades.TabIndex = 41
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ActividadesTI_Id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Actividad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Actividad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SubActividad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SubActividad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Clase"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Clase"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'LimInf
        '
        Me.LimInf.DataPropertyName = "LimInf"
        Me.LimInf.HeaderText = "Años Inicio"
        Me.LimInf.Name = "LimInf"
        '
        'LimSup
        '
        Me.LimSup.DataPropertyName = "LimSup"
        Me.LimSup.HeaderText = "Años Fin"
        Me.LimSup.Name = "LimSup"
        '
        'Cuota
        '
        Me.Cuota.DataPropertyName = "Cuota"
        Me.Cuota.HeaderText = "Cuota"
        Me.Cuota.Name = "Cuota"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Clase
        '
        Me.Clase.DataPropertyName = "Clase"
        Me.Clase.HeaderText = "Clase"
        Me.Clase.Name = "Clase"
        '
        'Prima
        '
        Me.Prima.DataPropertyName = "Prima"
        Me.Prima.HeaderText = "Prima"
        Me.Prima.Name = "Prima"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'foExportaCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(433, 368)
        Me.Controls.Add(Me.dgActividades)
        Me.Controls.Add(Me.dgM33)
        Me.Controls.Add(Me.dgRTPrima)
        Me.Controls.Add(Me.chkSeleccion)
        Me.Controls.Add(Me.dgModalidades)
        Me.Controls.Add(Me.dgDespacho)
        Me.Controls.Add(Me.dgUMA)
        Me.Controls.Add(Me.dgSeguros)
        Me.Controls.Add(Me.dgPctM40)
        Me.Controls.Add(Me.dgISR)
        Me.Controls.Add(Me.dgINEGI)
        Me.Controls.Add(Me.dgINPC)
        Me.Controls.Add(Me.dgDelegaciones)
        Me.Controls.Add(Me.dgTopados)
        Me.Controls.Add(Me.dgEstados)
        Me.Controls.Add(Me.dgCuantia97)
        Me.Controls.Add(Me.dgCuantia73)
        Me.Controls.Add(Me.dgCuantia73AR)
        Me.Controls.Add(Me.dgAfores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.stBotones)
        Me.Controls.Add(Me.tsBotones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "foExportaCatalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exporta Catalogos a Excel"
        Me.tsBotones.ResumeLayout(False)
        Me.tsBotones.PerformLayout()
        Me.stBotones.ResumeLayout(False)
        Me.stBotones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsAfores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCuantia73ar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCuantia73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCuantias97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEstados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTopados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDelegacdiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsINPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsINEGI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsISR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPctM40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSeuyPen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsModdalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAfores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuantia73AR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuantia73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuantia97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEstados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTopados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDelegaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgINPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgINEGI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgISR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPctM40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSeguros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgModalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRTPrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRTPrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgM33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsM33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents tsbExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents stBotones As StatusStrip
    Friend WithEvents tsslMensaje As ToolStripStatusLabel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkModalidades As CheckBox
    Friend WithEvents chkDespacho As CheckBox
    Friend WithEvents chkUMA As CheckBox
    Friend WithEvents chkPctM40 As CheckBox
    Friend WithEvents chkINEGI As CheckBox
    Friend WithEvents chkISR As CheckBox
    Friend WithEvents chkINPC As CheckBox
    Friend WithEvents chkEstados As CheckBox
    Friend WithEvents chkDelegacion As CheckBox
    Friend WithEvents chkTopados As CheckBox
    Friend WithEvents chkCuantias97 As CheckBox
    Friend WithEvents chkCuantias73AR As CheckBox
    Friend WithEvents chkCuantias73 As CheckBox
    Friend WithEvents chkAfores As CheckBox
    Friend WithEvents chkSegPen As CheckBox
    Friend WithEvents AforesTableAdapter As dsCatalogosTableAdapters.AforesTableAdapter
    Friend WithEvents bsAfores As BindingSource
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents bsCuantia73ar As BindingSource
    Friend WithEvents CuantiasLey1973arTableAdapter As dsCatalogosTableAdapters.CuantiasLey1973arTableAdapter
    Friend WithEvents bsCuantia73 As BindingSource
    Friend WithEvents CuantiasLey1973TableAdapter As dsCatalogosTableAdapters.CuantiasLey1973TableAdapter
    Friend WithEvents bsCuantias97 As BindingSource
    Friend WithEvents CuantiasLey1997TableAdapter As dsCatalogosTableAdapters.CuantiasLey1997TableAdapter
    Friend WithEvents bsEstados As BindingSource
    Friend WithEvents EstadosMxTableAdapter As dsCatalogosTableAdapters.EstadosMxTableAdapter
    Friend WithEvents bsTopados As BindingSource
    Friend WithEvents TopadoSMG_UMATableAdapter As dsCatalogosTableAdapters.TopadoSMG_UMATableAdapter
    Friend WithEvents bsDelegacdiones As BindingSource
    Friend WithEvents UMFTableAdapter As dsCatalogosTableAdapters.UMFTableAdapter
    Friend WithEvents bsINPC As BindingSource
    Friend WithEvents INPCTableAdapter As dsCatalogosTableAdapters.INPCTableAdapter
    Friend WithEvents bsINEGI As BindingSource
    Friend WithEvents bsISR As BindingSource
    Friend WithEvents ISRTableAdapter As dsCatalogosTableAdapters.ISRTableAdapter
    Friend WithEvents bsPctM40 As BindingSource
    Friend WithEvents PctSegurosM40TableAdapter As dsCatalogosTableAdapters.PctSegurosM40TableAdapter
    Friend WithEvents bsSeuyPen As BindingSource
    Friend WithEvents LeySegPenTableAdapter As dsCatalogosTableAdapters.LeySegPenTableAdapter
    Friend WithEvents bsUMA As BindingSource
    Friend WithEvents UMATableAdapter As dsCatalogosTableAdapters.UMATableAdapter
    Friend WithEvents bsDespacho As BindingSource
    Friend WithEvents DespachoTableAdapter As dsCatalogosTableAdapters.DespachoTableAdapter
    Friend WithEvents bsModdalidades As BindingSource
    Friend WithEvents RegimenIMSSTableAdapter As dsCatalogosTableAdapters.RegimenIMSSTableAdapter
    Friend WithEvents InflacionAnualTableAdapter As dsCatalogosTableAdapters.InflacionAnualTableAdapter
    Friend WithEvents dgAfores As DataGridView
    Friend WithEvents sfdExportar As SaveFileDialog
    Friend WithEvents dgCuantia73AR As DataGridView
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WebDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioInicialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalarioFinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaBaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaAdicionalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgCuantia73 As DataGridView
    Friend WithEvents dgCuantia97 As DataGridView
    Friend WithEvents dgEstados As DataGridView
    Friend WithEvents dgTopados As DataGridView
    Friend WithEvents dgDelegaciones As DataGridView
    Friend WithEvents dgINPC As DataGridView
    Friend WithEvents YearsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INPCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FactorRecargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgINEGI As DataGridView
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InflacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgISR As DataGridView
    Friend WithEvents LimInferiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimSuperiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaFijaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctExeLimInfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgPctM40 As DataGridView
    Friend WithEvents AnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SBCinfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SBCsupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctpRetiroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcteCAVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctpCAVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcteIVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctpIVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcteGMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctpGMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgSeguros As DataGridView
    Friend WithEvents LeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeguroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgUMA As DataGridView
    Friend WithEvents dgDespacho As DataGridView
    Friend WithEvents SloganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelOficinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelCelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasLaboralesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WebDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WhatsAppDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YoutubeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacebookDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstagramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TikTokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgModalidades As DataGridView
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
    Friend WithEvents chkSeleccion As CheckBox
    Friend WithEvents pbProceso As ToolStripProgressBar
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents UMADia As DataGridViewTextBoxColumn
    Friend WithEvents UMAMensual As DataGridViewTextBoxColumn
    Friend WithEvents UMAAnual As DataGridViewTextBoxColumn
    Friend WithEvents SMGDia As DataGridViewTextBoxColumn
    Friend WithEvents SMGMensual As DataGridViewTextBoxColumn
    Friend WithEvents SMGAnual As DataGridViewTextBoxColumn
    Friend WithEvents RelUMA_SMG As DataGridViewTextBoxColumn
    Friend WithEvents Estimada As DataGridViewTextBoxColumn
    Friend WithEvents LimInferior As DataGridViewTextBoxColumn
    Friend WithEvents LimSuperior As DataGridViewTextBoxColumn
    Friend WithEvents pctCuantiaBase As DataGridViewTextBoxColumn
    Friend WithEvents pctCuantiaAdicional As DataGridViewTextBoxColumn
    Friend WithEvents Año As DataGridViewTextBoxColumn
    Friend WithEvents AñosPension As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PensionGarantizada As DataGridViewTextBoxColumn
    Friend WithEvents SemCotInferior As DataGridViewTextBoxColumn
    Friend WithEvents SemCotSupeior As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Seguro As DataGridViewTextBoxColumn
    Friend WithEvents Topado As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Delegacion As DataGridViewTextBoxColumn
    Friend WithEvents Subdelegacion As DataGridViewTextBoxColumn
    Friend WithEvents UMF As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents Cve As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents LimInferiorDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LimSuperiorDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaBaseDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PctCuantiaAdicionalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents AñosPensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimInferiorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LimSuperiorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PensionGarantizadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemCotInferiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemCotSupeiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SeguroDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TopadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DelegacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubdelegacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UMFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MunicipioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UMADiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UMAMensualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UMAAnualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SMGDiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SMGMensualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SMGAnualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RelUMASMGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimadaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents chkRTPrima As CheckBox
    Friend WithEvents chkM33 As CheckBox
    Friend WithEvents chkActividadesTI As CheckBox
    Friend WithEvents bsRTPrima As BindingSource
    Friend WithEvents PrimaRiesgoTrabajoTableAdapter As dsCatalogosTableAdapters.PrimaRiesgoTrabajoTableAdapter
    Friend WithEvents dgRTPrima As DataGridView
    Friend WithEvents dgM33 As DataGridView
    Friend WithEvents bsM33 As BindingSource
    Friend WithEvents Modalidad33TableAdapter As dsCatalogosTableAdapters.Modalidad33TableAdapter
    Friend WithEvents TableAdapterManager As dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents ActividadesBindingSource As BindingSource
    Friend WithEvents ActividadesTableAdapter As dsCatalogosTableAdapters.ActividadesTableAdapter
    Friend WithEvents dgActividades As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Clase As DataGridViewTextBoxColumn
    Friend WithEvents Prima As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents LimInf As DataGridViewTextBoxColumn
    Friend WithEvents LimSup As DataGridViewTextBoxColumn
    Friend WithEvents Cuota As DataGridViewTextBoxColumn
End Class

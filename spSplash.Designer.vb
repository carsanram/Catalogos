<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spSplash
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
        Me.lblCompanyProduct = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.tmContador = New System.Windows.Forms.Timer(Me.components)
        Me.lblSO = New System.Windows.Forms.Label()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.lblPctCarga = New System.Windows.Forms.Label()
        Me.pbCarga = New System.Windows.Forms.ProgressBar()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCompanyProduct
        '
        Me.lblCompanyProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblCompanyProduct.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyProduct.ForeColor = System.Drawing.Color.Yellow
        Me.lblCompanyProduct.Location = New System.Drawing.Point(250, 9)
        Me.lblCompanyProduct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyProduct.Name = "lblCompanyProduct"
        Me.lblCompanyProduct.Size = New System.Drawing.Size(530, 31)
        Me.lblCompanyProduct.TabIndex = 1
        Me.lblCompanyProduct.Text = "Simulador  IMSS 73-97"
        Me.lblCompanyProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblProductName
        '
        Me.lblProductName.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.Yellow
        Me.lblProductName.Location = New System.Drawing.Point(250, 57)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(530, 43)
        Me.lblProductName.TabIndex = 2
        Me.lblProductName.Text = "Producto"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(250, 111)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(530, 25)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Versión"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmContador
        '
        Me.tmContador.Enabled = True
        Me.tmContador.Interval = 500
        '
        'lblSO
        '
        Me.lblSO.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSO.ForeColor = System.Drawing.Color.White
        Me.lblSO.Location = New System.Drawing.Point(22, 136)
        Me.lblSO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSO.Name = "lblSO"
        Me.lblSO.Size = New System.Drawing.Size(206, 20)
        Me.lblSO.TabIndex = 4
        Me.lblSO.Text = "SO"
        '
        'lblVer
        '
        Me.lblVer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.ForeColor = System.Drawing.Color.White
        Me.lblVer.Location = New System.Drawing.Point(22, 158)
        Me.lblVer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(206, 23)
        Me.lblVer.TabIndex = 5
        Me.lblVer.Text = "Ver"
        '
        'lblCopyright
        '
        Me.lblCopyright.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.White
        Me.lblCopyright.Location = New System.Drawing.Point(250, 150)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(530, 31)
        Me.lblCopyright.TabIndex = 6
        Me.lblCopyright.Text = "Copyright 2022"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCompany
        '
        Me.lblCompany.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.Lime
        Me.lblCompany.Location = New System.Drawing.Point(250, 197)
        Me.lblCompany.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(530, 31)
        Me.lblCompany.TabIndex = 7
        Me.lblCompany.Text = "Compañia"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.ForeColor = System.Drawing.Color.Lime
        Me.lblLoad.Location = New System.Drawing.Point(13, 252)
        Me.lblLoad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(100, 18)
        Me.lblLoad.TabIndex = 8
        Me.lblLoad.Text = "Cargando ..."
        '
        'lblPctCarga
        '
        Me.lblPctCarga.AutoSize = True
        Me.lblPctCarga.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPctCarga.ForeColor = System.Drawing.Color.Lime
        Me.lblPctCarga.Location = New System.Drawing.Point(121, 252)
        Me.lblPctCarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPctCarga.Name = "lblPctCarga"
        Me.lblPctCarga.Size = New System.Drawing.Size(33, 18)
        Me.lblPctCarga.TabIndex = 9
        Me.lblPctCarga.Text = "0 %"
        '
        'pbCarga
        '
        Me.pbCarga.Location = New System.Drawing.Point(13, 286)
        Me.pbCarga.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCarga.Maximum = 105
        Me.pbCarga.Name = "pbCarga"
        Me.pbCarga.Size = New System.Drawing.Size(767, 20)
        Me.pbCarga.TabIndex = 10
        Me.pbCarga.Value = 50
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.Catalogos.My.Resources.Resources.LogoSFB
        Me.imgLogo.InitialImage = Global.Catalogos.My.Resources.Resources.Logo
        Me.imgLogo.Location = New System.Drawing.Point(25, 15)
        Me.imgLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(169, 105)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Yellow
        Me.lblEstado.Location = New System.Drawing.Point(172, 254)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(91, 16)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Text = "Procesando: "
        '
        'spSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.pbCarga)
        Me.Controls.Add(Me.lblPctCarga)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblSO)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblCompanyProduct)
        Me.Controls.Add(Me.imgLogo)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "spSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentación"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompanyProduct As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents tmContador As System.Windows.Forms.Timer
    Friend WithEvents lblSO As System.Windows.Forms.Label
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents lblPctCarga As System.Windows.Forms.Label
    Friend WithEvents pbCarga As System.Windows.Forms.ProgressBar
    Friend WithEvents lblEstado As Label
End Class

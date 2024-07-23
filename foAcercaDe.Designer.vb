<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foAcercaDe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foAcercaDe))
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.lblUso = New System.Windows.Forms.Label()
        Me.gbLic = New System.Windows.Forms.GroupBox()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.lblNIT = New System.Windows.Forms.Label()
        Me.lblPropietario = New System.Windows.Forms.Label()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLic.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.Catalogos.My.Resources.Resources.Logo_SF
        Me.imgLogo.Location = New System.Drawing.Point(73, 13)
        Me.imgLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(244, 140)
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        Me.ttip.SetToolTip(Me.imgLogo, "Click para visitar sitio Web")
        '
        'lblUso
        '
        Me.lblUso.AutoSize = True
        Me.lblUso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUso.ForeColor = System.Drawing.Color.Blue
        Me.lblUso.Location = New System.Drawing.Point(70, 157)
        Me.lblUso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUso.Name = "lblUso"
        Me.lblUso.Size = New System.Drawing.Size(247, 16)
        Me.lblUso.TabIndex = 2
        Me.lblUso.Text = "Se autoriza el uso de este software a:"
        '
        'gbLic
        '
        Me.gbLic.Controls.Add(Me.lblSerial)
        Me.gbLic.Controls.Add(Me.lblNIT)
        Me.gbLic.Controls.Add(Me.lblPropietario)
        Me.gbLic.Location = New System.Drawing.Point(15, 177)
        Me.gbLic.Margin = New System.Windows.Forms.Padding(4)
        Me.gbLic.Name = "gbLic"
        Me.gbLic.Padding = New System.Windows.Forms.Padding(4)
        Me.gbLic.Size = New System.Drawing.Size(340, 101)
        Me.gbLic.TabIndex = 3
        Me.gbLic.TabStop = False
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.ForeColor = System.Drawing.Color.Red
        Me.lblSerial.Location = New System.Drawing.Point(21, 73)
        Me.lblSerial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(39, 16)
        Me.lblSerial.TabIndex = 2
        Me.lblSerial.Text = "Serial"
        '
        'lblNIT
        '
        Me.lblNIT.AutoSize = True
        Me.lblNIT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIT.Location = New System.Drawing.Point(21, 44)
        Me.lblNIT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNIT.Name = "lblNIT"
        Me.lblNIT.Size = New System.Drawing.Size(26, 16)
        Me.lblNIT.TabIndex = 1
        Me.lblNIT.Text = "NIT"
        '
        'lblPropietario
        '
        Me.lblPropietario.AutoSize = True
        Me.lblPropietario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropietario.Location = New System.Drawing.Point(21, 17)
        Me.lblPropietario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPropietario.Name = "lblPropietario"
        Me.lblPropietario.Size = New System.Drawing.Size(71, 16)
        Me.lblPropietario.TabIndex = 0
        Me.lblPropietario.Text = "Propietario"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAceptar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(300, 286)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(55, 49)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttip.SetToolTip(Me.btnAceptar, "Salir")
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(36, 291)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(67, 18)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Versión:"
        '
        'foAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(366, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbLic)
        Me.Controls.Add(Me.lblUso)
        Me.Controls.Add(Me.imgLogo)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "foAcercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información del Propietario de la Licencia de Uso"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLic.ResumeLayout(False)
        Me.gbLic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblUso As System.Windows.Forms.Label
    Friend WithEvents gbLic As System.Windows.Forms.GroupBox
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents lblNIT As System.Windows.Forms.Label
    Friend WithEvents lblPropietario As System.Windows.Forms.Label
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblVersion As Label
End Class

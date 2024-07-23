<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foAvisoBTN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foAvisoBTN))
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.icoQuestion = New System.Windows.Forms.PictureBox()
        Me.icoWarning = New System.Windows.Forms.PictureBox()
        Me.icoInformation = New System.Windows.Forms.PictureBox()
        Me.icoCritical = New System.Windows.Forms.PictureBox()
        Me.icoYes = New System.Windows.Forms.PictureBox()
        Me.icoNormal = New System.Windows.Forms.PictureBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.icoQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(47, 11)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(829, 70)
        Me.lblMensaje.TabIndex = 20
        Me.lblMensaje.Text = "mensaje"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'icoQuestion
        '
        Me.icoQuestion.Image = CType(resources.GetObject("icoQuestion.Image"), System.Drawing.Image)
        Me.icoQuestion.Location = New System.Drawing.Point(104, 25)
        Me.icoQuestion.Margin = New System.Windows.Forms.Padding(4)
        Me.icoQuestion.Name = "icoQuestion"
        Me.icoQuestion.Size = New System.Drawing.Size(35, 35)
        Me.icoQuestion.TabIndex = 25
        Me.icoQuestion.TabStop = False
        Me.tt.SetToolTip(Me.icoQuestion, "Pregunta")
        '
        'icoWarning
        '
        Me.icoWarning.Image = CType(resources.GetObject("icoWarning.Image"), System.Drawing.Image)
        Me.icoWarning.Location = New System.Drawing.Point(147, 25)
        Me.icoWarning.Margin = New System.Windows.Forms.Padding(4)
        Me.icoWarning.Name = "icoWarning"
        Me.icoWarning.Size = New System.Drawing.Size(35, 35)
        Me.icoWarning.TabIndex = 24
        Me.icoWarning.TabStop = False
        Me.tt.SetToolTip(Me.icoWarning, "Advertencia")
        '
        'icoInformation
        '
        Me.icoInformation.Image = CType(resources.GetObject("icoInformation.Image"), System.Drawing.Image)
        Me.icoInformation.Location = New System.Drawing.Point(190, 25)
        Me.icoInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.icoInformation.Name = "icoInformation"
        Me.icoInformation.Size = New System.Drawing.Size(35, 35)
        Me.icoInformation.TabIndex = 23
        Me.icoInformation.TabStop = False
        Me.tt.SetToolTip(Me.icoInformation, "Informacion")
        '
        'icoCritical
        '
        Me.icoCritical.Image = CType(resources.GetObject("icoCritical.Image"), System.Drawing.Image)
        Me.icoCritical.Location = New System.Drawing.Point(233, 25)
        Me.icoCritical.Margin = New System.Windows.Forms.Padding(4)
        Me.icoCritical.Name = "icoCritical"
        Me.icoCritical.Size = New System.Drawing.Size(35, 35)
        Me.icoCritical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.icoCritical.TabIndex = 22
        Me.icoCritical.TabStop = False
        Me.tt.SetToolTip(Me.icoCritical, "Error")
        '
        'icoYes
        '
        Me.icoYes.Image = CType(resources.GetObject("icoYes.Image"), System.Drawing.Image)
        Me.icoYes.Location = New System.Drawing.Point(5, 30)
        Me.icoYes.Margin = New System.Windows.Forms.Padding(4)
        Me.icoYes.Name = "icoYes"
        Me.icoYes.Size = New System.Drawing.Size(35, 35)
        Me.icoYes.TabIndex = 21
        Me.icoYes.TabStop = False
        Me.tt.SetToolTip(Me.icoYes, "OK")
        '
        'icoNormal
        '
        Me.icoNormal.Image = CType(resources.GetObject("icoNormal.Image"), System.Drawing.Image)
        Me.icoNormal.Location = New System.Drawing.Point(61, 25)
        Me.icoNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.icoNormal.Name = "icoNormal"
        Me.icoNormal.Size = New System.Drawing.Size(35, 35)
        Me.icoNormal.TabIndex = 29
        Me.icoNormal.TabStop = False
        Me.tt.SetToolTip(Me.icoNormal, "Mensaje")
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(985, 25)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(40, 40)
        Me.btnAceptar.TabIndex = 32
        Me.tt.SetToolTip(Me.btnAceptar, "Salir")
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNo.Image = CType(resources.GetObject("btnNo.Image"), System.Drawing.Image)
        Me.btnNo.Location = New System.Drawing.Point(935, 25)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(40, 40)
        Me.btnNo.TabIndex = 31
        Me.tt.SetToolTip(Me.btnNo, "No")
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'btnSi
        '
        Me.btnSi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.Image = CType(resources.GetObject("btnSi.Image"), System.Drawing.Image)
        Me.btnSi.Location = New System.Drawing.Point(885, 25)
        Me.btnSi.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(40, 40)
        Me.btnSi.TabIndex = 30
        Me.tt.SetToolTip(Me.btnSi, "SI")
        Me.btnSi.UseVisualStyleBackColor = False
        '
        'foAvisoBTN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1038, 90)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.icoNormal)
        Me.Controls.Add(Me.icoQuestion)
        Me.Controls.Add(Me.icoWarning)
        Me.Controls.Add(Me.icoInformation)
        Me.Controls.Add(Me.icoCritical)
        Me.Controls.Add(Me.icoYes)
        Me.Controls.Add(Me.lblMensaje)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "foAvisoBTN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aviso"
        CType(Me.icoQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents icoQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents icoWarning As System.Windows.Forms.PictureBox
    Friend WithEvents icoInformation As System.Windows.Forms.PictureBox
    Friend WithEvents icoCritical As System.Windows.Forms.PictureBox
    Friend WithEvents icoYes As System.Windows.Forms.PictureBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents icoNormal As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnSi As Button
    Friend WithEvents tt As ToolTip
End Class

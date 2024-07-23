<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foAvisoCorto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foAvisoCorto))
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.icoNormal = New System.Windows.Forms.PictureBox()
        Me.icoCritical = New System.Windows.Forms.PictureBox()
        Me.icoInformation = New System.Windows.Forms.PictureBox()
        Me.icoWarning = New System.Windows.Forms.PictureBox()
        Me.icoQuestion = New System.Windows.Forms.PictureBox()
        Me.icoYes = New System.Windows.Forms.PictureBox()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.icoNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoYes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(54, 9)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(1168, 37)
        Me.lblMensaje.TabIndex = 12
        Me.lblMensaje.Text = "mensaje"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'icoNormal
        '
        Me.icoNormal.Image = CType(resources.GetObject("icoNormal.Image"), System.Drawing.Image)
        Me.icoNormal.Location = New System.Drawing.Point(11, 9)
        Me.icoNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.icoNormal.Name = "icoNormal"
        Me.icoNormal.Size = New System.Drawing.Size(35, 35)
        Me.icoNormal.TabIndex = 13
        Me.icoNormal.TabStop = False
        Me.tt.SetToolTip(Me.icoNormal, "Mensaje")
        '
        'icoCritical
        '
        Me.icoCritical.Image = CType(resources.GetObject("icoCritical.Image"), System.Drawing.Image)
        Me.icoCritical.Location = New System.Drawing.Point(111, 8)
        Me.icoCritical.Margin = New System.Windows.Forms.Padding(4)
        Me.icoCritical.Name = "icoCritical"
        Me.icoCritical.Size = New System.Drawing.Size(35, 35)
        Me.icoCritical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.icoCritical.TabIndex = 15
        Me.icoCritical.TabStop = False
        Me.tt.SetToolTip(Me.icoCritical, "Error")
        '
        'icoInformation
        '
        Me.icoInformation.Image = CType(resources.GetObject("icoInformation.Image"), System.Drawing.Image)
        Me.icoInformation.Location = New System.Drawing.Point(240, 8)
        Me.icoInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.icoInformation.Name = "icoInformation"
        Me.icoInformation.Size = New System.Drawing.Size(35, 35)
        Me.icoInformation.TabIndex = 17
        Me.icoInformation.TabStop = False
        Me.tt.SetToolTip(Me.icoInformation, "Información")
        '
        'icoWarning
        '
        Me.icoWarning.Image = CType(resources.GetObject("icoWarning.Image"), System.Drawing.Image)
        Me.icoWarning.Location = New System.Drawing.Point(197, 8)
        Me.icoWarning.Margin = New System.Windows.Forms.Padding(4)
        Me.icoWarning.Name = "icoWarning"
        Me.icoWarning.Size = New System.Drawing.Size(35, 35)
        Me.icoWarning.TabIndex = 18
        Me.icoWarning.TabStop = False
        Me.tt.SetToolTip(Me.icoWarning, "Advertencia")
        '
        'icoQuestion
        '
        Me.icoQuestion.Image = CType(resources.GetObject("icoQuestion.Image"), System.Drawing.Image)
        Me.icoQuestion.Location = New System.Drawing.Point(154, 8)
        Me.icoQuestion.Margin = New System.Windows.Forms.Padding(4)
        Me.icoQuestion.Name = "icoQuestion"
        Me.icoQuestion.Size = New System.Drawing.Size(35, 35)
        Me.icoQuestion.TabIndex = 19
        Me.icoQuestion.TabStop = False
        Me.tt.SetToolTip(Me.icoQuestion, "Pregunta")
        '
        'icoYes
        '
        Me.icoYes.Image = CType(resources.GetObject("icoYes.Image"), System.Drawing.Image)
        Me.icoYes.Location = New System.Drawing.Point(68, 8)
        Me.icoYes.Margin = New System.Windows.Forms.Padding(4)
        Me.icoYes.Name = "icoYes"
        Me.icoYes.Size = New System.Drawing.Size(35, 35)
        Me.icoYes.TabIndex = 20
        Me.icoYes.TabStop = False
        Me.tt.SetToolTip(Me.icoYes, "Ok")
        '
        'foAvisoCorto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1235, 56)
        Me.ControlBox = False
        Me.Controls.Add(Me.icoYes)
        Me.Controls.Add(Me.icoQuestion)
        Me.Controls.Add(Me.icoWarning)
        Me.Controls.Add(Me.icoInformation)
        Me.Controls.Add(Me.icoCritical)
        Me.Controls.Add(Me.icoNormal)
        Me.Controls.Add(Me.lblMensaje)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "foAvisoCorto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Aviso"
        CType(Me.icoNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoYes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents icoNormal As System.Windows.Forms.PictureBox
    Friend WithEvents icoCritical As System.Windows.Forms.PictureBox
    Friend WithEvents icoInformation As System.Windows.Forms.PictureBox
    Friend WithEvents icoWarning As System.Windows.Forms.PictureBox
    Friend WithEvents icoQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents icoYes As System.Windows.Forms.PictureBox
    Friend WithEvents tt As ToolTip
End Class

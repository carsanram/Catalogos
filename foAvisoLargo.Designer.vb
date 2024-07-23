<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foAvisoLargo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foAvisoLargo))
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.icoInformation = New System.Windows.Forms.PictureBox()
        Me.icoQuestion = New System.Windows.Forms.PictureBox()
        Me.icoCritical = New System.Windows.Forms.PictureBox()
        Me.icoWarning = New System.Windows.Forms.PictureBox()
        Me.icoYes = New System.Windows.Forms.PictureBox()
        Me.icoNormal = New System.Windows.Forms.PictureBox()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.icoInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(104, 23)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(654, 175)
        Me.lblMensaje.TabIndex = 11
        Me.lblMensaje.Text = "mensaje"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'icoInformation
        '
        Me.icoInformation.Image = CType(resources.GetObject("icoInformation.Image"), System.Drawing.Image)
        Me.icoInformation.Location = New System.Drawing.Point(209, 42)
        Me.icoInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.icoInformation.Name = "icoInformation"
        Me.icoInformation.Size = New System.Drawing.Size(50, 50)
        Me.icoInformation.TabIndex = 16
        Me.icoInformation.TabStop = False
        Me.tt.SetToolTip(Me.icoInformation, "Informacíon")
        '
        'icoQuestion
        '
        Me.icoQuestion.Image = CType(resources.GetObject("icoQuestion.Image"), System.Drawing.Image)
        Me.icoQuestion.Location = New System.Drawing.Point(209, 124)
        Me.icoQuestion.Margin = New System.Windows.Forms.Padding(4)
        Me.icoQuestion.Name = "icoQuestion"
        Me.icoQuestion.Size = New System.Drawing.Size(50, 50)
        Me.icoQuestion.TabIndex = 15
        Me.icoQuestion.TabStop = False
        Me.tt.SetToolTip(Me.icoQuestion, "Pregunta")
        '
        'icoCritical
        '
        Me.icoCritical.Image = CType(resources.GetObject("icoCritical.Image"), System.Drawing.Image)
        Me.icoCritical.Location = New System.Drawing.Point(130, 42)
        Me.icoCritical.Margin = New System.Windows.Forms.Padding(4)
        Me.icoCritical.Name = "icoCritical"
        Me.icoCritical.Size = New System.Drawing.Size(50, 50)
        Me.icoCritical.TabIndex = 14
        Me.icoCritical.TabStop = False
        Me.tt.SetToolTip(Me.icoCritical, "Error")
        '
        'icoWarning
        '
        Me.icoWarning.Image = CType(resources.GetObject("icoWarning.Image"), System.Drawing.Image)
        Me.icoWarning.Location = New System.Drawing.Point(130, 124)
        Me.icoWarning.Margin = New System.Windows.Forms.Padding(4)
        Me.icoWarning.Name = "icoWarning"
        Me.icoWarning.Size = New System.Drawing.Size(50, 50)
        Me.icoWarning.TabIndex = 13
        Me.icoWarning.TabStop = False
        Me.tt.SetToolTip(Me.icoWarning, "Advertencia")
        '
        'icoYes
        '
        Me.icoYes.Image = CType(resources.GetObject("icoYes.Image"), System.Drawing.Image)
        Me.icoYes.Location = New System.Drawing.Point(295, 124)
        Me.icoYes.Margin = New System.Windows.Forms.Padding(4)
        Me.icoYes.Name = "icoYes"
        Me.icoYes.Size = New System.Drawing.Size(50, 50)
        Me.icoYes.TabIndex = 12
        Me.icoYes.TabStop = False
        Me.tt.SetToolTip(Me.icoYes, "Ok")
        '
        'icoNormal
        '
        Me.icoNormal.Image = CType(resources.GetObject("icoNormal.Image"), System.Drawing.Image)
        Me.icoNormal.Location = New System.Drawing.Point(26, 76)
        Me.icoNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.icoNormal.Name = "icoNormal"
        Me.icoNormal.Size = New System.Drawing.Size(50, 50)
        Me.icoNormal.TabIndex = 18
        Me.icoNormal.TabStop = False
        Me.tt.SetToolTip(Me.icoNormal, "Mensaje")
        '
        'foAvisoLargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.icoNormal)
        Me.Controls.Add(Me.icoInformation)
        Me.Controls.Add(Me.icoQuestion)
        Me.Controls.Add(Me.icoCritical)
        Me.Controls.Add(Me.icoWarning)
        Me.Controls.Add(Me.icoYes)
        Me.Controls.Add(Me.lblMensaje)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "foAvisoLargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aviso"
        CType(Me.icoInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents icoYes As System.Windows.Forms.PictureBox
    Friend WithEvents icoWarning As System.Windows.Forms.PictureBox
    Friend WithEvents icoCritical As System.Windows.Forms.PictureBox
    Friend WithEvents icoQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents icoInformation As System.Windows.Forms.PictureBox
    Friend WithEvents icoNormal As PictureBox
    Friend WithEvents tt As ToolTip
End Class

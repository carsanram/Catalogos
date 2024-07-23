<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foCalendario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foCalendario))
        Me.mcCalendario = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'mcCalendario
        '
        Me.mcCalendario.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.mcCalendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.mcCalendario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcCalendario.Location = New System.Drawing.Point(12, 10)
        Me.mcCalendario.Margin = New System.Windows.Forms.Padding(12, 14, 12, 14)
        Me.mcCalendario.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
        Me.mcCalendario.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.mcCalendario.Name = "mcCalendario"
        Me.mcCalendario.ShowWeekNumbers = True
        Me.mcCalendario.TabIndex = 2
        Me.mcCalendario.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mcCalendario.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'foCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(294, 183)
        Me.Controls.Add(Me.mcCalendario)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "foCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mcCalendario As MonthCalendar
End Class

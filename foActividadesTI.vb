Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class foActividadesTI

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foActividadesTI"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foActividadesTI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SubActividadesTITableAdapter.Fill(Me.DsCatalogos.SubActividadesTI)
        ActividadesTITableAdapter.Fill(Me.DsCatalogos.ActividadesTI)

        vg.gEvento = "foCuantias73_Load"

        Call SubPrimaRT()

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foActividadesTI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foActividadesTI_FormClosed"

        Try

            'Habilita la opcion de menu del formulario
            mdiprincipal.tsmiTrabajadorIndependiente.Enabled = True
            mdiprincipal.mnTrabajadorIndependienteTI.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '004 evento que llama a la prima
    Private Sub nudAño_ValueChanged(sender As Object, e As EventArgs) Handles nudAño.ValueChanged

        Call SubPrimaRT()

    End Sub


    Sub SubPrimaRT()

        Dim pAño As Integer
        Dim pClase As String
        Dim vPctRT


        pAño = nudAño.Value
        pClase = txtClase.Text


        vPctRT = ConsultasBD.FunGetPrimaRT(pAño, pClase)
        txtPctRT.Text = vPctRT

        Call SubSeveridad()

    End Sub



    Private Sub dgSubActividadTI_Click(sender As Object, e As EventArgs) Handles dgSubActividadTI.Click

        Call SubPrimaRT()
        ' Call SubSeveridad()

    End Sub


    Private Sub dgActividadTI_Click(sender As Object, e As EventArgs) Handles dgActividadTI.Click
        Call SubPrimaRT()
    End Sub


    Private Sub SubSeveridad()
        Dim vSeveridad As String

        vSeveridad = txtClase.Text

        Select Case vSeveridad
            Case "I"
                txtSeveridad.BackColor = Color.Lime
            Case "II"
                txtSeveridad.BackColor = Color.Yellow
            Case "III"
                txtSeveridad.BackColor = Color.Orange
            Case "IV"
                txtSeveridad.BackColor = Color.Red
            Case "V"
                txtSeveridad.BackColor = Color.DarkRed
            Case Else
                txtSeveridad.BackColor = Color.White
        End Select
    End Sub



    Private Sub txtClase_TextChanged(sender As Object, e As EventArgs) Handles txtClase.TextChanged
        Call SubPrimaRT()
    End Sub

    Private Sub dgSubActividadTI_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSubActividadTI.CellContentClick

    End Sub

    Private Sub bnDivision_Click(sender As Object, e As EventArgs) Handles bnDivision.Click
        Call SubPrimaRT()
    End Sub

    Private Sub bnGpoPrincipal_Click(sender As Object, e As EventArgs) Handles bnGpoPrincipal.Click
        Call SubPrimaRT()
    End Sub


End Class
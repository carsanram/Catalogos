
Public Class foAvisoBTN

    'Variables locales del formulario
    Dim vNameApp As String = "Catalogos"
    Dim gNomFormulario As String = "foAvisoBTN"
    Dim gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foAvisoBTN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foAvisoBTN_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento ejecuta [SubBotonSi] Para SI en el mensaje
    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click

        vg.gEvento = "btnSi_Click"

        Call SubBotonSi()
        '----------------

    End Sub

    '003 Evento ejecuta [SubBotonNo] Para NO en el mensaje
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        vg.gEvento = "btnNo_Click"

        Call SubBotonNo()
        '----------------

    End Sub

    '004 Evento ejecuta [SubBotonOk] Para Aceptar
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        vg.gEvento = "btnAceptar_Click"

        Call SubBotonOk()
        '----------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] Carga el formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        'Ubica Mensaje en Formulario
        Call SubUbicaMensaje(12, 35)
        '---------------------------

    End Sub

    '002 SUB [SubUbicaMensaj] Carga ubica el mensaje del formulario
    Sub SubUbicaMensaje(ByVal vLeft As Double, ByVal vTop As Double)

        vg.gEvento = "SubUbicaMensaje"

        Try

            With Me

            'Posicion de Iconos
            .icoCritical.Left = vLeft
            .icoInformation.Left = vLeft
            .icoQuestion.Left = vLeft
            .icoWarning.Left = vLeft
            .icoYes.Left = vLeft

            .icoInformation.Top = vTop
            .icoCritical.Top = vTop
            .icoQuestion.Top = vTop
            .icoWarning.Top = vTop
            .icoYes.Top = vTop

        End With

        vg.gOK = False
        vg.gSi = False
        vg.gNo = False

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 SUB [SubBotonSi] Guarda en variable global la respuesta SI
    Sub SubBotonSi()

        vg.gEvento = "SubBotonSi"

        vg.gSi = True
        Close()

    End Sub

    '004 SUB [SubBotonNO] Guarda en variable global la respuesta NO
    Sub SubBotonNo()

        vg.gEvento = "SubBotonNo"

        vg.gNo = True
        Close()

    End Sub

    '005 SUB [SubBotonOK] Guarda en variable global la respuesta Aceptar
    Sub SubBotonOk()

        vg.gEvento = "SubBotonOk"

        vg.gOK = True
        Close()

    End Sub


End Class
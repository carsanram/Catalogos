
Public Class foAvisoLargo

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    'Variables locales del formulario
    Dim vNameApp As String = "Catalogos"
    Dim gNomFormulario As String = "foAvisoLargo"
    Dim gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubUbicaMensaje] para carga de formulario
    Private Sub foAvisoLargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foAvisoLargo_Load"

        Call mUniversal.SubPlayWav()
        '---------------------------

        'Ubica Mensaje en Formulario
        Call subUbicaMensaje(24, 61)
        '------------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubUbicaMensaje] para carga de formulario
    Sub subUbicaMensaje(ByVal vLeft As Double, ByVal vTop As Double)

        vg.gEvento = "subUbicaMensaje"

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

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

End Class
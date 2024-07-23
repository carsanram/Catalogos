
Public Class foAvisoCorto

    'Variables locales del formulario
    Dim vNameApp As String = "Catalogos"
    Dim gNomFormulario As String = "foAvisoCorto"
    Dim gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foAvidoCorto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foAvidoCorto_Load"

        Call subCargaFormulario()
        '------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] para carga de formulario
    Sub subCargaFormulario()

        vg.gEvento = "subCargaFormulario"

        'Ubica Mensaje en Formulario
        Call subUbicaMensaje(12, 9)
        '--------------------------

    End Sub

    '002 SUB [subUbicaMensaje] para carga de formulario
    Sub subUbicaMensaje(ByVal vLeft As Double, ByVal vTop As Double)

        vg.gEvento = "subUbicaMensaje"

        Dim r As Rectangle = My.Computer.Screen.WorkingArea

        Try
            Call mUniversal.SubPlayWav()
            '---------------------------

            'Superior derecha
            Location = New Point(r.Width - Width, 0)

            With Me

                'Posicion de Iconos
                .icoCritical.Left = vLeft
                .icoInformation.Left = vLeft
                .icoQuestion.Left = vLeft
                .icoWarning.Left = vLeft
                .icoNormal.Left = vLeft
                .icoYes.Left = vLeft

                .icoInformation.Top = vTop
                .icoCritical.Top = vTop
                .icoQuestion.Top = vTop
                .icoWarning.Top = vTop
                .icoNormal.Top = vTop
                .icoYes.Top = vTop

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

End Class
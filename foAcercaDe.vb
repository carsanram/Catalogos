'Bibliotecas

Public Class foAcercaDe

    'Variables locales del formulario
    Dim vNameApp As String = "Catálogos"
    Dim gNomFormulario As String = "foAcercaDe"
    Dim gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Ejecuta [SubCargaFormulario] carga de formulario
    Private Sub foAcercaDe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foAcercaDe_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Cierra Formulario
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        vg.gEvento = "btnAceptar_Click"

        Close()

    End Sub

    '003 Ejecuta [SubIrSitioWeb] navegar en la pagina Web del desarrollador
    Private Sub imgLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgLogo.Click

        vg.gEvento = "imgLogo_Click"

        Call SubIrSitioWeb()
        '-------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] Carga el formulario de Acerca de
    Sub SubCargaFormulario()

        vg.gEvento = "subCargaFormulario"

        Try

            gNomFormulario = "foAcercaDe"
            lblVersion.Text = "Compilación : " & Application.ProductVersion

            'Propietario
            If vg.gPropietarioSoft <> "" Then
                lblPropietario.Text = "Propietario: " & vg.gPropietarioSoft
            Else
                lblPropietario.Text = "Propietario: No registrado"
            End If

            'NIT
            If vg.gNITPropietarioSoft <> "" Then
                lblNIT.Text = "NIT: " & vg.gNITPropietarioSoft
            Else
                lblNIT.Text = "Periodo de Prueba Vigente"
            End If

            'Serial de registro
            If vg.gSerialSoft <> "" Then
                lblSerial.Text = "Serial: " & vg.gSerialSoft
            Else
                lblSerial.Text = "Serial: ###-#####-###-#####-###-#####"
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubIrSitioWeb] Navega al sitio del desarrollador
    Sub SubIrSitioWeb()

        vg.gEvento = "subIrSitioWeb"

        Call mUniversal.SubWebNav("https://planeaydisfrutaunamejorpension.com/")
        '------------------------------------------------------------------------

    End Sub

End Class
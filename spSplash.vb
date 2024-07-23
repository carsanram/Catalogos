
Public Class spSplash

    'Variables locales del formulario
    Dim vNameApp As String = "Catálogos"
    Dim gNomFormulario As String = "spSplash"
    Dim gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS -----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub spSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.VisibleChanged

        vg.gEvento = "spSplash_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento ejecuta [tmContador_Tick] Para ejecutar un Timer (Reloj)
    Private Sub tmContador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmContador.Tick

        vg.gEvento = "tmContador_Tick"

        Call SubTImer()
        '--------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [subCargaFormulario] Carga el formulario 
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Dim vAñoVersion As String
        vAñoVersion = Year(Now).ToString

        Try

            Text = vNameApp

            lblVersion.Text = "Versión " & Application.ProductVersion
            lblProductName.Text = vNameApp

            lblSO.Text = "Sistema Operativo: " & My.Computer.Info.OSPlatform
            lblVer.Text = "Versión: " & My.Computer.Info.OSVersion

            lblCopyright.Text = "Copyright " & vAñoVersion
            lblCompany.Text = "Planea y Disfruta Una Mejor Pensión"


            Call SubLeeRutaCatalogos()
            '-------------------------

            Call SubLeeRutaAsegurados()
            '--------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubTImer] Ejecuta el reloj
    Sub SubTImer()

        vg.gEvento = "SubTImer"

        Try

            pbCarga.Value = pbCarga.Value + 5
            lblPctCarga.Text = pbCarga.Value & "%"

            If pbCarga.Value > 45 Then
                If FunVerificaFileCatalogos() Then
                    '------------------------
                    lblEstado.Text = " Verificando Archivo Ruta Base Datos Catálogos [ OK ]"
                Else
                    lblEstado.Text = " Verificando Archivo Ruta Base Datos Catálogos [ Error ]"

                    tmContador.Enabled = False

                    vg.gMensaje = "Error en Archivo Ruta Base Datos Catálogos, No Existe : " & vbCrLf & vg.gRutaCatalogos & vbCrLf & "Verifique Archivo"
                    gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoCritical, vg.gMensaje, False, False, True)
                    foAvisoBTN.ShowDialog()

                    Application.Exit()

                End If
            End If

            If pbCarga.Value > 90 Then
                If FunVerificaFileAsegurados() Then
                    '------------------------
                    lblEstado.Text = " Verificando Archivo Ruta Base Datos Asegurados [ OK ]"
                Else
                    lblEstado.Text = " Verificando Archivo Ruta Base Datos Asegurados [ Error ]"

                    tmContador.Enabled = False

                    vg.gMensaje = "Error en Archivo Ruta Base Datos Asegurados, No Existe : " & vbCrLf & vg.gRutaCatalogos & vbCrLf & "Verifique Archivo"
                    gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoCritical, vg.gMensaje, False, False, True)
                    foAvisoBTN.ShowDialog()

                    Application.Exit()

                End If

            End If

            If pbCarga.Value > 95 Then

                lblEstado.Text = "OK"

            End If

            If pbCarga.Value = pbCarga.Maximum Then

                tmContador.Enabled = False

                MDIPrincipal.Show()

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 FUN [FunVerificaFileCatalogos] Verifica que exista el archivo de catalogos
    Function FunVerificaFileCatalogos() As Boolean

        vg.gEvento = "FunVerificaFileCatalogos"

        Dim Resultado As String
        FunVerificaFileCatalogos = True

        Try

            Resultado = Dir(vg.gRutaCatalogos)

            If Len(Resultado) > 0 Then

                Return True

            Else

                Return False

        End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '004 FUN [FunVerificaFileAsegurados] Verifica que exista el archivo de asegurados
    Function FunVerificaFileAsegurados() As Boolean

        vg.gEvento = "FunVerificaFileAsegurados"

        Dim Resultado As String

        FunVerificaFileAsegurados = False

        Try

            FunVerificaFileAsegurados = True

            Resultado = Dir(vg.gRutaAsegurados)

            If Len(Resultado) > 0 Then

                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '005 FUN [SubLeeRutaCatalogos] Lee el archivo para obtener la ruta de catalogos
    Sub SubLeeRutaCatalogos()

        vg.gEvento = "SubLeeRutaCatalogos"

        Dim Apunt As Integer = FreeFile()

        Try

            FileOpen(Apunt, vg.gRutaCatalogos, OpenMode.Input, OpenAccess.Read)
            Do While Not EOF(Apunt)
                ' Leemos la línea de texto del archivo
                If Apunt = 1 Then
                    vg.gRutaBaseDatosCatalogos = LineInput(Apunt)

                End If

            Loop
            ' Cerramos el archivo
            FileClose(Apunt)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 FUN [SubLeeRutaAsegurados] Lee el archivo para obtener la ruta de asegurados
    Sub SubLeeRutaAsegurados()

        vg.gEvento = "SubLeeRutaAsegurados"

        Dim Apunt As Integer = FreeFile()

        Try

            FileOpen(Apunt, vg.gRutaAsegurados, OpenMode.Input, OpenAccess.Read)
            Do While Not EOF(Apunt)
                ' Leemos la línea de texto del archivo
                If Apunt = 1 Then
                    vg.gRutaBaseDatosAsegurados = LineInput(Apunt)

                End If

            Loop
            ' Cerramos el archivo
            FileClose(Apunt)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub pbCarga_Click(sender As Object, e As EventArgs) Handles pbCarga.Click

    End Sub
End Class
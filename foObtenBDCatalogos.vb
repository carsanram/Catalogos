Public Class foObtenBDCatalogos
    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foObtenBDCatalogos"

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foObtenBDCatalogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vg.gEvento = "foObtenBDCatalogos_Load"

        Call SubCargaFormulario()
        '------------------------


    End Sub

    '002 Evento agrega base de datos catalogos
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "tsbAgregar_Click"

        Try

            ofdBaseDatos.Filter = "Base de Datos Access | *.accdb"

            If ofdBaseDatos.ShowDialog = DialogResult.OK Then

                txtRuta.Text = ofdBaseDatos.FileName
                vg.gRutaBaseDatosCatalogos = txtRuta.Text

            End If
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento salir del formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Try

            DialogResult = System.Windows.Forms.DialogResult.Cancel
            Close()

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '---- METODOS ---------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] Configuracion y carga del formualario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            lblTitulo.Text = " Selección de Base de datos " & vNameApp

            Call SubMenOK(" Seleccione La Opción Deseada, en el Menú de Opciones ", 1)
            '-------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '005 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '006 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenWarning(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenWarning"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(247, 172, 8)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub


End Class

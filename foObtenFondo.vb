Imports System.Windows.Forms

Public Class foObtenFondo
    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foObtenFondo"
    Public gRutaFondo As String = ""

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento que ejecuta [SubCargaFormulario] para cargar el formulario
    Private Sub foObtenFondo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vg.gEvento = "foObtenFondo_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento que agrega lla imagen de la aplicacion
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "tsbAgregar_Click"

        Try

            ofdFondo.Filter = "Imagenes | *.png"


            If ofdFondo.ShowDialog = DialogResult.OK Then

                txtRutaFondo.Text = ofdFondo.FileName
                gRutaFondo = txtRutaFondo.Text

                MDIPrincipal.BackgroundImage = System.Drawing.Image.FromFile(gRutaFondo)

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento para salir del formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Try

            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 Evento que habilita la opcion de menu
    Private Sub foObtenFondo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foObtenFondo_FormClosed"

        MDIPrincipal.mnImagenAplicación.Enabled = True

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] para cargar el formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Call SubMenOK(" Seleccione el Fondo (Imagen) de la Aplicación que Desee Utilizar ", 1)
        '-------------------------------------------------------------------------------------

    End Sub

    '002 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '003 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '004 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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

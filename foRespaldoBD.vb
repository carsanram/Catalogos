Public Class foRespaldoBD
    'Variables Globales del Formulario
    Public vNameApp As String = "Simulador 73-97"
    Public gNomFormulario As String = "foRespaldoBD"
    Public gCreaBitacora As Boolean = True


    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS 003 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento que hace no disponible la opcion de meni principal
    Private Sub tsmRespaldoBD_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        vg.gEvento = "tsmRespaldoBD_FormClosed"

        MDIPrincipal.tsmiRespaldo.Enabled = True

    End Sub

    '002 Evento que cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        Close()

    End Sub

    '003 Evento que ejecuta los respaldos de la base de datos
    Private Sub tbBackup_Click(sender As Object, e As EventArgs) Handles tbBackup.Click


        fbdArchivo.ShowDialog()
        Dim vRuta As String = fbdArchivo.SelectedPath & "\"

        If chkCatalogos.Checked Then

            Call SubRespaldoCatalogos(vRuta)
            '--------------------------

        End If

        If chkAsegurados.Checked Then

            Call SubRespaldoAsegurados(vRuta)
            '---------------------------

        End If


        If chkPensiones.Checked Then

            Call SubRespaldoPensiones(vRuta)
            '--------------------------

        End If

        Call SubMenOK(" Presione boton [Salir]", 1)
        '-------------------------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS 006 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 [SubRespaldoCatalogos] Respalda Catalogos
    Private Sub SubRespaldoCatalogos(vruta)

        Try

            Dim vCatOri As String = "C:\Simulador IMSS 73-97\BaseDatos\Catalogos.accdb"
            Dim vCatDes As String = vRuta & Format(Now, "yyyyMMdd hhmmss-") & " Catalogos.accdb"

            Call SubMenOK(" Respaldando Catalogos .... Espere", 1)
            '--------------------------------------------------------
            FileCopy(vCatOri, vCatDes)

            Call SubMenOK(" Catalogos Respaldado OK", 1)
            '-------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    '002 [SubRespaldoAsegurados] Respalda Asegurados
    Private Sub SubRespaldoAsegurados(vruta)

        Try

            Dim vAseOri As String = "C:\Simulador IMSS 73-97\BaseDatos\Asegurados.accdb"
            Dim vAseDes As String = vRuta & Format(Now, "yyyyMMdd hhmmss-") & " Asegurados.accdb"

            Call SubMenOK(" Respaldando Asegurados  .... Espere", 1)
            '--------------------------------------------------------

            FileCopy(vAseOri, vAseDes)

            Call SubMenOK(" Asegurados Respaldado OK", 1)
            '-------------------------------------------
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '003  [SubRespaldoPensiones] Respalda Asegurados
    Private Sub SubRespaldoPensiones(vruta)

        Try

            Dim vPenOri As String = "C:\Simulador IMSS 73-97\BaseDatos\Pensiones.accdb"
        Dim vPenDes As String = vRuta & Format(Now, "yyyyMMdd hhmmss-") & " Pensiones.accdb"

        Call SubMenOK(" Respaldando Pensiones .... Espere", 1)
        '--------------------------------------------------------

        FileCopy(vPenOri, vPenDes)

        Call SubMenOK(" Pensiones Respaldado OK", 1)
            '-------------------------------------------

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
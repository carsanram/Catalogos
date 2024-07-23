
Public Class foRegistro

    'Variables Globales del Formulario
    Dim vNameApp As String = "Catálogos"
    Dim gNomFormulario = "foRegistro"
    Dim gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] Carga el Formulario de registro
    Private Sub foRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foRegistro_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento ejecuta [SubGuardarClave] Guarda el archivo texto con la clave
    Private Sub tsmiGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGuardar.Click

        vg.gEvento = "tsmiGuardar_Click"

        'Guarda archivo de texto con la clave
        Call SubGuardarClave()
        '---------------------

    End Sub

    '003 Evento ejecuta [SubGuardarClave] Guarda el archivo texto con la clave
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "tsbGuardar_Click"


        Call SubMenOK(" Guardando la Clave .... Espere", 1)
        '--------------------------------------------------

        'Guarda archivo de texto con la clave
        Call SubGuardarClave()
        '----------------------

    End Sub

    '004 Evento ejecuta [SubEnvioEmail]  Habilita los controles del email
    Private Sub tsmiEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEmail.Click

        vg.gEvento = "tsmiEmail_Click"

        'Envia email
        Call SubEnvioEmail()
        '-------------------

    End Sub

    '005 Evento ejecuta [SubEnvioEmail]  Habilita los controles del email
    Private Sub tsbEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEmail.Click

        vg.gEvento = "tsbEmail_Click"

        'Envia email
        Call SubEnvioEmail()
        '-------------------

    End Sub

    '006 Evento ejecuta [SubCierraFormulario] Cierra el formulario
    Private Sub tsmiSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiSalir.Click

        vg.gEvento = "tsmiSalir_Click"

        Close()

    End Sub

    '007 Evento ejecuta [SubCierraFormulario] Cierra el formulario
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubEnviaEmailViaOutlook] Envio la clave por Outlook
    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click

        vg.gEvento = "btnEnviarEmail_Click"

        Call SubEnviaEmailViaOutlook()
        '-----------------------------

    End Sub

    '009 Evento ejecuta [SubAbreArchivoNotePad] Abre el archivo texto con la clave
    Private Sub btnAbrirArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirArchivo.Click

        vg.gEvento = "btnAbrirArchivo_Click"

        Call SubAbreArchivoNotePad()
        '---------------------------

    End Sub

    '010 Evento ejecuta [SubLimpiaEmail] Limpia campo de Email
    Private Sub txtEmailOrigen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmailOrigen.Click

        vg.gEvento = "txtEmailOrigen_Click"

        Call SubLimpiaEmail()
        '--------------------

    End Sub

    '011 Evento ejecuta [SubHabilitaBotonGuardar] Habilita el boton de guardar
    Private Sub dtpNacimiento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNacimiento.TextChanged

        vg.gEvento = "dtpNacimiento_TextChanged"

        Call SubHabilitaBotonGuardar()
        '-----------------------------

    End Sub

    '012 Evento ejecuta [SubHabilitaBotonGuardar] Habilita el boton de guardar
    Private Sub dtpNacimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpNacimiento.ValueChanged

        vg.gEvento = "dtpNacimiento_ValueChanged"

        Call SubHabilitaBotonGuardar()
        '-----------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] Carga el Formulario de registro
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            'Inhabilita botones menu
            tsmiGuardar.Enabled = False
            tsmiEmail.Enabled = False
            'Inhabilita barra de botones
            tsbGuardar.Enabled = False
            tsbEmail.Enabled = False
            'Asigna el titulo del formulario
            lblTitulo.Text = " Generación de Clave para Registro de la Aplicación"

            'Genera licencia de uso
            Call subGeneraLicencia()
            '------------------------

            Call SubMenOK(" Seleccione la Fecha de Nacimiento ", 1)
            '------------------------------------------------------
            dtpNacimiento.Select()

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubGeneraLicencia] Habillita Fecha para generar la licencia
    Sub SubGeneraLicencia()

        vg.gEvento = "SubGeneraLicencia"

        Try

            'Genera la licencia
            txtLicencia.Text = gMet.FunInfoPc()
            '------------------------------------

            dtpNacimiento.Enabled = True
            dtpNacimiento.Select()

            Call SubMenOK(" Seleccione la Opción [ Email ], para Enviar la licencia por Correo Electrónico ", 1)
            '---------------------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '003 SUB [SubGuardarClave] Guarda el archivo texto con la clave
    Sub SubGuardarClave()

        vg.gEvento = "SubGuardarClave"

        Try


            Call SubMenOK(" Guardando el Archivo con la Licencia Generada ...", 2)
            '---------------------------------------------------------------------

            Call subGuardaArchivoRegistro()
            '------------------------------

            Call SubMenOK(" Archivo con la Licencia Guardada ...", 2)
            '--------------------------------------------------------

            Call SubMenOK(" Enviar por Email la Licencia, Seleccione la Opción [Email] ", 2)
            '-------------------------------------------------------------------------------
            tsmiEmail.Enabled = True
            tsbEmail.Enabled = True

            lblRutaArchivo.Text = "C:\RegistroCalculadoraIMSS"
            lblArchivo.Text = "RegistroCalculadoraIMSS.txt"

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [SubEnvioEmail] Habilita los controles del email
    Sub SubEnvioEmail()

        vg.gEvento = "SubEnvioEmail"

        Try

            lblEmail.Visible = True
            txtEmailOrigen.Visible = True
            btnEnviarEmail.Visible = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [SubEnviaEmailViaOutlook] Envio la clave por Outlook
    Sub SubEnviaEmailViaOutlook()

        vg.gEvento = "SubEnviaEmailViaOutlook"

        Dim vEmail As String
        Dim vEmailFormato As Boolean

        Dim vTO As String = "carsanram@gmail.com"
        Dim vSubject As String = "Registro de aplicacion de calculadora IMSS 73-97"
        Dim vBody As String
        Dim vEnvioOk As Boolean
        Dim vRegistro As String
        Dim vNIT As String

        Try

            'obtiene el ID del CPU
            vRegistro = txtLicencia.Text

            'Asigna el email de origen y fecha de nacimiento
            vEmail = txtEmailOrigen.Text
            vNIT = dtpNacimiento.Value

            'Valida la estructura del email ingresado
            vEmailFormato = mUniversal.FunValidaEmail(vEmail)
            '-----------------------------------------------

            'Valida si el formato es valido, procede a enviar el email 
            If vEmailFormato Then

                'Mensaje del email
                vBody = "Estimado Usuario:" & vbCrLf & vbCrLf & "Para Complementar el Registro de la Calculadora, Favor de Contactar a:" &
                    vbCrLf & "Carlos Sanchez Ramirez" & vbCrLf & "Cel: 55-2560-9617 " & vbCrLf & "Whats App: 55-2560-9617 " & vbCrLf &
                    "Email: carsanram@gmail" & vbCrLf & "Para Recibir Instrucciones del Pago de la Licencia de Uso" & vbCrLf & vbCrLf &
                    "Gracias por su Interes en la Calculadora de Pensiones IMSS 73-97" & vbCrLf & vbCrLf & "ID Sistema: " & vRegistro & vbCrLf &
                    "NIT: " & vNIT

                'Envio del email usuado Outlook regresando si fue o no exitoso el envio
                vEnvioOk = mUniversal.FunEnviaEmailxOutlook(vTO, vSubject, vBody)
                '----------------------------------------------------------------

                'Si el envio del email fue exitoso
                If vEnvioOk Then

                    Call SubMenOK(" Envio de Email Exitoso ", 4)
                    '-------------------------------------------

                    Call SubMenOK("", 1)
                    '-------------------

                    'Si el envio del email NO fue exitoso
                Else

                    Call SubMenError(" No se Envio el Email, Favor de Enviar el Archivo con el ID de CPU de Manera Manual ", 3)
                    '----------------------------------------------------------------------------------------------------------

                    Call SubMenOK("", 1)
                    '-------------------

                End If

                'El formato del mensaje de email es erroneo
            Else
                Call SubMenError(" Error en Formato de Email, Favor de Corregir ", 3)
                '---------------------------------------------------------------------

                Call SubMenOK("", 1)
                '-------------------

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 SUB [SubAbreArchivoNotePad] Abre el archivo texto con la clave
    Sub SubAbreArchivoNotePad()

        vg.gEvento = "SubAbreArchivoNotePad"

        Try

            Process.Start("notepad.exe", "C:\RegistroCalculadoraIMSS\RegistroCalculadoraIMSS.txt")

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubLimpiaEmail] Limpia campo de Email
    Sub SubLimpiaEmail()

        vg.gEvento = "SubLimpiaEmail"

        Try

            txtEmailOrigen.Text = ""

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubHabilitaBotonGuardar] Habilita el boton de guardar
    Sub SubHabilitaBotonGuardar()

        vg.gEvento = "SubHabilitaBotonGuardar"

        Try

            Call SubMenOK(" Seleccione la Opción [Guardar] para Generar Archivo de Texto con la Licencia ... ", 1)
            '-------------------------------------------------------------------------------------------------------

            tsmiGuardar.Enabled = True
            tsbGuardar.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)


        End Try

    End Sub

    '009 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '010 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '011 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
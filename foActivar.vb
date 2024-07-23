

Public Class foActivar

    'Variables Globales del Formulario
    Dim vNameApp As String = "Catálogos"
    Dim gNomFormulario As String = "foActivar"
    Dim gCreaBitacora As Boolean = True

    Dim vRegPorPeriodoPrueba As Boolean
    Dim vRegPorClave As Boolean
    Dim vActivador As String

    'Constante para generar una clave, esta debe de estar tambien en la aplicacion que genera las claves
    Const Clave = "1978"
    Const TiempoPrueba = 30

    'Ruta Registro  Equipo\HKEY_CURRENT_USER\SOFTWARE\ctlgs

    '--------------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS ------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foFormularioBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foFormularioBase_Load"

        Call subCargaFormulario()
        '------------------------

        Call SubGeneraAntecendentesLlave()
        '---------------------------------

    End Sub

    '002 Evento Click en Texto Codigo de activacion
    Private Sub txtCodigoActivacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoActivacion.Click

        vg.gEvento = "txtCodigoActivacion_Click"

        Call subLimpiaCodigoActivacion()
        '-------------------------------

    End Sub

    '003 Evento ejecuta [SubActivarLicencia] para mostrar la activacion
    Private Sub tsbActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbActivar.Click

        vg.gEvento = "tsbActivar_Click"

        Call subActivarLicencia(Me)
        '--------------------------

    End Sub

    '004 Evento ejecuta [SubActivarLicencia] Activacion de la aplicacion
    Private Sub mnuActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActivar.Click

        vg.gEvento = "mnuActivar_Click"

        Call subActivarLicencia(Me)
        '--------------------------

    End Sub

    '005 Evento ejecuta [SubValidaDatos] para validar los datos de entrada
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        vg.gEvento = "tsbValidar_Click"

        Call SubMenOK(" Validando .... Espere ", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '006 Evento ejecuta [SubProbar] Genera el registro del perido de prueba de la aplicacion
    Private Sub mnuPrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrueba.Click

        vg.gEvento = "mnuPrueba_Click"

        Call SubProbar()
        '---------------

    End Sub

    '007 Evento ejecuta [SubProbar] Genera el periodo de prueba
    Private Sub tsbPrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrueba.Click

        vg.gEvento = "tsbPrueba_Click"

        Call SubProbar()
        '---------------

    End Sub

    '008 Evento ejecuta [SubRegistrar] Genera el registro de la aplicacion y manda en email
    Private Sub mnuRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistrar.Click

        vg.gEvento = "mnuRegistrar_Click"

        Call subRegistrar()
        '------------------

    End Sub

    '009 Evento ejecuta [SubRegistrar] Genera el registro de la aplicacion
    Private Sub tsbRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRegistrar.Click

        vg.gEvento = "tsbRegistrar_Click"

        Call SubRegistrar()
        '------------------

    End Sub

    '010 Evento ejecuta [SubCreaBitacoraSiNo] Genera la bitacora
    Private Sub TSMIBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMIBitacora.Click

        vg.gEvento = "TSMIBitacora_Click"

        Call subCreaBitacoraSiNo()
        '-------------------------

    End Sub

    '011 Evento Salir de la aplicacion
    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click

        vg.gEvento = "mnuSalir_Click"

        Close()

    End Sub

    '012 Evento Salir de la aplicacion
    Private Sub tsbSalir_Click_(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] Configuracion y carga del formualario
    Sub SubCargaFormulario()

        vg.gEvento = "subCargaFormulario"

        Try

            vg.gNomApp = "Catalogos"
            vg.gCveNomApp = "ctlgs"
            vg.gCreaBitacora = True

            'Desactiva la opcion de Activar
            tsbActivar.Enabled = False
            mnuActivar.Enabled = False

            Call gMet.SubCreaBitacora("Activacion")
            '--------------------------------------

            'Activa la creacion de bitacora
            If TSMIBitacora.CheckState Then

                vg.gCreaBitacora = True
                vg.gEl = True

                Call gMet.SubCreaBitacora("Activacion")
                '--------------------------------------
            Else
                gCreaBitacora = False
                vg.gEl = False

            End If

            dtpNacimiento.Value = Today

            lblTitulo.Text = " Activar Licencia de Uso de la Aplicación: " & vNameApp

            Call SubMenOK(" Ingrese la Información Requerida ", 1)
            '-----------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubGeneraAntecendentesLlave] Genera la llave con la informacion del Equipo en donde esta instalada la aplicacion
    Sub SubGeneraAntecendentesLlave()

        vg.gEvento = "subGeneraAntecendentesLlave"

        Try

            'Genera ID del Procesador
            vg.gMensaje = "Seleccione la Opción a Ejecutar"

            gMet.FunMensajeBox(foAvisoLargo, vg.gMensaje, psTypeOfMsg.psNormal, 3, 10, 1)
            '----------------------------------------------------------------------------

            vRegPorPeriodoPrueba = False
            vRegPorClave = False

            'Genera ID del Procesador
            vg.gIDcpu = gMet.FunInfoPc
            '-------------------------

            Call gMet.SubEscribeBitacora("Serial del Computador: " & vg.gIDcpu, vg.gEl)
            '-------------------------------------------------------------------------

            'Asigna el ID de la Computadora
            txtIdMaquina.Text = vg.gIDcpu

            'Obtiene el NIT del Registro
            vg.gNIT = FunObtieneNIT()
            '------------------------

            Call gMet.SubEscribeBitacora("NIT: " & gNIT, vg.gEl)
            '--------------------------------------------------

            'Obtiene la clave de activacion
            vg.gActivador = FunActivador()
            '-----------------------------

            Call gMet.SubEscribeBitacora("Key: " & gActivador, vg.gEl)
            '--------------------------------------------------------

            'Genera el numero de serial con el valor del NIT
            Call SubGenerarSerialVer(gNIT)
            '-----------------------------

            If Not (FunRegistroAplicacion()) Then

                Call gMet.SubEscribeBitacora("Aplicación No Registrada ", vg.gEl)
                '----------------------------------------------------------------

                'Valida si exite registro de prueba
                vRegPorPeriodoPrueba = FunPeriodoPruebaExiste()
                '----------------------------------------------

                If Not (vRegPorPeriodoPrueba) Then 'Fecha de vigencia en prueba
                    'Existe periodo de prueba
                    tsbPrueba.Enabled = True
                    mnuPrueba.Enabled = True

                    Call gMet.SubEscribeBitacora("No Existe Periodo de Prueba ", vg.gEl)
                    '-------------------------------------------------------------------
                Else

                    tsbPrueba.Enabled = False
                    mnuPrueba.Enabled = False
                    Dim vPruebaOK As Boolean

                    vPruebaOK = FunVerificaPeriodoPruebaOk()
                    '---------------------------------------
                    If vPruebaOK Then
                        spSplash.Show()

                        Call gMet.SubEscribeBitacora("Periodo de Prueba Valido", vg.gEl)
                        '--------------------------------------------------

                        Close()

                        Call gMet.SubEscribeBitacora("Periodo de Prueba Valido", vg.gEl)
                        '----------------------------------------------------------------
                    Else

                        FunVerificaPeriodoPruebaVencido()
                        '--------------------------------
                        Call SubMenOK(" Periodo de Prueba Vencido o Incorrecta la Fecha de la Computadora", 10)
                        '-------------------------------------------------------------------------------------

                        'Verifica activacion de Licencia
                        Call subVerificarActivacion()
                        '----------------------------

                    End If
                End If
            Else

                Call subVerificarActivacion()
                '----------------------------

                spSplash.Show()

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 SUB [SubGenerarSerialVer] Arma la llave completa del equipo
    Sub SubGenerarSerialVer(ByVal pNIT)

        vg.gEvento = "SubGenerarSerialVer"

        Dim Serial As String

        Try

            'Para generar el serial usamos en Nit del cliente, el ID de la maquina y la clave
            Serial = pNIT & "_" & vg.gIDcpu & "_" & Clave

            vg.gSerialGeneradoAutomatico = FunGenerarClave(Serial)
            '-----------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [SubActivarLicencia] Activa la licencia ingresada en el formulario
    Sub SubVerificarActivacion()

        vg.gEvento = "subVerificarActivacion"

        Dim SerialActual As String

        'Valida si ya el software esta activo o no consoltando en el registro del sistema si existe la clave
        'Obtiene el nombre de la aplicacion para crear su lugar en el Registro de Windows

        Try

            vNameApp = vg.gNomApp

            'Consultamos la clave a ver si ya existe, y si nos devuelce el serial guardado
            'Obtenemos el la vigencia del registro
            vg.gSerialRegistro = gMet.FunGetRegistryValue("SerialKey")
            vg.gNIT = gMet.FunGetRegistryValue("NP")
            vg.gPropietarioSoft = gMet.FunGetRegistryValue("Owner")


            Call gMet.SubEscribeBitacora("Usuario Registrado: " & vg.gPropietarioSoft, vg.gEl)
            '---------------------------------------------------------------------------------

            'Se genera el serial con los datos obtenidos del sistema y se verifica si son iguales a los que generamos en el sistema
            vg.gSerial = vg.gNIT & "_" & vg.gIDcpu & "_" & Clave

            SerialActual = FunGenerarClave(vg.gSerial) 'Se genera el serial

            If SerialActual = vg.gSerialRegistro Then 'Si son iguales se cierra el formulario actual y se abre el principal

                vg.gPropietarioSoft = vg.gPropietarioSoft
                vg.gNITPropietarioSoft = vg.gNIT
                vg.gSerialSoft = vg.gSerialRegistro

                spSplash.Show()

                Close()

                Exit Sub

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [SubActivarLicencia] Activa la licencia ingresada en el formulario
    Sub SubActivarLicencia(ByVal frm As Form)

        vg.gEvento = "subActivarLicencia"

        Dim vDateNIT As String

        Try

            Call SubMenOK(" Activando Licencia .... Espere", 1)
            '--------------------------------------------------

            vDateNIT = mUniversal.FunFortDateAAMMDD(dtpNacimiento.Value)
            '-----------------------------------------------------------

            Call subGenerarSerial(vDateNIT)
            '------------------------------

            'Valida la captura de los datos de usuario
            If txtPropietario.Text = "" Then
                Call SubMenError(" Debe de Ingresar el Nombre del Propietrario de la Licencia de Uso del Software a Registrar ", 1)
                '------------------------------------------------------------------------------------------------------------------
                txtPropietario.Select()
                Exit Sub
            Else

                Call SubMenOK("", 1)
                '-------------------

            End If

            If txtCodigoActivacion.Text = "" Then

                Call SubMenError(" Ingresar el Codigo de Activación Proporcionado por el Desarrollador de la Aplicación  ", 1)
                '-------------------------------------------------------------------------------------------------------------
                txtCodigoActivacion.Select()
                Exit Sub
            Else
                Call SubMenOK("", 1)
                '-------------------
            End If

            vNameApp = vg.gNomApp

            If txtCodigoActivacion.Text = gSerialGeneradoAutomatico Then

                'Guarda en el registro de windows los datos del usuario
                Call gMet.SubSetRegistryValue("SerialKey", gSerialGeneradoAutomatico)
                Call gMet.SubSetRegistryValue("NP", vDateNIT)
                Call gMet.SubSetRegistryValue("Owner", txtPropietario.Text)
                Call gMet.SubDelRestryValue("Registration")
                Call gMet.SubDelRestryValue("Validity")
                '---------------------------------------------------------------------

                'Obtenemos la vigencia del registro para la pantalla de acerca de
                vg.gPropietarioSoft = txtPropietario.Text
                vg.gNITPropietarioSoft = vDateNIT

                vg.gSerialSoft = vg.gSerialGeneradoAutomatico

                vg.gMensaje = " Aplicación Activada con Exito, Gracias Por Su Compra"
                gMet.FunMensajeBox(foAvisoLargo, gMensaje, psTypeOfMsg.psNormal, 10, 10)

                foAvisoLargo.Show()
                foAvisoLargo.lblMensaje.BackColor = Color.FromArgb(203, 255, 254) 'Verde
                foAvisoLargo.Refresh()

                Call mUniversal.SubPausa(Me, 5)
                '------------------------------

                foAvisoLargo.Close()

                Call SubMenOK(" Licencia Activada", 3)
                '-------------------------------------

                spSplash.Show()

                Close()

            Else

                vg.gMensaje = " Aplicación Activada sin Exito" & vbCrLf & " Ingrese la Información Correcta o Solicite la Clave de Activación al Desarrollador al Email: " & vbCrLf & vbCrLf &
                    " carsanram@gmail.com"
                gMet.FunMensajeBox(foAvisoLargo, vg.gMensaje, psTypeOfMsg.psCritical, 10, 10)


                foAvisoLargo.lblMensaje.BackColor = Color.Red
                foAvisoLargo.Show()
                foAvisoLargo.Refresh()

                Call mUniversal.SubPausa(Me, 10)
                '------------------------------

                foAvisoLargo.Close()

                Call gMet.SubEscribeBitacora("Registro No Exitoso de la Aplicación", vg.gEl)
                '---------------------------------------------------------------------------

                Call SubMenOK(" Licencia NO Activada, Ingrese Información Valida", 3)
                '--------------------------------------------------------------------

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 SUB [SubGenerarSerial] Arma la clave del serial
    Sub SubGenerarSerial(ByVal pDateNIT As String)

        vg.gEvento = "subGenerarSerial"

        Dim Serial As String

        Try

            'Para generar el serial usamos en Nit del cliente, el ID de la maquina y la clave
            Serial = pDateNIT & "_" & vg.gIDcpu & "_" & Clave

            vg.gSerialGeneradoAutomatico = FunGenerarClave(Serial)
            '-----------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubEscribeRegWindowsPeriodo] Esscribe en el registro de widows el periodo de prueba
    Sub SubEscribeRegWindowsPeriodo(ByVal frm As Form)

        vg.gEvento = "SubEscribeRegWindowsPeriodo"

        Dim vfechaRegistro As String
        Dim vFechaFinalizacion As String
        Dim vNameApp As String
        Dim pFecha As Date

        Try

            pFecha = Now

            vfechaRegistro = FunFormatoFecha(pFecha)
            '---------------------------------------

            'Convierte a serial la fecha
            vfechaRegistro = mUniversal.FunDateToSerial(vfechaRegistro)
            '----------------------------------------------------------

            'Tiempo duracion de la prueba de la aplicacion
            pFecha = DateAdd("d", TiempoPrueba, Now)

            vFechaFinalizacion = FunFormatoFecha(pFecha)
            '-------------------------------------------

            'Convierte a serial la fecha vigencia
            vFechaFinalizacion = mUniversal.FunDateToSerial(vFechaFinalizacion)
            '------------------------------------------------------------------

            vNameApp = vg.gNomApp

            Call gMet.SubSetRegistryValue("Registration", vfechaRegistro)
            Call gMet.SubSetRegistryValue("Validity", vFechaFinalizacion)
            '-------------------------------------------------------------

            vg.gMensaje = " Inicia Periodo de Prueba Gratis del Uso de la Aplicación: " & vbCrLf & vbCrLf &
                " Inicio: " & mUniversal.FunSerialToDate(vfechaRegistro) & " " & vbCrLf &
                " Fin:    " & mUniversal.FunSerialToDate(vFechaFinalizacion) & " " & vbCrLf & vbCrLf &
                " Favor de Reiniciar la Aplicación Para Activar el Periodo de Prueba Gratis"

            gMet.FunMensajeBox(foAvisoLargo, vg.gMensaje, psTypeOfMsg.psNormal, 5, 11)
            '-------------------------------------------------------------------------

            foAvisoLargo.lblMensaje.BackColor = Color.FromArgb(203, 255, 254) 'Verde
            foAvisoLargo.Show()
            foAvisoLargo.Refresh()

            Call mUniversal.SubPausa(Me, 8)
            '------------------------------

            foAvisoLargo.Close()

            tsbPrueba.Enabled = False
            mnuPrueba.Enabled = False

            Close()

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubProbar] Registra en registro de WIndows los datos del registro
    Sub SubProbar()

        vg.gEvento = "subProbar"

        Call SubMenOK(" Registrando el Periodo de Prueba .... Espere", 1)
        '----------------------------------------------------------------

        Call SubEscribeRegWindowsPeriodo(Me)
        '-----------------------------------

        'Borra los registros viejos
        Call gMet.SubDelRestryValue("SerialKey")
        Call gMet.SubDelRestryValue("NP")
        Call gMet.SubDelRestryValue("Owner")
        '-----------------------------------

        Call SubMenOK(" Periodo de Prueba Registrado", 1)
        '------------------------------------------------

    End Sub

    '009 SUB [SubRegistrar] Muestra el formulario de registro del usuario
    Sub SubRegistrar()

        vg.gEvento = "SubRegistrar"

        Call SubMenOK(" Mostrando Pantalla para Generar ID PC .... Espere", 2)
        '---------------------------------------------------------------------

        foRegistro.Show()

        Call SubMenOK(" Ingrese la Información Requerida ", 1)
        '-----------------------------------------------------

    End Sub

    '010 SUB [SubCreaBitacoraSiNo] Habillita si genera bitacora o no
    Sub SubCreaBitacoraSiNo()

        vg.gEvento = "subCreaBitacoraSiNo"

        Try

            If TSMIBitacora.CheckState Then
                vg.gCreaBitacora = True
                vg.gEl = True

                Call gMet.SubCreaBitacora("Activacion")
                '--------------------------------------
            Else
                gCreaBitacora = False
                vg.gEl = True

                Call gMet.SubBorraBitacora()
                '---------------------------
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '011 SUB [SubLimpiaCodigoActivacion] Limpia el codigo de activacion
    Sub SubLimpiaCodigoActivacion()

        vg.gEvento = "subLimpiaCodigoActivacio"

        txtCodigoActivacion.Text = ""

    End Sub

    '012 FUN [FunSerialNIT] Genera NIT con la fecha de nacimiento del usuario
    Function FunSerialNIT(ByRef gNIT) As String

        vg.gEvento = "FunSerialNIT"

        Dim vA As String
        Dim vM As String
        Dim vD As String
        Dim vFecSerial As Integer
        Dim vFecPaso As Date

        FunSerialNIT = ""

        Try

            If gNIT = "" Then
                vD = Mid(dtpNacimiento.Value.ToString, 1, 2)
                vM = Mid(dtpNacimiento.Value.ToString, 4, 2)
                vA = Mid(dtpNacimiento.Value.ToString, 7, 4)
            Else
                vA = Mid(gNIT, 1, 4)
                vM = Mid(gNIT, 5, 2)
                vD = Mid(gNIT, 7, 2)
            End If

            FunSerialNIT = ""

            If vA = "" Or vM = "" Or vD = "" Then
                FunSerialNIT = "000000"
            Else
                vFecPaso = CDate(vD & "/" & vM & "/" & vA)
                vFecSerial = DateSerial(vA, vM, vD).ToOADate()
                FunSerialNIT = vFecSerial.ToString
            End If
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return FunSerialNIT

    End Function

    '013 FUN [FunObtieneNIT] Obtiene el valor del registro NIT
    Function FunObtieneNIT() As String

        vg.gEvento = "FunObtieneNIT"

        Dim vNameApp As String
        FunObtieneNIT = ""

        Try
            vNameApp = vg.gNomApp


            'Consultamos el NIT del registro
            FunObtieneNIT = gMet.FunGetRegistryValue("NP")
            '---------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return FunObtieneNIT

    End Function

    '014 FUN [FunActivador] Obtiene el SerialKey del registro de windows
    Function FunActivador() As String

        vg.gEvento = "FunActivador"

        FunActivador = ""

        Try
            'Consultamos el NIT del registro
            FunActivador = gMet.FunGetRegistryValue("SerialKey")
            '---------------------------------------------------
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


        Return FunActivador

    End Function

    '015 FUN [FunRegistroAplicacion] Obtiene verdadero, si existe el registro en Windows
    Function FunRegistroAplicacion() As Boolean

        vg.gEvento = "FunRegistroAplicacion"

        FunRegistroAplicacion = False

        Try

            If vg.gSerialGeneradoAutomatico = vg.gActivador Then
                FunRegistroAplicacion = True
            Else
                FunRegistroAplicacion = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '016 FUN [FunVerificaPeriodoPruebaOk] Verifica que el periodo de prueba de la aplicacion este activo
    Function FunVerificaPeriodoPruebaOk() As Boolean

        vg.gEvento = "FunVerificaPeriodoPruebaOk"

        Dim vHoy As Date
        Dim vDias As Integer
        Dim vfechaRegistro As String
        Dim vfechaVigencia As String
        Dim vfecVig As Date
        Dim vFecHoyComputadora As Integer

        Try
            vNameApp = vg.gNomApp
            vHoy = FunFormatoFecha(Now)

            vFecHoyComputadora = FunDateToSerial(vHoy)
            '-----------------------------------------

            'Obtenemos el la vigencia del registro
            vfechaVigencia = gMet.FunGetRegistryValue("Validity")
            '----------------------------------------------------

            vfechaRegistro = gMet.FunGetRegistryValue("Registration")
            '----------------------------------------------------

            vfecVig = CDate(FunSerialToDate(vfechaVigencia))
            '-----------------------------------------------

            'Valida que no se cambie la fecha de la computadora
            If vFecHoyComputadora < vfechaRegistro Then

                FunVerificaPeriodoPruebaOk = False
                '----------------------------------

                Exit Function

            Else

                If vHoy <= vfecVig Then

                    'Calcula los dias que restan para su uso
                    vDias = DateDiff("d", vHoy, (vfecVig)) + 1

                    If vDias >= 0 Then
                        vg.gMensaje = UCase(vg.gNomApp) & vbCrLf & vbCrLf & " Fecha de Vencimiento:  " & vfecVig & " " & vbCrLf & vbCrLf & " Faltan " & vDias & " Dia(s) Para Finalizar el Periodo de Prueba"
                        foAvisoLargo.lblMensaje.BackColor = Color.FromArgb(247, 255, 6) 'Amarillo
                        gMet.FunMensajeBox(foAvisoLargo, vg.gMensaje, psTypeOfMsg.psWarning, 10, 10)

                        Call gMet.SubEscribeBitacora("Periodo de Prueba Vencimiento " & vfecVig, vg.gEl)
                        '-------------------------------------------------------------------------------

                    Else
                        vg.gMensaje = " Acceso a la Aplicación:  " & vg.gNomApp & vbCrLf & vbCrLf & " Termina el Dia de Hoy..." & vbCrLf & vbCrLf & " Si Quiere Continuar Utilizando la Aplicacion, Favor de Solicitar el Registro Correspondiente"
                        foAvisoLargo.lblMensaje.BackColor = Color.FromArgb(255, 184, 174) 'Rojo
                        gMet.FunMensajeBox(foAvisoLargo, vg.gMensaje, psTypeOfMsg.psCritical, 10, 10)
                    End If

                    foAvisoLargo.Show()
                    foAvisoLargo.Refresh()

                    Call mUniversal.SubPausa(Me, 5)
                    '------------------------------

                    foAvisoLargo.Close()

                    FunVerificaPeriodoPruebaOk = True
                    '--------------------------------

                Else

                    If vDias <= 0 Then
                        vg.gMensaje = " Acceso a la Aplicación:  " & vg.gNomApp & " Termino ... " & vbCrLf & " Si Quiere Continuar Utilizando la Aplicacion, Favor de Solicitar el Registro Correspondiente"
                        foAvisoLargo.lblMensaje.BackColor = Color.FromArgb(255, 184, 174) 'Rojo
                        gMet.FunMensajeBox(foAvisoLargo, vg.gMensaje, psTypeOfMsg.psCritical, 10, 10)
                    End If

                    foAvisoLargo.Show()
                    foAvisoLargo.Refresh()

                    Call mUniversal.SubPausa(Me, 5)
                    '------------------------------

                    foAvisoLargo.Close()

                    FunVerificaPeriodoPruebaOk = False
                    '----------------------------------

                End If

            End If


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return FunVerificaPeriodoPruebaOk

        Exit Function

    End Function

    '017 FUN [FunPeriodoPruebaExiste] Valida si existe un periodo de prueba
    Function FunPeriodoPruebaExiste() As Boolean

        vg.gEvento = "FunPeriodoPruebaExiste"

        Dim vFechaFin As String

        Try

            vFechaFin = gMet.FunGetRegistryValue("Validity")
            vFechaFin = mUniversal.FunSerialToDate(vFechaFin)
            '------------------------------------------------

            vFechaFin = CDate(vFechaFin)

            If IsDate(vFechaFin) Then
                FunPeriodoPruebaExiste = True

                Call gMet.SubEscribeBitacora("Periodo de Prueba Existente OK", vg.gEl)
                '---------------------------------------------------------------------
            Else
                FunPeriodoPruebaExiste = False
                Call gMet.SubEscribeBitacora("Periodo de Prueba Existente NO", vg.gEl)
                '---------------------------------------------------------------------
            End If

        Catch ex As Exception

            FunPeriodoPruebaExiste = False

        End Try

    End Function

    '018 FUN [FunVerificaPeriodoPruebaVencido] Valida si el periodo de prueba esta vencido
    Function FunVerificaPeriodoPruebaVencido() As Boolean

        vg.gEvento = "FunVerificaPeriodoPruebaVencido"

        FunVerificaPeriodoPruebaVencido = False

        Dim vHoy As Date
        Dim vfechaVigencia As Date
        Dim vMensaje As String

        Try

            vNameApp = UCase(vg.gNomApp)
            vHoy = Now.Year & "/" & Now.Month & "/" & Now.Day

            'Obtenemos el la vigencia del registro
            vfechaVigencia = gMet.FunGetRegistryValue("Validity")
            '----------------------------------------------------

            'Validamos el registro
            If vHoy > vfechaVigencia Then
                vMensaje = " Se Termino el Periodo de Prueba del Uso de la Aplicación .." &
                   vbCrLf & " Para Utilizarla Nuevamente, Enviar un Email a: " & vbCrLf & " carsanram@gmail.com " &
                   vbCrLf & " WhatsApp 55-2560-9617 " & vbCrLf &
                   vbCrLf & " Para Solicitar Informes de Como Renovar La Licencia de Uso" & vbCrLf & vbCrLf & " Gracias"

                gMet.FunMensajeBox(foAvisoLargo, vMensaje, psTypeOfMsg.psCritical, 10, 10)
                '-----------------------------------------------------------------------
                foAvisoLargo.lblMensaje.BackColor = Color.FromArgb(255, 184, 174) 'Rojo
                foAvisoLargo.Show()
                foAvisoLargo.Refresh()

                Call mUniversal.SubPausa(Me, 5)
                '------------------------------

                foAvisoLargo.Close()

                Call gMet.SubEscribeBitacora("Perido de Prueba Vencido", vg.gEl)
                '---------------------------------------------------------------

                FunVerificaPeriodoPruebaVencido = True

            End If

            Return FunVerificaPeriodoPruebaVencido

        Catch ex As Exception

            'MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return FunVerificaPeriodoPruebaVencido

        Exit Function

    End Function

    '019 FUN [FunFormatoFecha] Convierte formato de fecha a DD/MM/YYYY
    Function FunFormatoFecha(ByRef pFecha As Date) As String

        vg.gEvento = "unFormatoFecha"

        Dim vAño As String
        Dim vMes As String
        Dim vDia As String

        FunFormatoFecha = ""

        Try

            vAño = pFecha.Year
            vMes = pFecha.Month
            vDia = pFecha.Day

            If Len(vMes) < 2 Then
                vMes = "0" & vMes
            End If

            If Len(vDia) < 2 Then
                vDia = "0" & vDia
            End If

            FunFormatoFecha = vDia & "/" & vMes & "/" & vAño

            Return FunFormatoFecha

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '020 FUN [FunGenerarClave] Genera la Clave del Serial
    Function FunGenerarClave(ByVal Usuario As String) As String

        vg.gEvento = "FunGenerarClave"

        Dim vFecSerial As String

        'Generamos una clave tenediendo en cuenta el Id de la CPU y la fecha de de nacimiento del usuario
        'Obtenemos la longitud de la cadena de usuario
        Dim longitud As Byte

        'Declaramos valorEntrada para obtener el valor general correspondiente a la entrada de usuario
        Dim valorEntrada As Long

        FunGenerarClave = ""

        Try

            valorEntrada = 0

            vFecSerial = FunSerialNIT(gNIT)
            '------------------------------

            Usuario = Usuario + CStr(vFecSerial)
            longitud = Len(Usuario)

            Dim i As Byte
            'Recorremos la cadena entera para sumar el valor total de sus ASCII
            Dim paso As String
            Dim pasoc As String

            For i = 1 To longitud
                valorEntrada = valorEntrada + Asc(Mid(Usuario, i, 1))
                pasoc = Asc(Mid(Usuario, i, 1))
                paso = Mid(Usuario, i, 1)
            Next

            'Obtenemos un valor base que corresponde con el c del producto entre el valor de entrada anteriormente calcula por su longitud
            Dim valorBase As Integer
            valorBase = valorEntrada * longitud
            Dim key As String
            key = ""
            'Empezamos obteniento valores
            'Obtenemos el valor hexadecimal
            Dim Valor As String
            Valor = Hex(valorBase + (123 * 100))

            key = key & Mid(Valor, Len(Valor) - 2, 6)
            'Obtenemos el valor hexadecimal
            Valor = Hex(valorBase + (98 * 125))
            'Obtenemos el valor de clave
            key = key & "-" & Mid(Valor, 1, 7)
            'Obtenemos el valor hexadecimal
            Valor = Hex(valorBase + (77 * 150))
            'Obtenemos el valor de clave
            key = key & "-" & Mid(Valor, Len(Valor) - 2, 6)
            'Obtenemos el valor hexadecimal
            Valor = Hex(valorBase + (121 * 175))
            'Obtenemos el valor de clave
            key = key & "-" & Mid(Valor, 1, 6)
            'Obtenemos el valor hexadecimal
            Valor = Hex(valorBase + (55 * 200))
            'Obtenemos el valor de clave
            key = key & "-" & Mid(Valor, Len(Valor) - 2, 6)
            'Obtenemos el valor hexadecimal
            Valor = Hex(valorBase + (134 * 225))

            vFecSerial = FunSerialNIT(gNIT)

            FunGenerarClave = key & "-" & CStr(vFecSerial)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '021 FUN [FunVAlidaPropietario] Valida el Propietario
    Function FunVAlidaPropietario() As Boolean

        vg.gEvento = "FunVAlidaPropietario"

        FunVAlidaPropietario = False

        Try

            If txtPropietario.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '022 FUN [FunValidaNacimiento] Valida el nacimiento
    Function FunValidaNacimiento() As Boolean

        vg.gEvento = "FunValidaNacimiento"

        FunValidaNacimiento = False

        Try
            If dtpNacimiento.Value = Today Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '023 FUN [FunVAlidaPropietario] Valida el Codigo de Activacion
    Function FunValidaCodigo() As Boolean

        vg.gEvento = "FunValidaCodigo"

        FunValidaCodigo = False

        Try

            If txtCodigoActivacion.Text = "" Or txtCodigoActivacion.Text = "Codigo de Activación" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '024 SUB [SubValidaDatos] Valida la informacion capturada
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunVAlidaPropietario() Then
                tsbActivar.Enabled = True
                mnuActivar.Enabled = True
            Else
                Call SubMenError(" Error en Propietario ", 1)
                '--------------------------------------------

                tsbActivar.Enabled = False
                txtPropietario.Select()
                Exit Sub
            End If

            If FunValidaNacimiento() Then
                tsbActivar.Enabled = True
                mnuActivar.Enabled = True
            Else
                Call SubMenError(" Error en Nacimiento ", 1)
                '-------------------------------------------

                tsbActivar.Enabled = False
                dtpNacimiento.Select()
                Exit Sub
            End If

            If FunValidaCodigo() Then
                tsbActivar.Enabled = True
                mnuActivar.Enabled = True
            Else
                Call SubMenError(" Error en Clave Activación ", 1)
                '-------------------------------------------------

                tsbActivar.Enabled = False
                txtCodigoActivacion.Select()
                Exit Sub
            End If

            Call SubMenOK(" Información Validada, Oprima Boton [Activar] para Activar la Aplicación", 1)
            '-------------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '025 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '026 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '024 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
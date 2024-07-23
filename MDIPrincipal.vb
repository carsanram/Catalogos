'Bibliotecas
Imports System.IO
Imports Catalogos.dsCatalogosTableAdapters

Public Class mdiprincipal

    Private m_childformnumber As Integer
    'variables de la forma
    Dim vnameapp As String = "Catálogos"
    Dim gnomformulario As String = "mdiprincipal"
    Dim gcreabitacora As Boolean = True
    Dim gbasedatos = "catalogos.accdb"
    Dim grutafondo As String = Application.StartupPath & "\catalogos.png"

    Dim gforzacerrarformulario As Boolean = False


    '----------------------------------------------------------------------------------------------------------------------------
    '----- Eventos 061 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 evento ejecuta [subcargaformulario] para carga de formulario
    Private Sub mdiprincipal_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "mdiprincipal_load"

        Call subcargaformulario()
        '------------------------

    End Sub

    '002 evento ejecuta [subeliminabitacora] para eliminar log de actividades
    Private Sub mdiprincipal_formclosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        vg.gEvento = "mdiprincipal_formclosed"

        If gforzacerrarformulario Then

        Else
            Call subeliminabitacora()
            '------------------------

        End If

    End Sub

    '003 excepcion notimplementedexception toolbartoolstripmenuitem
    Private Function toolbartoolstripmenuitem() As Object

        vg.gEvento = "toolbartoolstripmenuitem"

        Throw New NotImplementedException

    End Function

    '004 notimplementedexception statusbartoolstripmenuitem
    Private Function statusbartoolstripmenuitem() As Object

        vg.gEvento = "statusbartoolstripmenuitem"

        Throw New NotImplementedException

    End Function

    '005 evento ejecuta [submuestraafores] catalogo de afores
    Private Sub mnafores_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAfores.Click

        vg.gEvento = "mnafores_click"

        Call submuestraafores()
        '----------------------

    End Sub

    '006 evento ejecuta [submuestraafores] catalogo de afores
    Private Sub tsbafores_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAfores.Click

        vg.gEvento = "tsbafores_click"

        Call submuestraafores()
        '----------------------

    End Sub

    '007 evento ejecuta [submuestraimss73ar] catalogo de cuantias imss 1973 antes de la reforma 1990
    Private Sub mnimss73ar_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIMSS73ar.Click

        vg.gEvento = "mnimss73ar_click"

        Call submuestraimss73ar()
        '------------------------

    End Sub

    '008 evento ejecuta [submuestraimss73ar] catalogo de cuantias imss 1973 antes de la reforma 1990
    Private Sub tsmicuantias73ar_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCuantias73AR.Click

        vg.gEvento = "tsmicuantias73ar_click"

        Call submuestraimss73ar()
        '------------------------

    End Sub

    '009 evento ejecuta [submuestraimss73] catalogo de cuantias imss 1973 
    Private Sub mnimss73_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIMSS73.Click

        vg.gEvento = "mnimss73_click"

        Call submuestraimss73()
        '----------------------

    End Sub

    '010 evento ejecuta [submuestraimss73] catalogo de cuantias imss 1973 
    Private Sub tsmicuantiasley73_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCuantiasLey73.Click


        vg.gEvento = "tsmicuantiasley73_click"

        Call submuestraimss73()
        '----------------------

    End Sub

    '011 evento ejecuta [submuestraimss97] catalogo de cuantias imss 1997
    Private Sub mnimss97_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIMSS97.Click

        vg.gEvento = "mnimss97_click"

        Call submuestraimss97()
        '----------------------

    End Sub

    '012 evento ejecuta [submuestraimss97] catalogo de cuantias imss 1997
    Private Sub tsmicuantiasley97_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCuantiasLey97.Click

        vg.gEvento = "tsmicuantiasley97_click"

        Call submuestraimss97()
        '----------------------

    End Sub

    '013 evento ejecuta [submuestradelegacion] catalogo de delegaciones del imss
    Private Sub mndelegacion_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDelegacion.Click

        vg.gEvento = "mndelegacion_click"

        Call submuestradelegacion()
        '--------------------------

    End Sub

    '014 evento ejecuta [submuestradelegacion] catalogo de delegaciones del imss
    Private Sub tsbdelegacion_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDelegacion.Click

        vg.gEvento = "tsbdelegacion_click"

        Call submuestradelegacion()
        '--------------------------

    End Sub

    '015 evento ejecuta [submuestraestados] catalogo de estados de la republica
    Private Sub mnestados_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnEstados.Click

        vg.gEvento = "mnestados_click"

        Call submuestraestados()
        '-----------------------

    End Sub

    '016 evento ejecuta [submuestraestados] catalogo de estados de la republica
    Private Sub tsbestados_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEstados.Click

        vg.gEvento = "tsbestados_click"

        Call submuestraestados()
        '-----------------------

    End Sub

    '017 evento ejecuta [submuestrainpc] catalogo de inflacion del inpc
    Private Sub mninpc_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnINPC.Click

        vg.gEvento = "mninpc_click"

        Call submuestrainpc()
        '--------------------

    End Sub

    '018 evento ejecuta [submuestrainpc] catalogo de inflacion del inpc
    Private Sub tsbinpc_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbINPC.Click

        vg.gEvento = "tsbinpc_click"

        Call submuestrainpc()
        '--------------------

    End Sub

    '019 evento ejecuta [submuestrainfanual] catalogo de inflacion anual
    Private Sub mninfanual_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnInfAnual.Click

        vg.gEvento = "mninfanual_click"

        Call submuestrainfanual()
        '------------------------

    End Sub

    '020 evento ejecuta [submuestrainfanual] catalogo de inflacion anual
    Private Sub tsbinfanual_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbInfAnual.Click

        vg.gEvento = "tsbinfanual_click"

        Call submuestrainfanual()
        '------------------------

    End Sub

    '021 evento ejecuta [submuestraisr] catalogo de isr sat
    Private Sub mnisr_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnISR.Click

        vg.gEvento = "mnisr_click"

        Call submuestraisr()
        '-------------------

    End Sub

    '022 evento ejecuta [submuestraisr] catalogo de isr sat
    Private Sub tsbisr_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbISR.Click

        vg.gEvento = "tsbisr_click"

        Call submuestraisr()
        '-------------------

    End Sub

    '023 evento ejecuta [submuestrapctm40] catalogo de cuantia modalidad 40
    Private Sub mnpctm40_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPctM40.Click

        vg.gEvento = "mnpctm40_click"

        Call submuestrapctm40()
        '----------------------

    End Sub

    '024 evento ejecuta [submuestrapctm40] catalogo de cuantia modalidad 40
    Private Sub tsbpct40_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPct40.Click

        vg.gEvento = "tsbpct40_click"

        Call submuestrapctm40()
        '----------------------

    End Sub

    '025 evento ejecuta [submuestrasyp] catalogo de seguros y pensiones
    Private Sub mnsyp_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSyP.Click

        vg.gEvento = "mnsyp_click"

        Call submuestrasyp()
        '-------------------

    End Sub

    '026 evento ejecuta [submuestrasyp] catalogo de seguros y pensiones
    Private Sub tsbsegypen_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSegyPen.Click

        vg.gEvento = "tsbsegypen_click"

        Call submuestrasyp()
        '-------------------

    End Sub

    '027 evento ejecuta [submuestrauma] catalogo de uma y smg
    Private Sub mnuma_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnUMA.Click

        vg.gEvento = "mnuma_click"

        Call submuestrauma()
        '-------------------

    End Sub

    '028 evento ejecuta [submuestrauma] catalogo de uma y smg
    Private Sub tsbuma_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUMA.Click

        vg.gEvento = "tsbuma_click"

        Call submuestrauma()
        '-------------------

    End Sub

    '029 evento ejecuta [submuestraacerca] acerca de la apllicacion
    Private Sub mnacerca_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAcerca.Click

        vg.gEvento = "mnacerca_click"

        Call submuestraacerca()
        '----------------------

    End Sub

    '030 sub [submuestramanualusuario] para mostrar el manual de usuario
    Private Sub tsmmanualdeusuario_click(sender As Object, e As EventArgs) Handles tsmManualDeUsuario.Click

        vg.gEvento = "tsmmanualdeusuario_click"

        Call submuestramanualusuario()
        '-----------------------------

    End Sub

    '031 evento organizar la ventanas en cascada
    Private Sub mncascada_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCascada.Click

        vg.gEvento = "mncascada_click"

        LayoutMdi(MdiLayout.Cascade)

    End Sub

    '032 evento organizar la ventanas verticalmente
    Private Sub mnvertical_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnVertical.Click

        vg.gEvento = "mnvertical_click"

        LayoutMdi(MdiLayout.TileVertical)

    End Sub

    '033 evento organizar la ventanas horizontalmente
    Private Sub mnhorizontal_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnHorizontal.Click

        vg.gEvento = "mnhorizontal_click"

        LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    '034 evento cerrar todas las ventanas
    Private Sub mncerrartodo_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCerrarTodo.Click

        vg.gEvento = "mncerrartodo_click"

        Try

            ' cierre todos los formularios secundarios del principal.
            For Each childform As Form In MdiChildren
                childform.Close()
            Next

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '035 evento organizar iconos de las ventanas
    Private Sub mnorgicons_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnOrgIcons.Click

        vg.gEvento = "mnorgicons_click"

        LayoutMdi(MdiLayout.ArrangeIcons)

    End Sub

    '036 evento ejecuta [subbitacora] para a bitacora
    Private Sub mnbitacora_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBitacora.Click

        vg.gEvento = "mnbitacora_click"

        Call subbitacora()
        '-----------------

    End Sub

    '037 evento ejecuta [subbarraopciones] para habilitar/deshabilitar la barra de opciones
    Private Sub mnbarraopciones_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBarraOpciones.Click

        vg.gEvento = "mnbarraopciones_click"

        Call subbarraopciones()
        '----------------------

    End Sub

    '038 evento ejecuta [subbarramensajes] para habilitar/deshabilitar la barra de mensajes
    Private Sub mnbarramensajes_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBarraMensajes.Click

        vg.gEvento = "mnbarramensajes_click"

        Call subbarramensajes()
        '----------------------

    End Sub

    '039 evento ejecuta [subcerrarformulario(me)] para cerrar al formulario principal
    Private Sub mnsalir_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalir.Click

        vg.gEvento = "mnsalir_click"

        Call subconfirmarsalir()
        '-----------------------

    End Sub

    '040 evento ejecuta [subcerrarformulario(me)] para cerrar al formulario principal
    Private Sub tsbsalir_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbsalir_click"

        Call subconfirmarsalir()
        '-----------------------

    End Sub

    '041 evento ejecuta [submuestratitulo] para mostrar o quitar titulo 
    Private Sub tsbmostrartit_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbMostrarTit.Click

        vg.gEvento = "tsbmostrartit_click"

        Call submuestratitulo()
        '----------------------

    End Sub

    '042 evento muestra fecha y hora
    Private Sub tm_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm.Tick

        vg.gEvento = "tm_tick"

        Try
            tsslHoy.Text = DateTime.Now.Date
            tsslTime.Text = DateTime.Now.ToString("hh:mm:ss")

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '043 evento redimensiona el titulo
    Private Sub mdiprincipal_resize(sender As Object, e As EventArgs) Handles Me.Resize

        vg.gEvento = "mdiprincipal_resize"

        tslTitulo.Width = Width

    End Sub

    '044 evento muestra pantalla para seleccionar base de datos de catalogos
    Private Sub tsmibasedatos_click(sender As Object, e As EventArgs) Handles tsmiBaseDatos.Click
        vg.gEvento = "tsslcatalogos_click"

        Try

            Dim frm As foObtenBDCatalogos = New foObtenBDCatalogos
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '045 evento ejecuta [subvercalendario] muestra calendario
    Private Sub tsslhoy_click(sender As Object, e As EventArgs) Handles tsslHoy.Click

        vg.gEvento = "tsslhoy_click"

        Call subvercalendario()
        '----------------------

    End Sub

    '046 evento formulario para cambiar el fondo
    Private Sub mnimagenaplicación_click(sender As Object, e As EventArgs) Handles mnImagenAplicación.Click

        vg.gEvento = "mnimagenaplicación_click"

        Call gMet.SubEscribeBitacora("imagen de la aplicación: ", vg.gEl)
        '----------------------------------------------------------------

        Call submenok(" selección de fondo de la aplicación ", 1)
        '-------------------------------------------------------

        mnImagenAplicación.Enabled = False

        Try

            Dim frm As foObtenFondo = New foObtenFondo
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '047 evento ejecuta [subdespacho] formulario para datos del despacho de asesores
    Private Sub mndatosempresa_click(sender As Object, e As EventArgs) Handles mnDatosEmpresa.Click

        vg.gEvento = "mndatosempresa_click"

        Call subdespacho()
        '-----------------

    End Sub

    '048 evento ejecuta [subdespacho] formulario para datos del despacho de asesores
    Private Sub tsbempresa_click(sender As Object, e As EventArgs) Handles tsbEmpresa.Click

        vg.gEvento = "tsbempresa_click"

        Call subdespacho()
        '-----------------

    End Sub

    '049 evento ejecuta [subtopados] formulario para topados
    Private Sub mntopadosporaño_click(sender As Object, e As EventArgs) Handles mnTopadosPorAño.Click

        vg.gEvento = "mntopadosporaño_click"

        Call subtopados()
        '----------------

    End Sub

    '050 evento ejecuta [subtopados] formulario para topados
    Private Sub tsmitopadosporaño_click(sender As Object, e As EventArgs) Handles tsmiTopadosPorAño.Click

        vg.gEvento = "tsmitopadosporaño_click"

        Call subtopados()
        '----------------

    End Sub

    '051 evento ejecuta [subvercalendario] formulario para ver calendario
    Private Sub tsmcalendario_click(sender As Object, e As EventArgs) Handles tsmCalendario.Click

        vg.gEvento = "tsmcalendario_click"

        Call submenok(" calendario ", 1)
        '--------------------------------

        Call subvercalendario()
        '----------------------

    End Sub

    '052 evento ejecuta [submodalidades] formulario modalidades
    Private Sub tsbmodalidades_click(sender As Object, e As EventArgs) Handles tsbModalidades.Click

        vg.gEvento = "tsbmodalidades_click"

        Call submodalidades()
        '--------------------

    End Sub

    '053 evento ejecuta [subrespaldobd] respaldo base de datos
    Private Sub tsmirespaldo_click(sender As Object, e As EventArgs) Handles tsmiRespaldo.Click

        Call subrespaldobd()
        '-------------------

    End Sub

    '054 evento ejecuta [subrecuperacionbd] recupera base de datos
    Private Sub tsmrecuperacion_click(sender As Object, e As EventArgs) Handles tsmRecuperacion.Click

        gforzacerrarformulario = True

        Call subrecuperacionbd()
        '-----------------------

    End Sub

    '055 evento que muestra pantalla de exportar catalogos
    Private Sub tsmexportarcatalogosaexcel_click(sender As Object, e As EventArgs) Handles tsmExportarCatalogosAExcel.Click
        vg.gEvento = "tsmexportarcatalogosaexcel_click("

        tsmExportarCatalogosAExcel.Enabled = False

        Try

            Dim frm As foExportaCatalogos = New foExportaCatalogos
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '056 evento que muestra formulario para primas de trabajadoress independientes
    Private Sub tsmiprimariesgotrabajoti_click(sender As Object, e As EventArgs) Handles tsmiPrimaRiesgoTrabajoTI.Click

        vg.gEvento = "tsmiprimariesgotrabajoti_click"

        Call subPrimaTI()
        '----------------

    End Sub

    '057 evento que muestra formulario para primas de trabajadoress independientes
    Private Sub mnprimariesgotrabajoti_click(sender As Object, e As EventArgs) Handles mnPrimaRiesgoTrabajoTI.Click

        vg.gEvento = "tsmiprimariesgotrabajoti_click"

        Call subPrimaTI()
        '----------------

    End Sub

    '058 evento que muestra formulario para las actividades de trabajadores independientes
    Private Sub tsmiTrabajadorIndependiente_Click(sender As Object, e As EventArgs) Handles tsmiTrabajadorIndependiente.Click

        vg.gEvento = "tsmiTrabajadorIndependiente_Click"

        Call subActividadesTI()
        '----------------------

    End Sub

    '059 evento que muestra formulario para las actividades de trabajadores independientes
    Private Sub mnTrabajadorIndependienteTI_Click(sender As Object, e As EventArgs) Handles mnTrabajadorIndependienteTI.Click

        vg.gEvento = "mnTrabajadorIndependienteTI_Click"

        Call subActividadesTI()
        '----------------------

    End Sub

    '060 evento que muestra formulario de las cuotas de Modalidad 33
    Private Sub tsmiMod33_Click(sender As Object, e As EventArgs) Handles tsmiMod33.Click

        vg.gEvento = "tsmiMod33_Click"

        Call subCuotasM33()
        '------------------

    End Sub

    '061 evento que muestra formulario de las cuotas de Modalidad 33
    Private Sub mnMod33_Click(sender As Object, e As EventArgs) Handles mnMod33.Click

        vg.gEvento = "mnMod33_Click"

        Call subCuotasM33()
        '------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- Metodos 032 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 sub [submuestraafores] carga el formulario del catalogo afores
    Sub submuestraafores()

        vg.gEvento = "submuestraafores"

        'escribe bitacora
        Call gMet.SubEscribeBitacora("catalogo afores: ", vg.gEl)
        '--------------------------------------------------------

        Call submenok(" catálogo de afores ", 1)
        '---------------------------------------

        Try

            Dim frm As foAfores = New foAfores
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnAfores.Enabled = False
            tsbAfores.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 sub [submuestraimss73ar] carga el formulario del catalogo cuantias 1973 antes reforma 1990
    Sub submuestraimss73ar()

        vg.gEvento = "submuestraimss73ar"

        Call gMet.SubEscribeBitacora("catalogo cuantias 1973 antes reforma 1990: ", vg.gEl)
        '----------------------------------------------------------------------------------

        Call submenok(" catálogo de cuantías imss 1973 - antes reforma 1990 ", 1)
        '------------------------------------------------------------------------

        Try

            Dim frm As foCuantias73ar = New foCuantias73ar
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnIMSS73ar.Enabled = False
            tsmiCuantias73AR.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 sub [submuestraimss73] carga el formulario del catalogo cuantias 1973 despues reforma 1990
    Sub submuestraimss73()

        vg.gEvento = "submuestraimss73"

        Call gMet.SubEscribeBitacora("catalogo cuantias 1973: ", vg.gEl)
        '---------------------------------------------------------------

        Call submenok(" catálogo de cuantías imss 1973 ", 1)
        '---------------------------------------------------

        Try

            Dim frm As foCuantias73 = New foCuantias73
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnIMSS73.Enabled = False
            tsmiCuantiasLey73.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 sub [submuestraimss97] carga el formulario del catalogo cuantias 1997
    Sub submuestraimss97()

        vg.gEvento = "submuestraimss97"

        Call gMet.SubEscribeBitacora("catalogo cuantias 1997: ", vg.gEl)
        '---------------------------------------------------------------

        Call submenok(" catálogo de cuantías imss 1997 ", 1)
        '---------------------------------------------------

        Try

            Dim frm As foCuantias97 = New foCuantias97
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnIMSS97.Enabled = False
            tsmiCuantiasLey97.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 sub [submuestradelegacion] catalogo de delegaciones del imss
    Sub submuestradelegacion()

        vg.gEvento = "submuestradelegacion"

        Call gMet.SubEscribeBitacora("catalogo delegaciones, subdelegaciones y umf: ", vg.gEl)
        '-------------------------------------------------------------------------------------

        Call submenok(" catálogo de delegaciones, subdelegaciones y unidad dee medicina familiar imss ", 1)
        '--------------------------------------------------------------------------------------------------

        Try

            Dim frm As foDelegaciones = New foDelegaciones
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnDelegacion.Enabled = False
            tsbDelegacion.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 sub [submuestraestados] catalogo de estados de la republica
    Sub submuestraestados()

        vg.gEvento = "submuestraestados"

        Call gMet.SubEscribeBitacora("catalogo estados méxico: ", vg.gEl)
        '--------------------------------------------------------

        Call submenok(" catálogo de estados de la republica mexicana", 1)
        '----------------------------------------------------------------


        Try

            Dim frm As FoEdos = New FoEdos
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnEstados.Enabled = False
            tsbEstados.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 sub [submuestrainpc] catalogo de inflacion del inpc
    Sub submuestrainpc()

        vg.gEvento = "submuestrainpc"

        Call gMet.SubEscribeBitacora("catalogo indices inpc: ", vg.gEl)
        '--------------------------------------------------------

        Call submenok(" catálogo indices de inflación inpc ", 1)
        '-------------------------------------------------------

        Try

            Dim frm As foINPC = New foINPC
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnINPC.Enabled = False
            tsbINPC.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 sub [submuestrainfanual] catalogo de inflacion anual
    Sub submuestrainfanual()

        vg.gEvento = "submuestrainfanual"

        Call gMet.SubEscribeBitacora("catalogo inflación anual: ", vg.gEl)
        '-----------------------------------------------------------------

        Call submenok(" catálogo inflación anual ", 1)
        '---------------------------------------------

        Try

            Dim frm As foInflacionAnual = New foInflacionAnual
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnInfAnual.Enabled = False
            tsbInfAnual.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 sub [submuestraisr] catalogo de isr sat
    Sub submuestraisr()

        vg.gEvento = "submuestraisr"

        Call gMet.SubEscribeBitacora("catalogo isr: ", vg.gEl)
        '-----------------------------------------------------

        Call submenok(" catálogo impuesto sobre la renta sat ", 1)
        '---------------------------------------------------------

        Try

            Dim frm As foISR = New foISR
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnISR.Enabled = False
            tsbISR.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 sub [submuestrapctm40] catalogo de cuantia modalidad 40
    Sub submuestrapctm40()

        vg.gEvento = "submuestrapctm40"

        Call gMet.SubEscribeBitacora("catalogo % seguros modalidad 40: ", vg.gEl)
        '------------------------------------------------------------------------

        Call submenok(" catálogo % de seguros imss ley 1973 ", 1)
        '-------------------------------------------------------

        Try

            Dim frm As foPctM40 = New foPctM40
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnPctM40.Enabled = False
            tsbPct40.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '011 sub [submuestrasyp] catalogo de seguros y pensiones
    Sub submuestrasyp()

        vg.gEvento = "submuestrasyp"

        Call gMet.SubEscribeBitacora("catalogo seguros y pensiones: ", vg.gEl)
        '---------------------------------------------------------------------

        Call submenok(" catálogo ley-seguros-pensiones ", 1)
        '---------------------------------------------------

        Try

            Dim frm As foSegyPen = New foSegyPen
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnSyP.Enabled = False
            tsbSegyPen.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '012 sub [submuestrauma] catalogo de uma y smg
    Sub submuestrauma()

        vg.gEvento = "submuestrauma"

        Call gMet.SubEscribeBitacora("catalogo uma-smg: ", vg.gEl)
        '--------------------------------------------------------

        Call submenok(" catálogo valores smg - uma x año ", 1)
        '-------------------------------------------------------

        Try

            Dim frm As foUMA = New foUMA
            frm.MdiParent = Me
            frm.Show()

            'inhabilita la opcion de menu del formualario
            mnUMA.Enabled = False
            tsbUMA.Enabled = False

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '013 sub [submuestraacerca] acerca de la apllicacion
    Sub submuestraacerca()

        vg.gEvento = "submuestraacerca"

        Call submenok(" acerca de la aplicacion " & gNomApp, 1)
        '------------------------------------------------------


        foAcercaDe.Show()

    End Sub

    '014 sub [submuestramanualusuario] para mostrar el manual de usuario
    Sub submuestramanualusuario()

        vg.gEvento = "submuestramanualusuario"

        MsgBox("trabajando el manual de usuario.....")

    End Sub

    '015 sub [subcerrarformulario] cierra formulario
    Sub subcerrarformulario(ByVal pform As Form)

        vg.gEvento = "subcerrarformulario"


        'cierra conexion a base de datos

        Try
            conCa.Close()

            Call gMet.SubEscribeBitacora("cierre de base de datos catalogos ok", vg.gEl)
            '----------------------------------------------------------------------------

            pform.Close()
            Call gMet.SubEscribeBitacora("cierre de formulario principal de catalogos ok", vg.gEl)
            '--------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '016 sub [subbitacora] para habillitar la bitacora
    Sub subbitacora()

        vg.gEvento = "subbitacora"

        'codigo para la generacion de la bitacora
        vg.gCreaBitacora = mnBitacora.Checked

        Call subcreabitacorasino()
        '-------------------------

    End Sub

    '017 sub [subbarraopciones] para habilitar/deshabilitar la barra de opciones
    Sub subbarraopciones()

        vg.gEvento = "subbarraopciones"

        tsCatalogos.Visible = mnBarraOpciones.Checked

    End Sub

    '018 sub [subbarramensajes] para habilitar/deshabilitar la barra de mensajes
    Sub subbarramensajes()

        vg.gEvento = "subbarramensajes"

        stMensaje.Visible = mnBarraMensajes.Checked

    End Sub

    '019 sub [subcreabitacorasino] crea o borra la bitacora
    Sub subcreabitacorasino()

        vg.gEvento = "subcreabitacorasino"

        Try

            If mnBitacora.CheckState Then
                gcreabitacora = True
                vg.gEl = True

                Call gMet.SubCreaBitacora("administración")
                '------------------------------------------
            Else
                gcreabitacora = False
                vg.gEl = True
                Call gMet.SubBorraBitacora()
                '---------------------------

            End If

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '020 sub [subcargaformulario] carga formularion principal de la aplicacion catalogos
    Sub subcargaformulario()

        vg.gEvento = "subcargaformulario"

        Try

            'asigna la vesion
            tstxtVersion.Text = "ver: " & Application.ProductVersion

            vg.gRutaBaseDatosCatalogos = "c:\simulador imss 73-97\basedatos\catalogos.accdb"
            vg.gRutaBaseDatosAsegurados = "c:\simulador imss 73-97\basedatos\asegurados.accdb"
            vg.gRutaBaseDatosPensiones = "c:\simulador imss 73-97\basedatos\pensiones.accdb"

            'selecciona el fondo de la aplicacion
            Me.BackgroundImage = System.Drawing.Image.FromFile(grutafondo)

            Call gMet.SubCreaBitacora("administración")
            '------------------------------------------

            'asigna el nombre de la aplicaicion para la bitacora
            vg.gNomApp = "catalogos"

            'activa la creacion de bitacora
            If mnBitacora.CheckState Then
                gcreabitacora = True
                vg.gEl = True

                Call gMet.SubCreaBitacora("administración")
                '------------------------------------------
            Else
                gcreabitacora = False
                vg.gEl = False
            End If

            'verifica la conexion a base de datos
            If ConsultasBD.FunConexionBDcatalogos() Then
                '-----------------------------------
                tsslCatalogos.BackColor = Color.FromArgb(128, 255, 128) 'verde claro
                Call submenok(" Conexion a Base de Datos - Catalogos OK ", 2)
                '----------------------------------------------------------
            Else

                tsslCatalogos.BackColor = Color.FromArgb(255, 128, 128) 'rojo claro
                Call submenerror(" Error de Conexión en Base de Datos - Catalogos", 1)
                '---------------------------------------------------------------------


            End If

            'verifica la conexion a base de datos
            If ConsultasBD.FunConexionBDpensiones() Then
                '-----------------------------------
                tsslCatalogos.BackColor = Color.FromArgb(128, 255, 128) 'verde claro
                Call submenok(" Conexion a Base de Datos - Catalogos OK ", 2)
                '----------------------------------------------------------
            Else

                tsslCatalogos.BackColor = Color.FromArgb(255, 128, 128) 'rojo claro
                Call submenerror(" Error de Conexión en Base de Datos - Pensiones", 1)
                '---------------------------------------------------------------------


            End If

            tslTitulo.Text = "Simulador IMSS 73-97     Modulo: Administración de Catálogos "

            tslTitulo.BackColor = Color.FromArgb(45, 66, 91)
            tslTitulo.ForeColor = Color.Yellow
            tsMenu.BackColor = Color.FromArgb(206, 224, 255)


            Call submenok(" Seleccione el Catálogo que Desee Revisar ", 1)
            '-------------------------------------------------------------

            'ajusta la barra del titulo
            tslTitulo.Width = Width

            'ajusta la barra de mensajes
            tsslMensaje.Width = Width - tsslCatalogos.Width - tssLblSep01.Width - tsslHoy.Width - tssLblSep02.Width - tsslTime.Width - 70

            If vg.gPropietarioSoft = "" Then
                TStxtUsuario.Text = "Sin Registro"
            Else
                TStxtUsuario.Text = vg.gPropietarioSoft
            End If

            'configura barra de mensajes

            Refresh()
            spSplash.Close()


            'ajusta la barra de mensajes
            tsslMensaje.Width = Width - tsslCatalogos.Width - tssLblSep01.Width - tsslHoy.Width - tssLblSep02.Width - tsslTime.Width - 70

            vg.gBaseDatos = "catalogos.accdb"


        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '021 sub [submuestratitulo] para mostrar o quitar titulo
    Sub submuestratitulo()

        vg.gEvento = "submuestratitulo"

        Try

            If tslTitulo.Visible = True Then
                tslTitulo.Visible = False
                tsTitulo.Visible = False
            Else
                tslTitulo.Visible = True
                tsTitulo.Visible = True
            End If

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '022 sub [subdespacho] formulario despacho
    Sub subdespacho()

        vg.gEvento = "subdespacho"
        Call gMet.SubEscribeBitacora("información del despacho de asesores: ", vg.gEl)
        '-----------------------------------------------------------------------------

        Call submenok(" catálogo información del despacho de asesores en pensiones ", 1)
        '-------------------------------------------------------------------------------

        Try

            'habilita la opcion de menu del formualario
            mnDatosEmpresa.Enabled = False
            tsbEmpresa.Enabled = False

            Dim frm As foEmpresa = New foEmpresa
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '023 sub [submodalidades] formulario modalidades
    Sub submodalidades()

        vg.gEvento = "submodalidades"

        Call gMet.SubEscribeBitacora("catalogo modalidades: ", vg.gEl)
        '-------------------------------------------------------------

        Call submenok(" catálogo modalidades imss", 1)
        '---------------------------------------------

        Try

            'habilita la opcion de menu del formualario
            tsbModalidades.Enabled = False

            Dim frm As foModalidades = New foModalidades
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '024 sub [subvercalendario] muestra calendario
    Sub subvercalendario()

        vg.gEvento = "subvercalendario"

        Try

            Dim frm As foCalendario = New foCalendario
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '025 sub [subtopados] muestra formullario de topados
    Sub subtopados()

        vg.gEvento = "subtopados"

        Call gMet.SubEscribeBitacora("catalogo topados: ", vg.gEl)
        '--------------------------------------------------------

        Call submenok(" catálogo de sbc topados x año ", 1)
        '---------------------------------------------------

        Try

            'habilita la opcion de menu del formulario
            tsmiTopadosPorAño.Enabled = False

            Dim frm As foTopados = New foTopados
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '026 sub [subPrimaTI] muestra formullario de topados
    Sub subPrimaTI()

        vg.gEvento = "subPrimaTI"

        Call gMet.SubEscribeBitacora("Catalogo Prima Riesgo de Trabajo TI: ", vg.gEl)
        '--------------------------------------------------------

        Call submenok(" Catálogo de Primas de Riesgo de Trabajo TI ", 1)
        '---------------------------------------------------

        Try

            'habilita la opcion de menu del formulario
            tsmiPrimaRiesgoTrabajoTI.Enabled = False
            mnPrimaRiesgoTrabajoTI.Enabled = False

            Dim frm As foPrimaRT = New foPrimaRT
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '000 SUB [subPrimaTI] muestra formullario de actividades TI
    Sub subActividadesTI()

        vg.gEvento = "subActividadesTI"

        Try

            'habilita la opcion de menu del formulario
            tsmiTrabajadorIndependiente.Enabled = False
            mnTrabajadorIndependienteTI.Enabled = False

            Dim frm As foActividadesTI = New foActividadesTI
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '026 sub [subeliminabitacora] elimina la bitacora generada
    Sub subeliminabitacora()

        vg.gEvento = "subeliminabitacora"

        Try

            vg.gMensaje = "Desea Eliminar el LOG Generado: ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, False)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                Call gMet.SubBorraBitacora()

                vg.gMensaje = "Se Elimino el LOG de Actividades"
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

            If vg.gNo Then

                vg.gMensaje = "NO Se Elimino el LOG de Actividades"
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------


            End If

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '027 sub [submsgerror] muestra un mensaje de error en la barra de mensajes
    Sub submenerror(pmensaje As String, ppausa As Integer)

        vg.gEvento = "submenerror"

        tsslMensaje.Text = pmensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, ppausa)
        '-----------------------------------
        Refresh()

    End Sub

    '028 sub [submsgok]  muestra un mensaje ok en la barra de mensajes
    Sub submenok(pmensaje As String, ppausa As Integer)

        vg.gEvento = "submenok"

        tsslMensaje.Text = pmensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, ppausa)
        '-----------------------------------
        Refresh()

    End Sub

    '029 SUB [SubMenWarning]  muestra un mensaje ok en la barra de mensajes
    Sub subMenWarning(pmensaje As String, ppausa As Integer)

        vg.gEvento = "submenwarning"

        tsslMensaje.Text = pmensaje
        tsslMensaje.BackColor = Color.FromArgb(247, 172, 8)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, ppausa)
        '-----------------------------------
        Refresh()

    End Sub

    '030 SUB [ SubConfimaSalir ] confima si deseea salir de la aplicacion
    Sub SubConfirmarSalir()

        vg.gEvento = "subeliminabitacora"

        Try

            vg.gMensaje = "Desea Salir de la Aplicación " & vnameapp & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, False)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then

                Call subcerrarformulario(Me)
                '---------------------------

                Close()

            End If

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    '031 SUB [ SubRespaldoBD ] respalda base de datos
    Sub SubRespaldoBD()

        tsmiRespaldo.Enabled = False

        Call gMet.SubEscribeBitacora("respaldo de base de datos: ", vg.gEl)
        '------------------------------------------------------------------

        vg.gEvento = "subrespaldobd"

        Dim frm As foRespaldoBD = New foRespaldoBD
        frm.MdiParent = Me
        frm.Show()

    End Sub

    '032 SUB [ SubRecuperacionBD ] respalda base de datos
    Sub SubRecuperacionBD()

        vg.gEvento = "subrecuperacionbd"

        Call gMet.SubEscribeBitacora("restaurar base de datos: ", vg.gEl)
        '----------------------------------------------------------------

        Try
            vg.gMensaje = "¿Desea Salir de la Aplicación [ " & vnameapp & " ] para Realizar la Recuperación de las Base de Datos del Simulador Desde un Respaldo Guardado ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, False)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then

                Dim miproceso As New Process
                'miproceso = miproceso.start("c:\windows\system32\calc.exe")
                miproceso = miproceso.Start("C:\Simulador IMSS 73-97\App\Restablece BD Simulador IMSS\RecBDSimulador.exe")
                Shell("c:\simulador imss 73-97\app\Restablece BD Simulador IMSS\RecBDSimulador.exe")

                Call subcerrarformulario(Me)
                '---------------------------

                Close()

            End If

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    '033 SUB [ subCuotasM33 ] Catalogo de Modalidad 33
    Sub subCuotasM33()

        vg.gEvento = "subCuotasM33"

        Try

            'habilita la opcion de menu del formulario
            tsmiMod33.Enabled = False
            mnMod33.Enabled = False

            Dim frm As foMod33 = New foMod33
            frm.MdiParent = Me
            frm.Show()

        Catch ex As Exception

            MsgBox("error en " & gnomformulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

End Class

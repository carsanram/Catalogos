Imports System.Data.SqlClient

Public Class foDelegaciones

    'Variables Globales del Formulario
    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foDelegaciones"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS -----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foDelegaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foDelegaciones_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foDelegaciones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foDelegaciones_FormClosed"

        Try

            'Habilita la opcion de menu del formualario
            MDIPrincipal.mnDelegacion.Enabled = True
            MDIPrincipal.tsbDelegacion.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsUMF.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsUMF.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsUMF.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsUMF.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = " tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgUMF_Click(sender As Object, e As EventArgs) Handles dgUMF.Click

        vg.gEvento = "dgUMF_Click"

        Call SubHabiltaBotones()
        '-----------------------

        Try

            Call SubMenOK(" Delegación: " & txtDelegacion.Text & " Subdelegación : " & txtSubdelegacion.Text & " Seleccionado ", 1)
            '----------------------------------------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 Evento ejecuta [SubInserta] para insertar un nuevo registro
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "tsbAgregar_Click"

        Call SubInserta()
        '----------------

    End Sub

    '010 Evento que Cancela la edicion del registro
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click

        vg.gEvento = "tsbCancelar_Click"

        bsUMF.CancelEdit()
        Close()

    End Sub

    '011 Evento ejecuta [SubGuardar] para guardar un nuevo registro
    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "tsbGuardar_Click"

        Call SubGuardar()
        '----------------

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '012 Evento ejecuta [SubBorrar] para borrar un nuevo registro
    Private Sub tsbBorrar_Click(sender As Object, e As EventArgs) Handles tsbBorrar.Click

        vg.gEvento = "tsbBorrar_Click"

        Call SubBorra()
        '--------------

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '013 Evento ejecuta [SubValidaDatos] para validar los datos
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        vg.gEvento = "tsbValidar_Click"

        Call SubMenOK(" Validando .... Espere", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '014 Evento ejecuta [SubFiltroDelegacion] Filtra por Delegacion
    Private Sub btnFiltroDelegacion_Click(sender As Object, e As EventArgs) Handles btnFiltroDelegacion.Click

        vg.gEvento = "btnFiltroDelegacion_Click"

        Call SubFiltroDelegacion()
        '-------------------------

    End Sub

    '015 Evento ejecuta [SubFiltroSubdelegacion] Filtra por Subdelegacion
    Private Sub btnFiltroSubDelegacion_Click(sender As Object, e As EventArgs) Handles btnFiltroSubDelegacion.Click

        vg.gEvento = "btnFiltroSubDelegacion_Click("

        Call SubFiltroSubdelegacion()
        '----------------------------

    End Sub

    '016 Evento ejecuta [SubFiltroUMF] Filtra por UMF
    Private Sub btnFiltroUMF_Click(sender As Object, e As EventArgs) Handles btnFiltroUMF.Click

        vg.gEvento = "btnFiltroUMF_Click"

        Call SubFiltroUMF()
        '------------------

    End Sub

    '017 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = "tsbRefrescar_Click"

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '018 Evento limpia filtros Sebdelegacion-UMF
    Private Sub txtFilltroDelegacion_Click(sender As Object, e As EventArgs) Handles txtFilltroDelegacion.Click

        vg.gEvento = "txtFilltroDelegacion_Click"

        Try

            txtFilltroSubDelegacion.Clear()
            txtFilltroUMF.Clear()

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '019 Evento limpia filtros Delegacion-UMF
    Private Sub txtFilltroSubDelegacion_Click(sender As Object, e As EventArgs) Handles txtFilltroSubDelegacion.Click

        vg.gEvento = "txtFilltroSubDelegacion_Click"

        Try


            txtFilltroDelegacion.Clear()
            txtFilltroUMF.Clear()

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '020 Evento limpia filtros Delegacion-Subdelegacion
    Private Sub txtFilltroUMF_Click(sender As Object, e As EventArgs) Handles txtFilltroUMF.Click

        vg.gEvento = "txtFilltroUMF_Click"

        Try


            txtFilltroDelegacion.Clear()
            txtFilltroSubDelegacion.Clear()
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try


            'Habilita el botob de guardar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            cboEstado.Select()

            'Agrega registro
            bsUMF.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            tsbAgregar.Enabled = False

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información de la Delegación, Subdelegación y Unidad Medicina Familiar"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsUMF.EndEdit()
            UMFTableAdapter.Update(DsCatalogos.UMF)

            vg.gMensaje = " Delegación Actualizada en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = "Error en Guardar DDelegacion en la Base de Datos"
            Call mUniversal.SubMsgCritical(vg.gMensaje, Me, 5)
            '------------------------------------------------

            Call SubMenOK(" Ingrese la Información Requerida ", 1)
            '-----------------------------------------------------

            Exit Sub

        End Try

        Call SubMenOK(" Ingrese la Información Requerida ", 1)
        '-----------------------------------------------------

        tsbAgregar.Enabled = True
        tsbGuardar.Enabled = False

    End Sub

    '003 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        vg.gEvento = "SubBorra"

        Dim vEstado As String

        Try

            vEstado = txtEstado.Text


            vg.gMensaje = "Desea Eliminar la Delegación: " & vEstado & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then

                bsUMF.RemoveCurrent()
                bsUMF.EndEdit()

                UMFTableAdapter.Update(DsCatalogos.UMF)

                vg.gMensaje = "Se Elimino el Estado-Delegación-Subdelagación-UMF en la base de datos: " & vEstado
                Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
                '--------------------------------------------

                'inhabilita botones
                tsbAgregar.Enabled = True
                tsbBorrar.Enabled = False
                tsbGuardar.Enabled = False

        End If

            Call SubMenOK(" Ingrese la Información Requerida ", 1)
            '-----------------------------------------------------

            If vg.gNo Then

                vg.gMensaje = "NO Se Elimino el Estado-Delegación-Subdelagación-UMF en la base de datos:" & vEstado
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [SubCargaFormulario] para carga de formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try



            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            'Inicia el llenado del grid
            UMFTableAdapter.Fill(DsCatalogos.UMF)
            'Llena combo estados
            EstadosMxTableAdapter.Fill(DsCatalogos.EstadosMx)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Delegaciones, Subdelegaciones y Unidad de Medicina Familiar"
            lblTitulo.Select()

            'formato a la barra de estatus
            Call SubMenOK(" Ingrese la Información Requerida ", 1)
            '-----------------------------------------------------

            Call SubLimpiaDatos()
            '--------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 Sub [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            With Me

                .txtEstado.Text = ""
                .txtDelegacion.Text = ""
                .txtSubdelegacion.Text = ""
                .txtUMF.Text = ""
                .txtMunicipio.Text = ""
                .txtLocalidad.Text = ""

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Sub SubHabiltaBotones()

        vg.gEvento = "SubHabiltaBotones"

        Try

            tsbGuardar.Enabled = True
            tsbBorrar.Enabled = True
            tsbValidar.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubFiltroDelegacion] Filtra Delegacion
    Sub SubFiltroDelegacion()

        vg.gEvento = "SubFiltroDelegacion"

        Try
            UMFTableAdapter.FillByDelegacion(DsCatalogos.UMF, txtFilltroDelegacion.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubFiltroSubdelegacion] Filtra Subdelegacion
    Sub SubFiltroSubdelegacion()

        vg.gEvento = "SubFiltroSubdelegacion"

        Try
            UMFTableAdapter.FillBySubdelegacion(DsCatalogos.UMF, txtFilltroSubDelegacion.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 SUB [SubFiltroUMF] Filtra UMF
    Sub SubFiltroUMF()

        vg.gEvento = "SubFiltroUMF"

        Try
            UMFTableAdapter.FillByUMF(DsCatalogos.UMF, txtFilltroUMF.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "ubTodosLosRegistros"

        'Limpia los filtros
        txtFilltroDelegacion.Clear()
        txtFilltroSubDelegacion.Clear()
        txtFilltroUMF.Clear()

        Try

            UMFTableAdapter.Fill(DsCatalogos.UMF)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '011 FUN [FunValidaEstado] Valida el estado
    Function FunValidaEstado() As Boolean

        vg.gEvento = "FunValidaEstado"

        FunValidaEstado = True

        Try


            If cboEstado.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '012 FUN [FunValidaDelegacion(] Valida Delegacion
    Function FunValidaDelegacion() As Boolean

        vg.gEvento = "FunValidaDelegacion"

        FunValidaDelegacion = True

        Try


            If txtDelegacion.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Function

    '013 FUN [FunValidaDelegacion(] Valida Subdelegacion
    Function FunValidaSubdelegacion() As Boolean

        vg.gEvento = "FunValidaSubdelegacion"

        FunValidaSubdelegacion = True

        Try

            If txtSubdelegacion.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '014 FUN [FunValidaDelegacion(] Valida UMF
    Function FunValidaUMF() As Boolean

        vg.gEvento = "FunValidaUMF"

        FunValidaUMF = True

        Try

            If txtUMF.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '015 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = " SubValidaDatos"

        Try

            If FunValidaEstado() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Estado, Ingresar un Estado correcto ", 1)
                '-----------------------------------------------------------------------
                tsbGuardar.Enabled = True
                cboEstado.Select()
                Exit Sub
            End If

            If FunValidaDelegacion Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error Delegación, Ingrese una Delegación Valida ", 1)
                '-----------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtDelegacion.Select()
                Exit Sub
            End If

            If FunValidaSubdelegacion Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error Subdelegación, Ingrese una Subdelegación Valida ", 1)
                '-----------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSubdelegacion.Select()
                Exit Sub
            End If

            If FunValidaUMF Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error UMF, Ingrese una UMF Valida ", 1)
                '---------------------------------------------------------
                tsbGuardar.Enabled = False
                txtUMF.Select()
                Exit Sub
            End If

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '016 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '017 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '018 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
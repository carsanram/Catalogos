﻿Imports System.Runtime.CompilerServices

Public Class foCuantias73ar

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foCuantias73ar"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS -----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foCuantias73ar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foCuantias73ar_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foCuantias73ar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foCuantias73ar_FormClosed"

        Try

            'Habilita la opcion de menu del formulario
            MDIPrincipal.mnIMSS73ar.Enabled = True
            MDIPrincipal.tsmiCuantias73AR.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsCuantias73ar.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsCuantias73ar.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsCuantias73ar.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsCuantias73ar.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgCuantia73ar_Click(sender As Object, e As EventArgs) Handles dgCuantia73ar.Click

        vg.gEvento = "dgCuantia73ar_Click"

        Try

            Call SubHabiltaBotones()
            '-----------------------

            Call SubMenOK(" Salario Inicial  " & txtSalInicial.Text & " Seleccionado ", 1)
            '-----------------------------------------------------------------------------

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

        bsCuantias73ar.CancelEdit()
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

    '012 SUB [SubBorrar] para borrar un nuevo registro
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
        '-----------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '014 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita el boton Validar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            txtSalInicial.Select()

            'Agrega registro
            bsCuantias73ar.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información de la Cuantía"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '015 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsCuantias73ar.EndEdit()
            CuantiasLey1973arTableAdapter.Update(DsCatalogos.CuantiasLey1973ar)


            vg.gMensaje = " Cuantia Ley 73 Antes Reforma 1990 Actualizada en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 4)
            '--------------------------------------------


        Catch ex As Exception

            vg.gMensaje = " Error en Guardar Cuantia Ley 73 en la Base de Datos "
            Call mUniversal.SubMsgCritical(vg.gMensaje, Me, 4)
            '--------------------------------------------

            Call SubMenOK(" Ingrese la Información Requerida ", 1)
            '-----------------------------------------------------

            Exit Sub

        End Try

        Call SubMenOK(" Ingrese la Información Requerida ", 1)
        '-----------------------------------------------------

        tsbAgregar.Enabled = True
        tsbGuardar.Enabled = False

    End Sub

    '016 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        Dim vCuantiaBorrar As String

        vg.gEvento = "SubBorra"

        Try

            vCuantiaBorrar = txtSalInicial.Text

            vg.gMensaje = "Desea Eliminar la Cuantía Ley 73 AR con el Límite Salario Inicial: " & vCuantiaBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                bsCuantias73ar.RemoveCurrent()
                bsCuantias73ar.EndEdit()

                CuantiasLey1973arTableAdapter.Update(DsCatalogos.CuantiasLey1973ar)

                vg.gMensaje = "Se Elimino el Registro de Cuantias en la Base de Datos, con el Salario Inicial: " & vCuantiaBorrar
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

                vg.gMensaje = "NO se Elimino el Registro de Cuantias AR en la Base de Datos, con el Salario Inicial: " & vCuantiaBorrar
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    '017 SUB [SubCargaFormulario] para carga de formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            'Inicia el llenado del grid
            CuantiasLey1973arTableAdapter.Fill(DsCatalogos.CuantiasLey1973ar)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Cuantías Ley 1973 Antes Reforma 1990"
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

    '018 SUB [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            With Me

                .txtSalInicial.Text = ""
                .txtSalFinal.Text = ""
                .txtCuantiaBase.Text = ""
                .txtCuantiaAdicional.Text = ""

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '019 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Sub SubHabiltaBotones()

        vg.gEvento = "SubHabiltaBotones"

        Try

            tsbGuardar.Enabled = True
            tsbBorrar.Enabled = True
            tsbValidar.Enabled = True

            'Asigna valor de moneda 
            txtSalInicial.Text = FormatCurrency(txtSalInicial.Text)
            txtSalFinal.Text = FormatCurrency(txtSalFinal.Text)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '020 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try
            CuantiasLey1973arTableAdapter.Fill(DsCatalogos.CuantiasLey1973ar)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    '021 FUN [FunValidaSalInicial] Valida Salario Inicial
    Function FunValidaSalInicial() As Boolean

        vg.gEvento = "FunValidaSalInicial"

        FunValidaSalInicial = True

        Try

            If txtSalInicial.Text = "" Or Not IsNumeric(txtSalInicial.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '022 FUN [FunValidaSalFinal] Valida Salario Final
    Function FunValidaSalFinal() As Boolean

        vg.gEvento = "FunValidaSalFinal"

        FunValidaSalFinal = True

        Try

            If txtSalFinal.Text = "" Or Not IsNumeric(txtSalFinal.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '023 FUN [FunValidaCuantiaBase] Valida Cuantia Base
    Function FunValidaCuantiaBase() As Boolean

        vg.gEvento = "FunValidaCuantiaBase"

        FunValidaCuantiaBase = True

        Try

            If txtCuantiaBase.Text = "" Or Not IsNumeric(txtCuantiaBase.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '024 FUN [FunValidaCuantiaAdicional] Valida Cuantia Adicional
    Function FunValidaCuantiaAdicional() As Boolean

        vg.gEvento = "FunValidaCuantiaAdicional"

        FunValidaCuantiaAdicional = True

        Try

            If txtCuantiaAdicional.Text = "" Or Not IsNumeric(txtCuantiaAdicional.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Function

    '025 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunValidaSalInicial() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Salario Inicial, Ingresar un Salario Inicial Válido ", 1)
                '---------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSalInicial.Select()
            Exit Sub
        End If

            If FunValidaSalFinal Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Salario Inicial, Ingresar un Salario Final Válido ", 1)
                '-------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSalFinal.Select()
            Exit Sub
        End If

            If FunValidaCuantiaBase Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en la Cuantía Base, Ingresar una Cuantía Base Válida ", 1)
                '-----------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtCuantiaBase.Select()
            Exit Sub
        End If

            If FunValidaCuantiaAdicional Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en la Cuantía Base, Ingresar una Cuantía Adicional Válida ", 1)
                '---------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtCuantiaAdicional.Select()
            Exit Sub
        End If

        tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '026 SUB [SubLimpiaPantalla()] Limpia campos de Cuantia L73
    Sub SubLimpiaPantalla()

        vg.gEvento = "SubLimpiaPantalla"

        Try

            With Me

                .txtSalInicial.Text = "0"
                .txtSalFinal.Text = "0"
                .txtCuantiaBase.Text = "0"
                .txtCuantiaAdicional.Text = "0"

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '027 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '028 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '029 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
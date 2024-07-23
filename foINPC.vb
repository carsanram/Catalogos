Public Class foINPC

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foINPC"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foINPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foINPC_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foINPC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foINPC_FormClosed"

        Try

            'Habilita la opcion de menu del formualario
            MDIPrincipal.mnINPC.Enabled = True
            MDIPrincipal.tsbINPC.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento que navega en la pagina del INPC
    Private Sub tsbINPC_Click(sender As Object, e As EventArgs) Handles tsbINPC.Click

        vg.gEvento = "tsbINPC_Click"

        Try
            System.Diagnostics.Process.Start("https://www.elcontribuyente.mx/inpc/")

        Catch ex As Exception

            MsgBox("No Disponible la Pagina Web")

        End Try

    End Sub

    '004 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsINPC.MoveFirst()

    End Sub

    '005 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsINPC.MovePrevious()

    End Sub

    '006 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsINPC.MoveNext()

    End Sub

    '007 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsINPC.MoveLast()

    End Sub

    '008 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '009 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgINPC_Click(sender As Object, e As EventArgs) Handles dgINPC.Click

        vg.gEvento = "dgINPC_Click"

        Call SubHabiltaBotones()
        '-----------------------

        Try

            Call SubMenOK(" Año: " & txtAño.Text & " Mes: " & cboMes.Text & " Indice: " & txtINPC.Text & " Seleccionado ", 1)
            '----------------------------------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 Evento ejecuta [SubInserta] para insertar un nuevo registro
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "tsbAgregar_Click"

        Call SubInserta()
        '----------------

    End Sub

    '011 Evento que Cancela la edicion del registro
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click

        vg.gEvento = "tsbCancelar_Click"

        bsINPC.CancelEdit()
        Close()

    End Sub

    '012 Evento ejecuta [SubGuardar] para guardar un nuevo registro
    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "tsbGuardar_Click"

        Call SubGuardar()
        '----------------

        Call SubTodosLosRegistros()
        '-------------------------

    End Sub

    '013 Evento ejecuta [SubBorrar] para borrar un nuevo registro
    Private Sub tsbBorrar_Click(sender As Object, e As EventArgs) Handles tsbBorrar.Click

        vg.gEvento = "tsbBorrar_Click"

        Call SubBorra()
        '-----------------

        Call SubTodosLosRegistros()
        '-----------------------------

    End Sub

    '014 Evento ejecuta [SubValidaDatos] para validar los datos
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        vg.gEvento = "tsbValidar_Click"

        Call SubMenOK(" Validando .... Espere", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '015 Evento ejecuta [SubFiltraID] Filtra por Llave
    Private Sub BtnFillID_Click(sender As Object, e As EventArgs) Handles btnFillID.Click

        vg.gEvento = "BtnFillID_Click"

        Call SubFiltraID()
        '-----------------

    End Sub

    '016 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = "tsbRefrescar_Click"

        Call SubTodosLosRegistros()
        '--------------------------

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

            txtAño.Select()

            'Agrega registro
            bsINPC.AddNew()

            Call SubLimpiaDatos()
            '-----------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese Los Datos del INPC del Año, Mes Requerido y Factor de Recarga"
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

            bsINPC.EndEdit()
            INPCTableAdapter.Update(dsCatalogos.INPC)


            vg.gMensaje = " Indice INPC Actualizado en Base de Datos "
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 4)
            '--------------------------------------------

        Catch ex As Exception

            If ex.ToString.Contains("está restringida para ser única") Then
                vg.gMensaje = "Ya Existe el Año-Mes (Clave [ " & txtID.Text & " ] ) Ingrese Otro Año-Mes-Inflación"
                Call mUniversal.SubMsgWarning(vg.gMensaje, Me, 4)
                '--------------------------------------------

                Call SubMenOK(" Ingrese la Información Requerida ", 1)
                '-----------------------------------------------------

                Exit Sub
            Else
                vg.gMensaje = "Error en guardar registro en base de datos " & vbCrLf & ex.ToString
                Call mUniversal.SubMsgCritical(vg.gMensaje, Me, 4)
                '--------------------------------------------

                Exit Sub
            End If

        End Try

        Call SubMenOK(" Ingrese la Información Requerida ", 1)
        '-----------------------------------------------------

        tsbAgregar.Enabled = True
        tsbGuardar.Enabled = False

    End Sub

    '003 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        vg.gEvento = "SubBorra"


        Dim vINPCBorrar As String

        vINPCBorrar = txtINPC.Text

        Try

            vg.gMensaje = "Desea Eliminar el Valor del INPC: " & vINPCBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                bsINPC.RemoveCurrent()
                bsINPC.EndEdit()

                INPCTableAdapter.Update(dsCatalogos.INPC)

                vg.gMensaje = "Se Elimino el Valor del Indice INPC en la Base de Datos: " & vINPCBorrar
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

                vg.gMensaje = "No Se Elimino el Valor del Indice INPC en la Base de Datos: " & vINPCBorrar
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
            INPCTableAdapter.Fill(dsCatalogos.INPC)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: INPC - Indice Nacional de Precios al Consumidor y Factor de Recargo"
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

                .txtID.Text = ""
                .txtAño.Text = ""
                .cboMes.Text = ""

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

    '007 SUB [SubFiltraID] Filtra por ID
    Sub SubFiltraID()

        vg.gEvento = "SubFiltraID"


        Dim pID As String
        pID = txtIDFiltro.Text

        Try

            INPCTableAdapter.FillByID(dsCatalogos.INPC, pID)


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try

            INPCTableAdapter.Fill(dsCatalogos.INPC)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 FUN [FunValidaAño] valida el año
    Function FunValidaAño() As Boolean

        vg.gEvento = "FunValidaAño"

        FunValidaAño = False

        Try

            If Len(txtAño.Text) <> 4 Or txtAño.Text = "" Or txtAño.Text = "0" Or Not (IsNumeric(txtAño.Text)) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '010 FUN [FunValidaINPC] valida el INPC
    Function FunValidaINPC() As Boolean

        vg.gEvento = "FunValidaINPC"

        FunValidaINPC = False

        Try

            If Not (IsNumeric(txtINPC.Text)) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '010 FUN [FunValidaINPC] valida el INPC
    Function FunValidaFR() As Boolean

        vg.gEvento = "FunValidaFR"

        FunValidaFR = False

        Try

            If Not (IsNumeric(txtTasaRecargo.Text)) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '011 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        txtID.Text = txtAño.Text & cboMes.Text

        Try
            'Valida año
            If FunValidaAño() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Año, Ingresar un Año Válido ", 1)
                '---------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtAño.Select()
                Exit Sub
            End If
            'valida INPC
            If FunValidaINPC Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el INPC, Ingrese un INPC Válido ", 1)
                '----------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtINPC.Select()
                Exit Sub
            End If
            'Valida Factor de recargo
            If FunValidaFR() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Factor de Recargo, Ingrese un Factor de Recargo Válido ", 1)
                '-------------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtINPC.Select()
                Exit Sub
            End If

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '012 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '013 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '014 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
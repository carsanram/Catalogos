Imports Catalogos.dsCatalogosTableAdapters

Public Class foTopados
    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foTopados"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foTopados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vg.gEvento = "foTopados_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foTopados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        vg.gEvento = "foTopados_FormClosed"

        Try

            'Habilita la opcion de menu del formulario
            MDIPrincipal.tsbEstados.Enabled = True
            MDIPrincipal.tsmiTopadosPorAño.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsTopadoSMG_UMA.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsTopadoSMG_UMA.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsTopadoSMG_UMA.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro 
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsTopadoSMG_UMA.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgTopados_Click(sender As Object, e As EventArgs) Handles dgTopados.Click

        vg.gEvento = "dgTopados_Click"

        Try
            Call SubHabiltaBotones()
            '-----------------------

            Call SubMenOK(" Año: " & txtAño.Text & " Seguro: " & cobSeguro.Text & " Seleccionado ", 1)
            '-----------------------------------------------------------------------------------------

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

        bsTopadoSMG_UMA.CancelEdit()

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

    '014 Evento ejecuta [SubFiltraAño] Filtra por Año
    Private Sub btnFilAño_Click(sender As Object, e As EventArgs) Handles btnFilAño.Click

        vg.gEvento = "btnFilAño_Click"

        Call SubFiltraAño()
        '------------------

    End Sub

    '015 Evento ejecuta [SubFiltraSeguro] Filtra por Seguro
    Private Sub btnFilSeguro_Click(sender As Object, e As EventArgs) Handles btnFilSeguro.Click

        vg.gEvento = "btnFilSeguro_Click"

        Call SubFiltraSeguro()
        '---------------------

    End Sub

    '016 Evento ejecuta [SubFiltraTopado] Filtra por Topado
    Private Sub btnFilTopado_Click(sender As Object, e As EventArgs) Handles btnFilTopado.Click

        vg.gEvento = "btnFilTopado_Click"

        Call SubFiltraTopado()
        '---------------------

    End Sub

    '017 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = "tsbRefrescar_Click"

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] para carga de formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            'Inicia el llenado del grid
            TopadoSMG_UMATableAdapter.Fill(Me.DsCatalogos._TopadoSMG_UMA)

            'Formato al titulo
            lblTitulo.Select()

            'formato a la barra de estatus

            Call SubMenOK("Ingrese la Información Requerida", 1)
            '---------------------------------------------------

            Call SubLimpiaDatos()
            '--------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubFiltraAño] filtra por Año
    Sub SubFiltraAño()

        vg.gEvento = "SubFiltraAño"

        Try
            TopadoSMG_UMATableAdapter.FillByAño(DsCatalogos._TopadoSMG_UMA, txtFilAño.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 SUB [SubFiltraSeguro] filtra por Seguro
    Sub SubFiltraSeguro()

        vg.gEvento = "SubFiltraSeguro"

        Try
            TopadoSMG_UMATableAdapter.FillBySeguro(DsCatalogos._TopadoSMG_UMA, txtFilSeguro.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [SubFiltraTopado] filtra por Seguro
    Sub SubFiltraTopado()

        vg.gEvento = "SubFiltraTopado"

        Try
            TopadoSMG_UMATableAdapter.FillByTopado(DsCatalogos._TopadoSMG_UMA, txtFilTopado.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try

            txtFilAño.Clear()
            txtFilSeguro.Clear()
            txtFilTopado.Clear()

            TopadoSMG_UMATableAdapter.Fill(DsCatalogos._TopadoSMG_UMA)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 Sub [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            txtAño.Clear()
            cobSeguro.Text = ""
            txtTopado.Text = "0"

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunValidaAño() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Año, Ingrese un Año Valido ", 1)
                '--------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtAño.Select()
                Exit Sub
            End If

            If FunValidaSeguro() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Seguro, Ingresar un Seguro Valido ", 1)
                '------------------------------------------------------------------
                tsbGuardar.Enabled = False
                cobSeguro.Select()
                Exit Sub
            End If

            If FunValidaTopado() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Topado, Ingrese un Topado Valido ", 1)
                '--------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtTopado.Select()
                Exit Sub
            End If

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '008 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita botones
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            txtAño.Select()

            'Agrega registro
            bsTopadoSMG_UMA.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información del Topado del Seguro"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsTopadoSMG_UMA.EndEdit()
            TopadoSMG_UMATableAdapter.Update(DsCatalogos._TopadoSMG_UMA)

            vg.gMensaje = " Seguro Topado Actualizado en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------


        Catch ex As Exception

            vg.gMensaje = "Error en Guardar Seguro Topado Actualizado en Base de Datos"
            Call mUniversal.SubMsgWarning(vg.gMensaje, Me, 4)
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

    '010 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        vg.gEvento = "SubBorra"

        Dim vTopadoBorrar As String

        Try

            vTopadoBorrar = txtAño.Text & "-" & txtFilSeguro.Text

            vg.gMensaje = "Desea Eliminar el Seguro Topado: " & vTopadoBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then

                bsTopadoSMG_UMA.RemoveCurrent()
                bsTopadoSMG_UMA.EndEdit()

                TopadoSMG_UMATableAdapter.Update(DsCatalogos._TopadoSMG_UMA)

                vg.gMensaje = "Se Elimino el Seguro Topado en la Base de Datos: " & vTopadoBorrar
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

                vg.gMensaje = "NO Se Elimino el Seguro Topado en la Base de Datos:  " & vTopadoBorrar
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '011 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
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

    '012 FUN [FunValidaAño] filtra por Año
    Function FunValidaAño() As Boolean

        vg.gEvento = "FunValidaAño"

        FunValidaAño = False

        Try

            If IsNumeric(txtAño.Text) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '013 FUN [FunValidaSeguro] filtra por Seguro
    Function FunValidaSeguro() As Boolean

        vg.gEvento = "FunValidaSeguro"

        FunValidaSeguro = False

        Try

            If Len(cobSeguro.Text) = 0 Or cobSeguro.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '014 FUN [FunValidaTopado] filtra por Topado
    Function FunValidaTopado() As Boolean

        vg.gEvento = "FunValidaTopado"

        FunValidaTopado = False

        Try

            If CInt(txtTopado.Text) < 15 Or CInt(txtTopado.Text) > 25 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '015 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '016 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '017 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
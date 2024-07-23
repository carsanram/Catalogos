Imports Catalogos.dsCatalogosTableAdapters

Public Class foMod33

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foMod33"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foMod33_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vg.gEvento = "foMod33_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foMod33_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Try
            vg.gEvento = "foMod33_FormClosed"

            'Habilita la opcion de menu del formulario
            mdiprincipal.tsmiMod33.Enabled = True
            mdiprincipal.mnMod33.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsMod33.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click


        vg.gEvento = "tsbPrevio_Click"

        bsMod33.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsMod33.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsMod33.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dsMod33_Click(sender As Object, e As EventArgs) Handles dsMod33.Click


        vg.gEvento = "dsMod33_Click"

        Try

            Call SubHabiltaBotones()
            '-----------------------

            Call SubMenOK(" Año  " & txtAño.Text & " Seleccionado ", 1)
            '-----------------------------------------------------------

            txtCuota.Text = FormatCurrency(txtCuota.Text)

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

        bsMod33.CancelEdit()

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

    '013 SUB [SubValidaDatos] validar los datos requerido
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        vg.gEvento = "tsbValidar_Click"

        Call SubMenOK(" Validando .... Espere", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '014 SUB [ tsbRefrescar_Click ] Muestra todos los registros
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = " tsbRefrescar_Click"

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '015 SUB [ btnFiltro_Click ] Ejecuta los filtros de busqueda
    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click


        vg.gEvento = "btnFiltro_Click"


        Call SubFiltroAño()





    End Sub

    '016 SUB [cobEdadIni_SelectedIndexChanged] Asigna valores
    Private Sub cobEdadIni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobEdadIni.SelectedIndexChanged

        Select Case cobEdadIni.Text
            Case 0
                cobEdadFin.Text = 19
            Case 20
                cobEdadFin.Text = 29
            Case 30
                cobEdadFin.Text = 39
            Case 40
                cobEdadFin.Text = 49
            Case 50
                cobEdadFin.Text = 59
            Case 60
                cobEdadFin.Text = 69
            Case 70
                cobEdadFin.Text = 79
            Case 80
                cobEdadFin.Text = 100

        End Select
    End Sub

    '017 SUB [cobEdadIni_SelectedIndexChanged] Asigna valores
    Private Sub cobEdadFin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobEdadFin.SelectedIndexChanged

        Select Case cobEdadFin.Text
            Case 19
                cobEdadIni.Text = 0
            Case 29
                cobEdadIni.Text = 20
            Case 39
                cobEdadIni.Text = 30
            Case 49
                cobEdadIni.Text = 40
            Case 59
                cobEdadIni.Text = 50
            Case 69
                cobEdadIni.Text = 60
            Case 79
                cobEdadIni.Text = 70
            Case 100
                cobEdadIni.Text = 80

        End Select

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 sub [ SubCargaFormulario] carga formularion de seguro de salud para la familia
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            'Inicia el llenado del grid
            Me.Modalidad33TableAdapter.Fill(Me.DsCatalogos.Modalidad33)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Cuotas Seguro de la Familia (Mod 33)"
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

    '002 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunValidaAño() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Año, Ingrese un Año Válido", 1)
                '-------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtAño.Select()
                Exit Sub
            End If



            If FunValidaCuota() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Cuota del Seguro de Salud para la Familia, Ingrese una Válida ", 1)
                '------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtCuota.Select()
                Exit Sub
            End If



            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

            tsbGuardar.Enabled = True


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try


            'Habilita el boton Validar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            txtAño.Select()

            'Agrega registro
            bsMod33.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información del Seguro para la Familia"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsMod33.EndEdit()
            Modalidad33TableAdapter.Update(DsCatalogos.Modalidad33)

            vg.gMensaje = " La Cuota de Seguro de Salud para la Familia fue Actualizada en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 4)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = " Error en Cuota de Seguro de Salud para la Familia en la Base de Datos "
            Call mUniversal.SubMsgWarning(vg.gMensaje, Me, 4)
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

    '005 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        Dim vCuantiaBorrar As String

        vg.gEvento = "SubBorra"

        Try

            vCuantiaBorrar = txtCuota.Text


            vg.gMensaje = "Desea Eliminar la Cuota Seguro Salud para la Familia: " & vCuantiaBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then


                bsMod33.RemoveCurrent()
                bsMod33.EndEdit()

                Modalidad33TableAdapter.Update(DsCatalogos.Modalidad33)

                vg.gMensaje = "Se Elimino el Registro de Cuota Seguro Salud para la Familia en la Base de Datos: " & vCuantiaBorrar
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

                vg.gMensaje = "NO Se Elimino la Cuota Seguro Salud para la Familia en la Base de Datos " & vCuantiaBorrar
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

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

            'Asigna valor de moneda 
            txtCuota.Text = FormatCurrency(txtCuota.Text)


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            With Me

                .txtAño.Text = ""
                .cobEdadIni.Text = "0"
                '.cobEdadFin.Text = ""
                .txtCuota.Text = ""
                .txtAñoBus.Text = ""

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '009 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------

        Refresh()

    End Sub

    '010 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenWarning(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenWarning"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(247, 172, 8)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------

        Refresh()

    End Sub

    '011 FUN [FunValidaAño] Valida Año
    Function FunValidaAño() As Boolean

        vg.gEvento = "FunValidaLimInferior"

        FunValidaAño = True

        Try

            If txtAño.Text = "" Or Not IsNumeric(txtAño.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '012 FUN [FunValidaCuota] Valida Cuota
    Function FunValidaCuota()

        vg.gEvento = "FunValidaCuota"

        FunValidaCuota = True

        Try

            If txtCuota.Text = "" Or Not IsNumeric(txtCuota.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '013 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        txtAñoBus.Text = ""
        cobEdadIniBus.Text = ""

        Try

            Modalidad33TableAdapter.Fill(DsCatalogos.Modalidad33)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        lblTitulo.Select()

    End Sub

    '014 SUB [SubFiltroAño] Filtra informmacion por Año
    Sub SubFiltroAño()

        Dim vAño As Integer
        Dim vEdad As String

        If txtAñoBus.Text <> "" Then
            vAño = txtAñoBus.Text
        End If
        If cobEdadIniBus.Text <> "" Then
            vEdad = cobEdadIniBus.Text
        End If

        vg.gEvento = "SubFiltroPorLimSuperior"


        Try

            If txtAñoBus.Text <> "" And cobEdadIniBus.Text <> "" Then
                Modalidad33TableAdapter.FillByEdad(DsCatalogos.Modalidad33, vAño, vEdad)
            Else
                If txtAñoBus.Text <> "" And cobEdadIniBus.Text = "" Then
                    Modalidad33TableAdapter.FillByAño(DsCatalogos.Modalidad33, vAño)
                Else
                    If cobEdadIniBus.Text <> "" Then
                        Modalidad33TableAdapter.FillByRango(DsCatalogos.Modalidad33, vEdad)
                    End If
                End If
            End If
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub


End Class
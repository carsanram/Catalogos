Public Class foCuantias73

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foCuantias73"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foCuantias73_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foCuantias73_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foCuantias73_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foCuantias73_FormClosed"

        Try

            'Habilita la opcion de menu del formulario
            MDIPrincipal.mnIMSS73.Enabled = True
            MDIPrincipal.tsmiCuantiasLey73.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsCuantiasLey1973.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsCuantiasLey1973.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsCuantiasLey1973.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsCuantiasLey1973.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgCuantia73_Click(sender As Object, e As EventArgs) Handles dgCuantia73.Click

        vg.gEvento = "dgCuantia73_Click"

        Try

            Call SubHabiltaBotones()
            '-----------------------

            Call SubMenOK("Limíte Inferior  " & txtLimInferior.Text & " Seleccionado", 1)
            '----------------------------------------------------------------------------

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

        bsCuantiasLey1973.CancelEdit()
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

    '014 Evento ejecuta [SubFiltroPorLimSuperior] Filtra por Nombre de la Afore
    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click

        vg.gEvento = "btnFiltro_Click"

        Call SubFiltroPorLimSuperior()
        '-----------------------------

    End Sub

    '015 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = " tsbRefrescar_Click"

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '016 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita el boton Validar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            txtLimInferior.Select()

            'Agrega registro
            bsCuantiasLey1973.AddNew()

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

    '017 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsCuantiasLey1973.EndEdit()
            CuantiasLey1973TableAdapter.Update(DsCatalogos.CuantiasLey1973)

            vg.gMensaje = " Cuantia Ley 73 Actualizada en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 4)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = " Error en Guardar Cuantia Ley 73 en la Base de Datos "
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

    '018 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        Dim vCuantiaBorrar As String

        vg.gEvento = "SubBorra"

        Try

            vCuantiaBorrar = txtLimInferior.Text


            vg.gMensaje = "Desea Eliminar la Cuantía Ley 73 con el Límite Inferior: " & vCuantiaBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                bsCuantiasLey1973.RemoveCurrent()
                bsCuantiasLey1973.EndEdit()

                CuantiasLey1973TableAdapter.Update(DsCatalogos.CuantiasLey1973)

                vg.gMensaje = "Se Elimino el Registro de Cuantias en la Base de Datos, con el Límite Inferior: " & vCuantiaBorrar
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

                vg.gMensaje = "NO Se Elimino el Registro de Cuantias en la Base de Datos, con el Límite Inferior " & vCuantiaBorrar
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If



        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '019 SUB [SubCargaFormulario] para carga de formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            'Inicia el llenado del grid
            CuantiasLey1973TableAdapter.Fill(DsCatalogos.CuantiasLey1973)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Cuantías Ley 1973"
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

    '020 SUB [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            With Me

            .txtLimInferior.Text = ""
            .txtLimSuperior.Text = ""
            .txtCuantiaBase.Text = ""
            .txtCuantiaAdicional.Text = ""

        End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '021 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
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

    '022 SUB [SubFiltroPorLimSuperior] Filtra por Nombre de la Afore
    Sub SubFiltroPorLimSuperior()

        Dim vRangoIni As String
        Dim vRangoFin As String

        vg.gEvento = "SubFiltroPorLimSuperior"


        vRangoIni = txtRangoIni.Text
        vRangoFin = txtRangoFin.Text

        Try
            CuantiasLey1973TableAdapter.FillByLimInf(DsCatalogos.CuantiasLey1973, vRangoIni, vRangoFin)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '023 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try
            CuantiasLey1973TableAdapter.Fill(DsCatalogos.CuantiasLey1973)
            txtRangoIni.Text = ""
            txtRangoFin.Text = ""

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        lblTitulo.Select()

    End Sub

    '024 SUB [FunValidaLimInferior] Valida llimite inferior
    Function FunValidaLimInferior() As Boolean

        vg.gEvento = "FunValidaLimInferior"

        FunValidaLimInferior = True

        Try

            If txtLimInferior.Text = "" Or Not IsNumeric(txtLimInferior.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '025 FUN [FunValidaLimSuperior] Valida el limite inferior
    Function FunValidaLimSuperior() As Boolean

        vg.gEvento = "FunValidaLimSuperior"

        FunValidaLimSuperior = True

        Try


            If txtLimSuperior.Text = "" Or Not IsNumeric(txtLimSuperior.Text) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '026 FUN [FunValidaCuantiaBase] Valida la cuantia base
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

    '027 FUN [FunValidaCuantiaAdicional] Valida la cuantia adicional
    Function FunValidaCuantiaAdicional() As Boolean

        FunValidaCuantiaAdicional = True

        vg.gEvento = "FunValidaCuantiaAdicional"

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

    '028 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunValidaLimInferior() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Límite Inferior, Ingrese un Límite Inferior Válido", 1)
                '-------------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtLimInferior.Select()
                Exit Sub
            End If

            If FunValidaLimSuperior() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError("  Error en el Límite Superior, Ingrese un Límite Superior Válido ", 1)
                '---------------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtLimSuperior.Select()
                Exit Sub
            End If

            If FunValidaCuantiaBase() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Cuantía Base, Ingrese una Cuantía Base Válida ", 1)
                '------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtCuantiaBase.Select()
                Exit Sub
            End If

            If FunValidaCuantiaAdicional() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Cuantía Adicional, Ingrese una Cuantía Adicional Válida ", 1)
                '----------------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtCuantiaAdicional.Select()
                Exit Sub
            End If

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

            tsbGuardar.Enabled = True


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '029 SUB [SubLimpiaPantalla()] Limpia campos de Cuantia L73
    Sub SubLimpiaPantalla()

        vg.gEvento = "SubLimpiaPantalla"

        Try

            With Me

                .txtLimInferior.Text = "0"
                .txtLimSuperior.Text = "0"
                .txtCuantiaBase.Text = "0"
                .txtCuantiaAdicional.Text = "0"

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '030 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '031 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '032 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
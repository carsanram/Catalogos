Imports System.Runtime.CompilerServices

Public Class foCuantias97

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foCuantias97"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS -----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foCuantias97_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foCuantias97_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foCuantias97_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foCuantias97_FormClosed"

        Try

            'Habilita la opcion de menu del formualario
            MDIPrincipal.mnIMSS97.Enabled = True
            MDIPrincipal.tsmiCuantiasLey97.Enabled = True


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsCuantia97.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsCuantia97.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click("

        bsCuantia97.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsCuantia97.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgCuantia1997_Click(sender As Object, e As EventArgs) Handles dgCuantia1997.Click

        vg.gEvento = "dgCuantia1997_Click"

        Call SubHabiltaBotones()
        '-----------------------
        Try

            Call SubMenOK(" Año " & txtAño.Text & " Pensión a los : " & txtEdadPension.Text & " Años  Seleccionado ", 1)
            '-----------------------------------------------------------------------------------------------------------

            txtPensionGarantizada.Text = FormatCurrency(txtPensionGarantizada.Text)

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

        bsCuantia97.CancelEdit()
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

    '014 Evento ejecuta [SubFiltroAñoPen] Filtra por Año y pension
    Private Sub FillByAñoPenToolStripButton_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click

        vg.gEvento = "FillByAñoPenToolStripButton_Click"

        Call SubFiltroAñoPen()
        '---------------------

    End Sub

    '015 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
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
        bsCuantia97.AddNew()

        Call SubLimpiaDatos()
            '----------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información de la Cuantía"
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

            bsCuantia97.EndEdit()
            CuantiasLey1997TableAdapter.Update(DsCatalogos.CuantiasLey1997)


            vg.gMensaje = " Cuantía Ley 97 Actualizada en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = "Error en Guardar Cuantía Ley 97 en la Base de Datos"
            gMet.FunMensajeBox(foAvisoCorto, vg.gMensaje, psTypeOfMsg.psCritical, 10, 10)

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

    '003 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        vg.gEvento = "SubBorra"

        Dim vCuantiaBorrar As String

        Try


            vCuantiaBorrar = txtAño.Text & "-" & txtEdadPension.Text & "-" & txtSemCotInf.Text

            vg.gMensaje = "Desea Eliminar la Cuantía Ley 97: " & vCuantiaBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then

                bsCuantia97.RemoveCurrent()
                bsCuantia97.EndEdit()

                CuantiasLey1997TableAdapter.Update(DsCatalogos.CuantiasLey1997)

                vg.gMensaje = "Se Elimino la Cuantía Ley 1997 en la Base de Datos: " & vCuantiaBorrar
                Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
                '--------------------------------------------

                'inhabilita botones
                tsbAgregar.Enabled = True
                tsbBorrar.Enabled = False
                tsbGuardar.Enabled = False

            End If

            If vg.gNo Then

                vg.gMensaje = "NO Se Elimino la Cuantía Ley 1997 en la Base de Datos: " & vCuantiaBorrar
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)

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
            CuantiasLey1997TableAdapter.Fill(DsCatalogos.CuantiasLey1997)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Cuantías Pensión Garantizada Ley 1997"
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

    '005 SUB [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try


            With Me

            .txtAño.Clear()
            .txtEdadPension.Clear()
            .txtLimInferior.Clear()
            .txtLimSuperior.Clear()
            .txtSemCotInf.Clear()
            .txtSemCotSup.Clear()
            .txtPensionGarantizada.Clear()

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

    '007 SUB [SubFiltroPorLimSuperior] Filtra Año Pension
    Sub SubFiltroAñoPen()

        vg.gEvento = "SubFiltroAñoPen"

        Dim pAño As String
        Dim pAñoPen As String
        Dim pLimite As String

        pAño = txtFiltroAño.Text
        pAñoPen = txtFiltroAñoPension.Text
        pLimite = txtFiltroLimite.Text

        Try
            CuantiasLey1997TableAdapter.FillByAño(DsCatalogos.CuantiasLey1997, pAño, pAñoPen, pLimite)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try

            CuantiasLey1997TableAdapter.Fill(DsCatalogos.CuantiasLey1997)

            txtFiltroAño.Text = ""
            txtFiltroAñoPension.Text = ""
            txtFiltroAñoPension.Text = ""

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 FUN [FunValidaAño] Valida el año
    Function FunValidaAño() As Boolean

        vg.gEvento = "FunValidaAño"

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

    '010 FUN [FunValidaAñoPension] Valida el año a pensionarse
    Function FunValidaAñoPension() As Boolean

        vg.gEvento = "FunValidaAñoPension"

        FunValidaAñoPension = True

        Try

            If txtEdadPension.Text = "" Then
                txtEdadPension.Text = "0"
            End If

            If txtEdadPension.Text = "" Or Not IsNumeric(txtEdadPension.Text) Or txtEdadPension.Text < 60 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '011 FUN [FunValidaLimSBCInf] Valida Limite SBC Inferior
    Function FunValidaLimSBCInf() As Boolean

        vg.gEvento = "FunValidaLimSBCInf"

        FunValidaLimSBCInf = True

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

    '012 FUN [FunValidaLimSBCSup] Valida Limite SBC superior
    Function FunValidaLimSBCSup() As Boolean

        vg.gEvento = "FunValidaLimSBCSup"

        FunValidaLimSBCSup = True

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

    '013 FUN [FunValidaSemCotInf] Valida Semanas cotizadas inferior
    Function FunValidaSemCotInf() As Boolean

        vg.gEvento = "FunValidaSemCotInf"

        FunValidaSemCotInf = True

        Try

            If txtSemCotInf.Text = "" Or Not IsNumeric(txtSemCotInf.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '014 FUN [FunValidaSemCotSup] Valida Semanas cotizadas superior
    Function FunValidaSemCotSup() As Boolean

        vg.gEvento = "FunValidaSemCotSup"

        FunValidaSemCotSup = True

        Try


            If txtSemCotSup.Text = "" Or Not IsNumeric(txtSemCotSup.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '015 FUN [FunValidaPensionGarantizada] Valida pension garentizada
    Function FunValidaPensionGarantizada() As Boolean

        vg.gEvento = "FunValidaPensionGarantizada"

        FunValidaPensionGarantizada = True

        Try


            If txtPensionGarantizada.Text = "" Or Not IsNumeric(txtPensionGarantizada.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '016 SUB [SubValidaDatos] validar los datos requerido
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

            If FunValidaAñoPension Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Año a Pensionarse, Ingrese un Año de Pensión Valido ", 1)
                '---------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtEdadPension.Select()
            Exit Sub
        End If

            If FunValidaLimSBCInf Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Límite SBC Inferior, Ingrese un Límite SBC Inferior Valido ", 1)
                '-------------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtLimInferior.Select()
                Exit Sub
            End If

            If FunValidaLimSBCSup Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Límite SBC Superior, Ingrese un Límite SBC Superior Valido", 1)
                '------------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtLimSuperior.Select()
            Exit Sub
        End If

            If FunValidaSemCotInf Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Semanas Cotizadas Inferior, Ingrese SC Validas ", 1)
                '-------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSemCotInf.Select()
            Exit Sub
        End If

            If FunValidaSemCotSup Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Semanas Cotizadas Superior, Ingrese SC Validas ", 1)
                '-------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSemCotSup.Select()
            Exit Sub
        End If

            If FunValidaPensionGarantizada Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en la Pensión Garantizada, Ingrese una PG Valida ", 1)
                '------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtPensionGarantizada.Select()
            Exit Sub
        End If

            txtPensionGarantizada.Text = FormatCurrency(txtPensionGarantizada.Text)

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '017 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '018 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '019 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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

Imports System.Math
Public Class foPctM40

    'Variables Globales del Formulario
    Dim gNomFormulario As String = "foPctM40"
    Dim vNameApp As String = "Catálogos"
    Dim gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foPctM40_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foPctM40_Load"

        Call subCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foPctM40_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foPctM40_FormClosed"

        Try

            'Habilita la opcion de menu del formulario
            MDIPrincipal.tsbPct40.Enabled = True
            MDIPrincipal.mnPctM40.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsPctMod40.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsPctMod40.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsPctMod40.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsPctMod40.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgPctM40_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPctM40.Click

        vg.gEvento = "dgPctM40_Click"

        Call SubHabiltaBotones()
        '-----------------------

        Try

            Call SubMenOK(" Año: " & txtAño.Text & " SBC Inferior: " & txtSBCInf.Text & " SBC Superior: " & txtSBCSup.Text & " Seleccionado ", 1)
            '------------------------------------------------------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 Evento ejecuta [SubInserta] para insertar un nuevo registro
    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "tsbAgregar_Click"

        Call subInserta()
        '----------------

    End Sub

    '010 Evento que Cancela la edicion del registro
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click

        vg.gEvento = "tsbCancelar_Click"

        bsPctMod40.CancelEdit()
        Close()

    End Sub

    '011 Evento ejecuta [SubGuardar] para guardar un nuevo registro
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "tsbGuardar_Click"

        Call subGuardar()
        '----------------

        Call subTodosLosRegistros()
        '--------------------------

    End Sub

    '012 Evento ejecuta [SubBorrar] para borrar un nuevo registro
    Private Sub tsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBorrar.Click

        vg.gEvento = "tsbBorrar_Click"

        Call subBorra()
        '--------------

        Call subTodosLosRegistros()
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

    '014 Evento ejecuta [SubFiltraID] Filtra por año
    Private Sub BtnFillAño_Click(sender As Object, e As EventArgs) Handles BtnFillAño.Click

        vg.gEvento = "BtnFillAño_Click"

        Call subFiltraAño()
        '------------------

    End Sub

    '015 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = "tsbRefrescar_Click"

        Call subTodosLosRegistros()
        '--------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento txtTotal cambia el format del total 
    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

        vg.gEvento = "txtTotal_TextChanged"

        Dim vTotal As Double

        Try

            If txtTotal.Text = "" Then
                txtTotal.Text = "0"
            End If

            vTotal = CDbl(txtTotal.Text)
            txtTotal.Text = Round(vTotal, 3)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubInserta] para insertar un nuevo registro
    Sub subInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita el botob de guardar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            txtAño.Select()

            'Agrega registro
            bsPctMod40.AddNew()

            Call subLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese Los Datos de los Porcentajes de los Seguros M40 Para El Año Seleccionado"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 SUB [SubGuardar] para guardar un nuevo registro
    Sub subGuardar()

        vg.gEvento = "subGuardar"

        Call SubSumaTotales()
        '--------------------

        Try

            bsPctMod40.EndEdit()
            PctSegurosM40TableAdapter.Update(DsCatalogos.PctSegurosM40)

            vg.gMensaje = " % de Seguros Modalidad-40 Actualizados en la Base de Datos"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            vg.gMensaje = "Error En Guardar Registro en Base de Datos" & vbCrLf & ex.ToString
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

    '004 SUB [SubBorrar] para borrar un nuevo registro
    Sub subBorra()

        vg.gEvento = "subBorra"

        Try

            vg.gMensaje = "Desea Eliminar % de Modalidad 40 para el Año : " & txtAño.Text & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                bsPctMod40.RemoveCurrent()
                bsPctMod40.EndEdit()

                PctSegurosM40TableAdapter.Update(DsCatalogos.PctSegurosM40)

                vg.gMensaje = "Se Elimino los Valores de % de Modalidad 40 en la Base De Datos: " & txtAño.Text
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

                vg.gMensaje = "NO Se Elimino los Valores de % de Modalidad 40 en la Base De Datos: " & txtAño.Text
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [SubCargaFormulario] para carga de formulario
    Sub subCargaFormulario()

        vg.gEvento = "subCargaFormulario"

        Try

            'Asigna el nombre de la aplicacion para la bitacora
            PctSegurosM40TableAdapter.Fill(DsCatalogos.PctSegurosM40)

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Porcentajes Seguros CAV, IV, GM  -  Patrón y Trabajador"
            lblTitulo.Select()

            'formato a la barra de estatus
            Call SubMenOK(" Seleccione la opcion requerida ", 1)
            '---------------------------------------------------


            Call subLimpiaDatos()
            '--------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 Sub [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub subLimpiaDatos()

        vg.gEvento = "subLimpiaDatos"

        Try

            With Me

                .txtAño.Text = ""
                .txtSBCInf.Text = ""
                .txtSBCSup.Text = ""
                .txtRetiro.Text = ""
                .txtCAVt.Text = ""
                .txtCAVp.Text = ""
                .txtIVt.Text = ""
                .txtIVp.Text = ""
                .txtGMt.Text = ""
                .txtGMp.Text = ""
                .txtTotal.Text = ""

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Sub SubHabiltaBotones()

        vg.gEvento = "SubHabiltaBotones"

        Try

            tsbGuardar.Enabled = True
            tsbBorrar.Enabled = True
            tsbValidar.Enabled = True

            txtAño.Select()
            txtCAVp.Text = Round(CDbl(txtCAVp.Text), 4)
            txtTotal.Text = Round(CDbl(txtTotal.Text), 4)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubFiltroPorAño] Filtra Año
    Sub subFiltraAño()

        vg.gEvento = "subFiltraAño"

        Try
            PctSegurosM40TableAdapter.FillByYear(DsCatalogos.PctSegurosM40, txtAñoFiltro.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub subTodosLosRegistros()

        vg.gEvento = "subTodosLosRegistros"

        Try
            PctSegurosM40TableAdapter.Fill(DsCatalogos.PctSegurosM40)
            txtAñoFiltro.Text = ""

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 FUN [FunValidaAño] Valida el Año
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

    '011 FUN [FunValidaSBSInf] Valida el SBC Inferior
    Function FunValidaSBSInf() As Boolean

        vg.gEvento = "FunValidaSBSInf"

        If Not (IsNumeric(txtSBCInf.Text)) Or IsNothing(txtSBCInf.Text) Then
            Return False
        Else
            Return True
        End If

    End Function

    '012 FUN [FunValidaSBSSup] Valida el SBC Superior
    Function FunValidaSBSSup() As Boolean

        vg.gEvento = "FunValidaSBSSup"
        FunValidaSBSSup = False

        Try

            If Not (IsNumeric(txtSBCSup.Text)) Or IsNothing(txtSBCSup.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '013 FUN [FunValidaRetiro] Valida % Retiro
    Function FunValidaRetiro() As Boolean

        vg.gEvento = "FunValidaRetir"
        FunValidaRetiro = False

        Try

            If Not (IsNumeric(txtRetiro.Text)) Or IsNothing(txtRetiro.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '014 FUN [FunValidaCAVt] Valida % CAV trabajador
    Function FunValidaCAVt() As Boolean

        vg.gEvento = "FunValidaCAVt"
        FunValidaCAVt = False

        Try

            If Not (IsNumeric(txtCAVt.Text)) Or IsNothing(txtCAVt.Text) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '015 FUN [FunValidaCAVp] Valida % CAV patron
    Function FunValidaCAVp() As Boolean

        vg.gEvento = "FunValidaCAVp"

        If Not (IsNumeric(txtCAVp.Text)) Or IsNothing(txtCAVp.Text) Then
            Return False
        Else
            Return True
        End If

    End Function

    '016 FUN [FunValidaIVt] Valida % IV trabajador
    Function FunValidaIVt() As Boolean

        vg.gEvento = "FunValidaIVt"
        FunValidaIVt = False

        Try

            If Not (IsNumeric(txtIVt.Text)) Or IsNothing(txtIVt.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '017 FUN [FunValidaIVp] Valida % IV patron
    Function FunValidaIVp() As Boolean

        vg.gEvento = "FunValidaIVp"
        FunValidaIVp = False

        Try

            If Not (IsNumeric(txtIVp.Text)) Or IsNothing(txtIVp.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Function

    '018 FUN [FunValidaGNt] Valida % GM trabajador
    Function FunValidaGMt() As Boolean

        vg.gEvento = " FunValidaGMt"

        If Not (IsNumeric(txtGMt.Text)) Or IsNothing(txtGMt.Text) Then
            Return False
        Else
            Return True
        End If

    End Function

    '019 FUN [FunValidaGNp] Valida % GM patron
    Function FunValidaGMp() As Boolean

        vg.gEvento = "FunValidaGMp"
        FunValidaGMp = False

        Try


            If Not (IsNumeric(txtGMp.Text)) Or IsNothing(txtGMp.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '020 SUB [SubSumaTotales] Suma todos los % de seguros
    Sub SubSumaTotales()

        vg.gEvento = "SubSumaTotales"

        Dim vTotalSeguro As Double
        Dim vRetiro As Double
        Dim vCAVt As Double
        Dim vCAVp As Double
        Dim vIVt As Double
        Dim vIVp As Double
        Dim vGMt As Double
        Dim vGMp As Double

        Try

            vRetiro = CDbl(txtRetiro.Text)
            vCAVt = CDbl(txtCAVt.Text)
            vCAVp = CDbl(txtCAVp.Text)
            vIVt = CDbl(txtIVt.Text)
            vIVp = CDbl(txtIVp.Text)
            vGMt = CDbl(txtGMt.Text)
            vGMp = CDbl(txtGMp.Text)

            vTotalSeguro = (vRetiro + vCAVt + vCAVp + vIVt + vIVp + vGMt + vGMp)

            txtTotal.Text = CStr(vTotalSeguro)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '021 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"
        Try

            If FunValidaAño() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Año, Ingresar un Año Válido ", 1)
                '---------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtAño.Select()
                Exit Sub
            End If

            If FunValidaSBSInf() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en SBC Inferior, Ingresar SBS Válido ", 1)
                '------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSBCInf.Select()
                Exit Sub
            End If

            If FunValidaSBSSup() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en SBC Superior, Ingresar SBS Válido ", 1)
                '------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSBCSup.Select()
                Exit Sub
            End If

            If FunValidaRetiro() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error % de Retiro Patrón, Ingresar % Retiro Válido ", 1)
                '--------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtRetiro.Select()
                Exit Sub
            End If

            If FunValidaCAVt() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error % de CAV Trabajador, Ingresar % CAV Válido ", 1)
                '------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtCAVt.Select()
                Exit Sub
            End If

            If FunValidaCAVp() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error % de CAV Patrón, Ingresar % CAV Válido ", 1)
                '--------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtCAVp.Select()
                Exit Sub
            End If

            If FunValidaIVt() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error % de IV Trabajador, Ingresar % IV Válido ", 1)
                '----------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtIVt.Select()
                Exit Sub
            End If

            If FunValidaIVp() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error % de IV Patrón, Ingresar % IV Válido ", 1)
                '------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtIVp.Select()
                Exit Sub
            End If

            If FunValidaGMt() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error % de GM Trabajador, Ingresar % GM Válido ", 1)
                '----------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtGMt.Select()
                Exit Sub
            End If

            If FunValidaGMp() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error % de GM Patrón, Ingresar % GM Válido ", 1)
                '------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtGMp.Select()
                Exit Sub
            End If

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

            Call SubSumaTotales()
            '--------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '022 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '023 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
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
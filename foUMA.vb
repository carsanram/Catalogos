'Bibliotecas
Imports System.Math


Public Class foUMA

    'Variables locales del formulario
    Dim vNameApp As String = "Catálogos"
    Dim gNomFormulario As String = "foUMA"
    Dim gCreaBitacora As Boolean = True

    Dim vUltUMA As Double = 0
    Dim vUltSMG As Double = 0
    Dim vUltSMGF As Double = 0
    Dim vEdit As Boolean = False

    'Arrglo para guardar los valores del Grid UMA variable
    Dim vAñoA(100) As Integer
    Dim vUMAA(100) As Double
    Dim vSMGA(100) As Double

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foUMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foUMA_Load"

        Call subCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foUMA_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foUMA_FormClosed"

        Try

            'Habilita la opcion de menu del formulario
            mdiprincipal.tsbUMA.Enabled = True
            mdiprincipal.mnUMA.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsUMA.MoveFirst()

        Call subCambiaFormatoMoneda()
        '----------------------------

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_ClicK"

        bsUMA.MovePrevious()

        Call subCambiaFormatoMoneda()
        '----------------------------

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsUMA.MoveNext()

        Call subCambiaFormatoMoneda()
        '----------------------------

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUltimo.Click

        vg.gEvento = " tsbUltimo_Click"

        bsUMA.MoveLast()

        Call subCambiaFormatoMoneda()
        '----------------------------


    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgUMA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgUMA.Click

        vg.gEvento = "dgUMA_Click"

        Call SubHabiltaBotones()
        '-----------------------

    End Sub

    '009 Evento ejecuta [SubInserta] para insertar un nuevo registro
    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "tsbAgregar_Click"

        vEdit = False

        Call subInserta()
        '----------------

    End Sub

    '010 Evento que Cancela la edicion del registro
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click

        vg.gEvento = "tsbCancelar_Click"

        bsUMA.CancelEdit()

        Close()

    End Sub

    '011 Evento ejecuta [SubGuardar] para guardar un nuevo registro
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "tsbGuardar_Click"
        vEdit = True

        Call SubValidaDatos()
        '--------------------

        Call subCambiaFormatoMoneda()
        '----------------------------

        Call subGuardar()
        '----------------

        Call subTodosLosRegistros()
        '--------------------------

        'Obtiene el ultimo valor de la UMA y SMG
        Call SubUltimoUMA_SMG()
        '-----------------------

    End Sub

    '012 Evento ejecuta [SubBorrar] para borrar un nuevo registro
    Private Sub tsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBorrar.Click

        vg.gEvento = "tsbBorrar_Click"

        Call subBorra()
        '--------------

    End Sub

    '013 Evento ejecuta [SubValidaDatos] para validar los datos
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        vg.gEvento = "tsbValidar_Click"

        Call SubMenOK(" Validando .... Espere", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

        Call subCambiaFormatoMoneda()
        '----------------------------

    End Sub

    '014 Evento para actualizar los datos
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = "tsbRefrescar_Clic"

        Call subTodosLosRegistros()
        '--------------------------

    End Sub

    '015 Evento ejecuta [subFiltraxAño] Filtra informacion por Año
    Private Sub btnAñoBus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñoBus.Click

        vg.gEvento = "btnAñoBus_Click"

        Call subFiltraxAño()
        '-------------------

    End Sub

    '016 Evento ejecuta [subCambioEstimada] para cambiar el valor de la UMA Estimada
    Private Sub chkEstimada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEstimada.CheckedChanged

        vg.gEvento = "chkEstimada_CheckedChanged"

        Call subCambioEstimada()
        '-----------------------

    End Sub

    '017 Evento que realiza la actualizacion de las UMAs y SMGs Fijos
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Call SubMenOK(" Borrando UMAs y SMGs .... Espere", 2)
        '----------------------------------------------------

        Call SubBorraUMAs()
        '------------------

        Call SubInsertaUMAs()
        '------------------

        Call subTodosLosRegistros()
        '--------------------------

        'selecciona el tab Datos
        tabUMA.SelectTab(tabDatos)

    End Sub

    '018 Evento que realiza la actualizacion de las UMAs y SMGs Varibles
    Private Sub btnActualizarV_Click(sender As Object, e As EventArgs) Handles btnActualizarV.Click

        Call SubMenOK(" Borrando UMAs y SMGs .... Espere", 2)
        '----------------------------------------------------

        Call SubBorraUMAs()
        '------------------

        Call SubInsertaUMAsV()
        '---------------------


        Call subTodosLosRegistros()
        '--------------------------

        'selecciona el tab Datos
        tabUMA.SelectTab(tabDatos)

    End Sub

    '028 Evento que habilita cuando se selecciona un registro
    Private Sub dgUMA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUMA.CellContentClick

        nudUMA.Value = 0
        nudSMG.Value = 0
        ' nudSMGF.Value = 0

        If txtEstimada.Text = "SI" Then
            chkEstimada.Checked = True
        Else
            chkEstimada.Checked = False
        End If

        vEdit = True

        Call subCambiaFormatoMoneda()
        '----------------------------

    End Sub

    '029 Evento para agregar años y porcentajes de inflacion a UMAs y SMGs
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim vFilas As Integer
        Dim vCuota As Double = 0
        Dim pAño As Integer = 0
        Dim i As Integer = 0

        pAño = Now.Year

        If nudAño.Value > nudAñoFinV.Value Then
            Call SubMenError(" Ya No Se Pueden Ingresar Mas Valores de Año", 1)
            '----------------------------------------------------------
            nudAño.Select()

            Exit Sub

        Else

            dgValores.Rows.Add()
            vFilas = dgValores.Rows.Count - 1

            dgValores(0, vFilas).Value = nudAño.Value
            dgValores(1, vFilas).Value = nudUMAv.Value
            dgValores(2, vFilas).Value = nudSMGv.Value

            nudAño.Value = nudAño.Value + 1


        End If

        If dgValores.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgValores.Rows
                If Not Fila Is Nothing Then
                    vAñoA(vFilas) = nudAño.Value
                    vUMAA(vFilas) = nudUMAv.Value
                    vSMGA(vFilas) = nudSMGv.Value
                End If
            Next
        End If

    End Sub

    '029 Evento para borrar años y porcentajes de inflacion a UMAs y SMGs
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Dim vFilas As Integer

        dgValores.Rows.Remove(dgValores.CurrentRow)
        vFilas = dgValores.Rows.Count - 1


        If dgValores.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgValores.Rows
                If Not Fila Is Nothing Then
                    vAñoA(vFilas) = nudAño.Value
                    vUMAA(vFilas) = nudUMAv.Value
                    vSMGA(vFilas) = nudSMGv.Value

                End If
            Next
        End If

    End Sub

    '030 Evento que suma uno al año para el siguiente valor
    Private Sub nudAñoInicioV_ValueChanged(sender As Object, e As EventArgs) Handles nudAñoInicioV.ValueChanged

        nudAño.Value = nudAñoInicioV.Value

    End Sub

    '031 Evento que muestra los valores estimados
    Private Sub btnEstimados_Click(sender As Object, e As EventArgs) Handles btnEstimados.Click

        UMATableAdapter.FillByEstimadaSI(dsCatalogos.UMA)

    End Sub

    '032 Evento que muestra los valores reales
    Private Sub btnReales_Click(sender As Object, e As EventArgs) Handles btnReales.Click

        UMATableAdapter.FillByReales(dsCatalogos.UMA)

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubInserta] para insertar un nuevo registro
    Sub subInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita el botob de guardar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False


            txtAño.Select()


            'Agrega registro
            bsUMA.AddNew()

            Call subLimpiaDatos()
            '--------------------

            txtUMADia.Text = txtUlltimaUMA.Text
            txtSMGDia.Text = txtUlltimoSMG.Text
            txtSMGFDia.Text = txtUlltimoSMGF.Text

            'Mensaje de alta
            vg.gMensaje = " Ingrese Los Datos de la UMA y SMG Para El Año Seleccionado"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsUMA.EndEdit()
            UMATableAdapter.Update(dsCatalogos.UMA)

            vg.gMensaje = " UMA-SMG Actualizado en Base de Datos"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            If ex.ToString.Contains("Está restringida para ser única") Then
                vg.gMensaje = "Ya Existe el Año [ " & txtAño.Text & " ], Ingrese Otro Año"
                Call mUniversal.SubMsgWarning(vg.gMensaje, Me, 5)
                '------------------------------------------------

                Call SubMenOK(" Ingrese la Información Requerida ", 1)
                '-----------------------------------------------------

                Exit Sub
            Else
                vg.gMensaje = "Error En Guardar Registro en Base de Datos " & vbCrLf & ex.Message
                Call mUniversal.SubMsgCritical(vg.gMensaje, Me, 5)
                '------------------------------------------------

                Exit Sub
            End If

        End Try

        Call SubMenOK(" Ingrese la Información Requerida ", 1)
        '-----------------------------------------------------

        tsbAgregar.Enabled = True
        tsbGuardar.Enabled = False

    End Sub

    '003 SUB [SubBorrar] para borrar un nuevo registro
    Sub subBorra()

        vg.gEvento = "SubBorra"

        Try

            vg.gMensaje = "Desea Eliminar la Información del Valor de la UMA-SMG del Año: " & txtAño.Text & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                bsUMA.RemoveCurrent()
                bsUMA.EndEdit()
                UMATableAdapter.Update(dsCatalogos.UMA)

                vg.gMensaje = "Se Elimino la Información del Valor de la UMA-SMG del Año: " & txtAño.Text
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

                vg.gMensaje = "No Se Elimino la Información del Valor de la UMA-SMG del Año: " & txtAño.Text
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [SubCargaFormulario] para carga de formulario
    Sub subCargaFormulario()

        vg.gEvento = "subCargaFormulario"

        Dim vAño As String

        vAño = Now.Year

        nudAñoInicio.Value = vAño + 1
        nudAñoFin.Value = vAño + 5

        nudAñoInicioV.Value = vAño + 1
        nudAñoFinV.Value = vAño + 5

        nudAño.Value = nudAñoInicioV.Value

        Try

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            Call subCambiaFormatoMoneda()
            '---------------------------

            'Primer registro
            UMATableAdapter.Fill(dsCatalogos.UMA)
            'UMATableAdapter.FillByYear(dsCatalogos.UMA, vAño)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Unidad de Medida y Actualizacion (UMA) - Salario Minimo General (SMG)"
            lblTitulo.Select()

            'formato a la barra de estatus
            Call SubMenOK(" Ingrese la Información Requerida ", 1)
            '-----------------------------------------------------

            Call SubLimpiaDatos()
            '--------------------

            'Obtiene el ultimo valor de la UMA y SMG
            Call SubUltimoUMA_SMG()
            '-----------------------


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [subCambiaFormatoMoneda] cambia el formato a moneda
    Sub subCambiaFormatoMoneda()

        vg.gEvento = "subCambiaFormatoMoneda"

        Try

            With Me

                If .txtUMADia.Text = "" Then
                    .txtUMADia.Text = "0"
                End If
                If .txtUMAMen.Text = "" Then
                    .txtUMAMen.Text = "0"
                End If
                If .txtUMAAnu.Text = "" Then
                    .txtUMAAnu.Text = "0"
                End If
                If .txtSMGDia.Text = "" Then
                    .txtSMGDia.Text = "0"
                End If
                If .txtSMGMen.Text = "" Then
                    .txtSMGMen.Text = "0"
                End If
                If .txtSMGAnu.Text = "" Then
                    .txtSMGAnu.Text = "0"
                End If
                If .txtSMGFDia.Text = "" Then
                    .txtSMGFDia.Text = "0"
                End If
                If .txtSMGFMen.Text = "" Then
                    .txtSMGFMen.Text = "0"
                End If
                If .txtSMGFAnu.Text = "" Then
                    .txtSMGFAnu.Text = "0"
                End If

                Try
                    .txtUMADia.Text = FormatCurrency(.txtUMADia.Text)
                    .txtUMAMen.Text = FormatCurrency(.txtUMAMen.Text)
                    .txtUMAAnu.Text = FormatCurrency(.txtUMAAnu.Text)

                    .txtSMGDia.Text = FormatCurrency(.txtSMGDia.Text)
                    .txtSMGMen.Text = FormatCurrency(.txtSMGMen.Text)
                    .txtSMGAnu.Text = FormatCurrency(.txtSMGAnu.Text)

                    .txtSMGFDia.Text = FormatCurrency(.txtSMGFDia.Text)
                    .txtSMGFMen.Text = FormatCurrency(.txtSMGFMen.Text)
                    .txtSMGFAnu.Text = FormatCurrency(.txtSMGFAnu.Text)

                    .txtUlltimaUMA.Text = FormatCurrency(txtUlltimaUMA.Text)
                    .txtUlltimoSMG.Text = FormatCurrency(txtUlltimoSMG.Text)
                    .txtUlltimoSMGF.Text = FormatCurrency(txtUlltimoSMGF.Text)


                    If txtEstimada.Text = "SI" Then
                        chkEstimada.Checked = True
                    Else
                        chkEstimada.Checked = False
                    End If

                    .tsbGuardar.Enabled = True
                    .tsbBorrar.Enabled = True

                Catch ex As Exception

                    'MsgBox(ex.ToString)

                End Try

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 Sub [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "subLimpiaDatos"

        Try

            With Me

                .txtAño.Text = ""
                .txtUMADia.Text = ""
                .txtUMAMen.Text = ""
                .txtUMAAnu.Text = ""

                .txtSMGDia.Text = ""
                .txtSMGMen.Text = ""
                .txtSMGAnu.Text = ""

                .txtSMGFDia.Text = ""
                .txtSMGFMen.Text = ""
                .txtSMGFAnu.Text = ""

                .txtEstimada.Text = "NO"
                .chkEstimada.Checked = False

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Sub SubHabiltaBotones()

        vg.gEvento = "SubHabiltaBotones"

        tsbGuardar.Enabled = True
        tsbBorrar.Enabled = True
        tsbValidar.Enabled = True

        Try

            Call SubMenOK(" Año: " & txtAño.Text & " UMA Diaria: " & txtUMADia.Text & " SMG Diario: " & txtSMGDia.Text & " Seleccionado ", 1)
            '--------------------------------------------------------------------------------------------------------------------------------

            Call subCambiaFormatoMoneda()
            ''----------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub subTodosLosRegistros()

        vg.gEvento = "subTodosLosRegistros"

        Try
            UMATableAdapter.Fill(dsCatalogos.UMA)
            txtAñoBus.Text = ""

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 SUB [subFiltraxAño] Filtra por Año
    Sub subFiltraxAño()

        vg.gEvento = "subFiltraxAño"

        Try
            UMATableAdapter.FillByYear(dsCatalogos.UMA, txtAñoBus.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    '010 SUB [FunValidaAño] Valida el año
    Function FunValidaAño() As Boolean

        vg.gEvento = "FunValidaAño"
        FunValidaAño = False

        Try

            If txtAño.Text = "" Then
                txtAño.Text = "0"
            End If

            If Not (IsNumeric(txtAño.Text)) Or IsNothing(txtAño.Text) Or Val(CInt(txtAño.Text) < 1900) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '011 SUB [FunValidaUMA] Valida la UMA
    Function FunValidaUMA() As Boolean

        vg.gEvento = "FunValidaUMA"
        FunValidaUMA = False

        Try

            If Not (IsNumeric(txtUMADia.Text)) Or IsNothing(txtUMADia.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '012 SUB [FunValidaSMG] Valida el SMG
    Function FunValidaSMG() As Boolean

        vg.gEvento = "FunValidaSMG"
        FunValidaSMG = False

        Try

            If Not (IsNumeric(txtSMGDia.Text)) Or IsNothing(txtSMGDia.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '013 SUB [FunValidaSMGF] Valida el SMG
    Function FunValidaSMGF() As Boolean

        vg.gEvento = "FunValidaSMGF"
        FunValidaSMGF = False

        Try

            If Not (IsNumeric(txtSMGFDia.Text)) Or IsNothing(txtSMGFDia.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '014 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"
        Try

            If FunValidaAño() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Año, Ingrese Año Válido", 1)
                '----------------------------------------------------------
                tsbGuardar.Enabled = False
                txtAño.Select()
                Exit Sub
            End If

            If FunValidaUMA() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en UMA, Ingrese UMA Válida", 1)
                '-------------------------------------------------------
                tsbGuardar.Enabled = False
                txtUMADia.Select()
                Exit Sub
            End If

            If FunValidaSMG() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en SMG, Ingrese un SMG Válido ", 1)
                '-----------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSMGDia.Select()
                Exit Sub
            End If

            If FunValidaSMGF() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en SMG Frontera, Ingrese un SMG Frontera Válido ", 1)
                '-----------------------------------------------------------
                tsbGuardar.Enabled = False
                txtSMGDia.Select()
                Exit Sub
            End If


            'Calcula UMA Mensual y anual
            txtUMADia.Text = FormatCurrency(txtUMADia.Text)
            'txtUMAMen.Text = FormatCurrency(txtUMADia.Text * 30.4)
            'txtUMAAnu.Text = FormatCurrency(txtUMADia.Text * 365.25)

            txtUMAMen.Text = FormatCurrency(txtUMADia.Text * 31)
            txtUMAAnu.Text = FormatCurrency(txtUMADia.Text * 365)

            'Calcula SMG Mensual y anual
            txtSMGDia.Text = FormatCurrency(txtSMGDia.Text)
            'txtSMGMen.Text = FormatCurrency(txtSMGDia.Text * 30.4)
            'txtSMGAnu.Text = FormatCurrency(txtSMGDia.Text * 365.25)

            txtSMGMen.Text = FormatCurrency(txtSMGDia.Text * 31)
            txtSMGAnu.Text = FormatCurrency(txtSMGDia.Text * 365)

            'Calcula SMG Frontera Mensual y anual
            txtSMGFDia.Text = FormatCurrency(txtSMGFDia.Text)
            'txtSMGFMen.Text = FormatCurrency(txtSMGFDia.Text * 30.4)
            'txtSMGFAnu.Text = FormatCurrency(txtSMGFDia.Text * 365.25)

            txtSMGFMen.Text = FormatCurrency(txtSMGFDia.Text * 31)
            txtSMGFAnu.Text = FormatCurrency(txtSMGFDia.Text * 365)

            txtRelacion.Text = Round(txtSMGDia.Text / txtUMADia.Text, 2)
            'txtEstimada.Text = "NO"
            'chkEstimada.Checked = False

            tsbGuardar.Enabled = True


            'Asigna si la UMA y SMG es estimado
            If txtAño.Text = "" Then
                txtAño.Text = 0
            End If


            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '015 SUB [subCambioEstimada] Valida el SMG
    Sub subCambioEstimada()

        vg.gEvento = "subCambioEstimada"

        Try

            If chkEstimada.Checked = True Then
                txtEstimada.Text = "SI"
            Else
                txtEstimada.Text = "NO"
            End If


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

    '019 Sub [ SubUltimoUMA_SMG ] Obtiene los ultimmos UMA y SMG
    Sub SubUltimoUMA_SMG()

        vUltUMA = Now.Year
        txtAñoInicioB.Text = Now.Year
        txtAñoInicioV.Text = Now.Year

        'vUltUMA = ConsultasBD.FunGetUltimaUMA
        vUltUMA = ConsultasBD.FunCargaValorUMA(Now.Year)

        txtUlltimaUMA.Text = FormatCurrency(vUltUMA)
        txtUlltimaUMAv.Text = FormatCurrency(vUltUMA)


        'vUltSMG = ConsultasBD.FunGetUtimoSMG
        vUltSMG = ConsultasBD.FunCargaValorSMG(Now.Year)
        txtUlltimoSMG.Text = FormatCurrency(vUltSMG)
        txtUlltimoSMGv.Text = FormatCurrency(vUltSMG)


        'vUltSMGF = ConsultasBD.FunGetUtimoSMGF
        vUltSMGF = ConsultasBD.FunCargaValorSMGF(Now.Year)


        txtUlltimoSMGF.Text = FormatCurrency(vUltSMGF)
        txtUlltimoSMGFv.Text = FormatCurrency(vUltSMGF)


    End Sub

    '020 Sub [ SubBorraUMAs ] Borra UMAs y SMGs para insertar nuevos valores
    Sub SubBorraUMAs()

        Dim i As Integer = 0
        Dim vAñoIni As Integer = 0
        Dim vAñoFin As Integer = 0
        Dim vAñoProcesar As Integer = 0

        vg.gEvento = "SubBorraUMAs"

        'Toma el rango de años a borrar
        vAñoIni = nudAñoInicio.Value
        vAñoFin = nudAñoFin.Value

        Try

            For i = vAñoIni To vAñoFin

                vAñoProcesar = i

                cmd.CommandType = CommandType.Text
                cmd.Connection = conCa

                SQL = "DELETE FROM UMA WHERE Año = " & vAñoProcesar & ";"

                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()

            Next

            Call SubMenOK(" Se eliminaron las UMAs y SMGs del " & vAñoIni & " Al " & vAñoFin, 2)
            '-----------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '021 Sub [ SubInsertaUMAs ] Inserta UMAs y SMGs para insertar nuevos valores fijos
    Sub SubInsertaUMAs()

        vg.gEvento = "SubInsertaUMAs"

        Dim vUMAini As Double = 0
        Dim vSMGini As Double = 0
        Dim vSMGFIni As Double = 0

        Dim vUMAPro As Double = 0
        Dim vSMGPro As Double = 0
        Dim vSMGFPro As Double = 0

        Dim vUMAMenPro As Double = 0
        Dim vSMGMenPro As Double = 0
        Dim vSMGMenFPro As Double = 0

        Dim vUMAAñoPro As Double = 0
        Dim vSMGAñoPro As Double = 0
        Dim vSMGAñoFPro As Double = 0

        Dim i As Integer = 0
        Dim vAñoIni As Integer = 0
        Dim vAñoFin As Integer = 0
        Dim vAñoProcesar As Integer = 0

        Dim vPctUMA As Double = 0
        Dim vPctSMG As Double = 0

        Dim vRelUMASMG As Double = 0

        vAñoIni = nudAñoInicio.Value
        vAñoFin = nudAñoFin.Value

        Try

            Call SubMenOK(" Insertando las UMAs y SMGs " & vAñoIni & " Al " & vAñoFin, 2)
            '-----------------------------------------------------------------------------------

            cmd.CommandType = CommandType.Text
            cmd.Connection = conCa

            vPctUMA = nudUMA.Value / 100
            vPctSMG = nudSMG.Value / 100

            vUMAini = txtUlltimaUMA.Text
            vSMGini = txtUlltimoSMG.Text
            vSMGFIni = txtUlltimoSMGF.Text

            vUMAPro = vUMAini * (1 + vPctUMA)
            vSMGPro = vSMGini * (1 + vPctSMG)
            vSMGFPro = vSMGFIni * (1 + vPctSMG)

            'Calcula los valores mensuales 
            vUMAMenPro = vUMAPro * 31
            vSMGMenPro = vSMGPro * 31
            vSMGMenFPro = vSMGFPro * 31

            'Calcula los valores anuales
            vUMAAñoPro = vUMAPro * 365
            vSMGAñoPro = vSMGPro * 365
            vSMGAñoFPro = vSMGFPro * 365

            vRelUMASMG = Round(vSMGPro / vUMAPro, 4)

            'Inserta el primer registro

            SQL = "INSERT INTO UMA (Año,UMADia,UMAMensual,UMAAnual,SMGDia,SMGMensual,SMGAnual,SMGFDia,SMGFMensual,SMGFAnual,RelUMA_SMG,Estimada)"
            SQL = SQL & " VALUES (" & vAñoIni & "," & vUMAPro & "," & vUMAMenPro & "," & vUMAAñoPro & ","
            SQL = SQL & vSMGPro & "," & vSMGMenPro & "," & vSMGAñoPro & ","
            SQL = SQL & vSMGFPro & "," & vSMGMenFPro & "," & vSMGAñoFPro & "," & vRelUMASMG & ",'" & "SI" & "');"

            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            For i = vAñoIni + 1 To vAñoFin

                vUMAPro = vUMAPro * (1 + vPctUMA)
                vSMGPro = vSMGPro * (1 + vPctSMG)
                vSMGFPro = vSMGFPro * (1 + vPctSMG)

                'Calcula los valores mensuales 
                vUMAMenPro = vUMAPro * 31
                vSMGMenPro = vSMGPro * 31
                vSMGMenFPro = vSMGFPro * 31

                'Calcula los valores anuales
                vUMAAñoPro = vUMAPro * 365
                vSMGAñoPro = vSMGPro * 365
                vSMGAñoFPro = vSMGFPro * 365

                vRelUMASMG = Round(vSMGPro / vUMAPro, 4)

                SQL = "INSERT INTO UMA (Año,UMADia,UMAMensual,UMAAnual,SMGDia,SMGMensual,SMGAnual,SMGFDia,SMGFMensual,SMGFAnual,RelUMA_SMG,Estimada)"
                SQL = SQL & " VALUES (" & i & "," & vUMAPro & "," & vUMAMenPro & "," & vUMAAñoPro & ","
                SQL = SQL & vSMGPro & "," & vSMGMenPro & "," & vSMGAñoPro & ","
                SQL = SQL & vSMGFPro & "," & vSMGMenFPro & "," & vSMGAñoFPro & "," & vRelUMASMG & ",'" & "SI" & "');"

                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()

            Next

            Call SubMenOK(" Se Termino de Insertar las UMAs y SMGs " & vAñoIni & " Al " & vAñoFin, 2)
            '-----------------------------------------------------------------------------------

            Call SubMenOK(" Seleccione la Accion que Desee Realizar ", 2)
            '-----------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '022 Sub [ SubInsertaUMAsV ] Inserta UMAs y SMGs para insertar nuevos valores variables
    Sub SubInsertaUMAsV()

        vg.gEvento = "SubInsertaUMAs"

        Dim vUMAini As Double = 0
        Dim vSMGini As Double = 0
        Dim vSMGFIni As Double = 0

        Dim vUMAPro As Double = 0
        Dim vSMGPro As Double = 0
        Dim vSMGFPro As Double = 0

        Dim vUMAMenPro As Double = 0
        Dim vSMGMenPro As Double = 0
        Dim vSMGMenFPro As Double = 0

        Dim vUMAAñoPro As Double = 0
        Dim vSMGAñoPro As Double = 0
        Dim vSMGAñoFPro As Double = 0

        Dim i As Integer = 0
        Dim vAñoIni As Integer = 0
        Dim vAñoFin As Integer = 0
        Dim vAñoProcesar As Integer = 0

        Dim vPctUMA As Double = 0
        Dim vPctSMG As Double = 0

        Dim vRelUMASMG As Double = 0


        vAñoIni = nudAñoInicioV.Value
        vAñoFin = nudAñoFinV.Value


        Try

            Call SubMenOK(" Insertando las UMAs y SMGs " & vAñoIni & " Al " & vAñoFin, 2)
            '-----------------------------------------------------------------------------------

            cmd.CommandType = CommandType.Text
            cmd.Connection = conCa

            'Asigna el primer valor de la UMA y SMG guardado en el arreglo
            vPctUMA = vUMAA(0) / 100
            vPctSMG = vSMGA(0) / 100

            vUMAini = txtUlltimaUMA.Text
            vSMGini = txtUlltimoSMG.Text
            vSMGFIni = txtUlltimoSMGF.Text

            vUMAPro = vUMAini * (1 + vPctUMA)
            vSMGPro = vSMGini * (1 + vPctSMG)
            vSMGFPro = vSMGFIni * (1 + vPctSMG)

            'Calcula los valores mensuales 
            vUMAMenPro = vUMAPro * 31
            vSMGMenPro = vSMGPro * 31
            vSMGMenFPro = vSMGFPro * 31

            'Calcula los valores anuales
            vUMAAñoPro = vUMAPro * 365
            vSMGAñoPro = vSMGPro * 365
            vSMGAñoFPro = vSMGFPro * 365

            vRelUMASMG = Round(vSMGPro / vUMAPro, 4)

            'Inserta el primer registro

            SQL = "INSERT INTO UMA (Año,UMADia,UMAMensual,UMAAnual,SMGDia,SMGMensual,SMGAnual,SMGFDia,SMGFMensual,SMGFAnual,RelUMA_SMG,Estimada)"
            SQL = SQL & " VALUES (" & vAñoIni & "," & vUMAPro & "," & vUMAMenPro & "," & vUMAAñoPro & ","
            SQL = SQL & vSMGPro & "," & vSMGMenPro & "," & vSMGAñoPro & ","
            SQL = SQL & vSMGFPro & "," & vSMGMenFPro & "," & vSMGAñoFPro & "," & vRelUMASMG & ",'" & "SI" & "');"

            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            Dim j As Integer = 1

            For i = vAñoIni + 1 To vAñoFin

                'vUMAPro = vUMAPro * (1 + vPctUMA)
                'vSMGPro = vSMGPro * (1 + vPctSMG)
                'vSMGFPro = vSMGFPro * (1 + vPctSMG)

                vUMAPro = vUMAPro * (1 + vUMAA(j) / 100)
                vSMGPro = vSMGPro * (1 + vSMGA(j) / 100)
                vSMGFPro = vSMGFPro * (1 + vSMGA(j) / 100)

                'Calcula los valores mensuales 
                vUMAMenPro = vUMAPro * 31
                vSMGMenPro = vSMGPro * 31
                vSMGMenFPro = vSMGFPro * 31

                'Calcula los valores anuales
                vUMAAñoPro = vUMAPro * 365
                vSMGAñoPro = vSMGPro * 365
                vSMGAñoFPro = vSMGFPro * 365

                vRelUMASMG = Round(vSMGPro / vUMAPro, 4)

                SQL = "INSERT INTO UMA (Año,UMADia,UMAMensual,UMAAnual,SMGDia,SMGMensual,SMGAnual,SMGFDia,SMGFMensual,SMGFAnual,RelUMA_SMG,Estimada)"
                SQL = SQL & " VALUES (" & i & "," & vUMAPro & "," & vUMAMenPro & "," & vUMAAñoPro & ","
                SQL = SQL & vSMGPro & "," & vSMGMenPro & "," & vSMGAñoPro & ","
                SQL = SQL & vSMGFPro & "," & vSMGMenFPro & "," & vSMGAñoFPro & "," & vRelUMASMG & ",'" & "SI" & "');"

                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()

                j = j + 1

            Next

            Call SubMenOK(" Se Termino de Insertar las UMAs y SMGs " & vAñoIni & " Al " & vAñoFin, 2)
            '-----------------------------------------------------------------------------------

            Call SubMenOK(" Seleccione la Accion que Desee Realizar " & vAñoIni & " Al " & vAñoFin, 2)
            '-----------------------------------------------------------------------------------



        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

End Class

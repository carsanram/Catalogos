Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class foModalidades
    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foModalidades"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS 014 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foModalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vg.gEvento = "foModalidades_Load"

        Call SubCargaFormulario()
        '------------------------
        Me.RegimenIMSSTableAdapter.Fill(Me.DsCatalogos.RegimenIMSS)

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foModalidades_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foModalidades_FormClosed"

        Try
            'Habilita la opcion de menu del formulario
            MDIPrincipal.tsbModalidades.Enabled = True
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsRegimen.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsRegimen.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsRegimen.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsRegimen.MoveLast()

    End Sub

    '007 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click

        vg.gEvento = "tsbRefrescar_Click"

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '008 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '009 Evento que ejecuta el filtro de busqueda
    Private Sub btnModalidadFiltro_Click(sender As Object, e As EventArgs) Handles btnModalidadFiltro.Click

        Me.RegimenIMSSTableAdapter.FillByModallidad(Me.DsCatalogos.RegimenIMSS, txtModalidadFind.Text)

    End Sub

    '010 Evento que ejecuta [SubValidaDatos] Valida datos ingresados
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        Call SubMenOK(" Validando .... Espere", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '011 Evento ejecuta [SubInserta] para insertar un nuevo registro
    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "tsbAgregar_Click"

        Call SubInserta()
        '----------------

    End Sub

    '012 Evento que Cancela la edicion del registro
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click

        vg.gEvento = "tsbCancelar_Click"

        bsRegimen.CancelEdit()
        Close()

    End Sub

    '013 Evento ejecuta [SubGuardar] para guardar un nuevo registro
    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "tsbGuardar_Click"

        Call SubGuardar()
        '----------------

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '014 Evento ejecuta [SubBorrar] para borrar un nuevo registro
    Private Sub tsbBorrar_Click(sender As Object, e As EventArgs) Handles tsbBorrar.Click

        vg.gEvento = "tsbBorrar_Click"

        Call SubBorra()
        '--------------

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '015 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgRegimenIMSS_Click(sender As Object, e As EventArgs) Handles dgRegimenIMSS.Click

        vg.gEvento = "dgRegimenIMSS_Click"

        Try

            Call SubHabiltaBotones()
            '-----------------------

            Call SubMenOK(" Modalidad " & txtModalidad.Text & " Seleccionada", 1)
            '--------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS 014 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [SubCargaFormulario] para carga de formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            'Inhabilita el botones de Guardar y Borrar

            tsbValidar.Enabled = True
            tsbAgregar.Enabled = True
            tsbCancelar.Enabled = False
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False

            'Inicia el llenado del grid
            Me.RegimenIMSSTableAdapter.Fill(Me.DsCatalogos.RegimenIMSS)


            'Formato al titulo
            lblTitulo.Text = "Catálogo: Regimen y Modalidades del IMSS"
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

    '002 SUB [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            cboTipoRegimen.Text = ""
            txtModalidad.Text = ""
            txtDescripcion.Text = ""
            cboS_RT.Text = "NO"
            cboS_E.Text = "NO"
            cboS_M.Text = "NO"
            cboS_I.Text = "NO"
            cboS_V.Text = "NO"
            cboS_R.Text = "NO"
            cboS_C.Text = "NO"
            cboS_Ve.Text = "NO"
            cboS_G.Text = "NO"
            cboS_PS.Text = "NO"
            cboDS_E.Text = "NO"
            cboDS_M.Text = "NO"
            cboDS_RT.Text = "NO"
            txtAplicaPension.Text = ""

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try
            RegimenIMSSTableAdapter.Fill(DsCatalogos.RegimenIMSS)
            txtModalidadFind.Clear()

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        lblTitulo.Select()

    End Sub

    '004 SUB [SubValidaDatos] validar los datos ingresados
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            'Valida Regimen
            If FunValRegimen() Then
                tsbGuardar.Enabled = True

            Else
                Call SubMenError(" Seleccione un Regimen", 1)
                '--------------------------------------------

                tsbGuardar.Enabled = False
                cboTipoRegimen.Select()
                Exit Sub

            End If

            'Valida Modalidad
            If FunValRegimen() Then
                tsbGuardar.Enabled = True

            Else
                Call SubMenError(" Error en Numero de Modalidad, Ingrese Uno Correcto", 1)
                '-------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                cboTipoRegimen.Select()
                Exit Sub

            End If

            Call SubMenOK(" Generando Tipos de Pensión Aplicable", 1)
            '--------------------------------------------------------

            Call SubGeneraAplicaPension()
            '--------------------------

            Call SubMenOK(" Información Validada, Oprima Boton [Guardar] para Guardar la Información", 1)
            '--------------------------------------------------------------------------------------------

            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False
            tsbCancelar.Enabled = False
            tsbGuardar.Enabled = True
            tsbBorrar.Enabled = False

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [FunValRegimen] validar el regimen
    Function FunValRegimen() As Boolean

        vg.gEvento = "FunValRegimen"

        FunValRegimen = False

        Try

            If cboTipoRegimen.Text = "" Then
                FunValRegimen = False
            Else
                FunValRegimen = True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '006 SUB [FunValModalidad] validar la modalidad
    Function FunValModalidad() As Boolean

        vg.gEvento = "FunValModalidad"

        FunValModalidad = False

        Try

            If txtModalidad.Text = "" Or Not (IsNumeric(txtModalidad.Text)) Then
                FunValModalidad = False
            Else
                FunValModalidad = True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '007 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita el boton Validar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False
            tsbCancelar.Enabled = True
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False

            cboTipoRegimen.Select()

            'Agrega registro
            bsRegimen.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información del Regimen - Modalidad del IMSS "
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        'Activa los metodos de validacion agregados
        Try

            bsRegimen.EndEdit()
            RegimenIMSSTableAdapter.Update(DsCatalogos.RegimenIMSS)

            vg.gMensaje = " Regimen-Modalidad Actualizada en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = "Error en Guardar Regimen-Modalidad en la Base de Datos"
            Call mUniversal.SubMsgCritical(vg.gMensaje, Me, 5)
            '------------------------------------------------

            Exit Sub

        End Try

        Call SubMenOK(" Ingrese la Información Requerida ", 1)
        '-----------------------------------------------------


        tsbAgregar.Enabled = True

        tsbValidar.Enabled = False
        tsbGuardar.Enabled = False
        tsbCancelar.Enabled = False
        tsbBorrar.Enabled = False

    End Sub

    '009 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        vg.gEvento = "SubBorra"

        Dim vModBorrar As String

        Try

            vModBorrar = txtModalidad.Text

            vg.gMensaje = "Desea Eliminar la Modalidad: " & vModBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                bsRegimen.RemoveCurrent()
                bsRegimen.EndEdit()

                RegimenIMSSTableAdapter.Update(DsCatalogos.RegimenIMSS)

                vg.gMensaje = "Se Elimino la Modalidad en la base de datos: " & vModBorrar
                Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
                '--------------------------------------------

                'inhabilita botones
                tsbAgregar.Enabled = True
                tsbBorrar.Enabled = False
                tsbGuardar.Enabled = False

            End If

            If vg.gNo Then

                vg.gMensaje = "No Se Elimino la Modalidad en la base de datos: " & vModBorrar
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Sub SubHabiltaBotones()

        vg.gEvento = "SubHabiltaBotones"

        Try

            tsbValidar.Enabled = True
            tsbAgregar.Enabled = True
            tsbCancelar.Enabled = False
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '011 SUB [SubGeneraAplicaPension] Genera string de pensiones
    Sub SubGeneraAplicaPension()

        Dim vAplicaPension As String = ""
        Dim vS_RT As String = ""

        Dim vS_E As String = ""
        Dim vS_M As String = ""

        Dim vS_I As String = ""
        Dim vS_V As String = ""

        Dim vS_R As String = ""
        Dim vS_C As String = ""
        Dim vS_Ve As String = ""

        Dim vS_G As String = ""
        Dim vS_PS As String = ""

        'Riesgos de trabajo
        If cboS_RT.Text = "SI" Then
            vS_RT = "RT"
        End If

        'Enfermedad y Maternidad
        If cboS_E.Text = "SI" Then
            vS_E = "Enf"
        End If
        If cboS_M.Text = "SI" Then
            vS_M = "Mat"
        End If

        'Invalidez y vida
        If cboS_I.Text = "SI" Then
            vS_I = "Inv"
        End If
        If cboS_V.Text = "SI" Then
            vS_V = "Vid"
        End If

        'Retiro, cesantia y vejez
        If cboS_R.Text = "SI" Then
            vS_R = "Ret"
        End If
        If cboS_C.Text = "SI" Then
            vS_C = "Ces"
        End If
        If cboS_Ve.Text = "SI" Then
            vS_Ve = "Vej"
        End If

        'Guarderias y prestaciones sociales
        If cboS_G.Text = "SI" Then
            vS_G = "Gua"
        End If
        If cboS_PS.Text = "SI" Then
            vS_PS = "PS"
        End If


        'Riesgos de trabajo
        If vS_RT = "RT" Then
            vAplicaPension = vAplicaPension & vS_RT & " "
        End If

        'Enfermedad y Maternidad
        If vS_E = "Enf" Then
            vAplicaPension = vAplicaPension & vS_E & " "
        End If

        If vS_M = "Mat" Then
            vAplicaPension = vAplicaPension & vS_M & " "
        End If


        If vS_I = "Inv" Then
            vAplicaPension = vAplicaPension & vS_I & " "
        End If

        If vS_V = "Vid" Then
            vAplicaPension = vAplicaPension & vS_V & " "
        End If


        If vS_R = "Ret" Then
            vAplicaPension = vAplicaPension & vS_R & " "
        End If

        If vS_C = "Ces" Then
            vAplicaPension = vAplicaPension & vS_C & " "
        End If

        If vS_Ve = "Vej" Then
            vAplicaPension = vAplicaPension & vS_Ve & " "
        End If

        If vS_G = "Gua" Then
            vAplicaPension = vAplicaPension & vS_G & " "
        End If

        If vS_PS = "PS" Then
            vAplicaPension = vAplicaPension & vS_PS
        End If

        txtAplicaPension.Text = vAplicaPension

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
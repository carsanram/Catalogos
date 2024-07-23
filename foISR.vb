Public Class foISR

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foISR"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foISR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foISR_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foISR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foISR_FormClosed"

        Try

            'Habilita la opcion de menu del formualario
            MDIPrincipal.mnISR.Enabled = True
            MDIPrincipal.tsbISR.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsISR.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsISR.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsISR.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsISR.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgISR_Click(sender As Object, e As EventArgs) Handles dgISR.Click

        vg.gEvento = "dgISR_Click"

        Call SubHabiltaBotones()
        '-----------------------

        Try

            Call SubMenOK(" Límite Inferior: " & txtLimInf.Text & " Límite Superior: " & txtLimSup.Text & " Cuota Fija: " & txtCuotaFija.Text & " Seleccionado ", 1)
            '-------------------------------------------------------------------------------------------------------------------------------------------------------

            If txtLimInf.Text <> "" Then
                txtLimInf.Text = FormatCurrency(txtLimInf.Text)
            End If
            If txtLimSup.Text <> "" Then
                txtLimSup.Text = FormatCurrency(txtLimSup.Text)
            End If
            If txtCuotaFija.Text <> "" Then
                txtCuotaFija.Text = FormatCurrency(txtCuotaFija.Text)
            End If

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

        bsISR.CancelEdit()
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

        vg.gEvento = " tsbBorrar_Click"

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

    '014 Evento ejecuta [SubTodosLosRegistros] Filtra por todos los registros
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

            txtLimInf.Select()

            'Agrega registro
            bsISR.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información de los Límites, Cuota Fija y % Límite Excedente de Impuestos ISR"
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

            bsISR.EndEdit()
            ISRTableAdapter.Update(DsCatalogos.ISR)

            vg.gMensaje = " ISR Actualizado en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------


        Catch ex As Exception

            vg.gMensaje = "Error en Guardar Registro en Base de Datos" & vbCrLf & ex.ToString
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

        Try

            Dim vLimBorrar As String

            vLimBorrar = txtLimInf.Text

            vg.gMensaje = "Desea Eliminar La Informacion del ISR con el Límte Inferior : " & vLimBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then


                bsISR.RemoveCurrent()
                bsISR.EndEdit()

                ISRTableAdapter.Update(DsCatalogos.ISR)

                vg.gMensaje = "Se Elimino la Información del ISR con el Límite Inferior en la Base de Datos: " & vLimBorrar
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

                vg.gMensaje = "NO Se Elimino la Información del ISR con el Límite Inferior en la Base de Datos: " & vLimBorrar
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

            If vg.gOK Then

                Exit Sub

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
            ISRTableAdapter.Fill(DsCatalogos.ISR)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Impuesto de Pensión por ISR"
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

    '005 Sub [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            With Me

                .txtLimInf.Text = ""
                .txtLimSup.Text = ""
                .txtCuotaFija.Text = ""
                .txtPctExeLI.Text = ""

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

    '007 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try

            ISRTableAdapter.Fill(DsCatalogos.ISR)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [FunValidaLimSup] Valida el limite Inferior
    Function FunValidaLimInf() As Boolean

        vg.gEvento = "FunValidaLimInf"

        FunValidaLimInf = True

        Try

            If txtLimInf.Text = "" Or Not IsNumeric(txtLimInf.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '009 SUB [FunValidaLimSup] Valida el limite superior
    Function FunValidaLimSup() As Boolean

        vg.gEvento = "FunValidaLimSup"

        FunValidaLimSup = True

        Try

            If txtLimSup.Text = "" Or Not IsNumeric(txtLimSup.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '010 SUB [FunValidaCuotaFija] Valida Cuota fija
    Function FunValidaCuotaFija() As Boolean

        vg.gEvento = "FunValidaCuotaFija"

        FunValidaCuotaFija = True

        Try

            If txtCuotaFija.Text = "" Or Not IsNumeric(txtCuotaFija.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '011 SUB [FunValidaPctExcLimInf] Valida el % de la cuota
    Function FunValidaPctExcLimInf() As Boolean

        vg.gEvento = "FunValidaPctExcLimInf"

        FunValidaPctExcLimInf = True

        Try

            If txtPctExeLI.Text = "" Or Not IsNumeric(txtPctExeLI.Text) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '012 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunValidaLimInf() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Límite Inferior, Ingresar un Límite Válido ", 1)
                '------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtLimInf.Select()
                Exit Sub
            End If

            If FunValidaLimSup() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Límite Superior, Ingresar un Límite Válido ", 1)
                '------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtLimSup.Select()
                Exit Sub
            End If

            If FunValidaCuotaFija() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en la Cuota Fija, Ingresar una Cuota Fija Válida ", 1)
                '------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtCuotaFija.Select()
                Exit Sub
            End If

            If FunValidaPctExcLimInf() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el % Excedente Límite Inferior, Ingresar un % Excedente Válido ", 1)
                '-----------------------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtPctExeLI.Select()
                Exit Sub
            End If

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '013 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '014 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '015 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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

Public Class FoEdos

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foEdos"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub FoEdos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "FoEdos_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub FoEdos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "FoEdos_FormClosed"

        Try


            'Habilita la opcion de menu del formulario
            MDIPrincipal.tsbEstados.Enabled = True
            MDIPrincipal.mnEstados.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub TsbPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "TsbPrimero_Click"

        bsEdos.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub TsbPrevio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "TsbPrevio_Click"

        bsEdos.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub TsbSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "TsbSiguiente_Click"

        bsEdos.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro 
    Private Sub TsbUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "TsbUltimo_Click"

        bsEdos.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub TsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click

        vg.gEvento = "TsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub DgEstados_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgEstados.Click

        vg.gEvento = "DgEstados_Click"

        Call SubHabiltaBotones()
        '-----------------------

        Try

            Call SubMenOK(" Clave: " & txtCve.Text & " Estado : " & txtEstado.Text & " Seleccionado ", 1)
            '--------------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 Evento ejecuta [SubInserta] para insertar un nuevo registro
    Private Sub TsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click

        vg.gEvento = "TsbAgregar_Click"

        Call SubInserta()
        '----------------

    End Sub

    '010 Evento que Cancela la edicion del registro
    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click

        vg.gEvento = "tsbCancelar_Click"

        bsEdos.CancelEdit()
        Close()

    End Sub

    '011 Evento ejecuta [SubGuardar] para guardar un nuevo registro
    Private Sub TsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "TsbGuardar_Click"

        Call SubGuardar()
        '----------------

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '012 Evento ejecuta [SubBorrar] para borrar un nuevo registro
    Private Sub TsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBorrar.Click

        vg.gEvento = "TsbBorrar_Click"

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

    '014 Evento ejecuta [SubFiltraCve] Filtra por Cve
    Private Sub BtnFillCve_Click(sender As Object, e As EventArgs) Handles BtnFillCve.Click

        vg.gEvento = "BtnFillCve_Click"

        Call SubFiltraCve()
        '------------------

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

            'Habilita botones
            tsbValidar.Enabled = True
        tsbAgregar.Enabled = False

        txtCve.Select()

        'Agrega registro
        bsEdos.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información del Nuevo Estado (Clave y Nombre del Estado)"
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

            bsEdos.EndEdit()
            EstadosMxTableAdapter.Update(DsCatalogos.EstadosMx)

            vg.gMensaje = " Estado y Cve Actualizado en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = "Error en Guardar Estado y Cve en la Base de Datos"
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

    '003 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        Dim vCveBorrar As String

        vg.gEvento = "SubBorra"

        Try

            vCveBorrar = txtCve.Text & "-" & txtEstado.Text

            vg.gMensaje = "Desea Eliminar el Estado y Clave: " & vCveBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then

                bsEdos.RemoveCurrent()
                bsEdos.EndEdit()

                EstadosMxTableAdapter.Update(DsCatalogos.EstadosMx)

                vg.gMensaje = "Se Elimino el Estado y Clave en la Base de Datos: " & vCveBorrar
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

                vg.gMensaje = "NO Se Elimino el Estado y Clave en la Base de Datos:  " & vCveBorrar
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
            EstadosMxTableAdapter.Fill(DsCatalogos.EstadosMx)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Estados de México"
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

                .txtCve.Text = ""
                .txtEstado.Text = ""

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

    '007 SUB [SubFiltraCv] Filtra Año Pension
    Sub SubFiltraCve()

        vg.gEvento = "SubFiltraCve"

        Try
            EstadosMxTableAdapter.FillByCve(DsCatalogos.EstadosMx, txtCveFiltro.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)


        End Try

    End Sub

    '008 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        txtCveFiltro.Clear()

        Try
            EstadosMxTableAdapter.Fill(DsCatalogos.EstadosMx)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)


        End Try

    End Sub

    '009 FUN [FunValidaCve] Valida la CVE
    Function FunValidaCve() As Boolean

        vg.gEvento = "FunValidaCve"

        FunValidaCve = False

        Try


            If Len(txtCve.Text) <> 2 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '010 FUN [FunbValidaEstado] Valida el Estado
    Function FunbValidaEstado() As Boolean

        vg.gEvento = "FunbValidaEstado"
        FunbValidaEstado = False

        Try

            If Len(txtEstado.Text) = 0 Or txtEstado.Text = "" Then
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

        Try

            If FunValidaCve Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Clave de Estado, Debe de Ser de 2 Letras ", 1)
                '-------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtCve.Select()
                Exit Sub
            End If

            If FunbValidaEstado() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Nombre de Estado, Ingresar un Estado Correcto ", 1)
                '------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtEstado.Select()
                Exit Sub
            End If

            'Convierte a mayusculas
            txtCve.Text = UCase(txtCve.Text)

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

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


End Class
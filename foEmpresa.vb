Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports Catalogos.dsCatalogosTableAdapters

Public Class foEmpresa

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foEmpresa"
    Public gCreaBitacora As Boolean = True

    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Simulador IMSS 73-97\BaseDatos\Catalogos.accdb")
    'Public conA As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Simulador IMSS 73-97\BaseDatos\Asegurados.accdb")
    Public conA As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Simulador IMSS 73-97\BaseDatos\Pensiones.accdb")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public SQL As String = ""

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vg.gEvento = "foEmpresa_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foEmpresa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foEmpresa_FormClosed"

        Try

            'Habilita la opcion de menu del formualario
            MDIPrincipal.mnDatosEmpresa.Enabled = True
            MDIPrincipal.tsbEmpresa.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click("

        bsDespacho.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsDespacho.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsDespacho.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsDespacho.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub foEmpresa_Click(sender As Object, e As EventArgs) Handles MyBase.Click

        vg.gEvento = "foEmpresa_Clic"

        Call SubHabiltaBotones()
        '-----------------------

    End Sub

    '009 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub txtRazonSocial_Click(sender As Object, e As EventArgs)

        vg.gEvento = "txtRazonSocial_Click"

        Call SubHabiltaBotones()
        '-----------------------

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

        bsDespacho.CancelEdit()
        Close()

    End Sub

    '012 Evento ejecuta [SubGuardar] para guardar un nuevo registro
    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        vg.gEvento = "tsbGuardar_Click"

        Call SubGuardar()
        '----------------

    End Sub

    '013 Evento ejecuta [SubBorrar] para borrar un nuevo registro
    Private Sub tsbBorrar_Click(sender As Object, e As EventArgs) Handles tsbBorrar.Click

        vg.gEvento = "tsbBorrar_Click"

        Call SubBorra()
        '--------------

    End Sub

    '014 Evento ejecuta [SubValidaDatos] para validar los datos
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        vg.gEvento = "tsbValidar_Click"

        Call SubMenOK(" Validando .... Espere", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            Call SubCargaEdoOrigen()
            '-----------------------

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = True
            tsbValidar.Enabled = True


            'Acceso a BD Empresa
            Me.DespachoTableAdapter.FillByActivo(Me.DsPensiones.Despacho, "S")


            'Formato al titulo
            lblTitulo.Select()

            'formato a la barra de estatus
            Call SubMenOK(" Ingrese la Información Requerida ", 1)
            '-----------------------------------------------------


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 Sub [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            txtRazonSocial.Clear()
            txtDireccion.Clear()
            txtNumero.Clear()
            txtColonia.Clear()
            txtCP.Clear()
            cboEstado.Text = ""
            txtTel.Clear()
            txtCelular.Clear()
            txtEmail.Clear()
            txtWeb.Clear()
            txtSlogan.Clear()
            txtWhatsApp.Clear()
            txtYoutube.Clear()
            txtFacebook.Clear()
            txtInstagram.Clear()
            txtTikTok.Clear()


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 SUB [SubCargaEdoOrigen] Llena combo Estado de Origen
    Sub SubCargaEdoOrigen()

        vg.gEvento = "SubCargaEdoOrigen"

        Dim vEdoOri As String
        Dim vTabla As New DataTable
        Dim vSQL As String = "SELECT Estado FROM EstadosMX ORDER BY Estado ASC;"
        Dim vAdp As New OleDbDataAdapter(vSQL, con)

        Try

            vAdp.Fill(vTabla)
            cboEstado.DataSource = vTabla
            cboEstado.DisplayMember = "Estado"
            cboEstado.ValueMember = "Estado"

            vEdoOri = cboEstado.Text

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita botones
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            txtRazonSocial.Select()

            'Agrega registro
            bsDespacho.AddNew()

            'Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información del Despacho de Asesoria en Pensiones"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsDespacho.EndEdit()
            DespachoTableAdapter.Update(DsPensiones.Despacho)

            vg.gMensaje = " Despacho de Asesores Actualizada en Base de Datos "
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = "Error en Guardar Despacho de Asesores en Base de Datos"
            Call mUniversal.SubMsgCritical(vg.gMensaje, Me, 5)
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

    '006 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        vg.gEvento = "SubBorra"

        Dim vDespacho As String

        Try

            vDespacho = txtRazonSocial.Text

            vg.gMensaje = "Desea Eliminar el Despacho de Asesores : " & vDespacho & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()

            If vg.gSi Then

                bsDespacho.RemoveCurrent()
                bsDespacho.EndEdit()
                DespachoTableAdapter.Update(DsPensiones.Despacho)

                vg.gMensaje = "Se Elimino el Despacho en la Base de Datos: " & vDespacho
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

                vg.gMensaje = "NO Se Elimino el Despacho en la Base de Datos: " & vDespacho
                Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
                '-----------------------------------------------

            End If

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

            Call SubMenOK(" Despacho: " & txtRazonSocial.Text & " Seleccionado ", 1)
            '-----------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try


            If FunValidaRazonSocial Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Razón Social, Ingresar una Razón Social Valido ", 1)
                '-------------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                txtRazonSocial.Select()
                Exit Sub
            End If

            tsbGuardar.Enabled = True

            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 SUB [FunValidaRazonSocial] validar despacho
    Function FunValidaRazonSocial() As Boolean

        vg.gEvento = "FunValidaRazonSocial"

        FunValidaRazonSocial = True

        Try


            If txtRazonSocial.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '010 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '011 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '012 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
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
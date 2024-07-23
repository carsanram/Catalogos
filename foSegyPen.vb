Imports System.Data.OleDb

Public Class foSegyPen

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foSegyPen"
    Public gCreaBitacora As Boolean = True

    'Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\CalPension73-97\BaseDatos\Catalogos.accdb")
    'Public cmd As New OleDb.OleDbCommand
    'Public dr As OleDb.OleDbDataReader
    'Public SQL As String = ""

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foSegyPen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vg.gEvento = "foSegyPen_Load"

        Call SubCargaLey()
        '-----------------

        Call SubCargaSeguro()
        '--------------------

        Call SubCargaPension()
        '---------------------

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foSegyPen_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        vg.gEvento = "foSegyPen_FormClosed"

        Try

            'Habilita la opcion de menu del formualario
            MDIPrincipal.mnSyP.Enabled = True
            MDIPrincipal.tsbSegyPen.Enabled = True
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsLeySegPen.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsLeySegPen.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsLeySegPen.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsLeySegPen.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 Evento ejecuta [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dgLeySegPen_Click(sender As Object, e As EventArgs) Handles dgLeySegPen.Click

        vg.gEvento = "dgLeySegPen_Click"

        Call SubHabiltaBotones()
        '-----------------------

        Try

            Call SubMenOK(" Ley: " & cboLey.Text & " - Seguro: " & cboSeguro.Text & " - Pensión: " & cboPension.Text & "   Seleccionado ", 1)
            '--------------------------------------------------------------------------------------------------------------------------------

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

        bsLeySegPen.CancelEdit()
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

        vg.gEvento = "tsbBorrar_Clic"

        Call SubBorra()
        '--------------

        Call SubTodosLosRegistros()
        '--------------------------

    End Sub

    '013 Evento ejecuta [SubValidaDatos] para validar los datos
    Private Sub tsbValidar_Click(sender As Object, e As EventArgs) Handles tsbValidar.Click

        vg.gEvento = "sbValidar_Click"

        Call SubMenOK(" Validando .... Espere", 1)
        '------------------------------------------

        Call SubValidaDatos()
        '--------------------

    End Sub

    '014 Evento ejecuta [SubFiltroPorLey] Filtra por ley
    Private Sub btnFillLey_Click(sender As Object, e As EventArgs) Handles btnFillLey.Click

        vg.gEvento = "btnFillLey_Click"

        Call SubFiltroPorLey()
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

            cboLey.Select()

            'Agrega registro
            bsLeySegPen.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información de la Ley, Seguro y Pensión"
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

            bsLeySegPen.EndEdit()
            LeySegPenTableAdapter.Update(DsCatalogos.LeySegPen)

            vg.gMensaje = " Actualizado Ley, Seguro y Pensión"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 5)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = "Error en Guardar Registro en Base de Datos" & vbCrLf & ex.ToString
            Call mUniversal.SubMsgWarning(vg.gMensaje, Me, 4)
            '-------------------------------------------------

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

            Dim vLeyBorrar As String

            vLeyBorrar = cboLey.Text & "-" & cboPension.Text & "-" & cboSeguro.Text

            vg.gMensaje = "Desea Eliminar Ley-Seguro-Pension: " & vLeyBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then

                bsLeySegPen.RemoveCurrent()
                bsLeySegPen.EndEdit()

                LeySegPenTableAdapter.Update(DsCatalogos.LeySegPen)

                vg.gMensaje = "Se Elimino la Ley-Seguro-Pension en la Base de Datos: " & vLeyBorrar
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

                vg.gMensaje = "NO se Elimino la Ley-Seguro-Pension en la base de datos: " & vLeyBorrar
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
            LeySegPenTableAdapter.Fill(DsCatalogos.LeySegPen)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Ley, Seguros y Pensiones IMSS"
            lblTitulo.Select()

            'formato a la barra de estatus
            Call SubMenOK("Ingrese la Información Requerida", 1)
            '--------------------------------------------------

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

                .cboLey.Text = ""
                .cboSeguro.Text = ""
                .cboPension.Text = ""

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

    '007 SUB [SubCargaLey] Llena el Conbo Ley
    Sub SubCargaLey()

        vg.gEvento = "SubCargaLey"

        Try

            Dim vTabla As New DataTable
            Dim vSQL As String = "SELECT Ley FROM LeyIMSS;"
            Dim vAdp As New OleDbDataAdapter(vSQL, conCa)

            vAdp.Fill(vTabla)

            cboLey.DataSource = vTabla
            cboLey.DisplayMember = "Ley"
            cboLey.ValueMember = "Ley"

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [SubCargaSeguro] Llena el Combo Seguro
    Sub SubCargaSeguro()

        vg.gEvento = "SubCargaSeguro"

        Try

            Dim vTabla As New DataTable
            Dim vSQL As String = "SELECT Seguro FROM Seguro;"
            Dim vAdp As New OleDbDataAdapter(vSQL, conCa)

            'Me.cboSeguro.cl
            vAdp.Fill(vTabla)

            cboSeguro.DataSource = vTabla
            cboSeguro.DisplayMember = "Seguro"
            cboSeguro.ValueMember = "Seguro"

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 SUB [SubCargaPension] Llena el Combo Pension
    Sub SubCargaPension()

        vg.gEvento = "SubCargaPension"

        Try

            Dim vTabla As New DataTable
            Dim vSQL As String = "SELECT Pension FROM Pension;"

            Dim vAdp As New OleDbDataAdapter(vSQL, conCa)

            vAdp.Fill(vTabla)

            cboPension.DataSource = vTabla
            cboPension.DisplayMember = "Pension"
            cboPension.ValueMember = "Pension"
        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 SUB [SubFiltroPorLey] Filtra por Ley
    Sub SubFiltroPorLey()

        vg.gEvento = "SubFiltroPorLe"

        Try
            LeySegPenTableAdapter.FillByLey(DsCatalogos.LeySegPen, txtFillLey.Text)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '011 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        Try

            LeySegPenTableAdapter.Fill(DsCatalogos.LeySegPen)


        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '012 FUN [FunValidaLey] Valida la Ley
    Function FunValidaLey() As Boolean

        vg.gEvento = "FunValidaLey"
        FunValidaLey = False

        Try

            FunValidaLey = True

            If cboLey.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '013 FUN [FunValidaSeguro] Valida el Seguro
    Function FunValidaSeguro() As Boolean

        vg.gEvento = "FunValidaSeguro"
        FunValidaSeguro = False

        Try

            FunValidaSeguro = True

            If cboSeguro.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '014 FUN [FunValidaPension] Valida a Pension
    Function FunValidaPension() As Boolean

        vg.gEvento = "FunValidaPension"
        FunValidaPension = False

        Try

            FunValidaPension = True

            If cboPension.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '015 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunValidaLey() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en la Ley, Seleccionar una Ley Válida ", 1)
                '-------------------------------------------------------------------
                tsbGuardar.Enabled = False
                cboLey.Select()
                Exit Sub
            End If

            If FunValidaSeguro Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Seguro, Seleccionar un Seguro Válido ", 1)
                '------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                cboSeguro.Select()
                Exit Sub
            End If

            If FunValidaPension Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en la Pensión, Seleccionar una Pensión Válida ", 1)
                '--------------------------------------------------------------------------
                tsbGuardar.Enabled = False
                cboPension.Select()
                Exit Sub
            End If

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
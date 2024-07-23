'Imports Catalogos.dsCatalogosTableAdapters

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Catalogos.dsCatalogosTableAdapters
Imports Microsoft.Office.Interop.Excel

Public Class foPrimaRT

    'Variables Globales del Formulario
    Public vNameApp As String = "Catálogos"
    Public gNomFormulario As String = "foPrimaRT"
    Public gCreaBitacora As Boolean = True

    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS --------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 Evento ejecuta [SubCargaFormulario] para carga de formulario
    Private Sub foPrimaRT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vg.gEvento = "foPrimaRT_Load"

        Call SubCargaFormulario()
        '------------------------

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foPrimaRT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Try
            vg.gEvento = "foPrimaRT_FormClosed"

            'Habilita la opcion de menu del formulario
            mdiprincipal.tsmiPrimaRiesgoTrabajoTI.Enabled = True
            mdiprincipal.mnPrimaRiesgoTrabajoTI.Enabled = True

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '003 Evento mueve al primer registro
    Private Sub tsbPrimero_Click(sender As Object, e As EventArgs) Handles tsbPrimero.Click

        vg.gEvento = "tsbPrimero_Click"

        bsPrimaRT.MoveFirst()

    End Sub

    '004 Evento mueve al registro previo
    Private Sub tsbPrevio_Click(sender As Object, e As EventArgs) Handles tsbPrevio.Click

        vg.gEvento = "tsbPrevio_Click"

        bsPrimaRT.MovePrevious()

    End Sub

    '005 Evento mueve al registro siguiente
    Private Sub tsbSiguiente_Click(sender As Object, e As EventArgs) Handles tsbSiguiente.Click

        vg.gEvento = "tsbSiguiente_Click"

        bsPrimaRT.MoveNext()

    End Sub

    '006 Evento mueve al ultimo registro
    Private Sub tsbUltimo_Click(sender As Object, e As EventArgs) Handles tsbUltimo.Click

        vg.gEvento = "tsbUltimo_Click"

        bsPrimaRT.MoveLast()

    End Sub

    '007 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '008 SUB [SubHabiltaBotones] para habilita botones pera guardar y eliminar
    Private Sub dsPrima_Click(sender As Object, e As EventArgs) Handles dsPrima.Click

        vg.gEvento = "dgCuantia73ar_Click"

        Try

            Call SubHabiltaBotones()
            '-----------------------

            Call SubMenOK(" Año  " & txtAño.Text & " Seleccionado ", 1)
            '-----------------------------------------------------------------------------

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

        bsPrimaRT.CancelEdit()

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

    '014 Evento ejecuta [SubFiltroAño] Filtra por Año
    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click

        vg.gEvento = "btnFiltro_Click"

        Call SubFiltroAño()


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

    '000 SUB [SubCargaFormulario] para carga de formulario
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            'Inhabilita el botones de Guardar y Borrar
            tsbGuardar.Enabled = False
            tsbBorrar.Enabled = False
            tsbValidar.Enabled = False

            'Asugna datos
            nudOrigen.Value = Now.Year
            nudDestino.Value = Now.Year + 1

            'Inicia el llenado del grid
            PrimaRiesgoTrabajoTableAdapter.Fill(dsCatalogos.PrimaRiesgoTrabajo)

            'Formato al titulo
            lblTitulo.Text = "Catálogo: Primas de Riesgo de Trabajo TI"
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

    '001 SUB [SubLimpiaDatos] Limpia los datos de la pantalla
    Sub SubLimpiaDatos()

        vg.gEvento = "SubLimpiaDatos"

        Try

            With Me

                .txtAño.Text = ""
                '.cboClase.Text = ""
                .txtPrima.Text = ""
                .txtDescripcion.Text = ""
                .txtAñoBus.Text = ""

            End With

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenError"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '003 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenOK"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '004 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenWarning(pMensaje As String, pPausa As Integer)

        vg.gEvento = "SubMenWarning"

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(247, 172, 8)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '005 SUB [SubBorrar] para borrar un nuevo registro
    Sub SubBorra()

        Dim vCuantiaBorrar As String

        vg.gEvento = "SubBorra"

        Try

            vCuantiaBorrar = txtPrima.Text


            vg.gMensaje = "Desea Eliminar la Prima de Riesgo de Trabajo: " & vCuantiaBorrar & " ?"
            gMet.FunAvisoBTN(foAvisoBTN, psTypeIcono.icoQuestion, vg.gMensaje, True, True, True)
            foAvisoBTN.ShowDialog()


            If vg.gSi Then


                bsPrimaRT.RemoveCurrent()
                bsPrimaRT.EndEdit()

                PrimaRiesgoTrabajoTableAdapter.Update(dsCatalogos.PrimaRiesgoTrabajo)

                vg.gMensaje = "Se Elimino el Registro de Prima de Riesgo de Trabajo en la Base de Datos: " & vCuantiaBorrar
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

                vg.gMensaje = "NO Se Elimino el Registro de Prima de Riesgo de Trabajo en la Base de Datos " & vCuantiaBorrar
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


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [SubValidaDatos] validar los datos requerido
    Sub SubValidaDatos()

        vg.gEvento = "SubValidaDatos"

        Try

            If FunValidaAño() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en el Año, Ingrese un Año Válido", 1)
                '-------------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtAño.Select()
                Exit Sub
            End If

            If FunValidaClase() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError("  Error en la Clase del Riesgo de Trabajo TI, Seleccione una Clase Válida ", 1)
                '---------------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtAño.Select()
                Exit Sub
            End If

            If FunValidaPrima() Then
                tsbGuardar.Enabled = True
            Else
                Call SubMenError(" Error en Prima de Riesgo de Trabajo, Ingrese una válida ", 1)
                '------------------------------------------------------------------------------

                tsbGuardar.Enabled = False
                txtPrima.Select()
                Exit Sub
            End If



            Call SubMenOK(" Información Validada, Clik Botón [Guardar] para Guardar los Cambios ", 1)
            '----------------------------------------------------------------------------------------

            tsbGuardar.Enabled = True


        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [FunValidaAño] Valida llimite inferior
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

    '009 SUB [FunValidaClase] Valida llimite inferior
    Function FunValidaClase() As Boolean

        vg.gEvento = "FunValidaLimInferior"

        FunValidaClase = True

        Try

            If cboClase.Text = "" Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '010 SUB [FunValidaPrima] Valida Prima RT
    Function FunValidaPrima() As Boolean

        vg.gEvento = "FunValidaClase"

        FunValidaPrima = True

        Try

            If txtPrima.Text = "" Or Not (IsNumeric(txtPrima.Text)) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Function

    '011 SUB [SubInserta] para insertar un nuevo registro
    Sub SubInserta()

        vg.gEvento = "SubInserta"

        Try

            'Habilita el boton Validar
            tsbValidar.Enabled = True
            tsbAgregar.Enabled = False

            txtAño.Select()

            'Agrega registro
            bsPrimaRT.AddNew()

            Call SubLimpiaDatos()
            '--------------------

            'Mensaje de alta
            vg.gMensaje = " Ingrese la Información de la Prima de Riesgo de Trabajo"
            Call mUniversal.SubMsgNormal(vg.gMensaje, Me, 5)
            '-----------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '012 SUB [SubGuardar] para guardar un nuevo registro
    Sub SubGuardar()

        vg.gEvento = "SubGuardar"

        Try

            bsPrimaRT.EndEdit()
            PrimaRiesgoTrabajoTableAdapter.Update(dsCatalogos.PrimaRiesgoTrabajo)

            vg.gMensaje = " La Prima de Riesgo de Trabajo fue Actualizada en Base de Datos"
            Call mUniversal.SubMsgYes(vg.gMensaje, Me, 4)
            '--------------------------------------------

        Catch ex As Exception

            vg.gMensaje = " Error en Guardar Prima de Riesgo de Trabajo en la Base de Datos "
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

    '013 SUB [SubTodosLosRegistros] Muestra todos los registros
    Sub SubTodosLosRegistros()

        vg.gEvento = "SubTodosLosRegistros"

        txtAñoBus.Text = ""

        Try

            PrimaRiesgoTrabajoTableAdapter.Fill(dsCatalogos.PrimaRiesgoTrabajo)

        Catch ex As System.Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

        lblTitulo.Select()

    End Sub

    '013 SUB [SubFiltroAño] Filtra informmacion por Año
    Sub SubFiltroAño()

        Dim vAño As Integer

        vAño = txtAñoBus.Text

        vg.gEvento = "SubFiltroPorLimSuperior"

        Try

            PrimaRiesgoTrabajoTableAdapter.FillByAño(dsCatalogos.PrimaRiesgoTrabajo, vAño)

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Call SubMenOK(" Borrando Primas de Riesgo de Trabajo .... Espere", 2)
        '----------------------------------------------------

        Call SubBorraPrimas()
        '------------------

        Call SubInsertaPrimas()
        '------------------

        Call SubTodosLosRegistros()
        '--------------------------


    End Sub

    Sub SubBorraPrimas()

        Dim i As Integer = 0
        Dim vAñoIni As Integer = 0
        Dim vAñoFin As Integer = 0
        'Dim vAñoProcesar As Integer = 0

        vg.gEvento = "SubBorraPrimas"

        'Toma el rango de años a borrar
        vAñoIni = nudOrigen.Value
        vAñoFin = nudDestino.Value

        Try

            cmd.CommandType = CommandType.Text
            cmd.Connection = conCa

            SQL = "DELETE FROM PrimaRiesgoTrabajo WHERE Año = " & vAñoFin & ";"

            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()



            Call SubMenOK(" Se Eliminaron las Primas de Riesgo de Trabajo de TI del " & vAñoFin, 2)
            '-----------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    Sub SubInsertaPrimas()

        vg.gEvento = "SubInsertaPrimas"

        Dim vAño As Integer = 0
        Dim vAñoDestino As Integer = 0

        Dim vClase As String = ""
        Dim vPrima As Double = 0
        Dim vDescripcion = ""

        Dim i As Integer = 0

        Try
            'Año Copia
            vAño = nudOrigen.Value
            vAñoDestino = nudDestino.Value

            cmd.CommandType = CommandType.Text
            cmd.Connection = conCa

            Call SubMenOK(" Insertando la Prima de Riesgo de Trabajo del Año " & vAñoDestino, 2)
            '-----------------------------------------------------------------------------------

            For i = 1 To 5

                Select Case i
                    Case 1
                        vClase = "I"
                        vDescripcion = "Actividades con menor riesgo de trabajo"
                    Case 2
                        vClase = "II"
                        vDescripcion = "Actividades con medio riesgo medio de trabajo"

                    Case 3
                        vClase = "III"
                        vDescripcion = "Actividades con medio alto riesgo de trabajo"
                    Case 4
                        vClase = "IV"
                        vDescripcion = "Actividades con alto riesgo de trabajo"
                    Case 5
                        vClase = "V"
                        vDescripcion = "Actividades con muy alto riesgo de trabajo"

                End Select

                vPrima = ConsultasBD.FunGetPrimaRT(vAño, vClase)

                SQL = "INSERT INTO PrimaRiesgoTRabajo (Año,Clase,Prima,Descripcion)"
                SQL = SQL & " VALUES (" & vAñoDestino & ",'" & vClase & "'," & vPrima & ",'" & vDescripcion & "');"

                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()


            Next

            Call SubMenOK(" Se Termino de Insertar  Prima de Riesgo de Trabajo del Año " & vAñoDestino, 2)
            '-----------------------------------------------------------------------------------

            Call SubMenOK(" Seleccione la Accion que Desee Realizar ", 2)
            '-----------------------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub


End Class
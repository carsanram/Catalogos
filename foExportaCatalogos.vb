Imports Catalogos.dsCatalogosTableAdapters
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports Microsoft.SqlServer.Server

Public Class foExportaCatalogos

    'Variables Gllobales del Formulario
    Public vNameApp As String = "Asegurados"
    Public gNomFormulario As String = "foExportar"
    Public gCreaBitacora As Boolean = True

    'Variables para conocer que se exportara a Excel
    Public bAfores As Boolean = False
    Public bCuantias73AR As Boolean = False
    Public bCuantias73 As Boolean = False
    Public bCuantias97 As Boolean = False
    Public bTopados As Boolean = False
    Public bDelegacion As Boolean = False
    Public bEstados As Boolean = False
    Public bINPC As Boolean = False
    Public bINEGI As Boolean = False
    Public bISR As Boolean = False
    Public bPctM40 As Boolean = False
    Public bSegPen As Boolean = False
    Public bUMA As Boolean = False
    Public bDespacho As Boolean = False
    Public bModalidades As Boolean = False
    Public bRTPrima As Boolean = False
    Public bM33 As Boolean = False
    Public bActTI As Boolean = False


    '----------------------------------------------------------------------------------------------------------------------------
    '----- EVENTOS 022 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 FUN [SubCargaFormulario] Carga Formulario
    Private Sub foExportaCatalogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        vg.gEvento = "foExportar_Load"

        Try

            Call SubCargaFormulario()
            '------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 Evento Habilita Opciones del Menu Principal
    Private Sub foExportaCatalogos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        mdiprincipal.tsmExportarCatalogosAExcel.Enabled = True

    End Sub

    '003 Evento cierra el formulario
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click

        vg.gEvento = "tsbSalir_Click"

        Close()

    End Sub

    '004 Evento checa Afores
    Private Sub chkAfores_CheckedChanged(sender As Object, e As EventArgs) Handles chkAfores.CheckedChanged

        Try

            If chkAfores.Checked Then
                bAfores = True
            Else
                bAfores = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 Evento checa cuantias 73 antes reforma
    Private Sub chkCuantias73AR_CheckedChanged(sender As Object, e As EventArgs) Handles chkCuantias73AR.CheckedChanged

        Try

            If chkCuantias73AR.Checked Then
                bCuantias73AR = True
            Else
                bCuantias73AR = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 Evento checa cuantias 73 despues reforma
    Private Sub chkCuantias73_CheckedChanged(sender As Object, e As EventArgs) Handles chkCuantias73.CheckedChanged
        Try

            If chkCuantias73.Checked Then
                bCuantias73 = True
            Else
                bCuantias73 = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try
    End Sub

    '007 Evento checa cuantias 97
    Private Sub chkCuantias97_CheckedChanged(sender As Object, e As EventArgs) Handles chkCuantias97.CheckedChanged

        Try

            If chkCuantias97.Checked Then
                bCuantias97 = True
            Else
                bCuantias97 = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 Evento checa cuantias Topados
    Private Sub chkTopados_CheckedChanged(sender As Object, e As EventArgs) Handles chkTopados.CheckedChanged

        Try

            If chkTopados.Checked Then
                bTopados = True
            Else
                bTopados = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 Evento checa Unidades medicina familiar
    Private Sub chkDelegacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelegacion.CheckedChanged
        Try

            If chkDelegacion.Checked Then
                bDelegacion = True
            Else
                bDelegacion = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 Evento checa estados mexico
    Private Sub chkEstados_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstados.CheckedChanged

        Try

            If chkEstados.Checked Then
                bEstados = True
            Else
                bEstados = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '011 Evento checa INPC
    Private Sub chkINPC_CheckedChanged(sender As Object, e As EventArgs) Handles chkINPC.CheckedChanged

        Try

            If chkINPC.Checked Then
                bINPC = True
            Else
                bINPC = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '012 Evento checa INEGI
    Private Sub chkINEGI_CheckedChanged(sender As Object, e As EventArgs) Handles chkINEGI.CheckedChanged

        Try

            If chkINEGI.Checked Then
                bINEGI = True
            Else
                bINEGI = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '013 Evento checa ISR
    Private Sub chkISR_CheckedChanged(sender As Object, e As EventArgs) Handles chkISR.CheckedChanged

        Try

            If chkISR.Checked Then
                bISR = True
            Else
                bISR = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '014 Evento checa % M40
    Private Sub chkPctM40_CheckedChanged(sender As Object, e As EventArgs) Handles chkPctM40.CheckedChanged

        Try

            If chkPctM40.Checked Then
                bPctM40 = True
            Else
                bPctM40 = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '015 Evento checa Seguros y pensions
    Private Sub chkSegPen_CheckedChanged(sender As Object, e As EventArgs) Handles chkSegPen.CheckedChanged

        Try

            If chkSegPen.Checked Then
                bSegPen = True
            Else
                bSegPen = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '016 Evento checa UMA
    Private Sub chkUMA_CheckedChanged(sender As Object, e As EventArgs) Handles chkUMA.CheckedChanged

        Try

            If chkUMA.Checked Then
                bUMA = True
            Else
                bUMA = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '017 Evento checa Despacho
    Private Sub chkDespacho_CheckedChanged(sender As Object, e As EventArgs) Handles chkDespacho.CheckedChanged

        Try

            If chkDespacho.Checked Then
                bDespacho = True
            Else
                bDespacho = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '018 Evento checa modalidades
    Private Sub chkModalidades_CheckedChanged(sender As Object, e As EventArgs) Handles chkModalidades.CheckedChanged

        Try

            If chkModalidades.Checked Then
                bModalidades = True
            Else
                bModalidades = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '019 Evento checa prima RT TI
    Private Sub chkRTPrima_CheckedChanged(sender As Object, e As EventArgs) Handles chkRTPrima.CheckedChanged

        Try

            If chkRTPrima.Checked Then
                bRTPrima = True
            Else
                bRTPrima = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '020 Evento checa actividades TI
    Private Sub chkActividadesTI_CheckedChanged(sender As Object, e As EventArgs) Handles chkActividadesTI.CheckedChanged


        Try

            If chkActividadesTI.Checked Then
                bActTI = True
            Else
                bActTI = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '021 Evento checa cuotas m33
    Private Sub chkM33_CheckedChanged(sender As Object, e As EventArgs) Handles chkM33.CheckedChanged
        Try

            If chkM33.Checked Then
                bM33 = True
            Else
                bM33 = False
            End If

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '022 Evento ejecuta [ SubExportaExcel ] para exportar a Excel
    Private Sub tsbExcel_Click(sender As Object, e As EventArgs) Handles tsbExcel.Click

        vg.gEvento = "tsbExcel_Click"

        Call SubMenOK(" Exportando a Excel .... Espere", 1)
        '---------------------------------------------------


        Call SubCreaLibroExcel()
        '-----------------------

        Call SubMenOK(" Exportando a Excel Terminada", 2)
        '------------------------------------------------

        tsbExcel.Enabled = False

        Call SubMenOK(" Seleccione las Opciones que Desee Exportar a Excel ", 1)
        '-----------------------------------------------------------------------

    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '----- METODOS 024 ----------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

    '001 SUB [ SubCargaFormulario ] carga y configura el formulario inicialmente
    Sub SubCargaFormulario()

        vg.gEvento = "SubCargaFormulario"

        Try

            AforesTableAdapter.Fill(DsCatalogos.Afores)
            CuantiasLey1973arTableAdapter.Fill(DsCatalogos.CuantiasLey1973ar)
            CuantiasLey1973TableAdapter.Fill(DsCatalogos.CuantiasLey1973)
            CuantiasLey1997TableAdapter.Fill(DsCatalogos.CuantiasLey1997)
            TopadoSMG_UMATableAdapter.Fill(DsCatalogos._TopadoSMG_UMA)
            EstadosMxTableAdapter.Fill(DsCatalogos.EstadosMx)
            UMFTableAdapter.Fill(DsCatalogos.UMF)
            INPCTableAdapter.Fill(DsCatalogos.INPC)
            InflacionAnualTableAdapter.Fill(DsCatalogos.InflacionAnual)
            ISRTableAdapter.Fill(DsCatalogos.ISR)
            PctSegurosM40TableAdapter.Fill(DsCatalogos.PctSegurosM40)
            RegimenIMSSTableAdapter.Fill(DsCatalogos.RegimenIMSS)
            UMATableAdapter.Fill(DsCatalogos.UMA)
            DespachoTableAdapter.Fill(DsCatalogos.Despacho)
            LeySegPenTableAdapter.Fill(DsCatalogos.LeySegPen)
            ActividadesTableAdapter.Fill(Me.DsCatalogos.Actividades)
            Modalidad33TableAdapter.Fill(Me.DsCatalogos.Modalidad33)
            PrimaRiesgoTrabajoTableAdapter.Fill(Me.DsCatalogos.PrimaRiesgoTrabajo)

            'formato a la barra de estatus
            Call SubMenOK(" Seleccione las Opciones que Desee Exportar a Excel ", 1)
            '-----------------------------------------------------------------------

        Catch ex As Exception

            MsgBox("Error en " & gNomFormulario & "." & gEvento & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '002 SUB [ SubCreaLibroExcel ] Drive para exportar datos del asegurado seleccionado
    Sub SubCreaLibroExcel()

        Dim vHoja As Integer = 0

        Try
            vg.gEvento = "SubCreaLibroExcel"

            vg.gMensaje = "Creando Excel con Informacion de los Catalogo"
            mUniversal.SubMsgYesPause(vg.gMensaje, Me)

            'Habilita un objeto de Excel
            Dim ExcelApp = New Microsoft.Office.Interop.Excel.Application
            'Libro de Excel
            Dim Libro = ExcelApp.Workbooks.Add

            'Crea hoja Afores
            If bAfores Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Afores"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaAfores(Libro, vHoja)
                '-----------------------------------
            End If
            'Crea hoja Cuantias Ley 73 AR
            If bCuantias73AR Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Cuantias Ley 73 AR"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaCuantia73AR(Libro, vHoja)
                '-------------------------------
            End If
            'Crea hoja Cuantias Ley 73
            If bCuantias73 Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Cuantias Ley 73"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaCuantias73(Libro, vHoja)
                '-----------------------------
            End If
            'Crea hoja Cuantias Ley 97
            If bCuantias97 Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Cuantias Ley 97 PG"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaCuantias97(Libro, vHoja)
                '--------------------------------
            End If
            'Crea Hoja SBC Topado
            If bTopados Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "SBC Topado"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaTopados(Libro, vHoja)
                '-----------------------------
            End If

            'Crea Hoja Delegaciones
            If bDelegacion Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Delegaciones"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaDelegaciones(Libro, vHoja)
                '------------------------------
            End If
            'Crea Hoja Estados Republica
            If bEstados Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Estados"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaEstados(Libro, vHoja)
                '------------------------------
            End If
            'Crea Hoa INPC
            If bINPC Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "INPC"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaINPC(Libro, vHoja)
                '------------------------------
            End If
            'Crea Hoja Inegi
            If bINEGI Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Inflacion Anual"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaINEGI(Libro, vHoja)
                '------------------------------
            End If
            'Crea Hoja ISR
            If bISR Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "ISR Pensiones"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubHojaISR(Libro, vHoja)
                '------------------------------
            End If
            'Crea Hoja % Modalidad 40
            If bPctM40 Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "% Modalidad 40"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubPctM40(Libro, vHoja)
                '------------------------------
            End If
            'Crea hoja Seguros y pensiones
            If bSegPen Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Ley Seguros Pensiones"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubSeg(Libro, vHoja)
                '------------------------------
            End If
            'Crea hoja UMA SMG
            If bUMA Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "UMA - SMG"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubUMA(Libro, vHoja)
                '------------------------------
            End If
            'Crea hoja Despacho
            If bDespacho Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Despacho de Asesores"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubDespacho(Libro, vHoja)
                '------------------------------
            End If
            'Crea hoja Modalidades
            If bModalidades Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Modalidades IMSS"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubModalidades(Libro, vHoja)
                '------------------------------
            End If
            'Crea hoja Prima RT
            If bRTPrima Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Prima RT TI"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubPrimaRT(Libro, vHoja)
                '------------------------------
            End If
            'Crea Cuotas M33
            If bM33 Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Cuotas Seguro Familia"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubM33(Libro, vHoja)
                '------------------------------
            End If
            'Crea Actividades y SubActividades de TI
            If bActTI Then
                vHoja = vHoja + 1
                Libro.Sheets(vHoja).name = "Actividades TI"
                Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
                Call SubActTI(Libro, vHoja)
                '------------------------------
            End If
            'Crea Hoja Notas
            vHoja = vHoja + 1

            Libro.Sheets.Add(After:=Libro.Worksheets(Libro.Worksheets.Count))
            Libro.Sheets(vHoja).name = "Notas"

            Libro.Sheets(1).select

            'Variables para el guardado del libro de Excel
            sfdExportar.DefaultExt = ".xlsx"
            sfdExportar.FileName = "Catalogos Simulador IMSS 73-97"
            sfdExportar.Filter = "Libro de Excel (*.xlsx) |  *.xlsx"

            sfdExportar.InitialDirectory = vg.gDirReportes

            'Dialogo para guardar el libro de excel
            If sfdExportar.ShowDialog = DialogResult.OK Then
                Libro.SaveAs(sfdExportar.FileName)
                'formato a la barra de estatus

                vg.gMensaje = " Se Exporto la Información de Catalogos"
                mUniversal.SubMsgNormal(vg.gMensaje, Me, 4)
                '------------------------------------------
            Else
                vg.gMensaje = " NO Se Exporto la Información de Catalogos"
                mUniversal.SubMsgWarning(vg.gMensaje, Me, 4)
                '------------------------------------------

            End If

            'Guarda el Excecl
            Libro.Saved = True
            'Descarga Excel
            ExcelApp.Quit()

            'Limpia Objetos
            Libro = Nothing
            ExcelApp = Nothing

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try


    End Sub

    '003 SUB [ SubHojaAfore ] exporta los datos Afore
    Sub SubHojaAfores(Libro, vhoja)
        vg.gEvento = "SubHojaAfores"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo de Afores "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgAfores.Rows.Count - 1
        Dim ColumnCount As Integer = dgAfores.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgAfores.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount
                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgAfores.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1

                    'Progres Bar
                    pbProceso.Value = nfila * 100 / RowCount
                    'Refresh()

                Next
                Columna = Columna + 1
                Fila = 2


            Next

            chkAfores.ForeColor = Color.Red

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:F1").select
            Libro.Worksheets(vhoja).range("A1:F1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:F1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:F1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:F1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '004 SUB [ ubHojaCuantia73AR ] exporta los datos cuantias ley 73 Antes Reforma
    Sub SubHojaCuantia73AR(Libro, vhoja)
        vg.gEvento = "SubHojaCuantias73AR"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo de Cuantias 73 AR "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgCuantia73AR.Rows.Count - 1
        Dim ColumnCount As Integer = dgCuantia73AR.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgCuantia73AR.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount
                    If nCol = 0 Or nCol = 1 Then
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = FormatCurrency(dgCuantia73AR.Rows(nfila).Cells(nCol).Value)
                    Else
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = dgCuantia73AR.Rows(nfila).Cells(nCol).Value
                    End If
                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgCuantia73AR.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1

                Next
                Columna = Columna + 1
                Fila = 2

                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()

            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:D1").select
            Libro.Worksheets(vhoja).range("A1:D1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:D1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:D1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:D1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkCuantias73AR.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '005 SUB [ SubHojaCuantias73 ] exporta los datos cuantias ley 73 despues reforma
    Sub SubHojaCuantias73(Libro, vhoja)
        vg.gEvento = "SubHojaCuantias73"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo de Cuantias 73 "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgCuantia73.Rows.Count - 1
        Dim ColumnCount As Integer = dgCuantia73.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgCuantia73.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount
                    'If nCol = 0 Or nCol = 1 Then
                    'Libro.Worksheets(vhoja).cells(Fila, Columna) = FormatCurrency(dgCuantia73AR.Rows(nfila).Cells(nCol).Value)
                    'Else
                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgCuantia73.Rows(nfila).Cells(nCol).Value
                    'End If
                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgCuantia73.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108



                    Fila = Fila + 1
                Next

                Columna = Columna + 1
                Fila = 2

                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()


            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:D1").select
            Libro.Worksheets(vhoja).range("A1:D1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:D1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:D1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:D1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkCuantias73.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '006 SUB [ SubHojaCuantias97] exporta los datos cuantias ley 97
    Sub SubHojaCuantias97(Libro, vhoja)
        vg.gEvento = "SubHojaCuantias97"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo de Cuantias 97 "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgCuantia97.Rows.Count - 1
        Dim ColumnCount As Integer = dgCuantia97.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgCuantia97.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    If nCol = 4 Then
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = FormatCurrency(dgCuantia97.Rows(nfila).Cells(nCol).Value)
                    Else
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = dgCuantia97.Rows(nfila).Cells(nCol).Value
                    End If
                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgCuantia97.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1

                Next

                Columna = Columna + 1
                Fila = 2

                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()

            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:G1").select
            Libro.Worksheets(vhoja).range("A1:G1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:G1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:G1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:G1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkCuantias97.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '007 SUB [ SubHojaEstados ] exporta los datos de los estados de mexico
    Sub SubHojaEstados(Libro, vhoja)
        vg.gEvento = "SubHojaEstados"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo de Estados "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgEstados.Rows.Count - 1
        Dim ColumnCount As Integer = dgEstados.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgEstados.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgEstados.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2

                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:B1").select
            Libro.Worksheets(vhoja).range("A1:B1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:B1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:B1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:B1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkEstados.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '008 SUB [ SubHojaTopados ] exporta los datos topados salarios
    Sub SubHojaTopados(Libro, vhoja)
        vg.gEvento = "SubHojaTopados"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo SBC Topados "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgTopados.Rows.Count - 1
        Dim ColumnCount As Integer = dgTopados.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgTopados.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgTopados.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:C1").select
            Libro.Worksheets(vhoja).range("A1:C1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:C1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:C1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:C1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkTopados.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '009 SUB [ SubHojaDelegaciones ] exporta los datos unidades de medicina familiar
    Sub SubHojaDelegaciones(Libro, vhoja)
        vg.gEvento = "SubHojaDelegaciones"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Delegaciones "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgDelegaciones.Rows.Count - 1
        Dim ColumnCount As Integer = dgDelegaciones.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgDelegaciones.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgDelegaciones.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:F1").select
            Libro.Worksheets(vhoja).range("A1:F1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:F1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:F1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:F1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkDelegacion.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '010 SUB [ SubHojaINPC ] exporta los datos INPC
    Sub SubHojaINPC(Libro, vhoja)
        vg.gEvento = "SubHojaINPC"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo INPC "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgINPC.Rows.Count - 1
        Dim ColumnCount As Integer = dgINPC.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgINPC.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgINPC.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:D1").select
            Libro.Worksheets(vhoja).range("A1:D1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:D1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:D1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:D1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkINPC.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '011 SUB [ SubHojaINEGI ] exporta los datos INEGI
    Sub SubHojaINEGI(Libro, vhoja)
        vg.gEvento = "SubHojaINEGI"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Inflacion Anual "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgINEGI.Rows.Count - 1
        Dim ColumnCount As Integer = dgINEGI.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgINEGI.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgINEGI.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2

                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:C1").select
            Libro.Worksheets(vhoja).range("A1:C1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:C1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:C1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:C1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkINEGI.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '012 SUB [ SubHojaISR ] exporta los datos ISR
    Sub SubHojaISR(Libro, vhoja)
        vg.gEvento = "SubHojaISR"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo ISR Pensiones "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgISR.Rows.Count - 1
        Dim ColumnCount As Integer = dgISR.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgISR.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    If nCol = 0 Or nCol = 1 Or nCol = 2 Then
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = FormatCurrency(dgISR.Rows(nfila).Cells(nCol).Value)
                    Else
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = dgISR.Rows(nfila).Cells(nCol).Value
                    End If
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:D1").select
            Libro.Worksheets(vhoja).range("A1:D1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:D1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:D1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:D1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkISR.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '013 SUB [ SubPctM40 ] exporta los datos % M40
    Sub SubPctM40(Libro, vhoja)
        vg.gEvento = "SuPctM40"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo % Modalidad 40 "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgPctM40.Rows.Count - 1
        Dim ColumnCount As Integer = dgPctM40.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgPctM40.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount


                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgPctM40.Rows(nfila).Cells(nCol).Value

                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:K1").select
            Libro.Worksheets(vhoja).range("A1:K1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:K1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:K1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:K1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkPctM40.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '014 SUB [ SubSeg ] exporta los datos Seguros y pensiones
    Sub SubSeg(Libro, vhoja)
        vg.gEvento = "SuSeg"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Ley, Seguros y Pensiones "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgSeguros.Rows.Count - 1
        Dim ColumnCount As Integer = dgSeguros.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgSeguros.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgSeguros.Rows(nfila).Cells(nCol).Value

                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()

            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:C1").select
            Libro.Worksheets(vhoja).range("A1:C1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:C1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:C1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:C1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkSegPen.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '015 SUB [ SubUMA ] exporta los datos de la UMA
    Sub SubUMA(Libro, vhoja)
        vg.gEvento = "SubUMA"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo UMA y SMG "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgUMA.Rows.Count - 1
        Dim ColumnCount As Integer = dgUMA.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgUMA.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    If nCol = 1 Or nCol = 2 Or nCol = 3 Or nCol = 4 Or nCol = 5 Or nCol = 6 Then
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = FormatCurrency(dgUMA.Rows(nfila).Cells(nCol).Value)
                    Else
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = dgUMA.Rows(nfila).Cells(nCol).Value
                    End If

                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:I1").select
            Libro.Worksheets(vhoja).range("A1:I1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:I1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:I1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:I1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkUMA.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '016 SUB [ SubDespacho ] exporta los datos despacho de asesores
    Sub SubDespacho(Libro, vhoja)
        vg.gEvento = "SubUMA"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Despacho de Asesores "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgDespacho.Rows.Count - 1
        Dim ColumnCount As Integer = dgDespacho.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgDespacho.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgDespacho.Rows(nfila).Cells(nCol).Value

                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:S1").select
            Libro.Worksheets(vhoja).range("A1:S1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:S1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:S1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:S1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkDespacho.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '017 SUB [ SubModalidades ] exporta los datos modalidades del IMSS
    Sub SubModalidades(Libro, vhoja)
        vg.gEvento = "SubModalidades"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Despacho de Asesores "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgModalidades.Rows.Count - 1
        Dim ColumnCount As Integer = dgModalidades.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgModalidades.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgModalidades.Rows(nfila).Cells(nCol).Value

                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:Q1").select
            Libro.Worksheets(vhoja).range("A1:Q1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:Q1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:Q1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:Q1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkModalidades.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '018 SUB [ SubPrimaRT ] exporta los datos prima de riesgos de trabajo TI
    Sub SubPrimaRT(Libro, vhoja)
        vg.gEvento = "SubPrimaRT"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Prima RT TI "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgRTPrima.Rows.Count - 1
        Dim ColumnCount As Integer = dgRTPrima.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgRTPrima.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount

                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgRTPrima.Rows(nfila).Cells(nCol).Value

                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:D1").select
            Libro.Worksheets(vhoja).range("A1:D1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:D1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:D1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:D1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkRTPrima.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '019 SUB [ SubM33 ] exporta los datos cuotas Modalidad 33
    Sub SubM33(Libro, vhoja)
        vg.gEvento = "SubM33"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Cuotas Seguro Familia "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgM33.Rows.Count - 1
        Dim ColumnCount As Integer = dgM33.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgM33.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount
                    If nCol = 3 Then
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = FormatCurrency(dgM33.Rows(nfila).Cells(nCol).Value)
                    Else
                        Libro.Worksheets(vhoja).cells(Fila, Columna) = dgM33.Rows(nfila).Cells(nCol).Value
                    End If
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:D1").select
            Libro.Worksheets(vhoja).range("A1:D1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:D1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:D1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:D1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkM33.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '020 SUB [ SubActTI ] exporta las actividades de trabajador independiente
    Sub SubActTI(Libro, vhoja)
        vg.gEvento = "SubActTI"

        'Mensaje de aviso de exportacion a Excel
        vg.gMensaje = "Exportando a Excel Catalogo Actividades y SubActividades TI "
        mUniversal.SubMsgYesPause(vg.gMensaje, Me)

        'Selecciona la hoja 1
        Libro.Sheets(vhoja).select

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        'Contador de filas y columnas
        Dim RowCount As Integer = dgActividades.Rows.Count - 1
        Dim ColumnCount As Integer = dgActividades.Columns.Count - 1

        pbProceso.Value = 0

        Try

            For nCol As Integer = 0 To ColumnCount
                'Genera el Encabezado de excel
                Libro.Worksheets(vhoja).cells(1, Columna) = dgActividades.Columns(nCol).HeaderText
                'Asigna a la cabecera negritas
                Libro.Worksheets(vhoja).cells(1, Columna).font.bold = True
                ' Libro.Worksheets(1).cells(1, Columna).font.color = 255
                Libro.Worksheets(1).cells(1, Columna).font.size = 12

                'Genera los reglones con la informacion del DataViewGrid
                For nfila As Integer = 0 To RowCount
                    Libro.Worksheets(vhoja).cells(Fila, Columna) = dgActividades.Rows(nfila).Cells(nCol).Value
                    Libro.Worksheets(vhoja).cells(Fila, Columna).VerticalAlignment = -4108
                    Libro.Worksheets(vhoja).cells(Fila, Columna).HorizontalAlignment = -4108
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
                'Progres Bar
                pbProceso.Value = nCol * 100 / ColumnCount
                Refresh()
            Next

            'Cabecera del excel
            Libro.Worksheets(vhoja).range("A1:D1").select
            Libro.Worksheets(vhoja).range("A1:D1").EntireColumn.AutoFit
            Libro.Worksheets(vhoja).range("A1:D1").Interior.color = 50687
            Libro.Worksheets(vhoja).range("A1:D1").VerticalAlignment = -4108
            Libro.Worksheets(vhoja).range("A1:D1").HorizontalAlignment = -4108

            'Cierre de aviso
            foAvisoCorto.Close()

            chkActividadesTI.ForeColor = Color.Red

        Catch ex As Exception

            MsgBox("Error al Exportar a Excel: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    '021 SUB [ chkSeleccion_CheckedChanged ] Habilita o deshabilita temas a exportar
    Private Sub chkSeleccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccion.CheckedChanged

        If chkSeleccion.Checked Then
            chkAfores.Checked = True
            chkCuantias73AR.Checked = True
            chkCuantias73.Checked = True
            chkCuantias97.Checked = True
            chkTopados.Checked = True
            chkDelegacion.Checked = True
            chkEstados.Checked = True
            chkINPC.Checked = True
            chkINEGI.Checked = True
            chkISR.Checked = True
            chkPctM40.Checked = True
            chkSegPen.Checked = True
            chkUMA.Checked = True
            chkDespacho.Checked = True
            chkModalidades.Checked = True
            chkActividadesTI.Checked = True
            chkM33.Checked = True
            chkRTPrima.Checked = True
        Else
            chkAfores.Checked = False
            chkCuantias73AR.Checked = False
            chkCuantias73.Checked = False
            chkCuantias97.Checked = False
            chkTopados.Checked = False
            chkDelegacion.Checked = False
            chkEstados.Checked = False
            chkINPC.Checked = False
            chkINEGI.Checked = False
            chkISR.Checked = False
            chkPctM40.Checked = False
            chkSegPen.Checked = False
            chkUMA.Checked = False
            chkDespacho.Checked = False
            chkModalidades.Checked = False
            chkActividadesTI.Checked = False
            chkM33.Checked = False
            chkRTPrima.Checked = False
        End If

    End Sub

    '022 Sub [SubMsgError] Muestra un mensaje de error en la barra de mensajes
    Sub SubMenError(pMensaje As String, pPausa As Integer)

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.Red
        tsslMensaje.ForeColor = Color.White
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '023 Sub [SubMsgOK]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenOK(pMensaje As String, pPausa As Integer)

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(255, 243, 166)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

    '024 Sub [SubMenWarning]  Muestra un mensaje OK en la barra de mensajes
    Sub SubMenWarning(pMensaje As String, pPausa As Integer)

        tsslMensaje.Text = pMensaje
        tsslMensaje.BackColor = Color.FromArgb(247, 172, 8)
        tsslMensaje.ForeColor = Color.Black
        Call mUniversal.SubPausa(Me, pPausa)
        '-----------------------------------
        Refresh()

    End Sub

End Class
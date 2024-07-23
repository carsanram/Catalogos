Imports System.Management
Imports System
Imports System.Text
Imports System.Security.Cryptography

Module Utilerias

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    Private Const KEYEVENTF_KEYUP = &H2
    Private Const VK_LWIN = &H5B

    'Conexion Internet
    Public Function IsConnectionAvailable() As Boolean
        Dim objUrl As New System.Uri("http://www.youtube.com")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objresp As System.Net.WebResponse

        Try
            objresp = objWebReq.GetResponse
            objresp.Close()
            objresp = Nothing
            Return True

        Catch ex As Exception
            objresp = Nothing
            objWebReq = Nothing
            Return False
        End Try

        'Uso de la funcion 

        'If IsConnectionAvailable() = TrueThen
        '    Do Action Here
        'Else
        '    Do Action Here
        'End If

    End Function
    'Obtener la resolución de pantalla utilizada
    Public Sub subResolucionPantalla()
        Dim vAncho As String
        Dim vAlto As String
        vAncho = Screen.PrimaryScreen.WorkingArea.Width
        vAlto = Screen.PrimaryScreen.WorkingArea.Height
    End Sub
    'Ejecuta la aplicación desde el programa
    Public Sub subExeApp()
        Shell("mspaint")
    End Sub
    'Abrir archivos de música en la unidad
    Public Sub subPlaySong(ByVal pRuta As String, ByVal pArchivo As String)
        My.Computer.Audio.Play(pRuta & pArchivo)
    End Sub
    'Copiar texto del portapapeles
    Public Sub subCopyText()
        Dim vPaste As String

        If My.Computer.Clipboard.ContainsText Then
            vPaste = My.Computer.Clipboard.GetText
        End If
    End Sub
    'Abrir pitido desde el sonido del sistema de Windows
    Public Sub subPitido()
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    End Sub
    'Generar número aleatorio
    Public Sub subGeneraAleatorio()
        Dim number As Integer

        Randomize()
        ' The program will generate a number from 0 to 50
        number = Int(Rnd() * 50) + 1

    End Sub
    'Presione Alt + PrintScreen para tomar una captura de pantalla y guardar el archivo de imagen en la unidad
    Public Sub subGuardaImagen()
        SendKeys.SendWait("%({PRTSC})")
        My.Computer.Clipboard.GetImage().Save("C:form.jpg")
    End Sub
    'Obtenga información de RAM de la computadora
    Public Sub subMemoriaRam()
        Dim vTotPhyMem As String
        Dim vAvePhyMem As String
        Dim vTotVirMem As String
        Dim vAveVirMem As String

        vTotPhyMem = My.Computer.Info.TotalPhysicalMemory
        vAvePhyMem = My.Computer.Info.AvailablePhysicalMemory
        vTotVirMem = My.Computer.Info.TotalVirtualMemory
        vAveVirMem = My.Computer.Info.AvailableVirtualMemory

    End Sub
    'Ejecuta acciones de teclas
    Public Sub subTeclas()
        'BACKSPACE {BACKSPACE} or {BS}
        'BREAK({BREAK})
        'CAPS LOCK {CAPSLOCK}
        'CLEAR({CLEAR})
        'DELETE {DELETE} or {DEL}
        'DOWN ARROW {DOWN}
        'END {END}
        'ENTER (numeric keypad) {ENTER}
        'ENTER ~ ESC {ESCAPE} or {ESC}
        'Help({Help})
        'HOME({HOME})
        'INS({INSERT})
        'LEFT ARROW {LEFT}
        'NUM LOCK {NUMLOCK}
        'PAGE DOWN {PGDN}
        'PAGE UP {PGUP}
        'RETURN {RETURN}
        'RIGHT ARROW {RIGHT}
        'SCROLL LOCK {SCROLLLOCK} T
        'AB({TAB()})
        'UP ARROW {UP}
        'F1 ke F15 {F1} ke {F15}

        My.Computer.Keyboard.SendKeys("{BACKSPACE}")
    End Sub
    'Función de cifrado SHA1
    Public Function SHA1(ByVal number As String) As String
        Dim ASCIIENC As New ASCIIEncoding
        Dim strreturn As String
        strreturn = vbNullString
        Dim bytesourcetxt() As Byte = ASCIIENC.GetBytes(number)
        Dim SHA1Hash As New SHA1CryptoServiceProvider
        Dim bytehash() As Byte = SHA1Hash.ComputeHash(bytesourcetxt)
        For Each b As Byte In bytehash
            strreturn &= b.ToString("X8")
        Next
        Return strreturn
    End Function
    'Mostrar escritorio
    Public Sub ShowDesktop()
        keybd_event(VK_LWIN, 0, 0, 0)
        keybd_event(77, 0, 0, 0)
        keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0)
    End Sub
    'Obtenga la ruta de la carpeta personalizada, por ejemplo: Escritorio
    Public Sub subRutaCarpeta()
        Dim DesktopPath As String = CreateObject("WScript.Shell").Specialfolders(10)
        'OR
        Dim DesktopPath2 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    End Sub
    'Borrar todo el cuadro de texto en el formulario
    Public Sub subBorraText()
        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim a As Control

        'For Each a In Me.Controls
        '    If TypeOf a Is TextBox Then
        '        a.Text = Nothing
        '    End If
        'Next
        'End Sub
    End Sub
    'Borra numero de cajas de texto
    Public Sub subBorraNumText()
        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '    Dim rep As String = String.Empty
        '    For i As Integer = 0 To TextBox1.Text.Length - 1
        '        If Not IsNumeric(TextBox1.Text.Substring(i, 1)) Then
        '            rep += TextBox1.Text.Substring(i, 1)
        '        End If
        '    Next
        '    TextBox1.Text = rep
        'End Sub
    End Sub
    'Texto de tamaño de fuente automático para adaptarse a TextBox
    Public Sub subReduceFont()
        '    Dim h As String
        '    Dim w As String

        'Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        '    Dim orgFont As New Font(TextBox1.Font.Name, TextBox1.Font.Size, TextBox1.Font.Style)
        '    Dim textSize As New SizeF
        '    textSize = e.Graphics.MeasureString(TextBox1.Text, orgFont)
        '    h = textSize.Height
        '    w = textSize.Width
        'End Sub

        'Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        '    TextBox1.Font = New Font(TextBox1.Font.Name, 8, TextBox1.Font.Style)
        '    TextBox1.BorderStyle = BorderStyle.Fixed3D
        '    Do Until w > TextBox1.Size.Width - 5 Or TextBox1.Text = Nothing Or h > 182
        '        TextBox1.Font = New Font(TextBox1.Font.Name, TextBox1.Font.Size + 2, TextBox1.Font.Style)
        '    Loop
        '    TextBox1.BorderStyle = BorderStyle.None
        'End Sub
    End Sub
    'Solo puede ingresar números en el cuadro de texto
    Public Sub subSoloNumCajaTexto()
        'Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        '    If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
        '        MessageBox.Show("Please enter numbers only")
        '        e.Handled = True
        '    End If
        'End Sub
    End Sub
    'Descargar archivo del sitio web
    Public Sub subDescargaArchivoWeb()
        My.Computer.Network.DownloadFile("http://www.domain.com/file.txt", "C:yourpathfile.txt")
    End Sub
    'Sube el archivo al sitio web
    Public Sub subSubeArchivoWeb()
        My.Computer.Network.UploadFile("C:locationfile.xxx", "ftp://domain.com/www/file.xxx", "username", "password", True, 500)
    End Sub
    'Obtener todos los enlaces/URL del sitio web
    Public Sub subObtieneEnlacesWeb()
        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '    Dim a As Integer
        '    Dim b As String
        '    For a = 1 To WebBrowser1.Document.Links.Count - 1
        '        b = b & WebBrowser1.Document.Links(a).InnerHtml & vbCrLf
        '    Next

        '    TextBox1.Text = b
        '    Label1.Text = WebBrowser1.Document.Links.Count & " links."
        'End Sub
    End Sub
    'Comprobar si el archivo existe o no
    Public Function fnExisteArchivo() As Boolean
        If My.Computer.FileSystem.FileExists("C:locationfile.xxx") Then
            fnExisteArchivo = True
        Else
            fnExisteArchivo = False
        End If

        Return fnExisteArchivo()

    End Function
    'Copiar archivos de una carpeta a otra
    Public Sub subCopiaArchivos()
        My.Computer.FileSystem.CopyFile("C:yourLocationfile.xxx", "C:NewLocationfile.xxx")
    End Sub
    'Leer archivo de texto en cuadro de texto
    Public Sub subLeeArchivoACuadroTxt()
        Dim vContenido As String
        vContenido = My.Computer.FileSystem.ReadAllText("C:your pathfile.txt")
    End Sub
    'Escribir archivo de texto desde Textbox
    Public Sub subEscribeTextoAarchivo()
        '    Dim TextBox 'TextBox
        '    My.Computer.FileSystem.WriteAllText("C:locationfile.txt", TextBox, True)
    End Sub
    'Eliminar carpeta carpeta
    Public Sub subEliminmaCarpeta()
        My.Computer.FileSystem.DeleteDirectory("C:PathFolder", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    'String inverso
    Public Sub subStrigInverso()
        'Dim textToReverse As String
        'Dim Letters() As Char

        'Private Sub Button1_Click(ByVal sender As System.Object, _
        ' ByVal e As System.EventArgs) Handles Button1.Click
        '    textToReverse = TextBox1.Text
        '    Letters = textToReverse.ToCharArray()
        '    Array.Reverse(Letters)
        '    Dim ReversedText As New String(Letters, 0, Letters.Length)
        '    TextBox2.Text = ReversedText
        'End Sub
    End Sub
    'Imagen inversa
    Public Sub subImagenInversa()
        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '    Dim pic As New Bitmap(PictureBox1.Image)
        '    For y As Integer = 0 To pic.Height - 1
        '        For x As Integer = 0 To pic.Width - 1
        '            Dim inv As Color = pic.GetPixel(x, y)
        '            inv = Color.FromArgb(255, 255 - inv.R, 255 - inv.G, 255 - inv.B)
        '            pic.SetPixel(x, y, inv)
        '            PictureBox2.Image = pic
        '        Next x
        '    Next y
        'End Sub
    End Sub
    'Mostrar una imagen del portapapeles en el cuadro Imagen
    Public Sub subPegaImagen()
        'If My.Computer.Clipboard.ContainsImage Then
        '    PictureBox1.Image = My.Computer.Clipboard.GetImage
        'End If

        'Clipboard.Clear()
    End Sub

End Module

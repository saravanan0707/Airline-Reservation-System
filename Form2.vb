Imports System.Net.Mail

Public Class Form2

    Private Sub BtnSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendMail.Click
        Try
            Dim smpt_server As New SmtpClient
            Dim e_mail As New MailMessage()
            smpt_server.UseDefaultCredentials = False
            smpt_server.Credentials = New Net.NetworkCredential("deccanairlines2021@gmail.com", "Deccanairways2021")
            smpt_server.Port = 587
            smpt_server.EnableSsl = True
            smpt_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(TxtFrom.Text)
            e_mail.To.Add(TxtTo.Text)
            e_mail.Subject = TxtSubject.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = TxtMessage.Text
            smpt_server.Send(e_mail)
            MsgBox("mail sent successfully, Thank You :)")
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
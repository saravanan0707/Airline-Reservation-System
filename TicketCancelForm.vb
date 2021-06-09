Imports system.Data.SqlClient

Public Class TicketCancelForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from BookingTab where tStatus='N' and  bNo=" & Val(TextBox1.Text) & "", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.Read() Then
            SqlStr = "Flight No " & D1(5).ToString & vbCrLf & vbCrLf
            SqlStr = SqlStr & "Flying Date " & D1(6).ToString & vbCrLf & vbCrLf
            SqlStr = SqlStr & "Seat Type " & D1(7).ToString & vbCrLf & vbCrLf
            SqlStr = SqlStr & "Ticket Price " & D1(8).ToString & vbCrLf & vbCrLf
            TextBox2.Text = SqlStr
        Else
            MsgBox("This ticket no not found")
            TextBox2.Text = ""
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        SqlStr = "update bookingtab set tStatus='C' where bNo=" & Val(TextBox1.Text) & ""
        Dim cmd1 As New SqlCommand(SqlStr, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()

        MsgBox("Ticket is cancelled")
    End Sub

    Private Sub TicketCancelForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
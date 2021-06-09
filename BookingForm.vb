Imports System.Data.SqlClient
Public Class BookingForm
    Dim tSeats As Integer
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim b1var As Integer
        If ComboBox2.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MsgBox("Please select Flight No")
            Exit Sub
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select max(bNo)+1 from BookingTab", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.Read Then
            b1var = IIf(IsDBNull(D1(0)), 1000, D1(0))
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into BookingTab "
        q2Var = " values("
        q2Var = q2Var & "" & b1var & ","
        q2Var = q2Var & "'" & Format(Today.Date, "dd/MMM/yyyy") & "',"
        q2Var = q2Var & "'" & ComboBox2.Text & "',"
        q2Var = q2Var & "'" & TextBox1.Text & "',"
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q2Var = q2Var & "'" & TextBox3.Text & "',"
        q2Var = q2Var & "'" & Format(fDate.Value, "dd/MMM/yyyy") & "',"
        q2Var = q2Var & "'" & ComboBox5.Text & "',"
        q2Var = q2Var & "" & Val(TextBox4.Text) & ",'N','')"



        'MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1Var & q2Var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()

        MsgBox("Your ticket booked successfully Ticket no is " & b1var)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox2.Text = ""
        ComboBox5.Text = ""
    End Sub

    Private Sub BookingForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select placeName from PlaceTab order by PlaceName", Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox4.Items.Add(D1(0).ToString)
            ComboBox3.Items.Add(D1(0).ToString)
        End While


        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd2 As New SqlCommand("select custcode from customerTab order by custcode", Conn)
        Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
        While D2.Read
            ComboBox2.Items.Add(D2(0).ToString)
        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select flightno,compcode,dtime,duration,eseats,eprice,bseats,bprice From FlightTab where fplace='" & ComboBox3.Text & "' and tplace='" & ComboBox4.Text & "' order by flightno", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick

    End Sub

    Private Sub DG1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG1.SelectionChanged
        'MsgBox(DG1.CurrentRow.Cells(0).Value)
        TextBox3.Text = DG1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub ComboBox5_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedValueChanged
        If ComboBox5.Text = "" Then Exit Sub


        If ComboBox5.Text = "Economy" Then
            SqlStr = "select ePrice,eseats from FlightTab where flightno='" & TextBox3.Text & "'"
        ElseIf ComboBox5.Text = "Business" Then
            SqlStr = "select bPrice,bSeats from FlightTab where flightno='" & TextBox3.Text & "'"
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand(SqlStr, Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        If D1.Read Then
            TextBox4.Text = D1(0)
            tSeats = D1(1)
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged
        If Len(ComboBox5.Text) < 4 Then Exit Sub



        SqlStr = "select custName,passportno from customerTab where custcode='" & ComboBox2.Text & "'"
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand(SqlStr, Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        If D1.Read Then
            TextBox1.Text = D1(0)
            TextBox2.Text = D1(1)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub fDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fDate.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

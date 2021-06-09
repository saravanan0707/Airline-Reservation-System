Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class EmpDetailsForm
    Dim pkVar As String

    Private Property EmailValid As Boolean

    Private Property namevalid As Boolean

    Private Sub EmpDetForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        jDate.Value = Now.Date

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select qualificationname from QualificationTab order by qualificationName", Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox1.Items.Add(D1(0).ToString)
        End While
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd2 As New SqlCommand("select DesignationName  from DesignationTab order by DesignationName", Conn)
        Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
        While D2.Read
            ComboBox2.Items.Add(D2(0).ToString)
        End While

        disRecords()
    End Sub

    Private Sub butNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearTxtControls(Me, 1)
        TextBox1.Focus()
    End Sub


    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        SaveRecord()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub
    Sub SaveRecord()
        If TextBox1.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select empCode from empDetTab where empCode='" & UCase(TextBox1.Text) & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This record is allready present in the database")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into empDetTab("
        q2Var = " values("
        q1Var = q1Var & "empCode" & ","
        q2Var = q2Var & "'" & UCase(TextBox1.Text) & "',"
        q1Var = q1Var & "empName" & ","
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q1Var = q1Var & "Add1" & ","
        q2Var = q2Var & "'" & TextBox3.Text & "',"
        q1Var = q1Var & "Add2" & ","
        q2Var = q2Var & "'" & TextBox4.Text & "',"
        q1Var = q1Var & "Add3" & ","
        q2Var = q2Var & "'" & TextBox5.Text & "',"
        q1Var = q1Var & "PinCode" & ","
        q2Var = q2Var & "'" & TextBox6.Text & "',"
        q1Var = q1Var & "PhoneNo" & ","
        q2Var = q2Var & "'" & TextBox7.Text & "',"
        q1Var = q1Var & "eMail" & ","
        q2Var = q2Var & "'" & TextBox8.Text & "',"
        q1Var = q1Var & "QualificationName" & ","
        q2Var = q2Var & "'" & ComboBox1.Text & "',"
        q1Var = q1Var & "DesignationName" & ","
        q2Var = q2Var & "'" & ComboBox2.Text & "',"
        q1Var = q1Var & "DOJ" & ","
        q2Var = q2Var & "'" & jDate.Text & "',"
        q1Var = q1Var & "Salary" & ")"
        q2Var = q2Var & "" & Val(TextBox9.Text) & ")"

        'MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1Var & q2Var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()

    End Sub
    Sub disRecords()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select * From empDetTab order by empCode", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from empDetTab where empCode='" & pkVar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(0).ToString
            TextBox2.Text = D1(1).ToString
            TextBox3.Text = D1(2).ToString
            TextBox4.Text = D1(3).ToString
            TextBox5.Text = D1(4).ToString
            TextBox6.Text = D1(5).ToString
            TextBox7.Text = D1(6).ToString
            TextBox8.Text = D1(7).ToString
            ComboBox1.Text = D1(8).ToString
            ComboBox2.Text = D1(9).ToString
            jDate.Value = D1(10).ToString
            TextBox9.Text = D1(11).ToString
            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = True
            ButDelete.Enabled = True
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = False
            ButDelete.Enabled = False

        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()

    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub

    Private Sub butModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles butModify.Click
        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from empDetTab where empCode='" & pkVar & "'", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        SaveRecord()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        If vbNo = MsgBox("Are you sure you want delete this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from empDetTab where empCode='" & pkVar & "'", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub butNew_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles butNew.Click
        ClearTxtControls(Me, 1)

        TextBox1.Focus()
        butNew.Enabled = False
        butSave.Enabled = True
        butModify.Enabled = False
        ButDelete.Enabled = False
    End Sub

    Private Sub butList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butList.Click
        disRecords()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = UCase(TextBox1.Text)
    End Sub

    Private Sub TextBox7_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.Leave
        Dim lengthph As Integer
        Dim num As String
        num = TextBox7.Text(0)

        If IsNumeric(TextBox7.Text) Then
            lengthph = Len(TextBox7.Text)
            If lengthph <> 10 Then
                MsgBox("phone number invalid")
                TextBox7.Clear()
                TextBox7.Focus()
            ElseIf num <> "9" And num <> "8" And num <> "6" And num <> "7" Then
                MsgBox("Wrong format of Phone Number")
                TextBox7.Clear()
                TextBox7.Focus()
            End If
        Else
            MsgBox("entered data is not valid")
            TextBox7.Clear()
            TextBox7.Focus()
        End If
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.Leave
        Dim reEmail As Regex = New Regex("^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.com$", _
       RegexOptions.IgnoreCase _
       Or RegexOptions.CultureInvariant _
       Or RegexOptions.IgnorePatternWhitespace _
       Or RegexOptions.Compiled _
       )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(TextBox8.Text)
        If blnPossibleMatch Then
            If Not TextBox8.Text.Equals(reEmail.Match(TextBox8.Text).ToString) Then
                MsgBox("Invalid Email Address")
            Else
                EmailValid = True
            End If
        Else
            EmailValid = False
            MsgBox("invalid Email Id")
            TextBox8.Clear()
            TextBox8.Focus()
        End If
    End Sub

    Private Sub TextBox8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.LostFocus
        

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
       
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
       
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

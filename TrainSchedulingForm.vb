Imports System.Data.SqlClient
Public Class TrainSchedulingForm
    Dim pkVar As String
    Private Sub ItemForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        disRecords()

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select TrainName from TrainDetTab order by TrainName", Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox1.Items.Add(D1(0).ToString)
        End While
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd2 As New SqlCommand("select StationName  from StationTab order by StationName", Conn)
        Dim D2 As SqlDataReader = Cmd2.ExecuteReader()
        While D2.Read
            ComboBox2.Items.Add(D2(0).ToString)
            ComboBox3.Items.Add(D2(0).ToString)
        End While

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
        Dim Cmd0 As New SqlCommand("select TrainNo from TrainTimingsTab where TrainNo='" & UCase(TextBox1.Text) & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This record is allready present in the database")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into TrainTimingsTab "
        q2Var = " values("
        q2Var = q2Var & "'" & UCase(TextBox1.Text) & "',"
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q2Var = q2Var & "'" & ComboBox1.Text & "',"
        q2Var = q2Var & "'" & ComboBox2.Text & "',"
        q2Var = q2Var & "'" & TextBox3.Text & "',"
        q2Var = q2Var & "'" & ComboBox3.Text & "',"
        q2Var = q2Var & "'" & TextBox4.Text & "')"

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
        Dim adp As New SqlDataAdapter("Select TrainNo,TrainName From TrainTimingsTab order by TrainNo", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from TrainTimingsTab where TrainNo='" & pkVar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(0).ToString
            TextBox2.Text = D1(1).ToString
            ComboBox1.Text = D1(2).ToString
            ComboBox2.Text = D1(3).ToString
            TextBox3.Text = D1(4).ToString
            ComboBox3.Text = D1(5).ToString
            TextBox4.Text = D1(6).ToString


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
        Dim cmd1 As New SqlCommand("Delete from TrainTimingsTab where TrainNo='" & pkVar & "'", Conn)
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
        Dim cmd1 As New SqlCommand("Delete from TrainTimingsTab where TrainNo='" & pkVar & "'", Conn)
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
End Class

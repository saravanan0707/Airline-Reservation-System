Imports System.Data.SqlClient
Public Class CancelledReportForm

    Private Sub AppListReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select bNo,bdate,custName,flightNo,tprice  From BookingTab where tstatus='C' order by bNo", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long
        YPos = 50
        Dim MyFont As New Font("Arial", 18)
        XPos = 10
        e.Graphics.DrawString("Air Ticket Booking Administration", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("No. 101, 4th floor, UB City, Bangalore - 560001", MyFont, Brushes.Black, XPos, YPos)
        YPos += 100
        XPos = 10
        e.Graphics.DrawString("Cancelled Ticket Report", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("No", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Date", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Cust Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("FlightNo", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Price", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150



        YPos += 25
        For Each r As DataGridViewRow In DG1.Rows
            q1Var = r.Cells(1).Value & " : " & r.Cells(2).Value
            XPos = 10
            e.Graphics.DrawString(r.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(1).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(3).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(4).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150

            YPos += 25
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PP1.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
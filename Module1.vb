Imports System.Data.SqlClient

Module Module1
    Public Conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\FlightBookData.mdf;Integrated Security=True;User Instance=True")
    Public SqlStr, q1Var, q2Var As String
    Public colVar, rowVar, I, J As Long
    Public vTypeVar As Byte

    Enum CtrlType
        TextBox = 1
        ComboBox = 2
    End Enum
    Public Sub ClearTxtControls(ByRef frm As Object, ByRef ControlType As CtrlType, Optional ByRef Tagstr As Object = Nothing)
        Dim Contrl As Object
        For Each Contrl In frm.Controls
            If Not (IsNothing(Tagstr)) Then
                If Trim(UCase(Contrl.Tag)) = Trim(UCase(Tagstr)) Then
                    Contrl.Text = ""
                    Exit For
                End If
            Else
                Select Case ControlType
                    Case CtrlType.ComboBox
                        If TypeOf Contrl Is System.Windows.Forms.ComboBox Then Contrl.Text = ""
                    Case CtrlType.TextBox
                        If TypeOf Contrl Is System.Windows.Forms.TextBox Then Contrl.Text = ""
                End Select
            End If
        Next Contrl
        Contrl = Nothing
    End Sub

    Public Function CheckNum(ByRef KeyVar As String) As String
        If Asc(KeyVar) = 8 Then
            CheckNum = KeyVar : Exit Function
        End If
        If Asc(KeyVar) < 46 Or Asc(KeyVar) > 57 Then
            CheckNum = Nothing
            MsgBox("Please Enter Numbers Only")
        Else
            CheckNum = KeyVar
        End If
        If Asc(KeyVar) = 47 Then CheckNum = Nothing

    End Function
End Module

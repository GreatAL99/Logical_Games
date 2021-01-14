Imports System.Data.OleDb

Public Class Form7
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private score As Integer = 0
    Private rn As New Random
    Private questions(10) As Integer
    Private strConnexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\BD TestCulturel.accdb"
    Private oConnection As OleDbConnection = New OleDbConnection(strConnexion)
    Private repvrai As String
    Private indice As Integer = 2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If indice < 10 Then
            If (RadioButton1.Checked = True And repvrai = "A") Or (RadioButton2.Checked = True And repvrai = "B") Or (RadioButton3.Checked = True And repvrai = "C") Then
                score = score + 1
                indice = indice + 1
                Afficherq(indice)
            ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MsgBox("Choose an answer first!", vbOKOnly, "Error")
            Else
                indice = indice + 1
                Afficherq(indice)
            End If
        Else
            If (RadioButton1.Checked = True And repvrai = "A") Or (RadioButton2.Checked = True And repvrai = "B") Or (RadioButton3.Checked = True And repvrai = "C") Then
                score = score + 1
                MsgBox("Well Played! Your score is: " + score.ToString, vbOKOnly, "Done")
                Dim intermediaire As Double
                intermediaire = Scoreculture * NbJeuculture
                NbJeuculture = NbJeuculture + 1
                Scoreculture = (intermediaire + score) / NbJeuculture

            ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MsgBox("Choose an answer first!", vbOKOnly, "Error")
            Else
                MsgBox("Well Played! Your score is: " + score.ToString, vbOKOnly, "Done")
                Dim intermediaire As Double
                intermediaire = Scoreculture * NbJeuculture
                NbJeuculture = NbJeuculture + 1
                Scoreculture = (intermediaire + score) / NbJeuculture
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Function Afficherq(i As Integer)
        oConnection.Open()
        Dim strReq As String = "SELECT * FROM TestCulturel"
        Dim oCommand As New OleDbCommand(strReq, oConnection)
        Dim oReader As OleDbDataReader = oCommand.ExecuteReader()
        While oReader.Read()
            If questions(i) = oReader.GetInt32(0) Then
                Label2.Text = "Question " + i.ToString
                Label3.Text = oReader.GetString(1)
                RadioButton1.Text = oReader.GetString(2)
                RadioButton2.Text = oReader.GetString(3)
                RadioButton3.Text = oReader.GetString(4)
                repvrai = oReader.GetString(5)
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
            End If
        End While
        oConnection.Close()
        Return 1
    End Function

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 10
            questions(i) = rn.Next(1, 30)
        Next
        Afficherq(1)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("You really want to quit?", vbYesNo, "Confirmation") Then
            Close()
        End If
    End Sub
End Class
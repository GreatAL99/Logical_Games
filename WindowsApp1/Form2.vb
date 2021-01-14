Imports System.Data.OleDb

Public Class Form2
    Private strConnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Base_Projet.mdb"
    Private oConnection As OleDbConnection = New OleDbConnection(strConnexion)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(Identif)
        ListBox1.Items.Add("Tic Tac Toe games: " + NbJeuXO.ToString)
        ListBox1.Items.Add("Tic Tac Toe won games: " + NbJeuwinXO.ToString)
        ListBox1.Items.Add("Tic Tac Toe lost games: " + NbJeuloseXO.ToString)
        ListBox1.Items.Add("Hangman games: " + NbJeuhang.ToString)
        ListBox1.Items.Add("Hangman won games: " + NbJeuhangwin.ToString)
        ListBox1.Items.Add("Culturel Test games: " + NbJeuculture.ToString)
        ListBox1.Items.Add("Culturel Test Medium Score: " + Scoreculture.ToString)
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Mes Documents\Etudes 2 sem\Projet Intégré\Piano tiles\Hiroyuki Sawano – Battle Continues Suite  Epic Music  BEST Battle Music.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.ShowDialog()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MsgBox("You gave up already, Warrior! You really want to quit?", vbYesNo, "Confirmation") = vbYes Then
            oConnection.Open()
            Dim strReq2 As String = "UPDATE Utilisateurs SET NbjeuXO =" & NbJeuXO.ToString & ", NbjeuloseXO=" & NbJeuloseXO.ToString & ", NbjeuwinXO =" & NbJeuwinXO.ToString & ", Nbjeuhang=" & NbJeuhang.ToString & ",Nbjeuhangwin=" & NbJeuhangwin.ToString & ",nbjeuculture=" & NbJeuculture.ToString & ",scoreculture=" & Scoreculture.ToString & " WHERE Identifiant ='" & Identif & "';"
            Dim oCommand2 As New OleDbCommand(strReq2, oConnection)
            oCommand2.ExecuteNonQuery()
            oConnection.Close()
            End
        Else

        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("You gave up already, Warrior! You really want to quit?", vbYesNo, "Confirmation") = vbYes Then
            oConnection.Open()
            Dim strReq2 As String = "UPDATE Utilisateurs SET NbjeuXO =" & NbJeuXO.ToString & ", NbjeuloseXO=" & NbJeuloseXO.ToString & ", NbjeuwinXO =" & NbJeuwinXO.ToString & ", Nbjeuhang=" & NbJeuhang.ToString & ",Nbjeuhangwin=" & NbJeuhangwin.ToString & ",nbjeuculture=" & NbJeuculture.ToString & ",scoreculture=" & Scoreculture.ToString & " WHERE Identifiant ='" & Identif & "';"
            Dim oCommand2 As New OleDbCommand(strReq2, oConnection)
            oCommand2.ExecuteNonQuery()
            oConnection.Close()
            End
        Else

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
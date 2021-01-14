Imports System.Data.OleDb

Public Class Form1
    Private strConnexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\simob\OneDrive\Bureau\Mes Documents\Etudes 2 sem\Projet Intégré\Base_Projet.mdb"
    Private oConnection As OleDbConnection = New OleDbConnection(strConnexion)
    Private flag As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        flag = 0
        oConnection.Open()
        Dim strReq As String = "SELECT * FROM Utilisateurs"
        Dim oCommand As New OleDbCommand(strReq, oConnection)
        Dim oReader As OleDbDataReader = oCommand.ExecuteReader()
        While oReader.Read()
            If TextBox1.Text = oReader.GetString(0) And TextBox2.Text = oReader.GetString(1) Then
                flag = 1
                Identif = oReader.GetString(0)
                NbJeuXO = oReader.GetInt32(2)
                NbJeuloseXO = oReader.GetInt32(3)
                NbJeuwinXO = oReader.GetInt32(4)
                NbJeuhang = oReader.GetInt32(5)
                NbJeuhangwin = oReader.GetInt32(6)
                NbJeuculture = oReader.GetInt32(7)
                Scoreculture = oReader.GetInt32(8)
            End If
        End While
        oConnection.Close()
        If (flag = 1) Then
            FormInter.Show()
            Hide()
        Else
            MsgBox("The identifier or password are wrong. Please retry!", vbOK, "Erreur d'authentification")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        flag = 0
        oConnection.Open()
        Dim strReq As String = "SELECT * FROM Utilisateurs"
        Dim oCommand As New OleDbCommand(strReq, oConnection)
        Dim oReader As OleDbDataReader = oCommand.ExecuteReader()
        Dim Max = 0
        While oReader.Read()
            If (TextBox1.Text = oReader.GetString(1)) Then
                flag = 1
            End If
        End While
        oConnection.Close()
        If (flag = 0) Then
            oConnection.Open()
            Dim strReq2 As String = "INSERT INTO Utilisateurs VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "',0,0,0,0,0,0,0);"
            Dim oCommand2 As New OleDbCommand(strReq2, oConnection)
            oCommand2.ExecuteNonQuery()
            oConnection.Close()
            Identif = TextBox1.Text
            FormInter.Show()
            Hide()
        Else
            MsgBox("L'identifiant est déjà utilisé! Veuillez réessayer avec un autre.", vbOK, "Erreur d'authentification")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

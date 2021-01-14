Public Class FormInter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form2.Show()

    End Sub

    Private Sub FormInter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("This game was made by the project group : Mohammed BENSAID, Nabil AZIM, Amine BIDOUD, Ahmed BOUGARNE, Jad ElMoula DAHRI and Mohammed Amine ELMAJDI. We want to thank everyone who gave his help in any way in the construction of this application besides The Supervising teacher Mr HASBI!", vbOKOnly, "Credits")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
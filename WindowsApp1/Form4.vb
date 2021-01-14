Public Class Form4
    Private niveau As Integer = 0
    Private Symbol As String = "O"
    Private SymbolPC As String = "X"
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MsgBox("Are you ready to face the expert mode? Click No if you want to stick to the easy mode like a weeb!", vbYesNo, "Choix de niveau") = vbYes Then
            niveau = 1
        End If
        If MsgBox("You want to choose the symbol X?", vbYesNo, "Symbol") = vbYes Then
            Symbol = "X"
            SymbolPC = "O"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button1.Text = ""
        Button1.Enabled = True
        Button2.Text = ""
        Button2.Enabled = True
        Button3.Text = ""
        Button3.Enabled = True
        Button4.Text = ""
        Button4.Enabled = True
        Button5.Text = ""
        Button5.Enabled = True
        Button6.Text = ""
        Button6.Enabled = True
        Button7.Text = ""
        Button7.Enabled = True
        Button8.Text = ""
        Button8.Enabled = True
        Button9.Text = ""
        Button9.Enabled = True
        Button10.Enabled = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If MsgBox("You really wanna give up early?", vbYesNo, "Confirmation") Then
            Me.Close()
        End If
    End Sub

    Private Sub Whowins()
        If (Button1.Text = Button2.Text And Button2.Text = Button3.Text And Button2.Text = Symbol) Or (Button4.Text = Button5.Text And Button5.Text = Button6.Text And Button5.Text = Symbol) Or (Button7.Text = Button8.Text And Button8.Text = Button9.Text And Button8.Text = Symbol) Or (Button1.Text = Button4.Text And Button4.Text = Button7.Text And Button4.Text = Symbol) Or (Button2.Text = Button5.Text And Button5.Text = Button8.Text And Button5.Text = Symbol) Or (Button3.Text = Button6.Text And Button6.Text = Button9.Text And Button6.Text = Symbol) Or (Button1.Text = Button5.Text And Button5.Text = Button9.Text And Button5.Text = Symbol) Or (Button7.Text = Button5.Text And Button5.Text = Button3.Text And Button5.Text = Symbol) Then
            MsgBox("You won! I see that I understimated your powers.", vbOKOnly, "Congrats!")
            NbJeuwinXO = NbJeuwinXO + 1
            NbJeuXO = NbJeuXO + 1
            Button11.PerformClick()
        Else
            If (Button1.Text = Button2.Text And Button2.Text = Button3.Text And Button2.Text = SymbolPC) Or (Button4.Text = Button5.Text And Button5.Text = Button6.Text And Button5.Text = SymbolPC) Or (Button7.Text = Button8.Text And Button8.Text = Button9.Text And Button8.Text = SymbolPC) Or (Button1.Text = Button4.Text And Button4.Text = Button7.Text And Button4.Text = SymbolPC) Or (Button2.Text = Button5.Text And Button5.Text = Button8.Text And Button5.Text = SymbolPC) Or (Button3.Text = Button6.Text And Button6.Text = Button9.Text And Button6.Text = SymbolPC) Or (Button1.Text = Button5.Text And Button5.Text = Button9.Text And Button5.Text = SymbolPC) Or (Button7.Text = Button5.Text And Button5.Text = Button3.Text And Button5.Text = SymbolPC) Then
                MsgBox("You lost as expected! You still have much to learn!", vbOKOnly, "Lost")
                NbJeuXO = NbJeuXO + 1
                NbJeuloseXO = NbJeuloseXO + 1
                Button11.PerformClick()
            Else
                If (Button1.Enabled = False) And (Button2.Enabled = False) And (Button3.Enabled = False) And (Button4.Enabled = False) And (Button5.Enabled = False) And (Button6.Enabled = False) And (Button7.Enabled = False) And (Button8.Enabled = False) And (Button9.Enabled = False) Then
                    MsgBox("It was a tie! you are  worthy oppenent!", vbOKOnly, "Tie!")
                    NbJeuXO = NbJeuXO + 1
                    Button11.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Function Twoinrow()
        If (Button1.Text = Button2.Text And Button2.Text = Symbol) And (Button3.Enabled = True) Then
            Button3.Text = SymbolPC
            Button3.Enabled = False
            Return True
        Else
            If Button1.Text = Button3.Text And Button3.Text = Symbol And Button2.Enabled = True Then
                Button2.Text = SymbolPC
                Button2.Enabled = False
                Return True
            Else
                If Button1.Text = Button4.Text And Button4.Text = Symbol And Button7.Enabled = True Then
                    Button7.Text = SymbolPC
                    Button7.Enabled = False
                    Return True
                Else
                    If Button1.Text = Button7.Text And Button7.Text = Symbol And Button4.Enabled = True Then
                        Button4.Text = SymbolPC
                        Button4.Enabled = False
                        Return True
                    Else
                        If Button1.Text = Button5.Text And Button5.Text = Symbol And Button9.Enabled = True Then
                            Button9.Text = SymbolPC
                            Button9.Enabled = False
                            Return True
                        Else
                            If Button1.Text = Button9.Text And Button9.Text = Symbol And Button5.Enabled = True Then
                                Button5.Text = SymbolPC
                                Button5.Enabled = False
                                Return True
                            Else
                                If Button2.Text = Button5.Text And Button5.Text = Symbol And Button8.Enabled = True Then
                                    Button8.Text = SymbolPC
                                    Button8.Enabled = False
                                    Return True
                                Else
                                    If Button2.Text = Button8.Text And Button8.Text = Symbol And Button5.Enabled = True Then
                                        Button5.Text = SymbolPC
                                        Button5.Enabled = False
                                        Return True
                                    Else
                                        If Button3.Text = Button9.Text And Button9.Text = Symbol And Button6.Enabled = True Then
                                            Button6.Text = SymbolPC
                                            Button6.Enabled = False
                                            Return True
                                        Else
                                            If Button3.Text = Button6.Text And Button6.Text = Symbol And Button9.Enabled = True Then
                                                Button9.Text = SymbolPC
                                                Button9.Enabled = False
                                                Return True
                                            Else
                                                If Button3.Text = Button5.Text And Button5.Text = Symbol And Button7.Enabled = True Then
                                                    Button7.Text = SymbolPC
                                                    Button7.Enabled = False
                                                    Return True
                                                Else
                                                    If Button3.Text = Button7.Text And Button7.Text = Symbol And Button5.Enabled = True Then
                                                        Button5.Text = SymbolPC
                                                        Button5.Enabled = False
                                                        Return True
                                                    Else
                                                        If Button4.Text = Button5.Text And Button5.Text = Symbol And Button6.Enabled = True Then
                                                            Button6.Text = SymbolPC
                                                            Button6.Enabled = False
                                                            Return True
                                                        Else
                                                            If Button4.Text = Button6.Text And Button6.Text = Symbol And Button5.Enabled = True Then
                                                                Button5.Text = SymbolPC
                                                                Button5.Enabled = False
                                                                Return True
                                                            Else
                                                                If Button7.Text = Button9.Text And Button9.Text = Symbol And Button8.Enabled = True Then
                                                                    Button8.Text = SymbolPC
                                                                    Button8.Enabled = False
                                                                    Return True
                                                                Else
                                                                    If Button7.Text = Button8.Text And Button8.Text = Symbol And Button9.Enabled = True Then
                                                                        Button9.Text = SymbolPC
                                                                        Button9.Enabled = False
                                                                        Return True
                                                                    Else
                                                                        Return False
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If (Button1.Text = Button2.Text And Button2.Text = SymbolPC) And (Button3.Enabled = True) Then
            Button3.Text = SymbolPC
            Button3.Enabled = False
            Return True
        Else
            If Button1.Text = Button3.Text And Button3.Text = SymbolPC And Button2.Enabled = True Then
                Button2.Text = SymbolPC
                Button2.Enabled = False
                Return True
            Else
                If Button1.Text = Button4.Text And Button4.Text = SymbolPC And Button7.Enabled = True Then
                    Button7.Text = SymbolPC
                    Button7.Enabled = False
                    Return True
                Else
                    If Button1.Text = Button7.Text And Button7.Text = SymbolPC And Button4.Enabled = True Then
                        Button4.Text = SymbolPC
                        Button4.Enabled = False
                        Return True
                    Else
                        If Button1.Text = Button5.Text And Button5.Text = SymbolPC And Button9.Enabled = True Then
                            Button9.Text = SymbolPC
                            Button9.Enabled = False
                            Return True
                        Else
                            If Button1.Text = Button9.Text And Button9.Text = SymbolPC And Button5.Enabled = True Then
                                Button5.Text = SymbolPC
                                Button5.Enabled = False
                                Return True
                            Else
                                If Button2.Text = Button5.Text And Button5.Text = SymbolPC And Button8.Enabled = True Then
                                    Button8.Text = SymbolPC
                                    Button8.Enabled = False
                                    Return True
                                Else
                                    If Button2.Text = Button8.Text And Button8.Text = SymbolPC And Button5.Enabled = True Then
                                        Button5.Text = SymbolPC
                                        Button5.Enabled = False
                                        Return True
                                    Else
                                        If Button3.Text = Button9.Text And Button9.Text = SymbolPC And Button6.Enabled = True Then
                                            Button6.Text = SymbolPC
                                            Button6.Enabled = False
                                            Return True
                                        Else
                                            If Button3.Text = Button6.Text And Button6.Text = SymbolPC And Button9.Enabled = True Then
                                                Button9.Text = SymbolPC
                                                Button9.Enabled = False
                                                Return True
                                            Else
                                                If Button3.Text = Button5.Text And Button5.Text = SymbolPC And Button7.Enabled = True Then
                                                    Button7.Text = SymbolPC
                                                    Button7.Enabled = False
                                                    Return True
                                                Else
                                                    If Button3.Text = Button7.Text And Button7.Text = SymbolPC And Button5.Enabled = True Then
                                                        Button5.Text = SymbolPC
                                                        Button5.Enabled = False
                                                        Return True
                                                    Else
                                                        If Button4.Text = Button5.Text And Button5.Text = SymbolPC And Button6.Enabled = True Then
                                                            Button6.Text = SymbolPC
                                                            Button6.Enabled = False
                                                            Return True
                                                        Else
                                                            If Button4.Text = Button6.Text And Button6.Text = SymbolPC And Button5.Enabled = True Then
                                                                Button5.Text = SymbolPC
                                                                Button5.Enabled = False
                                                                Return True
                                                            Else
                                                                If Button7.Text = Button9.Text And Button9.Text = SymbolPC And Button8.Enabled = True Then
                                                                    Button8.Text = SymbolPC
                                                                    Button8.Enabled = False
                                                                    Return True
                                                                Else
                                                                    If Button7.Text = Button8.Text And Button8.Text = SymbolPC And Button9.Enabled = True Then
                                                                        Button9.Text = SymbolPC
                                                                        Button9.Enabled = False
                                                                        Return True
                                                                    Else
                                                                        Return False
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If niveau = 1 Then
            Dim rn As New Random
            Dim indice As Integer = rn.Next(1, 4)
            If indice = 1 Then
                Button1.Text = SymbolPC
                Button1.Enabled = False
            End If
            If indice = 2 Then
                Button3.Text = SymbolPC
                Button3.Enabled = False
            End If
            If indice = 3 Then
                Button7.Text = SymbolPC
                Button7.Enabled = False
            End If
            If indice = 4 Then
                Button9.Text = SymbolPC
                Button9.Enabled = False
            End If
        Else
            Dim rn As New Random
            Dim indice As Integer = rn.Next(1, 9)
            If indice = 1 Then
                Button1.Text = SymbolPC
                Button1.Enabled = False
            End If
            If indice = 3 Then
                Button3.Text = SymbolPC
                Button3.Enabled = False
            End If
            If indice = 7 Then
                Button7.Text = SymbolPC
                Button7.Enabled = False
            End If
            If indice = 9 Then
                Button9.Text = SymbolPC
                Button9.Enabled = False
            End If
            If indice = 4 Then
                Button4.Text = SymbolPC
                Button4.Enabled = False
            End If
            If indice = 2 Then
                Button2.Text = SymbolPC
                Button2.Enabled = False
            End If
            If indice = 6 Then
                Button6.Text = SymbolPC
                Button6.Enabled = False
            End If
            If indice = 8 Then
                Button8.Text = SymbolPC
                Button8.Enabled = False
            End If
            If indice = 5 Then
                Button5.Text = SymbolPC
                Button5.Enabled = False
            End If
        End If
        Button10.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = Symbol
        Button1.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
            Whowins()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = Symbol
        Button2.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Text = Symbol
        Button3.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Text = Symbol
        Button4.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Text = Symbol
        Button5.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Text = Symbol
        Button6.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Text = Symbol
        Button7.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Text = Symbol
        Button8.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Text = Symbol
        Button9.Enabled = False
        Button10.Enabled = False
        Dim notplay As Boolean = Not Twoinrow()
        If notplay = True Then
            If niveau = 0 Then
                If Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            Else
                If Button5.Enabled = True Then
                    Button5.Enabled = False
                    Button5.Text = SymbolPC
                ElseIf Button1.Enabled = True Then
                    Button1.Enabled = False
                    Button1.Text = SymbolPC
                ElseIf Button2.Enabled = True Then
                    Button2.Enabled = False
                    Button2.Text = SymbolPC
                ElseIf Button3.Enabled = True Then
                    Button3.Enabled = False
                    Button3.Text = SymbolPC
                ElseIf Button4.Enabled = True Then
                    Button4.Enabled = False
                    Button4.Text = SymbolPC
                ElseIf Button6.Enabled = True Then
                    Button6.Enabled = False
                    Button6.Text = SymbolPC
                ElseIf Button7.Enabled = True Then
                    Button7.Enabled = False
                    Button7.Text = SymbolPC
                ElseIf Button8.Enabled = True Then
                    Button8.Enabled = False
                    Button8.Text = SymbolPC
                ElseIf Button9.Enabled = True Then
                    Button9.Enabled = False
                    Button9.Text = SymbolPC
                End If
            End If
        End If
        Whowins()
    End Sub

End Class
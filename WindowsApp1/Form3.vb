Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Mes Documents\Etudes 2 sem\Projet Intégré\Piano tiles\PianoTile1.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad1
                Button1.PerformClick()
            Case Keys.NumPad2
                Button2.PerformClick()
            Case Keys.NumPad3
                Button3.PerformClick()
            Case Keys.NumPad4
                Button4.PerformClick()
            Case Keys.NumPad5
                Button5.PerformClick()
            Case Keys.NumPad6
                Button6.PerformClick()
            Case Keys.NumPad7
                Button7.PerformClick()
            Case Keys.NumPad8
                Button8.PerformClick()
            Case Keys.NumPad9
                Button9.PerformClick()
            Case Keys.NumPad0
                Button0.PerformClick()
            Case Keys.Q
                Buttonq.PerformClick()
            Case Keys.W
                Buttonw.PerformClick()
            Case Keys.E
                Buttone.PerformClick()
            Case Keys.R
                Buttonr.PerformClick()
            Case Keys.T
                Buttont.PerformClick()
            Case Keys.Y
                Buttony.PerformClick()
            Case Keys.U
                Buttonu.PerformClick()
            Case Keys.I
                Buttoni.PerformClick()
            Case Keys.O
                Buttono.PerformClick()
            Case Keys.P
                Buttonp.PerformClick()
            Case Keys.A
                Buttona.PerformClick()
            Case Keys.S
                Buttons.PerformClick()
            Case Keys.D
                Buttond.PerformClick()
            Case Keys.F
                Buttonf.PerformClick()
            Case Keys.G
                Buttong.PerformClick()
            Case Keys.H
                Buttonh.PerformClick()
            Case Keys.J
                Buttonj.PerformClick()
            Case Keys.K
                Buttonk.PerformClick()
            Case Keys.L
                Buttonl.PerformClick()
            Case Keys.Z
                Buttonz.PerformClick()
            Case Keys.X
                Buttonx.PerformClick()
            Case Keys.C
                Buttonc.PerformClick()
            Case Keys.V
                Buttonv.PerformClick()
            Case Keys.B
                Buttonb.PerformClick()
            Case Keys.N
                Buttonn.PerformClick()
            Case Keys.M
                Buttonm.PerformClick()
            Case Keys.D1 + Keys.Shift
                ButtonM1.PerformClick()
            Case Keys.D2 + Keys.Shift
                ButtonM2.PerformClick()
            Case Keys.D4 + Keys.Shift
                ButtonM4.PerformClick()
            Case Keys.D5 + Keys.Shift
                ButtonM5.PerformClick()
            Case Keys.D6 + Keys.Shift
                ButtonM6.PerformClick()
            Case Keys.D8 + Keys.Shift
                ButtonM8.PerformClick()
            Case Keys.D9 + Keys.Shift
                ButtonM9.PerformClick()
            Case Keys.Q + Keys.Shift
                ButtonMq.PerformClick()
            Case Keys.W + Keys.Shift
                ButtonMw.PerformClick()
            Case Keys.E + Keys.Shift
                ButtonMe.PerformClick()
            Case Keys.T + Keys.Shift
                ButtonMt.PerformClick()
            Case Keys.Y + Keys.Shift
                ButtonMy.PerformClick()
            Case Keys.I + Keys.Shift
                ButtonMi.PerformClick()
            Case Keys.O + Keys.Shift
                ButtonMo.PerformClick()
            Case Keys.P + Keys.Shift
                ButtonMp.PerformClick()
            Case Keys.S + Keys.Shift
                ButtonMs.PerformClick()
            Case Keys.D + Keys.Shift
                ButtonMd.PerformClick()
            Case Keys.G + Keys.Shift
                ButtonMg.PerformClick()
            Case Keys.H + Keys.Shift
                ButtonMh.PerformClick()
            Case Keys.J + Keys.Shift
                ButtonMj.PerformClick()
            Case Keys.L + Keys.Shift
                ButtonMl.PerformClick()
            Case Keys.Z + Keys.Shift
                ButtonMz.PerformClick()
            Case Keys.C + Keys.Shift
                ButtonMc.PerformClick()
            Case Keys.V + Keys.Shift
                ButtonMv.PerformClick()
            Case Keys.B + Keys.Shift
                ButtonMb.PerformClick()
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Mes Documents\Etudes 2 sem\Piano tiles\PianoTile8.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttono_Click(sender As Object, e As EventArgs) Handles Buttono.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Mes Documents\Etudes 2 sem\Piano tiles\PianoTileo.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Mes Documents\Etudes 2 sem\Piano tiles\PianoTile9.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Mes Documents\Etudes 2 sem\Piano tiles\PianoTile0.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonq_Click(sender As Object, e As EventArgs) Handles Buttonq.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\\Mes Documents\Etudes 2 sem\Piano tiles\PianoTileq.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonw_Click(sender As Object, e As EventArgs) Handles Buttonw.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilew.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttone_Click(sender As Object, e As EventArgs) Handles Buttone.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilee.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonr_Click(sender As Object, e As EventArgs) Handles Buttonr.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTiler.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttont_Click(sender As Object, e As EventArgs) Handles Buttont.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilet.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttony_Click(sender As Object, e As EventArgs) Handles Buttony.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTiley.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonu_Click(sender As Object, e As EventArgs) Handles Buttonu.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileu.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttoni_Click(sender As Object, e As EventArgs) Handles Buttoni.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilei.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile2.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile3.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile4.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile5.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile6.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile7.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonp_Click(sender As Object, e As EventArgs) Handles Buttonp.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilep.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttona_Click(sender As Object, e As EventArgs) Handles Buttona.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilea.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Buttons.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTiles.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttond_Click(sender As Object, e As EventArgs) Handles Buttond.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTiled.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonf_Click(sender As Object, e As EventArgs) Handles Buttonf.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilef.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttong_Click(sender As Object, e As EventArgs) Handles Buttong.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileg.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonh_Click(sender As Object, e As EventArgs) Handles Buttonh.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileh.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonj_Click(sender As Object, e As EventArgs) Handles Buttonj.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilej.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonk_Click(sender As Object, e As EventArgs) Handles Buttonk.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilek.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonl_Click(sender As Object, e As EventArgs) Handles Buttonl.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilel.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonz_Click(sender As Object, e As EventArgs) Handles Buttonz.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilez.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonx_Click(sender As Object, e As EventArgs) Handles Buttonx.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilex.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonc_Click(sender As Object, e As EventArgs) Handles Buttonc.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilec.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonv_Click(sender As Object, e As EventArgs) Handles Buttonv.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilev.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonb_Click(sender As Object, e As EventArgs) Handles Buttonb.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileb.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonM1_Click(sender As Object, e As EventArgs) Handles ButtonM1.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile1M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonm_Click(sender As Object, e As EventArgs) Handles Buttonm.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilem.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Buttonn_Click(sender As Object, e As EventArgs) Handles Buttonn.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilen.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMv_Click(sender As Object, e As EventArgs) Handles ButtonMv.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile2M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMc_Click(sender As Object, e As EventArgs) Handles ButtonMc.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilecM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMz_Click(sender As Object, e As EventArgs) Handles ButtonMz.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilezM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMl_Click(sender As Object, e As EventArgs) Handles ButtonMl.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilelM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMj_Click(sender As Object, e As EventArgs) Handles ButtonMj.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilejM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMh_Click(sender As Object, e As EventArgs) Handles ButtonMh.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilehM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMg_Click(sender As Object, e As EventArgs) Handles ButtonMg.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilegM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMd_Click(sender As Object, e As EventArgs) Handles ButtonMd.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTiledM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMs_Click(sender As Object, e As EventArgs) Handles ButtonMs.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilesM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMp_Click(sender As Object, e As EventArgs) Handles ButtonMp.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilepM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMo_Click(sender As Object, e As EventArgs) Handles ButtonMo.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileoM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMi_Click(sender As Object, e As EventArgs) Handles ButtonMi.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileiM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMy_Click(sender As Object, e As EventArgs) Handles ButtonMy.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileyM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMt_Click(sender As Object, e As EventArgs) Handles ButtonMt.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTiletM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMe_Click(sender As Object, e As EventArgs) Handles ButtonMe.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileeM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMw_Click(sender As Object, e As EventArgs) Handles ButtonMw.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilewM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMq_Click(sender As Object, e As EventArgs) Handles ButtonMq.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTileqM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonM9_Click(sender As Object, e As EventArgs) Handles ButtonM9.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile9M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonM8_Click(sender As Object, e As EventArgs) Handles ButtonM8.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile8M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonM6_Click(sender As Object, e As EventArgs) Handles ButtonM6.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile6M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonM5_Click(sender As Object, e As EventArgs) Handles ButtonM5.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile5M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonM4_Click(sender As Object, e As EventArgs) Handles ButtonM4.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile4M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonM2_Click(sender As Object, e As EventArgs) Handles ButtonM2.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTile2M.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub ButtonMb_Click(sender As Object, e As EventArgs) Handles ButtonMb.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer
        spath = "C:\Users\simob\OneDrive\Bureau\Shitty review\Projet Intégré\Piano tiles\PianoTilebM.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form5.ShowDialog()
    End Sub
End Class
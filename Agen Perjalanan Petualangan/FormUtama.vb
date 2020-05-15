Public Class FormUtama

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'menutup form
        Me.Close()
    End Sub

    Private Sub mnuPaketScuba_Click(sender As Object, e As EventArgs) Handles mnuPaketScuba.Click
        'menciptakan sebuah instansi dari FormScuba
        Dim frmScuba As New FormScuba

        'menampilkan FormScuba dengan gaya modal
        frmScuba.ShowDialog()
    End Sub

    Private Sub mnuPaketSkyDiving_Click(sender As Object, e As EventArgs) Handles mnuPaketSkyDiving.Click
        'menciptakan sebuah instansi dari FormSkyDive
        Dim frmSkyDive As New FormSkyDive

        'menampilkan FormSkyDive dengan gaya modal
        frmSkyDive.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'menampilkan kotak About sederhana
        MessageBox.Show("Aplikasi Agen Perjalanan Petualangan Versi 1.0")
    End Sub

    Private Sub MnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click

    End Sub
End Class

Public Class FormSkyDive

    Private Sub tombolHitungTotal_Click(sender As Object, e As EventArgs) Handles tombolHitungTotal.Click
        'konstanta untuk harga per orang untuk paket ini
        Const decHARGA_SKYDIVE_PER_ORANG As Decimal = 25000000D

        'variabel lokal
        Dim intBanyakOrang As Integer 'banyak orang
        Dim decDiskon As Decimal      'jumlah diskon
        Dim decTotal As Decimal       'biaya total

        Try
            'membaca banyak orang
            intBanyakOrang = CInt(teksBanyakOrang.Text)

            'menghitung total sebelum diskon diterapkan
            decTotal = intBanyakOrang * decHARGA_SKYDIVE_PER_ORANG

            'menentukan apakah diskon dapat diberikan atau tidak
            If intBanyakOrang >= g_intMINIMUM_UNTUK_DISKON Then
                'menghitung jumlah diskon
                decDiskon = HitungDiskon(decTotal)

                'mengurangkan diskon dari total
                decTotal = decTotal - decDiskon
            Else
                'diskon Rp. 0.
                decDiskon = 0D
            End If

            'menampilkan hasil
            labelDiskon.Text = "Rp. " & decDiskon.ToString()
            labelTotal.Text = "Rp. " & decTotal.ToString()
        Catch ex As Exception
            'pesan error untuk masukan tak valid
            MessageBox.Show("Masukkan integer valid untuk banyak orang.")
        End Try
    End Sub

    Private Sub tombolReset_Click(sender As Object, e As EventArgs) Handles tombolReset.Click
        'membersihkan kotak teks dan label
        teksBanyakOrang.Clear()
        labelDiskon.Text = String.Empty
        labelTotal.Text = String.Empty

        'mengatur fokus
        teksBanyakOrang.Focus()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
Module ModulHitungHarga
    'Konstanta-konstanta global
    Public Const g_intMINIMUM_UNTUK_DISKON As Integer = 5
    Public Const g_decPERSEN_DISKON As Decimal = 0.1D

    'Fungsi HitungDiskon menerima sebuah total paket sebagai
    'argumennya dan menghasilkan jumlah diskon dari 
    'total tersebut
    Public Function HitungDiskon(decTotal As Decimal) As Decimal
        Dim decDiskon As Decimal   'untuk menampung diskon

        'menghitung diskon
        decDiskon = decTotal * g_decPERSEN_DISKON

        'menghasilkan (menjadikan nilai balik) 
        Return decDiskon
    End Function
End Module

Imports System.Data.SqlClient

Public Class Sepet
    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")
    Dim tablo As New DataTable

    Sub SepeteEkle(sorgu As String)

        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            Dim komut As New SqlCommand(sorgu, baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()

        Catch ex As Exception
            baglanti.Close()
            MessageBox.Show("Böyle bir kayıt bulunuyor!", "Uyarı")
        End Try
    End Sub

    Sub SepetTemizle()

        baglanti.Open()
        Dim komut As New SqlCommand("delete from Sepet", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()

    End Sub



    Sub TextlereMusteriGetir(MusteriID As TextBox, AdiSoyadi As TextBox, Telefon As TextBox)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from Musteri where MusteriID= '" & MusteriID.Text & "'", baglanti)

        Dim reader As SqlDataReader
        reader = komut.ExecuteReader

        While reader.Read()
            AdiSoyadi.Text = reader(1)
            Telefon.Text = reader(2)

        End While
        baglanti.Close()
    End Sub

    Sub TextlereUrunGetir(barkodno As TextBox, kategori As TextBox, marka As TextBox, urunadi As TextBox, birim As TextBox, birimfiyati As TextBox, miktar As TextBox, toplamfiyati As TextBox)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from Urun where BarkodNo= '" & barkodno.Text & "'", baglanti)

        Dim reader As SqlDataReader
        reader = komut.ExecuteReader

        While reader.Read()
            kategori.Text = reader(1)
            marka.Text = reader(2)
            urunadi.Text = reader(3)
            birim.Text = reader(5)
            birimfiyati.Text = reader(7)
            toplamfiyati.Text = (Double.Parse(miktar.Text) * Double.Parse(birimfiyati.Text)).ToString("0.00")
        End While
        baglanti.Close()
    End Sub


    Sub Kaydet2(command As SqlCommand, sorgu As String)
        Try
            baglanti.Open()
            command.Connection = baglanti
            command.CommandText = sorgu
            command.ExecuteNonQuery()
            baglanti.Close()

        Catch ex As Exception
            MessageBox.Show("Böyle bir Barkod No bulunuyor!", "Uyarı")
        End Try
    End Sub

    Sub KayitGetir(sorgu As String, dgrid As DataGridView)

        tablo.Clear()
        Dim adtr As New SqlDataAdapter(sorgu, baglanti)
        adtr.Fill(tablo)
        dgrid.DataSource = tablo

    End Sub

End Class

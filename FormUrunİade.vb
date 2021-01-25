Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormUrunİade
    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub

    Dim S As New Stok

    Private Sub TextBarkodNo_TextChanged(sender As Object, e As EventArgs) Handles TextBarkodNo.TextChanged
        Dim miktar As New Label
        Dim toplamfiyat As New TextBox
        S.TextlereUrunGetir(TextBarkodNo, TextKategori, TextMarka, TextUrunAdi, miktar, TextBirim, toplamfiyat, TextBirimFiyati)

        Try
            TextToplamFiyat.Text = Double.Parse(TextMiktar.Text) * Double.Parse(TextBirimFiyati.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextMiktar_TextChanged(sender As Object, e As EventArgs) Handles TextMiktar.TextChanged
        Try
            TextToplamFiyat.Text = Double.Parse(TextMiktar.Text) * Double.Parse(TextBirimFiyati.Text)
        Catch ex As Exception

        End Try
    End Sub

    Dim spt As New Sepet

    Private Sub ButonİadeAl_Click(sender As Object, e As EventArgs) Handles ButonİadeAl.Click

        Dim sorgu As String = "insert into Satis(barkodno, kategori, marka, urunadi, miktar, birim, birimfiyati, toplamfiyat, odemeturu, tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktar,@birim,@birimfiyati,@toplamfiyat,@odemeturu,@tarih)"
        Dim komut As New SqlCommand()

        komut.Parameters.AddWithValue("@barkodno", TextBarkodNo.Text)
        komut.Parameters.AddWithValue("@kategori", TextKategori.Text)
        komut.Parameters.AddWithValue("@marka", TextMarka.Text)
        komut.Parameters.AddWithValue("@urunadi", TextUrunAdi.Text)
        komut.Parameters.AddWithValue("@miktar", Double.Parse(TextMiktar.Text))
        komut.Parameters.AddWithValue("@birim", TextBirim.Text)
        komut.Parameters.AddWithValue("@birimfiyati", Double.Parse(TextBirimFiyati.Text))
        komut.Parameters.AddWithValue("@toplamfiyat", Double.Parse(TextToplamFiyat.Text) * (-1))
        komut.Parameters.AddWithValue("@odemeturu", "İade")
        komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString())

        spt.Kaydet2(komut, sorgu)

        Dim sorgu2 As String = "update urun set miktar=miktar+@miktar where barkodno=@barkodno"
        Dim komut2 As New SqlCommand()
        komut2.Parameters.AddWithValue("@barkodno", TextBarkodNo.Text)
        komut2.Parameters.AddWithValue("@miktar", Double.Parse(TextMiktar.Text))
        spt.Kaydet2(komut2, sorgu2)

        MessageBox.Show("İşlem başarılı!")

    End Sub

    Private Sub FormUrunİade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormUrunİade").Assembly)

        LabelBarkodNo.Text = resM.GetString("Barkod No")
        LabelKategori.Text = resM.GetString("Kategori")
        LabelMarka.Text = resM.GetString("Marka")
        LabelUrunAdi.Text = resM.GetString("Ürün Adı")
        LabelMiktar.Text = resM.GetString("Miktar")
        LabelBirim.Text = resM.GetString("Birim")
        LabelBirimFiyati.Text = resM.GetString("Birim Fiyatı")
        LabelToplamFiyat.Text = resM.GetString("Toplam Fiyat")
        ButonİadeAl.Text = resM.GetString("Ürün İade")
        Butonİptal.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Ürün İade")
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormSatis

    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")
    Dim spt As New Sepet

    Sub FiyatYenile()

        LabelKayitSayisi.Text = DataGridView1.Rows.Count - 1

        Dim toplamtutar As Double = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            toplamtutar += DataGridView1.Rows(i).Cells("toplamfiyat").Value
            TextToplam.Text = toplamtutar.ToString("0.00")

        Next
    End Sub

    Private Sub FormSatis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormSatis").Assembly)

        LabelMusteriID.Text = resM.GetString("Müşteri ID")
        LabelAdiSoyadi.Text = resM.GetString("Adı Soyadı")
        LabelTelefon.Text = resM.GetString("Telefon")
        LabelBarkodNo.Text = resM.GetString("Barkod No")
        LabelKategori.Text = resM.GetString("Kategori")
        LabelMarka.Text = resM.GetString("Marka")
        LabelUrunAdi.Text = resM.GetString("Ürün Adı")
        LabelMiktar.Text = resM.GetString("Miktar")
        LabelBirim.Text = resM.GetString("Birim")
        LabelBirimFiyati.Text = resM.GetString("Birim Fiyatı")
        LabelToplamFiyati.Text = resM.GetString("Toplam Fiyat")
        ButonSepeteEkle.Text = resM.GetString("Ekle")
        LabelToplam.Text = resM.GetString("Toplam")
        LabelOdemeler.Text = resM.GetString("Ödemeler")
        LabelOdemeTuru.Text = resM.GetString("Ödeme Türü")
        LabelNakit.Text = resM.GetString("Nakit(F1)")
        LabelKrediKarti.Text = resM.GetString("Kredi Kartı(F2)")
        LabelOdenen.Text = resM.GetString("Ödenen")
        LabelParaUstu.Text = resM.GetString("Para Üstü")
        ButonSatisYap.Text = resM.GetString("Satış Yap")
        ButonYazdir.Text = resM.GetString("Yazdır")
        ButonAnaSayfa.Text = resM.GetString("Ana Sayfa")
        ButonUrunİade.Text = resM.GetString("Ürün İade")
        ButonSatisİptal.Text = resM.GetString("Satış İptal")
        LabelToplamKayit.Text = resM.GetString("Toplam Kayıt")




        spt.KayitGetir("select * from sepet", DataGridView1)
        FiyatYenile()
        TextBarkodNo.Focus()

    End Sub

    Sub Temizle()
        For Each control As Control In Me.PanelMusteri.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub TextMusteriID_TextChanged(sender As Object, e As EventArgs) Handles TextMusteriID.TextChanged
        If TextMusteriID.Text = "" Then
            Temizle()
        End If

        spt.TextlereMusteriGetir(TextMusteriID, TextAdiSoyadi, TextTelefon)

    End Sub

    Private Sub TextBarkodNo_TextChanged(sender As Object, e As EventArgs) Handles TextBarkodNo.TextChanged
        If TextBarkodNo.Text = "" Then
            For Each control As Control In Me.PanelUrun.Controls
                If TypeOf control Is TextBox Then
                    If control.Name <> TextMiktar.Name Then
                        control.Text = ""
                    End If
                End If
            Next
        End If

        spt.TextlereUrunGetir(TextBarkodNo, TextKategori, TextMarka, TextUrunAdi, TextBirim, TextBirimFiyati, TextMiktar, TextToplamFiyati)
    End Sub

    Private Sub TextMiktar_TextChanged(sender As Object, e As EventArgs) Handles TextMiktar.TextChanged
        Try
            TextToplamFiyati.Text = (Double.Parse(TextMiktar.Text) * Double.Parse(TextBirimFiyati.Text)).ToString()

        Catch ex As Exception

        End Try
    End Sub

    Dim secim As New Boolean

    Sub BarkodKontrol()
        secim = True
        baglanti.Open()
        Dim komut As New SqlCommand("select * from sepet ", baglanti)
        Dim reader As SqlDataReader = komut.ExecuteReader

        While reader.Read
            If TextBarkodNo.Text = reader("barkodno") Then
                secim = False
            End If

        End While
        baglanti.Close()

    End Sub

    Private Sub ButonSepeteEkle_Click(sender As Object, e As EventArgs) Handles ButonSepeteEkle.Click
        BarkodKontrol()
        If secim = True Then

            Dim sorgu As String = "insert into Sepet values('" & TextMusteriID.Text & "','" & TextAdiSoyadi.Text & "','" & TextBarkodNo.Text & "','" & TextKategori.Text & "','" & TextMarka.Text & "','" & TextUrunAdi.Text & "',@Miktar,'" & TextBirim.Text & "',@BirimFiyati,@ToplamFiyati,'" & DateTime.Now.ToString() & "')"
            Dim komut As New SqlCommand()
            komut.Parameters.AddWithValue("@Miktar", Double.Parse(TextMiktar.Text))
            komut.Parameters.AddWithValue("@BirimFiyati", Double.Parse(TextBirimFiyati.Text))
            komut.Parameters.AddWithValue("@ToplamFiyati", Double.Parse(TextToplamFiyati.Text))

            spt.Kaydet2(komut, sorgu)

        Else
            Dim sorgu2 As String = "update sepet set miktar=miktar+'" & Double.Parse(TextMiktar.Text) & "' where barkodno='" & TextBarkodNo.Text & "'"
            Dim komut2 As New SqlCommand()

            Dim sorgu3 As String = "update sepet set toplamfiyat=miktar*birimfiyati   where barkodno='" & TextBarkodNo.Text & "'"
            Dim komut3 As New SqlCommand()

            spt.Kaydet2(komut2, sorgu2)
            spt.Kaydet2(komut2, sorgu3)
        End If

        TextBarkodNo.Text = ""
        TextMiktar.Text = "1"
        spt.KayitGetir("select * from sepet", DataGridView1)
        FiyatYenile()
        TextBarkodNo.Focus()
    End Sub

    Private Sub ButonSatisİptal_Click(sender As Object, e As EventArgs) Handles ButonSatisİptal.Click
        spt.SepetTemizle()
        spt.KayitGetir("select * from sepet", DataGridView1)
        FiyatYenile()
        TextBarkodNo.Focus()
    End Sub

    Private Sub FormSatis_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            ComboOdemeTuru.SelectedIndex = 0
            TextOdenen.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            ComboOdemeTuru.SelectedIndex = 1
            TextOdenen.Text = TextToplam.Text
            TextParaUstu.Text = "0,00"
            TextOdenen.Focus()
        End If

        If e.KeyCode = Keys.F3 Then
            TextOdenen.Focus()

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 0 Then

            baglanti.Open()
            Dim komut2 As New SqlCommand("delete from sepet where  barkodno= '" & DataGridView1.CurrentRow.Cells("barkodno").Value.ToString & "'", baglanti)
            komut2.ExecuteNonQuery()
            baglanti.Close()
            spt.KayitGetir("select * from sepet", DataGridView1)
            FiyatYenile()
            TextBarkodNo.Focus()

        End If
    End Sub

    Private Sub ComboOdemeTuru_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboOdemeTuru.SelectedIndexChanged
        If ComboOdemeTuru.SelectedIndex = 1 Then
            TextOdenen.Text = TextToplam.Text
            TextParaUstu.Text = "0,00"



        End If
    End Sub

    Private Sub TextOdenen_TextChanged(sender As Object, e As EventArgs) Handles TextOdenen.TextChanged
        Try
            TextParaUstu.Text = (-Double.Parse(TextToplam.Text) + Double.Parse(TextOdenen.Text)).ToString("0.00")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        baglanti.Open()
        Dim komut As New SqlCommand("update sepet set miktar='" & DataGridView1.CurrentRow.Cells("miktar").Value & "' where barkodno='" & DataGridView1.CurrentRow.Cells("barkodno").Value.ToString() & "'", baglanti)
        komut.ExecuteNonQuery()
        Dim komut2 As New SqlCommand("update sepet set toplamfiyat = miktar * birimfiyati where barkodno='" & DataGridView1.CurrentRow.Cells("barkodno").Value.ToString() & "'", baglanti)
        komut2.ExecuteNonQuery()
        baglanti.Close()
        spt.KayitGetir("select * from sepet", DataGridView1)
        FiyatYenile()
        TextBarkodNo.Focus()
    End Sub

    Private Sub ButonSatisYap_Click(sender As Object, e As EventArgs) Handles ButonSatisYap.Click
        If DataGridView1.Rows.Count > 1 Then

            For i = 0 To DataGridView1.Rows.Count - 2
                Dim sorgu As String = "insert into satis values(@musteriid,@adisoyadi,@barkodno,@kategori,@marka,@urunadi,@miktar,@birim,@birimfiyati,@toplamfiyat,@odemeturu,@tarih)"
                Dim komut As New SqlCommand()
                komut.Parameters.AddWithValue("@musteriid", DataGridView1.Rows(i).Cells("musteriid").Value.ToString())
                komut.Parameters.AddWithValue("@adisoyadi", DataGridView1.Rows(i).Cells("adisoyadi").Value.ToString())
                komut.Parameters.AddWithValue("@barkodno", DataGridView1.Rows(i).Cells("barkodno").Value.ToString())
                komut.Parameters.AddWithValue("@kategori", DataGridView1.Rows(i).Cells("kategori").Value.ToString())
                komut.Parameters.AddWithValue("@marka", DataGridView1.Rows(i).Cells("marka").Value.ToString())
                komut.Parameters.AddWithValue("@urunadi", DataGridView1.Rows(i).Cells("urunadi").Value.ToString())
                komut.Parameters.AddWithValue("@miktar", Double.Parse(DataGridView1.Rows(i).Cells("miktar").Value.ToString()))
                komut.Parameters.AddWithValue("@birim", DataGridView1.Rows(i).Cells("birim").Value.ToString())
                komut.Parameters.AddWithValue("@birimfiyati", Double.Parse(DataGridView1.Rows(i).Cells("birimfiyati").Value.ToString()))
                komut.Parameters.AddWithValue("@toplamfiyat", Double.Parse(DataGridView1.Rows(i).Cells("toplamfiyat").Value.ToString()))
                komut.Parameters.AddWithValue("@odemeturu", ComboOdemeTuru.Text)
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString())

                spt.Kaydet2(komut, sorgu)

                Dim sorgu2 As String = "update urun set miktar=miktar-@miktar where barkodno=@barkodno"
                Dim komut2 As New SqlCommand()
                komut2.Parameters.AddWithValue("@barkodno", DataGridView1.Rows(i).Cells("barkodno").Value.ToString)
                komut2.Parameters.AddWithValue("@miktar", Double.Parse(DataGridView1.Rows(i).Cells("miktar").Value.ToString()))
                spt.Kaydet2(komut2, sorgu2)
            Next
            MessageBox.Show("İşlem başarılı!")

            spt.SepetTemizle()
            spt.KayitGetir("select * from sepet", DataGridView1)
            FiyatYenile()
            TextBarkodNo.Focus()
        Else
            MessageBox.Show("İşlem başarısız! Hiç kayıt yok!")

        End If
    End Sub

    Private Sub ButonUrunİade_Click(sender As Object, e As EventArgs) Handles ButonUrunİade.Click
        FormUrunİade.ShowDialog()

    End Sub

End Class
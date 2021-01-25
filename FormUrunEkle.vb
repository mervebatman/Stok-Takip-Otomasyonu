Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormUrunEkle

    Dim S As New Stok
    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")

    Private Sub FormUrunEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormUrunEkle").Assembly)

        LabelBarkodNo.Text = resM.GetString("Barkod No")
        LabelKategori.Text = resM.GetString("Kategori")
        LabelMarka.Text = resM.GetString("Marka")
        LabelUrunAdi.Text = resM.GetString("Ürün Adı")
        LabelMiktar.Text = resM.GetString("Miktar")
        LabelBirim.Text = resM.GetString("Birim")
        LabelAlisFiyati.Text = resM.GetString("Alış Fiyatı")
        LabelSatisFiyati.Text = resM.GetString("Satış Fiyatı")
        ButonEkle.Text = resM.GetString("Ekle")
        ButonCikis.Text = resM.GetString("İptal")
        LabelBarkodNo2.Text = resM.GetString("Barkod No")
        LabelKategori2.Text = resM.GetString("Kategori")
        LabelMarka2.Text = resM.GetString("Marka")
        LabelUrunAdi2.Text = resM.GetString("Ürün Adı")
        LabelMiktar2.Text = resM.GetString("Miktar")
        LabelBirim2.Text = resM.GetString("Birim")
        LabelAlisFiyati2.Text = resM.GetString("Alış Fiyatı")
        LabelSatisFiyati2.Text = resM.GetString("Satış Fiyatı")
        ButonGuncelle.Text = resM.GetString("Güncelle")
        Butonİptal.Text = resM.GetString("İptal")
        Label17.Text = resM.GetString("Miktar")

        S.ComboyaGetir(ComboKategori, "select * from Kategori")
        S.ComboyaGetir(ComboBirim, "select * from Birim")
    End Sub

    Private Sub ComboKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboKategori.SelectedIndexChanged
        S.ComboyaGetir(ComboMarka, "select marka from Marka where Kategori = '" & ComboKategori.Text & "'")
    End Sub

    Private Sub ButonEkle_Click(sender As Object, e As EventArgs) Handles ButonEkle.Click

        Dim sorgu As String = "insert into Urun values('" & TextBarkodNo.Text & "','" & ComboKategori.Text & "','" & ComboMarka.Text & "','" & TextUrunAdi.Text & "',@Miktar,'" & ComboBirim.Text & "',@AlisFiyati,@SatisFiyati,'" & DateTime.Now.ToString() & "')"
        Dim komut As New SqlCommand()
        komut.Parameters.AddWithValue("@Miktar", Double.Parse(TextMiktari.Text))
        komut.Parameters.AddWithValue("@AlisFiyati", Double.Parse(TextAlisFiyati.Text))
        komut.Parameters.AddWithValue("@SatisFiyati", Double.Parse(TextSatisFiyati.Text))

        S.Kaydet2(komut, sorgu)

    End Sub

    Private Sub ButonCikis_Click(sender As Object, e As EventArgs) Handles ButonCikis.Click
        Me.Close()
    End Sub

    Private Sub TextBarkodNo2_TextChanged(sender As Object, e As EventArgs) Handles TextBarkodNo2.TextChanged
        S.TextlereUrunGetir(TextBarkodNo2, TextKategori2, TextMarka2, TextUrunAdi2, Label17, TextBirim2, TextAlisFiyati2, TextSatisFiyati2)

    End Sub

    Private Sub ButonGuncelle_Click(sender As Object, e As EventArgs) Handles ButonGuncelle.Click
        S.Kaydet("update urun set miktar=miktar+ '" & Double.Parse(TextMiktar2.Text) & "', tarih='" & DateTime.Now.ToString & "' where BarkodNo= '" & TextBarkodNo2.Text & "'")
    End Sub

    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub
End Class
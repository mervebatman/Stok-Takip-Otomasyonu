Imports System.Globalization
Imports System.Resources
Imports System.Threading


Public Class FormYeniKullanici
    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub

    Dim K As New Kullanici

    Private Sub ButonEkle_Click(sender As Object, e As EventArgs) Handles ButonEkle.Click
        K.YeniKullanici(TextKullaniciYetkisi.Text, TextAdiSoyadi.Text, TextTelefon.Text, TextAdres.Text, TextKullaniciAdi.Text, TextSifre.Text, TextSoru.Text, TextCevap.Text, DateTime.Now.ToShortDateString)
    End Sub

    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""

            End If
        Next
    End Sub

    Private Sub FormYeniKullanici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormYeniKullanici").Assembly)

        LabelAdiSoyadi.Text = resM.GetString("Adı Soyadı")
        LabelTelefon.Text = resM.GetString("Telefon")
        LabelAdres.Text = resM.GetString("Adres")
        LabelKullaniciAdi.Text = resM.GetString("Kullanıcı Adı")
        LabelSifre.Text = resM.GetString("Parola")
        LabelSoru.Text = resM.GetString("Soru")
        LabelCevap.Text = resM.GetString("Cevap")
        Butonİptal.Text = resM.GetString("İptal")
        LabelAciklama.Text = resM.GetString("(*)Kullanıcı yetkisi 1 rakamı için yönetici, 2 rakamı için personeli ifade etmektedir!")
        LabelKullaniciYetkisi.Text = resM.GetString("Yeni Kullanıcı")
        ButonEkle.Text = resM.GetString("Ekle")
        Me.Text = resM.GetString("Yeni Kullanıcı")


    End Sub
End Class
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormSifremiUnuttum

    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""

            End If
        Next
    End Sub

    Dim K As New Kullanici

    Private Sub ButonGuncelle_Click(sender As Object, e As EventArgs) Handles ButonGuncelle.Click
        K.SifremiUnuttum(TextKullaniciAdi.Text, TextSoru.Text, TextCevap.Text, TextSifre.Text, TextSifreTekrar.Text, TextAdiSoyadi.Text, TextTelefon.Text, TextAdres.Text)
    End Sub

    Private Sub FormSifremiUnuttum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormSifremiUnuttum").Assembly)

        LabelKullaniciAdi.Text = resM.GetString("Kullanıcı Adı")
        LabelSoru.Text = resM.GetString("Soru")
        LabelCevap.Text = resM.GetString("Cevap")
        LabelSifre.Text = resM.GetString("Parola")
        LabelSifreTekrar.Text = resM.GetString("Şifre Tekrar")
        LabelAdiSoyadi.Text = resM.GetString("Adı Soyadı")
        LabelTelefon.Text = resM.GetString("Telefon")
        LabelAdres.Text = resM.GetString("Adres")
        ButonGuncelle.Text = resM.GetString("Güncelle")
        Butonİptal.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Şifremi Unuttum")
    End Sub
End Class
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormMusteriEkle
    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub

    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Dim S As New Stok

    Private Sub ButonEkle_Click(sender As Object, e As EventArgs) Handles ButonEkle.Click
        S.Kaydet("insert into Musteri values('" & TextMusteriID.Text & "', '" & TextAdiSoyadi.Text & "', '" & TextTelefon.Text & "', '" & TextAdres.Text & "', '" & TextEmail.Text & "')")

    End Sub

    Private Sub FormMusteriEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormAnaSayfa").Assembly)

        LabelMusteriID.Text = resM.GetString("Müşteri ID")
        LabelAdiSoyadi.Text = resM.GetString("Adı Soyadı")
        LabelTelefon.Text = resM.GetString("Telefon")
        LabelAdres.Text = resM.GetString("Adres")
        ButonEkle.Text = resM.GetString("Ekle")
        Butonİptal.Text = resM.GetString("İptal")

    End Sub
End Class
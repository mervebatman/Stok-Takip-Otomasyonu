Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormMarkaEkle

    Dim S As New Stok

    Private Sub ButonEkle_Click(sender As Object, e As EventArgs) Handles ButonEkle.Click
        ' S.Kaydet("insert into Marka values('" & ComboKategori.Text & "', '" & TextMarka.Text & "')")
        S.MarkaEkle(ComboKategori, TextMarka)
        S.ComboyaGetir(ComboKategori, "select * from Kategori")
    End Sub

    Private Sub FormMarka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormMarkaEkle").Assembly)

        LabelKategori.Text = resM.GetString("Kategori")
        LabelMarka.Text = resM.GetString("Marka")
        ButonEkle.Text = resM.GetString("Ekle")
        Butonİptal.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Marka Ekle")




        S.ComboyaGetir(ComboKategori, "select * from Kategori")

    End Sub

    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub
End Class
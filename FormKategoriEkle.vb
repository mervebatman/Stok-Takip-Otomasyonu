Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormKategoriEkle

    Dim S As New Stok

    Private Sub ButonEkle_Click(sender As Object, e As EventArgs) Handles ButonEkle.Click
        S.Kaydet("insert into Kategori values('" & TextKategori.Text & "')")
        TextKategori.Clear()

    End Sub

    Private Sub ButonCikis_Click(sender As Object, e As EventArgs) Handles ButonCikis.Click
        Me.Close()
    End Sub

    Private Sub FormKategoriEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormKategoriEkle").Assembly)

        LabelKategori.Text = resM.GetString("Kategori")
        ButonEkle.Text = resM.GetString("Ekle")
        ButonCikis.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Kategori Ekle")
    End Sub
End Class
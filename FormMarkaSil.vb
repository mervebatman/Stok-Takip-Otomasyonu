Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormMarkaSil
    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub

    Dim S As New Stok

    Private Sub ButonSil_Click(sender As Object, e As EventArgs) Handles ButonSil.Click
        S.Sil("delete from Marka where kategori = '" & ComboKategori.Text & "' and marka = '" & TextMarka.Text & "'")
        S.ComboyaGetir(ComboKategori, "select * from kategori")


    End Sub

    Private Sub FormMarkaSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormMarkaSil").Assembly)

        LabelKategori.Text = resM.GetString("Kategori")
        LabelMarka.Text = resM.GetString("Marka")
        ButonSil.Text = resM.GetString("Sil")
        Butonİptal.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Marka Sil")


        S.ComboyaGetir(ComboKategori, "select * from kategori")
    End Sub
End Class
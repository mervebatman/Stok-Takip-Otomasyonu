Imports System.Globalization
Imports System.Resources
Imports System.Threading


Public Class FormKategoriSil

    Dim S As New Stok

    Private Sub ButonSil_Click(sender As Object, e As EventArgs) Handles ButonSil.Click
        S.Sil("delete from Kategori where kategori = '" & TextKategori.Text & "'")
    End Sub

    Private Sub ButonCikis_Click(sender As Object, e As EventArgs) Handles ButonCikis.Click
        Me.Close()
    End Sub

    Private Sub FormKategoriSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormKategoriSil").Assembly)

        LabelKategori.Text = resM.GetString("Kategori")
        ButonSil.Text = resM.GetString("Sil")
        ButonCikis.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Kategori Sil")
    End Sub
End Class
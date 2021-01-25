Imports System.Globalization
Imports System.Resources
Imports System.Threading


Public Class FormBirimEkle

    Dim S As New Stok

    Private Sub ButonEkle_Click(sender As Object, e As EventArgs) Handles ButonEkle.Click
        S.Kaydet("insert into Birim values('" & TextBirim.Text & "')")

    End Sub

    Private Sub ButonCikis_Click(sender As Object, e As EventArgs) Handles ButonCikis.Click
        Me.Close()
    End Sub

    Private Sub FormBirimEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormBirimEkle").Assembly)

        LabelBirim.Text = resM.GetString("Birim")
        ButonEkle.Text = resM.GetString("Ekle")
        ButonCikis.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Birim Ekle")
    End Sub
End Class
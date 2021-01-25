Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormBirimSil

    Dim S As New Stok

    Private Sub ButonSil_Click(sender As Object, e As EventArgs) Handles ButonSil.Click
        S.Sil("delete from Birim where birim = '" & TextBirim.Text & "'")

    End Sub

    Private Sub ButonCikis_Click(sender As Object, e As EventArgs) Handles ButonCikis.Click
        Me.Close()
    End Sub

    Private Sub FormBirimSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormBirimSil").Assembly)

        LabelBirim.Text = resM.GetString("Birim")
        ButonSil.Text = resM.GetString("Sil")
        ButonCikis.Text = resM.GetString("İptal")
        Me.Text = resM.GetString("Birim Sil")

    End Sub
End Class
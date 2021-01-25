Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormPersonelListele

    Dim S As New Stok

    Private Sub FormPersonelListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormPersonelListele").Assembly)

        LabelPersonelAdiAra.Text = resM.GetString("Personel Adı Ara")
        ButonSil.Text = resM.GetString("Sil")
        LabelAciklama.Text = resM.GetString("(*)Kullanıcı yetkisi 1 rakamı için yönetici, 2 rakamı için personeli ifade etmektedir!")


        S.KayitGetir("select * from Kullanici", DataGridView1)


    End Sub

    Private Sub TextPersonelAdıAra_TextChanged(sender As Object, e As EventArgs) Handles TextPersonelAdıAra.TextChanged
        S.KayitGetir("select * from Kullanici where adisoyadi like '%" & TextPersonelAdıAra.Text & "%'", DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButonSil.Click
        S.Sil("delete from Kullanici where kullaniciadi='" & DataGridView1.CurrentRow.Cells(4).Value.ToString() & "'")
        S.KayitGetir("select * from Kullanici", DataGridView1)
    End Sub
End Class
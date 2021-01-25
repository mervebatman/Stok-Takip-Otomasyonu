Imports System.Globalization
Imports System.Resources
Imports System.Threading



Public Class FormSatisListele

    Dim S As New Stok

    Sub FiyatYenile()

        LabelKayitSayisi.Text = DataGridView1.Rows.Count - 1

        Dim toplamtutar As Double = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            toplamtutar += DataGridView1.Rows(i).Cells("toplamfiyat").Value
            LabelToplamKazanc.Text = toplamtutar.ToString("0.00")

        Next
    End Sub

    Private Sub FormSatisListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormSatisListele").Assembly)

        LabelMusteriAdiAra.Text = resM.GetString("Müşteri ID Ara")
        LabelUrunAdiAra.Text = resM.GetString("Ürün Adı Ara")
        LabelToplamKayit.Text = resM.GetString("Toplam Kayıt")
        LabelToplamKazanc.Text = resM.GetString("Toplam Kazanç")


        S.KayitGetir("select * from satis", DataGridView1)
        FiyatYenile()
    End Sub

    Private Sub TextMusteriAdiAra_TextChanged(sender As Object, e As EventArgs) Handles TextMusteriAdiAra.TextChanged
        S.KayitGetir("select * from satis where adisoyadi like '%" & TextMusteriAdiAra.Text & "%'", DataGridView1)
        FiyatYenile()
    End Sub

    Private Sub TextUrunAdiAra_TextChanged(sender As Object, e As EventArgs) Handles TextUrunAdiAra.TextChanged
        S.KayitGetir("select * from satis where urunadi like '%" & TextUrunAdiAra.Text & "%'", DataGridView1)
        FiyatYenile()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        S.KayitGetir("select * from satis", DataGridView1)
        FiyatYenile()
    End Sub
End Class
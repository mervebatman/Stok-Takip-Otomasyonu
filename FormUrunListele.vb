Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormUrunListele
    Private Const V As Boolean = False
    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")

    Public Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBarkodNo.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextKategori.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextMarka.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextUrunAdi.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextMiktar.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TextBirim.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        TextAlisFiyati.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        TextSatisFiyati.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()


    End Sub

    Dim S As New Stok

    Private Sub FormUrunListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormUrunEkle").Assembly)

        LabelBarkodNoAra.Text = resM.GetString("Barkod No Ara")
        LabelBarkodNo.Text = resM.GetString("Barkod No")
        LabelKategori.Text = resM.GetString("Kategori")
        LabelMarka.Text = resM.GetString("Marka")
        LabelUrunAdi.Text = resM.GetString("Ürün Adı")
        LabelMiktar.Text = resM.GetString("Miktar")
        LabelBirim.Text = resM.GetString("Birim")
        LabelAlisFiyati.Text = resM.GetString("Alış Fiyatı")
        LabelSatisFiyati.Text = resM.GetString("Satış Fiyatı")
        ButonGuncelle.Text = resM.GetString("Güncelle")
        Butonİptal.Text = resM.GetString("İptal")
        LabelKategori2.Text = resM.GetString("Kategori")
        LabelMarka2.Text = resM.GetString("Marka")
        ButonMarkaGuncelle.Text = resM.GetString("Marka Güncelle")
        LabelBirim2.Text = resM.GetString("Birim")
        ButonBirimGuncelle.Text = resM.GetString("Birim Güncelle")
        ButonSil.Text = resM.GetString("Sil")






        S.KayitGetir("select * from Urun", DataGridView1)
        S.ComboyaGetir(ComboKategori, "select * from Kategori")
        S.ComboyaGetir(ComboBirim, "select * from Birim")
        MiktarSorgula()

    End Sub

    Private Sub ComboKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboKategori.SelectedIndexChanged
        S.ComboyaGetir(ComboMarka, "select marka from Marka where kategori= '" & ComboKategori.Text & "'")

    End Sub

    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub

    Private Sub ButonBirimGuncelle_Click(sender As Object, e As EventArgs) Handles ButonBirimGuncelle.Click
        S.Kaydet("update urun set birim= '" & ComboBirim.Text & "' where BarkodNo='" & TextBarkodNo.Text & "'")
        S.KayitGetir("select * from Urun", DataGridView1)

    End Sub

    Private Sub ButonMarkaGuncelle_Click(sender As Object, e As EventArgs) Handles ButonMarkaGuncelle.Click
        S.Kaydet("update urun set kategori= '" & ComboKategori.Text & "',marka='" & ComboMarka.Text & "' where BarkodNo='" & TextBarkodNo.Text & "'")
        S.KayitGetir("select * from Urun", DataGridView1)

    End Sub

    Private Sub ButonSil_Click(sender As Object, e As EventArgs) Handles ButonSil.Click
        S.Sil("delete from Urun where barkodno='" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'")
        S.KayitGetir("select * from Urun", DataGridView1)

    End Sub

    Private Sub TextBarkodNoAra_TextChanged(sender As Object, e As EventArgs) Handles TextBarkodNoAra.TextChanged
        S.KayitGetir("select * from Urun where barkodno like '%" & TextBarkodNoAra.Text & "%'", DataGridView1)
    End Sub

    Private Sub ButonGuncelle_Click(sender As Object, e As EventArgs) Handles ButonGuncelle.Click
        Dim sorgu As String = "update urun set urunadi='" & TextUrunAdi.Text & "', miktar='" & Double.Parse(TextMiktar.Text) & "',alisfiyati=@alisfiyati,satisfiyati=@satisfiyati, tarih = '" & DateTime.Now.ToString() & "' where barkodno= '" & TextBarkodNo.Text & "'"
        Dim komut As New SqlCommand()
        komut.Parameters.AddWithValue("@alisfiyati", Double.Parse(TextAlisFiyati.Text))
        komut.Parameters.AddWithValue("@satisfiyati", Double.Parse(TextSatisFiyati.Text))

        S.Kaydet2(komut, sorgu)
        S.KayitGetir("select * from Urun", DataGridView1)

    End Sub

    Dim daset As New DataSet

    Sub MiktarSorgula()
        baglanti.Open()
        Dim adtr As New SqlDataAdapter("select * from Urun", baglanti)
        adtr.Fill(daset, "Urun")
        DataGridView1.DataSource = daset.Tables("Urun")
        baglanti.Close()
    End Sub


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        For i = 0 To DataGridView1.Rows.Count - 2

            If Decimal.Parse(DataGridView1.Rows(i).Cells(4).Value.ToString()) <= 5 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red

            End If
        Next


    End Sub


End Class
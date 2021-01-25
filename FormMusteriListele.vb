Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormMusteriListele

    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Dim S As New Stok

    Private Sub FormMusteriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormAnaSayfa").Assembly)

        LabelMusteriID.Text = resM.GetString("Müşteri ID")
        LabelAdiSoyadi.Text = resM.GetString("Adı Soyadı")
        LabelTelefon.Text = resM.GetString("Telefon")
        LabelAdres.Text = resM.GetString("Adres")
        ButonGuncelle.Text = resM.GetString("Güncelle")
        Butonİptal.Text = resM.GetString("İptal")
        ButonSil.Text = resM.GetString("Sil")
        LabelMusteriIDAra.Text = resM.GetString("Müşteri ID Ara")




        S.KayitGetir("select * from Musteri", DataGridView1)

    End Sub

    Private Sub TextMusteriIDAra_TextChanged(sender As Object, e As EventArgs) Handles TextMusteriIDAra.TextChanged
        S.KayitGetir("select * from Musteri where MusteriID like '%" & TextMusteriIDAra.Text & "%'", DataGridView1)
    End Sub

    Private Sub ButonGuncelle_Click(sender As Object, e As EventArgs) Handles ButonGuncelle.Click
        S.Kaydet("update Musteri set AdiSoyadi='" & TextAdiSoyadi.Text & "', Telefon='" & TextTelefon.Text & "', Adres='" & TextAdres.Text & "', Email='" & TextEmail.Text & "' where MusteriID='" & TextMusteriID.Text & "'")
        S.KayitGetir("select * from Musteri", DataGridView1)
    End Sub

    Private Sub Butonİptal_Click(sender As Object, e As EventArgs) Handles Butonİptal.Click
        Me.Close()
    End Sub

    Private Sub ButonSil_Click(sender As Object, e As EventArgs) Handles ButonSil.Click
        S.Sil("delete from Musteri where MusteriID='" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'")
        S.KayitGetir("select * from Musteri", DataGridView1)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextMusteriID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextAdiSoyadi.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextTelefon.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextAdres.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextEmail.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()


    End Sub
End Class
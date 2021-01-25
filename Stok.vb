Imports System.Data.SqlClient

Public Class Stok

    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")
    Dim tablo As New DataTable

    Sub Kaydet(sorgu As String)

        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            Dim komut As New SqlCommand(sorgu, baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("İşlem başarılı!")
            FormMusteriEkle.Temizle()
            FormMusteriListele.Temizle()
        Catch ex As Exception
            baglanti.Close()
            MessageBox.Show("Böyle bir kayıt bulunuyor!", "Uyarı")
        End Try
    End Sub

    Sub Kaydet2(command As SqlCommand, sorgu As String)
        Try
            baglanti.Open()
            command.Connection = baglanti
            command.CommandText = sorgu
            command.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("İşlem başarılı!")

        Catch ex As Exception
            MessageBox.Show("Böyle bir Barkod No bulunuyor!", "Uyarı")
        End Try


    End Sub

    Sub Sil(sorgu As String)

        Dim dialog As New DialogResult
        dialog = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Try
                If baglanti.State = ConnectionState.Closed Then
                    baglanti.Open()
                End If

                Dim komut As New SqlCommand(sorgu, baglanti)
                komut.ExecuteNonQuery()
                baglanti.Close()
                MessageBox.Show("Kayıt silindi!")
                FormMusteriEkle.Temizle()
                FormMusteriListele.Temizle()
            Catch ex As Exception
                baglanti.Close()
                MessageBox.Show(ex.Message, "Uyarı")
            End Try

        End If
    End Sub

    Dim secim As New Boolean

    Sub MarkaKontrol(cmbKategori As ComboBox, textMarka As TextBox)

        secim = False
        baglanti.Open()

        Dim komut As New SqlCommand("select * from Marka", baglanti)
        Dim reader As SqlDataReader = komut.ExecuteReader

        While reader.Read
            If reader(0) = cmbKategori.Text And reader(1) = textMarka.Text Or cmbKategori.Text = "" Or textMarka.Text = "" Then
                secim = True
            End If

        End While
        baglanti.Close()
    End Sub

    Sub MarkaEkle(combo As ComboBox, text As TextBox)
        MarkaKontrol(combo, text)
        If secim = False Then
            baglanti.Open()
            Dim komut2 As New SqlCommand("insert into marka values('" & combo.Text & "','" & text.Text & "')", baglanti)
            komut2.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("Marka eklendi!")

        Else
            MessageBox.Show("Böyle bir kayıt bulunuyor!", "Uyarı")
        End If

    End Sub




    Sub ComboyaGetir(Combo As ComboBox, sorgu As String)
        Combo.Items.Clear()
        If baglanti.State = ConnectionState.Closed Then
            baglanti.Open()
        End If

        Dim komut As New SqlCommand(sorgu, baglanti)
        Dim reader As SqlDataReader = komut.ExecuteReader
        While reader.Read
            Combo.Items.Add(reader(0).ToString)
        End While

        baglanti.Close()
    End Sub

    Sub KayitGetir(sorgu As String, dgrid As DataGridView)

        tablo.Clear()
        Dim adtr As New SqlDataAdapter(sorgu, baglanti)
        adtr.Fill(tablo)
        dgrid.DataSource = tablo

    End Sub

    Sub TextlereUrunGetir(barkodno As TextBox, kategori As TextBox, marka As TextBox, urunadi As TextBox, miktar As Label, birim As TextBox, alisfiyati As TextBox, satisfiyati As TextBox)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from Urun where BarkodNo= '" & barkodno.Text & "'", baglanti)

        Dim reader As SqlDataReader
        reader = komut.ExecuteReader

        While reader.Read()
            kategori.Text = reader(1)
            marka.Text = reader(2)
            urunadi.Text = reader(3)
            miktar.Text = reader(4)
            birim.Text = reader(5)
            alisfiyati.Text = reader(6)
            satisfiyati.Text = reader(7)



        End While
        baglanti.Close()
    End Sub


End Class

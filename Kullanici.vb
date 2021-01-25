Imports System.Data.SqlClient

Public Class Kullanici

    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")

    Private _kullaniciadi As String
    Private _sifre As String

    Public Property KullaniciAdi() As String
        Get
            Return _kullaniciadi
        End Get
        Set(value As String)
            _kullaniciadi = value
        End Set
    End Property

    Public Property Sifre() As String
        Get
            Return _sifre
        End Get
        Set(value As String)
            _sifre = value
        End Set
    End Property

    'Sub KullaniciGirisi(Kadi As String, Password As String)

    'KullaniciAdi = Kadi
    'Sifre = Password

    'If KullaniciAdi = "" Or Sifre = "" Then
    '   MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez!", "Uyarı")
    'Else
    'If baglanti.State = ConnectionState.Closed Then
    '   baglanti.Open()
    'End If

    ' Dim komut As New SqlCommand("select * from Kullanici where KullaniciAdi=@kullaniciadi and Sifre=@password", baglanti)
    '  komut.Parameters.AddWithValue("@kullaniciadi",KullaniciAdi.Text)
    'Dim reader As SqlDataReader = komut.ExecuteReader
    'If reader.Read Then
    'If reader(5) = Sifre Then
    'FormKullaniciGirisi.Hide()
    ' FormAnaSayfa.Show()

    ' MessageBox.Show("İşlem başarılı!", "Giriş")
    'FormKullaniciGirisi.Temizle()

    '                Else
    '   MessageBox.Show("Şifrenizi kontrol ediniz!", "Uyarı")
    'End If

    '         Else
    '              MessageBox.Show("Bilgilerinizi kontrol ediniz!", "Uyarı")
    '           End If
    '            baglanti.Close()

    'If baglanti.State = ConnectionState.Closed Then
    '    baglanti.Open()
    ' End If

    'Dim komut2 As New SqlCommand("select * from Kullanici where KullaniciAdi= '" & KullaniciAdi & "'", baglanti)
    'Dim reader2 As SqlDataReader = komut2.ExecuteReader
    'If reader2.Read Then
    'If reader2(5) = Sifre Then
    'FormKullaniciGirisi.Hide()
    'FormYonetici.Show()

    '  MessageBox.Show("Hoş geldiniz!")
    '   FormKullaniciGirisi.Temizle()
    ' Else
    '    MessageBox.Show("Şifrenizi kontrol ediniz!", "Uyarı")
    '  End If
    'Else
    '    MessageBox.Show("Bilgilerinizi kontrol ediniz!", "Uyarı")
    '  End If

    ' baglanti.Close()
    'End If
    '    End Sub

    Sub YeniKullanici(yetki As String, adisoyadi As String, telefon As String, adres As String, kadi As String, sifre As String, soru As String, cevap As String, tarih As String)
        Try
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            Dim komut As New SqlCommand("insert into Kullanici values('" & yetki & "','" & adisoyadi & "','" & telefon & "','" & adres & "', '" & kadi & "', '" & sifre & "', '" & soru & "', '" & cevap & "', '" & tarih & "')", baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("Kayıt eklendi!", "Kayıt")
            FormYeniKullanici.Temizle()
        Catch ex As Exception
            baglanti.Close()
            MessageBox.Show("Böyle bir kullanıcı mevcuttur!", "Uyarı")
        End Try
    End Sub

    Sub SifremiUnuttum(kadi As String, soru As String, cevap As String, password As String, passwordagain As String, adisoyadi As String, telefon As String, adres As String)
        If password = passwordagain Then
            baglanti.Open()
            Dim komut As New SqlCommand("select * from Kullanici where kullaniciAdi='" & kadi & "' and Soru='" & soru & "' and Cevap='" & cevap & "'", baglanti)
            Dim reader As SqlDataReader = komut.ExecuteReader
            If reader.Read Then
                baglanti.Close()
                baglanti.Open()

                Dim komut2 As New SqlCommand("update Kullanici set sifre='" & password & "', AdiSoyadi='" & adisoyadi & "', telefon='" & telefon & "', adres='" & adres & "' where kullaniciadi='" & kadi & "'", baglanti)
                komut2.ExecuteNonQuery()
                baglanti.Close()
                FormSifremiUnuttum.Temizle()
            Else
                baglanti.Close()
                MessageBox.Show("Bilgilerinizi kontrol ediniz!", "Uyarı")
            End If
            baglanti.Close()

        Else
            MessageBox.Show("Şifreler aynı değil!", "Uyarı")
        End If


    End Sub



End Class

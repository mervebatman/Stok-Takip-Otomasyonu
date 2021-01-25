Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Resources
Imports System.Threading


Public Class FormKullaniciGirisi

    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSifremiUnuttum.LinkClicked
        FormSifremiUnuttum.ShowDialog()
    End Sub


    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""

            End If

        Next

    End Sub

    Private Sub ButonGiris_Click(sender As Object, e As EventArgs) Handles ButonGirisYap.Click
        If TextKullaniciAdi.Text = "" Or TextSifre.Text = "" Then
            MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez!", "Uyarı")
        Else
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If

            Dim komut As New SqlCommand("select * from Kullanici where KullaniciAdi=@kullaniciadi and Sifre=@password", baglanti)
            komut.Parameters.AddWithValue("@kullaniciadi", TextKullaniciAdi.Text)
            komut.Parameters.AddWithValue("@password", TextSifre.Text)
            Dim reader As SqlDataReader = komut.ExecuteReader
            If reader.Read Then
                If reader(0) = 1 Then
                    Me.Hide()
                    FormYonetici.Show()
                ElseIf reader(0) = 2 Then
                    Me.Hide()
                    FormAnaSayfa.Show()


                    MessageBox.Show("İşlem başarılı!", "Giriş")
                    Me.Temizle()

                Else
                    MessageBox.Show("Şifrenizi kontrol ediniz!", "Uyarı")
                End If

            Else
                MessageBox.Show("Bilgilerinizi kontrol ediniz!", "Uyarı")
            End If
            baglanti.Close()

            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()

            End If
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub


    'Sub dilsec()

    'If Thread.CurrentThread.ThreadState Then
    '       Thread.CurrentThread.CurrentUICulture = New CultureInfo("tr-TR")
    '      Thread.CurrentThread.CurrentCulture = New CultureInfo("tr-TR")
    'Else
    '       Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
    '      Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
    'End If


    'End Sub



    Private Sub ButonSec_Click(sender As Object, e As EventArgs) Handles ButonSec.Click
        If ComboBox1.SelectedItem.ToString = "TR" Then
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("tr-TR")
            Thread.CurrentThread.CurrentCulture = New CultureInfo("tr-TR")
        Else
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        End If
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormKullaniciGirisi").Assembly)

        lblKullaniciAdi.Text = resM.GetString("Kullanıcı Adı")
        lblParola.Text = resM.GetString("Parola")
        CheckBoxBeniHatirla.Text = resM.GetString("Beni Hatırla")
        ButonGirisYap.Text = resM.GetString("Giriş Yap")
        LinkLabelSifremiUnuttum.Text = resM.GetString("Şifremi Unuttum")
    End Sub




    '  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButonSec.Click
    ' If ComboBox1.SelectedItem.ToString = "TR" Then
    '        Thread.CurrentThread.CurrentUICulture = New CultureInfo("tr-TR")
    '       Thread.CurrentThread.CurrentCulture = New CultureInfo("tr-TR")
    'Else
    '       Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
    '      Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
    'End If
    'Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormKullaniciGirisi").Assembly)

    '   lblKullaniciAdi.Text = resM.GetString("Kullanıcı Adı")
    '  lblParola.Text = resM.GetString("Parola")
    ' CheckBoxBeniHatirla.Text = resM.GetString("Beni Hatırla")
    'ButonGirisYap.Text = resM.GetString("Giriş Yap")
    'LinkLabelSifremiUnuttum.Text = resM.GetString("Şifremi Unuttum")
    ' End Sub


End Class

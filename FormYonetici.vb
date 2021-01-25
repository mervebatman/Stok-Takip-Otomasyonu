Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormYonetici
    Sub SayfaGetir(frm As Form)
        PanelSayfalar.Controls.Clear()
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Left
        PanelSayfalar.Controls.Add(frm)
        frm.Show()
    End Sub

    Dim S As New Stok
    Private Sub ButonAnaSayfayaGit_Click(sender As Object, e As EventArgs) Handles ButonAnaSayfayaGit.Click

        FormAnaSayfa.Show()

    End Sub

    Private Sub ButonPersonelListele_Click(sender As Object, e As EventArgs) Handles ButonPersonelListele.Click
        SayfaGetir(FormPersonelListele)

    End Sub

    Private Sub ButonPersonelEkle_Click(sender As Object, e As EventArgs) Handles ButonPersonelEkle.Click
        SayfaGetir(FormYeniKullanici)
    End Sub

    Private Sub ButonSatisRaporlari_Click(sender As Object, e As EventArgs) Handles ButonSatisRaporlari.Click
        SayfaGetir(FormSatisRaporlari1)

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

    Private Sub FormYonetici_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormYonetici").Assembly)

        Me.Text = resM.GetString("Yönetici")
        ButonAnaSayfayaGit.Text = resM.GetString("Ana Sayfaya Git")
        ButonPersonelListele.Text = resM.GetString("Personel Listele")
        ButonPersonelEkle.Text = resM.GetString("Personel Ekle")
        ButonSatisRaporlari.Text = resM.GetString("Satış Raporları")

    End Sub

    Private Sub PanelSayfalar_Paint(sender As Object, e As PaintEventArgs) Handles PanelSayfalar.Paint

    End Sub
End Class
Imports System.Globalization
Imports System.Resources
Imports System.Threading


Public Class FormAnaSayfa
    Sub SayfaGetir(frm As Form)
        PanelSayfalar.Controls.Clear()
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Left
        PanelSayfalar.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub ButonMusteriEkle_Click(sender As Object, e As EventArgs) Handles ButonMusteriEkle.Click
        SayfaGetir(FormMusteriEkle)
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub MüşteriEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriEkleToolStripMenuItem.Click
        SayfaGetir(FormMusteriEkle)
    End Sub

    Private Sub MüşteriListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriListeleToolStripMenuItem.Click
        SayfaGetir(FormMusteriListele)
    End Sub

    Private Sub ButonMusteriListele_Click(sender As Object, e As EventArgs) Handles ButonMusteriListele.Click
        SayfaGetir(FormMusteriListele)
    End Sub

    Private Sub KategoriEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriEkleToolStripMenuItem.Click
        FormKategoriEkle.ShowDialog()
    End Sub

    Private Sub MarkaEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkaEkleToolStripMenuItem.Click
        FormMarkaEkle.ShowDialog()
    End Sub

    Private Sub BirimEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BirimEkleToolStripMenuItem.Click
        FormBirimEkle.ShowDialog()
    End Sub

    Private Sub KategoriSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriSilToolStripMenuItem.Click
        FormKategoriSil.ShowDialog()
    End Sub

    Private Sub MarkaSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkaSilToolStripMenuItem.Click
        FormMarkaSil.ShowDialog()
    End Sub

    Private Sub BirimSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BirimSilToolStripMenuItem.Click
        FormBirimSil.ShowDialog()
    End Sub

    Private Sub ButonUrunEkle_Click(sender As Object, e As EventArgs) Handles ButonUrunEkle.Click
        SayfaGetir(FormUrunEkle)
    End Sub

    Private Sub ÜrünEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünEkleToolStripMenuItem.Click
        SayfaGetir(FormUrunEkle)
    End Sub

    Private Sub ButonUrunListele_Click(sender As Object, e As EventArgs) Handles ButonUrunListele.Click
        SayfaGetir(FormUrunListele)
    End Sub

    Private Sub ÜrünListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünListeleToolStripMenuItem.Click
        SayfaGetir(FormUrunListele)
    End Sub

    Private Sub ButonSatisYap_Click(sender As Object, e As EventArgs) Handles ButonSatisYap.Click
        SayfaGetir(FormSatis)
    End Sub

    Private Sub SatışYapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatışYapToolStripMenuItem.Click
        SayfaGetir(FormSatis)
    End Sub


    Private Sub ButonSatisListele_Click(sender As Object, e As EventArgs) Handles ButonSatisListele.Click
        SayfaGetir(FormSatisListele)

    End Sub

    Private Sub SatışlarıListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatışlarıListeleToolStripMenuItem.Click
        SayfaGetir(FormSatisListele)
    End Sub

    Private Sub ÜrünİadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünİadeToolStripMenuItem.Click
        FormUrunİade.ShowDialog()

    End Sub

    Private Sub ŞifremiUnuttumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞifremiUnuttumToolStripMenuItem.Click
        SayfaGetir(FormSifremiUnuttum)
    End Sub

    Private Sub FormAnaSayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormAnaSayfa").Assembly)

        MüşteriToolStripMenuItem.Text = resM.GetString("Müşteri")
        MüşteriEkleToolStripMenuItem.Text = resM.GetString("Müşteri Ekle")
        MüşteriListeleToolStripMenuItem.Text = resM.GetString("Müşteri Listele")
        ÜrünToolStripMenuItem.Text = resM.GetString("Ürün")
        ÜrünEkleToolStripMenuItem.Text = resM.GetString("Ürün Ekle")
        ÜrünListeleToolStripMenuItem.Text = resM.GetString("Ürün Listele")
        SatışToolStripMenuItem.Text = resM.GetString("Satış")
        SatışYapToolStripMenuItem.Text = resM.GetString("Satış Yap")
        SatışlarıListeleToolStripMenuItem.Text = resM.GetString("Satışları Listele")
        ÜrünİadeToolStripMenuItem.Text = resM.GetString("Ürün İade")
        AyarlarToolStripMenuItem.Text = resM.GetString("Ayarlar")
        KategoriEkleToolStripMenuItem.Text = resM.GetString("Kategori Ekle")
        MarkaEkleToolStripMenuItem.Text = resM.GetString("Marka Ekle")
        BirimEkleToolStripMenuItem.Text = resM.GetString("Birim Ekle")
        KategoriSilToolStripMenuItem.Text = resM.GetString("Kategori Sil")
        MarkaSilToolStripMenuItem.Text = resM.GetString("Marka Sil")
        BirimSilToolStripMenuItem.Text = resM.GetString("Birim Sil")
        KullanıcıToolStripMenuItem.Text = resM.GetString("Kullanıcı")
        ŞifremiUnuttumToolStripMenuItem.Text = resM.GetString("Şifremi Unuttum")
        ÇıkışToolStripMenuItem.Text = resM.GetString("Çıkış")
        ButonMusteriEkle.Text = resM.GetString("Müşteri Ekle")
        ButonMusteriListele.Text = resM.GetString("Müşteri Listele")
        ButonUrunEkle.Text = resM.GetString("Ürün Ekle")
        ButonUrunListele.Text = resM.GetString("Ürün Listele")
        ButonSatisYap.Text = resM.GetString("Satış Yap")
        ButonSatisListele.Text = resM.GetString("Satışları Listele")

    End Sub
End Class
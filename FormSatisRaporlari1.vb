Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class FormSatisRaporlari1

    Dim grafik As New SatisRaporu

    Private Sub FormSatisRaporlari1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grafik.Grafik(DataGridView1, Chart1, LabelEnAz, LabelEnCok)

        Dim resM As New ResourceManager("MBStokTakipSistemleri.Resource1", Type.[GetType]("MBStokTakipSistemleri.FormSatisRaporlari1").Assembly)

        LabelEnAzSatilan.Text = resM.GetString("En Az Satılan")
        LabelEnCokSatilan.Text = resM.GetString("En Çok Satılan")

    End Sub
End Class
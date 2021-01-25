Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class SatisRaporu

    Dim baglanti As New SqlConnection("Data Source=MERVE\SQLEXPRESS01;Initial Catalog=MBStokTakipSistemi;Integrated Security=True")
    Dim tablo As New DataTable
    Public Sub Grafik(dgrid As DataGridView, chrt As Chart, LabelAz As Label, LabelCok As Label)
        baglanti.Open()
        Dim adtr As New SqlDataAdapter("select barkodno, sum(Miktar) from satis group by GROUPING sets(BarkodNo) order by sum(Miktar) desc", baglanti)
        adtr.Fill(tablo)
        dgrid.DataSource = tablo
        baglanti.Close()
        LabelAz.Text = ""
        LabelCok.Text = ""
        LabelAz.Text = "Barkod No=" & dgrid.Rows(dgrid.Rows.Count - 2).Cells(0).Value.ToString() + " ==> " & dgrid.Rows(dgrid.Rows.Count - 2).Cells(1).Value.ToString()
        LabelCok.Text = "Barkod No=" & dgrid.Rows(0).Cells(0).Value.ToString() + " ==> " & dgrid.Rows(0).Cells(1).Value.ToString()



        For i = 0 To dgrid.Rows.Count - 2
            chrt.Series("Satış Adetleri").Points.AddXY(dgrid.Rows(i).Cells(0).Value.ToString(), dgrid.Rows(i).Cells(1).Value.ToString())

        Next
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSatisRaporlari1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BarkodNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toplam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelEnCokSatilan = New System.Windows.Forms.Label()
        Me.LabelEnAzSatilan = New System.Windows.Forms.Label()
        Me.LabelEnCok = New System.Windows.Forms.Label()
        Me.LabelEnAz = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Top
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Satış Adetleri"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(571, 186)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BarkodNo, Me.Toplam})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(571, 207)
        Me.DataGridView1.TabIndex = 1
        '
        'BarkodNo
        '
        Me.BarkodNo.DataPropertyName = "BarkodNo"
        Me.BarkodNo.HeaderText = "Barkod No"
        Me.BarkodNo.Name = "BarkodNo"
        '
        'Toplam
        '
        Me.Toplam.DataPropertyName = "Column1"
        Me.Toplam.HeaderText = "Satılan Adet"
        Me.Toplam.Name = "Toplam"
        '
        'LabelEnCokSatilan
        '
        Me.LabelEnCokSatilan.AutoSize = True
        Me.LabelEnCokSatilan.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelEnCokSatilan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelEnCokSatilan.Location = New System.Drawing.Point(12, 413)
        Me.LabelEnCokSatilan.Name = "LabelEnCokSatilan"
        Me.LabelEnCokSatilan.Size = New System.Drawing.Size(126, 22)
        Me.LabelEnCokSatilan.TabIndex = 2
        Me.LabelEnCokSatilan.Text = "En Çok Satılan"
        '
        'LabelEnAzSatilan
        '
        Me.LabelEnAzSatilan.AutoSize = True
        Me.LabelEnAzSatilan.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelEnAzSatilan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelEnAzSatilan.Location = New System.Drawing.Point(346, 413)
        Me.LabelEnAzSatilan.Name = "LabelEnAzSatilan"
        Me.LabelEnAzSatilan.Size = New System.Drawing.Size(113, 22)
        Me.LabelEnAzSatilan.TabIndex = 2
        Me.LabelEnAzSatilan.Text = "En Az Satılan"
        '
        'LabelEnCok
        '
        Me.LabelEnCok.AutoSize = True
        Me.LabelEnCok.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelEnCok.ForeColor = System.Drawing.Color.LightGreen
        Me.LabelEnCok.Location = New System.Drawing.Point(12, 447)
        Me.LabelEnCok.Name = "LabelEnCok"
        Me.LabelEnCok.Size = New System.Drawing.Size(126, 22)
        Me.LabelEnCok.TabIndex = 2
        Me.LabelEnCok.Text = "En Çok Satılan"
        '
        'LabelEnAz
        '
        Me.LabelEnAz.AutoSize = True
        Me.LabelEnAz.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelEnAz.ForeColor = System.Drawing.Color.Tomato
        Me.LabelEnAz.Location = New System.Drawing.Point(346, 447)
        Me.LabelEnAz.Name = "LabelEnAz"
        Me.LabelEnAz.Size = New System.Drawing.Size(113, 22)
        Me.LabelEnAz.TabIndex = 2
        Me.LabelEnAz.Text = "En Az Satılan"
        '
        'FormSatisRaporlari1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(571, 510)
        Me.Controls.Add(Me.LabelEnAz)
        Me.Controls.Add(Me.LabelEnAzSatilan)
        Me.Controls.Add(Me.LabelEnCok)
        Me.Controls.Add(Me.LabelEnCokSatilan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Chart1)
        Me.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSatisRaporlari1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satış Raporları"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelEnCokSatilan As Label
    Friend WithEvents LabelEnAzSatilan As Label
    Friend WithEvents LabelEnCok As Label
    Friend WithEvents LabelEnAz As Label
    Friend WithEvents BarkodNo As DataGridViewTextBoxColumn
    Friend WithEvents Toplam As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSatisListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSatisListele))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelUrunAdiAra = New System.Windows.Forms.Label()
        Me.LabelMusteriAdiAra = New System.Windows.Forms.Label()
        Me.TextUrunAdiAra = New System.Windows.Forms.TextBox()
        Me.TextMusteriAdiAra = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelToplamKazanc = New System.Windows.Forms.Label()
        Me.LabelKazanc = New System.Windows.Forms.Label()
        Me.LabelKayitSayisi = New System.Windows.Forms.Label()
        Me.LabelToplamKayit = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelUrunAdiAra)
        Me.Panel1.Controls.Add(Me.LabelMusteriAdiAra)
        Me.Panel1.Controls.Add(Me.TextUrunAdiAra)
        Me.Panel1.Controls.Add(Me.TextMusteriAdiAra)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1328, 77)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(783, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(193, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LabelUrunAdiAra
        '
        Me.LabelUrunAdiAra.AutoSize = True
        Me.LabelUrunAdiAra.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelUrunAdiAra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelUrunAdiAra.Location = New System.Drawing.Point(822, 0)
        Me.LabelUrunAdiAra.Name = "LabelUrunAdiAra"
        Me.LabelUrunAdiAra.Size = New System.Drawing.Size(107, 21)
        Me.LabelUrunAdiAra.TabIndex = 1
        Me.LabelUrunAdiAra.Text = "Ürün Adı Ara"
        '
        'LabelMusteriAdiAra
        '
        Me.LabelMusteriAdiAra.AutoSize = True
        Me.LabelMusteriAdiAra.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMusteriAdiAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelMusteriAdiAra.Location = New System.Drawing.Point(219, 2)
        Me.LabelMusteriAdiAra.Name = "LabelMusteriAdiAra"
        Me.LabelMusteriAdiAra.Size = New System.Drawing.Size(125, 21)
        Me.LabelMusteriAdiAra.TabIndex = 1
        Me.LabelMusteriAdiAra.Text = "Müşteri Adı Ara"
        '
        'TextUrunAdiAra
        '
        Me.TextUrunAdiAra.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextUrunAdiAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUrunAdiAra.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextUrunAdiAra.ForeColor = System.Drawing.Color.White
        Me.TextUrunAdiAra.Location = New System.Drawing.Point(826, 23)
        Me.TextUrunAdiAra.Name = "TextUrunAdiAra"
        Me.TextUrunAdiAra.Size = New System.Drawing.Size(158, 26)
        Me.TextUrunAdiAra.TabIndex = 0
        '
        'TextMusteriAdiAra
        '
        Me.TextMusteriAdiAra.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMusteriAdiAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMusteriAdiAra.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMusteriAdiAra.ForeColor = System.Drawing.SystemColors.Window
        Me.TextMusteriAdiAra.Location = New System.Drawing.Point(223, 26)
        Me.TextMusteriAdiAra.Name = "TextMusteriAdiAra"
        Me.TextMusteriAdiAra.Size = New System.Drawing.Size(158, 26)
        Me.TextMusteriAdiAra.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LabelToplamKazanc)
        Me.Panel2.Controls.Add(Me.LabelKazanc)
        Me.Panel2.Controls.Add(Me.LabelKayitSayisi)
        Me.Panel2.Controls.Add(Me.LabelToplamKayit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 407)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1328, 68)
        Me.Panel2.TabIndex = 1
        '
        'LabelToplamKazanc
        '
        Me.LabelToplamKazanc.AutoSize = True
        Me.LabelToplamKazanc.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelToplamKazanc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelToplamKazanc.Location = New System.Drawing.Point(839, 25)
        Me.LabelToplamKazanc.Name = "LabelToplamKazanc"
        Me.LabelToplamKazanc.Size = New System.Drawing.Size(0, 22)
        Me.LabelToplamKazanc.TabIndex = 3
        '
        'LabelKazanc
        '
        Me.LabelKazanc.AutoSize = True
        Me.LabelKazanc.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKazanc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKazanc.Location = New System.Drawing.Point(695, 25)
        Me.LabelKazanc.Name = "LabelKazanc"
        Me.LabelKazanc.Size = New System.Drawing.Size(125, 21)
        Me.LabelKazanc.TabIndex = 2
        Me.LabelKazanc.Text = "Toplam Kazanç"
        '
        'LabelKayitSayisi
        '
        Me.LabelKayitSayisi.AutoSize = True
        Me.LabelKayitSayisi.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKayitSayisi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKayitSayisi.Location = New System.Drawing.Point(187, 24)
        Me.LabelKayitSayisi.Name = "LabelKayitSayisi"
        Me.LabelKayitSayisi.Size = New System.Drawing.Size(0, 22)
        Me.LabelKayitSayisi.TabIndex = 1
        '
        'LabelToplamKayit
        '
        Me.LabelToplamKayit.AutoSize = True
        Me.LabelToplamKayit.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelToplamKayit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelToplamKayit.Location = New System.Drawing.Point(11, 25)
        Me.LabelToplamKayit.Name = "LabelToplamKayit"
        Me.LabelToplamKayit.Size = New System.Drawing.Size(153, 21)
        Me.LabelToplamKayit.TabIndex = 0
        Me.LabelToplamKayit.Text = "Toplam Kayıt Sayısı"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1328, 330)
        Me.Panel3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1326, 328)
        Me.DataGridView1.TabIndex = 0
        '
        'FormSatisListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1328, 475)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSatisListele"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satışları Listeleme"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelUrunAdiAra As Label
    Friend WithEvents LabelMusteriAdiAra As Label
    Friend WithEvents TextUrunAdiAra As TextBox
    Friend WithEvents TextMusteriAdiAra As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelToplamKazanc As Label
    Friend WithEvents LabelKazanc As Label
    Friend WithEvents LabelKayitSayisi As Label
    Friend WithEvents LabelToplamKayit As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class

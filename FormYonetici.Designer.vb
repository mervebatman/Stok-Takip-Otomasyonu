<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormYonetici
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormYonetici))
        Me.ButonSatisRaporlari = New System.Windows.Forms.Button()
        Me.ButonPersonelEkle = New System.Windows.Forms.Button()
        Me.ButonPersonelListele = New System.Windows.Forms.Button()
        Me.ButonAnaSayfayaGit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSayfalar = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButonSatisRaporlari
        '
        Me.ButonSatisRaporlari.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSatisRaporlari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonSatisRaporlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSatisRaporlari.ImageKey = "2644693.png"
        Me.ButonSatisRaporlari.Location = New System.Drawing.Point(2, 341)
        Me.ButonSatisRaporlari.Name = "ButonSatisRaporlari"
        Me.ButonSatisRaporlari.Size = New System.Drawing.Size(181, 57)
        Me.ButonSatisRaporlari.TabIndex = 1
        Me.ButonSatisRaporlari.Text = "Satış" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Raporları"
        Me.ButonSatisRaporlari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSatisRaporlari.UseVisualStyleBackColor = True
        '
        'ButonPersonelEkle
        '
        Me.ButonPersonelEkle.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonPersonelEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonPersonelEkle.ImageKey = "service.png"
        Me.ButonPersonelEkle.Location = New System.Drawing.Point(2, 278)
        Me.ButonPersonelEkle.Name = "ButonPersonelEkle"
        Me.ButonPersonelEkle.Size = New System.Drawing.Size(181, 57)
        Me.ButonPersonelEkle.TabIndex = 2
        Me.ButonPersonelEkle.Text = "Personel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ekle"
        Me.ButonPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonPersonelEkle.UseVisualStyleBackColor = True
        '
        'ButonPersonelListele
        '
        Me.ButonPersonelListele.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonPersonelListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonPersonelListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonPersonelListele.ImageKey = "list (1).png"
        Me.ButonPersonelListele.Location = New System.Drawing.Point(2, 215)
        Me.ButonPersonelListele.Name = "ButonPersonelListele"
        Me.ButonPersonelListele.Size = New System.Drawing.Size(181, 57)
        Me.ButonPersonelListele.TabIndex = 3
        Me.ButonPersonelListele.Text = "Personel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Listele"
        Me.ButonPersonelListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonPersonelListele.UseVisualStyleBackColor = True
        '
        'ButonAnaSayfayaGit
        '
        Me.ButonAnaSayfayaGit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonAnaSayfayaGit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonAnaSayfayaGit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonAnaSayfayaGit.ImageKey = "house.png"
        Me.ButonAnaSayfayaGit.Location = New System.Drawing.Point(2, 152)
        Me.ButonAnaSayfayaGit.Name = "ButonAnaSayfayaGit"
        Me.ButonAnaSayfayaGit.Size = New System.Drawing.Size(181, 57)
        Me.ButonAnaSayfayaGit.TabIndex = 4
        Me.ButonAnaSayfayaGit.Text = "Ana Sayfaya" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Git"
        Me.ButonAnaSayfayaGit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonAnaSayfayaGit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButonAnaSayfayaGit)
        Me.Panel1.Controls.Add(Me.ButonSatisRaporlari)
        Me.Panel1.Controls.Add(Me.ButonPersonelEkle)
        Me.Panel1.Controls.Add(Me.ButonPersonelListele)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(192, 410)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PanelSayfalar
        '
        Me.PanelSayfalar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSayfalar.Location = New System.Drawing.Point(192, 0)
        Me.PanelSayfalar.Name = "PanelSayfalar"
        Me.PanelSayfalar.Size = New System.Drawing.Size(868, 410)
        Me.PanelSayfalar.TabIndex = 8
        '
        'FormYonetici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1060, 410)
        Me.Controls.Add(Me.PanelSayfalar)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "FormYonetici"
        Me.Text = "Yönetici"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButonSatisRaporlari As Button
    Friend WithEvents ButonPersonelEkle As Button
    Friend WithEvents ButonPersonelListele As Button
    Friend WithEvents ButonAnaSayfayaGit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelSayfalar As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

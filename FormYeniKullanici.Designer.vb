<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormYeniKullanici
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormYeniKullanici))
        Me.ButonEkle = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.LabelKullaniciYetkisi = New System.Windows.Forms.Label()
        Me.LabelAdiSoyadi = New System.Windows.Forms.Label()
        Me.LabelTelefon = New System.Windows.Forms.Label()
        Me.LabelAdres = New System.Windows.Forms.Label()
        Me.LabelKullaniciAdi = New System.Windows.Forms.Label()
        Me.LabelSifre = New System.Windows.Forms.Label()
        Me.LabelSoru = New System.Windows.Forms.Label()
        Me.LabelCevap = New System.Windows.Forms.Label()
        Me.TextKullaniciYetkisi = New System.Windows.Forms.TextBox()
        Me.TextAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.TextTelefon = New System.Windows.Forms.TextBox()
        Me.TextAdres = New System.Windows.Forms.TextBox()
        Me.TextKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.TextSifre = New System.Windows.Forms.TextBox()
        Me.TextSoru = New System.Windows.Forms.TextBox()
        Me.TextCevap = New System.Windows.Forms.TextBox()
        Me.LabelAciklama = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButonEkle
        '
        Me.ButonEkle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButonEkle.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonEkle.ImageKey = "add (2).png"
        Me.ButonEkle.ImageList = Me.ımageList1
        Me.ButonEkle.Location = New System.Drawing.Point(121, 364)
        Me.ButonEkle.Name = "ButonEkle"
        Me.ButonEkle.Size = New System.Drawing.Size(84, 41)
        Me.ButonEkle.TabIndex = 8
        Me.ButonEkle.Text = "Ekle"
        Me.ButonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonEkle.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "add (2).png")
        Me.ımageList1.Images.SetKeyName(1, "cancel (1).png")
        '
        'Butonİptal
        '
        Me.Butonİptal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Butonİptal.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Butonİptal.ImageKey = "cancel (1).png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(282, 364)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(104, 41)
        Me.Butonİptal.TabIndex = 9
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = False
        '
        'LabelKullaniciYetkisi
        '
        Me.LabelKullaniciYetkisi.AutoSize = True
        Me.LabelKullaniciYetkisi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKullaniciYetkisi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKullaniciYetkisi.Location = New System.Drawing.Point(12, 24)
        Me.LabelKullaniciYetkisi.Name = "LabelKullaniciYetkisi"
        Me.LabelKullaniciYetkisi.Size = New System.Drawing.Size(149, 22)
        Me.LabelKullaniciYetkisi.TabIndex = 10
        Me.LabelKullaniciYetkisi.Text = "Kullanıcı Yetkisi(*)"
        '
        'LabelAdiSoyadi
        '
        Me.LabelAdiSoyadi.AutoSize = True
        Me.LabelAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdiSoyadi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdiSoyadi.Location = New System.Drawing.Point(23, 67)
        Me.LabelAdiSoyadi.Name = "LabelAdiSoyadi"
        Me.LabelAdiSoyadi.Size = New System.Drawing.Size(96, 22)
        Me.LabelAdiSoyadi.TabIndex = 10
        Me.LabelAdiSoyadi.Text = "Adı Soyadı:"
        '
        'LabelTelefon
        '
        Me.LabelTelefon.AutoSize = True
        Me.LabelTelefon.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTelefon.Location = New System.Drawing.Point(51, 108)
        Me.LabelTelefon.Name = "LabelTelefon"
        Me.LabelTelefon.Size = New System.Drawing.Size(71, 22)
        Me.LabelTelefon.TabIndex = 10
        Me.LabelTelefon.Text = "Telefon:"
        '
        'LabelAdres
        '
        Me.LabelAdres.AutoSize = True
        Me.LabelAdres.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdres.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdres.Location = New System.Drawing.Point(63, 153)
        Me.LabelAdres.Name = "LabelAdres"
        Me.LabelAdres.Size = New System.Drawing.Size(59, 22)
        Me.LabelAdres.TabIndex = 10
        Me.LabelAdres.Text = "Adres:"
        '
        'LabelKullaniciAdi
        '
        Me.LabelKullaniciAdi.AutoSize = True
        Me.LabelKullaniciAdi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKullaniciAdi.Location = New System.Drawing.Point(12, 190)
        Me.LabelKullaniciAdi.Name = "LabelKullaniciAdi"
        Me.LabelKullaniciAdi.Size = New System.Drawing.Size(110, 22)
        Me.LabelKullaniciAdi.TabIndex = 10
        Me.LabelKullaniciAdi.Text = "Kullanıcı Adı:"
        '
        'LabelSifre
        '
        Me.LabelSifre.AutoSize = True
        Me.LabelSifre.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSifre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSifre.Location = New System.Drawing.Point(63, 237)
        Me.LabelSifre.Name = "LabelSifre"
        Me.LabelSifre.Size = New System.Drawing.Size(49, 22)
        Me.LabelSifre.TabIndex = 10
        Me.LabelSifre.Text = "Şifre:"
        '
        'LabelSoru
        '
        Me.LabelSoru.AutoSize = True
        Me.LabelSoru.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSoru.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSoru.Location = New System.Drawing.Point(58, 276)
        Me.LabelSoru.Name = "LabelSoru"
        Me.LabelSoru.Size = New System.Drawing.Size(50, 22)
        Me.LabelSoru.TabIndex = 10
        Me.LabelSoru.Text = "Soru:"
        '
        'LabelCevap
        '
        Me.LabelCevap.AutoSize = True
        Me.LabelCevap.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelCevap.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelCevap.Location = New System.Drawing.Point(51, 316)
        Me.LabelCevap.Name = "LabelCevap"
        Me.LabelCevap.Size = New System.Drawing.Size(64, 22)
        Me.LabelCevap.TabIndex = 10
        Me.LabelCevap.Text = "Cevap:"
        '
        'TextKullaniciYetkisi
        '
        Me.TextKullaniciYetkisi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKullaniciYetkisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKullaniciYetkisi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextKullaniciYetkisi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextKullaniciYetkisi.Location = New System.Drawing.Point(167, 26)
        Me.TextKullaniciYetkisi.Name = "TextKullaniciYetkisi"
        Me.TextKullaniciYetkisi.Size = New System.Drawing.Size(197, 23)
        Me.TextKullaniciYetkisi.TabIndex = 11
        Me.TextKullaniciYetkisi.Text = "2"
        Me.TextKullaniciYetkisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextAdiSoyadi
        '
        Me.TextAdiSoyadi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdiSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdiSoyadi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdiSoyadi.Location = New System.Drawing.Point(167, 67)
        Me.TextAdiSoyadi.Name = "TextAdiSoyadi"
        Me.TextAdiSoyadi.Size = New System.Drawing.Size(197, 23)
        Me.TextAdiSoyadi.TabIndex = 11
        '
        'TextTelefon
        '
        Me.TextTelefon.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTelefon.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextTelefon.ForeColor = System.Drawing.SystemColors.Window
        Me.TextTelefon.Location = New System.Drawing.Point(167, 107)
        Me.TextTelefon.Name = "TextTelefon"
        Me.TextTelefon.Size = New System.Drawing.Size(197, 23)
        Me.TextTelefon.TabIndex = 11
        '
        'TextAdres
        '
        Me.TextAdres.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdres.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdres.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdres.Location = New System.Drawing.Point(167, 152)
        Me.TextAdres.Name = "TextAdres"
        Me.TextAdres.Size = New System.Drawing.Size(197, 23)
        Me.TextAdres.TabIndex = 11
        '
        'TextKullaniciAdi
        '
        Me.TextKullaniciAdi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKullaniciAdi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextKullaniciAdi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextKullaniciAdi.Location = New System.Drawing.Point(167, 192)
        Me.TextKullaniciAdi.Name = "TextKullaniciAdi"
        Me.TextKullaniciAdi.Size = New System.Drawing.Size(197, 23)
        Me.TextKullaniciAdi.TabIndex = 11
        '
        'TextSifre
        '
        Me.TextSifre.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSifre.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextSifre.ForeColor = System.Drawing.SystemColors.Window
        Me.TextSifre.Location = New System.Drawing.Point(167, 236)
        Me.TextSifre.Name = "TextSifre"
        Me.TextSifre.Size = New System.Drawing.Size(197, 23)
        Me.TextSifre.TabIndex = 11
        '
        'TextSoru
        '
        Me.TextSoru.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSoru.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextSoru.ForeColor = System.Drawing.SystemColors.Window
        Me.TextSoru.Location = New System.Drawing.Point(167, 275)
        Me.TextSoru.Name = "TextSoru"
        Me.TextSoru.Size = New System.Drawing.Size(197, 23)
        Me.TextSoru.TabIndex = 11
        '
        'TextCevap
        '
        Me.TextCevap.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextCevap.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextCevap.ForeColor = System.Drawing.SystemColors.Window
        Me.TextCevap.Location = New System.Drawing.Point(167, 318)
        Me.TextCevap.Name = "TextCevap"
        Me.TextCevap.Size = New System.Drawing.Size(197, 23)
        Me.TextCevap.TabIndex = 11
        '
        'LabelAciklama
        '
        Me.LabelAciklama.AutoSize = True
        Me.LabelAciklama.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAciklama.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelAciklama.Location = New System.Drawing.Point(23, 436)
        Me.LabelAciklama.Name = "LabelAciklama"
        Me.LabelAciklama.Size = New System.Drawing.Size(429, 44)
        Me.LabelAciklama.TabIndex = 12
        Me.LabelAciklama.Text = "(*) Kullanıcı Yetkisi 1 rakamı için yönetici, 2 rakamı için" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                  pe" &
    "rsoneli ifade etmektedir!"
        '
        'FormYeniKullanici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 489)
        Me.Controls.Add(Me.LabelAciklama)
        Me.Controls.Add(Me.TextCevap)
        Me.Controls.Add(Me.TextSoru)
        Me.Controls.Add(Me.TextSifre)
        Me.Controls.Add(Me.TextKullaniciAdi)
        Me.Controls.Add(Me.TextAdres)
        Me.Controls.Add(Me.TextTelefon)
        Me.Controls.Add(Me.TextAdiSoyadi)
        Me.Controls.Add(Me.TextKullaniciYetkisi)
        Me.Controls.Add(Me.LabelCevap)
        Me.Controls.Add(Me.LabelSoru)
        Me.Controls.Add(Me.LabelSifre)
        Me.Controls.Add(Me.LabelKullaniciAdi)
        Me.Controls.Add(Me.LabelAdres)
        Me.Controls.Add(Me.LabelTelefon)
        Me.Controls.Add(Me.LabelAdiSoyadi)
        Me.Controls.Add(Me.LabelKullaniciYetkisi)
        Me.Controls.Add(Me.Butonİptal)
        Me.Controls.Add(Me.ButonEkle)
        Me.Name = "FormYeniKullanici"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yeni Kullanıcı"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButonEkle As Button
    Friend WithEvents Butonİptal As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents LabelKullaniciYetkisi As Label
    Friend WithEvents LabelAdiSoyadi As Label
    Friend WithEvents LabelTelefon As Label
    Friend WithEvents LabelAdres As Label
    Friend WithEvents LabelKullaniciAdi As Label
    Friend WithEvents LabelSifre As Label
    Friend WithEvents LabelSoru As Label
    Friend WithEvents LabelCevap As Label
    Friend WithEvents TextKullaniciYetkisi As TextBox
    Friend WithEvents TextAdiSoyadi As TextBox
    Friend WithEvents TextTelefon As TextBox
    Friend WithEvents TextAdres As TextBox
    Friend WithEvents TextKullaniciAdi As TextBox
    Friend WithEvents TextSifre As TextBox
    Friend WithEvents TextSoru As TextBox
    Friend WithEvents TextCevap As TextBox
    Friend WithEvents LabelAciklama As Label
End Class

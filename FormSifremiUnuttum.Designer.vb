<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSifremiUnuttum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSifremiUnuttum))
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonGuncelle = New System.Windows.Forms.Button()
        Me.LabelAdres = New System.Windows.Forms.Label()
        Me.LabelTelefon = New System.Windows.Forms.Label()
        Me.LabelSoru = New System.Windows.Forms.Label()
        Me.LabelKullaniciAdi = New System.Windows.Forms.Label()
        Me.LabelAdiSoyadi = New System.Windows.Forms.Label()
        Me.TextKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.LabelSifre = New System.Windows.Forms.Label()
        Me.LabelCevap = New System.Windows.Forms.Label()
        Me.LabelSifreTekrar = New System.Windows.Forms.Label()
        Me.TextSoru = New System.Windows.Forms.TextBox()
        Me.TextCevap = New System.Windows.Forms.TextBox()
        Me.TextSifre = New System.Windows.Forms.TextBox()
        Me.TextSifreTekrar = New System.Windows.Forms.TextBox()
        Me.TextAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.TextTelefon = New System.Windows.Forms.TextBox()
        Me.TextAdres = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Butonİptal
        '
        Me.Butonİptal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Butonİptal.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Butonİptal.ImageKey = "exit.png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(193, 324)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(114, 43)
        Me.Butonİptal.TabIndex = 23
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "updated.png")
        Me.ımageList1.Images.SetKeyName(1, "exit.png")
        '
        'ButonGuncelle
        '
        Me.ButonGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButonGuncelle.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonGuncelle.ImageKey = "updated.png"
        Me.ButonGuncelle.ImageList = Me.ımageList1
        Me.ButonGuncelle.Location = New System.Drawing.Point(29, 324)
        Me.ButonGuncelle.Name = "ButonGuncelle"
        Me.ButonGuncelle.Size = New System.Drawing.Size(140, 43)
        Me.ButonGuncelle.TabIndex = 22
        Me.ButonGuncelle.Text = "Güncelle"
        Me.ButonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonGuncelle.UseVisualStyleBackColor = False
        '
        'LabelAdres
        '
        Me.LabelAdres.AutoSize = True
        Me.LabelAdres.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAdres.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdres.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdres.Location = New System.Drawing.Point(54, 284)
        Me.LabelAdres.Name = "LabelAdres"
        Me.LabelAdres.Size = New System.Drawing.Size(59, 22)
        Me.LabelAdres.TabIndex = 16
        Me.LabelAdres.Text = "Adres:"
        '
        'LabelTelefon
        '
        Me.LabelTelefon.AutoSize = True
        Me.LabelTelefon.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTelefon.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTelefon.Location = New System.Drawing.Point(42, 249)
        Me.LabelTelefon.Name = "LabelTelefon"
        Me.LabelTelefon.Size = New System.Drawing.Size(71, 22)
        Me.LabelTelefon.TabIndex = 17
        Me.LabelTelefon.Text = "Telefon:"
        '
        'LabelSoru
        '
        Me.LabelSoru.AutoSize = True
        Me.LabelSoru.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSoru.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSoru.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSoru.Location = New System.Drawing.Point(69, 54)
        Me.LabelSoru.Name = "LabelSoru"
        Me.LabelSoru.Size = New System.Drawing.Size(50, 22)
        Me.LabelSoru.TabIndex = 19
        Me.LabelSoru.Text = "Soru:"
        '
        'LabelKullaniciAdi
        '
        Me.LabelKullaniciAdi.AutoSize = True
        Me.LabelKullaniciAdi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelKullaniciAdi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKullaniciAdi.Location = New System.Drawing.Point(9, 14)
        Me.LabelKullaniciAdi.Name = "LabelKullaniciAdi"
        Me.LabelKullaniciAdi.Size = New System.Drawing.Size(110, 22)
        Me.LabelKullaniciAdi.TabIndex = 20
        Me.LabelKullaniciAdi.Text = "Kullanıcı Adı:"
        '
        'LabelAdiSoyadi
        '
        Me.LabelAdiSoyadi.AutoSize = True
        Me.LabelAdiSoyadi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdiSoyadi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdiSoyadi.Location = New System.Drawing.Point(17, 208)
        Me.LabelAdiSoyadi.Name = "LabelAdiSoyadi"
        Me.LabelAdiSoyadi.Size = New System.Drawing.Size(96, 22)
        Me.LabelAdiSoyadi.TabIndex = 21
        Me.LabelAdiSoyadi.Text = "Adı Soyadı:"
        '
        'TextKullaniciAdi
        '
        Me.TextKullaniciAdi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKullaniciAdi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextKullaniciAdi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextKullaniciAdi.Location = New System.Drawing.Point(125, 16)
        Me.TextKullaniciAdi.Name = "TextKullaniciAdi"
        Me.TextKullaniciAdi.Size = New System.Drawing.Size(177, 23)
        Me.TextKullaniciAdi.TabIndex = 10
        '
        'LabelSifre
        '
        Me.LabelSifre.AutoSize = True
        Me.LabelSifre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSifre.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSifre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSifre.Location = New System.Drawing.Point(69, 129)
        Me.LabelSifre.Name = "LabelSifre"
        Me.LabelSifre.Size = New System.Drawing.Size(49, 22)
        Me.LabelSifre.TabIndex = 25
        Me.LabelSifre.Text = "Şifre:"
        '
        'LabelCevap
        '
        Me.LabelCevap.AutoSize = True
        Me.LabelCevap.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelCevap.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelCevap.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelCevap.Location = New System.Drawing.Point(55, 95)
        Me.LabelCevap.Name = "LabelCevap"
        Me.LabelCevap.Size = New System.Drawing.Size(64, 22)
        Me.LabelCevap.TabIndex = 19
        Me.LabelCevap.Text = "Cevap:"
        '
        'LabelSifreTekrar
        '
        Me.LabelSifreTekrar.AutoSize = True
        Me.LabelSifreTekrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelSifreTekrar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSifreTekrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSifreTekrar.Location = New System.Drawing.Point(17, 169)
        Me.LabelSifreTekrar.Name = "LabelSifreTekrar"
        Me.LabelSifreTekrar.Size = New System.Drawing.Size(102, 22)
        Me.LabelSifreTekrar.TabIndex = 25
        Me.LabelSifreTekrar.Text = "Şifre Tekrar:"
        '
        'TextSoru
        '
        Me.TextSoru.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSoru.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextSoru.ForeColor = System.Drawing.SystemColors.Window
        Me.TextSoru.Location = New System.Drawing.Point(125, 56)
        Me.TextSoru.Name = "TextSoru"
        Me.TextSoru.Size = New System.Drawing.Size(177, 23)
        Me.TextSoru.TabIndex = 10
        '
        'TextCevap
        '
        Me.TextCevap.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextCevap.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextCevap.ForeColor = System.Drawing.SystemColors.Window
        Me.TextCevap.Location = New System.Drawing.Point(125, 94)
        Me.TextCevap.Name = "TextCevap"
        Me.TextCevap.Size = New System.Drawing.Size(177, 23)
        Me.TextCevap.TabIndex = 10
        '
        'TextSifre
        '
        Me.TextSifre.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSifre.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextSifre.ForeColor = System.Drawing.SystemColors.Window
        Me.TextSifre.Location = New System.Drawing.Point(124, 131)
        Me.TextSifre.Name = "TextSifre"
        Me.TextSifre.Size = New System.Drawing.Size(177, 23)
        Me.TextSifre.TabIndex = 10
        '
        'TextSifreTekrar
        '
        Me.TextSifreTekrar.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSifreTekrar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextSifreTekrar.ForeColor = System.Drawing.SystemColors.Window
        Me.TextSifreTekrar.Location = New System.Drawing.Point(125, 169)
        Me.TextSifreTekrar.Name = "TextSifreTekrar"
        Me.TextSifreTekrar.Size = New System.Drawing.Size(177, 23)
        Me.TextSifreTekrar.TabIndex = 10
        '
        'TextAdiSoyadi
        '
        Me.TextAdiSoyadi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdiSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdiSoyadi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdiSoyadi.Location = New System.Drawing.Point(125, 207)
        Me.TextAdiSoyadi.Name = "TextAdiSoyadi"
        Me.TextAdiSoyadi.Size = New System.Drawing.Size(177, 23)
        Me.TextAdiSoyadi.TabIndex = 10
        '
        'TextTelefon
        '
        Me.TextTelefon.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTelefon.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextTelefon.ForeColor = System.Drawing.SystemColors.Window
        Me.TextTelefon.Location = New System.Drawing.Point(125, 248)
        Me.TextTelefon.Name = "TextTelefon"
        Me.TextTelefon.Size = New System.Drawing.Size(177, 23)
        Me.TextTelefon.TabIndex = 10
        '
        'TextAdres
        '
        Me.TextAdres.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdres.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdres.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdres.Location = New System.Drawing.Point(124, 283)
        Me.TextAdres.Name = "TextAdres"
        Me.TextAdres.Size = New System.Drawing.Size(177, 23)
        Me.TextAdres.TabIndex = 10
        '
        'FormSifremiUnuttum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(371, 379)
        Me.Controls.Add(Me.LabelSifreTekrar)
        Me.Controls.Add(Me.LabelSifre)
        Me.Controls.Add(Me.Butonİptal)
        Me.Controls.Add(Me.ButonGuncelle)
        Me.Controls.Add(Me.LabelAdres)
        Me.Controls.Add(Me.LabelTelefon)
        Me.Controls.Add(Me.LabelCevap)
        Me.Controls.Add(Me.LabelSoru)
        Me.Controls.Add(Me.LabelKullaniciAdi)
        Me.Controls.Add(Me.LabelAdiSoyadi)
        Me.Controls.Add(Me.TextAdres)
        Me.Controls.Add(Me.TextTelefon)
        Me.Controls.Add(Me.TextAdiSoyadi)
        Me.Controls.Add(Me.TextSifreTekrar)
        Me.Controls.Add(Me.TextSifre)
        Me.Controls.Add(Me.TextCevap)
        Me.Controls.Add(Me.TextSoru)
        Me.Controls.Add(Me.TextKullaniciAdi)
        Me.Name = "FormSifremiUnuttum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Şifremi Unuttum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Butonİptal As Button
    Friend WithEvents ButonGuncelle As Button
    Friend WithEvents LabelAdres As Label
    Friend WithEvents LabelTelefon As Label
    Friend WithEvents LabelSoru As Label
    Friend WithEvents LabelKullaniciAdi As Label
    Friend WithEvents LabelAdiSoyadi As Label
    Friend WithEvents TextKullaniciAdi As TextBox
    Friend WithEvents LabelSifre As Label
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents LabelCevap As Label
    Friend WithEvents LabelSifreTekrar As Label
    Friend WithEvents TextSoru As TextBox
    Friend WithEvents TextCevap As TextBox
    Friend WithEvents TextSifre As TextBox
    Friend WithEvents TextSifreTekrar As TextBox
    Friend WithEvents TextAdiSoyadi As TextBox
    Friend WithEvents TextTelefon As TextBox
    Friend WithEvents TextAdres As TextBox
End Class

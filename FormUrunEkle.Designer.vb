<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunEkle))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelSatisFiyati = New System.Windows.Forms.Label()
        Me.LabelAlisFiyati = New System.Windows.Forms.Label()
        Me.LabelBirim = New System.Windows.Forms.Label()
        Me.LabelMiktar = New System.Windows.Forms.Label()
        Me.LabelUrunAdi = New System.Windows.Forms.Label()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.LabelBarkodNo = New System.Windows.Forms.Label()
        Me.ButonCikis = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonEkle = New System.Windows.Forms.Button()
        Me.ComboBirim = New System.Windows.Forms.ComboBox()
        Me.ComboMarka = New System.Windows.Forms.ComboBox()
        Me.ComboKategori = New System.Windows.Forms.ComboBox()
        Me.TextSatisFiyati = New System.Windows.Forms.TextBox()
        Me.TextAlisFiyati = New System.Windows.Forms.TextBox()
        Me.TextMiktari = New System.Windows.Forms.TextBox()
        Me.TextUrunAdi = New System.Windows.Forms.TextBox()
        Me.TextBarkodNo = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabelSatisFiyati2 = New System.Windows.Forms.Label()
        Me.LabelAlisFiyati2 = New System.Windows.Forms.Label()
        Me.LabelBirim2 = New System.Windows.Forms.Label()
        Me.LabelMiktar2 = New System.Windows.Forms.Label()
        Me.LabelUrunAdi2 = New System.Windows.Forms.Label()
        Me.LabelMarka2 = New System.Windows.Forms.Label()
        Me.LabelKategori2 = New System.Windows.Forms.Label()
        Me.LabelBarkodNo2 = New System.Windows.Forms.Label()
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.ButonGuncelle = New System.Windows.Forms.Button()
        Me.TextSatisFiyati2 = New System.Windows.Forms.TextBox()
        Me.TextAlisFiyati2 = New System.Windows.Forms.TextBox()
        Me.TextBirim2 = New System.Windows.Forms.TextBox()
        Me.TextMiktar2 = New System.Windows.Forms.TextBox()
        Me.TextMarka2 = New System.Windows.Forms.TextBox()
        Me.TextKategori2 = New System.Windows.Forms.TextBox()
        Me.TextUrunAdi2 = New System.Windows.Forms.TextBox()
        Me.TextBarkodNo2 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(432, 490)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.LabelSatisFiyati)
        Me.TabPage1.Controls.Add(Me.LabelAlisFiyati)
        Me.TabPage1.Controls.Add(Me.LabelBirim)
        Me.TabPage1.Controls.Add(Me.LabelMiktar)
        Me.TabPage1.Controls.Add(Me.LabelUrunAdi)
        Me.TabPage1.Controls.Add(Me.LabelMarka)
        Me.TabPage1.Controls.Add(Me.LabelKategori)
        Me.TabPage1.Controls.Add(Me.LabelBarkodNo)
        Me.TabPage1.Controls.Add(Me.ButonCikis)
        Me.TabPage1.Controls.Add(Me.ButonEkle)
        Me.TabPage1.Controls.Add(Me.ComboBirim)
        Me.TabPage1.Controls.Add(Me.ComboMarka)
        Me.TabPage1.Controls.Add(Me.ComboKategori)
        Me.TabPage1.Controls.Add(Me.TextSatisFiyati)
        Me.TabPage1.Controls.Add(Me.TextAlisFiyati)
        Me.TabPage1.Controls.Add(Me.TextMiktari)
        Me.TabPage1.Controls.Add(Me.TextUrunAdi)
        Me.TabPage1.Controls.Add(Me.TextBarkodNo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(424, 455)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Yeni Ürün"
        '
        'LabelSatisFiyati
        '
        Me.LabelSatisFiyati.AutoSize = True
        Me.LabelSatisFiyati.Location = New System.Drawing.Point(8, 344)
        Me.LabelSatisFiyati.Name = "LabelSatisFiyati"
        Me.LabelSatisFiyati.Size = New System.Drawing.Size(98, 22)
        Me.LabelSatisFiyati.TabIndex = 5
        Me.LabelSatisFiyati.Text = "Satış Fiyatı:"
        '
        'LabelAlisFiyati
        '
        Me.LabelAlisFiyati.AutoSize = True
        Me.LabelAlisFiyati.Location = New System.Drawing.Point(24, 289)
        Me.LabelAlisFiyati.Name = "LabelAlisFiyati"
        Me.LabelAlisFiyati.Size = New System.Drawing.Size(87, 22)
        Me.LabelAlisFiyati.TabIndex = 5
        Me.LabelAlisFiyati.Text = "Alış Fiyatı:"
        '
        'LabelBirim
        '
        Me.LabelBirim.AutoSize = True
        Me.LabelBirim.Location = New System.Drawing.Point(55, 249)
        Me.LabelBirim.Name = "LabelBirim"
        Me.LabelBirim.Size = New System.Drawing.Size(56, 22)
        Me.LabelBirim.TabIndex = 5
        Me.LabelBirim.Text = "Birim:"
        '
        'LabelMiktar
        '
        Me.LabelMiktar.AutoSize = True
        Me.LabelMiktar.Location = New System.Drawing.Point(47, 202)
        Me.LabelMiktar.Name = "LabelMiktar"
        Me.LabelMiktar.Size = New System.Drawing.Size(64, 22)
        Me.LabelMiktar.TabIndex = 5
        Me.LabelMiktar.Text = "Miktar:"
        '
        'LabelUrunAdi
        '
        Me.LabelUrunAdi.AutoSize = True
        Me.LabelUrunAdi.Location = New System.Drawing.Point(32, 160)
        Me.LabelUrunAdi.Name = "LabelUrunAdi"
        Me.LabelUrunAdi.Size = New System.Drawing.Size(84, 22)
        Me.LabelUrunAdi.TabIndex = 5
        Me.LabelUrunAdi.Text = "Ürün Adı:"
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.Location = New System.Drawing.Point(54, 118)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(62, 22)
        Me.LabelMarka.TabIndex = 5
        Me.LabelMarka.Text = "Marka:"
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Location = New System.Drawing.Point(35, 73)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(81, 22)
        Me.LabelKategori.TabIndex = 5
        Me.LabelKategori.Text = "Kategori:"
        '
        'LabelBarkodNo
        '
        Me.LabelBarkodNo.AutoSize = True
        Me.LabelBarkodNo.Location = New System.Drawing.Point(18, 27)
        Me.LabelBarkodNo.Name = "LabelBarkodNo"
        Me.LabelBarkodNo.Size = New System.Drawing.Size(98, 22)
        Me.LabelBarkodNo.TabIndex = 5
        Me.LabelBarkodNo.Text = "Barkod No:"
        '
        'ButonCikis
        '
        Me.ButonCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonCikis.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButonCikis.ImageKey = "cancel.png"
        Me.ButonCikis.ImageList = Me.ımageList1
        Me.ButonCikis.Location = New System.Drawing.Point(251, 381)
        Me.ButonCikis.Name = "ButonCikis"
        Me.ButonCikis.Size = New System.Drawing.Size(80, 33)
        Me.ButonCikis.TabIndex = 4
        Me.ButonCikis.Text = "İptal"
        Me.ButonCikis.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ButonCikis.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "add-file.png")
        Me.ımageList1.Images.SetKeyName(1, "cancel.png")
        Me.ımageList1.Images.SetKeyName(2, "updated.png")
        Me.ımageList1.Images.SetKeyName(3, "2104046.png")
        '
        'ButonEkle
        '
        Me.ButonEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButonEkle.ImageKey = "add-file.png"
        Me.ButonEkle.ImageList = Me.ımageList1
        Me.ButonEkle.Location = New System.Drawing.Point(127, 381)
        Me.ButonEkle.Name = "ButonEkle"
        Me.ButonEkle.Size = New System.Drawing.Size(78, 33)
        Me.ButonEkle.TabIndex = 4
        Me.ButonEkle.Text = "Ekle"
        Me.ButonEkle.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ButonEkle.UseVisualStyleBackColor = True
        '
        'ComboBirim
        '
        Me.ComboBirim.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBirim.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBirim.FormattingEnabled = True
        Me.ComboBirim.Location = New System.Drawing.Point(140, 241)
        Me.ComboBirim.Name = "ComboBirim"
        Me.ComboBirim.Size = New System.Drawing.Size(173, 30)
        Me.ComboBirim.TabIndex = 3
        '
        'ComboMarka
        '
        Me.ComboMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboMarka.FormattingEnabled = True
        Me.ComboMarka.Location = New System.Drawing.Point(140, 110)
        Me.ComboMarka.Name = "ComboMarka"
        Me.ComboMarka.Size = New System.Drawing.Size(173, 30)
        Me.ComboMarka.TabIndex = 2
        '
        'ComboKategori
        '
        Me.ComboKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboKategori.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboKategori.FormattingEnabled = True
        Me.ComboKategori.Location = New System.Drawing.Point(140, 65)
        Me.ComboKategori.Name = "ComboKategori"
        Me.ComboKategori.Size = New System.Drawing.Size(173, 30)
        Me.ComboKategori.TabIndex = 1
        '
        'TextSatisFiyati
        '
        Me.TextSatisFiyati.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSatisFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSatisFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextSatisFiyati.Location = New System.Drawing.Point(140, 339)
        Me.TextSatisFiyati.Name = "TextSatisFiyati"
        Me.TextSatisFiyati.Size = New System.Drawing.Size(173, 27)
        Me.TextSatisFiyati.TabIndex = 0
        '
        'TextAlisFiyati
        '
        Me.TextAlisFiyati.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAlisFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAlisFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextAlisFiyati.Location = New System.Drawing.Point(140, 289)
        Me.TextAlisFiyati.Name = "TextAlisFiyati"
        Me.TextAlisFiyati.Size = New System.Drawing.Size(173, 27)
        Me.TextAlisFiyati.TabIndex = 0
        '
        'TextMiktari
        '
        Me.TextMiktari.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMiktari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMiktari.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMiktari.Location = New System.Drawing.Point(140, 197)
        Me.TextMiktari.Name = "TextMiktari"
        Me.TextMiktari.Size = New System.Drawing.Size(173, 27)
        Me.TextMiktari.TabIndex = 0
        '
        'TextUrunAdi
        '
        Me.TextUrunAdi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUrunAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextUrunAdi.Location = New System.Drawing.Point(140, 155)
        Me.TextUrunAdi.Name = "TextUrunAdi"
        Me.TextUrunAdi.Size = New System.Drawing.Size(173, 27)
        Me.TextUrunAdi.TabIndex = 0
        '
        'TextBarkodNo
        '
        Me.TextBarkodNo.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBarkodNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBarkodNo.Location = New System.Drawing.Point(140, 22)
        Me.TextBarkodNo.Name = "TextBarkodNo"
        Me.TextBarkodNo.Size = New System.Drawing.Size(173, 27)
        Me.TextBarkodNo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.LabelSatisFiyati2)
        Me.TabPage2.Controls.Add(Me.LabelAlisFiyati2)
        Me.TabPage2.Controls.Add(Me.LabelBirim2)
        Me.TabPage2.Controls.Add(Me.LabelMiktar2)
        Me.TabPage2.Controls.Add(Me.LabelUrunAdi2)
        Me.TabPage2.Controls.Add(Me.LabelMarka2)
        Me.TabPage2.Controls.Add(Me.LabelKategori2)
        Me.TabPage2.Controls.Add(Me.LabelBarkodNo2)
        Me.TabPage2.Controls.Add(Me.Butonİptal)
        Me.TabPage2.Controls.Add(Me.ButonGuncelle)
        Me.TabPage2.Controls.Add(Me.TextSatisFiyati2)
        Me.TabPage2.Controls.Add(Me.TextAlisFiyati2)
        Me.TabPage2.Controls.Add(Me.TextBirim2)
        Me.TabPage2.Controls.Add(Me.TextMiktar2)
        Me.TabPage2.Controls.Add(Me.TextMarka2)
        Me.TabPage2.Controls.Add(Me.TextKategori2)
        Me.TabPage2.Controls.Add(Me.TextUrunAdi2)
        Me.TabPage2.Controls.Add(Me.TextBarkodNo2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(424, 455)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Varolan Ürün"
        '
        'Button1
        '
        Me.Button1.ImageKey = "2104046.png"
        Me.Button1.ImageList = Me.ımageList1
        Me.Button1.Location = New System.Drawing.Point(8, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 31)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.ImageKey = "2104046.png"
        Me.Label17.ImageList = Me.ımageList1
        Me.Label17.Location = New System.Drawing.Point(53, 418)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 22)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Miktar"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSatisFiyati2
        '
        Me.LabelSatisFiyati2.AutoSize = True
        Me.LabelSatisFiyati2.Location = New System.Drawing.Point(30, 344)
        Me.LabelSatisFiyati2.Name = "LabelSatisFiyati2"
        Me.LabelSatisFiyati2.Size = New System.Drawing.Size(98, 22)
        Me.LabelSatisFiyati2.TabIndex = 23
        Me.LabelSatisFiyati2.Text = "Satış Fiyatı:"
        '
        'LabelAlisFiyati2
        '
        Me.LabelAlisFiyati2.AutoSize = True
        Me.LabelAlisFiyati2.Location = New System.Drawing.Point(41, 294)
        Me.LabelAlisFiyati2.Name = "LabelAlisFiyati2"
        Me.LabelAlisFiyati2.Size = New System.Drawing.Size(87, 22)
        Me.LabelAlisFiyati2.TabIndex = 21
        Me.LabelAlisFiyati2.Text = "Alış Fiyatı:"
        '
        'LabelBirim2
        '
        Me.LabelBirim2.AutoSize = True
        Me.LabelBirim2.Location = New System.Drawing.Point(79, 249)
        Me.LabelBirim2.Name = "LabelBirim2"
        Me.LabelBirim2.Size = New System.Drawing.Size(56, 22)
        Me.LabelBirim2.TabIndex = 20
        Me.LabelBirim2.Text = "Birim:"
        '
        'LabelMiktar2
        '
        Me.LabelMiktar2.AutoSize = True
        Me.LabelMiktar2.Location = New System.Drawing.Point(71, 202)
        Me.LabelMiktar2.Name = "LabelMiktar2"
        Me.LabelMiktar2.Size = New System.Drawing.Size(64, 22)
        Me.LabelMiktar2.TabIndex = 19
        Me.LabelMiktar2.Text = "Miktar:"
        '
        'LabelUrunAdi2
        '
        Me.LabelUrunAdi2.AutoSize = True
        Me.LabelUrunAdi2.Location = New System.Drawing.Point(51, 160)
        Me.LabelUrunAdi2.Name = "LabelUrunAdi2"
        Me.LabelUrunAdi2.Size = New System.Drawing.Size(84, 22)
        Me.LabelUrunAdi2.TabIndex = 18
        Me.LabelUrunAdi2.Text = "Ürün Adı:"
        '
        'LabelMarka2
        '
        Me.LabelMarka2.AutoSize = True
        Me.LabelMarka2.Location = New System.Drawing.Point(73, 118)
        Me.LabelMarka2.Name = "LabelMarka2"
        Me.LabelMarka2.Size = New System.Drawing.Size(62, 22)
        Me.LabelMarka2.TabIndex = 17
        Me.LabelMarka2.Text = "Marka:"
        '
        'LabelKategori2
        '
        Me.LabelKategori2.AutoSize = True
        Me.LabelKategori2.Location = New System.Drawing.Point(58, 76)
        Me.LabelKategori2.Name = "LabelKategori2"
        Me.LabelKategori2.Size = New System.Drawing.Size(81, 22)
        Me.LabelKategori2.TabIndex = 16
        Me.LabelKategori2.Text = "Kategori:"
        '
        'LabelBarkodNo2
        '
        Me.LabelBarkodNo2.AutoSize = True
        Me.LabelBarkodNo2.Location = New System.Drawing.Point(41, 27)
        Me.LabelBarkodNo2.Name = "LabelBarkodNo2"
        Me.LabelBarkodNo2.Size = New System.Drawing.Size(98, 22)
        Me.LabelBarkodNo2.TabIndex = 22
        Me.LabelBarkodNo2.Text = "Barkod No:"
        '
        'Butonİptal
        '
        Me.Butonİptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Butonİptal.ImageKey = "cancel.png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(259, 381)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(99, 33)
        Me.Butonİptal.TabIndex = 15
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Butonİptal.UseVisualStyleBackColor = True
        '
        'ButonGuncelle
        '
        Me.ButonGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButonGuncelle.ImageKey = "updated.png"
        Me.ButonGuncelle.ImageList = Me.ımageList1
        Me.ButonGuncelle.Location = New System.Drawing.Point(122, 381)
        Me.ButonGuncelle.Name = "ButonGuncelle"
        Me.ButonGuncelle.Size = New System.Drawing.Size(112, 33)
        Me.ButonGuncelle.TabIndex = 14
        Me.ButonGuncelle.Text = "Güncelle"
        Me.ButonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonGuncelle.UseVisualStyleBackColor = True
        '
        'TextSatisFiyati2
        '
        Me.TextSatisFiyati2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSatisFiyati2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSatisFiyati2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextSatisFiyati2.Location = New System.Drawing.Point(166, 339)
        Me.TextSatisFiyati2.Name = "TextSatisFiyati2"
        Me.TextSatisFiyati2.Size = New System.Drawing.Size(173, 27)
        Me.TextSatisFiyati2.TabIndex = 9
        '
        'TextAlisFiyati2
        '
        Me.TextAlisFiyati2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAlisFiyati2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAlisFiyati2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextAlisFiyati2.Location = New System.Drawing.Point(166, 294)
        Me.TextAlisFiyati2.Name = "TextAlisFiyati2"
        Me.TextAlisFiyati2.Size = New System.Drawing.Size(173, 27)
        Me.TextAlisFiyati2.TabIndex = 8
        '
        'TextBirim2
        '
        Me.TextBirim2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirim2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirim2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBirim2.Location = New System.Drawing.Point(166, 249)
        Me.TextBirim2.Name = "TextBirim2"
        Me.TextBirim2.Size = New System.Drawing.Size(173, 27)
        Me.TextBirim2.TabIndex = 7
        '
        'TextMiktar2
        '
        Me.TextMiktar2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMiktar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMiktar2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMiktar2.Location = New System.Drawing.Point(166, 202)
        Me.TextMiktar2.Name = "TextMiktar2"
        Me.TextMiktar2.Size = New System.Drawing.Size(173, 27)
        Me.TextMiktar2.TabIndex = 7
        '
        'TextMarka2
        '
        Me.TextMarka2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMarka2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMarka2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMarka2.Location = New System.Drawing.Point(166, 113)
        Me.TextMarka2.Name = "TextMarka2"
        Me.TextMarka2.Size = New System.Drawing.Size(173, 27)
        Me.TextMarka2.TabIndex = 10
        '
        'TextKategori2
        '
        Me.TextKategori2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKategori2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKategori2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextKategori2.Location = New System.Drawing.Point(166, 71)
        Me.TextKategori2.Name = "TextKategori2"
        Me.TextKategori2.Size = New System.Drawing.Size(173, 27)
        Me.TextKategori2.TabIndex = 10
        '
        'TextUrunAdi2
        '
        Me.TextUrunAdi2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextUrunAdi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUrunAdi2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextUrunAdi2.Location = New System.Drawing.Point(166, 160)
        Me.TextUrunAdi2.Name = "TextUrunAdi2"
        Me.TextUrunAdi2.Size = New System.Drawing.Size(173, 27)
        Me.TextUrunAdi2.TabIndex = 10
        '
        'TextBarkodNo2
        '
        Me.TextBarkodNo2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBarkodNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBarkodNo2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBarkodNo2.Location = New System.Drawing.Point(166, 22)
        Me.TextBarkodNo2.Name = "TextBarkodNo2"
        Me.TextBarkodNo2.Size = New System.Drawing.Size(173, 27)
        Me.TextBarkodNo2.TabIndex = 6
        '
        'FormUrunEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(432, 490)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormUrunEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LabelSatisFiyati As Label
    Friend WithEvents LabelAlisFiyati As Label
    Friend WithEvents LabelBirim As Label
    Friend WithEvents LabelMiktar As Label
    Friend WithEvents LabelUrunAdi As Label
    Friend WithEvents LabelMarka As Label
    Friend WithEvents LabelKategori As Label
    Friend WithEvents LabelBarkodNo As Label
    Friend WithEvents ButonCikis As Button
    Friend WithEvents ButonEkle As Button
    Friend WithEvents ComboBirim As ComboBox
    Friend WithEvents ComboMarka As ComboBox
    Friend WithEvents ComboKategori As ComboBox
    Friend WithEvents TextSatisFiyati As TextBox
    Friend WithEvents TextAlisFiyati As TextBox
    Friend WithEvents TextMiktari As TextBox
    Friend WithEvents TextUrunAdi As TextBox
    Friend WithEvents TextBarkodNo As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents LabelSatisFiyati2 As Label
    Friend WithEvents LabelAlisFiyati2 As Label
    Friend WithEvents LabelBirim2 As Label
    Friend WithEvents LabelMiktar2 As Label
    Friend WithEvents LabelUrunAdi2 As Label
    Friend WithEvents LabelMarka2 As Label
    Friend WithEvents LabelKategori2 As Label
    Friend WithEvents LabelBarkodNo2 As Label
    Friend WithEvents Butonİptal As Button
    Friend WithEvents ButonGuncelle As Button
    Friend WithEvents TextSatisFiyati2 As TextBox
    Friend WithEvents TextAlisFiyati2 As TextBox
    Friend WithEvents TextBirim2 As TextBox
    Friend WithEvents TextMiktar2 As TextBox
    Friend WithEvents TextUrunAdi2 As TextBox
    Friend WithEvents TextBarkodNo2 As TextBox
    Friend WithEvents ComboMarka2 As ComboBox
    Friend WithEvents ComboKategori2 As ComboBox
    Friend WithEvents TextMarka2 As TextBox
    Friend WithEvents TextKategori2 As TextBox
End Class

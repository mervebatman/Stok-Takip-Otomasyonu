<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSatis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSatis))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelMusteri = New System.Windows.Forms.Panel()
        Me.LabelTelefon = New System.Windows.Forms.Label()
        Me.LabelMusteriID = New System.Windows.Forms.Label()
        Me.LabelAdiSoyadi = New System.Windows.Forms.Label()
        Me.TextMusteriID = New System.Windows.Forms.TextBox()
        Me.TextAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.TextTelefon = New System.Windows.Forms.TextBox()
        Me.PanelUrun = New System.Windows.Forms.Panel()
        Me.ButonSepeteEkle = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextToplamFiyati = New System.Windows.Forms.TextBox()
        Me.LabelToplamFiyati = New System.Windows.Forms.Label()
        Me.TextBirim = New System.Windows.Forms.TextBox()
        Me.LabelBirimFiyati = New System.Windows.Forms.Label()
        Me.TextBirimFiyati = New System.Windows.Forms.TextBox()
        Me.LabelBirim = New System.Windows.Forms.Label()
        Me.TextMarka = New System.Windows.Forms.TextBox()
        Me.LabelMiktar = New System.Windows.Forms.Label()
        Me.TextMiktar = New System.Windows.Forms.TextBox()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelUrunAdi = New System.Windows.Forms.Label()
        Me.LabelBarkodNo = New System.Windows.Forms.Label()
        Me.TextUrunAdi = New System.Windows.Forms.TextBox()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.TextKategori = New System.Windows.Forms.TextBox()
        Me.TextBarkodNo = New System.Windows.Forms.TextBox()
        Me.ButonYazdir = New System.Windows.Forms.Button()
        Me.ButonSatisYap = New System.Windows.Forms.Button()
        Me.TextParaUstu = New System.Windows.Forms.TextBox()
        Me.TextOdenen = New System.Windows.Forms.TextBox()
        Me.LabelParaUstu = New System.Windows.Forms.Label()
        Me.LabelOdenen = New System.Windows.Forms.Label()
        Me.LabelKrediKarti = New System.Windows.Forms.Label()
        Me.LabelNakit = New System.Windows.Forms.Label()
        Me.ComboOdemeTuru = New System.Windows.Forms.ComboBox()
        Me.LabelOdemeTuru = New System.Windows.Forms.Label()
        Me.LabelOdemeler = New System.Windows.Forms.Label()
        Me.TextToplam = New System.Windows.Forms.TextBox()
        Me.LabelToplam = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButonAnaSayfa = New System.Windows.Forms.Button()
        Me.ButonUrunİade = New System.Windows.Forms.Button()
        Me.ButonSatisİptal = New System.Windows.Forms.Button()
        Me.LabelToplamKayit = New System.Windows.Forms.Label()
        Me.LabelKayitSayisi = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sil = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanelMusteri.SuspendLayout()
        Me.PanelUrun.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelMusteri)
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelUrun)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1099, 143)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PanelMusteri
        '
        Me.PanelMusteri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMusteri.Controls.Add(Me.LabelTelefon)
        Me.PanelMusteri.Controls.Add(Me.LabelMusteriID)
        Me.PanelMusteri.Controls.Add(Me.LabelAdiSoyadi)
        Me.PanelMusteri.Controls.Add(Me.TextMusteriID)
        Me.PanelMusteri.Controls.Add(Me.TextAdiSoyadi)
        Me.PanelMusteri.Controls.Add(Me.TextTelefon)
        Me.PanelMusteri.Location = New System.Drawing.Point(3, 3)
        Me.PanelMusteri.Name = "PanelMusteri"
        Me.PanelMusteri.Size = New System.Drawing.Size(280, 132)
        Me.PanelMusteri.TabIndex = 1
        '
        'LabelTelefon
        '
        Me.LabelTelefon.AutoSize = True
        Me.LabelTelefon.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTelefon.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTelefon.Location = New System.Drawing.Point(34, 85)
        Me.LabelTelefon.Name = "LabelTelefon"
        Me.LabelTelefon.Size = New System.Drawing.Size(71, 22)
        Me.LabelTelefon.TabIndex = 5
        Me.LabelTelefon.Text = "Telefon:"
        '
        'LabelMusteriID
        '
        Me.LabelMusteriID.AutoSize = True
        Me.LabelMusteriID.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMusteriID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMusteriID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMusteriID.Location = New System.Drawing.Point(9, 16)
        Me.LabelMusteriID.Name = "LabelMusteriID"
        Me.LabelMusteriID.Size = New System.Drawing.Size(96, 22)
        Me.LabelMusteriID.TabIndex = 7
        Me.LabelMusteriID.Text = "Müşteri ID:"
        '
        'LabelAdiSoyadi
        '
        Me.LabelAdiSoyadi.AutoSize = True
        Me.LabelAdiSoyadi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdiSoyadi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdiSoyadi.Location = New System.Drawing.Point(9, 53)
        Me.LabelAdiSoyadi.Name = "LabelAdiSoyadi"
        Me.LabelAdiSoyadi.Size = New System.Drawing.Size(96, 22)
        Me.LabelAdiSoyadi.TabIndex = 6
        Me.LabelAdiSoyadi.Text = "Adı Soyadı:"
        '
        'TextMusteriID
        '
        Me.TextMusteriID.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextMusteriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMusteriID.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMusteriID.ForeColor = System.Drawing.SystemColors.Window
        Me.TextMusteriID.Location = New System.Drawing.Point(111, 16)
        Me.TextMusteriID.Name = "TextMusteriID"
        Me.TextMusteriID.Size = New System.Drawing.Size(154, 23)
        Me.TextMusteriID.TabIndex = 4
        '
        'TextAdiSoyadi
        '
        Me.TextAdiSoyadi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdiSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdiSoyadi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdiSoyadi.Location = New System.Drawing.Point(111, 53)
        Me.TextAdiSoyadi.Name = "TextAdiSoyadi"
        Me.TextAdiSoyadi.Size = New System.Drawing.Size(154, 23)
        Me.TextAdiSoyadi.TabIndex = 3
        '
        'TextTelefon
        '
        Me.TextTelefon.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTelefon.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextTelefon.ForeColor = System.Drawing.SystemColors.Window
        Me.TextTelefon.Location = New System.Drawing.Point(111, 87)
        Me.TextTelefon.Name = "TextTelefon"
        Me.TextTelefon.Size = New System.Drawing.Size(154, 23)
        Me.TextTelefon.TabIndex = 2
        '
        'PanelUrun
        '
        Me.PanelUrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUrun.Controls.Add(Me.ButonSepeteEkle)
        Me.PanelUrun.Controls.Add(Me.TextToplamFiyati)
        Me.PanelUrun.Controls.Add(Me.LabelToplamFiyati)
        Me.PanelUrun.Controls.Add(Me.TextBirim)
        Me.PanelUrun.Controls.Add(Me.LabelBirimFiyati)
        Me.PanelUrun.Controls.Add(Me.TextBirimFiyati)
        Me.PanelUrun.Controls.Add(Me.LabelBirim)
        Me.PanelUrun.Controls.Add(Me.TextMarka)
        Me.PanelUrun.Controls.Add(Me.LabelMiktar)
        Me.PanelUrun.Controls.Add(Me.TextMiktar)
        Me.PanelUrun.Controls.Add(Me.LabelMarka)
        Me.PanelUrun.Controls.Add(Me.LabelUrunAdi)
        Me.PanelUrun.Controls.Add(Me.LabelBarkodNo)
        Me.PanelUrun.Controls.Add(Me.TextUrunAdi)
        Me.PanelUrun.Controls.Add(Me.LabelKategori)
        Me.PanelUrun.Controls.Add(Me.TextKategori)
        Me.PanelUrun.Controls.Add(Me.TextBarkodNo)
        Me.PanelUrun.Location = New System.Drawing.Point(289, 3)
        Me.PanelUrun.Name = "PanelUrun"
        Me.PanelUrun.Size = New System.Drawing.Size(801, 132)
        Me.PanelUrun.TabIndex = 2
        '
        'ButonSepeteEkle
        '
        Me.ButonSepeteEkle.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSepeteEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSepeteEkle.ImageKey = "2229589.png"
        Me.ButonSepeteEkle.ImageList = Me.ımageList1
        Me.ButonSepeteEkle.Location = New System.Drawing.Point(703, 83)
        Me.ButonSepeteEkle.Name = "ButonSepeteEkle"
        Me.ButonSepeteEkle.Size = New System.Drawing.Size(93, 39)
        Me.ButonSepeteEkle.TabIndex = 1
        Me.ButonSepeteEkle.Text = "Ekle"
        Me.ButonSepeteEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSepeteEkle.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "2229589.png")
        Me.ımageList1.Images.SetKeyName(1, "trade.png")
        Me.ımageList1.Images.SetKeyName(2, "house.png")
        Me.ımageList1.Images.SetKeyName(3, "debt.png")
        Me.ımageList1.Images.SetKeyName(4, "price-tag.png")
        Me.ımageList1.Images.SetKeyName(5, "exchange.png")
        Me.ımageList1.Images.SetKeyName(6, "cancel (1).png")
        Me.ımageList1.Images.SetKeyName(7, "printer.png")
        '
        'TextToplamFiyati
        '
        Me.TextToplamFiyati.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextToplamFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextToplamFiyati.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextToplamFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextToplamFiyati.Location = New System.Drawing.Point(651, 53)
        Me.TextToplamFiyati.Name = "TextToplamFiyati"
        Me.TextToplamFiyati.Size = New System.Drawing.Size(141, 23)
        Me.TextToplamFiyati.TabIndex = 25
        '
        'LabelToplamFiyati
        '
        Me.LabelToplamFiyati.AutoSize = True
        Me.LabelToplamFiyati.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelToplamFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelToplamFiyati.Location = New System.Drawing.Point(526, 54)
        Me.LabelToplamFiyati.Name = "LabelToplamFiyati"
        Me.LabelToplamFiyati.Size = New System.Drawing.Size(119, 22)
        Me.LabelToplamFiyati.TabIndex = 27
        Me.LabelToplamFiyati.Text = "Toplam Fiyatı:"
        '
        'TextBirim
        '
        Me.TextBirim.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirim.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBirim.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBirim.Location = New System.Drawing.Point(366, 93)
        Me.TextBirim.Name = "TextBirim"
        Me.TextBirim.Size = New System.Drawing.Size(154, 23)
        Me.TextBirim.TabIndex = 21
        '
        'LabelBirimFiyati
        '
        Me.LabelBirimFiyati.AutoSize = True
        Me.LabelBirimFiyati.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBirimFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelBirimFiyati.Location = New System.Drawing.Point(542, 14)
        Me.LabelBirimFiyati.Name = "LabelBirimFiyati"
        Me.LabelBirimFiyati.Size = New System.Drawing.Size(103, 22)
        Me.LabelBirimFiyati.TabIndex = 26
        Me.LabelBirimFiyati.Text = "Birim Fiyatı:"
        '
        'TextBirimFiyati
        '
        Me.TextBirimFiyati.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirimFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirimFiyati.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBirimFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBirimFiyati.Location = New System.Drawing.Point(651, 14)
        Me.TextBirimFiyati.Name = "TextBirimFiyati"
        Me.TextBirimFiyati.Size = New System.Drawing.Size(141, 23)
        Me.TextBirimFiyati.TabIndex = 24
        '
        'LabelBirim
        '
        Me.LabelBirim.AutoSize = True
        Me.LabelBirim.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBirim.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelBirim.Location = New System.Drawing.Point(304, 91)
        Me.LabelBirim.Name = "LabelBirim"
        Me.LabelBirim.Size = New System.Drawing.Size(56, 22)
        Me.LabelBirim.TabIndex = 27
        Me.LabelBirim.Text = "Birim:"
        '
        'TextMarka
        '
        Me.TextMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMarka.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMarka.Location = New System.Drawing.Point(107, 93)
        Me.TextMarka.Name = "TextMarka"
        Me.TextMarka.Size = New System.Drawing.Size(154, 23)
        Me.TextMarka.TabIndex = 24
        '
        'LabelMiktar
        '
        Me.LabelMiktar.AutoSize = True
        Me.LabelMiktar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMiktar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMiktar.Location = New System.Drawing.Point(296, 54)
        Me.LabelMiktar.Name = "LabelMiktar"
        Me.LabelMiktar.Size = New System.Drawing.Size(64, 22)
        Me.LabelMiktar.TabIndex = 26
        Me.LabelMiktar.Text = "Miktar:"
        '
        'TextMiktar
        '
        Me.TextMiktar.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMiktar.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMiktar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMiktar.Location = New System.Drawing.Point(366, 54)
        Me.TextMiktar.Name = "TextMiktar"
        Me.TextMiktar.Size = New System.Drawing.Size(154, 26)
        Me.TextMiktar.TabIndex = 22
        Me.TextMiktar.Text = "1"
        Me.TextMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMarka.Location = New System.Drawing.Point(39, 88)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(62, 22)
        Me.LabelMarka.TabIndex = 28
        Me.LabelMarka.Text = "Marka:"
        '
        'LabelUrunAdi
        '
        Me.LabelUrunAdi.AutoSize = True
        Me.LabelUrunAdi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelUrunAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelUrunAdi.Location = New System.Drawing.Point(276, 14)
        Me.LabelUrunAdi.Name = "LabelUrunAdi"
        Me.LabelUrunAdi.Size = New System.Drawing.Size(84, 22)
        Me.LabelUrunAdi.TabIndex = 25
        Me.LabelUrunAdi.Text = "Ürün Adı:"
        '
        'LabelBarkodNo
        '
        Me.LabelBarkodNo.AutoSize = True
        Me.LabelBarkodNo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBarkodNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelBarkodNo.Location = New System.Drawing.Point(3, 17)
        Me.LabelBarkodNo.Name = "LabelBarkodNo"
        Me.LabelBarkodNo.Size = New System.Drawing.Size(98, 22)
        Me.LabelBarkodNo.TabIndex = 29
        Me.LabelBarkodNo.Text = "Barkod No:"
        '
        'TextUrunAdi
        '
        Me.TextUrunAdi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUrunAdi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextUrunAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextUrunAdi.Location = New System.Drawing.Point(366, 13)
        Me.TextUrunAdi.Name = "TextUrunAdi"
        Me.TextUrunAdi.Size = New System.Drawing.Size(154, 23)
        Me.TextUrunAdi.TabIndex = 23
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKategori.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKategori.Location = New System.Drawing.Point(20, 54)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(81, 22)
        Me.LabelKategori.TabIndex = 27
        Me.LabelKategori.Text = "Kategori:"
        '
        'TextKategori
        '
        Me.TextKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKategori.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextKategori.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextKategori.Location = New System.Drawing.Point(107, 53)
        Me.TextKategori.Name = "TextKategori"
        Me.TextKategori.Size = New System.Drawing.Size(154, 23)
        Me.TextKategori.TabIndex = 25
        '
        'TextBarkodNo
        '
        Me.TextBarkodNo.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBarkodNo.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBarkodNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBarkodNo.Location = New System.Drawing.Point(107, 19)
        Me.TextBarkodNo.Name = "TextBarkodNo"
        Me.TextBarkodNo.Size = New System.Drawing.Size(154, 23)
        Me.TextBarkodNo.TabIndex = 23
        '
        'ButonYazdir
        '
        Me.ButonYazdir.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonYazdir.ImageKey = "printer.png"
        Me.ButonYazdir.ImageList = Me.ımageList1
        Me.ButonYazdir.Location = New System.Drawing.Point(618, 67)
        Me.ButonYazdir.Name = "ButonYazdir"
        Me.ButonYazdir.Size = New System.Drawing.Size(104, 38)
        Me.ButonYazdir.TabIndex = 3
        Me.ButonYazdir.Text = "Yazdır"
        Me.ButonYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonYazdir.UseVisualStyleBackColor = True
        '
        'ButonSatisYap
        '
        Me.ButonSatisYap.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSatisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSatisYap.ImageKey = "trade.png"
        Me.ButonSatisYap.ImageList = Me.ımageList1
        Me.ButonSatisYap.Location = New System.Drawing.Point(618, 7)
        Me.ButonSatisYap.Name = "ButonSatisYap"
        Me.ButonSatisYap.Size = New System.Drawing.Size(104, 56)
        Me.ButonSatisYap.TabIndex = 2
        Me.ButonSatisYap.Text = " Satış " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Yap"
        Me.ButonSatisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSatisYap.UseVisualStyleBackColor = True
        '
        'TextParaUstu
        '
        Me.TextParaUstu.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextParaUstu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextParaUstu.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextParaUstu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextParaUstu.Location = New System.Drawing.Point(454, 67)
        Me.TextParaUstu.Name = "TextParaUstu"
        Me.TextParaUstu.Size = New System.Drawing.Size(145, 26)
        Me.TextParaUstu.TabIndex = 5
        '
        'TextOdenen
        '
        Me.TextOdenen.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextOdenen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextOdenen.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextOdenen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextOdenen.Location = New System.Drawing.Point(454, 35)
        Me.TextOdenen.Name = "TextOdenen"
        Me.TextOdenen.Size = New System.Drawing.Size(145, 26)
        Me.TextOdenen.TabIndex = 5
        '
        'LabelParaUstu
        '
        Me.LabelParaUstu.AutoSize = True
        Me.LabelParaUstu.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelParaUstu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelParaUstu.Location = New System.Drawing.Point(361, 72)
        Me.LabelParaUstu.Name = "LabelParaUstu"
        Me.LabelParaUstu.Size = New System.Drawing.Size(87, 21)
        Me.LabelParaUstu.TabIndex = 4
        Me.LabelParaUstu.Text = "Para Üstü:"
        '
        'LabelOdenen
        '
        Me.LabelOdenen.AutoSize = True
        Me.LabelOdenen.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelOdenen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelOdenen.Location = New System.Drawing.Point(349, 37)
        Me.LabelOdenen.Name = "LabelOdenen"
        Me.LabelOdenen.Size = New System.Drawing.Size(99, 21)
        Me.LabelOdenen.TabIndex = 4
        Me.LabelOdenen.Text = "Ödenen(F3)"
        '
        'LabelKrediKarti
        '
        Me.LabelKrediKarti.AutoSize = True
        Me.LabelKrediKarti.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKrediKarti.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKrediKarti.Location = New System.Drawing.Point(118, 79)
        Me.LabelKrediKarti.Name = "LabelKrediKarti"
        Me.LabelKrediKarti.Size = New System.Drawing.Size(100, 18)
        Me.LabelKrediKarti.TabIndex = 3
        Me.LabelKrediKarti.Text = "Kredi Kartı(F2)"
        '
        'LabelNakit
        '
        Me.LabelNakit.AutoSize = True
        Me.LabelNakit.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelNakit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelNakit.Location = New System.Drawing.Point(30, 79)
        Me.LabelNakit.Name = "LabelNakit"
        Me.LabelNakit.Size = New System.Drawing.Size(65, 18)
        Me.LabelNakit.TabIndex = 3
        Me.LabelNakit.Text = "Nakit(F1)"
        '
        'ComboOdemeTuru
        '
        Me.ComboOdemeTuru.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboOdemeTuru.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboOdemeTuru.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboOdemeTuru.FormattingEnabled = True
        Me.ComboOdemeTuru.Items.AddRange(New Object() {"Nakit", "Kredi Kartı"})
        Me.ComboOdemeTuru.Location = New System.Drawing.Point(121, 34)
        Me.ComboOdemeTuru.Name = "ComboOdemeTuru"
        Me.ComboOdemeTuru.Size = New System.Drawing.Size(157, 29)
        Me.ComboOdemeTuru.TabIndex = 2
        '
        'LabelOdemeTuru
        '
        Me.LabelOdemeTuru.AutoSize = True
        Me.LabelOdemeTuru.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelOdemeTuru.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelOdemeTuru.Location = New System.Drawing.Point(6, 42)
        Me.LabelOdemeTuru.Name = "LabelOdemeTuru"
        Me.LabelOdemeTuru.Size = New System.Drawing.Size(109, 21)
        Me.LabelOdemeTuru.TabIndex = 1
        Me.LabelOdemeTuru.Text = "Ödeme Türü:"
        '
        'LabelOdemeler
        '
        Me.LabelOdemeler.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelOdemeler.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelOdemeler.Location = New System.Drawing.Point(271, 9)
        Me.LabelOdemeler.Name = "LabelOdemeler"
        Me.LabelOdemeler.Size = New System.Drawing.Size(91, 22)
        Me.LabelOdemeler.TabIndex = 0
        Me.LabelOdemeler.Text = "Ödemeler"
        '
        'TextToplam
        '
        Me.TextToplam.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextToplam.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextToplam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextToplam.Location = New System.Drawing.Point(99, 23)
        Me.TextToplam.Name = "TextToplam"
        Me.TextToplam.Size = New System.Drawing.Size(137, 26)
        Me.TextToplam.TabIndex = 4
        '
        'LabelToplam
        '
        Me.LabelToplam.AutoSize = True
        Me.LabelToplam.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelToplam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelToplam.Location = New System.Drawing.Point(24, 25)
        Me.LabelToplam.Name = "LabelToplam"
        Me.LabelToplam.Size = New System.Drawing.Size(69, 21)
        Me.LabelToplam.TabIndex = 3
        Me.LabelToplam.Text = "Toplam:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(242, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "TL"
        '
        'ButonAnaSayfa
        '
        Me.ButonAnaSayfa.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButonAnaSayfa.ImageKey = "house.png"
        Me.ButonAnaSayfa.ImageList = Me.ımageList1
        Me.ButonAnaSayfa.Location = New System.Drawing.Point(12, 559)
        Me.ButonAnaSayfa.Name = "ButonAnaSayfa"
        Me.ButonAnaSayfa.Size = New System.Drawing.Size(97, 55)
        Me.ButonAnaSayfa.TabIndex = 2
        Me.ButonAnaSayfa.Text = "Ana Sayfa"
        Me.ButonAnaSayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButonAnaSayfa.UseVisualStyleBackColor = True
        '
        'ButonUrunİade
        '
        Me.ButonUrunİade.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonUrunİade.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButonUrunİade.ImageKey = "exchange.png"
        Me.ButonUrunİade.ImageList = Me.ımageList1
        Me.ButonUrunİade.Location = New System.Drawing.Point(115, 559)
        Me.ButonUrunİade.Name = "ButonUrunİade"
        Me.ButonUrunİade.Size = New System.Drawing.Size(105, 55)
        Me.ButonUrunİade.TabIndex = 2
        Me.ButonUrunİade.Text = "Ürün İade"
        Me.ButonUrunİade.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButonUrunİade.UseVisualStyleBackColor = True
        '
        'ButonSatisİptal
        '
        Me.ButonSatisİptal.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSatisİptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButonSatisİptal.ImageKey = "cancel (1).png"
        Me.ButonSatisİptal.ImageList = Me.ımageList1
        Me.ButonSatisİptal.Location = New System.Drawing.Point(226, 559)
        Me.ButonSatisİptal.Name = "ButonSatisİptal"
        Me.ButonSatisİptal.Size = New System.Drawing.Size(107, 55)
        Me.ButonSatisİptal.TabIndex = 2
        Me.ButonSatisİptal.Text = "Satış İptal"
        Me.ButonSatisİptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButonSatisİptal.UseVisualStyleBackColor = True
        '
        'LabelToplamKayit
        '
        Me.LabelToplamKayit.AutoSize = True
        Me.LabelToplamKayit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelToplamKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelToplamKayit.Location = New System.Drawing.Point(609, 559)
        Me.LabelToplamKayit.Name = "LabelToplamKayit"
        Me.LabelToplamKayit.Size = New System.Drawing.Size(113, 22)
        Me.LabelToplamKayit.TabIndex = 4
        Me.LabelToplamKayit.Text = "Toplam Kayıt"
        Me.LabelToplamKayit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelKayitSayisi
        '
        Me.LabelKayitSayisi.AutoSize = True
        Me.LabelKayitSayisi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelKayitSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelKayitSayisi.Font = New System.Drawing.Font("Montserrat Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKayitSayisi.Location = New System.Drawing.Point(656, 581)
        Me.LabelKayitSayisi.Name = "LabelKayitSayisi"
        Me.LabelKayitSayisi.Size = New System.Drawing.Size(2, 31)
        Me.LabelKayitSayisi.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextToplam)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.LabelToplam)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 87)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LabelOdemeler)
        Me.Panel4.Controls.Add(Me.LabelOdemeTuru)
        Me.Panel4.Controls.Add(Me.ButonYazdir)
        Me.Panel4.Controls.Add(Me.ComboOdemeTuru)
        Me.Panel4.Controls.Add(Me.LabelNakit)
        Me.Panel4.Controls.Add(Me.ButonSatisYap)
        Me.Panel4.Controls.Add(Me.LabelKrediKarti)
        Me.Panel4.Controls.Add(Me.LabelOdenen)
        Me.Panel4.Controls.Add(Me.TextParaUstu)
        Me.Panel4.Controls.Add(Me.LabelParaUstu)
        Me.Panel4.Controls.Add(Me.TextOdenen)
        Me.Panel4.Location = New System.Drawing.Point(304, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(733, 114)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Location = New System.Drawing.Point(12, 430)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1070, 123)
        Me.Panel5.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sil})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 286)
        Me.DataGridView1.TabIndex = 9
        '
        'Sil
        '
        Me.Sil.HeaderText = "Sil"
        Me.Sil.Name = "Sil"
        Me.Sil.Text = "Sil"
        Me.Sil.ToolTipText = "İlgili kaydı siler"
        Me.Sil.UseColumnTextForButtonValue = True
        '
        'FormSatis
        '
        Me.AcceptButton = Me.ButonSepeteEkle
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1349, 618)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.LabelKayitSayisi)
        Me.Controls.Add(Me.LabelToplamKayit)
        Me.Controls.Add(Me.ButonSatisİptal)
        Me.Controls.Add(Me.ButonUrunİade)
        Me.Controls.Add(Me.ButonAnaSayfa)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "FormSatis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satış Yap"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PanelMusteri.ResumeLayout(False)
        Me.PanelMusteri.PerformLayout()
        Me.PanelUrun.ResumeLayout(False)
        Me.PanelUrun.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PanelMusteri As Panel
    Friend WithEvents LabelTelefon As Label
    Friend WithEvents LabelMusteriID As Label
    Friend WithEvents LabelAdiSoyadi As Label
    Friend WithEvents TextMusteriID As TextBox
    Friend WithEvents TextAdiSoyadi As TextBox
    Friend WithEvents TextTelefon As TextBox
    Friend WithEvents PanelUrun As Panel
    Friend WithEvents TextMarka As TextBox
    Friend WithEvents LabelMarka As Label
    Friend WithEvents LabelBarkodNo As Label
    Friend WithEvents LabelKategori As Label
    Friend WithEvents TextKategori As TextBox
    Friend WithEvents TextBarkodNo As TextBox
    Friend WithEvents TextBirim As TextBox
    Friend WithEvents LabelBirim As Label
    Friend WithEvents LabelMiktar As Label
    Friend WithEvents TextMiktar As TextBox
    Friend WithEvents LabelUrunAdi As Label
    Friend WithEvents TextUrunAdi As TextBox
    Friend WithEvents ButonSepeteEkle As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents TextToplamFiyati As TextBox
    Friend WithEvents LabelToplamFiyati As Label
    Friend WithEvents LabelBirimFiyati As Label
    Friend WithEvents TextBirimFiyati As TextBox
    Friend WithEvents ButonSatisYap As Button
    Friend WithEvents TextParaUstu As TextBox
    Friend WithEvents TextOdenen As TextBox
    Friend WithEvents LabelParaUstu As Label
    Friend WithEvents LabelOdenen As Label
    Friend WithEvents LabelKrediKarti As Label
    Friend WithEvents LabelNakit As Label
    Friend WithEvents ComboOdemeTuru As ComboBox
    Friend WithEvents LabelOdemeTuru As Label
    Friend WithEvents LabelOdemeler As Label
    Friend WithEvents TextToplam As TextBox
    Friend WithEvents LabelToplam As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButonAnaSayfa As Button
    Friend WithEvents ButonUrunİade As Button
    Friend WithEvents ButonSatisİptal As Button
    Friend WithEvents ButonYazdir As Button
    Friend WithEvents LabelToplamKayit As Label
    Friend WithEvents LabelKayitSayisi As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Sil As DataGridViewButtonColumn
End Class

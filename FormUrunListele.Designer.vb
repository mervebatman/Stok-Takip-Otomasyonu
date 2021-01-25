<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunListele))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonGuncelle = New System.Windows.Forms.Button()
        Me.TextSatisFiyati = New System.Windows.Forms.TextBox()
        Me.TextAlisFiyati = New System.Windows.Forms.TextBox()
        Me.TextBirim = New System.Windows.Forms.TextBox()
        Me.TextMiktar = New System.Windows.Forms.TextBox()
        Me.LabelSatisFiyati = New System.Windows.Forms.Label()
        Me.LabelAlisFiyati = New System.Windows.Forms.Label()
        Me.LabelBirim = New System.Windows.Forms.Label()
        Me.LabelMiktar = New System.Windows.Forms.Label()
        Me.TextUrunAdi = New System.Windows.Forms.TextBox()
        Me.TextMarka = New System.Windows.Forms.TextBox()
        Me.TextKategori = New System.Windows.Forms.TextBox()
        Me.TextBarkodNo = New System.Windows.Forms.TextBox()
        Me.LabelUrunAdi = New System.Windows.Forms.Label()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.LabelBarkodNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButonMarkaGuncelle = New System.Windows.Forms.Button()
        Me.ComboMarka = New System.Windows.Forms.ComboBox()
        Me.ComboKategori = New System.Windows.Forms.ComboBox()
        Me.LabelMarka2 = New System.Windows.Forms.Label()
        Me.LabelKategori2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBirim = New System.Windows.Forms.ComboBox()
        Me.ButonBirimGuncelle = New System.Windows.Forms.Button()
        Me.LabelBirim2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButonSil = New System.Windows.Forms.Button()
        Me.TextBarkodNoAra = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelBarkodNoAra = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Butonİptal)
        Me.Panel1.Controls.Add(Me.ButonGuncelle)
        Me.Panel1.Controls.Add(Me.TextSatisFiyati)
        Me.Panel1.Controls.Add(Me.TextAlisFiyati)
        Me.Panel1.Controls.Add(Me.TextBirim)
        Me.Panel1.Controls.Add(Me.TextMiktar)
        Me.Panel1.Controls.Add(Me.LabelSatisFiyati)
        Me.Panel1.Controls.Add(Me.LabelAlisFiyati)
        Me.Panel1.Controls.Add(Me.LabelBirim)
        Me.Panel1.Controls.Add(Me.LabelMiktar)
        Me.Panel1.Controls.Add(Me.TextUrunAdi)
        Me.Panel1.Controls.Add(Me.TextMarka)
        Me.Panel1.Controls.Add(Me.TextKategori)
        Me.Panel1.Controls.Add(Me.TextBarkodNo)
        Me.Panel1.Controls.Add(Me.LabelUrunAdi)
        Me.Panel1.Controls.Add(Me.LabelMarka)
        Me.Panel1.Controls.Add(Me.LabelKategori)
        Me.Panel1.Controls.Add(Me.LabelBarkodNo)
        Me.Panel1.Location = New System.Drawing.Point(1, 356)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 209)
        Me.Panel1.TabIndex = 0
        '
        'Butonİptal
        '
        Me.Butonİptal.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Butonİptal.ImageKey = "cancel (1).png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(601, 153)
        Me.Butonİptal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(120, 47)
        Me.Butonİptal.TabIndex = 10
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "updated.png")
        Me.ımageList1.Images.SetKeyName(1, "cancel (1).png")
        Me.ımageList1.Images.SetKeyName(2, "refresh.png")
        Me.ımageList1.Images.SetKeyName(3, "1214428.png")
        '
        'ButonGuncelle
        '
        Me.ButonGuncelle.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonGuncelle.ImageKey = "updated.png"
        Me.ButonGuncelle.ImageList = Me.ımageList1
        Me.ButonGuncelle.Location = New System.Drawing.Point(601, 97)
        Me.ButonGuncelle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButonGuncelle.Name = "ButonGuncelle"
        Me.ButonGuncelle.Size = New System.Drawing.Size(120, 43)
        Me.ButonGuncelle.TabIndex = 10
        Me.ButonGuncelle.Text = "Güncelle"
        Me.ButonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonGuncelle.UseVisualStyleBackColor = True
        '
        'TextSatisFiyati
        '
        Me.TextSatisFiyati.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextSatisFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSatisFiyati.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextSatisFiyati.ForeColor = System.Drawing.SystemColors.Window
        Me.TextSatisFiyati.Location = New System.Drawing.Point(430, 160)
        Me.TextSatisFiyati.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextSatisFiyati.Name = "TextSatisFiyati"
        Me.TextSatisFiyati.Size = New System.Drawing.Size(163, 23)
        Me.TextSatisFiyati.TabIndex = 6
        '
        'TextAlisFiyati
        '
        Me.TextAlisFiyati.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAlisFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAlisFiyati.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAlisFiyati.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAlisFiyati.Location = New System.Drawing.Point(434, 115)
        Me.TextAlisFiyati.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextAlisFiyati.Name = "TextAlisFiyati"
        Me.TextAlisFiyati.Size = New System.Drawing.Size(163, 23)
        Me.TextAlisFiyati.TabIndex = 7
        '
        'TextBirim
        '
        Me.TextBirim.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirim.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBirim.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBirim.Location = New System.Drawing.Point(434, 68)
        Me.TextBirim.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBirim.Name = "TextBirim"
        Me.TextBirim.Size = New System.Drawing.Size(163, 23)
        Me.TextBirim.TabIndex = 8
        '
        'TextMiktar
        '
        Me.TextMiktar.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMiktar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMiktar.ForeColor = System.Drawing.SystemColors.Window
        Me.TextMiktar.Location = New System.Drawing.Point(434, 18)
        Me.TextMiktar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextMiktar.Name = "TextMiktar"
        Me.TextMiktar.Size = New System.Drawing.Size(163, 23)
        Me.TextMiktar.TabIndex = 9
        '
        'LabelSatisFiyati
        '
        Me.LabelSatisFiyati.AutoSize = True
        Me.LabelSatisFiyati.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSatisFiyati.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelSatisFiyati.Location = New System.Drawing.Point(304, 160)
        Me.LabelSatisFiyati.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSatisFiyati.Name = "LabelSatisFiyati"
        Me.LabelSatisFiyati.Size = New System.Drawing.Size(93, 21)
        Me.LabelSatisFiyati.TabIndex = 2
        Me.LabelSatisFiyati.Text = "Satış Fiyatı:"
        '
        'LabelAlisFiyati
        '
        Me.LabelAlisFiyati.AutoSize = True
        Me.LabelAlisFiyati.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAlisFiyati.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAlisFiyati.Location = New System.Drawing.Point(304, 115)
        Me.LabelAlisFiyati.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAlisFiyati.Name = "LabelAlisFiyati"
        Me.LabelAlisFiyati.Size = New System.Drawing.Size(84, 21)
        Me.LabelAlisFiyati.TabIndex = 3
        Me.LabelAlisFiyati.Text = "Alış Fiyatı:"
        '
        'LabelBirim
        '
        Me.LabelBirim.AutoSize = True
        Me.LabelBirim.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBirim.ForeColor = System.Drawing.Color.Snow
        Me.LabelBirim.Location = New System.Drawing.Point(304, 67)
        Me.LabelBirim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBirim.Name = "LabelBirim"
        Me.LabelBirim.Size = New System.Drawing.Size(54, 21)
        Me.LabelBirim.TabIndex = 4
        Me.LabelBirim.Text = "Birim:"
        '
        'LabelMiktar
        '
        Me.LabelMiktar.AutoSize = True
        Me.LabelMiktar.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMiktar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelMiktar.Location = New System.Drawing.Point(304, 15)
        Me.LabelMiktar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMiktar.Name = "LabelMiktar"
        Me.LabelMiktar.Size = New System.Drawing.Size(61, 21)
        Me.LabelMiktar.TabIndex = 5
        Me.LabelMiktar.Text = "Miktar:"
        '
        'TextUrunAdi
        '
        Me.TextUrunAdi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUrunAdi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextUrunAdi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextUrunAdi.Location = New System.Drawing.Point(118, 160)
        Me.TextUrunAdi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextUrunAdi.Name = "TextUrunAdi"
        Me.TextUrunAdi.Size = New System.Drawing.Size(163, 23)
        Me.TextUrunAdi.TabIndex = 1
        '
        'TextMarka
        '
        Me.TextMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMarka.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMarka.ForeColor = System.Drawing.SystemColors.Window
        Me.TextMarka.Location = New System.Drawing.Point(118, 115)
        Me.TextMarka.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextMarka.Name = "TextMarka"
        Me.TextMarka.Size = New System.Drawing.Size(163, 23)
        Me.TextMarka.TabIndex = 1
        '
        'TextKategori
        '
        Me.TextKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKategori.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextKategori.ForeColor = System.Drawing.SystemColors.Window
        Me.TextKategori.Location = New System.Drawing.Point(118, 67)
        Me.TextKategori.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextKategori.Name = "TextKategori"
        Me.TextKategori.Size = New System.Drawing.Size(163, 23)
        Me.TextKategori.TabIndex = 1
        '
        'TextBarkodNo
        '
        Me.TextBarkodNo.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBarkodNo.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBarkodNo.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBarkodNo.Location = New System.Drawing.Point(118, 18)
        Me.TextBarkodNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBarkodNo.Name = "TextBarkodNo"
        Me.TextBarkodNo.Size = New System.Drawing.Size(163, 23)
        Me.TextBarkodNo.TabIndex = 1
        '
        'LabelUrunAdi
        '
        Me.LabelUrunAdi.AutoSize = True
        Me.LabelUrunAdi.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelUrunAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelUrunAdi.Location = New System.Drawing.Point(4, 160)
        Me.LabelUrunAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUrunAdi.Name = "LabelUrunAdi"
        Me.LabelUrunAdi.Size = New System.Drawing.Size(80, 21)
        Me.LabelUrunAdi.TabIndex = 0
        Me.LabelUrunAdi.Text = "Ürün Adı:"
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMarka.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelMarka.Location = New System.Drawing.Point(4, 115)
        Me.LabelMarka.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(60, 21)
        Me.LabelMarka.TabIndex = 0
        Me.LabelMarka.Text = "Marka:"
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKategori.ForeColor = System.Drawing.Color.Snow
        Me.LabelKategori.Location = New System.Drawing.Point(4, 67)
        Me.LabelKategori.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(77, 21)
        Me.LabelKategori.TabIndex = 0
        Me.LabelKategori.Text = "Kategori:"
        '
        'LabelBarkodNo
        '
        Me.LabelBarkodNo.AutoSize = True
        Me.LabelBarkodNo.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBarkodNo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelBarkodNo.Location = New System.Drawing.Point(4, 15)
        Me.LabelBarkodNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBarkodNo.Name = "LabelBarkodNo"
        Me.LabelBarkodNo.Size = New System.Drawing.Size(92, 21)
        Me.LabelBarkodNo.TabIndex = 0
        Me.LabelBarkodNo.Text = "Barkod No:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ButonMarkaGuncelle)
        Me.Panel2.Controls.Add(Me.ComboMarka)
        Me.Panel2.Controls.Add(Me.ComboKategori)
        Me.Panel2.Controls.Add(Me.LabelMarka2)
        Me.Panel2.Controls.Add(Me.LabelKategori2)
        Me.Panel2.Location = New System.Drawing.Point(731, 406)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 159)
        Me.Panel2.TabIndex = 0
        '
        'ButonMarkaGuncelle
        '
        Me.ButonMarkaGuncelle.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonMarkaGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonMarkaGuncelle.ImageKey = "refresh.png"
        Me.ButonMarkaGuncelle.ImageList = Me.ımageList1
        Me.ButonMarkaGuncelle.Location = New System.Drawing.Point(148, 102)
        Me.ButonMarkaGuncelle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButonMarkaGuncelle.Name = "ButonMarkaGuncelle"
        Me.ButonMarkaGuncelle.Size = New System.Drawing.Size(174, 42)
        Me.ButonMarkaGuncelle.TabIndex = 2
        Me.ButonMarkaGuncelle.Text = "Marka Güncelle"
        Me.ButonMarkaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonMarkaGuncelle.UseVisualStyleBackColor = True
        '
        'ComboMarka
        '
        Me.ComboMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboMarka.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboMarka.ForeColor = System.Drawing.SystemColors.Window
        Me.ComboMarka.FormattingEnabled = True
        Me.ComboMarka.Location = New System.Drawing.Point(94, 57)
        Me.ComboMarka.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboMarka.Name = "ComboMarka"
        Me.ComboMarka.Size = New System.Drawing.Size(151, 26)
        Me.ComboMarka.TabIndex = 1
        '
        'ComboKategori
        '
        Me.ComboKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboKategori.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboKategori.ForeColor = System.Drawing.SystemColors.Window
        Me.ComboKategori.FormattingEnabled = True
        Me.ComboKategori.Location = New System.Drawing.Point(94, 15)
        Me.ComboKategori.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboKategori.Name = "ComboKategori"
        Me.ComboKategori.Size = New System.Drawing.Size(151, 26)
        Me.ComboKategori.TabIndex = 1
        '
        'LabelMarka2
        '
        Me.LabelMarka2.AutoSize = True
        Me.LabelMarka2.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMarka2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelMarka2.Location = New System.Drawing.Point(4, 52)
        Me.LabelMarka2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMarka2.Name = "LabelMarka2"
        Me.LabelMarka2.Size = New System.Drawing.Size(60, 21)
        Me.LabelMarka2.TabIndex = 0
        Me.LabelMarka2.Text = "Marka:"
        '
        'LabelKategori2
        '
        Me.LabelKategori2.AutoSize = True
        Me.LabelKategori2.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKategori2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelKategori2.Location = New System.Drawing.Point(4, 15)
        Me.LabelKategori2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelKategori2.Name = "LabelKategori2"
        Me.LabelKategori2.Size = New System.Drawing.Size(77, 21)
        Me.LabelKategori2.TabIndex = 0
        Me.LabelKategori2.Text = "Kategori:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ComboBirim)
        Me.Panel3.Controls.Add(Me.ButonBirimGuncelle)
        Me.Panel3.Controls.Add(Me.LabelBirim2)
        Me.Panel3.Location = New System.Drawing.Point(1062, 451)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 114)
        Me.Panel3.TabIndex = 1
        '
        'ComboBirim
        '
        Me.ComboBirim.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboBirim.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboBirim.ForeColor = System.Drawing.SystemColors.Window
        Me.ComboBirim.FormattingEnabled = True
        Me.ComboBirim.Location = New System.Drawing.Point(85, 18)
        Me.ComboBirim.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBirim.Name = "ComboBirim"
        Me.ComboBirim.Size = New System.Drawing.Size(176, 26)
        Me.ComboBirim.TabIndex = 13
        '
        'ButonBirimGuncelle
        '
        Me.ButonBirimGuncelle.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonBirimGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonBirimGuncelle.ImageKey = "refresh.png"
        Me.ButonBirimGuncelle.ImageList = Me.ımageList1
        Me.ButonBirimGuncelle.Location = New System.Drawing.Point(94, 62)
        Me.ButonBirimGuncelle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButonBirimGuncelle.Name = "ButonBirimGuncelle"
        Me.ButonBirimGuncelle.Size = New System.Drawing.Size(167, 38)
        Me.ButonBirimGuncelle.TabIndex = 12
        Me.ButonBirimGuncelle.Text = "Birim Güncelle"
        Me.ButonBirimGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonBirimGuncelle.UseVisualStyleBackColor = True
        '
        'LabelBirim2
        '
        Me.LabelBirim2.AutoSize = True
        Me.LabelBirim2.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBirim2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelBirim2.Location = New System.Drawing.Point(15, 18)
        Me.LabelBirim2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBirim2.Name = "LabelBirim2"
        Me.LabelBirim2.Size = New System.Drawing.Size(54, 21)
        Me.LabelBirim2.TabIndex = 10
        Me.LabelBirim2.Text = "Birim:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 60)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1339, 290)
        Me.DataGridView1.TabIndex = 2
        '
        'ButonSil
        '
        Me.ButonSil.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSil.ImageKey = "1214428.png"
        Me.ButonSil.ImageList = Me.ımageList1
        Me.ButonSil.Location = New System.Drawing.Point(1246, 400)
        Me.ButonSil.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButonSil.Name = "ButonSil"
        Me.ButonSil.Size = New System.Drawing.Size(94, 43)
        Me.ButonSil.TabIndex = 3
        Me.ButonSil.Text = "Sil"
        Me.ButonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSil.UseVisualStyleBackColor = True
        '
        'TextBarkodNoAra
        '
        Me.TextBarkodNoAra.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBarkodNoAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBarkodNoAra.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBarkodNoAra.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBarkodNoAra.Location = New System.Drawing.Point(1166, 31)
        Me.TextBarkodNoAra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBarkodNoAra.Name = "TextBarkodNoAra"
        Me.TextBarkodNoAra.Size = New System.Drawing.Size(166, 23)
        Me.TextBarkodNoAra.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1116, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LabelBarkodNoAra
        '
        Me.LabelBarkodNoAra.AutoSize = True
        Me.LabelBarkodNoAra.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBarkodNoAra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelBarkodNoAra.Location = New System.Drawing.Point(1112, 7)
        Me.LabelBarkodNoAra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBarkodNoAra.Name = "LabelBarkodNoAra"
        Me.LabelBarkodNoAra.Size = New System.Drawing.Size(119, 21)
        Me.LabelBarkodNoAra.TabIndex = 6
        Me.LabelBarkodNoAra.Text = "Barkod No Ara"
        '
        'FormUrunListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1344, 575)
        Me.Controls.Add(Me.LabelBarkodNoAra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBarkodNoAra)
        Me.Controls.Add(Me.ButonSil)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormUrunListele"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Listele"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Butonİptal As Button
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents ButonGuncelle As Button
    Friend WithEvents TextSatisFiyati As TextBox
    Friend WithEvents TextAlisFiyati As TextBox
    Friend WithEvents TextBirim As TextBox
    Friend WithEvents TextMiktar As TextBox
    Friend WithEvents LabelSatisFiyati As Label
    Friend WithEvents LabelAlisFiyati As Label
    Friend WithEvents LabelBirim As Label
    Friend WithEvents LabelMiktar As Label
    Friend WithEvents TextUrunAdi As TextBox
    Friend WithEvents TextMarka As TextBox
    Friend WithEvents TextKategori As TextBox
    Friend WithEvents TextBarkodNo As TextBox
    Friend WithEvents LabelUrunAdi As Label
    Friend WithEvents LabelMarka As Label
    Friend WithEvents LabelKategori As Label
    Friend WithEvents LabelBarkodNo As Label
    Friend WithEvents ButonMarkaGuncelle As Button
    Friend WithEvents ComboMarka As ComboBox
    Friend WithEvents ComboKategori As ComboBox
    Friend WithEvents LabelMarka2 As Label
    Friend WithEvents LabelKategori2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelBirim2 As Label
    Friend WithEvents ComboBirim As ComboBox
    Friend WithEvents ButonBirimGuncelle As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButonSil As Button
    Friend WithEvents TextBarkodNoAra As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelBarkodNoAra As Label
End Class

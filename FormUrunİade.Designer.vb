<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUrunİade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUrunİade))
        Me.LabelToplamFiyat = New System.Windows.Forms.Label()
        Me.LabelBirimFiyati = New System.Windows.Forms.Label()
        Me.LabelBirim = New System.Windows.Forms.Label()
        Me.LabelMiktar = New System.Windows.Forms.Label()
        Me.LabelUrunAdi = New System.Windows.Forms.Label()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.LabelBarkodNo = New System.Windows.Forms.Label()
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonİadeAl = New System.Windows.Forms.Button()
        Me.TextToplamFiyat = New System.Windows.Forms.TextBox()
        Me.TextBirimFiyati = New System.Windows.Forms.TextBox()
        Me.TextBirim = New System.Windows.Forms.TextBox()
        Me.TextMiktar = New System.Windows.Forms.TextBox()
        Me.TextMarka = New System.Windows.Forms.TextBox()
        Me.TextKategori = New System.Windows.Forms.TextBox()
        Me.TextUrunAdi = New System.Windows.Forms.TextBox()
        Me.TextBarkodNo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelToplamFiyat
        '
        Me.LabelToplamFiyat.AutoSize = True
        Me.LabelToplamFiyat.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelToplamFiyat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelToplamFiyat.Location = New System.Drawing.Point(5, 317)
        Me.LabelToplamFiyat.Name = "LabelToplamFiyat"
        Me.LabelToplamFiyat.Size = New System.Drawing.Size(115, 22)
        Me.LabelToplamFiyat.TabIndex = 43
        Me.LabelToplamFiyat.Text = "Toplam Fiyat:"
        '
        'LabelBirimFiyati
        '
        Me.LabelBirimFiyati.AutoSize = True
        Me.LabelBirimFiyati.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBirimFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelBirimFiyati.Location = New System.Drawing.Point(5, 275)
        Me.LabelBirimFiyati.Name = "LabelBirimFiyati"
        Me.LabelBirimFiyati.Size = New System.Drawing.Size(103, 22)
        Me.LabelBirimFiyati.TabIndex = 41
        Me.LabelBirimFiyati.Text = "Birim Fiyatı:"
        '
        'LabelBirim
        '
        Me.LabelBirim.AutoSize = True
        Me.LabelBirim.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBirim.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelBirim.Location = New System.Drawing.Point(54, 229)
        Me.LabelBirim.Name = "LabelBirim"
        Me.LabelBirim.Size = New System.Drawing.Size(56, 22)
        Me.LabelBirim.TabIndex = 40
        Me.LabelBirim.Text = "Birim:"
        '
        'LabelMiktar
        '
        Me.LabelMiktar.AutoSize = True
        Me.LabelMiktar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMiktar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMiktar.Location = New System.Drawing.Point(44, 185)
        Me.LabelMiktar.Name = "LabelMiktar"
        Me.LabelMiktar.Size = New System.Drawing.Size(64, 22)
        Me.LabelMiktar.TabIndex = 39
        Me.LabelMiktar.Text = "Miktar:"
        '
        'LabelUrunAdi
        '
        Me.LabelUrunAdi.AutoSize = True
        Me.LabelUrunAdi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelUrunAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelUrunAdi.Location = New System.Drawing.Point(24, 147)
        Me.LabelUrunAdi.Name = "LabelUrunAdi"
        Me.LabelUrunAdi.Size = New System.Drawing.Size(84, 22)
        Me.LabelUrunAdi.TabIndex = 38
        Me.LabelUrunAdi.Text = "Ürün Adı:"
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMarka.Location = New System.Drawing.Point(48, 108)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(62, 22)
        Me.LabelMarka.TabIndex = 37
        Me.LabelMarka.Text = "Marka:"
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelKategori.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelKategori.Location = New System.Drawing.Point(29, 68)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(81, 22)
        Me.LabelKategori.TabIndex = 36
        Me.LabelKategori.Text = "Kategori:"
        '
        'LabelBarkodNo
        '
        Me.LabelBarkodNo.AutoSize = True
        Me.LabelBarkodNo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBarkodNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelBarkodNo.Location = New System.Drawing.Point(12, 26)
        Me.LabelBarkodNo.Name = "LabelBarkodNo"
        Me.LabelBarkodNo.Size = New System.Drawing.Size(98, 22)
        Me.LabelBarkodNo.TabIndex = 42
        Me.LabelBarkodNo.Text = "Barkod No:"
        '
        'Butonİptal
        '
        Me.Butonİptal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Butonİptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Butonİptal.ImageKey = "1304140.png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(204, 356)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(86, 33)
        Me.Butonİptal.TabIndex = 35
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "1981862.png")
        Me.ımageList1.Images.SetKeyName(1, "1304140.png")
        '
        'ButonİadeAl
        '
        Me.ButonİadeAl.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonİadeAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonİadeAl.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButonİadeAl.ImageKey = "1981862.png"
        Me.ButonİadeAl.ImageList = Me.ımageList1
        Me.ButonİadeAl.Location = New System.Drawing.Point(57, 356)
        Me.ButonİadeAl.Name = "ButonİadeAl"
        Me.ButonİadeAl.Size = New System.Drawing.Size(101, 33)
        Me.ButonİadeAl.TabIndex = 34
        Me.ButonİadeAl.Text = "İade Al"
        Me.ButonİadeAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonİadeAl.UseVisualStyleBackColor = True
        '
        'TextToplamFiyat
        '
        Me.TextToplamFiyat.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextToplamFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextToplamFiyat.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextToplamFiyat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextToplamFiyat.Location = New System.Drawing.Point(133, 312)
        Me.TextToplamFiyat.Name = "TextToplamFiyat"
        Me.TextToplamFiyat.Size = New System.Drawing.Size(173, 27)
        Me.TextToplamFiyat.TabIndex = 28
        '
        'TextBirimFiyati
        '
        Me.TextBirimFiyati.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirimFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirimFiyati.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBirimFiyati.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBirimFiyati.Location = New System.Drawing.Point(133, 270)
        Me.TextBirimFiyati.Name = "TextBirimFiyati"
        Me.TextBirimFiyati.Size = New System.Drawing.Size(173, 27)
        Me.TextBirimFiyati.TabIndex = 27
        '
        'TextBirim
        '
        Me.TextBirim.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirim.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBirim.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBirim.Location = New System.Drawing.Point(133, 227)
        Me.TextBirim.Name = "TextBirim"
        Me.TextBirim.Size = New System.Drawing.Size(173, 27)
        Me.TextBirim.TabIndex = 26
        '
        'TextMiktar
        '
        Me.TextMiktar.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMiktar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMiktar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMiktar.Location = New System.Drawing.Point(133, 183)
        Me.TextMiktar.Name = "TextMiktar"
        Me.TextMiktar.Size = New System.Drawing.Size(173, 27)
        Me.TextMiktar.TabIndex = 25
        Me.TextMiktar.Text = "1"
        Me.TextMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextMarka
        '
        Me.TextMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMarka.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMarka.Location = New System.Drawing.Point(133, 106)
        Me.TextMarka.Name = "TextMarka"
        Me.TextMarka.Size = New System.Drawing.Size(173, 27)
        Me.TextMarka.TabIndex = 32
        '
        'TextKategori
        '
        Me.TextKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKategori.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextKategori.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextKategori.Location = New System.Drawing.Point(133, 66)
        Me.TextKategori.Name = "TextKategori"
        Me.TextKategori.Size = New System.Drawing.Size(173, 27)
        Me.TextKategori.TabIndex = 31
        '
        'TextUrunAdi
        '
        Me.TextUrunAdi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUrunAdi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextUrunAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextUrunAdi.Location = New System.Drawing.Point(133, 145)
        Me.TextUrunAdi.Name = "TextUrunAdi"
        Me.TextUrunAdi.Size = New System.Drawing.Size(173, 27)
        Me.TextUrunAdi.TabIndex = 29
        '
        'TextBarkodNo
        '
        Me.TextBarkodNo.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBarkodNo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBarkodNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBarkodNo.Location = New System.Drawing.Point(133, 26)
        Me.TextBarkodNo.Name = "TextBarkodNo"
        Me.TextBarkodNo.Size = New System.Drawing.Size(173, 27)
        Me.TextBarkodNo.TabIndex = 24
        '
        'FormUrunİade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(342, 413)
        Me.Controls.Add(Me.LabelToplamFiyat)
        Me.Controls.Add(Me.LabelBirimFiyati)
        Me.Controls.Add(Me.LabelBirim)
        Me.Controls.Add(Me.LabelMiktar)
        Me.Controls.Add(Me.LabelUrunAdi)
        Me.Controls.Add(Me.LabelMarka)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.LabelBarkodNo)
        Me.Controls.Add(Me.Butonİptal)
        Me.Controls.Add(Me.ButonİadeAl)
        Me.Controls.Add(Me.TextToplamFiyat)
        Me.Controls.Add(Me.TextBirimFiyati)
        Me.Controls.Add(Me.TextBirim)
        Me.Controls.Add(Me.TextMiktar)
        Me.Controls.Add(Me.TextMarka)
        Me.Controls.Add(Me.TextKategori)
        Me.Controls.Add(Me.TextUrunAdi)
        Me.Controls.Add(Me.TextBarkodNo)
        Me.Name = "FormUrunİade"
        Me.Text = "Ürün İade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelToplamFiyat As Label
    Friend WithEvents LabelBirimFiyati As Label
    Friend WithEvents LabelBirim As Label
    Friend WithEvents LabelMiktar As Label
    Friend WithEvents LabelUrunAdi As Label
    Friend WithEvents LabelMarka As Label
    Friend WithEvents LabelKategori As Label
    Friend WithEvents LabelBarkodNo As Label
    Friend WithEvents Butonİptal As Button
    Friend WithEvents ButonİadeAl As Button
    Friend WithEvents TextToplamFiyat As TextBox
    Friend WithEvents TextBirimFiyati As TextBox
    Friend WithEvents TextBirim As TextBox
    Friend WithEvents TextMiktar As TextBox
    Friend WithEvents TextMarka As TextBox
    Friend WithEvents TextKategori As TextBox
    Friend WithEvents TextUrunAdi As TextBox
    Friend WithEvents TextBarkodNo As TextBox
    Friend WithEvents ımageList1 As ImageList
End Class

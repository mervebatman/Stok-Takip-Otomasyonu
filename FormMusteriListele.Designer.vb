<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMusteriListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMusteriListele))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonGuncelle = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelAdres = New System.Windows.Forms.Label()
        Me.LabelTelefon = New System.Windows.Forms.Label()
        Me.LabelAdiSoyadi = New System.Windows.Forms.Label()
        Me.LabelMusteriID = New System.Windows.Forms.Label()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.TextAdres = New System.Windows.Forms.TextBox()
        Me.TextTelefon = New System.Windows.Forms.TextBox()
        Me.TextAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.TextMusteriID = New System.Windows.Forms.TextBox()
        Me.ButonSil = New System.Windows.Forms.Button()
        Me.LabelMusteriIDAra = New System.Windows.Forms.Label()
        Me.TextMusteriIDAra = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(941, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'Butonİptal
        '
        Me.Butonİptal.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Butonİptal.ImageKey = "cancel (1).png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(342, 474)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(97, 34)
        Me.Butonİptal.TabIndex = 13
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "refresh.png")
        Me.ımageList1.Images.SetKeyName(1, "1214428.png")
        Me.ımageList1.Images.SetKeyName(2, "cancel (1).png")
        '
        'ButonGuncelle
        '
        Me.ButonGuncelle.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonGuncelle.ImageKey = "refresh.png"
        Me.ButonGuncelle.ImageList = Me.ımageList1
        Me.ButonGuncelle.Location = New System.Drawing.Point(342, 339)
        Me.ButonGuncelle.Name = "ButonGuncelle"
        Me.ButonGuncelle.Size = New System.Drawing.Size(97, 43)
        Me.ButonGuncelle.TabIndex = 14
        Me.ButonGuncelle.Text = "Güncelle"
        Me.ButonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonGuncelle.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(58, 480)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "E-mail:"
        '
        'LabelAdres
        '
        Me.LabelAdres.AutoSize = True
        Me.LabelAdres.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAdres.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdres.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdres.Location = New System.Drawing.Point(63, 394)
        Me.LabelAdres.Name = "LabelAdres"
        Me.LabelAdres.Size = New System.Drawing.Size(59, 22)
        Me.LabelAdres.TabIndex = 9
        Me.LabelAdres.Text = "Adres:"
        '
        'LabelTelefon
        '
        Me.LabelTelefon.AutoSize = True
        Me.LabelTelefon.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTelefon.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTelefon.Location = New System.Drawing.Point(49, 360)
        Me.LabelTelefon.Name = "LabelTelefon"
        Me.LabelTelefon.Size = New System.Drawing.Size(71, 22)
        Me.LabelTelefon.TabIndex = 10
        Me.LabelTelefon.Text = "Telefon:"
        '
        'LabelAdiSoyadi
        '
        Me.LabelAdiSoyadi.AutoSize = True
        Me.LabelAdiSoyadi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdiSoyadi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdiSoyadi.Location = New System.Drawing.Point(26, 330)
        Me.LabelAdiSoyadi.Name = "LabelAdiSoyadi"
        Me.LabelAdiSoyadi.Size = New System.Drawing.Size(96, 22)
        Me.LabelAdiSoyadi.TabIndex = 11
        Me.LabelAdiSoyadi.Text = "Adı Soyadı:"
        '
        'LabelMusteriID
        '
        Me.LabelMusteriID.AutoSize = True
        Me.LabelMusteriID.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMusteriID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMusteriID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMusteriID.Location = New System.Drawing.Point(26, 291)
        Me.LabelMusteriID.Name = "LabelMusteriID"
        Me.LabelMusteriID.Size = New System.Drawing.Size(96, 22)
        Me.LabelMusteriID.TabIndex = 12
        Me.LabelMusteriID.Text = "Müşteri ID:"
        '
        'TextEmail
        '
        Me.TextEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEmail.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEmail.ForeColor = System.Drawing.SystemColors.Window
        Me.TextEmail.Location = New System.Drawing.Point(162, 480)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(154, 23)
        Me.TextEmail.TabIndex = 3
        '
        'TextAdres
        '
        Me.TextAdres.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdres.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdres.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdres.Location = New System.Drawing.Point(162, 394)
        Me.TextAdres.Multiline = True
        Me.TextAdres.Name = "TextAdres"
        Me.TextAdres.Size = New System.Drawing.Size(154, 80)
        Me.TextAdres.TabIndex = 4
        '
        'TextTelefon
        '
        Me.TextTelefon.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTelefon.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextTelefon.ForeColor = System.Drawing.SystemColors.Window
        Me.TextTelefon.Location = New System.Drawing.Point(162, 362)
        Me.TextTelefon.Name = "TextTelefon"
        Me.TextTelefon.Size = New System.Drawing.Size(154, 23)
        Me.TextTelefon.TabIndex = 5
        '
        'TextAdiSoyadi
        '
        Me.TextAdiSoyadi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdiSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdiSoyadi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdiSoyadi.Location = New System.Drawing.Point(162, 330)
        Me.TextAdiSoyadi.Name = "TextAdiSoyadi"
        Me.TextAdiSoyadi.Size = New System.Drawing.Size(154, 23)
        Me.TextAdiSoyadi.TabIndex = 6
        '
        'TextMusteriID
        '
        Me.TextMusteriID.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMusteriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMusteriID.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMusteriID.ForeColor = System.Drawing.SystemColors.Window
        Me.TextMusteriID.Location = New System.Drawing.Point(162, 291)
        Me.TextMusteriID.Name = "TextMusteriID"
        Me.TextMusteriID.Size = New System.Drawing.Size(154, 23)
        Me.TextMusteriID.TabIndex = 7
        '
        'ButonSil
        '
        Me.ButonSil.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSil.ImageKey = "1214428.png"
        Me.ButonSil.ImageList = Me.ımageList1
        Me.ButonSil.Location = New System.Drawing.Point(342, 409)
        Me.ButonSil.Name = "ButonSil"
        Me.ButonSil.Size = New System.Drawing.Size(97, 37)
        Me.ButonSil.TabIndex = 15
        Me.ButonSil.Text = "Sil"
        Me.ButonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSil.UseVisualStyleBackColor = True
        '
        'LabelMusteriIDAra
        '
        Me.LabelMusteriIDAra.AutoSize = True
        Me.LabelMusteriIDAra.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMusteriIDAra.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMusteriIDAra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMusteriIDAra.Location = New System.Drawing.Point(638, 276)
        Me.LabelMusteriIDAra.Name = "LabelMusteriIDAra"
        Me.LabelMusteriIDAra.Size = New System.Drawing.Size(141, 22)
        Me.LabelMusteriIDAra.TabIndex = 17
        Me.LabelMusteriIDAra.Text = "Müşteri ID Ara"
        '
        'TextMusteriIDAra
        '
        Me.TextMusteriIDAra.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMusteriIDAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMusteriIDAra.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMusteriIDAra.ForeColor = System.Drawing.SystemColors.Window
        Me.TextMusteriIDAra.Location = New System.Drawing.Point(625, 305)
        Me.TextMusteriIDAra.Name = "TextMusteriIDAra"
        Me.TextMusteriIDAra.Size = New System.Drawing.Size(154, 23)
        Me.TextMusteriIDAra.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(587, 305)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'FormMusteriListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 520)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelMusteriIDAra)
        Me.Controls.Add(Me.TextMusteriIDAra)
        Me.Controls.Add(Me.ButonSil)
        Me.Controls.Add(Me.Butonİptal)
        Me.Controls.Add(Me.ButonGuncelle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelAdres)
        Me.Controls.Add(Me.LabelTelefon)
        Me.Controls.Add(Me.LabelAdiSoyadi)
        Me.Controls.Add(Me.LabelMusteriID)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.TextAdres)
        Me.Controls.Add(Me.TextTelefon)
        Me.Controls.Add(Me.TextAdiSoyadi)
        Me.Controls.Add(Me.TextMusteriID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMusteriListele"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Listeleme"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Butonİptal As Button
    Friend WithEvents ButonGuncelle As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelAdres As Label
    Friend WithEvents LabelTelefon As Label
    Friend WithEvents LabelAdiSoyadi As Label
    Friend WithEvents LabelMusteriID As Label
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents TextAdres As TextBox
    Friend WithEvents TextTelefon As TextBox
    Friend WithEvents TextAdiSoyadi As TextBox
    Friend WithEvents TextMusteriID As TextBox
    Friend WithEvents ButonSil As Button
    Friend WithEvents LabelMusteriIDAra As Label
    Friend WithEvents TextMusteriIDAra As TextBox
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
End Class

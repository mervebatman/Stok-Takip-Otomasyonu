<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMarkaEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMarkaEkle))
        Me.TextMarka = New System.Windows.Forms.TextBox()
        Me.ComboKategori = New System.Windows.Forms.ComboBox()
        Me.ButonEkle = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextMarka
        '
        Me.TextMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMarka.Location = New System.Drawing.Point(128, 45)
        Me.TextMarka.Name = "TextMarka"
        Me.TextMarka.Size = New System.Drawing.Size(155, 27)
        Me.TextMarka.TabIndex = 1
        '
        'ComboKategori
        '
        Me.ComboKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboKategori.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboKategori.FormattingEnabled = True
        Me.ComboKategori.Location = New System.Drawing.Point(128, 9)
        Me.ComboKategori.Name = "ComboKategori"
        Me.ComboKategori.Size = New System.Drawing.Size(155, 30)
        Me.ComboKategori.TabIndex = 2
        '
        'ButonEkle
        '
        Me.ButonEkle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButonEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonEkle.ImageKey = "add (2).png"
        Me.ButonEkle.ImageList = Me.ımageList1
        Me.ButonEkle.Location = New System.Drawing.Point(93, 87)
        Me.ButonEkle.Name = "ButonEkle"
        Me.ButonEkle.Size = New System.Drawing.Size(75, 37)
        Me.ButonEkle.TabIndex = 3
        Me.ButonEkle.Text = "Ekle"
        Me.ButonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonEkle.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "add (2).png")
        Me.ımageList1.Images.SetKeyName(1, "1304140.png")
        '
        'Butonİptal
        '
        Me.Butonİptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Butonİptal.ImageKey = "1304140.png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(208, 87)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(81, 37)
        Me.Butonİptal.TabIndex = 4
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = True
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelKategori.Location = New System.Drawing.Point(40, 12)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(81, 22)
        Me.LabelKategori.TabIndex = 5
        Me.LabelKategori.Text = "Kategori:"
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMarka.Location = New System.Drawing.Point(59, 50)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(62, 22)
        Me.LabelMarka.TabIndex = 6
        Me.LabelMarka.Text = "Marka:"
        '
        'FormMarkaEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(324, 142)
        Me.Controls.Add(Me.LabelMarka)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.Butonİptal)
        Me.Controls.Add(Me.ButonEkle)
        Me.Controls.Add(Me.ComboKategori)
        Me.Controls.Add(Me.TextMarka)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormMarkaEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marka Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextMarka As TextBox
    Friend WithEvents ComboKategori As ComboBox
    Friend WithEvents ButonEkle As Button
    Friend WithEvents Butonİptal As Button
    Friend WithEvents LabelKategori As Label
    Friend WithEvents LabelMarka As Label
    Friend WithEvents ımageList1 As ImageList
End Class

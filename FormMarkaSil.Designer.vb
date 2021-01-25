<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMarkaSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMarkaSil))
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonSil = New System.Windows.Forms.Button()
        Me.ComboKategori = New System.Windows.Forms.ComboBox()
        Me.TextMarka = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMarka.Location = New System.Drawing.Point(43, 58)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(62, 22)
        Me.LabelMarka.TabIndex = 12
        Me.LabelMarka.Text = "Marka:"
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelKategori.Location = New System.Drawing.Point(24, 20)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(81, 22)
        Me.LabelKategori.TabIndex = 11
        Me.LabelKategori.Text = "Kategori:"
        '
        'Butonİptal
        '
        Me.Butonİptal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Butonİptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Butonİptal.ImageKey = "1304140.png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(175, 92)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(79, 35)
        Me.Butonİptal.TabIndex = 10
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "1214428.png")
        Me.ımageList1.Images.SetKeyName(1, "1304140.png")
        '
        'ButonSil
        '
        Me.ButonSil.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButonSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSil.ImageKey = "1214428.png"
        Me.ButonSil.ImageList = Me.ımageList1
        Me.ButonSil.Location = New System.Drawing.Point(47, 90)
        Me.ButonSil.Name = "ButonSil"
        Me.ButonSil.Size = New System.Drawing.Size(68, 37)
        Me.ButonSil.TabIndex = 9
        Me.ButonSil.Text = "Sil"
        Me.ButonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSil.UseVisualStyleBackColor = False
        '
        'ComboKategori
        '
        Me.ComboKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboKategori.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboKategori.FormattingEnabled = True
        Me.ComboKategori.Location = New System.Drawing.Point(112, 17)
        Me.ComboKategori.Name = "ComboKategori"
        Me.ComboKategori.Size = New System.Drawing.Size(155, 30)
        Me.ComboKategori.TabIndex = 8
        '
        'TextMarka
        '
        Me.TextMarka.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextMarka.Location = New System.Drawing.Point(112, 53)
        Me.TextMarka.Name = "TextMarka"
        Me.TextMarka.Size = New System.Drawing.Size(155, 27)
        Me.TextMarka.TabIndex = 7
        '
        'FormMarkaSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(318, 150)
        Me.Controls.Add(Me.LabelMarka)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.Butonİptal)
        Me.Controls.Add(Me.ButonSil)
        Me.Controls.Add(Me.ComboKategori)
        Me.Controls.Add(Me.TextMarka)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormMarkaSil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marka Sil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMarka As Label
    Friend WithEvents LabelKategori As Label
    Friend WithEvents Butonİptal As Button
    Friend WithEvents ButonSil As Button
    Friend WithEvents ComboKategori As ComboBox
    Friend WithEvents TextMarka As TextBox
    Friend WithEvents ımageList1 As ImageList
End Class

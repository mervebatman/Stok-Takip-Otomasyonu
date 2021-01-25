<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategoriEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKategoriEkle))
        Me.TextKategori = New System.Windows.Forms.TextBox()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.ButonEkle = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonCikis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextKategori
        '
        Me.TextKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKategori.ForeColor = System.Drawing.SystemColors.Window
        Me.TextKategori.Location = New System.Drawing.Point(115, 34)
        Me.TextKategori.Name = "TextKategori"
        Me.TextKategori.Size = New System.Drawing.Size(203, 27)
        Me.TextKategori.TabIndex = 0
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelKategori.Location = New System.Drawing.Point(28, 34)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(81, 22)
        Me.LabelKategori.TabIndex = 1
        Me.LabelKategori.Text = "Kategori:"
        '
        'ButonEkle
        '
        Me.ButonEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonEkle.ImageKey = "1828930.png"
        Me.ButonEkle.ImageList = Me.ımageList1
        Me.ButonEkle.Location = New System.Drawing.Point(50, 78)
        Me.ButonEkle.Name = "ButonEkle"
        Me.ButonEkle.Size = New System.Drawing.Size(81, 39)
        Me.ButonEkle.TabIndex = 2
        Me.ButonEkle.Text = "Ekle"
        Me.ButonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonEkle.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "1828930.png")
        Me.ımageList1.Images.SetKeyName(1, "exit.png")
        '
        'ButonCikis
        '
        Me.ButonCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonCikis.ImageKey = "exit.png"
        Me.ButonCikis.ImageList = Me.ımageList1
        Me.ButonCikis.Location = New System.Drawing.Point(191, 78)
        Me.ButonCikis.Name = "ButonCikis"
        Me.ButonCikis.Size = New System.Drawing.Size(82, 39)
        Me.ButonCikis.TabIndex = 2
        Me.ButonCikis.Text = "Çıkış"
        Me.ButonCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonCikis.UseVisualStyleBackColor = True
        '
        'FormKategoriEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(355, 153)
        Me.Controls.Add(Me.ButonCikis)
        Me.Controls.Add(Me.ButonEkle)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.TextKategori)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormKategoriEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kategori Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextKategori As TextBox
    Friend WithEvents LabelKategori As Label
    Friend WithEvents ButonEkle As Button
    Friend WithEvents ButonCikis As Button
    Friend WithEvents ımageList1 As ImageList
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKategoriSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKategoriSil))
        Me.ButonCikis = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonSil = New System.Windows.Forms.Button()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.TextKategori = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButonCikis
        '
        Me.ButonCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonCikis.ImageKey = "exit.png"
        Me.ButonCikis.ImageList = Me.ımageList1
        Me.ButonCikis.Location = New System.Drawing.Point(183, 69)
        Me.ButonCikis.Name = "ButonCikis"
        Me.ButonCikis.Size = New System.Drawing.Size(82, 39)
        Me.ButonCikis.TabIndex = 5
        Me.ButonCikis.Text = "Çıkış"
        Me.ButonCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonCikis.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "1214428.png")
        Me.ımageList1.Images.SetKeyName(1, "exit.png")
        '
        'ButonSil
        '
        Me.ButonSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSil.ImageKey = "1214428.png"
        Me.ButonSil.ImageList = Me.ımageList1
        Me.ButonSil.Location = New System.Drawing.Point(45, 69)
        Me.ButonSil.Name = "ButonSil"
        Me.ButonSil.Size = New System.Drawing.Size(75, 39)
        Me.ButonSil.TabIndex = 6
        Me.ButonSil.Text = "Sil"
        Me.ButonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSil.UseVisualStyleBackColor = True
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelKategori.Location = New System.Drawing.Point(23, 25)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(77, 21)
        Me.LabelKategori.TabIndex = 4
        Me.LabelKategori.Text = "Kategori:"
        '
        'TextKategori
        '
        Me.TextKategori.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKategori.ForeColor = System.Drawing.SystemColors.Window
        Me.TextKategori.Location = New System.Drawing.Point(110, 25)
        Me.TextKategori.Name = "TextKategori"
        Me.TextKategori.Size = New System.Drawing.Size(203, 26)
        Me.TextKategori.TabIndex = 3
        '
        'FormKategoriSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(331, 124)
        Me.Controls.Add(Me.ButonCikis)
        Me.Controls.Add(Me.ButonSil)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.TextKategori)
        Me.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormKategoriSil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kategori Sil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButonCikis As Button
    Friend WithEvents ButonSil As Button
    Friend WithEvents LabelKategori As Label
    Friend WithEvents TextKategori As TextBox
    Friend WithEvents ımageList1 As ImageList
End Class

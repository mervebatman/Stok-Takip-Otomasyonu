<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBirimEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBirimEkle))
        Me.ButonCikis = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonEkle = New System.Windows.Forms.Button()
        Me.LabelBirim = New System.Windows.Forms.Label()
        Me.TextBirim = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButonCikis
        '
        Me.ButonCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonCikis.ImageKey = "exit.png"
        Me.ButonCikis.ImageList = Me.ımageList1
        Me.ButonCikis.Location = New System.Drawing.Point(208, 75)
        Me.ButonCikis.Name = "ButonCikis"
        Me.ButonCikis.Size = New System.Drawing.Size(83, 39)
        Me.ButonCikis.TabIndex = 5
        Me.ButonCikis.Text = "Çıkış"
        Me.ButonCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonCikis.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "add (2).png")
        Me.ımageList1.Images.SetKeyName(1, "exit.png")
        '
        'ButonEkle
        '
        Me.ButonEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonEkle.ImageKey = "add (2).png"
        Me.ButonEkle.ImageList = Me.ımageList1
        Me.ButonEkle.Location = New System.Drawing.Point(42, 75)
        Me.ButonEkle.Name = "ButonEkle"
        Me.ButonEkle.Size = New System.Drawing.Size(75, 39)
        Me.ButonEkle.TabIndex = 6
        Me.ButonEkle.Text = "Ekle"
        Me.ButonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonEkle.UseVisualStyleBackColor = True
        '
        'LabelBirim
        '
        Me.LabelBirim.AutoSize = True
        Me.LabelBirim.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelBirim.Location = New System.Drawing.Point(27, 34)
        Me.LabelBirim.Name = "LabelBirim"
        Me.LabelBirim.Size = New System.Drawing.Size(56, 22)
        Me.LabelBirim.TabIndex = 4
        Me.LabelBirim.Text = "Birim:"
        '
        'TextBirim
        '
        Me.TextBirim.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirim.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBirim.Location = New System.Drawing.Point(114, 34)
        Me.TextBirim.Name = "TextBirim"
        Me.TextBirim.Size = New System.Drawing.Size(203, 27)
        Me.TextBirim.TabIndex = 3
        '
        'FormBirimEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(342, 129)
        Me.Controls.Add(Me.ButonCikis)
        Me.Controls.Add(Me.ButonEkle)
        Me.Controls.Add(Me.LabelBirim)
        Me.Controls.Add(Me.TextBirim)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormBirimEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Birim Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButonCikis As Button
    Friend WithEvents ButonEkle As Button
    Friend WithEvents LabelBirim As Label
    Friend WithEvents TextBirim As TextBox
    Friend WithEvents ımageList1 As ImageList
End Class

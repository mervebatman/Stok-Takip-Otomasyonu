<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPersonelListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPersonelListele))
        Me.LabelPersonelAdiAra = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextPersonelAdıAra = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelAciklama = New System.Windows.Forms.Label()
        Me.ButonSil = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPersonelAdiAra
        '
        Me.LabelPersonelAdiAra.AutoSize = True
        Me.LabelPersonelAdiAra.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelPersonelAdiAra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelPersonelAdiAra.Location = New System.Drawing.Point(286, 4)
        Me.LabelPersonelAdiAra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPersonelAdiAra.Name = "LabelPersonelAdiAra"
        Me.LabelPersonelAdiAra.Size = New System.Drawing.Size(140, 22)
        Me.LabelPersonelAdiAra.TabIndex = 0
        Me.LabelPersonelAdiAra.Text = "Personel Adı Ara"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(232, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TextPersonelAdıAra
        '
        Me.TextPersonelAdıAra.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextPersonelAdıAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPersonelAdıAra.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextPersonelAdıAra.ForeColor = System.Drawing.SystemColors.Window
        Me.TextPersonelAdıAra.Location = New System.Drawing.Point(271, 30)
        Me.TextPersonelAdıAra.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPersonelAdıAra.Name = "TextPersonelAdıAra"
        Me.TextPersonelAdıAra.Size = New System.Drawing.Size(217, 23)
        Me.TextPersonelAdıAra.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 71)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1215, 500)
        Me.DataGridView1.TabIndex = 3
        '
        'LabelAciklama
        '
        Me.LabelAciklama.AutoSize = True
        Me.LabelAciklama.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAciklama.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAciklama.Location = New System.Drawing.Point(217, 594)
        Me.LabelAciklama.Name = "LabelAciklama"
        Me.LabelAciklama.Size = New System.Drawing.Size(650, 22)
        Me.LabelAciklama.TabIndex = 4
        Me.LabelAciklama.Text = "(*) Kullanıcı yetkisi 1 rakamı için yönetici, 2 rakamı için personeli ifade etmek" &
    "tedir!"
        '
        'ButonSil
        '
        Me.ButonSil.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSil.ImageKey = "1214428.png"
        Me.ButonSil.ImageList = Me.ımageList1
        Me.ButonSil.Location = New System.Drawing.Point(1023, 15)
        Me.ButonSil.Name = "ButonSil"
        Me.ButonSil.Size = New System.Drawing.Size(130, 49)
        Me.ButonSil.TabIndex = 5
        Me.ButonSil.Text = "Sil"
        Me.ButonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSil.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "1214428.png")
        '
        'FormPersonelListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1219, 685)
        Me.Controls.Add(Me.ButonSil)
        Me.Controls.Add(Me.LabelAciklama)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextPersonelAdıAra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelPersonelAdiAra)
        Me.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPersonelListele"
        Me.Text = "FormPersonelListele"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPersonelAdiAra As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextPersonelAdıAra As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelAciklama As Label
    Friend WithEvents ButonSil As Button
    Friend WithEvents ımageList1 As ImageList
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBirimSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBirimSil))
        Me.ButonCikis = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButonSil = New System.Windows.Forms.Button()
        Me.LabelBirim = New System.Windows.Forms.Label()
        Me.TextBirim = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButonCikis
        '
        Me.ButonCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonCikis.ImageKey = "cancel.png"
        Me.ButonCikis.ImageList = Me.ımageList1
        Me.ButonCikis.Location = New System.Drawing.Point(203, 67)
        Me.ButonCikis.Name = "ButonCikis"
        Me.ButonCikis.Size = New System.Drawing.Size(83, 39)
        Me.ButonCikis.TabIndex = 9
        Me.ButonCikis.Text = "Çıkış"
        Me.ButonCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonCikis.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "delete.png")
        Me.ımageList1.Images.SetKeyName(1, "cancel.png")
        '
        'ButonSil
        '
        Me.ButonSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonSil.ImageKey = "delete.png"
        Me.ButonSil.ImageList = Me.ımageList1
        Me.ButonSil.Location = New System.Drawing.Point(75, 67)
        Me.ButonSil.Name = "ButonSil"
        Me.ButonSil.Size = New System.Drawing.Size(73, 39)
        Me.ButonSil.TabIndex = 10
        Me.ButonSil.Text = "Sil"
        Me.ButonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonSil.UseVisualStyleBackColor = True
        '
        'LabelBirim
        '
        Me.LabelBirim.AutoSize = True
        Me.LabelBirim.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelBirim.Location = New System.Drawing.Point(12, 23)
        Me.LabelBirim.Name = "LabelBirim"
        Me.LabelBirim.Size = New System.Drawing.Size(56, 22)
        Me.LabelBirim.TabIndex = 8
        Me.LabelBirim.Text = "Birim:"
        '
        'TextBirim
        '
        Me.TextBirim.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBirim.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBirim.Location = New System.Drawing.Point(99, 23)
        Me.TextBirim.Name = "TextBirim"
        Me.TextBirim.Size = New System.Drawing.Size(203, 27)
        Me.TextBirim.TabIndex = 7
        '
        'FormBirimSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(332, 139)
        Me.Controls.Add(Me.ButonCikis)
        Me.Controls.Add(Me.ButonSil)
        Me.Controls.Add(Me.LabelBirim)
        Me.Controls.Add(Me.TextBirim)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormBirimSil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Birim Sil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButonCikis As Button
    Friend WithEvents ButonSil As Button
    Friend WithEvents LabelBirim As Label
    Friend WithEvents TextBirim As TextBox
    Friend WithEvents ımageList1 As ImageList
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMusteriEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMusteriEkle))
        Me.TextMusteriID = New System.Windows.Forms.TextBox()
        Me.TextAdiSoyadi = New System.Windows.Forms.TextBox()
        Me.TextTelefon = New System.Windows.Forms.TextBox()
        Me.TextAdres = New System.Windows.Forms.TextBox()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.LabelMusteriID = New System.Windows.Forms.Label()
        Me.LabelAdiSoyadi = New System.Windows.Forms.Label()
        Me.LabelTelefon = New System.Windows.Forms.Label()
        Me.LabelAdres = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.ButonEkle = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Butonİptal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextMusteriID
        '
        Me.TextMusteriID.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextMusteriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMusteriID.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextMusteriID.ForeColor = System.Drawing.SystemColors.Window
        Me.TextMusteriID.Location = New System.Drawing.Point(157, 18)
        Me.TextMusteriID.Name = "TextMusteriID"
        Me.TextMusteriID.Size = New System.Drawing.Size(154, 23)
        Me.TextMusteriID.TabIndex = 0
        '
        'TextAdiSoyadi
        '
        Me.TextAdiSoyadi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdiSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdiSoyadi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdiSoyadi.Location = New System.Drawing.Point(157, 60)
        Me.TextAdiSoyadi.Name = "TextAdiSoyadi"
        Me.TextAdiSoyadi.Size = New System.Drawing.Size(154, 23)
        Me.TextAdiSoyadi.TabIndex = 0
        '
        'TextTelefon
        '
        Me.TextTelefon.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTelefon.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextTelefon.ForeColor = System.Drawing.SystemColors.Window
        Me.TextTelefon.Location = New System.Drawing.Point(157, 92)
        Me.TextTelefon.Name = "TextTelefon"
        Me.TextTelefon.Size = New System.Drawing.Size(154, 23)
        Me.TextTelefon.TabIndex = 0
        '
        'TextAdres
        '
        Me.TextAdres.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAdres.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextAdres.ForeColor = System.Drawing.SystemColors.Window
        Me.TextAdres.Location = New System.Drawing.Point(157, 123)
        Me.TextAdres.Multiline = True
        Me.TextAdres.Name = "TextAdres"
        Me.TextAdres.Size = New System.Drawing.Size(154, 80)
        Me.TextAdres.TabIndex = 0
        '
        'TextEmail
        '
        Me.TextEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEmail.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEmail.ForeColor = System.Drawing.SystemColors.Window
        Me.TextEmail.Location = New System.Drawing.Point(157, 209)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(154, 23)
        Me.TextEmail.TabIndex = 0
        '
        'LabelMusteriID
        '
        Me.LabelMusteriID.AutoSize = True
        Me.LabelMusteriID.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelMusteriID.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMusteriID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelMusteriID.Location = New System.Drawing.Point(21, 16)
        Me.LabelMusteriID.Name = "LabelMusteriID"
        Me.LabelMusteriID.Size = New System.Drawing.Size(96, 22)
        Me.LabelMusteriID.TabIndex = 1
        Me.LabelMusteriID.Text = "Müşteri ID:"
        '
        'LabelAdiSoyadi
        '
        Me.LabelAdiSoyadi.AutoSize = True
        Me.LabelAdiSoyadi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAdiSoyadi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdiSoyadi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdiSoyadi.Location = New System.Drawing.Point(21, 60)
        Me.LabelAdiSoyadi.Name = "LabelAdiSoyadi"
        Me.LabelAdiSoyadi.Size = New System.Drawing.Size(96, 22)
        Me.LabelAdiSoyadi.TabIndex = 1
        Me.LabelAdiSoyadi.Text = "Adı Soyadı:"
        '
        'LabelTelefon
        '
        Me.LabelTelefon.AutoSize = True
        Me.LabelTelefon.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTelefon.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelTelefon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTelefon.Location = New System.Drawing.Point(46, 90)
        Me.LabelTelefon.Name = "LabelTelefon"
        Me.LabelTelefon.Size = New System.Drawing.Size(71, 22)
        Me.LabelTelefon.TabIndex = 1
        Me.LabelTelefon.Text = "Telefon:"
        '
        'LabelAdres
        '
        Me.LabelAdres.AutoSize = True
        Me.LabelAdres.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelAdres.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdres.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAdres.Location = New System.Drawing.Point(58, 121)
        Me.LabelAdres.Name = "LabelAdres"
        Me.LabelAdres.Size = New System.Drawing.Size(59, 22)
        Me.LabelAdres.TabIndex = 1
        Me.LabelAdres.Text = "Adres:"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelEmail.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelEmail.Location = New System.Drawing.Point(58, 210)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(64, 22)
        Me.LabelEmail.TabIndex = 1
        Me.LabelEmail.Text = "E-mail:"
        '
        'ButonEkle
        '
        Me.ButonEkle.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonEkle.ImageKey = "add (2).png"
        Me.ButonEkle.ImageList = Me.ımageList1
        Me.ButonEkle.Location = New System.Drawing.Point(124, 250)
        Me.ButonEkle.Name = "ButonEkle"
        Me.ButonEkle.Size = New System.Drawing.Size(74, 38)
        Me.ButonEkle.TabIndex = 2
        Me.ButonEkle.Text = "Ekle"
        Me.ButonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonEkle.UseVisualStyleBackColor = True
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "add (2).png")
        Me.ımageList1.Images.SetKeyName(1, "cancel (1).png")
        '
        'Butonİptal
        '
        Me.Butonİptal.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Butonİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Butonİptal.ImageKey = "cancel (1).png"
        Me.Butonİptal.ImageList = Me.ımageList1
        Me.Butonİptal.Location = New System.Drawing.Point(236, 250)
        Me.Butonİptal.Name = "Butonİptal"
        Me.Butonİptal.Size = New System.Drawing.Size(88, 38)
        Me.Butonİptal.TabIndex = 2
        Me.Butonİptal.Text = "İptal"
        Me.Butonİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Butonİptal.UseVisualStyleBackColor = True
        '
        'FormMusteriEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(375, 308)
        Me.Controls.Add(Me.Butonİptal)
        Me.Controls.Add(Me.ButonEkle)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelAdres)
        Me.Controls.Add(Me.LabelTelefon)
        Me.Controls.Add(Me.LabelAdiSoyadi)
        Me.Controls.Add(Me.LabelMusteriID)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.TextAdres)
        Me.Controls.Add(Me.TextTelefon)
        Me.Controls.Add(Me.TextAdiSoyadi)
        Me.Controls.Add(Me.TextMusteriID)
        Me.Name = "FormMusteriEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Ekle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextMusteriID As TextBox
    Friend WithEvents TextAdiSoyadi As TextBox
    Friend WithEvents TextTelefon As TextBox
    Friend WithEvents TextAdres As TextBox
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents LabelMusteriID As Label
    Friend WithEvents LabelAdiSoyadi As Label
    Friend WithEvents LabelTelefon As Label
    Friend WithEvents LabelAdres As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents ButonEkle As Button
    Friend WithEvents Butonİptal As Button
    Friend WithEvents ımageList1 As ImageList
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKullaniciGirisi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKullaniciGirisi))
        Me.lblKullaniciAdi = New System.Windows.Forms.Label()
        Me.TextKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.lblParola = New System.Windows.Forms.Label()
        Me.TextSifre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButonGirisYap = New System.Windows.Forms.Button()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CheckBoxBeniHatirla = New System.Windows.Forms.CheckBox()
        Me.LinkLabelSifremiUnuttum = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButonSec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKullaniciAdi
        '
        Me.lblKullaniciAdi.AutoSize = True
        Me.lblKullaniciAdi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKullaniciAdi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblKullaniciAdi.Location = New System.Drawing.Point(23, 67)
        Me.lblKullaniciAdi.Name = "lblKullaniciAdi"
        Me.lblKullaniciAdi.Size = New System.Drawing.Size(110, 22)
        Me.lblKullaniciAdi.TabIndex = 0
        Me.lblKullaniciAdi.Text = "Kullanıcı Adı:"
        '
        'TextKullaniciAdi
        '
        Me.TextKullaniciAdi.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextKullaniciAdi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextKullaniciAdi.ForeColor = System.Drawing.SystemColors.Window
        Me.TextKullaniciAdi.Location = New System.Drawing.Point(145, 66)
        Me.TextKullaniciAdi.Name = "TextKullaniciAdi"
        Me.TextKullaniciAdi.Size = New System.Drawing.Size(166, 23)
        Me.TextKullaniciAdi.TabIndex = 1
        '
        'lblParola
        '
        Me.lblParola.AutoSize = True
        Me.lblParola.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblParola.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblParola.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblParola.Location = New System.Drawing.Point(50, 104)
        Me.lblParola.Name = "lblParola"
        Me.lblParola.Size = New System.Drawing.Size(62, 22)
        Me.lblParola.TabIndex = 2
        Me.lblParola.Text = "Parola:"
        '
        'TextSifre
        '
        Me.TextSifre.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSifre.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextSifre.ForeColor = System.Drawing.SystemColors.Window
        Me.TextSifre.Location = New System.Drawing.Point(145, 106)
        Me.TextSifre.Name = "TextSifre"
        Me.TextSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextSifre.Size = New System.Drawing.Size(166, 23)
        Me.TextSifre.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(145, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(166, 1)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(145, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(166, 1)
        Me.Panel2.TabIndex = 5
        '
        'ButonGirisYap
        '
        Me.ButonGirisYap.BackColor = System.Drawing.Color.Transparent
        Me.ButonGirisYap.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonGirisYap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonGirisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButonGirisYap.ImageKey = "1828457.png"
        Me.ButonGirisYap.ImageList = Me.ımageList1
        Me.ButonGirisYap.Location = New System.Drawing.Point(202, 149)
        Me.ButonGirisYap.Name = "ButonGirisYap"
        Me.ButonGirisYap.Size = New System.Drawing.Size(109, 36)
        Me.ButonGirisYap.TabIndex = 6
        Me.ButonGirisYap.Text = "Giriş Yap"
        Me.ButonGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButonGirisYap.UseVisualStyleBackColor = False
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "1828457.png")
        '
        'CheckBoxBeniHatirla
        '
        Me.CheckBoxBeniHatirla.AutoSize = True
        Me.CheckBoxBeniHatirla.BackColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxBeniHatirla.Checked = True
        Me.CheckBoxBeniHatirla.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxBeniHatirla.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckBoxBeniHatirla.Location = New System.Drawing.Point(63, 135)
        Me.CheckBoxBeniHatirla.Name = "CheckBoxBeniHatirla"
        Me.CheckBoxBeniHatirla.Size = New System.Drawing.Size(106, 22)
        Me.CheckBoxBeniHatirla.TabIndex = 7
        Me.CheckBoxBeniHatirla.Text = "Beni Hatırla"
        Me.CheckBoxBeniHatirla.UseVisualStyleBackColor = False
        '
        'LinkLabelSifremiUnuttum
        '
        Me.LinkLabelSifremiUnuttum.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabelSifremiUnuttum.AutoSize = True
        Me.LinkLabelSifremiUnuttum.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LinkLabelSifremiUnuttum.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabelSifremiUnuttum.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LinkLabelSifremiUnuttum.LinkColor = System.Drawing.Color.White
        Me.LinkLabelSifremiUnuttum.Location = New System.Drawing.Point(13, 192)
        Me.LinkLabelSifremiUnuttum.Name = "LinkLabelSifremiUnuttum"
        Me.LinkLabelSifremiUnuttum.Size = New System.Drawing.Size(120, 18)
        Me.LinkLabelSifremiUnuttum.TabIndex = 8
        Me.LinkLabelSifremiUnuttum.TabStop = True
        Me.LinkLabelSifremiUnuttum.Text = "Şifremi Unuttum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "X"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ComboBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"TR", "EN"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(57, 26)
        Me.ComboBox1.TabIndex = 10
        '
        'ButonSec
        '
        Me.ButonSec.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButonSec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButonSec.Location = New System.Drawing.Point(75, 9)
        Me.ButonSec.Name = "ButonSec"
        Me.ButonSec.Size = New System.Drawing.Size(58, 29)
        Me.ButonSec.TabIndex = 11
        Me.ButonSec.Text = "Seç"
        Me.ButonSec.UseVisualStyleBackColor = True
        '
        'FormKullaniciGirisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(395, 229)
        Me.Controls.Add(Me.ButonSec)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabelSifremiUnuttum)
        Me.Controls.Add(Me.CheckBoxBeniHatirla)
        Me.Controls.Add(Me.ButonGirisYap)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextSifre)
        Me.Controls.Add(Me.lblParola)
        Me.Controls.Add(Me.TextKullaniciAdi)
        Me.Controls.Add(Me.lblKullaniciAdi)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKullaniciGirisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Girişi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKullaniciAdi As Label
    Friend WithEvents TextKullaniciAdi As TextBox
    Friend WithEvents lblParola As Label
    Friend WithEvents TextSifre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButonGirisYap As Button
    Friend WithEvents CheckBoxBeniHatirla As CheckBox
    Friend WithEvents LinkLabelSifremiUnuttum As LinkLabel
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ButonSec As Button
End Class

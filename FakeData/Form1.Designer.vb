<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGenerer = New Button()
        txtNom = New TextBox()
        Label1 = New Label()
        txtPrenom = New TextBox()
        txtDateNaissance = New TextBox()
        txtNumSecu = New TextBox()
        txtAdresse = New TextBox()
        txtCodePostal = New TextBox()
        txtVille = New TextBox()
        txtEmail = New TextBox()
        txtTelephone = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtMobile = New TextBox()
        txtSexe = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        txtCle = New TextBox()
        txtIban = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        txtBic = New TextBox()
        Label13 = New Label()
        txtEtablissement = New TextBox()
        lMsg = New Label()
        SuspendLayout()
        ' 
        ' btnGenerer
        ' 
        btnGenerer.BackColor = Color.DodgerBlue
        btnGenerer.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        btnGenerer.Location = New Point(170, 14)
        btnGenerer.Margin = New Padding(4, 3, 4, 3)
        btnGenerer.Name = "btnGenerer"
        btnGenerer.Size = New Size(223, 58)
        btnGenerer.TabIndex = 0
        btnGenerer.Text = "générer"
        btnGenerer.UseVisualStyleBackColor = False
        ' 
        ' txtNom
        ' 
        txtNom.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNom.Location = New Point(173, 117)
        txtNom.Margin = New Padding(4, 3, 4, 3)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(333, 22)
        txtNom.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 120)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 17)
        Label1.TabIndex = 2
        Label1.Text = "Nom :"
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPrenom.Location = New Point(173, 150)
        txtPrenom.Margin = New Padding(4, 3, 4, 3)
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(333, 22)
        txtPrenom.TabIndex = 3
        ' 
        ' txtDateNaissance
        ' 
        txtDateNaissance.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDateNaissance.Location = New Point(173, 183)
        txtDateNaissance.Margin = New Padding(4, 3, 4, 3)
        txtDateNaissance.Name = "txtDateNaissance"
        txtDateNaissance.Size = New Size(142, 22)
        txtDateNaissance.TabIndex = 4
        ' 
        ' txtNumSecu
        ' 
        txtNumSecu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNumSecu.Location = New Point(173, 217)
        txtNumSecu.Margin = New Padding(4, 3, 4, 3)
        txtNumSecu.Name = "txtNumSecu"
        txtNumSecu.Size = New Size(181, 22)
        txtNumSecu.TabIndex = 5
        ' 
        ' txtAdresse
        ' 
        txtAdresse.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAdresse.Location = New Point(173, 264)
        txtAdresse.Margin = New Padding(4, 3, 4, 3)
        txtAdresse.Name = "txtAdresse"
        txtAdresse.Size = New Size(333, 22)
        txtAdresse.TabIndex = 6
        ' 
        ' txtCodePostal
        ' 
        txtCodePostal.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCodePostal.Location = New Point(173, 298)
        txtCodePostal.Margin = New Padding(4, 3, 4, 3)
        txtCodePostal.Name = "txtCodePostal"
        txtCodePostal.Size = New Size(220, 22)
        txtCodePostal.TabIndex = 7
        ' 
        ' txtVille
        ' 
        txtVille.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtVille.Location = New Point(173, 331)
        txtVille.Margin = New Padding(4, 3, 4, 3)
        txtVille.Name = "txtVille"
        txtVille.Size = New Size(333, 22)
        txtVille.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(173, 365)
        txtEmail.Margin = New Padding(4, 3, 4, 3)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(333, 22)
        txtEmail.TabIndex = 9
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTelephone.Location = New Point(173, 410)
        txtTelephone.Margin = New Padding(4, 3, 4, 3)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(220, 22)
        txtTelephone.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(112, 368)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 17)
        Label2.TabIndex = 11
        Label2.Text = "email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 153)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 17)
        Label3.TabIndex = 12
        Label3.Text = "Prénom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 186)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 17)
        Label4.TabIndex = 13
        Label4.Text = "Date Naissance"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(54, 219)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 17)
        Label5.TabIndex = 14
        Label5.Text = "numéro sécu"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(91, 269)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 17)
        Label6.TabIndex = 15
        Label6.Text = "adresse"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(133, 301)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 17)
        Label7.TabIndex = 16
        Label7.Text = "CP"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(120, 335)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 17)
        Label8.TabIndex = 17
        Label8.Text = "Ville"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(70, 410)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 17)
        Label9.TabIndex = 18
        Label9.Text = "Téléphone"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(102, 447)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 17)
        Label10.TabIndex = 20
        Label10.Text = "Mobile"
        ' 
        ' txtMobile
        ' 
        txtMobile.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtMobile.Location = New Point(173, 443)
        txtMobile.Margin = New Padding(4, 3, 4, 3)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(220, 22)
        txtMobile.TabIndex = 19
        ' 
        ' txtSexe
        ' 
        txtSexe.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSexe.Location = New Point(330, 186)
        txtSexe.Margin = New Padding(4, 3, 4, 3)
        txtSexe.Name = "txtSexe"
        txtSexe.Size = New Size(62, 22)
        txtSexe.TabIndex = 21
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(438, 14)
        RadioButton1.Margin = New Padding(4, 3, 4, 3)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(69, 19)
        RadioButton1.TabIndex = 22
        RadioButton1.TabStop = True
        RadioButton1.Text = "Homme"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(438, 40)
        RadioButton2.Margin = New Padding(4, 3, 4, 3)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(65, 19)
        RadioButton2.TabIndex = 23
        RadioButton2.Text = "Femme"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' txtCle
        ' 
        txtCle.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCle.Location = New Point(362, 219)
        txtCle.Margin = New Padding(4, 3, 4, 3)
        txtCle.Name = "txtCle"
        txtCle.Size = New Size(46, 22)
        txtCle.TabIndex = 24
        ' 
        ' txtIban
        ' 
        txtIban.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtIban.Location = New Point(173, 486)
        txtIban.Margin = New Padding(4, 3, 4, 3)
        txtIban.Name = "txtIban"
        txtIban.Size = New Size(335, 23)
        txtIban.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(112, 489)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 17)
        Label11.TabIndex = 26
        Label11.Text = "IBAN"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(120, 523)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(32, 17)
        Label12.TabIndex = 28
        Label12.Text = "BIC"
        ' 
        ' txtBic
        ' 
        txtBic.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBic.Location = New Point(170, 519)
        txtBic.Margin = New Padding(4, 3, 4, 3)
        txtBic.Name = "txtBic"
        txtBic.Size = New Size(237, 23)
        txtBic.TabIndex = 27
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(38, 560)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(109, 17)
        Label13.TabIndex = 30
        Label13.Text = "Etablissement"
        ' 
        ' txtEtablissement
        ' 
        txtEtablissement.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEtablissement.Location = New Point(170, 553)
        txtEtablissement.Margin = New Padding(4, 3, 4, 3)
        txtEtablissement.Name = "txtEtablissement"
        txtEtablissement.Size = New Size(335, 23)
        txtEtablissement.TabIndex = 29
        ' 
        ' lMsg
        ' 
        lMsg.AutoSize = True
        lMsg.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lMsg.ForeColor = Color.Crimson
        lMsg.Location = New Point(169, 628)
        lMsg.Margin = New Padding(4, 0, 4, 0)
        lMsg.Name = "lMsg"
        lMsg.Size = New Size(263, 17)
        lMsg.TabIndex = 31
        lMsg.Text = "Champs copié dans le press papier"
        lMsg.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(625, 673)
        Controls.Add(lMsg)
        Controls.Add(Label13)
        Controls.Add(txtEtablissement)
        Controls.Add(Label12)
        Controls.Add(txtBic)
        Controls.Add(Label11)
        Controls.Add(txtIban)
        Controls.Add(txtCle)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(txtSexe)
        Controls.Add(Label10)
        Controls.Add(txtMobile)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtTelephone)
        Controls.Add(txtEmail)
        Controls.Add(txtVille)
        Controls.Add(txtCodePostal)
        Controls.Add(txtAdresse)
        Controls.Add(txtNumSecu)
        Controls.Add(txtDateNaissance)
        Controls.Add(txtPrenom)
        Controls.Add(Label1)
        Controls.Add(txtNom)
        Controls.Add(btnGenerer)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnGenerer As Button
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtDateNaissance As TextBox
    Friend WithEvents txtNumSecu As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtCodePostal As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtSexe As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtCle As TextBox
    Friend WithEvents txtIban As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBic As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEtablissement As TextBox
    Friend WithEvents lMsg As Label
End Class



Public Class Form1
    Private Sub btnGenerer_Click(sender As Object, e As EventArgs) Handles btnGenerer.Click
        lMsg.Visible = False
        Populate(1, If(RadioButton1.Checked, 0, 1))
    End Sub


    Sub Populate(nombre As Integer, genre As Integer)
        Dim ttp As ToolTip = New ToolTip()
        Dim annee As Integer = New Random().Next(1930, 2005)
        Dim jour As Integer = New Random().Next(1, 365)
        txtNom.Text = GetRandomLastName(noms)
        txtPrenom.Text = GetRandomNameFromJson(If(RadioButton1.Checked, 0, 1))
        txtDateNaissance.Text = GetNthDayOfYear(jour, annee).ToString("dd/MM/yyyy")
        ttp.SetToolTip(txtDateNaissance, DateAndTime.DateDiff(DateInterval.Year, CDate(txtDateNaissance.Text), Now).ToString())
        txtSexe.Text = If(RadioButton1.Checked, "H", "F")
        Dim numss = GenererNumeroSecuriteSociale(txtSexe.Text, txtDateNaissance.Text, New Random().Next(10000, 75020))
        txtNumSecu.Text = numss.Substring(0, 13)
        txtCle.Text = numss.Substring(13, 2)

        txtAdresse.Text = New Random().Next(1, 99) & " " & GetRandomStreet(rues).Denomination
        Dim commune1 As Commune = GetRandomCity(communes)
        txtVille.Text = commune1.nom_standard.ToUpper
        txtCodePostal.Text = commune1.code_postal.PadLeft(5, "0"c)
        txtTelephone.Text = GetRandomFrenchPhoneNumber(False)
        txtMobile.Text = GetRandomFrenchPhoneNumber(True)
        txtEmail.Text = ("test-" & txtNom.Text.ToLower & "@monsupersite.com").Replace(" ", "-")
        txtIban.Text = GenererIBANFR()
        Dim indice As Integer = New Random().Next(0, banquesFR.Count - 1)
        txtBic.Text = banquesFR(indice).Bic
        txtEtablissement.Text = banquesFR(indice).NomCourt.ToUpper
    End Sub

    Function GenererNumeroSecuriteSociale(sexe As String, dateNaissance As String, codepostal As String) As String
        Dim random As New Random()
        Dim numero As String = ""
        Dim numeroInsee As String = If(sexe = "H", 1, 2) & CDate(dateNaissance).ToString("yyMM") & codepostal
        Dim randomNumber As String = random.Next(0, 999).ToString("D3")
        Dim cle As Integer = 97 - (Convert.ToDouble(numeroInsee & randomNumber) Mod 97)
        If cle < 10 Then
            numero = numeroInsee & randomNumber & "0" & cle.ToString()
        Else
            numero = numeroInsee & randomNumber & cle.ToString()
        End If
        Return numero
    End Function

    Public Class CustomPerson
        Public Property FullName As String
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Sexe As String
        Public Property DateOfBirth As DateTime
        Public Property Address As CardAddress
        Public Property PhoneNumber As String
        Public Property Mobile As String
        Public Property Email As String
        Public Property Rib As RibDetails
    End Class

    Public Class CardAddress
        Public Property Street As String
        Public Property City As String
        Public Property State As String
        Public Property ZipCode As String
    End Class
    Class RibDetails
        Property Iban As String
        Property Bic As String
        Property Etablissement As String
        Property Titulaire As String

    End Class

    Public Enum Sexe
        Homme = 1
        Femme = 2
    End Enum
    Class Banque
        Property NomCourt As String
        Property NomComplet As String
        Property Bic As String
        Sub New(nomCourt As String, nomComplet As String, bic As String)
            Me.NomCourt = nomCourt
            Me.NomComplet = nomComplet
            Me.Bic = bic
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler DirectCast(ctrl, TextBox).Click, AddressOf TextBox_Click
            End If
        Next
        POpulateBanques()
    End Sub
    Private Sub TextBox_Click(sender As Object, e As EventArgs)
        ' Vérifier que sender est bien un TextBox
        If TypeOf sender Is TextBox Then
            Dim txt As TextBox = DirectCast(sender, TextBox)
            ' Copier le contenu dans le presse-papier
            If Not String.IsNullOrEmpty(txt.Text) Then
                Clipboard.SetText(txt.Text)
                lMsg.Visible = True
                ' Masquer le message après 2 secondes
                Dim timer As New Timer()
                AddHandler timer.Tick, Sub(s, args)
                                           lMsg.Visible = False
                                           timer.Stop()
                                       End Sub
                timer.Interval = 2000 ' 2 secondes
                timer.Start()
            End If
        End If
    End Sub

    Private banquesFR As New List(Of Banque)
    Sub PopulateBanques()
        banquesFR.Add(New Banque("BNP", "Banque Nationale de Paris", "PARBFRPPXXX"))
        banquesFR.Add(New Banque("LCL", "Le Crédit Lyonnais", "CRLYFRPPXXX"))
        banquesFR.Add(New Banque("Société Générale", "Société Générale SCF", "GSCFFR22XXX"))
        banquesFR.Add(New Banque("Crédit Agricole", "Crédit Agricole SA", "AGRIFRPPXXX"))
        banquesFR.Add(New Banque("Crédit Mutuel", "Crédit Mutuel", "CMCIFR2AXXX"))
        banquesFR.Add(New Banque("La Banque Postale", "La Banque Postale", "PSSTFRPPXXX"))
    End Sub


    Private noms As New List(Of String)
    Private prenoms As New List(Of String)
    Private Function GetRandomNameFromJson(genre As Integer) As String
        ' Lire le contenu du fichier JSON
        Dim jsonContent As String = System.IO.File.ReadAllText(".\Data\prenoms.json")

        ' Désérialiser le JSON en tableau d'objets
        Dim prenoms = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Prenom))(jsonContent)

        ' Filtrer les prénoms selon le genre (0 = homme, 1 = femme)
        Dim filteredNames = prenoms.Where(Function(p) p.sex = If(genre = 0, "h", "f")).ToList()

        ' Choisir un prénom au hasard
        Dim random As New Random()
        Dim randomIndex = random.Next(0, filteredNames.Count)

        Return filteredNames(randomIndex).name
    End Function

    Private Function GetRandomLastName(ByRef noms As List(Of String)) As String
        Try
            If noms.Count = 0 Then
                Dim jsonContent As String = System.IO.File.ReadAllText(".\Data\noms.json")
                noms = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of String))(jsonContent)
            End If

            If noms Is Nothing OrElse noms.Count = 0 Then
                Throw New Exception("Le fichier noms.json est vide ou mal formaté.")
            End If

            Dim randomIndex = New Random().Next(0, noms.Count)
            Return noms(randomIndex)
        Catch ex As Exception
            MessageBox.Show($"Erreur lors de la lecture du fichier noms.json : {ex.Message}")
            Return "Nom_Inconnu"
        End Try
    End Function

    Private communes As New List(Of Commune)
    Private Function GetRandomCity(ByRef communes As List(Of Commune)) As Commune
        Try
            If communes.Count = 0 Then
                Dim jsonContent As String = System.IO.File.ReadAllText(".\Data\communes-france.json")
                communes = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Commune))(jsonContent)
            End If

            If communes Is Nothing OrElse communes.Count = 0 Then
                Throw New Exception("Le fichier communes-france.json est vide ou mal formaté.")
            End If

            Dim random As New Random()
            Dim randomIndex = random.Next(0, communes.Count)

            Return communes(randomIndex)
        Catch ex As Exception
            MessageBox.Show($"Erreur lors de la lecture du fichier communes-france.json : {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private rues As New List(Of Street)
    Private Function GetRandomStreet(ByRef rues As List(Of Street)) As Street
        Try
            If rues.Count = 0 Then
                Dim jsonContent As String = System.IO.File.ReadAllText(".\Data\rues-paris.json")
                rues = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Street))(jsonContent)
            End If
            If rues Is Nothing OrElse rues.Count = 0 Then
                Throw New Exception("Le fichier rues-paris.json est vide ou mal formaté.")
            End If
            Dim random As New Random()
            Dim randomIndex = random.Next(0, rues.Count)
            Return rues(randomIndex)
        Catch ex As Exception
            Return (New Street())
        End Try
    End Function

    Private Function GetNthDayOfYear(n As Integer, year As Integer) As DateTime
        Try
            If n < 1 OrElse n > DateTime.IsLeapYear(year) + 365 Then
                Throw New ArgumentOutOfRangeException("n", "Le numéro de jour est hors des limites pour l'année spécifiée.")
            End If

            Return New DateTime(year, 1, 1).AddDays(n - 1)
        Catch ex As Exception
            MessageBox.Show($"Erreur : {ex.Message}")
            Return DateTime.MinValue
        End Try
    End Function

    Private Function GetRandomFrenchPhoneNumber(Optional mobile = False) As String
        Try
            ' Définir les préfixes valides pour les numéros français
            Dim prefixes As String() = {"01", "02", "03", "04", "05"}
            If mobile Then
                prefixes = {"06", "07"}
            End If

            ' Générer un préfixe aléatoire
            Dim random As New Random()
            Dim prefix As String = prefixes(random.Next(0, prefixes.Length))

            ' Générer les 8 chiffres restants
            Dim remainingDigits As String = random.Next(0, 99999999).ToString("D8")

            ' Combiner le préfixe et les chiffres restants
            Return $"{prefix} {remainingDigits.Substring(0, 2)} {remainingDigits.Substring(2, 2)} {remainingDigits.Substring(4, 2)} {remainingDigits.Substring(6, 2)}"
        Catch ex As Exception
            Return "Numéro_Inconnu"
        End Try
    End Function


    Class Prenom
        Property id As String
        Property name As String
        Property sex As String

    End Class
    Class Commune
        Property nom_standard As String
        Property code_postal As String
        Property code_insee As String
    End Class

    Class Street
        Property id As Integer
        Property Denomination As String

        Sub New()
            id = 0
            Denomination = ""
        End Sub
    End Class


End Class

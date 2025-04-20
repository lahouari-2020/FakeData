Imports System
Imports System.Text
Imports System.Numerics

Module IBANGenerator

    Function RandomDigits(n As Integer) As String
        Dim rnd As New Random()
        Dim sb As New StringBuilder()
        For i As Integer = 1 To n
            sb.Append(rnd.Next(0, 10).ToString())
        Next
        Return sb.ToString()
    End Function

    Function RandomAlphanum(n As Integer) As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim rnd As New Random()
        Dim sb As New StringBuilder()
        For i As Integer = 1 To n
            sb.Append(chars(rnd.Next(chars.Length)))
        Next
        Return sb.ToString()
    End Function

    Function CalculCleIBAN(ibanBase As String) As String
        ' Déplacer les 4 premiers caractères à la fin
        Dim ibanMod As String = ibanBase.Substring(4) & ibanBase.Substring(0, 4)
        ' Remplacer les lettres par leur valeur numérique
        Dim conversion As New StringBuilder()
        For Each c As Char In ibanMod
            If Char.IsDigit(c) Then
                conversion.Append(c)
            Else
                conversion.Append((Asc(Char.ToUpper(c)) - 55).ToString())
            End If
        Next
        ' Calculer le reste modulo 97
        Dim bigNum As New BigInteger()
        bigNum = BigInteger.Parse(conversion.ToString())
        Dim reste As Integer = CType(bigNum Mod 97, Integer)
        Dim cle As Integer = 98 - reste
        Return cle.ToString("00")
    End Function

    Function GenererIBANFR() As String
        Dim codeBanque As String = RandomDigits(5)
        Dim codeGuichet As String = RandomDigits(5)
        Dim numCompte As String = RandomAlphanum(11)
        Dim cleRIB As String = RandomDigits(2)
        Dim ibanBase As String = $"FR00{codeBanque}{codeGuichet}{numCompte}{cleRIB}"
        Dim cleIBAN As String = CalculCleIBAN(ibanBase)
        Return $"FR{cleIBAN}{codeBanque}{codeGuichet}{numCompte}{cleRIB}"
    End Function



End Module


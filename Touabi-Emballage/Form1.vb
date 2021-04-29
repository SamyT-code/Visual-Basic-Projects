'***********************************
'*Projet : emballage
'*Programmeur : Samy Touabi
'*Date de conception : 28 mars 2020
'***********************************
Public Class frmEmballage
    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click
        'Déclarer la variable de la procédure
        Dim intoranges As Integer
        Dim intcaisses As Integer
        Dim intindividuelles As Integer

        'Saisir les mesures de la variable
        intoranges = Val(Me.txtOranges.Text)

        'Converir les mesures de la variable
        intcaisses = intoranges \ 5
        intindividuelles = intoranges Mod 5

        'Afficher le resultat
        Me.lblCaisses.Text = "Vous avez " & intcaisses & " caisses, et " & intindividuelles & " oranges individuelles."
        Me.lblCout.Text = "Le prix total est donc de " & 3 * intcaisses + intindividuelles & " $."




    End Sub
End Class

'**********************************
'*Travail : Papeterie en gros
'*Programmeur : Samy Touabi
'*Date de conception : 27 mai 2020
'**********************************
Public Class frmPapeterie

    'Déclarer les constantes pour les prix des fruits
    Const Prix_ABRICOTS As Integer = 1
    Const Prix_FRAISES As Integer = 2
    Const Prix_BANANE As Integer = 3
    Const Prix_ORANGES As Integer = 4
    Const Prix_MANGUES As Integer = 5

    'Le coût de chaque fruit
    Dim Cout_ABRICOTS As Integer
    Dim Cout_FRAISES As Integer
    Dim Cout_BANANES As Integer
    Dim Cout_ORANGES As Integer
    Dim Cout_MANGUES As Integer

    Private Sub btnAjouterPanier_Click(sender As Object, e As EventArgs) Handles btnAjouterPanier.Click

        'Déclarer les variables
        Dim Quantite As Integer 'La quantité de fruits

        If cboQuantite.SelectedIndex >= 0 Then
            Quantite = Val(cboQuantite.SelectedItem) 'Choisir un item dans la liste
        Else
            Quantite = Val(cboQuantite.Text) 'Faire entrer une valeur dans le champ de saisie
        End If

        Select Case lstArticles.SelectedItem

            Case "Abricots (1$)" 'Les abricots sont choisis
                Cout_ABRICOTS = Prix_ABRICOTS * Quantite
                lblAbricots.Visible = True 'Rendre visible le label
                lblAbricots.Text = "Abricots : " & Quantite

            Case "Fraises (2$)" 'Les fraises sont choisies
                Cout_FRAISES = Prix_FRAISES * Quantite
                lblFraises.Visible = True 'Rendre visible le label
                lblFraises.Text = "Fraises : " & Quantite

            Case "Bananes (3$)" 'Les bananes sont choisies
                Cout_BANANES = Prix_BANANE * Quantite
                lblBananes.Visible = True 'Rendre visible le label
                lblBananes.Text = "Bananes : " & Quantite

            Case "Oranges (4$)" 'Les oranges sont choisies
                Cout_ORANGES = Prix_ORANGES * Quantite
                lblOranges.Visible = True 'Rendre visible le label
                lblOranges.Text = "Oranges : " & Quantite

            Case "Mangues (5$)" 'Les mangues sont choisies
                Cout_MANGUES = Prix_MANGUES * Quantite
                lblMangues.Visible = True 'Rendre visible le label
                lblMangues.Text = "Mangues : " & Quantite

        End Select

        btnCalculerCout.Enabled = True 'Permet à l'utilisateur de calculer le coût quand des fruits sont choisis

    End Sub

    Private Sub btnCalculerCout_Click(sender As Object, e As EventArgs) Handles btnCalculerCout.Click

        'Calculer le coût total
        lblCoutTotal.Text = "Coût total : " & (Cout_ABRICOTS + Cout_BANANES + Cout_FRAISES _
            + Cout_MANGUES + Cout_ORANGES) & " $"

    End Sub

    Private Sub btnResetPanier_Click(sender As Object, e As EventArgs) Handles btnResetPanier.Click

        Application.Restart() 'Reset le form

        Me.Refresh() ' Reset le form

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click

        End 'Quitter l'application

    End Sub

End Class
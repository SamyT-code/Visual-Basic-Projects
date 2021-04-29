<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPapeterie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstArticles = New System.Windows.Forms.ListBox()
        Me.lblChoisirFruit = New System.Windows.Forms.Label()
        Me.cboQuantite = New System.Windows.Forms.ComboBox()
        Me.lblChoisirQuantite = New System.Windows.Forms.Label()
        Me.btnAjouterPanier = New System.Windows.Forms.Button()
        Me.lblAbricots = New System.Windows.Forms.Label()
        Me.lblFraises = New System.Windows.Forms.Label()
        Me.lblBananes = New System.Windows.Forms.Label()
        Me.lblOranges = New System.Windows.Forms.Label()
        Me.lblMangues = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnResetPanier = New System.Windows.Forms.Button()
        Me.lblCoutTotal = New System.Windows.Forms.Label()
        Me.btnCalculerCout = New System.Windows.Forms.Button()
        Me.picFruitShop = New System.Windows.Forms.PictureBox()
        Me.picPanier = New System.Windows.Forms.PictureBox()
        CType(Me.picFruitShop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPanier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstArticles
        '
        Me.lstArticles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArticles.FormattingEnabled = True
        Me.lstArticles.ItemHeight = 20
        Me.lstArticles.Items.AddRange(New Object() {"Abricots (1$)", "Fraises (2$)", "Bananes (3$)", "Oranges (4$)", "Mangues (5$)"})
        Me.lstArticles.Location = New System.Drawing.Point(35, 92)
        Me.lstArticles.Name = "lstArticles"
        Me.lstArticles.Size = New System.Drawing.Size(170, 84)
        Me.lstArticles.TabIndex = 1
        '
        'lblChoisirFruit
        '
        Me.lblChoisirFruit.AutoSize = True
        Me.lblChoisirFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoisirFruit.Location = New System.Drawing.Point(31, 62)
        Me.lblChoisirFruit.Name = "lblChoisirFruit"
        Me.lblChoisirFruit.Size = New System.Drawing.Size(150, 20)
        Me.lblChoisirFruit.TabIndex = 2
        Me.lblChoisirFruit.Text = "Choisis un fruit :"
        '
        'cboQuantite
        '
        Me.cboQuantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQuantite.FormattingEnabled = True
        Me.cboQuantite.Items.AddRange(New Object() {"2", "4", "6", "8", "10"})
        Me.cboQuantite.Location = New System.Drawing.Point(235, 92)
        Me.cboQuantite.Name = "cboQuantite"
        Me.cboQuantite.Size = New System.Drawing.Size(175, 28)
        Me.cboQuantite.TabIndex = 3
        '
        'lblChoisirQuantite
        '
        Me.lblChoisirQuantite.AutoSize = True
        Me.lblChoisirQuantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoisirQuantite.Location = New System.Drawing.Point(232, 62)
        Me.lblChoisirQuantite.Name = "lblChoisirQuantite"
        Me.lblChoisirQuantite.Size = New System.Drawing.Size(178, 20)
        Me.lblChoisirQuantite.TabIndex = 4
        Me.lblChoisirQuantite.Text = "Choisis la quantité :"
        '
        'btnAjouterPanier
        '
        Me.btnAjouterPanier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterPanier.Location = New System.Drawing.Point(443, 72)
        Me.btnAjouterPanier.Name = "btnAjouterPanier"
        Me.btnAjouterPanier.Size = New System.Drawing.Size(131, 66)
        Me.btnAjouterPanier.TabIndex = 5
        Me.btnAjouterPanier.Text = "Ajouter au panier"
        Me.btnAjouterPanier.UseVisualStyleBackColor = True
        '
        'lblAbricots
        '
        Me.lblAbricots.AutoSize = True
        Me.lblAbricots.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbricots.ForeColor = System.Drawing.Color.Green
        Me.lblAbricots.Location = New System.Drawing.Point(694, 224)
        Me.lblAbricots.Name = "lblAbricots"
        Me.lblAbricots.Size = New System.Drawing.Size(77, 25)
        Me.lblAbricots.TabIndex = 6
        Me.lblAbricots.Text = "Label1"
        Me.lblAbricots.Visible = False
        '
        'lblFraises
        '
        Me.lblFraises.AutoSize = True
        Me.lblFraises.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraises.ForeColor = System.Drawing.Color.Green
        Me.lblFraises.Location = New System.Drawing.Point(694, 264)
        Me.lblFraises.Name = "lblFraises"
        Me.lblFraises.Size = New System.Drawing.Size(77, 25)
        Me.lblFraises.TabIndex = 7
        Me.lblFraises.Text = "Label2"
        Me.lblFraises.Visible = False
        '
        'lblBananes
        '
        Me.lblBananes.AutoSize = True
        Me.lblBananes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBananes.ForeColor = System.Drawing.Color.Green
        Me.lblBananes.Location = New System.Drawing.Point(694, 304)
        Me.lblBananes.Name = "lblBananes"
        Me.lblBananes.Size = New System.Drawing.Size(77, 25)
        Me.lblBananes.TabIndex = 8
        Me.lblBananes.Text = "Label3"
        Me.lblBananes.Visible = False
        '
        'lblOranges
        '
        Me.lblOranges.AutoSize = True
        Me.lblOranges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOranges.ForeColor = System.Drawing.Color.Green
        Me.lblOranges.Location = New System.Drawing.Point(694, 344)
        Me.lblOranges.Name = "lblOranges"
        Me.lblOranges.Size = New System.Drawing.Size(77, 25)
        Me.lblOranges.TabIndex = 9
        Me.lblOranges.Text = "Label4"
        Me.lblOranges.Visible = False
        '
        'lblMangues
        '
        Me.lblMangues.AutoSize = True
        Me.lblMangues.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMangues.ForeColor = System.Drawing.Color.Green
        Me.lblMangues.Location = New System.Drawing.Point(694, 385)
        Me.lblMangues.Name = "lblMangues"
        Me.lblMangues.Size = New System.Drawing.Size(77, 25)
        Me.lblMangues.TabIndex = 10
        Me.lblMangues.Text = "Label5"
        Me.lblMangues.Visible = False
        '
        'btnQuitter
        '
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.ForeColor = System.Drawing.Color.Red
        Me.btnQuitter.Location = New System.Drawing.Point(799, 548)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(113, 45)
        Me.btnQuitter.TabIndex = 11
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnResetPanier
        '
        Me.btnResetPanier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPanier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResetPanier.Location = New System.Drawing.Point(667, 548)
        Me.btnResetPanier.Name = "btnResetPanier"
        Me.btnResetPanier.Size = New System.Drawing.Size(113, 45)
        Me.btnResetPanier.TabIndex = 12
        Me.btnResetPanier.Text = "Reset"
        Me.btnResetPanier.UseVisualStyleBackColor = True
        '
        'lblCoutTotal
        '
        Me.lblCoutTotal.AutoSize = True
        Me.lblCoutTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoutTotal.ForeColor = System.Drawing.Color.Navy
        Me.lblCoutTotal.Location = New System.Drawing.Point(596, 467)
        Me.lblCoutTotal.Name = "lblCoutTotal"
        Me.lblCoutTotal.Size = New System.Drawing.Size(118, 25)
        Me.lblCoutTotal.TabIndex = 13
        Me.lblCoutTotal.Text = "Coût total :"
        '
        'btnCalculerCout
        '
        Me.btnCalculerCout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculerCout.Location = New System.Drawing.Point(443, 164)
        Me.btnCalculerCout.Name = "btnCalculerCout"
        Me.btnCalculerCout.Size = New System.Drawing.Size(131, 66)
        Me.btnCalculerCout.TabIndex = 14
        Me.btnCalculerCout.Text = "Calculer le coût"
        Me.btnCalculerCout.UseVisualStyleBackColor = True
        '
        'picFruitShop
        '
        Me.picFruitShop.Image = Global.Papeterie_En_Gros_2.My.Resources.Resources.nec_fruit_shop_thumbnail
        Me.picFruitShop.Location = New System.Drawing.Point(1, 254)
        Me.picFruitShop.Name = "picFruitShop"
        Me.picFruitShop.Size = New System.Drawing.Size(573, 357)
        Me.picFruitShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruitShop.TabIndex = 15
        Me.picFruitShop.TabStop = False
        '
        'picPanier
        '
        Me.picPanier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPanier.Image = Global.Papeterie_En_Gros_2.My.Resources.Resources.clipart1843239
        Me.picPanier.Location = New System.Drawing.Point(601, 29)
        Me.picPanier.Name = "picPanier"
        Me.picPanier.Size = New System.Drawing.Size(322, 409)
        Me.picPanier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPanier.TabIndex = 0
        Me.picPanier.TabStop = False
        '
        'frmPapeterie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 610)
        Me.Controls.Add(Me.picFruitShop)
        Me.Controls.Add(Me.btnCalculerCout)
        Me.Controls.Add(Me.lblCoutTotal)
        Me.Controls.Add(Me.btnResetPanier)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblMangues)
        Me.Controls.Add(Me.lblOranges)
        Me.Controls.Add(Me.lblBananes)
        Me.Controls.Add(Me.lblFraises)
        Me.Controls.Add(Me.lblAbricots)
        Me.Controls.Add(Me.btnAjouterPanier)
        Me.Controls.Add(Me.lblChoisirQuantite)
        Me.Controls.Add(Me.cboQuantite)
        Me.Controls.Add(Me.lblChoisirFruit)
        Me.Controls.Add(Me.lstArticles)
        Me.Controls.Add(Me.picPanier)
        Me.Name = "frmPapeterie"
        Me.Text = "Papeterie En Gros - Bon de commande"
        CType(Me.picFruitShop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPanier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPanier As PictureBox
    Friend WithEvents lstArticles As ListBox
    Friend WithEvents lblChoisirFruit As Label
    Friend WithEvents cboQuantite As ComboBox
    Friend WithEvents lblChoisirQuantite As Label
    Friend WithEvents btnAjouterPanier As Button
    Private WithEvents lblAbricots As Label
    Private WithEvents lblFraises As Label
    Private WithEvents lblBananes As Label
    Private WithEvents lblOranges As Label
    Private WithEvents lblMangues As Label
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnResetPanier As Button
    Friend WithEvents lblCoutTotal As Label
    Friend WithEvents btnCalculerCout As Button
    Friend WithEvents picFruitShop As PictureBox
End Class

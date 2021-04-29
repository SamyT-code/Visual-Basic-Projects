<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmballage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmballage))
        Me.lblTexte = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtOranges = New System.Windows.Forms.TextBox()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.lblCaisses = New System.Windows.Forms.Label()
        Me.lblCout = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTexte
        '
        Me.lblTexte.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTexte.Location = New System.Drawing.Point(63, 58)
        Me.lblTexte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTexte.Name = "lblTexte"
        Me.lblTexte.Size = New System.Drawing.Size(793, 103)
        Me.lblTexte.TabIndex = 0
        Me.lblTexte.Text = resources.GetString("lblTexte.Text")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(70, 192)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(174, 20)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre d'oranges :"
        '
        'txtOranges
        '
        Me.txtOranges.Location = New System.Drawing.Point(239, 192)
        Me.txtOranges.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOranges.Name = "txtOranges"
        Me.txtOranges.Size = New System.Drawing.Size(172, 27)
        Me.txtOranges.TabIndex = 2
        '
        'btnCalculer
        '
        Me.btnCalculer.ForeColor = System.Drawing.Color.Green
        Me.btnCalculer.Location = New System.Drawing.Point(514, 165)
        Me.btnCalculer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(309, 75)
        Me.btnCalculer.TabIndex = 3
        Me.btnCalculer.Text = "Calculer le prix et l'empaquetage"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'lblCaisses
        '
        Me.lblCaisses.AutoSize = True
        Me.lblCaisses.Location = New System.Drawing.Point(105, 257)
        Me.lblCaisses.Name = "lblCaisses"
        Me.lblCaisses.Size = New System.Drawing.Size(0, 20)
        Me.lblCaisses.TabIndex = 4
        '
        'lblCout
        '
        Me.lblCout.AutoSize = True
        Me.lblCout.Location = New System.Drawing.Point(105, 287)
        Me.lblCout.Name = "lblCout"
        Me.lblCout.Size = New System.Drawing.Size(0, 20)
        Me.lblCout.TabIndex = 5
        '
        'frmEmballage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 370)
        Me.Controls.Add(Me.lblCout)
        Me.Controls.Add(Me.lblCaisses)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.txtOranges)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTexte)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmballage"
        Me.Text = "Vente d'oranges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTexte As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtOranges As TextBox
    Friend WithEvents btnCalculer As Button
    Friend WithEvents lblCaisses As Label
    Friend WithEvents lblCout As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuConjuntos
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
        Label1 = New Label()
        Label2 = New Label()
        Conjutos2 = New Button()
        Conjutos3 = New Button()
        Conjutos4 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(98, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 25)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenido a Calculos de conjuntos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(162, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 17)
        Label2.TabIndex = 1
        Label2.Text = "Selecciona la cantidad de cojunto"
        ' 
        ' Conjutos2
        ' 
        Conjutos2.Location = New Point(29, 161)
        Conjutos2.Name = "Conjutos2"
        Conjutos2.Size = New Size(75, 23)
        Conjutos2.TabIndex = 2
        Conjutos2.Text = "2"
        Conjutos2.UseVisualStyleBackColor = True
        ' 
        ' Conjutos3
        ' 
        Conjutos3.Location = New Point(213, 161)
        Conjutos3.Name = "Conjutos3"
        Conjutos3.Size = New Size(75, 23)
        Conjutos3.TabIndex = 3
        Conjutos3.Text = "3"
        Conjutos3.UseVisualStyleBackColor = True
        ' 
        ' Conjutos4
        ' 
        Conjutos4.Location = New Point(401, 161)
        Conjutos4.Name = "Conjutos4"
        Conjutos4.Size = New Size(75, 23)
        Conjutos4.TabIndex = 4
        Conjutos4.Text = "4"
        Conjutos4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(374, 15)
        Label3.TabIndex = 5
        Label3.Text = "@copyrigth derechos reservado - Trabajo Integrador Matematica 2023"
        ' 
        ' MenuConjuntos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(512, 253)
        Controls.Add(Label3)
        Controls.Add(Conjutos4)
        Controls.Add(Conjutos3)
        Controls.Add(Conjutos2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MenuConjuntos"
        Text = "Menu Principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Conjutos2 As Button
    Friend WithEvents Conjutos3 As Button
    Friend WithEvents Conjutos4 As Button
    Friend WithEvents Label3 As Label
End Class

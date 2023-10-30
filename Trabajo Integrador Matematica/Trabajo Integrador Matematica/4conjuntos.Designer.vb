<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4conjuntos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label8 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label9 = New Label()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(436, 128)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 15)
        Label8.TabIndex = 46
        Label8.Text = "3er Conjunto"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(384, 165)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(180, 23)
        TextBox3.TabIndex = 45
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(206, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(227, 15)
        Label7.TabIndex = 44
        Label7.Text = "Ingrese los valores del conjuto con comas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(256, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 43
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(310, 406)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 42
        Label5.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(289, 376)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 41
        Label4.Text = "Resultado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(246, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 25)
        Label3.TabIndex = 40
        Label3.Text = "4 CONJUNTOS"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(379, 309)
        Button6.Name = "Button6"
        Button6.Size = New Size(93, 38)
        Button6.TabIndex = 39
        Button6.Text = "Diferencia Simetrica"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(508, 309)
        Button5.Name = "Button5"
        Button5.Size = New Size(92, 38)
        Button5.TabIndex = 38
        Button5.Text = "Complemento"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(238, 309)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 38)
        Button4.TabIndex = 37
        Button4.Text = "Diferencia Numero"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(119, 309)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 38)
        Button3.TabIndex = 36
        Button3.Text = "Interseccion"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(16, 309)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 38)
        Button2.TabIndex = 35
        Button2.Text = "Union"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 34
        Label2.Text = "2do Conjunto"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(76, 250)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(180, 23)
        TextBox2.TabIndex = 33
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(76, 165)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 23)
        TextBox1.TabIndex = 32
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 31
        Label1.Text = "1er Conjunto"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(436, 213)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 15)
        Label9.TabIndex = 48
        Label9.Text = "4to Conjunto"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(384, 250)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(180, 23)
        TextBox4.TabIndex = 47
        ' 
        ' _4conjuntos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(615, 430)
        Controls.Add(Label9)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "_4conjuntos"
        Text = "_4conjuntos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
End Class

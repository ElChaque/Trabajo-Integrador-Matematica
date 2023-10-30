<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3conjuntos
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
        TextBox3 = New TextBox()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(221, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(227, 15)
        Label7.TabIndex = 28
        Label7.Text = "Ingrese los valores del conjuto con comas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(271, 79)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 27
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(323, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 26
        Label5.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(302, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 25
        Label4.Text = "Resultado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(261, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 25)
        Label3.TabIndex = 24
        Label3.Text = "3 CONJUNTOS"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(415, 206)
        Button6.Name = "Button6"
        Button6.Size = New Size(93, 38)
        Button6.TabIndex = 23
        Button6.Text = "Diferencia Simetrica"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(550, 206)
        Button5.Name = "Button5"
        Button5.Size = New Size(92, 38)
        Button5.TabIndex = 22
        Button5.Text = "Complemento"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(271, 206)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 38)
        Button4.TabIndex = 21
        Button4.Text = "Diferencia Numero"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(142, 206)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 38)
        Button3.TabIndex = 20
        Button3.Text = "Interseccion"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(29, 206)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 38)
        Button2.TabIndex = 19
        Button2.Text = "Union"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(292, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 18
        Label2.Text = "2do Conjunto"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(251, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(180, 23)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(29, 146)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 23)
        TextBox1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 15
        Label1.Text = "1er Conjunto"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(462, 146)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(180, 23)
        TextBox3.TabIndex = 29
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(525, 109)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 15)
        Label8.TabIndex = 30
        Label8.Text = "3er Conjunto"
        ' 
        ' _3conjuntos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 327)
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
        Name = "_3conjuntos"
        Text = "_3conjuntos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
End Class

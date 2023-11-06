<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conjuntos2
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
        BtnUnion2 = New Button()
        BtnInter2 = New Button()
        BtnDifN2 = New Button()
        BtnDifS2 = New Button()
        BtnComp2 = New Button()
        Label1 = New Label()
        Conjunto2A = New TextBox()
        Conjunto2B = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Principal2A = New RadioButton()
        Principal2B = New RadioButton()
        BtnLimpiar = New Button()
        Label2 = New Label()
        BoxResult = New TextBox()
        ResultConjunto = New Label()
        Label5 = New Label()
        BtnVolver = New Button()
        SuspendLayout()
        ' 
        ' BtnUnion2
        ' 
        BtnUnion2.Location = New Point(28, 184)
        BtnUnion2.Name = "BtnUnion2"
        BtnUnion2.Size = New Size(98, 40)
        BtnUnion2.TabIndex = 0
        BtnUnion2.Text = "Unión"
        BtnUnion2.UseVisualStyleBackColor = True
        ' 
        ' BtnInter2
        ' 
        BtnInter2.Location = New Point(275, 184)
        BtnInter2.Name = "BtnInter2"
        BtnInter2.Size = New Size(98, 40)
        BtnInter2.TabIndex = 1
        BtnInter2.Text = "Intersección"
        BtnInter2.UseVisualStyleBackColor = True
        ' 
        ' BtnDifN2
        ' 
        BtnDifN2.Location = New Point(524, 184)
        BtnDifN2.Name = "BtnDifN2"
        BtnDifN2.Size = New Size(98, 40)
        BtnDifN2.TabIndex = 2
        BtnDifN2.Text = "Diferencia Número"
        BtnDifN2.UseVisualStyleBackColor = True
        ' 
        ' BtnDifS2
        ' 
        BtnDifS2.Location = New Point(401, 184)
        BtnDifS2.Name = "BtnDifS2"
        BtnDifS2.Size = New Size(98, 40)
        BtnDifS2.TabIndex = 3
        BtnDifS2.Text = "Diferencia Simétrica"
        BtnDifS2.UseVisualStyleBackColor = True
        ' 
        ' BtnComp2
        ' 
        BtnComp2.Location = New Point(151, 184)
        BtnComp2.Name = "BtnComp2"
        BtnComp2.Size = New Size(98, 40)
        BtnComp2.TabIndex = 4
        BtnComp2.Text = "Complemento"
        BtnComp2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(225, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 21)
        Label1.TabIndex = 5
        Label1.Text = "Calculadora de 2 Cojuntos"
        ' 
        ' Conjunto2A
        ' 
        Conjunto2A.Location = New Point(28, 114)
        Conjunto2A.Name = "Conjunto2A"
        Conjunto2A.Size = New Size(221, 23)
        Conjunto2A.TabIndex = 6
        ' 
        ' Conjunto2B
        ' 
        Conjunto2B.Location = New Point(401, 114)
        Conjunto2B.Name = "Conjunto2B"
        Conjunto2B.Size = New Size(221, 23)
        Conjunto2B.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(99, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 9
        Label3.Text = "Conjunto A"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(480, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 10
        Label4.Text = "Conjunto B"
        ' 
        ' Principal2A
        ' 
        Principal2A.AutoSize = True
        Principal2A.Location = New Point(28, 143)
        Principal2A.Name = "Principal2A"
        Principal2A.Size = New Size(124, 19)
        Principal2A.TabIndex = 25
        Principal2A.TabStop = True
        Principal2A.Text = "Conjunto Principal"
        Principal2A.UseVisualStyleBackColor = True
        ' 
        ' Principal2B
        ' 
        Principal2B.AutoSize = True
        Principal2B.Location = New Point(401, 143)
        Principal2B.Name = "Principal2B"
        Principal2B.Size = New Size(124, 19)
        Principal2B.TabIndex = 26
        Principal2B.TabStop = True
        Principal2B.Text = "Conjunto Principal"
        Principal2B.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpiar
        ' 
        BtnLimpiar.Location = New Point(275, 113)
        BtnLimpiar.Name = "BtnLimpiar"
        BtnLimpiar.Size = New Size(98, 23)
        BtnLimpiar.TabIndex = 32
        BtnLimpiar.Text = "Limpiar"
        BtnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(272, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 33
        ' 
        ' BoxResult
        ' 
        BoxResult.Location = New Point(213, 273)
        BoxResult.Name = "BoxResult"
        BoxResult.Size = New Size(221, 23)
        BoxResult.TabIndex = 34
        ' 
        ' ResultConjunto
        ' 
        ResultConjunto.AutoSize = True
        ResultConjunto.Location = New Point(153, 276)
        ResultConjunto.Name = "ResultConjunto"
        ResultConjunto.Size = New Size(59, 15)
        ResultConjunto.TabIndex = 36
        ResultConjunto.Text = "Resultado"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(186, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(279, 15)
        Label5.TabIndex = 37
        Label5.Text = "Ingrese los elementos a cada conjunto para calcular"
        ' 
        ' BtnVolver
        ' 
        BtnVolver.Location = New Point(12, 12)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(85, 31)
        BtnVolver.TabIndex = 38
        BtnVolver.Text = "Volver"
        BtnVolver.UseVisualStyleBackColor = True
        ' 
        ' Conjuntos2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(662, 331)
        Controls.Add(BtnVolver)
        Controls.Add(Label5)
        Controls.Add(ResultConjunto)
        Controls.Add(BoxResult)
        Controls.Add(Label2)
        Controls.Add(BtnLimpiar)
        Controls.Add(Principal2B)
        Controls.Add(Principal2A)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Conjunto2B)
        Controls.Add(Conjunto2A)
        Controls.Add(Label1)
        Controls.Add(BtnComp2)
        Controls.Add(BtnDifS2)
        Controls.Add(BtnDifN2)
        Controls.Add(BtnInter2)
        Controls.Add(BtnUnion2)
        Name = "Conjuntos2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculadora de 2 Conjuntos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnUnion2 As Button
    Friend WithEvents BtnInter2 As Button
    Friend WithEvents BtnDifN2 As Button
    Friend WithEvents BtnDifS2 As Button
    Friend WithEvents BtnComp2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Conjunto2A As TextBox
    Friend WithEvents Conjunto2B As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Principal2A As RadioButton
    Friend WithEvents Principal2B As RadioButton
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BoxResult As TextBox
    Friend WithEvents ResultConjunto As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnVolver As Button
End Class

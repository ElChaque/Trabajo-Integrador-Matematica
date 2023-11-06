Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Conjuntos2

    Private listaA As New List(Of Integer)
    Private listaB As New List(Of Integer)
    Private conjuntoSeleccionado As Char ' Puede ser 'A' o 'B'

    Private Sub GuardarElementos(ByRef listaA As List(Of Integer), ByRef listaB As List(Of Integer))
        ' los elementos ingresados en los textbox se guardan en listas
        listaA.Clear()
        listaB.Clear()

        Dim elementosA As String = Conjunto2A.Text
        Dim elementosB As String = Conjunto2B.Text

        ' Divide las cadenas en elementos individuales
        Dim elementosSeparadosA() As String = elementosA.Split(","c)
        Dim elementosSeparadosB() As String = elementosB.Split(","c)

        ' Llena las listas A y B con los elementos
        Dim NewElement As Integer
        For Each elemento As String In elementosSeparadosA
            If Integer.TryParse(elemento, NewElement) Then
                ' Elemento válido para A
                listaA.Add(NewElement)
            Else
                MessageBox.Show("Elemento no válido en el primer Conjunto A.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        For Each elemento As String In elementosSeparadosB
            If Integer.TryParse(elemento, NewElement) Then
                ' Elemento válido para B
                listaB.Add(NewElement)
            Else
                MessageBox.Show("Elemento no válido en el segundo Conjunto B.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Conjuntos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnUnion2_Click(sender As Object, e As EventArgs) Handles BtnUnion2.Click

        GuardarElementos(listaA, listaB)

        ' Crea conjuntos HashSet para eliminar elementos duplicados
        Dim conjuntoA As New HashSet(Of Integer)(listaA)
        Dim conjuntoB As New HashSet(Of Integer)(listaB)

        ' Realiza la unión de los conjuntos
        conjuntoA.UnionWith(conjuntoB)

        ' Convierte el conjunto de nuevo a una lista
        Dim resultadoUnion As List(Of Integer) = conjuntoA.ToList()

        ' Muestra el resultado en ConjuntoResult
        ConjuntoResult2.Text = "(" & String.Join(", ", resultadoUnion) & ")"
    End Sub

    Private Sub BtnComp2_Click(sender As Object, e As EventArgs) Handles BtnComp2.Click

        GuardarElementos(listaA, listaB)

        Dim conjuntoA As New HashSet(Of Integer)(listaA)
        Dim conjuntoB As New HashSet(Of Integer)(listaB)

        Dim resultadoComplemento As New List(Of Integer)

        If conjuntoSeleccionado = "A" Then
            conjuntoB.ExceptWith(conjuntoA)
            resultadoComplemento = conjuntoB.ToList()

        ElseIf conjuntoSeleccionado = "B" Then
            conjuntoA.ExceptWith(conjuntoB)
            resultadoComplemento = conjuntoA.ToList()

        Else String.IsNullOrEmpty(conjuntoSeleccionado)
            MessageBox.Show("Por favor, selecciona un conjunto (A o B) antes de calcular la diferencia.")
            Return
        End If


        Debug.WriteLine(resultadoComplemento)

        ' Muestra el resultado en ConjuntoResult
        ConjuntoResult2.Text = "(" & String.Join(", ", resultadoComplemento) & ")"

    End Sub

    Private Sub BtnInter2_Click(sender As Object, e As EventArgs) Handles BtnInter2.Click

        GuardarElementos(listaA, listaB)

        ' Crea conjuntos HashSet para eliminar elementos duplicados
        Dim conjuntoA As New HashSet(Of Integer)(listaA)
        Dim conjuntoB As New HashSet(Of Integer)(listaB)

        ' Calcula la intersección entre A y B
        conjuntoA.IntersectWith(conjuntoB)

        ' Convierte el conjunto de nuevo a una lista
        Dim resultadoInterseccion As List(Of Integer) = conjuntoA.ToList()

        ' Muestra el resultado en ConjuntoResult
        ConjuntoResult2.Text = "(" & String.Join(", ", resultadoInterseccion) & ")"
    End Sub

    Private Sub BtnDifS2_Click(sender As Object, e As EventArgs) Handles BtnDifS2.Click

        GuardarElementos(listaA, listaB)

        ' Crea conjuntos HashSet para eliminar elementos duplicados
        Dim conjuntoA As New HashSet(Of Integer)(listaA)
        Dim conjuntoB As New HashSet(Of Integer)(listaB)

        ' Calcula la diferencia simétrica entre A y B
        conjuntoA.SymmetricExceptWith(conjuntoB)

        ' Convierte el conjunto de nuevo a una lista
        Dim resultadoDiferenciaSimetrica As List(Of Integer) = conjuntoA.ToList()

        ' Muestra el resultado en ConjuntoResult
        ConjuntoResult2.Text = "(" & String.Join(", ", resultadoDiferenciaSimetrica) & ")"

    End Sub

    Private Sub BtnDifN2_Click(sender As Object, e As EventArgs) Handles BtnDifN2.Click

        GuardarElementos(listaA, listaB)

        ' Crea conjuntos HashSet para eliminar elementos duplicados
        Dim conjuntoA As New HashSet(Of Integer)(listaA)
        Dim conjuntoB As New HashSet(Of Integer)(listaB)

        Dim resultadoDiferenciaNumerica As New List(Of Integer)

        If conjuntoSeleccionado = "A" Then
            conjuntoA.ExceptWith(conjuntoB)
            resultadoDiferenciaNumerica = conjuntoA.ToList()

        ElseIf conjuntoSeleccionado = "B" Then
            conjuntoB.ExceptWith(conjuntoA)
            resultadoDiferenciaNumerica = conjuntoB.ToList()

        Else String.IsNullOrEmpty(conjuntoSeleccionado)
            MessageBox.Show("Por favor, selecciona un conjunto (A o B) antes de calcular la diferencia.")
            Return
        End If

        ' Muestra el resultado en ConjuntoResult
        ConjuntoResult2.Text = "(" & String.Join(", ", resultadoDiferenciaNumerica) & ")"
    End Sub

    Private Sub Principal2A_CheckedChanged(sender As Object, e As EventArgs) Handles Principal2A.CheckedChanged
        If Principal2A.Checked Then
            conjuntoSeleccionado = "A"
        End If
    End Sub

    Private Sub Principal2B_CheckedChanged(sender As Object, e As EventArgs) Handles Principal2B.CheckedChanged
        If Principal2B.Checked Then
            conjuntoSeleccionado = "B"
        End If
    End Sub
End Class
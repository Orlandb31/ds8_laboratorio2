Module Modproblema3
    Dim ventas(), ventas2() As Integer
    Dim rango As String

    Public Sub Cargar_Vector(ByVal tamaño As Integer)
        ReDim ventas(tamaño)
        For i = 0 To tamaño - 1

            rango = InputBox("Digite la venta")
            If rango = String.Empty Then
                MessageBox.Show("No indroduzca un valor numerico")
                Return
            End If
            If (rango >= 50 And rango <= 286) Then
                ventas(i) = rango
            Else
                MessageBox.Show("Solo se aceptan valores mayores que 50 y menores que 286")
                i = i - 1
                Return
            End If
        Next
    End Sub

    Public Function Ordenar(ByVal tamaño As Integer)
        Dim temp As Integer
        For i = 0 To tamaño
            For j = i + 1 To tamaño
                If ventas(i) > ventas(j) Then

                    temp = ventas(i)
                    ventas(i) = ventas(j)
                    ventas(j) = temp


                End If
            Next
        Next
        Return ventas
    End Function

End Module

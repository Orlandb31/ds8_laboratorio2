Module Modproblema2
    Dim edad(0), tip(0) As Integer
    Public Sub Cargar_Matriz(ByVal edd As Integer, ByVal ti As Integer)
        Dim ind1, indi2 As Integer
        ind1 = edad.Length
        ReDim edad(ind1 + 1)
        edad(ind1 + 1) = edd
        indi2 = tip.Length
        ReDim tip(indi2 + 1)
        tip(indi2 + 1) = ti
    End Sub
    Public Function Total_clientes_mayores60() As Integer
        Dim i As Integer
        Dim v As Integer
        v = 0
        For i = 0 To edad.Length - 1
            If edad(i) >= 60 Then
                v += 1
            End If
        Next
        Return v
    End Function
    Public Function Total_clientes_mayores25() As Integer
        Dim v As Integer
        Dim i As Integer
        v = 0
        For i = 0 To edad.Length - 1
            If edad(i) >= 25 Then
                v += 1
            End If
        Next
        Return v
    End Function
    Public Function Total_clientes_menores25() As Integer
        Dim i As Integer
        Dim v As Integer
        v = 0
        For i = 0 To edad.Length - 1
            If edad(i) < 25 Then
                v += 1
            End If
        Next
        Return v
    End Function
    Public Function Total_clientes() As Integer
        Dim i As Integer
        Dim v As Integer
        v = 0
        For i = 0 To edad.Length - 1
            v += 1
        Next
        Return v
    End Function
    Public Function Total_clientes_porcentajeT1() As Double
        Dim i, c, t As Integer
        Dim v As Double
        c = 0
        t = 0
        For i = 0 To tip.Length - 1
            If tip(i) = 1 Then
                c += 1
            End If
            t += 1
        Next
        v = c * t / 100
        Return v
    End Function
    Public Function Total_clientes_porcentajeT2() As Double
        Dim i, c, t As Integer
        Dim v As Double
        c = 0
        t = 0
        For i = 0 To tip.Length - 1
            If tip(i) = 2 Then
                c += 1
            End If
            t += 1
        Next
        v = c * t / 100
        Return v
    End Function
    Public Function Total_clientes_porcentajeT3() As Double
        Dim i, c, t As Integer
        Dim v As Double
        c = 0
        t = 0
        For i = 0 To tip.Length - 1
            If tip(i) = 3 Then
                c += 1
            End If
            t += 1
        Next
        v = c * t / 100
        Return v
    End Function
End Module

Module Modproblema2
    Dim edad(0) As Integer
    Dim tipos(0) As Integer
    Public Sub Cargar_Edad(ByVal edd As Integer)
        Dim ind1 As Integer
        ind1 = edad.Length()
        If ind1 = 1 Then
            edad(ind1 - 1) = edd
            ReDim Preserve edad(ind1)
        ElseIf ind1 > 1 Then
            edad(ind1 - 1) = edd
            ReDim Preserve edad(ind1)
        End If
    End Sub
    Public Sub Cargar_tipos(ByRef ti As Integer)
        Dim indi2 As Integer
        indi2 = tipos.Length()
        If indi2 = 1 Then
            tipos(indi2 - 1) = ti
            ReDim Preserve tipos(indi2)
        ElseIf indi2 <> 1 Then
            tipos(indi2 - 1) = ti
            ReDim Preserve tipos(indi2)
        End If
    End Sub
    Public Function Total_clientes_mayores60() As Integer
        Dim i, iin As Integer
        Dim v As Integer
        v = 0
        iin = edad.Length()
        If edad(iin - 1) = 0 Then
            For i = 0 To iin - 2
                If edad(i) >= 60 Then
                    v += 1
                End If
            Next
        Else
            For i = 0 To iin - 1
                If edad(i) >= 60 Then
                    v += 1
                End If
            Next
        End If
        Return v
    End Function
    Public Function Total_clientes_mayores25() As Integer
        Dim i, iin As Integer
        Dim v As Integer
        v = 0
        iin = edad.Length()
        If edad(iin - 1) = 0 Then
            For i = 0 To iin - 2
                If edad(i) >= 25 And edad(i) < 60 Then
                    v += 1
                End If
            Next
        Else
            For i = 0 To iin - 1
                If edad(i) >= 25 And edad(i) < 60 Then
                    v += 1
                End If
            Next
        End If
        Return v
    End Function
    Public Function Total_clientes_menores25() As Integer
        Dim i, iin As Integer
        Dim v As Integer
        v = 0
        iin = edad.Length()
        If edad(iin - 1) = 0 Then
            For i = 0 To iin - 2
                If edad(i) < 25 Then
                    v += 1
                End If
            Next
        Else
            For i = 0 To iin - 1
                If edad(i) < 25 Then
                    v += 1
                End If
            Next
        End If
        Return v
    End Function
    Public Function Total_clientes() As Integer
        Dim i, iin As Integer
        Dim v As Integer
        v = 0
        iin = edad.Length()
        If edad(iin - 1) = 0 Then
            For i = 0 To iin - 2
                v += 1
            Next
        Else
            For i = 0 To iin - 1
                v += 1
            Next
        End If
        Return v
    End Function
    Public Function Total_clientes_porcentajeT1() As Double
        Dim i, c, t As Integer
        Dim v As Double
        c = 0
        t = tipos.Length() - 1
        For i = 0 To tipos.Length() - 1
            If tipos(i) = 1 Then
                c += 1
            End If
        Next
        v = (c * 100) / t
        Return v
    End Function
    Public Function Total_clientes_porcentajeT2() As Double
        Dim i, c, t As Integer
        Dim v As Double
        c = 0
        t = tipos.Length() - 1
        For i = 0 To tipos.Length() - 1
            If tipos(i) = 2 Then
                c += 1
            End If
        Next
        v = (c * 100) / t
        Return v
    End Function
    Public Function Total_clientes_porcentajeT3() As Double
        Dim i, c, t As Integer
        Dim v As Double
        c = 0
        t = tipos.Length() - 1
        For i = 0 To tipos.Length() - 1
            If tipos(i) = 3 Then
                c += 1
            End If
        Next
        v = (c * 100) / t
        Return v
    End Function
End Module

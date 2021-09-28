Public Class Problema1
    Public Function validaretiro(ByVal vmonto As Integer, ByVal vretiro As Integer)
        If vretiro > vmonto Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Retiro(ByVal vmonto As Integer, ByVal vretiro As Integer)

        Dim montoretiro As Integer
        montoretiro = vmonto - vretiro
        Return montoretiro

    End Function

    Public Function Deposito(ByVal vmonto As Integer, ByVal vdeposito As Integer)
        Dim montodeposito As Integer
        montodeposito = vmonto + vdeposito
        Return montodeposito
    End Function



End Class

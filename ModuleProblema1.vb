Imports System.Text.RegularExpressions

Module ModuleProblema1

    Public Function validarCampos(ByVal cliente)
        If Not Regex.Match(cliente, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            Return True
        Else
            Return False

        End If
    End Function
End Module

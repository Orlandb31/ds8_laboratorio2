Module numerodecimal

    Public Sub NumyDecimal(ByVal txtdim As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar)) AndAlso
                (Not e.KeyChar = "." Or txtdim.Text.Contains(".")) Then
            e.Handled = True

        End If

    End Sub
End Module

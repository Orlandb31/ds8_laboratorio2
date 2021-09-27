Imports System.ComponentModel

Public Class frmarreglo
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim tamaño, auxiliar() As Integer
        tamaño = Val(txtboxtamaño.Text)
        ReDim auxiliar(tamaño)
        If tamaño > 0 Then
            Cargar_Vector(tamaño)
            dgvmostrar.RowCount = tamaño
            For Each i In Ordenar(tamaño)
                dgvmostrar.Rows.Add(i)

            Next
        End If
    End Sub

    Private Sub txtboxtamaño_TextChanged(sender As Object, e As EventArgs) Handles txtboxtamaño.TextChanged

    End Sub

    Private Sub txtboxtamaño_Validating(sender As Object, e As CancelEventArgs) Handles txtboxtamaño.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errormensaje.SetError(sender, "")
        Else
            Me.errormensaje.SetError(sender, "Valor en blanco")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtboxtamaño.Text = ""
        dgvmostrar.Rows.Clear()
    End Sub

    Private Sub txtboxtamaño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxtamaño.KeyPress
        NumyDecimal(txtboxtamaño, e)
    End Sub

    Private Sub frmarreglo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
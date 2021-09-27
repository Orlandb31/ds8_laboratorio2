Imports System.ComponentModel

Public Class frmmatrices
    Private Sub txtdim_TextChanged(sender As Object, e As EventArgs) Handles txtdim.TextChanged

    End Sub

    Private Sub txtdim_Validating(sender As Object, e As CancelEventArgs) Handles txtdim.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errordim.SetError(sender, "")
        Else
            Me.errordim.SetError(sender, "Valor en blanco")
        End If
    End Sub

    Private Sub txtdim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdim.KeyPress
        NumyDecimal(txtdim, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnejecutar.Click
        Dim tamaño, principal(,), secundaria(,), fila, columna As Integer
        tamaño = Val(txtdim.Text)
        ReDim principal(tamaño, tamaño)
        ReDim secundaria(tamaño, tamaño)
        fila = Val(txtdim.Text)
        columna = Val(txtdim.Text)
        If (tamaño > 0) Then
            dgvprincipal.RowCount = fila
            dgvprincipal.ColumnCount = columna
            dgvsecundaria.RowCount = fila
            dgvsecundaria.ColumnCount = columna

            For i = 0 To columna - 1
                For j = 0 To fila - 1
                    If i = j Then
                        dgvprincipal.Rows(i).Cells(j).Value = 15
                    ElseIf (i + j = tamaño - 1) Then
                        dgvsecundaria.Rows(i).Cells(j).Value = 28
                        End If
                Next
            Next

        Else
            lblmensaje.Text = "Error-Valores Mayores a 0"


        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtdim.Text = " "
        dgvprincipal.Columns.Clear()
        dgvprincipal.Rows.Clear()
        dgvsecundaria.Columns.Clear()
        dgvsecundaria.Rows.Clear()

    End Sub

    Private Sub frmmatrices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
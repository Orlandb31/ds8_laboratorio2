Public Class frmregistrar
    Private Sub btnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
        Label17.Show()
        txtTotal25.Show()
        txtTotal60.Show()
        txtTotalC.Show()
        txtTotalm25.Show()
        txtP1.Show()
        txtP2.Show()
        txtP3.Show()

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre, tipo, telefono, sexo As String
        Dim edad, dias, tp As Integer
        nombre = txtNombre.Text()
        tipo = cboTratamiento.SelectedItem.ToString()
        If "Tratamiento Básico" = tipo Then
            tp = 1
        ElseIf "Tratamiento Intermedio" = tipo Then
            tp = 2
        ElseIf "Tratamiento Premium" = tipo Then
            tp = 3
        End If
        telefono = txtTelefono.Text()
        If rbtSexoF.Checked() = True Then
            sexo = "F"
        ElseIf rbtSexoM.Checked() = True Then
            sexo = "M"
        Else
            MsgBox("Debe elegir un sexo")
        End If
        edad = Val(txtEdad.Text)
        dias = DateDiff("d", dtpFechaI, dtpFechaS)
        If dias >= 5 Then
            MsgBox("El cliente spa tiene derecho a un día de tratamiento gratis en 
            cualquiera de los
            otros tipos de tratamiento de menor costo. ")
        End If
        Cargar_Matriz(edad, tp)
        txtNombre.Clear()
        txtEdad.Clear()
        txtTelefono.Clear()
        dtpFechaI.ResetText()
        dtpFechaS.ResetText()
        cboTratamiento.ResetText()
    End Sub

    Private Sub frmregistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        Label17.Hide()
        txtTotal25.Hide()
        txtTotal60.Hide()
        txtTotalC.Hide()
        txtTotalm25.Hide()
        txtP1.Hide()
        txtP2.Hide()
        txtP3.Hide()
    End Sub
End Class
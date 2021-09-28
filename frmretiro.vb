
Imports System.ComponentModel

Public Class frmretiro
    Dim calculo As New Problema1
    Dim saldo As Double


    Private Sub txt_validar_cliente(sender As Object, e As CancelEventArgs) Handles txt_cliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.error_cliente.SetError(sender, "")
        Else
            Me.error_cliente.SetError(sender, "Valor en blanco")
        End If
    End Sub

    Private Sub txt_validar_monto(sender As Object, e As CancelEventArgs) Handles txt_montoInicial.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.error_monto.SetError(sender, "")
        Else
            Me.error_monto.SetError(sender, "Valor en blanco")
        End If
    End Sub


    Private Sub frmretiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' btn_nuevo.Enabled = False
        gbox_cuenta.Visible = False
        gbox_transaccion.Visible = False
    End Sub

    Private Sub btn_abrirCuenta_Click(sender As Object, e As EventArgs) Handles btn_abrirCuenta.Click
        Try

            If validarCampos(txt_cliente.Text()) Then
                MsgBox("Por Favor instruzca valores alfabeticos")

            ElseIf txt_cliente.Text = String.Empty Or txt_montoInicial.Text = String.Empty Then
                MsgBox("Por Favor llenar los campos ")
                Return
            ElseIf IsNumeric(txt_montoInicial.Text) = False Then
                MsgBox("Intruzca un valor numerico")
            Else
                btn_abrirCuenta.Enabled = False
                gbox_cuenta.Visible = True
                gbox_transaccion.Visible = True
                saldo = txt_montoInicial.Text()
            End If

        Catch ex As Exception
            Console.WriteLine(ex)

        End Try

    End Sub


    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            btn_abrirCuenta.Enabled = True
            saldo = 0
            txt_saldo.Text = ""
            txt_montoInicial.Text() = ""
            txt_cliente.Text() = ""
            gbox_cuenta.Visible = False
            gbox_transaccion.Visible = False
            lbox_retiro.Items.Clear()
            lbox_depositos.Items.Clear()

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Try
            If rb_deposito.Checked Then
                Dim boxdeposito As Double

                boxdeposito = InputBox("ingrese la cantidad a depositar")
                'chk_deposito.Checked = False
                saldo = calculo.Deposito(saldo, boxdeposito)
                txt_saldo.Text() = saldo
                lbox_depositos.Items.Add(boxdeposito)
            ElseIf rb_retiro.Checked Then
                Dim boxretiro As Double
                boxretiro = InputBox("ingrese la cantidad retirar")
                If calculo.validaretiro(saldo, boxretiro) = True Then
                    MsgBox("La cantidad de Retiro no puede ser mayor que el monto de la cuenta")
                    Return
                Else
                    saldo = calculo.Retiro(saldo, boxretiro)
                    txt_saldo.Text = saldo
                    lbox_retiro.Items.Add(boxretiro)
                End If
            End If

        Catch ex As Exception
            Console.WriteLine(ex)

        End Try


    End Sub


End Class
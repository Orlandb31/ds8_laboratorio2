<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmretiro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_montoInicial = New System.Windows.Forms.TextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.btn_abrirCuenta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbox_transaccion = New System.Windows.Forms.GroupBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.rb_retiro = New System.Windows.Forms.RadioButton()
        Me.rb_deposito = New System.Windows.Forms.RadioButton()
        Me.gbox_cuenta = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_saldo = New System.Windows.Forms.TextBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.lbox_depositos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbox_retiro = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.error_cliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.error_monto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gbox_transaccion.SuspendLayout()
        Me.gbox_cuenta.SuspendLayout()
        CType(Me.error_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.error_monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_montoInicial)
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.btn_abrirCuenta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 179)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'txt_montoInicial
        '
        Me.txt_montoInicial.Location = New System.Drawing.Point(92, 86)
        Me.txt_montoInicial.Name = "txt_montoInicial"
        Me.txt_montoInicial.Size = New System.Drawing.Size(100, 20)
        Me.txt_montoInicial.TabIndex = 4
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(92, 39)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_cliente.TabIndex = 3
        '
        'btn_abrirCuenta
        '
        Me.btn_abrirCuenta.Location = New System.Drawing.Point(419, 55)
        Me.btn_abrirCuenta.Name = "btn_abrirCuenta"
        Me.btn_abrirCuenta.Size = New System.Drawing.Size(75, 23)
        Me.btn_abrirCuenta.TabIndex = 2
        Me.btn_abrirCuenta.Text = "Abrir Cuenta"
        Me.btn_abrirCuenta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'gbox_transaccion
        '
        Me.gbox_transaccion.Controls.Add(Me.btn_generar)
        Me.gbox_transaccion.Controls.Add(Me.rb_retiro)
        Me.gbox_transaccion.Controls.Add(Me.rb_deposito)
        Me.gbox_transaccion.Location = New System.Drawing.Point(39, 226)
        Me.gbox_transaccion.Name = "gbox_transaccion"
        Me.gbox_transaccion.Size = New System.Drawing.Size(514, 73)
        Me.gbox_transaccion.TabIndex = 2
        Me.gbox_transaccion.TabStop = False
        Me.gbox_transaccion.Text = "Transacciones"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(406, 24)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 4
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'rb_retiro
        '
        Me.rb_retiro.AutoSize = True
        Me.rb_retiro.Location = New System.Drawing.Point(249, 30)
        Me.rb_retiro.Name = "rb_retiro"
        Me.rb_retiro.Size = New System.Drawing.Size(58, 17)
        Me.rb_retiro.TabIndex = 3
        Me.rb_retiro.TabStop = True
        Me.rb_retiro.Text = "Retiros"
        Me.rb_retiro.UseVisualStyleBackColor = True
        '
        'rb_deposito
        '
        Me.rb_deposito.AutoSize = True
        Me.rb_deposito.Location = New System.Drawing.Point(67, 33)
        Me.rb_deposito.Name = "rb_deposito"
        Me.rb_deposito.Size = New System.Drawing.Size(72, 17)
        Me.rb_deposito.TabIndex = 2
        Me.rb_deposito.TabStop = True
        Me.rb_deposito.Text = "Depósitos"
        Me.rb_deposito.UseVisualStyleBackColor = True
        '
        'gbox_cuenta
        '
        Me.gbox_cuenta.Controls.Add(Me.Label5)
        Me.gbox_cuenta.Controls.Add(Me.txt_saldo)
        Me.gbox_cuenta.Controls.Add(Me.btn_nuevo)
        Me.gbox_cuenta.Controls.Add(Me.lbox_depositos)
        Me.gbox_cuenta.Controls.Add(Me.Label4)
        Me.gbox_cuenta.Controls.Add(Me.lbox_retiro)
        Me.gbox_cuenta.Controls.Add(Me.Label3)
        Me.gbox_cuenta.Location = New System.Drawing.Point(39, 314)
        Me.gbox_cuenta.Name = "gbox_cuenta"
        Me.gbox_cuenta.Size = New System.Drawing.Size(514, 253)
        Me.gbox_cuenta.TabIndex = 3
        Me.gbox_cuenta.TabStop = False
        Me.gbox_cuenta.Text = "Cuenta de Ahorros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Saldo"
        '
        'txt_saldo
        '
        Me.txt_saldo.Location = New System.Drawing.Point(363, 139)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(118, 20)
        Me.txt_saldo.TabIndex = 5
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(363, 182)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(118, 37)
        Me.btn_nuevo.TabIndex = 4
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'lbox_depositos
        '
        Me.lbox_depositos.FormattingEnabled = True
        Me.lbox_depositos.Location = New System.Drawing.Point(175, 56)
        Me.lbox_depositos.Name = "lbox_depositos"
        Me.lbox_depositos.Size = New System.Drawing.Size(132, 173)
        Me.lbox_depositos.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Depositos"
        '
        'lbox_retiro
        '
        Me.lbox_retiro.FormattingEnabled = True
        Me.lbox_retiro.Location = New System.Drawing.Point(22, 56)
        Me.lbox_retiro.Name = "lbox_retiro"
        Me.lbox_retiro.Size = New System.Drawing.Size(132, 173)
        Me.lbox_retiro.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Retiros"
        '
        'error_cliente
        '
        Me.error_cliente.ContainerControl = Me
        '
        'error_monto
        '
        Me.error_monto.ContainerControl = Me
        '
        'frmretiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 590)
        Me.Controls.Add(Me.gbox_cuenta)
        Me.Controls.Add(Me.gbox_transaccion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmretiro"
        Me.Text = "frmretiro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbox_transaccion.ResumeLayout(False)
        Me.gbox_transaccion.PerformLayout()
        Me.gbox_cuenta.ResumeLayout(False)
        Me.gbox_cuenta.PerformLayout()
        CType(Me.error_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.error_monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_montoInicial As TextBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents btn_abrirCuenta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbox_transaccion As GroupBox
    Friend WithEvents gbox_cuenta As GroupBox
    Friend WithEvents lbox_depositos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbox_retiro As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_saldo As TextBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents error_cliente As ErrorProvider
    Friend WithEvents error_monto As ErrorProvider
    Friend WithEvents btn_generar As Button
    Friend WithEvents rb_retiro As RadioButton
    Friend WithEvents rb_deposito As RadioButton
End Class

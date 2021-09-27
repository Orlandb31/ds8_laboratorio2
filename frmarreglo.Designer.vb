<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmarreglo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxtamaño = New System.Windows.Forms.TextBox()
        Me.dgvmostrar = New System.Windows.Forms.DataGridView()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.errormensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvmostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errormensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arreglo de N posiciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tamaño del Arreglo"
        '
        'txtboxtamaño
        '
        Me.txtboxtamaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxtamaño.Location = New System.Drawing.Point(381, 112)
        Me.txtboxtamaño.Name = "txtboxtamaño"
        Me.txtboxtamaño.Size = New System.Drawing.Size(112, 30)
        Me.txtboxtamaño.TabIndex = 2
        '
        'dgvmostrar
        '
        Me.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmostrar.Location = New System.Drawing.Point(176, 191)
        Me.dgvmostrar.Name = "dgvmostrar"
        Me.dgvmostrar.RowHeadersWidth = 51
        Me.dgvmostrar.RowTemplate.Height = 24
        Me.dgvmostrar.Size = New System.Drawing.Size(391, 227)
        Me.dgvmostrar.TabIndex = 3
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.Location = New System.Drawing.Point(214, 471)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(129, 38)
        Me.btnEjecutar.TabIndex = 4
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(420, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'errormensaje
        '
        Me.errormensaje.ContainerControl = Me
        '
        'frmarreglo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 545)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.dgvmostrar)
        Me.Controls.Add(Me.txtboxtamaño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmarreglo"
        Me.Text = "frmarreglo"
        CType(Me.dgvmostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errormensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxtamaño As TextBox
    Friend WithEvents dgvmostrar As DataGridView
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents errormensaje As ErrorProvider
End Class

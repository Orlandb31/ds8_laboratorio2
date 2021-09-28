<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmatrices
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdim = New System.Windows.Forms.TextBox()
        Me.dgvprincipal = New System.Windows.Forms.DataGridView()
        Me.dgvsecundaria = New System.Windows.Forms.DataGridView()
        Me.btnejecutar = New System.Windows.Forms.Button()
        Me.errordim = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.lblmensaje = New System.Windows.Forms.Label()
        CType(Me.dgvprincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvsecundaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errordim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matriz NXN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagonal Principal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(527, 179)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diagonal Secundaria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tamaño de la Matriz"
        '
        'txtdim
        '
        Me.txtdim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdim.Location = New System.Drawing.Point(376, 89)
        Me.txtdim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdim.Name = "txtdim"
        Me.txtdim.Size = New System.Drawing.Size(111, 26)
        Me.txtdim.TabIndex = 4
        '
        'dgvprincipal
        '
        Me.dgvprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprincipal.Location = New System.Drawing.Point(38, 219)
        Me.dgvprincipal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvprincipal.Name = "dgvprincipal"
        Me.dgvprincipal.RowHeadersWidth = 51
        Me.dgvprincipal.RowTemplate.Height = 24
        Me.dgvprincipal.Size = New System.Drawing.Size(328, 278)
        Me.dgvprincipal.TabIndex = 5
        '
        'dgvsecundaria
        '
        Me.dgvsecundaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsecundaria.Location = New System.Drawing.Point(467, 219)
        Me.dgvsecundaria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvsecundaria.Name = "dgvsecundaria"
        Me.dgvsecundaria.RowHeadersWidth = 51
        Me.dgvsecundaria.RowTemplate.Height = 24
        Me.dgvsecundaria.Size = New System.Drawing.Size(323, 278)
        Me.dgvsecundaria.TabIndex = 6
        '
        'btnejecutar
        '
        Me.btnejecutar.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnejecutar.Location = New System.Drawing.Point(369, 532)
        Me.btnejecutar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnejecutar.Name = "btnejecutar"
        Me.btnejecutar.Size = New System.Drawing.Size(105, 33)
        Me.btnejecutar.TabIndex = 7
        Me.btnejecutar.Text = "Ejecutar"
        Me.btnejecutar.UseVisualStyleBackColor = True
        '
        'errordim
        '
        Me.errordim.ContainerControl = Me
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(376, 158)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(93, 29)
        Me.btnlimpiar.TabIndex = 8
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.Font = New System.Drawing.Font("Lucida Sans Typewriter", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.Color.Red
        Me.lblmensaje.Location = New System.Drawing.Point(300, 125)
        Me.lblmensaje.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(0, 18)
        Me.lblmensaje.TabIndex = 9
        '
        'frmmatrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 604)
        Me.Controls.Add(Me.lblmensaje)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnejecutar)
        Me.Controls.Add(Me.dgvsecundaria)
        Me.Controls.Add(Me.dgvprincipal)
        Me.Controls.Add(Me.txtdim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmmatrices"
        Me.Text = "frmmatrices"
        CType(Me.dgvprincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvsecundaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errordim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdim As TextBox
    Friend WithEvents dgvprincipal As DataGridView
    Friend WithEvents dgvsecundaria As DataGridView
    Friend WithEvents btnejecutar As Button
    Friend WithEvents errordim As ErrorProvider
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents lblmensaje As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistrar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInforme = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTratamiento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbtSexoF = New System.Windows.Forms.RadioButton()
        Me.rbtSexoM = New System.Windows.Forms.RadioButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.dtpFechaI = New System.Windows.Forms.DateTimePicker()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaS = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal60 = New System.Windows.Forms.TextBox()
        Me.txtTotalm25 = New System.Windows.Forms.TextBox()
        Me.txtTotal25 = New System.Windows.Forms.TextBox()
        Me.txtTotalC = New System.Windows.Forms.TextBox()
        Me.txtP1 = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.txtP3 = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Problema #2"
        '
        'btnInforme
        '
        Me.btnInforme.Location = New System.Drawing.Point(251, 326)
        Me.btnInforme.Name = "btnInforme"
        Me.btnInforme.Size = New System.Drawing.Size(75, 23)
        Me.btnInforme.TabIndex = 1
        Me.btnInforme.Text = "Informe"
        Me.btnInforme.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Spa EGPH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha de Internacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sexo"
        '
        'cboTratamiento
        '
        Me.cboTratamiento.FormattingEnabled = True
        Me.cboTratamiento.Items.AddRange(New Object() {"Tratamiento Básico", "Tratamiento Intermedio", "Tratamiento Premium"})
        Me.cboTratamiento.Location = New System.Drawing.Point(126, 218)
        Me.cboTratamiento.Name = "cboTratamiento"
        Me.cboTratamiento.Size = New System.Drawing.Size(121, 21)
        Me.cboTratamiento.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tipo de Tratamiento"
        '
        'rbtSexoF
        '
        Me.rbtSexoF.AutoSize = True
        Me.rbtSexoF.Location = New System.Drawing.Point(89, 286)
        Me.rbtSexoF.Name = "rbtSexoF"
        Me.rbtSexoF.Size = New System.Drawing.Size(31, 17)
        Me.rbtSexoF.TabIndex = 10
        Me.rbtSexoF.TabStop = True
        Me.rbtSexoF.Text = "F"
        Me.rbtSexoF.UseVisualStyleBackColor = True
        '
        'rbtSexoM
        '
        Me.rbtSexoM.AutoSize = True
        Me.rbtSexoM.Location = New System.Drawing.Point(140, 286)
        Me.rbtSexoM.Name = "rbtSexoM"
        Me.rbtSexoM.Size = New System.Drawing.Size(34, 17)
        Me.rbtSexoM.TabIndex = 11
        Me.rbtSexoM.TabStop = True
        Me.rbtSexoM.Text = "M"
        Me.rbtSexoM.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(126, 95)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 12
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(126, 129)
        Me.txtEdad.MaxLength = 3
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(48, 20)
        Me.txtEdad.TabIndex = 13
        '
        'dtpFechaI
        '
        Me.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaI.Location = New System.Drawing.Point(126, 164)
        Me.dtpFechaI.Name = "dtpFechaI"
        Me.dtpFechaI.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaI.TabIndex = 14
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(126, 249)
        Me.txtTelefono.MaxLength = 32
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Fecha de Salida"
        '
        'dtpFechaS
        '
        Me.dtpFechaS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaS.Location = New System.Drawing.Point(126, 190)
        Me.dtpFechaS.Name = "dtpFechaS"
        Me.dtpFechaS.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaS.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(341, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total de Clientes Mayores de 60"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(341, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Total de Clientes Mayores de 25"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(341, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(160, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Total de Clientes Menores de 25"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(341, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Total de Clientes"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(341, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(183, 26)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Porcentajes de clientes," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que solicitan cada tipo de tratamiento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(371, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Tipo 1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(371, 306)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Tipo 2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(371, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Tipo 3"
        '
        'txtTotal60
        '
        Me.txtTotal60.Location = New System.Drawing.Point(516, 95)
        Me.txtTotal60.Name = "txtTotal60"
        Me.txtTotal60.ReadOnly = True
        Me.txtTotal60.Size = New System.Drawing.Size(72, 20)
        Me.txtTotal60.TabIndex = 26
        '
        'txtTotalm25
        '
        Me.txtTotalm25.Location = New System.Drawing.Point(516, 129)
        Me.txtTotalm25.Name = "txtTotalm25"
        Me.txtTotalm25.ReadOnly = True
        Me.txtTotalm25.Size = New System.Drawing.Size(72, 20)
        Me.txtTotalm25.TabIndex = 27
        '
        'txtTotal25
        '
        Me.txtTotal25.Location = New System.Drawing.Point(516, 161)
        Me.txtTotal25.Name = "txtTotal25"
        Me.txtTotal25.ReadOnly = True
        Me.txtTotal25.Size = New System.Drawing.Size(72, 20)
        Me.txtTotal25.TabIndex = 28
        '
        'txtTotalC
        '
        Me.txtTotalC.Location = New System.Drawing.Point(516, 194)
        Me.txtTotalC.Name = "txtTotalC"
        Me.txtTotalC.ReadOnly = True
        Me.txtTotalC.Size = New System.Drawing.Size(72, 20)
        Me.txtTotalC.TabIndex = 29
        '
        'txtP1
        '
        Me.txtP1.Location = New System.Drawing.Point(429, 271)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.ReadOnly = True
        Me.txtP1.Size = New System.Drawing.Size(72, 20)
        Me.txtP1.TabIndex = 30
        '
        'txtP2
        '
        Me.txtP2.Location = New System.Drawing.Point(429, 303)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.ReadOnly = True
        Me.txtP2.Size = New System.Drawing.Size(72, 20)
        Me.txtP2.TabIndex = 31
        '
        'txtP3
        '
        Me.txtP3.Location = New System.Drawing.Point(429, 333)
        Me.txtP3.Name = "txtP3"
        Me.txtP3.ReadOnly = True
        Me.txtP3.Size = New System.Drawing.Size(72, 20)
        Me.txtP3.TabIndex = 32
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(126, 326)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 33
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmregistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtP3)
        Me.Controls.Add(Me.txtP2)
        Me.Controls.Add(Me.txtP1)
        Me.Controls.Add(Me.txtTotalC)
        Me.Controls.Add(Me.txtTotal25)
        Me.Controls.Add(Me.txtTotalm25)
        Me.Controls.Add(Me.txtTotal60)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFechaS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.dtpFechaI)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.rbtSexoM)
        Me.Controls.Add(Me.rbtSexoF)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboTratamiento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInforme)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmregistrar"
        Me.Text = "frmregistrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnInforme As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboTratamiento As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rbtSexoF As RadioButton
    Friend WithEvents rbtSexoM As RadioButton
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents dtpFechaI As DateTimePicker
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaS As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTotal60 As TextBox
    Friend WithEvents txtTotalm25 As TextBox
    Friend WithEvents txtTotal25 As TextBox
    Friend WithEvents txtTotalC As TextBox
    Friend WithEvents txtP1 As TextBox
    Friend WithEvents txtP2 As TextBox
    Friend WithEvents txtP3 As TextBox
    Friend WithEvents btnAgregar As Button
End Class

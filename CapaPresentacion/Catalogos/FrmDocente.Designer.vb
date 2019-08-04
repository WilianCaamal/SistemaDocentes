<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDocente
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCp = New System.Windows.Forms.TextBox()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.CboCiudad = New System.Windows.Forms.ComboBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.DtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.CboGenero = New System.Windows.Forms.ComboBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtIdiomas = New System.Windows.Forms.TextBox()
        Me.DtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CboGrado = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CboArea = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtPostgrado = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtPerfil = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPlaza = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.TxtCp)
        Me.GroupBox1.Controls.Add(Me.CboEstado)
        Me.GroupBox1.Controls.Add(Me.CboCiudad)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtCurp)
        Me.GroupBox1.Controls.Add(Me.DtFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.CboGenero)
        Me.GroupBox1.Controls.Add(Me.TxtApellidos)
        Me.GroupBox1.Controls.Add(Me.TxtNombres)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 191)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(571, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Examinar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(578, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Fotografía"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(556, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(328, 130)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(200, 20)
        Me.TxtEmail.TabIndex = 21
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(328, 104)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefono.TabIndex = 20
        '
        'TxtCp
        '
        Me.TxtCp.Location = New System.Drawing.Point(328, 78)
        Me.TxtCp.MaxLength = 5
        Me.TxtCp.Name = "TxtCp"
        Me.TxtCp.Size = New System.Drawing.Size(200, 20)
        Me.TxtCp.TabIndex = 19
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(328, 24)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(200, 21)
        Me.CboEstado.TabIndex = 17
        '
        'CboCiudad
        '
        Me.CboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCiudad.FormattingEnabled = True
        Me.CboCiudad.Location = New System.Drawing.Point(328, 51)
        Me.CboCiudad.Name = "CboCiudad"
        Me.CboCiudad.Size = New System.Drawing.Size(200, 21)
        Me.CboCiudad.TabIndex = 18
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(64, 104)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(200, 20)
        Me.TxtDireccion.TabIndex = 14
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(64, 156)
        Me.TxtCurp.MaxLength = 18
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(200, 20)
        Me.TxtCurp.TabIndex = 16
        '
        'DtFechaNacimiento
        '
        Me.DtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaNacimiento.Location = New System.Drawing.Point(120, 130)
        Me.DtFechaNacimiento.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.DtFechaNacimiento.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DtFechaNacimiento.Name = "DtFechaNacimiento"
        Me.DtFechaNacimiento.Size = New System.Drawing.Size(144, 20)
        Me.DtFechaNacimiento.TabIndex = 15
        '
        'CboGenero
        '
        Me.CboGenero.DisplayMember = "1"
        Me.CboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGenero.FormattingEnabled = True
        Me.CboGenero.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.CboGenero.Location = New System.Drawing.Point(64, 78)
        Me.CboGenero.Name = "CboGenero"
        Me.CboGenero.Size = New System.Drawing.Size(200, 21)
        Me.CboGenero.TabIndex = 13
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(64, 52)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(200, 20)
        Me.TxtApellidos.TabIndex = 12
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(64, 23)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(200, 20)
        Me.TxtNombres.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(270, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "E-mail:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(270, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Teléfono:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(270, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "CP:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(270, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Estado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(270, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Dirección:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CURP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha de Nacimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Género:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Apellidos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombres:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtIdiomas)
        Me.GroupBox2.Controls.Add(Me.DtFechaIngreso)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.CboGrado)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.CboArea)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TxtPostgrado)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TxtPerfil)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtPlaza)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 130)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos academicos"
        '
        'TxtIdiomas
        '
        Me.TxtIdiomas.Location = New System.Drawing.Point(435, 74)
        Me.TxtIdiomas.Name = "TxtIdiomas"
        Me.TxtIdiomas.Size = New System.Drawing.Size(246, 20)
        Me.TxtIdiomas.TabIndex = 27
        '
        'DtFechaIngreso
        '
        Me.DtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIngreso.Location = New System.Drawing.Point(104, 45)
        Me.DtFechaIngreso.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.DtFechaIngreso.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DtFechaIngreso.Name = "DtFechaIngreso"
        Me.DtFechaIngreso.Size = New System.Drawing.Size(209, 20)
        Me.DtFechaIngreso.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(325, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Idiomas que domina:"
        '
        'CboGrado
        '
        Me.CboGrado.FormattingEnabled = True
        Me.CboGrado.Location = New System.Drawing.Point(435, 46)
        Me.CboGrado.Name = "CboGrado"
        Me.CboGrado.Size = New System.Drawing.Size(246, 21)
        Me.CboGrado.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(325, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Grado academico:"
        '
        'CboArea
        '
        Me.CboArea.FormattingEnabled = True
        Me.CboArea.Location = New System.Drawing.Point(435, 19)
        Me.CboArea.Name = "CboArea"
        Me.CboArea.Size = New System.Drawing.Size(246, 21)
        Me.CboArea.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(325, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Área:"
        '
        'TxtPostgrado
        '
        Me.TxtPostgrado.Location = New System.Drawing.Point(104, 97)
        Me.TxtPostgrado.Name = "TxtPostgrado"
        Me.TxtPostgrado.Size = New System.Drawing.Size(209, 20)
        Me.TxtPostgrado.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Perfil Postgrado:"
        '
        'TxtPerfil
        '
        Me.TxtPerfil.Location = New System.Drawing.Point(104, 71)
        Me.TxtPerfil.Name = "TxtPerfil"
        Me.TxtPerfil.Size = New System.Drawing.Size(209, 20)
        Me.TxtPerfil.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Perfil:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Fecha de ingreso:"
        '
        'TxtPlaza
        '
        Me.TxtPlaza.Location = New System.Drawing.Point(104, 19)
        Me.TxtPlaza.Name = "TxtPlaza"
        Me.TxtPlaza.Size = New System.Drawing.Size(209, 20)
        Me.TxtPlaza.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Tag = ""
        Me.Label14.Text = "Clave(plaza):"
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.cancel_24px
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(635, 393)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 30)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "     Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.delete_24px
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(377, 393)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(80, 30)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.edit_24px
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(549, 393)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(80, 30)
        Me.BtnEditar.TabIndex = 5
        Me.BtnEditar.Text = "     Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.save_24px
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(463, 393)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(80, 30)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.CapaPresentacion.My.Resources.ResourceImages48px.businessman_48px
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Docente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(727, 435)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDocente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario docente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCp As TextBox
    Friend WithEvents CboEstado As ComboBox
    Friend WithEvents CboCiudad As ComboBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents DtFechaNacimiento As DateTimePicker
    Friend WithEvents CboGenero As ComboBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdiomas As TextBox
    Friend WithEvents DtFechaIngreso As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents CboGrado As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents CboArea As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtPostgrado As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtPerfil As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPlaza As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
End Class

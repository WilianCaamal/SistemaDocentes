<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFormacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdiomas = New System.Windows.Forms.TextBox()
        Me.TxtGrado = New System.Windows.Forms.TextBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtPerfil = New System.Windows.Forms.TextBox()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.TxtPlaza = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombreDocente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DgvEstudios = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminarEstudios = New System.Windows.Forms.Button()
        Me.BtnAgregarEstudios = New System.Windows.Forms.Button()
        Me.TxtTiempoDocente = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionDocente = New System.Windows.Forms.TextBox()
        Me.TxtExpDocente = New System.Windows.Forms.TextBox()
        Me.TxtTiempoProfesional = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionProfesional = New System.Windows.Forms.TextBox()
        Me.TxtExpProfesional = New System.Windows.Forms.TextBox()
        Me.DtFechaEstudio = New System.Windows.Forms.DateTimePicker()
        Me.TxtEstudio = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvCursos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminarCurso = New System.Windows.Forms.Button()
        Me.DtFechaCurso = New System.Windows.Forms.DateTimePicker()
        Me.BtnAgregarCurso = New System.Windows.Forms.Button()
        Me.TxtTiempoCurso = New System.Windows.Forms.TextBox()
        Me.TxtInstitucion = New System.Windows.Forms.TextBox()
        Me.TxtCurso = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtIdiomas)
        Me.GroupBox1.Controls.Add(Me.TxtGrado)
        Me.GroupBox1.Controls.Add(Me.TxtCurp)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtPerfil)
        Me.GroupBox1.Controls.Add(Me.TxtArea)
        Me.GroupBox1.Controls.Add(Me.TxtPlaza)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNombreDocente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos el docente"
        '
        'TxtIdiomas
        '
        Me.TxtIdiomas.Location = New System.Drawing.Point(715, 91)
        Me.TxtIdiomas.Name = "TxtIdiomas"
        Me.TxtIdiomas.Size = New System.Drawing.Size(201, 20)
        Me.TxtIdiomas.TabIndex = 15
        '
        'TxtGrado
        '
        Me.TxtGrado.Location = New System.Drawing.Point(508, 91)
        Me.TxtGrado.Name = "TxtGrado"
        Me.TxtGrado.Size = New System.Drawing.Size(201, 20)
        Me.TxtGrado.TabIndex = 14
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(336, 91)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(166, 20)
        Me.TxtCurp.TabIndex = 13
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(11, 91)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(319, 20)
        Me.TxtDireccion.TabIndex = 12
        '
        'TxtPerfil
        '
        Me.TxtPerfil.Location = New System.Drawing.Point(715, 42)
        Me.TxtPerfil.Name = "TxtPerfil"
        Me.TxtPerfil.Size = New System.Drawing.Size(201, 20)
        Me.TxtPerfil.TabIndex = 11
        '
        'TxtArea
        '
        Me.TxtArea.Location = New System.Drawing.Point(508, 42)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(201, 20)
        Me.TxtArea.TabIndex = 10
        '
        'TxtPlaza
        '
        Me.TxtPlaza.Location = New System.Drawing.Point(336, 42)
        Me.TxtPlaza.Name = "TxtPlaza"
        Me.TxtPlaza.Size = New System.Drawing.Size(166, 20)
        Me.TxtPlaza.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(505, 70)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Grado académico:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(505, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Área:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(333, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CURP:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(712, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Idiomas que domina:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(712, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Perfil:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clave de plaza:"
        '
        'TxtNombreDocente
        '
        Me.TxtNombreDocente.Location = New System.Drawing.Point(11, 42)
        Me.TxtNombreDocente.Name = "TxtNombreDocente"
        Me.TxtNombreDocente.Size = New System.Drawing.Size(319, 20)
        Me.TxtNombreDocente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 203)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(920, 396)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvEstudios)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(912, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudios Realizados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DgvEstudios
        '
        Me.DgvEstudios.AllowUserToAddRows = False
        Me.DgvEstudios.AllowUserToDeleteRows = False
        Me.DgvEstudios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEstudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstudios.Location = New System.Drawing.Point(6, 176)
        Me.DgvEstudios.MultiSelect = False
        Me.DgvEstudios.Name = "DgvEstudios"
        Me.DgvEstudios.ReadOnly = True
        Me.DgvEstudios.RowHeadersVisible = False
        Me.DgvEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEstudios.Size = New System.Drawing.Size(900, 188)
        Me.DgvEstudios.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BtnEliminarEstudios)
        Me.GroupBox2.Controls.Add(Me.BtnAgregarEstudios)
        Me.GroupBox2.Controls.Add(Me.TxtTiempoDocente)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcionDocente)
        Me.GroupBox2.Controls.Add(Me.TxtExpDocente)
        Me.GroupBox2.Controls.Add(Me.TxtTiempoProfesional)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcionProfesional)
        Me.GroupBox2.Controls.Add(Me.TxtExpProfesional)
        Me.GroupBox2.Controls.Add(Me.DtFechaEstudio)
        Me.GroupBox2.Controls.Add(Me.TxtEstudio)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(900, 164)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'BtnEliminarEstudios
        '
        Me.BtnEliminarEstudios.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.delete_24px
        Me.BtnEliminarEstudios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarEstudios.Location = New System.Drawing.Point(812, 31)
        Me.BtnEliminarEstudios.Name = "BtnEliminarEstudios"
        Me.BtnEliminarEstudios.Size = New System.Drawing.Size(80, 30)
        Me.BtnEliminarEstudios.TabIndex = 20
        Me.BtnEliminarEstudios.Text = "Eliminar"
        Me.BtnEliminarEstudios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarEstudios.UseVisualStyleBackColor = True
        '
        'BtnAgregarEstudios
        '
        Me.BtnAgregarEstudios.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.save_24px
        Me.BtnAgregarEstudios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarEstudios.Location = New System.Drawing.Point(726, 31)
        Me.BtnAgregarEstudios.Name = "BtnAgregarEstudios"
        Me.BtnAgregarEstudios.Size = New System.Drawing.Size(80, 30)
        Me.BtnAgregarEstudios.TabIndex = 19
        Me.BtnAgregarEstudios.Text = "Guardar"
        Me.BtnAgregarEstudios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarEstudios.UseVisualStyleBackColor = True
        '
        'TxtTiempoDocente
        '
        Me.TxtTiempoDocente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTiempoDocente.Location = New System.Drawing.Point(726, 138)
        Me.TxtTiempoDocente.MaxLength = 20
        Me.TxtTiempoDocente.Name = "TxtTiempoDocente"
        Me.TxtTiempoDocente.Size = New System.Drawing.Size(164, 20)
        Me.TxtTiempoDocente.TabIndex = 16
        '
        'TxtDescripcionDocente
        '
        Me.TxtDescripcionDocente.Location = New System.Drawing.Point(382, 138)
        Me.TxtDescripcionDocente.Name = "TxtDescripcionDocente"
        Me.TxtDescripcionDocente.Size = New System.Drawing.Size(317, 20)
        Me.TxtDescripcionDocente.TabIndex = 15
        '
        'TxtExpDocente
        '
        Me.TxtExpDocente.Location = New System.Drawing.Point(11, 138)
        Me.TxtExpDocente.Name = "TxtExpDocente"
        Me.TxtExpDocente.Size = New System.Drawing.Size(352, 20)
        Me.TxtExpDocente.TabIndex = 14
        '
        'TxtTiempoProfesional
        '
        Me.TxtTiempoProfesional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTiempoProfesional.Location = New System.Drawing.Point(726, 93)
        Me.TxtTiempoProfesional.MaxLength = 20
        Me.TxtTiempoProfesional.Name = "TxtTiempoProfesional"
        Me.TxtTiempoProfesional.Size = New System.Drawing.Size(164, 20)
        Me.TxtTiempoProfesional.TabIndex = 13
        '
        'TxtDescripcionProfesional
        '
        Me.TxtDescripcionProfesional.Location = New System.Drawing.Point(382, 93)
        Me.TxtDescripcionProfesional.Name = "TxtDescripcionProfesional"
        Me.TxtDescripcionProfesional.Size = New System.Drawing.Size(317, 20)
        Me.TxtDescripcionProfesional.TabIndex = 11
        '
        'TxtExpProfesional
        '
        Me.TxtExpProfesional.Location = New System.Drawing.Point(11, 91)
        Me.TxtExpProfesional.Name = "TxtExpProfesional"
        Me.TxtExpProfesional.Size = New System.Drawing.Size(352, 20)
        Me.TxtExpProfesional.TabIndex = 10
        '
        'DtFechaEstudio
        '
        Me.DtFechaEstudio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaEstudio.Location = New System.Drawing.Point(499, 42)
        Me.DtFechaEstudio.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DtFechaEstudio.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DtFechaEstudio.Name = "DtFechaEstudio"
        Me.DtFechaEstudio.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaEstudio.TabIndex = 9
        '
        'TxtEstudio
        '
        Me.TxtEstudio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEstudio.Location = New System.Drawing.Point(11, 42)
        Me.TxtEstudio.Name = "TxtEstudio"
        Me.TxtEstudio.Size = New System.Drawing.Size(477, 20)
        Me.TxtEstudio.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 117)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Experiencia Docente:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(723, 117)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Tiempo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(723, 72)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Tiempo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(379, 117)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Descripción:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(379, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(496, 21)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 70)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Experiencia Profesional:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Estudios realizados:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvCursos)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(912, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cursos Tomados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgvCursos
        '
        Me.DgvCursos.AllowUserToAddRows = False
        Me.DgvCursos.AllowUserToDeleteRows = False
        Me.DgvCursos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCursos.Location = New System.Drawing.Point(7, 135)
        Me.DgvCursos.MultiSelect = False
        Me.DgvCursos.Name = "DgvCursos"
        Me.DgvCursos.ReadOnly = True
        Me.DgvCursos.RowHeadersVisible = False
        Me.DgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCursos.Size = New System.Drawing.Size(899, 229)
        Me.DgvCursos.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnEliminarCurso)
        Me.GroupBox3.Controls.Add(Me.DtFechaCurso)
        Me.GroupBox3.Controls.Add(Me.BtnAgregarCurso)
        Me.GroupBox3.Controls.Add(Me.TxtTiempoCurso)
        Me.GroupBox3.Controls.Add(Me.TxtInstitucion)
        Me.GroupBox3.Controls.Add(Me.TxtCurso)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(898, 123)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'BtnEliminarCurso
        '
        Me.BtnEliminarCurso.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.delete_24px
        Me.BtnEliminarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarCurso.Location = New System.Drawing.Point(812, 32)
        Me.BtnEliminarCurso.Name = "BtnEliminarCurso"
        Me.BtnEliminarCurso.Size = New System.Drawing.Size(80, 30)
        Me.BtnEliminarCurso.TabIndex = 4
        Me.BtnEliminarCurso.Text = "Eliminar"
        Me.BtnEliminarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminarCurso.UseVisualStyleBackColor = True
        '
        'DtFechaCurso
        '
        Me.DtFechaCurso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaCurso.Location = New System.Drawing.Point(11, 92)
        Me.DtFechaCurso.Name = "DtFechaCurso"
        Me.DtFechaCurso.Size = New System.Drawing.Size(150, 20)
        Me.DtFechaCurso.TabIndex = 6
        '
        'BtnAgregarCurso
        '
        Me.BtnAgregarCurso.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.add_24px
        Me.BtnAgregarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarCurso.Location = New System.Drawing.Point(726, 32)
        Me.BtnAgregarCurso.Name = "BtnAgregarCurso"
        Me.BtnAgregarCurso.Size = New System.Drawing.Size(80, 30)
        Me.BtnAgregarCurso.TabIndex = 3
        Me.BtnAgregarCurso.Text = "Agregar"
        Me.BtnAgregarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarCurso.UseVisualStyleBackColor = True
        '
        'TxtTiempoCurso
        '
        Me.TxtTiempoCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTiempoCurso.Location = New System.Drawing.Point(211, 92)
        Me.TxtTiempoCurso.Name = "TxtTiempoCurso"
        Me.TxtTiempoCurso.Size = New System.Drawing.Size(150, 20)
        Me.TxtTiempoCurso.TabIndex = 7
        '
        'TxtInstitucion
        '
        Me.TxtInstitucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtInstitucion.Location = New System.Drawing.Point(367, 42)
        Me.TxtInstitucion.Name = "TxtInstitucion"
        Me.TxtInstitucion.Size = New System.Drawing.Size(350, 20)
        Me.TxtInstitucion.TabIndex = 5
        '
        'TxtCurso
        '
        Me.TxtCurso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCurso.Location = New System.Drawing.Point(11, 42)
        Me.TxtCurso.Name = "TxtCurso"
        Me.TxtCurso.Size = New System.Drawing.Size(350, 20)
        Me.TxtCurso.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(208, 70)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Tiempo:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 70)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Fecha:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(364, 21)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Institución donde la tomo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 21)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Curso Tomados:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.CapaPresentacion.My.Resources.ResourceImages48px.employee_card_48px
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.edit_24px
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(764, 12)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(80, 30)
        Me.BtnEditar.TabIndex = 22
        Me.BtnEditar.Text = "     Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.add_24px
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(678, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(80, 30)
        Me.BtnNuevo.TabIndex = 21
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.CapaPresentacion.My.Resources.ResourceImages24px.cancel_24px
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(850, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 30)
        Me.BtnSalir.TabIndex = 23
        Me.BtnSalir.Text = "     Cancelar"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmFormacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 611)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmFormacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DgvEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtIdiomas As TextBox
    Friend WithEvents TxtGrado As TextBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtPerfil As TextBox
    Friend WithEvents TxtArea As TextBox
    Friend WithEvents TxtPlaza As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombreDocente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DgvEstudios As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnEliminarEstudios As Button
    Friend WithEvents BtnAgregarEstudios As Button
    Friend WithEvents TxtTiempoDocente As TextBox
    Friend WithEvents TxtDescripcionDocente As TextBox
    Friend WithEvents TxtExpDocente As TextBox
    Friend WithEvents TxtTiempoProfesional As TextBox
    Friend WithEvents TxtDescripcionProfesional As TextBox
    Friend WithEvents TxtExpProfesional As TextBox
    Friend WithEvents DtFechaEstudio As DateTimePicker
    Friend WithEvents TxtEstudio As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnEliminarCurso As Button
    Friend WithEvents BtnAgregarCurso As Button
    Friend WithEvents DgvCursos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtTiempoCurso As TextBox
    Friend WithEvents TxtInstitucion As TextBox
    Friend WithEvents TxtCurso As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DtFechaCurso As DateTimePicker
End Class

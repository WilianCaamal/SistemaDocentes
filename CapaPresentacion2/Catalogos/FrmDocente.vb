Imports Entidades
Imports CapaNegocios
Imports System.IO

Public Class FrmDocente
    Dim objEstados As New LbEstados
    Dim objMunicipios As New LbMunicipios
    Dim listaMunicipios As New List(Of Municipio)
    Dim objDocente As New Docente
    Dim objDocentes As New LbDocentes

    Property IsNew As Boolean
    Property IdDocente As Int32

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim eliminar As DialogResult
        eliminar = MessageBox.Show("Desea eliminar al docente", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If eliminar = DialogResult.Yes Then
            objDocentes.Eliminar(IdDocente)
            MessageBox.Show("Se ha eliminado el docente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Question)
            DialogResult = DialogResult.Yes
            Close()
        End If
    End Sub

    Private Sub ActivarControles(active As Boolean)
        TxtNombres.Enabled = active
        TxtApellidos.Enabled = active
        TxtCurp.Enabled = active
        TxtDireccion.Enabled = active
        TxtCp.Enabled = active
        TxtTelefono.Enabled = active
        TxtEmail.Enabled = active
        CboGenero.Enabled = active
        CboCiudad.Enabled = active
        CboEstado.Enabled = active
        DtFechaNacimiento.Enabled = active

        TxtPlaza.Enabled = active
        TxtPerfil.Enabled = active
        TxtPostgrado.Enabled = active
        TxtIdiomas.Enabled = active
        TxtArea.Enabled = active
        TxtGrado.Enabled = active
        DtFechaIngreso.Enabled = active

        Button1.Enabled = active
    End Sub

    Private Sub FrmDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CboGenero.SelectedIndex = 0
        If IsNew Then
            PbFoto.BackgroundImage = My.Resources.ResourceImages48px.gender_neutral_user_96px
            ActivarControles(IsNew)
            BtnEliminar.Enabled = Not IsNew
            BtnEditar.Enabled = Not IsNew
            Label1.Image = My.Resources.ResourceImages48px.business_contact_48px
        Else
            CargarDatosDocente(IdDocente)
            ActivarControles(False)
            BtnGuardar.Enabled = IsNew
            objDocente.IdDocente = IdDocente
        End If
    End Sub

    Private Sub ValidarCampos(form As Form)

    End Sub

    Private Function ObtenerDocente() As Docente
        Dim objDocente As New Docente With {
            .IdDocente = IdDocente,
            .Nombres = TxtNombres.Text.Trim,
            .Apellidos = TxtApellidos.Text.Trim,
            .Genero = CboGenero.Text.Trim,
            .FechaNacimiento = DtFechaNacimiento.Value,
            .Curp = TxtCurp.Text.Trim,
            .Direccion = TxtDireccion.Text.Trim,
            .IdEstado = CboEstado.SelectedIndex + 1,
            .IdCiudad = CboCiudad.SelectedValue,
            .Cp = TxtCp.Text.Trim,
            .Telefono = TxtTelefono.Text.Trim,
            .Email = TxtEmail.Text.Trim,
            .Plaza = TxtPlaza.Text.Trim,
            .FechaIngreso = DtFechaIngreso.Value,
            .Perfil = TxtPerfil.Text.Trim,
            .Postgrado = TxtPostgrado.Text.Trim,
            .Area = TxtArea.Text.Trim,
            .Grado = TxtGrado.Text.Trim,
            .Idiomas = TxtIdiomas.Text.Trim
        }
        If (PbFoto.Image IsNot Nothing) Then
            Dim img As New Bitmap(PbFoto.Image)
            Dim stream As New MemoryStream
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
            objDocente.Foto = stream.GetBuffer
        End If
        Return objDocente
    End Function

    Private Sub CargarEstados()
        Dim listaEstados As New List(Of Estado)
        listaEstados = objEstados.ListarEstados()
        CboEstado.DisplayMember = "Nombre"
        CboEstado.ValueMember = "Id"
        CboEstado.DataSource = listaEstados
    End Sub

    Private Sub CargarMunicipios(IdEstado As Int32)
        listaMunicipios.Clear()
        CboCiudad.DataSource = Nothing
        listaMunicipios = objMunicipios.MunicipiosByIdEstado(IdEstado + 1)
        CboCiudad.DisplayMember = "Nombre"
        CboCiudad.ValueMember = "Id"
        CboCiudad.DataSource = listaMunicipios
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If IdDocente = 0 Then
                Dim respuesta = objDocentes.Agregar(ObtenerDocente())
                If respuesta Then
                    MessageBox.Show("Se agrego el docente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.Yes
                Else
                    MessageBox.Show("No se agrego el docente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                Dim respuesta = objDocentes.Editar(ObtenerDocente())
                If respuesta Then
                    MessageBox.Show("Se edito el docente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.Yes
                Else
                    MessageBox.Show("No se edito el docente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Agregar Docente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEstado.SelectedIndexChanged
        CargarMunicipios(CboEstado.SelectedIndex)
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ActivarControles(True)
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
    End Sub

    Private Sub CargarDatosDocente(Id As Int32)
        objDocente = objDocentes.GetDocenteById(Id)

        TxtNombres.Text = objDocente.Nombres
        TxtApellidos.Text = objDocente.Apellidos

        If objDocente.Genero = "Hombre" Then
            CboGenero.SelectedItem = 0
            CboGenero.SelectedIndex = 0
            Label1.Image = My.Resources.ResourceImages48px.businessman_48px
        Else
            Label1.Image = My.Resources.ResourceImages48px.administrator_female_48px
            CboGenero.SelectedIndex = 1
            CboGenero.SelectedItem = 1
        End If

        DtFechaNacimiento.Value = objDocente.FechaNacimiento
        TxtCurp.Text = objDocente.Curp
        TxtDireccion.Text = objDocente.Direccion
        CboEstado.SelectedValue = objDocente.IdEstado
        CboCiudad.SelectedValue = objDocente.IdCiudad
        TxtCp.Text = objDocente.Cp
        TxtTelefono.Text = objDocente.Telefono
        TxtEmail.Text = objDocente.Email
        TxtPlaza.Text = objDocente.Plaza
        DtFechaIngreso.Value = objDocente.FechaIngreso
        TxtPerfil.Text = objDocente.Perfil
        TxtPostgrado.Text = objDocente.Postgrado
        TxtArea.Text = objDocente.Area
        TxtGrado.Text = objDocente.Grado
        TxtIdiomas.Text = objDocente.Idiomas

        If objDocente.Foto IsNot Nothing Then
            Dim photo As New Bitmap(New MemoryStream(objDocente.Foto))
            PbFoto.Image = photo
        Else
            PbFoto.BackgroundImage = My.Resources.ResourceImages48px.gender_neutral_user_96px
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OfdFoto.ShowDialog()
        Dim file As New Bitmap(OfdFoto.FileName)

        PbFoto.Image = file
    End Sub
End Class
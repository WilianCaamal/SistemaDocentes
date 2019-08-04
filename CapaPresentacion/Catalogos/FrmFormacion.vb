Imports CapaNegocios
Imports Entidades

Public Class FrmFormacion
    Property IdDocente As Int32
    Dim objDocente As New Docente
    Dim objDocentes As New LbDocentes
    Dim listaEstudios As New List(Of Estudio)
    Dim objEstudios As New LbEstudios

    Private Sub ActivarControles(activar As Boolean)
        TxtNombreDocente.Enabled = activar
        TxtPlaza.Enabled = activar
        TxtArea.Enabled = activar
        TxtPerfil.Enabled = activar
        TxtDireccion.Enabled = activar
        TxtCurp.Enabled = activar
        TxtGrado.Enabled = activar
        TxtIdiomas.Enabled = activar
    End Sub

    Private Sub LimpiarCamposDocente()
        TxtNombreDocente.Text = String.Empty
        TxtPlaza.Text = String.Empty
        TxtArea.Text = String.Empty
        TxtPerfil.Text = String.Empty
        TxtDireccion.Text = String.Empty
        TxtCurp.Text = String.Empty
        TxtGrado.Text = String.Empty
        TxtIdiomas.Text = String.Empty
    End Sub

    Private Sub LimpiarCamposEstudio()
        TxtEstudio.Text = String.Empty
        DtFechaEstudio.Value = DateTime.Now
        TxtExpProfesional.Text = String.Empty
        TxtDescripcionProfesional.Text = String.Empty
        TxtTiempoProfesional.Text = String.Empty
        TxtExpDocente.Text = String.Empty
        TxtDescripcionDocente.Text = String.Empty
        TxtTiempoDocente.Text = String.Empty
        DgvEstudios.DataSource = Nothing
    End Sub

    Private Sub LimpiarCamposCurso()
        TxtCurso.Text = String.Empty
        TxtInstitucion.Text = String.Empty
        TxtTiempoCurso.Text = String.Empty
        DtFechaCurso.Value = DateTime.Now
    End Sub

    Private Sub FrmFormacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivarControles(False)
        ListarEstudios()
        CargarDatosDocente()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub ConfigGridEstudios()
        DgvEstudios.Columns.Item("IdEstudio").Visible = False
        DgvEstudios.Columns.Item("IdDocente").Visible = False
        DgvEstudios.Columns.Item("Nombre").HeaderCell.Value = "Estudios Realizados"
        DgvEstudios.Columns.Item("ExpProfesional").HeaderCell.Value = "Exp. Profesional"
        DgvEstudios.Columns.Item("DescripcionProfesional").HeaderCell.Value = "Descripción"
        DgvEstudios.Columns.Item("TiempoExpProfesional").HeaderCell.Value = "Tiempo"
        DgvEstudios.Columns.Item("TiempoExpProfesional").Width = 60

        DgvEstudios.Columns.Item("ExpDocente").HeaderCell.Value = "Exp. Docente"
        DgvEstudios.Columns.Item("DescripcionDocente").HeaderCell.Value = "Descripción"
        DgvEstudios.Columns.Item("TiempoExpDocente").HeaderCell.Value = "Tiempo"
        DgvEstudios.Columns.Item("TiempoExpDocente").Width = 60
        DgvEstudios.Columns.Item("FechaEstudio").HeaderCell.Value = "Fecha"
        DgvEstudios.Columns.Item("FechaEstudio").Width = 70
    End Sub

    Private Sub ListarEstudios()
        Try
            DgvEstudios.DataSource = Nothing
            listaEstudios.Clear()
            listaEstudios = objEstudios.ListarEstudios(IdDocente)
            Dim count = listaEstudios.Count
            If count > 0 Then
                DgvEstudios.DataSource = listaEstudios
                ConfigGridEstudios()
            Else
                DgvEstudios.DataSource = listaEstudios
                ConfigGridEstudios()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDatosDocente()
        Try
            objDocente = objDocentes.GetDocenteById(IdDocente)
            TxtNombreDocente.Text = objDocente.Nombres + " " + objDocente.Apellidos
            TxtPlaza.Text = objDocente.Plaza
            TxtArea.Text = objDocente.Area
            TxtPerfil.Text = objDocente.Perfil
            TxtDireccion.Text = objDocente.Direccion
            TxtCurp.Text = objDocente.Curp
            TxtGrado.Text = objDocente.Grado
            TxtIdiomas.Text = objDocente.Idiomas
        Catch ex As Exception
            MessageBox.Show("No se logro cargar datos del docente", "Cargar Datos Docente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerEstudio() As Estudio
        Dim objEstudio As New Estudio With {
            .IdDocente = IdDocente,
            .Nombre = TxtEstudio.Text.Trim,
            .ExpProfesional = TxtExpProfesional.Text.Trim,
            .DescripcionProfesional = TxtDescripcionProfesional.Text.Trim,
            .TiempoExpProfesional = TxtTiempoProfesional.Text.Trim,
            .ExpDocente = TxtExpDocente.Text.Trim,
            .DescripcionDocente = TxtDescripcionDocente.Text.Trim,
            .TiempoExpDocente = TxtTiempoDocente.Text.Trim,
            .FechaEstudio = DtFechaEstudio.Value
        }
        Return objEstudio
    End Function

    Private Sub BtnAgregarEstudios_Click(sender As Object, e As EventArgs) Handles BtnAgregarEstudios.Click
        Try
            Dim respuesta = objEstudios.Agregar(ObtenerEstudio())
            If Not respuesta Then
                MessageBox.Show("No se agrego el registro", "Agregar Estudio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                LimpiarCamposEstudio()
                ListarEstudios()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Agregar Estudio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
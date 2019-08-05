﻿Imports CapaNegocios
Imports Entidades

Public Class FrmFormacion
    Property IdDocente As Int32
    Dim objDocente As New Docente
    Dim objEstudio As New Estudio
    Dim objDocentes As New LbDocentes
    Dim listaEstudios As New List(Of Estudio)
    Dim objEstudios As New LbEstudios
    Dim listaCursos As New List(Of Curso)
    Dim objCursos As New LbCursos
    Private Property IdEstudio As Int32

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

    Public Sub ActivarControlesEstudios(activar As Boolean)
        TxtEstudio.Enabled = activar
        DtFechaEstudio.Enabled = activar
        TxtExpProfesional.Enabled = activar
        TxtDescripcionProfesional.Enabled = activar
        TxtTiempoProfesional.Enabled = activar
        TxtExpDocente.Enabled = activar
        TxtDescripcionDocente.Enabled = activar
        TxtTiempoDocente.Enabled = activar
        BtnAgregarEstudios.Enabled = activar
        BtnEliminarEstudios.Enabled = Not activar
        BtnEditar.Enabled = Not activar
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
        TxtEstudio.Select()
        DtFechaEstudio.Value = DateTime.Now
        TxtExpProfesional.Text = String.Empty
        TxtDescripcionProfesional.Text = String.Empty
        TxtTiempoProfesional.Text = String.Empty
        TxtExpDocente.Text = String.Empty
        TxtDescripcionDocente.Text = String.Empty
        TxtTiempoDocente.Text = String.Empty
    End Sub

    Private Sub LimpiarCamposCurso()
        TxtCurso.Text = String.Empty
        TxtInstitucion.Text = String.Empty
        TxtTiempoCurso.Text = String.Empty
        DtFechaCurso.Value = DateTime.Now
        DgvCursos.DataSource = Nothing
    End Sub

    Private Sub FrmFormacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEliminarEstudios.Enabled = False
        ActivarControles(False)
        ActivarControlesEstudios(False)
        ListarEstudios()
        ListarCursos()
        CargarDatosDocente()
        TabControl1.SelectedIndex = 0
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
                DgvEstudios.Rows(0).Selected = True
                Dim selectedRow = DgvEstudios.Rows(0).Cells
                IdEstudio = selectedRow(0).Value
                CargarDatosEstudio(IdEstudio)
                BtnEliminarEstudios.Enabled = True
            Else
                DgvEstudios.DataSource = listaEstudios
                ConfigGridEstudios()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Listar Estudios", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub CargarDatosEstudio(IdEstudio As Int32)
        Try
            objEstudio = objEstudios.GetEstudioById(IdEstudio)
            TxtEstudio.Text = objEstudio.Nombre
            DtFechaEstudio.Value = objEstudio.FechaEstudio
            TxtExpProfesional.Text = objEstudio.ExpProfesional
            TxtDescripcionProfesional.Text = objEstudio.DescripcionProfesional
            TxtTiempoProfesional.Text = objEstudio.TiempoExpProfesional
            TxtExpDocente.Text = objEstudio.ExpDocente
            TxtDescripcionDocente.Text = objEstudio.DescripcionDocente
            TxtTiempoDocente.Text = objEstudio.TiempoExpDocente
        Catch ex As Exception
            MessageBox.Show("No se logro cargar datos del estudio", "Cargar Datos Estudio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerEstudio() As Estudio
        Dim objEstudio As New Estudio With {
            .IdEstudio = IdEstudio,
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
            Dim respuesta As Boolean
            If IdEstudio <> 0 Then
                respuesta = objEstudios.Editar(ObtenerEstudio())
                If Not respuesta Then
                    MessageBox.Show("No se edito el registro", "Editar Estudio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    LimpiarCamposEstudio()
                    ActivarControlesEstudios(False)
                    ListarEstudios()
                End If
            Else
                respuesta = objEstudios.Agregar(ObtenerEstudio())
                If Not respuesta Then
                    MessageBox.Show("No se agrego el registro", "Agregar Estudio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    LimpiarCamposEstudio()
                    ActivarControlesEstudios(False)
                    ListarEstudios()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Agregar Estudio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarCursos()
        Try
            DgvCursos.DataSource = Nothing
            listaCursos.Clear()
            listaCursos = objCursos.ListarCursos(IdDocente)
            Dim count = listaCursos.Count
            If count > 0 Then
                DgvCursos.DataSource = listaCursos
                ConfigGridCursos()
            Else
                DgvCursos.DataSource = listaCursos
                ConfigGridCursos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Listar Cursos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigGridCursos()
        DgvCursos.Columns.Item("IdCurso").Visible = False
        DgvCursos.Columns.Item("IdDocente").Visible = False
        DgvCursos.Columns.Item("Nombre").HeaderCell.Value = "Curso Tomado"
        DgvCursos.Columns.Item("Institucion").HeaderCell.Value = "Institución"
        DgvCursos.Columns.Item("FechaCurso").HeaderCell.Value = "Fecha"
    End Sub

    Private Function ObtenerCurso() As Curso
        Dim objCurso As New Curso With {
            .IdDocente = IdDocente,
            .Nombre = TxtCurso.Text.Trim,
            .Institucion = TxtInstitucion.Text.Trim,
            .Tiempo = TxtTiempoCurso.Text.Trim,
            .FechaCurso = DtFechaCurso.Value
        }
        Return objCurso
    End Function

    Private Sub BtnAgregarCurso_Click(sender As Object, e As EventArgs) Handles BtnAgregarCurso.Click
        Try
            Dim respuesta = objCursos.Agregar(ObtenerCurso())
            If Not respuesta Then
                MessageBox.Show("No se agrego el registro", "Agregar Curso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                LimpiarCamposCurso()
                ListarCursos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Agregar Curso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvEstudios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvEstudios.CellMouseClick
        Dim selectedRow = DgvEstudios.Rows(e.RowIndex).Cells
        IdEstudio = selectedRow(0).Value
        If IdEstudio <> 0 Then
            CargarDatosEstudio(IdEstudio)
            ActivarControlesEstudios(False)
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ActivarControlesEstudios(True)
        BtnAgregarEstudios.Enabled = True
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim indexTab = TabControl1.SelectedIndex
        IdEstudio = 0
        If indexTab = 0 Then
            ActivarControlesEstudios(True)
            LimpiarCamposEstudio()
        Else
            LimpiarCamposCurso()
        End If
    End Sub
End Class
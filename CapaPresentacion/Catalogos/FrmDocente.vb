﻿Imports Entidades

Public Class FrmDocente
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim eliminar As DialogResult
        eliminar = MessageBox.Show("Desea eliminar al docente", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If eliminar = DialogResult.Yes Then
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
        CboArea.Enabled = active
        CboGrado.Enabled = active
        DtFechaIngreso.Enabled = active
    End Sub

    Private Sub FrmDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivarControles(False)
    End Sub

    Private Sub ValidarCampos(form As Form)

    End Sub

    Private Sub Docente()
        Dim objDocente As New Docente With {
            .Nombres = TxtNombres.Text.Trim,
            .Apellidos = TxtApellidos.Text.Trim,
            .Genero = CboGenero.Text.Trim,
            .FechaNacimiento = DtFechaNacimiento.Value,
            .Curp = TxtCurp.Text.Trim,
            .Direccion = TxtDireccion.Text.Trim,
            .IdEstado = CboEstado.ValueMember,
            .IdCiudad = CboCiudad.ValueMember,
            .Cp = TxtCp.Text.Trim,
            .Telefono = TxtTelefono.Text.Trim,
            .Email = TxtEmail.Text.Trim,
            .Plaza = TxtPlaza.Text.Trim,
            .FechaIngreso = DtFechaIngreso.Value,
            .Perfil = TxtPerfil.Text.Trim,
            .Postgrado = TxtPostgrado.Text.Trim,
            .Area = CboArea.Text.Trim,
            .Grado = CboGrado.Text.Trim,
            .Idiomas = TxtIdiomas.Text.Trim
        }
    End Sub

End Class
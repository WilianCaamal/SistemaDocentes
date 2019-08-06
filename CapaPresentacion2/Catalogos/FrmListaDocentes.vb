﻿Imports CapaNegocios
Imports Entidades

Public Class FrmListaDocentes
    Dim resultado As DialogResult
    Dim objDocente As New LbDocentes
    Dim listaDocentes As New List(Of Docente)
    Private IdDocente As Int32

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frmDocente As New FrmDocente With {
            .IsNew = True,
            .IdDocente = 0
        }
        resultado = frmDocente.ShowDialog()
        If resultado = DialogResult.Yes Then
            CargarDocentes()
        End If
    End Sub

    Private Sub BtnFormacion_Click(sender As Object, e As EventArgs) Handles BtnFormacion.Click
        If IdDocente <> 0 Then
            Dim frmFormacion As New FrmFormacion With {
            .IdDocente = IdDocente
            }
            resultado = frmFormacion.ShowDialog()
            If resultado = DialogResult.Yes Then
                CargarDocentes()
            End If
        Else
            MessageBox.Show("Selecciones un registro antes", "Formacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub CargarDocentes()
        Try
            DgvDocentes.DataSource = Nothing
            listaDocentes.Clear()
            listaDocentes = objDocente.ListarDocentes
            Dim count = listaDocentes.Count
            If count > 0 Then
                DgvDocentes.DataSource = listaDocentes
                ConfigurarGrid()
                Dim selectedRow = DgvDocentes.Rows(0).Cells
                IdDocente = CInt(selectedRow(0).Value)
            Else
                MessageBox.Show("Catalogo Vacio", "Listar Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmListaDocentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resultado = DialogResult.No
        CargarDocentes()
    End Sub

    Private Sub ConfigurarGrid()
        DgvDocentes.Columns.Item("IdDocente").Visible = False
        DgvDocentes.Columns.Item("Genero").Visible = False
        DgvDocentes.Columns.Item("FechaNacimiento").Visible = False
        DgvDocentes.Columns.Item("FechaIngreso").Visible = False
        DgvDocentes.Columns.Item("Curp").Visible = False
        DgvDocentes.Columns.Item("Direccion").Visible = False
        DgvDocentes.Columns.Item("IdEstado").Visible = False
        DgvDocentes.Columns.Item("IdCiudad").Visible = False
        DgvDocentes.Columns.Item("Cp").Visible = False
        DgvDocentes.Columns.Item("Telefono").Visible = False
        DgvDocentes.Columns.Item("Email").Visible = False
        DgvDocentes.Columns.Item("Plaza").Visible = False
        DgvDocentes.Columns.Item("Postgrado").Visible = False
        DgvDocentes.Columns.Item("Area").Visible = False
        DgvDocentes.Columns.Item("Grado").Visible = False
        DgvDocentes.Columns.Item("Idiomas").Visible = False
        DgvDocentes.Columns.Item("Foto").Visible = False
    End Sub

    Private Sub DgvDocentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDocentes.CellContentClick

    End Sub

    Private Sub DgvDocentes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDocentes.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DgvDocentes.Rows(e.RowIndex).Cells
            Dim frmDocente As New FrmDocente With {
                .IdDocente = CInt(selectedRow(0).Value),
                .IsNew = False
            }
            Dim respuesta = frmDocente.ShowDialog()
            If respuesta = DialogResult.Yes Then
                CargarDocentes()
            End If
        End If
    End Sub

    Private Sub DgvDocentes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDocentes.CellMouseClick
        Try
            Dim selectedRow = DgvDocentes.Rows(e.RowIndex).Cells
            IdDocente = CInt(selectedRow(0).Value)
        Catch ex As Exception

        End Try
    End Sub
End Class
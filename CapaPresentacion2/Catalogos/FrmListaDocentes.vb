﻿Imports System.Text
Imports CapaNegocios
Imports DevExpress.XtraReports.UI
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
            BtnFormacion.Enabled = True
            BtnBuscar.Enabled = True
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
                BtnBuscar.Enabled = True
                BtnFormacion.Enabled = True
                BtnBuscar.Enabled = True
                TxtBusqueda.Enabled = True
                BtnReporte.Enabled = True
            Else
                BtnBuscar.Enabled = False
                BtnFormacion.Enabled = False
                BtnBuscar.Enabled = False
                TxtBusqueda.Enabled = False
                BtnReporte.Enabled = False
                MessageBox.Show("Catalogo Vacio", "Listar Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmListaDocentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarConexion()
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

    Private Sub CargarConexion()
        Dim SqlConnection As New StringBuilder
        SqlConnection.Clear()
        SqlConnection.Append(My.Settings.Usuario)
        SqlConnection.Append(My.Settings.Contrasena)
        Dim RUTA = "Database=" + Application.StartupPath + "\BD\SISTEMADOCENTES2.FDB;"
        My.Settings.PathBD = "Database=" + Application.StartupPath + "\BD\SISTEMADOCENTES2.FDB;"
        My.Settings.Save()
        SqlConnection.Append(My.Settings.PathBD)
        SqlConnection.Append(My.Settings.DataSource)
        SqlConnection.Append(My.Settings.Port)
        SqlConnection.Append(My.Settings.Extras)
        Dim objConexion As New LbConexion
        objConexion.GuardarConexion(SqlConnection.ToString)
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        ProgressPanel1.Visible = True
        Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim report As New rptUpdateDocente
        report.IdDocente = IdDocente
        Dim reportTool As New ReportPrintTool(report)
        reportTool.ShowPreviewDialog()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressPanel1.Visible = False
        Activate()
        Enabled = True
    End Sub

    Private Sub BtnBuscar_Click_1(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtBusqueda.Text.Trim <> Nothing Then
            Dim listaBusqueda As New List(Of Docente)
            listaBusqueda.Clear()
            listaBusqueda = objDocente.Buscar(TxtBusqueda.Text.Trim)
            TxtBusqueda.Text = String.Empty
            If listaBusqueda.Count > 0 Then
                DgvDocentes.DataSource = Nothing
                DgvDocentes.DataSource = listaBusqueda
                ConfigurarGrid()
            Else
                MessageBox.Show("No hay registro para la busqueda" + vbNewLine + "Se recargaran todos los datos", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtBusqueda.Text = String.Empty
                CargarDocentes()
            End If
        Else
            CargarDocentes()
        End If
    End Sub
End Class
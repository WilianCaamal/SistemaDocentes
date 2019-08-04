Imports CapaNegocios
Imports Entidades

Public Class FrmListaDocentes
    Dim resultado As DialogResult
    Dim objDocente As New LbDocentes
    Dim listaDocentes As New List(Of Docente)

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frmDocente As New FrmDocente With {
            .IsNew = True
        }
        resultado = frmDocente.ShowDialog()
        If resultado = DialogResult.Yes Then
            CargarDocentes()
        End If
    End Sub

    Private Sub BtnFormacion_Click(sender As Object, e As EventArgs) Handles BtnFormacion.Click
        Dim frmFormacion As New FrmFormacion
        resultado = frmFormacion.ShowDialog()
        If resultado = DialogResult.Yes Then
            CargarDocentes()
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
        'DgvDocentes.Columns.Item("Perfil").Visible = False
        DgvDocentes.Columns.Item("Postgrado").Visible = False
        DgvDocentes.Columns.Item("Area").Visible = False
        DgvDocentes.Columns.Item("Grado").Visible = False
        DgvDocentes.Columns.Item("Idiomas").Visible = False
    End Sub

    Private Sub DgvDocentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDocentes.CellContentClick

    End Sub

    Private Sub DgvDocentes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDocentes.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DgvDocentes.Rows(e.RowIndex).Cells
            Dim frmDocente As New FrmDocente
            frmDocente.IdDocente = selectedRow(0).Value
            frmDocente.ShowDialog()
        End If
    End Sub
End Class
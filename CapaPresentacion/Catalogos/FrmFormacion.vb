Public Class FrmFormacion
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

    Private Sub LimpiarControles()
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
        TxtExpProfecional.Text = String.Empty
        TxtDescripcionProfecional.Text = String.Empty
        TxtTiempoProfesional.Text = String.Empty
        TxtExpDocente.Text = String.Empty
        TxtDescripcionDocente.Text = String.Empty
        TxtTiempoDocente.Text = String.Empty
        DgvEstudios.DataSource = ""
    End Sub

    Private Sub LimpiarCamposCurso()
        TxtCurso.Text = String.Empty
        TxtInstitucion.Text = String.Empty
        TxtTiempoCurso.Text = String.Empty
        DtFechaCurso.Value = DateTime.Now
    End Sub

    Private Sub FrmFormacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivarControles(False)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class
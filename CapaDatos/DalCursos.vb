Public Class DalCursos
    Private ReadOnly listaCursos = "SELECT * FROM CURSOS"
    Private ReadOnly CursoByDocente = "SELECT NOMBRE_CURSO,INSTITUCION,TIEMPO,FECHA_CURSO FROM CURSOS WHERE ID_DOCENTE = {0}"

    Public Sub ListarCursos()

    End Sub

    Public Sub CursosByDocente()

    End Sub

End Class

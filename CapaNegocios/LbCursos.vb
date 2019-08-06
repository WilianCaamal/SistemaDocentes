Imports CapaDatos
Imports Entidades

Public Class LbCursos
    Dim objCursos As New DalCursos
    Public Function ListarCursos(IdDocente As Int32) As List(Of Curso)
        Return objCursos.ListarCursos(IdDocente)
    End Function

    Public Function Agregar(objCurso As Curso) As Boolean
        Return objCursos.Agregar(objCurso)
    End Function

    Public Function GetCursoById(IdCurso As Int32) As Curso
        Return objCursos.GetCursoById(IdCurso)
    End Function

    Public Function Editar(objCurso As Curso) As Boolean
        Return objCursos.Editar(objCurso)
    End Function

    Public Function Eliminar(Id As Int32)
        Return objCursos.Eliminar(Id)
    End Function

End Class

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
End Class

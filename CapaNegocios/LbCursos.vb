Imports CapaDatos
Imports Entidades

Public Class LbCursos
    Dim objCursos As New DalCursos
    Public Function ListarCursos(IdDocente As Int32) As List(Of Curso)
        Return objCursos.ListarCursos(IdDocente)
    End Function

    Public Function Agregar(objCurso As Curso) As Boolean
        Dim _error As String = ""
        If objCurso.Nombre = String.Empty Then
            _error += " Nombre"
        End If
        If objCurso.Institucion = String.Empty Then
            _error += ", Institución"
        End If

        If _error.Length > 0 Then
            Throw New Exception("Los siguientes campos no pueden estar vacios: " + vbNewLine + _error.Substring(1))
        End If

        Return objCursos.Agregar(objCurso)
    End Function

    Public Function GetCursoById(IdCurso As Int32) As Curso
        Return objCursos.GetCursoById(IdCurso)
    End Function

    Public Function Editar(objCurso As Curso) As Boolean
        Dim _error As String = ""
        If objCurso.Nombre = String.Empty Then
            _error += " Nombre"
        End If
        If objCurso.Institucion = String.Empty Then
            _error += ", Institución"
        End If

        If _error.Length > 0 Then
            Throw New Exception("Los siguientes campos no pueden estar vacios: " + vbNewLine + _error.Substring(1))
        End If
        Return objCursos.Editar(objCurso)
    End Function

    Public Function Eliminar(Id As Int32)
        Return objCursos.Eliminar(Id)
    End Function

End Class

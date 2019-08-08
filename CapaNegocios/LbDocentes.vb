Imports Entidades
Imports CapaDatos

Public Class LbDocentes
    Dim objDocentes As New DalDocentes

    Public Function ListarDocentes() As List(Of Docente)
        Return objDocentes.ListarDocentes()
    End Function

    Public Function GetDocenteById(id As Int32) As Docente
        Return objDocentes.GetDocenteById(id)
    End Function

    Public Function Agregar(objDocente As Docente) As Boolean
        Return objDocentes.Agregar(objDocente)
    End Function

    Public Function Editar(objDocente As Docente) As Boolean
        Return objDocentes.Editar(objDocente)
    End Function

    Public Function Eliminar(Id As Int32) As Boolean
        Return objDocentes.Eliminar(Id)
    End Function

    Public Function Buscar(busqueda As String) As List(Of Docente)
        Return objDocentes.Buscar(busqueda)
    End Function

End Class

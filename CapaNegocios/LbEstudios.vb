Imports CapaDatos
Imports Entidades
Public Class LbEstudios
    Dim objEstudios As New DalEstudios
    Public Function ListarEstudios(IdDocente As Int32) As List(Of Estudio)
        Return objEstudios.ListarEstudios(IdDocente)
    End Function

    Public Function Agregar(objEstudio As Estudio) As Boolean
        Return objEstudios.Agregar(objEstudio)
    End Function

    Public Function GetEstudioById(IdEstudio As Int32) As Estudio
        Return objEstudios.GetEstudioById(IdEstudio)
    End Function

    Public Function Editar(objEstudio As Estudio) As Boolean
        Return objEstudios.Editar(objEstudio)
    End Function

    Public Function Eliminar(Id As Int32)
        Return objEstudios.Eliminar(Id)
    End Function

End Class

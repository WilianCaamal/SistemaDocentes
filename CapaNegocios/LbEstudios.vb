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
End Class

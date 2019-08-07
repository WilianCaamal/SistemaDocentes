Imports CapaDatos
Imports Entidades

Public Class LbEstados
    Dim objEstados As New DalEstados
    Public Function ListarEstados() As List(Of Estado)
        Return objEstados.ListarEstados()
    End Function

    Public Function EstadoById(IdEstado As Int32) As Estado
        Return objEstados.EstadoById(IdEstado)
    End Function
End Class

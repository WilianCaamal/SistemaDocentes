Imports CapaDatos
Imports Entidades

Public Class LbEstados
    Dim objEstados As New DalEstados
    Public Function ListarEstados() As List(Of Estado)
        Return objEstados.ListarEstados()
    End Function
End Class

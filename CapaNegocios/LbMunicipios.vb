Imports CapaDatos
Imports Entidades

Public Class LbMunicipios
    Dim objMunicipios As New DalMunicipios
    Public Function MunicipiosByIdEstado(Id As Int32) As List(Of Municipio)
        Return objMunicipios.MunicipiosByIdEstado(Id)
    End Function
End Class

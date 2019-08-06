Imports CapaDatos
Public Class LbConexion
    Dim objConexion As New DalConexion
    Sub GuardarConexion(StringConnection As String)
        objConexion.GuardarConexion(StringConnection)
    End Sub
End Class

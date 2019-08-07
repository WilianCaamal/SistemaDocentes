Imports FirebirdSql.Data.FirebirdClient

Public Class DalConexion

    Public Sub GuardarConexion(StringConnection As String)
        My.Settings.cadenaConexion = StringConnection
        My.Settings.Save()
    End Sub
End Class

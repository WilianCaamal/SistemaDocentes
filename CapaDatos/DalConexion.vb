Imports FirebirdSql.Data.FirebirdClient

Public Class DalConexion
    Shared Sub Conexion()
        Dim cadenaConexion As String
        cadenaConexion =
            "User=SYSDBA;" +
            "Password=masterkey;" +
            "Database=C:\\Users\\wilia\\Documents\\Visual Studio 2017\\Projects\\SISTEMADOCENTES2.FDB;" +
            "DataSource=localhost;" +
            "Port=3050;" +
            "Dialect=3;" +
            "Charset=NONE;" +
            "Role=;" +
            "Connection lifetime=15;" +
            "Pooling=true;" +
            "MinPoolSize=0;" +
            "MaxPoolSize=50;" +
            "Packet Size=8192;" +
            "ServerType=0"

        Using Conexion As New FbConnection
            Try
                Conexion.ConnectionString = My.Settings.cadenaConexion
                Dim transaccion As FbTransaction
                transaccion = Conexion.BeginTransaction
                Dim command As New FbCommand With {
                    .CommandText = "Select * from CURSOS",
                    .Connection = Conexion,
                    .Transaction = transaccion
                }

                'command.Parameters.AddWithValue("@field", "objeto")

                command.ExecuteNonQuery()

                transaccion.Commit()
                command.Dispose()
                Conexion.Close()
            Catch ex As Exception

            End Try
        End Using
    End Sub
End Class

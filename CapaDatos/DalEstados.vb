Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalEstados
    Private ReadOnly SqlEstados = "SELECT ID,NOMBRE FROM ESTADOS ORDER BY ID"
    Private ReadOnly SqlEstadosById = "SELECT ID,NOMBRE FROM ESTADOS WHERE ID = @ID_ESTADO"
    Private ListaEstado As New List(Of Estado)

    Public Function ListarEstados() As List(Of Estado)
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim transaccion As FbTransaction
            transaccion = conexion.BeginTransaction
            Dim command As New FbCommand With {
                .CommandText = SqlEstados,
                .Connection = conexion,
                .Transaction = transaccion
            }
            Try
                'command.Parameters.AddWithValue("@field", "objeto")
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Dim objEstado As New Estado With {
                    .Id = Convert.ToInt32(dr.GetInt32(0)),
                    .Nombre = dr.GetString(1)
                }
                    ListaEstado.Add(objEstado)
                End While

                transaccion.Commit()
                command.Dispose()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return ListaEstado
    End Function

    Public Function EstadoById(IdEstado As Int32) As Estado
        Dim objEstado As New Estado
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = SqlEstadosById,
                    .Connection = conexion
                }
            Try

                command.Parameters.AddWithValue("@ID_ESTADO", IdEstado)
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Console.WriteLine(dr)
                    objEstado.Id = dr.GetInt32(0)
                    objEstado.Nombre = dr.GetString(1)
                End While
                dr.Close()
                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return objEstado
    End Function

End Class

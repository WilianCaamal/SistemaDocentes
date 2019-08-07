Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalMunicipios
    Private ReadOnly SqlMunicipios = "SELECT ID,NOMBRE FROM MUNICIPIOS ORDER BY ID"
    Private ReadOnly SqlMunicipiosByIdEstado = "SELECT ID,NOMBRE FROM MUNICIPIOS WHERE ID_ESTADO = {0} ORDER BY ID"
    Private ReadOnly SqlMunicipiosById = "SELECT ID,NOMBRE FROM MUNICIPIOS WHERE ID = @ID"
    Private ListaMunicipios As New List(Of Municipio)

    Public Function ListarMunicipios() As List(Of Municipio)
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim transaccion As FbTransaction
            transaccion = conexion.BeginTransaction
            Dim command As New FbCommand With {
                .CommandText = SqlMunicipios,
                .Connection = conexion,
                .Transaction = transaccion
            }
            Try
                'command.Parameters.AddWithValue("@field", "objeto")
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Dim objMunicipio As New Municipio With {
                    .Id = Convert.ToInt32(dr.GetInt32(0)),
                    .Nombre = dr.GetString(1)
                }
                    ListaMunicipios.Add(objMunicipio)
                End While

                transaccion.Commit()
                command.Dispose()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return ListaMunicipios
    End Function

    Public Function MunicipiosByIdEstado(id As Int32) As List(Of Municipio)
        Using conexion As New FbConnection
            ListaMunicipios.Clear()
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim transaccion As FbTransaction
            transaccion = conexion.BeginTransaction
            Dim command As New FbCommand With {
                .CommandText = String.Format(SqlMunicipiosByIdEstado, id),
                .Connection = conexion,
                .Transaction = transaccion
            }
            Try
                'command.Parameters.AddWithValue("@field", "objeto")
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Dim objMunicipio As New Municipio With {
                    .Id = Convert.ToInt32(dr.GetInt32(0)),
                    .Nombre = dr.GetString(1)
                }
                    ListaMunicipios.Add(objMunicipio)
                End While

                transaccion.Commit()
                command.Dispose()
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return ListaMunicipios
    End Function

    Public Function MunicipioById(IdMunicipio) As Municipio
        Dim objMunicipio As New Municipio
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = SqlMunicipiosById,
                    .Connection = conexion
                }
            Try
                command.Parameters.AddWithValue("@ID", IdMunicipio)
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Console.WriteLine(dr)
                    objMunicipio.Id = dr.GetInt32(0)
                    objMunicipio.Nombre = dr.GetString(1)
                End While
                dr.Close()
                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return objMunicipio
    End Function
End Class

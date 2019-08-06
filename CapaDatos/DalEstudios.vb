Imports System.Text
Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalEstudios
    Private Sql As New StringBuilder

    Private listaEstudios As New List(Of Estudio)

    ''' <summary>
    ''' Lista de estudios por docente
    ''' </summary>
    ''' <param name="IdDocente">Id del Docente</param>
    ''' <returns>List Type Estudio</returns>
    Function ListarEstudios(IdDocente As Int32) As List(Of Estudio)

        Sql.Clear()
        Sql.Append("SELECT * FROM ESTUDIOS ")
        Sql.Append("WHERE ")
        Sql.Append("ID_DOCENTE = @ID_DOCENTE")

        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = conexion
                }
            Try
                command.Parameters.AddWithValue("@ID_DOCENTE", IdDocente)
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Dim objEstudio As New Estudio With {
                        .IdEstudio = dr.GetInt32(0),
                        .IdDocente = dr.GetInt32(1),
                        .Nombre = dr.GetString(2),
                        .FechaEstudio = dr.GetDateTime(3),
                        .ExpProfesional = dr.GetString(4),
                        .DescripcionProfesional = dr.GetString(5),
                        .TiempoExpProfesional = dr.GetString(6),
                        .ExpDocente = dr.GetString(7),
                        .TiempoExpDocente = dr.GetString(8),
                        .DescripcionDocente = dr.GetString(9)
                    }
                    listaEstudios.Add(objEstudio)
                End While
                dr.Close()

                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return listaEstudios
    End Function

    ''' <summary>
    ''' Agrega un registro en estudios
    ''' </summary>
    ''' <param name="objEstudio">Object Type Estudio</param>
    ''' <returns>True o False</returns>
    Function Agregar(objEstudio As Estudio) As Boolean

        Sql.Clear()
        Sql.Append("INSERT INTO ESTUDIOS ")
        Sql.Append("(")
        Sql.Append("ID_DOCENTE,")
        Sql.Append("NOMBRE_ESTUDIO,")
        Sql.Append("FECHA_ESTUDIO,")
        Sql.Append("EXP_PROFESIONAL,")
        Sql.Append("DESCRIPCION_PROFESIONAL,")
        Sql.Append("TIEMPO_EXP_PROFESIONAL,")
        Sql.Append("EXP_DOCENTE,")
        Sql.Append("DESCRIPCION_DOCENTE,")
        Sql.Append("TIEMPO_EXP_DOCENTE")
        Sql.Append(")")
        Sql.Append(" VALUES ")
        Sql.Append("(")
        Sql.Append("@ID_DOCENTE,")
        Sql.Append("@NOMBRE,")
        Sql.Append("@FECHA_EST,")
        Sql.Append("@EXP_PRO,")
        Sql.Append("@DESC_PRO,")
        Sql.Append("@TIEMPO_PRO,")
        Sql.Append("@EXP_DOC,")
        Sql.Append("@DESC_DOC,")
        Sql.Append("@TIEMPO_DOC")
        Sql.Append(")")

        Dim resultado As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = Conexion,
                    .Transaction = transaccion
                }
            Try
                command.Parameters.AddWithValue("@ID_DOCENTE", objEstudio.IdDocente)
                command.Parameters.AddWithValue("@NOMBRE", objEstudio.Nombre)
                command.Parameters.AddWithValue("@FECHA_EST", objEstudio.FechaEstudio)
                command.Parameters.AddWithValue("@EXP_PRO", objEstudio.ExpProfesional)
                command.Parameters.AddWithValue("@DESC_PRO", objEstudio.DescripcionProfesional)
                command.Parameters.AddWithValue("@TIEMPO_PRO", objEstudio.TiempoExpProfesional)
                command.Parameters.AddWithValue("@EXP_DOC", objEstudio.ExpDocente)
                command.Parameters.AddWithValue("@DESC_DOC", objEstudio.DescripcionDocente)
                command.Parameters.AddWithValue("@TIEMPO_DOC", objEstudio.TiempoExpDocente)

                Dim respuesta = command.ExecuteNonQuery()

                transaccion.Commit()
                command.Dispose()
                If respuesta > 0 Then
                    resultado = True
                Else
                    resultado = False
                End If
            Catch ex As Exception
                transaccion.Rollback()
            End Try
        End Using
        Return resultado
    End Function

    ''' <summary>
    ''' Obtiene un registro de un estudio
    ''' </summary>
    ''' <param name="IdEstudio">Id del estudio a consultar</param>
    ''' <returns>True o False</returns>
    Function GetEstudioById(IdEstudio As Int32) As Estudio

        Sql.Clear()
        Sql.Append("SELECT * FROM ESTUDIOS")
        Sql.Append(" WHERE ")
        Sql.Append("ID_ESTUDIO = @ID_ESTUDIO")

        Dim objEstudio As New Estudio
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = conexion
                }
            Try
                command.Parameters.AddWithValue("@ID_ESTUDIO", IdEstudio)
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Console.WriteLine(dr)
                    objEstudio.IdEstudio = dr.GetInt32(0)
                    objEstudio.IdDocente = dr.GetInt32(1)
                    objEstudio.Nombre = dr.GetString(2)
                    objEstudio.FechaEstudio = dr.GetDateTime(3)
                    objEstudio.ExpProfesional = dr.GetString(4)
                    objEstudio.DescripcionProfesional = dr.GetString(5)
                    objEstudio.TiempoExpProfesional = dr.GetString(6)
                    objEstudio.ExpDocente = dr.GetString(7)
                    objEstudio.DescripcionDocente = dr.GetString(8)
                    objEstudio.TiempoExpDocente = dr.GetString(9)
                End While
                dr.Close()
                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return objEstudio
    End Function

    ''' <summary>
    ''' Editar un registro de estudio
    ''' </summary>
    ''' <param name="objEstudio">Object Type Estudio</param>
    ''' <returns>True o False</returns>
    Function Editar(objEstudio As Estudio) As Boolean

        Sql.Clear()
        Sql.Append("UPDATE ESTUDIOS SET ")
        Sql.Append("ID_DOCENTE = @ID_DOCENTE,")
        Sql.Append("NOMBRE_ESTUDIO = @NOMBRE,")
        Sql.Append("FECHA_ESTUDIO = @FECHA_EST,")
        Sql.Append("EXP_PROFESIONAL = @EXP_PRO,")
        Sql.Append("DESCRIPCION_PROFESIONAL = @DESC_PRO,")
        Sql.Append("TIEMPO_EXP_PROFESIONAL = @TIEMPO_PRO,")
        Sql.Append("EXP_DOCENTE = @EXP_DOC,")
        Sql.Append("DESCRIPCION_DOCENTE = @DESC_DOC,")
        Sql.Append("TIEMPO_EXP_DOCENTE = @TIEMPO_DOC")
        Sql.Append(" WHERE ")
        Sql.Append("ID_ESTUDIO = @ID_ESTUDIO")

        Dim resultado As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = Conexion,
                    .Transaction = transaccion
                }
            Try
                command.Parameters.AddWithValue("@ID_DOCENTE", objEstudio.IdDocente)
                command.Parameters.AddWithValue("@NOMBRE", objEstudio.Nombre)
                command.Parameters.AddWithValue("@FECHA_EST", objEstudio.FechaEstudio)
                command.Parameters.AddWithValue("@EXP_PRO", objEstudio.ExpProfesional)
                command.Parameters.AddWithValue("@DESC_PRO", objEstudio.DescripcionProfesional)
                command.Parameters.AddWithValue("@TIEMPO_PRO", objEstudio.TiempoExpProfesional)
                command.Parameters.AddWithValue("@EXP_DOC", objEstudio.ExpDocente)
                command.Parameters.AddWithValue("@DESC_DOC", objEstudio.DescripcionDocente)
                command.Parameters.AddWithValue("@TIEMPO_DOC", objEstudio.TiempoExpDocente)
                command.Parameters.AddWithValue("@ID_ESTUDIO", objEstudio.IdEstudio)
                Dim respuesta = command.ExecuteNonQuery()

                transaccion.Commit()
                command.Dispose()
                If respuesta > 0 Then
                    resultado = True
                Else
                    resultado = False
                End If
            Catch ex As Exception
                transaccion.Rollback()
            End Try
        End Using
        Return resultado
    End Function

    ''' <summary>
    ''' Elimina un registro de estudio
    ''' </summary>
    ''' <param name="IdEstudio">ID del estudio a eliminar</param>
    ''' <returns>True o False</returns>
    Public Function Eliminar(IdEstudio As Int32) As Boolean

        Sql.Clear()
        Sql.Append("DELETE FROM ESTUDIOS ")
        Sql.Append("WHERE ")
        Sql.Append("ID_ESTUDIO = @ID_ESTUDIO")

        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = Conexion,
                    .Transaction = transaccion
                }
            Try
                command.Parameters.AddWithValue("@ID_ESTUDIO", IdEstudio)
                Dim respuesta = command.ExecuteNonQuery()

                transaccion.Commit()
                command.Dispose()
                If respuesta > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Elimina todos los estudios pertenecientes al docente al ser este eliminado
    ''' </summary>
    ''' <param name="IdDocente">Id del docente</param>
    ''' <returns>True o False</returns>
    Public Function EliminarEstudiosDoncente(IdDocente As Int32) As Boolean
        Sql.Clear()
        Sql.Append("DELETE FROM ESTUDIOS ")
        Sql.Append("WHERE ")
        Sql.Append("ID_DOCENTE = @ID_DOCENTE")

        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = Conexion,
                    .Transaction = transaccion
                }
            Try
                command.Parameters.AddWithValue("@ID_DOCENTE", IdDocente)
                Dim respuesta = command.ExecuteNonQuery()

                transaccion.Commit()
                command.Dispose()
                If respuesta > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                transaccion.Rollback()
                Throw New Exception
            End Try
        End Using
    End Function

End Class

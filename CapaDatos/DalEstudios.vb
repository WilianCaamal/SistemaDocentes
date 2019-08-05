Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalEstudios
    Private ReadOnly SqlEstudios = "SELECT * FROM ESTUDIOS WHERE ID_DOCENTE = @ID_DOCENTE"
    Private ReadOnly SqlEstudioAdd = "INSERT INTO ESTUDIOS " +
        "(ID_DOCENTE,NOMBRE_ESTUDIO,FECHA_ESTUDIO,EXP_PROFESIONAL,DESCRIPCION_PROFESIONAL,TIEMPO_EXP_PROFESIONAL,EXP_DOCENTE,DESCRIPCION_DOCENTE,TIEMPO_EXP_DOCENTE)" +
        " VALUES " +
        "(@ID_DOCENTE,@NOMBRE,@FECHA_EST,@EXP_PRO,@DESC_PRO,@TIEMPO_PRO,@EXP_DOC,@DESC_DOC,@TIEMPO_DOC)"
    Private ReadOnly SqlEstudioEdit = "UPDATE ESTUDIOS SET " +
        "ID_DOCENTE = @ID_DOCENTE,NOMBRE_ESTUDIO = @NOMBRE ,FECHA_ESTUDIO = @FECHA_EST,EXP_PROFESIONAL = @EXP_PRO, " +
        "DESCRIPCION_PROFESIONAL = @DESC_PRO,TIEMPO_EXP_PROFESIONAL = @TIEMPO_PRO,EXP_DOCENTE = @EXP_DOC, " +
        "DESCRIPCION_DOCENTE = @DESC_DOC,TIEMPO_EXP_DOCENTE = @TIEMPO_DOC " +
        "WHERE ID_ESTUDIO = @ID_ESTUDIO "
    Private ReadOnly SqlEstidioById = "SELECT * FROM ESTUDIOS WHERE ID_ESTUDIO = @ID_ESTUDIO"
    Private listaEstudios As New List(Of Estudio)

    Function ListarEstudios(IdDocente As Int32) As List(Of Estudio)
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = SqlEstudios,
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
        Return ListaEstudios
    End Function

    Function Agregar(objEstudio As Estudio) As Boolean
        Dim resultado As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = SqlEstudioAdd,
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

    Function GetEstudioById(IdEstudio As Int32) As Estudio
        Dim objEstudio As New Estudio
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = SqlEstidioById,
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

    Function Editar(objEstudio As Estudio) As Boolean
        Dim resultado As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = SqlEstudioEdit,
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

End Class

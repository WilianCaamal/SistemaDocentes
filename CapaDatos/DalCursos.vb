Imports System.Text
Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalCursos
    Private Sql As New StringBuilder
    Private listaCursos As New List(Of Curso)

    ''' <summary>
    ''' Lista de cursos de un docente
    ''' </summary>
    ''' <param name="IdDocente">Id de un docente</param>
    ''' <returns>Lista de Cursos</returns>
    Function ListarCursos(IdDocente As Int32) As List(Of Curso)
        Sql.Clear()
        Sql.Append("SELECT * FROM CURSOS ")
        Sql.Append("WHERE ")
        Sql.Append("ID_DOCENTE = @ID_DOCENTE ")

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
                    Dim objCurso As New Curso With {
                        .IdCurso = dr.GetInt32(0),
                        .IdDocente = dr.GetInt32(1),
                        .Nombre = dr.GetString(2),
                        .Institucion = dr.GetString(3),
                        .Tiempo = dr.GetString(4),
                        .FechaCurso = dr.GetDateTime(5)
                    }
                    listaCursos.Add(objCurso)
                End While
                dr.Close()

                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return listaCursos
    End Function

    ''' <summary>
    ''' Agrega un registro en cursos
    ''' </summary>
    ''' <param name="objCurso">Object Type Curso</param>
    ''' <returns>True o False</returns>
    Function Agregar(objCurso As Curso) As Boolean
        Dim resultado As Boolean

        Sql.Clear()
        Sql.Append("INSERT INTO CURSOS ")
        Sql.Append("( ")
        Sql.Append("ID_DOCENTE, ")
        Sql.Append("NOMBRE_CURSO, ")
        Sql.Append("INSTITUCION, ")
        Sql.Append("TIEMPO, ")
        Sql.Append("FECHA_CURSO ")
        Sql.Append(") ")
        Sql.Append("VALUES ")
        Sql.Append("( ")
        Sql.Append("@ID_DOCENTE, ")
        Sql.Append("@NOMBRE_CURSO, ")
        Sql.Append("@INSTITUCION, ")
        Sql.Append("@TIEMPO, ")
        Sql.Append("@FECHA_CURSO ")
        Sql.Append(") ")

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
                command.Parameters.AddWithValue("@ID_DOCENTE", objCurso.IdDocente)
                command.Parameters.AddWithValue("@NOMBRE_CURSO", objCurso.Nombre)
                command.Parameters.AddWithValue("@INSTITUCION", objCurso.Institucion)
                command.Parameters.AddWithValue("@TIEMPO", objCurso.Tiempo)
                command.Parameters.AddWithValue("@FECHA_CURSO", objCurso.FechaCurso)

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
    ''' Obtiene los datos de un curso
    ''' </summary>
    ''' <param name="IdCurso">Ud del curso a consultar</param>
    ''' <returns>Object Type Curso</returns>
    Function GetCursoById(IdCurso As Int32) As Curso
        Dim objCurso As New Curso

        Sql.Clear()
        Sql.Append("SELECT * FROM CURSOS ")
        Sql.Append("WHERE ")
        Sql.Append("ID_CURSO = @ID_CURSO ")

        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = conexion
                }
            Try
                command.Parameters.AddWithValue("@ID_CURSO", IdCurso)
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Console.WriteLine(dr)
                    objCurso.IdCurso = dr.GetInt32(0)
                    objCurso.IdDocente = dr.GetInt32(1)
                    objCurso.Nombre = dr.GetString(2)
                    objCurso.Institucion = dr.GetString(3)
                    objCurso.Tiempo = dr.GetString(4)
                    objCurso.FechaCurso = dr.GetDateTime(5)
                End While
                dr.Close()
                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return objCurso
    End Function

    ''' <summary>
    ''' Edita un registro en cursos
    ''' </summary>
    ''' <param name="objCurso">Object Type Curso</param>
    ''' <returns>True o False</returns>
    Function Editar(objCurso As Curso) As Boolean
        Dim resultado As Boolean

        Sql.Clear()
        Sql.Append("UPDATE CURSOS SET ")
        Sql.Append("ID_DOCENTE = @ID_DOCENTE, ")
        Sql.Append("NOMBRE_CURSO = @NOMBRE, ")
        Sql.Append("INSTITUCION = @INSTITUCION, ")
        Sql.Append("TIEMPO = @TIEMPO, ")
        Sql.Append("FECHA_CURSO = @FECHA_CURSO ")
        Sql.Append("WHERE ")
        Sql.Append("ID_CURSO = @ID_CURSO")

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
                command.Parameters.AddWithValue("@ID_CURSO", objCurso.IdCurso)
                command.Parameters.AddWithValue("@ID_DOCENTE", objCurso.IdDocente)
                command.Parameters.AddWithValue("@NOMBRE", objCurso.Nombre)
                command.Parameters.AddWithValue("@INSTITUCION", objCurso.Institucion)
                command.Parameters.AddWithValue("@TIEMPO", objCurso.Tiempo)
                command.Parameters.AddWithValue("@FECHA_CURSO", objCurso.FechaCurso)

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
    ''' Elimina un registro de curso
    ''' </summary>
    ''' <param name="IdCurso">ID del estudio a eliminar</param>
    ''' <returns>True o False</returns>
    Public Function Eliminar(IdCurso As Int32) As Boolean

        Sql.Clear()
        Sql.Append("DELETE FROM CURSOS ")
        Sql.Append("WHERE ")
        Sql.Append("ID_CURSO = @ID_CURSO")

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
                command.Parameters.AddWithValue("@ID_CURSO", IdCurso)
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

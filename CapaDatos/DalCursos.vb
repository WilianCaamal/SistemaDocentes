Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalCursos
    Private ReadOnly SqlListaCursos = "SELECT * FROM CURSOS WHERE ID_DOCENTE = @ID_DOCENTE"
    Private ReadOnly SqlCursosAdd = "INSERT INTO CURSOS " +
        "(ID_DOCENTE,NOMBRE_CURSO,INSTITUCION,TIEMPO,FECHA_CURSO) " +
        "VALUES " +
        "(@ID_DOCENTE,@NOMBRE_CURSO,@INSTITUCION,@TIEMPO,@FECHA_CURSO)"
    Private listaCursos As New List(Of Curso)

    Function ListarCursos(IdDocente As Int32) As List(Of Curso)
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = SqlListaCursos,
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

    Function Agregar(objCurso As Curso) As Boolean
        Dim resultado As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = SqlCursosAdd,
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

End Class

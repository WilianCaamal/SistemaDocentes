Imports System.Text
Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalDocentes
    Private Sql As New StringBuilder
    Private ListaDocentes As New List(Of Docente)

    ''' <summary>
    ''' Lista de todos los docentes
    ''' </summary>
    ''' <returns>List Type Docente</returns>
    Public Function ListarDocentes() As List(Of Docente)
        Sql.Clear()
        Sql.Append("SELECT * FROM DOCENTES ORDER BY NOMBRES")
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = Sql.ToString,
                    .Connection = conexion
                }
            Try
                Dim dr As FbDataReader
                dr = command.ExecuteReader()

                While dr.Read
                    Dim objDocente As New Docente With {
                        .IdDocente = dr.GetInt32(0),
                        .Nombres = dr.GetString(1),
                        .Apellidos = dr.GetString(2),
                        .Perfil = dr.GetString(3),
                        .FechaNacimiento = dr.GetDateTime(4)
                    }
                    ListaDocentes.Add(objDocente)
                End While
                dr.Close()

                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return ListaDocentes
    End Function

    ''' <summary>
    ''' Obtiene los datos de un docente
    ''' </summary>
    ''' <param name="IdDocente">Id del docente a consultar</param>
    ''' <returns>Object Type Docente</returns>
    Public Function GetDocenteById(IdDocente As Int32) As Docente

        Sql.Clear()
        Sql.Append("SELECT * FROM DOCENTES ")
        Sql.Append("WHERE ")
        Sql.Append("ID_DOCENTE = @ID_DOCENTE")

        Dim objDocente As New Docente
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
                    Console.WriteLine(dr)
                    objDocente.IdDocente = dr.GetInt32(0)
                    objDocente.Nombres = dr.GetString(1)
                    objDocente.Apellidos = dr.GetString(2)
                    objDocente.Genero = dr.GetString(3)
                    objDocente.FechaNacimiento = dr.GetDateTime(4)
                    objDocente.Curp = dr.GetString(5)
                    objDocente.Direccion = dr.GetString(6)
                    objDocente.IdEstado = dr.GetInt32(7)
                    objDocente.IdCiudad = dr.GetInt32(8)
                    objDocente.Cp = dr.GetString(9)
                    objDocente.Telefono = dr.GetString(10)
                    objDocente.Email = dr.GetString(11)
                    objDocente.Plaza = dr.GetString(12)
                    objDocente.FechaIngreso = dr.GetDateTime(13)
                    objDocente.Perfil = dr.GetString(14)
                    objDocente.Postgrado = dr.GetString(15)
                    objDocente.Area = dr.GetString(16)
                    objDocente.Grado = dr.GetString(17)
                    objDocente.Idiomas = dr.GetString(18)

                    Dim img = dr.GetValue(19)
                    'img = dr.GetValue(19)
                    Console.WriteLine("||||||||||||||||")
                    Console.WriteLine(dr.GetValue(19))
                    If Not (dr.GetValue(19).Equals(DBNull.Value)) Then
                        objDocente.Foto = dr.GetValue(19)
                    End If
                End While
                dr.Close()
                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return objDocente
    End Function

    ''' <summary>
    ''' Agrega un registro en docentes
    ''' </summary>
    ''' <param name="objDocente">Object Type Docente</param>
    ''' <returns>True o False</returns>
    Public Function Agregar(objDocente As Docente) As Boolean

        Sql.Clear()
        Sql.Append("INSERT INTO DOCENTES ")
        Sql.Append("(")
        Sql.Append("NOMBRES, ")
        Sql.Append("APELLIDOS, ")
        Sql.Append("GENERO, ")
        Sql.Append("FECHA_NACIMIENTO, ")
        Sql.Append("CURP, ")
        Sql.Append("DIRECCION, ")
        Sql.Append("ID_ESTADO, ")
        Sql.Append("ID_CIUDAD, ")
        Sql.Append("CP, ")
        Sql.Append("TELEFONO, ")
        Sql.Append("EMAIL, ")
        Sql.Append("PLAZA, ")
        Sql.Append("FECHA_INGRESO, ")
        Sql.Append("PERFIL, ")
        Sql.Append("POSTGRADO, ")
        Sql.Append("AREA, ")
        Sql.Append("GRADO, ")
        Sql.Append("IDIOMAS, ")
        Sql.Append("FOTO")
        Sql.Append(")")
        Sql.Append("VALUES ")
        Sql.Append("(")
        Sql.Append("@NOMBRES,")
        Sql.Append("@APELLIDOS,")
        Sql.Append("@GENERO,")
        Sql.Append("@FECHA_NACIMIENTO,")
        Sql.Append("@CURP,")
        Sql.Append("@DIRECCION,")
        Sql.Append("@ID_ESTADO,")
        Sql.Append("@ID_CIUDAD,")
        Sql.Append("@CP,")
        Sql.Append("@TELEFONO,")
        Sql.Append("@EMAIL,")
        Sql.Append("@PLAZA,")
        Sql.Append("@FECHA_INGRESO,")
        Sql.Append("@PERFIL,")
        Sql.Append("@POSTGRADO,")
        Sql.Append("@AREA,")
        Sql.Append("@GRADO,")
        Sql.Append("@IDIOMAS, ")
        Sql.Append("@FOTO")
        Sql.Append(")")

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
                command.Parameters.AddWithValue("@NOMBRES", objDocente.Nombres)
                command.Parameters.AddWithValue("@APELLIDOS", objDocente.Apellidos)
                command.Parameters.AddWithValue("@GENERO", objDocente.Genero)
                command.Parameters.AddWithValue("@FECHA_NACIMIENTO", objDocente.FechaNacimiento)
                command.Parameters.AddWithValue("@CURP", objDocente.Curp)
                command.Parameters.AddWithValue("@DIRECCION", objDocente.Direccion)
                command.Parameters.AddWithValue("@ID_ESTADO", objDocente.IdEstado)
                command.Parameters.AddWithValue("@ID_CIUDAD", objDocente.IdCiudad)
                command.Parameters.AddWithValue("@CP", objDocente.Cp)
                command.Parameters.AddWithValue("@TELEFONO", objDocente.Telefono)
                command.Parameters.AddWithValue("@EMAIL", objDocente.Email)
                command.Parameters.AddWithValue("@PLAZA", objDocente.Plaza)
                command.Parameters.AddWithValue("@FECHA_INGRESO", objDocente.FechaIngreso)
                command.Parameters.AddWithValue("@PERFIL", objDocente.Perfil)
                command.Parameters.AddWithValue("@POSTGRADO", objDocente.Postgrado)
                command.Parameters.AddWithValue("@AREA", objDocente.Area)
                command.Parameters.AddWithValue("@GRADO", objDocente.Grado)
                command.Parameters.AddWithValue("@IDIOMAS", objDocente.Idiomas)
                command.Parameters.AddWithValue("@FOTO", objDocente.Foto)

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
    ''' Edita un registro de docentes
    ''' </summary>
    ''' <param name="objDocente">Object Type Docente</param>
    ''' <returns>True o False</returns>
    Public Function Editar(objDocente As Docente) As Boolean

        Sql.Clear()
        Sql.Append("UPDATE DOCENTES SET ")
        Sql.Append("NOMBRES = @NOMBRES,")
        Sql.Append("APELLIDOS = @APELLIDOS,")
        Sql.Append("GENERO = @GENERO,")
        Sql.Append("FECHA_NACIMIENTO = @FECHA_NACIMIENTO,")
        Sql.Append("CURP = @CURP,")
        Sql.Append("DIRECCION = @DIRECCION,")
        Sql.Append("ID_ESTADO = @ID_ESTADO,")
        Sql.Append("ID_CIUDAD = @ID_CIUDAD,")
        Sql.Append("CP = @CP,")
        Sql.Append("TELEFONO = @TELEFONO,")
        Sql.Append("EMAIL = @EMAIL,")
        Sql.Append("PLAZA = @PLAZA,")
        Sql.Append("FECHA_INGRESO = @FECHA_INGRESO,")
        Sql.Append("PERFIL = @PERFIL,")
        Sql.Append("POSTGRADO = @POSTGRADO,")
        Sql.Append("AREA = @AREA,")
        Sql.Append("GRADO = @GRADO,")
        Sql.Append("IDIOMAS = @IDIOMAS, ")
        Sql.Append("FOTO = @FOTO ")
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
                command.Parameters.AddWithValue("@NOMBRES", objDocente.Nombres)
                command.Parameters.AddWithValue("@APELLIDOS", objDocente.Apellidos)
                command.Parameters.AddWithValue("@GENERO", objDocente.Genero)
                command.Parameters.AddWithValue("@FECHA_NACIMIENTO", objDocente.FechaNacimiento)
                command.Parameters.AddWithValue("@CURP", objDocente.Curp)
                command.Parameters.AddWithValue("@DIRECCION", objDocente.Direccion)
                command.Parameters.AddWithValue("@ID_ESTADO", objDocente.IdEstado)
                command.Parameters.AddWithValue("@ID_CIUDAD", objDocente.IdCiudad)
                command.Parameters.AddWithValue("@CP", objDocente.Cp)
                command.Parameters.AddWithValue("@TELEFONO", objDocente.Telefono)
                command.Parameters.AddWithValue("@EMAIL", objDocente.Email)
                command.Parameters.AddWithValue("@PLAZA", objDocente.Plaza)
                command.Parameters.AddWithValue("@FECHA_INGRESO", objDocente.FechaIngreso)
                command.Parameters.AddWithValue("@PERFIL", objDocente.Perfil)
                command.Parameters.AddWithValue("@POSTGRADO", objDocente.Postgrado)
                command.Parameters.AddWithValue("@AREA", objDocente.Area)
                command.Parameters.AddWithValue("@GRADO", objDocente.Grado)
                command.Parameters.AddWithValue("@IDIOMAS", objDocente.Idiomas)
                command.Parameters.AddWithValue("@FOTO", objDocente.Foto)
                command.Parameters.AddWithValue("@ID_DOCENTE", objDocente.IdDocente)

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
    ''' Elimina un registro de docentes
    ''' </summary>
    ''' <param name="IdDocente">ID del docente a eliminar</param>
    ''' <returns>True o False</returns>
    Public Function Eliminar(IdDocente As Int32) As Boolean

        Sql.Clear()
        Sql.Append("DELETE FROM DOCENTES ")
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

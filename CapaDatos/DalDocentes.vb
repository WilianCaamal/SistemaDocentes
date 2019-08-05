﻿Imports Entidades
Imports FirebirdSql.Data.FirebirdClient

Public Class DalDocentes
    Private ReadOnly SqlDocentes = "SELECT ID_DOCENTE,NOMBRES,APELLIDOS,PERFIL AS PROFESION,FECHA_NACIMIENTO FROM DOCENTES"
    Private ReadOnly SqlDocenteAdd = "INSERT INTO DOCENTES" +
        " (NOMBRES,APELLIDOS,GENERO,FECHA_NACIMIENTO,CURP,DIRECCION,ID_ESTADO,ID_CIUDAD,CP,TELEFONO,EMAIL,PLAZA,FECHA_INGRESO,PERFIL,POSTGRADO,AREA,GRADO,IDIOMAS) " +
        "VALUES" +
        " (@NOMBRES,@APELLIDOS,@GENERO,@FECHA_NACIMIENTO,@CURP,@DIRECCION,@ID_ESTADO,@ID_CIUDAD,@CP,@TELEFONO,@EMAIL,@PLAZA,@FECHA_INGRESO,@PERFIL,@POSTGRADO,@AREA,@GRADO,@IDIOMAS) "
    Private ReadOnly SqlDocenteEdit = "UPDATE DOCENTES SET" +
        " NOMBRES = @NOMBRES,APELLIDOS = @APELLIDOS,GENERO = @GENERO,FECHA_NACIMIENTO = @FECHA_NACIMIENTO,CURP = @CURP," +
        " DIRECCION = @DIRECCION,ID_ESTADO = @ID_ESTADO,ID_CIUDAD = @ID_CIUDAD,CP = @CP,TELEFONO = @TELEFONO,EMAIL = @EMAIL," +
        " PLAZA = @PLAZA,FECHA_INGRESO = @FECHA_INGRESO,PERFIL = @PERFIL,POSTGRADO = @POSTGRADO,AREA = @AREA,GRADO = @GRADO,IDIOMAS = @IDIOMAS" +
        " WHERE ID_DOCENTE = @ID_DOCENTE"
    Private ReadOnly SqlDocenteEdit2 = "UPDATE DOCENTES SET" +
        " NOMBRES = {0},APELLIDOS = {1},GENERO = {3},FECHA_NACIMIENTO = {4},CURP = {5}," +
        " DIRECCION = {6},ID_ESTADO = {7},ID_CIUDAD = {8},CP = {9},TELEFONO = {10},EMAIL = {11}," +
        " PLAZA = {12},FECHA_INGRESO = {13},PERFIL = {14},POSTGRADO = {15},AREA = {16},GRADO = {17},IDIOMAS = {18}" +
        " WHERE ID_DOCENTE = {19}"
    Private ReadOnly SqlDocenteById = "SELECT * FROM DOCENTES WHERE ID_DOCENTE = {0}"
    Private ReadOnly SqlDocenteDelete = "DELETE FROM DOCENTES WHERE ID_DOCENTE = @ID_DOCENTE"
    Private ListaDocentes As New List(Of Docente)

    Public Function ListarDocentes() As List(Of Docente)
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = SqlDocentes,
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

    Public Function GetDocenteById(Id As Int32) As Docente
        Dim objDocente As New Docente
        Using conexion As New FbConnection
            conexion.ConnectionString = My.Settings.cadenaConexion
            conexion.Open()
            Dim command As New FbCommand With {
                    .CommandText = String.Format(SqlDocenteById, Id),
                    .Connection = conexion
                }
            Try
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

                End While
                dr.Close()
                command.Dispose()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
        Return objDocente
    End Function

    Public Function Agregar(objDocente As Docente) As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = SqlDocenteAdd,
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

    Public Function Editar(objDocente As Docente) As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = SqlDocenteEdit,
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

    Public Function Eliminar(Id As Int32) As Boolean
        Using Conexion As New FbConnection
            Conexion.ConnectionString = My.Settings.cadenaConexion
            Dim transaccion As FbTransaction
            Conexion.Open()
            transaccion = Conexion.BeginTransaction
            Dim command As New FbCommand With {
                    .CommandText = SqlDocenteDelete,
                    .Connection = Conexion,
                    .Transaction = transaccion
                }
            Try
                command.Parameters.AddWithValue("@ID_DOCENTE", Id)
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
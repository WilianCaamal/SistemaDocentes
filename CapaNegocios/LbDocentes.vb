Imports Entidades
Imports CapaDatos

Public Class LbDocentes
    Dim objDocentes As New DalDocentes

    Public Function ListarDocentes() As List(Of Docente)
        Return objDocentes.ListarDocentes()
    End Function

    Public Function GetDocenteById(id As Int32) As Docente
        Return objDocentes.GetDocenteById(id)
    End Function

    Public Function Agregar(objDocente As Docente) As Boolean
        Dim _error As String = ""
        If objDocente.Nombres = String.Empty Then
            _error += " Nombres"
        End If
        If objDocente.Apellidos = String.Empty Then
            _error += ", Apellidos"
        End If
        If objDocente.Curp = String.Empty Then
            _error += ", CURP"
        End If
        If objDocente.Perfil = String.Empty Then
            _error += ", Perfil"
        End If

        If _error.Length > 0 Then
            Throw New Exception("Los siguientes campos no pueden estar vacios: " + vbNewLine + _error.Substring(1))
        End If

        Return objDocentes.Agregar(objDocente)
    End Function

    Public Function Editar(objDocente As Docente) As Boolean
        Dim _error As String = ""
        If objDocente.Nombres = String.Empty Then
            _error += " Nombres"
        End If
        If objDocente.Apellidos = String.Empty Then
            _error += ", Apellidos"
        End If
        If objDocente.Curp = String.Empty Then
            _error += ", CURP"
        End If
        If objDocente.Perfil = String.Empty Then
            _error += ", Perfil"
        End If
        If _error.Length > 0 Then
            Throw New Exception("Los siguientes campos no pueden estar vacios: " + vbNewLine + _error.Substring(1))
        End If

        Return objDocentes.Editar(objDocente)
    End Function

    Public Function Eliminar(Id As Int32) As Boolean
        Return objDocentes.Eliminar(Id)
    End Function

    Public Function Buscar(busqueda As String) As List(Of Docente)
        Return objDocentes.Buscar(busqueda)
    End Function

End Class

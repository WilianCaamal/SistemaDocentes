Imports CapaDatos
Imports Entidades
Public Class LbEstudios
    Dim objEstudios As New DalEstudios
    Public Function ListarEstudios(IdDocente As Int32) As List(Of Estudio)
        Return objEstudios.ListarEstudios(IdDocente)
    End Function

    Public Function Agregar(objEstudio As Estudio) As Boolean
        Dim _error As String = ""
        If objEstudio.Nombre = String.Empty Then
            _error += " Nombres"
        End If
        If objEstudio.ExpDocente = String.Empty Then
            _error += ", Experiencia docente"
        End If
        If objEstudio.ExpProfesional = String.Empty Then
            _error += ", Experiencia Profesional"
        End If

        If _error.Length > 0 Then
            Throw New Exception("Los siguientes campos no pueden estar vacios: " + vbNewLine + _error.Substring(1))
        End If

        Return objEstudios.Agregar(objEstudio)
    End Function

    Public Function GetEstudioById(IdEstudio As Int32) As Estudio
        Return objEstudios.GetEstudioById(IdEstudio)
    End Function

    Public Function Editar(objEstudio As Estudio) As Boolean
        Dim _error As String = ""
        If objEstudio.Nombre = String.Empty Then
            _error += " Nombres"
        End If
        If objEstudio.ExpDocente = String.Empty Then
            _error += ", Experiencia docente"
        End If
        If objEstudio.ExpProfesional = String.Empty Then
            _error += ", Experiencia Profesional"
        End If

        If _error.Length > 0 Then
            Throw New Exception("Los siguientes campos no pueden estar vacios: " + vbNewLine + _error.Substring(1))
        End If
        Return objEstudios.Editar(objEstudio)
    End Function

    Public Function Eliminar(Id As Int32)
        Return objEstudios.Eliminar(Id)
    End Function

End Class

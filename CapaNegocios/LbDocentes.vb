﻿Imports Entidades
Imports CapaDatos

Public Class LbDocentes
    Dim objDocentes As New DalDocentes

    Public Function ListarDocentes() As List(Of Docente)
        Return objDocentes.ListarDocentes()
    End Function

    Public Function GetDocenteById(id As Int32)
        Return objDocentes.GetDocenteById(id)
    End Function

    Public Function Agregar(objDocente As Docente)
        Return objDocentes.Agregar(objDocente)
    End Function

    Public Function Editar(objDocente As Docente)
        Return objDocentes.Editar(objDocente)
    End Function

    Public Function Eliminar(Id As Int32)
        Return objDocentes.Eliminar(Id)
    End Function

End Class
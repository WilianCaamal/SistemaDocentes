Imports System.IO

Public Class Docente
    Property IdDocente As Int32
    Property Nombres As String
    Property Apellidos As String
    Property Genero As String
    Property FechaNacimiento As DateTime
    Property Curp As String
    Property Direccion As String
    Property IdEstado As Int32
    Property IdCiudad As Int32
    Property Cp As String
    Property Telefono As String
    Property Email As String
    Property Plaza As String
    Property FechaIngreso As DateTime
    Property Perfil As String
    Property Postgrado As String
    Property Area As String
    Property Grado As String
    Property Idiomas As String
    Property Foto As Byte()

    Private edadDocente As Int32
    Property Edad As Int32
        Get
            Return (DateTime.Now.Year - FechaNacimiento.Year)
        End Get
        Set(ByVal value As Int32)
            edadDocente = value
        End Set
    End Property
End Class

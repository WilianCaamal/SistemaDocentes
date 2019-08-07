Imports Entidades
Imports CapaNegocios
Public Class rptUpdateDocente

    Property IdDocente As Int32
    Dim objDocente As New Docente
    Dim objLbDocente As New LbDocentes
    Dim objEstado As New Estado
    Dim objLbEstado As New LbEstados
    Dim objMunicipio As New Municipio
    Dim objLbMunicipio As New LbMunicipios

    Private Sub rptUpdateDocente_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        objDocente = objLbDocente.GetDocenteById(IdDocente)
        objEstado = objLbEstado.EstadoById(objDocente.IdEstado)
        objMunicipio = objLbMunicipio.MunicipioById(objDocente.IdCiudad)

        NombreDocente.Value = objDocente.Nombres + " " + objDocente.Apellidos
        Nombres.Value = objDocente.Nombres
        Apellidos.Value = objDocente.Apellidos
        Genero.Value = objDocente.Genero
        FechaNacimiento.Value = objDocente.FechaNacimiento
        Curp.Value = objDocente.Curp
        Direccion.Value = objDocente.Direccion
        Ciudad.Value = objMunicipio.Nombre
        Cp.Value = objDocente.Cp
        Estado.Value = objEstado.Nombre
        Telefono.Value = objDocente.Telefono
        ClavePlaza.Value = objDocente.Plaza
        FechaIngreso.Value = objDocente.FechaIngreso
        Perfil.Value = objDocente.Perfil
        Postgrado.Value = objDocente.Postgrado
        Ciudad.Value = objMunicipio.Nombre
        Estado.Value = objEstado.Nombre
        Area.Value = objDocente.Area
        GradoAcademico.Value = objDocente.Grado
        Idiomas.Value = objDocente.Idiomas
        Dim edadAnio = (DateTime.Now.Year - objDocente.FechaNacimiento.Year).ToString + "Años, "
        Dim edadMeses = (DateTime.Now.Month - objDocente.FechaNacimiento.Month).ToString + "Meses, "
        Dim edadDias = (DateTime.Now.Day - objDocente.FechaNacimiento.Day).ToString + "Dias."
        EdadActual.Value = edadAnio + edadMeses + edadDias
        'AniosServicio
    End Sub
End Class
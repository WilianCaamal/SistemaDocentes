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
        FechaNacimiento.Value = objDocente.FechaNacimiento.ToString("d")
        Curp.Value = objDocente.Curp
        Direccion.Value = objDocente.Direccion
        Ciudad.Value = objMunicipio.Nombre
        Cp.Value = objDocente.Cp
        Estado.Value = objEstado.Nombre
        Telefono.Value = objDocente.Telefono
        ClavePlaza.Value = objDocente.Plaza
        FechaIngreso.Value = objDocente.FechaIngreso.ToString("d")
        Perfil.Value = objDocente.Perfil
        Postgrado.Value = objDocente.Postgrado
        Ciudad.Value = objMunicipio.Nombre
        Area.Value = objDocente.Area
        GradoAcademico.Value = objDocente.Grado
        Idiomas.Value = objDocente.Idiomas

        EdadActual.Value = FechasRestas(objDocente.FechaNacimiento)
        AniosServicio.Value = FechasRestas(objDocente.FechaIngreso)
    End Sub

    Private Function FechasRestas(fecha As DateTime) As String
        Dim años, meses, dias, dias_sobran As Integer
        Dim años_str, meses_str, dias_str As String
        Dim PriFec As Date = fecha
        Dim SecFec As Date = DateTime.Now
        Dim DiasTotales As Long = DateDiff(DateInterval.Day, PriFec, SecFec)
        años = DiasTotales \ 365
        dias_sobran = DiasTotales Mod 365
        meses = dias_sobran \ 30
        dias = dias_sobran Mod 30
        If (años > 0) Then
            años_str = años & " año(s) "
        Else
            años_str = ""
        End If
        If (meses > 0) Then
            meses_str = meses & " mes(es) "
        Else
            meses_str = ""
        End If
        If (dias > 0) Then
            dias_str = dias & " dia(s)"
        Else
            dias_str = ""
        End If
        Return Trim(años_str & meses_str & dias_str)
    End Function
End Class
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports Capa_servicios

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function
    <WebMethod()>
    Public Function ListarFaculdates() As List(Of ModeloFacultad)
        Dim obj_facultad As New facultad
        Return obj_facultad.ListarFaculdates()
    End Function

    <WebMethod()>
    Public Function ListarEstudiantes() As DataSet
        Dim objEstudiante As New Estudiante
        Return objEstudiante.Listar()
    End Function

    <WebMethod()>
    Public Function BuscarEstudiantes(cedula As String) As DataSet
        Dim objEstudiante As New Estudiante
        Return objEstudiante.Buscar(cedula)
    End Function

    <WebMethod()>
    Public Function BuscarCarreras(facultad As String) As DataSet
        Dim obj_facultad As New facultad
        Return obj_facultad.BuscarCarreras(facultad)
    End Function

    <WebMethod()>
    Public Function CrearEstudiantes(estudiante As modeloEstudiante) As Boolean
        Dim objEstudiante As New Estudiante
        Return objEstudiante.crearEstudiante(estudiante)
    End Function

    <WebMethod()>
    Public Function ActualizarEstudiantes(estudiante As modeloEstudiante) As Boolean
        Dim objEstudiante As New Estudiante
        Return objEstudiante.actualizarEstudiante(estudiante)
    End Function

    <WebMethod()>
    Public Function EliminarEstudiantes(cedula As String) As Boolean
        Dim objEstudiante As New Estudiante
        Return objEstudiante.Delete(cedula)
    End Function

    <WebMethod()>
    Public Function Validarcorreo(value As String) As Boolean
        Dim objValidate As New Validate
        Return objValidate.Validarcorreo(value)
    End Function

    <WebMethod()>
    Public Function ValidarLetras(value As String) As Boolean
        Dim objValidate As New Validate
        Return objValidate.ValidarLetras(value)
    End Function

    <WebMethod()>
    Public Function ValidarNumero(value As String) As Boolean
        Dim objValidate As New Validate
        Return objValidate.ValidarNumero(value)
    End Function

End Class
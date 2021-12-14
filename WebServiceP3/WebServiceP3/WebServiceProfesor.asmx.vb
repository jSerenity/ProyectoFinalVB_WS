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
Public Class WebServiceProfesor
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
    Public Function ListarCategoria() As DataSet
        Dim obj_profesor As New Profesor
        Return obj_profesor.ListarCategoria()
    End Function

    <WebMethod()>
    Public Function ListarProfesores() As DataSet
        Dim objProfesor As New Profesor
        Return objProfesor.Listar()
    End Function

    <WebMethod()>
    Public Function BuscarProfesors(codigo As String) As DataSet
        Dim objProfesor As New Profesor
        Return objProfesor.Buscar(codigo)
    End Function

    <WebMethod()>
    Public Function CrearProfesor(profesor As ModeloProfesor) As Boolean
        Dim objProfesor As New Profesor
        Return objProfesor.CrearProfesor(profesor)
    End Function
    <WebMethod()>
    Public Function ActuaizarProfesor(profesor As ModeloProfesor) As Boolean
        Dim objProfesor As New Profesor
        Return objProfesor.ActualizarProfesor(profesor)
    End Function

    <WebMethod()>
    Public Function EliminarProfesor(profesor As String) As Boolean
        Dim objProfesor As New Profesor
        Return objProfesor.Delete(profesor)
    End Function
End Class

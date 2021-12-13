Public Class modeloEstudiante

    Public Cedula As String
    Public Nombre As String
    Public Apellido As String
    Public Direccion As String
    Public celular As String
    Public correo As String
    Public cod_facultad As String
    Public cod_carrera As String
    Public indice_academico As String
    Public sexo As String
    Public estatus As String

    Public Sub New(cedulap As String, nombrep As String, apellidop As String, direccionp As String, celularp As String, correop As String, cod_facultadp As String,
            cod_carrerap As String, indice_academicop As String, sexop As String, estatusp As String)
        Cedula = cedulap
        Nombre = nombrep
        Apellido = apellidop
        Direccion = direccionp
        celular = celularp
        correo = correop
        cod_facultad = cod_facultadp
        cod_carrera = cod_carrerap
        indice_academico = indice_academicop
        sexo = sexop
        estatus = estatusp
    End Sub
    Public Sub New()

    End Sub
End Class

Public Class ModeloProfesor
    Public Cedula As String
    Public codigo As String
    Public Nombre As String
    Public Apellido As String
    Public Direccion As String
    Public celular As String
    Public correo As String
    Public cod_facultad As String
    Public cod_categoria As String
    Public salario As String
    Public estatus As String
    Public Sub New()

    End Sub
    Public Sub New(cedulap As String,
                   nombrep As String,
                   apellidop As String,
                   direccionp As String,
                   celularp As String,
                   correop As String,
                   cod_facultadp As String,
                   categoriap As String,
                   salariop As String,
                   codigop As String,
                   estatusp As String)
        Cedula = cedulap
        Nombre = nombrep
        Apellido = apellidop
        Direccion = direccionp
        celular = celularp
        correo = correop
        cod_facultad = cod_facultadp
        cod_categoria = categoriap
        salario = salariop
        codigo = codigop
        estatus = estatusp
    End Sub
End Class

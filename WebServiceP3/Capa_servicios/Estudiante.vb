Imports System.Data
Imports System.Data.SqlClient
Imports Capa_Datos
Public Class Estudiante
    Dim DB As BD
    Dim command As SqlCommand
    Public Sub New()
        DB = New BD
    End Sub
    Public Function Listar() As DataSet
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("SP_Listar_Estudiante", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            Dim sqlAdapter As New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()

        End Try

    End Function
    Public Function Buscar(cedula As String) As DataSet
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("Estudianteinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", cedula)
            command.Parameters.AddWithValue("@tipoOperacion", "Select")
            Dim sqlAdapter As New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()
        End Try
    End Function
    Public Function crearEstudiante(estudiante As modeloEstudiante) As Boolean
        Dim ds As New DataSet
        Try
            DB.connection.Open()
            command = New SqlCommand("Estudianteinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", estudiante.Cedula)

            command.Parameters.AddWithValue("@nombre", estudiante.Nombre)
            command.Parameters.AddWithValue("@apellido", estudiante.Apellido)
            command.Parameters.AddWithValue("@direccion", estudiante.Direccion)
            command.Parameters.AddWithValue("@celular", estudiante.celular)
            command.Parameters.AddWithValue("@correo", estudiante.correo)
            command.Parameters.AddWithValue("@cod_facultad", estudiante.cod_facultad)
            command.Parameters.AddWithValue("@cod_carrera", estudiante.cod_carrera)
            command.Parameters.AddWithValue("@indice_academico", estudiante.indice_academico)
            command.Parameters.AddWithValue("@sexo", estudiante.sexo)
            command.Parameters.AddWithValue("@estatus", estudiante.estatus)

            command.Parameters.AddWithValue("@tipoOperacion", "Insert")
            Dim count As Int32 = command.ExecuteNonQuery()
            If (count > 0) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
            Return False
        Finally
            DB.connection.Close()
        End Try
    End Function
    Public Function actualizarEstudiante(estudiante As modeloEstudiante) As Boolean
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("Estudianteinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", estudiante.Cedula)

            command.Parameters.AddWithValue("@nombre", estudiante.Nombre)
            command.Parameters.AddWithValue("@apellido", estudiante.Apellido)
            command.Parameters.AddWithValue("@direccion", estudiante.Direccion)
            command.Parameters.AddWithValue("@celular", estudiante.celular)
            command.Parameters.AddWithValue("@correo", estudiante.correo)
            command.Parameters.AddWithValue("@cod_facultad", estudiante.cod_facultad)
            command.Parameters.AddWithValue("@cod_carrera", estudiante.cod_carrera)
            command.Parameters.AddWithValue("@indice_academico", estudiante.indice_academico)
            command.Parameters.AddWithValue("@sexo", estudiante.sexo)
            command.Parameters.AddWithValue("@estatus", estudiante.estatus)

            command.Parameters.AddWithValue("@tipoOperacion", "Update")
            Dim count As Int32 = command.ExecuteNonQuery()
            If (count > 0) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
            Return False
        Finally
            DB.connection.Close()
        End Try
    End Function
    Public Function Delete(cedula As String) As Boolean
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("Estudianteinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", cedula)
            command.Parameters.AddWithValue("@tipoOperacion", "Delete")
            Dim count As Int32 = command.ExecuteNonQuery()
            If (count > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()
        End Try
    End Function
End Class

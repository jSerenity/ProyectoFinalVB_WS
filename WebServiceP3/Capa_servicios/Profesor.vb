Imports System.Data
Imports System.Data.SqlClient
Imports Capa_Datos
Public Class Profesor
    Dim DB As BD
    Dim command As SqlCommand
    Public Sub New()
        DB = New BD
    End Sub
    Public Function Listar() As DataSet
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("SP_Listar_Profesores", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            Dim sqlAdapter As SqlDataAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()
        End Try
    End Function
    Public Function ListarCategoria() As DataSet
        Dim dt As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("SP_Listar_Categoria", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            Dim sqlAdapter As SqlDataAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(dt)
            DB.connection.Close()
            Return dt
        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()
        End Try
    End Function

    Public Function Buscar(codigo As String) As DataSet
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("Profesorinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@codigo", codigo)
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
    Public Function CrearProfesor(profesor As ModeloProfesor) As Boolean
        Dim ds As New DataSet
        Try
            DB.connection.Open()
            command = New SqlCommand("Profesorinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", profesor.Cedula)

            command.Parameters.AddWithValue("@nombre", profesor.Nombre)
            command.Parameters.AddWithValue("@apellido", profesor.Apellido)
            command.Parameters.AddWithValue("@direccion", profesor.Direccion)
            command.Parameters.AddWithValue("@celular", profesor.celular)
            command.Parameters.AddWithValue("@correo", profesor.correo)
            command.Parameters.AddWithValue("@cod_facultad", profesor.cod_facultad)
            command.Parameters.AddWithValue("@codigo", profesor.codigo)
            command.Parameters.AddWithValue("@cod_categoria", profesor.cod_categoria)
            command.Parameters.AddWithValue("@salario_base", profesor.salario)
            command.Parameters.AddWithValue("@estatus", profesor.estatus)

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
    Public Function ActualizarProfesor(profesor As ModeloProfesor) As Boolean
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("Profesorinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cedula", profesor.Cedula)
            command.Parameters.AddWithValue("@codigo", profesor.codigo)

            command.Parameters.AddWithValue("@nombre", profesor.Nombre)
            command.Parameters.AddWithValue("@apellido", profesor.Apellido)
            command.Parameters.AddWithValue("@direccion", profesor.Direccion)
            command.Parameters.AddWithValue("@celular", profesor.celular)
            command.Parameters.AddWithValue("@correo", profesor.correo)
            command.Parameters.AddWithValue("@cod_facultad", profesor.cod_facultad)

            command.Parameters.AddWithValue("@cod_categoria", profesor.cod_categoria)
            command.Parameters.AddWithValue("@salario_base", profesor.salario)
            command.Parameters.AddWithValue("@estatus", profesor.estatus)


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
    Public Function Delete(codigo As String) As Boolean
        Dim ds As New DataSet

        Try
            DB.connection.Open()
            command = New SqlCommand("Profesorinsertupdatedelete", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@codigo", codigo)
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

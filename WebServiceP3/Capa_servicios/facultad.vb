Imports System.Data
Imports System.Data.SqlClient
Imports Capa_Datos
Public Class facultad
    Dim DB As BD
    Dim command As SqlCommand
    Public Sub New()
        DB = New BD
    End Sub
    Public Function ListarFaculdates() As List(Of ModeloFacultad)
        Dim dt As New DataSet
        Dim listaFacultades As New List(Of ModeloFacultad)

        Try
            DB.connection.Open()
            command = New SqlCommand("SP_Listar_Facultades", DB.connection)
            command.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = command.ExecuteReader()
            'Dim sqlAdapter = New SqlDataAdapter(command)
            While reader.Read()
                Dim facultad As New ModeloFacultad()
                facultad.Codigo = Convert.ToString(reader.Item(0))
                facultad.Facultad = Convert.ToString(reader.Item(1))
                listaFacultades.Add(facultad)
            End While

            'sqlAdapter.Fill(dt)
            DB.connection.Close()
            Return listaFacultades

        Catch ex As Exception
            Console.WriteLine("error" + ex.ToString)
        Finally
            DB.connection.Close()
        End Try
    End Function
    Public Function BuscarCarreras(codigo As String) As DataSet
        Dim dt As New DataSet

        Try
            DB.connection.Open()
            Dim sql As String = "select a.cod_carrera,a.carrera from Carrera a inner join Facultad b
                                  on a.cod_facultad = b.codigo
                                  where a.cod_facultad=@codigo"
            command = New SqlCommand(sql, DB.connection)
            command.CommandType = CommandType.Text
            command.Parameters.AddWithValue("@codigo", codigo)
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
End Class

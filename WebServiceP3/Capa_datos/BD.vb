Imports System.Data.SqlClient

Public Class BD
    Dim connectionstring As String
    Public connection As SqlConnection
    Public Sub New()
        connectionstring = "Data Source=LAPTOP-AC4304LP\SQLEXPRESS;database=PROYECTO2;Integrated Security=SSPI;persist security info=True;"
        connection = New SqlConnection(connectionstring)
    End Sub
End Class

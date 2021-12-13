Public Class Validate
	Function Validarcorreo(ByVal emailAddress As String) As Boolean
		Dim valid As Boolean = True
		Try
			If Not String.IsNullOrEmpty(emailAddress) Then
				Dim a = New System.Net.Mail.MailAddress(emailAddress)
			Else
				valid = False
			End If

		Catch ex As FormatException
			valid = False
		End Try
		Return valid
	End Function

	Function ValidarLetras(ByVal value As String) As Boolean
		Dim valid As Boolean = True
		Try
			If String.IsNullOrEmpty(value) Then
				valid = False
			Else
				If Not System.Text.RegularExpressions.Regex.IsMatch(value, "^[a-zA-Z\s]*$") Then
					valid = False
				End If
			End If



		Catch ex As FormatException
			valid = False
		End Try
		Return valid
	End Function
	Function ValidarNumero(ByVal value As String) As Boolean
		Dim valid As Boolean = True
		Try
			If String.IsNullOrEmpty(value) Then
				valid = False
			Else
				For index As Integer = 0 To value.Length - 1
					If Not Char.IsNumber(value, index) Then
						valid = False
					End If

				Next
			End If


		Catch ex As FormatException
			valid = False
		End Try
		Return valid
	End Function
End Class

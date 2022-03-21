Imports System.Text
Imports MySql.Data.MySqlClient
Namespace Services.Database
    Public Class MysqlConnectionHelpersService
        Private ReadOnly dbConnection As MySqlConnection
        Private ReadOnly dbConnectionService As MysqlConnectionService

        Public Function EscapeString(value As Object) As String
            If TypeOf value Is Boolean Then
                If CType(value, Boolean) = True Then
                    Return "1"
                Else
                    Return "0"
                End If
            ElseIf TypeOf (value) Is Date Then
                Return "'" + CType(value, Date).ToString("yyyy-MM-dd") + "'"
            Else
                If value Is Nothing Then
                    Return "''"
                Else
                    If String.IsNullOrEmpty(value.ToString) Then
                        Return "''"
                    Else
                        Return "'" + value.ToString.Replace("'", "''").Replace("\", "\\") + "'"
                    End If
                End If
            End If
        End Function

        Public Sub New(connection As MySqlConnection, connectionService As MysqlConnectionService)
            dbConnection = connection
            dbConnectionService = connectionService
        End Sub
        ''' <summary>
        ''' Inserts a record or updates a record based on the specified id
        ''' </summary>
        ''' <param name="table">Target table you want to update or insert a record</param>
        ''' <param name="id">The id of the row you want to update</param>
        ''' <param name="idColumn">The name of the column that must be used for the id</param>
        ''' <returns>Id of the last inserted row</returns>
        Public Function UpdateOrInsertBasedOnParameters(table As String, Optional id As Integer = 0, Optional idColumn As String = "id") As Integer
            Dim queryBuilder As New StringBuilder
            Dim finalQuery As String
            Dim parameterCount As Integer
            Dim parameterIndex As Integer = 1

            Dim columns As New StringBuilder
            Dim columnValues As New StringBuilder

            If id <> 0 Then
                parameterCount = dbConnectionService.Parameters.Count

                ' Create the query syntax
                queryBuilder.Append("UPDATE `" & table & "`")

                ' Add the specified parameters to the query
                For Each pair As KeyValuePair(Of String, String) In dbConnectionService.Parameters
                    If parameterIndex = 1 Then queryBuilder.Append(" SET ")

                    If parameterIndex = parameterCount Then
                        queryBuilder.Append("`" & pair.Key.Replace("?", "") & "` = " & EscapeString(pair.Value))
                    Else
                        queryBuilder.Append("`" & pair.Key.Replace("?", "") & "` = " & EscapeString(pair.Value) & ",")
                    End If

                    parameterIndex = parameterIndex + 1
                Next

                ' Add the where statement to the query
                queryBuilder.Append(" WHERE " & idColumn & " = " & EscapeString(id))

                ' Render the query and replace the variables
                finalQuery = queryBuilder.ToString()
                finalQuery = dbConnectionService.DoParameterReplacements(finalQuery)
            Else
                parameterCount = dbConnectionService.Parameters.Count

                ' Create the query syntax
                queryBuilder.Append("INSERT INTO " & table)

                ' Add the specified parameters to the query
                For Each pair As KeyValuePair(Of String, String) In dbConnectionService.Parameters
                    If parameterIndex = parameterCount Then
                        columns.Append(pair.Key.Replace("?", ""))
                        columnValues.Append(EscapeString(pair.Value))
                    Else
                        columns.Append(pair.Key.Replace("?", "") & ",")
                        columnValues.Append(EscapeString(pair.Value) & ",")
                    End If

                    parameterIndex = parameterIndex + 1
                Next

                ' Add the where statement to the query
                queryBuilder.Append(" (" & columns.ToString & ") ")
                queryBuilder.Append("VALUES (" & columnValues.ToString & ")")

                ' Render the query and replace the variables
                finalQuery = queryBuilder.ToString()
                finalQuery = dbConnectionService.DoParameterReplacements(finalQuery)
            End If

            ' Execute the rendered query
            dbConnectionService.ExecuteQuery(finalQuery)

            ' Return the last insert ID
            Return dbConnectionService.GetLastInsertId()
        End Function
    End Class
End Namespace
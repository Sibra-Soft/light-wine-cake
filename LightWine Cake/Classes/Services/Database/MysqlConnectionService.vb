Imports MySql.Data.MySqlClient
Imports System.Text
Namespace Services.Database
    Public Class MysqlConnectionService
        Implements IDisposable

        Public Helpers As New MysqlConnectionHelpersService(_connection, Me)
        Public Parameters As New Dictionary(Of String, String)

        Private ReadOnly AffectedRowCount As Integer = 0

        Private _disposedValue As Boolean
        Private _RowCount = 0
        Private _firstRow As DataRow
        Private _connection As MySqlConnection
        Private _command As MySqlCommand

        Public Sub PushParameters(parameters As Dictionary(Of String, String))
            parameters = parameters
        End Sub
        Public Function CheckConnectionAndConnect(connectionString As String)
            Try
                Console.WriteLine("Connecting to MySQL...")

                _connection = New MySqlConnection(connectionString)
                _connection.Open()

            Catch ex As Exception

                _connection.Close()
                Return False

            End Try

            Return True
        End Function
        ''' <summary>
        ''' Gets the first row of the current dataset
        ''' </summary>
        ''' <typeparam name="myType">The datatype the current selected value must be casted to</typeparam>
        ''' <param name="column">The name of the column you want to select the data</param>
        ''' <returns>The data of the selected column of the firstrow</returns>
        Public Function DatasetFirstRow(Of myType)(column As String) As myType
            Dim value As Object

            If _firstRow Is Nothing OrElse IsDBNull(_firstRow(column)) Then
                Return Nothing
            Else
                If GetType(myType) = GetType(Boolean) Then
                    value = _firstRow(column)
                    value = Convert.ToInt32(value)
                    value = Convert.ToBoolean(value)

                    Return DirectCast(value, myType)
                ElseIf GetType(myType) = GetType(Integer) Then
                    value = _firstRow(column)
                    value = Convert.ToInt32(value)
                    Return DirectCast(value, myType)
                ElseIf GetType(myType) = GetType(String) Then
                    value = _firstRow(column)
                    value = Convert.ToString(value)
                    Return DirectCast(value, myType)
                ElseIf GetType(myType) = GetType(Long) Then
                    value = _firstRow(column)
                    value = Convert.ToInt64(value)
                    Return DirectCast(value, myType)
                Else
                    Return DirectCast(_firstRow(column), myType)
                End If
            End If
        End Function
        ''' <summary>
        ''' Gets the last id of the inserted row
        ''' </summary>
        ''' <returns>The id of the last inserted row</returns>
        Public Function GetLastInsertId() As Integer
            Dim lastInsertId As Integer = 0

            GetDataset("SELECT LAST_INSERT_ID() AS `insert_id`;")
            lastInsertId = DatasetFirstRow(Of Integer)("insert_id")

            Return lastInsertId
        End Function

        ''' <summary>
        ''' Executes a specified query
        ''' </summary>
        ''' <param name="query">The query that must be executed</param>
        Public Sub ExecuteQuery(query As String)
            _command = New MySqlCommand With {
                .CommandText = DoParameterReplacements(query),
                .Connection = _connection
            }

            _command.ExecuteNonQuery()
        End Sub
        ''' <summary>
        ''' Clears all the parameters
        ''' </summary>
        Public Sub ClearParameters()
            Parameters.Clear()
        End Sub
        ''' <summary>
        ''' Adds a parameter, that can be used in queries
        ''' </summary>
        ''' <typeparam name="myType">The datatype of the new parameter</typeparam>
        ''' <param name="name">The name of the parameter</param>
        ''' <param name="value">The value of the parameter</param>
        Public Sub AddParameter(name As String, value As String)
            Parameters.Add(name, value)
        End Sub

        Public Function DoParameterReplacements(query As String) As String
            Dim resultString As New StringBuilder()

            ' Add the query to the stringbuilder
            resultString.Append(query)

            ' Loop trought the parameters and replace them in the specified query
            For Each parameter In Parameters
                resultString.Replace("?" & parameter.Key, Helpers.EscapeString(parameter.Value))
            Next

            ' Return the rendered query
            Return resultString.ToString()
        End Function
        ''' <summary>
        ''' Gets a dataset, based on the specified query
        ''' </summary>
        ''' <param name="query">The query that must be executed</param>
        ''' <returns>The dataset of the executed query</returns>
        Public Function GetDataset(query As String) As DataSet
            _command = New MySqlCommand With {
                .CommandText = Me.DoParameterReplacements(query),
                .Connection = _connection
            }

            Dim adapter As New MySqlDataAdapter(_command)
            Dim dataset As New DataSet()

            adapter.Fill(dataset)

            _RowCount = dataset.Tables(0).Rows.Count
            If RowCount() > 0 Then _firstRow = dataset.Tables(0).Rows(0)

            Return dataset
        End Function
        ''' <summary>
        ''' Returns the rowcount of the current query result
        ''' </summary>
        ''' <returns>The amount of rows</returns>
        Public Function RowCount() As Integer
            Return _RowCount
        End Function

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not _disposedValue Then
                If disposing Then

                End If
            End If
            _disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
        End Sub
    End Class
End Namespace
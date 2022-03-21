Imports Newtonsoft.Json

Public Class SmtpSettingsModel
    Public Host As String = ""
    Public Port As Integer = 25
    Public Username As String = ""
    Public Password As String = ""

    <JsonProperty("from_name")>
    Public FromName As String = ""
    <JsonProperty("from_address")>
    Public FromAddress As String = ""
End Class

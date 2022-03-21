Imports Newtonsoft.Json

Public Class WebsiteProjectModel
    Public Name As String
    Public ProjectLocation As String
    Public ProjectFile As String

    <JsonProperty("cache_folder")>
    Public CacheFolder As String = "~/cache/"
    Public Environment As String
    Public Tracing As Boolean
    Public Domain As String

    <JsonProperty("log_traffic")>
    Public LogTraffic As Boolean
    <JsonProperty("create_debug_log")>
    Public CreateDebugLog As Boolean
    <JsonProperty("log_database")>
    Public LogDatabase As Boolean
    <JsonProperty("gzip_encode")>
    Public GzipEncode As Boolean

    Public Connections As New WebsiteProjectConnectionsModel
    Public Smtp As New SmtpSettingsModel
End Class

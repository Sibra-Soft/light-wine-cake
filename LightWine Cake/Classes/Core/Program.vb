Imports System.IO
Imports Newtonsoft.Json
Public Class Program
    Public Shared Projects As New List(Of WebsiteProjectModel)
    Public Shared Function CheckIfProjectExistsBasedOnDomain(domain As String) As Boolean
        Return Projects.Where(Function(x) x.Domain = domain).Count > 0
    End Function
    Public Shared Sub LoadProjects()
        Dim groupFile As String = Application.StartupPath & "\projects.json"

        If File.Exists(groupFile) Then
            Dim json = File.ReadAllText(groupFile)
            Projects = JsonConvert.DeserializeObject(Of List(Of WebsiteProjectModel))(json)
        Else
            Projects = New List(Of WebsiteProjectModel)
        End If
    End Sub
    Public Shared Sub SaveProjects()
        Dim output = JsonConvert.SerializeObject(Projects)
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\projects.json", False)
        file.WriteLine(output)
        file.Close()
    End Sub
    Public Shared Sub Main(ByVal args() As String)
        Application.EnableVisualStyles()
        Application.Run(Form_Main)
    End Sub
End Class

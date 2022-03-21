Public Class WebServerService
    Public debugSession As Process
    Public isRunning As Boolean
    Public Sub StartServer(docPath As String, Optional port As Integer = 80, Optional openUrl As Boolean = False)
        Dim procStartInfo As New ProcessStartInfo
        Dim procExecuting As New Process

        ' Start the webserver
        With procStartInfo
            .UseShellExecute = False
            .FileName = Application.StartupPath & "\web_server\wwebserver_cmd.exe"
            .WindowStyle = ProcessWindowStyle.Hidden
            .CreateNoWindow = True
            .WorkingDirectory = Application.StartupPath & "\web_server\"
        End With

        If openUrl Then procStartInfo.Arguments = " --open-url=http://localhost:" & port & "/ --docpath=" & docPath
        procExecuting = Process.Start(procStartInfo)

        debugSession = procExecuting
        isRunning = True
    End Sub
    Public Sub TerminateCurrent()
        debugSession.CloseMainWindow()
        debugSession.Kill()

        isRunning = False
    End Sub
    Public Shared Sub TerminateAll()
        Dim procStartInfo As New ProcessStartInfo

        With procStartInfo
            .UseShellExecute = True
            .FileName = "cmd.exe"
            .WindowStyle = ProcessWindowStyle.Hidden
            .CreateNoWindow = True
            .Arguments = " /c taskkill /F /IM wwebserver_cmd.exe"
        End With

        Process.Start(procStartInfo)
    End Sub
End Class
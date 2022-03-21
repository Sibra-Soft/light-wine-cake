Imports System.IO
Imports System.Text
Imports Newtonsoft.Json

Namespace Services.Project
    Public Class ProjectCreatorService
        Public ProjectLocation As String
        Public Project As New WebsiteProjectModel
        Public InstallFrameworkUsingComposer As Boolean

        Public Event ProjectFoldersCreated()
        Public Event ProjectSaved()
        Public Event FrameworkInstalled()
        Public Event TablesCreated()
        Public Sub Start()
            SaveProject()
            GenerateFolders()
            InstallFramework()
            GenerateHtAccessFile()
            GenerateLoaderFile()
            GenerateDatabaseTables()
        End Sub
        Private Sub AddLogEntry(log As String)
            Console.WriteLine(String.Format("{0} {1}", Date.Now.ToShortTimeString, log))
        End Sub
        Private Sub GenerateLoaderFile()
            Dim loaderFile As New StringBuilder
            Dim file As StreamWriter

            AddLogEntry("Generating loader file")

            loaderFile.AppendLine("<?php")
            loaderFile.AppendLine("require_once ('vendor/autoload.php');")
            loaderFile.AppendLine(vbNullString)
            loaderFile.AppendLine("use LightWine\Bootloader;")
            loaderFile.AppendLine(vbNullString)
            loaderFile.AppendLine("session_start();")
            loaderFile.AppendLine(vbNullString)
            loaderFile.AppendLine("ini_set('display_errors', 1);")
            loaderFile.AppendLine("error_reporting(E_STRICT|E_ALL);")
            loaderFile.AppendLine(vbNullString)
            loaderFile.AppendLine("$framework = new Bootloader;")
            loaderFile.AppendLine("$framework->AddConfigurationFile(" & Chr(34) & "./app-config.json" & Chr(34) & ");")
            loaderFile.AppendLine("$framework->Run();")

            file = My.Computer.FileSystem.OpenTextFileWriter(Project.ProjectLocation & "\index.php", False)
            file.WriteLine(loaderFile.ToString())
            file.Close()
        End Sub
        Private Sub GenerateHtAccessFile()
            Dim htAccessFile As New StringBuilder
            Dim file As StreamWriter

            AddLogEntry("Generating .htaccess file")

            htAccessFile.AppendLine("RewriteEngine on")
            htAccessFile.AppendLine(vbNullString)
            htAccessFile.AppendLine("RewriteCond %{REQUEST_FILENAME} !-f")
            htAccessFile.AppendLine("RewriteCond %{REQUEST_FILENAME} !-d")
            htAccessFile.AppendLine(vbNullString)
            htAccessFile.AppendLine("RewriteRule ^(.*)$ /index.php?path=$1 [NC,L,QSA]")
            htAccessFile.AppendLine("RewriteRule ^(.+)\.json$ /index.php [NC,L]")

            file = My.Computer.FileSystem.OpenTextFileWriter(Project.ProjectLocation & "\.htaccess", False)
            file.WriteLine(htAccessFile.ToString())
            file.Close()
        End Sub
        Private Sub SaveProject()
            Dim output = JsonConvert.SerializeObject(Project)
            Dim file As StreamWriter

            AddLogEntry("Saving project")

            file = My.Computer.FileSystem.OpenTextFileWriter(Project.ProjectLocation & "\" & Project.ProjectFile, False)
            file.WriteLine(output)
            file.Close()

            RaiseEvent ProjectSaved()
        End Sub
        Private Sub GenerateFolders()
            AddLogEntry("Creating project folders")

            Directory.CreateDirectory(Project.ProjectLocation & "\app-code")
            Directory.CreateDirectory(Project.ProjectLocation & "\app-data")
            Directory.CreateDirectory(Project.ProjectLocation & "\cache")
            Directory.CreateDirectory(Project.ProjectLocation & "\logs")
            Directory.CreateDirectory(Project.ProjectLocation & "\temp")

            RaiseEvent ProjectFoldersCreated()
        End Sub
        Private Sub InstallFrameworkUsingLocalPackage()

        End Sub
        Private Sub FillTablesWithInitialData()
            Dim di As New DirectoryInfo(Application.StartupPath & "\initial_data\")
            Dim fiArr As FileInfo() = di.GetFiles("*.sql")
            Dim fri As FileInfo

            Using dbConnection As New Database.MysqlConnectionService
                dbConnection.CheckConnectionAndConnect(Project.Connections.DefaultConnectionString)

                For Each fri In fiArr
                    Dim query As String = File.ReadAllText(fri.FullName)

                    Console.WriteLine("Initial data query: " & fri.Name)

                    dbConnection.ExecuteQuery(query)

                    Application.DoEvents()
                Next fri
            End Using
        End Sub
        Private Sub GenerateDatabaseTables()
            Dim di As New DirectoryInfo(Application.StartupPath & "\tables\")
            Dim fiArr As FileInfo() = di.GetFiles("*.sql")
            Dim fri As FileInfo

            Using dbConnection As New Database.MysqlConnectionService
                dbConnection.CheckConnectionAndConnect(Project.Connections.DefaultConnectionString)

                For Each fri In fiArr
                    Dim query As String = File.ReadAllText(fri.FullName)

                    Console.WriteLine("Executing: " & fri.Name)

                    dbConnection.ExecuteQuery(query)

                    Application.DoEvents()
                Next fri
            End Using

            FillTablesWithInitialData()

            RaiseEvent TablesCreated()
        End Sub
        Private Sub InstallFramework()
            AddLogEntry("Start framework installation")

            If InstallFrameworkUsingComposer Then
                AddLogEntry("Installing using Composer package")

                Dim process As New Process
                Dim processInfo As New ProcessStartInfo With {
                    .FileName = "C:\windows\system32\cmd.exe",
                    .Arguments = "/c composer require sibra-soft/light-wine-framework",
                    .WorkingDirectory = Project.ProjectLocation,
                    .WindowStyle = ProcessWindowStyle.Hidden
                }

                process.StartInfo = processInfo
                process.Start()
                process.WaitForExit()

                RaiseEvent FrameworkInstalled()
            Else
                InstallFrameworkUsingLocalPackage()
            End If
        End Sub
    End Class
End Namespace
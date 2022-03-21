Imports System.ComponentModel
Imports DevComponents.DotNetBar
Public Class Form_Site_Wizard
    Private ConnectionString As String
    Private WithEvents ProjectCreator As New Services.Project.ProjectCreatorService
    Private Function ValidateWizardDetailsStep() As Boolean
        Dim result As Boolean = True

        If String.IsNullOrWhiteSpace(Textbox_ProjectName.Text) Then result = False : MessageBox.Show(Me, "No project name specified", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If String.IsNullOrWhiteSpace(Textbox_DatabaseName.Text) Then result = False : MessageBox.Show(Me, "No database name specified", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If String.IsNullOrWhiteSpace(Textbox_Domain.Text) Then result = False : MessageBox.Show(Me, "No domain name specified", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If String.IsNullOrWhiteSpace(Textbox_DatabasePort.Text) Then result = False : MessageBox.Show(Me, "No database port specified", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Return result
    End Function

    Private Sub Form_Site_Wizard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Combox_ConnectionType.SelectedIndex = 0
        Combox_Enviroment.SelectedIndex = 0
    End Sub

    Private Sub Wizard_FinishButtonClick(sender As Object, e As CancelEventArgs) Handles Wizard.FinishButtonClick
        ' Generate the project
        Dim newProject As New WebsiteProjectModel With {
            .Domain = Textbox_Domain.Text,
            .Name = Textbox_ProjectName.Text,
            .ProjectFile = "app-config.json",
            .Connections = New WebsiteProjectConnectionsModel With {
                .DefaultConnectionString = ConnectionString
            },
            .Environment = "dev"
        }

        If Program.CheckIfProjectExistsBasedOnDomain(newProject.Domain) Then
            MessageBox.Show(Me, "There is already a project with the same domain name added", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            FolderBrowserDialog.Description = "Select the location you want to create the new project"

            If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
                newProject.ProjectLocation = FolderBrowserDialog.SelectedPath

                Wizard.SelectedPage = Wizard_Page_Busy
                Wizard_Page_Busy.FinishButtonEnabled = eWizardButtonState.False
                Wizard_Page_Busy.BackButtonEnabled = eWizardButtonState.False

                ProjectCreator.InstallFrameworkUsingComposer = RadioButton_InstallLatestVersion.Checked
                ProjectCreator.ProjectLocation = FolderBrowserDialog.SelectedPath
                ProjectCreator.Project = newProject
                ProjectCreator.Start()

                Program.Projects.Add(newProject)

                Close()
            End If
        End If
    End Sub

    Private Sub Wizard_WizardPageChanging(sender As Object, e As WizardCancelPageChangeEventArgs) Handles Wizard.WizardPageChanging
        Dim mysqlService As New Services.Database.MysqlConnectionService()

        If e.NewPage Is Wizard_Page_Data Then
            e.Cancel = True

            If ValidateWizardDetailsStep() Then
                ' Generate the connectionstring
                Dim connString As New Dictionary(Of String, String) From {
                    {"server", Textbox_DatabaseHostname.Text},
                    {"database", Textbox_DatabaseName.Text},
                    {"user", Textbox_DatabaseUsername.Text},
                    {"password", Textbox_DatabasePassword.Text},
                    {"port", Textbox_DatabasePort.Text}
                }
                ConnectionString = String.Join(";", connString.Select(Function(kvp) String.Format("{0}={1}", kvp.Key, kvp.Value)).ToArray())

                If mysqlService.CheckConnectionAndConnect(ConnectionString) Then
                    e.Cancel = False
                Else
                    MessageBox.Show(Me, "Can't connect to the specified database, please check the specified details and try again.", "Mysql connection error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub ProjectCreator_ProjectSaved() Handles ProjectCreator.ProjectSaved
        Picturebox_Step2.Image = My.Resources.check_box
    End Sub

    Private Sub ProjectCreator_ProjectFoldersCreated() Handles ProjectCreator.ProjectFoldersCreated
        Picturebox_Step1.Image = My.Resources.check_box
    End Sub

    Private Sub ProjectCreator_FrameworkInstalled() Handles ProjectCreator.FrameworkInstalled
        Picturebox_Step3.Image = My.Resources.check_box
    End Sub

    Private Sub Wizard_WizardPageChanged(sender As Object, e As WizardPageChangeEventArgs) Handles Wizard.WizardPageChanged
        If e.NewPage Is Wizard_Page_Details Then
            Textbox_ProjectName.Select()
        End If

        If e.NewPage Is Wizard_Page_Data Then
            Wizard_Page_Data.FinishButtonEnabled = eWizardButtonState.True
        Else
            Wizard_Page_Data.FinishButtonEnabled = eWizardButtonState.False
        End If
    End Sub
    Private Sub Timer_Main_Tick(sender As Object, e As EventArgs) Handles Timer_Main.Tick
        Textbox_SmtpHostname.Enabled = Checkbox_UseSmtp.Checked
        Textbox_SmtpUsername.Enabled = Checkbox_UseSmtp.Checked
        Textbox_SmtpPassword.Enabled = Checkbox_UseSmtp.Checked
        Textbox_SmtpPort.Enabled = Checkbox_UseSmtp.Checked
        Textbox_SmtpFromAddress.Enabled = Checkbox_UseSmtp.Checked
        Textbox_SmtpFormName.Enabled = Checkbox_UseSmtp.Checked
    End Sub

    Private Sub ProjectCreator_TablesCreated() Handles ProjectCreator.TablesCreated
        Picturebox_Step4.Image = My.Resources.check_box
    End Sub
End Class
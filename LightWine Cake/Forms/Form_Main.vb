Imports Newtonsoft.Json
Imports System.IO
Public Class Form_Main
    Private Server As New WebServerService
    Private SelectedProject As WebsiteProjectModel
    Private Sub EnableDisableControls()
        If Listview_Sites.Items.Count > 0 Then
            Toolstrip_Button_Delete.Enabled = True
            Toolstrip_Button_Start.Enabled = True
            Toolstrip_Button_Update.Enabled = True
        Else
            Toolstrip_Button_Delete.Enabled = False
            Toolstrip_Button_Start.Enabled = False
            Toolstrip_Button_Update.Enabled = False
        End If
    End Sub
    Private Sub RefreshListview()
        Dim index As Integer = 1

        Listview_Sites.ConfigureListview()

        Listview_Sites.Columns.Add("#", 80)
        Listview_Sites.Columns.Add("Domain")
        Listview_Sites.Columns.Add("Enviroment")
        Listview_Sites.Columns.Add("Location")

        For Each project As WebsiteProjectModel In Program.Projects
            Dim listItem As New ListViewItem With {
                .Text = index,
                .ImageIndex = 0,
                .Tag = project
            }
            listItem.SubItems.Add(project.Domain)
            listItem.SubItems.Add(project.Environment)
            listItem.SubItems.Add(project.ProjectLocation)

            Listview_Sites.Items.Add(listItem)

            index = index + 1
        Next

        If Listview_Sites.Items.Count > 0 Then Panel_Information.Visible = False

        Listview_Sites.AutoResizeListviewColumns()
        EnableDisableControls()
    End Sub
    Private Sub AddNewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Toolstrip_Button_Add_New.Click
        Form_Site_Wizard.ShowDialog()
        RefreshListview()

        Program.SaveProjects()
    End Sub

    Private Sub Toolstrip_Button_Add_Existing_Click(sender As Object, e As EventArgs) Handles Toolstrip_Button_Add_Existing.Click
        Dim project As WebsiteProjectModel
        Dim projectFileContent As String

        OpenFileDialog.Title = "Select the project file of the project you want to add"
        OpenFileDialog.Filter = "Json file (*.json)|*.json"

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            projectFileContent = File.ReadAllText(OpenFileDialog.FileName)
            project = JsonConvert.DeserializeObject(Of WebsiteProjectModel)(projectFileContent)
            project.ProjectLocation = Path.GetDirectoryName(OpenFileDialog.FileName)

            If Program.CheckIfProjectExistsBasedOnDomain(project.Domain) Then
                MessageBox.Show(Me, "There is already a project with the same domain name added", "Project exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Program.Projects.Add(project)
                Program.SaveProjects()

                RefreshListview()
            End If
        End If
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Program.LoadProjects()
        RefreshListview()
    End Sub

    Private Sub Toolstrip_Button_Delete_Click(sender As Object, e As EventArgs) Handles Toolstrip_Button_Delete.Click
        If MessageBox.Show(Me, "Are you sure you want to delete the selected project?", "Delete project", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Listview_Sites.Items.Remove(Listview_Sites.SelectedItems(0))

            Program.Projects.Remove(SelectedProject)
            Program.SaveProjects()

            RefreshListview()
        End If
    End Sub

    Private Sub Toolstrip_Button_Start_Click(sender As Object, e As EventArgs) Handles Toolstrip_Button_Start.Click
        Server.StartServer(SelectedProject.ProjectLocation, "8080", True)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Form_Settings.ShowDialog()
    End Sub

    Private Sub Listview_Sites_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles Listview_Sites.ItemSelectionChanged
        SelectedProject = DirectCast(e.Item.Tag, WebsiteProjectModel)
    End Sub
End Class

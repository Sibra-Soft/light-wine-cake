Public Class Form_Settings
    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Close()
    End Sub

    Private Sub Button_Browse_Click(sender As Object, e As EventArgs) Handles Button_Browse.Click
        FolderBrowserDialog.ShowNewFolderButton = False

        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Textbox_LocalPackageLocation.Text = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub Timer_Main_Tick(sender As Object, e As EventArgs) Handles Timer_Main.Tick
        If RadioButton_LocalPackage.Checked Then
            Textbox_LocalPackageLocation.Enabled = True
            Button_Browse.Enabled = True
        Else
            Textbox_LocalPackageLocation.Enabled = False
            Button_Browse.Enabled = False
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        My.Settings.Item("server_port") = Convert.ToInt32(Numeric_ServerPort.Value)
        My.Settings.Item("local_package_location") = Textbox_LocalPackageLocation.Text
        My.Settings.Item("always_update_before_start") = Checkbox_AlwaysUpdateBeforeStart.Checked
        My.Settings.Save()

        Close()
    End Sub

    Private Sub Form_Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Numeric_ServerPort.Value = My.Settings.Item("server_port")
        Textbox_LocalPackageLocation.Text = My.Settings.Item("local_package_location")
        Checkbox_AlwaysUpdateBeforeStart.Checked = My.Settings.Item("always_update_before_start")

        If Not String.IsNullOrWhiteSpace(Textbox_LocalPackageLocation.Text) Then
            RadioButton_LocalPackage.Checked = True
            Textbox_LocalPackageLocation.Enabled = True
            Button_Browse.Enabled = True
        End If
    End Sub
End Class
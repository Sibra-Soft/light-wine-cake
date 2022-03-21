<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.Toolstrip = New System.Windows.Forms.ToolStrip()
        Me.Toolstrip_Button_Add = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Toolstrip_Button_Add_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.Toolstrip_Button_Add_Existing = New System.Windows.Forms.ToolStripMenuItem()
        Me.Toolstrip_Button_Delete = New System.Windows.Forms.ToolStripButton()
        Me.Toolstrip_Button_Update = New System.Windows.Forms.ToolStripButton()
        Me.Toolstrip_Button_Start = New System.Windows.Forms.ToolStripButton()
        Me.Toolstrip_Button_OpenInElixer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Listview_Sites = New System.Windows.Forms.ListView()
        Me.Imagelist_Listview = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel_Information = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Toolstrip.SuspendLayout()
        Me.Panel_Information.SuspendLayout()
        Me.SuspendLayout()
        '
        'Toolstrip
        '
        Me.Toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolstrip_Button_Add, Me.Toolstrip_Button_Delete, Me.Toolstrip_Button_Update, Me.Toolstrip_Button_Start, Me.Toolstrip_Button_OpenInElixer, Me.ToolStripButton1})
        Me.Toolstrip.Location = New System.Drawing.Point(0, 0)
        Me.Toolstrip.Name = "Toolstrip"
        Me.Toolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Toolstrip.Size = New System.Drawing.Size(787, 25)
        Me.Toolstrip.TabIndex = 0
        Me.Toolstrip.Text = "ToolStrip1"
        '
        'Toolstrip_Button_Add
        '
        Me.Toolstrip_Button_Add.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolstrip_Button_Add_New, Me.Toolstrip_Button_Add_Existing})
        Me.Toolstrip_Button_Add.Image = Global.LightWineCake.My.Resources.Resources.add_16
        Me.Toolstrip_Button_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toolstrip_Button_Add.Name = "Toolstrip_Button_Add"
        Me.Toolstrip_Button_Add.Size = New System.Drawing.Size(58, 22)
        Me.Toolstrip_Button_Add.Text = "Add"
        Me.Toolstrip_Button_Add.ToolTipText = "Add new or existing project"
        '
        'Toolstrip_Button_Add_New
        '
        Me.Toolstrip_Button_Add_New.Name = "Toolstrip_Button_Add_New"
        Me.Toolstrip_Button_Add_New.Size = New System.Drawing.Size(208, 22)
        Me.Toolstrip_Button_Add_New.Text = "Add new project"
        '
        'Toolstrip_Button_Add_Existing
        '
        Me.Toolstrip_Button_Add_Existing.Name = "Toolstrip_Button_Add_Existing"
        Me.Toolstrip_Button_Add_Existing.Size = New System.Drawing.Size(208, 22)
        Me.Toolstrip_Button_Add_Existing.Text = "Add local existing project"
        '
        'Toolstrip_Button_Delete
        '
        Me.Toolstrip_Button_Delete.Enabled = False
        Me.Toolstrip_Button_Delete.Image = Global.LightWineCake.My.Resources.Resources.delete_16
        Me.Toolstrip_Button_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toolstrip_Button_Delete.Name = "Toolstrip_Button_Delete"
        Me.Toolstrip_Button_Delete.Size = New System.Drawing.Size(60, 22)
        Me.Toolstrip_Button_Delete.Text = "Delete"
        Me.Toolstrip_Button_Delete.ToolTipText = "Delete the selected project"
        '
        'Toolstrip_Button_Update
        '
        Me.Toolstrip_Button_Update.Enabled = False
        Me.Toolstrip_Button_Update.Image = Global.LightWineCake.My.Resources.Resources.update
        Me.Toolstrip_Button_Update.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toolstrip_Button_Update.Name = "Toolstrip_Button_Update"
        Me.Toolstrip_Button_Update.Size = New System.Drawing.Size(65, 22)
        Me.Toolstrip_Button_Update.Text = "Update"
        Me.Toolstrip_Button_Update.ToolTipText = "Update the selected project"
        '
        'Toolstrip_Button_Start
        '
        Me.Toolstrip_Button_Start.Enabled = False
        Me.Toolstrip_Button_Start.Image = Global.LightWineCake.My.Resources.Resources.run_macros
        Me.Toolstrip_Button_Start.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toolstrip_Button_Start.Name = "Toolstrip_Button_Start"
        Me.Toolstrip_Button_Start.Size = New System.Drawing.Size(51, 22)
        Me.Toolstrip_Button_Start.Text = "Start"
        Me.Toolstrip_Button_Start.ToolTipText = "Start the selected project"
        '
        'Toolstrip_Button_OpenInElixer
        '
        Me.Toolstrip_Button_OpenInElixer.Image = Global.LightWineCake.My.Resources.Resources.flask
        Me.Toolstrip_Button_OpenInElixer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toolstrip_Button_OpenInElixer.Name = "Toolstrip_Button_OpenInElixer"
        Me.Toolstrip_Button_OpenInElixer.Size = New System.Drawing.Size(100, 22)
        Me.Toolstrip_Button_OpenInElixer.Text = "Open in Elixer"
        Me.Toolstrip_Button_OpenInElixer.ToolTipText = "Open the selected project in Elixer"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.LightWineCake.My.Resources.Resources.setting_tools_16
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton1.Text = "Settings"
        '
        'Listview_Sites
        '
        Me.Listview_Sites.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Listview_Sites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Listview_Sites.HideSelection = False
        Me.Listview_Sites.Location = New System.Drawing.Point(0, 25)
        Me.Listview_Sites.Name = "Listview_Sites"
        Me.Listview_Sites.Size = New System.Drawing.Size(787, 434)
        Me.Listview_Sites.SmallImageList = Me.Imagelist_Listview
        Me.Listview_Sites.TabIndex = 1
        Me.Listview_Sites.UseCompatibleStateImageBehavior = False
        '
        'Imagelist_Listview
        '
        Me.Imagelist_Listview.ImageStream = CType(resources.GetObject("Imagelist_Listview.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagelist_Listview.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagelist_Listview.Images.SetKeyName(0, "bullet_red.png")
        Me.Imagelist_Listview.Images.SetKeyName(1, "bullet_green.png")
        '
        'Panel_Information
        '
        Me.Panel_Information.BackColor = System.Drawing.Color.White
        Me.Panel_Information.Controls.Add(Me.Label2)
        Me.Panel_Information.Controls.Add(Me.Label1)
        Me.Panel_Information.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Information.Location = New System.Drawing.Point(0, 25)
        Me.Panel_Information.Name = "Panel_Information"
        Me.Panel_Information.Size = New System.Drawing.Size(787, 434)
        Me.Panel_Information.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(768, 58)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome to LightWine Cake"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 459)
        Me.Controls.Add(Me.Panel_Information)
        Me.Controls.Add(Me.Listview_Sites)
        Me.Controls.Add(Me.Toolstrip)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Main"
        Me.Text = "Sibra-Soft LightWine - Cake"
        Me.Toolstrip.ResumeLayout(False)
        Me.Toolstrip.PerformLayout()
        Me.Panel_Information.ResumeLayout(False)
        Me.Panel_Information.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Toolstrip As ToolStrip
    Friend WithEvents Listview_Sites As ListView
    Friend WithEvents Toolstrip_Button_Delete As ToolStripButton
    Friend WithEvents Toolstrip_Button_Update As ToolStripButton
    Friend WithEvents Toolstrip_Button_Start As ToolStripButton
    Friend WithEvents Panel_Information As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Toolstrip_Button_OpenInElixer As ToolStripButton
    Friend WithEvents Toolstrip_Button_Add As ToolStripDropDownButton
    Friend WithEvents Toolstrip_Button_Add_New As ToolStripMenuItem
    Friend WithEvents Toolstrip_Button_Add_Existing As ToolStripMenuItem
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Imagelist_Listview As ImageList
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

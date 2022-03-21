<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Site_Wizard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Site_Wizard))
        Me.Wizard = New DevComponents.DotNetBar.Wizard()
        Me.Wizard_Page_Welcome = New DevComponents.DotNetBar.WizardPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Wizard_Page_Details = New DevComponents.DotNetBar.WizardPage()
        Me.Checkbox_UseSmtp = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Textbox_DatabaseHostname = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Textbox_ProjectName = New System.Windows.Forms.TextBox()
        Me.Combox_Enviroment = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Textbox_SmtpFromAddress = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Textbox_SmtpFormName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Textbox_SmtpPassword = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Textbox_SmtpUsername = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Textbox_SmtpPort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Textbox_SmtpHostname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Textbox_Domain = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Textbox_DatabasePassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textbox_DatabaseUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textbox_DatabasePort = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textbox_DatabaseName = New System.Windows.Forms.TextBox()
        Me.Combox_ConnectionType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Wizard_Page_Data = New DevComponents.DotNetBar.WizardPage()
        Me.RadioButton_UseLocalVersion = New System.Windows.Forms.RadioButton()
        Me.RadioButton_InstallLatestVersion = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Checkbox_AddSiteSettings = New System.Windows.Forms.CheckBox()
        Me.Checkbox_FillInitialData = New System.Windows.Forms.CheckBox()
        Me.Checkbox_CreateDatabase = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Checkbox_LogErrorsAndWarning = New System.Windows.Forms.CheckBox()
        Me.Checkbox_EnableDebugLogging = New System.Windows.Forms.CheckBox()
        Me.Checkbox_EnableTracing = New System.Windows.Forms.CheckBox()
        Me.Checkbox_LogIncommingTraffic = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Wizard_Page_Busy = New DevComponents.DotNetBar.WizardPage()
        Me.Label_Step4 = New System.Windows.Forms.Label()
        Me.Picturebox_Step4 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Picturebox_Step3 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Picturebox_Step2 = New System.Windows.Forms.PictureBox()
        Me.Picturebox_Step1 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer_Main = New System.Windows.Forms.Timer(Me.components)
        Me.Wizard.SuspendLayout()
        Me.Wizard_Page_Welcome.SuspendLayout()
        Me.Wizard_Page_Details.SuspendLayout()
        Me.Wizard_Page_Data.SuspendLayout()
        Me.Wizard_Page_Busy.SuspendLayout()
        CType(Me.Picturebox_Step4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturebox_Step3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturebox_Step2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturebox_Step1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wizard
        '
        Me.Wizard.CancelButtonText = "Cancel"
        Me.Wizard.Cursor = System.Windows.Forms.Cursors.Default
        Me.Wizard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wizard.FinishButtonTabIndex = 3
        '
        '
        '
        Me.Wizard.FooterStyle.BackColor = System.Drawing.SystemColors.Control
        Me.Wizard.FooterStyle.BackColorGradientAngle = 90
        Me.Wizard.FooterStyle.BorderBottomWidth = 1
        Me.Wizard.FooterStyle.BorderColor = System.Drawing.SystemColors.Control
        Me.Wizard.FooterStyle.BorderLeftWidth = 1
        Me.Wizard.FooterStyle.BorderRightWidth = 1
        Me.Wizard.FooterStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.Wizard.FooterStyle.BorderTopColor = System.Drawing.SystemColors.Control
        Me.Wizard.FooterStyle.BorderTopWidth = 1
        Me.Wizard.FooterStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard.FooterStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Wizard.FooterStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Wizard.HeaderCaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard.HeaderDescriptionFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard.HeaderDescriptionIndent = 16
        '
        '
        '
        Me.Wizard.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Wizard.HeaderStyle.BackColorGradientAngle = 90
        Me.Wizard.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.Wizard.HeaderStyle.BorderBottomWidth = 1
        Me.Wizard.HeaderStyle.BorderColor = System.Drawing.SystemColors.Control
        Me.Wizard.HeaderStyle.BorderLeftWidth = 1
        Me.Wizard.HeaderStyle.BorderRightWidth = 1
        Me.Wizard.HeaderStyle.BorderTopWidth = 1
        Me.Wizard.HeaderStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard.HeaderStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Wizard.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Wizard.Location = New System.Drawing.Point(0, 0)
        Me.Wizard.Name = "Wizard"
        Me.Wizard.Size = New System.Drawing.Size(723, 408)
        Me.Wizard.TabIndex = 0
        Me.Wizard.WizardPages.AddRange(New DevComponents.DotNetBar.WizardPage() {Me.Wizard_Page_Welcome, Me.Wizard_Page_Details, Me.Wizard_Page_Data, Me.Wizard_Page_Busy})
        '
        'Wizard_Page_Welcome
        '
        Me.Wizard_Page_Welcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Wizard_Page_Welcome.BackColor = System.Drawing.Color.White
        Me.Wizard_Page_Welcome.Controls.Add(Me.Label1)
        Me.Wizard_Page_Welcome.Controls.Add(Me.Label2)
        Me.Wizard_Page_Welcome.Controls.Add(Me.Label3)
        Me.Wizard_Page_Welcome.HelpButtonVisible = DevComponents.DotNetBar.eWizardButtonState.[False]
        Me.Wizard_Page_Welcome.InteriorPage = False
        Me.Wizard_Page_Welcome.Location = New System.Drawing.Point(0, 0)
        Me.Wizard_Page_Welcome.Name = "Wizard_Page_Welcome"
        Me.Wizard_Page_Welcome.PageTitle = "Add new website wizard"
        Me.Wizard_Page_Welcome.Size = New System.Drawing.Size(723, 362)
        '
        '
        '
        Me.Wizard_Page_Welcome.Style.BackColor = System.Drawing.Color.White
        Me.Wizard_Page_Welcome.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Wizard_Page_Welcome.Style.BackColorGradientAngle = 10
        Me.Wizard_Page_Welcome.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft
        Me.Wizard_Page_Welcome.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Welcome.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Welcome.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard_Page_Welcome.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(210, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add new website wizard"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(210, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(498, 230)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(210, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To continue, click Next."
        '
        'Wizard_Page_Details
        '
        Me.Wizard_Page_Details.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Wizard_Page_Details.AntiAlias = False
        Me.Wizard_Page_Details.Controls.Add(Me.Checkbox_UseSmtp)
        Me.Wizard_Page_Details.Controls.Add(Me.Label24)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_DatabaseHostname)
        Me.Wizard_Page_Details.Controls.Add(Me.Label23)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_ProjectName)
        Me.Wizard_Page_Details.Controls.Add(Me.Combox_Enviroment)
        Me.Wizard_Page_Details.Controls.Add(Me.Label20)
        Me.Wizard_Page_Details.Controls.Add(Me.Label18)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_SmtpFromAddress)
        Me.Wizard_Page_Details.Controls.Add(Me.Label17)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_SmtpFormName)
        Me.Wizard_Page_Details.Controls.Add(Me.Label16)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_SmtpPassword)
        Me.Wizard_Page_Details.Controls.Add(Me.Label15)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_SmtpUsername)
        Me.Wizard_Page_Details.Controls.Add(Me.Label14)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_SmtpPort)
        Me.Wizard_Page_Details.Controls.Add(Me.Label13)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_SmtpHostname)
        Me.Wizard_Page_Details.Controls.Add(Me.Label12)
        Me.Wizard_Page_Details.Controls.Add(Me.Label11)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_Domain)
        Me.Wizard_Page_Details.Controls.Add(Me.Label10)
        Me.Wizard_Page_Details.Controls.Add(Me.Label9)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_DatabasePassword)
        Me.Wizard_Page_Details.Controls.Add(Me.Label8)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_DatabaseUsername)
        Me.Wizard_Page_Details.Controls.Add(Me.Label7)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_DatabasePort)
        Me.Wizard_Page_Details.Controls.Add(Me.Label6)
        Me.Wizard_Page_Details.Controls.Add(Me.Textbox_DatabaseName)
        Me.Wizard_Page_Details.Controls.Add(Me.Combox_ConnectionType)
        Me.Wizard_Page_Details.Controls.Add(Me.Label5)
        Me.Wizard_Page_Details.Controls.Add(Me.Label4)
        Me.Wizard_Page_Details.HelpButtonVisible = DevComponents.DotNetBar.eWizardButtonState.[False]
        Me.Wizard_Page_Details.Location = New System.Drawing.Point(7, 72)
        Me.Wizard_Page_Details.Name = "Wizard_Page_Details"
        Me.Wizard_Page_Details.PageDescription = "Enter the details of your website project bellow"
        Me.Wizard_Page_Details.PageTitle = "Project Details"
        Me.Wizard_Page_Details.Size = New System.Drawing.Size(709, 278)
        '
        '
        '
        Me.Wizard_Page_Details.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Details.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Details.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard_Page_Details.TabIndex = 8
        '
        'Checkbox_UseSmtp
        '
        Me.Checkbox_UseSmtp.AutoSize = True
        Me.Checkbox_UseSmtp.Location = New System.Drawing.Point(507, 86)
        Me.Checkbox_UseSmtp.Name = "Checkbox_UseSmtp"
        Me.Checkbox_UseSmtp.Size = New System.Drawing.Size(79, 17)
        Me.Checkbox_UseSmtp.TabIndex = 33
        Me.Checkbox_UseSmtp.Text = "Use smtp"
        Me.Checkbox_UseSmtp.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(5, 143)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 13)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "Hostname"
        '
        'Textbox_DatabaseHostname
        '
        Me.Textbox_DatabaseHostname.Location = New System.Drawing.Point(143, 140)
        Me.Textbox_DatabaseHostname.Name = "Textbox_DatabaseHostname"
        Me.Textbox_DatabaseHostname.Size = New System.Drawing.Size(242, 21)
        Me.Textbox_DatabaseHostname.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Project name:"
        '
        'Textbox_ProjectName
        '
        Me.Textbox_ProjectName.Location = New System.Drawing.Point(143, 20)
        Me.Textbox_ProjectName.Name = "Textbox_ProjectName"
        Me.Textbox_ProjectName.Size = New System.Drawing.Size(561, 21)
        Me.Textbox_ProjectName.TabIndex = 0
        '
        'Combox_Enviroment
        '
        Me.Combox_Enviroment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combox_Enviroment.FormattingEnabled = True
        Me.Combox_Enviroment.Items.AddRange(New Object() {"Development", "Test", "Live", "Acceptance"})
        Me.Combox_Enviroment.Location = New System.Drawing.Point(509, 48)
        Me.Combox_Enviroment.Name = "Combox_Enviroment"
        Me.Combox_Enviroment.Size = New System.Drawing.Size(195, 21)
        Me.Combox_Enviroment.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(413, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Enviroment:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(413, 253)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "From address:"
        '
        'Textbox_SmtpFromAddress
        '
        Me.Textbox_SmtpFromAddress.Location = New System.Drawing.Point(509, 249)
        Me.Textbox_SmtpFromAddress.Name = "Textbox_SmtpFromAddress"
        Me.Textbox_SmtpFromAddress.Size = New System.Drawing.Size(195, 21)
        Me.Textbox_SmtpFromAddress.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(413, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "From name:"
        '
        'Textbox_SmtpFormName
        '
        Me.Textbox_SmtpFormName.Location = New System.Drawing.Point(509, 222)
        Me.Textbox_SmtpFormName.Name = "Textbox_SmtpFormName"
        Me.Textbox_SmtpFormName.Size = New System.Drawing.Size(195, 21)
        Me.Textbox_SmtpFormName.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(413, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Password:"
        '
        'Textbox_SmtpPassword
        '
        Me.Textbox_SmtpPassword.Location = New System.Drawing.Point(509, 195)
        Me.Textbox_SmtpPassword.Name = "Textbox_SmtpPassword"
        Me.Textbox_SmtpPassword.Size = New System.Drawing.Size(195, 21)
        Me.Textbox_SmtpPassword.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(413, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Username:"
        '
        'Textbox_SmtpUsername
        '
        Me.Textbox_SmtpUsername.Location = New System.Drawing.Point(509, 168)
        Me.Textbox_SmtpUsername.Name = "Textbox_SmtpUsername"
        Me.Textbox_SmtpUsername.Size = New System.Drawing.Size(195, 21)
        Me.Textbox_SmtpUsername.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(413, 143)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Port:"
        '
        'Textbox_SmtpPort
        '
        Me.Textbox_SmtpPort.Location = New System.Drawing.Point(509, 140)
        Me.Textbox_SmtpPort.Name = "Textbox_SmtpPort"
        Me.Textbox_SmtpPort.Size = New System.Drawing.Size(67, 21)
        Me.Textbox_SmtpPort.TabIndex = 17
        Me.Textbox_SmtpPort.Text = "25"
        Me.Textbox_SmtpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(413, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Hostname"
        '
        'Textbox_SmtpHostname
        '
        Me.Textbox_SmtpHostname.Location = New System.Drawing.Point(509, 113)
        Me.Textbox_SmtpHostname.Name = "Textbox_SmtpHostname"
        Me.Textbox_SmtpHostname.Size = New System.Drawing.Size(195, 21)
        Me.Textbox_SmtpHostname.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(413, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Smtp details"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Domain:"
        '
        'Textbox_Domain
        '
        Me.Textbox_Domain.Location = New System.Drawing.Point(143, 47)
        Me.Textbox_Domain.Name = "Textbox_Domain"
        Me.Textbox_Domain.Size = New System.Drawing.Size(242, 21)
        Me.Textbox_Domain.TabIndex = 1
        Me.Textbox_Domain.Text = "www.example.com"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, -2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Project"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Password:"
        '
        'Textbox_DatabasePassword
        '
        Me.Textbox_DatabasePassword.Location = New System.Drawing.Point(143, 249)
        Me.Textbox_DatabasePassword.Name = "Textbox_DatabasePassword"
        Me.Textbox_DatabasePassword.Size = New System.Drawing.Size(242, 21)
        Me.Textbox_DatabasePassword.TabIndex = 6
        Me.Textbox_DatabasePassword.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Username:"
        '
        'Textbox_DatabaseUsername
        '
        Me.Textbox_DatabaseUsername.Location = New System.Drawing.Point(143, 222)
        Me.Textbox_DatabaseUsername.Name = "Textbox_DatabaseUsername"
        Me.Textbox_DatabaseUsername.Size = New System.Drawing.Size(176, 21)
        Me.Textbox_DatabaseUsername.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Port:"
        '
        'Textbox_DatabasePort
        '
        Me.Textbox_DatabasePort.Location = New System.Drawing.Point(143, 195)
        Me.Textbox_DatabasePort.Name = "Textbox_DatabasePort"
        Me.Textbox_DatabasePort.Size = New System.Drawing.Size(67, 21)
        Me.Textbox_DatabasePort.TabIndex = 4
        Me.Textbox_DatabasePort.Text = "3306"
        Me.Textbox_DatabasePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Database:"
        '
        'Textbox_DatabaseName
        '
        Me.Textbox_DatabaseName.Location = New System.Drawing.Point(143, 168)
        Me.Textbox_DatabaseName.Name = "Textbox_DatabaseName"
        Me.Textbox_DatabaseName.Size = New System.Drawing.Size(242, 21)
        Me.Textbox_DatabaseName.TabIndex = 3
        '
        'Combox_ConnectionType
        '
        Me.Combox_ConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combox_ConnectionType.FormattingEnabled = True
        Me.Combox_ConnectionType.Items.AddRange(New Object() {"Mysql Database Connection"})
        Me.Combox_ConnectionType.Location = New System.Drawing.Point(143, 113)
        Me.Combox_ConnectionType.Name = "Combox_ConnectionType"
        Me.Combox_ConnectionType.Size = New System.Drawing.Size(242, 21)
        Me.Combox_ConnectionType.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Connection type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Database details"
        '
        'Wizard_Page_Data
        '
        Me.Wizard_Page_Data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Wizard_Page_Data.AntiAlias = False
        Me.Wizard_Page_Data.Controls.Add(Me.RadioButton_UseLocalVersion)
        Me.Wizard_Page_Data.Controls.Add(Me.RadioButton_InstallLatestVersion)
        Me.Wizard_Page_Data.Controls.Add(Me.Label22)
        Me.Wizard_Page_Data.Controls.Add(Me.Checkbox_AddSiteSettings)
        Me.Wizard_Page_Data.Controls.Add(Me.Checkbox_FillInitialData)
        Me.Wizard_Page_Data.Controls.Add(Me.Checkbox_CreateDatabase)
        Me.Wizard_Page_Data.Controls.Add(Me.Label21)
        Me.Wizard_Page_Data.Controls.Add(Me.Checkbox_LogErrorsAndWarning)
        Me.Wizard_Page_Data.Controls.Add(Me.Checkbox_EnableDebugLogging)
        Me.Wizard_Page_Data.Controls.Add(Me.Checkbox_EnableTracing)
        Me.Wizard_Page_Data.Controls.Add(Me.Checkbox_LogIncommingTraffic)
        Me.Wizard_Page_Data.Controls.Add(Me.Label19)
        Me.Wizard_Page_Data.HelpButtonVisible = DevComponents.DotNetBar.eWizardButtonState.[False]
        Me.Wizard_Page_Data.Location = New System.Drawing.Point(7, 72)
        Me.Wizard_Page_Data.Name = "Wizard_Page_Data"
        Me.Wizard_Page_Data.PageDescription = "Enter the data option details for the framework"
        Me.Wizard_Page_Data.PageTitle = "Data options"
        Me.Wizard_Page_Data.Size = New System.Drawing.Size(709, 278)
        '
        '
        '
        Me.Wizard_Page_Data.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Data.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Data.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard_Page_Data.TabIndex = 9
        '
        'RadioButton_UseLocalVersion
        '
        Me.RadioButton_UseLocalVersion.AutoSize = True
        Me.RadioButton_UseLocalVersion.Location = New System.Drawing.Point(8, 228)
        Me.RadioButton_UseLocalVersion.Name = "RadioButton_UseLocalVersion"
        Me.RadioButton_UseLocalVersion.Size = New System.Drawing.Size(225, 17)
        Me.RadioButton_UseLocalVersion.TabIndex = 11
        Me.RadioButton_UseLocalVersion.Text = "Use local version of the framework"
        Me.RadioButton_UseLocalVersion.UseVisualStyleBackColor = True
        '
        'RadioButton_InstallLatestVersion
        '
        Me.RadioButton_InstallLatestVersion.AutoSize = True
        Me.RadioButton_InstallLatestVersion.Checked = True
        Me.RadioButton_InstallLatestVersion.Location = New System.Drawing.Point(8, 211)
        Me.RadioButton_InstallLatestVersion.Name = "RadioButton_InstallLatestVersion"
        Me.RadioButton_InstallLatestVersion.Size = New System.Drawing.Size(334, 17)
        Me.RadioButton_InstallLatestVersion.TabIndex = 10
        Me.RadioButton_InstallLatestVersion.TabStop = True
        Me.RadioButton_InstallLatestVersion.Text = "Install latest version of the framwork using Composer"
        Me.RadioButton_InstallLatestVersion.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 195)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(133, 13)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Framework options"
        Me.Label22.UseMnemonic = False
        '
        'Checkbox_AddSiteSettings
        '
        Me.Checkbox_AddSiteSettings.AutoSize = True
        Me.Checkbox_AddSiteSettings.Checked = True
        Me.Checkbox_AddSiteSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkbox_AddSiteSettings.Location = New System.Drawing.Point(8, 159)
        Me.Checkbox_AddSiteSettings.Name = "Checkbox_AddSiteSettings"
        Me.Checkbox_AddSiteSettings.Size = New System.Drawing.Size(249, 17)
        Me.Checkbox_AddSiteSettings.TabIndex = 8
        Me.Checkbox_AddSiteSettings.Text = "Add the default settings for this project"
        Me.Checkbox_AddSiteSettings.UseVisualStyleBackColor = True
        '
        'Checkbox_FillInitialData
        '
        Me.Checkbox_FillInitialData.AutoSize = True
        Me.Checkbox_FillInitialData.Checked = True
        Me.Checkbox_FillInitialData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkbox_FillInitialData.Location = New System.Drawing.Point(8, 141)
        Me.Checkbox_FillInitialData.Name = "Checkbox_FillInitialData"
        Me.Checkbox_FillInitialData.Size = New System.Drawing.Size(191, 17)
        Me.Checkbox_FillInitialData.TabIndex = 7
        Me.Checkbox_FillInitialData.Text = "Fill the tabels with initial data"
        Me.Checkbox_FillInitialData.UseVisualStyleBackColor = True
        '
        'Checkbox_CreateDatabase
        '
        Me.Checkbox_CreateDatabase.AutoSize = True
        Me.Checkbox_CreateDatabase.Checked = True
        Me.Checkbox_CreateDatabase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkbox_CreateDatabase.Location = New System.Drawing.Point(8, 123)
        Me.Checkbox_CreateDatabase.Name = "Checkbox_CreateDatabase"
        Me.Checkbox_CreateDatabase.Size = New System.Drawing.Size(317, 17)
        Me.Checkbox_CreateDatabase.TabIndex = 6
        Me.Checkbox_CreateDatabase.Text = "Create database tabels required by the framework"
        Me.Checkbox_CreateDatabase.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 107)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Extra options"
        Me.Label21.UseMnemonic = False
        '
        'Checkbox_LogErrorsAndWarning
        '
        Me.Checkbox_LogErrorsAndWarning.AutoSize = True
        Me.Checkbox_LogErrorsAndWarning.Location = New System.Drawing.Point(8, 70)
        Me.Checkbox_LogErrorsAndWarning.Name = "Checkbox_LogErrorsAndWarning"
        Me.Checkbox_LogErrorsAndWarning.Size = New System.Drawing.Size(274, 17)
        Me.Checkbox_LogErrorsAndWarning.TabIndex = 4
        Me.Checkbox_LogErrorsAndWarning.Text = "Log all errors/warning, etc. to the database"
        Me.Checkbox_LogErrorsAndWarning.UseVisualStyleBackColor = True
        '
        'Checkbox_EnableDebugLogging
        '
        Me.Checkbox_EnableDebugLogging.AutoSize = True
        Me.Checkbox_EnableDebugLogging.Location = New System.Drawing.Point(8, 52)
        Me.Checkbox_EnableDebugLogging.Name = "Checkbox_EnableDebugLogging"
        Me.Checkbox_EnableDebugLogging.Size = New System.Drawing.Size(148, 17)
        Me.Checkbox_EnableDebugLogging.TabIndex = 3
        Me.Checkbox_EnableDebugLogging.Text = "Enable debug logging"
        Me.Checkbox_EnableDebugLogging.UseVisualStyleBackColor = True
        '
        'Checkbox_EnableTracing
        '
        Me.Checkbox_EnableTracing.AutoSize = True
        Me.Checkbox_EnableTracing.Location = New System.Drawing.Point(8, 34)
        Me.Checkbox_EnableTracing.Name = "Checkbox_EnableTracing"
        Me.Checkbox_EnableTracing.Size = New System.Drawing.Size(107, 17)
        Me.Checkbox_EnableTracing.TabIndex = 2
        Me.Checkbox_EnableTracing.Text = "Enable tracing"
        Me.Checkbox_EnableTracing.UseVisualStyleBackColor = True
        '
        'Checkbox_LogIncommingTraffic
        '
        Me.Checkbox_LogIncommingTraffic.AutoSize = True
        Me.Checkbox_LogIncommingTraffic.Checked = True
        Me.Checkbox_LogIncommingTraffic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkbox_LogIncommingTraffic.Location = New System.Drawing.Point(8, 16)
        Me.Checkbox_LogIncommingTraffic.Name = "Checkbox_LogIncommingTraffic"
        Me.Checkbox_LogIncommingTraffic.Size = New System.Drawing.Size(244, 17)
        Me.Checkbox_LogIncommingTraffic.TabIndex = 1
        Me.Checkbox_LogIncommingTraffic.Text = "Log all incomming traffic and requests"
        Me.Checkbox_LogIncommingTraffic.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(145, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Debugging & Logging"
        Me.Label19.UseMnemonic = False
        '
        'Wizard_Page_Busy
        '
        Me.Wizard_Page_Busy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Wizard_Page_Busy.AntiAlias = False
        Me.Wizard_Page_Busy.Controls.Add(Me.Label_Step4)
        Me.Wizard_Page_Busy.Controls.Add(Me.Picturebox_Step4)
        Me.Wizard_Page_Busy.Controls.Add(Me.Label27)
        Me.Wizard_Page_Busy.Controls.Add(Me.Picturebox_Step3)
        Me.Wizard_Page_Busy.Controls.Add(Me.Label26)
        Me.Wizard_Page_Busy.Controls.Add(Me.Label25)
        Me.Wizard_Page_Busy.Controls.Add(Me.Picturebox_Step2)
        Me.Wizard_Page_Busy.Controls.Add(Me.Picturebox_Step1)
        Me.Wizard_Page_Busy.HelpButtonVisible = DevComponents.DotNetBar.eWizardButtonState.[False]
        Me.Wizard_Page_Busy.Location = New System.Drawing.Point(7, 72)
        Me.Wizard_Page_Busy.Name = "Wizard_Page_Busy"
        Me.Wizard_Page_Busy.PageDescription = "Please wait while the project is being created"
        Me.Wizard_Page_Busy.PageTitle = "Creating Project"
        Me.Wizard_Page_Busy.Size = New System.Drawing.Size(709, 278)
        '
        '
        '
        Me.Wizard_Page_Busy.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Busy.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Wizard_Page_Busy.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Wizard_Page_Busy.TabIndex = 10
        '
        'Label_Step4
        '
        Me.Label_Step4.AutoSize = True
        Me.Label_Step4.Location = New System.Drawing.Point(51, 128)
        Me.Label_Step4.Name = "Label_Step4"
        Me.Label_Step4.Size = New System.Drawing.Size(150, 13)
        Me.Label_Step4.TabIndex = 7
        Me.Label_Step4.Text = "Creating database tables"
        '
        'Picturebox_Step4
        '
        Me.Picturebox_Step4.Image = Global.LightWineCake.My.Resources.Resources.check_box_uncheck
        Me.Picturebox_Step4.Location = New System.Drawing.Point(29, 127)
        Me.Picturebox_Step4.Name = "Picturebox_Step4"
        Me.Picturebox_Step4.Size = New System.Drawing.Size(16, 16)
        Me.Picturebox_Step4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picturebox_Step4.TabIndex = 6
        Me.Picturebox_Step4.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(50, 97)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(274, 13)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Installing framework using Composer package"
        '
        'Picturebox_Step3
        '
        Me.Picturebox_Step3.Image = Global.LightWineCake.My.Resources.Resources.check_box_uncheck
        Me.Picturebox_Step3.Location = New System.Drawing.Point(29, 96)
        Me.Picturebox_Step3.Name = "Picturebox_Step3"
        Me.Picturebox_Step3.Size = New System.Drawing.Size(16, 16)
        Me.Picturebox_Step3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picturebox_Step3.TabIndex = 4
        Me.Picturebox_Step3.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(50, 66)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(121, 13)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Creating project file"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(49, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Creating project folders"
        '
        'Picturebox_Step2
        '
        Me.Picturebox_Step2.Image = Global.LightWineCake.My.Resources.Resources.check_box_uncheck
        Me.Picturebox_Step2.Location = New System.Drawing.Point(28, 65)
        Me.Picturebox_Step2.Name = "Picturebox_Step2"
        Me.Picturebox_Step2.Size = New System.Drawing.Size(16, 16)
        Me.Picturebox_Step2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picturebox_Step2.TabIndex = 1
        Me.Picturebox_Step2.TabStop = False
        '
        'Picturebox_Step1
        '
        Me.Picturebox_Step1.Image = Global.LightWineCake.My.Resources.Resources.check_box_uncheck
        Me.Picturebox_Step1.Location = New System.Drawing.Point(28, 34)
        Me.Picturebox_Step1.Name = "Picturebox_Step1"
        Me.Picturebox_Step1.Size = New System.Drawing.Size(16, 16)
        Me.Picturebox_Step1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picturebox_Step1.TabIndex = 0
        Me.Picturebox_Step1.TabStop = False
        '
        'Timer_Main
        '
        Me.Timer_Main.Enabled = True
        Me.Timer_Main.Interval = 10
        '
        'Form_Site_Wizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 408)
        Me.Controls.Add(Me.Wizard)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Site_Wizard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Add new website project"
        Me.Wizard.ResumeLayout(False)
        Me.Wizard_Page_Welcome.ResumeLayout(False)
        Me.Wizard_Page_Details.ResumeLayout(False)
        Me.Wizard_Page_Details.PerformLayout()
        Me.Wizard_Page_Data.ResumeLayout(False)
        Me.Wizard_Page_Data.PerformLayout()
        Me.Wizard_Page_Busy.ResumeLayout(False)
        Me.Wizard_Page_Busy.PerformLayout()
        CType(Me.Picturebox_Step4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturebox_Step3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturebox_Step2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturebox_Step1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Wizard As DevComponents.DotNetBar.Wizard
    Friend WithEvents Wizard_Page_Welcome As DevComponents.DotNetBar.WizardPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Wizard_Page_Details As DevComponents.DotNetBar.WizardPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Textbox_DatabasePassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Textbox_DatabaseUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Textbox_DatabasePort As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Textbox_DatabaseName As TextBox
    Friend WithEvents Combox_ConnectionType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Textbox_Domain As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Textbox_SmtpFromAddress As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Textbox_SmtpFormName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Textbox_SmtpPassword As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Textbox_SmtpUsername As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Textbox_SmtpPort As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Textbox_SmtpHostname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Wizard_Page_Data As DevComponents.DotNetBar.WizardPage
    Friend WithEvents Combox_Enviroment As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Checkbox_LogErrorsAndWarning As CheckBox
    Friend WithEvents Checkbox_EnableDebugLogging As CheckBox
    Friend WithEvents Checkbox_EnableTracing As CheckBox
    Friend WithEvents Checkbox_LogIncommingTraffic As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Checkbox_FillInitialData As CheckBox
    Friend WithEvents Checkbox_CreateDatabase As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Checkbox_AddSiteSettings As CheckBox
    Friend WithEvents RadioButton_UseLocalVersion As RadioButton
    Friend WithEvents RadioButton_InstallLatestVersion As RadioButton
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Textbox_ProjectName As TextBox
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents Label24 As Label
    Friend WithEvents Textbox_DatabaseHostname As TextBox
    Friend WithEvents Wizard_Page_Busy As DevComponents.DotNetBar.WizardPage
    Friend WithEvents Picturebox_Step1 As PictureBox
    Friend WithEvents Picturebox_Step2 As PictureBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Picturebox_Step3 As PictureBox
    Friend WithEvents Label_Step4 As Label
    Friend WithEvents Picturebox_Step4 As PictureBox
    Friend WithEvents Checkbox_UseSmtp As CheckBox
    Friend WithEvents Timer_Main As Timer
End Class

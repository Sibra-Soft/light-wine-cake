<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Settings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Numeric_ServerPort = New System.Windows.Forms.NumericUpDown()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Checkbox_AlwaysUpdateBeforeStart = New System.Windows.Forms.CheckBox()
        Me.RadioButton_ComposerPackage = New System.Windows.Forms.RadioButton()
        Me.RadioButton_LocalPackage = New System.Windows.Forms.RadioButton()
        Me.Textbox_LocalPackageLocation = New System.Windows.Forms.TextBox()
        Me.Button_Browse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer_Main = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Numeric_ServerPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Numeric_ServerPort)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Server "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Local port to use:"
        '
        'Numeric_ServerPort
        '
        Me.Numeric_ServerPort.Location = New System.Drawing.Point(222, 38)
        Me.Numeric_ServerPort.Maximum = New Decimal(New Integer() {9000, 0, 0, 0})
        Me.Numeric_ServerPort.Name = "Numeric_ServerPort"
        Me.Numeric_ServerPort.Size = New System.Drawing.Size(80, 21)
        Me.Numeric_ServerPort.TabIndex = 0
        Me.Numeric_ServerPort.Value = New Decimal(New Integer() {8080, 0, 0, 0})
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Location = New System.Drawing.Point(224, 238)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancel.TabIndex = 1
        Me.Button_Cancel.Text = "&Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(143, 238)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 2
        Me.Button_Save.Text = "&Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Checkbox_AlwaysUpdateBeforeStart
        '
        Me.Checkbox_AlwaysUpdateBeforeStart.AutoSize = True
        Me.Checkbox_AlwaysUpdateBeforeStart.Location = New System.Drawing.Point(12, 118)
        Me.Checkbox_AlwaysUpdateBeforeStart.Name = "Checkbox_AlwaysUpdateBeforeStart"
        Me.Checkbox_AlwaysUpdateBeforeStart.Size = New System.Drawing.Size(315, 17)
        Me.Checkbox_AlwaysUpdateBeforeStart.TabIndex = 3
        Me.Checkbox_AlwaysUpdateBeforeStart.Text = "Always check for updates before starting a project"
        Me.Checkbox_AlwaysUpdateBeforeStart.UseVisualStyleBackColor = True
        '
        'RadioButton_ComposerPackage
        '
        Me.RadioButton_ComposerPackage.AutoSize = True
        Me.RadioButton_ComposerPackage.Checked = True
        Me.RadioButton_ComposerPackage.Location = New System.Drawing.Point(12, 143)
        Me.RadioButton_ComposerPackage.Name = "RadioButton_ComposerPackage"
        Me.RadioButton_ComposerPackage.Size = New System.Drawing.Size(300, 17)
        Me.RadioButton_ComposerPackage.TabIndex = 4
        Me.RadioButton_ComposerPackage.TabStop = True
        Me.RadioButton_ComposerPackage.Text = "Use Composer package for updating framework"
        Me.RadioButton_ComposerPackage.UseVisualStyleBackColor = True
        '
        'RadioButton_LocalPackage
        '
        Me.RadioButton_LocalPackage.AutoSize = True
        Me.RadioButton_LocalPackage.Location = New System.Drawing.Point(12, 161)
        Me.RadioButton_LocalPackage.Name = "RadioButton_LocalPackage"
        Me.RadioButton_LocalPackage.Size = New System.Drawing.Size(267, 17)
        Me.RadioButton_LocalPackage.TabIndex = 5
        Me.RadioButton_LocalPackage.TabStop = True
        Me.RadioButton_LocalPackage.Text = "Use local package for updating framework"
        Me.RadioButton_LocalPackage.UseVisualStyleBackColor = True
        '
        'Textbox_LocalPackageLocation
        '
        Me.Textbox_LocalPackageLocation.Enabled = False
        Me.Textbox_LocalPackageLocation.Location = New System.Drawing.Point(12, 184)
        Me.Textbox_LocalPackageLocation.Name = "Textbox_LocalPackageLocation"
        Me.Textbox_LocalPackageLocation.Size = New System.Drawing.Size(365, 21)
        Me.Textbox_LocalPackageLocation.TabIndex = 6
        '
        'Button_Browse
        '
        Me.Button_Browse.Enabled = False
        Me.Button_Browse.Location = New System.Drawing.Point(383, 183)
        Me.Button_Browse.Name = "Button_Browse"
        Me.Button_Browse.Size = New System.Drawing.Size(40, 23)
        Me.Button_Browse.TabIndex = 7
        Me.Button_Browse.Text = "..."
        Me.Button_Browse.UseVisualStyleBackColor = True
        '
        'Timer_Main
        '
        Me.Timer_Main.Enabled = True
        Me.Timer_Main.Interval = 10
        '
        'Form_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 273)
        Me.Controls.Add(Me.Button_Browse)
        Me.Controls.Add(Me.Textbox_LocalPackageLocation)
        Me.Controls.Add(Me.RadioButton_LocalPackage)
        Me.Controls.Add(Me.RadioButton_ComposerPackage)
        Me.Controls.Add(Me.Checkbox_AlwaysUpdateBeforeStart)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form_Settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Numeric_ServerPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Numeric_ServerPort As NumericUpDown
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents Checkbox_AlwaysUpdateBeforeStart As CheckBox
    Friend WithEvents RadioButton_ComposerPackage As RadioButton
    Friend WithEvents RadioButton_LocalPackage As RadioButton
    Friend WithEvents Textbox_LocalPackageLocation As TextBox
    Friend WithEvents Button_Browse As Button
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents Timer_Main As Timer
End Class

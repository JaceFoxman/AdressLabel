<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelForm
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
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAdressLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.StreetAdressLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(14, 18)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(353, 420)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Mailing Adress"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(10, 324)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(35, 20)
        Me.ZipLabel.TabIndex = 7
        Me.ZipLabel.Text = "Zip:"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(14, 352)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(112, 26)
        Me.ZipTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ZipTextBox, "Add your numeric Zip code value")
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(6, 272)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(52, 20)
        Me.StateLabel.TabIndex = 7
        Me.StateLabel.Text = "State:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(6, 218)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(39, 20)
        Me.CityLabel.TabIndex = 7
        Me.CityLabel.Text = "City:"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(10, 295)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(112, 26)
        Me.StateTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.StateTextBox, "Add the abreviatioin of your state")
        '
        'StreetAdressLabel
        '
        Me.StreetAdressLabel.AutoSize = True
        Me.StreetAdressLabel.Location = New System.Drawing.Point(6, 155)
        Me.StreetAdressLabel.Name = "StreetAdressLabel"
        Me.StreetAdressLabel.Size = New System.Drawing.Size(120, 20)
        Me.StreetAdressLabel.TabIndex = 7
        Me.StreetAdressLabel.Text = "Street Address:"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(6, 94)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(90, 20)
        Me.LastNameLabel.TabIndex = 7
        Me.LastNameLabel.Text = "Last Name:"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(10, 241)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(116, 26)
        Me.CityTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Add the City you live in")
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 42)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(90, 20)
        Me.FirstNameLabel.TabIndex = 7
        Me.FirstNameLabel.Text = "First Name:"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(6, 178)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(317, 26)
        Me.StreetAddressTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.StreetAddressTextBox, "Add your Street Adress")
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(6, 117)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(317, 26)
        Me.LastNameTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.LastNameTextBox, "Add your last Name")
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(6, 65)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(317, 26)
        Me.FirstNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FirstNameTextBox, "Add your First Name")
        '
        'DisplayButton
        '
        Me.DisplayButton.BackColor = System.Drawing.Color.SeaShell
        Me.DisplayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayButton.Location = New System.Drawing.Point(373, 328)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(136, 110)
        Me.DisplayButton.TabIndex = 8
        Me.DisplayButton.Text = "Display Label"
        Me.ToolTip1.SetToolTip(Me.DisplayButton, "Displays informatin")
        Me.DisplayButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Lavender
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(515, 328)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(126, 110)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears any previously enterd information")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(647, 328)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(141, 110)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Close program")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(373, 18)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(415, 297)
        Me.OutputGroupBox.TabIndex = 7
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Adress Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(22, 40)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(368, 227)
        Me.DisplayLabel.TabIndex = 0
        '
        'AddressLabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "AddressLabelForm"
        Me.Text = "AdressLabelForm"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetAdressLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class

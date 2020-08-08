<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titleComboBox = New System.Windows.Forms.ComboBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.studentIDTextBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.cancel1Button = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = true
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.titleLabel.Location = New System.Drawing.Point(59, 21)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(48, 21)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Title:"
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = true
        Me.firstNameLabel.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.firstNameLabel.Location = New System.Drawing.Point(11, 53)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(96, 21)
        Me.firstNameLabel.TabIndex = 1
        Me.firstNameLabel.Text = "First Name:"
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = true
        Me.lastNameLabel.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lastNameLabel.Location = New System.Drawing.Point(13, 85)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(94, 21)
        Me.lastNameLabel.TabIndex = 2
        Me.lastNameLabel.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student ID:"
        '
        'titleComboBox
        '
        Me.titleComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.titleComboBox.FormattingEnabled = true
        Me.titleComboBox.Items.AddRange(New Object() {"Mr", "Ms"})
        Me.titleComboBox.Location = New System.Drawing.Point(113, 21)
        Me.titleComboBox.Name = "titleComboBox"
        Me.titleComboBox.Size = New System.Drawing.Size(78, 25)
        Me.titleComboBox.TabIndex = 4
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.firstNameTextBox.Location = New System.Drawing.Point(113, 53)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(161, 25)
        Me.firstNameTextBox.TabIndex = 5
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lastNameTextBox.Location = New System.Drawing.Point(113, 85)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(161, 25)
        Me.lastNameTextBox.TabIndex = 6
        '
        'studentIDTextBox
        '
        Me.studentIDTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.studentIDTextBox.Location = New System.Drawing.Point(113, 117)
        Me.studentIDTextBox.MaxLength = 9
        Me.studentIDTextBox.Name = "studentIDTextBox"
        Me.studentIDTextBox.Size = New System.Drawing.Size(161, 25)
        Me.studentIDTextBox.TabIndex = 7
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Silver
        Me.addButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.addButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.addButton.Location = New System.Drawing.Point(113, 159)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(161, 35)
        Me.addButton.TabIndex = 8
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = false
        '
        'cancel1Button
        '
        Me.cancel1Button.BackColor = System.Drawing.Color.Silver
        Me.cancel1Button.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cancel1Button.ForeColor = System.Drawing.Color.Maroon
        Me.cancel1Button.Location = New System.Drawing.Point(12, 159)
        Me.cancel1Button.Name = "cancel1Button"
        Me.cancel1Button.Size = New System.Drawing.Size(82, 35)
        Me.cancel1Button.TabIndex = 9
        Me.cancel1Button.Text = "Cancel"
        Me.cancel1Button.UseVisualStyleBackColor = false
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 197)
        Me.Controls.Add(Me.cancel1Button)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.studentIDTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.titleComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lastNameLabel)
        Me.Controls.Add(Me.firstNameLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "RegisterForm"
        Me.Text = "Register Member"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents titleComboBox As ComboBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents cancel1Button As Button
End Class

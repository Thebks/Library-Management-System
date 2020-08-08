<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.mainName = New System.Windows.Forms.Label()
        Me.LibraryMember = New System.Windows.Forms.GroupBox()
        Me.selectButton = New System.Windows.Forms.Button()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.memberIDTextBox = New System.Windows.Forms.TextBox()
        Me.studentIDTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextbox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.memberIDLabel = New System.Windows.Forms.Label()
        Me.studentIDLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.bookDetails = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.selectBookButton = New System.Windows.Forms.Button()
        Me.bookIDTextBox = New System.Windows.Forms.TextBox()
        Me.categoryTextBox = New System.Windows.Forms.TextBox()
        Me.yearPubTextBox = New System.Windows.Forms.TextBox()
        Me.authorTextBox = New System.Windows.Forms.TextBox()
        Me.bookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.isbnTextBox = New System.Windows.Forms.TextBox()
        Me.borrowedLabel = New System.Windows.Forms.Label()
        Me.borrowedCheckBox = New System.Windows.Forms.CheckBox()
        Me.bookidLabel = New System.Windows.Forms.Label()
        Me.categoryLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.authorLabel = New System.Windows.Forms.Label()
        Me.bookTitleLabel = New System.Windows.Forms.Label()
        Me.isbnLabel = New System.Windows.Forms.Label()
        Me.libraryLoanInfo = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lliborrowedButton = New System.Windows.Forms.Button()
        Me.llilateReturnFineTextBox = New System.Windows.Forms.TextBox()
        Me.llilateReturnFineLabel = New System.Windows.Forms.Label()
        Me.llidateReturnButton = New System.Windows.Forms.Button()
        Me.llidateReturnResult = New System.Windows.Forms.Label()
        Me.llidateReturnTextBox = New System.Windows.Forms.TextBox()
        Me.llidueDateTextBox = New System.Windows.Forms.TextBox()
        Me.llidateBorrowTextBox = New System.Windows.Forms.TextBox()
        Me.llimemberIDTextBox = New System.Windows.Forms.TextBox()
        Me.lliBookIDTextBox = New System.Windows.Forms.TextBox()
        Me.llidateReturn = New System.Windows.Forms.Label()
        Me.llibookIDLabel = New System.Windows.Forms.Label()
        Me.llidueDate = New System.Windows.Forms.Label()
        Me.llimemberIDLabel = New System.Windows.Forms.Label()
        Me.llidateborrowLabel = New System.Windows.Forms.Label()
        Me.LibraryMember.SuspendLayout
        Me.bookDetails.SuspendLayout
        Me.libraryLoanInfo.SuspendLayout
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'mainName
        '
        resources.ApplyResources(Me.mainName, "mainName")
        Me.mainName.Name = "mainName"
        '
        'LibraryMember
        '
        Me.LibraryMember.BackColor = System.Drawing.Color.AliceBlue
        Me.LibraryMember.Controls.Add(Me.selectButton)
        Me.LibraryMember.Controls.Add(Me.registerButton)
        Me.LibraryMember.Controls.Add(Me.deleteButton)
        Me.LibraryMember.Controls.Add(Me.memberIDTextBox)
        Me.LibraryMember.Controls.Add(Me.studentIDTextBox)
        Me.LibraryMember.Controls.Add(Me.lastNameTextbox)
        Me.LibraryMember.Controls.Add(Me.firstNameTextBox)
        Me.LibraryMember.Controls.Add(Me.titleTextBox)
        Me.LibraryMember.Controls.Add(Me.memberIDLabel)
        Me.LibraryMember.Controls.Add(Me.studentIDLabel)
        Me.LibraryMember.Controls.Add(Me.lastNameLabel)
        Me.LibraryMember.Controls.Add(Me.firstNameLabel)
        Me.LibraryMember.Controls.Add(Me.titleLabel)
        resources.ApplyResources(Me.LibraryMember, "LibraryMember")
        Me.LibraryMember.Name = "LibraryMember"
        Me.LibraryMember.TabStop = false
        '
        'selectButton
        '
        Me.selectButton.BackColor = System.Drawing.Color.SlateBlue
        resources.ApplyResources(Me.selectButton, "selectButton")
        Me.selectButton.ForeColor = System.Drawing.Color.Transparent
        Me.selectButton.Name = "selectButton"
        Me.selectButton.UseVisualStyleBackColor = false
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.Color.Green
        resources.ApplyResources(Me.registerButton, "registerButton")
        Me.registerButton.ForeColor = System.Drawing.Color.Transparent
        Me.registerButton.Name = "registerButton"
        Me.registerButton.UseVisualStyleBackColor = false
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Crimson
        resources.ApplyResources(Me.deleteButton, "deleteButton")
        Me.deleteButton.ForeColor = System.Drawing.Color.Transparent
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.UseVisualStyleBackColor = false
        '
        'memberIDTextBox
        '
        resources.ApplyResources(Me.memberIDTextBox, "memberIDTextBox")
        Me.memberIDTextBox.Name = "memberIDTextBox"
        Me.memberIDTextBox.ReadOnly = true
        '
        'studentIDTextBox
        '
        resources.ApplyResources(Me.studentIDTextBox, "studentIDTextBox")
        Me.studentIDTextBox.Name = "studentIDTextBox"
        Me.studentIDTextBox.ReadOnly = true
        '
        'lastNameTextbox
        '
        resources.ApplyResources(Me.lastNameTextbox, "lastNameTextbox")
        Me.lastNameTextbox.Name = "lastNameTextbox"
        Me.lastNameTextbox.ReadOnly = true
        '
        'firstNameTextBox
        '
        resources.ApplyResources(Me.firstNameTextBox, "firstNameTextBox")
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.ReadOnly = true
        '
        'titleTextBox
        '
        resources.ApplyResources(Me.titleTextBox, "titleTextBox")
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.ReadOnly = true
        '
        'memberIDLabel
        '
        resources.ApplyResources(Me.memberIDLabel, "memberIDLabel")
        Me.memberIDLabel.Name = "memberIDLabel"
        '
        'studentIDLabel
        '
        resources.ApplyResources(Me.studentIDLabel, "studentIDLabel")
        Me.studentIDLabel.Name = "studentIDLabel"
        '
        'lastNameLabel
        '
        resources.ApplyResources(Me.lastNameLabel, "lastNameLabel")
        Me.lastNameLabel.Name = "lastNameLabel"
        '
        'firstNameLabel
        '
        resources.ApplyResources(Me.firstNameLabel, "firstNameLabel")
        Me.firstNameLabel.Name = "firstNameLabel"
        '
        'titleLabel
        '
        resources.ApplyResources(Me.titleLabel, "titleLabel")
        Me.titleLabel.Name = "titleLabel"
        '
        'bookDetails
        '
        Me.bookDetails.BackColor = System.Drawing.Color.AliceBlue
        Me.bookDetails.Controls.Add(Me.Button1)
        Me.bookDetails.Controls.Add(Me.selectBookButton)
        Me.bookDetails.Controls.Add(Me.bookIDTextBox)
        Me.bookDetails.Controls.Add(Me.categoryTextBox)
        Me.bookDetails.Controls.Add(Me.yearPubTextBox)
        Me.bookDetails.Controls.Add(Me.authorTextBox)
        Me.bookDetails.Controls.Add(Me.bookTitleTextBox)
        Me.bookDetails.Controls.Add(Me.isbnTextBox)
        Me.bookDetails.Controls.Add(Me.borrowedLabel)
        Me.bookDetails.Controls.Add(Me.borrowedCheckBox)
        Me.bookDetails.Controls.Add(Me.bookidLabel)
        Me.bookDetails.Controls.Add(Me.categoryLabel)
        Me.bookDetails.Controls.Add(Me.yearLabel)
        Me.bookDetails.Controls.Add(Me.authorLabel)
        Me.bookDetails.Controls.Add(Me.bookTitleLabel)
        Me.bookDetails.Controls.Add(Me.isbnLabel)
        resources.ApplyResources(Me.bookDetails, "bookDetails")
        Me.bookDetails.Name = "bookDetails"
        Me.bookDetails.TabStop = false
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'selectBookButton
        '
        Me.selectBookButton.BackColor = System.Drawing.Color.SlateBlue
        resources.ApplyResources(Me.selectBookButton, "selectBookButton")
        Me.selectBookButton.ForeColor = System.Drawing.Color.Transparent
        Me.selectBookButton.Name = "selectBookButton"
        Me.selectBookButton.UseVisualStyleBackColor = false
        '
        'bookIDTextBox
        '
        resources.ApplyResources(Me.bookIDTextBox, "bookIDTextBox")
        Me.bookIDTextBox.Name = "bookIDTextBox"
        Me.bookIDTextBox.ReadOnly = true
        '
        'categoryTextBox
        '
        resources.ApplyResources(Me.categoryTextBox, "categoryTextBox")
        Me.categoryTextBox.Name = "categoryTextBox"
        Me.categoryTextBox.ReadOnly = true
        '
        'yearPubTextBox
        '
        resources.ApplyResources(Me.yearPubTextBox, "yearPubTextBox")
        Me.yearPubTextBox.Name = "yearPubTextBox"
        Me.yearPubTextBox.ReadOnly = true
        '
        'authorTextBox
        '
        resources.ApplyResources(Me.authorTextBox, "authorTextBox")
        Me.authorTextBox.Name = "authorTextBox"
        Me.authorTextBox.ReadOnly = true
        '
        'bookTitleTextBox
        '
        resources.ApplyResources(Me.bookTitleTextBox, "bookTitleTextBox")
        Me.bookTitleTextBox.Name = "bookTitleTextBox"
        Me.bookTitleTextBox.ReadOnly = true
        '
        'isbnTextBox
        '
        resources.ApplyResources(Me.isbnTextBox, "isbnTextBox")
        Me.isbnTextBox.Name = "isbnTextBox"
        Me.isbnTextBox.ReadOnly = true
        '
        'borrowedLabel
        '
        resources.ApplyResources(Me.borrowedLabel, "borrowedLabel")
        Me.borrowedLabel.Name = "borrowedLabel"
        '
        'borrowedCheckBox
        '
        resources.ApplyResources(Me.borrowedCheckBox, "borrowedCheckBox")
        Me.borrowedCheckBox.Name = "borrowedCheckBox"
        Me.borrowedCheckBox.UseVisualStyleBackColor = true
        '
        'bookidLabel
        '
        resources.ApplyResources(Me.bookidLabel, "bookidLabel")
        Me.bookidLabel.Name = "bookidLabel"
        '
        'categoryLabel
        '
        resources.ApplyResources(Me.categoryLabel, "categoryLabel")
        Me.categoryLabel.Name = "categoryLabel"
        '
        'yearLabel
        '
        resources.ApplyResources(Me.yearLabel, "yearLabel")
        Me.yearLabel.Name = "yearLabel"
        '
        'authorLabel
        '
        resources.ApplyResources(Me.authorLabel, "authorLabel")
        Me.authorLabel.Name = "authorLabel"
        '
        'bookTitleLabel
        '
        resources.ApplyResources(Me.bookTitleLabel, "bookTitleLabel")
        Me.bookTitleLabel.Name = "bookTitleLabel"
        '
        'isbnLabel
        '
        resources.ApplyResources(Me.isbnLabel, "isbnLabel")
        Me.isbnLabel.Name = "isbnLabel"
        '
        'libraryLoanInfo
        '
        Me.libraryLoanInfo.BackColor = System.Drawing.Color.AliceBlue
        Me.libraryLoanInfo.Controls.Add(Me.NumericUpDown1)
        Me.libraryLoanInfo.Controls.Add(Me.lliborrowedButton)
        Me.libraryLoanInfo.Controls.Add(Me.llilateReturnFineTextBox)
        Me.libraryLoanInfo.Controls.Add(Me.llilateReturnFineLabel)
        Me.libraryLoanInfo.Controls.Add(Me.llidateReturnButton)
        Me.libraryLoanInfo.Controls.Add(Me.llidateReturnResult)
        Me.libraryLoanInfo.Controls.Add(Me.llidateReturnTextBox)
        Me.libraryLoanInfo.Controls.Add(Me.llidueDateTextBox)
        Me.libraryLoanInfo.Controls.Add(Me.llidateBorrowTextBox)
        Me.libraryLoanInfo.Controls.Add(Me.llimemberIDTextBox)
        Me.libraryLoanInfo.Controls.Add(Me.lliBookIDTextBox)
        Me.libraryLoanInfo.Controls.Add(Me.llidateReturn)
        Me.libraryLoanInfo.Controls.Add(Me.llibookIDLabel)
        Me.libraryLoanInfo.Controls.Add(Me.llidueDate)
        Me.libraryLoanInfo.Controls.Add(Me.llimemberIDLabel)
        Me.libraryLoanInfo.Controls.Add(Me.llidateborrowLabel)
        resources.ApplyResources(Me.libraryLoanInfo, "libraryLoanInfo")
        Me.libraryLoanInfo.Name = "libraryLoanInfo"
        Me.libraryLoanInfo.TabStop = false
        '
        'NumericUpDown1
        '
        resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lliborrowedButton
        '
        Me.lliborrowedButton.BackColor = System.Drawing.Color.Tomato
        resources.ApplyResources(Me.lliborrowedButton, "lliborrowedButton")
        Me.lliborrowedButton.ForeColor = System.Drawing.Color.Transparent
        Me.lliborrowedButton.Name = "lliborrowedButton"
        Me.lliborrowedButton.UseVisualStyleBackColor = false
        '
        'llilateReturnFineTextBox
        '
        resources.ApplyResources(Me.llilateReturnFineTextBox, "llilateReturnFineTextBox")
        Me.llilateReturnFineTextBox.Name = "llilateReturnFineTextBox"
        Me.llilateReturnFineTextBox.ReadOnly = true
        '
        'llilateReturnFineLabel
        '
        resources.ApplyResources(Me.llilateReturnFineLabel, "llilateReturnFineLabel")
        Me.llilateReturnFineLabel.Name = "llilateReturnFineLabel"
        '
        'llidateReturnButton
        '
        Me.llidateReturnButton.BackColor = System.Drawing.Color.MediumSeaGreen
        resources.ApplyResources(Me.llidateReturnButton, "llidateReturnButton")
        Me.llidateReturnButton.ForeColor = System.Drawing.Color.Transparent
        Me.llidateReturnButton.Name = "llidateReturnButton"
        Me.llidateReturnButton.UseVisualStyleBackColor = false
        '
        'llidateReturnResult
        '
        resources.ApplyResources(Me.llidateReturnResult, "llidateReturnResult")
        Me.llidateReturnResult.Name = "llidateReturnResult"
        '
        'llidateReturnTextBox
        '
        resources.ApplyResources(Me.llidateReturnTextBox, "llidateReturnTextBox")
        Me.llidateReturnTextBox.Name = "llidateReturnTextBox"
        '
        'llidueDateTextBox
        '
        resources.ApplyResources(Me.llidueDateTextBox, "llidueDateTextBox")
        Me.llidueDateTextBox.Name = "llidueDateTextBox"
        Me.llidueDateTextBox.ReadOnly = true
        '
        'llidateBorrowTextBox
        '
        resources.ApplyResources(Me.llidateBorrowTextBox, "llidateBorrowTextBox")
        Me.llidateBorrowTextBox.Name = "llidateBorrowTextBox"
        Me.llidateBorrowTextBox.ReadOnly = true
        '
        'llimemberIDTextBox
        '
        resources.ApplyResources(Me.llimemberIDTextBox, "llimemberIDTextBox")
        Me.llimemberIDTextBox.Name = "llimemberIDTextBox"
        Me.llimemberIDTextBox.ReadOnly = true
        '
        'lliBookIDTextBox
        '
        resources.ApplyResources(Me.lliBookIDTextBox, "lliBookIDTextBox")
        Me.lliBookIDTextBox.Name = "lliBookIDTextBox"
        Me.lliBookIDTextBox.ReadOnly = true
        '
        'llidateReturn
        '
        resources.ApplyResources(Me.llidateReturn, "llidateReturn")
        Me.llidateReturn.Name = "llidateReturn"
        '
        'llibookIDLabel
        '
        resources.ApplyResources(Me.llibookIDLabel, "llibookIDLabel")
        Me.llibookIDLabel.Name = "llibookIDLabel"
        '
        'llidueDate
        '
        resources.ApplyResources(Me.llidueDate, "llidueDate")
        Me.llidueDate.Name = "llidueDate"
        '
        'llimemberIDLabel
        '
        resources.ApplyResources(Me.llimemberIDLabel, "llimemberIDLabel")
        Me.llimemberIDLabel.Name = "llimemberIDLabel"
        '
        'llidateborrowLabel
        '
        resources.ApplyResources(Me.llidateborrowLabel, "llidateborrowLabel")
        Me.llidateborrowLabel.Name = "llidateborrowLabel"
        '
        'MainWindow
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.libraryLoanInfo)
        Me.Controls.Add(Me.bookDetails)
        Me.Controls.Add(Me.LibraryMember)
        Me.Controls.Add(Me.mainName)
        Me.Name = "MainWindow"
        Me.LibraryMember.ResumeLayout(false)
        Me.LibraryMember.PerformLayout
        Me.bookDetails.ResumeLayout(false)
        Me.bookDetails.PerformLayout
        Me.libraryLoanInfo.ResumeLayout(false)
        Me.libraryLoanInfo.PerformLayout
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents mainName As Label
    Friend WithEvents LibraryMember As GroupBox
    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents memberIDLabel As Label
    Friend WithEvents studentIDLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents memberIDTextBox As TextBox
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents lastNameTextbox As TextBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents selectButton As Button
    Friend WithEvents registerButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bookDetails As GroupBox
    Friend WithEvents selectBookButton As Button
    Friend WithEvents bookIDTextBox As TextBox
    Friend WithEvents categoryTextBox As TextBox
    Friend WithEvents yearPubTextBox As TextBox
    Friend WithEvents authorTextBox As TextBox
    Friend WithEvents bookTitleTextBox As TextBox
    Friend WithEvents isbnTextBox As TextBox
    Friend WithEvents borrowedLabel As Label
    Friend WithEvents borrowedCheckBox As CheckBox
    Friend WithEvents bookidLabel As Label
    Friend WithEvents categoryLabel As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents authorLabel As Label
    Friend WithEvents bookTitleLabel As Label
    Friend WithEvents isbnLabel As Label
    Friend WithEvents libraryLoanInfo As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lliborrowedButton As Button
    Friend WithEvents llilateReturnFineTextBox As TextBox
    Friend WithEvents llilateReturnFineLabel As Label
    Friend WithEvents llidateReturnButton As Button
    Friend WithEvents llidateReturnResult As Label
    Friend WithEvents llidateReturnTextBox As TextBox
    Friend WithEvents llidueDateTextBox As TextBox
    Friend WithEvents llidateBorrowTextBox As TextBox
    Friend WithEvents llimemberIDTextBox As TextBox
    Friend WithEvents lliBookIDTextBox As TextBox
    Friend WithEvents llidateReturn As Label
    Friend WithEvents llibookIDLabel As Label
    Friend WithEvents llidueDate As Label
    Friend WithEvents llimemberIDLabel As Label
    Friend WithEvents llidateborrowLabel As Label
    Friend WithEvents Button1 As Button
End Class

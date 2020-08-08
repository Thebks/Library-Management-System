<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteMember
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
        Me.searchButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibraryMemberTableAdapter = New FinalLibraryManApp.libdbDataSetTableAdapters.LibraryMemberTableAdapter()
        Me.LibraryMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibdbDataSet = New FinalLibraryManApp.libdbDataSet()
        Me.studentFirstNameCBx = New System.Windows.Forms.ComboBox()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.studentIDTextBox = New System.Windows.Forms.TextBox()
        Me.memberIDTextBox = New System.Windows.Forms.TextBox()
        Me.studentIDLabel = New System.Windows.Forms.Label()
        Me.memberIDLabel = New System.Windows.Forms.Label()
        CType(Me.LibraryMemberBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LibdbDataSetBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LibdbDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.searchButton.Location = New System.Drawing.Point(667, 47)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(121, 31)
        Me.searchButton.TabIndex = 15
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = true
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = true
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = true
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = true
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = true
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "Member ID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.ReadOnly = true
        '
        'LibraryMemberTableAdapter
        '
        Me.LibraryMemberTableAdapter.ClearBeforeFill = true
        '
        'LibraryMemberBindingSource
        '
        Me.LibraryMemberBindingSource.DataMember = "LibraryMember"
        Me.LibraryMemberBindingSource.DataSource = Me.LibdbDataSetBindingSource
        '
        'LibdbDataSetBindingSource
        '
        Me.LibdbDataSetBindingSource.DataSource = Me.LibdbDataSet
        Me.LibdbDataSetBindingSource.Position = 0
        '
        'LibdbDataSet
        '
        Me.LibdbDataSet.DataSetName = "libdbDataSet"
        Me.LibdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'studentFirstNameCBx
        '
        Me.studentFirstNameCBx.Font = New System.Drawing.Font("Segoe UI Semilight", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.studentFirstNameCBx.FormattingEnabled = true
        Me.studentFirstNameCBx.Location = New System.Drawing.Point(576, 134)
        Me.studentFirstNameCBx.Name = "studentFirstNameCBx"
        Me.studentFirstNameCBx.Size = New System.Drawing.Size(211, 29)
        Me.studentFirstNameCBx.TabIndex = 16
        '
        'searchTextBox
        '
        Me.searchTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.searchTextBox.Location = New System.Drawing.Point(571, 12)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(217, 29)
        Me.searchTextBox.TabIndex = 14
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = false
        Me.dgvData.AllowUserToDeleteRows = false
        Me.dgvData.AllowUserToOrderColumns = true
        Me.dgvData.AutoGenerateColumns = false
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.LibraryMemberBindingSource
        Me.dgvData.Location = New System.Drawing.Point(13, 12)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = true
        Me.dgvData.Size = New System.Drawing.Size(543, 426)
        Me.dgvData.TabIndex = 9
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Crimson
        Me.deleteButton.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.deleteButton.ForeColor = System.Drawing.Color.Transparent
        Me.deleteButton.Location = New System.Drawing.Point(575, 396)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(211, 42)
        Me.deleteButton.TabIndex = 21
        Me.deleteButton.Text = "Delete Member"
        Me.deleteButton.UseVisualStyleBackColor = false
        '
        'studentIDTextBox
        '
        Me.studentIDTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.studentIDTextBox.Location = New System.Drawing.Point(666, 354)
        Me.studentIDTextBox.Name = "studentIDTextBox"
        Me.studentIDTextBox.ReadOnly = true
        Me.studentIDTextBox.Size = New System.Drawing.Size(121, 29)
        Me.studentIDTextBox.TabIndex = 20
        '
        'memberIDTextBox
        '
        Me.memberIDTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.memberIDTextBox.Location = New System.Drawing.Point(666, 319)
        Me.memberIDTextBox.Name = "memberIDTextBox"
        Me.memberIDTextBox.ReadOnly = true
        Me.memberIDTextBox.Size = New System.Drawing.Size(121, 29)
        Me.memberIDTextBox.TabIndex = 19
        '
        'studentIDLabel
        '
        Me.studentIDLabel.AutoSize = true
        Me.studentIDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.studentIDLabel.Location = New System.Drawing.Point(571, 358)
        Me.studentIDLabel.Name = "studentIDLabel"
        Me.studentIDLabel.Size = New System.Drawing.Size(89, 20)
        Me.studentIDLabel.TabIndex = 18
        Me.studentIDLabel.Text = "Student ID: "
        '
        'memberIDLabel
        '
        Me.memberIDLabel.AutoSize = true
        Me.memberIDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.memberIDLabel.Location = New System.Drawing.Point(566, 323)
        Me.memberIDLabel.Name = "memberIDLabel"
        Me.memberIDLabel.Size = New System.Drawing.Size(94, 20)
        Me.memberIDLabel.TabIndex = 17
        Me.memberIDLabel.Text = "Member ID: "
        '
        'DeleteMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.studentIDTextBox)
        Me.Controls.Add(Me.memberIDTextBox)
        Me.Controls.Add(Me.studentIDLabel)
        Me.Controls.Add(Me.memberIDLabel)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.studentFirstNameCBx)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "DeleteMember"
        Me.Text = "Delete Member"
        CType(Me.LibraryMemberBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LibdbDataSetBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LibdbDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvData,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents searchButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibraryMemberTableAdapter As libdbDataSetTableAdapters.LibraryMemberTableAdapter
    Friend WithEvents LibraryMemberBindingSource As BindingSource
    Friend WithEvents LibdbDataSetBindingSource As BindingSource
    Friend WithEvents LibdbDataSet As libdbDataSet
    Friend WithEvents studentFirstNameCBx As ComboBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents deleteButton As Button
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents memberIDTextBox As TextBox
    Friend WithEvents studentIDLabel As Label
    Friend WithEvents memberIDLabel As Label
End Class

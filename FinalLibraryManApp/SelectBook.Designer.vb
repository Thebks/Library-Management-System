<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectBook
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
        Me.selectBookButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.booksComboBox = New System.Windows.Forms.ComboBox()
        Me.isbnTextBox = New System.Windows.Forms.TextBox()
        Me.bookIDTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.bookIDLabel = New System.Windows.Forms.Label()
        Me.LibraryMemberTableAdapter = New FinalLibraryManApp.libdbDataSetTableAdapters.LibraryMemberTableAdapter()
        Me.LibdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibdbDataSet = New FinalLibraryManApp.libdbDataSet()
        Me.LibraryMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Databook = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearPublishedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BookDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookDetailsTableAdapter = New FinalLibraryManApp.libdbDataSetTableAdapters.BookDetailsTableAdapter()
        CType(Me.LibdbDataSetBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LibdbDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LibraryMemberBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Databook,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BookDetailsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'selectBookButton
        '
        Me.selectBookButton.BackColor = System.Drawing.Color.SlateBlue
        Me.selectBookButton.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.selectBookButton.ForeColor = System.Drawing.Color.Transparent
        Me.selectBookButton.Location = New System.Drawing.Point(784, 396)
        Me.selectBookButton.Name = "selectBookButton"
        Me.selectBookButton.Size = New System.Drawing.Size(233, 42)
        Me.selectBookButton.TabIndex = 18
        Me.selectBookButton.Text = "Select Book"
        Me.selectBookButton.UseVisualStyleBackColor = false
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.searchButton.Location = New System.Drawing.Point(896, 47)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(121, 31)
        Me.searchButton.TabIndex = 16
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = true
        '
        'searchTextBox
        '
        Me.searchTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.searchTextBox.Location = New System.Drawing.Point(800, 12)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(217, 29)
        Me.searchTextBox.TabIndex = 15
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'booksComboBox
        '
        Me.booksComboBox.Font = New System.Drawing.Font("Segoe UI Semilight", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.booksComboBox.FormattingEnabled = true
        Me.booksComboBox.Location = New System.Drawing.Point(800, 134)
        Me.booksComboBox.Name = "booksComboBox"
        Me.booksComboBox.Size = New System.Drawing.Size(216, 29)
        Me.booksComboBox.TabIndex = 17
        '
        'isbnTextBox
        '
        Me.isbnTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.isbnTextBox.Location = New System.Drawing.Point(851, 354)
        Me.isbnTextBox.Name = "isbnTextBox"
        Me.isbnTextBox.ReadOnly = true
        Me.isbnTextBox.Size = New System.Drawing.Size(165, 29)
        Me.isbnTextBox.TabIndex = 14
        '
        'bookIDTextBox
        '
        Me.bookIDTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.bookIDTextBox.Location = New System.Drawing.Point(851, 319)
        Me.bookIDTextBox.Name = "bookIDTextBox"
        Me.bookIDTextBox.ReadOnly = true
        Me.bookIDTextBox.Size = New System.Drawing.Size(165, 29)
        Me.bookIDTextBox.TabIndex = 13
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = true
        Me.ISBNLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ISBNLabel.Location = New System.Drawing.Point(801, 358)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(50, 20)
        Me.ISBNLabel.TabIndex = 12
        Me.ISBNLabel.Text = "ISBN: "
        '
        'bookIDLabel
        '
        Me.bookIDLabel.AutoSize = true
        Me.bookIDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.bookIDLabel.Location = New System.Drawing.Point(780, 323)
        Me.bookIDLabel.Name = "bookIDLabel"
        Me.bookIDLabel.Size = New System.Drawing.Size(71, 20)
        Me.bookIDLabel.TabIndex = 11
        Me.bookIDLabel.Text = "Book ID: "
        '
        'LibraryMemberTableAdapter
        '
        Me.LibraryMemberTableAdapter.ClearBeforeFill = true
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
        'LibraryMemberBindingSource
        '
        Me.LibraryMemberBindingSource.DataMember = "LibraryMember"
        Me.LibraryMemberBindingSource.DataSource = Me.LibdbDataSetBindingSource
        '
        'Databook
        '
        Me.Databook.AllowUserToAddRows = false
        Me.Databook.AllowUserToDeleteRows = false
        Me.Databook.AutoGenerateColumns = false
        Me.Databook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Databook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.BookTitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.YearPublishedDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.BorrowedDataGridViewCheckBoxColumn})
        Me.Databook.DataSource = Me.BookDetailsBindingSource
        Me.Databook.GridColor = System.Drawing.Color.LemonChiffon
        Me.Databook.Location = New System.Drawing.Point(13, 12)
        Me.Databook.Name = "Databook"
        Me.Databook.ReadOnly = true
        Me.Databook.Size = New System.Drawing.Size(743, 426)
        Me.Databook.TabIndex = 10
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = true
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = true
        '
        'BookTitleDataGridViewTextBoxColumn
        '
        Me.BookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle"
        Me.BookTitleDataGridViewTextBoxColumn.HeaderText = "Book Title"
        Me.BookTitleDataGridViewTextBoxColumn.Name = "BookTitleDataGridViewTextBoxColumn"
        Me.BookTitleDataGridViewTextBoxColumn.ReadOnly = true
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = true
        '
        'YearPublishedDataGridViewTextBoxColumn
        '
        Me.YearPublishedDataGridViewTextBoxColumn.DataPropertyName = "YearPublished"
        Me.YearPublishedDataGridViewTextBoxColumn.HeaderText = "Year Published"
        Me.YearPublishedDataGridViewTextBoxColumn.Name = "YearPublishedDataGridViewTextBoxColumn"
        Me.YearPublishedDataGridViewTextBoxColumn.ReadOnly = true
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = true
        '
        'BorrowedDataGridViewCheckBoxColumn
        '
        Me.BorrowedDataGridViewCheckBoxColumn.DataPropertyName = "Borrowed"
        Me.BorrowedDataGridViewCheckBoxColumn.HeaderText = "Borrowed"
        Me.BorrowedDataGridViewCheckBoxColumn.Name = "BorrowedDataGridViewCheckBoxColumn"
        Me.BorrowedDataGridViewCheckBoxColumn.ReadOnly = true
        '
        'BookDetailsBindingSource
        '
        Me.BookDetailsBindingSource.DataMember = "BookDetails"
        Me.BookDetailsBindingSource.DataSource = Me.LibdbDataSetBindingSource
        '
        'BookDetailsTableAdapter
        '
        Me.BookDetailsTableAdapter.ClearBeforeFill = true
        '
        'SelectBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 450)
        Me.Controls.Add(Me.selectBookButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.booksComboBox)
        Me.Controls.Add(Me.isbnTextBox)
        Me.Controls.Add(Me.bookIDTextBox)
        Me.Controls.Add(Me.ISBNLabel)
        Me.Controls.Add(Me.bookIDLabel)
        Me.Controls.Add(Me.Databook)
        Me.Name = "SelectBook"
        Me.Text = "SelectBook"
        CType(Me.LibdbDataSetBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LibdbDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LibraryMemberBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Databook,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BookDetailsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents selectBookButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents booksComboBox As ComboBox
    Friend WithEvents isbnTextBox As TextBox
    Friend WithEvents bookIDTextBox As TextBox
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents bookIDLabel As Label
    Friend WithEvents LibraryMemberTableAdapter As libdbDataSetTableAdapters.LibraryMemberTableAdapter
    Friend WithEvents LibdbDataSetBindingSource As BindingSource
    Friend WithEvents LibdbDataSet As libdbDataSet
    Friend WithEvents LibraryMemberBindingSource As BindingSource
    Friend WithEvents Databook As DataGridView
    Friend WithEvents BookDetailsBindingSource As BindingSource
    Friend WithEvents BookDetailsTableAdapter As libdbDataSetTableAdapters.BookDetailsTableAdapter
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearPublishedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class

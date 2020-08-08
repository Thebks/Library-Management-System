Public Class SelectBook
    Private Access As New DBControl

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub SelectBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibdbDataSet.BookDetails' table. You can move, or remove it, as needed.
        Me.BookDetailsTableAdapter.Fill(Me.LibdbDataSet.BookDetails)
        Refreshgrid()
    End Sub
    Public Sub RefreshGrid()
        
        Access.ExecQuery("SELECT * FROM BookDetails ORDER BY BookID ")


        If NoErrors(True) = False Then Exit Sub
        

        Databook.DataSource = Access.DBDT

       
        booksComboBox.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            booksComboBox.Items.Add(R("BookTitle"))
        Next

        ' DISPLAY FIRS NAME FOUND
        If Access.RecordCount > 0 Then booksComboBox    .SelectedIndex = 0
    End Sub
    Private Sub Searchbook(Name As String)
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@book", "%" & Name & "%")
        Access.ExecQuery("SELECT ISBN, BookTitle, Author, YearPublished, Category, Borrowed,BookID " &
                         "FROM BookDetails " &
                         "WHERE BookTitle LIKE @book")

        
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRIDVIEW
        Databook.DataSource = Access.DBDT
    End Sub
    Private Sub Selectbook(details As String)
        ' QUERY USER
        Access.AddParam("@bk", details)
        Access.ExecQuery("SELECT TOP 1 BookID, ISBN FROM BookDetails Where @bk=BookTitle")

        
        If NoErrors(True) = False Then
            MessageBox.Show("Error")
        ElseIf Access.RecordCount < 1 Then
            MessageBox.Show(CType(Access.RecordCount, String))
        End If
        ' GET FIRST ROW FOUND
        Dim r As DataRow = Access.DBDT.Rows(0)

        ' POPULATE TEXTBOXES WITH 
        bookIDTextBox.Text = r("BOOKID").ToString
        isbnTextBox.Text = r("ISBN").ToString

        
        selectBookButton.Enabled = True
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Searchbook(searchTextBox.Text)
    End Sub

    Private Sub booksComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles booksComboBox.SelectedIndexChanged
        If Not String.IsNullOrEmpty(booksComboBox.Text) Then Selectbook(booksComboBox.Text)
    End Sub

    Private Sub selectBookButton_Click(sender As Object, e As EventArgs) Handles selectBookButton.Click
        MainWindow.SetMyBooks(bookIDTextBox.Text)
        Me.Close()
    End Sub
    Private Sub Databook_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Databook.CellClick
        ' PREVENT OUT OF INDEX RANGE ERRORS
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        ' SELECT USERNAME FROM COLUMN 1 OF ROW CLICKED
        Selectbook(Databook.Item(2, e.RowIndex).Value.ToString)
    End Sub

End Class
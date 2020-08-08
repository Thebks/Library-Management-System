Public Class MainWindow
    Private Access As New DBControl
    Private Access1 As New DBControl
    Private Access3 As New DBControl
    Dim DaysBorrowed As Decimal
    Dim regDate As Date=Date.Now()
    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        RegisterForm.Show()
    End Sub

    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectButton.Click
        SelectMember.Show()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        DeleteMember.Show()
    End Sub
    Public Sub SetMymember(iGotmember As String)
        Access.AddParam("@mem", iGotmember)
        Dim querySMM As String
        querySMM="SELECT Title, FirstName, LastName, StudentID FROM LibraryMember where @mem=MemberID"
        Access.ExecQuery(querySMM)
        memberIDTextBox.Text=iGotmember
        Dim storeInMe As DataTable = New DataTable()
        Access.DBDA.Fill(storeInMe)
        titleTextBox.Text = storeInMe.Rows(0).Item("Title").ToString
        firstNameTextBox.Text = storeInMe.Rows(0).Item("FirstName").ToString
        lastNameTextbox.Text = storeInMe.Rows(0).Item("LastName").ToString
        studentIDTextBox.Text = storeInMe.Rows(0).Item("StudentID").ToString
        llimemberIDTextBox.Text=memberIDTextBox.Text
    End Sub
    Public Sub SetMyBooks(iGotBookID As String)
        Access.AddParam("@bk", iGotBookID)
        Dim query As String
        query="SELECT BookTitle, Author, YearPublished, Category, Borrowed, ISBN FROM BookDetails Where @bk=BookID"
        Access.ExecQuery(query)
        bookIDTextBox.Text = iGotBookID
        Dim storeInMe As DataTable = New DataTable()
        Access.DBDA.Fill(storeInMe)
        bookTitleTextBox.Text = storeInMe.Rows(0).Item("BookTitle").ToString
        authorTextBox.Text = storeInMe.Rows(0).Item("Author").ToString
        yearPubTextBox.Text = storeInMe.Rows(0).Item("YearPublished").ToString
        categoryTextBox.Text = storeInMe.Rows(0).Item("Category").ToString
        isbnTextBox.Text = storeInMe.Rows(0).Item("ISBN").ToString
        borrowedCheckBox.Checked = CBool(storeInMe.Rows(0).Item("Borrowed"))
        lliBookIDTextBox.Text = bookIDTextBox.Text
    End Sub
    Private Sub selectBookButton_Click(sender As Object, e As EventArgs) Handles selectBookButton.Click
        SelectBook.Show()
    End Sub

    Private Sub llidateReturnButton_Click(sender As Object, e As EventArgs) Handles llidateReturnButton.Click
        Dim DateDueBack As Date
        Dim DateReturnBack As Date
        Dim DaysOverDue As Short
        Dim FineRate As Decimal
        Dim Fine As Decimal
        If Not Date.TryParse(llidateReturnTextBox.Text, DateReturnBack) Then
            MessageBox.Show("Enter a valid date for Date Return")
            Exit Sub
        End If
        Access3.AddParam("@bkID", lliBookIDTextBox.Text)
        Dim findBookDue As String
        findBookDue = "Select * from [LibraryLoanInfo] where BookID=@bkID"
        Access3.ExecQuery(findBookDue)
        Dim storeinthis As DataTable = New DataTable()
        Access3.DBDA.Fill(storeinthis)
        DateDueBack = CDate(storeinthis.Rows(0).Item("DueDate"))
        DaysOverDue = CShort(DateDiff("d", DateDueBack, DateReturnBack))
        If NumericUpDown1.Value > 0 Then
            DaysBorrowed = CShort(NumericUpDown1.Value)
            FineRate = 1
        End If
        If DaysOverDue <= 0 Then
            DaysOverDue = 0
        End If
        If DaysOverDue > 0 Then
            Fine = FineRate * DaysOverDue
        Else
            Fine = 0
        End If
        llidateReturnResult.Text = DaysOverDue & " Days Overdue"
        llilateReturnFineTextBox.Text = "Fine of " & Format(Fine, "Currency") & " to pay"
        Access1.AddParam("@latereturn", llilateReturnFineTextBox.Text)
        Access1.AddParam("@bkID", lliBookIDTextBox.Text)
        Access.AddParam("@BookID", lliBookIDTextBox.Text)
        Dim updateLLi, updateBD As String
        updateBD = "UPDATE [BookDetails] SET [Borrowed]=False where BookID=@BookID"
        updateLLi = "UPDATE [LibraryLoanInfo] SET [Returned]=True, LateReturnFine=@latereturn WHERE @bkID=BookID"
        Access1.ExecQuery(updateLLi)
        Access.ExecQuery(updateBD)
        MessageBox.Show("Book has been returned")
    End Sub

    Private Sub lliborrowedButton_Click(sender As Object, e As EventArgs) Handles lliborrowedButton.Click
        Dim query3 As String
        query3="SELECT Borrowed FROM BookDetails WHERE @bkID=BookID"
        Access3.AddParam("@bkID", lliBookIDTextBox.Text)
        Access3.ExecQuery(query3)
        Dim storeinThis As DataTable= New DataTable
        Access3.DBDA.Fill(storeinThis)
        If String.IsNullOrEmpty(lliBookIDTextBox.Text) Then
            MessageBox.Show("Error: Select a Book")
        ElseIf CBool(storeinThis.Rows(0).Item("Borrowed")) Then
            MessageBox.Show("Error: Book is already Borrwed")
        ElseIf String.IsNullOrEmpty(llimemberIDTextBox.Text)
            MessageBox.Show("Error: Select a Member")
        Else
            Dim bkID As String
            Dim bookduedate As Date
            'days selection from numeric up/down

            DaysBorrowed=NumericUpDown1.Value  
            bkID = lliBookIDTextBox.Text
            Dim query1, query2 As String
            query1 = "Insert into [LibraryLoanInfo] ([BookID],[MemberID],[DateBorrow],[Duedate]) values (@BookID,@MemberID,@DateBorrow,@DueDate)"
            query2 = "UPDATE [BookDetails] SET [Borrowed]=True where BookID=@BookID"
            bookduedate = Today.AddDays(DaysBorrowed)
            llidueDateTextBox.Text = Format(bookduedate, "dddd dd MMMM yyyy")
            Access.AddParam("@BookID", lliBookIDTextBox.Text)
            Access.AddParam("@MemberID", llimemberIDTextBox.Text)
            Access.AddParam("@DateBorrow", llidateBorrowTextBox.Text)
            Access.AddParam("@DueDate", llidueDateTextBox.Text)
            Access1.AddParam("@BookID", lliBookIDTextBox.Text)
            Access.ExecQuery(query1)
            Access1.ExecQuery(query2)
            MessageBox.Show("Book Borrowed!")
        End If
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llidateBorrowTextBox.Text=regDate.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addbook.Show()
    End Sub

    Private Sub LibraryMember_Enter(sender As Object, e As EventArgs) Handles LibraryMember.Enter

    End Sub
End Class

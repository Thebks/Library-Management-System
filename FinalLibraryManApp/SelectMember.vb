Public Class SelectMember
    Private Access As New DBControl
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub SelectMember_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub
    Public Sub RefreshGrid()
        
        Access.ExecQuery("SELECT * FROM LibraryMember ORDER BY MemberID ")

  
        If NoErrors(True) = False Then Exit Sub

        
        dgvData.DataSource = Access.DBDT

        
        studentFirstNameCBx.Items.Clear()

       
        For Each R As DataRow In Access.DBDT.Rows
            studentFirstNameCBx.Items.Add(R("FirstName"))
        Next

        ' DISPLAY FIRS NAME FOUND
        If Access.RecordCount > 0 Then studentFirstNameCBx.SelectedIndex = 0
    End Sub
    Private Sub SearchMember(Name As String)
        
        Access.AddParam("@user", "%" & Name & "%")
        Access.ExecQuery("SELECT MemberID,Title, FirstName, LastName, StudentID " &
                         "FROM LibraryMember " &
                         "WHERE FirstName LIKE @user")

       
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRIDVIEW
        dgvData.DataSource = Access.DBDT
    End Sub
    Private Sub SelectUser(Username As String)
        ' QUERY USER
        Access.AddParam("@name", Username)
        Dim query As String
        query="SELECT TOP 1 MemberID, StudentID FROM LibraryMember Where @name=FirstName"
        Access.ExecQuery(query)

        
        If NoErrors(True) = False Then
            MessageBox.Show("Error")
        ElseIf Access.RecordCount < 1 Then
            MessageBox.Show(CType(Access.RecordCount, String))
        End If
        ' GET FIRST ROW FOUND
        Dim r As DataRow = Access.DBDT.Rows(0)

        
        memberIDTextBox.Text = r("MemberID").ToString
        studentIDTextBox.Text = r("StudentID").ToString
    End Sub
    'Private Sub SelectMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'LibdbDataSet.LibraryMember' table. You can move, or remove it, as needed.
    '    Me.LibraryMemberTableAdapter.Fill(Me.LibdbDataSet.LibraryMember)

   ' End Sub
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        SearchMember(searchTextBox.Text)
    End Sub
    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectButton.Click
        MainWindow.SetMymember(memberIDTextBox.Text)
        Me.Close()
    End Sub
    Private Sub dgvData_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        ' PREVENT OUT OF INDEX RANGE ERRORS
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        ' SELECT USERNAME FROM COLUMN 1 OF ROW CLICKED
        SelectUser(dgvData.Item(2, e.RowIndex).Value.ToString)
    End Sub

    Private Sub studentFirstNameCBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentFirstNameCBx.SelectedIndexChanged
        If Not String.IsNullOrEmpty(studentFirstNameCBx.Text) Then SelectUser(studentFirstNameCBx.Text)
    End Sub

End Class
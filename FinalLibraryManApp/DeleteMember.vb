Public Class DeleteMember
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
        ' RUN QUERY
        Access.ExecQuery("SELECT * FROM LibraryMember ORDER BY MemberID ")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT

        ' CLEAR COMBOBOX
        studentFirstNameCBx.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            studentFirstNameCBx.Items.Add(R("FirstName"))
        Next

        ' DISPLAY FIRS NAME FOUND
        If Access.RecordCount > 0 Then studentFirstNameCBx.SelectedIndex = 0
    End Sub
    Private Sub SearchMember(Name As String)
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@user", "%" & Name & "%")
        Access.ExecQuery("SELECT MemberID,Title, FirstName, LastName, StudentID " &
                         "FROM LibraryMember " &
                         "WHERE FirstName LIKE @user")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' FILL DATAGRIDVIEW
        dgvData.DataSource = Access.DBDT
    End Sub
    Private Sub SelectUser(Username As String)
        ' QUERY USER
        Dim query As String
        query= "SELECT TOP 1 MemberID, StudentID FROM LibraryMember Where @name=FirstName"
        Access.AddParam("@name", Username)
        Access.ExecQuery(query)

        ' REPORT & ABORT ON ERRORS OR NO RECORDS FOUND
        If NoErrors(True) = False Then
            MessageBox.Show("Error")
        ElseIf Access.RecordCount < 1 Then
            MessageBox.Show(CType(Access.RecordCount, String))
        End If
        ' GET FIRST ROW FOUND
        Dim r As DataRow = Access.DBDT.Rows(0)        

        
        memberIDTextBox.Text = r("MemberID").ToString
        studentIDTextBox.Text = r("StudentID").ToString

        deleteButton.Enabled = True
    End Sub
    Private Sub DeleteUser()
        ' CONFIRM DELETEION
        If MsgBox("Are you sure that you want to delete the selected member?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub
        Dim query As String
        query= "DELETE FROM LibraryMember WHERE @mid=MemberID"
        ' DELETE SELECTED USER
        Access.AddParam("@mid", memberIDTextBox.Text)
        Access.ExecQuery(query)

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' CLEANUP & REFRESH
        memberIDTextBox.Clear()
        studentIDTextBox.Clear()
        deleteButton.Enabled = False
        RefreshGrid()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        DeleteUser()
    End Sub
    Private Sub dgvData_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        ' PREVENT OUT OF INDEX RANGE ERRORS
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        ' SELECT USERNAME FROM COLUMN 1 OF ROW CLICKED
        SelectUser(dgvData.Item(2, e.RowIndex).Value.ToString)
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        SearchMember(searchTextBox.Text)
    End Sub
    Private Sub studentFirstNameCBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentFirstNameCBx.SelectedIndexChanged
        If Not String.IsNullOrEmpty(studentFirstNameCBx.Text) Then SelectUser(studentFirstNameCBx.Text)
    End Sub

    Private Sub DeleteMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
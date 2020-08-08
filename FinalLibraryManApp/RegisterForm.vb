Public Class RegisterForm
    Private Access As New DBControl
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancel1Button.Click
        Me.Close()
    End Sub
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Access.AddParam("@title", titleComboBox.Text.ToString())
        Access.AddParam("@firstname", firstNameTextBox.Text)
        Access.AddParam("@lastname", lastNameTextBox.Text)
        Access.AddParam("@studentid", studentIDTextBox.Text)
        Dim query As String
        query="INSERT INTO [LibraryMember](Title, FirstName,LastName,StudentID) values (@title,@firstname,@lastname,@studentid)"
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        MessageBox.Show("Member Added Successfully!")
        Me.Close()
    End Sub
    Private Sub studentIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studentIDTextBox.KeyPress
         If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub titleComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles titleComboBox.SelectedIndexChanged

    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
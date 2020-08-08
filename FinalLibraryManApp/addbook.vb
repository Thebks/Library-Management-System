Public Class addbook
   Private Access As New DBControl
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       ' Access.AddParam("@BookID", txtbkid.Text.ToString())
        Access.AddParam("@ISBN", txtisbn.Text)
        Access.AddParam("@BookTitle", txtbktitle.Text)
        Access.AddParam("@Author", txtauthor.Text)
        Access.AddParam("@YearPublished", txtyearpublished.Text)
        Access.AddParam("@Category", txtcategory.Text)
        Dim query As String
        query="INSERT INTO [BookDetails]( ISBN, BookTitle,Author,YearPublished,Category) values (@ISBN,@BookTitle,@Author,@YearPublished,@Category)"
        Access.ExecQuery(query)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        MessageBox.Show("Book Added Successfully!")

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtauthor.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub addbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
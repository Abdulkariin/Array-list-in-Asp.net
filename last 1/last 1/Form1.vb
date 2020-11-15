Public Class Form1
    Dim product_names As New List(Of String)()
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub At_Click(sender As Object, e As EventArgs) Handles Noofproducts.Click

    End Sub
    Private Sub Inser_Click(sender As Object, e As EventArgs) Handles Inser.Click
        product_names.Add("Hello world")
        viewproduct()
    End Sub

    Private Sub Names_Click(sender As Object, e As EventArgs) Handles Names.Click
        product_names.Add(TextBox1.Text)

        viewproduct()
        TextBox1.Text = String.Empty
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Console.WriteLine(product_names.ToList().FindIndex(Function(x) x = "Hello world"))
    End Sub

    Sub viewproduct()
        listBox1.Items.clear()

        For Each product As String In product_names
            listBox1.items.add(product)
        Next
        Noofproducts.Text = product_names.Count()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

  
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Removed.Click
        product_names.Remove(ListBox1.SelectedItem)
        viewproduct()
    End Sub

    Private Sub RemovAt_Click(sender As Object, e As EventArgs) Handles RemovAt.Click
        ListBox1.Items.RemoveAt(0)
    End Sub




End Class
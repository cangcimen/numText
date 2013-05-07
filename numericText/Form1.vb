Public Class Form1
    Dim i As Long

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            i = CInt(TextBox1.Text)
            TextBox1.Text = Format(i, "N0")
            TextBox1.Select(TextBox1.Text.Length, 0)
        Catch ex As Exception
            TextBox1.Text = "0"
        End Try
    End Sub
End Class



Public Class register
    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click


        If tbUsername.Text.Length > 0 And tbPassword.Text.Length > 0 Then
            If String.Compare(tbPassword.Text, tbConfirm.Text) = 0 Then
                Login.Users.AddUsersDatabase(tbUsername.Text, tbPassword.Text)
                Me.Close()
            Else
                MessageBox.Show("Different Password!")
            End If

        Else
            MessageBox.Show("Insert Data!")
        End If
    End Sub

    Private Sub register_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
    End Sub
End Class
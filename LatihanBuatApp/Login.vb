Public Class Login
    Public Shared Perpustakaan = New FormPerpustakaan
    Public Shared Users = New Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tbPassword.UseSystemPasswordChar = True

        If showPassCheck.Checked Then
            tbPassword.UseSystemPasswordChar = False
        End If

        Perpustakaan = New FormPerpustakaan
        Users = New Users
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim plainUsername As String = tbUsername.Text
        Dim plainPassword As String = tbPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.GSusername = data_user(1)
            Me.Hide()
            FormPerpustakaan.Show()
        Else
            MessageBox.Show("Wrong Username or Password")
        End If
    End Sub

    Private Sub showPassBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub showPassCheck_CheckedChanged(sender As Object, e As EventArgs) Handles showPassCheck.CheckedChanged
        tbPassword.UseSystemPasswordChar = Not showPassCheck.Checked
    End Sub

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        Me.Hide()
        register.Show()
    End Sub
End Class
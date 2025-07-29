Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Simple login validation
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' Check if fields are empty
        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        ' Simple hardcoded credentials for demo (in real app, use database)
        If username = "admin" AndAlso password = "password123" Then
            MessageBox.Show("Login successful! Welcome, " & username & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Here you would typically open the main application form
            ' For this demo, we'll just clear the fields
            txtUsername.Clear()
            txtPassword.Clear()
        ElseIf username = "user" AndAlso password = "user123" Then
            MessageBox.Show("Login successful! Welcome, " & username & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Clear()
            txtPassword.Clear()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Clear the form fields
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application
        Application.Exit()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set focus to username field when form loads
        txtUsername.Focus()
        
        ' Set some form properties
        Me.Text = "Login - Demo Application"
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        ' Allow login when Enter is pressed in password field
        If e.KeyChar = Chr(13) Then ' Enter key
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        ' Move to password field when Enter is pressed in username field
        If e.KeyChar = Chr(13) Then ' Enter key
            txtPassword.Focus()
        End If
    End Sub

    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        MessageBox.Show("Demo credentials:" & vbCrLf & vbCrLf & 
                       "Username: admin" & vbCrLf & "Password: password123" & vbCrLf & vbCrLf &
                       "Username: user" & vbCrLf & "Password: user123", 
                       "Demo Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
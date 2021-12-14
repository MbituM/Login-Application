Public Class frmlogin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "admin" And txtpassword.Text = "admin" Then
            MsgBox("Login Successful!", MsgBoxStyle.OkOnly, "Log in Form")
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class

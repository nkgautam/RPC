Public Class Password

    Private Sub BtnOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Dim todaysDay As String = DateTime.Now.Day
        Dim todaysMonth As String = DateTime.Now.Month
        Dim revDay As String = todaysDay.ToString()
        revDay = revDay.Substring(1, 1) + revDay.Substring(0, 1)
        Dim i As Integer = Asc("A")
        Dim c As Char = Chr(i + todaysMonth - 1)
        Dim revStr As String = revDay + c

        If (TxtPassword.Text.Trim().Equals(revStr)) Then
            Dim import As New Import
            import.Visible = True
            Me.Dispose(True)
        Else
            MessageBox.Show("Enter correct password")
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Dispose(True)

    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose(True)
    End Sub

   
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Dispose(True)
    End Sub
End Class
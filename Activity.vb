Public Class Activity
    Private Sub cmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        Me.Hide()
        CustActivity1.Show()
    End Sub
    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdHomepage.Click
        Me.Hide()
        FormMenu.Show()
    End Sub
    Private Sub cmdContractor_Click(sender As Object, e As EventArgs) Handles cmdContractor.Click
        Me.Hide()
        ContActivity.Show()
    End Sub
End Class
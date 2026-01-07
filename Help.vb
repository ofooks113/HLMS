Public Class Help
    Private Sub cmdActivity_Click(sender As Object, e As EventArgs) Handles cmdActivity.Click
        'The description of the message
        Dim msg = "This function will allow you to access or print an activity summary within a date range."
        'The title of the message
        Dim title = "Activity"
        'The style and icon of the message
        Dim style = MsgBoxStyle.Information
        Dim response = MsgBox(msg, style, title)
    End Sub
    Private Sub cmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        'Description of the message
        Dim msg = "This function will allow you to create, amend or remove a customer detail or search for a detail.
This function is connected to the Access Database. To CREATE a record, fill in statistics of the customer (e.g. name,
contact details and notes). You can also AMEND any record detail or REMOVE a record from the database.
To SEARCH a detail, enter the CUSTOMERID of the customer (the record MUST be in the database when you search). 
You can also access the customer FEEDBACK and BOOKINGs."
        Dim title = "Customer Details"
        Dim style = MsgBoxStyle.Information
        Dim response = MsgBox(msg, style, title)
    End Sub
    Private Sub cmdContractor_Click(sender As Object, e As EventArgs) Handles cmdContractor.Click
        Dim msg = "This function will allow you to create, amend or remove a contractor detail or search for a detail.
This function is connected to the Access Database. To CREATE a record, fill in statistics of the contractor (e.g. name,
contact details and occupation etc.). You can also AMEND any record detail or REMOVE a record from the database.
To SEARCH a detail, enter the CONTRACTORID of the contractor (the record MUST be in the database when you search).
You can also access the contractor's JOB."
        Dim title = "Contractor Details"
        Dim style = MsgBoxStyle.Information
        Dim response = MsgBox(msg, style, title)
    End Sub
    Private Sub cmdItem_Click(sender As Object, e As EventArgs) Handles cmdItem.Click
        Dim msg = "This function will allow you to enter, amend or remove an item detail on the property or search
This function is connected to the Access Database. To CREATE a record, fill in statistics of the item on the property (e.g. name,
description, serviceability, quantity etc.). You can also AMEND any record detail or REMOVE a record from the database.
To SEARCH a detail, enter the ITEMID of the property's item (the record MUST be in the database when you search)."
        Dim title = "Inventory Details"
        Dim style = MsgBoxStyle.Information
        Dim response = MsgBox(msg, style, title)
    End Sub

    Private Sub cmdTariff_Click(sender As Object, e As EventArgs) Handles cmdTariff.Click
        Dim msg = "This function will allow you to enter a date range (e.g. 01/11/2021 - 12/11/2021)
and calculate the income and expenditure made during that period.
This function is connected to the Access Database. You can also query 2 date ranges
and compare the income and expenditure between the 2 date ranges."
        Dim title = "Weekly Tariff"
        Dim style = MsgBoxStyle.Information
        Dim response = MsgBox(msg, style, title)
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class
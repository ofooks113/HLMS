Imports System.Data
Imports System.Data.OleDb

Public Class CustFinancials
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub SetUpGridView(lf, coln)
        ' Create a connection to Northwind.mdb
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\white\OneDrive\Documents_Licences\Octavius\Computing\Project\Booking\Booking\HLMS1.accdb"
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString

        ' Create a data adapter with the required INNER JOIN SQL command
        Dim sqlComd As String = "SELECT CustomerTable.CustomerID, CustomerTable.Firstname, CustomerTable.Surname, BookingTable.RentDue FROM CustomerTable 
                                INNER JOIN BookingTable ON CustomerTable.CustomerID=BookingTable.CustomerID WHERE " + coln + " LIKE '" + lf + "%'"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlComd, myConnection)

        ' Set up the data table with the columns we want to see
        Using dt As New DataTable()
            da.Fill(dt)

            ' Clear the dtgCustomerFinancial Data Source
            dtgCustomerFinancial.DataSource = Nothing

            'Set AutoGenerateColumns off - we will generate our own
            dtgCustomerFinancial.AutoGenerateColumns = False

            'Set Columns Count - the number of columns we want to display
            dtgCustomerFinancial.ColumnCount = 4

            'Add the Columns we want
            dtgCustomerFinancial.Columns(0).Name = "CustomerId" 'Name given to 1st column in the data view
            dtgCustomerFinancial.Columns(0).HeaderText = "Customer ID" 'Header text to be displayed for 1st column
            dtgCustomerFinancial.Columns(0).DataPropertyName = "CustomerID" 'Name of the data source column for 1st column
            dtgCustomerFinancial.Columns.Item("CustomerID").Width = 90 'Width in pixels of displayed column

            dtgCustomerFinancial.Columns(1).Name = "Firstname"
            dtgCustomerFinancial.Columns(1).HeaderText = "First Name"
            dtgCustomerFinancial.Columns(1).DataPropertyName = "FirstName"
            dtgCustomerFinancial.Columns.Item("FirstName").Width = 180

            dtgCustomerFinancial.Columns(2).Name = "Surname"
            dtgCustomerFinancial.Columns(2).HeaderText = "Surname"
            dtgCustomerFinancial.Columns(2).DataPropertyName = "Surname"
            dtgCustomerFinancial.Columns.Item("Surname").Width = 80

            dtgCustomerFinancial.Columns(3).Name = "RentDue"
            dtgCustomerFinancial.Columns(3).HeaderText = "RentDue"
            dtgCustomerFinancial.Columns(3).DataPropertyName = "RentDue"
            dtgCustomerFinancial.Columns.Item("RentDue").Width = 100

            dtgCustomerFinancial.DataSource = dt
        End Using
    End Sub

    Private Sub cmdFinancial_Click(sender As Object, e As EventArgs) Handles cmdFinancial.Click
        Me.Hide()
        Financial.Show()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        ' Get the text from the TextBox
        Dim lookfor As String
        lookfor = txtSearch.Text
        ' Get the search column from the Radio Buttons
        Dim col As String
        If rbCustomerID.Checked = True Then
            col = "CustomerTable.CustomerID"
        ElseIf rbFirstName.Checked = True Then
            col = "CustomerTable.Firstname"
        ElseIf rbSurname.Checked = True Then
            col = "CustomerTable.Surname"
        ElseIf rbRentDue.Checked = True Then
            col = "BookingTable.RentDue"
        End If
        SetUpGridView(lookfor, col)
    End Sub
End Class

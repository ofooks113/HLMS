Imports System.Data
Imports System.Data.OleDb
Public Class CustActivity1
        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
        End Sub
        Private Sub SetUpGridView(lf, coln)

            ' Create a connection to HLMS1.accdb
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HLMS1.accdb"
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            ' Create a data adapter with the required INNER JOIN SQL command
            Dim sqlComd As String = "SELECT CustomerTable.CustomerID, CustomerTable.FirstName, CustomerTable.Surname, BookingTable.StartDate, BookingTable.EndDate 
                                FROM CustomerTable INNER JOIN BookingTable ON CustomerTable.CustomerID=BookingTable.CustomerID WHERE " + coln + " LIKE '" + lf + "%'"
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlComd, myConnection)

            ' Set up the data table with the columns we want to see
            Using dt As New DataTable()
                da.Fill(dt)

            ' Clear the CustActivity1DataGridView Data Source
            CustActivity1DataGridView.DataSource = Nothing

            'Set AutoGenerateColumns off - we will generate our own
            CustActivity1DataGridView.AutoGenerateColumns = False

            'Set Columns Count - the number of columns we want to display
            CustActivity1DataGridView.ColumnCount = 5

            'Add the Columns we want
            CustActivity1DataGridView.Columns(0).Name = "CustomerId" 'Name given to 1st column in the data view
            CustActivity1DataGridView.Columns(0).HeaderText = "Customer ID" 'Header text to be displayed for 1st column
            CustActivity1DataGridView.Columns(0).DataPropertyName = "CustomerID" 'Name of the data source column for 1st column
            CustActivity1DataGridView.Columns.Item("CustomerID").Width = 80 'Width in pixels of displayed column

            CustActivity1DataGridView.Columns(1).Name = "FirstName"
            CustActivity1DataGridView.Columns(1).HeaderText = "First Name"
            CustActivity1DataGridView.Columns(1).DataPropertyName = "FirstName"
            CustActivity1DataGridView.Columns.Item("FirstName").Width = 90

            CustActivity1DataGridView.Columns(2).Name = "Surname"
            CustActivity1DataGridView.Columns(2).HeaderText = "Surname"
            CustActivity1DataGridView.Columns(2).DataPropertyName = "Surname"
            CustActivity1DataGridView.Columns.Item("Surname").Width = 90

            CustActivity1DataGridView.Columns(3).Name = "StartDate"
            CustActivity1DataGridView.Columns(3).HeaderText = "Start Date"
            CustActivity1DataGridView.Columns(3).DataPropertyName = "StartDate"
            CustActivity1DataGridView.Columns.Item("StartDate").Width = 100

            CustActivity1DataGridView.Columns(4).Name = "EndDate"
            CustActivity1DataGridView.Columns(4).HeaderText = "End Date"
            CustActivity1DataGridView.Columns(4).DataPropertyName = "EndDate"
            CustActivity1DataGridView.Columns.Item("EndDate").Width = 100

            CustActivity1DataGridView.DataSource = dt
        End Using
        End Sub
        Private Sub cmdActivityMenu_Click(sender As Object, e As EventArgs) Handles cmdActivityMenu.Click
            Me.Hide()
            Activity.Show()
        End Sub

        Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
            ' Get the text from the TextBox
            Dim lookfor As String
            lookfor = txtSearch.Text
            ' Get the search column from the Radio Buttons
            Dim col As String
            If rbID.Checked = True Then
                col = "CustomerTable.CustomerID"
            ElseIf rbfName.Checked = True Then
                col = "CustomerTable.Firstname"
            ElseIf rbsName.Checked = True Then
                col = "CustomerTable.Surname"
            ElseIf rbStartDate.Checked = True Then
                col = "BookingTable.StartDate"
            ElseIf rbEndDate.Checked = True Then
                col = "BookingTable.EndDate"
            End If
            SetUpGridView(lookfor, col)
        End Sub
    End Class

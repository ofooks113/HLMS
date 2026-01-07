Imports System.Data
Imports System.Data.OleDb
Public Class ContActivity
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
        Dim sqlComd As String = "SELECT ContractorTable.ContractorID, ContractorTable.FirstName, ContractorTable.Surname, ContractorJobTable.StartDate, ContractorJobTable.EndDate FROM ContractorTable 
                                INNER JOIN ContractorJobTable ON ContractorTable.ContractorID=ContractorJobTable.ContractorID WHERE " + coln + " LIKE '" + lf + "%'"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlComd, myConnection)

        ' Set up the data table with the columns we want to see
        Using dt As New DataTable()
            da.Fill(dt)

            ' Clear the dtgCustomerFinancial Data Source
            ContActivityDataGridView1.DataSource = Nothing

            'Set AutoGenerateColumns off - we will generate our own
            ContActivityDataGridView1.AutoGenerateColumns = False

            'Set Columns Count - the number of columns we want to display
            ContActivityDataGridView1.ColumnCount = 5

            'Add the Columns we want
            ContActivityDataGridView1.Columns(0).Name = "ContractorID" 'Name given to 1st column in the data view
            ContActivityDataGridView1.Columns(0).HeaderText = "Contractor ID" 'Header text to be displayed for 1st column
            ContActivityDataGridView1.Columns(0).DataPropertyName = "ContractorID" 'Name of the data source column for 1st column
            ContActivityDataGridView1.Columns.Item("ContractorID").Width = 80 'Width in pixels of displayed column

            ContActivityDataGridView1.Columns(1).Name = "FirstName"
            ContActivityDataGridView1.Columns(1).HeaderText = "First Name"
            ContActivityDataGridView1.Columns(1).DataPropertyName = "FirstName"
            ContActivityDataGridView1.Columns.Item("FirstName").Width = 90

            ContActivityDataGridView1.Columns(2).Name = "Surname"
            ContActivityDataGridView1.Columns(2).HeaderText = "Surname"
            ContActivityDataGridView1.Columns(2).DataPropertyName = "Surname"
            ContActivityDataGridView1.Columns.Item("Surname").Width = 90

            ContActivityDataGridView1.Columns(3).Name = "StartDate"
            ContActivityDataGridView1.Columns(3).HeaderText = "Start Date"
            ContActivityDataGridView1.Columns(3).DataPropertyName = "StartDate"
            ContActivityDataGridView1.Columns.Item("StartDate").Width = 100

            ContActivityDataGridView1.Columns(4).Name = "EndDate"
            ContActivityDataGridView1.Columns(4).HeaderText = "End Date"
            ContActivityDataGridView1.Columns(4).DataPropertyName = "EndDate"
            ContActivityDataGridView1.Columns.Item("EndDate").Width = 100

            ContActivityDataGridView1.DataSource = dt
        End Using
    End Sub

    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdHomepage.Click
        Me.Hide()
        Activity.Show()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        ' Get the text from the TextBox
        Dim lookfor As String
        lookfor = txtSearch.Text
        ' Get the search column from the Radio Buttons
        Dim col As String
        If rbID.Checked = True Then
            col = "ContractorTable.ContractorID"
        ElseIf rbfName.Checked = True Then
            col = "ContractorTable.Firstname"
        ElseIf rbsName.Checked = True Then
            col = "ContractorTable.Surname"
        ElseIf rbStartDate.Checked = True Then
            col = "ContractorJobTable.StartDate"
        ElseIf rbEndDate.Checked = True Then
            col = "ContractorJobTable.EndDate"
        End If
        SetUpGridView(lookfor, col)
    End Sub
End Class
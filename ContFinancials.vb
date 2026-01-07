Imports System.Data
Imports System.Data.OleDb
Public Class ContFinancials
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub SetUpGridView(lf, coln)
        ' Create a connection to Northwind.mdb
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\white\OneDrive\Documents_Licences\Octavius\Computing\Project\Booking\Booking\HLMS1.accdb"
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString

        ' Create a data adapter with the required INNER JOIN SQL command
        Dim sqlComd As String = "SELECT ContractorTable.ContractorID, ContractorTable.Firstname, ContractorTable.Surname, ContractorJobTable.FeeDue FROM ContractorTable 
                                INNER JOIN ContractorJobTable ON ContractorTable.ContractorID=ContractorJobTable.ContractorID WHERE " + coln + " LIKE '" + lf + "%'"
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlComd, myConnection)

        ' Set up the data table with the columns we want to see
        Using dt As New DataTable()
            da.Fill(dt)

            ' Clear the dtgContractorFinancial Data Source
            dtgContractorFinancial.DataSource = Nothing

            'Set AutoGenerateColumns off - we will generate our own
            dtgContractorFinancial.AutoGenerateColumns = False

            'Set Columns Count - the number of columns we want to display
            dtgContractorFinancial.ColumnCount = 4

            'Add the Columns we want
            dtgContractorFinancial.Columns(0).Name = "ContractorID" 'Name given to 1st column in the data view
            dtgContractorFinancial.Columns(0).HeaderText = "Contractor ID" 'Header text to be displayed for 1st column
            dtgContractorFinancial.Columns(0).DataPropertyName = "ContractorID" 'Name of the data source column for 1st column
            dtgContractorFinancial.Columns.Item("ContractorID").Width = 90 'Width in pixels of displayed column

            dtgContractorFinancial.Columns(1).Name = "Firstname"
            dtgContractorFinancial.Columns(1).HeaderText = "First Name"
            dtgContractorFinancial.Columns(1).DataPropertyName = "FirstName"
            dtgContractorFinancial.Columns.Item("FirstName").Width = 180

            dtgContractorFinancial.Columns(2).Name = "Surname"
            dtgContractorFinancial.Columns(2).HeaderText = "Surname"
            dtgContractorFinancial.Columns(2).DataPropertyName = "Surname"
            dtgContractorFinancial.Columns.Item("Surname").Width = 80

            dtgContractorFinancial.Columns(3).Name = "FeeDue"
            dtgContractorFinancial.Columns(3).HeaderText = "FeeDue"
            dtgContractorFinancial.Columns(3).DataPropertyName = "FeeDue"
            dtgContractorFinancial.Columns.Item("FeeDue").Width = 100

            dtgContractorFinancial.DataSource = dt
        End Using
    End Sub

    Private Sub cmdFinancials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinancials.Click
        Me.Hide()
        Financial.Show()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        ' Get the text from the TextBox
        Dim lookfor As String
        lookfor = txtSearch.Text
        ' Get the search column from the Radio Buttons
        Dim col As String
        If rbContractorID.Checked = True Then
            col = "ContractorTable.ContractorID"
        ElseIf rbFirstname.Checked = True Then
            col = "ContractorTable.Firstname"
        ElseIf rbSurname.Checked = True Then
            col = "ContractorTable.Surname"
        ElseIf rbFeeDue.Checked = True Then
            col = "ContractorJobTable.FeeDue"
        End If
        SetUpGridView(lookfor, col)
    End Sub
End Class
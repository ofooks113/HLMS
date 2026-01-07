Imports System.IO
Imports System.Data.OleDb
Public Class WeeklyTariff
    Dim dbProvider As String
    Dim dbSource As String
    Dim sql As String
    Dim con As New OleDb.OleDbConnection

    Dim dbPathAndFilename As String = "C:\Users\white\OneDrive\Documents_Licences\Octavius\Computing\Project\Booking\Booking\HLMS1.accdb"
    Private Sub WeeklyTariff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source="

        LoadData()
    End Sub
    Sub LoadData()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter

        con.ConnectionString = dbProvider & dbSource & dbPathAndFilename

        con.Open()
        sql = "SELECT SeasonTable.ID, SeasonTable.StartDate, SeasonTable.EndDate, SeasonTable.SeasonRateID, SeasonRateTable.Rate 
                FROM SeasonTable INNER JOIN SeasonRateTable ON SeasonTable.ID=SeasonRateTable.ID"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "SeasonTable")
        con.Close()

        SeasonTableDataGridView.DataSource = ds.Tables("SeasonTable")
    End Sub
    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Try
            Dim sqlquery As New OleDb.OleDbCommand

            con.ConnectionString = dbProvider & dbSource & dbPathAndFilename
            sqlquery.Connection = con
            con.Open()

            sqlquery.CommandText = "INSERT INTO SeasonTable ([StartDate], [EndDate], [SeasonRateID])
                                    Values(@StartDate, @EndDate, @SeasonRateID)"

            sqlquery.Parameters.AddWithValue("@StartDate", selectStartDate.Value())
            sqlquery.Parameters.AddWithValue("@EndDate", selectEndDate.Value())
            sqlquery.Parameters.AddWithValue("@SeasonRateID", txtSeasonRateID.Text())

            sqlquery.ExecuteNonQuery()
            con.Close()

            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim iRowIndex As Integer

        'get selected row index
        For i As Integer = 0 To Me.SeasonTableDataGridView.SelectedCells.Count - 1
            iRowIndex = Me.SeasonTableDataGridView.SelectedCells.Item(i).RowIndex
        Next

        'get row ID from selected row index
        Dim row As New DataGridViewRow()
        row = SeasonTableDataGridView.Rows(iRowIndex)
        Dim recordToUpdate As Integer
        recordToUpdate = row.Cells(0).Value

        MsgBox("Record ID: " & recordToUpdate)

        Try
            'compose SQL UPDATE statement
            Dim sql = "UPDATE SeasonTable SET StartDate = ?, EndDate = ?, SeasonRateID = ? WHERE ID = ?"

            'bind data to DB parameters
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@StartDate", selectStartDate.Value())
                cmd.Parameters.AddWithValue("@EndDate", selectEndDate.Value())
                cmd.Parameters.AddWithValue("@SeasonRateID", txtSeasonRateID.Text())
                cmd.Parameters.AddWithValue("@ID", recordToUpdate)

                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            LoadData()

            ' display message if db update can't happen for any reason
        Catch ex As Exception
            MsgBox("Error! Could not update record in DB!")
        End Try
    End Sub
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim iRowIndex As Integer

        'get selected row index
        For i As Integer = 0 To Me.SeasonTableDataGridView.SelectedCells.Count - 1
            iRowIndex = Me.SeasonTableDataGridView.SelectedCells.Item(i).RowIndex
        Next

        'get row ID from selected row index
        Dim row As New DataGridViewRow()
        row = SeasonTableDataGridView.Rows(iRowIndex)
        Dim recordToDelete As Integer
        recordToDelete = row.Cells(0).Value

        MsgBox("Record ID: " & recordToDelete)

        Try
            'compose SQL DELETE statement
            Dim cmdText As String = "DELETE * FROM SeasonTable WHERE ID = ?"

            Using cmd = New OleDbCommand(cmdText, con)
                con.Open()
                cmd.Parameters.AddWithValue("@ID", recordToDelete)
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            LoadData()

            ' display message if db update can't happen for any reason
        Catch ex As Exception
            MsgBox("Error! Could not delete record from DB! " & ex.Message)
        End Try
    End Sub

    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdHomepage.Click
        Me.Hide()
        Rate.Show()
    End Sub

    Private Sub cmdRate_Click(sender As Object, e As EventArgs) Handles cmdRate.Click
        Me.Hide()
        Rate.Show()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Try
            sql = "select * from SeasonTable where StartDate ='" & txtSearch.Text & "' or EndDate ='" & txtSearch.Text & "' or ID = '" &
                txtSearch.Text & "' or SeasonRateID ='" & txtSearch.Text & "'"
            Dim ds As New DataSet
            Dim da As OleDb.OleDbDataAdapter
            'Create connection to database
            con.ConnectionString = dbProvider & dbSource & dbPathAndFilename
            'Open database
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            'Name given to the dataset retrieved from the DB
            da.Fill(ds, "SeasonTable")
            con.Close()
            'Populate DataGridView
            SeasonTableDataGridView.DataSource = ds.Tables("SeasonTable")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
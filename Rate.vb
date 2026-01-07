Imports System.IO
Imports System.Data.OleDb
Public Class Rate
    Dim dbProvider As String
    Dim dbSource As String
    Dim sql As String
    Dim con As New OleDb.OleDbConnection

    Private Sub Rate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()
    End Sub
    Sub LoadData()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter

        con.ConnectionString = DB_PATH

        con.Open()
        sql = "SELECT ID, SeasonRateType, Rate FROM SeasonRateTable"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "SeasonRateTable")
        con.Close()

        SeasonRateTableDataGridView.DataSource = ds.Tables("SeasonRateTable")
    End Sub
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
        Try
            Dim sqlquery As New OleDb.OleDbCommand

            con.ConnectionString = DB_PATH
            sqlquery.Connection = con
            con.Open()

            'Insert SQL statement
            sqlquery.CommandText = "INSERT INTO SeasonRateTable([SeasonRateType], [Rate])
                                    Values(@SeasonRateType, @Rate)"

            sqlquery.Parameters.AddWithValue("@SeasonRateType", txtSeasonRateType.Text)
            sqlquery.Parameters.AddWithValue("@Rate", Val(txtRate.Text()))

            sqlquery.ExecuteNonQuery()
            con.Close()

            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim iRowIndex As Integer

        'get selected row index
        For i As Integer = 0 To Me.SeasonRateTableDataGridView.SelectedCells.Count - 1
            iRowIndex = Me.SeasonRateTableDataGridView.SelectedCells.Item(i).RowIndex
        Next

        'get row ID from selected row index
        Dim row As New DataGridViewRow()
        row = SeasonRateTableDataGridView.Rows(iRowIndex)
        Dim recordToDelete As Integer
        recordToDelete = row.Cells(0).Value

        MsgBox("Record ID: " & recordToDelete)

        Try
            'compose SQL DELETE statement
            Dim cmdText As String = "DELETE * FROM SeasonRateTable WHERE ID = ?"

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

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim iRowIndex As Integer

        'get selected row index
        For i As Integer = 0 To Me.SeasonRateTableDataGridView.SelectedCells.Count - 1
            iRowIndex = Me.SeasonRateTableDataGridView.SelectedCells.Item(i).RowIndex
        Next

        'get row ID from selected row index
        Dim row As New DataGridViewRow()
        row = SeasonRateTableDataGridView.Rows(iRowIndex)
        Dim recordToUpdate As Integer
        recordToUpdate = row.Cells(0).Value

        MsgBox("Record ID: " & recordToUpdate)

        Try
            'compose SQL UPDATE statement
            Dim sql = "UPDATE SeasonRateTable SET SeasonRateType = ?, Rate = ? WHERE ID = ?"

            'bind data to DB parameters
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@SeasonRateType", txtSeasonRateType.Text())
                cmd.Parameters.AddWithValue("@Rate", Val(txtRate.Text()))
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
    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdHomepage.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub cmdTariff_Click(sender As Object, e As EventArgs) Handles cmdTariff.Click
        Me.Hide()
        WeeklyTariff.Show()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Try
            sql = "select * from SeasonRateTable where Rate ='" & txtSearch.Text & "' or ID ='" & txtSearch.Text & "' or SeasonRateType = '" & txtSearch.Text & "'"
            Dim ds As New DataSet
            Dim da As OleDb.OleDbDataAdapter
            'Create connection to database
            con.ConnectionString = DB_PATH
            'Open database
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            'Name given to the dataset retrieved from the DB
            da.Fill(ds, "SeasonRateTable")
            con.Close()
            'Populate DataGridView
            SeasonRateTableDataGridView.DataSource = ds.Tables("SeasonRateTable")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
Imports System.IO
Imports System.Data.OleDb
Public Class Feedback
    Dim dbProvider As String
    Dim dbSource As String
    Dim sql As String
    Dim con As New OleDb.OleDbConnection

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'HLMS1DataSet.FeedbackTable' table. You can move, or remove it, as needed.
        Me.FeedbackTableTableAdapter.Fill(Me.HLMS1DataSet.FeedbackTable)



        LoadData()

    End Sub
    Sub LoadData()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter

        con.ConnectionString = DB_PATH
        con.Open()
        sql = "Select * From FeedbackTable;"
        da = New OleDb.OleDbDataAdapter(sql, con)
        'Name of table
        da.Fill(ds, "FeedbackTable")

        con.Close()

        FeedbackTableDataGridView.DataSource = ds.Tables("FeedbackTable")
    End Sub
    Private Sub cmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        Dim r As MsgBoxResult
        r = MsgBox("Are you sure you want to go back to the customer form?", MsgBoxStyle.YesNo, "Feedback")

        If r = MsgBoxResult.Yes Then
            Me.Hide()
            Customer.Show()
        End If
    End Sub
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim iRowIndex As Integer

        'get selected row index
        For i As Integer = 0 To Me.FeedbackTableDataGridView.SelectedCells.Count - 1
            iRowIndex = Me.FeedbackTableDataGridView.SelectedCells.Item(i).RowIndex
        Next

        'get row ID from selected row index
        Dim row As New DataGridViewRow()
        row = FeedbackTableDataGridView.Rows(iRowIndex)
        Dim recordToDelete As Integer
        recordToDelete = row.Cells(0).Value

        Dim r As MsgBoxResult
        r = MsgBox("Are you sure you want to delete Record ID: " & recordToDelete & "?", MessageBoxButtons.YesNo)
        If MsgBoxResult.Yes Then
            MsgBox("Are you sure")
        Else
            MsgBox("Operation Cancelled")
        End If
        Try
            'compose SQL DELETE statement
            Dim cmdText As String = "DELETE * FROM FeedbackTable WHERE FeedbackID = ?"

            Using cmd = New OleDbCommand(cmdText, con)
                con.Open()
                cmd.Parameters.AddWithValue("@FeedbackID", recordToDelete)
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
        For i As Integer = 0 To Me.FeedbackTableDataGridView.SelectedCells.Count - 1
            iRowIndex = Me.FeedbackTableDataGridView.SelectedCells.Item(i).RowIndex
        Next

        'get row ID from selected row index
        Dim row As New DataGridViewRow()
        row = FeedbackTableDataGridView.Rows(iRowIndex)
        Dim recordToUpdate As Integer
        recordToUpdate = row.Cells(0).Value

        Dim r As MsgBoxResult
        r = MsgBox("Are you sure you want to update values to Record ID: " & recordToUpdate & "?", MessageBoxButtons.YesNo)
        If MsgBoxResult.No Then
            MsgBox("Operation Cancelled")
        End If

        Try
            'compose SQL UPDATE statement
            Dim sql = "UPDATE FeedbackTable SET Comment = ?, Rating = ? WHERE FeedbackID = ?"

            'bind data to DB parameters
            Using cmd = New OleDb.OleDbCommand(sql, con)
                con.Open()
                cmd.Parameters.AddWithValue("@Comment", txtComment.Text())
                cmd.Parameters.AddWithValue("@Rating", txtRating.Text())
                cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text())
                cmd.Parameters.AddWithValue("@FeedbackID", recordToUpdate)

                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            LoadData()

            ' display message if db update can't happen for any reason
        Catch ex As Exception
            MsgBox("Error! Could not update record in DB!")
        End Try

    End Sub
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
        Try
            Dim sqlquery As New OleDb.OleDbCommand

            con.ConnectionString = DB_PATH
            sqlquery.Connection = con
            con.Open()

            sqlquery.CommandText = "INSERT INTO FeedbackTable([Comment], [Rating], [CustomerID]) VALUES (@Comment, @Rating, @CustomerID);"
            sqlquery.Parameters.AddWithValue("@Comment", txtComment.Text())
            sqlquery.Parameters.AddWithValue("@Rating", txtRating.Text())
            sqlquery.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text())
            sqlquery.ExecuteNonQuery()
            con.Close()

            LoadData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Try
            sql = "select * from FeedbackTable where Comment ='" & txtSearch.Text & "' or Rating ='" & txtSearch.Text & "' or CustomerID = '" & txtSearch.Text & "'"
            Dim ds As New DataSet
            Dim da As OleDb.OleDbDataAdapter
            'Create connection to database
            con.ConnectionString = DB_PATH
            'Open database
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            'Name given to the dataset retrieved from the DB
            da.Fill(ds, "FeedbackTable")
            con.Close()
            'Populate DataGridView
            FeedbackTableDataGridView.DataSource = ds.Tables("FeedbackTable")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
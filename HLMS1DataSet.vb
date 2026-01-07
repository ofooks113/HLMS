Partial Class HLMS1DataSet
    Partial Public Class SeasonRateTableDataTable
        Private Sub SeasonRateTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub SeasonRateTableDataTable_SeasonRateTableRowChanging(sender As Object, e As SeasonRateTableRowChangeEvent) Handles Me.SeasonRateTableRowChanging

        End Sub

    End Class

    Partial Public Class FeedbackTableDataTable
        Private Sub FeedbackTableDataTable_FeedbackTableRowChanging(sender As Object, e As FeedbackTableRowChangeEvent) Handles Me.FeedbackTableRowChanging

        End Sub

    End Class
End Class

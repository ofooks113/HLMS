Imports System.IO
Imports System.Data.OleDb
Public Class Financial
    Private Sub Financial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_title.Text = "FINANCIAL REPORT FOR YEAR - " & Today.Year()
        updateGraphs()

    End Sub

    Dim totalIncome As Single = 0
    Dim totalCost As Single = 0

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Create graphs for income and expenditure
    ''
    ''

    Public Sub updateGraphs()

        ' initialise DB connection
        Dim cn As New OleDbConnection(DB_PATH)
        Dim da As New OleDbDataAdapter()
        Dim dt_income As New DataTable()
        Dim dt_costs As New DataTable()

        Dim teamID As Integer = 0
        Dim x_coord As Integer = 15
        Dim y_coord As Integer = 30
        Dim y_offset As Integer = 0

        totalIncome = 0
        totalCost = 0

        'clear existing items from list of teams
        _graphData.Clear()

        ' initialise totals list
        For x = 0 To 11
            _graphData.Add(New HLMS_Finance With {.monthID = x, .costs = 0, .income = 0})
        Next


        ''''''''''''' INCOME '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' open DB connection
        cn.Open()

        dt_income.Clear()
        'select data from DB and store in dataTable

        da.SelectCommand = New OleDbCommand("SELECT RentDue, StartDate FROM BookingTable  ORDER BY StartDate ASC", cn)
        da.Fill(dt_income)

        'close DB connection!
        cn.Close()

        Dim tmpAmount As Single = 0
        Dim tmpDate As Date = Today().ToShortDateString()
        Dim thisYear As Int16 = Date.Today.Year()
        Dim thisMonth As Int16 = 0

        ' total points for each team
        For Each r In dt_income.Rows

            tmpAmount = r(0)
            tmpDate = r(1)

            If tmpDate.Year() = thisYear Then

                Dim selectedValue As HLMS_Finance

                selectedValue = _graphData.Find(Function(p) p.monthID + 1 = tmpDate.Month()) ' get correct month
                selectedValue.income += r(0)    ' add on income for this month
            End If

        Next


        Dim maxVal As Integer = 0

        'get combined income for year
        For ai = 0 To 11
            totalIncome += _graphData(ai).income

            If _graphData(ai).income > maxVal Then
                maxVal = _graphData(ai).income
            End If
        Next

        ' now update graph

        If totalIncome > 0 Then

            x_coord = 15

            'now determine each month's income as % of max monthly income & update picbox height
            For ai = 0 To 11

                Dim picBoxName As String = "pb_income_" & ai
                Dim lblName As String = "lbl_income_" & ai

                Dim incomeVal As Int16 = Val(_graphData(ai).income)

                'set income percentage for current month
                _graphData(ai).incomePercent = Math.Floor((_graphData(ai).income / maxVal) * 100)

                ' update y coordinate for picbox accordingly
                y_coord = (100 - _graphData(ai).incomePercent) + 40

                Me.grp_income.Controls(picBoxName).SetBounds(x_coord, y_coord, 30, _graphData(ai).incomePercent)
                Me.grp_income.Controls(picBoxName).BackColor = Color.Green

                ' only show label & column for monthly income if > £0 
                If (incomeVal) > 0 Then
                    Me.grp_income.Controls(lblName).Text = "£" & incomeVal
                    Me.grp_income.Controls(lblName).Visible = True
                    Me.grp_income.Controls(picBoxName).Visible = True
                Else
                    Me.grp_income.Controls(lblName).Visible = False
                    Me.grp_income.Controls(picBoxName).Visible = False
                End If

                'position label above column on bar chart
                Me.grp_income.Controls(lblName).SetBounds(x_coord - 5, y_coord - 20, 40, 15)
                x_coord += 35

            Next

        End If

        ''''''''''''' EXPENSE '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' open DB connection
        cn.Open()

        dt_costs.Clear()
        'select data from DB and store in dataTable

        da.SelectCommand = New OleDbCommand("SELECT FeeDue, StartDate FROM ContractorJobTable  ORDER BY StartDate ASC", cn)
        da.Fill(dt_costs)

        'close DB connection!
        cn.Close()

        ' total cost for each month
        For Each r In dt_costs.Rows

            tmpAmount = r(0)
            tmpDate = r(1)

            If tmpDate.Year() = thisYear Then

                Dim selectedValue As HLMS_Finance

                selectedValue = _graphData.Find(Function(p) p.monthID + 1 = tmpDate.Month()) ' get correct month
                selectedValue.costs += r(0)    ' add on costs for this month
            End If

        Next

        maxVal = 0

        For ai = 0 To 11
            totalCost += _graphData(ai).costs

            If _graphData(ai).costs > maxVal Then
                maxVal = _graphData(ai).costs
            End If
        Next
        ' now update graph

        If totalCost > 0 Then

            x_coord = 15

            'now determine each month's expenditure as % of maximum monthly expenditure & update picbox height
            For ai = 0 To 11
                Dim picBoxName As String = "pb_cost_" & ai
                Dim lblName As String = "lbl_cost_" & ai

                Dim costVal As Int16 = Val(_graphData(ai).costs)

                'set costs percentage for current month
                _graphData(ai).costPercent = Math.Floor((_graphData(ai).costs / maxVal) * 100)

                ' update y coordinate for picbox accordingly
                y_coord = (100 - _graphData(ai).costPercent) + 40

                Me.grp_costs.Controls(picBoxName).SetBounds(x_coord, y_coord, 30, _graphData(ai).costPercent)
                Me.grp_costs.Controls(picBoxName).BackColor = Color.Red

                ' only show label for monthly costs if > £0 
                If (costVal) > 0 Then
                    Me.grp_costs.Controls(lblName).Text = "£" & costVal
                    Me.grp_costs.Controls(lblName).Visible = True
                    Me.grp_costs.Controls(picBoxName).Visible = True
                Else
                    Me.grp_costs.Controls(lblName).Visible = False
                    Me.grp_costs.Controls(picBoxName).Visible = False
                End If

                'position label above column on bar chart
                Me.grp_costs.Controls(lblName).SetBounds(x_coord - 5, y_coord - 20, 40, 15)
                x_coord += 35

            Next
        End If

        ''''''''''''' TOTALS '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim totals_pc As Integer = (totalIncome + totalCost)
        Dim totalIn_pc As Integer = (totalIncome / totals_pc) * 100
        Dim totalOut_pc As Integer = (totalCost / totals_pc) * 100


        pb_total_in.SetBounds(35, (100 - totalIn_pc + 40), 30, totalIn_pc)
        pb_total_in.BackColor = Color.Green

        pb_total_out.SetBounds(70, (100 - totalOut_pc + 40), 30, totalOut_pc)
        pb_total_out.BackColor = Color.Red

        ' only show label for monthly costs if > £0 
        If (totalCost) > 0 Then
            lbl_total_out.Text = "£" & Int(totalCost)
            lbl_total_out.Visible = True
        Else
            lbl_total_out.Visible = False
        End If

        ' only show label for monthly income if > £0 
        If (totalIncome) > 0 Then
            lbl_total_in.Text = "£" & Int(totalIncome)
            lbl_total_in.Visible = True
        Else
            lbl_total_in.Visible = False
        End If


        'position label above column on bar chart
        lbl_total_in.SetBounds(30, (100 - totalIn_pc + 30), 40, 15)
        lbl_total_out.SetBounds(66, (100 - totalOut_pc + 30), 40, 15)
        pb_total_in.Visible = True
        pb_total_out.Visible = True

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Close the form
    ''
    ''
    Private Sub cmdHomepage_Click(sender As Object, e As EventArgs) Handles cmdHomepage.Click
        Me.Close()
    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''
    '' Tooltip to show actual values on hover (labels are rounded to integer values to save space)
    ''
    ''
    Private Sub pb_total_in_MouseHover(sender As Object, e As EventArgs) Handles pb_total_in.MouseHover
        ToolTip1.Show("£" & totalIncome, pb_total_in)
    End Sub

    Private Sub pb_total_out_MouseHover(sender As Object, e As EventArgs) Handles pb_total_out.MouseHover
        ToolTip1.Show("£" & totalCost, pb_total_out)
    End Sub


End Class
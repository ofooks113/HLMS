Imports System.IO

Module systemData

    Friend DB_PATH As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0; Data Source=" & Directory.GetCurrentDirectory & "\HLMS1.accdb"

    Public Const PROTECT As Byte = 0 'Not written to (Read-only)
    Public Const INSERT As Byte = 1 'Insert record
    Public Const MODIFY As Byte = 2 'Change existing record
    Public Const DELETE As Byte = 3 'Delete record from database

    Class HLMS_Customer
        Property custID As Integer
        Property custFirstName As String
        Property custSurname As String
        Property displayName As String

    End Class

    Class HLMS_Contractor
        Property contID As String
        Property contFirstName As String
        Property contSurname As String
        Property displayName As String
    End Class

    Class HLMS_Booking
        Property bookingID As Integer
        Property bookingRef As String
        Property bookingStartDate As DateTime
        Property bookingEndDate As DateTime
    End Class

    Class HLMS_Job
        Property jobID As Integer
        Property contID As String
        Property jobStartDate As DateTime
        Property jobEndDate As DateTime
    End Class

    Class HLMS_Finance

        Property monthID As Short
        Property income As Single
        Property costs As Single
        Property incomePercent As Single
        Property costPercent As Single

    End Class

    ' lists of customers, bookings and contractors
    Public _customers As New List(Of HLMS_Customer)
    Public _bookings As New List(Of HLMS_Booking)
    Public _contractors As New List(Of HLMS_Contractor)
    Public _jobs As New List(Of HLMS_Job)
    Public _finance As New List(Of HLMS_Finance)
    Public _graphData As New List(Of HLMS_Finance)


    'flags for updates to DB (used in combobox refresh)
    Public customerUpdated As Boolean = False
    Public bookingUpdated As Boolean = False
    Public contractorUpdated As Boolean = False
    Public jobUpdated As Boolean = False
    Public incomeUpdated As Boolean = False


End Module

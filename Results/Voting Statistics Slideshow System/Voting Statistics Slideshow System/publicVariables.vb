Imports MySql.Data.MySqlClient

Module publicVariables

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public sql As String

    Public totalundervote As Integer
    Public totalstatvote As Integer

    Public total As Double
    Public untotal As Double

    Public counttotals As Integer
    Public countvoted As Integer

End Module

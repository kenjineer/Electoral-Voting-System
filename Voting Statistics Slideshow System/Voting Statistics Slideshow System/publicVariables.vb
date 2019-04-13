Imports MySql.Data.MySqlClient

Module publicVariables

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public sql As String

    Public cecount As String
    Public cpecount As String
    Public ececount As String
    Public eecount As String
    Public iecount As String
    Public mecount As String

    Public totalundervote As Integer
    Public totalstatvote As Integer

    Public total As Double
    Public untotal As Double

    Public counttotals As Integer
    Public countce As String
    Public countcpe As String
    Public countece As String
    Public countee As String
    Public countie As String
    Public countme As String

End Module

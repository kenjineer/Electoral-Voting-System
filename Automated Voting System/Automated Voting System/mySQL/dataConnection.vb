Imports MySql.Data.MySqlClient

Module dataConnection

    Public Sub dbConnection()

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=root;database=esc_elections"
        conn.Open()

    End Sub

End Module

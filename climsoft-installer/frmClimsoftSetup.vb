Imports MySql.Data.MySqlClient

Public Class frmClimsoftSetup
    Private Sub executeSQL(conn As MySqlConnection)
        Dim cmd As New MySqlCommand
        Dim fileReader As System.IO.StreamReader
        Dim line As String
        Dim lineNum As Integer = 0
        Dim numLines As Integer = 1040 ' FIXME: Should be read from file

        Try
            lblProgress.Visible = True
            pgbProgress.Visible = True
            Me.Refresh()

            cmd = New MySqlCommand("DROP DATABASE IF EXISTS mariadb_climsoft_db_v4", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("DROP DATABASE IF EXISTS mariadb_climsoft_test_db_v4", conn)
            cmd.ExecuteNonQuery()

            Try
                fileReader = My.Computer.FileSystem.OpenTextFileReader("climsoft4_setup.sql")
                line = fileReader.ReadLine()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            While (line IsNot Nothing)
                ' lblDatabase2.Text = lineNum.ToString
                ' Me.Refresh()
                cmd = New MySqlCommand(line, conn)
                cmd.ExecuteNonQuery()
                lineNum += 1
                pgbProgress.Value = 100 * lineNum / numLines
                line = fileReader.ReadLine()
            End While

            MsgBox("Setup complete")
        Catch ex As Exception
            MsgBox(ex.Message & String.Format(" ({0})", lineNum))
        End Try

    End Sub

    Private Sub cmdSetup_Click(sender As Object, e As EventArgs) Handles cmdSetup.Click
        Dim cmd As New MySqlCommand
        Dim databases = New String() {"mariadb_climsoft_db_v4", "mariadb_climsoft_test_db_v4"}
        Dim databaseExists As Boolean = False
        Dim conn As New MySqlConnection
        Dim strConnection As String

        cmdSetup.Enabled = False

        ' First - attempt to connect to the two databases to check whether it already exists
        For Each database In databases
            strConnection = String.Format("server={0};database={1};port={2};uid={3};pwd={4};", txtServer.Text, database, txtPort.Text, txtUser.Text, txtPass.Text)
            conn.ConnectionString = strConnection

            Try
                conn.Open()
                ' Oh dear - the database already exists and we were able to connect to it
                databaseExists = True
            Catch ex As Exception
                ' Good, the database does not exist yet (or we are unable to connect to it)
            Finally
                conn.Close()
            End Try
        Next

        strConnection = String.Format("server={0};port={1};uid={2};pwd={3};", txtServer.Text, txtPort.Text, txtUser.Text, txtPass.Text)
        conn.ConnectionString = strConnection
        Try
            conn.Open()
            If databaseExists Then
                Select Case MsgBox("All data in existing mariadb_climsoft_db_v4 and mariadb_climsoft_test_db_v4 databases will be lost. Are you sure you want to continue?", MsgBoxStyle.YesNoCancel, "Warning")
                    Case MsgBoxResult.Yes
                        executeSQL(conn)
                End Select
            Else
                executeSQL(conn)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        lblProgress.Visible = False
        pgbProgress.Visible = False
        cmdSetup.Enabled = True
        Me.Refresh()
    End Sub
End Class

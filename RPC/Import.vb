Imports System.IO
Imports System.Data.SqlServerCe
Imports System.Data
Imports System


Public Class Import
    Dim count As Integer

    Private Sub BtnBack_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose(True)
    End Sub
    Private Sub WriteLocationToDB(ByVal str As String)
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        cmd = New SqlCeCommand("Insert Into location(name) Values('" + str.Trim() + "')", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        cmd.ExecuteNonQuery()
        count += 1
        SQLtransaction.Commit()

        con.Close()
        con = Nothing
    End Sub
    Private Sub WriteCustToDB(ByVal str As String)
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        cmd = New SqlCeCommand("Insert Into customer(name) Values('" + str.Trim() + "')", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        cmd.ExecuteNonQuery()
        count += 1
        SQLtransaction.Commit()
        con.Close()
        con = Nothing
    End Sub
    Private Sub BtnImportCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportCust.Click
        Dim filePath As String
        Dim line As String
        If OpenFileDialog1.ShowDialog = 1 Then
            filePath = OpenFileDialog1.FileName
            
            If MessageBox.Show("Are you sure?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Using sr As New StreamReader(filePath)
                    line = sr.ReadToEnd()
                End Using
            Else
                Return
            End If

        Else
            Return
        End If

        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand

        cmd = New SqlCeCommand("DELETE FROM  customer", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        cmd.ExecuteNonQuery()
        SQLtransaction.Commit()
        con.Close()
        con = Nothing

        Dim split As String() = line.Split(New [Char]() {","c})
        count = 0
        For Each s As String In split
            If s.Trim() <> "" Then
                WriteCustToDB(s)
            End If
        Next s
        MessageBox.Show(count.ToString() + " records imported!")
        If MessageBox.Show("Are you sure to Detele csv?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            File.Delete(filePath)
        End If
    End Sub

    Private Sub BtnImportLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportLoc.Click
        Dim filePath As String
        Dim line As String
        If OpenFileDialog1.ShowDialog = 1 Then
            filePath = OpenFileDialog1.FileName

            If MessageBox.Show("Are you sure?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Using sr As New StreamReader(filePath)
                    line = sr.ReadToEnd()
                End Using
            Else
                Return
            End If            
        Else
            Return
        End If
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand

        cmd = New SqlCeCommand("DELETE FROM  location ", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        cmd.ExecuteNonQuery()
        SQLtransaction.Commit()
        con.Close()
        con = Nothing
        Dim split As String() = line.Split(New [Char]() {","c})
        count = 0
        For Each s As String In split
            If s.Trim() <> "" Then
                WriteLocationToDB(s)
            End If
        Next s
        MessageBox.Show(count.ToString() + " records imported!")
        If MessageBox.Show("Are you sure to Detele csv?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            File.Delete(filePath)
        End If
    End Sub
    Private Sub WriteAdrToDB(ByVal str As String)
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand

        Dim split As String() = str.Split(New [Char]() {","c})
        cmd = New SqlCeCommand("Insert Into customer_address(customer,address) Values('" + split(0).Trim() + "','" + split(1).Trim() + "')", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        cmd.ExecuteNonQuery()
        count += 1
        SQLtransaction.Commit()
        con.Close()
        con = Nothing
    End Sub
    Private Sub BtnImportAdr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportAdr.Click
        Dim filePath As String
        Dim line As String
        If OpenFileDialog1.ShowDialog = 1 Then
            filePath = OpenFileDialog1.FileName
            
            If MessageBox.Show("Are you sure?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Using sr As New StreamReader(filePath)
                    line = sr.ReadToEnd()
                End Using
            Else
                Return
            End If
           
        Else
            Return
        End If

        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        cmd = New SqlCeCommand("DELETE FROM  customer_address", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        cmd.ExecuteNonQuery()
        SQLtransaction.Commit()
        con.Close()
        con = Nothing

        Dim splitOnNewLine As String() = line.Split(New [Char]() {})
        count = 0
        For Each str As String In splitOnNewLine
            If str.Trim() <> "" Then
                WriteAdrToDB(str)
            End If
        Next str

        MessageBox.Show((count).ToString() + " records imported!")
        If MessageBox.Show("Are you sure to Detele csv?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            File.Delete(filePath)
        End If
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Dispose(True)
    End Sub

    Private Sub BtnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearAll.Click
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        cmd = New SqlCeCommand("DELETE FROM  batch", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        Dim ret As Integer = cmd.ExecuteNonQuery()
        SQLtransaction.Commit()

        cmd = New SqlCeCommand("DELETE FROM  batch_line", con)
        If con.State = ConnectionState.Closed Then con.Open()
        SQLtransaction = con.BeginTransaction()

        Dim ret1 As Integer = cmd.ExecuteNonQuery()
        SQLtransaction.Commit()

        con.Close()
        con = Nothing

        MessageBox.Show((ret + ret1).ToString() + " records delete!")
    End Sub

    Private Sub BtnClearWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearWeek.Click
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        Dim weeks2 As String = DateAdd(DateInterval.Day, -14, Now).ToString("yyyy-MM-dd HH:mm:ss")

        cmd = New SqlCeCommand("DELETE FROM  batch where created <'" + weeks2 + "'", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
        Dim ret As Integer = cmd.ExecuteNonQuery()
        SQLtransaction.Commit()

        con.Close()
        con = Nothing

        MessageBox.Show(ret.ToString() + " records delete!")
    End Sub
End Class
Imports System.Data.SqlServerCe
Imports System.Data
Imports System
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports Symbol.Barcode2


Public Class EditAdd

    Private Sub CboCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCustomer.SelectedIndexChanged
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        Dim dA As SqlCeDataAdapter
        Dim str As String = CboCustomer.SelectedValue.ToString().Trim()
        cmd = New SqlCeCommand("Select address FROM customer_address where customer='" _
                               + str + "'", con)
        If con.State = ConnectionState.Closed Then con.Open()
        dA = New SqlCeDataAdapter(cmd)
        Dim table As Data.DataTable = New Data.DataTable()
        dA.Fill(table)
        CboAddress.DisplayMember = "address"
        CboAddress.ValueMember = "address"
        CboAddress.DataSource = table

        con.Close()
        con = Nothing
    End Sub

    Private Sub EditAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Module1.isEdit = False Then
            Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
            Dim cmd As SqlCeCommand
            Dim dA As SqlCeDataAdapter
            Dim table As Data.DataTable = New Data.DataTable()
            cmd = New SqlCeCommand("Select name FROM customer", con)
            If con.State = ConnectionState.Closed Then con.Open()
            dA = New SqlCeDataAdapter(cmd)

            dA.Fill(table)
            CboCustomer.DisplayMember = "name"
            CboCustomer.ValueMember = "name"
            CboCustomer.DataSource = table

            cmd = New SqlCeCommand("Select name FROM location", con)
            If con.State = ConnectionState.Closed Then con.Open()
            dA = New SqlCeDataAdapter(cmd)
            Dim table2 As Data.DataTable = New Data.DataTable()
            dA.Fill(table2)
            CboLocation.DisplayMember = "name"
            CboLocation.ValueMember = "name"
            CboLocation.DataSource = table2

            con.Close()
            con = Nothing

            'should remove in final relase its for barcode testing
            ListBox1.Items.Add("24224242434")
            ListBox1.Items.Add("11111111111")
        End If
        If Module1.isEdit = True Then
            TxtBoxOrderNo.Text = Module1.orderno
            If String.IsNullOrEmpty(Module1.batch_code) = False Then
                Dim split As String() = Module1.batch_code.Split(New [Char]() {","c})
                For Each s As String In split
                    If s.Trim() <> "" Then
                        ListBox1.Items.Add(s)
                    End If
                Next s
            End If

            Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
            Dim cmd As SqlCeCommand
            Dim dA As SqlCeDataAdapter
            Dim table As Data.DataTable = New Data.DataTable()
            cmd = New SqlCeCommand("Select name FROM customer", con)
            If con.State = ConnectionState.Closed Then con.Open()
            dA = New SqlCeDataAdapter(cmd)

            dA.Fill(table)
            CboCustomer.DisplayMember = "name"
            CboCustomer.ValueMember = "name"
            CboCustomer.DataSource = table

            cmd = New SqlCeCommand("Select name FROM location", con)
            If con.State = ConnectionState.Closed Then con.Open()
            dA = New SqlCeDataAdapter(cmd)
            Dim table2 As Data.DataTable = New Data.DataTable()
            dA.Fill(table2)
            CboLocation.DisplayMember = "name"
            CboLocation.ValueMember = "name"
            CboLocation.DataSource = table2

            con.Close()
            con = Nothing

            CboCustomer.SelectedValue = Module1.customer

            CboLocation.SelectedValue = Module1.location
        End If

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub BtnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel2.Click
        If MessageBox.Show("Back to main?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Dispose(True)

        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Back to main?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Dispose(True)

        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If String.IsNullOrEmpty(TxtBoxOrderNo.Text.Trim()) Then
            MessageBox.Show("OrderNo is empty")
            Return
        End If

        If String.IsNullOrEmpty(CboAddress.SelectedItem.ToString()) Then
            MessageBox.Show("Address is empty")
            Return
        End If

        If String.IsNullOrEmpty(CboLocation.SelectedItem.ToString()) Then
            MessageBox.Show("Location is empty")
            Return
        End If

        If String.IsNullOrEmpty(CboCustomer.SelectedItem.ToString()) Then
            MessageBox.Show("Location is empty")
            Return
        End If

        If MessageBox.Show("Are you sure?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            If Module1.isEdit = False Then
                Dim filename As String = Module1.workingDirectory + "\" + TxtBoxOrderNo.Text + "-" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".csv"
                Dim file As New StreamWriter(filename)

                file.WriteLine("OrderNo," + TxtBoxOrderNo.Text)
                file.WriteLine("Customer," + CboCustomer.SelectedValue.ToString())
                file.WriteLine("Address," + CboAddress.SelectedValue.ToString())
                file.WriteLine("Location," + CboLocation.SelectedValue.ToString())

                Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
                Dim cmd As SqlCeCommand = New SqlCeCommand()
                cmd.Connection = con
                cmd.CommandText = "Insert Into batch(customer,customer_address,location,[order],created) Values(@customer,@customer_address,@location,@order,@created)"
                cmd.Parameters.AddWithValue("@customer", CboCustomer.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@customer_address", CboAddress.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@location", CboLocation.SelectedValue.ToString())

                cmd.Parameters.AddWithValue("@order", TxtBoxOrderNo.Text.Trim())

                cmd.Parameters.AddWithValue("@created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

                If con.State = ConnectionState.Closed Then con.Open()
                Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
                cmd.ExecuteNonQuery()
                SQLtransaction.Commit()
                cmd.CommandText = "SELECT @@IDENTITY"
                Dim ret As Integer = cmd.ExecuteScalar()
                Dim i As Integer
                For i = 0 To ListBox1.Items.Count - 1
                    Dim str As String = ListBox1.Items.Item(i)
                    cmd.CommandText = "Insert Into batch_line(fk_batch,code) Values(@fk_batch,@code)"
                    cmd.Parameters.AddWithValue("@fk_batch", ret)
                    cmd.Parameters.AddWithValue("@code", str)

                    If con.State = ConnectionState.Closed Then con.Open()
                    SQLtransaction = con.BeginTransaction()
                    cmd.ExecuteNonQuery()
                    SQLtransaction.Commit()
                    cmd.Parameters.Clear()
                    file.WriteLine("Batch_line," + ret.ToString() + "," + str)
                Next

                con.Close()
                con = Nothing
                file.Close()
                MessageBox.Show("Order No." + TxtBoxOrderNo.Text + " record added!")
                MessageBox.Show(filename + " created!")

            End If
            If Module1.isEdit = True Then
                Dim filename As String = Module1.workingDirectory + "\" + TxtBoxOrderNo.Text + "-" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".csv"
                Dim file As New StreamWriter(filename)

                file.WriteLine("OrderNo," + TxtBoxOrderNo.Text)
                file.WriteLine("Customer," + CboCustomer.SelectedValue.ToString())
                file.WriteLine("Address," + CboAddress.SelectedValue.ToString())
                file.WriteLine("Location," + CboLocation.SelectedValue.ToString())

                Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
                Dim cmd As SqlCeCommand = New SqlCeCommand()
                cmd.Connection = con
                cmd.CommandText = "Update batch Set customer=@customer,customer_address=@customer_address,location=@location,[order]=@order,edit=@edit where pk=@pk"
                cmd.Parameters.AddWithValue("@customer", CboCustomer.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@customer_address", CboAddress.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@location", CboLocation.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@order", TxtBoxOrderNo.Text.Trim())

                cmd.Parameters.AddWithValue("@edit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@pk", Module1.pk)
                If con.State = ConnectionState.Closed Then con.Open()
                Dim SQLtransaction As SqlCeTransaction = con.BeginTransaction()
                cmd.ExecuteNonQuery()
                SQLtransaction.Commit()
                Dim ret As Integer = Module1.batch_line
                cmd = New SqlCeCommand("DELETE FROM  batch_line where fk_batch='" + ret.ToString() + "'", con)
                If con.State = ConnectionState.Closed Then con.Open()
                SQLtransaction = con.BeginTransaction()
                cmd.ExecuteNonQuery()
                SQLtransaction.Commit()

                Dim i As Integer
                For i = 0 To ListBox1.Items.Count - 1
                    Dim str As String = ListBox1.Items.Item(i)
                    cmd.CommandText = "Insert Into batch_line(fk_batch,code) Values(@fk_batch,@code)"
                    cmd.Parameters.AddWithValue("@fk_batch", ret)
                    cmd.Parameters.AddWithValue("@code", str)

                    If con.State = ConnectionState.Closed Then con.Open()
                    SQLtransaction = con.BeginTransaction()
                    cmd.ExecuteNonQuery()
                    SQLtransaction.Commit()
                    cmd.Parameters.Clear()
                    file.WriteLine("Batch_line," + ret.ToString() + "," + str)
                Next

                con.Close()
                con = Nothing
                file.Close()
                MessageBox.Show("Order No." + TxtBoxOrderNo.Text + " record updated!")
                MessageBox.Show(filename + " created!")
            End If

        End If
    End Sub

    Private Sub Barcode1_OnRead(ByVal sender As System.Object, ByVal readerData As Symbol.Barcode.ReaderData) Handles Barcode1.OnRead
        ListBox1.Items.Add(readerData.Text)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If MessageBox.Show("Back to main?", "RPC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Dispose(True)

        End If
    End Sub


End Class
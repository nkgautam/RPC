Imports System.Data.SqlServerCe
Imports System.Data

Public Class Form1
    Dim dataSet As DataSet
    Private Sub BtnSetttings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim form2 As New Password
        form2.Visible = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ts As DataGridTableStyle = New DataGridTableStyle()
        ts.MappingName = "dTable"

        Dim created As New DataGridTextBoxColumn()
        created.MappingName = "created1"
        created.HeaderText = "created"
        created.Width = 70
        ts.GridColumnStyles.Add(created)

        Dim order As New DataGridTextBoxColumn()
        order.MappingName = "order"
        order.HeaderText = "order"
        order.Width = 70
        ts.GridColumnStyles.Add(order)

        Dim customer As New DataGridTextBoxColumn()
        customer.MappingName = "customer"
        customer.HeaderText = "customer"
        customer.Width = 70
        ts.GridColumnStyles.Add(customer)

        Dim location As New DataGridTextBoxColumn()
        location.MappingName = "location"
        location.HeaderText = "location"
        location.Width = 70
        ts.GridColumnStyles.Add(location)
        DataGrid1.TableStyles.Add(ts)
        updateBatch()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If DataGrid1.CurrentRowIndex() < 0 Then
            Return
        End If
        Module1.isEdit = True
        Dim table As DataTable = dataSet.Tables("dTable")

        Module1.orderno = table.Rows.Item(DataGrid1.CurrentRowIndex())("order")
        Module1.customer = table.Rows.Item(DataGrid1.CurrentRowIndex())("customer")
        Module1.location = table.Rows.Item(DataGrid1.CurrentRowIndex())("location")
        Dim strCreated = table.Rows.Item(DataGrid1.CurrentRowIndex())("created")

        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        Dim dA As SqlCeDataAdapter

        cmd = New SqlCeCommand("SELECT *  FROM batch where  created ='" + strCreated + "'", con)

        If con.State = ConnectionState.Closed Then con.Open()
        dA = New SqlCeDataAdapter(cmd)
        Dim dataSet2 = New DataSet()
        dA.Fill(dataSet2, "dTable")

        Module1.pk = dataSet2.Tables("dTable").Rows.Item(0)("pk")
        Module1.created = strCreated
        cmd = New SqlCeCommand("SELECT *  FROM batch_line where  fk_batch ='" + Module1.pk.ToString() + "'", con)

        If con.State = ConnectionState.Closed Then con.Open()
        dA = New SqlCeDataAdapter(cmd)
        Dim dataSet3 = New DataSet()
        dA.Fill(dataSet3, "dTable")
        Dim strcCode As String = Nothing

        For Each row As DataRow In dataSet3.Tables("dTable").Rows
            strcCode += row("code") + ","
        Next row
        Module1.batch_code = strcCode

        con.Close()
        con = Nothing

        Dim edit As New EditAdd
        edit.Visible = True
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Module1.isEdit = False
        Dim add As New EditAdd
        add.Visible = True
    End Sub
    Private Sub updateBatch()

        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand
        Dim dA As SqlCeDataAdapter

        cmd = New SqlCeCommand("SELECT created, CONVERT(nvarchar(24), created,13) AS created1 , [order], customer, location  FROM batch ORDER BY created DESC, [order] ASC", con)

        If con.State = ConnectionState.Closed Then con.Open()
        dA = New SqlCeDataAdapter(cmd)
        dataSet = New DataSet()
        dA.Fill(dataSet, "dTable")
        DataGrid1.DataSource = dataSet.Tables("dTable").DefaultView
        con.Close()
        con = Nothing
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim strCreated = dataSet.Tables("dTable").Rows.Item(DataGrid1.CurrentRowIndex())("created")
        Dim con As SqlCeConnection = New SqlCeConnection("Data Source=" + Module1.path)
        Dim cmd As SqlCeCommand

        cmd = New SqlCeCommand("Delete FROM batch where  created ='" + strCreated + "'", con)

        If con.State = ConnectionState.Closed Then con.Open()
        Dim ret As Integer = cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        If ret > 0 Then
            MessageBox.Show(dataSet.Tables("dTable").Rows.Item(DataGrid1.CurrentRowIndex())("order") + " deleted!")
            updateBatch()
        End If

        
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim form2 As New Password
        form2.Visible = True
    End Sub

    Private Sub Form1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        updateBatch()
    End Sub
End Class

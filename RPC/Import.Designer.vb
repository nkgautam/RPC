<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Import
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Import))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.BtnClearAll = New System.Windows.Forms.Button
        Me.BtnClearWeek = New System.Windows.Forms.Button
        Me.BtnImportLoc = New System.Windows.Forms.Button
        Me.BtnImportAdr = New System.Windows.Forms.Button
        Me.BtnImportCust = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'BtnClearAll
        '
        Me.BtnClearAll.Location = New System.Drawing.Point(191, 188)
        Me.BtnClearAll.Name = "BtnClearAll"
        Me.BtnClearAll.Size = New System.Drawing.Size(94, 22)
        Me.BtnClearAll.TabIndex = 9
        Me.BtnClearAll.Text = "Clear All"
        '
        'BtnClearWeek
        '
        Me.BtnClearWeek.Location = New System.Drawing.Point(191, 159)
        Me.BtnClearWeek.Name = "BtnClearWeek"
        Me.BtnClearWeek.Size = New System.Drawing.Size(94, 22)
        Me.BtnClearWeek.TabIndex = 8
        Me.BtnClearWeek.Text = "Clear 2 Weeks"
        '
        'BtnImportLoc
        '
        Me.BtnImportLoc.Location = New System.Drawing.Point(70, 120)
        Me.BtnImportLoc.Name = "BtnImportLoc"
        Me.BtnImportLoc.Size = New System.Drawing.Size(215, 29)
        Me.BtnImportLoc.TabIndex = 7
        Me.BtnImportLoc.Text = "Import Location"
        '
        'BtnImportAdr
        '
        Me.BtnImportAdr.Location = New System.Drawing.Point(70, 80)
        Me.BtnImportAdr.Name = "BtnImportAdr"
        Me.BtnImportAdr.Size = New System.Drawing.Size(215, 29)
        Me.BtnImportAdr.TabIndex = 6
        Me.BtnImportAdr.Text = "Import Addresses"
        '
        'BtnImportCust
        '
        Me.BtnImportCust.Location = New System.Drawing.Point(70, 40)
        Me.BtnImportCust.Name = "BtnImportCust"
        Me.BtnImportCust.Size = New System.Drawing.Size(215, 29)
        Me.BtnImportCust.TabIndex = 5
        Me.BtnImportCust.Text = "Import Customer"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """Text Files (*.csv)|*.csv"""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 34)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(253, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 36)
        '
        'Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(318, 215)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnClearAll)
        Me.Controls.Add(Me.BtnClearWeek)
        Me.Controls.Add(Me.BtnImportLoc)
        Me.Controls.Add(Me.BtnImportAdr)
        Me.Controls.Add(Me.BtnImportCust)
        Me.Menu = Me.mainMenu1
        Me.Name = "Import"
        Me.Text = "Import"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClearAll As System.Windows.Forms.Button
    Friend WithEvents BtnClearWeek As System.Windows.Forms.Button
    Friend WithEvents BtnImportLoc As System.Windows.Forms.Button
    Friend WithEvents BtnImportAdr As System.Windows.Forms.Button
    Friend WithEvents BtnImportCust As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

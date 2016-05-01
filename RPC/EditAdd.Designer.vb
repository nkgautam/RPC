<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class EditAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAdd))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnCancel2 = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.TxtBoxOrderNo = New System.Windows.Forms.TextBox
        Me.CboCustomer = New System.Windows.Forms.ComboBox
        Me.CboAddress = New System.Windows.Forms.ComboBox
        Me.CboLocation = New System.Windows.Forms.ComboBox
        Me.Barcode1 = New Barcode.Barcode
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "Order No."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.Text = "Location"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(8, 152)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(286, 162)
        Me.ListBox1.TabIndex = 14
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(8, 320)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(72, 20)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "Add"
        '
        'BtnCancel2
        '
        Me.BtnCancel2.Location = New System.Drawing.Point(86, 320)
        Me.BtnCancel2.Name = "BtnCancel2"
        Me.BtnCancel2.Size = New System.Drawing.Size(72, 20)
        Me.BtnCancel2.TabIndex = 16
        Me.BtnCancel2.Text = "Cancel"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(222, 320)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(72, 20)
        Me.BtnDelete.TabIndex = 17
        Me.BtnDelete.Text = "Delete"
        '
        'TxtBoxOrderNo
        '
        Me.TxtBoxOrderNo.Location = New System.Drawing.Point(73, 31)
        Me.TxtBoxOrderNo.Name = "TxtBoxOrderNo"
        Me.TxtBoxOrderNo.Size = New System.Drawing.Size(220, 23)
        Me.TxtBoxOrderNo.TabIndex = 18
        '
        'CboCustomer
        '
        Me.CboCustomer.Location = New System.Drawing.Point(73, 60)
        Me.CboCustomer.Name = "CboCustomer"
        Me.CboCustomer.Size = New System.Drawing.Size(220, 23)
        Me.CboCustomer.TabIndex = 19
        '
        'CboAddress
        '
        Me.CboAddress.Location = New System.Drawing.Point(73, 89)
        Me.CboAddress.Name = "CboAddress"
        Me.CboAddress.Size = New System.Drawing.Size(220, 23)
        Me.CboAddress.TabIndex = 20
        '
        'CboLocation
        '
        Me.CboLocation.Location = New System.Drawing.Point(73, 122)
        Me.CboLocation.Name = "CboLocation"
        Me.CboLocation.Size = New System.Drawing.Size(220, 23)
        Me.CboLocation.TabIndex = 21
        '
        'Barcode1
        '
        Me.Barcode1.BufferSize = 7905
        Me.Barcode1.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.CODABARParams.ClsiEditing = False
        Me.Barcode1.DecoderParameters.CODABARParams.NotisEditing = False
        Me.Barcode1.DecoderParameters.CODABARParams.Redundancy = True
        Me.Barcode1.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.CODE128Params.EAN128 = True
        Me.Barcode1.DecoderParameters.CODE128Params.ISBT128 = True
        Me.Barcode1.DecoderParameters.CODE128Params.Other128 = True
        Me.Barcode1.DecoderParameters.CODE128Params.Redundancy = False
        Me.Barcode1.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.CODE39Params.Code32Prefix = False
        Me.Barcode1.DecoderParameters.CODE39Params.Concatenation = False
        Me.Barcode1.DecoderParameters.CODE39Params.ConvertToCode32 = False
        Me.Barcode1.DecoderParameters.CODE39Params.FullAscii = False
        Me.Barcode1.DecoderParameters.CODE39Params.Redundancy = False
        Me.Barcode1.DecoderParameters.CODE39Params.ReportCheckDigit = False
        Me.Barcode1.DecoderParameters.CODE39Params.VerifyCheckDigit = False
        Me.Barcode1.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.DecoderParameters.CODE93Params.Redundancy = False
        Me.Barcode1.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled
        Me.Barcode1.DecoderParameters.D2OF5Params.Redundancy = True
        Me.Barcode1.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.EAN8Params.ConvertToEAN13 = False
        Me.Barcode1.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None
        Me.Barcode1.DecoderParameters.I2OF5Params.ConvertToEAN13 = False
        Me.Barcode1.DecoderParameters.I2OF5Params.Redundancy = True
        Me.Barcode1.DecoderParameters.I2OF5Params.ReportCheckDigit = False
        Me.Barcode1.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One
        Me.Barcode1.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10
        Me.Barcode1.DecoderParameters.MSIParams.Redundancy = True
        Me.Barcode1.DecoderParameters.MSIParams.ReportCheckDigit = False
        Me.Barcode1.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System
        Me.Barcode1.DecoderParameters.UPCAParams.ReportCheckDigit = True
        Me.Barcode1.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled
        Me.Barcode1.DecoderParameters.UPCE0Params.ConvertToUPCA = False
        Me.Barcode1.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None
        Me.Barcode1.DecoderParameters.UPCE0Params.ReportCheckDigit = False
        Me.Barcode1.DeviceName = Nothing
        Me.Barcode1.EnableScanner = False
        Me.Barcode1.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0
        Me.Barcode1.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED
        Me.Barcode1.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined
        Me.Barcode1.ScanParameters.BeepFrequency = 2670
        Me.Barcode1.ScanParameters.BeepTime = 200
        Me.Barcode1.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None
        Me.Barcode1.ScanParameters.LedTime = 3000
        Me.Barcode1.ScanParameters.ScanType = Barcode.ScanTypes.Foreground
        Me.Barcode1.ScanParameters.WaveFile = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 31)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(261, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 31)
        '
        'EditAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(318, 215)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CboLocation)
        Me.Controls.Add(Me.CboAddress)
        Me.Controls.Add(Me.CboCustomer)
        Me.Controls.Add(Me.TxtBoxOrderNo)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnCancel2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "EditAdd"
        Me.Text = "RPC"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel2 As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents TxtBoxOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents CboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents CboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents CboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Barcode1 As Barcode.Barcode
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

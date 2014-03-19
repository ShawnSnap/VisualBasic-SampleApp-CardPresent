Namespace SampleCode
    Partial Class ManageApplicationData
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageApplicationData))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cboApplicationDataAction = New System.Windows.Forms.ComboBox()
        Me.lnkManageApplicationData = New System.Windows.Forms.LinkLabel()
        Me.label15 = New System.Windows.Forms.Label()
        Me.CmdPerformWebRequest = New System.Windows.Forms.Button()
        Me.txtApplicationProfileId = New System.Windows.Forms.TextBox()
        Me.GrpGetApplicationData = New System.Windows.Forms.GroupBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboEncryptionType = New System.Windows.Forms.ComboBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TxtDeviceSerialNumber = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmdPopulateTestValues = New System.Windows.Forms.Button()
        Me.cboReadCapability = New System.Windows.Forms.ComboBox()
        Me.cboPINCapability = New System.Windows.Forms.ComboBox()
        Me.txtPTLSSocketId = New System.Windows.Forms.TextBox()
        Me.cboHardwareType = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cboApplicationLocation = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cboApplicationAttended = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtVendorId = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtSoftwareVersionDate = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtSoftwareVersion = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtDeveloperId = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtApplicationName = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.GrpGetApplicationData.SuspendLayout
        Me.groupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(377, 533)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = true
        '
        'cboApplicationDataAction
        '
        Me.cboApplicationDataAction.FormattingEnabled = true
        Me.cboApplicationDataAction.Location = New System.Drawing.Point(6, 19)
        Me.cboApplicationDataAction.Name = "cboApplicationDataAction"
        Me.cboApplicationDataAction.Size = New System.Drawing.Size(197, 21)
        Me.cboApplicationDataAction.TabIndex = 147
        '
        'lnkManageApplicationData
        '
        Me.lnkManageApplicationData.AutoSize = true
        Me.lnkManageApplicationData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkManageApplicationData.Image = CType(resources.GetObject("lnkManageApplicationData.Image"),System.Drawing.Image)
        Me.lnkManageApplicationData.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lnkManageApplicationData.Location = New System.Drawing.Point(420, 41)
        Me.lnkManageApplicationData.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkManageApplicationData.MinimumSize = New System.Drawing.Size(20, 20)
        Me.lnkManageApplicationData.Name = "lnkManageApplicationData"
        Me.lnkManageApplicationData.Size = New System.Drawing.Size(20, 20)
        Me.lnkManageApplicationData.TabIndex = 124
        Me.lnkManageApplicationData.Tag = "Learn more about ""Sign On"""
        '
        'label15
        '
        Me.label15.AutoSize = true
        Me.label15.Location = New System.Drawing.Point(6, 49)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(103, 13)
        Me.label15.TabIndex = 8
        Me.label15.Text = "Application Profile Id"
        '
        'CmdPerformWebRequest
        '
        Me.CmdPerformWebRequest.Location = New System.Drawing.Point(293, 15)
        Me.CmdPerformWebRequest.Name = "CmdPerformWebRequest"
        Me.CmdPerformWebRequest.Size = New System.Drawing.Size(147, 23)
        Me.CmdPerformWebRequest.TabIndex = 0
        Me.CmdPerformWebRequest.Text = "Perform Web Request"
        Me.CmdPerformWebRequest.UseVisualStyleBackColor = true
        '
        'txtApplicationProfileId
        '
        Me.txtApplicationProfileId.BackColor = System.Drawing.SystemColors.Window
        Me.txtApplicationProfileId.Location = New System.Drawing.Point(115, 46)
        Me.txtApplicationProfileId.Name = "txtApplicationProfileId"
        Me.txtApplicationProfileId.Size = New System.Drawing.Size(88, 20)
        Me.txtApplicationProfileId.TabIndex = 7
        '
        'GrpGetApplicationData
        '
        Me.GrpGetApplicationData.Controls.Add(Me.cboApplicationDataAction)
        Me.GrpGetApplicationData.Controls.Add(Me.lnkManageApplicationData)
        Me.GrpGetApplicationData.Controls.Add(Me.label15)
        Me.GrpGetApplicationData.Controls.Add(Me.CmdPerformWebRequest)
        Me.GrpGetApplicationData.Controls.Add(Me.txtApplicationProfileId)
        Me.GrpGetApplicationData.Location = New System.Drawing.Point(12, 12)
        Me.GrpGetApplicationData.Name = "GrpGetApplicationData"
        Me.GrpGetApplicationData.Size = New System.Drawing.Size(446, 77)
        Me.GrpGetApplicationData.TabIndex = 48
        Me.GrpGetApplicationData.TabStop = false
        Me.GrpGetApplicationData.Text = "Managing Application Configuration Data"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.CboEncryptionType)
        Me.groupBox1.Controls.Add(Me.label14)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.TxtDeviceSerialNumber)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.cmdPopulateTestValues)
        Me.groupBox1.Controls.Add(Me.cboReadCapability)
        Me.groupBox1.Controls.Add(Me.cboPINCapability)
        Me.groupBox1.Controls.Add(Me.txtPTLSSocketId)
        Me.groupBox1.Controls.Add(Me.cboHardwareType)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.cboApplicationLocation)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.cboApplicationAttended)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtVendorId)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtSoftwareVersionDate)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.txtSoftwareVersion)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.txtSerialNumber)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.txtDeveloperId)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.txtApplicationName)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.label13)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Location = New System.Drawing.Point(12, 95)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(446, 432)
        Me.groupBox1.TabIndex = 49
        Me.groupBox1.TabStop = false
        Me.groupBox1.Text = "Application Data"
        '
        'CboEncryptionType
        '
        Me.CboEncryptionType.FormattingEnabled = true
        Me.CboEncryptionType.Location = New System.Drawing.Point(184, 167)
        Me.CboEncryptionType.Name = "CboEncryptionType"
        Me.CboEncryptionType.Size = New System.Drawing.Size(256, 21)
        Me.CboEncryptionType.TabIndex = 49
        '
        'label14
        '
        Me.label14.AutoSize = true
        Me.label14.Location = New System.Drawing.Point(15, 170)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(142, 13)
        Me.label14.TabIndex = 48
        Me.label14.Text = "EncryptionType (Conditional)"
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(15, 144)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(165, 13)
        Me.label1.TabIndex = 46
        Me.label1.Text = "DeviceSerialNumber (Conditional)"
        '
        'TxtDeviceSerialNumber
        '
        Me.TxtDeviceSerialNumber.AcceptsReturn = true
        Me.TxtDeviceSerialNumber.Location = New System.Drawing.Point(184, 141)
        Me.TxtDeviceSerialNumber.Name = "TxtDeviceSerialNumber"
        Me.TxtDeviceSerialNumber.Size = New System.Drawing.Size(256, 20)
        Me.TxtDeviceSerialNumber.TabIndex = 47
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(15, 42)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(154, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "ApplicationAttended (Required)"
        '
        'cmdPopulateTestValues
        '
        Me.cmdPopulateTestValues.Location = New System.Drawing.Point(293, 10)
        Me.cmdPopulateTestValues.Name = "cmdPopulateTestValues"
        Me.cmdPopulateTestValues.Size = New System.Drawing.Size(147, 23)
        Me.cmdPopulateTestValues.TabIndex = 45
        Me.cmdPopulateTestValues.Text = "Populate With Test Values"
        Me.cmdPopulateTestValues.UseVisualStyleBackColor = true
        '
        'cboReadCapability
        '
        Me.cboReadCapability.FormattingEnabled = true
        Me.cboReadCapability.Location = New System.Drawing.Point(184, 301)
        Me.cboReadCapability.Name = "cboReadCapability"
        Me.cboReadCapability.Size = New System.Drawing.Size(256, 21)
        Me.cboReadCapability.TabIndex = 40
        '
        'cboPINCapability
        '
        Me.cboPINCapability.FormattingEnabled = true
        Me.cboPINCapability.Location = New System.Drawing.Point(184, 218)
        Me.cboPINCapability.Name = "cboPINCapability"
        Me.cboPINCapability.Size = New System.Drawing.Size(256, 21)
        Me.cboPINCapability.TabIndex = 38
        '
        'txtPTLSSocketId
        '
        Me.txtPTLSSocketId.Location = New System.Drawing.Point(184, 244)
        Me.txtPTLSSocketId.Multiline = true
        Me.txtPTLSSocketId.Name = "txtPTLSSocketId"
        Me.txtPTLSSocketId.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPTLSSocketId.Size = New System.Drawing.Size(256, 51)
        Me.txtPTLSSocketId.TabIndex = 39
        '
        'cboHardwareType
        '
        Me.cboHardwareType.FormattingEnabled = true
        Me.cboHardwareType.Location = New System.Drawing.Point(184, 192)
        Me.cboHardwareType.Name = "cboHardwareType"
        Me.cboHardwareType.Size = New System.Drawing.Size(256, 21)
        Me.cboHardwareType.TabIndex = 37
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(15, 68)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(152, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "ApplicationLocation (Required)"
        '
        'cboApplicationLocation
        '
        Me.cboApplicationLocation.FormattingEnabled = true
        Me.cboApplicationLocation.Location = New System.Drawing.Point(184, 65)
        Me.cboApplicationLocation.Name = "cboApplicationLocation"
        Me.cboApplicationLocation.Size = New System.Drawing.Size(256, 21)
        Me.cboApplicationLocation.TabIndex = 34
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(15, 94)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(139, 13)
        Me.label4.TabIndex = 11
        Me.label4.Text = "ApplicationName (Required)"
        '
        'cboApplicationAttended
        '
        Me.cboApplicationAttended.FormattingEnabled = true
        Me.cboApplicationAttended.Location = New System.Drawing.Point(184, 39)
        Me.cboApplicationAttended.Name = "cboApplicationAttended"
        Me.cboApplicationAttended.Size = New System.Drawing.Size(256, 21)
        Me.cboApplicationAttended.TabIndex = 33
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(15, 120)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(126, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "DeveloperId (Conditional)"
        '
        'txtVendorId
        '
        Me.txtVendorId.Location = New System.Drawing.Point(184, 405)
        Me.txtVendorId.Name = "txtVendorId"
        Me.txtVendorId.Size = New System.Drawing.Size(256, 20)
        Me.txtVendorId.TabIndex = 44
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(15, 221)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(122, 13)
        Me.label6.TabIndex = 13
        Me.label6.Text = "PINCapability (Required)"
        '
        'txtSoftwareVersionDate
        '
        Me.txtSoftwareVersionDate.Location = New System.Drawing.Point(184, 379)
        Me.txtSoftwareVersionDate.Name = "txtSoftwareVersionDate"
        Me.txtSoftwareVersionDate.Size = New System.Drawing.Size(256, 20)
        Me.txtSoftwareVersionDate.TabIndex = 43
        '
        'label7
        '
        Me.label7.AutoSize = true
        Me.label7.Location = New System.Drawing.Point(15, 195)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(129, 13)
        Me.label7.TabIndex = 14
        Me.label7.Text = "HardwareType (Required)"
        '
        'txtSoftwareVersion
        '
        Me.txtSoftwareVersion.Location = New System.Drawing.Point(184, 353)
        Me.txtSoftwareVersion.Name = "txtSoftwareVersion"
        Me.txtSoftwareVersion.Size = New System.Drawing.Size(256, 20)
        Me.txtSoftwareVersion.TabIndex = 42
        '
        'label8
        '
        Me.label8.AutoSize = true
        Me.label8.Location = New System.Drawing.Point(15, 247)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(129, 13)
        Me.label8.TabIndex = 15
        Me.label8.Text = "PTLSSocketId (Required)"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(184, 327)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(256, 20)
        Me.txtSerialNumber.TabIndex = 41
        '
        'label9
        '
        Me.label9.AutoSize = true
        Me.label9.Location = New System.Drawing.Point(15, 304)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(130, 13)
        Me.label9.TabIndex = 16
        Me.label9.Text = "ReadCapability (Required)"
        '
        'txtDeveloperId
        '
        Me.txtDeveloperId.Location = New System.Drawing.Point(184, 117)
        Me.txtDeveloperId.Name = "txtDeveloperId"
        Me.txtDeveloperId.Size = New System.Drawing.Size(256, 20)
        Me.txtDeveloperId.TabIndex = 36
        '
        'label10
        '
        Me.label10.AutoSize = true
        Me.label10.Location = New System.Drawing.Point(15, 330)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(122, 13)
        Me.label10.TabIndex = 17
        Me.label10.Text = "SerialNumber (Required)"
        '
        'txtApplicationName
        '
        Me.txtApplicationName.Location = New System.Drawing.Point(184, 91)
        Me.txtApplicationName.Name = "txtApplicationName"
        Me.txtApplicationName.Size = New System.Drawing.Size(256, 20)
        Me.txtApplicationName.TabIndex = 35
        '
        'label11
        '
        Me.label11.AutoSize = true
        Me.label11.Location = New System.Drawing.Point(15, 356)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(136, 13)
        Me.label11.TabIndex = 18
        Me.label11.Text = "SoftwareVersion (Required)"
        '
        'label13
        '
        Me.label13.AutoSize = true
        Me.label13.Location = New System.Drawing.Point(15, 408)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(111, 13)
        Me.label13.TabIndex = 20
        Me.label13.Text = "VendorId (Conditional)"
        '
        'label12
        '
        Me.label12.AutoSize = true
        Me.label12.Location = New System.Drawing.Point(15, 382)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(159, 13)
        Me.label12.TabIndex = 19
        Me.label12.Text = "SoftwareVersionDate (Required)"
        '
        'ManageApplicationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 561)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.GrpGetApplicationData)
        Me.Controls.Add(Me.cmdClose)
        Me.Name = "ManageApplicationData"
        Me.Text = "Manage Application Configuration Data - CWS 1.17.18"
        Me.GrpGetApplicationData.ResumeLayout(false)
        Me.GrpGetApplicationData.PerformLayout
        Me.groupBox1.ResumeLayout(false)
        Me.groupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub

#End Region

        Private WithEvents cmdClose As System.Windows.Forms.Button
        Private WithEvents cboApplicationDataAction As System.Windows.Forms.ComboBox
        Private WithEvents lnkManageApplicationData As System.Windows.Forms.LinkLabel
        Private WithEvents label15 As System.Windows.Forms.Label
        Private WithEvents CmdPerformWebRequest As System.Windows.Forms.Button
        Private WithEvents txtApplicationProfileId As System.Windows.Forms.TextBox
        Private WithEvents GrpGetApplicationData As System.Windows.Forms.GroupBox
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents CboEncryptionType As System.Windows.Forms.ComboBox
        Private WithEvents label14 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents TxtDeviceSerialNumber As System.Windows.Forms.TextBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents cmdPopulateTestValues As System.Windows.Forms.Button
        Private WithEvents cboReadCapability As System.Windows.Forms.ComboBox
        Private WithEvents cboPINCapability As System.Windows.Forms.ComboBox
        Private WithEvents txtPTLSSocketId As System.Windows.Forms.TextBox
        Private WithEvents cboHardwareType As System.Windows.Forms.ComboBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents cboApplicationLocation As System.Windows.Forms.ComboBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents cboApplicationAttended As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents txtVendorId As System.Windows.Forms.TextBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents txtSoftwareVersionDate As System.Windows.Forms.TextBox
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents txtSoftwareVersion As System.Windows.Forms.TextBox
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents txtSerialNumber As System.Windows.Forms.TextBox
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents txtDeveloperId As System.Windows.Forms.TextBox
        Private WithEvents label10 As System.Windows.Forms.Label
        Private WithEvents txtApplicationName As System.Windows.Forms.TextBox
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents label13 As System.Windows.Forms.Label
        Private WithEvents label12 As System.Windows.Forms.Label
    End Class
End Namespace
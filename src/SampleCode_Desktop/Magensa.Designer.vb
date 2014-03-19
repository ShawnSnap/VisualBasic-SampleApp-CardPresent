Namespace SampleCode
    Partial Class Magensa
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Magensa))
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.TxtTrackInformation = New System.Windows.Forms.TextBox()
            Me.lnkManageAccountById = New System.Windows.Forms.LinkLabel()
            Me.label12 = New System.Windows.Forms.Label()
            Me.TxtDeviceSerialNumber = New System.Windows.Forms.TextBox()
            Me.label11 = New System.Windows.Forms.Label()
            Me.TxtScoreThreshold = New System.Windows.Forms.TextBox()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.TxtMaskedPAN = New System.Windows.Forms.TextBox()
            Me.CboMagensaCardType = New System.Windows.Forms.ComboBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.TxtTrack2Masked = New System.Windows.Forms.TextBox()
            Me.ChkPipeDelimited = New System.Windows.Forms.CheckBox()
            Me.CboTriggerTests = New System.Windows.Forms.ComboBox()
            Me.CmdClose = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.CmdGenerateFields = New System.Windows.Forms.Button()
            Me.label5 = New System.Windows.Forms.Label()
            Me.TxtMagnePrintData = New System.Windows.Forms.TextBox()
            Me.TxtDukptKeySerialNumber = New System.Windows.Forms.TextBox()
            Me.TxtTrack2EncryptedData = New System.Windows.Forms.TextBox()
            Me.TxtMagnePrintStatus = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.CmdPopulateWithTestValues = New System.Windows.Forms.Button()
            Me.TxtAmount = New System.Windows.Forms.TextBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.CmdProcessMagensaTxn = New System.Windows.Forms.Button()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'linkLabel1
            '
            Me.linkLabel1.AutoSize = True
            Me.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.linkLabel1.Image = CType(resources.GetObject("linkLabel1.Image"), System.Drawing.Image)
            Me.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.linkLabel1.Location = New System.Drawing.Point(215, 251)
            Me.linkLabel1.Margin = New System.Windows.Forms.Padding(0)
            Me.linkLabel1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(20, 20)
            Me.linkLabel1.TabIndex = 148
            Me.linkLabel1.Tag = ""
            Me.toolTip1.SetToolTip(Me.linkLabel1, "Click Here to view more information")
            '
            'TxtTrackInformation
            '
            Me.TxtTrackInformation.AcceptsReturn = True
            Me.TxtTrackInformation.Location = New System.Drawing.Point(12, 37)
            Me.TxtTrackInformation.MaxLength = 0
            Me.TxtTrackInformation.Multiline = True
            Me.TxtTrackInformation.Name = "TxtTrackInformation"
            Me.TxtTrackInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.TxtTrackInformation.Size = New System.Drawing.Size(597, 141)
            Me.TxtTrackInformation.TabIndex = 135
            Me.toolTip1.SetToolTip(Me.TxtTrackInformation, "Depending on your MagTek output please check or uncheck the above checkbox.  Once" & _
            " you have pasted your MagTek read please click the Generate Fields From Track bu" & _
            "tton.")
            '
            'lnkManageAccountById
            '
            Me.lnkManageAccountById.AutoSize = True
            Me.lnkManageAccountById.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkManageAccountById.Image = CType(resources.GetObject("lnkManageAccountById.Image"), System.Drawing.Image)
            Me.lnkManageAccountById.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkManageAccountById.Location = New System.Drawing.Point(182, 14)
            Me.lnkManageAccountById.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkManageAccountById.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkManageAccountById.Name = "lnkManageAccountById"
            Me.lnkManageAccountById.Size = New System.Drawing.Size(20, 20)
            Me.lnkManageAccountById.TabIndex = 145
            Me.lnkManageAccountById.Tag = ""
            Me.toolTip1.SetToolTip(Me.lnkManageAccountById, "Click Here to view more information")
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(10, 228)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(110, 13)
            Me.label12.TabIndex = 149
            Me.label12.Text = "Device Serial Number"
            '
            'TxtDeviceSerialNumber
            '
            Me.TxtDeviceSerialNumber.Location = New System.Drawing.Point(152, 225)
            Me.TxtDeviceSerialNumber.Name = "TxtDeviceSerialNumber"
            Me.TxtDeviceSerialNumber.Size = New System.Drawing.Size(155, 20)
            Me.TxtDeviceSerialNumber.TabIndex = 150
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(10, 254)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(109, 13)
            Me.label11.TabIndex = 146
            Me.label11.Text = "Score Threshold (0-1)"
            '
            'TxtScoreThreshold
            '
            Me.TxtScoreThreshold.Location = New System.Drawing.Point(152, 251)
            Me.TxtScoreThreshold.Name = "TxtScoreThreshold"
            Me.TxtScoreThreshold.Size = New System.Drawing.Size(60, 20)
            Me.TxtScoreThreshold.TabIndex = 147
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(10, 174)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(53, 13)
            Me.label9.TabIndex = 142
            Me.label9.Text = "CardType"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(10, 201)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(70, 13)
            Me.label10.TabIndex = 144
            Me.label10.Text = "Masked PAN"
            '
            'TxtMaskedPAN
            '
            Me.TxtMaskedPAN.Location = New System.Drawing.Point(152, 198)
            Me.TxtMaskedPAN.Name = "TxtMaskedPAN"
            Me.TxtMaskedPAN.Size = New System.Drawing.Size(155, 20)
            Me.TxtMaskedPAN.TabIndex = 145
            '
            'CboMagensaCardType
            '
            Me.CboMagensaCardType.FormattingEnabled = True
            Me.CboMagensaCardType.Location = New System.Drawing.Point(152, 171)
            Me.CboMagensaCardType.Name = "CboMagensaCardType"
            Me.CboMagensaCardType.Size = New System.Drawing.Size(155, 21)
            Me.CboMagensaCardType.TabIndex = 143
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(10, 148)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(85, 13)
            Me.label8.TabIndex = 140
            Me.label8.Text = "Track 2 Masked"
            '
            'TxtTrack2Masked
            '
            Me.TxtTrack2Masked.Location = New System.Drawing.Point(152, 145)
            Me.TxtTrack2Masked.Name = "TxtTrack2Masked"
            Me.TxtTrack2Masked.Size = New System.Drawing.Size(261, 20)
            Me.TxtTrack2Masked.TabIndex = 141
            '
            'ChkPipeDelimited
            '
            Me.ChkPipeDelimited.AutoSize = True
            Me.ChkPipeDelimited.Checked = True
            Me.ChkPipeDelimited.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ChkPipeDelimited.Location = New System.Drawing.Point(230, 19)
            Me.ChkPipeDelimited.Name = "ChkPipeDelimited"
            Me.ChkPipeDelimited.Size = New System.Drawing.Size(175, 17)
            Me.ChkPipeDelimited.TabIndex = 146
            Me.ChkPipeDelimited.Text = "MagTek Read is Pipe Delimited"
            Me.ChkPipeDelimited.UseVisualStyleBackColor = True
            '
            'CboTriggerTests
            '
            Me.CboTriggerTests.FormattingEnabled = True
            Me.CboTriggerTests.Location = New System.Drawing.Point(164, 517)
            Me.CboTriggerTests.Name = "CboTriggerTests"
            Me.CboTriggerTests.Size = New System.Drawing.Size(439, 21)
            Me.CboTriggerTests.TabIndex = 141
            '
            'CmdClose
            '
            Me.CmdClose.Location = New System.Drawing.Point(534, 582)
            Me.CmdClose.Name = "CmdClose"
            Me.CmdClose.Size = New System.Drawing.Size(75, 23)
            Me.CmdClose.TabIndex = 144
            Me.CmdClose.Text = "Close"
            Me.CmdClose.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label12)
            Me.groupBox1.Controls.Add(Me.TxtDeviceSerialNumber)
            Me.groupBox1.Controls.Add(Me.linkLabel1)
            Me.groupBox1.Controls.Add(Me.label11)
            Me.groupBox1.Controls.Add(Me.TxtScoreThreshold)
            Me.groupBox1.Controls.Add(Me.label9)
            Me.groupBox1.Controls.Add(Me.label10)
            Me.groupBox1.Controls.Add(Me.TxtMaskedPAN)
            Me.groupBox1.Controls.Add(Me.CboMagensaCardType)
            Me.groupBox1.Controls.Add(Me.label8)
            Me.groupBox1.Controls.Add(Me.TxtTrack2Masked)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.CmdGenerateFields)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.TxtMagnePrintData)
            Me.groupBox1.Controls.Add(Me.TxtDukptKeySerialNumber)
            Me.groupBox1.Controls.Add(Me.TxtTrack2EncryptedData)
            Me.groupBox1.Controls.Add(Me.TxtMagnePrintStatus)
            Me.groupBox1.Location = New System.Drawing.Point(12, 195)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(597, 316)
            Me.groupBox1.TabIndex = 143
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Obtain values from swipe above"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(10, 44)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(85, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "MagnePrint data"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(10, 70)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(134, 13)
            Me.label3.TabIndex = 3
            Me.label3.Text = "DUKPT Key Serial Number"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(10, 96)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(118, 13)
            Me.label4.TabIndex = 4
            Me.label4.Text = "Track 2 encrypted data"
            '
            'CmdGenerateFields
            '
            Me.CmdGenerateFields.Location = New System.Drawing.Point(431, 12)
            Me.CmdGenerateFields.Name = "CmdGenerateFields"
            Me.CmdGenerateFields.Size = New System.Drawing.Size(160, 23)
            Me.CmdGenerateFields.TabIndex = 10
            Me.CmdGenerateFields.Text = "Generate Fields From Track Data"
            Me.CmdGenerateFields.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(10, 122)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(94, 13)
            Me.label5.TabIndex = 5
            Me.label5.Text = "MagnePrint Status"
            '
            'TxtMagnePrintData
            '
            Me.TxtMagnePrintData.Location = New System.Drawing.Point(152, 41)
            Me.TxtMagnePrintData.Name = "TxtMagnePrintData"
            Me.TxtMagnePrintData.Size = New System.Drawing.Size(439, 20)
            Me.TxtMagnePrintData.TabIndex = 6
            '
            'TxtDukptKeySerialNumber
            '
            Me.TxtDukptKeySerialNumber.Location = New System.Drawing.Point(152, 67)
            Me.TxtDukptKeySerialNumber.Name = "TxtDukptKeySerialNumber"
            Me.TxtDukptKeySerialNumber.Size = New System.Drawing.Size(439, 20)
            Me.TxtDukptKeySerialNumber.TabIndex = 7
            '
            'TxtTrack2EncryptedData
            '
            Me.TxtTrack2EncryptedData.Location = New System.Drawing.Point(152, 93)
            Me.TxtTrack2EncryptedData.Name = "TxtTrack2EncryptedData"
            Me.TxtTrack2EncryptedData.Size = New System.Drawing.Size(439, 20)
            Me.TxtTrack2EncryptedData.TabIndex = 8
            '
            'TxtMagnePrintStatus
            '
            Me.TxtMagnePrintStatus.Location = New System.Drawing.Point(152, 119)
            Me.TxtMagnePrintStatus.Name = "TxtMagnePrintStatus"
            Me.TxtMagnePrintStatus.Size = New System.Drawing.Size(439, 20)
            Me.TxtMagnePrintStatus.TabIndex = 9
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 19)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(167, 13)
            Me.label1.TabIndex = 136
            Me.label1.Text = "Track Data from USB MSR Demo"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(22, 520)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(65, 13)
            Me.label7.TabIndex = 140
            Me.label7.Text = "Trigger tests"
            '
            'CmdPopulateWithTestValues
            '
            Me.CmdPopulateWithTestValues.Location = New System.Drawing.Point(443, 8)
            Me.CmdPopulateWithTestValues.Name = "CmdPopulateWithTestValues"
            Me.CmdPopulateWithTestValues.Size = New System.Drawing.Size(160, 23)
            Me.CmdPopulateWithTestValues.TabIndex = 142
            Me.CmdPopulateWithTestValues.Text = "Populate with test values"
            Me.CmdPopulateWithTestValues.UseVisualStyleBackColor = True
            '
            'TxtAmount
            '
            Me.TxtAmount.Location = New System.Drawing.Point(164, 544)
            Me.TxtAmount.Name = "TxtAmount"
            Me.TxtAmount.Size = New System.Drawing.Size(60, 20)
            Me.TxtAmount.TabIndex = 139
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(22, 547)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(43, 13)
            Me.label6.TabIndex = 138
            Me.label6.Text = "Amount"
            '
            'CmdProcessMagensaTxn
            '
            Me.CmdProcessMagensaTxn.Location = New System.Drawing.Point(164, 573)
            Me.CmdProcessMagensaTxn.Name = "CmdProcessMagensaTxn"
            Me.CmdProcessMagensaTxn.Size = New System.Drawing.Size(160, 23)
            Me.CmdProcessMagensaTxn.TabIndex = 137
            Me.CmdProcessMagensaTxn.Text = "Process Magensa Transaction"
            Me.CmdProcessMagensaTxn.UseVisualStyleBackColor = True
            '
            'Magensa
            '
            Me.ClientSize = New System.Drawing.Size(616, 610)
            Me.Controls.Add(Me.ChkPipeDelimited)
            Me.Controls.Add(Me.CboTriggerTests)
            Me.Controls.Add(Me.CmdClose)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.TxtTrackInformation)
            Me.Controls.Add(Me.lnkManageAccountById)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.CmdPopulateWithTestValues)
            Me.Controls.Add(Me.TxtAmount)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.CmdProcessMagensaTxn)
            Me.Name = "Magensa"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region ' Windows Form Designer generated code

        Private WithEvents CmdProcessMagensaTxn As System.Windows.Forms.Button
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents TxtAmount As System.Windows.Forms.TextBox
        Private WithEvents CmdPopulateWithTestValues As System.Windows.Forms.Button
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents TxtMagnePrintStatus As System.Windows.Forms.TextBox
        Private WithEvents TxtTrack2EncryptedData As System.Windows.Forms.TextBox
        Private WithEvents TxtDukptKeySerialNumber As System.Windows.Forms.TextBox
        Private WithEvents TxtMagnePrintData As System.Windows.Forms.TextBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents CmdGenerateFields As System.Windows.Forms.Button
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents CmdClose As System.Windows.Forms.Button
        Private WithEvents CboTriggerTests As System.Windows.Forms.ComboBox
        Private WithEvents ChkPipeDelimited As System.Windows.Forms.CheckBox
        Private WithEvents TxtTrack2Masked As System.Windows.Forms.TextBox
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents CboMagensaCardType As System.Windows.Forms.ComboBox
        Private WithEvents TxtMaskedPAN As System.Windows.Forms.TextBox
        Private WithEvents label10 As System.Windows.Forms.Label
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents TxtScoreThreshold As System.Windows.Forms.TextBox
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents TxtDeviceSerialNumber As System.Windows.Forms.TextBox
        Private WithEvents label12 As System.Windows.Forms.Label
        Private WithEvents lnkManageAccountById As System.Windows.Forms.LinkLabel
        Private WithEvents TxtTrackInformation As System.Windows.Forms.TextBox
        Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    End Class
End Namespace
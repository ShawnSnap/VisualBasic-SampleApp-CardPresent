Namespace SampleCode
    Partial Class ManageMerchantProfile
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageMerchantProfile))
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.cboMerchantDataAction = New System.Windows.Forms.ComboBox()
            Me.ChkEnableAllMerchantFields = New System.Windows.Forms.CheckBox()
            Me.txtCustomerServiceInternet = New System.Windows.Forms.TextBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.cboAvailableProfiles = New System.Windows.Forms.ComboBox()
            Me.label13 = New System.Windows.Forms.Label()
            Me.txtPhone = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.txtCustomerServicePhone = New System.Windows.Forms.TextBox()
            Me.cboCountryCode = New System.Windows.Forms.ComboBox()
            Me.lnkManageMerchantData = New System.Windows.Forms.LinkLabel()
            Me.CmdPerformWebRequest = New System.Windows.Forms.Button()
            Me.txtPostalCode = New System.Windows.Forms.TextBox()
            Me.txtMerchantProfileServiceId = New System.Windows.Forms.TextBox()
            Me.label33 = New System.Windows.Forms.Label()
            Me.cmdPopulateTestValues = New System.Windows.Forms.Button()
            Me.label20 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.txtStreetAddress1 = New System.Windows.Forms.TextBox()
            Me.txtStreetAddress2 = New System.Windows.Forms.TextBox()
            Me.txtCity = New System.Windows.Forms.TextBox()
            Me.txtStateProvince = New System.Windows.Forms.TextBox()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.tbMerchantInformation = New System.Windows.Forms.TabControl()
            Me.tbMerchantContactData = New System.Windows.Forms.TabPage()
            Me.tbMerchantAccountData = New System.Windows.Forms.TabPage()
            Me.lblMerchantId = New System.Windows.Forms.Label()
            Me.txtClientNum = New System.Windows.Forms.TextBox()
            Me.label12 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.txtSocketNum = New System.Windows.Forms.TextBox()
            Me.txtSIC = New System.Windows.Forms.TextBox()
            Me.lblTerminalId = New System.Windows.Forms.Label()
            Me.label15 = New System.Windows.Forms.Label()
            Me.txtMerchantId = New System.Windows.Forms.TextBox()
            Me.txtTaxId = New System.Windows.Forms.TextBox()
            Me.txtSharingGroup = New System.Windows.Forms.TextBox()
            Me.txtSettlementAgent = New System.Windows.Forms.TextBox()
            Me.txtABANumber = New System.Windows.Forms.TextBox()
            Me.label32 = New System.Windows.Forms.Label()
            Me.label31 = New System.Windows.Forms.Label()
            Me.label30 = New System.Windows.Forms.Label()
            Me.txtReimbursementAttribute = New System.Windows.Forms.TextBox()
            Me.txtTimeZoneDifferential = New System.Windows.Forms.TextBox()
            Me.txtStoreId = New System.Windows.Forms.TextBox()
            Me.txtSecondaryTerminalId = New System.Windows.Forms.TextBox()
            Me.lblStoreId = New System.Windows.Forms.Label()
            Me.txtLocation = New System.Windows.Forms.TextBox()
            Me.txtAgentChain = New System.Windows.Forms.TextBox()
            Me.txtAgentBank = New System.Windows.Forms.TextBox()
            Me.txtAcquirerBIN = New System.Windows.Forms.TextBox()
            Me.label28 = New System.Windows.Forms.Label()
            Me.label27 = New System.Windows.Forms.Label()
            Me.label26 = New System.Windows.Forms.Label()
            Me.label25 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.label23 = New System.Windows.Forms.Label()
            Me.label22 = New System.Windows.Forms.Label()
            Me.tbMerchantDataTxnDefaults = New System.Windows.Forms.TabPage()
            Me.cboEntryMode = New System.Windows.Forms.ComboBox()
            Me.label34 = New System.Windows.Forms.Label()
            Me.cboRequestACI = New System.Windows.Forms.ComboBox()
            Me.label21 = New System.Windows.Forms.Label()
            Me.cboMerchantIndustryType = New System.Windows.Forms.ComboBox()
            Me.label29 = New System.Windows.Forms.Label()
            Me.cboCustomerPresent = New System.Windows.Forms.ComboBox()
            Me.label18 = New System.Windows.Forms.Label()
            Me.cboCurrencyCode = New System.Windows.Forms.ComboBox()
            Me.label17 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.cboLanguage = New System.Windows.Forms.ComboBox()
            Me.lblLastUpdated = New System.Windows.Forms.Label()
            Me.cmdClose = New System.Windows.Forms.Button()
            Me.tbMerchantInformation.SuspendLayout()
            Me.tbMerchantContactData.SuspendLayout()
            Me.tbMerchantAccountData.SuspendLayout()
            Me.tbMerchantDataTxnDefaults.SuspendLayout()
            Me.SuspendLayout()
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(6, 40)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(85, 13)
            Me.label2.TabIndex = 0
            Me.label2.Text = "Street Address 1"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(6, 66)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(85, 13)
            Me.label3.TabIndex = 1
            Me.label3.Text = "Street Address 2"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(6, 92)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(24, 13)
            Me.label4.TabIndex = 2
            Me.label4.Text = "City"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(6, 118)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(77, 13)
            Me.label5.TabIndex = 3
            Me.label5.Text = "State Province"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(6, 144)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(64, 13)
            Me.label6.TabIndex = 4
            Me.label6.Text = "Postal Code"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(6, 170)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(71, 13)
            Me.label7.TabIndex = 5
            Me.label7.Text = "Country Code"
            '
            'cboMerchantDataAction
            '
            Me.cboMerchantDataAction.FormattingEnabled = True
            Me.cboMerchantDataAction.Location = New System.Drawing.Point(12, 12)
            Me.cboMerchantDataAction.Name = "cboMerchantDataAction"
            Me.cboMerchantDataAction.Size = New System.Drawing.Size(286, 21)
            Me.cboMerchantDataAction.TabIndex = 160
            '
            'ChkEnableAllMerchantFields
            '
            Me.ChkEnableAllMerchantFields.AutoSize = True
            Me.ChkEnableAllMerchantFields.Location = New System.Drawing.Point(147, 112)
            Me.ChkEnableAllMerchantFields.Name = "ChkEnableAllMerchantFields"
            Me.ChkEnableAllMerchantFields.Size = New System.Drawing.Size(102, 17)
            Me.ChkEnableAllMerchantFields.TabIndex = 158
            Me.ChkEnableAllMerchantFields.Text = "Enable all Fields"
            Me.ChkEnableAllMerchantFields.UseVisualStyleBackColor = True
            '
            'txtCustomerServiceInternet
            '
            Me.txtCustomerServiceInternet.Location = New System.Drawing.Point(157, 245)
            Me.txtCustomerServiceInternet.Name = "txtCustomerServiceInternet"
            Me.txtCustomerServiceInternet.Size = New System.Drawing.Size(267, 20)
            Me.txtCustomerServiceInternet.TabIndex = 9
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(11, 82)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(93, 13)
            Me.label10.TabIndex = 162
            Me.label10.Text = "Available Profile(s)"
            '
            'cboAvailableProfiles
            '
            Me.cboAvailableProfiles.FormattingEnabled = True
            Me.cboAvailableProfiles.Location = New System.Drawing.Point(109, 79)
            Me.cboAvailableProfiles.Name = "cboAvailableProfiles"
            Me.cboAvailableProfiles.Size = New System.Drawing.Size(189, 21)
            Me.cboAvailableProfiles.TabIndex = 161
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(6, 221)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(38, 13)
            Me.label13.TabIndex = 11
            Me.label13.Text = "Phone"
            '
            'txtPhone
            '
            Me.txtPhone.Location = New System.Drawing.Point(137, 218)
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.Size = New System.Drawing.Size(287, 20)
            Me.txtPhone.TabIndex = 8
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.DarkOrange
            Me.label1.Location = New System.Drawing.Point(11, 63)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(379, 13)
            Me.label1.TabIndex = 163
            Me.label1.Text = "Note : To add a new profile, type the Merchant ProfileId in the dropdown below"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(6, 196)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(124, 13)
            Me.label8.TabIndex = 6
            Me.label8.Text = "Customer Service Phone"
            '
            'txtCustomerServicePhone
            '
            Me.txtCustomerServicePhone.Location = New System.Drawing.Point(137, 189)
            Me.txtCustomerServicePhone.Name = "txtCustomerServicePhone"
            Me.txtCustomerServicePhone.Size = New System.Drawing.Size(287, 20)
            Me.txtCustomerServicePhone.TabIndex = 7
            '
            'cboCountryCode
            '
            Me.cboCountryCode.FormattingEnabled = True
            Me.cboCountryCode.Location = New System.Drawing.Point(137, 162)
            Me.cboCountryCode.Name = "cboCountryCode"
            Me.cboCountryCode.Size = New System.Drawing.Size(287, 21)
            Me.cboCountryCode.TabIndex = 6
            '
            'lnkManageMerchantData
            '
            Me.lnkManageMerchantData.AutoSize = True
            Me.lnkManageMerchantData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkManageMerchantData.Image = CType(resources.GetObject("lnkManageMerchantData.Image"), System.Drawing.Image)
            Me.lnkManageMerchantData.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkManageMerchantData.Location = New System.Drawing.Point(426, 42)
            Me.lnkManageMerchantData.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkManageMerchantData.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkManageMerchantData.Name = "lnkManageMerchantData"
            Me.lnkManageMerchantData.Size = New System.Drawing.Size(20, 20)
            Me.lnkManageMerchantData.TabIndex = 164
            Me.lnkManageMerchantData.Tag = ""
            '
            'CmdPerformWebRequest
            '
            Me.CmdPerformWebRequest.Location = New System.Drawing.Point(304, 10)
            Me.CmdPerformWebRequest.Name = "CmdPerformWebRequest"
            Me.CmdPerformWebRequest.Size = New System.Drawing.Size(142, 23)
            Me.CmdPerformWebRequest.TabIndex = 159
            Me.CmdPerformWebRequest.Text = "Perform Web Request"
            Me.CmdPerformWebRequest.UseVisualStyleBackColor = True
            '
            'txtPostalCode
            '
            Me.txtPostalCode.Location = New System.Drawing.Point(137, 137)
            Me.txtPostalCode.Name = "txtPostalCode"
            Me.txtPostalCode.Size = New System.Drawing.Size(287, 20)
            Me.txtPostalCode.TabIndex = 5
            '
            'txtMerchantProfileServiceId
            '
            Me.txtMerchantProfileServiceId.Location = New System.Drawing.Point(111, 39)
            Me.txtMerchantProfileServiceId.Name = "txtMerchantProfileServiceId"
            Me.txtMerchantProfileServiceId.ReadOnly = True
            Me.txtMerchantProfileServiceId.Size = New System.Drawing.Size(187, 20)
            Me.txtMerchantProfileServiceId.TabIndex = 157
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Location = New System.Drawing.Point(16, 42)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(52, 13)
            Me.label33.TabIndex = 156
            Me.label33.Text = "ServiceId"
            '
            'cmdPopulateTestValues
            '
            Me.cmdPopulateTestValues.Location = New System.Drawing.Point(302, 106)
            Me.cmdPopulateTestValues.Name = "cmdPopulateTestValues"
            Me.cmdPopulateTestValues.Size = New System.Drawing.Size(142, 23)
            Me.cmdPopulateTestValues.TabIndex = 155
            Me.cmdPopulateTestValues.Text = "Populate With Test Values"
            Me.cmdPopulateTestValues.UseVisualStyleBackColor = True
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Location = New System.Drawing.Point(6, 248)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(145, 13)
            Me.label20.TabIndex = 41
            Me.label20.Text = "Customer Service Email/URL"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(6, 10)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(83, 13)
            Me.label11.TabIndex = 9
            Me.label11.Text = "Merchant Name"
            '
            'txtStreetAddress1
            '
            Me.txtStreetAddress1.Location = New System.Drawing.Point(137, 33)
            Me.txtStreetAddress1.Name = "txtStreetAddress1"
            Me.txtStreetAddress1.Size = New System.Drawing.Size(287, 20)
            Me.txtStreetAddress1.TabIndex = 1
            '
            'txtStreetAddress2
            '
            Me.txtStreetAddress2.Location = New System.Drawing.Point(137, 59)
            Me.txtStreetAddress2.Name = "txtStreetAddress2"
            Me.txtStreetAddress2.Size = New System.Drawing.Size(287, 20)
            Me.txtStreetAddress2.TabIndex = 2
            '
            'txtCity
            '
            Me.txtCity.Location = New System.Drawing.Point(137, 85)
            Me.txtCity.Name = "txtCity"
            Me.txtCity.Size = New System.Drawing.Size(287, 20)
            Me.txtCity.TabIndex = 3
            '
            'txtStateProvince
            '
            Me.txtStateProvince.Location = New System.Drawing.Point(137, 111)
            Me.txtStateProvince.Name = "txtStateProvince"
            Me.txtStateProvince.Size = New System.Drawing.Size(287, 20)
            Me.txtStateProvince.TabIndex = 4
            '
            'txtName
            '
            Me.txtName.Location = New System.Drawing.Point(137, 7)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(287, 20)
            Me.txtName.TabIndex = 0
            '
            'tbMerchantInformation
            '
            Me.tbMerchantInformation.Controls.Add(Me.tbMerchantContactData)
            Me.tbMerchantInformation.Controls.Add(Me.tbMerchantAccountData)
            Me.tbMerchantInformation.Controls.Add(Me.tbMerchantDataTxnDefaults)
            Me.tbMerchantInformation.Location = New System.Drawing.Point(9, 135)
            Me.tbMerchantInformation.Name = "tbMerchantInformation"
            Me.tbMerchantInformation.SelectedIndex = 0
            Me.tbMerchantInformation.ShowToolTips = True
            Me.tbMerchantInformation.Size = New System.Drawing.Size(435, 461)
            Me.tbMerchantInformation.TabIndex = 154
            '
            'tbMerchantContactData
            '
            Me.tbMerchantContactData.Controls.Add(Me.label2)
            Me.tbMerchantContactData.Controls.Add(Me.label3)
            Me.tbMerchantContactData.Controls.Add(Me.label4)
            Me.tbMerchantContactData.Controls.Add(Me.label5)
            Me.tbMerchantContactData.Controls.Add(Me.label6)
            Me.tbMerchantContactData.Controls.Add(Me.label7)
            Me.tbMerchantContactData.Controls.Add(Me.txtCustomerServiceInternet)
            Me.tbMerchantContactData.Controls.Add(Me.label8)
            Me.tbMerchantContactData.Controls.Add(Me.label20)
            Me.tbMerchantContactData.Controls.Add(Me.label11)
            Me.tbMerchantContactData.Controls.Add(Me.label13)
            Me.tbMerchantContactData.Controls.Add(Me.txtStreetAddress1)
            Me.tbMerchantContactData.Controls.Add(Me.txtStreetAddress2)
            Me.tbMerchantContactData.Controls.Add(Me.txtCity)
            Me.tbMerchantContactData.Controls.Add(Me.txtStateProvince)
            Me.tbMerchantContactData.Controls.Add(Me.txtPostalCode)
            Me.tbMerchantContactData.Controls.Add(Me.txtCustomerServicePhone)
            Me.tbMerchantContactData.Controls.Add(Me.cboCountryCode)
            Me.tbMerchantContactData.Controls.Add(Me.txtName)
            Me.tbMerchantContactData.Controls.Add(Me.txtPhone)
            Me.tbMerchantContactData.Location = New System.Drawing.Point(4, 22)
            Me.tbMerchantContactData.Name = "tbMerchantContactData"
            Me.tbMerchantContactData.Padding = New System.Windows.Forms.Padding(3)
            Me.tbMerchantContactData.Size = New System.Drawing.Size(427, 435)
            Me.tbMerchantContactData.TabIndex = 0
            Me.tbMerchantContactData.Text = "Merchant Contact Data"
            Me.tbMerchantContactData.UseVisualStyleBackColor = True
            '
            'tbMerchantAccountData
            '
            Me.tbMerchantAccountData.Controls.Add(Me.lblMerchantId)
            Me.tbMerchantAccountData.Controls.Add(Me.txtClientNum)
            Me.tbMerchantAccountData.Controls.Add(Me.label12)
            Me.tbMerchantAccountData.Controls.Add(Me.label14)
            Me.tbMerchantAccountData.Controls.Add(Me.txtSocketNum)
            Me.tbMerchantAccountData.Controls.Add(Me.txtSIC)
            Me.tbMerchantAccountData.Controls.Add(Me.lblTerminalId)
            Me.tbMerchantAccountData.Controls.Add(Me.label15)
            Me.tbMerchantAccountData.Controls.Add(Me.txtMerchantId)
            Me.tbMerchantAccountData.Controls.Add(Me.txtTaxId)
            Me.tbMerchantAccountData.Controls.Add(Me.txtSharingGroup)
            Me.tbMerchantAccountData.Controls.Add(Me.txtSettlementAgent)
            Me.tbMerchantAccountData.Controls.Add(Me.txtABANumber)
            Me.tbMerchantAccountData.Controls.Add(Me.label32)
            Me.tbMerchantAccountData.Controls.Add(Me.label31)
            Me.tbMerchantAccountData.Controls.Add(Me.label30)
            Me.tbMerchantAccountData.Controls.Add(Me.txtReimbursementAttribute)
            Me.tbMerchantAccountData.Controls.Add(Me.txtTimeZoneDifferential)
            Me.tbMerchantAccountData.Controls.Add(Me.txtStoreId)
            Me.tbMerchantAccountData.Controls.Add(Me.txtSecondaryTerminalId)
            Me.tbMerchantAccountData.Controls.Add(Me.lblStoreId)
            Me.tbMerchantAccountData.Controls.Add(Me.txtLocation)
            Me.tbMerchantAccountData.Controls.Add(Me.txtAgentChain)
            Me.tbMerchantAccountData.Controls.Add(Me.txtAgentBank)
            Me.tbMerchantAccountData.Controls.Add(Me.txtAcquirerBIN)
            Me.tbMerchantAccountData.Controls.Add(Me.label28)
            Me.tbMerchantAccountData.Controls.Add(Me.label27)
            Me.tbMerchantAccountData.Controls.Add(Me.label26)
            Me.tbMerchantAccountData.Controls.Add(Me.label25)
            Me.tbMerchantAccountData.Controls.Add(Me.label24)
            Me.tbMerchantAccountData.Controls.Add(Me.label23)
            Me.tbMerchantAccountData.Controls.Add(Me.label22)
            Me.tbMerchantAccountData.Location = New System.Drawing.Point(4, 22)
            Me.tbMerchantAccountData.Name = "tbMerchantAccountData"
            Me.tbMerchantAccountData.Padding = New System.Windows.Forms.Padding(3)
            Me.tbMerchantAccountData.Size = New System.Drawing.Size(427, 435)
            Me.tbMerchantAccountData.TabIndex = 1
            Me.tbMerchantAccountData.Text = "Merchant Account Data"
            Me.tbMerchantAccountData.UseVisualStyleBackColor = True
            '
            'lblMerchantId
            '
            Me.lblMerchantId.AutoSize = True
            Me.lblMerchantId.Location = New System.Drawing.Point(14, 14)
            Me.lblMerchantId.Name = "lblMerchantId"
            Me.lblMerchantId.Size = New System.Drawing.Size(64, 13)
            Me.lblMerchantId.TabIndex = 54
            Me.lblMerchantId.Text = "Merchant Id"
            '
            'txtClientNum
            '
            Me.txtClientNum.Location = New System.Drawing.Point(142, 138)
            Me.txtClientNum.Name = "txtClientNum"
            Me.txtClientNum.Size = New System.Drawing.Size(269, 20)
            Me.txtClientNum.TabIndex = 5
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(13, 142)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(55, 13)
            Me.label12.TabIndex = 62
            Me.label12.Text = "ClientNum"
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Location = New System.Drawing.Point(13, 116)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(34, 13)
            Me.label14.TabIndex = 55
            Me.label14.Text = "TaxId"
            '
            'txtSocketNum
            '
            Me.txtSocketNum.Location = New System.Drawing.Point(143, 37)
            Me.txtSocketNum.Name = "txtSocketNum"
            Me.txtSocketNum.Size = New System.Drawing.Size(269, 20)
            Me.txtSocketNum.TabIndex = 1
            '
            'txtSIC
            '
            Me.txtSIC.Location = New System.Drawing.Point(142, 86)
            Me.txtSIC.Name = "txtSIC"
            Me.txtSIC.Size = New System.Drawing.Size(269, 20)
            Me.txtSIC.TabIndex = 2
            '
            'lblTerminalId
            '
            Me.lblTerminalId.AutoSize = True
            Me.lblTerminalId.Location = New System.Drawing.Point(14, 40)
            Me.lblTerminalId.Name = "lblTerminalId"
            Me.lblTerminalId.Size = New System.Drawing.Size(59, 13)
            Me.lblTerminalId.TabIndex = 61
            Me.lblTerminalId.Text = "Terminal Id"
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Location = New System.Drawing.Point(13, 89)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(24, 13)
            Me.label15.TabIndex = 60
            Me.label15.Text = "SIC"
            '
            'txtMerchantId
            '
            Me.txtMerchantId.Location = New System.Drawing.Point(143, 11)
            Me.txtMerchantId.Name = "txtMerchantId"
            Me.txtMerchantId.Size = New System.Drawing.Size(269, 20)
            Me.txtMerchantId.TabIndex = 0
            '
            'txtTaxId
            '
            Me.txtTaxId.Location = New System.Drawing.Point(142, 112)
            Me.txtTaxId.Name = "txtTaxId"
            Me.txtTaxId.Size = New System.Drawing.Size(269, 20)
            Me.txtTaxId.TabIndex = 4
            '
            'txtSharingGroup
            '
            Me.txtSharingGroup.Location = New System.Drawing.Point(143, 352)
            Me.txtSharingGroup.Name = "txtSharingGroup"
            Me.txtSharingGroup.Size = New System.Drawing.Size(269, 20)
            Me.txtSharingGroup.TabIndex = 13
            '
            'txtSettlementAgent
            '
            Me.txtSettlementAgent.Location = New System.Drawing.Point(143, 325)
            Me.txtSettlementAgent.Name = "txtSettlementAgent"
            Me.txtSettlementAgent.Size = New System.Drawing.Size(269, 20)
            Me.txtSettlementAgent.TabIndex = 12
            '
            'txtABANumber
            '
            Me.txtABANumber.Location = New System.Drawing.Point(143, 168)
            Me.txtABANumber.Name = "txtABANumber"
            Me.txtABANumber.Size = New System.Drawing.Size(269, 20)
            Me.txtABANumber.TabIndex = 6
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Location = New System.Drawing.Point(13, 328)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(85, 13)
            Me.label32.TabIndex = 49
            Me.label32.Text = "SettlementAgent"
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Location = New System.Drawing.Point(13, 352)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(72, 13)
            Me.label31.TabIndex = 48
            Me.label31.Text = "SharingGroup"
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Location = New System.Drawing.Point(13, 171)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(65, 13)
            Me.label30.TabIndex = 47
            Me.label30.Text = "ABANumber"
            '
            'txtReimbursementAttribute
            '
            Me.txtReimbursementAttribute.Location = New System.Drawing.Point(143, 405)
            Me.txtReimbursementAttribute.Name = "txtReimbursementAttribute"
            Me.txtReimbursementAttribute.Size = New System.Drawing.Size(269, 20)
            Me.txtReimbursementAttribute.TabIndex = 15
            '
            'txtTimeZoneDifferential
            '
            Me.txtTimeZoneDifferential.Location = New System.Drawing.Point(143, 378)
            Me.txtTimeZoneDifferential.Name = "txtTimeZoneDifferential"
            Me.txtTimeZoneDifferential.Size = New System.Drawing.Size(269, 20)
            Me.txtTimeZoneDifferential.TabIndex = 14
            '
            'txtStoreId
            '
            Me.txtStoreId.Location = New System.Drawing.Point(143, 63)
            Me.txtStoreId.Name = "txtStoreId"
            Me.txtStoreId.Size = New System.Drawing.Size(269, 20)
            Me.txtStoreId.TabIndex = 3
            '
            'txtSecondaryTerminalId
            '
            Me.txtSecondaryTerminalId.Location = New System.Drawing.Point(143, 299)
            Me.txtSecondaryTerminalId.Name = "txtSecondaryTerminalId"
            Me.txtSecondaryTerminalId.Size = New System.Drawing.Size(269, 20)
            Me.txtSecondaryTerminalId.TabIndex = 11
            '
            'lblStoreId
            '
            Me.lblStoreId.AutoSize = True
            Me.lblStoreId.Location = New System.Drawing.Point(14, 64)
            Me.lblStoreId.Name = "lblStoreId"
            Me.lblStoreId.Size = New System.Drawing.Size(41, 13)
            Me.lblStoreId.TabIndex = 46
            Me.lblStoreId.Text = "StoreId"
            '
            'txtLocation
            '
            Me.txtLocation.Location = New System.Drawing.Point(143, 272)
            Me.txtLocation.Name = "txtLocation"
            Me.txtLocation.Size = New System.Drawing.Size(269, 20)
            Me.txtLocation.TabIndex = 10
            '
            'txtAgentChain
            '
            Me.txtAgentChain.Location = New System.Drawing.Point(143, 246)
            Me.txtAgentChain.Name = "txtAgentChain"
            Me.txtAgentChain.Size = New System.Drawing.Size(269, 20)
            Me.txtAgentChain.TabIndex = 9
            '
            'txtAgentBank
            '
            Me.txtAgentBank.Location = New System.Drawing.Point(143, 220)
            Me.txtAgentBank.Name = "txtAgentBank"
            Me.txtAgentBank.Size = New System.Drawing.Size(269, 20)
            Me.txtAgentBank.TabIndex = 8
            '
            'txtAcquirerBIN
            '
            Me.txtAcquirerBIN.Location = New System.Drawing.Point(143, 194)
            Me.txtAcquirerBIN.Name = "txtAcquirerBIN"
            Me.txtAcquirerBIN.Size = New System.Drawing.Size(269, 20)
            Me.txtAcquirerBIN.TabIndex = 7
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Location = New System.Drawing.Point(13, 408)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(119, 13)
            Me.label28.TabIndex = 22
            Me.label28.Text = "ReimbursementAttribute"
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Location = New System.Drawing.Point(13, 382)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(105, 13)
            Me.label27.TabIndex = 20
            Me.label27.Text = "TimeZoneDifferential"
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Location = New System.Drawing.Point(13, 304)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(107, 13)
            Me.label26.TabIndex = 18
            Me.label26.Text = "SecondaryTerminalId"
            Me.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Location = New System.Drawing.Point(13, 278)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(48, 13)
            Me.label25.TabIndex = 16
            Me.label25.Text = "Location"
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.Location = New System.Drawing.Point(13, 252)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(62, 13)
            Me.label24.TabIndex = 14
            Me.label24.Text = "AgentChain"
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Location = New System.Drawing.Point(13, 226)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(60, 13)
            Me.label23.TabIndex = 12
            Me.label23.Text = "AgentBank"
            Me.label23.UseMnemonic = False
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Location = New System.Drawing.Point(13, 200)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(64, 13)
            Me.label22.TabIndex = 10
            Me.label22.Text = "AcquirerBIN"
            '
            'tbMerchantDataTxnDefaults
            '
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.cboEntryMode)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.label34)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.cboRequestACI)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.label21)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.cboMerchantIndustryType)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.label29)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.cboCustomerPresent)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.label18)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.cboCurrencyCode)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.label17)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.label9)
            Me.tbMerchantDataTxnDefaults.Controls.Add(Me.cboLanguage)
            Me.tbMerchantDataTxnDefaults.Location = New System.Drawing.Point(4, 22)
            Me.tbMerchantDataTxnDefaults.Name = "tbMerchantDataTxnDefaults"
            Me.tbMerchantDataTxnDefaults.Padding = New System.Windows.Forms.Padding(3)
            Me.tbMerchantDataTxnDefaults.Size = New System.Drawing.Size(427, 435)
            Me.tbMerchantDataTxnDefaults.TabIndex = 2
            Me.tbMerchantDataTxnDefaults.Text = "Merchant TxnData Defaults"
            Me.tbMerchantDataTxnDefaults.UseVisualStyleBackColor = True
            '
            'cboEntryMode
            '
            Me.cboEntryMode.FormattingEnabled = True
            Me.cboEntryMode.Location = New System.Drawing.Point(134, 149)
            Me.cboEntryMode.Name = "cboEntryMode"
            Me.cboEntryMode.Size = New System.Drawing.Size(287, 21)
            Me.cboEntryMode.TabIndex = 59
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Location = New System.Drawing.Point(3, 151)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(61, 13)
            Me.label34.TabIndex = 58
            Me.label34.Text = "Entry Mode"
            '
            'cboRequestACI
            '
            Me.cboRequestACI.FormattingEnabled = True
            Me.cboRequestACI.Location = New System.Drawing.Point(134, 95)
            Me.cboRequestACI.Name = "cboRequestACI"
            Me.cboRequestACI.Size = New System.Drawing.Size(287, 21)
            Me.cboRequestACI.TabIndex = 57
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Location = New System.Drawing.Point(3, 98)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(64, 13)
            Me.label21.TabIndex = 56
            Me.label21.Text = "RequestACI"
            '
            'cboMerchantIndustryType
            '
            Me.cboMerchantIndustryType.FormattingEnabled = True
            Me.cboMerchantIndustryType.Location = New System.Drawing.Point(134, 122)
            Me.cboMerchantIndustryType.Name = "cboMerchantIndustryType"
            Me.cboMerchantIndustryType.Size = New System.Drawing.Size(287, 21)
            Me.cboMerchantIndustryType.TabIndex = 54
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(3, 125)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(71, 13)
            Me.label29.TabIndex = 53
            Me.label29.Text = "Industry Type"
            '
            'cboCustomerPresent
            '
            Me.cboCustomerPresent.FormattingEnabled = True
            Me.cboCustomerPresent.Location = New System.Drawing.Point(134, 41)
            Me.cboCustomerPresent.Name = "cboCustomerPresent"
            Me.cboCustomerPresent.Size = New System.Drawing.Size(287, 21)
            Me.cboCustomerPresent.TabIndex = 51
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Location = New System.Drawing.Point(3, 44)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(90, 13)
            Me.label18.TabIndex = 55
            Me.label18.Text = "Customer Present"
            '
            'cboCurrencyCode
            '
            Me.cboCurrencyCode.FormattingEnabled = True
            Me.cboCurrencyCode.Location = New System.Drawing.Point(135, 14)
            Me.cboCurrencyCode.Name = "cboCurrencyCode"
            Me.cboCurrencyCode.Size = New System.Drawing.Size(286, 21)
            Me.cboCurrencyCode.TabIndex = 50
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Location = New System.Drawing.Point(3, 17)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(74, 13)
            Me.label17.TabIndex = 52
            Me.label17.Text = "CurrencyCode"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(3, 71)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(99, 13)
            Me.label9.TabIndex = 11
            Me.label9.Text = "Language Indicator"
            '
            'cboLanguage
            '
            Me.cboLanguage.FormattingEnabled = True
            Me.cboLanguage.Location = New System.Drawing.Point(134, 68)
            Me.cboLanguage.Name = "cboLanguage"
            Me.cboLanguage.Size = New System.Drawing.Size(287, 21)
            Me.cboLanguage.TabIndex = 12
            '
            'lblLastUpdated
            '
            Me.lblLastUpdated.AutoSize = True
            Me.lblLastUpdated.Location = New System.Drawing.Point(12, 611)
            Me.lblLastUpdated.Name = "lblLastUpdated"
            Me.lblLastUpdated.Size = New System.Drawing.Size(0, 13)
            Me.lblLastUpdated.TabIndex = 165
            '
            'cmdClose
            '
            Me.cmdClose.Location = New System.Drawing.Point(388, 602)
            Me.cmdClose.Name = "cmdClose"
            Me.cmdClose.Size = New System.Drawing.Size(56, 23)
            Me.cmdClose.TabIndex = 166
            Me.cmdClose.Text = "Close"
            Me.cmdClose.UseVisualStyleBackColor = True
            '
            'ManageMerchantProfile
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(451, 633)
            Me.Controls.Add(Me.cmdClose)
            Me.Controls.Add(Me.lblLastUpdated)
            Me.Controls.Add(Me.cboMerchantDataAction)
            Me.Controls.Add(Me.ChkEnableAllMerchantFields)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.cboAvailableProfiles)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.lnkManageMerchantData)
            Me.Controls.Add(Me.CmdPerformWebRequest)
            Me.Controls.Add(Me.txtMerchantProfileServiceId)
            Me.Controls.Add(Me.label33)
            Me.Controls.Add(Me.cmdPopulateTestValues)
            Me.Controls.Add(Me.tbMerchantInformation)
            Me.Name = "ManageMerchantProfile"
            Me.Text = "Manage Merchant Profiles - CWS 1.17.18"
            Me.tbMerchantInformation.ResumeLayout(False)
            Me.tbMerchantContactData.ResumeLayout(False)
            Me.tbMerchantContactData.PerformLayout()
            Me.tbMerchantAccountData.ResumeLayout(False)
            Me.tbMerchantAccountData.PerformLayout()
            Me.tbMerchantDataTxnDefaults.ResumeLayout(False)
            Me.tbMerchantDataTxnDefaults.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents cboMerchantDataAction As System.Windows.Forms.ComboBox
        Private WithEvents ChkEnableAllMerchantFields As System.Windows.Forms.CheckBox
        Private WithEvents txtCustomerServiceInternet As System.Windows.Forms.TextBox
        Private WithEvents label10 As System.Windows.Forms.Label
        Public WithEvents cboAvailableProfiles As System.Windows.Forms.ComboBox
        Private WithEvents label13 As System.Windows.Forms.Label
        Private WithEvents txtPhone As System.Windows.Forms.TextBox
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents txtCustomerServicePhone As System.Windows.Forms.TextBox
        Private WithEvents cboCountryCode As System.Windows.Forms.ComboBox
        Private WithEvents lnkManageMerchantData As System.Windows.Forms.LinkLabel
        Private WithEvents CmdPerformWebRequest As System.Windows.Forms.Button
        Private WithEvents txtPostalCode As System.Windows.Forms.TextBox
        Private WithEvents txtMerchantProfileServiceId As System.Windows.Forms.TextBox
        Private WithEvents label33 As System.Windows.Forms.Label
        Private WithEvents cmdPopulateTestValues As System.Windows.Forms.Button
        Private WithEvents label20 As System.Windows.Forms.Label
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents txtStreetAddress1 As System.Windows.Forms.TextBox
        Private WithEvents txtStreetAddress2 As System.Windows.Forms.TextBox
        Private WithEvents txtCity As System.Windows.Forms.TextBox
        Private WithEvents txtStateProvince As System.Windows.Forms.TextBox
        Private WithEvents txtName As System.Windows.Forms.TextBox
        Private WithEvents tbMerchantInformation As System.Windows.Forms.TabControl
        Private WithEvents tbMerchantContactData As System.Windows.Forms.TabPage
        Private WithEvents tbMerchantAccountData As System.Windows.Forms.TabPage
        Private WithEvents lblMerchantId As System.Windows.Forms.Label
        Private WithEvents txtClientNum As System.Windows.Forms.TextBox
        Private WithEvents label12 As System.Windows.Forms.Label
        Private WithEvents label14 As System.Windows.Forms.Label
        Private WithEvents txtSocketNum As System.Windows.Forms.TextBox
        Private WithEvents txtSIC As System.Windows.Forms.TextBox
        Private WithEvents lblTerminalId As System.Windows.Forms.Label
        Private WithEvents label15 As System.Windows.Forms.Label
        Private WithEvents txtMerchantId As System.Windows.Forms.TextBox
        Private WithEvents txtTaxId As System.Windows.Forms.TextBox
        Private WithEvents txtSharingGroup As System.Windows.Forms.TextBox
        Private WithEvents txtSettlementAgent As System.Windows.Forms.TextBox
        Private WithEvents txtABANumber As System.Windows.Forms.TextBox
        Private WithEvents label32 As System.Windows.Forms.Label
        Private WithEvents label31 As System.Windows.Forms.Label
        Private WithEvents label30 As System.Windows.Forms.Label
        Private WithEvents txtReimbursementAttribute As System.Windows.Forms.TextBox
        Private WithEvents txtTimeZoneDifferential As System.Windows.Forms.TextBox
        Private WithEvents txtStoreId As System.Windows.Forms.TextBox
        Private WithEvents txtSecondaryTerminalId As System.Windows.Forms.TextBox
        Private WithEvents lblStoreId As System.Windows.Forms.Label
        Private WithEvents txtLocation As System.Windows.Forms.TextBox
        Private WithEvents txtAgentChain As System.Windows.Forms.TextBox
        Private WithEvents txtAgentBank As System.Windows.Forms.TextBox
        Private WithEvents txtAcquirerBIN As System.Windows.Forms.TextBox
        Private WithEvents label28 As System.Windows.Forms.Label
        Private WithEvents label27 As System.Windows.Forms.Label
        Private WithEvents label26 As System.Windows.Forms.Label
        Private WithEvents label25 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents label23 As System.Windows.Forms.Label
        Private WithEvents label22 As System.Windows.Forms.Label
        Private WithEvents tbMerchantDataTxnDefaults As System.Windows.Forms.TabPage
        Private WithEvents cboEntryMode As System.Windows.Forms.ComboBox
        Private WithEvents label34 As System.Windows.Forms.Label
        Private WithEvents cboRequestACI As System.Windows.Forms.ComboBox
        Private WithEvents label21 As System.Windows.Forms.Label
        Private WithEvents cboMerchantIndustryType As System.Windows.Forms.ComboBox
        Private WithEvents label29 As System.Windows.Forms.Label
        Private WithEvents cboCustomerPresent As System.Windows.Forms.ComboBox
        Private WithEvents label18 As System.Windows.Forms.Label
        Private WithEvents cboCurrencyCode As System.Windows.Forms.ComboBox
        Private WithEvents label17 As System.Windows.Forms.Label
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents cboLanguage As System.Windows.Forms.ComboBox
        Private WithEvents lblLastUpdated As System.Windows.Forms.Label
        Private WithEvents cmdClose As System.Windows.Forms.Button

#End Region

    End Class
End Namespace
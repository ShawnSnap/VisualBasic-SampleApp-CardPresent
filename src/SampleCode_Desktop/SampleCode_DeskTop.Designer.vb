Namespace SampleCode
    Partial Class SampleCode_DeskTop
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SampleCode_DeskTop))
            Me.lnkOnlineDocumentation = New System.Windows.Forms.LinkLabel()
            Me.tmrServiceArrow = New System.Windows.Forms.Timer(Me.components)
            Me.tbTransactionProcessing = New System.Windows.Forms.TabPage()
            Me.lblCurrentServiceClass = New System.Windows.Forms.Label()
            Me.lblCurrentService = New System.Windows.Forms.Label()
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.viewTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.configurationValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.applicationProfileIdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.serviceIdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.workflowIdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.merchantProfileIdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.identityTokenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ServiceKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.groupBox11 = New System.Windows.Forms.GroupBox()
            Me.rdoDeactivate = New System.Windows.Forms.RadioButton()
            Me.rdoReload = New System.Windows.Forms.RadioButton()
            Me.rdoActivate = New System.Windows.Forms.RadioButton()
            Me.lnkManageAccountById = New System.Windows.Forms.LinkLabel()
            Me.cmdManageAccountById = New System.Windows.Forms.Button()
            Me.cmdManageAccount = New System.Windows.Forms.Button()
            Me.lnkManageAccount = New System.Windows.Forms.LinkLabel()
            Me.ChkOnClickDisplayTxnMessage = New System.Windows.Forms.CheckBox()
            Me.CmdClearTransactions = New System.Windows.Forms.Button()
            Me.ChkLstTransactionsProcessed = New System.Windows.Forms.CheckedListBox()
            Me.label18 = New System.Windows.Forms.Label()
            Me.TxtTip = New System.Windows.Forms.TextBox()
            Me.label20 = New System.Windows.Forms.Label()
            Me.TxtAmount = New System.Windows.Forms.TextBox()
            Me.label19 = New System.Windows.Forms.Label()
            Me.txtCredPassword = New System.Windows.Forms.TextBox()
            Me.txtCredUserName = New System.Windows.Forms.TextBox()
            Me.label46 = New System.Windows.Forms.Label()
            Me.label45 = New System.Windows.Forms.Label()
            Me.groupBox13 = New System.Windows.Forms.GroupBox()
            Me.ChkMagensaAuthorizeAndCapture = New System.Windows.Forms.CheckBox()
            Me.CmdMagensa = New System.Windows.Forms.Button()
            Me.ChkAcknowledge = New System.Windows.Forms.CheckBox()
            Me.LnkRequestTransaction = New System.Windows.Forms.LinkLabel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtApprovalCode = New System.Windows.Forms.TextBox()
            Me.CmdRequestTransaction = New System.Windows.Forms.Button()
            Me.cmdForcePost = New System.Windows.Forms.Button()
            Me.chkL3AuthAndCapture = New System.Windows.Forms.CheckBox()
            Me.lnkAcknowledge = New System.Windows.Forms.LinkLabel()
            Me.chkL2AuthAndCapture = New System.Windows.Forms.CheckBox()
            Me.cmdPurchaseCardL3 = New System.Windows.Forms.Button()
            Me.cmdPurchaseCardL2 = New System.Windows.Forms.Button()
            Me.cmdCardTokenization = New System.Windows.Forms.Button()
            Me.groupBox9 = New System.Windows.Forms.GroupBox()
            Me.lnkVerify = New System.Windows.Forms.LinkLabel()
            Me.lnkQueryAccount = New System.Windows.Forms.LinkLabel()
            Me.cmdQueryAccount = New System.Windows.Forms.Button()
            Me.cmdVerify = New System.Windows.Forms.Button()
            Me.groupBox8 = New System.Windows.Forms.GroupBox()
            Me.lnkReturnUnlinked = New System.Windows.Forms.LinkLabel()
            Me.lnkReturnById = New System.Windows.Forms.LinkLabel()
            Me.cmdReturnById = New System.Windows.Forms.Button()
            Me.cmdReturnUnlinked = New System.Windows.Forms.Button()
            Me.groupBox7 = New System.Windows.Forms.GroupBox()
            Me.groupBox14 = New System.Windows.Forms.GroupBox()
            Me.ChkForceCloseBatch = New System.Windows.Forms.CheckBox()
            Me.cmdCaptureAll = New System.Windows.Forms.Button()
            Me.ChkCapSelectiveDiffData = New System.Windows.Forms.CheckBox()
            Me.cmdCaptureSelective = New System.Windows.Forms.Button()
            Me.lnkCaptureAll = New System.Windows.Forms.LinkLabel()
            Me.lnkCaptureSelective = New System.Windows.Forms.LinkLabel()
            Me.chkCaptureAllAndSelectiveAsync = New System.Windows.Forms.CheckBox()
            Me.ChkMultiplePartialCapture = New System.Windows.Forms.CheckBox()
            Me.lnkCapture = New System.Windows.Forms.LinkLabel()
            Me.cmdCapture = New System.Windows.Forms.Button()
            Me.groupBox6 = New System.Windows.Forms.GroupBox()
            Me.ChkForceVoid = New System.Windows.Forms.CheckBox()
            Me.lnkUndo = New System.Windows.Forms.LinkLabel()
            Me.lnkAdjust = New System.Windows.Forms.LinkLabel()
            Me.cmdAdjust = New System.Windows.Forms.Button()
            Me.cmdUndo = New System.Windows.Forms.Button()
            Me.groupBox5 = New System.Windows.Forms.GroupBox()
            Me.ChkUserWorkflowId = New System.Windows.Forms.CheckBox()
            Me.ChkAllowPartialApprovals = New System.Windows.Forms.CheckBox()
            Me.lnkAuthorize = New System.Windows.Forms.LinkLabel()
            Me.lnkAuthorizeAndCapture = New System.Windows.Forms.LinkLabel()
            Me.cmdAuthorize = New System.Windows.Forms.Button()
            Me.cmdAuthorizeAndCapture = New System.Windows.Forms.Button()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.tbPreparingApplicationToTransact = New System.Windows.Forms.TabPage()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.linkPreparingAppToTransact = New System.Windows.Forms.LinkLabel()
            Me.ckBoxDelegatedSignOn = New System.Windows.Forms.CheckBox()
            Me.txtDelegatedServiceKey = New System.Windows.Forms.TextBox()
            Me.lnkLblDelegatedSignOn = New System.Windows.Forms.LinkLabel()
            Me.CmdManageMerchantData = New System.Windows.Forms.Button()
            Me.label3 = New System.Windows.Forms.Label()
            Me.CboWorkFlowIdsByServiceId = New System.Windows.Forms.ComboBox()
            Me.cmdSignOnWithToken = New System.Windows.Forms.Button()
            Me.picArrow = New System.Windows.Forms.PictureBox()
            Me.lnkRetrieveServiceInformation = New System.Windows.Forms.LinkLabel()
            Me.lnkManageApplicationData = New System.Windows.Forms.LinkLabel()
            Me.lnkSignOnWithToken = New System.Windows.Forms.LinkLabel()
            Me.lblIsProfileInitialized = New System.Windows.Forms.Label()
            Me.label22 = New System.Windows.Forms.Label()
            Me.txtAboutTheService = New System.Windows.Forms.TextBox()
            Me.groupBox10 = New System.Windows.Forms.GroupBox()
            Me.chkEncryptIdentityToken = New System.Windows.Forms.CheckBox()
            Me.cmdPersistConfig = New System.Windows.Forms.Button()
            Me.txtPersistedAndCached = New System.Windows.Forms.TextBox()
            Me.cmdDeletePersistCached = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label17 = New System.Windows.Forms.Label()
            Me.label16 = New System.Windows.Forms.Label()
            Me.label15 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.label12 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.cboAvailableProfiles = New System.Windows.Forms.ComboBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.cboAvailableServices = New System.Windows.Forms.ComboBox()
            Me.chkStep2 = New System.Windows.Forms.CheckBox()
            Me.chkStep3 = New System.Windows.Forms.CheckBox()
            Me.chkStep1 = New System.Windows.Forms.CheckBox()
            Me.cmdRetrieveServiceInformation = New System.Windows.Forms.Button()
            Me.cmdManageApplicationData = New System.Windows.Forms.Button()
            Me.tbIntroduction = New System.Windows.Forms.TabPage()
            Me.label35 = New System.Windows.Forms.Label()
            Me.CboindustryType = New System.Windows.Forms.ComboBox()
            Me.TxtServiceKey = New System.Windows.Forms.TextBox()
            Me.cmdPopulateWithMyTestValues = New System.Windows.Forms.Button()
            Me.lnkAccessingWebServiceEndpoints = New System.Windows.Forms.LinkLabel()
            Me.cmdGo = New System.Windows.Forms.Button()
            Me.txtIntroduction = New System.Windows.Forms.TextBox()
            Me.txtIdentityToken = New System.Windows.Forms.TextBox()
            Me.lnkIdentityToken = New System.Windows.Forms.LinkLabel()
            Me.label24 = New System.Windows.Forms.Label()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.label31 = New System.Windows.Forms.Label()
            Me.label32 = New System.Windows.Forms.Label()
            Me.label30 = New System.Windows.Forms.Label()
            Me.txtTMSSecondary = New System.Windows.Forms.TextBox()
            Me.txtTMSPrimary = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.txtTxnSecondary = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.txtTxnPrimary = New System.Windows.Forms.TextBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.txtSvcSecondary = New System.Windows.Forms.TextBox()
            Me.label7 = New System.Windows.Forms.Label()
            Me.txtSvcPrimary = New System.Windows.Forms.TextBox()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label21 = New System.Windows.Forms.Label()
            Me.groupBox12 = New System.Windows.Forms.GroupBox()
            Me.txtDisclaimer = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.tbTransactionData = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.GrpTokenization = New System.Windows.Forms.GroupBox()
            Me.ChkTokenization = New System.Windows.Forms.CheckBox()
            Me.CboTokenizedCard = New System.Windows.Forms.ComboBox()
            Me.label27 = New System.Windows.Forms.Label()
            Me.GrpTrackDataFromMSR = New System.Windows.Forms.GroupBox()
            Me.ChkTrackDataFromMSR = New System.Windows.Forms.CheckBox()
            Me.grpPinDebit = New System.Windows.Forms.GroupBox()
            Me.chkProcessAsPINDebitTxn = New System.Windows.Forms.CheckBox()
            Me.TxtEncryptedPIN = New System.Windows.Forms.TextBox()
            Me.label34 = New System.Windows.Forms.Label()
            Me.TxtKeySerialNumber = New System.Windows.Forms.TextBox()
            Me.label33 = New System.Windows.Forms.Label()
            Me.TxtCashBack = New System.Windows.Forms.TextBox()
            Me.label29 = New System.Windows.Forms.Label()
            Me.TxtTrackDataFromMSR = New System.Windows.Forms.TextBox()
            Me.grpProcessasPINLessDebit = New System.Windows.Forms.GroupBox()
            Me.ChkProcessAsPINLessDebit = New System.Windows.Forms.CheckBox()
            Me.GrpCNP = New System.Windows.Forms.GroupBox()
            Me.ChkCardNotPresent = New System.Windows.Forms.CheckBox()
            Me.TxtPAN = New System.Windows.Forms.TextBox()
            Me.label23 = New System.Windows.Forms.Label()
            Me.label25 = New System.Windows.Forms.Label()
            Me.TxtExpirationDate = New System.Windows.Forms.TextBox()
            Me.label26 = New System.Windows.Forms.Label()
            Me.CboCardTypes = New System.Windows.Forms.ComboBox()
            Me.lnkServiceKey = New System.Windows.Forms.LinkLabel()
            Me.tbTransactionProcessing.SuspendLayout()
            Me.menuStrip1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox11.SuspendLayout()
            Me.groupBox13.SuspendLayout()
            Me.groupBox9.SuspendLayout()
            Me.groupBox8.SuspendLayout()
            Me.groupBox7.SuspendLayout()
            Me.groupBox14.SuspendLayout()
            Me.groupBox6.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tbPreparingApplicationToTransact.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.picArrow, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox10.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tbIntroduction.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox12.SuspendLayout()
            Me.tbTransactionData.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GrpTokenization.SuspendLayout()
            Me.GrpTrackDataFromMSR.SuspendLayout()
            Me.grpPinDebit.SuspendLayout()
            Me.grpProcessasPINLessDebit.SuspendLayout()
            Me.GrpCNP.SuspendLayout()
            Me.SuspendLayout()
            '
            'lnkOnlineDocumentation
            '
            Me.lnkOnlineDocumentation.AutoSize = True
            Me.lnkOnlineDocumentation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lnkOnlineDocumentation.Location = New System.Drawing.Point(711, 9)
            Me.lnkOnlineDocumentation.Name = "lnkOnlineDocumentation"
            Me.lnkOnlineDocumentation.Size = New System.Drawing.Size(132, 13)
            Me.lnkOnlineDocumentation.TabIndex = 10
            Me.lnkOnlineDocumentation.TabStop = True
            Me.lnkOnlineDocumentation.Text = "Online Documentation"
            '
            'tmrServiceArrow
            '
            Me.tmrServiceArrow.Interval = 5000
            '
            'tbTransactionProcessing
            '
            Me.tbTransactionProcessing.Controls.Add(Me.lblCurrentServiceClass)
            Me.tbTransactionProcessing.Controls.Add(Me.lblCurrentService)
            Me.tbTransactionProcessing.Controls.Add(Me.menuStrip1)
            Me.tbTransactionProcessing.Controls.Add(Me.groupBox2)
            Me.tbTransactionProcessing.Location = New System.Drawing.Point(4, 25)
            Me.tbTransactionProcessing.Name = "tbTransactionProcessing"
            Me.tbTransactionProcessing.Size = New System.Drawing.Size(836, 766)
            Me.tbTransactionProcessing.TabIndex = 2
            Me.tbTransactionProcessing.Text = "Transaction Processing"
            Me.tbTransactionProcessing.UseVisualStyleBackColor = True
            '
            'lblCurrentServiceClass
            '
            Me.lblCurrentServiceClass.AutoSize = True
            Me.lblCurrentServiceClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCurrentServiceClass.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblCurrentServiceClass.Location = New System.Drawing.Point(13, 52)
            Me.lblCurrentServiceClass.Name = "lblCurrentServiceClass"
            Me.lblCurrentServiceClass.Size = New System.Drawing.Size(105, 17)
            Me.lblCurrentServiceClass.TabIndex = 135
            Me.lblCurrentServiceClass.Text = "Service Class : "
            '
            'lblCurrentService
            '
            Me.lblCurrentService.AutoSize = True
            Me.lblCurrentService.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCurrentService.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblCurrentService.Location = New System.Drawing.Point(13, 27)
            Me.lblCurrentService.Name = "lblCurrentService"
            Me.lblCurrentService.Size = New System.Drawing.Size(211, 24)
            Me.lblCurrentService.TabIndex = 134
            Me.lblCurrentService.Text = "Processing as Service : "
            '
            'menuStrip1
            '
            Me.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.viewTransactionsToolStripMenuItem, Me.configurationValuesToolStripMenuItem})
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Size = New System.Drawing.Size(836, 24)
            Me.menuStrip1.TabIndex = 133
            Me.menuStrip1.Text = "menuStrip1"
            '
            'viewTransactionsToolStripMenuItem
            '
            Me.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem"
            Me.viewTransactionsToolStripMenuItem.Size = New System.Drawing.Size(310, 20)
            Me.viewTransactionsToolStripMenuItem.Text = "Click Here for Transaction Management Services (TMS)"
            '
            'configurationValuesToolStripMenuItem
            '
            Me.configurationValuesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.applicationProfileIdToolStripMenuItem, Me.serviceIdToolStripMenuItem, Me.workflowIdToolStripMenuItem, Me.merchantProfileIdToolStripMenuItem, Me.identityTokenToolStripMenuItem, Me.ServiceKeyToolStripMenuItem})
            Me.configurationValuesToolStripMenuItem.Name = "configurationValuesToolStripMenuItem"
            Me.configurationValuesToolStripMenuItem.Size = New System.Drawing.Size(226, 20)
            Me.configurationValuesToolStripMenuItem.Text = "Click here to view Configuration Values"
            '
            'applicationProfileIdToolStripMenuItem
            '
            Me.applicationProfileIdToolStripMenuItem.Name = "applicationProfileIdToolStripMenuItem"
            Me.applicationProfileIdToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.applicationProfileIdToolStripMenuItem.Text = "Application ProfileId : "
            '
            'serviceIdToolStripMenuItem
            '
            Me.serviceIdToolStripMenuItem.Name = "serviceIdToolStripMenuItem"
            Me.serviceIdToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.serviceIdToolStripMenuItem.Text = "Service Id : "
            '
            'workflowIdToolStripMenuItem
            '
            Me.workflowIdToolStripMenuItem.Name = "workflowIdToolStripMenuItem"
            Me.workflowIdToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.workflowIdToolStripMenuItem.Text = "Workflow Id: "
            '
            'merchantProfileIdToolStripMenuItem
            '
            Me.merchantProfileIdToolStripMenuItem.Name = "merchantProfileIdToolStripMenuItem"
            Me.merchantProfileIdToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.merchantProfileIdToolStripMenuItem.Text = "MerchantProfileId : "
            '
            'identityTokenToolStripMenuItem
            '
            Me.identityTokenToolStripMenuItem.Name = "identityTokenToolStripMenuItem"
            Me.identityTokenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.identityTokenToolStripMenuItem.Text = "Identity Token : "
            '
            'ServiceKeyToolStripMenuItem
            '
            Me.ServiceKeyToolStripMenuItem.Name = "ServiceKeyToolStripMenuItem"
            Me.ServiceKeyToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
            Me.ServiceKeyToolStripMenuItem.Text = "Service Key :"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.groupBox11)
            Me.groupBox2.Controls.Add(Me.ChkOnClickDisplayTxnMessage)
            Me.groupBox2.Controls.Add(Me.CmdClearTransactions)
            Me.groupBox2.Controls.Add(Me.ChkLstTransactionsProcessed)
            Me.groupBox2.Controls.Add(Me.label18)
            Me.groupBox2.Controls.Add(Me.TxtTip)
            Me.groupBox2.Controls.Add(Me.label20)
            Me.groupBox2.Controls.Add(Me.TxtAmount)
            Me.groupBox2.Controls.Add(Me.label19)
            Me.groupBox2.Controls.Add(Me.txtCredPassword)
            Me.groupBox2.Controls.Add(Me.txtCredUserName)
            Me.groupBox2.Controls.Add(Me.label46)
            Me.groupBox2.Controls.Add(Me.label45)
            Me.groupBox2.Controls.Add(Me.groupBox13)
            Me.groupBox2.Controls.Add(Me.groupBox9)
            Me.groupBox2.Controls.Add(Me.groupBox8)
            Me.groupBox2.Controls.Add(Me.groupBox7)
            Me.groupBox2.Controls.Add(Me.groupBox6)
            Me.groupBox2.Controls.Add(Me.groupBox5)
            Me.groupBox2.Controls.Add(Me.pictureBox2)
            Me.groupBox2.Location = New System.Drawing.Point(4, 72)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(821, 654)
            Me.groupBox2.TabIndex = 8
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Transaction Processing"
            '
            'groupBox11
            '
            Me.groupBox11.Controls.Add(Me.rdoDeactivate)
            Me.groupBox11.Controls.Add(Me.rdoReload)
            Me.groupBox11.Controls.Add(Me.rdoActivate)
            Me.groupBox11.Controls.Add(Me.lnkManageAccountById)
            Me.groupBox11.Controls.Add(Me.cmdManageAccountById)
            Me.groupBox11.Controls.Add(Me.cmdManageAccount)
            Me.groupBox11.Controls.Add(Me.lnkManageAccount)
            Me.groupBox11.Location = New System.Drawing.Point(203, 423)
            Me.groupBox11.Name = "groupBox11"
            Me.groupBox11.Size = New System.Drawing.Size(329, 90)
            Me.groupBox11.TabIndex = 142
            Me.groupBox11.TabStop = False
            Me.groupBox11.Text = "Manage Stored Value Account"
            '
            'rdoDeactivate
            '
            Me.rdoDeactivate.AutoSize = True
            Me.rdoDeactivate.Location = New System.Drawing.Point(188, 67)
            Me.rdoDeactivate.Name = "rdoDeactivate"
            Me.rdoDeactivate.Size = New System.Drawing.Size(80, 17)
            Me.rdoDeactivate.TabIndex = 135
            Me.rdoDeactivate.TabStop = True
            Me.rdoDeactivate.Text = "De-activate"
            Me.rdoDeactivate.UseVisualStyleBackColor = True
            '
            'rdoReload
            '
            Me.rdoReload.AutoSize = True
            Me.rdoReload.Location = New System.Drawing.Point(188, 44)
            Me.rdoReload.Name = "rdoReload"
            Me.rdoReload.Size = New System.Drawing.Size(59, 17)
            Me.rdoReload.TabIndex = 134
            Me.rdoReload.TabStop = True
            Me.rdoReload.Text = "Reload"
            Me.rdoReload.UseVisualStyleBackColor = True
            '
            'rdoActivate
            '
            Me.rdoActivate.AutoSize = True
            Me.rdoActivate.Checked = True
            Me.rdoActivate.Location = New System.Drawing.Point(188, 22)
            Me.rdoActivate.Name = "rdoActivate"
            Me.rdoActivate.Size = New System.Drawing.Size(64, 17)
            Me.rdoActivate.TabIndex = 133
            Me.rdoActivate.TabStop = True
            Me.rdoActivate.Text = "Activate"
            Me.rdoActivate.UseVisualStyleBackColor = True
            '
            'lnkManageAccountById
            '
            Me.lnkManageAccountById.AutoSize = True
            Me.lnkManageAccountById.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkManageAccountById.Image = CType(resources.GetObject("lnkManageAccountById.Image"), System.Drawing.Image)
            Me.lnkManageAccountById.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkManageAccountById.Location = New System.Drawing.Point(156, 51)
            Me.lnkManageAccountById.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkManageAccountById.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkManageAccountById.Name = "lnkManageAccountById"
            Me.lnkManageAccountById.Size = New System.Drawing.Size(20, 20)
            Me.lnkManageAccountById.TabIndex = 132
            Me.lnkManageAccountById.Tag = "Learn more about ""Sign On"""
            '
            'cmdManageAccountById
            '
            Me.cmdManageAccountById.Enabled = False
            Me.cmdManageAccountById.Location = New System.Drawing.Point(17, 48)
            Me.cmdManageAccountById.Name = "cmdManageAccountById"
            Me.cmdManageAccountById.Size = New System.Drawing.Size(136, 23)
            Me.cmdManageAccountById.TabIndex = 131
            Me.cmdManageAccountById.Text = "ManageAccountById()"
            Me.cmdManageAccountById.UseVisualStyleBackColor = True
            '
            'cmdManageAccount
            '
            Me.cmdManageAccount.Enabled = False
            Me.cmdManageAccount.Location = New System.Drawing.Point(17, 19)
            Me.cmdManageAccount.Name = "cmdManageAccount"
            Me.cmdManageAccount.Size = New System.Drawing.Size(136, 23)
            Me.cmdManageAccount.TabIndex = 128
            Me.cmdManageAccount.Text = "ManageAccount()"
            Me.cmdManageAccount.UseVisualStyleBackColor = True
            '
            'lnkManageAccount
            '
            Me.lnkManageAccount.AutoSize = True
            Me.lnkManageAccount.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkManageAccount.Image = CType(resources.GetObject("lnkManageAccount.Image"), System.Drawing.Image)
            Me.lnkManageAccount.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkManageAccount.Location = New System.Drawing.Point(156, 21)
            Me.lnkManageAccount.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkManageAccount.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkManageAccount.Name = "lnkManageAccount"
            Me.lnkManageAccount.Size = New System.Drawing.Size(20, 20)
            Me.lnkManageAccount.TabIndex = 126
            Me.lnkManageAccount.Tag = "Learn more about ""Sign On"""
            '
            'ChkOnClickDisplayTxnMessage
            '
            Me.ChkOnClickDisplayTxnMessage.AutoSize = True
            Me.ChkOnClickDisplayTxnMessage.Location = New System.Drawing.Point(272, 523)
            Me.ChkOnClickDisplayTxnMessage.Name = "ChkOnClickDisplayTxnMessage"
            Me.ChkOnClickDisplayTxnMessage.Size = New System.Drawing.Size(189, 17)
            Me.ChkOnClickDisplayTxnMessage.TabIndex = 141
            Me.ChkOnClickDisplayTxnMessage.Text = "Display Transaction Detail OnClick"
            Me.ChkOnClickDisplayTxnMessage.UseVisualStyleBackColor = True
            '
            'CmdClearTransactions
            '
            Me.CmdClearTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmdClearTransactions.Location = New System.Drawing.Point(199, 520)
            Me.CmdClearTransactions.Name = "CmdClearTransactions"
            Me.CmdClearTransactions.Size = New System.Drawing.Size(69, 21)
            Me.CmdClearTransactions.TabIndex = 140
            Me.CmdClearTransactions.Text = "Clear Txns"
            Me.CmdClearTransactions.UseVisualStyleBackColor = True
            '
            'ChkLstTransactionsProcessed
            '
            Me.ChkLstTransactionsProcessed.FormattingEnabled = True
            Me.ChkLstTransactionsProcessed.HorizontalScrollbar = True
            Me.ChkLstTransactionsProcessed.IntegralHeight = False
            Me.ChkLstTransactionsProcessed.Location = New System.Drawing.Point(5, 542)
            Me.ChkLstTransactionsProcessed.Name = "ChkLstTransactionsProcessed"
            Me.ChkLstTransactionsProcessed.ScrollAlwaysVisible = True
            Me.ChkLstTransactionsProcessed.Size = New System.Drawing.Size(810, 103)
            Me.ChkLstTransactionsProcessed.TabIndex = 139
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Location = New System.Drawing.Point(3, 526)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(124, 13)
            Me.label18.TabIndex = 138
            Me.label18.Text = "Transactions Processed "
            '
            'TxtTip
            '
            Me.TxtTip.Location = New System.Drawing.Point(144, 474)
            Me.TxtTip.Name = "TxtTip"
            Me.TxtTip.Size = New System.Drawing.Size(52, 20)
            Me.TxtTip.TabIndex = 137
            Me.TxtTip.Text = "0.00"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Location = New System.Drawing.Point(124, 479)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(22, 13)
            Me.label20.TabIndex = 136
            Me.label20.Text = "Tip"
            '
            'TxtAmount
            '
            Me.TxtAmount.Location = New System.Drawing.Point(66, 474)
            Me.TxtAmount.Name = "TxtAmount"
            Me.TxtAmount.Size = New System.Drawing.Size(52, 20)
            Me.TxtAmount.TabIndex = 135
            Me.TxtAmount.Text = "10.00"
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Location = New System.Drawing.Point(7, 479)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(46, 13)
            Me.label19.TabIndex = 134
            Me.label19.Text = "Amount "
            '
            'txtCredPassword
            '
            Me.txtCredPassword.Enabled = False
            Me.txtCredPassword.Location = New System.Drawing.Point(76, 444)
            Me.txtCredPassword.Name = "txtCredPassword"
            Me.txtCredPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtCredPassword.Size = New System.Drawing.Size(118, 20)
            Me.txtCredPassword.TabIndex = 28
            '
            'txtCredUserName
            '
            Me.txtCredUserName.Enabled = False
            Me.txtCredUserName.Location = New System.Drawing.Point(76, 418)
            Me.txtCredUserName.Name = "txtCredUserName"
            Me.txtCredUserName.Size = New System.Drawing.Size(118, 20)
            Me.txtCredUserName.TabIndex = 27
            '
            'label46
            '
            Me.label46.AutoSize = True
            Me.label46.Location = New System.Drawing.Point(13, 447)
            Me.label46.Name = "label46"
            Me.label46.Size = New System.Drawing.Size(53, 13)
            Me.label46.TabIndex = 26
            Me.label46.Text = "Password"
            '
            'label45
            '
            Me.label45.AutoSize = True
            Me.label45.Location = New System.Drawing.Point(13, 421)
            Me.label45.Name = "label45"
            Me.label45.Size = New System.Drawing.Size(57, 13)
            Me.label45.TabIndex = 25
            Me.label45.Text = "UserName"
            '
            'groupBox13
            '
            Me.groupBox13.Controls.Add(Me.ChkMagensaAuthorizeAndCapture)
            Me.groupBox13.Controls.Add(Me.CmdMagensa)
            Me.groupBox13.Controls.Add(Me.ChkAcknowledge)
            Me.groupBox13.Controls.Add(Me.LnkRequestTransaction)
            Me.groupBox13.Controls.Add(Me.label1)
            Me.groupBox13.Controls.Add(Me.txtApprovalCode)
            Me.groupBox13.Controls.Add(Me.CmdRequestTransaction)
            Me.groupBox13.Controls.Add(Me.cmdForcePost)
            Me.groupBox13.Controls.Add(Me.chkL3AuthAndCapture)
            Me.groupBox13.Controls.Add(Me.lnkAcknowledge)
            Me.groupBox13.Controls.Add(Me.chkL2AuthAndCapture)
            Me.groupBox13.Controls.Add(Me.cmdPurchaseCardL3)
            Me.groupBox13.Controls.Add(Me.cmdPurchaseCardL2)
            Me.groupBox13.Controls.Add(Me.cmdCardTokenization)
            Me.groupBox13.Location = New System.Drawing.Point(538, 261)
            Me.groupBox13.Name = "groupBox13"
            Me.groupBox13.Size = New System.Drawing.Size(277, 231)
            Me.groupBox13.TabIndex = 20
            Me.groupBox13.TabStop = False
            Me.groupBox13.Text = "Additional Examples / Features"
            '
            'ChkMagensaAuthorizeAndCapture
            '
            Me.ChkMagensaAuthorizeAndCapture.AutoSize = True
            Me.ChkMagensaAuthorizeAndCapture.Enabled = False
            Me.ChkMagensaAuthorizeAndCapture.Location = New System.Drawing.Point(142, 131)
            Me.ChkMagensaAuthorizeAndCapture.Name = "ChkMagensaAuthorizeAndCapture"
            Me.ChkMagensaAuthorizeAndCapture.Size = New System.Drawing.Size(132, 17)
            Me.ChkMagensaAuthorizeAndCapture.TabIndex = 135
            Me.ChkMagensaAuthorizeAndCapture.Text = "AuthorizeAndCapture()"
            Me.ChkMagensaAuthorizeAndCapture.UseVisualStyleBackColor = True
            '
            'CmdMagensa
            '
            Me.CmdMagensa.Enabled = False
            Me.CmdMagensa.Location = New System.Drawing.Point(9, 127)
            Me.CmdMagensa.Name = "CmdMagensa"
            Me.CmdMagensa.Size = New System.Drawing.Size(127, 23)
            Me.CmdMagensa.TabIndex = 134
            Me.CmdMagensa.Text = "Magensa"
            Me.CmdMagensa.UseVisualStyleBackColor = True
            '
            'ChkAcknowledge
            '
            Me.ChkAcknowledge.AutoSize = True
            Me.ChkAcknowledge.Location = New System.Drawing.Point(9, 178)
            Me.ChkAcknowledge.Name = "ChkAcknowledge"
            Me.ChkAcknowledge.Size = New System.Drawing.Size(161, 17)
            Me.ChkAcknowledge.TabIndex = 29
            Me.ChkAcknowledge.Text = "Acknowledge() Transactions"
            Me.ChkAcknowledge.UseVisualStyleBackColor = True
            '
            'LnkRequestTransaction
            '
            Me.LnkRequestTransaction.AutoSize = True
            Me.LnkRequestTransaction.Cursor = System.Windows.Forms.Cursors.Hand
            Me.LnkRequestTransaction.Image = CType(resources.GetObject("LnkRequestTransaction.Image"), System.Drawing.Image)
            Me.LnkRequestTransaction.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.LnkRequestTransaction.Location = New System.Drawing.Point(175, 200)
            Me.LnkRequestTransaction.Margin = New System.Windows.Forms.Padding(0)
            Me.LnkRequestTransaction.MinimumSize = New System.Drawing.Size(20, 20)
            Me.LnkRequestTransaction.Name = "LnkRequestTransaction"
            Me.LnkRequestTransaction.Size = New System.Drawing.Size(20, 20)
            Me.LnkRequestTransaction.TabIndex = 131
            Me.LnkRequestTransaction.Tag = "Learn more about ""Sign On"""
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(139, 105)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(77, 13)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Approval Code"
            '
            'txtApprovalCode
            '
            Me.txtApprovalCode.Location = New System.Drawing.Point(216, 102)
            Me.txtApprovalCode.Name = "txtApprovalCode"
            Me.txtApprovalCode.Size = New System.Drawing.Size(52, 20)
            Me.txtApprovalCode.TabIndex = 6
            '
            'CmdRequestTransaction
            '
            Me.CmdRequestTransaction.Location = New System.Drawing.Point(9, 200)
            Me.CmdRequestTransaction.Name = "CmdRequestTransaction"
            Me.CmdRequestTransaction.Size = New System.Drawing.Size(136, 23)
            Me.CmdRequestTransaction.TabIndex = 130
            Me.CmdRequestTransaction.Text = "RequestTransaction()"
            Me.CmdRequestTransaction.UseVisualStyleBackColor = True
            '
            'cmdForcePost
            '
            Me.cmdForcePost.Location = New System.Drawing.Point(9, 100)
            Me.cmdForcePost.Name = "cmdForcePost"
            Me.cmdForcePost.Size = New System.Drawing.Size(127, 23)
            Me.cmdForcePost.TabIndex = 5
            Me.cmdForcePost.Text = "Force Post"
            Me.cmdForcePost.UseVisualStyleBackColor = True
            '
            'chkL3AuthAndCapture
            '
            Me.chkL3AuthAndCapture.AutoSize = True
            Me.chkL3AuthAndCapture.Enabled = False
            Me.chkL3AuthAndCapture.Location = New System.Drawing.Point(142, 56)
            Me.chkL3AuthAndCapture.Name = "chkL3AuthAndCapture"
            Me.chkL3AuthAndCapture.Size = New System.Drawing.Size(132, 17)
            Me.chkL3AuthAndCapture.TabIndex = 4
            Me.chkL3AuthAndCapture.Text = "AuthorizeAndCapture()"
            Me.chkL3AuthAndCapture.UseVisualStyleBackColor = True
            '
            'lnkAcknowledge
            '
            Me.lnkAcknowledge.AutoSize = True
            Me.lnkAcknowledge.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkAcknowledge.Image = CType(resources.GetObject("lnkAcknowledge.Image"), System.Drawing.Image)
            Me.lnkAcknowledge.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkAcknowledge.Location = New System.Drawing.Point(175, 175)
            Me.lnkAcknowledge.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkAcknowledge.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkAcknowledge.Name = "lnkAcknowledge"
            Me.lnkAcknowledge.Size = New System.Drawing.Size(20, 20)
            Me.lnkAcknowledge.TabIndex = 129
            Me.lnkAcknowledge.Tag = "Learn more about ""Sign On"""
            '
            'chkL2AuthAndCapture
            '
            Me.chkL2AuthAndCapture.AutoSize = True
            Me.chkL2AuthAndCapture.Enabled = False
            Me.chkL2AuthAndCapture.Location = New System.Drawing.Point(142, 27)
            Me.chkL2AuthAndCapture.Name = "chkL2AuthAndCapture"
            Me.chkL2AuthAndCapture.Size = New System.Drawing.Size(132, 17)
            Me.chkL2AuthAndCapture.TabIndex = 3
            Me.chkL2AuthAndCapture.Text = "AuthorizeAndCapture()"
            Me.chkL2AuthAndCapture.UseVisualStyleBackColor = True
            '
            'cmdPurchaseCardL3
            '
            Me.cmdPurchaseCardL3.Enabled = False
            Me.cmdPurchaseCardL3.Location = New System.Drawing.Point(9, 50)
            Me.cmdPurchaseCardL3.Name = "cmdPurchaseCardL3"
            Me.cmdPurchaseCardL3.Size = New System.Drawing.Size(128, 23)
            Me.cmdPurchaseCardL3.TabIndex = 2
            Me.cmdPurchaseCardL3.Text = "Purchase Card L3"
            Me.cmdPurchaseCardL3.UseVisualStyleBackColor = True
            '
            'cmdPurchaseCardL2
            '
            Me.cmdPurchaseCardL2.Enabled = False
            Me.cmdPurchaseCardL2.Location = New System.Drawing.Point(9, 23)
            Me.cmdPurchaseCardL2.Name = "cmdPurchaseCardL2"
            Me.cmdPurchaseCardL2.Size = New System.Drawing.Size(128, 23)
            Me.cmdPurchaseCardL2.TabIndex = 1
            Me.cmdPurchaseCardL2.Text = "Purchase Card L2"
            Me.cmdPurchaseCardL2.UseVisualStyleBackColor = True
            '
            'cmdCardTokenization
            '
            Me.cmdCardTokenization.Enabled = False
            Me.cmdCardTokenization.Location = New System.Drawing.Point(9, 75)
            Me.cmdCardTokenization.Name = "cmdCardTokenization"
            Me.cmdCardTokenization.Size = New System.Drawing.Size(128, 23)
            Me.cmdCardTokenization.TabIndex = 0
            Me.cmdCardTokenization.Text = "Card Tokenization"
            Me.cmdCardTokenization.UseVisualStyleBackColor = True
            '
            'groupBox9
            '
            Me.groupBox9.Controls.Add(Me.lnkVerify)
            Me.groupBox9.Controls.Add(Me.lnkQueryAccount)
            Me.groupBox9.Controls.Add(Me.cmdQueryAccount)
            Me.groupBox9.Controls.Add(Me.cmdVerify)
            Me.groupBox9.Location = New System.Drawing.Point(538, 175)
            Me.groupBox9.Name = "groupBox9"
            Me.groupBox9.Size = New System.Drawing.Size(274, 80)
            Me.groupBox9.TabIndex = 15
            Me.groupBox9.TabStop = False
            Me.groupBox9.Text = "Optional Operations Step 9"
            '
            'lnkVerify
            '
            Me.lnkVerify.AutoSize = True
            Me.lnkVerify.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkVerify.Image = CType(resources.GetObject("lnkVerify.Image"), System.Drawing.Image)
            Me.lnkVerify.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkVerify.Location = New System.Drawing.Point(149, 46)
            Me.lnkVerify.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkVerify.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkVerify.Name = "lnkVerify"
            Me.lnkVerify.Size = New System.Drawing.Size(20, 20)
            Me.lnkVerify.TabIndex = 127
            Me.lnkVerify.Tag = "Learn more about ""Sign On"""
            '
            'lnkQueryAccount
            '
            Me.lnkQueryAccount.AutoSize = True
            Me.lnkQueryAccount.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkQueryAccount.Image = CType(resources.GetObject("lnkQueryAccount.Image"), System.Drawing.Image)
            Me.lnkQueryAccount.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkQueryAccount.Location = New System.Drawing.Point(149, 20)
            Me.lnkQueryAccount.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkQueryAccount.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkQueryAccount.Name = "lnkQueryAccount"
            Me.lnkQueryAccount.Size = New System.Drawing.Size(20, 20)
            Me.lnkQueryAccount.TabIndex = 126
            Me.lnkQueryAccount.Tag = "Learn more about ""Sign On"""
            '
            'cmdQueryAccount
            '
            Me.cmdQueryAccount.Enabled = False
            Me.cmdQueryAccount.Location = New System.Drawing.Point(9, 20)
            Me.cmdQueryAccount.Name = "cmdQueryAccount"
            Me.cmdQueryAccount.Size = New System.Drawing.Size(136, 23)
            Me.cmdQueryAccount.TabIndex = 8
            Me.cmdQueryAccount.Text = "9. QueryAccount()"
            Me.cmdQueryAccount.UseVisualStyleBackColor = True
            '
            'cmdVerify
            '
            Me.cmdVerify.Enabled = False
            Me.cmdVerify.Location = New System.Drawing.Point(9, 46)
            Me.cmdVerify.Name = "cmdVerify"
            Me.cmdVerify.Size = New System.Drawing.Size(136, 23)
            Me.cmdVerify.TabIndex = 9
            Me.cmdVerify.Text = "9. Verify() AVSONLY"
            Me.cmdVerify.UseVisualStyleBackColor = True
            '
            'groupBox8
            '
            Me.groupBox8.Controls.Add(Me.lnkReturnUnlinked)
            Me.groupBox8.Controls.Add(Me.lnkReturnById)
            Me.groupBox8.Controls.Add(Me.cmdReturnById)
            Me.groupBox8.Controls.Add(Me.cmdReturnUnlinked)
            Me.groupBox8.Location = New System.Drawing.Point(202, 336)
            Me.groupBox8.Name = "groupBox8"
            Me.groupBox8.Size = New System.Drawing.Size(330, 81)
            Me.groupBox8.TabIndex = 14
            Me.groupBox8.TabStop = False
            Me.groupBox8.Text = "Refunding Step 8"
            '
            'lnkReturnUnlinked
            '
            Me.lnkReturnUnlinked.AutoSize = True
            Me.lnkReturnUnlinked.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkReturnUnlinked.Image = CType(resources.GetObject("lnkReturnUnlinked.Image"), System.Drawing.Image)
            Me.lnkReturnUnlinked.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkReturnUnlinked.Location = New System.Drawing.Point(165, 48)
            Me.lnkReturnUnlinked.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkReturnUnlinked.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkReturnUnlinked.Name = "lnkReturnUnlinked"
            Me.lnkReturnUnlinked.Size = New System.Drawing.Size(20, 20)
            Me.lnkReturnUnlinked.TabIndex = 127
            Me.lnkReturnUnlinked.Tag = "Learn more about ""Sign On"""
            '
            'lnkReturnById
            '
            Me.lnkReturnById.AutoSize = True
            Me.lnkReturnById.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkReturnById.Image = CType(resources.GetObject("lnkReturnById.Image"), System.Drawing.Image)
            Me.lnkReturnById.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkReturnById.Location = New System.Drawing.Point(165, 19)
            Me.lnkReturnById.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkReturnById.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkReturnById.Name = "lnkReturnById"
            Me.lnkReturnById.Size = New System.Drawing.Size(20, 20)
            Me.lnkReturnById.TabIndex = 126
            Me.lnkReturnById.Tag = "Learn more about ""Sign On"""
            '
            'cmdReturnById
            '
            Me.cmdReturnById.Enabled = False
            Me.cmdReturnById.Location = New System.Drawing.Point(17, 19)
            Me.cmdReturnById.Name = "cmdReturnById"
            Me.cmdReturnById.Size = New System.Drawing.Size(149, 23)
            Me.cmdReturnById.TabIndex = 5
            Me.cmdReturnById.Text = "8. ReturnById()"
            Me.cmdReturnById.UseVisualStyleBackColor = True
            '
            'cmdReturnUnlinked
            '
            Me.cmdReturnUnlinked.Enabled = False
            Me.cmdReturnUnlinked.Location = New System.Drawing.Point(17, 48)
            Me.cmdReturnUnlinked.Name = "cmdReturnUnlinked"
            Me.cmdReturnUnlinked.Size = New System.Drawing.Size(149, 23)
            Me.cmdReturnUnlinked.TabIndex = 6
            Me.cmdReturnUnlinked.Text = "8. ReturnUnlinked()"
            Me.cmdReturnUnlinked.UseVisualStyleBackColor = True
            '
            'groupBox7
            '
            Me.groupBox7.Controls.Add(Me.groupBox14)
            Me.groupBox7.Controls.Add(Me.ChkMultiplePartialCapture)
            Me.groupBox7.Controls.Add(Me.lnkCapture)
            Me.groupBox7.Controls.Add(Me.cmdCapture)
            Me.groupBox7.Location = New System.Drawing.Point(202, 175)
            Me.groupBox7.Name = "groupBox7"
            Me.groupBox7.Size = New System.Drawing.Size(330, 155)
            Me.groupBox7.TabIndex = 13
            Me.groupBox7.TabStop = False
            Me.groupBox7.Text = "Capturing for Settlement Step 7"
            '
            'groupBox14
            '
            Me.groupBox14.Controls.Add(Me.ChkForceCloseBatch)
            Me.groupBox14.Controls.Add(Me.cmdCaptureAll)
            Me.groupBox14.Controls.Add(Me.ChkCapSelectiveDiffData)
            Me.groupBox14.Controls.Add(Me.cmdCaptureSelective)
            Me.groupBox14.Controls.Add(Me.lnkCaptureAll)
            Me.groupBox14.Controls.Add(Me.lnkCaptureSelective)
            Me.groupBox14.Controls.Add(Me.chkCaptureAllAndSelectiveAsync)
            Me.groupBox14.Location = New System.Drawing.Point(6, 55)
            Me.groupBox14.Name = "groupBox14"
            Me.groupBox14.Size = New System.Drawing.Size(318, 94)
            Me.groupBox14.TabIndex = 139
            Me.groupBox14.TabStop = False
            Me.groupBox14.Text = "Settlement"
            '
            'ChkForceCloseBatch
            '
            Me.ChkForceCloseBatch.AutoSize = True
            Me.ChkForceCloseBatch.Enabled = False
            Me.ChkForceCloseBatch.Location = New System.Drawing.Point(192, 25)
            Me.ChkForceCloseBatch.Name = "ChkForceCloseBatch"
            Me.ChkForceCloseBatch.Size = New System.Drawing.Size(113, 17)
            Me.ChkForceCloseBatch.TabIndex = 133
            Me.ChkForceCloseBatch.Text = "Force Close Batch"
            Me.ChkForceCloseBatch.UseVisualStyleBackColor = True
            '
            'cmdCaptureAll
            '
            Me.cmdCaptureAll.Enabled = False
            Me.cmdCaptureAll.Location = New System.Drawing.Point(7, 19)
            Me.cmdCaptureAll.Name = "cmdCaptureAll"
            Me.cmdCaptureAll.Size = New System.Drawing.Size(149, 23)
            Me.cmdCaptureAll.TabIndex = 3
            Me.cmdCaptureAll.Text = "7. CaptureAll()"
            Me.cmdCaptureAll.UseVisualStyleBackColor = True
            '
            'ChkCapSelectiveDiffData
            '
            Me.ChkCapSelectiveDiffData.AutoSize = True
            Me.ChkCapSelectiveDiffData.Location = New System.Drawing.Point(247, 54)
            Me.ChkCapSelectiveDiffData.Name = "ChkCapSelectiveDiffData"
            Me.ChkCapSelectiveDiffData.Size = New System.Drawing.Size(68, 17)
            Me.ChkCapSelectiveDiffData.TabIndex = 132
            Me.ChkCapSelectiveDiffData.Text = "Diff Data"
            Me.ChkCapSelectiveDiffData.UseVisualStyleBackColor = True
            '
            'cmdCaptureSelective
            '
            Me.cmdCaptureSelective.Enabled = False
            Me.cmdCaptureSelective.Location = New System.Drawing.Point(7, 48)
            Me.cmdCaptureSelective.Name = "cmdCaptureSelective"
            Me.cmdCaptureSelective.Size = New System.Drawing.Size(149, 23)
            Me.cmdCaptureSelective.TabIndex = 4
            Me.cmdCaptureSelective.Text = "7. CaptureSelective()"
            Me.cmdCaptureSelective.UseVisualStyleBackColor = True
            '
            'lnkCaptureAll
            '
            Me.lnkCaptureAll.AutoSize = True
            Me.lnkCaptureAll.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkCaptureAll.Image = CType(resources.GetObject("lnkCaptureAll.Image"), System.Drawing.Image)
            Me.lnkCaptureAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkCaptureAll.Location = New System.Drawing.Point(159, 20)
            Me.lnkCaptureAll.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkCaptureAll.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkCaptureAll.Name = "lnkCaptureAll"
            Me.lnkCaptureAll.Size = New System.Drawing.Size(20, 20)
            Me.lnkCaptureAll.TabIndex = 127
            Me.lnkCaptureAll.Tag = "Learn more about ""Sign On"""
            '
            'lnkCaptureSelective
            '
            Me.lnkCaptureSelective.AutoSize = True
            Me.lnkCaptureSelective.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkCaptureSelective.Image = CType(resources.GetObject("lnkCaptureSelective.Image"), System.Drawing.Image)
            Me.lnkCaptureSelective.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkCaptureSelective.Location = New System.Drawing.Point(159, 48)
            Me.lnkCaptureSelective.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkCaptureSelective.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkCaptureSelective.Name = "lnkCaptureSelective"
            Me.lnkCaptureSelective.Size = New System.Drawing.Size(20, 20)
            Me.lnkCaptureSelective.TabIndex = 128
            Me.lnkCaptureSelective.Tag = "Learn more about ""Sign On"""
            '
            'chkCaptureAllAndSelectiveAsync
            '
            Me.chkCaptureAllAndSelectiveAsync.AutoSize = True
            Me.chkCaptureAllAndSelectiveAsync.Enabled = False
            Me.chkCaptureAllAndSelectiveAsync.Location = New System.Drawing.Point(192, 54)
            Me.chkCaptureAllAndSelectiveAsync.Name = "chkCaptureAllAndSelectiveAsync"
            Me.chkCaptureAllAndSelectiveAsync.Size = New System.Drawing.Size(55, 17)
            Me.chkCaptureAllAndSelectiveAsync.TabIndex = 129
            Me.chkCaptureAllAndSelectiveAsync.Text = "Async"
            Me.chkCaptureAllAndSelectiveAsync.UseVisualStyleBackColor = True
            '
            'ChkMultiplePartialCapture
            '
            Me.ChkMultiplePartialCapture.AutoSize = True
            Me.ChkMultiplePartialCapture.Location = New System.Drawing.Point(196, 23)
            Me.ChkMultiplePartialCapture.Name = "ChkMultiplePartialCapture"
            Me.ChkMultiplePartialCapture.Size = New System.Drawing.Size(128, 17)
            Me.ChkMultiplePartialCapture.TabIndex = 138
            Me.ChkMultiplePartialCapture.Text = "MultiplePartialCapture"
            Me.ChkMultiplePartialCapture.UseVisualStyleBackColor = True
            '
            'lnkCapture
            '
            Me.lnkCapture.AutoSize = True
            Me.lnkCapture.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkCapture.Image = CType(resources.GetObject("lnkCapture.Image"), System.Drawing.Image)
            Me.lnkCapture.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkCapture.Location = New System.Drawing.Point(165, 19)
            Me.lnkCapture.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkCapture.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkCapture.Name = "lnkCapture"
            Me.lnkCapture.Size = New System.Drawing.Size(20, 20)
            Me.lnkCapture.TabIndex = 126
            Me.lnkCapture.Tag = "Learn more about ""Sign On"""
            '
            'cmdCapture
            '
            Me.cmdCapture.Enabled = False
            Me.cmdCapture.Location = New System.Drawing.Point(13, 19)
            Me.cmdCapture.Name = "cmdCapture"
            Me.cmdCapture.Size = New System.Drawing.Size(149, 23)
            Me.cmdCapture.TabIndex = 2
            Me.cmdCapture.Text = "7. Capture()"
            Me.cmdCapture.UseVisualStyleBackColor = True
            '
            'groupBox6
            '
            Me.groupBox6.Controls.Add(Me.ChkForceVoid)
            Me.groupBox6.Controls.Add(Me.lnkUndo)
            Me.groupBox6.Controls.Add(Me.lnkAdjust)
            Me.groupBox6.Controls.Add(Me.cmdAdjust)
            Me.groupBox6.Controls.Add(Me.cmdUndo)
            Me.groupBox6.Location = New System.Drawing.Point(6, 311)
            Me.groupBox6.Name = "groupBox6"
            Me.groupBox6.Size = New System.Drawing.Size(190, 98)
            Me.groupBox6.TabIndex = 12
            Me.groupBox6.TabStop = False
            Me.groupBox6.Text = "Adjusting and Voiding Step 6"
            '
            'ChkForceVoid
            '
            Me.ChkForceVoid.AutoSize = True
            Me.ChkForceVoid.Checked = True
            Me.ChkForceVoid.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ChkForceVoid.Enabled = False
            Me.ChkForceVoid.Location = New System.Drawing.Point(6, 77)
            Me.ChkForceVoid.Name = "ChkForceVoid"
            Me.ChkForceVoid.Size = New System.Drawing.Size(77, 17)
            Me.ChkForceVoid.TabIndex = 134
            Me.ChkForceVoid.Text = "Force Void"
            Me.ChkForceVoid.UseVisualStyleBackColor = True
            '
            'lnkUndo
            '
            Me.lnkUndo.AutoSize = True
            Me.lnkUndo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkUndo.Image = CType(resources.GetObject("lnkUndo.Image"), System.Drawing.Image)
            Me.lnkUndo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkUndo.Location = New System.Drawing.Point(156, 48)
            Me.lnkUndo.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkUndo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkUndo.Name = "lnkUndo"
            Me.lnkUndo.Size = New System.Drawing.Size(20, 20)
            Me.lnkUndo.TabIndex = 127
            Me.lnkUndo.Tag = "Learn more about ""Sign On"""
            '
            'lnkAdjust
            '
            Me.lnkAdjust.AutoSize = True
            Me.lnkAdjust.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkAdjust.Image = CType(resources.GetObject("lnkAdjust.Image"), System.Drawing.Image)
            Me.lnkAdjust.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkAdjust.Location = New System.Drawing.Point(156, 19)
            Me.lnkAdjust.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkAdjust.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkAdjust.Name = "lnkAdjust"
            Me.lnkAdjust.Size = New System.Drawing.Size(20, 20)
            Me.lnkAdjust.TabIndex = 126
            Me.lnkAdjust.Tag = "Learn more about ""Sign On"""
            '
            'cmdAdjust
            '
            Me.cmdAdjust.Enabled = False
            Me.cmdAdjust.Location = New System.Drawing.Point(6, 19)
            Me.cmdAdjust.Name = "cmdAdjust"
            Me.cmdAdjust.Size = New System.Drawing.Size(147, 23)
            Me.cmdAdjust.TabIndex = 8
            Me.cmdAdjust.Text = "Adjust()"
            Me.cmdAdjust.UseVisualStyleBackColor = True
            '
            'cmdUndo
            '
            Me.cmdUndo.Enabled = False
            Me.cmdUndo.Location = New System.Drawing.Point(6, 48)
            Me.cmdUndo.Name = "cmdUndo"
            Me.cmdUndo.Size = New System.Drawing.Size(147, 23)
            Me.cmdUndo.TabIndex = 7
            Me.cmdUndo.Text = "Undo() VOID"
            Me.cmdUndo.UseVisualStyleBackColor = True
            '
            'groupBox5
            '
            Me.groupBox5.Controls.Add(Me.ChkUserWorkflowId)
            Me.groupBox5.Controls.Add(Me.ChkAllowPartialApprovals)
            Me.groupBox5.Controls.Add(Me.lnkAuthorize)
            Me.groupBox5.Controls.Add(Me.lnkAuthorizeAndCapture)
            Me.groupBox5.Controls.Add(Me.cmdAuthorize)
            Me.groupBox5.Controls.Add(Me.cmdAuthorizeAndCapture)
            Me.groupBox5.Location = New System.Drawing.Point(6, 175)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(190, 130)
            Me.groupBox5.TabIndex = 11
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Authorizing Step 5"
            '
            'ChkUserWorkflowId
            '
            Me.ChkUserWorkflowId.AutoSize = True
            Me.ChkUserWorkflowId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ChkUserWorkflowId.ForeColor = System.Drawing.Color.IndianRed
            Me.ChkUserWorkflowId.Location = New System.Drawing.Point(6, 102)
            Me.ChkUserWorkflowId.Name = "ChkUserWorkflowId"
            Me.ChkUserWorkflowId.Size = New System.Drawing.Size(105, 17)
            Me.ChkUserWorkflowId.TabIndex = 136
            Me.ChkUserWorkflowId.Text = "Use Workflow Id"
            Me.ChkUserWorkflowId.UseVisualStyleBackColor = True
            '
            'ChkAllowPartialApprovals
            '
            Me.ChkAllowPartialApprovals.AutoSize = True
            Me.ChkAllowPartialApprovals.Enabled = False
            Me.ChkAllowPartialApprovals.Location = New System.Drawing.Point(6, 80)
            Me.ChkAllowPartialApprovals.Name = "ChkAllowPartialApprovals"
            Me.ChkAllowPartialApprovals.Size = New System.Drawing.Size(133, 17)
            Me.ChkAllowPartialApprovals.TabIndex = 135
            Me.ChkAllowPartialApprovals.Text = "Allow Partial Approvals"
            Me.ChkAllowPartialApprovals.UseVisualStyleBackColor = True
            '
            'lnkAuthorize
            '
            Me.lnkAuthorize.AutoSize = True
            Me.lnkAuthorize.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkAuthorize.Image = CType(resources.GetObject("lnkAuthorize.Image"), System.Drawing.Image)
            Me.lnkAuthorize.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkAuthorize.Location = New System.Drawing.Point(156, 48)
            Me.lnkAuthorize.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkAuthorize.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkAuthorize.Name = "lnkAuthorize"
            Me.lnkAuthorize.Size = New System.Drawing.Size(20, 20)
            Me.lnkAuthorize.TabIndex = 127
            Me.lnkAuthorize.Tag = "Learn more about ""Sign On"""
            '
            'lnkAuthorizeAndCapture
            '
            Me.lnkAuthorizeAndCapture.AutoSize = True
            Me.lnkAuthorizeAndCapture.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkAuthorizeAndCapture.Image = CType(resources.GetObject("lnkAuthorizeAndCapture.Image"), System.Drawing.Image)
            Me.lnkAuthorizeAndCapture.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkAuthorizeAndCapture.Location = New System.Drawing.Point(156, 20)
            Me.lnkAuthorizeAndCapture.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkAuthorizeAndCapture.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkAuthorizeAndCapture.Name = "lnkAuthorizeAndCapture"
            Me.lnkAuthorizeAndCapture.Size = New System.Drawing.Size(20, 20)
            Me.lnkAuthorizeAndCapture.TabIndex = 126
            Me.lnkAuthorizeAndCapture.Tag = "Learn more about ""Sign On"""
            Me.lnkAuthorizeAndCapture.UseCompatibleTextRendering = True
            '
            'cmdAuthorize
            '
            Me.cmdAuthorize.Enabled = False
            Me.cmdAuthorize.Location = New System.Drawing.Point(6, 48)
            Me.cmdAuthorize.Name = "cmdAuthorize"
            Me.cmdAuthorize.Size = New System.Drawing.Size(147, 23)
            Me.cmdAuthorize.TabIndex = 1
            Me.cmdAuthorize.Text = "Authorize()"
            Me.cmdAuthorize.UseVisualStyleBackColor = True
            '
            'cmdAuthorizeAndCapture
            '
            Me.cmdAuthorizeAndCapture.Enabled = False
            Me.cmdAuthorizeAndCapture.Location = New System.Drawing.Point(6, 19)
            Me.cmdAuthorizeAndCapture.Name = "cmdAuthorizeAndCapture"
            Me.cmdAuthorizeAndCapture.Size = New System.Drawing.Size(147, 23)
            Me.cmdAuthorizeAndCapture.TabIndex = 0
            Me.cmdAuthorizeAndCapture.Text = "AuthorizeAndCapture()"
            Me.cmdAuthorizeAndCapture.UseVisualStyleBackColor = True
            '
            'pictureBox2
            '
            Me.pictureBox2.ImageLocation = ""
            Me.pictureBox2.Location = New System.Drawing.Point(6, 19)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(806, 150)
            Me.pictureBox2.TabIndex = 10
            Me.pictureBox2.TabStop = False
            '
            'tbPreparingApplicationToTransact
            '
            Me.tbPreparingApplicationToTransact.Controls.Add(Me.groupBox1)
            Me.tbPreparingApplicationToTransact.Location = New System.Drawing.Point(4, 25)
            Me.tbPreparingApplicationToTransact.Name = "tbPreparingApplicationToTransact"
            Me.tbPreparingApplicationToTransact.Padding = New System.Windows.Forms.Padding(3)
            Me.tbPreparingApplicationToTransact.Size = New System.Drawing.Size(836, 766)
            Me.tbPreparingApplicationToTransact.TabIndex = 1
            Me.tbPreparingApplicationToTransact.Text = "Preparing the Application to Transact"
            Me.tbPreparingApplicationToTransact.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.linkPreparingAppToTransact)
            Me.groupBox1.Controls.Add(Me.ckBoxDelegatedSignOn)
            Me.groupBox1.Controls.Add(Me.txtDelegatedServiceKey)
            Me.groupBox1.Controls.Add(Me.lnkLblDelegatedSignOn)
            Me.groupBox1.Controls.Add(Me.CmdManageMerchantData)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.CboWorkFlowIdsByServiceId)
            Me.groupBox1.Controls.Add(Me.cmdSignOnWithToken)
            Me.groupBox1.Controls.Add(Me.picArrow)
            Me.groupBox1.Controls.Add(Me.lnkRetrieveServiceInformation)
            Me.groupBox1.Controls.Add(Me.lnkManageApplicationData)
            Me.groupBox1.Controls.Add(Me.lnkSignOnWithToken)
            Me.groupBox1.Controls.Add(Me.lblIsProfileInitialized)
            Me.groupBox1.Controls.Add(Me.label22)
            Me.groupBox1.Controls.Add(Me.txtAboutTheService)
            Me.groupBox1.Controls.Add(Me.groupBox10)
            Me.groupBox1.Controls.Add(Me.pictureBox1)
            Me.groupBox1.Controls.Add(Me.label17)
            Me.groupBox1.Controls.Add(Me.label16)
            Me.groupBox1.Controls.Add(Me.label15)
            Me.groupBox1.Controls.Add(Me.label14)
            Me.groupBox1.Controls.Add(Me.label13)
            Me.groupBox1.Controls.Add(Me.label12)
            Me.groupBox1.Controls.Add(Me.label11)
            Me.groupBox1.Controls.Add(Me.cboAvailableProfiles)
            Me.groupBox1.Controls.Add(Me.label10)
            Me.groupBox1.Controls.Add(Me.cboAvailableServices)
            Me.groupBox1.Controls.Add(Me.chkStep2)
            Me.groupBox1.Controls.Add(Me.chkStep3)
            Me.groupBox1.Controls.Add(Me.chkStep1)
            Me.groupBox1.Controls.Add(Me.cmdRetrieveServiceInformation)
            Me.groupBox1.Controls.Add(Me.cmdManageApplicationData)
            Me.groupBox1.Location = New System.Drawing.Point(20, 15)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(807, 660)
            Me.groupBox1.TabIndex = 6
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Preparing the Application to Transact"
            '
            'linkPreparingAppToTransact
            '
            Me.linkPreparingAppToTransact.AutoSize = True
            Me.linkPreparingAppToTransact.Cursor = System.Windows.Forms.Cursors.Hand
            Me.linkPreparingAppToTransact.Image = CType(resources.GetObject("linkPreparingAppToTransact.Image"), System.Drawing.Image)
            Me.linkPreparingAppToTransact.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.linkPreparingAppToTransact.Location = New System.Drawing.Point(774, 19)
            Me.linkPreparingAppToTransact.Margin = New System.Windows.Forms.Padding(0)
            Me.linkPreparingAppToTransact.MinimumSize = New System.Drawing.Size(20, 20)
            Me.linkPreparingAppToTransact.Name = "linkPreparingAppToTransact"
            Me.linkPreparingAppToTransact.Size = New System.Drawing.Size(20, 20)
            Me.linkPreparingAppToTransact.TabIndex = 144
            Me.linkPreparingAppToTransact.Tag = "Learn more about ""Sign On"""
            Me.linkPreparingAppToTransact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ckBoxDelegatedSignOn
            '
            Me.ckBoxDelegatedSignOn.AutoSize = True
            Me.ckBoxDelegatedSignOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ckBoxDelegatedSignOn.ForeColor = System.Drawing.Color.SteelBlue
            Me.ckBoxDelegatedSignOn.Location = New System.Drawing.Point(317, 102)
            Me.ckBoxDelegatedSignOn.Name = "ckBoxDelegatedSignOn"
            Me.ckBoxDelegatedSignOn.Size = New System.Drawing.Size(250, 17)
            Me.ckBoxDelegatedSignOn.TabIndex = 143
            Me.ckBoxDelegatedSignOn.Text = "Use Delegated SignOn : Service Key ->"
            Me.ckBoxDelegatedSignOn.UseVisualStyleBackColor = True
            '
            'txtDelegatedServiceKey
            '
            Me.txtDelegatedServiceKey.Location = New System.Drawing.Point(566, 99)
            Me.txtDelegatedServiceKey.Name = "txtDelegatedServiceKey"
            Me.txtDelegatedServiceKey.Size = New System.Drawing.Size(198, 20)
            Me.txtDelegatedServiceKey.TabIndex = 142
            '
            'lnkLblDelegatedSignOn
            '
            Me.lnkLblDelegatedSignOn.AutoSize = True
            Me.lnkLblDelegatedSignOn.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkLblDelegatedSignOn.Image = CType(resources.GetObject("lnkLblDelegatedSignOn.Image"), System.Drawing.Image)
            Me.lnkLblDelegatedSignOn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkLblDelegatedSignOn.Location = New System.Drawing.Point(774, 97)
            Me.lnkLblDelegatedSignOn.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkLblDelegatedSignOn.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkLblDelegatedSignOn.Name = "lnkLblDelegatedSignOn"
            Me.lnkLblDelegatedSignOn.Size = New System.Drawing.Size(20, 20)
            Me.lnkLblDelegatedSignOn.TabIndex = 141
            Me.lnkLblDelegatedSignOn.Tag = "Learn more about ""Delegated Sign On"""
            '
            'CmdManageMerchantData
            '
            Me.CmdManageMerchantData.AccessibleDescription = "txtStoreId"
            Me.CmdManageMerchantData.Enabled = False
            Me.CmdManageMerchantData.Location = New System.Drawing.Point(45, 309)
            Me.CmdManageMerchantData.Name = "CmdManageMerchantData"
            Me.CmdManageMerchantData.Size = New System.Drawing.Size(218, 23)
            Me.CmdManageMerchantData.TabIndex = 140
            Me.CmdManageMerchantData.Text = "Step 4: Manage Merchant Data"
            Me.CmdManageMerchantData.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(61, 221)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(177, 13)
            Me.label3.TabIndex = 130
            Me.label3.Text = "Available WorkFlowIds by ServiceId"
            '
            'CboWorkFlowIdsByServiceId
            '
            Me.CboWorkFlowIdsByServiceId.FormattingEnabled = True
            Me.CboWorkFlowIdsByServiceId.Location = New System.Drawing.Point(64, 237)
            Me.CboWorkFlowIdsByServiceId.Name = "CboWorkFlowIdsByServiceId"
            Me.CboWorkFlowIdsByServiceId.Size = New System.Drawing.Size(248, 21)
            Me.CboWorkFlowIdsByServiceId.TabIndex = 129
            '
            'cmdSignOnWithToken
            '
            Me.cmdSignOnWithToken.Location = New System.Drawing.Point(45, 98)
            Me.cmdSignOnWithToken.Name = "cmdSignOnWithToken"
            Me.cmdSignOnWithToken.Size = New System.Drawing.Size(216, 23)
            Me.cmdSignOnWithToken.TabIndex = 2
            Me.cmdSignOnWithToken.Text = "Step 1: Sign On With Token"
            Me.cmdSignOnWithToken.UseVisualStyleBackColor = True
            '
            'picArrow
            '
            Me.picArrow.InitialImage = Nothing
            Me.picArrow.Location = New System.Drawing.Point(317, 192)
            Me.picArrow.Name = "picArrow"
            Me.picArrow.Size = New System.Drawing.Size(149, 24)
            Me.picArrow.TabIndex = 126
            Me.picArrow.TabStop = False
            Me.picArrow.Visible = False
            '
            'lnkRetrieveServiceInformation
            '
            Me.lnkRetrieveServiceInformation.AutoSize = True
            Me.lnkRetrieveServiceInformation.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkRetrieveServiceInformation.Image = CType(resources.GetObject("lnkRetrieveServiceInformation.Image"), System.Drawing.Image)
            Me.lnkRetrieveServiceInformation.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkRetrieveServiceInformation.Location = New System.Drawing.Point(291, 156)
            Me.lnkRetrieveServiceInformation.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkRetrieveServiceInformation.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkRetrieveServiceInformation.Name = "lnkRetrieveServiceInformation"
            Me.lnkRetrieveServiceInformation.Size = New System.Drawing.Size(20, 20)
            Me.lnkRetrieveServiceInformation.TabIndex = 124
            Me.lnkRetrieveServiceInformation.Tag = "Learn more about ""Sign On"""
            '
            'lnkManageApplicationData
            '
            Me.lnkManageApplicationData.AutoSize = True
            Me.lnkManageApplicationData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkManageApplicationData.Image = CType(resources.GetObject("lnkManageApplicationData.Image"), System.Drawing.Image)
            Me.lnkManageApplicationData.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkManageApplicationData.Location = New System.Drawing.Point(291, 127)
            Me.lnkManageApplicationData.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkManageApplicationData.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkManageApplicationData.Name = "lnkManageApplicationData"
            Me.lnkManageApplicationData.Size = New System.Drawing.Size(20, 20)
            Me.lnkManageApplicationData.TabIndex = 123
            Me.lnkManageApplicationData.Tag = "Learn more about ""Sign On"""
            '
            'lnkSignOnWithToken
            '
            Me.lnkSignOnWithToken.AutoSize = True
            Me.lnkSignOnWithToken.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkSignOnWithToken.Image = CType(resources.GetObject("lnkSignOnWithToken.Image"), System.Drawing.Image)
            Me.lnkSignOnWithToken.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkSignOnWithToken.Location = New System.Drawing.Point(291, 97)
            Me.lnkSignOnWithToken.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkSignOnWithToken.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkSignOnWithToken.Name = "lnkSignOnWithToken"
            Me.lnkSignOnWithToken.Size = New System.Drawing.Size(20, 20)
            Me.lnkSignOnWithToken.TabIndex = 122
            Me.lnkSignOnWithToken.Tag = "Learn more about ""Sign On"""
            '
            'lblIsProfileInitialized
            '
            Me.lblIsProfileInitialized.AutoSize = True
            Me.lblIsProfileInitialized.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIsProfileInitialized.ForeColor = System.Drawing.Color.Green
            Me.lblIsProfileInitialized.Location = New System.Drawing.Point(267, 239)
            Me.lblIsProfileInitialized.Name = "lblIsProfileInitialized"
            Me.lblIsProfileInitialized.Size = New System.Drawing.Size(0, 15)
            Me.lblIsProfileInitialized.TabIndex = 121
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Location = New System.Drawing.Point(465, 127)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(189, 13)
            Me.label22.TabIndex = 120
            Me.label22.Text = "Information about the selected Service"
            '
            'txtAboutTheService
            '
            Me.txtAboutTheService.BackColor = System.Drawing.SystemColors.Menu
            Me.txtAboutTheService.Location = New System.Drawing.Point(468, 143)
            Me.txtAboutTheService.Multiline = True
            Me.txtAboutTheService.Name = "txtAboutTheService"
            Me.txtAboutTheService.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtAboutTheService.Size = New System.Drawing.Size(303, 497)
            Me.txtAboutTheService.TabIndex = 0
            '
            'groupBox10
            '
            Me.groupBox10.Controls.Add(Me.chkEncryptIdentityToken)
            Me.groupBox10.Controls.Add(Me.cmdPersistConfig)
            Me.groupBox10.Controls.Add(Me.txtPersistedAndCached)
            Me.groupBox10.Controls.Add(Me.cmdDeletePersistCached)
            Me.groupBox10.Location = New System.Drawing.Point(26, 338)
            Me.groupBox10.Name = "groupBox10"
            Me.groupBox10.Size = New System.Drawing.Size(428, 140)
            Me.groupBox10.TabIndex = 119
            Me.groupBox10.TabStop = False
            Me.groupBox10.Text = "Service Information Configuration Values Needed for Transaction Processing"
            '
            'chkEncryptIdentityToken
            '
            Me.chkEncryptIdentityToken.AutoSize = True
            Me.chkEncryptIdentityToken.Checked = True
            Me.chkEncryptIdentityToken.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkEncryptIdentityToken.Location = New System.Drawing.Point(103, 25)
            Me.chkEncryptIdentityToken.Name = "chkEncryptIdentityToken"
            Me.chkEncryptIdentityToken.Size = New System.Drawing.Size(183, 17)
            Me.chkEncryptIdentityToken.TabIndex = 121
            Me.chkEncryptIdentityToken.Text = "Safely Encrypt the Identity Token"
            Me.chkEncryptIdentityToken.UseVisualStyleBackColor = True
            '
            'cmdPersistConfig
            '
            Me.cmdPersistConfig.Enabled = False
            Me.cmdPersistConfig.Location = New System.Drawing.Point(7, 21)
            Me.cmdPersistConfig.Name = "cmdPersistConfig"
            Me.cmdPersistConfig.Size = New System.Drawing.Size(90, 23)
            Me.cmdPersistConfig.TabIndex = 120
            Me.cmdPersistConfig.Text = "Persist Config"
            Me.cmdPersistConfig.UseVisualStyleBackColor = True
            '
            'txtPersistedAndCached
            '
            Me.txtPersistedAndCached.BackColor = System.Drawing.SystemColors.Control
            Me.txtPersistedAndCached.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.txtPersistedAndCached.Location = New System.Drawing.Point(6, 50)
            Me.txtPersistedAndCached.Multiline = True
            Me.txtPersistedAndCached.Name = "txtPersistedAndCached"
            Me.txtPersistedAndCached.Size = New System.Drawing.Size(416, 74)
            Me.txtPersistedAndCached.TabIndex = 17
            '
            'cmdDeletePersistCached
            '
            Me.cmdDeletePersistCached.Enabled = False
            Me.cmdDeletePersistCached.Location = New System.Drawing.Point(332, 21)
            Me.cmdDeletePersistCached.Name = "cmdDeletePersistCached"
            Me.cmdDeletePersistCached.Size = New System.Drawing.Size(90, 23)
            Me.cmdDeletePersistCached.TabIndex = 119
            Me.cmdDeletePersistCached.Text = "Delete"
            Me.cmdDeletePersistCached.UseVisualStyleBackColor = True
            '
            'pictureBox1
            '
            Me.pictureBox1.ImageLocation = ""
            Me.pictureBox1.Location = New System.Drawing.Point(6, 19)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(765, 69)
            Me.pictureBox1.TabIndex = 7
            Me.pictureBox1.TabStop = False
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label17.ForeColor = System.Drawing.Color.RoyalBlue
            Me.label17.Location = New System.Drawing.Point(23, 640)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(431, 15)
            Me.label17.TabIndex = 22
            Me.label17.Text = "* - Values that can and should be Persisted/cached for Transaction Processing"
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label16.ForeColor = System.Drawing.Color.Red
            Me.label16.Location = New System.Drawing.Point(23, 625)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(380, 15)
            Me.label16.TabIndex = 21
            Me.label16.Text = "* - Required for both Service Information and Transaction Processing"
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label15.ForeColor = System.Drawing.Color.RoyalBlue
            Me.label15.Location = New System.Drawing.Point(22, 266)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(17, 24)
            Me.label15.TabIndex = 17
            Me.label15.Text = "*"
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label14.ForeColor = System.Drawing.Color.RoyalBlue
            Me.label14.Location = New System.Drawing.Point(22, 195)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(17, 24)
            Me.label14.TabIndex = 16
            Me.label14.Text = "*"
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label13.ForeColor = System.Drawing.Color.RoyalBlue
            Me.label13.Location = New System.Drawing.Point(22, 132)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(17, 24)
            Me.label13.TabIndex = 15
            Me.label13.Text = "*"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.ForeColor = System.Drawing.Color.Red
            Me.label12.Location = New System.Drawing.Point(22, 101)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(17, 24)
            Me.label12.TabIndex = 14
            Me.label12.Text = "*"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(40, 266)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(93, 13)
            Me.label11.TabIndex = 13
            Me.label11.Text = "Available Profile(s)"
            '
            'cboAvailableProfiles
            '
            Me.cboAvailableProfiles.FormattingEnabled = True
            Me.cboAvailableProfiles.Location = New System.Drawing.Point(43, 282)
            Me.cboAvailableProfiles.Name = "cboAvailableProfiles"
            Me.cboAvailableProfiles.Size = New System.Drawing.Size(268, 21)
            Me.cboAvailableProfiles.TabIndex = 12
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(40, 179)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(100, 13)
            Me.label10.TabIndex = 11
            Me.label10.Text = "Available Service(s)"
            '
            'cboAvailableServices
            '
            Me.cboAvailableServices.FormattingEnabled = True
            Me.cboAvailableServices.Location = New System.Drawing.Point(43, 195)
            Me.cboAvailableServices.Name = "cboAvailableServices"
            Me.cboAvailableServices.Size = New System.Drawing.Size(268, 21)
            Me.cboAvailableServices.TabIndex = 10
            '
            'chkStep2
            '
            Me.chkStep2.AutoSize = True
            Me.chkStep2.Location = New System.Drawing.Point(273, 132)
            Me.chkStep2.Name = "chkStep2"
            Me.chkStep2.Size = New System.Drawing.Size(15, 14)
            Me.chkStep2.TabIndex = 8
            Me.chkStep2.UseVisualStyleBackColor = True
            '
            'chkStep3
            '
            Me.chkStep3.AutoSize = True
            Me.chkStep3.Location = New System.Drawing.Point(273, 161)
            Me.chkStep3.Name = "chkStep3"
            Me.chkStep3.Size = New System.Drawing.Size(15, 14)
            Me.chkStep3.TabIndex = 7
            Me.chkStep3.UseVisualStyleBackColor = True
            '
            'chkStep1
            '
            Me.chkStep1.AutoSize = True
            Me.chkStep1.Location = New System.Drawing.Point(273, 102)
            Me.chkStep1.Name = "chkStep1"
            Me.chkStep1.Size = New System.Drawing.Size(15, 14)
            Me.chkStep1.TabIndex = 6
            Me.chkStep1.UseVisualStyleBackColor = True
            '
            'cmdRetrieveServiceInformation
            '
            Me.cmdRetrieveServiceInformation.Enabled = False
            Me.cmdRetrieveServiceInformation.Location = New System.Drawing.Point(45, 154)
            Me.cmdRetrieveServiceInformation.Name = "cmdRetrieveServiceInformation"
            Me.cmdRetrieveServiceInformation.Size = New System.Drawing.Size(218, 23)
            Me.cmdRetrieveServiceInformation.TabIndex = 3
            Me.cmdRetrieveServiceInformation.Text = "Step 3: Retrieving Service Information"
            Me.cmdRetrieveServiceInformation.UseVisualStyleBackColor = True
            '
            'cmdManageApplicationData
            '
            Me.cmdManageApplicationData.Enabled = False
            Me.cmdManageApplicationData.Location = New System.Drawing.Point(43, 127)
            Me.cmdManageApplicationData.Name = "cmdManageApplicationData"
            Me.cmdManageApplicationData.Size = New System.Drawing.Size(218, 23)
            Me.cmdManageApplicationData.TabIndex = 4
            Me.cmdManageApplicationData.Text = "Step 2: Manage Application Data"
            Me.cmdManageApplicationData.UseVisualStyleBackColor = True
            '
            'tbIntroduction
            '
            Me.tbIntroduction.Controls.Add(Me.lnkServiceKey)
            Me.tbIntroduction.Controls.Add(Me.label35)
            Me.tbIntroduction.Controls.Add(Me.CboindustryType)
            Me.tbIntroduction.Controls.Add(Me.TxtServiceKey)
            Me.tbIntroduction.Controls.Add(Me.cmdPopulateWithMyTestValues)
            Me.tbIntroduction.Controls.Add(Me.lnkAccessingWebServiceEndpoints)
            Me.tbIntroduction.Controls.Add(Me.cmdGo)
            Me.tbIntroduction.Controls.Add(Me.txtIntroduction)
            Me.tbIntroduction.Controls.Add(Me.txtIdentityToken)
            Me.tbIntroduction.Controls.Add(Me.lnkIdentityToken)
            Me.tbIntroduction.Controls.Add(Me.label24)
            Me.tbIntroduction.Controls.Add(Me.groupBox3)
            Me.tbIntroduction.Controls.Add(Me.label21)
            Me.tbIntroduction.Controls.Add(Me.groupBox12)
            Me.tbIntroduction.Controls.Add(Me.label2)
            Me.tbIntroduction.Location = New System.Drawing.Point(4, 25)
            Me.tbIntroduction.Name = "tbIntroduction"
            Me.tbIntroduction.Padding = New System.Windows.Forms.Padding(3)
            Me.tbIntroduction.Size = New System.Drawing.Size(836, 766)
            Me.tbIntroduction.TabIndex = 0
            Me.tbIntroduction.Text = "Introduction"
            Me.tbIntroduction.UseVisualStyleBackColor = True
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.Location = New System.Drawing.Point(195, 257)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(204, 13)
            Me.label35.TabIndex = 146
            Me.label35.Text = "Application is configured for IndustryType:"
            '
            'CboindustryType
            '
            Me.CboindustryType.FormattingEnabled = True
            Me.CboindustryType.Items.AddRange(New Object() {"Ecommerce", "MOTO", "Retail", "Restaurant"})
            Me.CboindustryType.Location = New System.Drawing.Point(402, 254)
            Me.CboindustryType.Name = "CboindustryType"
            Me.CboindustryType.Size = New System.Drawing.Size(99, 21)
            Me.CboindustryType.TabIndex = 145
            '
            'TxtServiceKey
            '
            Me.TxtServiceKey.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TxtServiceKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtServiceKey.ForeColor = System.Drawing.Color.OrangeRed
            Me.TxtServiceKey.Location = New System.Drawing.Point(265, 229)
            Me.TxtServiceKey.Name = "TxtServiceKey"
            Me.TxtServiceKey.Size = New System.Drawing.Size(236, 14)
            Me.TxtServiceKey.TabIndex = 133
            Me.TxtServiceKey.Text = "Service Key: "
            Me.TxtServiceKey.Visible = False
            '
            'cmdPopulateWithMyTestValues
            '
            Me.cmdPopulateWithMyTestValues.Location = New System.Drawing.Point(522, 253)
            Me.cmdPopulateWithMyTestValues.Name = "cmdPopulateWithMyTestValues"
            Me.cmdPopulateWithMyTestValues.Size = New System.Drawing.Size(160, 23)
            Me.cmdPopulateWithMyTestValues.TabIndex = 130
            Me.cmdPopulateWithMyTestValues.Text = "Populate With My Test Values"
            Me.cmdPopulateWithMyTestValues.UseVisualStyleBackColor = True
            '
            'lnkAccessingWebServiceEndpoints
            '
            Me.lnkAccessingWebServiceEndpoints.AutoSize = True
            Me.lnkAccessingWebServiceEndpoints.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkAccessingWebServiceEndpoints.Image = CType(resources.GetObject("lnkAccessingWebServiceEndpoints.Image"), System.Drawing.Image)
            Me.lnkAccessingWebServiceEndpoints.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkAccessingWebServiceEndpoints.Location = New System.Drawing.Point(510, 371)
            Me.lnkAccessingWebServiceEndpoints.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkAccessingWebServiceEndpoints.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkAccessingWebServiceEndpoints.Name = "lnkAccessingWebServiceEndpoints"
            Me.lnkAccessingWebServiceEndpoints.Size = New System.Drawing.Size(20, 20)
            Me.lnkAccessingWebServiceEndpoints.TabIndex = 124
            Me.lnkAccessingWebServiceEndpoints.Tag = ""
            '
            'cmdGo
            '
            Me.cmdGo.Location = New System.Drawing.Point(432, 604)
            Me.cmdGo.Name = "cmdGo"
            Me.cmdGo.Size = New System.Drawing.Size(75, 23)
            Me.cmdGo.TabIndex = 128
            Me.cmdGo.Text = "Go"
            Me.cmdGo.UseVisualStyleBackColor = True
            '
            'txtIntroduction
            '
            Me.txtIntroduction.AcceptsReturn = True
            Me.txtIntroduction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.txtIntroduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIntroduction.Location = New System.Drawing.Point(22, 50)
            Me.txtIntroduction.Multiline = True
            Me.txtIntroduction.Name = "txtIntroduction"
            Me.txtIntroduction.ReadOnly = True
            Me.txtIntroduction.Size = New System.Drawing.Size(789, 155)
            Me.txtIntroduction.TabIndex = 3
            '
            'txtIdentityToken
            '
            Me.txtIdentityToken.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtIdentityToken.Location = New System.Drawing.Point(19, 283)
            Me.txtIdentityToken.Multiline = True
            Me.txtIdentityToken.Name = "txtIdentityToken"
            Me.txtIdentityToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtIdentityToken.Size = New System.Drawing.Size(482, 70)
            Me.txtIdentityToken.TabIndex = 4
            '
            'lnkIdentityToken
            '
            Me.lnkIdentityToken.AutoSize = True
            Me.lnkIdentityToken.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkIdentityToken.Image = CType(resources.GetObject("lnkIdentityToken.Image"), System.Drawing.Image)
            Me.lnkIdentityToken.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkIdentityToken.Location = New System.Drawing.Point(510, 283)
            Me.lnkIdentityToken.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkIdentityToken.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkIdentityToken.Name = "lnkIdentityToken"
            Me.lnkIdentityToken.Size = New System.Drawing.Size(20, 20)
            Me.lnkIdentityToken.TabIndex = 124
            Me.lnkIdentityToken.Tag = "Learn more about ""Sign On"""
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.label24.Location = New System.Drawing.Point(18, 219)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(102, 24)
            Me.label24.TabIndex = 118
            Me.label24.Text = "Let's Begin"
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.label31)
            Me.groupBox3.Controls.Add(Me.label32)
            Me.groupBox3.Controls.Add(Me.label30)
            Me.groupBox3.Controls.Add(Me.txtTMSSecondary)
            Me.groupBox3.Controls.Add(Me.txtTMSPrimary)
            Me.groupBox3.Controls.Add(Me.label5)
            Me.groupBox3.Controls.Add(Me.txtTxnSecondary)
            Me.groupBox3.Controls.Add(Me.label4)
            Me.groupBox3.Controls.Add(Me.txtTxnPrimary)
            Me.groupBox3.Controls.Add(Me.label6)
            Me.groupBox3.Controls.Add(Me.txtSvcSecondary)
            Me.groupBox3.Controls.Add(Me.label7)
            Me.groupBox3.Controls.Add(Me.txtSvcPrimary)
            Me.groupBox3.Controls.Add(Me.label9)
            Me.groupBox3.Controls.Add(Me.label8)
            Me.groupBox3.Location = New System.Drawing.Point(19, 359)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(485, 239)
            Me.groupBox3.TabIndex = 114
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Accessing Web Service Endpoints"
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Location = New System.Drawing.Point(14, 184)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(41, 13)
            Me.label31.TabIndex = 118
            Me.label31.Text = "Primary"
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Location = New System.Drawing.Point(14, 209)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(58, 13)
            Me.label32.TabIndex = 119
            Me.label32.Text = "Secondary"
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Location = New System.Drawing.Point(6, 161)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(199, 13)
            Me.label30.TabIndex = 117
            Me.label30.Text = "Transaction Management Service (TMS)"
            '
            'txtTMSSecondary
            '
            Me.txtTMSSecondary.Location = New System.Drawing.Point(76, 202)
            Me.txtTMSSecondary.Name = "txtTMSSecondary"
            Me.txtTMSSecondary.Size = New System.Drawing.Size(403, 20)
            Me.txtTMSSecondary.TabIndex = 116
            '
            'txtTMSPrimary
            '
            Me.txtTMSPrimary.Location = New System.Drawing.Point(76, 177)
            Me.txtTMSPrimary.Name = "txtTMSPrimary"
            Me.txtTMSPrimary.Size = New System.Drawing.Size(403, 20)
            Me.txtTMSPrimary.TabIndex = 115
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(6, 89)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(118, 13)
            Me.label5.TabIndex = 105
            Me.label5.Text = "Transaction Processing"
            '
            'txtTxnSecondary
            '
            Me.txtTxnSecondary.Location = New System.Drawing.Point(76, 130)
            Me.txtTxnSecondary.Name = "txtTxnSecondary"
            Me.txtTxnSecondary.Size = New System.Drawing.Size(403, 20)
            Me.txtTxnSecondary.TabIndex = 8
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(6, 21)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(97, 13)
            Me.label4.TabIndex = 104
            Me.label4.Text = "Service information"
            '
            'txtTxnPrimary
            '
            Me.txtTxnPrimary.Location = New System.Drawing.Point(76, 105)
            Me.txtTxnPrimary.Name = "txtTxnPrimary"
            Me.txtTxnPrimary.Size = New System.Drawing.Size(403, 20)
            Me.txtTxnPrimary.TabIndex = 7
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(14, 45)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(41, 13)
            Me.label6.TabIndex = 106
            Me.label6.Text = "Primary"
            '
            'txtSvcSecondary
            '
            Me.txtSvcSecondary.Location = New System.Drawing.Point(76, 63)
            Me.txtSvcSecondary.Name = "txtSvcSecondary"
            Me.txtSvcSecondary.Size = New System.Drawing.Size(403, 20)
            Me.txtSvcSecondary.TabIndex = 6
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(14, 69)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(58, 13)
            Me.label7.TabIndex = 107
            Me.label7.Text = "Secondary"
            '
            'txtSvcPrimary
            '
            Me.txtSvcPrimary.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtSvcPrimary.Location = New System.Drawing.Point(76, 37)
            Me.txtSvcPrimary.Name = "txtSvcPrimary"
            Me.txtSvcPrimary.Size = New System.Drawing.Size(403, 20)
            Me.txtSvcPrimary.TabIndex = 5
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(14, 112)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(41, 13)
            Me.label9.TabIndex = 108
            Me.label9.Text = "Primary"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(14, 137)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(58, 13)
            Me.label8.TabIndex = 109
            Me.label8.Text = "Secondary"
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.label21.Location = New System.Drawing.Point(19, 23)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(286, 24)
            Me.label21.TabIndex = 2
            Me.label21.Text = "Commerce Web Services (CWS)"
            '
            'groupBox12
            '
            Me.groupBox12.Controls.Add(Me.txtDisclaimer)
            Me.groupBox12.Location = New System.Drawing.Point(19, 633)
            Me.groupBox12.Name = "groupBox12"
            Me.groupBox12.Size = New System.Drawing.Size(792, 125)
            Me.groupBox12.TabIndex = 1
            Me.groupBox12.TabStop = False
            Me.groupBox12.Text = "Disclaimer"
            '
            'txtDisclaimer
            '
            Me.txtDisclaimer.Location = New System.Drawing.Point(6, 19)
            Me.txtDisclaimer.Multiline = True
            Me.txtDisclaimer.Name = "txtDisclaimer"
            Me.txtDisclaimer.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtDisclaimer.Size = New System.Drawing.Size(780, 100)
            Me.txtDisclaimer.TabIndex = 0
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(19, 267)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(75, 13)
            Me.label2.TabIndex = 100
            Me.label2.Text = "Identity Token"
            '
            'tbTransactionData
            '
            Me.tbTransactionData.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
            Me.tbTransactionData.Controls.Add(Me.tbIntroduction)
            Me.tbTransactionData.Controls.Add(Me.tbPreparingApplicationToTransact)
            Me.tbTransactionData.Controls.Add(Me.tbTransactionProcessing)
            Me.tbTransactionData.Controls.Add(Me.TabPage1)
            Me.tbTransactionData.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.tbTransactionData.Location = New System.Drawing.Point(12, 12)
            Me.tbTransactionData.Name = "tbTransactionData"
            Me.tbTransactionData.SelectedIndex = 0
            Me.tbTransactionData.Size = New System.Drawing.Size(844, 795)
            Me.tbTransactionData.TabIndex = 9
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.GrpTokenization)
            Me.TabPage1.Controls.Add(Me.GrpTrackDataFromMSR)
            Me.TabPage1.Controls.Add(Me.grpProcessasPINLessDebit)
            Me.TabPage1.Controls.Add(Me.GrpCNP)
            Me.TabPage1.Location = New System.Drawing.Point(4, 25)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(836, 766)
            Me.TabPage1.TabIndex = 3
            Me.TabPage1.Text = "Processing Data"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'GrpTokenization
            '
            Me.GrpTokenization.Controls.Add(Me.ChkTokenization)
            Me.GrpTokenization.Controls.Add(Me.CboTokenizedCard)
            Me.GrpTokenization.Controls.Add(Me.label27)
            Me.GrpTokenization.Location = New System.Drawing.Point(6, 309)
            Me.GrpTokenization.Name = "GrpTokenization"
            Me.GrpTokenization.Size = New System.Drawing.Size(316, 65)
            Me.GrpTokenization.TabIndex = 148
            Me.GrpTokenization.TabStop = False
            Me.GrpTokenization.Text = "Tokenization"
            '
            'ChkTokenization
            '
            Me.ChkTokenization.AutoSize = True
            Me.ChkTokenization.Location = New System.Drawing.Point(295, 16)
            Me.ChkTokenization.Name = "ChkTokenization"
            Me.ChkTokenization.Size = New System.Drawing.Size(15, 14)
            Me.ChkTokenization.TabIndex = 141
            Me.ChkTokenization.UseVisualStyleBackColor = True
            '
            'CboTokenizedCard
            '
            Me.CboTokenizedCard.FormattingEnabled = True
            Me.CboTokenizedCard.Location = New System.Drawing.Point(14, 32)
            Me.CboTokenizedCard.Name = "CboTokenizedCard"
            Me.CboTokenizedCard.Size = New System.Drawing.Size(296, 21)
            Me.CboTokenizedCard.TabIndex = 7
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Location = New System.Drawing.Point(11, 16)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(151, 13)
            Me.label27.TabIndex = 8
            Me.label27.Text = "Payment Account Data Token"
            '
            'GrpTrackDataFromMSR
            '
            Me.GrpTrackDataFromMSR.Controls.Add(Me.ChkTrackDataFromMSR)
            Me.GrpTrackDataFromMSR.Controls.Add(Me.grpPinDebit)
            Me.GrpTrackDataFromMSR.Controls.Add(Me.TxtTrackDataFromMSR)
            Me.GrpTrackDataFromMSR.Location = New System.Drawing.Point(6, 142)
            Me.GrpTrackDataFromMSR.Name = "GrpTrackDataFromMSR"
            Me.GrpTrackDataFromMSR.Size = New System.Drawing.Size(316, 161)
            Me.GrpTrackDataFromMSR.TabIndex = 149
            Me.GrpTrackDataFromMSR.TabStop = False
            Me.GrpTrackDataFromMSR.Text = "Track Data from MSR"
            '
            'ChkTrackDataFromMSR
            '
            Me.ChkTrackDataFromMSR.AutoSize = True
            Me.ChkTrackDataFromMSR.Location = New System.Drawing.Point(295, 19)
            Me.ChkTrackDataFromMSR.Name = "ChkTrackDataFromMSR"
            Me.ChkTrackDataFromMSR.Size = New System.Drawing.Size(15, 14)
            Me.ChkTrackDataFromMSR.TabIndex = 140
            Me.ChkTrackDataFromMSR.UseVisualStyleBackColor = True
            '
            'grpPinDebit
            '
            Me.grpPinDebit.Controls.Add(Me.chkProcessAsPINDebitTxn)
            Me.grpPinDebit.Controls.Add(Me.TxtEncryptedPIN)
            Me.grpPinDebit.Controls.Add(Me.label34)
            Me.grpPinDebit.Controls.Add(Me.TxtKeySerialNumber)
            Me.grpPinDebit.Controls.Add(Me.label33)
            Me.grpPinDebit.Controls.Add(Me.TxtCashBack)
            Me.grpPinDebit.Controls.Add(Me.label29)
            Me.grpPinDebit.Location = New System.Drawing.Point(6, 62)
            Me.grpPinDebit.Name = "grpPinDebit"
            Me.grpPinDebit.Size = New System.Drawing.Size(304, 93)
            Me.grpPinDebit.TabIndex = 145
            Me.grpPinDebit.TabStop = False
            Me.grpPinDebit.Text = "Process as PINDebit Transaction"
            '
            'chkProcessAsPINDebitTxn
            '
            Me.chkProcessAsPINDebitTxn.AutoSize = True
            Me.chkProcessAsPINDebitTxn.Location = New System.Drawing.Point(289, 17)
            Me.chkProcessAsPINDebitTxn.Name = "chkProcessAsPINDebitTxn"
            Me.chkProcessAsPINDebitTxn.Size = New System.Drawing.Size(15, 14)
            Me.chkProcessAsPINDebitTxn.TabIndex = 148
            Me.chkProcessAsPINDebitTxn.UseVisualStyleBackColor = True
            '
            'TxtEncryptedPIN
            '
            Me.TxtEncryptedPIN.Location = New System.Drawing.Point(105, 44)
            Me.TxtEncryptedPIN.Name = "TxtEncryptedPIN"
            Me.TxtEncryptedPIN.Size = New System.Drawing.Size(168, 20)
            Me.TxtEncryptedPIN.TabIndex = 147
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Location = New System.Drawing.Point(5, 47)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(76, 13)
            Me.label34.TabIndex = 146
            Me.label34.Text = "Encrypted PIN"
            '
            'TxtKeySerialNumber
            '
            Me.TxtKeySerialNumber.Location = New System.Drawing.Point(105, 18)
            Me.TxtKeySerialNumber.Name = "TxtKeySerialNumber"
            Me.TxtKeySerialNumber.Size = New System.Drawing.Size(168, 20)
            Me.TxtKeySerialNumber.TabIndex = 145
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Location = New System.Drawing.Point(5, 21)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(94, 13)
            Me.label33.TabIndex = 144
            Me.label33.Text = "Key Serial Number"
            '
            'TxtCashBack
            '
            Me.TxtCashBack.Location = New System.Drawing.Point(144, 70)
            Me.TxtCashBack.Name = "TxtCashBack"
            Me.TxtCashBack.Size = New System.Drawing.Size(52, 20)
            Me.TxtCashBack.TabIndex = 143
            Me.TxtCashBack.Text = "0.00"
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(5, 73)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(133, 13)
            Me.label29.TabIndex = 142
            Me.label29.Text = "Cash Back (PINDebit only)"
            '
            'TxtTrackDataFromMSR
            '
            Me.TxtTrackDataFromMSR.Location = New System.Drawing.Point(14, 36)
            Me.TxtTrackDataFromMSR.Name = "TxtTrackDataFromMSR"
            Me.TxtTrackDataFromMSR.Size = New System.Drawing.Size(296, 20)
            Me.TxtTrackDataFromMSR.TabIndex = 6
            '
            'grpProcessasPINLessDebit
            '
            Me.grpProcessasPINLessDebit.Controls.Add(Me.ChkProcessAsPINLessDebit)
            Me.grpProcessasPINLessDebit.Location = New System.Drawing.Point(6, 380)
            Me.grpProcessasPINLessDebit.Name = "grpProcessasPINLessDebit"
            Me.grpProcessasPINLessDebit.Size = New System.Drawing.Size(316, 49)
            Me.grpProcessasPINLessDebit.TabIndex = 150
            Me.grpProcessasPINLessDebit.TabStop = False
            Me.grpProcessasPINLessDebit.Text = "Process As PINLess Debit"
            '
            'ChkProcessAsPINLessDebit
            '
            Me.ChkProcessAsPINLessDebit.AutoSize = True
            Me.ChkProcessAsPINLessDebit.Location = New System.Drawing.Point(295, 19)
            Me.ChkProcessAsPINLessDebit.Name = "ChkProcessAsPINLessDebit"
            Me.ChkProcessAsPINLessDebit.Size = New System.Drawing.Size(15, 14)
            Me.ChkProcessAsPINLessDebit.TabIndex = 30
            Me.ChkProcessAsPINLessDebit.UseVisualStyleBackColor = True
            '
            'GrpCNP
            '
            Me.GrpCNP.Controls.Add(Me.ChkCardNotPresent)
            Me.GrpCNP.Controls.Add(Me.TxtPAN)
            Me.GrpCNP.Controls.Add(Me.label23)
            Me.GrpCNP.Controls.Add(Me.label25)
            Me.GrpCNP.Controls.Add(Me.TxtExpirationDate)
            Me.GrpCNP.Controls.Add(Me.label26)
            Me.GrpCNP.Controls.Add(Me.CboCardTypes)
            Me.GrpCNP.Location = New System.Drawing.Point(6, 39)
            Me.GrpCNP.Name = "GrpCNP"
            Me.GrpCNP.Size = New System.Drawing.Size(316, 101)
            Me.GrpCNP.TabIndex = 147
            Me.GrpCNP.TabStop = False
            Me.GrpCNP.Text = "Card Not Present"
            '
            'ChkCardNotPresent
            '
            Me.ChkCardNotPresent.AutoSize = True
            Me.ChkCardNotPresent.Checked = True
            Me.ChkCardNotPresent.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ChkCardNotPresent.Location = New System.Drawing.Point(295, 18)
            Me.ChkCardNotPresent.Name = "ChkCardNotPresent"
            Me.ChkCardNotPresent.Size = New System.Drawing.Size(15, 14)
            Me.ChkCardNotPresent.TabIndex = 139
            Me.ChkCardNotPresent.UseVisualStyleBackColor = True
            '
            'TxtPAN
            '
            Me.TxtPAN.Location = New System.Drawing.Point(96, 71)
            Me.TxtPAN.Name = "TxtPAN"
            Me.TxtPAN.Size = New System.Drawing.Size(183, 20)
            Me.TxtPAN.TabIndex = 5
            Me.TxtPAN.Text = "5499990123456781"
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Location = New System.Drawing.Point(11, 21)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(53, 13)
            Me.label23.TabIndex = 0
            Me.label23.Text = "CardType"
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Location = New System.Drawing.Point(11, 48)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(79, 13)
            Me.label25.TabIndex = 1
            Me.label25.Text = "Expiration Date"
            '
            'TxtExpirationDate
            '
            Me.TxtExpirationDate.Location = New System.Drawing.Point(96, 45)
            Me.TxtExpirationDate.Name = "TxtExpirationDate"
            Me.TxtExpirationDate.Size = New System.Drawing.Size(183, 20)
            Me.TxtExpirationDate.TabIndex = 2
            Me.TxtExpirationDate.Text = "1215"
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Location = New System.Drawing.Point(11, 74)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(29, 13)
            Me.label26.TabIndex = 3
            Me.label26.Text = "PAN"
            '
            'CboCardTypes
            '
            Me.CboCardTypes.FormattingEnabled = True
            Me.CboCardTypes.Location = New System.Drawing.Point(96, 18)
            Me.CboCardTypes.Name = "CboCardTypes"
            Me.CboCardTypes.Size = New System.Drawing.Size(183, 21)
            Me.CboCardTypes.TabIndex = 6
            '
            'lnkServiceKey
            '
            Me.lnkServiceKey.AutoSize = True
            Me.lnkServiceKey.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkServiceKey.Image = CType(resources.GetObject("lnkServiceKey.Image"), System.Drawing.Image)
            Me.lnkServiceKey.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkServiceKey.Location = New System.Drawing.Point(242, 227)
            Me.lnkServiceKey.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkServiceKey.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkServiceKey.Name = "lnkServiceKey"
            Me.lnkServiceKey.Size = New System.Drawing.Size(20, 20)
            Me.lnkServiceKey.TabIndex = 147
            Me.lnkServiceKey.Tag = ""
            '
            'SampleCode_DeskTop
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(885, 761)
        Me.Controls.Add(Me.lnkOnlineDocumentation)
        Me.Controls.Add(Me.tbTransactionData)
        Me.ForeColor = System.Drawing.Color.DarkMagenta
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "SampleCode_DeskTop"
        Me.Text = "Sample Code - CWS 1.17.19"
        Me.tbTransactionProcessing.ResumeLayout(false)
        Me.tbTransactionProcessing.PerformLayout
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.groupBox2.ResumeLayout(false)
        Me.groupBox2.PerformLayout
        Me.groupBox11.ResumeLayout(false)
        Me.groupBox11.PerformLayout
        Me.groupBox13.ResumeLayout(false)
        Me.groupBox13.PerformLayout
        Me.groupBox9.ResumeLayout(false)
        Me.groupBox9.PerformLayout
        Me.groupBox8.ResumeLayout(false)
        Me.groupBox8.PerformLayout
        Me.groupBox7.ResumeLayout(false)
        Me.groupBox7.PerformLayout
        Me.groupBox14.ResumeLayout(false)
        Me.groupBox14.PerformLayout
        Me.groupBox6.ResumeLayout(false)
        Me.groupBox6.PerformLayout
        Me.groupBox5.ResumeLayout(false)
        Me.groupBox5.PerformLayout
        CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbPreparingApplicationToTransact.ResumeLayout(false)
        Me.groupBox1.ResumeLayout(false)
        Me.groupBox1.PerformLayout
        CType(Me.picArrow,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox10.ResumeLayout(false)
        Me.groupBox10.PerformLayout
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbIntroduction.ResumeLayout(false)
        Me.tbIntroduction.PerformLayout
        Me.groupBox3.ResumeLayout(false)
        Me.groupBox3.PerformLayout
        Me.groupBox12.ResumeLayout(false)
        Me.groupBox12.PerformLayout
        Me.tbTransactionData.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.GrpTokenization.ResumeLayout(false)
        Me.GrpTokenization.PerformLayout
        Me.GrpTrackDataFromMSR.ResumeLayout(false)
        Me.GrpTrackDataFromMSR.PerformLayout
        Me.grpPinDebit.ResumeLayout(false)
        Me.grpPinDebit.PerformLayout
        Me.grpProcessasPINLessDebit.ResumeLayout(false)
        Me.grpProcessasPINLessDebit.PerformLayout
        Me.GrpCNP.ResumeLayout(false)
        Me.GrpCNP.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

        Private WithEvents lnkOnlineDocumentation As System.Windows.Forms.LinkLabel
        Private WithEvents tmrServiceArrow As System.Windows.Forms.Timer
        Private WithEvents tbTransactionProcessing As System.Windows.Forms.TabPage
        Private WithEvents lblCurrentServiceClass As System.Windows.Forms.Label
        Private WithEvents lblCurrentService As System.Windows.Forms.Label
        Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
        Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents txtCredPassword As System.Windows.Forms.TextBox
        Private WithEvents txtCredUserName As System.Windows.Forms.TextBox
        Private WithEvents label46 As System.Windows.Forms.Label
        Private WithEvents label45 As System.Windows.Forms.Label
        Private WithEvents groupBox13 As System.Windows.Forms.GroupBox
        Private WithEvents ChkAcknowledge As System.Windows.Forms.CheckBox
        Private WithEvents LnkRequestTransaction As System.Windows.Forms.LinkLabel
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents txtApprovalCode As System.Windows.Forms.TextBox
        Private WithEvents CmdRequestTransaction As System.Windows.Forms.Button
        Private WithEvents cmdForcePost As System.Windows.Forms.Button
        Private WithEvents chkL3AuthAndCapture As System.Windows.Forms.CheckBox
        Private WithEvents lnkAcknowledge As System.Windows.Forms.LinkLabel
        Private WithEvents chkL2AuthAndCapture As System.Windows.Forms.CheckBox
        Private WithEvents cmdPurchaseCardL3 As System.Windows.Forms.Button
        Private WithEvents cmdPurchaseCardL2 As System.Windows.Forms.Button
        Private WithEvents cmdCardTokenization As System.Windows.Forms.Button
        Private WithEvents groupBox9 As System.Windows.Forms.GroupBox
        Private WithEvents lnkVerify As System.Windows.Forms.LinkLabel
        Private WithEvents lnkQueryAccount As System.Windows.Forms.LinkLabel
        Private WithEvents cmdQueryAccount As System.Windows.Forms.Button
        Private WithEvents cmdVerify As System.Windows.Forms.Button
        Private WithEvents groupBox8 As System.Windows.Forms.GroupBox
        Private WithEvents lnkReturnUnlinked As System.Windows.Forms.LinkLabel
        Private WithEvents lnkReturnById As System.Windows.Forms.LinkLabel
        Private WithEvents cmdReturnById As System.Windows.Forms.Button
        Private WithEvents cmdReturnUnlinked As System.Windows.Forms.Button
        Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
        Private WithEvents lnkCapture As System.Windows.Forms.LinkLabel
        Private WithEvents cmdCapture As System.Windows.Forms.Button
        Private WithEvents groupBox6 As System.Windows.Forms.GroupBox
        Private WithEvents lnkUndo As System.Windows.Forms.LinkLabel
        Private WithEvents lnkAdjust As System.Windows.Forms.LinkLabel
        Private WithEvents cmdAdjust As System.Windows.Forms.Button
        Private WithEvents cmdUndo As System.Windows.Forms.Button
        Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
        Private WithEvents lnkAuthorize As System.Windows.Forms.LinkLabel
        Private WithEvents lnkAuthorizeAndCapture As System.Windows.Forms.LinkLabel
        Private WithEvents cmdAuthorize As System.Windows.Forms.Button
        Private WithEvents cmdAuthorizeAndCapture As System.Windows.Forms.Button
        Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
        Private WithEvents tbPreparingApplicationToTransact As System.Windows.Forms.TabPage
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents cmdSignOnWithToken As System.Windows.Forms.Button
        Private WithEvents picArrow As System.Windows.Forms.PictureBox
        Private WithEvents lnkRetrieveServiceInformation As System.Windows.Forms.LinkLabel
        Private WithEvents lnkManageApplicationData As System.Windows.Forms.LinkLabel
        Private WithEvents lnkSignOnWithToken As System.Windows.Forms.LinkLabel
        Private WithEvents lblIsProfileInitialized As System.Windows.Forms.Label
        Private WithEvents label22 As System.Windows.Forms.Label
        Private WithEvents txtAboutTheService As System.Windows.Forms.TextBox
        Private WithEvents groupBox10 As System.Windows.Forms.GroupBox
        Private WithEvents chkEncryptIdentityToken As System.Windows.Forms.CheckBox
        Private WithEvents cmdPersistConfig As System.Windows.Forms.Button
        Private WithEvents txtPersistedAndCached As System.Windows.Forms.TextBox
        Private WithEvents cmdDeletePersistCached As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label17 As System.Windows.Forms.Label
        Private WithEvents label16 As System.Windows.Forms.Label
        Private WithEvents label15 As System.Windows.Forms.Label
        Private WithEvents label14 As System.Windows.Forms.Label
        Private WithEvents label13 As System.Windows.Forms.Label
        Private WithEvents label12 As System.Windows.Forms.Label
        Private WithEvents label11 As System.Windows.Forms.Label
        Public WithEvents cboAvailableProfiles As System.Windows.Forms.ComboBox
        Private WithEvents label10 As System.Windows.Forms.Label
        Private WithEvents cboAvailableServices As System.Windows.Forms.ComboBox
        Public WithEvents chkStep2 As System.Windows.Forms.CheckBox
        Private WithEvents chkStep3 As System.Windows.Forms.CheckBox
        Private WithEvents chkStep1 As System.Windows.Forms.CheckBox
        Private WithEvents cmdRetrieveServiceInformation As System.Windows.Forms.Button
        Private WithEvents cmdManageApplicationData As System.Windows.Forms.Button
        Private WithEvents tbIntroduction As System.Windows.Forms.TabPage
        Private WithEvents cmdPopulateWithMyTestValues As System.Windows.Forms.Button
        Private WithEvents lnkAccessingWebServiceEndpoints As System.Windows.Forms.LinkLabel
        Private WithEvents cmdGo As System.Windows.Forms.Button
        Private WithEvents txtIntroduction As System.Windows.Forms.TextBox
        Private WithEvents txtIdentityToken As System.Windows.Forms.TextBox
        Private WithEvents lnkIdentityToken As System.Windows.Forms.LinkLabel
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents txtTxnSecondary As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents txtTxnPrimary As System.Windows.Forms.TextBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents txtSvcSecondary As System.Windows.Forms.TextBox
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents txtSvcPrimary As System.Windows.Forms.TextBox
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents label21 As System.Windows.Forms.Label
        Private WithEvents groupBox12 As System.Windows.Forms.GroupBox
        Private WithEvents txtDisclaimer As System.Windows.Forms.TextBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents tbTransactionData As System.Windows.Forms.TabControl
        Private WithEvents label31 As System.Windows.Forms.Label
        Private WithEvents label32 As System.Windows.Forms.Label
        Private WithEvents label30 As System.Windows.Forms.Label
        Private WithEvents txtTMSSecondary As System.Windows.Forms.TextBox
        Private WithEvents txtTMSPrimary As System.Windows.Forms.TextBox
        Private WithEvents TxtServiceKey As System.Windows.Forms.TextBox
        Private WithEvents label35 As System.Windows.Forms.Label
        Private WithEvents CboindustryType As System.Windows.Forms.ComboBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents CboWorkFlowIdsByServiceId As System.Windows.Forms.ComboBox
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Private WithEvents GrpTokenization As System.Windows.Forms.GroupBox
        Public WithEvents ChkTokenization As System.Windows.Forms.CheckBox
        Public WithEvents CboTokenizedCard As System.Windows.Forms.ComboBox
        Private WithEvents label27 As System.Windows.Forms.Label
        Private WithEvents GrpTrackDataFromMSR As System.Windows.Forms.GroupBox
        Public WithEvents ChkTrackDataFromMSR As System.Windows.Forms.CheckBox
        Private WithEvents grpPinDebit As System.Windows.Forms.GroupBox
        Public WithEvents TxtEncryptedPIN As System.Windows.Forms.TextBox
        Private WithEvents label34 As System.Windows.Forms.Label
        Public WithEvents TxtKeySerialNumber As System.Windows.Forms.TextBox
        Private WithEvents label33 As System.Windows.Forms.Label
        Public WithEvents TxtCashBack As System.Windows.Forms.TextBox
        Private WithEvents label29 As System.Windows.Forms.Label
        Public WithEvents TxtTrackDataFromMSR As System.Windows.Forms.TextBox
        Private WithEvents grpProcessasPINLessDebit As System.Windows.Forms.GroupBox
        Public WithEvents ChkProcessAsPINLessDebit As System.Windows.Forms.CheckBox
        Private WithEvents GrpCNP As System.Windows.Forms.GroupBox
        Public WithEvents ChkCardNotPresent As System.Windows.Forms.CheckBox
        Public WithEvents TxtPAN As System.Windows.Forms.TextBox
        Private WithEvents label23 As System.Windows.Forms.Label
        Private WithEvents label25 As System.Windows.Forms.Label
        Public WithEvents TxtExpirationDate As System.Windows.Forms.TextBox
        Private WithEvents label26 As System.Windows.Forms.Label
        Public WithEvents CboCardTypes As System.Windows.Forms.ComboBox
        Public WithEvents ChkAllowPartialApprovals As System.Windows.Forms.CheckBox
        Private WithEvents chkProcessAsPINDebitTxn As System.Windows.Forms.CheckBox
        Public WithEvents TxtTip As System.Windows.Forms.TextBox
        Private WithEvents label20 As System.Windows.Forms.Label
        Public WithEvents TxtAmount As System.Windows.Forms.TextBox
        Private WithEvents label19 As System.Windows.Forms.Label
        Private WithEvents groupBox14 As System.Windows.Forms.GroupBox
        Private WithEvents ChkForceCloseBatch As System.Windows.Forms.CheckBox
        Private WithEvents cmdCaptureAll As System.Windows.Forms.Button
        Private WithEvents ChkCapSelectiveDiffData As System.Windows.Forms.CheckBox
        Private WithEvents cmdCaptureSelective As System.Windows.Forms.Button
        Private WithEvents lnkCaptureAll As System.Windows.Forms.LinkLabel
        Private WithEvents lnkCaptureSelective As System.Windows.Forms.LinkLabel
        Private WithEvents chkCaptureAllAndSelectiveAsync As System.Windows.Forms.CheckBox
        Private WithEvents ChkMultiplePartialCapture As System.Windows.Forms.CheckBox
        Private WithEvents ChkForceVoid As System.Windows.Forms.CheckBox
        Private WithEvents ChkOnClickDisplayTxnMessage As System.Windows.Forms.CheckBox
        Private WithEvents CmdClearTransactions As System.Windows.Forms.Button
        Public WithEvents ChkLstTransactionsProcessed As System.Windows.Forms.CheckedListBox
        Private WithEvents label18 As System.Windows.Forms.Label
        Private industryToolTip As System.Windows.Forms.ToolTip
        Private WithEvents CmdManageMerchantData As System.Windows.Forms.Button
        Private WithEvents linkPreparingAppToTransact As System.Windows.Forms.LinkLabel
        Private WithEvents ckBoxDelegatedSignOn As System.Windows.Forms.CheckBox
        Private WithEvents txtDelegatedServiceKey As System.Windows.Forms.TextBox
        Private WithEvents lnkLblDelegatedSignOn As System.Windows.Forms.LinkLabel
        Private WithEvents groupBox11 As System.Windows.Forms.GroupBox
        Private WithEvents rdoDeactivate As System.Windows.Forms.RadioButton
        Private WithEvents rdoReload As System.Windows.Forms.RadioButton
        Private WithEvents rdoActivate As System.Windows.Forms.RadioButton
        Private WithEvents lnkManageAccountById As System.Windows.Forms.LinkLabel
        Private WithEvents cmdManageAccountById As System.Windows.Forms.Button
        Private WithEvents cmdManageAccount As System.Windows.Forms.Button
        Private WithEvents lnkManageAccount As System.Windows.Forms.LinkLabel
        Private WithEvents viewTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents configurationValuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents applicationProfileIdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents serviceIdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents workflowIdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents merchantProfileIdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents identityTokenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ServiceKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ChkMagensaAuthorizeAndCapture As System.Windows.Forms.CheckBox
        Private WithEvents CmdMagensa As System.Windows.Forms.Button
        Private WithEvents ChkUserWorkflowId As System.Windows.Forms.CheckBox
        Private WithEvents lnkServiceKey As System.Windows.Forms.LinkLabel
    End Class
End Namespace
Namespace SampleCode
    Partial Class TransactionManagementServices
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
            Dim lnkQueryTransactionDetails As System.Windows.Forms.LinkLabel
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionManagementServices))
            Dim lnkQueryTransactions As System.Windows.Forms.LinkLabel
            Me.label44 = New System.Windows.Forms.Label()
            Me.grpQueryTransactionsParameters = New System.Windows.Forms.GroupBox()
            Me.chkIncludeRelated = New System.Windows.Forms.CheckBox()
            Me.chkUseTransactionIdSelected = New System.Windows.Forms.CheckBox()
            Me.cboQTP_CardTypes = New System.Windows.Forms.ComboBox()
            Me.cboQTP_CaptureStates = New System.Windows.Forms.ComboBox()
            Me.cboQTP_TransactionStates = New System.Windows.Forms.ComboBox()
            Me.txtQTP_ServiceIds = New System.Windows.Forms.TextBox()
            Me.cboQTP_QueryType = New System.Windows.Forms.ComboBox()
            Me.cboQTP_IsAcknowledged = New System.Windows.Forms.ComboBox()
            Me.txtQTP_ApprovalCodes = New System.Windows.Forms.TextBox()
            Me.txtQTP_TransactionIds = New System.Windows.Forms.TextBox()
            Me.cmdQueryTransactionsDetail = New System.Windows.Forms.Button()
            Me.txtQTP_ServiceKeys = New System.Windows.Forms.TextBox()
            Me.label43 = New System.Windows.Forms.Label()
            Me.cmdQueryTransactionsSummary = New System.Windows.Forms.Button()
            Me.txtQTP_TransactionClassTypePairs = New System.Windows.Forms.TextBox()
            Me.label42 = New System.Windows.Forms.Label()
            Me.label41 = New System.Windows.Forms.Label()
            Me.cmdQueryTransactionFamilies = New System.Windows.Forms.Button()
            Me.label40 = New System.Windows.Forms.Label()
            Me.label39 = New System.Windows.Forms.Label()
            Me.label38 = New System.Windows.Forms.Label()
            Me.label37 = New System.Windows.Forms.Label()
            Me.label31 = New System.Windows.Forms.Label()
            Me.label36 = New System.Windows.Forms.Label()
            Me.txtQTP_Amounts = New System.Windows.Forms.TextBox()
            Me.label35 = New System.Windows.Forms.Label()
            Me.label32 = New System.Windows.Forms.Label()
            Me.txtQTP_MerchantProfileIds = New System.Windows.Forms.TextBox()
            Me.label33 = New System.Windows.Forms.Label()
            Me.txtQTP_BatchIds = New System.Windows.Forms.TextBox()
            Me.label34 = New System.Windows.Forms.Label()
            Me.label30 = New System.Windows.Forms.Label()
            Me.grpQueryBatchParameters = New System.Windows.Forms.GroupBox()
            Me.txtQBP_TransactionIds = New System.Windows.Forms.TextBox()
            Me.txtQBP_BatchIds = New System.Windows.Forms.TextBox()
            Me.label29 = New System.Windows.Forms.Label()
            Me.txtQBP_ServiceKeys = New System.Windows.Forms.TextBox()
            Me.label28 = New System.Windows.Forms.Label()
            Me.txtQBP_MercProfileIds = New System.Windows.Forms.TextBox()
            Me.label27 = New System.Windows.Forms.Label()
            Me.label26 = New System.Windows.Forms.Label()
            Me.label20 = New System.Windows.Forms.Label()
            Me.cmdQueryBatch = New System.Windows.Forms.Button()
            Me.txtTMSResults = New System.Windows.Forms.TextBox()
            Me.label18 = New System.Windows.Forms.Label()
            Me.label25 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.dtpEndTimeTMS = New System.Windows.Forms.DateTimePicker()
            Me.dtpStartTimeTMS = New System.Windows.Forms.DateTimePicker()
            Me.label1 = New System.Windows.Forms.Label()
            Me.chklstTMSResults = New System.Windows.Forms.CheckedListBox()
            Me.LnkNext = New System.Windows.Forms.LinkLabel()
            Me.LnkPrevious = New System.Windows.Forms.LinkLabel()
            Me.lblPageNumber = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.lnkQueryBatch = New System.Windows.Forms.LinkLabel()
            Me.lnkQueryTransactionFamilies = New System.Windows.Forms.LinkLabel()
            lnkQueryTransactionDetails = New System.Windows.Forms.LinkLabel()
            lnkQueryTransactions = New System.Windows.Forms.LinkLabel()
            Me.grpQueryTransactionsParameters.SuspendLayout()
            Me.grpQueryBatchParameters.SuspendLayout()
            Me.SuspendLayout()
            '
            'label44
            '
            Me.label44.AutoSize = True
            Me.label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label44.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.label44.Location = New System.Drawing.Point(12, 9)
            Me.label44.Name = "label44"
            Me.label44.Size = New System.Drawing.Size(583, 24)
            Me.label44.TabIndex = 31
            Me.label44.Text = "Please note that the TMS service does incure additional costs"
            '
            'grpQueryTransactionsParameters
            '
            Me.grpQueryTransactionsParameters.Controls.Add(Me.chkIncludeRelated)
            Me.grpQueryTransactionsParameters.Controls.Add(lnkQueryTransactionDetails)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.chkUseTransactionIdSelected)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.lnkQueryTransactionFamilies)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cboQTP_CardTypes)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cboQTP_CaptureStates)
            Me.grpQueryTransactionsParameters.Controls.Add(lnkQueryTransactions)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cboQTP_TransactionStates)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_ServiceIds)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cboQTP_QueryType)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cboQTP_IsAcknowledged)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_ApprovalCodes)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_TransactionIds)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cmdQueryTransactionsDetail)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_ServiceKeys)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label43)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cmdQueryTransactionsSummary)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_TransactionClassTypePairs)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label42)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label41)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.cmdQueryTransactionFamilies)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label40)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label39)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label38)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label37)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label31)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label36)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_Amounts)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label35)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label32)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_MerchantProfileIds)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label33)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.txtQTP_BatchIds)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label34)
            Me.grpQueryTransactionsParameters.Controls.Add(Me.label30)
            Me.grpQueryTransactionsParameters.Location = New System.Drawing.Point(8, 277)
            Me.grpQueryTransactionsParameters.Name = "grpQueryTransactionsParameters"
            Me.grpQueryTransactionsParameters.Size = New System.Drawing.Size(453, 425)
            Me.grpQueryTransactionsParameters.TabIndex = 28
            Me.grpQueryTransactionsParameters.TabStop = False
            Me.grpQueryTransactionsParameters.Text = "Query Transactions Parameters"
            '
            'chkIncludeRelated
            '
            Me.chkIncludeRelated.AutoSize = True
            Me.chkIncludeRelated.Location = New System.Drawing.Point(286, 42)
            Me.chkIncludeRelated.Name = "chkIncludeRelated"
            Me.chkIncludeRelated.Size = New System.Drawing.Size(101, 17)
            Me.chkIncludeRelated.TabIndex = 131
            Me.chkIncludeRelated.Text = "Include Related"
            Me.chkIncludeRelated.UseVisualStyleBackColor = True
            '
            'chkUseTransactionIdSelected
            '
            Me.chkUseTransactionIdSelected.AutoSize = True
            Me.chkUseTransactionIdSelected.Location = New System.Drawing.Point(277, 349)
            Me.chkUseTransactionIdSelected.Name = "chkUseTransactionIdSelected"
            Me.chkUseTransactionIdSelected.Size = New System.Drawing.Size(158, 17)
            Me.chkUseTransactionIdSelected.TabIndex = 36
            Me.chkUseTransactionIdSelected.Text = "Use TransactionId Selected"
            Me.chkUseTransactionIdSelected.UseVisualStyleBackColor = True
            '
            'cboQTP_CardTypes
            '
            Me.cboQTP_CardTypes.FormattingEnabled = True
            Me.cboQTP_CardTypes.Location = New System.Drawing.Point(129, 161)
            Me.cboQTP_CardTypes.Name = "cboQTP_CardTypes"
            Me.cboQTP_CardTypes.Size = New System.Drawing.Size(299, 21)
            Me.cboQTP_CardTypes.TabIndex = 11
            '
            'cboQTP_CaptureStates
            '
            Me.cboQTP_CaptureStates.FormattingEnabled = True
            Me.cboQTP_CaptureStates.Location = New System.Drawing.Point(129, 139)
            Me.cboQTP_CaptureStates.Name = "cboQTP_CaptureStates"
            Me.cboQTP_CaptureStates.Size = New System.Drawing.Size(299, 21)
            Me.cboQTP_CaptureStates.TabIndex = 10
            '
            'cboQTP_TransactionStates
            '
            Me.cboQTP_TransactionStates.FormattingEnabled = True
            Me.cboQTP_TransactionStates.Location = New System.Drawing.Point(129, 370)
            Me.cboQTP_TransactionStates.Name = "cboQTP_TransactionStates"
            Me.cboQTP_TransactionStates.Size = New System.Drawing.Size(299, 21)
            Me.cboQTP_TransactionStates.TabIndex = 19
            '
            'txtQTP_ServiceIds
            '
            Me.txtQTP_ServiceIds.Location = New System.Drawing.Point(129, 269)
            Me.txtQTP_ServiceIds.Name = "txtQTP_ServiceIds"
            Me.txtQTP_ServiceIds.Size = New System.Drawing.Size(299, 20)
            Me.txtQTP_ServiceIds.TabIndex = 15
            '
            'cboQTP_QueryType
            '
            Me.cboQTP_QueryType.FormattingEnabled = True
            Me.cboQTP_QueryType.Location = New System.Drawing.Point(129, 242)
            Me.cboQTP_QueryType.Name = "cboQTP_QueryType"
            Me.cboQTP_QueryType.Size = New System.Drawing.Size(299, 21)
            Me.cboQTP_QueryType.TabIndex = 14
            '
            'cboQTP_IsAcknowledged
            '
            Me.cboQTP_IsAcknowledged.FormattingEnabled = True
            Me.cboQTP_IsAcknowledged.Location = New System.Drawing.Point(129, 187)
            Me.cboQTP_IsAcknowledged.Name = "cboQTP_IsAcknowledged"
            Me.cboQTP_IsAcknowledged.Size = New System.Drawing.Size(299, 21)
            Me.cboQTP_IsAcknowledged.TabIndex = 12
            '
            'txtQTP_ApprovalCodes
            '
            Me.txtQTP_ApprovalCodes.Location = New System.Drawing.Point(129, 87)
            Me.txtQTP_ApprovalCodes.Name = "txtQTP_ApprovalCodes"
            Me.txtQTP_ApprovalCodes.Size = New System.Drawing.Size(136, 20)
            Me.txtQTP_ApprovalCodes.TabIndex = 8
            '
            'txtQTP_TransactionIds
            '
            Me.txtQTP_TransactionIds.Location = New System.Drawing.Point(129, 347)
            Me.txtQTP_TransactionIds.Name = "txtQTP_TransactionIds"
            Me.txtQTP_TransactionIds.Size = New System.Drawing.Size(142, 20)
            Me.txtQTP_TransactionIds.TabIndex = 18
            '
            'cmdQueryTransactionsDetail
            '
            Me.cmdQueryTransactionsDetail.Location = New System.Drawing.Point(281, 113)
            Me.cmdQueryTransactionsDetail.Name = "cmdQueryTransactionsDetail"
            Me.cmdQueryTransactionsDetail.Size = New System.Drawing.Size(147, 23)
            Me.cmdQueryTransactionsDetail.TabIndex = 12
            Me.cmdQueryTransactionsDetail.Text = "Query Transactions Detail"
            Me.cmdQueryTransactionsDetail.UseVisualStyleBackColor = True
            '
            'txtQTP_ServiceKeys
            '
            Me.txtQTP_ServiceKeys.Location = New System.Drawing.Point(129, 296)
            Me.txtQTP_ServiceKeys.Name = "txtQTP_ServiceKeys"
            Me.txtQTP_ServiceKeys.Size = New System.Drawing.Size(299, 20)
            Me.txtQTP_ServiceKeys.TabIndex = 16
            '
            'label43
            '
            Me.label43.AutoSize = True
            Me.label43.Location = New System.Drawing.Point(23, 377)
            Me.label43.Name = "label43"
            Me.label43.Size = New System.Drawing.Size(99, 13)
            Me.label43.TabIndex = 33
            Me.label43.Text = "TransactionState(s)"
            '
            'cmdQueryTransactionsSummary
            '
            Me.cmdQueryTransactionsSummary.Location = New System.Drawing.Point(281, 61)
            Me.cmdQueryTransactionsSummary.Name = "cmdQueryTransactionsSummary"
            Me.cmdQueryTransactionsSummary.Size = New System.Drawing.Size(147, 23)
            Me.cmdQueryTransactionsSummary.TabIndex = 11
            Me.cmdQueryTransactionsSummary.Text = "Query Transactions Summary"
            Me.cmdQueryTransactionsSummary.UseVisualStyleBackColor = True
            '
            'txtQTP_TransactionClassTypePairs
            '
            Me.txtQTP_TransactionClassTypePairs.Enabled = False
            Me.txtQTP_TransactionClassTypePairs.Location = New System.Drawing.Point(170, 321)
            Me.txtQTP_TransactionClassTypePairs.Name = "txtQTP_TransactionClassTypePairs"
            Me.txtQTP_TransactionClassTypePairs.Size = New System.Drawing.Size(258, 20)
            Me.txtQTP_TransactionClassTypePairs.TabIndex = 17
            '
            'label42
            '
            Me.label42.AutoSize = True
            Me.label42.Enabled = False
            Me.label42.Location = New System.Drawing.Point(23, 325)
            Me.label42.Name = "label42"
            Me.label42.Size = New System.Drawing.Size(141, 13)
            Me.label42.TabIndex = 31
            Me.label42.Text = "TransactionClassTypePair(s)"
            '
            'label41
            '
            Me.label41.AutoSize = True
            Me.label41.Location = New System.Drawing.Point(23, 273)
            Me.label41.Name = "label41"
            Me.label41.Size = New System.Drawing.Size(63, 13)
            Me.label41.TabIndex = 29
            Me.label41.Text = "ServiceId(s)"
            '
            'cmdQueryTransactionFamilies
            '
            Me.cmdQueryTransactionFamilies.Location = New System.Drawing.Point(281, 87)
            Me.cmdQueryTransactionFamilies.Name = "cmdQueryTransactionFamilies"
            Me.cmdQueryTransactionFamilies.Size = New System.Drawing.Size(147, 23)
            Me.cmdQueryTransactionFamilies.TabIndex = 10
            Me.cmdQueryTransactionFamilies.Text = "Query Transaction Families"
            Me.cmdQueryTransactionFamilies.UseVisualStyleBackColor = True
            '
            'label40
            '
            Me.label40.AutoSize = True
            Me.label40.Location = New System.Drawing.Point(23, 247)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(59, 13)
            Me.label40.TabIndex = 27
            Me.label40.Text = "QueryType"
            '
            'label39
            '
            Me.label39.AutoSize = True
            Me.label39.Location = New System.Drawing.Point(23, 195)
            Me.label39.Name = "label39"
            Me.label39.Size = New System.Drawing.Size(86, 13)
            Me.label39.TabIndex = 25
            Me.label39.Text = "IsAcknowledged"
            '
            'label38
            '
            Me.label38.AutoSize = True
            Me.label38.Location = New System.Drawing.Point(23, 169)
            Me.label38.Name = "label38"
            Me.label38.Size = New System.Drawing.Size(64, 13)
            Me.label38.TabIndex = 23
            Me.label38.Text = "CardType(s)"
            '
            'label37
            '
            Me.label37.AutoSize = True
            Me.label37.Location = New System.Drawing.Point(23, 143)
            Me.label37.Name = "label37"
            Me.label37.Size = New System.Drawing.Size(80, 13)
            Me.label37.TabIndex = 21
            Me.label37.Text = "CaptureState(s)"
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Location = New System.Drawing.Point(23, 351)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(83, 13)
            Me.label31.TabIndex = 15
            Me.label31.Text = "TransactionId(s)"
            '
            'label36
            '
            Me.label36.AutoSize = True
            Me.label36.Location = New System.Drawing.Point(23, 91)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(85, 13)
            Me.label36.TabIndex = 19
            Me.label36.Text = "ApprovalCode(s)"
            '
            'txtQTP_Amounts
            '
            Me.txtQTP_Amounts.Location = New System.Drawing.Point(129, 61)
            Me.txtQTP_Amounts.Name = "txtQTP_Amounts"
            Me.txtQTP_Amounts.Size = New System.Drawing.Size(136, 20)
            Me.txtQTP_Amounts.TabIndex = 7
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.Location = New System.Drawing.Point(23, 65)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(54, 13)
            Me.label35.TabIndex = 17
            Me.label35.Text = "Amount(s)"
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Location = New System.Drawing.Point(23, 299)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(72, 13)
            Me.label32.TabIndex = 13
            Me.label32.Text = "ServiceKey(s)"
            '
            'txtQTP_MerchantProfileIds
            '
            Me.txtQTP_MerchantProfileIds.Location = New System.Drawing.Point(129, 217)
            Me.txtQTP_MerchantProfileIds.Name = "txtQTP_MerchantProfileIds"
            Me.txtQTP_MerchantProfileIds.Size = New System.Drawing.Size(299, 20)
            Me.txtQTP_MerchantProfileIds.TabIndex = 13
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Location = New System.Drawing.Point(23, 221)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(80, 13)
            Me.label33.TabIndex = 11
            Me.label33.Text = "MercProfileId(s)"
            '
            'txtQTP_BatchIds
            '
            Me.txtQTP_BatchIds.Location = New System.Drawing.Point(129, 113)
            Me.txtQTP_BatchIds.Name = "txtQTP_BatchIds"
            Me.txtQTP_BatchIds.Size = New System.Drawing.Size(136, 20)
            Me.txtQTP_BatchIds.TabIndex = 9
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Location = New System.Drawing.Point(23, 117)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(55, 13)
            Me.label34.TabIndex = 9
            Me.label34.Text = "BatchId(s)"
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label30.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.label30.Location = New System.Drawing.Point(23, 16)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(349, 15)
            Me.label30.TabIndex = 3
            Me.label30.Text = "Please use a comma to seperate more than one entry"
            '
            'grpQueryBatchParameters
            '
            Me.grpQueryBatchParameters.Controls.Add(Me.lnkQueryBatch)
            Me.grpQueryBatchParameters.Controls.Add(Me.txtQBP_TransactionIds)
            Me.grpQueryBatchParameters.Controls.Add(Me.txtQBP_BatchIds)
            Me.grpQueryBatchParameters.Controls.Add(Me.label29)
            Me.grpQueryBatchParameters.Controls.Add(Me.txtQBP_ServiceKeys)
            Me.grpQueryBatchParameters.Controls.Add(Me.label28)
            Me.grpQueryBatchParameters.Controls.Add(Me.txtQBP_MercProfileIds)
            Me.grpQueryBatchParameters.Controls.Add(Me.label27)
            Me.grpQueryBatchParameters.Controls.Add(Me.label26)
            Me.grpQueryBatchParameters.Controls.Add(Me.label20)
            Me.grpQueryBatchParameters.Controls.Add(Me.cmdQueryBatch)
            Me.grpQueryBatchParameters.Location = New System.Drawing.Point(8, 120)
            Me.grpQueryBatchParameters.Name = "grpQueryBatchParameters"
            Me.grpQueryBatchParameters.Size = New System.Drawing.Size(453, 141)
            Me.grpQueryBatchParameters.TabIndex = 27
            Me.grpQueryBatchParameters.TabStop = False
            Me.grpQueryBatchParameters.Text = "Query Batch Parameters"
            '
            'txtQBP_TransactionIds
            '
            Me.txtQBP_TransactionIds.Location = New System.Drawing.Point(129, 109)
            Me.txtQBP_TransactionIds.Name = "txtQBP_TransactionIds"
            Me.txtQBP_TransactionIds.Size = New System.Drawing.Size(138, 20)
            Me.txtQBP_TransactionIds.TabIndex = 6
            '
            'txtQBP_BatchIds
            '
            Me.txtQBP_BatchIds.Location = New System.Drawing.Point(129, 37)
            Me.txtQBP_BatchIds.Name = "txtQBP_BatchIds"
            Me.txtQBP_BatchIds.Size = New System.Drawing.Size(138, 20)
            Me.txtQBP_BatchIds.TabIndex = 3
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(23, 116)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(83, 13)
            Me.label29.TabIndex = 7
            Me.label29.Text = "TransactionId(s)"
            '
            'txtQBP_ServiceKeys
            '
            Me.txtQBP_ServiceKeys.Location = New System.Drawing.Point(129, 86)
            Me.txtQBP_ServiceKeys.Name = "txtQBP_ServiceKeys"
            Me.txtQBP_ServiceKeys.Size = New System.Drawing.Size(139, 20)
            Me.txtQBP_ServiceKeys.TabIndex = 5
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Location = New System.Drawing.Point(23, 90)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(72, 13)
            Me.label28.TabIndex = 5
            Me.label28.Text = "ServiceKey(s)"
            '
            'txtQBP_MercProfileIds
            '
            Me.txtQBP_MercProfileIds.Location = New System.Drawing.Point(129, 60)
            Me.txtQBP_MercProfileIds.Name = "txtQBP_MercProfileIds"
            Me.txtQBP_MercProfileIds.Size = New System.Drawing.Size(139, 20)
            Me.txtQBP_MercProfileIds.TabIndex = 4
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Location = New System.Drawing.Point(23, 64)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(80, 13)
            Me.label27.TabIndex = 3
            Me.label27.Text = "MercProfileId(s)"
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label26.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.label26.Location = New System.Drawing.Point(23, 16)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(349, 15)
            Me.label26.TabIndex = 2
            Me.label26.Text = "Please use a comma to seperate more than one entry"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Location = New System.Drawing.Point(23, 38)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(55, 13)
            Me.label20.TabIndex = 0
            Me.label20.Text = "BatchId(s)"
            '
            'cmdQueryBatch
            '
            Me.cmdQueryBatch.Location = New System.Drawing.Point(281, 35)
            Me.cmdQueryBatch.Name = "cmdQueryBatch"
            Me.cmdQueryBatch.Size = New System.Drawing.Size(147, 23)
            Me.cmdQueryBatch.TabIndex = 5
            Me.cmdQueryBatch.Text = "QueryBatch"
            Me.cmdQueryBatch.UseVisualStyleBackColor = True
            '
            'txtTMSResults
            '
            Me.txtTMSResults.BackColor = System.Drawing.SystemColors.ControlLight
            Me.txtTMSResults.Location = New System.Drawing.Point(477, 331)
            Me.txtTMSResults.Multiline = True
            Me.txtTMSResults.Name = "txtTMSResults"
            Me.txtTMSResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtTMSResults.Size = New System.Drawing.Size(487, 371)
            Me.txtTMSResults.TabIndex = 26
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label18.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.label18.Location = New System.Drawing.Point(31, 43)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(303, 15)
            Me.label18.TabIndex = 25
            Me.label18.Text = "Note : Times are converted to UTC in the Code"
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Location = New System.Drawing.Point(31, 93)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(26, 13)
            Me.label25.TabIndex = 24
            Me.label25.Text = "End"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(31, 67)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(29, 13)
            Me.label3.TabIndex = 23
            Me.label3.Text = "Start"
            '
            'dtpEndTimeTMS
            '
            Me.dtpEndTimeTMS.CustomFormat = ""
            Me.dtpEndTimeTMS.Location = New System.Drawing.Point(66, 90)
            Me.dtpEndTimeTMS.Name = "dtpEndTimeTMS"
            Me.dtpEndTimeTMS.Size = New System.Drawing.Size(229, 20)
            Me.dtpEndTimeTMS.TabIndex = 22
            '
            'dtpStartTimeTMS
            '
            Me.dtpStartTimeTMS.CustomFormat = ""
            Me.dtpStartTimeTMS.Location = New System.Drawing.Point(66, 64)
            Me.dtpStartTimeTMS.Name = "dtpStartTimeTMS"
            Me.dtpStartTimeTMS.Size = New System.Drawing.Size(229, 20)
            Me.dtpStartTimeTMS.TabIndex = 21
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(474, 61)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(136, 13)
            Me.label1.TabIndex = 34
            Me.label1.Text = "Select a row to view details"
            '
            'chklstTMSResults
            '
            Me.chklstTMSResults.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
            Me.chklstTMSResults.FormattingEnabled = True
            Me.chklstTMSResults.HorizontalScrollbar = True
            Me.chklstTMSResults.Location = New System.Drawing.Point(477, 79)
            Me.chklstTMSResults.Name = "chklstTMSResults"
            Me.chklstTMSResults.Size = New System.Drawing.Size(487, 229)
            Me.chklstTMSResults.TabIndex = 35
            '
            'LnkNext
            '
            Me.LnkNext.AutoSize = True
            Me.LnkNext.Location = New System.Drawing.Point(926, 61)
            Me.LnkNext.Name = "LnkNext"
            Me.LnkNext.Size = New System.Drawing.Size(38, 13)
            Me.LnkNext.TabIndex = 36
            Me.LnkNext.TabStop = True
            Me.LnkNext.Text = "Next >"
            Me.LnkNext.Visible = False
            '
            'LnkPrevious
            '
            Me.LnkPrevious.AutoSize = True
            Me.LnkPrevious.Location = New System.Drawing.Point(809, 61)
            Me.LnkPrevious.Name = "LnkPrevious"
            Me.LnkPrevious.Size = New System.Drawing.Size(57, 13)
            Me.LnkPrevious.TabIndex = 37
            Me.LnkPrevious.TabStop = True
            Me.LnkPrevious.Text = "< Previous"
            Me.LnkPrevious.Visible = False
            '
            'lblPageNumber
            '
            Me.lblPageNumber.AutoSize = True
            Me.lblPageNumber.Location = New System.Drawing.Point(872, 61)
            Me.lblPageNumber.Name = "lblPageNumber"
            Me.lblPageNumber.Size = New System.Drawing.Size(41, 13)
            Me.lblPageNumber.TabIndex = 38
            Me.lblPageNumber.Text = "Page : "
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(474, 315)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(105, 13)
            Me.label2.TabIndex = 39
            Me.label2.Text = "Summary Information"
            '
            'lnkQueryBatch
            '
            Me.lnkQueryBatch.AutoSize = True
            Me.lnkQueryBatch.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkQueryBatch.Image = CType(resources.GetObject("lnkQueryBatch.Image"), System.Drawing.Image)
            Me.lnkQueryBatch.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkQueryBatch.Location = New System.Drawing.Point(431, 37)
            Me.lnkQueryBatch.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkQueryBatch.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkQueryBatch.Name = "lnkQueryBatch"
            Me.lnkQueryBatch.Size = New System.Drawing.Size(20, 20)
            Me.lnkQueryBatch.TabIndex = 132
            Me.lnkQueryBatch.Tag = ""
            Me.lnkQueryBatch.UseCompatibleTextRendering = True
            '
            'lnkQueryTransactionDetails
            '
            lnkQueryTransactionDetails.AutoSize = True
            lnkQueryTransactionDetails.Cursor = System.Windows.Forms.Cursors.Hand
            lnkQueryTransactionDetails.Image = CType(resources.GetObject("lnkQueryTransactionDetails.Image"), System.Drawing.Image)
            lnkQueryTransactionDetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            lnkQueryTransactionDetails.Location = New System.Drawing.Point(430, 113)
            lnkQueryTransactionDetails.Margin = New System.Windows.Forms.Padding(0)
            lnkQueryTransactionDetails.MinimumSize = New System.Drawing.Size(20, 20)
            lnkQueryTransactionDetails.Name = "lnkQueryTransactionDetails"
            lnkQueryTransactionDetails.Size = New System.Drawing.Size(20, 20)
            lnkQueryTransactionDetails.TabIndex = 135
            lnkQueryTransactionDetails.Tag = ""
            lnkQueryTransactionDetails.UseCompatibleTextRendering = True
            '
            'lnkQueryTransactionFamilies
            '
            Me.lnkQueryTransactionFamilies.AutoSize = True
            Me.lnkQueryTransactionFamilies.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lnkQueryTransactionFamilies.Image = CType(resources.GetObject("lnkQueryTransactionFamilies.Image"), System.Drawing.Image)
            Me.lnkQueryTransactionFamilies.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lnkQueryTransactionFamilies.Location = New System.Drawing.Point(430, 87)
            Me.lnkQueryTransactionFamilies.Margin = New System.Windows.Forms.Padding(0)
            Me.lnkQueryTransactionFamilies.MinimumSize = New System.Drawing.Size(20, 20)
            Me.lnkQueryTransactionFamilies.Name = "lnkQueryTransactionFamilies"
            Me.lnkQueryTransactionFamilies.Size = New System.Drawing.Size(20, 20)
            Me.lnkQueryTransactionFamilies.TabIndex = 134
            Me.lnkQueryTransactionFamilies.Tag = ""
            Me.lnkQueryTransactionFamilies.UseCompatibleTextRendering = True
            '
            'lnkQueryTransactions
            '
            lnkQueryTransactions.AutoSize = True
            lnkQueryTransactions.Cursor = System.Windows.Forms.Cursors.Hand
            lnkQueryTransactions.Image = CType(resources.GetObject("lnkQueryTransactions.Image"), System.Drawing.Image)
            lnkQueryTransactions.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            lnkQueryTransactions.Location = New System.Drawing.Point(430, 61)
            lnkQueryTransactions.Margin = New System.Windows.Forms.Padding(0)
            lnkQueryTransactions.MinimumSize = New System.Drawing.Size(20, 20)
            lnkQueryTransactions.Name = "lnkQueryTransactions"
            lnkQueryTransactions.Size = New System.Drawing.Size(20, 20)
            lnkQueryTransactions.TabIndex = 133
            lnkQueryTransactions.Tag = ""
            lnkQueryTransactions.UseCompatibleTextRendering = True
            '
            'TransactionManagementServices
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(976, 714)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.lblPageNumber)
            Me.Controls.Add(Me.LnkPrevious)
            Me.Controls.Add(Me.LnkNext)
            Me.Controls.Add(Me.chklstTMSResults)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.label44)
            Me.Controls.Add(Me.grpQueryTransactionsParameters)
            Me.Controls.Add(Me.grpQueryBatchParameters)
            Me.Controls.Add(Me.txtTMSResults)
            Me.Controls.Add(Me.label18)
            Me.Controls.Add(Me.label25)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.dtpEndTimeTMS)
            Me.Controls.Add(Me.dtpStartTimeTMS)
            Me.Name = "TransactionManagementServices"
            Me.Text = "TransactionManagementServices - CWS 1.17.18"
            Me.grpQueryTransactionsParameters.ResumeLayout(False)
            Me.grpQueryTransactionsParameters.PerformLayout()
            Me.grpQueryBatchParameters.ResumeLayout(False)
            Me.grpQueryBatchParameters.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private label44 As System.Windows.Forms.Label
        Private grpQueryTransactionsParameters As System.Windows.Forms.GroupBox
        Private cboQTP_CardTypes As System.Windows.Forms.ComboBox
        Private cboQTP_CaptureStates As System.Windows.Forms.ComboBox
        Private cboQTP_TransactionStates As System.Windows.Forms.ComboBox
        Private txtQTP_ServiceIds As System.Windows.Forms.TextBox
        Private cboQTP_QueryType As System.Windows.Forms.ComboBox
        Private cboQTP_IsAcknowledged As System.Windows.Forms.ComboBox
        Private txtQTP_ApprovalCodes As System.Windows.Forms.TextBox
        Private txtQTP_TransactionIds As System.Windows.Forms.TextBox
        Private WithEvents cmdQueryTransactionsDetail As System.Windows.Forms.Button
        Private txtQTP_ServiceKeys As System.Windows.Forms.TextBox
        Private label43 As System.Windows.Forms.Label
        Private WithEvents cmdQueryTransactionsSummary As System.Windows.Forms.Button
        Private txtQTP_TransactionClassTypePairs As System.Windows.Forms.TextBox
        Private label42 As System.Windows.Forms.Label
        Private label41 As System.Windows.Forms.Label
        Private WithEvents cmdQueryTransactionFamilies As System.Windows.Forms.Button
        Private label40 As System.Windows.Forms.Label
        Private label39 As System.Windows.Forms.Label
        Private label38 As System.Windows.Forms.Label
        Private label37 As System.Windows.Forms.Label
        Private label31 As System.Windows.Forms.Label
        Private label36 As System.Windows.Forms.Label
        Private txtQTP_Amounts As System.Windows.Forms.TextBox
        Private label35 As System.Windows.Forms.Label
        Private label32 As System.Windows.Forms.Label
        Private txtQTP_MerchantProfileIds As System.Windows.Forms.TextBox
        Private label33 As System.Windows.Forms.Label
        Private txtQTP_BatchIds As System.Windows.Forms.TextBox
        Private label34 As System.Windows.Forms.Label
        Private label30 As System.Windows.Forms.Label
        Private grpQueryBatchParameters As System.Windows.Forms.GroupBox
        Private txtQBP_TransactionIds As System.Windows.Forms.TextBox
        Private txtQBP_BatchIds As System.Windows.Forms.TextBox
        Private label29 As System.Windows.Forms.Label
        Private txtQBP_ServiceKeys As System.Windows.Forms.TextBox
        Private label28 As System.Windows.Forms.Label
        Private txtQBP_MercProfileIds As System.Windows.Forms.TextBox
        Private label27 As System.Windows.Forms.Label
        Private label26 As System.Windows.Forms.Label
        Private label20 As System.Windows.Forms.Label
        Private WithEvents cmdQueryBatch As System.Windows.Forms.Button
        Private WithEvents txtTMSResults As System.Windows.Forms.TextBox
        Private label18 As System.Windows.Forms.Label
        Private label25 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private dtpEndTimeTMS As System.Windows.Forms.DateTimePicker
        Private dtpStartTimeTMS As System.Windows.Forms.DateTimePicker
        Private label1 As System.Windows.Forms.Label
        Private WithEvents chklstTMSResults As System.Windows.Forms.CheckedListBox
        Private chkUseTransactionIdSelected As System.Windows.Forms.CheckBox
        Private chkIncludeRelated As System.Windows.Forms.CheckBox
        Private WithEvents LnkNext As System.Windows.Forms.LinkLabel
        Private WithEvents LnkPrevious As System.Windows.Forms.LinkLabel
        Private lblPageNumber As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private WithEvents lnkQueryBatch As System.Windows.Forms.LinkLabel
        Private WithEvents lnkQueryTransactionFamilies As System.Windows.Forms.LinkLabel
    End Class
End Namespace

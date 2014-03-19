Imports System.Collections.Generic
Imports System.Net
Imports System.ServiceModel
Imports System.Windows.Forms
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.TMS

Namespace SampleCode
    Partial Public Class TransactionManagementServices
        Inherits Form
        Private _FaultHandler As New FaultHandler.FaultHandler()
        Private _intCurrentPage As Integer = 0
        'Zero based so 0 is page 1
        Private _intResultsPerPage As Integer = 50
        'The upperlimit is 50.
        Private _intCurrentPageResults As Integer = 0
        'Zero based so 0 is page 1
        Private _intResultsPerPageResults As Integer = 50
        'The upperlimit is 50.
        Private _lastSearch As LastSearchType

        Public Sub New()
            InitializeComponent()

            cboQTP_CaptureStates.Sorted = True
            cboQTP_CaptureStates.DataSource = [Enum].GetValues(GetType(CaptureState))
            cboQTP_CaptureStates.SelectedIndex = -1

            cboQTP_CardTypes.Sorted = True
            cboQTP_CardTypes.DataSource = [Enum].GetValues(GetType(TypeCardType))
            cboQTP_CardTypes.SelectedIndex = -1

            'Populate drop downs with enumerated values
            cboQTP_IsAcknowledged.Items.Add(True)
            cboQTP_IsAcknowledged.Items.Add(False)

            cboQTP_QueryType.Sorted = True
            cboQTP_QueryType.DataSource = [Enum].GetValues(GetType(QueryType))
            cboQTP_QueryType.SelectedIndex = -1

            cboQTP_TransactionStates.Sorted = True
            cboQTP_TransactionStates.DataSource = [Enum].GetValues(GetType(TransactionState))
            cboQTP_TransactionStates.SelectedIndex = -1

            'Format the dateTimePicker for TMS queries
            dtpStartTimeTMS.Format = DateTimePickerFormat.[Custom]
            dtpStartTimeTMS.CustomFormat = "dddd MM'/'dd'/'yyyy hh':'mm tt"
            dtpStartTimeTMS.Value = DateTime.Now.AddHours(-2)

            dtpEndTimeTMS.Format = DateTimePickerFormat.[Custom]
            dtpEndTimeTMS.CustomFormat = "dddd MM'/'dd'/'yyyy hh':'mm tt"
            dtpEndTimeTMS.Value = DateTime.Now
        End Sub

        Private Sub cmdQueryTransactionsSummary_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdQueryTransactionsSummary.Click
            ResetPreviousNext()
            If _lastSearch <> LastSearchType.QueryTransactionsSummary Then
                ResetPreviousNext()
                _lastSearch = LastSearchType.QueryTransactionsSummary
            End If
            QueryTransactionsSummary()
        End Sub

        Private Sub cmdQueryTransactionFamilies_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdQueryTransactionFamilies.Click
            ResetPreviousNext()
            If _lastSearch <> LastSearchType.QueryTransactionFamilies Then
                ResetPreviousNext()
                _lastSearch = LastSearchType.QueryTransactionFamilies
            End If
            QueryTransactionFamilies()
        End Sub

        Private Sub cmdQueryTransactionsDetail_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdQueryTransactionsDetail.Click
            ResetPreviousNext()
            If _lastSearch <> LastSearchType.QueryTransactionsDetail Then
                ResetPreviousNext()
                _lastSearch = LastSearchType.QueryTransactionsDetail
            End If
            QueryTransactionsDetail()
        End Sub

        Private Sub cmdQueryBatch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdQueryBatch.Click
            ResetPreviousNext()
            If _lastSearch <> LastSearchType.QueryBatch Then
                ResetPreviousNext()
                _lastSearch = LastSearchType.QueryBatch
            End If
            QueryBatch()
        End Sub

        Private Sub QueryTransactionsSummary()
            'http://commercelab.ipcommerce.com/Docs/Documentation/1.17.11/CWS_TMS_Developer_Guide/TMSImplementation/QueryTransactionsSummary.aspx
            Dim BlnIncludeRelated As Boolean = chkIncludeRelated.Checked

            Try
                DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
                'Make sure the current token is valid
                txtTMSResults.Text = ""

                Cursor = Cursors.WaitCursor
                ProcessQueryTransactionSummaryResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryTransactionsSummary(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQTP(), BlnIncludeRelated, GetPP()))



                Cursor = Cursors.[Default]
            Catch generatedExceptionName As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    DirectCast(Owner, SampleCode_DeskTop).Helper.SetTxnEndpoint()
                    'Change the endpoint to use the backup.
                    ProcessQueryTransactionSummaryResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryTransactionsSummary(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQTP(), BlnIncludeRelated, GetPP()))


                Catch generatedExceptionNameDuplicate As EndpointNotFoundException
                    MessageBox.Show("Neither the primary or secondary TMS endpoints are available. Unable to process.")
                Catch ex As Exception
                    MessageBox.Show("Unable to Query Transactions Summary" & vbCr & vbLf & "Error Message : " & ex.Message, "Query Transactions Summary Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTMSFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            Finally
                Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub QueryTransactionFamilies()
            'http://commercelab.ipcommerce.com/Docs/Documentation/1.17.11/CWS_TMS_Developer_Guide/TMSImplementation/QueryTransactionFamilies.aspx

            Try
                DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
                'Make sure the current token is valid
                txtTMSResults.Text = ""

                Cursor = Cursors.WaitCursor
                If txtQTP_TransactionIds.Text.Length < 1 Then
                    MessageBox.Show("At Lease one TransactionId is necessary in Query Transaction Parameters")
                    Cursor = Cursors.[Default]
                    Return
                End If
                ProcessQueryTransactionFamiliesResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryTransactionFamilies(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQTP(), GetPP()))

                Cursor = Cursors.[Default]
            Catch generatedExceptionName As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    DirectCast(Owner, SampleCode_DeskTop).Helper.SetTxnEndpoint()
                    'Change the endpoint to use the backup.
                    ProcessQueryTransactionFamiliesResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryTransactionFamilies(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQTP(), GetPP()))
                Catch generatedExceptionNameDuplicate As EndpointNotFoundException
                    MessageBox.Show("Neither the primary or secondary TMS endpoints are available. Unable to process.")
                Catch ex As Exception
                    MessageBox.Show("Unable to Query Transaction Families" & vbCr & vbLf & "Error Message : " & ex.Message, "Query Transaction Families Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTMSFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            Finally
                Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub QueryTransactionsDetail()
            'http://commercelab.ipcommerce.com/Docs/Documentation/1.17.11/CWS_TMS_Developer_Guide/TMSImplementation/QueryTransactionsDetail.aspx

            Dim BlnIncludeRelated As Boolean = chkIncludeRelated.Checked
            Try
                DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
                'Make sure the current token is valid
                txtTMSResults.Text = ""

                Cursor = Cursors.WaitCursor
                If txtQTP_TransactionIds.Text.Length < 1 Then
                    MessageBox.Show("At Lease one TransactionId is necessary in Query Transaction Parameters")
                    Cursor = Cursors.[Default]
                    Return
                End If

                Dim TDF As New TransactionDetailFormat()
                ProcessQueryTransactionsDetailResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryTransactionsDetail(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQTP(), TDF, BlnIncludeRelated, GetPP()))



                If txtTMSResults.Text.Length < 1 Then
                    txtTMSResults.Text = "No Query Transaction Detail Results : " & DateTime.Now
                End If
                Cursor = Cursors.[Default]
            Catch generatedExceptionName As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    DirectCast(Owner, SampleCode_DeskTop).Helper.SetTxnEndpoint()
                    'Change the endpoint to use the backup.
                    Dim TDF As New TransactionDetailFormat()
                    ProcessQueryTransactionsDetailResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryTransactionsDetail(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQTP(), TDF, BlnIncludeRelated, GetPP()))
                Catch generatedExceptionNameDuplicate As EndpointNotFoundException
                    MessageBox.Show("Neither the primary or secondary TMS endpoints are available. Unable to process.")
                Catch ex As Exception
                    MessageBox.Show("Unable to Query Transaction Families" & vbCr & vbLf & "Error Message : " & ex.Message, "Query Transaction Families Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTMSFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            Finally
                Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub QueryBatch()
            'http://commercelab.ipcommerce.com/Docs/Documentation/1.17.11/CWS_TMS_Developer_Guide/TMSImplementation/QueryBatch.aspx

            Try
                DirectCast(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
                'Make sure the current token is valid
                txtTMSResults.Text = ""

                Cursor = Cursors.WaitCursor
                ProcessQueryBatchResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryBatch(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQBP(), GetPP()))

                If txtTMSResults.Text.Length < 1 Then
                    txtTMSResults.Text = "No Query Batch Results : " & DateTime.Now
                End If
                Cursor = Cursors.[Default]
            Catch generatedExceptionName As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    DirectCast(Owner, SampleCode_DeskTop).Helper.SetTxnEndpoint()
                    'Change the endpoint to use the backup.
                    ProcessQueryBatchResponse(DirectCast(Owner, SampleCode_DeskTop).Helper.Tmsoc.QueryBatch(DirectCast(Owner, SampleCode_DeskTop).Helper.SessionToken, GetQBP(), GetPP()))
                Catch generatedExceptionNameDuplicate As EndpointNotFoundException
                    MessageBox.Show("Neither the primary or secondary TMS endpoints are available. Unable to process.")
                Catch ex As Exception
                    MessageBox.Show("Unable to QueryBatch" & vbCr & vbLf & "Error Message : " & ex.Message, "QueryBatch Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Catch eW As WebException
                'e.Status;
                '((HttpWebResponse) e.Response).StatusCode;
                MessageBox.Show(eW.Message)
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTMSFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            Finally
                Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub ResetPreviousNext()
            LnkPrevious.Visible = False
            LnkNext.Visible = False
            lblPageNumber.Visible = False
            _intCurrentPage = 0
            'Zero based so 0 is page 1
        End Sub

        Private Sub LnkNext_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LnkNext.LinkClicked
            _intCurrentPage += 1
            If _lastSearch = LastSearchType.QueryTransactionsSummary Then
                QueryTransactionsSummary()
            End If
            'Since data is saved to the results textbox the following do not apply
            'if (_lst == LastSearchType.QueryTransactionFamilies) QueryTransactionFamilies();
            'if (_lst == LastSearchType.QueryTransactionsDetail) QueryTransactionsDetail();
            'if (_lst == LastSearchType.QueryBatch) QueryBatch();
        End Sub

        Private Sub LnkPrevious_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LnkPrevious.LinkClicked
            _intCurrentPage -= 1
            If _lastSearch = LastSearchType.QueryTransactionsSummary Then
                QueryTransactionsSummary()
            End If
            'Since data is saved to the results textbox the following do not apply
            'if (_lst == LastSearchType.QueryTransactionFamilies) QueryTransactionFamilies();
            'if (_lst == LastSearchType.QueryTransactionsDetail) QueryTransactionsDetail();
            'if (_lst == LastSearchType.QueryBatch) QueryBatch();
        End Sub

        Private Function GetQBP() As QueryBatchParameters
            Dim QBP As New QueryBatchParameters()
            Dim splitter As Char() = {","c}
            'Specify batch paramaters
            QBP.BatchDateRange = New DateRange()
            QBP.BatchDateRange.StartDateTime = dtpStartTimeTMS.Value.ToUniversalTime()
            QBP.BatchDateRange.EndDateTime = dtpEndTimeTMS.Value.ToUniversalTime()

            If txtQBP_BatchIds.Text.Length > 0 Then
                QBP.BatchIds = New List(Of String)(txtQBP_BatchIds.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If
            If txtQBP_MercProfileIds.Text.Length > 0 Then
                QBP.MerchantProfileIds = New List(Of String)(txtQBP_MercProfileIds.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If
            If txtQBP_ServiceKeys.Text.Length > 0 Then
                QBP.ServiceKeys = New List(Of String)(txtQBP_ServiceKeys.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If
            If txtQBP_TransactionIds.Text.Length > 0 Then
                QBP.TransactionIds = New List(Of String)(txtQBP_TransactionIds.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If

            Return QBP
        End Function

        Private Function GetQTP() As QueryTransactionsParameters
            Dim QTP As New QueryTransactionsParameters()
            Dim splitter As Char() = {","c}

            If txtQTP_Amounts.Text.Length > 0 Then
                Dim Amt As New List(Of Decimal)()
                Dim values As String() = txtQTP_Amounts.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries)
                For Each s As String In values
                    Try
                        Dim d As Decimal = Convert.ToDecimal(s)
                        d = Decimal.Parse(d.ToString("0.00"))
                        'Amounts must be in format N.NN
                        Amt.Add(d)
                    Catch
                    End Try
                Next
                QTP.Amounts = Amt
            End If

            If txtQTP_ApprovalCodes.Text.Length > 0 Then
                QTP.ApprovalCodes = New List(Of String)(txtQTP_ApprovalCodes.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If
            If txtQTP_BatchIds.Text.Length > 0 Then
                QTP.BatchIds = New List(Of String)(txtQTP_BatchIds.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If

            'ToDo : add logic
            'QTP.CaptureDateRange = new DateRange();
            'QTP.CaptureDateRange.StartDateTime = dtpStartTimeTMS.Value.ToUniversalTime();
            'QTP.CaptureDateRange.EndDateTime = dtpEndTimeTMS.Value.ToUniversalTime();

            If cboQTP_CaptureStates.Text.Length > 0 Then
                Dim TS As New List(Of CaptureState)()
                TS.Add(DirectCast(cboQTP_CaptureStates.SelectedItem, CaptureState))
                QTP.CaptureStates = TS
            End If

            If cboQTP_CardTypes.Text.Length > 0 Then
                Dim TS As New List(Of TypeCardType)()
                TS.Add(DirectCast(cboQTP_CardTypes.SelectedItem, TypeCardType))
                QTP.CardTypes = TS
            End If

            If cboQTP_IsAcknowledged.Text.Length > 0 Then
                If CBool(cboQTP_IsAcknowledged.SelectedItem) Then
                    QTP.IsAcknowledged = BooleanParameter.[True]
                Else
                    QTP.IsAcknowledged = BooleanParameter.[False]
                End If
            End If

            If txtQTP_MerchantProfileIds.Text.Length > 0 Then
                QTP.MerchantProfileIds = New List(Of String)(txtQTP_MerchantProfileIds.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If

            If cboQTP_QueryType.Text.Length > 0 Then
                QTP.QueryType = DirectCast(cboQTP_QueryType.SelectedItem, QueryType)
            End If

            If txtQTP_ServiceIds.Text.Length > 0 Then
                QTP.ServiceIds = New List(Of String)(txtQTP_ServiceIds.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If

            If txtQTP_ServiceKeys.Text.Length > 0 Then
                QTP.ServiceKeys = New List(Of String)(txtQTP_ServiceKeys.Text.Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If

            'ToDo : add logic
            If txtQTP_TransactionClassTypePairs.Text.Length > 0 Then
                Dim TCTP As New List(Of TransactionClassTypePair)()
                TCTP.Add(New TransactionClassTypePair())
                QTP.TransactionClassTypePairs = TCTP
            End If

            'Specify batch paramaters
            QTP.TransactionDateRange = New DateRange()
            QTP.TransactionDateRange.StartDateTime = dtpStartTimeTMS.Value.ToUniversalTime()
            QTP.TransactionDateRange.EndDateTime = dtpEndTimeTMS.Value.ToUniversalTime()

            If txtQTP_TransactionIds.Text.Length > 0 Then
                QTP.TransactionIds = New List(Of String)(txtQTP_TransactionIds.Text.Replace(" ", "").Split(splitter, StringSplitOptions.RemoveEmptyEntries))
            End If

            If cboQTP_TransactionStates.Text.Length > 0 Then
                Dim TS As New List(Of TransactionState)()
                TS.Add(DirectCast(cboQTP_TransactionStates.SelectedItem, TransactionState))
                QTP.TransactionStates = TS
            End If

            Return QTP
        End Function

        Private Function GetPP() As PagingParameters
            'Specify Paging Parameters
            Dim PP As New PagingParameters()

            If _lastSearch = LastSearchType.QueryTransactionsSummary Then
                PP.Page = _intCurrentPage
                PP.PageSize = _intResultsPerPage
            End If

            If _lastSearch = LastSearchType.QueryTransactionFamilies Or _lastSearch = LastSearchType.QueryTransactionsDetail Or _lastSearch = LastSearchType.QueryBatch Then
                PP.Page = _intCurrentPageResults
                PP.PageSize = _intResultsPerPageResults
            End If

            Return PP
        End Function

        Private Sub txtTMSResults_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTMSResults.KeyDown
            ' See if Ctrl-A is pressed... 
            If e.Control AndAlso (e.KeyCode = Keys.A) Then
                txtTMSResults.SelectAll()
                e.Handled = True
            End If
        End Sub

        Private Sub chklstTMSResults_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chklstTMSResults.SelectedIndexChanged
            'Process SummaryDetail response
            If _lastSearch = LastSearchType.QueryTransactionsSummary Then
                If chklstTMSResults.SelectedItem Is Nothing Then
                    Return
                End If
                Dim s As SummaryDetail = DirectCast(chklstTMSResults.SelectedItem, SummaryDetailVal).SD
                txtTMSResults.Text = SummaryDetailString(s)
            End If
            'Process FamilyDetail response
            If _lastSearch = LastSearchType.QueryTransactionFamilies Then
                If chklstTMSResults.SelectedItem Is Nothing Then
                    Return
                End If
                Dim f As FamilyDetail = DirectCast(chklstTMSResults.SelectedItem, FamilyDetailVal).FD
                txtTMSResults.Text = FamilyDetailString(f)
            End If
            'Process BatchDetailData response
            If _lastSearch = LastSearchType.QueryBatch Then
                If chklstTMSResults.SelectedItem Is Nothing Then
                    Return
                End If
                Dim b As BatchDetailData = DirectCast(chklstTMSResults.SelectedItem, BatchDetailDataVal).BDD
                txtTMSResults.Text = BatchDetailDataString(b)
            End If
            'Process TransactionDetail response
            If _lastSearch = LastSearchType.QueryTransactionsDetail Then
                If chklstTMSResults.SelectedItem Is Nothing Then
                    Return
                End If
                Dim t As TransactionDetail = DirectCast(chklstTMSResults.SelectedItem, TransactionDetailVal).TD
                txtTMSResults.Text = TransactionDetailString(t)
            End If
        End Sub

#Region "process TMS response"

        Private Sub ProcessQueryBatchResponse(ByVal _BDD As List(Of BatchDetailData))
            chklstTMSResults.Items.Clear()

            'Check for the need of paging
            If _BDD.Count > _intResultsPerPage - 1 Then
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                lblPageNumber.Visible = True
                LnkNext.Visible = True
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            Else
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                LnkNext.Visible = False
                'End of the list so disable the Next link
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            End If

            If _BDD.Count > 0 Then
                For Each b As BatchDetailData In _BDD
                    Dim BDD As BatchDetailData = New BatchDetailDataVal(b)
                    chklstTMSResults.Items.Add(BDD)
                Next
            End If
        End Sub

        Private Sub ProcessQueryTransactionFamiliesResponse(ByVal _FD As List(Of FamilyDetail))
            chklstTMSResults.Items.Clear()

            'Check for the need of paging
            If _FD.Count > _intResultsPerPage - 1 Then
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                lblPageNumber.Visible = True
                LnkNext.Visible = True
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            Else
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                LnkNext.Visible = False
                'End of the list so disable the Next link
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            End If

            If _FD.Count > 0 Then
                For Each f As FamilyDetail In _FD
                    Dim SDV As New FamilyDetailVal(f)
                    chklstTMSResults.Items.Add(SDV)
                Next
            End If
        End Sub

        Private Sub ProcessQueryTransactionSummaryResponse(ByVal _SD As List(Of SummaryDetail))
            chklstTMSResults.Items.Clear()

            'Check for the need of paging
            If _SD.Count > _intResultsPerPage - 1 Then
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                lblPageNumber.Visible = True
                LnkNext.Visible = True
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            Else
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                LnkNext.Visible = False
                'End of the list so disable the Next link
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            End If

            If _SD.Count > 0 Then
                For Each s As SummaryDetail In _SD
                    Dim SDV As New SummaryDetailVal(s)
                    chklstTMSResults.Items.Add(SDV)
                Next
            End If
        End Sub

        Private Sub ProcessQueryTransactionsDetailResponse(ByVal _TD As List(Of TransactionDetail))
            chklstTMSResults.Items.Clear()

            'Check for the need of paging
            If _TD.Count > _intResultsPerPage - 1 Then
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                lblPageNumber.Visible = True
                LnkNext.Visible = True
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            Else
                lblPageNumber.Text = "Page : " & (_intCurrentPage + 1)
                LnkNext.Visible = False
                'End of the list so disable the Next link
                'Enable previous on page 2
                If _intCurrentPage > 0 Then
                    LnkPrevious.Visible = True
                Else
                    LnkPrevious.Visible = False
                End If
            End If

            If _TD.Count > 0 Then
                For Each t As TransactionDetail In _TD
                    Dim TDV As New TransactionDetailVal(t)
                    chklstTMSResults.Items.Add(TDV)
                Next
            End If
        End Sub

        Private Function BatchDetailDataString(ByVal b As BatchDetailData) As String
            Dim intPreviousIndex As Integer = -1
            For Each itemChecked As Integer In chklstTMSResults.CheckedIndices
                intPreviousIndex = itemChecked
                chklstTMSResults.SetItemChecked(itemChecked, False)
            Next

            If chklstTMSResults.SelectedIndex <> intPreviousIndex Then
                chklstTMSResults.SetItemChecked(chklstTMSResults.SelectedIndex, True)
            End If

            Dim strSummary As String = ""

            'Batch Summary
            strSummary = strSummary & "BatchCaptureDate : " & Convert.ToString(b.BatchCaptureDate) & " (UTC)" & vbCr & vbLf
            strSummary = strSummary & "BatchId : " & Convert.ToString(b.BatchId) & vbCr & vbLf
            strSummary = strSummary & "Description : " & Convert.ToString(b.Description) & vbCr & vbLf
            'Batch Summary Data
            strSummary = strSummary & "Batch Summary Data"
            If b.BatchSummaryData.CashBackTotals IsNot Nothing Then
                strSummary = strSummary & vbCr & vbLf & "Cash Back Totals " & vbCr & vbLf & "  Count : " & Convert.ToString(b.BatchSummaryData.CashBackTotals.Count) & vbCr & vbLf & "  Net Amount : " & Convert.ToString(b.BatchSummaryData.CashBackTotals.NetAmount)
            End If
            If b.BatchSummaryData.NetTotals IsNot Nothing Then
                strSummary = strSummary & vbCr & vbLf & "Net Totals " & vbCr & vbLf & "  Count : " & Convert.ToString(b.BatchSummaryData.NetTotals.Count) & vbCr & vbLf & "  Net Amount : " & Convert.ToString(b.BatchSummaryData.NetTotals.NetAmount)
            End If
            If b.BatchSummaryData.PINDebitReturnTotals IsNot Nothing Then
                strSummary = strSummary & vbCr & vbLf & "PINDebit Return Totals " & vbCr & vbLf & "  Count : " & Convert.ToString(b.BatchSummaryData.PINDebitReturnTotals.Count) & vbCr & vbLf & "  Net Amount : " & Convert.ToString(b.BatchSummaryData.PINDebitReturnTotals.NetAmount)
            End If
            If b.BatchSummaryData.PINDebitSaleTotals IsNot Nothing Then
                strSummary = strSummary & vbCr & vbLf & "PINDebit Sale Totals " & vbCr & vbLf & "  Count : " & Convert.ToString(b.BatchSummaryData.PINDebitSaleTotals.Count) & vbCr & vbLf & "  Net Amount : " & Convert.ToString(b.BatchSummaryData.PINDebitSaleTotals.NetAmount)
            End If
            If b.BatchSummaryData.ReturnTotals IsNot Nothing Then
                strSummary = strSummary & vbCr & vbLf & "Return Totals " & vbCr & vbLf & "  Count : " & Convert.ToString(b.BatchSummaryData.ReturnTotals.Count) & vbCr & vbLf & "  Net Amount : " & Convert.ToString(b.BatchSummaryData.ReturnTotals.NetAmount)
            End If
            If b.BatchSummaryData.SaleTotals IsNot Nothing Then
                strSummary = strSummary & vbCr & vbLf & "Sale Totals " & vbCr & vbLf & "  Count : " & Convert.ToString(b.BatchSummaryData.SaleTotals.Count) & vbCr & vbLf & "  Net Amount : " & Convert.ToString(b.BatchSummaryData.SaleTotals.NetAmount)
            End If
            If b.BatchSummaryData.VoidTotals IsNot Nothing Then
                strSummary = strSummary & vbCr & vbLf & "Void Totals " & vbCr & vbLf & "  Count : " & Convert.ToString(b.BatchSummaryData.VoidTotals.Count) & vbCr & vbLf & "  Net Amount : " & Convert.ToString(b.BatchSummaryData.VoidTotals.NetAmount)
            End If
            'TransactionId
            strSummary = strSummary & vbCr & vbLf & "List of TransactionIds" & vbCr & vbLf
            If b.TransactionIds IsNot Nothing Then
                For Each txnid As String In b.TransactionIds
                    strSummary = strSummary & txnid & vbCr & vbLf
                Next
            End If
            strSummary = strSummary & vbCr & vbLf
            Return strSummary
        End Function

        Private Function FamilyDetailString(ByVal f As FamilyDetail) As String
            Dim intPreviousIndex As Integer = -1
            For Each itemChecked As Integer In chklstTMSResults.CheckedIndices
                intPreviousIndex = itemChecked
                chklstTMSResults.SetItemChecked(itemChecked, False)
            Next

            If chklstTMSResults.SelectedIndex <> intPreviousIndex Then
                chklstTMSResults.SetItemChecked(chklstTMSResults.SelectedIndex, True)
            End If

            Dim strSummary As String = ""

            'Family Summary
            strSummary = strSummary & "FamilyId : " & Convert.ToString(f.FamilyId) & vbCr & vbLf
            strSummary = strSummary & "FamilyState : " & Convert.ToString(f.FamilyState) & vbCr & vbLf
            strSummary = strSummary & "LastAuthorizedAmount : " & Convert.ToString(f.LastAuthorizedAmount) & vbCr & vbLf
            strSummary = strSummary & "MerchantProfileId : " & Convert.ToString(f.MerchantProfileId) & vbCr & vbLf
            strSummary = strSummary & "NetAmount : " & Convert.ToString(f.NetAmount) & vbCr & vbLf
            strSummary = strSummary & "ServiceKey : " & Convert.ToString(f.ServiceKey) & vbCr & vbLf

            'TransactionId
            strSummary = strSummary & "List of TransactionIds" & vbCr & vbLf
            For Each txnid As String In f.TransactionIds
                strSummary = strSummary & txnid & vbCr & vbLf
            Next
            strSummary = strSummary & vbCr & vbLf
            Return strSummary
        End Function

        Private Function SummaryDetailString(ByVal s As SummaryDetail) As String
            s.TransactionInformation.BankcardData = New BankcardData()
            s.TransactionInformation.BankcardData.AVSResult = New AVSResult()

            If chkUseTransactionIdSelected.Checked Then
                txtQTP_TransactionIds.Text = s.TransactionInformation.TransactionId
            End If

            Dim intPreviousIndex As Integer = -1
            For Each itemChecked As Integer In chklstTMSResults.CheckedIndices
                intPreviousIndex = itemChecked
                chklstTMSResults.SetItemChecked(itemChecked, False)
            Next

            If chklstTMSResults.SelectedIndex <> intPreviousIndex Then
                chklstTMSResults.SetItemChecked(chklstTMSResults.SelectedIndex, True)
            End If

            Dim strSummary As String = ""
            'Family Information
            strSummary = strSummary & "Family Information" & vbCr & vbLf
            strSummary = strSummary & "FamilyId : " & Convert.ToString(s.FamilyInformation.FamilyId) & vbCr & vbLf
            strSummary = strSummary & "FamilySequenceCount : " & Convert.ToString(s.FamilyInformation.FamilySequenceCount) & vbCr & vbLf
            strSummary = strSummary & "FamilySequenceNumber : " & Convert.ToString(s.FamilyInformation.FamilySequenceNumber) & vbCr & vbLf
            strSummary = strSummary & "FamilyState : " & Convert.ToString(s.FamilyInformation.FamilyState) & vbCr & vbLf
            'Transaction Information
            strSummary = strSummary & "Transaction Information" & vbCr & vbLf
            strSummary = strSummary & "Amount : " & Convert.ToString(s.TransactionInformation.Amount) & vbCr & vbLf
            strSummary = strSummary & "ApprovalCode : " & Convert.ToString(s.TransactionInformation.ApprovalCode) & vbCr & vbLf
            strSummary = strSummary & "AVSResult Summary" & vbCr & vbLf
            strSummary = strSummary & " - ActualResult : " & Convert.ToString(s.TransactionInformation.BankcardData.AVSResult.ActualResult) & vbCr & vbLf
            strSummary = strSummary & " - AddressResult : " & Convert.ToString(s.TransactionInformation.BankcardData.AVSResult.AddressResult) & vbCr & vbLf
            strSummary = strSummary & " - PostalCodeResult : " & Convert.ToString(s.TransactionInformation.BankcardData.AVSResult.PostalCodeResult) & vbCr & vbLf
            strSummary = strSummary & "BatchId : " & Convert.ToString(s.TransactionInformation.BatchId) & vbCr & vbLf
            strSummary = strSummary & "CaptureDateTime : " & Convert.ToString(s.TransactionInformation.CaptureDateTime) & vbCr & vbLf
            strSummary = strSummary & "CaptureState : " & Convert.ToString(s.TransactionInformation.CaptureState) & vbCr & vbLf
            strSummary = strSummary & "CardType : " & Convert.ToString(s.TransactionInformation.BankcardData.CardType) & vbCr & vbLf
            strSummary = strSummary & "CustomerId : " & Convert.ToString(s.TransactionInformation.CustomerId) & vbCr & vbLf
            strSummary = strSummary & "CVResult : " & Convert.ToString(s.TransactionInformation.BankcardData.CVResult) & vbCr & vbLf
            strSummary = strSummary & "IsAcknowledged : " & Convert.ToString(s.TransactionInformation.IsAcknowledged) & vbCr & vbLf
            strSummary = strSummary & "MaskedPAN : " & Convert.ToString(s.TransactionInformation.MaskedPAN) & vbCr & vbLf
            strSummary = strSummary & "MerchantProfileId : " & Convert.ToString(s.TransactionInformation.MerchantProfileId) & vbCr & vbLf
            strSummary = strSummary & "OriginatorTransactionId : " & Convert.ToString(s.TransactionInformation.OriginatorTransactionId) & vbCr & vbLf
            strSummary = strSummary & "ServiceId : " & Convert.ToString(s.TransactionInformation.ServiceId) & vbCr & vbLf
            strSummary = strSummary & "ServiceKey : " & Convert.ToString(s.TransactionInformation.ServiceKey) & vbCr & vbLf
            strSummary = strSummary & "ServiceTransactionId : " & Convert.ToString(s.TransactionInformation.ServiceTransactionId) & vbCr & vbLf
            strSummary = strSummary & "Status : " & Convert.ToString(s.TransactionInformation.Status) & vbCr & vbLf
            strSummary = strSummary & "TransactionClass : " & Convert.ToString(s.TransactionInformation.TransactionClassTypePair.TransactionClass) & "    "
            strSummary = strSummary & "TransactionType : " & Convert.ToString(s.TransactionInformation.TransactionClassTypePair.TransactionType) & vbCr & vbLf
            strSummary = strSummary & "TransactionId : " & Convert.ToString(s.TransactionInformation.TransactionId) & vbCr & vbLf
            strSummary = strSummary & "TransactionState : " & Convert.ToString(s.TransactionInformation.TransactionState) & vbCr & vbLf
            strSummary = strSummary & "TransactionStatusCode : " & Convert.ToString(s.TransactionInformation.TransactionStatusCode) & vbCr & vbLf
            strSummary = strSummary & "TransactionTimestamp : " & Convert.ToString(s.TransactionInformation.TransactionTimestamp) & vbCr & vbLf
            strSummary = strSummary & vbCr & vbLf
            Return strSummary
        End Function

        Private Function TransactionDetailString(ByVal t As TransactionDetail) As String
            Dim intPreviousIndex As Integer = -1
            For Each itemChecked As Integer In chklstTMSResults.CheckedIndices
                intPreviousIndex = itemChecked
                chklstTMSResults.SetItemChecked(itemChecked, False)
            Next

            If chklstTMSResults.SelectedIndex <> intPreviousIndex Then
                chklstTMSResults.SetItemChecked(chklstTMSResults.SelectedIndex, True)
            End If

            Dim strSummary As String = ""
            Dim strSerialState As String = ""

            t.TransactionInformation.BankcardData = New BankcardData()
            t.TransactionInformation.BankcardData.AVSResult = New AVSResult()
            'Batch Summary
            strSummary = strSummary & "CompleteTransaction CWS object : " & "OBJECT" & vbCr & vbLf
            If t.CompleteTransaction.SerializedTransaction Is Nothing Then
                strSerialState = "CompleteTransaction Serialized : NOT AVAILABLE" & vbCr & vbLf
            Else
                strSerialState = "CompleteTransaction Serialized : " & Convert.ToString(t.CompleteTransaction.SerializedTransaction) & vbCr & vbLf

            End If
            strSummary = strSummary & strSerialState
            'Family Information
            strSummary = strSummary & "Family Information " & vbCr & vbLf
            strSummary = strSummary & "FamilyId : " & Convert.ToString(t.FamilyInformation.FamilyId) & vbCr & vbLf
            strSummary = strSummary & "FamilySequenceCount : " & Convert.ToString(t.FamilyInformation.FamilySequenceCount) & vbCr & vbLf
            strSummary = strSummary & "FamilySequenceNumber : " & Convert.ToString(t.FamilyInformation.FamilySequenceNumber) & vbCr & vbLf
            strSummary = strSummary & "FamilyState : " & Convert.ToString(t.FamilyInformation.FamilyState) & vbCr & vbLf
            'Transaction Information
            strSummary = strSummary & "Transaction Information" & vbCr & vbLf
            strSummary = strSummary & "Amount : " & Convert.ToString(t.TransactionInformation.Amount) & vbCr & vbLf
            strSummary = strSummary & "ApprovalCode : " & Convert.ToString(t.TransactionInformation.ApprovalCode) & vbCr & vbLf
            strSummary = strSummary & "AVSResult Summary"
            strSummary = strSummary & " - ActualResult : " & Convert.ToString(t.TransactionInformation.BankcardData.AVSResult.ActualResult) & vbCr & vbLf
            strSummary = strSummary & " - AddressResult : " & Convert.ToString(t.TransactionInformation.BankcardData.AVSResult.AddressResult) & vbCr & vbLf
            strSummary = strSummary & " - PostalCodeResult : " & Convert.ToString(t.TransactionInformation.BankcardData.AVSResult.PostalCodeResult) & vbCr & vbLf
            strSummary = strSummary & "BatchId : " & Convert.ToString(t.TransactionInformation.BatchId) & vbCr & vbLf
            strSummary = strSummary & "CaptureDateTime : " & Convert.ToString(t.TransactionInformation.CaptureDateTime) & vbCr & vbLf
            strSummary = strSummary & "CaptureState : " & Convert.ToString(t.TransactionInformation.CaptureState) & vbCr & vbLf
            strSummary = strSummary & "CardType : " & Convert.ToString(t.TransactionInformation.BankcardData.CardType) & vbCr & vbLf
            strSummary = strSummary & "CustomerId : " & Convert.ToString(t.TransactionInformation.CustomerId) & vbCr & vbLf
            strSummary = strSummary & "CVResult : " & Convert.ToString(t.TransactionInformation.BankcardData.CVResult) & vbCr & vbLf
            strSummary = strSummary & "IsAcknowledged : " & Convert.ToString(t.TransactionInformation.IsAcknowledged) & vbCr & vbLf
            strSummary = strSummary & "MaskedPAN : " & Convert.ToString(t.TransactionInformation.MaskedPAN) & vbCr & vbLf
            strSummary = strSummary & "MerchantProfileId : " & Convert.ToString(t.TransactionInformation.MerchantProfileId) & vbCr & vbLf
            strSummary = strSummary & "OriginatorTransactionId : " & Convert.ToString(t.TransactionInformation.OriginatorTransactionId) & vbCr & vbLf
            strSummary = strSummary & "ServiceId : " & Convert.ToString(t.TransactionInformation.ServiceId) & vbCr & vbLf
            strSummary = strSummary & "ServiceKey : " & Convert.ToString(t.TransactionInformation.ServiceKey) & vbCr & vbLf
            strSummary = strSummary & "ServiceTransactionId : " & Convert.ToString(t.TransactionInformation.ServiceTransactionId) & vbCr & vbLf
            strSummary = strSummary & "Status : " & Convert.ToString(t.TransactionInformation.Status) & vbCr & vbLf
            strSummary = strSummary & "TransactionClass : " & Convert.ToString(t.TransactionInformation.TransactionClassTypePair.TransactionClass) & "    "
            strSummary = strSummary & "TransactionType : " & Convert.ToString(t.TransactionInformation.TransactionClassTypePair.TransactionType) & vbCr & vbLf
            strSummary = strSummary & "TransactionId : " & Convert.ToString(t.TransactionInformation.TransactionId) & vbCr & vbLf
            strSummary = strSummary & "TransactionState : " & Convert.ToString(t.TransactionInformation.TransactionState) & vbCr & vbLf
            strSummary = strSummary & "TransactionStatusCode : " & Convert.ToString(t.TransactionInformation.TransactionStatusCode) & vbCr & vbLf
            strSummary = strSummary & "TransactionTimestamp : " & Convert.ToString(t.TransactionInformation.TransactionTimestamp) & vbCr & vbLf
            strSummary = strSummary & vbCr & vbLf

            strSummary = strSummary & vbCr & vbLf
            Return strSummary
        End Function

#End Region

#Region "Setup Help Links"
        Private Sub lnkQueryBatch_Click(ByVal sender As Object, ByVal e As EventArgs)
            System.Diagnostics.Process.Start("http://commercelab.ipcommerce.com/Docs/Documentation/1.17.13/CWS_TMS_Developer_Guide/TMSImplementation/Operations/QueryBatch.aspx")
        End Sub
        Private Sub lnkQueryTransactions_Click(ByVal sender As Object, ByVal e As EventArgs)
            System.Diagnostics.Process.Start("http://commercelab.ipcommerce.com/Docs/Documentation/1.17.13/CWS_TMS_Developer_Guide/TMSImplementation/Operations/QueryTransactionsSummary.aspx")
        End Sub
        Private Sub lnkQueryTransactionFamilies_Click(ByVal sender As Object, ByVal e As EventArgs)
            System.Diagnostics.Process.Start("http://commercelab.ipcommerce.com/Docs/Documentation/1.17.13/CWS_TMS_Developer_Guide/TMSImplementation/Operations/QueryTransactionFamilies.aspx")
        End Sub
        Private Sub lnkQueryTransactionDetails_Click(ByVal sender As Object, ByVal e As EventArgs)
            System.Diagnostics.Process.Start("http://commercelab.ipcommerce.com/Docs/Documentation/1.17.13/CWS_TMS_Developer_Guide/TMSImplementation/Operations/QueryTransactionsDetail.aspx")
        End Sub
#End Region

    End Class

#Region "Local Classes"

    Public Class SummaryDetailVal
        Inherits SummaryDetail
        Public SD As SummaryDetail
        Public Sub New(ByVal sd__1 As SummaryDetail)
            SD = sd__1
        End Sub
        Public Overrides Function ToString() As String
            ' Generates the text shown in the combo box
            Return Convert.ToString(SD.TransactionInformation.Amount) & " | " & Convert.ToString(SD.TransactionInformation.TransactionId) & " (" & Convert.ToString(SD.TransactionInformation.TransactionTimestamp) & ") UTC"
        End Function
    End Class

    Public Class FamilyDetailVal
        Inherits FamilyDetail
        Public FD As FamilyDetail
        Public Sub New(ByVal fd__1 As FamilyDetail)
            FD = fd__1
        End Sub
        Public Overrides Function ToString() As String
            ' Generates the text shown in the combo box
            Return "Net Amount : " & Convert.ToString(FD.NetAmount) & " | Family State : " & Convert.ToString(FD.FamilyState)
        End Function
    End Class

    Public Class BatchDetailDataVal
        Inherits BatchDetailData
        Public BDD As BatchDetailData
        Public Sub New(ByVal bdd__1 As BatchDetailData)
            BDD = bdd__1
        End Sub
        Public Overrides Function ToString() As String
            ' Generates the text shown in the combo box
            Return "BatchId : " & Convert.ToString(BDD.BatchId) & " | BatchCaptureDate : " & Convert.ToString(BDD.BatchCaptureDate)
        End Function
    End Class

    Public Class TransactionDetailVal
        Inherits TransactionDetail
        Public TD As TransactionDetail
        Public Sub New(ByVal td__1 As TransactionDetail)
            TD = td__1
        End Sub
        Public Overrides Function ToString() As String
            ' Generates the text shown in the combo box
            Return Convert.ToString(TD.TransactionInformation.Amount) & " | " & Convert.ToString(TD.TransactionInformation.TransactionId) & " (" & Convert.ToString(TD.TransactionInformation.TransactionTimestamp) & ") UTC"
        End Function
    End Class

    Public Enum LastSearchType As Integer
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        QueryTransactionsSummary = 0
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        QueryTransactionFamilies = 1
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        QueryTransactionsDetail = 2
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        QueryBatch = 3

    End Enum

#End Region
End Namespace

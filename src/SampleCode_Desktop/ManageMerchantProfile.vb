#Region "DISCLAIMER"
' Copyright (c) 2004-2010 IP Commerce, INC. - All Rights Reserved.
' *
' * This software and documentation is subject to and made
' * available only pursuant to the terms of an executed license
' * agreement, and may be used only in accordance with the terms
' * of said agreement. This software may not, in whole or in part,
' * be copied, photocopied, reproduced, translated, or reduced to
' * any electronic medium or machine-readable form without
' * prior consent, in writing, from IP Commerce, INC.
' *
' * Use, duplication or disclosure by the U.S. Government is subject
' * to restrictions set forth in an executed license agreement
' * and in subparagraph (c)(1) of the Commercial Computer
' * Software-Restricted Rights Clause at FAR 52.227-19; subparagraph
' * (c)(1)(ii) of the Rights in Technical Data and Computer Software
' * clause at DFARS 252.227-7013, subparagraph (d) of the Commercial
' * Computer Software--Licensing clause at NASA FAR supplement
' * 16-52.227-86; or their equivalent.
' *
' * Information in this software is subject to change without notice
' * and does not represent a commitment on the part of IP Commerce.
' * 
' * Sample Code is for reference Only and is intended to be used for educational purposes. It's the responsibility of 
' * the software company to properly integrate into thier solution code that best meets thier production needs. 
'

#End Region

Imports System.Collections.Generic
Imports System.Configuration
Imports System.Windows.Forms
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo

Namespace SampleCode
    Partial Public Class ManageMerchantProfile
        Inherits Form
        Private _Language As TypeISOLanguageCodeA3
        Private _CountryCode As TypeISOCountryCodeA3
        Private _CurrencyCode As TypeISOCurrencyCodeA3
        Private _CustomerPresent As CustomerPresent
        Private _RequestACI As RequestACI
        Private _MerchantIndustryType As IndustryType
        Private _EntryMode As EntryMode
        Public _Dirty As Boolean
        Public Helper As New HelperMethods() 'The following class performs many of the different operations needs for service information and trasaction processing
        Private _bcs As New BankcardService()
        Private _ecks As New ElectronicCheckingService()
        Private _svas As New StoredValueService()
        Private _strServiceID As String
        Private Shared _dg As DataGenerator
        Private Item As New Object

        Protected _FaultHandler As New FaultHandler.FaultHandler()

        Public Sub New()
            InitializeComponent()

            'Actions for Application Data - Typically only performed upon initial installation of software
            'Note : Resultant variable to be stored : ApplicationProfileId
            cboMerchantDataAction.Items.Add(New Item("[Select Action]", "0", ""))
            cboMerchantDataAction.Items.Add(New Item("Is Merchant Profile Initialized", "1", ""))
            cboMerchantDataAction.Items.Add(New Item("Get Merchant Profile", "2", ""))
            cboMerchantDataAction.Items.Add(New Item("Get Merchant Profile Ids", "3", ""))
            cboMerchantDataAction.Items.Add(New Item("Get Merchant Profiles", "4", ""))
            cboMerchantDataAction.Items.Add(New Item("Get Merchant Profiles By ProfileId", "5", ""))
            cboMerchantDataAction.Items.Add(New Item("Save Merchant Profiles", "6", ""))
            cboMerchantDataAction.Items.Add(New Item("Delete Merchant Profile", "7", ""))
            cboMerchantDataAction.SelectedIndex = 0
        End Sub
        
        Private Sub ManageMerchantProfile_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            For Each Item In CType(Owner, SampleCode_DeskTop).cboAvailableProfiles.Items
                cboAvailableProfiles.Items.Add(Item)
            Next Item
            cboAvailableProfiles.SelectedItem = CType(Owner, SampleCode_DeskTop).cboAvailableProfiles.SelectedItem
        End Sub

        Private Sub showECKFields()
            'MerchantData
            txtCustomerServiceInternet.ReadOnly = False
            txtCustomerServicePhone.ReadOnly = False
            txtMerchantId.ReadOnly = False
            lblMerchantId.Text = "OriginatorId"
            txtName.ReadOnly = False
            txtPhone.ReadOnly = False
            txtTaxId.ReadOnly = True
            'MerchantData.Address
            txtCity.ReadOnly = False
            txtPostalCode.ReadOnly = False
            txtStateProvince.ReadOnly = False
            txtStreetAddress1.ReadOnly = False
            txtStreetAddress2.ReadOnly = False
            'MerchantData.BankcardMerchantData
            txtABANumber.ReadOnly = True
            txtAcquirerBIN.ReadOnly = True
            txtAgentBank.ReadOnly = True
            txtAgentChain.ReadOnly = True
            txtClientNum.ReadOnly = True
            txtLocation.ReadOnly = True
            txtSecondaryTerminalId.ReadOnly = True
            txtSettlementAgent.ReadOnly = True
            txtSharingGroup.ReadOnly = True
            txtSIC.ReadOnly = False
            txtStoreId.ReadOnly = False
            lblStoreId.Text = "SiteId"
            txtSocketNum.ReadOnly = False
            lblTerminalId.Text = "ProductId"
            txtTimeZoneDifferential.ReadOnly = True
            txtReimbursementAttribute.ReadOnly = True
            txtClientNum.Text = ""

        End Sub

        Private Sub showSVAFields()
            'MerchantData
            txtCustomerServiceInternet.ReadOnly = False
            txtCustomerServicePhone.ReadOnly = False
            txtMerchantId.ReadOnly = False
            txtName.ReadOnly = False
            txtPhone.ReadOnly = False
            txtTaxId.ReadOnly = False
            'MerchantData.Address
            txtCity.ReadOnly = False
            txtPostalCode.ReadOnly = False
            txtStateProvince.ReadOnly = False
            txtStreetAddress1.ReadOnly = False
            txtStreetAddress2.ReadOnly = False
            'MerchantData.BankcardMerchantData
            txtABANumber.ReadOnly = True
            txtAcquirerBIN.ReadOnly = True
            txtAgentBank.ReadOnly = True
            txtAgentChain.ReadOnly = False
            txtAgentChain.Text = "124423"
            txtClientNum.ReadOnly = False
            txtLocation.ReadOnly = True
            txtSecondaryTerminalId.ReadOnly = True
            txtSettlementAgent.ReadOnly = True
            txtSharingGroup.ReadOnly = True
            txtSIC.ReadOnly = False
            txtStoreId.ReadOnly = False
            txtSocketNum.ReadOnly = False
            txtTimeZoneDifferential.ReadOnly = True
            txtReimbursementAttribute.ReadOnly = True

        End Sub

        Private Sub showBCPFields()
            'MerchantData
            txtCustomerServiceInternet.ReadOnly = False
            txtCustomerServicePhone.ReadOnly = False
            txtMerchantId.ReadOnly = False
            txtName.ReadOnly = False
            txtPhone.ReadOnly = False
            txtTaxId.ReadOnly = False
            'MerchantData.Address
            txtCity.ReadOnly = False
            txtPostalCode.ReadOnly = False
            txtStateProvince.ReadOnly = False
            txtStreetAddress1.ReadOnly = False
            txtStreetAddress2.ReadOnly = False
            'MerchantData.BankcardMerchantData
            txtABANumber.ReadOnly = True
            txtAcquirerBIN.ReadOnly = True
            txtAgentBank.ReadOnly = True
            txtAgentChain.ReadOnly = True
            txtClientNum.ReadOnly = True
            txtLocation.ReadOnly = True
            txtSecondaryTerminalId.ReadOnly = True
            txtSettlementAgent.ReadOnly = True
            txtSharingGroup.ReadOnly = True
            txtSIC.ReadOnly = False
            txtStoreId.ReadOnly = True
            txtSocketNum.ReadOnly = False
            txtTimeZoneDifferential.ReadOnly = True
            txtReimbursementAttribute.ReadOnly = True

        End Sub

        Private Sub showBCPExpandedFields()
            'MerchantData
            txtCustomerServiceInternet.ReadOnly = False
            txtCustomerServicePhone.ReadOnly = False
            txtMerchantId.ReadOnly = False
            txtName.ReadOnly = False
            txtPhone.ReadOnly = False
            txtTaxId.ReadOnly = False
            'MerchantData.Address
            txtCity.ReadOnly = False
            txtPostalCode.ReadOnly = False
            txtStateProvince.ReadOnly = False
            txtStreetAddress1.ReadOnly = False
            txtStreetAddress2.ReadOnly = False
            'MerchantData.BankcardMerchantData
            txtABANumber.ReadOnly = False
            txtAcquirerBIN.ReadOnly = False
            txtAgentBank.ReadOnly = False
            txtAgentChain.ReadOnly = False
            txtClientNum.ReadOnly = False
            txtLocation.ReadOnly = False
            txtSecondaryTerminalId.ReadOnly = False
            txtSettlementAgent.ReadOnly = False
            txtSharingGroup.ReadOnly = False
            txtSIC.ReadOnly = False
            txtStoreId.ReadOnly = False
            txtSocketNum.ReadOnly = False
            txtTimeZoneDifferential.ReadOnly = False
            txtReimbursementAttribute.ReadOnly = False
        End Sub

        Private Sub hideAllFields()
            'MerchantData
            txtCustomerServiceInternet.ReadOnly = True
            txtCustomerServicePhone.ReadOnly = True
            txtMerchantId.ReadOnly = True
            lblMerchantId.Text = "MerchantId"
            txtName.ReadOnly = True
            txtPhone.ReadOnly = True
            txtTaxId.ReadOnly = True
            'MerchantData.Address
            txtCity.ReadOnly = True
            txtPostalCode.ReadOnly = True
            txtStateProvince.ReadOnly = True
            txtStreetAddress1.ReadOnly = True
            txtStreetAddress2.ReadOnly = True
            'MerchantData.BankcardMerchantData
            txtABANumber.ReadOnly = True
            txtAcquirerBIN.ReadOnly = True
            txtAgentBank.ReadOnly = True
            txtAgentChain.ReadOnly = True
            txtClientNum.ReadOnly = True
            txtLocation.ReadOnly = True
            txtSecondaryTerminalId.ReadOnly = True
            txtSettlementAgent.ReadOnly = True
            txtSharingGroup.ReadOnly = True
            txtSIC.ReadOnly = True
            txtStoreId.ReadOnly = True
            lblStoreId.Text = "StoreId"
            txtSocketNum.ReadOnly = True
            lblTerminalId.Text = "TerminalId"
            txtTimeZoneDifferential.ReadOnly = True
            txtReimbursementAttribute.ReadOnly = True
        End Sub

        Private Sub showAllFields()
            'MerchantData
            txtCustomerServiceInternet.ReadOnly = False
            txtCustomerServicePhone.ReadOnly = False
            txtMerchantId.ReadOnly = False
            lblMerchantId.Text = "MerchantId"
            txtName.ReadOnly = False
            txtPhone.ReadOnly = False
            txtTaxId.ReadOnly = False
            'MerchantData.Address
            txtCity.ReadOnly = False
            txtPostalCode.ReadOnly = False
            txtStateProvince.ReadOnly = False
            txtStreetAddress1.ReadOnly = False
            txtStreetAddress2.ReadOnly = False
            'MerchantData.BankcardMerchantData
            txtABANumber.ReadOnly = False
            txtAcquirerBIN.ReadOnly = False
            txtAgentBank.ReadOnly = False
            txtAgentChain.ReadOnly = False
            txtClientNum.ReadOnly = False
            txtLocation.ReadOnly = False
            txtSecondaryTerminalId.ReadOnly = False
            txtSettlementAgent.ReadOnly = False
            txtSharingGroup.ReadOnly = False
            txtSIC.ReadOnly = False
            txtStoreId.ReadOnly = False
            lblStoreId.Text = "StoreId"
            txtSocketNum.ReadOnly = False
            lblTerminalId.Text = "TerminalId"
            txtTimeZoneDifferential.ReadOnly = False
            txtReimbursementAttribute.ReadOnly = False
        End Sub

        Public Sub CallingForm(ByVal merchantProfile As MerchantProfile, ByVal blnNewProfile As Boolean, ByVal bcs As BankcardService, ByVal ecks As ElectronicCheckingService, ByVal serviceId As String, ByVal dg As DataGenerator)
            _bcs = bcs
            _ecks = ecks
            _strServiceID = serviceId
            _dg = dg

            hideAllFields()
            'Since MerchantProfile is saved at the serviceId level, display serviceId.
            'txtMerchantProfileServiceId.Text = merchantProfile.ServiceId;

            If serviceId.Length < 1 Then
                txtMerchantProfileServiceId.Text = "ServiceId not selected in calling form"
            Else
                txtMerchantProfileServiceId.Text = serviceId
            End If

            'Populate combo boxes with the Enumeration
            cboCountryCode.Sorted = True
            cboCountryCode.DataSource = System.Enum.GetValues(GetType(TypeISOCountryCodeA3))
            cboCountryCode.SelectedItem = TypeISOCountryCodeA3.NotSet

            cboLanguage.Sorted = True
            cboLanguage.DataSource = System.Enum.GetValues(GetType(TypeISOLanguageCodeA3))
            cboLanguage.SelectedItem = TypeISOLanguageCodeA3.NotSet

            cboCurrencyCode.Sorted = True
            cboCurrencyCode.DataSource = System.Enum.GetValues(GetType(TypeISOCurrencyCodeA3))
            cboCurrencyCode.SelectedItem = TypeISOCurrencyCodeA3.NotSet


            cboCustomerPresent.Sorted = True
            cboCustomerPresent.DataSource = System.Enum.GetValues(GetType(CustomerPresent))
            cboCustomerPresent.SelectedItem = CustomerPresent.NotSet

            cboRequestACI.Sorted = True
            cboRequestACI.DataSource = System.Enum.GetValues(GetType(RequestACI))
            cboRequestACI.SelectedItem = RequestACI.IsCPSMeritCapable

            cboEntryMode.Sorted = True
            cboEntryMode.DataSource = System.Enum.GetValues(GetType(EntryMode))
            cboEntryMode.SelectedItem = EntryMode.NotSet

            cboMerchantIndustryType.Sorted = True
            cboMerchantIndustryType.DataSource = System.Enum.GetValues(GetType(IndustryType))
            cboMerchantIndustryType.SelectedItem = IndustryType.NotSet

            If _bcs IsNot Nothing Then
                If _strServiceID = "C82ED00001" OrElse _strServiceID = "71C8700001" OrElse _strServiceID = "88D9300001" OrElse _strServiceID = "B447F00001" OrElse _strServiceID = "D806000001" OrElse _strServiceID = "E88FD00001" Then
                    showBCPExpandedFields()
                ElseIf _strServiceID = "168511300C" OrElse _strServiceID = "9999999999" Then
                    showBCPExpandedFields()
                Else
                    showBCPFields()
                End If
            End If

            If _ecks IsNot Nothing Then
                showECKFields()
            End If
            If _svas IsNot Nothing Then
                showSVAFields()
            End If
        End Sub

        Private Sub SaveMerchantProfiles()
            Try
                'Unique MerchantProfileId should be used for all new MerchantProfiles added
                If cboAvailableProfiles.Text.Length < 1 Then
                    MessageBox.Show("Merchant ProfileId required and cannot be empty")
                    cboAvailableProfiles.Focus()
                    Return
                End If
                SaveMerchantInformation()
            Catch e1 As System.ServiceModel.EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    CType(Owner, SampleCode_DeskTop).Helper.SetSvcEndpoint() 'Change the endpoint to use the backup.
                    SaveMerchantInformation()
                Catch e2 As System.ServiceModel.EndpointNotFoundException
                    MessageBox.Show("Neither the primary or secondary endpoints are available. Unable to process.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            End Try
        End Sub

        Private Sub DeleteMerchantProfile()
            Try
                'Unique MerchantProfileId should be used for all new MerchantProfiles added
                If cboAvailableProfiles.Text.Length < 1 Then
                    MessageBox.Show("Merchant ProfileId required and cannot be empty")
                    cboAvailableProfiles.Focus()
                    Return
                End If

                DeleteMerchProfile()
            Catch e1 As System.ServiceModel.EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    CType(Owner, SampleCode_DeskTop).Helper.SetSvcEndpoint() 'Change the endpoint to use the backup.
                    DeleteMerchProfile()
                Catch e2 As System.ServiceModel.EndpointNotFoundException
                    MessageBox.Show("Neither the primary or secondary endpoints are available. Unable to process.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    MessageBox.Show(strErrorId & " : " & strErrorMessage)
                Else
                    MessageBox.Show(ex.Message)
                End If
            End Try
        End Sub

#Region "WebService Calls"

        Private Sub SaveMerchantInformation()
            Dim MPList As New List(Of MerchantProfile)()
            Dim MerP As New MerchantProfile()

            MerP.ProfileId = cboAvailableProfiles.Text
            MerP.MerchantData = New MerchantProfileMerchantData()
            MerP.MerchantData.Address = New AddressInfo()
            'MerP.MerchantData.BankcardMerchantData = new BankcardMerchantData();

            MerP.TransactionData = New MerchantProfileTransactionData()


            MerP.MerchantData.Address.Street1 = txtStreetAddress1.Text
            MerP.MerchantData.Address.Street2 = txtStreetAddress2.Text
            MerP.MerchantData.Address.City = txtCity.Text
            Try
                MerP.MerchantData.Address.StateProvince = DirectCast(System.Enum.Parse(GetType(TypeStateProvince), txtStateProvince.Text), TypeStateProvince)
            Catch
            End Try
            MerP.MerchantData.Address.PostalCode = txtPostalCode.Text
            MerP.MerchantData.CustomerServicePhone = txtCustomerServicePhone.Text
            MerP.MerchantData.CustomerServiceInternet = txtCustomerServiceInternet.Text
            MerP.MerchantData.MerchantId = txtMerchantId.Text
            MerP.MerchantData.Name = txtName.Text
            MerP.MerchantData.Phone = txtPhone.Text
            MerP.MerchantData.TaxId = txtTaxId.Text
            MerP.MerchantData.Language = _Language
            MerP.MerchantData.Address.CountryCode = _CountryCode

            MerP.MerchantData.BankcardMerchantData = New BankcardMerchantData()

            If _bcs IsNot Nothing Then
                MerP.TransactionData.BankcardTransactionDataDefaults = New BankcardTransactionDataDefaults()
                MerP.MerchantData.BankcardMerchantData = New BankcardMerchantData()
                MerP.MerchantData.BankcardMerchantData.ClientNumber = txtClientNum.Text
                MerP.MerchantData.BankcardMerchantData.SIC = txtSIC.Text
                MerP.MerchantData.BankcardMerchantData.TerminalId = txtSocketNum.Text
                MerP.MerchantData.BankcardMerchantData.StoreId = txtStoreId.Text
                MerP.TransactionData.BankcardTransactionDataDefaults.CurrencyCode = _CurrencyCode
                MerP.TransactionData.BankcardTransactionDataDefaults.CustomerPresent = _CustomerPresent
                MerP.TransactionData.BankcardTransactionDataDefaults.RequestACI = _RequestACI
                MerP.TransactionData.BankcardTransactionDataDefaults.RequestAdvice = RequestAdvice.Capable
                MerP.TransactionData.BankcardTransactionDataDefaults.EntryMode = _EntryMode

                ' Terminal Capture other providers
                MerP.MerchantData.BankcardMerchantData.ABANumber = txtABANumber.Text
                MerP.MerchantData.BankcardMerchantData.AcquirerBIN = txtAcquirerBIN.Text
                MerP.MerchantData.BankcardMerchantData.AgentBank = txtAgentBank.Text
                MerP.MerchantData.BankcardMerchantData.AgentChain = txtAgentChain.Text
                MerP.MerchantData.BankcardMerchantData.Location = txtLocation.Text
                MerP.MerchantData.BankcardMerchantData.SecondaryTerminalId = txtSecondaryTerminalId.Text
                MerP.MerchantData.BankcardMerchantData.SettlementAgent = txtSettlementAgent.Text
                MerP.MerchantData.BankcardMerchantData.SharingGroup = txtSharingGroup.Text
                MerP.MerchantData.BankcardMerchantData.TimeZoneDifferential = txtTimeZoneDifferential.Text
                MerP.MerchantData.BankcardMerchantData.ReimbursementAttribute = txtReimbursementAttribute.Text
                MerP.MerchantData.BankcardMerchantData.IndustryType = _MerchantIndustryType
            End If

            If _ecks IsNot Nothing Then
                MerP.MerchantData.ElectronicCheckingMerchantData = New ElectronicCheckingMerchantData()
                MerP.MerchantData.ElectronicCheckingMerchantData.OrginatorId = txtMerchantId.Text
                MerP.MerchantData.ElectronicCheckingMerchantData.ProductId = txtSocketNum.Text
                MerP.MerchantData.ElectronicCheckingMerchantData.SiteId = txtStoreId.Text
            End If
            If _svas IsNot Nothing Then
                MerP.MerchantData.StoredValueMerchantData = New StoredValueMerchantData()
                MerP.MerchantData.StoredValueMerchantData.AgentChain = txtAgentChain.Text
                MerP.MerchantData.StoredValueMerchantData.ClientNumber = txtClientNum.Text
                MerP.MerchantData.StoredValueMerchantData.SIC = txtSIC.Text
                MerP.MerchantData.StoredValueMerchantData.StoreId = txtStoreId.Text
                MerP.MerchantData.StoredValueMerchantData.TerminalId = txtSocketNum.Text
                MerP.MerchantData.StoredValueMerchantData.IndustryType = _MerchantIndustryType

            End If

            'Add the profile to a list of profiles. This is necessary to save the profile
            MPList.Add(MerP)
            'From the calling form
            CType(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
            Dim _strServiceID As String = CType(Owner, SampleCode_DeskTop).Helper.ServiceID
            Dim _strSessionToken As String = CType(Owner, SampleCode_DeskTop).Helper.SessionToken

            CType(Owner, SampleCode_DeskTop).Helper.Cwssic.SaveMerchantProfiles(_strSessionToken, _strServiceID, TenderType.Credit, MPList)

            _Dirty = True 'When control is returned to calling form the form will re-generate service information.

            MessageBox.Show("Successfully Saved a Merchant Profile")

            'Reset the cboAvailableProfiles dropdown.
            cboAvailableProfiles.Items.Clear()
            cboAvailableProfiles.Text = ""
            'Now sync the new list
            CType(Owner, SampleCode_DeskTop).GetMerchantProfileIds()
            For Each Item In CType(Owner, SampleCode_DeskTop).cboAvailableProfiles.Items
                cboAvailableProfiles.Items.Add(Item)
            Next Item
        End Sub

        Private Sub DeleteMerchProfile()
            Dim Result As DialogResult
            Dim profileId As String = cboAvailableProfiles.Text
            If profileId.Trim() = "" Then
                profileId = "<default>"
            End If
            Result = MessageBox.Show("The action will attempt to delete the profile " & vbCrLf & vbCrLf & "     '" & profileId & "' " & vbCrLf & vbCrLf & "Do you want to continue?", "Overwrite", MessageBoxButtons.OKCancel)
            If Result = DialogResult.Cancel Then
                Return
            End If

            'From the calling form
            CType(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
            Dim _strServiceID As String = CType(Owner, SampleCode_DeskTop).Helper.ServiceID
            Dim _strSessionToken As String = CType(Owner, SampleCode_DeskTop).Helper.SessionToken

            CType(Owner, SampleCode_DeskTop).Helper.Cwssic.DeleteMerchantProfile(_strSessionToken, cboAvailableProfiles.Text, _strServiceID, TenderType.Credit)
            MessageBox.Show("Successfully deleted merchant ProfileId : " & cboAvailableProfiles.Text)

            _Dirty = True 'When control is returned to calling form the form will re-generate service information.

            'Reset the cboAvailableProfiles dropdown.
            cboAvailableProfiles.Items.Clear()
            cboAvailableProfiles.Text = ""
            'Now sync the new list
            CType(Owner, SampleCode_DeskTop).GetMerchantProfileIds()
            For Each Item In CType(Owner, SampleCode_DeskTop).cboAvailableProfiles.Items
                cboAvailableProfiles.Items.Add(Item)
            Next Item
        End Sub

        Private Sub IsMerchantProfileInitialized()
            If cboAvailableProfiles.Text.Length < 1 Then
                MessageBox.Show("Please select a merchant profileId")
                cboAvailableProfiles.Focus()
                Return
            End If
            'From the calling form
            CType(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
            Dim _strServiceID As String = CType(Owner, SampleCode_DeskTop).Helper.ServiceID
            Dim _strSessionToken As String = CType(Owner, SampleCode_DeskTop).Helper.SessionToken

            If CType(Owner, SampleCode_DeskTop).Helper.Cwssic.IsMerchantProfileInitialized(_strSessionToken, _strServiceID, cboAvailableProfiles.Text, TenderType.Credit) Then
                MessageBox.Show("Merchant profileId : " & cboAvailableProfiles.Text & " is initialized.")
            Else
                MessageBox.Show("Merchant profileId : " & cboAvailableProfiles.Text & " is NOT initialized.")
            End If

        End Sub

        Private Sub GetMerchantProfile()
            If cboAvailableProfiles.Text.Length < 1 Then
                MessageBox.Show("Please select a merchant profileId")
                cboAvailableProfiles.Focus()
                Return
            End If

            CType(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
            Dim _strServiceID As String = CType(Owner, SampleCode_DeskTop).Helper.ServiceID
            Dim _strSessionToken As String = CType(Owner, SampleCode_DeskTop).Helper.SessionToken


            Dim merchantProfile As MerchantProfile = CType(Owner, SampleCode_DeskTop).Helper.Cwssic.GetMerchantProfile(_strSessionToken, cboAvailableProfiles.Text, _strServiceID, TenderType.Credit)

            'Note : items commented out are not use so no need to wire up a text box as well as add to 'SaveMerchantInformation()'
            lblLastUpdated.Text = "Last Updated : " & merchantProfile.LastUpdated
            'MerchantData
            'MerchantData.Address
            txtCity.Text = merchantProfile.MerchantData.Address.City
            txtPostalCode.Text = merchantProfile.MerchantData.Address.PostalCode
            txtStateProvince.Text = merchantProfile.MerchantData.Address.StateProvince.ToString()
            txtStreetAddress1.Text = merchantProfile.MerchantData.Address.Street1
            txtStreetAddress2.Text = merchantProfile.MerchantData.Address.Street2

            txtCustomerServiceInternet.Text = merchantProfile.MerchantData.CustomerServiceInternet
            txtCustomerServicePhone.Text = merchantProfile.MerchantData.CustomerServicePhone
            txtMerchantId.Text = merchantProfile.MerchantData.MerchantId
            txtName.Text = merchantProfile.MerchantData.Name
            txtPhone.Text = merchantProfile.MerchantData.Phone
            txtTaxId.Text = merchantProfile.MerchantData.TaxId
            If _bcs IsNot Nothing Then
                'MerchantData.BankcardMerchantData
                txtABANumber.Text = merchantProfile.MerchantData.BankcardMerchantData.ABANumber
                txtAcquirerBIN.Text = merchantProfile.MerchantData.BankcardMerchantData.AcquirerBIN
                txtAgentBank.Text = merchantProfile.MerchantData.BankcardMerchantData.AgentBank
                txtAgentChain.Text = merchantProfile.MerchantData.BankcardMerchantData.AgentChain
                txtClientNum.Text = merchantProfile.MerchantData.BankcardMerchantData.ClientNumber
                txtLocation.Text = merchantProfile.MerchantData.BankcardMerchantData.Location
                'txtTBD.Text = _MerchantProfile.MerchantData.BankcardMerchantData.PrintCustomerServicePhone == "";
                txtSecondaryTerminalId.Text = merchantProfile.MerchantData.BankcardMerchantData.SecondaryTerminalId
                txtSettlementAgent.Text = merchantProfile.MerchantData.BankcardMerchantData.SettlementAgent
                txtSharingGroup.Text = merchantProfile.MerchantData.BankcardMerchantData.SharingGroup
                txtSIC.Text = merchantProfile.MerchantData.BankcardMerchantData.SIC
                txtStoreId.Text = merchantProfile.MerchantData.BankcardMerchantData.StoreId
                txtSocketNum.Text = merchantProfile.MerchantData.BankcardMerchantData.TerminalId
                txtTimeZoneDifferential.Text = merchantProfile.MerchantData.BankcardMerchantData.TimeZoneDifferential
                txtReimbursementAttribute.Text = merchantProfile.MerchantData.BankcardMerchantData.ReimbursementAttribute
            End If
            If _svas IsNot Nothing Then
                'MerchantData.StoredValueMerchantData
                txtAgentChain.Text = merchantProfile.MerchantData.StoredValueMerchantData.AgentChain
                txtClientNum.Text = merchantProfile.MerchantData.StoredValueMerchantData.ClientNumber
                txtSIC.Text = merchantProfile.MerchantData.StoredValueMerchantData.SIC
                txtStoreId.Text = merchantProfile.MerchantData.StoredValueMerchantData.StoreId
                txtSocketNum.Text = merchantProfile.MerchantData.StoredValueMerchantData.TerminalId
                _MerchantIndustryType = merchantProfile.MerchantData.StoredValueMerchantData.IndustryType
            End If
            If _ecks IsNot Nothing Then
                'MerchantData.ElectronicCheckingMerchantData
                txtMerchantId.Text = merchantProfile.MerchantData.ElectronicCheckingMerchantData.OrginatorId
                txtStoreId.Text = merchantProfile.MerchantData.ElectronicCheckingMerchantData.SiteId
                txtSocketNum.Text = merchantProfile.MerchantData.ElectronicCheckingMerchantData.ProductId
            End If

            'First Populate with the Enumeration
            cboCountryCode.DataSource = System.Enum.GetValues(GetType(TypeISOCountryCodeA3))
            'Now select the index that matches
            If merchantProfile.MerchantData.Address.CountryCode.ToString().Length > 0 Then
                cboCountryCode.SelectedItem = merchantProfile.MerchantData.Address.CountryCode
                _CountryCode = CType(cboCountryCode.SelectedItem, TypeISOCountryCodeA3)
            End If
            'First Populate with the Enumeration
            cboLanguage.DataSource = System.Enum.GetValues(GetType(TypeISOLanguageCodeA3))
            'Now select the index that matches
            If merchantProfile.MerchantData.Language.ToString().Length > 0 Then
                cboLanguage.SelectedItem = merchantProfile.MerchantData.Language
                _Language = CType(cboLanguage.SelectedItem, TypeISOLanguageCodeA3)
            End If
            'First Populate with the Enumeration
            cboCurrencyCode.DataSource = System.Enum.GetValues(GetType(TypeISOCurrencyCodeA3))
            'Now select the index that matches
            If merchantProfile.MerchantData.Language.ToString().Length > 0 Then
                cboCurrencyCode.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.CurrencyCode
                _CurrencyCode = CType(cboCurrencyCode.SelectedItem, TypeISOCurrencyCodeA3)
            End If

            'First Populate with the Enumeration
            cboCustomerPresent.DataSource = System.Enum.GetValues(GetType(CustomerPresent))
            'Now select the index that matches
            If merchantProfile.TransactionData.BankcardTransactionDataDefaults.CustomerPresent.ToString().Length > 0 Then
                cboCustomerPresent.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.CustomerPresent
                _CustomerPresent = CType(cboCustomerPresent.SelectedItem, CustomerPresent)
            End If

            'First Populate with the Enumeration
            cboRequestACI.DataSource = System.Enum.GetValues(GetType(RequestACI))
            'Now select the index that matches
            If merchantProfile.TransactionData.BankcardTransactionDataDefaults.RequestACI.ToString().Length > 0 Then
                cboRequestACI.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.RequestACI
                _RequestACI = CType(cboRequestACI.SelectedItem, RequestACI)
            End If

            'First Populate with the Enumeration
            cboMerchantIndustryType.DataSource = System.Enum.GetValues(GetType(IndustryType))
            If merchantProfile.MerchantData.BankcardMerchantData.IndustryType.ToString().Length > 0 Then
                cboMerchantIndustryType.SelectedItem = merchantProfile.MerchantData.BankcardMerchantData.IndustryType
                _MerchantIndustryType = CType(cboMerchantIndustryType.SelectedItem, IndustryType)
            End If

            'First Populate with the Enumeration
            cboEntryMode.DataSource = System.Enum.GetValues(GetType(EntryMode))
            If merchantProfile.TransactionData.BankcardTransactionDataDefaults.EntryMode.ToString().Length > 0 Then
                cboEntryMode.SelectedItem = merchantProfile.TransactionData.BankcardTransactionDataDefaults.EntryMode
                _EntryMode = CType(cboEntryMode.SelectedItem, EntryMode)
            End If
        End Sub

        Private Sub GetMerchantProfileIds()
            CType(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()
            Dim _strServiceID As String = CType(Owner, SampleCode_DeskTop).Helper.ServiceID
            Dim _strSessionToken As String = CType(Owner, SampleCode_DeskTop).Helper.SessionToken

            Dim merchantProfileIds As List(Of String) = CType(Owner, SampleCode_DeskTop).Helper.Cwssic.GetMerchantProfileIds(_strSessionToken, _strServiceID, TenderType.Credit)

            Dim msgbox As String = ""
            For Each merchantProfileId As String In merchantProfileIds
                msgbox &= merchantProfileId & vbCrLf
            Next merchantProfileId
            MessageBox.Show("The following is a list of saved merchant profileId(s)" & vbCrLf & vbCrLf & msgbox)
        End Sub

#End Region ' WebService Calls

#Region "Form Events"

        Private Sub CmdPerformWebRequest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdPerformWebRequest.Click
            Try
                Cursor = Cursors.WaitCursor

                CType(Owner, SampleCode_DeskTop).Helper.CheckTokenExpire()

                Dim item As Item = CType(cboMerchantDataAction.SelectedItem, Item)
                If item.Value1 = "0" Then
                    MessageBox.Show("Please select an action")
                    Cursor = Cursors.Default
                    Return
                End If
                If item.Value1 = "1" Then
                    IsMerchantProfileInitialized()
                    Cursor = Cursors.Default
                    Return
                End If
                If item.Value1 = "2" Then
                    GetMerchantProfile()
                    Cursor = Cursors.Default
                    Return
                End If
                If item.Value1 = "3" Then
                    GetMerchantProfileIds()
                    Cursor = Cursors.Default
                    Return
                End If
                If item.Value1 = "4" Then
                    MessageBox.Show("In general it's better to use the 'GetMerchantProfileIds' first and then to use 'GetMerchantProfile' to manage a merchant account.")
                    Cursor = Cursors.Default
                    Return
                End If
                If item.Value1 = "5" Then
                    MessageBox.Show("The GetMerchantProfilesByProfileId returns a list of profiles which this page cannot currently disply. Please use GetMerchantProfile instead.")
                    Cursor = Cursors.Default
                    Return
                End If
                If item.Value1 = "6" Then
                    SaveMerchantProfiles()
                    Cursor = Cursors.Default
                    Return
                End If
                If item.Value1 = "7" Then
                    DeleteMerchantProfile()
                    Cursor = Cursors.Default
                    Return
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Cursor = Cursors.Default
            End Try
        End Sub

        Private Sub cmdPopulateTestValues_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdPopulateTestValues.Click
            MessageBox.Show("Please note that the following values are generic. Depending on the scope of your integration the following values may change. Please contact your solution consultant with any questions.")

            Dim MP As MerchantProfile = _dg.CreateMerchantProfile()

            'The following are typical settings please ask your solution consultant if you have any questions
            txtStreetAddress1.Text = MP.MerchantData.Address.Street1
            txtStreetAddress2.Text = MP.MerchantData.Address.Street2
            txtCity.Text = MP.MerchantData.Address.City
            txtStateProvince.Text = MP.MerchantData.Address.StateProvince.ToString()
            txtPostalCode.Text = MP.MerchantData.Address.PostalCode
            txtCustomerServicePhone.Text = MP.MerchantData.CustomerServicePhone ' Must be of format "NNN NNNNNNN"
            txtMerchantId.Text = MP.MerchantData.MerchantId
            txtName.Text = MP.MerchantData.Name
            txtPhone.Text = MP.MerchantData.Phone ' Must be of format "NNN NNNNNNN"
            txtTaxId.Text = MP.MerchantData.TaxId
            txtCustomerServiceInternet.Text = MP.MerchantData.CustomerServiceInternet

            'BankCard
            txtClientNum.Text = MP.MerchantData.BankcardMerchantData.ClientNumber
            txtSIC.Text = MP.MerchantData.BankcardMerchantData.SIC
            txtStoreId.Text = MP.MerchantData.BankcardMerchantData.StoreId
            txtSocketNum.Text = MP.MerchantData.BankcardMerchantData.TerminalId

            'The following fields are used by Other Terminal Capture Providers and are part of the additional items
            If _strServiceID = "C82ED00001" OrElse _strServiceID = "71C8700001" OrElse _strServiceID = "88D9300001" OrElse _strServiceID = "B447F00001" OrElse _strServiceID = "D806000001" OrElse _strServiceID = "E88FD00001" Then
                txtABANumber.Text = MP.MerchantData.BankcardMerchantData.ABANumber
                txtAcquirerBIN.Text = MP.MerchantData.BankcardMerchantData.AcquirerBIN
                txtAgentBank.Text = MP.MerchantData.BankcardMerchantData.AgentBank
                txtAgentChain.Text = MP.MerchantData.BankcardMerchantData.AgentChain
                txtLocation.Text = MP.MerchantData.BankcardMerchantData.Location
                txtSecondaryTerminalId.Text = MP.MerchantData.BankcardMerchantData.SecondaryTerminalId
                txtSettlementAgent.Text = MP.MerchantData.BankcardMerchantData.SettlementAgent
                txtSharingGroup.Text = MP.MerchantData.BankcardMerchantData.SharingGroup
                txtTimeZoneDifferential.Text = MP.MerchantData.BankcardMerchantData.TimeZoneDifferential
                txtReimbursementAttribute.Text = MP.MerchantData.BankcardMerchantData.ReimbursementAttribute
                txtSocketNum.Text = MP.MerchantData.BankcardMerchantData.TerminalId
            End If

            Try
                Try
                    cboMerchantIndustryType.SelectedItem = MP.MerchantData.BankcardMerchantData.IndustryType
                Catch
                End Try
                cboLanguage.SelectedItem = MP.MerchantData.Language
                cboCountryCode.SelectedItem = MP.MerchantData.Address.CountryCode
                cboCurrencyCode.SelectedItem = MP.TransactionData.BankcardTransactionDataDefaults.CurrencyCode
                Try ' [Ecommerce : Ecommerce] [MOTO : MOTO] [Retail/Restaurant : Present]
                    cboCustomerPresent.SelectedItem = MP.TransactionData.BankcardTransactionDataDefaults.CustomerPresent
                Catch
                End Try
                Try 'In general default to "IsCPSMeritCapable"
                    cboRequestACI.SelectedItem = MP.TransactionData.BankcardTransactionDataDefaults.RequestACI
                Catch
                End Try
                Try '[Keyed : TrackDataFromMSR ]
                    cboEntryMode.SelectedItem = MP.TransactionData.BankcardTransactionDataDefaults.EntryMode
                Catch
                End Try
            Catch
            End Try
            If _bcs IsNot Nothing Then
                If _strServiceID = "C82ED00001" OrElse _strServiceID = "71C8700001" OrElse _strServiceID = "88D9300001" OrElse _strServiceID = "B447F00001" OrElse _strServiceID = "D806000001" OrElse _strServiceID = "E88FD00001" Then
                    showBCPExpandedFields()
                ElseIf _strServiceID = "168511300C" OrElse _strServiceID = "9999999999" Then
                    showBCPExpandedFields()
                Else
                    showBCPFields()
                End If
            End If

            If _ecks IsNot Nothing Then
                showECKFields()
            End If
            If _svas IsNot Nothing Then
                showSVAFields()
            End If
        End Sub

        Private Sub ChkEnableAllMerchantFields_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ChkEnableAllMerchantFields.Checked Then
                showAllFields()
            Else
                hideAllFields()
            End If
        End Sub

#Region "ComboBox Events"
        Private Sub cboCountryCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _CountryCode = CType(cboCountryCode.SelectedItem, TypeISOCountryCodeA3)
        End Sub

        Private Sub cboLanguage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _Language = CType(cboLanguage.SelectedItem, TypeISOLanguageCodeA3)
        End Sub

        Private Sub cboCurrencyCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _CurrencyCode = CType(cboCurrencyCode.SelectedItem, TypeISOCurrencyCodeA3)
        End Sub

        Private Sub cboCustomerPresent_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _CustomerPresent = CType(cboCustomerPresent.SelectedItem, CustomerPresent)
        End Sub

        Private Sub cboRequestACI_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _RequestACI = CType(cboRequestACI.SelectedItem, RequestACI)
        End Sub

        Private Sub cboMerchantIndustryType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _MerchantIndustryType = CType(cboMerchantIndustryType.SelectedItem, IndustryType)
        End Sub

        Private Sub cboEntryMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            _EntryMode = CType(cboEntryMode.SelectedItem, EntryMode)
        End Sub

        Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClose.Click
            Close()
        End Sub

#End Region ' END Form Events

        Private Sub lnkManageMerchantData_Click(ByVal sender As Object, ByVal e As EventArgs)
            System.Diagnostics.Process.Start("http://docs.evosnap.com/TransactionProcessing/CWS/Developer_Guide/2.0.18/Implementation/PreparingTheAppToTransact/ManagingMerchantProfiles/index.aspx")
        End Sub
#End Region ' ComboBox Events

    End Class
End Namespace

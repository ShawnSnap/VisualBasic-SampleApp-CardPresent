#Region "DISCLAIMER"
' Copyright (c) 2013 EVO Payments International - All Rights Reserved.
'
' This software and documentation is subject to and made
' available only pursuant to the terms of an executed license
' agreement, and may be used only in accordance with the terms
' of said agreement. This software may not, in whole or in part,
' be copied, photocopied, reproduced, translated, or reduced to
' any electronic medium or machine-readable form without
' prior consent, in writing, from EVO Payments International, INC.
'
' Use, duplication or disclosure by the U.S. Government is subject
' to restrictions set forth in an executed license agreement
' and in subparagraph (c)(1) of the Commercial Computer
' Software-Restricted Rights Clause at FAR 52.227-19; subparagraph
' (c)(1)(ii) of the Rights in Technical Data and Computer Software
' clause at DFARS 252.227-7013, subparagraph (d) of the Commercial
' Computer Software--Licensing clause at NASA FAR supplement
' 16-52.227-86; or their equivalent.
'
' Information in this software is subject to change without notice
' and does not represent a commitment on the part of EVO Payments International.
' 
' Sample Code is for reference Only and is intended to be used for educational purposes. It's the responsibility of 
' the software company to properly integrate into thier solution code that best meets thier production needs. 
'
#End Region ' DISCLAIMER

Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn
Imports EntryMode = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode

Namespace SampleCode
    'Please note that the DataGenerator class will not likely be used for a software company's solution. Instead the information below would come from a database
    Public Class DataGenerator

#Region "Variable Declarations"

        Public _ITV As IndustryTypeValues
        'Message regarding processing. Likely instead of this your software would write the results directly to your database or a log file. 
        Public IntService As Boolean
        Public _message As String

#End Region

#Region "Class Properties"

        Public _amount As String = "10.00"
        Public _tip As String = "0.00"
        Public _keySerialNumber As String = "1234567890123456"
        Public _encryptedPIN As String = "1234567890"
        Public _cashBack As String = "0.00"
        Public _processAs As ProcessAs
        Public _allowPartialApprovals As Boolean
        Public _cardType As TypeCardType
        Public _expirationDate As String = "1215"
        Public _pan As String = "4111111111111111"
        Public _tokenizedTransaction As TokenizedTransaction
        Public _trackDataFromMSRVal As String = "%B4111111111111111^EVOSNAP/TESTCARD^15121010454500415000010?;4111111111111111=15121010454541500010?"
        Public Shared _helper As HelperMethods
        Public _encryptedIdentityToken As Boolean
        Public _step2 As Boolean
        Public _persistedAndCached As String = ""
        Public Shared _si As ServiceInformation
        Public Shared _merchantProfileIds As List(Of String)

        Public Property Amount() As String
            Get
                Return _amount
            End Get
            Set(ByVal value As String)
                _amount = value
            End Set
        End Property
        Public Property Tip() As String
            Get
                Return _tip
            End Get
            Set(ByVal value As String)
                _tip = value
            End Set
        End Property
        Public Property KeySerialNumber() As String
            Get
                Return _keySerialNumber
            End Get
            Set(ByVal value As String)
                _keySerialNumber = value
            End Set
        End Property
        Public Property EncryptedPIN() As String
            Get
                Return _encryptedPIN
            End Get
            Set(ByVal value As String)
                _encryptedPIN = value
            End Set
        End Property
        Public Property CashBack() As String
            Get
                Return _cashBack
            End Get
            Set(ByVal value As String)
                _cashBack = value
            End Set
        End Property
        Public Property ProcessAs() As ProcessAs
            Get
                Return _processAs
            End Get
            Set(ByVal value As ProcessAs)
                _processAs = value
            End Set
        End Property
        Public Property AllowPartialApprovals() As Boolean
            Get
                Return _allowPartialApprovals
            End Get
            Set(ByVal value As Boolean)
                _allowPartialApprovals = value
            End Set
        End Property
        Public Property CardType() As TypeCardType
            Get
                Return _cardType
            End Get
            Set(ByVal value As TypeCardType)
                _cardType = value
            End Set
        End Property
        Public Property ExpirationDate() As String
            Get
                Return _expirationDate
            End Get
            Set(ByVal value As String)
                _expirationDate = value
            End Set
        End Property
        Public Property PAN() As String
            Get
                Return _pan
            End Get
            Set(ByVal value As String)
                _pan = value
            End Set
        End Property
        Public Property TokenizedTransaction() As TokenizedTransaction
            Get
                Return _tokenizedTransaction
            End Get
            Set(ByVal value As TokenizedTransaction)
                _tokenizedTransaction = value
            End Set
        End Property
        Public Property TrackDataFromMSRVal() As String
            Get
                Return _trackDataFromMSRVal
            End Get
            Set(ByVal value As String)
                _trackDataFromMSRVal = value
            End Set
        End Property
        Public Shared Property Helper() As HelperMethods
            Get
                Return _helper
            End Get
            Set(ByVal value As HelperMethods)
                _helper = value
            End Set
        End Property
        Public Property EncryptedIdentityToken() As Boolean
            Get
                Return _encryptedIdentityToken
            End Get
            Set(ByVal value As Boolean)
                _encryptedIdentityToken = value
            End Set
        End Property
        Public Property Step2() As Boolean
            Get
                Return _step2
            End Get
            Set(ByVal value As Boolean)
                _step2 = value
            End Set
        End Property
        Public Property PersistedAndCached() As String
            Get
                Return _persistedAndCached
            End Get
            Set(ByVal value As String)
                _persistedAndCached = value
            End Set
        End Property
        Public Shared Property SI() As ServiceInformation
            Get
                Return _si
            End Get
            Set(ByVal value As ServiceInformation)
                _si = value
            End Set
        End Property
        Public Shared Property MerchantProfileIds() As List(Of String)
            Get
                Return _merchantProfileIds
            End Get
            Set(ByVal value As List(Of String))
                _merchantProfileIds = value
            End Set
        End Property

#End Region

        Public Sub New()
            _ITV = getIndustryType(ConfigurationSettings.AppSettings("IndustryType"))
        End Sub

#Region "Service Information"

        Public Function CreateApplicationData() As ApplicationData
            Dim appData As New ApplicationData()
            appData.ApplicationAttended = _ITV._ApplicationAttended
            appData.ApplicationLocation = _ITV._ApplicationLocation
            appData.ApplicationName = "MyTestApp" 'Should be the software company's application name
            appData.DeveloperId = "" 'Only used int he case of a TPPId
            appData.DeviceSerialNumber = ""
            appData.EncryptionType = _ITV._EncryptionType
            appData.HardwareType = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.HardwareType.PC
            appData.PINCapability = _ITV._PINCapability
            appData.PTLSSocketId = ""
            appData.ReadCapability = _ITV._ReadCapability
            appData.SerialNumber = "208093707" 'This default values should always be used.
            appData.SoftwareVersion = "1.0"
            appData.SoftwareVersionDate = New Date(2012, 10, 27)
            appData.VendorId = ""

            Return appData
        End Function

        Public Function CreateMerchantProfile() As MerchantProfile
            Dim merchData As New MerchantProfile()

            merchData.LastUpdated = Date.UtcNow
            'MerchantData : http://www.evosnap.com/support/knowledgebase/service-information-data-elements/#merchantprofilemerchantdata
            merchData.MerchantData = New MerchantProfileMerchantData()
            'Address
            merchData.MerchantData.Address = New schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.AddressInfo()
            merchData.MerchantData.Address.City = "Denver"
            merchData.MerchantData.Address.CountryCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.TypeISOCountryCodeA3.USA
            merchData.MerchantData.Address.PostalCode = "80202"
            merchData.MerchantData.Address.StateProvince = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.TypeStateProvince.CA
            merchData.MerchantData.Address.Street1 = "1553 Platte Street"
            merchData.MerchantData.Address.Street2 = "Suite #310"
            merchData.MerchantData.CustomerServiceInternet = "test@test.com"
            merchData.MerchantData.CustomerServicePhone = "303 5553232"
            merchData.MerchantData.Language = TypeISOLanguageCodeA3.ENG
            merchData.MerchantData.MerchantId = "123456789012"
            merchData.MerchantData.Name = "Acme Widgets"
            merchData.MerchantData.Phone = "720 8881212"
            merchData.MerchantData.TaxId = ""

            'BankcardMerchantData : http://www.evosnap.com/support/knowledgebase/service-information-data-elements/#bankcardmerchantdata
            merchData.MerchantData.BankcardMerchantData = New BankcardMerchantData()
            merchData.MerchantData.BankcardMerchantData.ABANumber = "987654321"
            merchData.MerchantData.BankcardMerchantData.AcquirerBIN = "654321"
            merchData.MerchantData.BankcardMerchantData.AgentBank = "123456"
            merchData.MerchantData.BankcardMerchantData.AgentChain = "645231"
            merchData.MerchantData.BankcardMerchantData.Aggregator = False
            merchData.MerchantData.BankcardMerchantData.ClientNumber = "1234"
            merchData.MerchantData.BankcardMerchantData.IndustryType = _ITV._IndustryType
            merchData.MerchantData.BankcardMerchantData.Location = "12345"
            merchData.MerchantData.BankcardMerchantData.MerchantType = ""
            merchData.MerchantData.BankcardMerchantData.PrintCustomerServicePhone = False
            merchData.MerchantData.BankcardMerchantData.QualificationCodes = ""
            merchData.MerchantData.BankcardMerchantData.ReimbursementAttribute = "A"
            merchData.MerchantData.BankcardMerchantData.SIC = "5999"
            merchData.MerchantData.BankcardMerchantData.SecondaryTerminalId = "12345678"
            merchData.MerchantData.BankcardMerchantData.SettlementAgent = "12AB"
            merchData.MerchantData.BankcardMerchantData.SharingGroup = "123ABC"
            merchData.MerchantData.BankcardMerchantData.StoreId = "1234"
            merchData.MerchantData.BankcardMerchantData.TerminalId = "98765432160550"
            merchData.MerchantData.BankcardMerchantData.TimeZoneDifferential = "005"
            'ElectronicCheckingMerchantData : http://www.evosnap.com/support/knowledgebase/service-information-data-elements/#electroniccheckingmerchantdata
            merchData.MerchantData.ElectronicCheckingMerchantData = New ElectronicCheckingMerchantData()
            merchData.MerchantData.ElectronicCheckingMerchantData.OrginatorId = ""
            merchData.MerchantData.ElectronicCheckingMerchantData.ProductId = ""
            merchData.MerchantData.ElectronicCheckingMerchantData.SiteId = ""
            'StoredValueMerchantData : http://www.evosnap.com/support/knowledgebase/service-information-data-elements/#storedvaluemerchantdata
            merchData.MerchantData.StoredValueMerchantData = New StoredValueMerchantData()
            merchData.MerchantData.StoredValueMerchantData.AgentChain = ""
            merchData.MerchantData.StoredValueMerchantData.ClientNumber = ""
            merchData.MerchantData.StoredValueMerchantData.IndustryType = _ITV._IndustryType
            merchData.MerchantData.StoredValueMerchantData.SIC = ""
            merchData.MerchantData.StoredValueMerchantData.StoreId = ""
            merchData.MerchantData.StoredValueMerchantData.TerminalId = ""

            'TransactionData
            merchData.TransactionData = New MerchantProfileTransactionData()
            merchData.TransactionData.BankcardTransactionDataDefaults = New BankcardTransactionDataDefaults()
            merchData.TransactionData.BankcardTransactionDataDefaults.CurrencyCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.TypeISOCurrencyCodeA3.USD
            merchData.TransactionData.BankcardTransactionDataDefaults.CustomerPresent = _ITV._CustomerPresent
            merchData.TransactionData.BankcardTransactionDataDefaults.EntryMode = _ITV._EntryMode
            merchData.TransactionData.BankcardTransactionDataDefaults.RequestACI = _ITV._RequestACI
            merchData.TransactionData.BankcardTransactionDataDefaults.RequestAdvice = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestAdvice.Capable

            Return merchData
        End Function
#End Region

#Region "Transaction Processing"
#Region "Bankcard Processing"

        Public Function SetBankCardTxnData() As BankcardTransaction
            'Contains information about the Bankcard transaction (Credit and PIN Debit). 
            Return SetBankCardTxnData(Nothing)
        End Function

        Public Function SetBankCardTxnData(ByVal _BCPPO As BankCardProProcessingOptions) As Global.SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.BankcardTransactionPro
            'Note : the following values aplly to the BankcardTransaction
            Dim BCtransaction As New BankcardTransactionPro()
            Dim TxnData As New BankcardTransactionDataPro() 'The following is necessary due to inheritance

            'The following are typical settings please ask your solution consultant if you have any questions
            TxnData.Amount = Convert.ToDecimal((Amount))
            '			#Region "Ways to Convert to a decimal with two decimals"
            'Note : Decimal Example please remember that the amount must always be two decimals "0.00"
            'decimal dAmount = 10;
            'TxnData.Amount = Convert.ToDecimal(dAmount);
            'TxnData.Amount = Decimal.Parse(TxnData.Amount.ToString("0.00"));
            'Or Simply
            'TxnData.Amount = Decimal.Parse(TxnData.Amount.ToString("0.00"));

            'Note : String Example please remember that the amount must always be two decimals "0.00"
            'string strAmount = "10";
            'TxnData.Amount = Convert.ToDecimal(strAmount);
            'TxnData.Amount = Decimal.Parse(TxnData.Amount.ToString("0.00"));

            'Note : Int Example please remember that the amount must always be two decimals "0.00"
            'int intAmount = 10;
            'TxnData.Amount = Convert.ToDecimal(intAmount);
            'TxnData.Amount = Decimal.Parse(TxnData.Amount.ToString("0.00"));
            'Or
            '((int)(100 * amount)) * 0.01m;

            '			#End Region ' Ways to Convert to a decimal with two decimals

            If Tip.ToString().Length > 0 Then
                If Convert.ToDecimal(Tip) > 0 Then
                    TxnData.TipAmount = Convert.ToDecimal(Tip)
                End If
            End If

            If ProcessAs = ProcessAs.PINDebit Then 'Cashback for PINDebit only
                If CashBack.ToString().Length > 0 Then
                    If Convert.ToDecimal(CashBack) > 0 Then
                        TxnData.CashBackAmount = Convert.ToDecimal(CashBack)
                    End If
                End If
            End If

            TxnData.CurrencyCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCurrencyCodeA3.USD
            'Set below 
            'try { TxnData.EntryMode = (schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode)_ITV._EntryMode; }
            'catch { }
            Try
                TxnData.CustomerPresent = CType(_ITV._CustomerPresent, schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.CustomerPresent)
            Catch
            End Try
            Try
                TxnData.SignatureCaptured = _ITV._SignatureCaptured
            Catch
            End Try


            TxnData.TransactionDateTime = Date.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz")

            ' Used for QuasiCash transactions
            TxnData.IsQuasiCash = False

            TxnData.LaneId = "1" 'Used for MasterCard

            TxnData.TransactionCode = TransactionCode.Override

            'Used for Retail/Restaurant/MOTO
            TxnData.EmployeeId = "1234"

            'Used for Ecommerce/MOTO
            TxnData.OrderNumber = "123543" 'This values must be unique for each transaction. OrderNum should never be zero
            'TxnData.GoodsType = GoodsType.PhysicalGoods;

            'Check to see if partial approval should be allowed. To test a value of *.59 can be used
            If AllowPartialApprovals Then
                TxnData.PartialApprovalCapable = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.PartialApprovalSupportType.Capable
            End If

            ' The below value is to support partial authorizations as mandated by Visa and Mastercard
            ' First check to see if the service supports partial approvals, if it does then set the flag
            ' that this transaction will support that partial approval.  Remember to parse your Response.Amount to verify 
            ' the amount that was approved.  Card Not Present applications do not need to abide by the partial approval mandate
            If AllowPartialApprovals Then
                TxnData.PartialApprovalCapable = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.PartialApprovalSupportType.Capable
            End If

            BCtransaction.CustomerData = New TransactionCustomerData()
            BCtransaction.CustomerData.CustomerId = TxnData.OrderNumber

            BCtransaction.TenderData = New BankcardTenderData()
            BCtransaction.TenderData.CardData = New CardData1()

            'Process as a Swipe or as a Keyed Transaction
            If ProcessAs = ProcessAs.Keyed Then
                TxnData.EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode.Keyed
                BCtransaction.TenderData.CardData.CardType = CardType
                BCtransaction.TenderData.CardData.Expire = ExpirationDate ' Note : that in a swipe track data the format is "YYMM" however here it's "MMYY"
                BCtransaction.TenderData.CardData.PAN = PAN
                BCtransaction.TenderData.CardData.CardholderName = "Dirk Pit"
            ElseIf ProcessAs = ProcessAs.PaymentAccountDataToken Then
                Try
                    TxnData.EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode.Keyed
                    Dim T As TokenizedTransaction = TokenizedTransaction
                    BCtransaction.TenderData.CardData = New CardData1()
                    BCtransaction.TenderData.PaymentAccountDataToken = T.PaymentAccountDataToken
                    BCtransaction.TenderData.CardData.CardType = T.CardType
                    BCtransaction.TenderData.CardData.Expire = T.ExpireationDate ' Note : that in a swipe track data the format is "YYMM" however here it's "MMYY"
                    BCtransaction.TenderData.CardData.PAN = T.MaskedPAN 'It's recommended to set the masked PAN that was returned with the original token
                Catch
                End Try
            ElseIf ProcessAs = ProcessAs.TrackDataFromMSR Or ProcessAs = ProcessAs.PINDebit Then
                '#Region "Card Validation Samples (Optional however good reference for sending valid card swipes)"
                'NOTE Example : In the case of processing a card swipe string use the following.
                'NOTE Example : The following will remove starting and ending sentenals
                BCtransaction.TenderData.CardData.CardType = CardType
                Dim SwipeToSeperateTracks As String = TrackDataFromMSRVal
                Dim TFMSRS As TrackFromMSRSwipe = Helper.seperateTrackData(SwipeToSeperateTracks)

                Dim TrackProcessingOrder() As String = ConfigurationSettings.AppSettings("TxnData_OrderOfProcessingTracks").Split("|"c)
                For Each track As String In TrackProcessingOrder
                    If track = "Track1" Then
                        If Helper.validateTrackData(BCtransaction, TFMSRS.Track1Data) Then
                            TxnData.EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode.TrackDataFromMSR
                            Exit For
                        End If
                    End If
                    If track = "Track2" Then
                        If Helper.validateTrackData(BCtransaction, TFMSRS.Track2Data) Then
                            TxnData.EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode.Track2DataFromMSR
                            Exit For
                        End If
                    End If
                    If track = "Keyed" Then
                        _message &= "Neither Track 1 nor Track 2 match. Processing as keyed"
                        TxnData.EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode.Keyed
                        BCtransaction.TenderData.CardData.CardType = CardType
                        BCtransaction.TenderData.CardData.Expire = ExpirationDate ' Note : that in a swipe track data the format is "YYMM" however here it's "MMYY"
                        BCtransaction.TenderData.CardData.PAN = PAN
                        Exit For
                    End If
                Next track

                'Note : Other Track Examples (includes track 1 track 2 and an example of track 3)
                'MasterCard : %B5454545454545454^IPCOMMERCE/TESTCARD^1312101013490000000001000880000?;5454545454545454=13121010134988000010?
                'MasterCardPurchase : %B5480020605154711^IPCOMMERCE/TESTCARD^1312101100000001000000218000000?;5480020605154711=13121011000017026218?
                'MasterCardSigDebit : %B9999989900007723^IPCOMMERCE/TESTCARD^13121015432112345678?;9999989900007723=13121015432112345678?
                'Visa : %B4111111111111111^IPCOMMERCE/TESTCARD^13121010454500415000010?;4111111111111111=13121010454541500010?
                'Visa Purchasecard : %B4005765777003^IPCOMMERCE/TESTCARD^13121015432112345678?;4005765777003=13121015432112345678?
                'AmericanExpress : %B371449635398456^IPCOMMERCE/TESTCARD^1312060523319?;371449635398456=1312060523319?
                'Discover : %B6011000995504101^IPCOMMERCE/TESTCARD^13121011000627210201?;6011000995504101=13121011000627210201?
                'The following track includes a track 3 which is possible in Costco American Express cards %B371449635398456^IPCOMMERCE/TESTCARD^1312060523319?;371449635398456=1312060523319?+823156444000?

                '				#End Region ' Card Validation Samples (Optional however good reference for sending valid card swipes)

                'Check to see if the transaction is a PINDebit Transaction
                If ProcessAs = ProcessAs.PINDebit Then
                    If BCtransaction.TenderData.CardSecurityData Is Nothing Then
                        BCtransaction.TenderData.CardSecurityData = New CardSecurityData1()
                    End If
                    BCtransaction.TenderData.CardSecurityData.KeySerialNumber = KeySerialNumber
                    BCtransaction.TenderData.CardSecurityData.PIN = EncryptedPIN
                    TxnData.AccountType = AccountType.CheckingAccount
                End If
            End If
            '#Region "Simulating a flag used to set either AVS CV or PINDebit data"
            'Simulating a flag used to set either AVS, CV data or PINDebit
            Dim blnAVS As Boolean = _ITV._IncludeAVS
            Dim blnIntService = IntService
            Dim blnIntAVSOverride = _ITV._IntAVSOverride
            Dim blnCVV As Boolean = _ITV._IncludeCV

            If blnAVS Or blnCVV Then
                If BCtransaction.TenderData.CardSecurityData Is Nothing Then
                    BCtransaction.TenderData.CardSecurityData = New CardSecurityData1() 'Required if AVS or CV is used
                End If
                If blnAVS Then
                    If (Not blnIntService) Then
                        'AVSData
                        BCtransaction.TenderData.CardSecurityData.AVSData = New AVSData()
                        'Required AVS Elements
                        BCtransaction.TenderData.CardSecurityData.AVSData.PostalCode = "10101"
                        'Optional AVS Elements
                        BCtransaction.TenderData.CardSecurityData.AVSData.CardholderName = "John Smith"
                        BCtransaction.TenderData.CardSecurityData.AVSData.City = "Denver"
                        BCtransaction.TenderData.CardSecurityData.AVSData.Country = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCountryCodeA3.USA
                        BCtransaction.TenderData.CardSecurityData.AVSData.Phone = "303 5456699" 'Must be of format "NNN NNNNNNN"
                        BCtransaction.TenderData.CardSecurityData.AVSData.StateProvince = "CO"
                        BCtransaction.TenderData.CardSecurityData.AVSData.Street = "1000 1st Av"
                    Else
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData = New InternationalAVSData()
                        'Required International AVS Elements
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData.HouseNumber = "5"
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData.Street = "Schulstrasse"
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData.City = "Bad Oyenhausen"
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData.PostalCode = "32547"
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData.Country = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCountryCodeA3.DEU
                        'Optional Internation AVS Elements
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData.POBoxNumber = ""
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSData.StateProvince = "RW"
                    End If
                    If (blnIntAVSOverride And CardType <> TypeCardType.Maestro) Then
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSOverride = New InternationalAVSOverride()
                        BCtransaction.TenderData.CardSecurityData.InternationalAVSOverride.IgnoreAVS = True 'This will keep the system from declining transactions on 'No Match' AVS
                        'BCtransaction.TenderData.CardSecurityData.InternationalAVSOverride.AVSRejectCodes = "NI"; 'EVO payments and merchant will agree on what is populated here
                        'BCtransaction.TenderData.CardSecurityData.InternationalAVSOverride.SkipAVS = true; 'This will skip AVS processing
                    End If
                End If

                If blnCVV Then
                    'CVData
                    Dim strCVData As String = "111" 'Please note that this would typically be an input field in the application.
                    If CardType = TypeCardType.AmericanExpress Then
                        strCVData = "1111" 'AVS has 4 numeric
                    End If
                    If strCVData.Length > 0 Then
                        BCtransaction.TenderData.CardSecurityData.CVDataProvided = CVDataProvided.Provided
                        BCtransaction.TenderData.CardSecurityData.CVData = strCVData
                    Else
                        'In this case the card was present (Retail or Restaurant) however the CV code was not readable or available
                        BCtransaction.TenderData.CardSecurityData.CVDataProvided = CVDataProvided.DeliberatelyBypass
                    End If
                End If
            End If
            '#End Region  END Simulating a flag used to set either AVS CV or PINDebit data

            Dim blnIntBilling As Boolean = _ITV._IncludeBilling
            If (blnIntService And blnIntBilling) Then
                BCtransaction.CustomerData.BillingData = New CustomerInfo()
                BCtransaction.CustomerData.BillingData.Name = New NameInfo()
                BCtransaction.CustomerData.BillingData.InternationalAddress = New InternationalAddressInfo()
                BCtransaction.CustomerData.BillingData.Name.First = "Mark"
                BCtransaction.CustomerData.BillingData.Name.Last = "Malinowski"
                BCtransaction.CustomerData.BillingData.InternationalAddress.Street1 = "Platte St"
                BCtransaction.CustomerData.BillingData.InternationalAddress.HouseNumber = "1553"
                BCtransaction.CustomerData.BillingData.InternationalAddress.City = "Denver"
                BCtransaction.CustomerData.BillingData.InternationalAddress.CountryCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCountryCodeA3.USA
                BCtransaction.CustomerData.BillingData.InternationalAddress.PostalCode = "80228"
                BCtransaction.CustomerData.BillingData.InternationalAddress.StateProvince = "CO"
                BCtransaction.CustomerData.BillingData.InternationalAddress.Street2 = "Unit 310"
                'Shipping Data
                BCtransaction.CustomerData.ShippingData = New CustomerInfo()
                BCtransaction.CustomerData.ShippingData.Name = New NameInfo()
                BCtransaction.CustomerData.ShippingData.InternationalAddress = New InternationalAddressInfo()
                BCtransaction.CustomerData.ShippingData.Name.First = "Dustin"
                BCtransaction.CustomerData.ShippingData.Name.Last = "Dowell"
                BCtransaction.CustomerData.ShippingData.InternationalAddress.Street1 = "Larimer St"
                BCtransaction.CustomerData.ShippingData.InternationalAddress.City = "Lakewood"
                BCtransaction.CustomerData.ShippingData.InternationalAddress.CountryCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCountryCodeA3.USA
                BCtransaction.CustomerData.ShippingData.InternationalAddress.HouseNumber = "1625"
                BCtransaction.CustomerData.ShippingData.InternationalAddress.PostalCode = "80228"
                BCtransaction.CustomerData.ShippingData.InternationalAddress.StateProvince = "CO"
                BCtransaction.CustomerData.ShippingData.InternationalAddress.Street2 = "2601"
            End If


            '#Region "Check to see if PINLessDebit selected"

            If ProcessAs = ProcessAs.PINLessDebit Then
                TxnData.PINlessDebitData = New PINlessDebitData()
                TxnData.PINlessDebitData.PayeeData = New PayeeData()
                TxnData.PINlessDebitData.PayeeData.AccountNumber = "000056"
                TxnData.PINlessDebitData.PayeeData.CompanyName = "ABC Company"
                TxnData.PINlessDebitData.PayeeData.Phone = "555 1238888"
            End If

            '			#End Region ' END Check to see if PINLessDebit selected

            '#region Simulating a flag used to set Magensa data
            '//Simulating a flag used to set either AVS, CV data or PINDebit
            'bool blnMagensa = false;

            'try { blnMagensa = Convert.ToBoolean(ConfigurationSettings.AppSettings["TxnData_ProcessMagensaTxn"]); }
            'catch { };

            'if (blnMagensa)
            '{ //*** ToDo : the following are generic values which will only work against Sandbox.***
            '    //First set the CardData to null
            '    BCtransaction.TenderData.CardData = null;

            '    if (BCtransaction.TenderData.CardSecurityData == null) { BCtransaction.TenderData.CardSecurityData = new CardSecurityData(); }
            '    BCtransaction.TenderData.CardSecurityData.CVData = null;
            '    BCtransaction.TenderData.CardSecurityData.CVDataProvided = CVDataProvided.NotSet;
            '    BCtransaction.TenderData.CardSecurityData.IdentificationInformation = "A52AFB9FB5B283A6C8C38377A6CB1D2C63CC59D3B0B29D2A0DF1C9A54F123D37536756C77B4A9B75E51BF028B51971E81C8B221533A3AFF4";

            '    BCtransaction.TenderData.SecurePaymentAccountData = "13A7783BD91D0A05712606644778CF8F34397EAC2AB26676A52A380350CAA07E";

            '    BCtransaction.TenderData.EncryptionKeyId = "9011400B042692000398";
            '    BCtransaction.TenderData.SwipeStatus = "1065057";

            '    TxnData.ScoreThreshold = ".5";
            '    TxnData.EntryMode = EntryMode.Track2DataFromMSR;
            '    TxnData.Reference = "11";

            '}
            '#endregion Simulating a flag used to set Magensa data


            'Note : BankcardTransactionPro
            'The following sections are specific to the Pro object
            'Applications that will support Level 2, Level 3, and Managed Billing (recurring/installment payments) data may be
            'required to provide the following data elements in addition to the Base Transaction and Bankcard
            'Transaction data elements described above.
            If Convert.ToBoolean(ConfigurationSettings.AppSettings("ProcessAsBankcardTransaction_Pro")) Or _BCPPO IsNot Nothing Then 'Determines if additional Pro objects should be used.
                Dim PCL As PurchaseCardLevel
                Dim InterchangeData As Boolean
                Dim L2L3 As Boolean
                If _BCPPO IsNot Nothing Then
                    PCL = _BCPPO.PurchaseCardLevel
                    InterchangeData = _BCPPO.InterchangeData
                    L2L3 = _BCPPO.IncludeLevel2OrLevel3Data
                Else
                    PCL = DirectCast(System.Enum.Parse(GetType(PurchaseCardLevel), ConfigurationSettings.AppSettings("Pro_PurchaseCardLevel")), PurchaseCardLevel)
                    InterchangeData = Convert.ToBoolean(ConfigurationSettings.AppSettings("Pro_InterchangeData"))
                    L2L3 = Convert.ToBoolean(ConfigurationSettings.AppSettings("Pro_IncludeLevel2OrLevel3Data"))
                End If

                If PCL = PurchaseCardLevel.Level2 Or PCL = PurchaseCardLevel.Level3 Then
                    '                    
                    '                        For AuthorizeAndCapture the level2/3 goes in immediately as there is no follow up transaction.
                    '                        For Authorize followed by Capture the level 2/3 goes in the Capture, never in the Authorize.  
                    '                        The schema requires BaseAmt and OrderNum for level 2.  Amt, Quantity, SeqNum, TaxIncludedInd, and UnitPrice are all required for level 3.
                    '                        • Of course you must have level 2 in order to have level 3.
                    '                        Set TxnData.CmrclCardReq to "Enable" since some providers get that value and will return the card type in the response in CmrclCardResp.  Not all providers do this but they should always set it.  
                    '                        The value is returned in the response and can be used to determine whether or not to submit level 2.
                    '
                    '                        Level 2 requirements for Ecomm/Moto:
                    '                        • TaxExempt
                    '                        • DestinationPostal
                    '                        • ShipFromPostalCode
                    '                        Level 2 requirements for Retail:
                    '                        • DestinationPostal
                    '                        • TaxExempt                   
                    '                        Level 3 requirements for Ecomm/Moto:
                    '                        • Desc
                    '                        • ProductCode
                    '                        • UnitOfMeasure
                    '                        • only 98 items allowed
                    '                    

                    'Send with the original Authorize with the "RequestCommerciaCard" flag set. In the response you will reference
                    '"CommercialCardResponse" as the indicator that the card is a valid Level 2 or Level 3 card.
                    BCtransaction.InterchangeData = New BankcardInterchangeData()
                    BCtransaction.InterchangeData.RequestCommercialCard = RequestCommercialCard.Enable

                    If L2L3 And PCL = PurchaseCardLevel.Level2 Then
                        TxnData.Level2Data = SetLevel2Data()

                        If BCtransaction.TenderData.CardData.CardType = TypeCardType.AmericanExpress Then
                            BCtransaction.CustomerData = New TransactionCustomerData()
                            BCtransaction.CustomerData.ShippingData = New CustomerInfo()
                            BCtransaction.CustomerData.ShippingData.Name = New NameInfo()
                            BCtransaction.CustomerData.ShippingData.Address = New schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.AddressInfo()

                            'For Amex only cards. Amex only supports Purchase Card Level 2
                            BCtransaction.CustomerData.ShippingData.Name.First = "Dan" 'Full name or parameterized name.
                            BCtransaction.CustomerData.ShippingData.Name.Middle = "Joe"
                            BCtransaction.CustomerData.ShippingData.Name.Last = "Billings"

                            BCtransaction.CustomerData.ShippingData.Address.Street1 = "123 HappyWay"
                            'BCtransaction.CustomerData.ShippingData.Address.Street2 = "";
                            BCtransaction.CustomerData.ShippingData.Address.City = "Mason"
                            BCtransaction.CustomerData.ShippingData.Address.StateProvince = "OH"
                            BCtransaction.CustomerData.ShippingData.Address.PostalCode = "45040"
                            BCtransaction.CustomerData.ShippingData.Address.CountryCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCountryCodeA3.USA
                        End If
                    End If
                    If L2L3 And PCL = PurchaseCardLevel.Level3 Then
                        TxnData.Level2Data = SetLevel2Data()

                        'Level 3 data includes Level 2 data plus line items details. in this case your application should handle calling the following
                        ' for each line item
                        Dim LIDs As New List(Of LineItemDetail)()
                        Dim LID As New LineItemDetail()
                        LID = SetLevel3Data()
                        LIDs.Add(LID)
                        TxnData.LineItemDetails = LIDs
                    End If
                End If

                If InterchangeData Then
                    BCtransaction.InterchangeData = New BankcardInterchangeData()

                    'Single Payment
                    BCtransaction.InterchangeData.BillPayment = BillPayment.SinglePayment
                    BCtransaction.InterchangeData.ExistingDebt = ExistingDebt.IsExistingDebt

                    '                    
                    '                    //Deferred Billing
                    '                    BCtransaction.InterchangeData.BillPayment = BillPayment.DeferredBilling;
                    '                    BCtransaction.InterchangeData.ExistingDebt = ExistingDebt.IsExistingDebt;
                    '        
                    '                    //Installment
                    '                    BCtransaction.InterchangeData.BillPayment = BillPayment.Installment;
                    '                    BCtransaction.InterchangeData.ExistingDebt = ExistingDebt.IsExistingDebt;
                    '                    BCtransaction.InterchangeData.CurrentInstallmentNumber = 1;
                    '                    BCtransaction.InterchangeData.TotalNumberOfInstallments = 3;
                    '                    
                    'Recurring
                    'Note: Any time recurring payments are used for any BCP service MultiClearSeqNum should be 1 for the first payment and any number 
                    'greater than 1 for the additional recurring payments.  The software company doesn’t have to count payments.  
                    'They can always send 2 for the additional transactions if they want. Sending the 1 sends a code to the service provider that this 
                    'is the first payment and CVData and AVSData are expected.  Sending greater than 1 means that the lack of CVData and AVSData is OK 
                    'since they don’t have to store or submit that data with the additional payments.
                    BCtransaction.InterchangeData.BillPayment = BillPayment.Recurring
                    BCtransaction.InterchangeData.ExistingDebt = ExistingDebt.IsExistingDebt
                    BCtransaction.InterchangeData.CurrentInstallmentNumber = 1 'If this is a follow-up recuring payment the value needs to be greater than 1.

                    'Any time BillPayInd is set to either "Deferred_Billing", "Installment" or "Recurring", CustPresentFlag should be set to "Bill_Payment"
                    If BCtransaction.InterchangeData.BillPayment = BillPayment.DeferredBilling Or BCtransaction.InterchangeData.BillPayment = BillPayment.Installment Or BCtransaction.InterchangeData.BillPayment = BillPayment.Recurring Then
                        TxnData.CustomerPresent = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.CustomerPresent.BillPayment
                    End If
                End If
            End If

            Dim blnVPAS As Boolean = False
            Try
                blnVPAS = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeVPAS"))
            Catch
            End Try
            '             IF supported
            '                If a token is obtained:
            '                    TenderData/EcommerceSecurityData/TokenData is required and contains the token provided by the service.
            '                    TenderData/EcommerceSecurityData/TokenInd is required and must be set to VPAS_3D_Secure_V100 or VPAS_3D_Secure_V102.  Even if the merchant has a newer version, either setting will work for any version.
            '                    TxnData/EcommerceData/PayTypeInd is required and must be set to Secure_Ecom.
            '                    TenderData/EcommerceSecurityData/XID is optional and may contain the Visa XID value.
            '                If VbV is supported but the token could not be obtained:
            '                    TenderData/EcommerceSecurityData/TokenData will not be populated.
            '                    TenderData/EcommerceSecurityData/TokenInd is required and must be set to Attempted_Card_Unsupported or Attempted_Service_Unavailable.
            '                    TxnData/EcommerceData/PayTypeInd is required and must be set to Non_authenticated_Security_Without_SSL or Non_authenticated_Security_With_SSL.
            '             
            If blnVPAS AndAlso BCtransaction.TenderData.CardData.CardType = TypeCardType.Visa Then
                'Token Obtained
                BCtransaction.TenderData.EcommerceSecurityData.TokenData = ""
                BCtransaction.TenderData.EcommerceSecurityData.TokenIndicator = TokenIndicator.VPAS
                'TODO :TxnData.
                BCtransaction.TenderData.EcommerceSecurityData.XID = ""

                'No Token Obtained
                BCtransaction.TenderData.EcommerceSecurityData.TokenIndicator = TokenIndicator.AttemptedCardUnsupported
                'TODO :TxnData.
            End If
            '			#End Region ' Verified By Visa (VbV/VPAS)

            '			#Region "MasterCard Secure Code (MCSC/UCAF)"
            Dim blnUCAF As Boolean = False
            Try
                blnUCAF = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeUCAF"))
            Catch
            End Try
            '            
            '             * If a token is obtained:
            '                    TenderData/EcommerceSecurityData/TokenData is required and contains the token provided by the service.
            '                    TenderData/EcommerceSecurityData/TokenInd is required and must be set to UCAF or UCAF_With_Data.
            '                    TxnData/EcommerceData/PayTypeInd is required and must be set to Secure_Ecom.
            '               If MCSC is supported but the token could not be obtained or will not be sent with the transaction:
            '                    TenderData/EcommerceSecurityData/TokenData will not be populated.
            '                    TenderData/EcommerceSecurityData/TokenInd is required and must be set to Attempted_Card_Unsupported, Attempted_Service_Unavailable, or UCAF_Without_Data.
            '                    TxnData/EcommerceData/PayTypeInd is required and must be set to either Non_authenticated_Security_Without_SSL or Non_authenticated_Security_With_SSL.
            '             
            If blnUCAF AndAlso BCtransaction.TenderData.CardData.CardType = TypeCardType.MasterCard Then
                'Token Obtained
                BCtransaction.TenderData.EcommerceSecurityData.TokenData = ""
                BCtransaction.TenderData.EcommerceSecurityData.TokenIndicator = TokenIndicator.UCAFWithData
                'TODO :TxnData.
                BCtransaction.TenderData.EcommerceSecurityData.XID = ""

                'No Token Obtained
                BCtransaction.TenderData.EcommerceSecurityData.TokenIndicator = TokenIndicator.AttemptedCardUnsupported
                'TODO :TxnData.
            End If
            '			#End Region ' MasterCard Secure Code (MCSC/UCAF)

            '			#Region "Convenience Fees"

            'Simulating a flag used to include Convenience Fees
            Dim cFees As Boolean = False

            Try
                cFees = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeCFees"))
            Catch
            End Try

            If cFees Then
                'TxnData.FeeAmount = 5.00M;
            End If

            '			#End Region ' Convenience Fees

            '			#Region "Soft Descriptors"

            'Simulating setting soft descriptors
            Try
                If Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_SoftDescriptors")) Then
                    TxnData.AlternativeMerchantData = Helper.SetSoftDescriptors()
                End If
            Catch
            End Try

            '			#End Region ' Soft Descriptors

            BCtransaction.TransactionData = TxnData
            Return BCtransaction
        End Function

        Public Function SetLevel2Data() As Level2Data
            Dim L2 As New Level2Data()
            L2.BaseAmount = 10D 'Required : Base amount of the transaction, not including freight, handling, and tax amounts.
            'L2.CommodityCode = ""; //Optional : Commodity code for the entire purchase.
            'L2.CompanyName = ""; //Optional : Name of company making purchase. 
            'L2.CustomerCode = ""; //Optional : Provided by cardholder to appear on invoice. 
            'L2.Description = ""; //Optional : Description of the purchase. 
            'L2.DestinationCountryCode = TypeISOCountryCodeA3.USA; //Optional : Specifies the destination country code of the goods being shipped. 
            L2.DestinationPostal = "80040" '(Required) Specifies the destination postal code.
            'L2.DiscountAmount = 1.00M;
            'L2.DutyAmount = 2.00M; //Optional : Specifies duty amount. 
            'L2.FreightAmount = 3.00M; //Optional : Specifies freight amount. 
            'L2.MiscHandlingAmount = 4.00M; //Optional : Miscellaneous handling charges. 
            'L2.OrderDate = DateTime.utcNow(); //Optional : Date the order was placed. 
            L2.OrderNumber = "1235" 'Required : Indicates the Order Number.
            'L2.RequesterName = "Don"; //Optional : Name of the person making the request. 
            L2.ShipFromPostalCode = "94566" '(Required) The zip/postal code of the location from which the goods are shipped.
            L2.ShipmentId = "12DDER" 'Optional : Number of the shipment.

            L2.TaxExempt = New TaxExempt() 'Optional : Tax exemption indicator and number.
            L2.TaxExempt.IsTaxExempt = IsTaxExempt.NotExemptTaxInfoProvided 'Required : Indicates tax exempt status for the transaction.
            If L2.TaxExempt.IsTaxExempt = IsTaxExempt.Exempt Then
                L2.TaxExempt.TaxExemptNumber = "123jsd" 'Conditional : Indicates tax exempt number for the transaction. Conditional, required if TaxExemptInd = 'Exempt' or 'Not_Exempt_Tax_Info_Provided'.
            End If

            If L2.TaxExempt.IsTaxExempt = IsTaxExempt.NotExemptTaxInfoProvided Then
                'The following is used if the "IsTaxExempt" is not "Exempt"
                L2.Tax = New Tax() 'Optional : Aggregate of tax information.
                L2.Tax.Amount = 1D 'Required : Total amount of tax applied.
                L2.Tax.Rate = 0.06D 'Optional : Total tax rate.
                L2.Tax.InvoiceNumber = "" 'Optional : Tax invoice number.

                'The software can do itemized taxes with Level 2, but is optional. This would be needed for Canadian taxes if you want to have separate totals for the various taxes.
                'List<ItemizedTax> ITxs = new List<ItemizedTax>(); //Optional : Collection of itemized tax information. 
                'ItemizedTax ITX = new ItemizedTax();
                'ITX.Amount = 0.05M; //Required : Amount of specified tax applied.
                'ITX.Rate = 0.02M; //Optional : Rate for tax specified. 
                'ITX.Type = TypeTaxType.StateSalesTax; //Required : Type of tax specified. 
                'ITxs.Add(ITX);
                'L2.Tax.ItemizedTaxes = ITxs;
            End If

            Return L2
        End Function

        Public Function SetLevel3Data() As LineItemDetail
            Dim LID As New LineItemDetail()
            LID.Amount = 2D 'Required : Line item total cost. See DiscountInd and TaxInd to determine whether this amount is inclusive of DiscountAmt and Tax.
            LID.CommodityCode = "123456789012" 'Optional : Line item commodity code.
            LID.Description = "PartXYZ" 'Optional : Line item description.
            LID.DiscountAmount = 1D 'Optional : Discount amount for this line item.
            LID.DiscountIncluded = True 'Conditional : Indicates whether Amt is inclusive of discount. Conditional, required if DiscountAmt is specified.
            LID.ProductCode = "xyz123" 'Optional : Line item product code.
            LID.Quantity = 1D 'Required : Quantity of item.
            Dim tx As Tax = New Tax()
            tx.Amount = 0.15D 'Required : Total amount of tax applied.
            tx.InvoiceNumber = "IONum" 'Optional : Tax invoice number.
            'List<ItemizedTax> ITxs = new List<ItemizedTax>(); //Optional : Collection of itemized tax information. 
            'ItemizedTax ITX = new ItemizedTax();
            'ITX.Amount = 0.05M; //Required : Amount of specified tax applied.
            'ITX.Rate = 0.02M; //Optional : Rate for tax specified. 
            'ITX.Type = TypeTaxType.StateSalesTax; //Required : Type of tax specified. 
            'ITxs.Add(ITX);
            LID.Tax = tx
            LID.TaxIncluded = True 'Required: Specifies whether Amt is inclusive of tax.
            LID.UnitOfMeasure = TypeUnitOfMeasure.Ounce 'Optional : Units used to measure quantity.
            LID.UnitPrice = 0.8D 'Required : Price per unit of line item.
            LID.UPC = "UPC123" 'Optional : Line item UPC code.

            Return LID
        End Function
#End Region 'Bankcard Processing

#Region "Electronic Checking"

        Public Function SetElectronicCheckTxnData() As ElectronicCheckingTransaction
            Dim ECKTransaction As New ElectronicCheckingTransaction()
            ECKTransaction.TransactionData = New ElectronicCheckingTransactionData()

            'Consumer Data
            'NOTE : Need one or the other
            ECKTransaction.CustomerData = New TransactionCustomerData()
            ECKTransaction.CustomerData.BillingData = New CustomerInfo()
            ECKTransaction.CustomerData.BillingData.BusinessName = "ACME Supplies"
            'OR
            ECKTransaction.CustomerData.BillingData.Name = New NameInfo()
            ECKTransaction.CustomerData.BillingData.Name.First = "Joe"
            ECKTransaction.CustomerData.BillingData.Name.Middle = "Johnson"
            ECKTransaction.CustomerData.BillingData.Name.Last = "Smith"

            'Transaction Data
            ECKTransaction.TransactionData.Amount = Convert.ToDecimal(Amount)
            'ECKTransaction.TransactionData.CurrencyCode = SampleCode.CwsTransactionProcessing.TypeISOCurrencyCodeA3.USD;
            ECKTransaction.TransactionData.EffectiveDate = Date.UtcNow 'Specifies the effective date of the transaction. Required.
            ECKTransaction.TransactionData.IsRecurring = False 'Indicates whether the transaction is recurring. Conditional, required if SECCode = 'WEB'.
            'Supported SEC Codes are PPD, CCD, TEL, WEB and BOC.  CCD and PPD transactions can be either credit or debit.  TEL, WEB and BOC are debit transactions only.
            ECKTransaction.TransactionData.SECCode = SECCode.WEB 'The three letter code that indicates what NACHA regulations the transaction must adhere to. Required.
            ECKTransaction.TransactionData.ServiceType = ServiceType.ACH 'Indicates the Electronic Checking service type: ACH, RDC or ECK. Required.
            'ECKTransaction.TransactionData.TransactionDateTime = DateTime.UtcNow;
            ECKTransaction.TransactionData.TransactionType = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TransactionType.Debit 'Indicates the transaction type. Required.

            'Tender Data
            ECKTransaction.TenderData = New ElectronicCheckingTenderData()
            ECKTransaction.TenderData.CheckData = New CheckData()
            ECKTransaction.TenderData.CheckData.AccountNumber = "1234567890" 'Account number on the check. Required.
            ECKTransaction.TenderData.CheckData.CheckCountryCode = CheckCountryCode.US 'Bank account country of origin for receiver deposit.
            ECKTransaction.TenderData.CheckData.CheckNumber = "191" 'The check number as printed on the check. Optional.
            ECKTransaction.TenderData.CheckData.OwnerType = OwnerType.Personal 'Indicates the type of entity which owns the account.
            ECKTransaction.TenderData.CheckData.RoutingNumber = "987654321" '9-digit bank routing number of the receiver deposit account. Required.
            ECKTransaction.TenderData.CheckData.UseType = UseType.Checking 'Indicates the type of account.

            Return ECKTransaction
        End Function

#End Region ' electronic checking

#Region "Stored Value"

        Public Function SetStoredValueTxnData() As StoredValueTransaction
            Dim SVATransaction As New StoredValueTransaction()
            SVATransaction.TransactionData = New StoredValueTransactionData()

            'Transaction Data
            SVATransaction.TransactionData.Amount = Convert.ToDecimal(Amount)
            SVATransaction.TransactionData.CurrencyCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCurrencyCodeA3.USD
            SVATransaction.TransactionData.EmployeeId = "122"

            SVATransaction.TransactionData.IndustryType = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.IndustryType.Retail

            SVATransaction.TransactionData.TenderCurrencyCode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCurrencyCodeA3.USD
            SVATransaction.TransactionData.TransactionDateTime = Date.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz")

            'Tender Data
            SVATransaction.TenderData = New StoredValueTenderData()
            SVATransaction.TenderData.CardData = New CardData()
            SVATransaction.TenderData.CardSecurityData = New CardSecurityData()
            SVATransaction.TenderData.CardSecurityData.CVDataProvided = CVDataProvided.Provided
            SVATransaction.TenderData.CardSecurityData.CVData = "1111"

            If Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_ProcessAsKeyed")) Then
                SVATransaction.TenderData.CardData.AccountNumber = "5858836401000004"
                SVATransaction.TenderData.CardData.Expire = "1012"
                SVATransaction.TransactionData.EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode.Keyed
            Else
                SVATransaction.TenderData.CardData.Track2Data = "5858836401000004^ / ^4912101000005320000000532000000"
                SVATransaction.TenderData.CardData.AccountNumber = "5858836401000004"
                SVATransaction.TransactionData.EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.EntryMode.TrackDataFromMSR
            End If

            Return SVATransaction
        End Function

#End Region ' Stored Value

#End Region ' Transaction Processing

        Public Function getIndustryType(ByVal _industryType As String) As IndustryTypeValues
            Dim i As New IndustryTypeValues()
            If _industryType = "" Then
                'ApplicationData schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.
                i._ApplicationAttended = Convert.ToBoolean(ConfigurationSettings.AppSettings("ApplicationAttended"))
                i._ApplicationLocation = DirectCast(System.Enum.Parse(GetType(schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ApplicationLocation), ConfigurationSettings.AppSettings("ApplicationLocation")), schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ApplicationLocation)
                i._PINCapability = DirectCast(System.Enum.Parse(GetType(schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.PINCapability), ConfigurationSettings.AppSettings("PINCapability")), schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.PINCapability)
                i._ReadCapability = DirectCast(System.Enum.Parse(GetType(schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ReadCapability), ConfigurationSettings.AppSettings("ReadCapability")), schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ReadCapability)
                i._EncryptionType = DirectCast(System.Enum.Parse(GetType(EncryptionType), ConfigurationSettings.AppSettings("EncryptionType")), EncryptionType)

                'MerchantData
                i._IndustryType = DirectCast(System.Enum.Parse(GetType(schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.IndustryType), ConfigurationSettings.AppSettings("IndustryType")), schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.IndustryType)
                i._CustomerPresent = DirectCast(System.Enum.Parse(GetType(schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.CustomerPresent), ConfigurationSettings.AppSettings("CustomerPresent")), schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.CustomerPresent)
                i._RequestACI = DirectCast(System.Enum.Parse(GetType(schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestACI), ConfigurationSettings.AppSettings("RequestACI")), schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestACI)
                i._EntryMode = DirectCast(System.Enum.Parse(GetType(schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode), ConfigurationSettings.AppSettings("EntryMode")), schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode)

                'TransactionData
                i._ProcessAsKeyed = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_ProcessAsKeyed"))
                i._SignatureCaptured = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_SignatureCaptured"))
                i._IncludeAVS = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeAVS"))
                i._IntAVSOverride = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IntAVSOverride"))
                i._IncludeCV = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeCV"))
                i._IncludeBilling = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeBilling"))
            End If
            If _industryType = "Ecommerce" Then
                'ApplicationData
                i._ApplicationAttended = False
                i._ApplicationLocation = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ApplicationLocation.OffPremises
                i._PINCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.PINCapability.PINNotSupported
                i._ReadCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ReadCapability.KeyOnly
                i._EncryptionType = EncryptionType.NotSet

                'MerchantData
                i._IndustryType = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.IndustryType.Ecommerce
                i._CustomerPresent = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.CustomerPresent.Ecommerce
                i._RequestACI = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestACI.IsCPSMeritCapable
                i._EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode.Keyed

                'TransactionData
                i._ProcessAsKeyed = True
                i._SignatureCaptured = False
                i._IncludeAVS = True
                i._IntAVSOverride = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IntAVSOverride"))
                i._IncludeCV = True
                i._IncludeBilling = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeBilling"))
            End If
            If _industryType = "MOTO" Then
                'ApplicationData
                i._ApplicationAttended = False
                i._ApplicationLocation = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ApplicationLocation.OffPremises
                i._PINCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.PINCapability.PINNotSupported
                i._ReadCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ReadCapability.KeyOnly
                i._EncryptionType = EncryptionType.NotSet

                'MerchantData
                i._IndustryType = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.IndustryType.MOTO
                i._CustomerPresent = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.CustomerPresent.MOTO
                i._RequestACI = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestACI.IsCPSMeritCapable
                i._EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode.Keyed

                'TransactionData
                i._ProcessAsKeyed = True
                i._SignatureCaptured = False
                i._IncludeAVS = True
                i._IntAVSOverride = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IntAVSOverride"))
                i._IncludeCV = True
                i._IncludeBilling = Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_IncludeBilling"))
            End If
            If _industryType = "Retail" Then
                'ApplicationData
                i._ApplicationAttended = True
                i._ApplicationLocation = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ApplicationLocation.OnPremises
                i._PINCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.PINCapability.PINNotSupported
                i._ReadCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ReadCapability.HasMSR
                If Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_ProcessMagensaTxn")) Then
                    i._EncryptionType = EncryptionType.MagneSafeV4V5Compatible
                Else
                    i._EncryptionType = EncryptionType.NotSet
                End If
                'MerchantData
                i._IndustryType = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.IndustryType.Retail
                i._CustomerPresent = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.CustomerPresent.Present
                i._RequestACI = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestACI.IsCPSMeritCapable
                i._EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode.TrackDataFromMSR

                'TransactionData
                i._ProcessAsKeyed = False
                i._SignatureCaptured = True
                i._IncludeAVS = False
                i._IncludeCV = True
            End If
            If _industryType = "Restaurant" Then
                'ApplicationData
                i._ApplicationAttended = True
                i._ApplicationLocation = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ApplicationLocation.OnPremises
                i._PINCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.PINCapability.PINNotSupported
                i._ReadCapability = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ReadCapability.HasMSR
                If Convert.ToBoolean(ConfigurationSettings.AppSettings("TxnData_ProcessMagensaTxn")) Then
                    i._EncryptionType = EncryptionType.MagneSafeV4V5Compatible
                Else
                    i._EncryptionType = EncryptionType.NotSet
                End If
                'MerchantData
                i._IndustryType = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.IndustryType.Restaurant
                i._CustomerPresent = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.CustomerPresent.Present
                i._RequestACI = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestACI.IsCPSMeritCapable
                i._EntryMode = schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode.TrackDataFromMSR

                'TransactionData
                i._ProcessAsKeyed = False
                i._SignatureCaptured = True
                i._IncludeAVS = False
                i._IncludeCV = False
            End If
            _ITV = i
            Return i
        End Function

        Public Function LoadPersistedConfig() As Boolean
            'Check to see if previous settings exists. 
            '            NOTE
            '              * SECURITY CONSIDERATIONS
            '              * Stored on file system with read/write permission for only the application/service and IT Administration
            '              * Stored in DB with read/write permission for only the application/service and IT Administration
            '            
            Try
                'Get Settings
                EncryptedIdentityToken = False

                Try
                    If File.Exists(Helper.ServiceKey & "_TransactionProcessing.config") Then
                        Dim xtr As New XmlTextReader(Helper.ServiceKey & "_TransactionProcessing.config")
                        Dim doc As New XmlDocument()
                        doc.Load(xtr)
                        xtr.Close()

                        Dim xnav As XPathNavigator = doc.CreateNavigator()
                        Dim node As XPathNavigator = xnav.SelectSingleNode("//TransactionProcessing/Configuration/ApplicationProfielId")
                        If node IsNot Nothing AndAlso node.Value IsNot Nothing Then
                            Helper.ApplicationProfileId = node.Value
                        End If

                        node = xnav.SelectSingleNode("//TransactionProcessing/Configuration/ServiceId")
                        If node IsNot Nothing AndAlso node.Value IsNot Nothing Then
                            Helper.ServiceID = node.Value
                        End If

                        node = xnav.SelectSingleNode("//TransactionProcessing/Configuration/WorkflowId")
                        If node IsNot Nothing AndAlso node.Value IsNot Nothing Then
                            Helper.WorkflowID = node.Value
                        End If

                        node = xnav.SelectSingleNode("//TransactionProcessing/Configuration/MerchantProfielId")
                        If node IsNot Nothing AndAlso node.Value IsNot Nothing Then
                            Helper.MerchantProfileId = node.Value
                        End If

                        node = xnav.SelectSingleNode("//TransactionProcessing/Configuration/IdentityToken")
                        If node IsNot Nothing AndAlso node.Value IsNot Nothing Then
                            Helper.IdentityToken = node.Value
                        End If
                        EncryptedIdentityToken = Convert.ToBoolean(node.GetAttribute("Encrypted", ""))

                        Dim strEncryptedIdentityToken As String = vbCrLf & "Identity Token [NOT ENCRYPTED]"

                        If EncryptedIdentityToken Then
                            strEncryptedIdentityToken = vbCrLf & "Identity Token [ENCRYPTED]"
                            Helper.IdentityToken = Helper.Decrypt(Helper.IdentityToken)
                        End If

                        If Helper.ApplicationProfileId.Length > 0 Then
                            Step2 = True
                        End If
                        PersistedAndCached = "ApplicationProfileId : " & Helper.ApplicationProfileId & vbCrLf & "ServiceId : " & Helper.ServiceID & vbCrLf & "WorkflowId : " & Helper.WorkflowID & vbCrLf & "MerchantProfileId : " & Helper.MerchantProfileId & strEncryptedIdentityToken
                    End If
                    Return True
                Catch Ex As Exception
                    '_message += Ex.Message;
                    PersistedAndCached = "ApplicationProfileId : " & Helper.ApplicationProfileId & vbCrLf & "ServiceId : " & Helper.ServiceID & vbCrLf & "WorkflowId : " & Helper.WorkflowID & vbCrLf & "MerchantProfileId : " & Helper.MerchantProfileId
                    Return False
                End Try
            Catch Ex As Exception
                '_message += "No persisted values found in '[SK]_TransactionProcessing.config'. Initializing application for the first time";
                PersistedAndCached = "ApplicationProfileId : " & Helper.ApplicationProfileId & vbCrLf & "ServiceId : " & Helper.ServiceID & vbCrLf & "WorkflowId : " & Helper.WorkflowID & vbCrLf & "MerchantProfileId : " & Helper.MerchantProfileId
                Return False
            End Try
        End Function

        Public Function SavePersistedConfig(ByVal pacs As PersistAndCacheSettings) As Boolean
            'Save to file
            '            NOTE
            '              * SECURITY CONSIDERATIONS
            '              * Stored on file system with read/write permission for only the application/service and IT Administration
            '              * Stored in DB with read/write permission for only the application/service and IT Administration
            '            

            'Save Settings
            Dim doc As New XmlDocument()
            Dim docNode As XmlNode = doc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            doc.AppendChild(docNode)
            Dim transactionProcessingValues As XmlNode = doc.CreateElement("TransactionProcessing")
            doc.AppendChild(transactionProcessingValues)
            Dim configuration As XmlNode = doc.CreateElement("Configuration")
            transactionProcessingValues.AppendChild(configuration)

            si = helper.ServiceInformation
            Dim applicationProfielId As XmlNode = doc.CreateElement("ApplicationProfielId")
            applicationProfielId.InnerText = pacs.ApplicationProfileId
            configuration.AppendChild(applicationProfielId)

            Dim serviceId As XmlNode = doc.CreateElement("ServiceId")
            serviceId.InnerText = pacs.ServiceId
            Dim multipleServiceId As XmlAttribute = doc.CreateAttribute("MultipleServiceId")
            multipleServiceId.Value = (If(si.BankcardServices.Count > 1, "True", "False"))
            serviceId.Attributes.Append(multipleServiceId)
            configuration.AppendChild(serviceId)

            Dim workflowId As XmlNode = doc.CreateElement("WorkflowId")
            workflowId.InnerText = pacs.WorkflowId
            Dim multipleWorkflowId As XmlAttribute = doc.CreateAttribute("MultipleWorkflowId")
            multipleWorkflowId.Value = (If(si.BankcardServices.Count > 1, "True", "False"))
            workflowId.Attributes.Append(multipleWorkflowId)
            configuration.AppendChild(workflowId)

            Dim merchantProfielId As XmlNode = doc.CreateElement("MerchantProfielId")
            merchantProfielId.InnerText = pacs.MerchantProfileId
            Dim multipleMerchants As XmlAttribute = doc.CreateAttribute("MultipleMerchants")
            multipleMerchants.Value = (If(merchantProfileIds.Count > 2, "True", "False")) 'Since by default empty comes back we need to validate at 2 and not 1
            merchantProfielId.Attributes.Append(multipleMerchants)
            configuration.AppendChild(merchantProfielId)

            Dim identityToken As XmlNode = doc.CreateElement("IdentityToken")
            identityToken.InnerText = pacs.IdentityToken
            Dim encrypted As XmlAttribute = doc.CreateAttribute("Encrypted")
            encrypted.Value = pacs.EncryptedIdentityToken.ToString() 'The following is dependant on the software company integration needs.
            identityToken.Attributes.Append(encrypted)
            configuration.AppendChild(identityToken)

            doc.Save(helper.ServiceKey & "_TransactionProcessing.config")

            Return True
        End Function

        Public Sub SandboxTestCardData()
            If CardType = TypeCardType.Visa Then
                PAN = "4111111111111111"
                TrackDataFromMSRVal = "%B4111111111111111^EVOSNAP/TESTCARD^15121010454500415000010?;4111111111111111=15121010454541500010?"
            ElseIf CardType = TypeCardType.MasterCard Then
                PAN = "5454545454545454"
                TrackDataFromMSRVal = "%B5454545454545454^EVOSNAP/TESTCARD^1512101013490000000001000880000?;5454545454545454=15121010134988000010?"
            ElseIf CardType = TypeCardType.AmericanExpress Then
                PAN = "371449635398456"
                TrackDataFromMSRVal = "%B371449635398456^EVOSNAP/TESTCARD^1512060523319?;371449635398456=1512060523319?"
            ElseIf CardType = TypeCardType.Discover Then
                PAN = "6011000995504100"
                TrackDataFromMSRVal = "%B6011000995504101^EVOSNAP/TESTCARD^15121011000627210201?;6011000995504101=15121011000627210201?"
            ElseIf CardType = TypeCardType.PrivateLabel Then
                PAN = "8818889876543211"
                TrackDataFromMSRVal = ";8818889876543211=15121014764094900001?"
            Else
                PAN = ""
                TrackDataFromMSRVal = ""
            End If
        End Sub
    End Class

    Public Class Item
        Public Name As String
        Public Value1 As String
        Public Value2 As String
        Public Sub New(ByVal name As String, ByVal value1 As String, ByVal value2 As String)
            Me.Name = name
            Me.Value1 = value1
            Me.Value2 = value2
        End Sub
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public Class BankCardProProcessingOptions
        Public PurchaseCardLevel As PurchaseCardLevel
        Public InterchangeData As Boolean
        Public IncludeLevel2OrLevel3Data As Boolean
        Public Sub New(ByVal purchaseCardLevel As PurchaseCardLevel, ByVal interchangeData As Boolean, ByVal includeLevel2OrLevel3Data As Boolean)
            Me.PurchaseCardLevel = purchaseCardLevel
            Me.InterchangeData = interchangeData
            Me.IncludeLevel2OrLevel3Data = includeLevel2OrLevel3Data
        End Sub
    End Class

    Public Class TokenizedTransaction
        Public PaymentAccountDataToken As String
        Public ExpireationDate As String
        Public MaskedPAN As String
        Public CardType As TypeCardType
        Public Sub New(ByVal paymentAccountDataToken As String, ByVal expireationDate As String, ByVal maskedPAN As String, ByVal cardType As TypeCardType)
            Me.PaymentAccountDataToken = paymentAccountDataToken
            Me.ExpireationDate = expireationDate
            Me.MaskedPAN = maskedPAN
            Me.CardType = cardType
        End Sub
        Public Overrides Function ToString() As String
            Return CardType & " - [Exp:" & ExpireationDate & "] " & MaskedPAN
        End Function
    End Class

    Public Class IndustryTypeValues
        'ApplicationData
        Public _ApplicationAttended As Boolean
        Public _ApplicationLocation As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ApplicationLocation
        Public _PINCapability As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.PINCapability
        Public _ReadCapability As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.ReadCapability
        Public _EncryptionType As EncryptionType

        'MerchantData
        Public _IndustryType As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.IndustryType
        Public _CustomerPresent As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.CustomerPresent
        Public _RequestACI As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.RequestACI
        Public _EntryMode As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo.EntryMode

        'TransactionData
        Public _ProcessAsKeyed As Boolean
        Public _SignatureCaptured As Boolean
        Public _IncludeAVS As Boolean
        Public _IntAVSOverride As Boolean
        Public _IncludeCV As Boolean
        Public _IncludeBilling As Boolean

    End Class

    Public Enum ProcessAs As Integer
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        Keyed = 0
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        TrackDataFromMSR = 1
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        PINDebit = 2
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        PINLessDebit = 3
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        PaymentAccountDataToken = 4
    End Enum
End Namespace
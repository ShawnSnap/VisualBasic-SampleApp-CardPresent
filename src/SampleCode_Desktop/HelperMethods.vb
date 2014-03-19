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

#Region "Import Statements"
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Security.Cryptography
Imports System.ServiceModel
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Xml.XPath
Imports System.Configuration
Imports Microsoft.VisualBasic
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.TMS
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo

Imports Response = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.Response
Imports BankcardTransactionResponse = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.BankcardTransactionResponse
Imports BankcardCaptureResponse = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.BankcardCaptureResponse
Imports Capture = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.Capture
Imports BankcardTransactionPro = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.BankcardTransactionPro
Imports BankcardTransactionResponsePro = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.BankcardTransactionResponsePro
Imports Addendum = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.Addendum
Imports BankcardTransaction = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.BankcardTransaction
Imports ElectronicCheckingCaptureResponse = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.ElectronicCheckingCaptureResponse
Imports ElectronicCheckingTransaction = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.ElectronicCheckingTransaction
Imports ElectronicCheckingTransactionResponse = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.ElectronicCheckingTransactionResponse
Imports TypeCardType = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeCardType
Imports Unmanaged = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.Unmanaged
Imports Status = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.Status
Imports StoredValueTransaction = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.StoredValueTransaction
Imports StoredValueTransactionResponse = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.StoredValueTransactionResponse
Imports AlternativeMerchantData = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.AlternativeMerchantData
Imports AddressInfo = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.AddressInfo
Imports PrepaidCard = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.PrepaidCard
Imports TypeISOCountryCodeA3 = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TypeISOCountryCodeA3
#End Region

Namespace SampleCode
    Public Class HelperMethods
#Region "Variable Declarations"
        'Primary webservice objects
        Private _cwssic As New CWSServiceInformationClient()
        Private _cwsbc As New CwsTransactionProcessingClient()
        Private _tmsoc As New TMSOperationsClient()

        Private _applicationProfileId As String = ""
        'Obtained after saving application data
        Private _serviceId As String = ""
        'Unique to each service
        Private _workflowId As String = ""
        'Unique to each bundle of module and service 
        Private _merchantProfileId As String = ""
        'Your application will have one to many merchantProfileId's depending on how many merchant accounts you have.
        Private _sessionToken As String = ""
        'The sessionToken lives for only 30 minutes. The CheckTokenExpire() method below rotates this value after 25 minutes as elapsed. 
        Private _delegatedSessionToken As String = ""
        'The sessionToken lives for only 30 minutes. The CheckTokenExpire() method below rotates this value after 25 minutes as elapsed.
        Private _identityToken As String = ""
        'The identity token is the primary token used to gain access to CWS. This value expires every 3 year or if a security breach is detected. You application need to have a way to update this value at any time. 
        Private _serviceKey As String = ""
        'One identity token can have one to many serviceKey. ServiceKey's are tied to service available.
        Private _delegatedServiceKey As String = ""
        ' ServiceKey that has been delegated to the Initiator IdentityToken.
        Private _serviceInformation As New ServiceInformation()
        Private _forceClose As Boolean
        Private _FaultHandler As New FaultHandler.FaultHandler()
        Public DtSessionToken As DateTime 'Used by CheckTokenExpire() to determine when the session token needs to be updated

        'The following would likely come from a config value or database
        Public BaseSvcEndpointPrimary As String = ConfigurationSettings.AppSettings("BaseSvcEndpointPrimary")
        Public BaseSvcEndpointSecondary As String = ConfigurationSettings.AppSettings("BaseSvcEndpointSecondary")
        Public BaseTxnEndpointPrimary As String = ConfigurationSettings.AppSettings("BaseTxnEndpointPrimary")
        Public BaseTxnEndpointSecondary As String = ConfigurationSettings.AppSettings("BaseTxnEndpointSecondary")
        Public BaseTMSEndpointPrimary As String = ConfigurationSettings.AppSettings("BaseDataServicesEndpointPrimary")
        Public BaseTMSEndpointSecondary As String = ConfigurationSettings.AppSettings("BaseDataServicesEndpointSecondary")

        'The following is used to track Primary versus Secondary Endpoint use
        Private _blnSvcInfoPrimary As Boolean = True
        'Used to track if primary or secondary is currently being used
        Private _blnTxnPrimary As Boolean = True
        'Used to track if primary or secondary is currently being used
        Private _blnTMSPrimary As Boolean = True
        'Used to track if primary or secondary is currently being used
        'Enctyption based security key password
        Private Const SKey As String = "204E3EB69155460F85A8F7AB0F609334"
        'Using a random GUID for the key. Your application should replace this value with a new GUID for uniqueness. 
        'Some service providers require a username and user password with every transaction
        Private _credUserName As String = ""
        Private _credPassword As String = ""

        'The following are used to switch the URI for posting data
        Private Shared bankCardChannelLock As New Object()
        Private Shared svcInfoChannelLock As New Object()
        Private Shared TMSChannelLock As New Object()

        'Send an acknowledge response for each transaction
        Public BlnAcknowledge As Boolean

        'Message regarding processing. Likely instead of this your software would write the results directly to your database or a log file. 
        Public _message As String
#End Region

        Public Sub CheckTokenExpire()
            _message = ""
            If Date.UtcNow.Subtract(DtSessionToken).TotalMinutes > 25 Then 'Use 25 as the baseline for renewing session tokens
                Try
                    'if (_delegatedServiceKey != "")
                    '{
                    '    _delegatedSessionToken = Cwssic.DelegatedSignOn(_identityToken, _delegatedServiceKey, null);
                    '    _sessionToken = _delegatedSessionToken;
                    '}
                    'else
                    _sessionToken = Cwssic.SignOnWithToken(_identityToken)
                    DtSessionToken = Date.UtcNow
                Catch ex As Exception
                    Dim strErrorId As String
                    Dim strErrorMessage As String
                    _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage)

                    Dim e As New Exception("Unable to Refresh a new Token" & vbCrLf & "Error Message : " & ex.Message & vbCrLf & vbCrLf & "Unable to Refresh a new Token" & vbCrLf & "Error Message : " & strErrorId & " : " & strErrorMessage)
                    Throw e
                End Try
            End If
        End Sub

#Region "Data Encryption and Decryption"

        Public Function Encrypt(ByVal identityToken As String) As String
            'Note : Encrypt the identity token so that it's safe from any non-administrative personel
            'Reference (String) : http://www.codeproject.com/KB/security/DotNetCrypto.aspx
            'Reference (File) : http://support.microsoft.com/kb/307010

            ' First we need to turn the input string into a byte array. 
            Dim clearBytes As Byte() = System.Text.Encoding.Unicode.GetBytes(identityToken)

            ' Then, we need to turn the password into Key and IV We are using salt to make it harder to guess our key
            ' using a dictionary attack - trying to guess a password by enumerating all possible words. 
            Dim pdb As New PasswordDeriveBytes(SKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})

            ' Now get the key/IV and do the encryption using the function that accepts byte arrays. 
            ' Using PasswordDeriveBytes object we are first getting 32 bytes for the Key 
            ' (the default Rijndael key length is 256bit = 32bytes) and then 16 bytes for the IV. 
            ' IV should always be the block size, which is by default 16 bytes (128 bit) for Rijndael. 
            ' If you are using DES/TripleDES/RC2 the block size is 8 bytes and so should be the IV size. 
            ' You can also read KeySize/BlockSize properties off the algorithm to find out the sizes. 
            Dim encryptedData As Byte() = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16))


            ' Now we need to turn the resulting byte array into a string. A common mistake would be to use an Encoding class for that.
            'It does not work because not all byte values can be represented by characters. 
            ' We are going to be using Base64 encoding that is designed exactly for what we are trying to do. 
            Return Convert.ToBase64String(encryptedData)

        End Function

        Public Function Decrypt(ByVal identityToken As String) As String
            ' Since the identity token is encrypted you'll need to decrypt

            ' First we need to turn the input string into a byte array. We presume that Base64 encoding was used 
            Dim cipherBytes As Byte() = Convert.FromBase64String(identityToken)

            ' Then, we need to turn the password into Key and IV We are using salt to make it harder to guess our key
            ' using a dictionary attack - trying to guess a password by enumerating all possible words. 
            Dim pdb As New PasswordDeriveBytes(SKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})

            ' Now get the key/IV and do the decryption using the function that accepts byte arrays. 
            ' Using PasswordDeriveBytes object we are first getting 32 bytes for the Key 
            ' (the default Rijndael key length is 256bit = 32bytes) and then 16 bytes for the IV. 
            ' IV should always be the block size, which is by default 16 bytes (128 bit) for Rijndael. 
            ' If you are using DES/TripleDES/RC2 the block size is 8 bytes and so should be the IV size. 
            ' You can also read KeySize/BlockSize properties off the algorithm to find out the sizes. 
            Dim decryptedData As Byte() = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16))

            ' Now we need to turn the resulting byte array into a string. A common mistake would be to use an Encoding class for that.
            ' It does not work  because not all byte values can be represented by characters. 
            ' We are going to be using Base64 encoding that is designed exactly for what we are trying to do. 
            Return System.Text.Encoding.Unicode.GetString(decryptedData)
        End Function

        ' Encrypt a byte array into a byte array using a key and an IV 
        Private Shared Function Encrypt(ByVal clearData As Byte(), ByVal key As Byte(), ByVal IV As Byte()) As Byte()
            ' Create a MemoryStream to accept the encrypted bytes 
            Dim ms As New MemoryStream()

            ' Create a symmetric algorithm. We are going to use Rijndael because it is strong and
            ' available on all platforms. You can use other algorithms, to do so substitute the
            ' next line with something like TripleDES alg = TripleDES.Create(); 
            Dim alg As Rijndael = Rijndael.Create()

            ' Now set the key and the IV. We need the IV (Initialization Vector) because
            ' the algorithm is operating in its default mode called CBC (Cipher Block Chaining).
            ' The IV is XORed with the first block (8 byte) of the data before it is encrypted, and then each
            ' encrypted block is XORed with the following block of plaintext. This is done to make encryption more secure. 

            ' There is also a mode called ECB which does not need an IV, but it is much less secure. 
            alg.Key = key
            alg.IV = IV

            ' Create a CryptoStream through which we are going to be pumping our data. 
            ' CryptoStreamMode.Write means that we are going to be writing data to the stream and the output will be written
            ' in the MemoryStream we have provided. 
            Dim cs As New CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write)

            ' Write the data and make it do the encryption 
            cs.Write(clearData, 0, clearData.Length)

            ' Close the crypto stream (or do FlushFinalBlock). This will tell it that we have done our encryption and
            ' there is no more data coming in, and it is now a good time to apply the padding and finalize the encryption process. 
            cs.Close()

            ' Now get the encrypted data from the MemoryStream. Some people make a mistake of using GetBuffer() here,
            ' which is not the right way. 
            Dim encryptedData As Byte() = ms.ToArray()
            ms.Close()

            Return encryptedData
        End Function

        ' Decrypt a byte array into a byte array using a key and an IV 
        Private Shared Function Decrypt(ByVal cipherData As Byte(), ByVal key As Byte(), ByVal IV As Byte()) As Byte()
            ' Create a MemoryStream that is going to accept the
            ' decrypted bytes 
            Dim ms As New MemoryStream()

            ' Create a symmetric algorithm. We are going to use Rijndael because it is strong and
            ' available on all platforms. You can use other algorithms, to do so substitute the next
            ' line with something like TripleDES alg = TripleDES.Create(); 
            Dim alg As Rijndael = Rijndael.Create()

            ' Now set the key and the IV. We need the IV (Initialization Vector) because the algorithm
            ' is operating in its default mode called CBC (Cipher Block Chaining). The IV is XORed with
            ' the first block (8 byte) of the data after it is decrypted, and then each decrypted
            ' block is XORed with the previous cipher block. This is done to make encryption more secure. 
            ' There is also a mode called ECB which does not need an IV, but it is much less secure. 
            alg.Key = key
            alg.IV = IV

            ' Create a CryptoStream through which we are going to be pumping our data. CryptoStreamMode.Write means that we are going to be writing data to the stream 
            ' and the output will be written in the MemoryStream we have provided. 
            Dim cs As New CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write)

            ' Write the data and make it do the decryption 
            cs.Write(cipherData, 0, cipherData.Length)

            ' Close the crypto stream (or do FlushFinalBlock). This will tell it that we have done our decryption
            ' and there is no more data coming in, and it is now a good time to remove the padding and finalize the decryption process. 
            cs.Close()

            ' Now get the decrypted data from the MemoryStream. Some people make a mistake of using GetBuffer() here,
            ' which is not the right way. 
            Dim decryptedData As Byte() = ms.ToArray()
            ms.Close()

            Return decryptedData
        End Function

#End Region

#Region "Changing URI and Service Key"

        Public Function SetSvcEndpoint() As Boolean
            ' Possible Loging -- MessageBox.Show("Setting Svc Endpoint");

            Dim ServiceKey As String = ""

            'Switch to use Dedicated or Dynamic endpoints.
            Try
                If _blnSvcInfoPrimary Then
                    _blnSvcInfoPrimary = False
                    'Flip the boolean so that next time the secondary Endpoint is used.
                    'Try the primary URI for CWSServiceInformationClient
                    Cwssic = GetServiceInfoChannel(ServiceKey, BaseSvcEndpointPrimary)
                Else
                    _blnSvcInfoPrimary = True
                    'Flip the boolean so that next time the primary Endpoint is used.
                    'Try the secondary URI for CWSServiceInformationClient
                    Cwssic = GetServiceInfoChannel(ServiceKey, BaseSvcEndpointSecondary)
                End If
                Return True
            Catch e1 As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    If _blnSvcInfoPrimary Then
                        _blnSvcInfoPrimary = False 'Flip the boolean so that next time the secondary Endpoint is used.
                        'Try the primary URI for CWSServiceInformationClient
                        Cwssic = GetServiceInfoChannel(ServiceKey, BaseSvcEndpointPrimary)
                    Else
                        _blnSvcInfoPrimary = True 'Flip the boolean so that next time the primary Endpoint is used.
                        'Try the secondary URI for CWSServiceInformationClient
                        Cwssic = GetServiceInfoChannel(ServiceKey, BaseSvcEndpointSecondary)
                    End If
                    Return True
                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                    Return False
                Catch ex As Exception
                    _message &= "Unable to SigOn" & vbCrLf & "Error Message : " & ex.Message
                    Return False
                End Try
                '				#End Region
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                Else
                    _message += ex.Message
                End If
                Return False
            End Try
        End Function

        Public Function SetTxnEndpoint() As Boolean
            ' Possible Loging -- MessageBox.Show("Setting Txn Endpoint");

            Dim ServiceKey As String = ""

            'Switch to use Dedicated or Dynamic endpoints
            Try
                If _blnTxnPrimary Then
                    _blnTxnPrimary = False
                    'Flip the boolean so that next time the secondary Endpoint is used.
                    'Try the primary URI for CWSServiceInformationClient
                    Cwsbc = GetTxnChannel(ServiceKey, BaseTxnEndpointPrimary)
                Else
                    _blnTxnPrimary = True
                    'Flip the boolean so that next time the primary Endpoint is used.
                    'Try the secondary URI for CWSServiceInformationClient
                    Cwsbc = GetTxnChannel(ServiceKey, BaseTxnEndpointSecondary)
                End If
                Return True
            Catch e1 As EndpointNotFoundException
                '				#Region "EndpointNotFoundException"
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    If _blnTxnPrimary Then
                        _blnTxnPrimary = False 'Flip the boolean so that next time the secondary Endpoint is used.
                        'Try the primary URI for CWSServiceInformationClient
                        Cwsbc = GetTxnChannel(ServiceKey, BaseTxnEndpointPrimary)
                    Else
                        _blnTxnPrimary = True 'Flip the boolean so that next time the primary Endpoint is used.
                        'Try the secondary URI for CWSServiceInformationClient
                        Cwsbc = GetTxnChannel(ServiceKey, BaseTxnEndpointSecondary)
                    End If
                    Return True
                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                    Return False
                Catch ex As Exception
                    _message &= "Unable to SigOn" & vbCrLf & "Error Message : " & ex.Message
                    Return False
                End Try
                '				#End Region
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                Else
                    _message += ex.Message
                End If
                Return False
            End Try
        End Function

        Public Function SetTMSEndpoint() As Boolean
            ' Possible Loging -- MessageBox.Show("Setting Txn Endpoint");

            Dim ServiceKey As String = ""

            'Switch to use Dedicated or Shared endpoints
            Try
                If _blnTMSPrimary Then
                    _blnTMSPrimary = False
                    'Flip the boolean so that next time the secondary Endpoint is used.
                    'Try the primary URI for CWSServiceInformationClient
                    Tmsoc = GetTMSChannel(ServiceKey, BaseTMSEndpointPrimary)
                Else
                    _blnTMSPrimary = True
                    'Flip the boolean so that next time the primary Endpoint is used.
                    'Try the secondary URI for CWSServiceInformationClient
                    Tmsoc = GetTMSChannel(ServiceKey, BaseTMSEndpointSecondary)
                End If
                Return True
            Catch e1 As EndpointNotFoundException
                '				#Region "EndpointNotFoundException"
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    If _blnTMSPrimary Then
                        _blnTMSPrimary = False 'Flip the boolean so that next time the secondary Endpoint is used.
                        'Try the primary URI for CWSServiceInformationClient
                        Tmsoc = GetTMSChannel(ServiceKey, BaseTMSEndpointPrimary)
                    Else
                        _blnTMSPrimary = True 'Flip the boolean so that next time the primary Endpoint is used.
                        'Try the secondary URI for CWSServiceInformationClient
                        Tmsoc = GetTMSChannel(ServiceKey, BaseTMSEndpointSecondary)
                    End If
                    Return True
                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                    Return False
                Catch ex As Exception
                    _message &= "Unable to SigOn" & vbCrLf & "Error Message : " & ex.Message
                    Return False
                End Try
                '				#End Region
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleSvcInfoFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                Else
                    _message += ex.Message
                End If
                Return False
            End Try
        End Function

        Public Function GetServiceInfoChannel(ByVal serviceActivationKey As String, ByVal Uri As String) As CWSServiceInformationClient
            SyncLock svcInfoChannelLock
                Dim client As New CWSServiceInformationClient()
                client.Endpoint.Address = New EndpointAddress(Uri & serviceActivationKey)
                client.Open()
                Return client
            End SyncLock
        End Function

        Public Function GetTxnChannel(ByVal serviceActivationKey As String, ByVal Uri As String) As CwsTransactionProcessingClient
            SyncLock bankCardChannelLock
                Dim client As New CwsTransactionProcessingClient()
                client.Endpoint.Address = New EndpointAddress(Uri & serviceActivationKey)
                client.Open()
                Return client
            End SyncLock
        End Function

        Public Function GetTMSChannel(ByVal serviceActivationKey As String, ByVal Uri As String) As TMSOperationsClient
            SyncLock TMSChannelLock
                Dim client As New TMSOperationsClient()
                client.Endpoint.Address = New EndpointAddress(Uri & serviceActivationKey)
                client.Open()
                Return client
            End SyncLock
        End Function

#End Region

#Region "BankCardTransaction Methods"

        Public Function checkIfCredentialsRequired(ByVal serviceID As String, ByVal username As String, ByVal password As String) As Addendum

            If CredentialRequired() Then
                'The following items have to be included in every transaction and is specific to each individual merchant. 
                'A UI has to be in place to support entry of these data elements
                If username.Length > 1 AndAlso password.Length > 1 Then

                    Dim _add As New List(Of String)()
                    _add.Add("<UserId>" & username & "</UserId>")
                    _add.Add("<Password>" & password & "</Password>")

                    Dim a As New Addendum()
                    a.Unmanaged = New Unmanaged()
                    a.Unmanaged.Any = _add
                    Return a
                Else
                    Dim e As New Exception("This ServiceId requires a Username and Password")
                    Throw e
                End If
            End If
            Return Nothing
        End Function

        Public Function CredentialRequired() As Boolean

            'Affirmative ACH Now
            'Sandbox
            If ServiceID = "35A7700001" Then
                Return True
            End If
            'Production
            If ServiceID = "DF29D1300C" Then
                Return True
            End If
        End Function

        Public Function SetSoftDescriptors() As AlternativeMerchantData
            Dim AMD As New AlternativeMerchantData()
            'Set Soft Descriptors
            'BCP74                     BCP68                       BCP64         
            If _serviceId = "D806000001" Or _serviceId = "B447F00001" Or _serviceId = "88D9300001" Or _serviceId = "DEDC61300C" Or _serviceId = "1A8871300C" Or _serviceId = "C43CC1300C" Then 'Production - Sandbox
                AMD.Name = "ABC Merchant"
                AMD.Address = New AddressInfo()
                AMD.Address.City = "Denver"
                AMD.Address.CountryCode = TypeISOCountryCodeA3.USA
                AMD.Address.StateProvince = "CO"
                AMD.Address.Street1 = "1234 Happy St"
                AMD.Address.PostalCode = "80023"
                AMD.CustomerServicePhone = "303 3575700"
                AMD.CustomerServiceInternet = "www.test.com"
            Else
                AMD = Nothing
            End If

            Return AMD
        End Function

        Public Function TranslateServiceIdToFriendlyName(ByVal bankcardService As BankcardService) As String

            'Sandbox            
            If bankcardService.ServiceId = "35A7700001" Then
                Return "Affirmative ACH Now"
            End If

            'Production
            If bankcardService.ServiceId = "DF29D1300C" Then
                Return "Affirmative ACH Now"
            End If

            Return bankcardService.ServiceName
            'Match was not found so pass back the name in the service.
        End Function

        Public Function ProcessBCPTransaction(ByVal _TT As TransactionType, ByVal _BCtransaction As BankcardTransaction, ByVal _BCDifferenceData As BankcardCapture, ByVal _BatchIds As List(Of String), ByVal _RDifferenceData As BankcardReturn, ByVal _ADifferenceData As Adjust, ByVal _UDifferenceData As BankcardUndo, ByVal _TransactionIds As List(Of String), ByVal _CaptureDifferenceData As List(Of Capture), ByVal _SendAcknowledge As Boolean, ByVal _UseWorkflowId As Boolean, ByVal _ForceClose As Boolean) As List(Of ResponseDetails)
            'TransactionType _TT                    //Required
            'BankcardTransaction _BCtransaction     //Conditional : Only used for an AuthorizeAndCapture, Authorize and ReturnUnlinked. Otherwise null
            'BankcardCapture _BCDifferenceData      //Conditional : Only used for a Capture. Otherwise null
            'List<String> _BatchIds                 //Conditional : A list of one or more batch Ids to capture.
            'BankcardReturn _RDifferenceData        //Conditional : Only used for a ReturnById. Otherwise null
            'Adjust _ADifferenceData                //Conditional : Only used for an Adjust. Otherwise null
            'BankcardUndo _UDifferenceData          //Conditional : Only used for an Undo. Otherwise null
            'List<string> _TransactionIds           //Conditional : Only used for a CaptureSelective. Otherwise null
            'List<Capture> _CaptureDifferenceData   //Conditional : Only used for CaptureAll and CaptureSelective. Otherwise null
            'bool _SendAcknowledge
            'bool _ForceClose) 

            Dim _Response As New List(Of Response)()
            Try
                CheckTokenExpire() 'Make sure the current token is valid

                Dim _serviceIdOrWorkflowId As String = _serviceId
                If _UseWorkflowId Then
                    _serviceIdOrWorkflowId = _workflowId
                End If

                If _TT = TransactionType.AuthorizeAndCapture Then
                    If CredentialRequired() Then
                        _BCtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.AuthorizeAndCapture(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceIdOrWorkflowId))

                    'Always Verify that the requested amount and approved amount are the same. 
                    Dim BCR As New BankcardTransactionResponse()
                    BCR = CType(_Response(0), BankcardTransactionResponse)
                    If _BCtransaction.TransactionData.Amount <> BCR.Amount Then
                        _message &= "The transaction was approved for " & BCR.Amount & " which is an amount not equal to the requested amount of " & _BCtransaction.TransactionData.Amount & ". Please provide alternate payment to complete transaction"
                    End If
                End If

                If _TT = TransactionType.Authorize Then
                    If CredentialRequired() Then
                        _BCtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Authorize(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceIdOrWorkflowId))

                    'Always Verify that the requested amount and approved amount are the same. 
                    Dim BCR As New BankcardTransactionResponse()
                    BCR = CType(_Response(0), BankcardTransactionResponse)
                    If _BCtransaction.TransactionData.Amount <> BCR.Amount Then
                        _message &= "The transaction was approved for " & BCR.Amount & " which is an amount not equal to than the requested amount of " & _BCtransaction.TransactionData.Amount & ". Please provide alternate payment to complete transaction"
                    End If
                End If
                If _TT = TransactionType.Capture Then
                    If CredentialRequired() Then
                        _BCDifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Capture(_sessionToken, _BCDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.CaptureAll Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response = Cwsbc.CaptureAll(_sessionToken, _CaptureDifferenceData, _BatchIds, _applicationProfileId, _merchantProfileId, _serviceId, _ForceClose)
                End If
                If _TT = TransactionType.CaptureAllAsync Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.CaptureAllAsync(_sessionToken, _CaptureDifferenceData, _BatchIds, _applicationProfileId, _merchantProfileId, _serviceId, _ForceClose))
                End If
                If _TT = TransactionType.CaptureSelective Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response = Cwsbc.CaptureSelective(_sessionToken, _TransactionIds, _CaptureDifferenceData, _applicationProfileId, _serviceId)
                End If
                If _TT = TransactionType.ReturnById Then
                    If CredentialRequired() Then
                        _RDifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.ReturnById(_sessionToken, _RDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.Return Then
                    If CredentialRequired() Then
                        _BCtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.ReturnUnlinked(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If
                If _TT = TransactionType.Adjust Then
                    _Response.Add(Cwsbc.Adjust(_sessionToken, _ADifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.Undo Then
                    If CredentialRequired() Then
                        _UDifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Undo(_sessionToken, _UDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.QueryAccount Then
                    _Response.Add(Cwsbc.QueryAccount(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If
                If _TT = TransactionType.Verify Then
                    _Response.Add(Cwsbc.Verify(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If

                Dim RD As New List(Of ResponseDetails)() 'Convert the response to response details so that we can report on the UI
                If _Response IsNot Nothing Then
                    For Each r As Response In _Response
                        If _SendAcknowledge AndAlso r.TransactionId.Length > 0 Then
                            Cwsbc.Acknowledge(_sessionToken, r.TransactionId, _applicationProfileId, _serviceId)
                        End If

                        Dim RDN As New ResponseDetails(0D, r, _TT.ToString(), _serviceIdOrWorkflowId, _merchantProfileId, True, TypeCardType.NotSet, "")
                        _message += ProcessResponse(RDN) 'Pass as reference so we can extract more values from the response
                        RD.Add(RDN)
                    Next r
                End If

                Return RD
            Catch e1 As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    SetTxnEndpoint() 'Change the endpoint to use the backup.

                    'TODO : Add a copy of the code above once fully tested out.

                    Return Nothing

                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                Catch ex As Exception
                    _message &= "Unable to AuthorizeAndCapture" & vbCrLf & "Error Message : " & ex.Message
                End Try
            Catch te As System.TimeoutException
                'A timeout has occured. Prompt the user if they'd like to query for the last transaction submitted
                If _BCtransaction IsNot Nothing Then
                    _message &= "A timeout has occured. A call to 'RequestTransaction' was made to obtain the transactions that should have been returned. Your code will need to reconcile transactions."
                    RequestTransaction(_BCtransaction.TenderData)
                Else
                    Throw te
                End If
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTxnFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                    Throw ex
                Else
                    _message += ex.Message
                End If
            End Try

            Return Nothing
        End Function

        'Required
        'Conditional : Only used for an AuthorizeAndCapture, Authorize and ReturnUnlinked. Otherwise null
        'Conditional : Only used for a Capture. Otherwise null
        'Conditional : A list of one or more batch Ids to capture.
        'Conditional : Only used for a ReturnById. Otherwise null
        'Conditional : Only used for an Adjust. Otherwise null
        'Conditional : Only used for an Undo. Otherwise null
        'Conditional : Only used for a CaptureSelective. Otherwise null
        'Conditional : Only used for CaptureAll and CaptureSelective. Otherwise null
        Public Function ProcessBCPTransactionPro(ByVal _TT As TransactionType, ByVal _BCtransaction As BankcardTransactionPro, ByVal _BCDifferenceData As BankcardCapturePro, ByVal _BatchIds As List(Of String), ByVal _RDifferenceData As BankcardReturn, ByVal _ADifferenceData As Adjust, ByVal _UDifferenceData As BankcardUndo, ByVal _TransactionIds As List(Of String), ByVal _CaptureDifferenceData As List(Of Capture), ByVal _SendAcknowledge As Boolean, ByVal _UseWorkflowId As Boolean, ByVal _ForceClose As Boolean) As List(Of ResponseDetails) 'Conditional : Only used for CaptureAll and CaptureSelective. Otherwise null - Conditional : Only used for a CaptureSelective. Otherwise null - Conditional : Only used for an Undo. Otherwise null - Conditional : Only used for an Adjust. Otherwise null - Conditional : Only used for a ReturnById. Otherwise null - Conditional : A list of one or more batch Ids to capture. - Conditional : Only used for a Capture. Otherwise null - Conditional : Only used for an AuthorizeAndCapture, Authorize and ReturnUnlinked. Otherwise null - Required
            Dim _Response As New List(Of Response)()
            Try
                CheckTokenExpire() 'Make sure the current token is valid

                Dim _serviceIdOrWorkflowId As String = _serviceId
                If _UseWorkflowId Then
                    _serviceIdOrWorkflowId = _workflowId
                End If

                If _TT = TransactionType.AuthorizeAndCapture Then
                    If CredentialRequired() Then
                        _BCtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.AuthorizeAndCapture(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceIdOrWorkflowId))
                    'Always Verify that the requested amount and approved amount are the same. 
                    Dim BCR As New BankcardTransactionResponsePro()
                    BCR = CType(_Response(0), BankcardTransactionResponsePro)
                    If _BCtransaction.TransactionData.Amount <> BCR.Amount Then
                        _message &= "The transaction was approved for " & BCR.Amount & " which is an amount not equal to the requested amount of " & _BCtransaction.TransactionData.Amount & ". Please provide alternate payment to complete transaction"
                    End If
                End If

                If _TT = TransactionType.Authorize Then
                    If CredentialRequired() Then
                        _BCtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Authorize(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceIdOrWorkflowId))
                    'Always Verify that the requested amount and approved amount are the same. 
                    Dim BCR As New BankcardTransactionResponsePro()
                    BCR = CType(_Response(0), BankcardTransactionResponsePro)
                    If _BCtransaction.TransactionData.Amount <> BCR.Amount Then
                        _message &= "The transaction was approved for " & BCR.Amount & " which is an amount not equal to than the requested amount of " & _BCtransaction.TransactionData.Amount & ". Please provide alternate payment to complete transaction"
                    End If
                End If
                If _TT = TransactionType.Capture Then
                    If CredentialRequired() Then
                        _BCDifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Capture(_sessionToken, _BCDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.CaptureAll Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response = Cwsbc.CaptureAll(_sessionToken, _CaptureDifferenceData, _BatchIds, _applicationProfileId, _merchantProfileId, _serviceId, _ForceClose)
                End If
                If _TT = TransactionType.CaptureAllAsync Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.CaptureAllAsync(_sessionToken, _CaptureDifferenceData, _BatchIds, _applicationProfileId, _merchantProfileId, _serviceId, _ForceClose))
                End If
                If _TT = TransactionType.CaptureSelective Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response = Cwsbc.CaptureSelective(_sessionToken, _TransactionIds, _CaptureDifferenceData, _applicationProfileId, _serviceId)
                End If
                'If _TT = TransactionType.CaptureSelectiveAsync Then
                '    If CredentialRequired() Then
                '        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                '    End If
                '    _Response.Add(Cwsbc.CaptureSelectiveAsync(_sessionToken, _TransactionIds, _CaptureDifferenceData, _applicationProfileId, _serviceId))
                'End If
                If _TT = TransactionType.ReturnById Then
                    If CredentialRequired() Then
                        _RDifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.ReturnById(_sessionToken, _RDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.Return Then
                    If CredentialRequired() Then
                        _BCtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.ReturnUnlinked(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If
                If _TT = TransactionType.Adjust Then
                    If CredentialRequired() Then
                        _ADifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Adjust(_sessionToken, _ADifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.Undo Then
                    If CredentialRequired() Then
                        _UDifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Undo(_sessionToken, _UDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.QueryAccount Then
                    If CredentialRequired() Then
                        _BCtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.QueryAccount(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If
                If _TT = TransactionType.Verify Then
                    _Response.Add(Cwsbc.Verify(_sessionToken, _BCtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If

                Dim RD As New List(Of ResponseDetails)() 'Convert the response to response details so that we can report on the UI
                If _Response IsNot Nothing Then
                    For Each r As Response In _Response
                        If _SendAcknowledge AndAlso r.TransactionId.Length > 0 Then
                            Cwsbc.Acknowledge(_sessionToken, r.TransactionId, _applicationProfileId, _serviceId)
                        End If

                        Dim RDN As New ResponseDetails(0D, r, _TT.ToString(), _serviceIdOrWorkflowId, _merchantProfileId, True, TypeCardType.NotSet, "")
                        _message += ProcessResponse(RDN) 'Pass as reference so we can extract more values from the response
                        RD.Add(RDN)
                    Next r
                End If

                Return RD
            Catch e1 As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    SetTxnEndpoint() 'Change the endpoint to use the backup.

                    'TODO : Add a copy of the code above once fully tested out.

                    Return Nothing

                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                Catch ex As Exception
                    _message &= "Unable to AuthorizeAndCapture" & vbCrLf & "Error Message : " & ex.Message
                End Try
            Catch te As System.TimeoutException
                'A timeout has occured. Prompt the user if they'd like to query for the last transaction submitted               
                If _BCtransaction IsNot Nothing Then
                    _message &= "A timeout has occured. A call to 'RequestTransaction' was made to obtain the transactions that should have been returned. Your code will need to reconcile transactions."
                    RequestTransaction(_BCtransaction.TenderData)
                Else
                    Throw te
                End If
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTxnFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                Else
                    _message += ex.Message
                End If
            End Try

            Return Nothing
        End Function


#Region "Card Validation Helper Methods"

        Public Function seperateTrackData(ByVal _TrackFromMSR As String) As TrackFromMSRSwipe
            Dim TFMSRS As New TrackFromMSRSwipe("", "")
            Dim Tracks As String() = New String(2) {}
            Dim splitter As Char() = {"?"c}

            Tracks = _TrackFromMSR.Split(splitter, StringSplitOptions.RemoveEmptyEntries)

            For x As Integer = 0 To Tracks.Length - 1
                If Tracks(x).Substring(0, 1) = "%" And TFMSRS.Track1Data.Length < 1 Then
                    'The following removes track 1 start sentinal
                    TFMSRS.Track1Data = Tracks(x).Substring(1, Tracks(x).Length - 1)
                End If
                If Tracks(x).Substring(0, 1) = ";" And TFMSRS.Track2Data.Length < 1 Then
                    'Removes start sentenal for Track 2
                    TFMSRS.Track2Data = Tracks(x).Substring(1, Tracks(x).Length - 1)
                End If
            Next
            Return TFMSRS
        End Function

        Public Function validateTrackData(ByRef _BCtransaction As BankcardTransactionPro, ByVal _SwipedTrackData As String) As Boolean
            'NOTE: The following assumes that you have already seperated track 1 from track 2 and selected which one to use
            Dim regTrackData1 As New Regex("^([B|b])([\d]{1,19})\^([^\^]{2,26})\^([\d]{4}|\^)([\d]{3}|\^)([^\?]+)$")
            Dim regTrackData2 As New Regex("^(\d{1,19})\=(\d{4}|\=)(\d{3}|\=)([^\?]+)$")
            If regTrackData2.IsMatch(_SwipedTrackData) Then
                'Track 2 Match - You'll have to remove the starting and ending sentinal
                _BCtransaction.TenderData.CardData.Track2Data = _SwipedTrackData
            ElseIf regTrackData1.IsMatch(_SwipedTrackData) Then
                'Track 1 Match
                _BCtransaction.TenderData.CardData.Track1Data = _SwipedTrackData
            Else
                Return False
            End If
            Return True
        End Function

        Public Function CardTypeLookup(ByVal strPAN As String) As TypeCardType
            Dim strCardType As String = ""

            '
            '             * NOTE : "NotSet" TypeCardType is not a valid card type to transmit in the BankcardTransaction Object. If returned the 
            '             * validation checks did not find a match. The software should log a message that it was unable to 
            '             * match as the CardTypeLookup may need additional validation logic added to it. Never log the PAN as this would 
            '             * be a PCI violation.
            '            

            If Convert.ToInt16(strPAN.Substring(0, 1)) = 4 Then
                Return TypeCardType.Visa
            End If

            If Convert.ToInt16(strPAN.Substring(0, 1)) = 5 Then
                Return TypeCardType.MasterCard
            End If

            If Convert.ToInt16(strPAN.Substring(0, 2)) = 34 Or Convert.ToInt16(strPAN.Substring(0, 2)) = 37 Then
                Return TypeCardType.AmericanExpress
            End If

            If Convert.ToInt16(strPAN.Substring(0, 2)) = 36 Then
                Return TypeCardType.Discover
            End If

            If Convert.ToInt16(strPAN.Substring(0, 4)) = 3095 Then
                Return TypeCardType.Discover
            End If

            If Convert.ToInt16(strPAN.Substring(0, 2)) = 67 Then
                Return TypeCardType.Maestro
            End If

            If Convert.ToInt16(strPAN.Substring(0, 4)) > 2999 And Convert.ToInt16(strPAN.Substring(0, 4)) < 3096 Then
                Return TypeCardType.Discover
            End If

            If Convert.ToInt16(strPAN.Substring(0, 2)) > 37 And Convert.ToInt16(strPAN.Substring(0, 2)) < 40 Then
                Return TypeCardType.Discover
            End If

            If Convert.ToInt16(strPAN.Substring(0, 4)) = 6011 Then
                If Convert.ToInt16(strPAN.Substring(4, 2)) = 4 Then
                    'Paypal to be added to schema
                    'Return TypeCardType.Paypal

                    Return TypeCardType.Discover
                Else
                    Return TypeCardType.Discover
                End If
            End If

            If Convert.ToInt16(strPAN.Substring(0, 2)) > 63 And Convert.ToInt16(strPAN.Substring(0, 2)) < 66 Then
                If Convert.ToInt16(strPAN.Substring(3, 3)) > 599 And Convert.ToInt16(strPAN.Substring(3, 3)) < 611 Then
                    'Paypal to be added to schema
                    'Return TypeCardType.Paypal

                    Return TypeCardType.Discover
                Else
                    Return TypeCardType.Discover
                End If
            End If

            If Convert.ToInt32(strPAN.Substring(0, 6)) = 352800 And Convert.ToInt32(strPAN.Substring(0, 6)) < 358999 Then
                Return TypeCardType.JCB
            End If

            If Convert.ToInt16(strPAN.Substring(0, 2)) = 62 Then
                Return TypeCardType.Discover
            End If

            Return TypeCardType.NotSet
            'No match was found
        End Function

        Public Shared Function ValidateCreditCardNumber(ByVal creditCardNumber As String) As Boolean
            'check to see if it's masked by the protector
            Dim pattern As String = "^(X+)[\d]{4}$"
            Dim exp As New Regex(pattern)
            Dim match As Match = exp.Match(creditCardNumber)
            If match.Success Then
                Return True
            End If

            Try
                ' Array to contain individual numbers
                Dim CheckNumbers As New ArrayList()

                ' Get length of card
                Dim CardLength As Integer = creditCardNumber.Length

                ' Double the value of alternate digits, starting with the second digit
                ' from the right, i.e. back to front.

                ' Loop through starting at the end
                Dim i As Integer = CardLength - 2
                While i >= 0
                    ' Now read the contents at each index, this
                    ' can then be stored as an array of integers

                    ' Double the number returned
                    CheckNumbers.Add(Int32.Parse(creditCardNumber(i).ToString()) * 2)
                    i = i - 2
                End While

                Dim CheckSum As Integer = 0
                ' Will hold the total sum of all checksum digits
                ' Second stage, add separate digits of all products
                For iCount As Integer = 0 To CheckNumbers.Count - 1
                    Dim _count As Integer = 0
                    ' will hold the sum of the digits
                    ' determine if current number has more than one digit
                    If CInt(CheckNumbers(iCount)) > 9 Then
                        Dim _numLength As Integer = CInt(CheckNumbers(iCount)).ToString().Length
                        ' add count to each digit
                        For x As Integer = 0 To _numLength - 1
                            _count = _count + Int32.Parse(CInt(CheckNumbers(iCount)).ToString()(x).ToString())
                        Next
                    Else
                        ' single digit, just add it by itself
                        _count = CInt(CheckNumbers(iCount))
                    End If

                    ' add sum to the total sum
                    CheckSum = CheckSum + _count
                Next

                ' Stage 3, add the unaffected digits
                ' Add all the digits that we didn't double still starting from the right
                ' but this time we'll start from the rightmost number with alternating digits
                Dim OriginalSum As Integer = 0
                Dim y As Integer = CardLength - 1
                While y >= 0
                    OriginalSum = OriginalSum + Int32.Parse(creditCardNumber(y).ToString())
                    y = y - 2
                End While

                ' Perform the final calculation, if the sum Mod 10 results in 0 then
                ' it's valid, otherwise its false.
                Dim isValid As Boolean = (((OriginalSum + CheckSum) Mod 10) = 0)

                'Now that the number checks out, make sure it has the correct number of digits
                'for the card type
                If isValid Then
                    ' AMEX -- 34 or 37 -- 15 length
                    If Regex.IsMatch(creditCardNumber, "^(34|37)") Then
                        Return (15 = creditCardNumber.Length)
                    End If

                    ' MasterCard -- 51 through 55 -- 16 length
                    If Regex.IsMatch(creditCardNumber, "^(51|52|53|54|55)") Then
                        Return (16 = creditCardNumber.Length)
                    End If

                    ' VISA -- 4 -- 13 and 16 length
                    If Regex.IsMatch(creditCardNumber, "^(4)") Then
                        Return (13 = creditCardNumber.Length OrElse 16 = creditCardNumber.Length)
                    End If

                    ' Diners Club -- 300-305, 36 or 38 -- 14 length
                    If Regex.IsMatch(creditCardNumber, "^(300|301|302|303|304|305|36|38)") Then
                        Return (14 = creditCardNumber.Length)
                    End If

                    ' enRoute -- 2014,2149 -- 15 length
                    If Regex.IsMatch(creditCardNumber, "^(2014|2149)") Then
                        Return (15 = creditCardNumber.Length)
                    End If

                    ' Discover -- 6011 -- 16 length
                    If Regex.IsMatch(creditCardNumber, "^(6011)") Then
                        Return (16 = creditCardNumber.Length)
                    End If

                    ' JCB -- 3 -- 16 length
                    If Regex.IsMatch(creditCardNumber, "^(3)") Then
                        Return (16 = creditCardNumber.Length)
                    End If

                    ' JCB -- 2131, 1800 -- 15 length
                    If Regex.IsMatch(creditCardNumber, "^(2131|1800)") Then
                        Return (15 = creditCardNumber.Length)
                    End If
                    'Card type wasn't recognised but could be a private label.
                    'Since it isn't breaking any rules of known cards, it's OK to return true.

                    Return True
                End If
                Return False
            Catch
                Return False
            End Try
        End Function

#End Region

#End Region

#Region "ElectronicCheckTransaction Methods"

        Public Function TranslateServiceIdToFriendlyName(ByVal electronicCheckingService As ElectronicCheckingService) As String
            'Sandbox
            If electronicCheckingService.ServiceId = "35A7700001" Then
                Return "Affirmative ACH Now"
            End If

            'Production
            If electronicCheckingService.ServiceId = "DF29D1300C" Then
                Return "Affirmative ACH Now"
            End If

            Return electronicCheckingService.ServiceName
            'Match was not found so pass back the name in the service.
        End Function

        'Required
        'Conditional : A list of one or more batch Ids to capture.
        'Conditional : Only used for an Undo. Otherwise null

        Public Function ProcessECKTransaction(ByVal _TT As TransactionType, ByVal _ECKtransaction As ElectronicCheckingTransaction, ByVal _BatchIds As List(Of String), ByVal _CaptureDifferenceData As List(Of Capture), ByVal _UDifferenceData As Undo, ByVal _SendAcknowledge As Boolean, ByVal _ForceClose As Boolean) As List(Of ResponseDetails) 'Conditional : Only used for an Undo. Otherwise null - Conditional : A list of one or more batch Ids to capture. - Required
            Dim _Response As New List(Of Response)()
            Try
                CheckTokenExpire() 'Make sure the current token is valid

                'if (_TT == TransactionType.AuthorizeAndCapture)
                If _TT = TransactionType.Authorize Then
                    If CredentialRequired() Then
                        _ECKtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Authorize(_sessionToken, _ECKtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                    'Always Verify that the requested amount and approved amount are the same. 

                    Dim ECKR As New ElectronicCheckingTransactionResponse()
                    ECKR = CType(_Response(0), ElectronicCheckingTransactionResponse)
                    If _ECKtransaction.TransactionData.Amount <> ECKR.Amount Then
                        _message &= "The transaction was approved for " & ECKR.Amount & " which is an amount not equal to than the requested amount of " & _ECKtransaction.TransactionData.Amount & ". Please provide alternate payment to complete transaction"
                    End If
                End If
                'if (_TT == TransactionType.Capture)
                If _TT = TransactionType.CaptureAll Then
                    _CaptureDifferenceData = New List(Of Capture)()
                    Dim cap As New Capture()
                    If CredentialRequired() Then
                        cap.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    cap.TransactionId = "-1"
                    _CaptureDifferenceData.Add(cap)
                    _Response = Cwsbc.CaptureAll(_sessionToken, _CaptureDifferenceData, _BatchIds, _applicationProfileId, _merchantProfileId, _serviceId, _ForceClose)
                End If
                If _TT = TransactionType.CaptureAllAsync Then
                    _CaptureDifferenceData = New List(Of Capture)()
                    Dim cap As New Capture()
                    If CredentialRequired() Then
                        cap.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    cap.TransactionId = "-1"
                    _CaptureDifferenceData.Add(cap)
                    _Response.Add(Cwsbc.CaptureAllAsync(_sessionToken, _CaptureDifferenceData, _BatchIds, _applicationProfileId, _merchantProfileId, _serviceId, _ForceClose))
                End If

                'if (_TT == TransactionType.CaptureSelective)
                'if (_TT == TransactionType.CaptureSelectiveAsync)
                'if (_TT == TransactionType.ReturnById)
                'if (_TT == TransactionType.Return)
                'if (_TT == TransactionType.Adjust)
                If _TT = TransactionType.Undo Then
                    If CredentialRequired() Then
                        _UDifferenceData.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.Undo(_sessionToken, _UDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.QueryAccount Then
                    If CredentialRequired() Then
                        _ECKtransaction.Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                    End If
                    _Response.Add(Cwsbc.QueryAccount(_sessionToken, _ECKtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If

                'if (_TT == TransactionType.Verify)

                Dim RD As New List(Of ResponseDetails)() 'Convert the response to response details so that we can report on the UI
                If _Response IsNot Nothing Then
                    For Each r As Response In _Response
                        If _SendAcknowledge AndAlso r.TransactionId.Length > 0 Then
                            Cwsbc.Acknowledge(_sessionToken, r.TransactionId, _applicationProfileId, _serviceId)
                        End If

                        Dim RDN As New ResponseDetails(0D, r, _TT.ToString(), _serviceId, _merchantProfileId, True, TypeCardType.NotSet, "")
                        _message += ProcessResponse(RDN) 'Pass as reference so we can extract more values from the response
                        RD.Add(RDN)
                    Next r
                End If

                Return RD
            Catch e1 As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    SetTxnEndpoint() 'Change the endpoint to use the backup.

                    'TODO : Add a copy of the code above once fully tested out.

                    Return Nothing

                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                Catch ex As Exception
                    _message &= "Unable to AuthorizeAndCapture" & vbCrLf & "Error Message : " & ex.Message
                End Try
            Catch te As System.TimeoutException
                'A timeout has occured. Prompt the user if they'd like to query for the last transaction submitted
                If _ECKtransaction IsNot Nothing Then
                    _message &= "A timeout has occured. A call to 'RequestTransaction' was made to obtain the transactions that should have been returned. Your code will need to reconcile transactions."
                    RequestTransaction(_ECKtransaction.TenderData)
                Else
                    Throw te
                End If
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTxnFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                Else
                    _message += ex.Message
                End If
            End Try

            Return Nothing
        End Function

        Public Function ProcessECKCaptureAll(ByVal _TT As TransactionType, ByVal _CaptureDifferenceData As List(Of Capture), ByVal _SendAcknowledge As Boolean, ByVal _UseWorkflowId As Boolean) As List(Of ResponseDetails) 'Conditional : Only used for CaptureAll and CaptureSelective. Otherwise null - Required
            Dim _Response As New List(Of Response)()
            Try
                CheckTokenExpire() 'Make sure the current token is valid

                Dim _serviceIdOrWorkflowId As String = _serviceId
                If _UseWorkflowId Then
                    _serviceIdOrWorkflowId = _workflowId
                End If

                If _TT = TransactionType.CaptureAll Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                        _CaptureDifferenceData(0).TransactionId = "-1"
                    End If

                    _Response = Cwsbc.CaptureAll(_sessionToken, _CaptureDifferenceData, Nothing, _applicationProfileId, _merchantProfileId, _serviceId, False)
                End If
                If _TT = TransactionType.CaptureAllAsync Then
                    If CredentialRequired() Then
                        _CaptureDifferenceData(0).Addendum = checkIfCredentialsRequired(_serviceId, _credUserName, _credPassword)
                        _CaptureDifferenceData(0).TransactionId = "-1"
                    End If
                    _Response.Add(Cwsbc.CaptureAllAsync(_sessionToken, _CaptureDifferenceData, Nothing, _applicationProfileId, _merchantProfileId, _serviceId, False))
                End If

                Dim RD As New List(Of ResponseDetails)() 'Convert the response to response details so that we can report on the UI
                If _Response IsNot Nothing Then
                    For Each r As Response In _Response
                        If _SendAcknowledge AndAlso r.TransactionId.Length > 0 Then
                            Cwsbc.Acknowledge(_sessionToken, r.TransactionId, _applicationProfileId, _serviceId)
                        End If

                        Dim RDN As New ResponseDetails(0D, r, _TT.ToString(), _serviceIdOrWorkflowId, _merchantProfileId, True, TypeCardType.NotSet, "")
                        _message += ProcessResponse(RDN) 'Pass as reference so we can extract more values from the response
                        RD.Add(RDN)
                    Next r
                End If

                Return RD
            Catch e1 As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    SetTxnEndpoint() 'Change the endpoint to use the backup.

                    'TODO : Add a copy of the code above once fully tested out.

                    Return Nothing

                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                Catch ex As Exception
                    _message &= "Unable to AuthorizeAndCapture" & vbCrLf & "Error Message : " & ex.Message
                End Try
            Catch te As System.TimeoutException
                Throw te
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTxnFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                Else
                    _message += ex.Message
                End If
            End Try

            Return Nothing
        End Function

#End Region

#Region "StoredValueTransaction Methods"

        Public Function TranslateServiceIdToFriendlyName(ByVal storedValueService As StoredValueService) As String
            'Sandbox
            If storedValueService.ServiceId = "C58FD00001" Then
                Return "Stored Value Service"
            End If

            'Production
            If storedValueService.ServiceId = "XXXXX1300C" Then
                Return "Stored Value Service"
            End If

            Return storedValueService.ServiceName 'Match was not found so pass back the name in the service.
        End Function


        Public Function ProcessSVATransaction(ByVal _TT As TransactionType, ByVal _SVAtransaction As StoredValueTransaction, ByVal _SVManage As StoredValueManage, ByVal _SVDifferenceData As StoredValueCapture, ByVal _SVRDifferenceData As StoredValueReturn, ByVal _UDifferenceData As Undo, ByVal _SendAcknowledge As Boolean) As List(Of ResponseDetails) 'Conditional : Only used for an Undo. Otherwise null - Conditional : Only used for a ReturnById. Otherwise null - Conditional : Only used for a Capture. Otherwise null -  Conditional : Only used to manage. Otherwise null - Conditional : Only used for an AuthorizeAndCapture, Authorize and ReturnUnlinked. Otherwise null - Required
            Dim _Response As New List(Of Response)()
            Try
                CheckTokenExpire() 'Make sure the current token is valid

                'if (_TT == TransactionType.AuthorizeAndCapture)
                If _TT = TransactionType.Authorize Then
                    _Response.Add(Cwsbc.Authorize(_sessionToken, _SVAtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                    'Always Verify that the requested amount and approved amount are the same. 
                    Dim SVR As New StoredValueTransactionResponse()
                    SVR = CType(_Response(0), StoredValueTransactionResponse)
                    If _SVAtransaction.TransactionData.Amount <> SVR.Amount Then
                        _message &= "The transaction was approved for " & SVR.Amount & " which is an amount not equal to than the requested amount of " & _SVAtransaction.TransactionData.Amount & ". Please provide alternate payment to complete transaction"
                    End If
                End If
                If _TT = TransactionType.ManageAccountById Then
                    _Response.Add(Cwsbc.ManageAccountById(_sessionToken, _SVManage, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.ManageAccount Then
                    _Response.Add(Cwsbc.ManageAccount(_sessionToken, _SVAtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If
                If _TT = TransactionType.Capture Then
                    _Response.Add(Cwsbc.Capture(_sessionToken, _SVDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.ReturnById Then
                    _Response.Add(Cwsbc.ReturnById(_sessionToken, _SVRDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.Return Then
                    _Response.Add(Cwsbc.ReturnUnlinked(_sessionToken, _SVAtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If
                If _TT = TransactionType.Undo Then
                    _Response.Add(Cwsbc.Undo(_sessionToken, _UDifferenceData, _applicationProfileId, _serviceId))
                End If
                If _TT = TransactionType.QueryAccount Then
                    _Response.Add(Cwsbc.QueryAccount(_sessionToken, _SVAtransaction, _applicationProfileId, _merchantProfileId, _serviceId))
                End If

                Dim RD As New List(Of ResponseDetails)() 'Convert the response to response details so that we can report on the UI
                If _Response IsNot Nothing Then
                    For Each r As Response In _Response
                        If _SendAcknowledge AndAlso r.TransactionId.Length > 0 Then
                            Cwsbc.Acknowledge(_sessionToken, r.TransactionId, _applicationProfileId, _serviceId)
                        End If

                        Dim RDN As New ResponseDetails(0D, r, _TT.ToString(), _serviceId, _merchantProfileId, True, TypeCardType.NotSet, "")
                        _message += ProcessResponse(RDN) 'Pass as reference so we can extract more values from the response
                        RD.Add(RDN)
                    Next r
                End If

                Return RD
            Catch e1 As EndpointNotFoundException
                'In this case the SvcEndpoint was not available. Try the same logic again with the alternate Endpoint
                Try
                    SetTxnEndpoint() 'Change the endpoint to use the backup.

                    'TODO : Add a copy of the code above once fully tested out.

                    Return Nothing

                Catch e2 As EndpointNotFoundException
                    _message &= "Neither the primary or secondary endpoints are available. Unable to process."
                Catch ex As Exception
                    _message &= "Unable to AuthorizeAndCapture" & vbCrLf & "Error Message : " & ex.Message
                End Try
            Catch te As System.TimeoutException
                'A timeout has occured. Prompt the user if they'd like to query for the last transaction submitted               
                If _SVAtransaction IsNot Nothing Then
                    _message &= "A timeout has occured. A call to 'RequestTransaction' was made to obtain the transactions that should have been returned. Your code will need to reconcile transactions."
                    RequestTransaction(_SVAtransaction.TenderData)
                Else
                    Throw te
                End If
            Catch ex As Exception
                Dim strErrorId As String
                Dim strErrorMessage As String
                If _FaultHandler.handleTxnFault(ex, strErrorId, strErrorMessage) Then
                    _message += strErrorId & " : " & strErrorMessage
                Else
                    _message += ex.Message
                End If
            End Try

            Return Nothing
        End Function

#End Region

#Region "Process Response"
        Public Sub RequestTransaction(ByVal _transactionTenderData As schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn.TransactionTenderData)
            'when the application does not receive a response from CWS indicating the TransactionState.

            Dim _Response As New List(Of Response)()
            CheckTokenExpire() 'Make sure the current token is valid
            _Response = Cwsbc.RequestTransaction(_sessionToken, _merchantProfileId, _transactionTenderData)

            If _Response IsNot Nothing Then
                For Each r As Response In _Response
                    Dim RDN As New ResponseDetails(0D, r, "", "", _merchantProfileId, True, TypeCardType.NotSet, "")
                    _message += ProcessResponse(RDN) 'Pass as reference so we can extract more values from the response
                Next r
            End If
        End Sub

        Public Function ProcessResponse(ByVal _Response As ResponseDetails) As String
            If TypeOf _Response.Response Is BankcardTransactionResponsePro Then
                'In the 1.17.11 release all response objects are BankcardTransactionResponsePro
                Return ProcessBankcardTransactionResponsePro(_Response)
            End If
            'Future functionality as a BankcardTransactionResponse is presently not returned
            If TypeOf _Response.Response Is BankcardTransactionResponse Then
            End If
            If TypeOf _Response.Response Is BankcardCaptureResponse Then
                'BankcardCaptureResponse
                Return ProcessBankcardCaptureResponse(_Response)
            End If
            If TypeOf _Response.Response Is ElectronicCheckingTransactionResponse Then
                Return ProcessElectronicCheckingTransactionResponse(_Response)
            End If
            If TypeOf _Response.Response Is ElectronicCheckingCaptureResponse Then
                Return ProcessElectronicCheckingCaptureResponse(_Response)
            End If
            Return ""
        End Function

        Private Function ProcessBankcardTransactionResponsePro(ByVal _Response As ResponseDetails) As String
            Dim _BCResponse As New BankcardTransactionResponsePro()
            _BCResponse = DirectCast(_Response.Response, BankcardTransactionResponsePro)
            Dim strMessage As String = ""

            'Note : IMPORTANT Always verify the approved amount was the same as the requested approval amount for "AuthorizeAndCapture" as well as "Authorize" 
            If _Response.TransactionType = "AuthorizeAndCapture" Or _Response.TransactionType = "Authorize" Then

                If Not _Response.Verbose Then
                    ' In this case don't present to the user all of the data. 
                    If _BCResponse.Status = Status.Successful Then
                        'The transaction was approved
                        'NOTE : Please reference the developers guide for a more complete explination of the return fields
                        'Note Highly recommended to save
                        'The unique id of the transaction. TransactionId is required for all subsequent transactions such as Return, Undo, etc.
                        'Must be stored with the TransactionId in order to identify which merchant sent which transaction. Required to support multi-merchant.
                        'Note Optional but recommended to save
                        'Status code generated by the Service Provider. This code should be displayed to the user as verification of the transaction.
                        'Explains the StatusCode which is generated by the Service Provider. This message should be displayed to the user as verification of the transaction.
                        'A value returned when a transaction is approved. This value should be printed on the receipt, and also recorded for every off-line transaction, such as a voice authorization. This same data element and value must be provided during settlement. Required.
                        'Specifies the authorization amount of the transaction. This is the actual amount authorized.
                        strMessage = "Your '" & _Response.TransactionType & "' transaction was APPROVED" & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId & vbCr & vbLf & "MerchantProfileId : " & _Response.MerchantProfileId & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage & vbCr & vbLf & "ApprovalCode : " & _BCResponse.ApprovalCode & vbCr & vbLf & "Amount : " & _BCResponse.Amount
                    End If
                    If _BCResponse.Status = Status.Failure Then
                        'The transaction was declined
                        'NOTE : Please reference the developers guide for a more complete explination of the return fields
                        'Note Highly recommended to save
                        'The unique id of the transaction. TransactionId is required for all subsequent transactions such as Return, Undo, etc.
                        'Must be stored with the TransactionId in order to identify which merchant sent which transaction. Required to support multi-merchant.
                        'Note Optional but recommended to save
                        'Status code generated by the Service Provider. This code should be displayed to the user as verification of the transaction.
                        'Explains the StatusCode which is generated by the Service Provider. This message should be displayed to the user as verification of the transaction.
                        strMessage = "Your '" & _Response.TransactionType & "' transaction was DECLINED" & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId & vbCr & vbLf & "MerchantProfileId : " & _Response.MerchantProfileId & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage
                    End If
                    Return strMessage
                End If
            End If
            If _BCResponse.Status = Status.Successful Then
                'The transaction was approved
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                'The unique id of the transaction. TransactionId is required for all subsequent transactions such as Return, Undo, etc.
                'Must be stored with the TransactionId in order to identify which merchant sent which transaction. Required to support multi-merchant.
                'Note Highly recommended to save if Tokenization will be used
                '+ "\r\nPaymentAccountDataToken : " + _BCResponse.PaymentAccountDataToken //If tokenization purchased this field represents the actual token returned in the transaction for future use.
                'Note Optional but recommended to save
                'Status code generated by the Service Provider. This code should be displayed to the user as verification of the transaction.
                'Explains the StatusCode which is generated by the Service Provider. This message should be displayed to the user as verification of the transaction.
                'A value returned when a transaction is approved. This value should be printed on the receipt, and also recorded for every off-line transaction, such as a voice authorization. This same data element and value must be provided during settlement. Required.
                'Specifies the authorization amount of the transaction. This is the actual amount authorized.
                'Note Optional but recommended if AVS is supported
                '+ "\r\nAVSResult ActualResult : " + _BCResponse.AVSResult.ActualResult //Specifies the actual result of AVS from the Service Provider.
                '+ "\r\nAVSResult AddressResult : " + _BCResponse.AVSResult.AddressResult //Specifies the result of AVS as it pertains to Address matching
                '+ "\r\nAVSResult PostalCodeResult : " + _BCResponse.AVSResult.PostalCodeResult //Specifies the result of AVS as it pertains to Postal Code matching
                'Note Optional but recommended if CV data is supported
                'Response code returned by the card issuer indicating the result of Card Verification (CVV2/CVC2/CID).
                'Note Optional
                'A unique ID used to identify a specific batch settlement                
                'Indicates downgrade reason.
                'Fee amount charged for the transaction. 
                'Fee amount charged for the transaction.
                'Specifies whether resubmission is supported for PIN Debit transactions.
                '+ "\r\nSettlementDate : " + _BCResponse.SettlementDate //Settlement date. Conditional, if present in the authorization response, this same data element and value must be provided during settlement
                strMessage = "Your '" & _Response.TransactionType & "' transaction was APPROVED" & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId & vbCr & vbLf & "MerchantProfileId : " & _Response.MerchantProfileId & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage & vbCr & vbLf & "ApprovalCode : " & _BCResponse.ApprovalCode & vbCr & vbLf & "Amount : " & _BCResponse.Amount & vbCr & vbLf & "CVResult : " & _BCResponse.CVResult & vbCr & vbLf & "BatchId : " & _BCResponse.BatchId & vbCr & vbLf & "DowngradeCode : " & _BCResponse.DowngradeCode & vbCr & vbLf & "FeeAmount : " & _BCResponse.FeeAmount & vbCr & vbLf & "FinalBalance : " & _BCResponse.FinalBalance & vbCr & vbLf & "Resubmit : " & _BCResponse.Resubmit & vbCr & vbLf & "ServiceTransactionId : " & _BCResponse.ServiceTransactionId
            End If
            If _BCResponse.Status = Status.Failure Then
                'The transaction was declined
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                'The unique id of the transaction. TransactionId is required for all subsequent transactions such as Return, Undo, etc.
                'Must be stored with the TransactionId in order to identify which merchant sent which transaction. Required to support multi-merchant.
                'Note Optional but recommended to save
                'Status code generated by the Service Provider. This code should be displayed to the user as verification of the transaction.
                'Explains the StatusCode which is generated by the Service Provider. This message should be displayed to the user as verification of the transaction.
                'Note Optional but recommended if CV data is supported
                'Response code returned by the card issuer indicating the result of Card Verification (CVV2/CVC2/CID).
                'Note Optional
                strMessage = "Your '" & _Response.TransactionType & "' transaction was DECLINED" & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId & vbCr & vbLf & "MerchantProfileId : " & _Response.MerchantProfileId & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage & vbCr & vbLf & "CVResult : " & _BCResponse.CVResult & vbCr & vbLf & "ServiceTransactionId : " & _BCResponse.ServiceTransactionId
            End If
            Return strMessage
        End Function

        Private Function ProcessBankcardCaptureResponse(ByVal _Response As ResponseDetails) As String
            Dim _BCResponse As New BankcardCaptureResponse()
            _BCResponse = DirectCast(_Response.Response, BankcardCaptureResponse)

            Dim strResponseMessage As String = ""

            If Not _Response.Verbose Then
                ' In this case don't present to the user all of the data. 
                If _BCResponse.Status = Status.Successful Then
                    'The transaction was approved
                    'NOTE : Please reference the developers guide for a more complete explination of the return fields
                    'Note Highly recommended to save
                    If _BCResponse.TransactionId IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId
                    End If
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                    'Note Optional but recommended to save
                    If _BCResponse.StatusCode IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode
                    End If
                    If _BCResponse.StatusMessage IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage
                    End If

                    strResponseMessage = "Your transaction was APPROVED" & vbCr & vbLf & strResponseMessage
                End If
                If _BCResponse.Status = Status.Failure Then
                    'The transaction was declined
                    'NOTE : Please reference the developers guide for a more complete explination of the return fields
                    'Note Highly recommended to save
                    If _BCResponse.TransactionId IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId
                    End If
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                    'Note Optional but recommended to save
                    If _BCResponse.StatusCode IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode
                    End If
                    If _BCResponse.StatusMessage IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage
                    End If

                    strResponseMessage = "Your transaction was DECLINED" & vbCr & vbLf & strResponseMessage
                End If
                Return strResponseMessage
            End If
            If _BCResponse.Status = Status.Successful Then
                'The transaction was approved
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                If _BCResponse.TransactionId IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId
                End If
                strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                'Note Optional but recommended to save
                If _BCResponse.StatusCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode
                End If
                If _BCResponse.StatusMessage IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage
                End If
                'Note Optional data about the batch
                If _BCResponse.BatchId IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Batch Id : " & _BCResponse.BatchId
                End If
                If _BCResponse.TransactionSummaryData IsNot Nothing Then
                    If _BCResponse.TransactionSummaryData.CashBackTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Cash Back Totals " & vbCr & vbLf & "  Count : " & _BCResponse.TransactionSummaryData.CashBackTotals.Count & vbCr & vbLf & "  Net Amount : " & _BCResponse.TransactionSummaryData.CashBackTotals.NetAmount
                    End If
                    If _BCResponse.TransactionSummaryData.NetTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Net Totals " & vbCr & vbLf & "  Count : " & _BCResponse.TransactionSummaryData.NetTotals.Count & vbCr & vbLf & "  Net Amount : " & _BCResponse.TransactionSummaryData.NetTotals.NetAmount
                    End If
                    If _BCResponse.TransactionSummaryData.PINDebitReturnTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "PINDebit Return Totals " & vbCr & vbLf & "  Count : " & _BCResponse.TransactionSummaryData.PINDebitReturnTotals.Count & vbCr & vbLf & "  Net Amount : " & _BCResponse.TransactionSummaryData.PINDebitReturnTotals.NetAmount
                    End If
                    If _BCResponse.TransactionSummaryData.PINDebitSaleTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "PINDebit Sale Totals " & vbCr & vbLf & "  Count : " & _BCResponse.TransactionSummaryData.PINDebitSaleTotals.Count & vbCr & vbLf & "  Net Amount : " & _BCResponse.TransactionSummaryData.PINDebitSaleTotals.NetAmount
                    End If
                    If _BCResponse.TransactionSummaryData.ReturnTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Return Totals " & vbCr & vbLf & "  Count : " & _BCResponse.TransactionSummaryData.ReturnTotals.Count & vbCr & vbLf & "  Net Amount : " & _BCResponse.TransactionSummaryData.ReturnTotals.NetAmount
                    End If
                    If _BCResponse.TransactionSummaryData.SaleTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Sale Totals " & vbCr & vbLf & "  Count : " & _BCResponse.TransactionSummaryData.SaleTotals.Count & vbCr & vbLf & "  Net Amount : " & _BCResponse.TransactionSummaryData.SaleTotals.NetAmount
                    End If
                    If _BCResponse.TransactionSummaryData.VoidTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Void Totals " & vbCr & vbLf & "  Count : " & _BCResponse.TransactionSummaryData.VoidTotals.Count & vbCr & vbLf & "  Net Amount : " & _BCResponse.TransactionSummaryData.VoidTotals.NetAmount
                    End If
                End If
                strResponseMessage = "Your transaction was APPROVED" & vbCr & vbLf & strResponseMessage
            End If
            If _BCResponse.Status = Status.Failure Then
                'The transaction was declined
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                If _BCResponse.TransactionId IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _BCResponse.TransactionId
                End If
                strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                'Note Optional but recommended to save
                If _BCResponse.StatusCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _BCResponse.StatusCode
                End If
                If _BCResponse.StatusMessage IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _BCResponse.StatusMessage
                End If
                'Note Optional

                strResponseMessage = "Your transaction was DECLINED" & vbCr & vbLf & strResponseMessage
            End If
            If _BCResponse.Status = Status.NotSet Then
                'The transaction was declined
                strResponseMessage = "No Transactions found for settlement"
            End If
            Return strResponseMessage
        End Function

        Private Function ProcessElectronicCheckingTransactionResponse(ByVal _Response As ResponseDetails) As String
            Dim _ECKResponse As New ElectronicCheckingTransactionResponse()
            _ECKResponse = DirectCast(_Response.Response, ElectronicCheckingTransactionResponse)

            Dim strResponseMessage As String = ""

            If _ECKResponse.Status = Status.Successful Then
                'The transaction was approved
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                If _ECKResponse.TransactionId IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _ECKResponse.TransactionId
                End If
                strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                'Note Optional but recommended to save
                If _ECKResponse.StatusCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _ECKResponse.StatusCode
                End If
                If _ECKResponse.StatusMessage IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _ECKResponse.StatusMessage
                End If
                'Note Optional data about the batch
                If _ECKResponse.ACHCapable <> Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ACHCapable : " & _ECKResponse.ACHCapable
                End If
                'Indicates if the customer's account will accept ACH transactions. Returned only on QueryAccount() transactions.
                If _ECKResponse.Amount <> Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Amount : " & _ECKResponse.Amount
                End If
                If _ECKResponse.ApprovalCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ApprovalCode : " & _ECKResponse.ApprovalCode
                End If
                'A code provided when a transaction is approved.
                If _ECKResponse.ModifiedAccountNumber IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ModifiedAccountNumber : " & _ECKResponse.ModifiedAccountNumber
                End If
                'Indicates the corrected account number that should be used for electronic check processing
                If _ECKResponse.ModifiedRoutingNumber IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ModifiedRoutingNumber : " & _ECKResponse.ModifiedRoutingNumber
                End If
                'Indicates the corrected 9-digit bank routing number that should be used for electronic check processing.
                If _ECKResponse.ReturnInformation IsNot Nothing Then
                    If _ECKResponse.ReturnInformation.ReturnCode IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "ReturnCode : " & _ECKResponse.ReturnInformation.ReturnCode
                    End If
                    'Code that indicates why the transaction was returned.
                    If _ECKResponse.ReturnInformation.ReturnDate <> Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "ReturnDate : " & _ECKResponse.ReturnInformation.ReturnDate
                    End If
                    'The date the transaction was returned by the bank. 
                    If _ECKResponse.ReturnInformation.ReturnReason IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "ReturnReason : " & _ECKResponse.ReturnInformation.ReturnReason
                        'Reason that indicates why the transaction was returned. 
                    End If
                End If
                If _ECKResponse.SubmitDate <> Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "SubmitDate : " & _ECKResponse.SubmitDate
                End If
                'The date the transaction was submitted to the bank.
                strResponseMessage = "Your transaction was APPROVED" & vbCr & vbLf & strResponseMessage
            End If
            If _ECKResponse.Status = Status.Failure Then
                'The transaction was declined
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                If _ECKResponse.TransactionId IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _ECKResponse.TransactionId
                End If
                strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                'Note Optional but recommended to save
                If _ECKResponse.StatusCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _ECKResponse.StatusCode
                End If
                If _ECKResponse.StatusMessage IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _ECKResponse.StatusMessage
                End If
                'Note Optional
                If _ECKResponse.ACHCapable <> Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ACHCapable : " & _ECKResponse.ACHCapable
                End If
                'Indicates if the customer's account will accept ACH transactions. Returned only on QueryAccount() transactions.
                If _ECKResponse.Amount <> Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Amount : " & _ECKResponse.Amount
                End If
                If _ECKResponse.ApprovalCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ApprovalCode : " & _ECKResponse.ApprovalCode
                End If
                'A code provided when a transaction is approved.
                If _ECKResponse.ModifiedAccountNumber IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ModifiedAccountNumber : " & _ECKResponse.ModifiedAccountNumber
                End If
                'Indicates the corrected account number that should be used for electronic check processing
                If _ECKResponse.ModifiedRoutingNumber IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "ModifiedRoutingNumber : " & _ECKResponse.ModifiedRoutingNumber
                End If
                'Indicates the corrected 9-digit bank routing number that should be used for electronic check processing.
                If _ECKResponse.ReturnInformation IsNot Nothing Then
                    If _ECKResponse.ReturnInformation.ReturnCode IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "ReturnCode : " & _ECKResponse.ReturnInformation.ReturnCode
                    End If
                    'Code that indicates why the transaction was returned.
                    If _ECKResponse.ReturnInformation.ReturnDate <> Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "ReturnDate : " & _ECKResponse.ReturnInformation.ReturnDate
                    End If
                    'The date the transaction was returned by the bank. 
                    If _ECKResponse.ReturnInformation.ReturnReason IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "ReturnReason : " & _ECKResponse.ReturnInformation.ReturnReason
                        'Reason that indicates why the transaction was returned. 
                    End If
                End If
                If _ECKResponse.SubmitDate <> Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "SubmitDate : " & _ECKResponse.SubmitDate
                End If
                'The date the transaction was submitted to the bank.
                strResponseMessage = "Your transaction was DECLINED" & vbCr & vbLf & strResponseMessage
            End If
            If _ECKResponse.Status = Status.NotSet Then
                'The transaction was declined
                strResponseMessage = "No Transactions found for settlement"
            End If
            Return strResponseMessage
        End Function

        Private Function ProcessElectronicCheckingCaptureResponse(ByVal _Response As ResponseDetails) As String
            Dim _ECKResponse As New ElectronicCheckingCaptureResponse()
            _ECKResponse = DirectCast(_Response.Response, ElectronicCheckingCaptureResponse)

            Dim strResponseMessage As String = ""

            If _ECKResponse.Status = Status.Successful Then
                'The transaction was approved
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                If _ECKResponse.TransactionId IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _ECKResponse.TransactionId
                End If
                strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                'Note Optional but recommended to save
                If _ECKResponse.StatusCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _ECKResponse.StatusCode
                End If
                If _ECKResponse.StatusMessage IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _ECKResponse.StatusMessage
                End If
                'Note Optional data about the batch
                If _ECKResponse.SummaryData IsNot Nothing Then
                    If _ECKResponse.SummaryData.CreditTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Credit Totals " & vbCr & vbLf & "  Count : " & _ECKResponse.SummaryData.CreditTotals.Count & vbCr & vbLf & "  Net Amount : " & _ECKResponse.SummaryData.CreditTotals.NetAmount
                    End If
                    If _ECKResponse.SummaryData.DebitTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Debit Totals " & vbCr & vbLf & "  Count : " & _ECKResponse.SummaryData.DebitTotals.Count & vbCr & vbLf & "  Net Amount : " & _ECKResponse.SummaryData.DebitTotals.NetAmount
                    End If
                    If _ECKResponse.SummaryData.NetTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Net Totals " & vbCr & vbLf & "  Count : " & _ECKResponse.SummaryData.NetTotals.Count & vbCr & vbLf & "  Net Amount : " & _ECKResponse.SummaryData.NetTotals.NetAmount
                    End If
                    If _ECKResponse.SummaryData.VoidTotals IsNot Nothing Then
                        strResponseMessage = strResponseMessage & vbCr & vbLf & "Void Totals " & vbCr & vbLf & "  Count : " & _ECKResponse.SummaryData.VoidTotals.Count & vbCr & vbLf & "  Net Amount : " & _ECKResponse.SummaryData.VoidTotals.NetAmount
                    End If
                End If
                strResponseMessage = "Your transaction was APPROVED" & vbCr & vbLf & strResponseMessage
            End If
            If _ECKResponse.Status = Status.Failure Then
                'The transaction was declined
                'NOTE : Please reference the developers guide for a more complete explination of the return fields
                'Note Highly recommended to save
                If _ECKResponse.TransactionId IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "TransactionId : " & _ECKResponse.TransactionId
                End If
                strResponseMessage = strResponseMessage & vbCr & vbLf & "Merchant Profile Id : " & _Response.MerchantProfileId
                'Note Optional but recommended to save
                If _ECKResponse.StatusCode IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Code : " & _ECKResponse.StatusCode
                End If
                If _ECKResponse.StatusMessage IsNot Nothing Then
                    strResponseMessage = strResponseMessage & vbCr & vbLf & "Status Message : " & _ECKResponse.StatusMessage
                End If
                'Note Optional

                strResponseMessage = "Your transaction was DECLINED" & vbCr & vbLf & strResponseMessage
            End If
            If _ECKResponse.Status = Status.NotSet Then
                'The transaction was declined
                strResponseMessage = "No Transactions found for settlement"
            End If
            Return strResponseMessage
        End Function

#End Region

#Region "Extras"

        Public Function ImageFromBase64String(ByVal base64 As String) As Image
            Dim memory As New MemoryStream(Convert.FromBase64String(base64))
            Dim result As Image = Image.FromStream(memory)
            memory.Close()
            Return result
        End Function

        Public Function RetrieveServiceKeyFromIdentityToken(ByVal identityToken As String) As String
            Try
                Dim clearToken As [String] = Encoding.UTF8.GetString(Convert.FromBase64String(identityToken))

                'Now try and retrieve the Service Key from the XML
                Dim doc As New XmlDocument()
                doc.LoadXml(clearToken)
                Dim xnav As XPathNavigator = doc.CreateNavigator()

                Dim manager As New XmlNamespaceManager(xnav.NameTable)
                manager.AddNamespace("SK", "urn:oasis:names:tc:SAML:1.0:assertion")

                Dim node As XPathNavigator = xnav.SelectSingleNode("//SK:Attribute[@AttributeName='SAK']", manager)
                Return node.Value
            Catch ex As Exception
                Return ""
            End Try
        End Function

#End Region

#Region "Class Properties"
        Public Property ApplicationProfileId() As String
            Get
                Return _applicationProfileId
            End Get
            Set(ByVal value As String)
                _applicationProfileId = value.Trim()
            End Set
        End Property
        Public Property ServiceID() As String
            Get
                Return _serviceId
            End Get
            Set(ByVal value As String)
                _serviceId = value
            End Set
        End Property
        Public Property WorkflowID() As String
            Get
                Return _workflowId
            End Get
            Set(ByVal value As String)
                _workflowId = value
            End Set
        End Property
        Public Property MerchantProfileId() As String
            Get
                Return _merchantProfileId
            End Get
            Set(ByVal value As String)
                _merchantProfileId = value
            End Set
        End Property
        Public Property SessionToken() As String
            Get
                Return _sessionToken
            End Get
            Set(ByVal value As String)
                _sessionToken = value
            End Set
        End Property
        Public Property DelegatedSessionToken() As String
            Get
                Return _delegatedSessionToken
            End Get
            Set(ByVal value As String)
                _delegatedSessionToken = value
            End Set
        End Property
        Public Property DelegatedServiceKey() As String
            Get
                Return _delegatedServiceKey
            End Get
            Set(ByVal value As String)
                _delegatedServiceKey = value
            End Set
        End Property
        Public Property IdentityToken() As String
            Get
                Return _identityToken
            End Get
            Set(ByVal value As String)
                _identityToken = value.Trim()
            End Set
        End Property
        Public Property ServiceKey() As String
            Get
                Return _serviceKey
            End Get
            Set(ByVal value As String)
                _serviceKey = value
            End Set
        End Property
        Public Property CredUserName() As String
            Get
                Return _credUserName
            End Get
            Set(ByVal value As String)
                _credUserName = value
            End Set
        End Property
        Public Property ServiceInformation() As ServiceInformation
            Get
                Return _serviceInformation
            End Get
            Set(ByVal value As ServiceInformation)
                _serviceInformation = value
            End Set
        End Property
        Public Property CredPassword() As String
            Get
                Return _credPassword
            End Get
            Set(ByVal value As String)
                _credPassword = value
            End Set
        End Property
        Public Property Cwssic() As CWSServiceInformationClient
            Get
                Return _cwssic
            End Get
            Set(ByVal value As CWSServiceInformationClient)
                _cwssic = value
            End Set
        End Property
        Public Property Cwsbc() As CwsTransactionProcessingClient
            Get
                Return _cwsbc
            End Get
            Set(ByVal value As CwsTransactionProcessingClient)
                _cwsbc = value
            End Set
        End Property
        Public Property Tmsoc() As TMSOperationsClient
            Get
                Return _tmsoc
            End Get
            Set(ByVal value As TMSOperationsClient)
                _tmsoc = value
            End Set
        End Property
#End Region

    End Class

#Region "Extra Classes"

    <Serializable> _
    Public Class PersistAndCacheSettings
        Public ApplicationProfileId As String
        Public ServiceId As String
        Public WorkflowId As String
        Public MerchantProfileId As String
        Public EncryptedIdentityToken As Boolean
        Public IdentityToken As String
        Public Sub New(ByVal applicationProfileId As String, ByVal serviceId As String, ByVal workflowId As String, ByVal merchantProfileId As String, ByVal encryptedIdentityToken As Boolean, ByVal identityToken As String)
            Me.ApplicationProfileId = applicationProfileId
            Me.ServiceId = serviceId
            Me.WorkflowId = workflowId
            Me.MerchantProfileId = merchantProfileId
            Me.EncryptedIdentityToken = encryptedIdentityToken
            Me.IdentityToken = identityToken
        End Sub
    End Class

    Public Class TrackFromMSRSwipe
        Public Track1Data As String
        Public Track2Data As String

        Public Sub New(ByVal track1Data__1 As String, ByVal track2Data__2 As String)
            Track1Data = track1Data__1
            Track2Data = track2Data__2
        End Sub
    End Class

    Public Class ResponseDetails
        Public TxnAmount As Decimal
        Public Response As Response
        Public TransactionType As String
        Public WorkflowId As String
        Public MerchantProfileId As String
        Public Verbose As Boolean
        Public CardType As TypeCardType
        Public MaskedPan As String

        Public Sub New(ByVal txnAmount As Decimal, ByVal response As Response, ByVal transactionType As String, ByVal workflowId As String, ByVal merchantProfileId As String, ByVal verbose As Boolean, ByVal cardType As TypeCardType, ByVal maskedPan As String)
            Me.TxnAmount = txnAmount
            Me.Response = response
            Me.TransactionType = transactionType
            Me.WorkflowId = workflowId
            Me.MerchantProfileId = merchantProfileId
            Me.Verbose = verbose
            Me.CardType = TypeCardType.NotSet
            Me.MaskedPan = ""
        End Sub
        Public Overrides Function ToString() As String
            Return "<Orig Type:" & TransactionType & ">" & TxnAmount & " " & Response.TransactionId & " [Status : " & Response.Status & "]" & " [Capture State : " & Response.CaptureState & "]" & " [Transaction State : " & Response.TransactionState & "] " & Date.Now
            '+ " [Status Code : " + Response.StatusCode + "]"
            '+ " [Status Message : " + Response.StatusMessage + "]"
        End Function
    End Class

    Public Enum TransactionType As Integer
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        AuthorizeAndCapture = 0
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        Authorize = 1
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        Capture = 2
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        CaptureAll = 3
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        CaptureSelective = 4
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        ReturnById = 5
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        [Return] = 6
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        Adjust = 7
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        Undo = 8
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        QueryAccount = 9
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        Verify = 10
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        CaptureAllAsync = 11
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        CaptureSelectiveAsync = 12
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        ManageAccount = 13
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        ManageAccountById = 14
        <System.Runtime.Serialization.EnumMemberAttribute()> _
        RequestTransaction = 15
    End Enum

#End Region
End Namespace

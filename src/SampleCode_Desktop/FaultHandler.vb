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

Imports System.ServiceModel
Imports System.ServiceModel.FaultException
Imports SvcInfo = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.SvcInfo
Imports Txn = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn
Imports DataServices = SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.TMS

Namespace FaultHandler
    Public Class FaultHandler
        Public Function handleSvcInfoFault(ByVal _ex As Exception, ByRef _strErrorID As String, ByRef _strErrorMessage As String) As Boolean
            'Note : that the boolean indicates if the fault was handled by this class
            _strErrorID = ""
            _strErrorMessage = ""

            '#Region "AuthorizationFault"
            Try

                If DirectCast(_ex, FaultException(Of SvcInfo.AuthenticationFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.AuthenticationFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.AuthenticationFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            ''#Region "ClaimNotFoundFault"
            'Try
            '    If DirectCast(_ex, FaultException(Of SvcInfo.ClaimNotFoundFault)).Detail IsNot Nothing Then
            '        _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.ClaimNotFoundFault)).Detail.ErrorID.ToString()
            '        _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.ClaimNotFoundFault)).Detail.ProblemType
            '        'Positive Match
            '        Return True
            '    End If
            'Catch
            'End Try
            ''#End Region

            '#Region "CWSValidationResultFault"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.CWSValidationResultFault)).Detail IsNot Nothing Then
                    For Each [error] As SvcInfo.CWSValidationErrorFault In DirectCast(_ex, FaultException(Of SvcInfo.CWSValidationResultFault)).Detail.Errors
                        _strErrorMessage = (_strErrorMessage + [error].RuleKey & " : ") + [error].RuleMessage & vbCr & vbLf & vbCr & vbLf
                    Next
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "AuthenticationFault"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.AuthenticationFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.AuthenticationFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.AuthenticationFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "STSUnavailableFault"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.STSUnavailableFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.STSUnavailableFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.STSUnavailableFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "ExpiredTokenFault"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.ExpiredTokenFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.ExpiredTokenFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.ExpiredTokenFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "InvalidTokenFault"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.InvalidTokenFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.InvalidTokenFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.InvalidTokenFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSServiceInformationUnavailableFault"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.CWSServiceInformationUnavailableFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.CWSServiceInformationUnavailableFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.CWSServiceInformationUnavailableFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            'Additional Faults called out in the data contract

            '#Region "CWSValidationErrorFault"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.CWSValidationErrorFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of SvcInfo.CWSValidationErrorFault)).Detail.RuleKey
                    _strErrorMessage = DirectCast(_ex, FaultException(Of SvcInfo.CWSValidationErrorFault)).Detail.RuleMessage
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "Presently Unsupported Faults"
            Try
                If DirectCast(_ex, FaultException(Of SvcInfo.BadAttemptThresholdExceededFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "BadAttemptThresholdExceededFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.GeneratePasswordFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "GeneratePasswordFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.InvalidEmailFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "InvalidEmailFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.LockedByAdminFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "LockedByAdminFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.OneTimePasswordFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "OneTimePasswordFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.PasswordExpiredFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "PasswordExpiredFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.PasswordInvalidFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "PasswordInvalidFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.SendEmailFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "SendEmailFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.STSUnavailableFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "STSUnavailableFault thrown however not handled by code"
                End If
                If DirectCast(_ex, FaultException(Of SvcInfo.UserNotFoundFault)).Detail IsNot Nothing Then
                    _strErrorMessage = "UserNotFoundFault thrown however not handled by code"
                End If
            Catch
            End Try
            '#End Region

            'As one last check look at the GeneralFaults
            If GeneralFaults(_ex, _strErrorID, _strErrorMessage) Then
                Return True
            End If
            'Positive Match
            _strErrorMessage = "An unhandled fault was thrown " & vbCr & vbLf & "Message : " & _ex.Message
            Return False
            'In this case unable to match fault so return false. 
        End Function

        Public Function handleTxnFault(ByVal _ex As Exception, ByRef _strErrorID As String, ByRef _strErrorMessage As String) As Boolean
            'Note : that the boolean indicates if the fault was handled by this class
            _strErrorID = ""
            _strErrorMessage = ""

            '#Region "CWSConnectionFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSConnectionFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSConnectionFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSConnectionFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSExtendedDataNotSupportedFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSExtendedDataNotSupportedFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSExtendedDataNotSupportedFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSExtendedDataNotSupportedFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSInvalidOperationFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSInvalidOperationFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSInvalidOperationFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSInvalidOperationFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSOperationNotSupportedFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSOperationNotSupportedFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSOperationNotSupportedFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSOperationNotSupportedFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSValidationResultFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSValidationResultFault)).Detail IsNot Nothing Then
                    For Each [error] As Txn.CWSValidationErrorFault In DirectCast(_ex, FaultException(Of Txn.CWSValidationResultFault)).Detail.Errors
                        _strErrorMessage = (_strErrorMessage + [error].RuleKey & " : ") + [error].RuleMessage & vbCr & vbLf
                    Next
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "AuthenticationFault"

            Try
                If DirectCast(_ex, FaultException(Of Txn.AuthenticationFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.AuthenticationFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.AuthenticationFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "ExpiredTokenFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.ExpiredTokenFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.ExpiredTokenFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.ExpiredTokenFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "InvalidTokenFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.InvalidTokenFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.InvalidTokenFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.InvalidTokenFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSTransactionServiceUnavailableFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSTransactionServiceUnavailableFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSTransactionServiceUnavailableFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSTransactionServiceUnavailableFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSInvalidMessageFormatFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSInvalidMessageFormatFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSInvalidMessageFormatFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSInvalidMessageFormatFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSInvalidServiceInformationFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSInvalidServiceInformationFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSInvalidServiceInformationFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSInvalidServiceInformationFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSTransactionAlreadySettledFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSTransactionAlreadySettledFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSTransactionAlreadySettledFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSTransactionAlreadySettledFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSTransactionFailedFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSTransactionFailedFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSTransactionFailedFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSTransactionFailedFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            'Additional Faults called out in the data contract
            '#Region "CWSValidationErrorFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSValidationErrorFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSValidationErrorFault)).Detail.RuleKey
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSValidationErrorFault)).Detail.RuleMessage
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "CWSDeserializationFault"
            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSDeserializationFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSDeserializationFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSDeserializationFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try

            '#End Region

            'As one last check look at the GeneralFaults
            If GeneralFaults(_ex, _strErrorID, _strErrorMessage) Then
                Return True
            End If
            'Positive Match
            _strErrorMessage = "An unhandled fault was thrown " & vbCr & vbLf & "Message : " & _ex.Message
            Return False
            'In this case unable to match fault so return false. 
        End Function

        Public Function handleTMSFault(ByVal _ex As Exception, ByRef _strErrorID As String, ByRef _strErrorMessage As String) As Boolean
            'Note : that the boolean indicates if the fault was handled by this class
            _strErrorID = ""
            _strErrorMessage = ""

            '#Region "AuthenticationFault"
            Try
                If DirectCast(_ex, FaultException(Of DataServices.AuthenticationFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of DataServices.AuthenticationFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of DataServices.AuthenticationFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "TMSOperationNotSupportedFault"
            Try
                If DirectCast(_ex, FaultException(Of DataServices.TMSOperationNotSupportedFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of DataServices.TMSOperationNotSupportedFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of DataServices.TMSOperationNotSupportedFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "TMSTransactionFailedFault"
            Try
                If DirectCast(_ex, FaultException(Of DataServices.TMSTransactionFailedFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of DataServices.TMSTransactionFailedFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of DataServices.TMSTransactionFailedFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "TMSUnknownServiceKeyFault"
            Try
                If DirectCast(_ex, FaultException(Of DataServices.TMSUnknownServiceKeyFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of DataServices.TMSUnknownServiceKeyFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of DataServices.TMSUnknownServiceKeyFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "ExpiredTokenFault"
            Try
                If DirectCast(_ex, FaultException(Of DataServices.ExpiredTokenFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of DataServices.ExpiredTokenFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of DataServices.ExpiredTokenFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "InvalidTokenFault"
            Try
                If DirectCast(_ex, FaultException(Of DataServices.InvalidTokenFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of DataServices.InvalidTokenFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of DataServices.InvalidTokenFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region

            '#Region "TMSUnavailableFault"
            Try
                If DirectCast(_ex, FaultException(Of DataServices.TMSUnavailableFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of DataServices.TMSUnavailableFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of DataServices.TMSUnavailableFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try
            '#End Region


            'As one last check look at the GeneralFaults
            If GeneralFaults(_ex, _strErrorID, _strErrorMessage) Then
                Return True
            End If
            'Positive Match
            _strErrorMessage = "An unhandled fault was thrown " & vbCr & vbLf & "Message : " & _ex.Message
            Return False
            'In this case unable to match fault so return false. 
        End Function

        Public Function GeneralFaults(ByVal _ex As Exception, ByRef _strErrorID As String, ByRef _strErrorMessage As String) As Boolean
            'Note : that the boolean indicates if the fault was handled by this class
            _strErrorID = ""
            _strErrorMessage = ""

            Try
                If DirectCast(_ex, FaultException(Of Txn.CWSFault)).Detail IsNot Nothing Then
                    _strErrorID = DirectCast(_ex, FaultException(Of Txn.CWSFault)).Detail.ErrorID.ToString()
                    _strErrorMessage = DirectCast(_ex, FaultException(Of Txn.CWSFault)).Detail.ProblemType
                    'Positive Match
                    Return True
                End If
            Catch
            End Try

            'No General faults found
            Return False
        End Function
    End Class
End Namespace

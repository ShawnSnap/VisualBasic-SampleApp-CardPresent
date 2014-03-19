#Region "DISCLAIMER"
' Copyright (c) 2013 EVO Payments International - All Rights Reserved.
' 
'  This software and documentation is subject to and made
'  available only pursuant to the terms of an executed license
'  agreement, and may be used only in accordance with the terms
'  of said agreement. This software may not, in whole or in part,
'  be copied, photocopied, reproduced, translated, or reduced to
'  any electronic medium or machine-readable form without
'  prior consent, in writing, from EVO Payments International, INC.
' 
'  Use, duplication or disclosure by the U.S. Government is subject
'  to restrictions set forth in an executed license agreement
'  and in subparagraph (c)(1) of the Commercial Computer
'  Software-Restricted Rights Clause at FAR 52.227-19; subparagraph
'  (c)(1)(ii) of the Rights in Technical Data and Computer Software
'  clause at DFARS 252.227-7013, subparagraph (d) of the Commercial
'  Computer Software--Licensing clause at NASA FAR supplement
'  16-52.227-86; or their equivalent.
' 
'  Information in this software is subject to change without notice
'  and does not represent a commitment on the part of EVO Payments International.
' 
'  Sample Code is for reference Only and is intended to be used for educational purposes. It's the responsibility of 
'  the software company to properly integrate into thier solution code that best meets thier production needs. 

#End Region ' DISCLAIMER

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports SampleCode_Desktop.schemas.evosnap.com.Ipc.General.WCF.Contracts.Common.External.Txn

Namespace SampleCode
    Partial Public Class Magensa
        Inherits Form

        Public _bct As BankcardTransaction
        Public TT As TestTriggers
        Public ProcessTransaction As Boolean
        Public ReadOnly Property MaskedPAN() As String
            Get
                Return TxtMaskedPAN.Text
            End Get
            'set
            '{
            '    TxtMaskedPAN.Text = value;
            '}
        End Property
        Public ReadOnly Property CardType() As TypeCardType
            Get
                Return CType(CboMagensaCardType.SelectedItem, TypeCardType)
            End Get
            'set
            '{
            '    (TypeCardType)CboMagensaCardType.SelectedItem = value;
            '}
        End Property

        Public Sub New()
            InitializeComponent()

            CboTriggerTests.Items.Add(New TestTriggers("10.00", "E860", "Magensa returned OK."))
            CboTriggerTests.Items.Add(New TestTriggers("10.05", "E860", "Magensa error number: Y001. No PAN Found in Track2 Data."))
            CboTriggerTests.Items.Add(New TestTriggers("10.10", "E860", "Magensa error number: Y091. Invalid KSID."))
            CboTriggerTests.Items.Add(New TestTriggers("10.15", "E860", "Magensa error number: Y093. Invalid MagnePrint."))
            CboTriggerTests.Items.Add(New TestTriggers("10.20", "E860", "Magensa error number: Y094. Invalid MagnePrint. Invalid transaction CRC/PAN."))
            CboTriggerTests.Items.Add(New TestTriggers("10.25", "E860", "Magensa error number: Y095. Error Scoring Card."))
            CboTriggerTests.Items.Add(New TestTriggers("10.30", "E860", "Magensa error number: Y096. Inactive MagnePrint reference."))
            CboTriggerTests.Items.Add(New TestTriggers("10.35", "E860", "Magensa error number: Y097. DUKPT KSN and counter is replayed."))
            CboTriggerTests.Items.Add(New TestTriggers("10.40", "E860", "Magensa error number: Y098. Problem Decrypting Data."))
            CboTriggerTests.Items.Add(New TestTriggers("10.45", "E860", "Magensa error number: Y099. Error Validating Credentials."))
            CboTriggerTests.Items.Add(New TestTriggers("10.50", "E898", "Magensa returned an invalid data error: <Insert Magensa StatusCode>. <Insert Magensa input validation error "))
            CboTriggerTests.Items.Add(New TestTriggers("10.55", "E899", "Magensa returned an unknown error.  <Insert Magensa StatusCode>. <StatusMsg>."))

            CboMagensaCardType.Sorted = True
            CboMagensaCardType.DataSource = System.Enum.GetValues(GetType(TypeCardType))
            CboMagensaCardType.SelectedIndex = -1
        End Sub

        Public Sub CallingForm(ByRef bct As BankcardTransaction)
            _bct = bct
            TxtAmount.Text = _bct.TransactionData.Amount.ToString()
        End Sub

        Private Sub CmdGenerateFields_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdGenerateFields.Click

            ' The below code is specific to the newer version of the MagTek Dynamag USB MSR
            ' It takes the raw swipe generated from the Dynamag to populate the correct lines below.
            Try
                If ChkPipeDelimited.Checked Then
                    Dim lines() As String = TxtTrackInformation.Text.Split("|"c)

                    If lines.Length < 13 Then
                        MessageBox.Show("No Magensa Swipes to use")
                    Else
                        Dim encryptedTrack2 As String = lines(3)
                        Dim encryptedMagnePrintData As String = lines(6)
                        Dim DUKPTserialNo As String = lines(9)
                        Dim magenPrintStatus As String = lines(5)
                        Dim deviceSerialNum As String = lines(7)
                        Dim _txtTrack2Masked As String = lines(0).Substring(lines(0).IndexOf(";") + 1).Replace("?", "").Trim()
                        'string pan = txtTrack2Masked.Substring(0, 16);
                        Dim track2() As String = _txtTrack2Masked.Split("="c)
                        Dim panTrack2 As String = track2(0)
                        Dim discTrack2 As String = track2(1)

                        'Get Masked Pan and CardType

                        Dim h As New HelperMethods()

                        Dim masklength As Integer = panTrack2.Length - 10
                        Dim count As Integer = 0
                        Dim maskingCount As String = panTrack2.Substring(0, 6)
                        Do
                            maskingCount &= "X"
                            count += 1
                        Loop While count < masklength

                        TxtMaskedPAN.Text = maskingCount & panTrack2.Substring(panTrack2.Length - 4, 4)

                        masklength = discTrack2.Length - 4
                        maskingCount = discTrack2.Substring(0, 4)
                        count = 0
                        Do
                            maskingCount &= "X"
                            count += 1
                        Loop While count < masklength

                        TxtTrack2Masked.Text = TxtMaskedPAN.Text & "=" & maskingCount

                        Try
                            CboMagensaCardType.SelectedItem = h.CardTypeLookup(panTrack2)
                        Catch
                        End Try

                        TxtMagnePrintData.Text = encryptedMagnePrintData
                        TxtDukptKeySerialNumber.Text = DUKPTserialNo
                        TxtTrack2EncryptedData.Text = encryptedTrack2
                        TxtMagnePrintStatus.Text = magenPrintStatus
                        TxtDeviceSerialNumber.Text = deviceSerialNum
                    End If
                Else
                    'StringReader strReader = new StringReader(TxtTrackData.Text);
                    Dim lines() As String = TxtTrackInformation.Text.Replace(vbCr, "").Split(ControlChars.Lf)

                    If lines.Length < 21 Then
                        MessageBox.Show("No Magensa Swipes to use")
                    Else

                        Dim encryptedTrack2 As String = lines(6).Substring(lines(6).IndexOf("=") + 1).Replace(" ", "")
                        Dim encryptedMagnePrintData As String = lines(12).Substring(lines(12).IndexOf("=") + 1).Replace(" ", "")
                        Dim DUKPTserialNo As String = lines(2).Substring(lines(2).IndexOf("=") + 1).Replace(" ", "")
                        Dim magenPrintStatus As String = lines(10).Substring(lines(10).IndexOf("=") + 1).Replace(" ", "")
                        Dim deviceSerialNum As String = lines(14).Substring(lines(14).IndexOf("=") + 2)

                        Dim _txtTrack2Masked As String = lines(18).Substring(lines(18).IndexOf(";") + 1).Replace("?", "").Trim()
                        Dim track2() As String = _txtTrack2Masked.Split("="c)
                        Dim panTrack2 As String = track2(0)
                        Dim discTrack2 As String = track2(1)

                        'Get Masked Pan and CardType
                        TxtTrack2Masked.Text = lines(18).Substring(lines(18).IndexOf("=") + 1).Replace(" ", "").Trim()
                        Dim h As New HelperMethods()

                        Dim masklength As Integer = panTrack2.Length - 8
                        Dim count As Integer = 0
                        Dim maskingCount As String = panTrack2.Substring(0, 4)
                        Do
                            maskingCount &= "X"
                            count += 1
                        Loop While count < masklength

                        TxtMaskedPAN.Text = maskingCount & panTrack2.Substring(panTrack2.Length - 4, 4)

                        masklength = discTrack2.Length - 4
                        maskingCount = discTrack2.Substring(0, 4)
                        count = 0
                        Do
                            maskingCount &= "X"
                            count += 1
                        Loop While count < masklength

                        TxtTrack2Masked.Text = TxtMaskedPAN.Text & "=" & maskingCount

                        Try
                            CboMagensaCardType.SelectedItem = h.CardTypeLookup(panTrack2)
                        Catch
                        End Try

                        TxtMagnePrintData.Text = encryptedMagnePrintData
                        TxtDukptKeySerialNumber.Text = DUKPTserialNo
                        TxtTrack2EncryptedData.Text = encryptedTrack2
                        TxtMagnePrintStatus.Text = magenPrintStatus
                        TxtDeviceSerialNumber.Text = deviceSerialNum
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub CmdUseValues_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdProcessMagensaTxn.Click
            If TxtMagnePrintData.Text.Length < 1 Or TxtDukptKeySerialNumber.Text.Length < 1 Or TxtTrack2EncryptedData.Text.Length < 1 Or TxtMagnePrintStatus.Text.Length < 1 Then
                MessageBox.Show("Required information is missing")
                Return
            End If

            _bct.TenderData.CardData = Nothing
            If _bct.TenderData.CardSecurityData Is Nothing Then
                _bct.TenderData.CardSecurityData = New CardSecurityData()
            End If

            _bct.TenderData.CardSecurityData.CVData = Nothing
            _bct.TenderData.CardSecurityData.CVDataProvided = CVDataProvided.NotSet
            _bct.TenderData.CardSecurityData.IdentificationInformation = TxtMagnePrintData.Text
            _bct.TenderData.SecurePaymentAccountData = TxtTrack2EncryptedData.Text
            _bct.TenderData.EncryptionKeyId = TxtDukptKeySerialNumber.Text
            _bct.TenderData.SwipeStatus = TxtMagnePrintStatus.Text
            _bct.TenderData.DeviceSerialNumber = TxtDeviceSerialNumber.Text
            _bct.TransactionData.EntryMode = EntryMode.Track2DataFromMSR
            ' Note Reference should be a unique value for each transaction being sent.
            _bct.TransactionData.Reference = "25"

            _bct.TransactionData.Amount = Convert.ToDecimal(TxtAmount.Text)
            If TxtScoreThreshold.Text.Length > 0 Then
                _bct.TransactionData.ScoreThreshold = TxtScoreThreshold.Text
            End If

            ProcessTransaction = True
            Me.Close()
        End Sub

        Private Sub CboTriggerTests_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CboTriggerTests.SelectedIndexChanged
            TT = CType(CboTriggerTests.SelectedItem, TestTriggers)
            TxtAmount.Text = TT.Trigger
        End Sub

        Private Sub CmdPopulateWithTestValues_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdPopulateWithTestValues.Click
            If ChkPipeDelimited.Checked Then
                ' The below information is from the latest version of the MagTek Dynamag USB MSR
                TxtTrackInformation.Text = "%B5499990001006781^TESTCARD/MC/NDCECOMMERCE^15120000000000000000?;5499990001006781=15120000000000000000?|0600|AE9F6AE3EBD5A16B0369884F57EAC1C5DA7C4BD34004BA81421E9BF7CA3C0F0494264E258128C078DF377F6E453A70E31B29DD624A02D41D9B04A5D575F2BE9FC927F06D85FADAE8|C126841EDE220A5FA3A1E147A6A83F813D53644E6082195DBDD29203AAD8B38447180B9E4902CE1B||61403000|914CEA90C623ED14B9DE35CDB3F05F74AC5ECD8F90A8C1A8AA6945C0895E05A718437CEBDCD8C1AA020FD4F1E4EE99E3D74A5850AB9034B7|B1CBB65090413AA|D956BFF98750C117|9011880B1CBB6500006B|1422||1000"
            Else
                TxtTrackInformation.Text = "Card Encode Type = ISO" & vbCrLf & vbCrLf & "DUKPT Key Serial Number = 9010010B0C247200001F" & vbCrLf & vbCrLf & "Track 1 Encrypted = CF BD 82 96 5A 66 FF C8 8D 51 2C 8D 1C 4B 1D B6 7C 45 5B 6C 1E 36 17 6A 20 26 BF 27 94 2F C5 71 7D 89 B1 BE A7 9B 88 14 26 47 9C 51 FA 30 1C 2D 99 F6 83 78 A0 66 4C 0D 79 6A 08 36 95 F6 1F 30 " & vbCrLf & vbCrLf & "Track 2 Encrypted = EA D1 C2 F9 6D DE 13 1B 35 6B 2C 6C 98 25 D3 68 C9 C6 F7 26 84 75 72 FC BC 78 81 18 C4 9F 46 F7 87 6E A8 7A 71 75 E4 7A " & vbCrLf & vbCrLf & "Track 3 Encrypted = " & vbCrLf & vbCrLf & "MagnePrint Status (hex) = 00304061" & vbCrLf & vbCrLf & "MagnePrint Data (hex) = A3 63 34 A6 4D C8 A5 35 67 EE 0F 28 AD B6 5E EB F1 5D 2B 22 AB 39 2F C2 DC 79 E3 4A A4 90 C3 6E 6E C1 90 A1 F3 E5 19 63 8F CC AA F0 37 23 CA CA 05 84 43 1C AE 3E 1B B1 " & vbCrLf & vbCrLf & "Device Serial Number = B0C2472071812AA" & vbCrLf & vbCrLf & "Track 1 Masked = %B4111000010001111^IPCOMMERCE/TESTCARD^13120000000000000000000?" & vbCrLf & vbCrLf & "Track 2 Masked = ;4111000010001111=13120000000000000000?" & vbCrLf & vbCrLf & "Encrypted Session ID (Hex) = 14 1B 21 95 AB 89 D8 C9" & vbCrLf
            End If

        End Sub

        Private Sub CmdClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CmdClose.Click
            Me.Close()
        End Sub

        Private Sub lnkManageAccountById_Click(sender As Object, e As EventArgs) Handles lnkManageAccountById.Click
            System.Diagnostics.Process.Start("http://www.magtek.com/support/software/demo_programs/encoder_reader.asp")
        End Sub

        Private Sub linkLabel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles linkLabel1.Click
            System.Diagnostics.Process.Start("http://www.magtek.com/V2/products/magnesafe/index.asp")
        End Sub
    End Class

    Public Class TestTriggers
        Public Trigger As String
        Public StatusCode As String
        Public StatusMessage As String
        Public Sub New(ByVal trigger As String, ByVal statusCode As String, ByVal statusMessage As String)
            Me.Trigger = trigger
            Me.StatusCode = statusCode
            Me.StatusMessage = statusMessage
        End Sub
        Public Overrides Function ToString() As String
            Return Trigger & " - " & StatusCode & " - " & StatusMessage
        End Function
    End Class
End Namespace

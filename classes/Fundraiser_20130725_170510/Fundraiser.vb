
Public Class Fundraiser
     Inherits AutoBase

Public Sub New()
End Sub

Public Function Template() As fakeTemplate
     Return New fakeTemplate()
End Function


''' <summary>
''' Clicks on the 'givingLevels' button
''' </summary>
Public Sub Click_givingLevels()
     AutoBase.Click("$(&quot;input[id$=&#39;1&#39;][type=&#39;radio&#39;]&quot;)")
End Sub


''' <summary>
''' Clicks on the 'chkAnonymous' button
''' </summary>
Public Sub Click_chkAnonymous()
     AutoBase.Click("$(&quot;input[id$=&#39;chkAnonymous&#39;][type=&#39;checkbox&#39;]&quot;)")
End Sub


''' <summary>
''' Clicks on the 'chkMGCompany' button
''' </summary>
Public Sub Click_chkMGCompany()
     AutoBase.Click("$(&quot;input[id$=&#39;chkMGCompany&#39;][type=&#39;checkbox&#39;]&quot;)")
End Sub


''' <summary>
''' Clicks on the 'btnNext' button
''' </summary>
Public Sub Click_btnNext()
     AutoBase.Click("$(&quot;input[id$=&#39;btnNext&#39;][type=&#39;submit&#39;][class*=&#39;BBFormSubmitButton DonationSubmitButton&#39;]&quot;)")
End Sub


''' <summary>
''' Clicks on the 'btnBack' button
''' </summary>
Public Sub Click_btnBack()
     AutoBase.Click("$(&quot;input[id$=&#39;btnBack&#39;][type=&#39;button&#39;][class*=&#39;aspNetDisabled BBFormSubmitButton FRSubmitButton&#39;][style*=&#39;display: none&#39;]&quot;)")
End Sub


''' <summary>
''' Clicks on the 'btnNext' button
''' </summary>
Public Sub Click_btnNext()
     AutoBase.Click("$(&quot;input[id$=&#39;btnNext&#39;][type=&#39;button&#39;][class*=&#39;BBFormSubmitButton FRSubmitButton&#39;][style*=&#39;display: none&#39;]&quot;)")
End Sub


''' <summary>
''' Sets the text on the 'txtAmount' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtAmount(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtAmount&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationTextboxNarrow&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtAmount' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtAmount(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtAmount&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationTextboxNarrow&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'DatePickerStart' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_DatePickerStart(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;DatePickerStart&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationTextboxNarrow hasDatepicker&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'DatePickerStart' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_DatePickerStart(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;DatePickerStart&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationTextboxNarrow hasDatepicker&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'DatePickerEnd' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_DatePickerEnd(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;DatePickerEnd&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationTextboxNarrow hasDatepicker&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'DatePickerEnd' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_DatePickerEnd(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;DatePickerEnd&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationTextboxNarrow hasDatepicker&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtFirstName' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtFirstName(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtFirstName&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtFirstName' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtFirstName(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtFirstName&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtLastName' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtLastName(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtLastName&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtLastName' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtLastName(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtLastName&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'CityUS' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_CityUS(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;CityUS&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextbox&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'CityUS' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_CityUS(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;CityUS&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextbox&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'ZipUS' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_ZipUS(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;ZipUS&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextbox&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'ZipUS' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_ZipUS(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;ZipUS&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextbox&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtPhone' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtPhone(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtPhone&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextbox&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtPhone' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtPhone(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtPhone&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextbox&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtEmail' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtEmail(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtEmail&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtEmail' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtEmail(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtEmail&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtCardholder' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtCardholder(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtCardholder&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtCardholder' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtCardholder(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtCardholder&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtCardNumber' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtCardNumber(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtCardNumber&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtCardNumber' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtCardNumber(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtCardNumber&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtCSC' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtCSC(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;txtCSC&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxNarrow&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtCSC' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtCSC(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;txtCSC&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxNarrow&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'MGCompany' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_MGCompany(ByVal value As String)
     AutoBase.SetField("$(&quot;input[id$=&#39;MGCompany&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'MGCompany' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_MGCompany(ByVal value As String)
     AutoBase.VerifyField("$(&quot;input[id$=&#39;MGCompany&#39;][type=&#39;text&#39;][class*=&#39;BBFormTextbox DonationCaptureTextboxWide&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'AddressLine' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_AddressLine(ByVal value As String)
     AutoBase.SetField("$(&quot;textarea[id$=&#39;AddressLine&#39;][class*=&#39;BBFormTextArea DonationCaptureTextArea&#39;]&quot;)", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'AddressLine' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_AddressLine(ByVal value As String)
     AutoBase.VerifyField("$(&quot;textarea[id$=&#39;AddressLine&#39;][class*=&#39;BBFormTextArea DonationCaptureTextArea&#39;]&quot;)", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'ddlFrequency' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_ddlFrequency(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;ddlFrequency&#39;][class*=&#39;BBFormSelectList DonationSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'ddlFrequency' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_ddlFrequency(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;ddlFrequency&#39;][class*=&#39;BBFormSelectList DonationSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'ddlDayOfWeek1' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_ddlDayOfWeek1(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;ddlDayOfWeek1&#39;][class*=&#39;BBFormSelectList DonationSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'ddlDayOfWeek1' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_ddlDayOfWeek1(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;ddlDayOfWeek1&#39;][class*=&#39;BBFormSelectList DonationSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboTitle' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboTitle(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;cboTitle&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboTitle' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboTitle(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;cboTitle&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'Country' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_Country(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;Country&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'Country' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_Country(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;Country&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'StateUS' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_StateUS(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;StateUS&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'StateUS' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_StateUS(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;StateUS&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboCardType' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboCardType(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;cboCardType&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboCardType' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboCardType(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;cboCardType&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectList&#39;]&quot;)", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboMonth' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboMonth(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;cboMonth&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectListNarrow&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboMonth' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboMonth(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;cboMonth&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectListNarrow&#39;]&quot;)", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboYear' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboYear(ByVal value As String)
     AutoBase.SetField("$(&quot;select[id$=&#39;cboYear&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectListNarrow&#39;]&quot;)", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboYear' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboYear(ByVal value As String)
     AutoBase.VerifyField("$(&quot;select[id$=&#39;cboYear&#39;][class*=&#39;BBFormSelectList DonationCaptureSelectListNarrow&#39;]&quot;)", value, FieldType.Select)
End Sub

End Class
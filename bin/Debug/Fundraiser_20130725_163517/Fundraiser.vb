
Public Class Fundraiser
     Inherits AutoBase
Public Sub New()
End Sub


''' <summary>
''' Clicks on the 'givingLevels' button
''' </summary>
Public Sub Click_givingLevels()
     AutoBase.Click("$("input[id$='1'][type='radio']")")
End Sub


''' <summary>
''' Clicks on the 'chkAnonymous' button
''' </summary>
Public Sub Click_chkAnonymous()
     AutoBase.Click("$("input[id$='chkAnonymous'][type='checkbox']")")
End Sub


''' <summary>
''' Clicks on the 'chkMGCompany' button
''' </summary>
Public Sub Click_chkMGCompany()
     AutoBase.Click("$("input[id$='chkMGCompany'][type='checkbox']")")
End Sub


''' <summary>
''' Clicks on the 'btnNext' button
''' </summary>
Public Sub Click_btnNext()
     AutoBase.Click("$("input[id$='btnNext'][type='submit'][class*='BBFormSubmitButton DonationSubmitButton']")")
End Sub


''' <summary>
''' Clicks on the 'btnBack' button
''' </summary>
Public Sub Click_btnBack()
     AutoBase.Click("$("input[id$='btnBack'][type='button'][class*='aspNetDisabled BBFormSubmitButton FRSubmitButton'][style*='display: none']")")
End Sub


''' <summary>
''' Clicks on the 'btnNext' button
''' </summary>
Public Sub Click_btnNext()
     AutoBase.Click("$("input[id$='btnNext'][type='button'][class*='BBFormSubmitButton FRSubmitButton'][style*='display: none']")")
End Sub


''' <summary>
''' Sets the text on the 'txtAmount' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtAmount(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtAmount'][type='text'][class*='BBFormTextbox DonationTextboxNarrow']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtAmount' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtAmount(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtAmount'][type='text'][class*='BBFormTextbox DonationTextboxNarrow']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'DatePickerStart' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_DatePickerStart(ByVal value As String)
     AutoBase.SetField("$("input[id$='DatePickerStart'][type='text'][class*='BBFormTextbox DonationTextboxNarrow hasDatepicker']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'DatePickerStart' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_DatePickerStart(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='DatePickerStart'][type='text'][class*='BBFormTextbox DonationTextboxNarrow hasDatepicker']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'DatePickerEnd' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_DatePickerEnd(ByVal value As String)
     AutoBase.SetField("$("input[id$='DatePickerEnd'][type='text'][class*='BBFormTextbox DonationTextboxNarrow hasDatepicker']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'DatePickerEnd' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_DatePickerEnd(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='DatePickerEnd'][type='text'][class*='BBFormTextbox DonationTextboxNarrow hasDatepicker']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtFirstName' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtFirstName(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtFirstName'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtFirstName' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtFirstName(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtFirstName'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtLastName' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtLastName(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtLastName'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtLastName' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtLastName(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtLastName'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'CityUS' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_CityUS(ByVal value As String)
     AutoBase.SetField("$("input[id$='CityUS'][type='text'][class*='BBFormTextbox DonationCaptureTextbox']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'CityUS' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_CityUS(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='CityUS'][type='text'][class*='BBFormTextbox DonationCaptureTextbox']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'ZipUS' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_ZipUS(ByVal value As String)
     AutoBase.SetField("$("input[id$='ZipUS'][type='text'][class*='BBFormTextbox DonationCaptureTextbox']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'ZipUS' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_ZipUS(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='ZipUS'][type='text'][class*='BBFormTextbox DonationCaptureTextbox']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtPhone' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtPhone(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtPhone'][type='text'][class*='BBFormTextbox DonationCaptureTextbox']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtPhone' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtPhone(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtPhone'][type='text'][class*='BBFormTextbox DonationCaptureTextbox']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtEmail' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtEmail(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtEmail'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtEmail' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtEmail(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtEmail'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtCardholder' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtCardholder(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtCardholder'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtCardholder' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtCardholder(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtCardholder'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtCardNumber' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtCardNumber(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtCardNumber'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtCardNumber' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtCardNumber(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtCardNumber'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'txtCSC' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_txtCSC(ByVal value As String)
     AutoBase.SetField("$("input[id$='txtCSC'][type='text'][class*='BBFormTextbox DonationCaptureTextboxNarrow']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'txtCSC' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_txtCSC(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='txtCSC'][type='text'][class*='BBFormTextbox DonationCaptureTextboxNarrow']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'MGCompany' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_MGCompany(ByVal value As String)
     AutoBase.SetField("$("input[id$='MGCompany'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'MGCompany' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_MGCompany(ByVal value As String)
     AutoBase.VerifyField("$("input[id$='MGCompany'][type='text'][class*='BBFormTextbox DonationCaptureTextboxWide']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'AddressLine' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_AddressLine(ByVal value As String)
     AutoBase.SetField("$("textarea[id$='AddressLine'][class*='BBFormTextArea DonationCaptureTextArea']")", value, FieldType.Text)
End Sub

''' <summary>
''' Verifies the text on the 'AddressLine' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_AddressLine(ByVal value As String)
     AutoBase.VerifyField("$("textarea[id$='AddressLine'][class*='BBFormTextArea DonationCaptureTextArea']")", value, FieldType.Text)
End Sub


''' <summary>
''' Sets the text on the 'ddlFrequency' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_ddlFrequency(ByVal value As String)
     AutoBase.SetField("$("select[id$='ddlFrequency'][class*='BBFormSelectList DonationSelectList']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'ddlFrequency' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_ddlFrequency(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='ddlFrequency'][class*='BBFormSelectList DonationSelectList']")", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'ddlDayOfWeek1' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_ddlDayOfWeek1(ByVal value As String)
     AutoBase.SetField("$("select[id$='ddlDayOfWeek1'][class*='BBFormSelectList DonationSelectList']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'ddlDayOfWeek1' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_ddlDayOfWeek1(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='ddlDayOfWeek1'][class*='BBFormSelectList DonationSelectList']")", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboTitle' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboTitle(ByVal value As String)
     AutoBase.SetField("$("select[id$='cboTitle'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboTitle' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboTitle(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='cboTitle'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'Country' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_Country(ByVal value As String)
     AutoBase.SetField("$("select[id$='Country'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'Country' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_Country(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='Country'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'StateUS' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_StateUS(ByVal value As String)
     AutoBase.SetField("$("select[id$='StateUS'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'StateUS' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_StateUS(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='StateUS'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboCardType' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboCardType(ByVal value As String)
     AutoBase.SetField("$("select[id$='cboCardType'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboCardType' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboCardType(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='cboCardType'][class*='BBFormSelectList DonationCaptureSelectList']")", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboMonth' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboMonth(ByVal value As String)
     AutoBase.SetField("$("select[id$='cboMonth'][class*='BBFormSelectList DonationCaptureSelectListNarrow']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboMonth' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboMonth(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='cboMonth'][class*='BBFormSelectList DonationCaptureSelectListNarrow']")", value, FieldType.Select)
End Sub


''' <summary>
''' Sets the text on the 'cboYear' field
''' <param name="value">The value to set in the field</param>)
''' </summary>
Public Sub Set_cboYear(ByVal value As String)
     AutoBase.SetField("$("select[id$='cboYear'][class*='BBFormSelectList DonationCaptureSelectListNarrow']")", value, FieldType.Select)
End Sub

''' <summary>
''' Verifies the text on the 'cboYear' field
''' <param name="value">The value to verify on the field</param>)
''' </summary>
Public Sub Verify_cboYear(ByVal value As String)
     AutoBase.VerifyField("$("select[id$='cboYear'][class*='BBFormSelectList DonationCaptureSelectListNarrow']")", value, FieldType.Select)
End Sub

End Class
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium

Public Class AutoBase

    Enum FieldType
        Text
        [Select]
    End Enum

    Public Shared driver As IWebDriver

    Public Shared Sub Navigate(ByVal url As String)
        driver.Navigate().GoToUrl(url)
    End Sub

    Public Shared Sub Click(ByVal jQuery As String)
        Dim js As IJavaScriptExecutor = driver
        js.ExecuteScript(jQuery & ".click()")
    End Sub

    Public Shared Sub SetField(ByVal jQuery As String, ByVal value As String, ByVal type As FieldType)
        Dim js As IJavaScriptExecutor = driver
        If type = FieldType.Text Then
            js.ExecuteScript(jQuery & ".val(""" & value & """)")
        End If
        If type = FieldType.Select Then
            'SELECTS
        End If
    End Sub


    Public Shared Sub VerifyField(ByVal jQuery As String, ByVal value As String, ByVal type As FieldType)
        Dim js As IJavaScriptExecutor = driver
        If type = FieldType.Text Then
            If Not js.ExecuteScript("return " & jQuery & ".val()") = value Then
                Throw New Exception("Field did not match value of '" & value & "'")
            End If
        End If
        If type = FieldType.Select Then
            'SELECTS
        End If
    End Sub



End Class



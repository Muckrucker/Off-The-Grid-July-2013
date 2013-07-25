Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium
Imports System.Xml
Imports System.IO

Public Class Form1

    Private Sub btn_go_Click(sender As Object, e As EventArgs) Handles btn_go.Click
        Dim driver As IWebDriver
        driver = New ChromeDriver()
        driver.Navigate().GoToUrl(tb_url.Text)
        
        Dim js As IJavaScriptExecutor = driver
        js.ExecuteScript(My.Resources.HtmlToXml)

        Dim xDoc As XDocument = XDocument.Parse(CStr(js.ExecuteScript("return HtmlAsXml.toXmlString();")))

        'Dim xmlDoc As New XmlDocument()
        'xmlDoc.LoadXml(CStr(js.ExecuteScript("return HtmlAsXml.toXmlString();")))
    End Sub
End Class

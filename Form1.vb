Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium
Imports System.Xml
Imports System.IO
Imports System.Linq

Public Class Form1

    Private _driver As IWebDriver
    Private _xDoc As XDocument

    Private Sub btn_go_Click(sender As Object, e As EventArgs) Handles btn_go.Click
        _driver = New ChromeDriver()
        _driver.Navigate().GoToUrl(tb_url.Text)

        Dim js As IJavaScriptExecutor = _driver
        js.ExecuteScript(My.Resources.HtmlToXml)

        _xDoc = XDocument.Parse(CStr(js.ExecuteScript("return HtmlAsXml.toXmlString();")))

        'Dim xmlDoc As New XmlDocument()
        'xmlDoc.LoadXml(CStr(js.ExecuteScript("return HtmlAsXml.toXmlString();")))
    End Sub

    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        If _xDoc Is Nothing Then
            btn_go_Click(Nothing, Nothing)
        End If
        'all elements by execution type
        Dim elementsToConvert_Type As IEnumerable(Of XElement)
        Dim elementsToConvert_Click As IEnumerable(Of XElement)
        Dim elementsToConvert_Select As IEnumerable(Of XElement)

        'text input types
        Dim textInputElements As IEnumerable(Of XElement)
        Dim textAreaElements As IEnumerable(Of XElement)

        'click types
        Dim anchorElements As IEnumerable(Of XElement)
        Dim buttonElements As IEnumerable(Of XElement)
        Dim checkboxElements As IEnumerable(Of XElement)

        'select types
        Dim selectElements As IEnumerable(Of XElement)

        'type-based elements
        'grab input text boxes
        textInputElements = From node In _xDoc.Descendants("input")
                            Where node.Attribute("type").Value.Equals("text", StringComparison.OrdinalIgnoreCase) Or
                                    node.Attribute("type").Value.Equals("password", StringComparison.OrdinalIgnoreCase)
                            Select node
        elementsToConvert_Type = textInputElements

        textAreaElements = From node In _xDoc.Descendants("textarea")
                            Select node
        elementsToConvert_Type = elementsToConvert_Type.Union(textAreaElements)

        'click-based elements
        'grab anchor elements
        anchorElements = From node In _xDoc.Descendants("a")
                         Select node
        elementsToConvert_Click = anchorElements

        'grab button elements
        buttonElements = From node In _xDoc.Descendants("button")
                         Select node
        elementsToConvert_Click = elementsToConvert_Click.Union(buttonElements)
        'query is not working
        'Where node.Attribute("type").Value.Equals("submit", StringComparison.OrdinalIgnoreCase)

        'grab checkbox elements
        checkboxElements = From node In _xDoc.Descendants("input")
                         Where node.Attribute("type").Value.Equals("checkbox", StringComparison.OrdinalIgnoreCase) Or
                                node.Attribute("type").Value.Equals("submit", StringComparison.OrdinalIgnoreCase) Or
                                node.Attribute("type").Value.Equals("radio", StringComparison.OrdinalIgnoreCase) Or
                                node.Attribute("type").Value.Equals("button", StringComparison.OrdinalIgnoreCase)
                         Select node
        elementsToConvert_Click = elementsToConvert_Click.Union(checkboxElements)

        'select-based elements
        'grab select elements
        selectElements = From node In _xDoc.Descendants("select")
                         Select node
        elementsToConvert_Select = selectElements

    End Sub

End Class

Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium
Imports System.Xml
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Web

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

    Private Sub btn_xsd_Click(sender As Object, e As EventArgs) Handles btn_xsd.Click
        Dim _tempXDoc As XDocument = XDocument.Parse(My.Resources.mappingfile)
        CreateClasses(_tempXDoc)
    End Sub

    ''' <summary>
    ''' This sub takes the specified file name, loads its xml version, creates an xsd from it, parses the xsd into code classes
    '''  and finally links the data from the mappingfile into the code classes
    ''' </summary>
    ''' <param name="xDoc">The XDocument object containing all of the prepped data for generation</param>
    Private Sub CreateClasses(ByVal xDoc As XDocument)
        'grab the filename
        Dim fileName As String = xDoc.Root.Attribute("class")

        'create a new folder to put the files into
        Dim folderName As String = CreateFolder(fileName)

        'iterate through the list of nodes and create the class file
        Dim classString As String = String.Empty

        'generate the header
        classString += Generate_ClassHeader(fileName, xDoc.Root.Attribute("template"))

        'iterate over all of the nodes and generate class entries for them
        For Each element As XElement In xDoc.Root.Descendants()
            Dim elementType As String = element.Attribute("type")
            Select Case elementType
                Case "Click"
                    classString += Generate_Click(element.Attribute("jQuery"), element.Name.LocalName)
                Case "Type"
                    classString += Generate_Type(element.Attribute("jQuery"), element.Name.LocalName)
                Case "Select"
                    classString += Generate_Select(element.Attribute("jQuery"), element.Name.LocalName)
                Case Else
                    'have some cake and eat it too
            End Select
        Next

        'add the footer
        classString += "End Class"

        'output the class file
        File.WriteAllText(folderName + fileName + ".vb", classString)
    End Sub

    ''' <summary>
    ''' Generates the required code to create the Instantiation of a class
    ''' </summary>
    ''' <param name="className">The name to use for the newly generated class</param>
    ''' <param name="templateClass">(Optional) The name of the class to use as the Template class for the newly generated class</param>
    ''' <returns>String formatted in VB.Net for the click Sub</returns>
    Private Function Generate_ClassHeader(ByVal className As String, Optional ByVal templateClass As String = "") As String
        Dim generatedString As New StringBuilder()
        generatedString.AppendLine()
        generatedString.AppendLine(String.Format("Public Class {0}", className))
        generatedString.AppendLine("     Inherits AutoBase")
        generatedString.AppendLine()
        generatedString.AppendLine("Public Sub New()")
        generatedString.AppendLine("End Sub")
        generatedString.AppendLine()
        If Not String.IsNullOrEmpty(templateClass) Then
            generatedString.AppendLine(String.Format("Public Function Template() As {0}", templateClass))
            generatedString.AppendLine(String.Format("     Return New {0}()", templateClass))
            generatedString.AppendLine("End Function")
            generatedString.AppendLine()
        End If
        Return generatedString.ToString()
    End Function

    ''' <summary>
    ''' Generates the required code to operate a Click step
    ''' </summary>
    ''' <param name="jQuery">The jQuery to access the item to click</param>
    ''' <param name="subName">The name to use in code for the Sub to drive the Click keyword</param>
    ''' <returns>String formatted in VB.Net for the click Sub</returns>
    Private Function Generate_Click(ByVal jQuery As String, ByVal subName As String) As String
        Dim generatedString As New StringBuilder()
        generatedString.AppendLine()
        generatedString.AppendLine("''' <summary>")
        generatedString.AppendLine(String.Format("''' Clicks on the '{0}' button", subName))
        generatedString.AppendLine("''' </summary>")
        generatedString.AppendLine(String.Format("Public Sub Click_{0}()", subName))
        generatedString.AppendLine(String.Format("     AutoBase.Click(""{0}"")", HttpUtility.HtmlEncode(jQuery)))
        generatedString.AppendLine("End Sub")
        generatedString.AppendLine()
        Return generatedString.ToString()
    End Function

    ''' <summary>
    ''' Generates the required code to operate a Type step
    ''' </summary>
    ''' <param name="jQuery">The jQuery to access the item to click</param>
    ''' <param name="subName">The name to use in code for the Subs to drive the Set and Verify keywords</param>
    ''' <returns>String formatted in VB.Net for the click Sub</returns>
    Private Function Generate_Type(ByVal jQuery As String, ByVal subName As String) As String
        Dim generatedString As New StringBuilder()
        generatedString.AppendLine()
        generatedString.AppendLine("''' <summary>")
        generatedString.AppendLine(String.Format("''' Sets the text on the '{0}' field", subName))
        generatedString.AppendLine("''' <param name=""value"">The value to set in the field</param>)")
        generatedString.AppendLine("''' </summary>")
        generatedString.AppendLine(String.Format("Public Sub Set_{0}(ByVal value As String)", subName))
        generatedString.AppendLine(String.Format("     AutoBase.SetField(""{0}"", value, FieldType.Text)", HttpUtility.HtmlEncode(jQuery)))
        generatedString.AppendLine("End Sub")
        generatedString.AppendLine()
        generatedString.AppendLine("''' <summary>")
        generatedString.AppendLine(String.Format("''' Verifies the text on the '{0}' field", subName))
        generatedString.AppendLine("''' <param name=""value"">The value to verify on the field</param>)")
        generatedString.AppendLine("''' </summary>")
        generatedString.AppendLine(String.Format("Public Sub Verify_{0}(ByVal value As String)", subName))
        generatedString.AppendLine(String.Format("     AutoBase.VerifyField(""{0}"", value, FieldType.Text)", HttpUtility.HtmlEncode(jQuery)))
        generatedString.AppendLine("End Sub")
        generatedString.AppendLine()
        Return generatedString.ToString()
    End Function

    ''' <summary>
    ''' Generates the required code to operate a Select step
    ''' </summary>
    ''' <param name="jQuery">The jQuery to access the item to click</param>
    ''' <param name="subName">The name to use in code for the Sub to drive the Set and Verify keywords</param>
    ''' <returns>String formatted in VB.Net for the click Sub</returns>
    Private Function Generate_Select(ByVal jQuery As String, ByVal subName As String) As String
        Dim generatedString As New StringBuilder()
        generatedString.AppendLine()
        generatedString.AppendLine("''' <summary>")
        generatedString.AppendLine(String.Format("''' Sets the text on the '{0}' field", subName))
        generatedString.AppendLine("''' <param name=""value"">The value to set in the field</param>)")
        generatedString.AppendLine("''' </summary>")
        generatedString.AppendLine(String.Format("Public Sub Set_{0}(ByVal value As String)", subName))
        generatedString.AppendLine(String.Format("     AutoBase.SetField(""{0}"", value, FieldType.Select)", HttpUtility.HtmlEncode(jQuery)))
        generatedString.AppendLine("End Sub")
        generatedString.AppendLine()
        generatedString.AppendLine("''' <summary>")
        generatedString.AppendLine(String.Format("''' Verifies the text on the '{0}' field", subName))
        generatedString.AppendLine("''' <param name=""value"">The value to verify on the field</param>)")
        generatedString.AppendLine("''' </summary>")
        generatedString.AppendLine(String.Format("Public Sub Verify_{0}(ByVal value As String)", subName))
        generatedString.AppendLine(String.Format("     AutoBase.VerifyField(""{0}"", value, FieldType.Select)", HttpUtility.HtmlEncode(jQuery)))
        generatedString.AppendLine("End Sub")
        generatedString.AppendLine()
        Return generatedString.ToString()
    End Function

    ''' <summary>
    ''' Used to make a backup copy of existing files and delete the originals so code-gen can continue
    ''' </summary>
    ''' <param name="fileName">The filename to create the folder name off of</param>
    Private Function CreateFolder(ByVal fileName As String) As String
        Dim timestamp As DateTime = DateTime.Now()
        Dim folderName As String = String.Format("..\..\classes\{0}_{1}\", fileName, timestamp.ToString("yyyyMMdd_HHmmss"))
        Directory.CreateDirectory(folderName)
        Return folderName
    End Function
End Class

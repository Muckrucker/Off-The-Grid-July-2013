Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium
Imports System.Xml
Imports System.IO
Imports System.Linq
Imports System.Object
Imports System.Text
Imports System.Web


Public Class Form1
    Private _driver As IWebDriver
    Private _xDoc As XDocument

    Private Sub btn_go_Click(sender As Object, e As EventArgs) Handles btn_go.Click
        _driver = New ChromeDriver()
        _driver.Navigate().GoToUrl(tb_url.Text)
    End Sub

    Private Sub btn_js_Click(sender As Object, e As EventArgs) Handles btn_js.Click

        Dim js As IJavaScriptExecutor = _driver
        js.ExecuteScript(My.Resources.HtmlToXml)
        _xDoc = XDocument.Parse(CStr(js.ExecuteScript("return HtmlAsXml.toXmlString();")))
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

        '****Parse elements into info we want
        Dim finalXDoc As New XDocument()
        finalXDoc.AddFirst(New XElement("root"))
        finalXDoc.Root.SetAttributeValue("class", tbClassName.Text)
        finalXDoc.Root.SetAttributeValue("template", "")
        finalXDoc.Root.Add(updateElements(New List(Of XElement)(elementsToConvert_Click), "Click").ToArray)
        finalXDoc.Root.Add(updateElements(New List(Of XElement)(elementsToConvert_Type), "Type").ToArray)
        finalXDoc.Root.Add(updateElements(New List(Of XElement)(elementsToConvert_Select), "Select").ToArray)
        '  Dim list As List(Of XElement) = updateElements(New List(Of XElement)(elementsToConvert_Click), "Click")
        'list = list.Union(updateElements(New List(Of XElement)(elementsToConvert_Type), "Type"))
        'list = list.Union(updateElements(New List(Of XElement)(elementsToConvert_Select), "Select"))

        tbResults.Text = finalXDoc.ToString
        CreateClasses(finalXDoc)
    End Sub

    Private Function updateElements(ByVal elements As List(Of XElement), ByVal type As String) As List(Of XElement)
        Dim updatedList As New List(Of XElement)

        For Each element As XElement In elements
            Dim newElement As XElement = parseJquery(element)
            If newElement IsNot Nothing Then
                newElement.SetAttributeValue("type", type)
                updatedList.Add(newElement)
            Else
                'something went wrong, we should say what
            End If

        Next
        Return updatedList
    End Function

    Private Function parseJquery(ByVal element As XElement) As XElement
        Dim updatedElement As XElement = Nothing
        Dim tagName As String = element.Name.LocalName
        Dim innerText As String = ""
        Dim value As String = getElementAttribute(element, "value")
        Dim name As String = getElementAttribute(element, "name")
        Dim id As String = getElementAttribute(element, "id")
        Dim title As String = getElementAttribute(element, "title")
        Dim classValue As String = getElementAttribute(element, "class")
        Dim style As String = getElementAttribute(element, "style")
        Dim type As String = getElementAttribute(element, "type")

        Dim jquery As String = ""
        Dim fieldName As String = ""

        'Figure out what we want to name this field******
        If element.Element("innerText") IsNot Nothing Then
            innerText = element.Element("innerText").Value
            fieldName = innerText
        End If

        If Not String.IsNullOrEmpty(name) Then
            'if name = "ctrl100$title" or "ctrl100_title" will make it title
            For i = name.Length - 1 To 0 Step -1
                If name(i) = "$" Or name(i) = "_" Then
                    name = name.Substring(i + 1, name.Length - i - 1)
                    name = name.Trim
                    Exit For
                End If
            Next
        End If
        If Not String.IsNullOrEmpty(id) Then
            'if id = "ctrl100$title" or "ctrl100_title" will make it title
            For i = id.Length - 1 To 0 Step -1
                If id(i) = "$" Or id(i) = "_" Then
                    id = id.Substring(i + 1, id.Length - i - 1)
                    id = id.Trim
                    Exit For
                End If
            Next
        End If
        'has no inner text to use to make the field name, will try value, then name, then id, then class, otherwise will be generic name
        If String.IsNullOrEmpty(fieldName) Then
            If Not String.IsNullOrEmpty(value) Then
                fieldName = value
            ElseIf Not String.IsNullOrEmpty(name) Then
                fieldName = name
            ElseIf Not String.IsNullOrEmpty(id) Then
                fieldName = id
            ElseIf Not String.IsNullOrEmpty(classValue) Then
                fieldName = classValue
            Else
                fieldName = tagName
            End If
        End If
        fieldName = fieldName.Replace(" ", "")
        'End figuring out what to name********


        'create jquery
        Dim selector As String = BuildGenericSelector(tagname:=tagName, _
                                      id:=id, _
                                      classValue:=classValue, _
                                      style:=style, _
                                      title:=title, _
                                      type:=type, _
                                      textValue:=innerText, _
                                      textCompare:=TextCompareTypes.Contains)
        jquery = "$(""" & selector & """)"

        Dim returnedRecordCount As Integer = CInt(executeJquerySize(jquery))
        If returnedRecordCount > 0 Then
            Try
                updatedElement = New XElement(fieldName.Replace("-", "_"))
            Catch ex As Exception
                updatedElement = New XElement(tagName)
            End Try

            updatedElement.SetAttributeValue("jQuery", jquery)
            'ElseIf returnedRecordCount > 1 Then
            '    'oh shit tooooooo many!
            '    Throw New Exception("Found too many records POOO")
        Else
            'oh shit didnt find any!!
            ' Throw New Exception("Didn't return any results")
        End If

        Return updatedElement


    End Function

    ''' <summary>
    ''' Returns a selector string based on the parameters supplied
    ''' Note: Any parameter left empty will not be used in the element lookup.
    ''' </summary>
    ''' <param name="tagname">The html tagname of the element (ie: a, button, etc)</param>
    ''' <param name="wrapSelector">Boolean indicating whether to wrap all of the selectors in single quotes.  Note: Primarily only useful when executing custom jQuery</param>
    ''' <param name="id">The id of the element.  This will handle partial matches as well (ie: '_elementdesired' will work for 'ctrl0123_elementdesired')</param>
    ''' <param name="type">The html type of the element (ie: button, text, etc)</param>
    ''' <param name="textValue">The value present on the element</param>
    ''' <param name="textCompare">The type of text comparison to use</param>
    ''' <param name="title">The title attribute of the element</param>
    ''' <param name="classValue">The class attribute of the element</param>
    ''' <remarks></remarks>
    Public Shared Function BuildGenericSelector(ByVal tagname As String,
                                         Optional ByVal wrapSelector As Boolean = True,
                                         Optional ByVal id As String = "",
                                         Optional ByVal type As String = "",
                                         Optional ByVal textValue As String = "",
                                         Optional ByVal textCompare As TextCompareTypes = TextCompareTypes.Contains,
                                         Optional ByVal title As String = "",
                                         Optional ByVal classValue As String = "",
                                         Optional ByVal style As String = "",
                                         Optional ByVal dataTag As String = "") As String
        Dim selectorString As System.Text.StringBuilder = New System.Text.StringBuilder("")
        If Not String.IsNullOrEmpty(tagname) Then
            selectorString.Append(tagname)
        End If
        If Not String.IsNullOrEmpty(id) Then
            selectorString.Append(String.Format("[id$='{0}']", id))
        End If
        If Not String.IsNullOrEmpty(type) Then
            selectorString.Append(String.Format("[type='{0}']", type))
        End If
        If Not String.IsNullOrEmpty(title) Then
            selectorString.Append(String.Format("[title='{0}']", title))
        End If
        If Not String.IsNullOrEmpty(classValue) Then
            selectorString.Append(String.Format("[class*='{0}']", classValue))
        End If
        If Not String.IsNullOrEmpty(style) Then
            selectorString.Append(String.Format("[style*='{0}']", style))
        End If
        If Not String.IsNullOrEmpty(dataTag) Then
            selectorString.Append(String.Format("[data-tag='{0}']", dataTag))
        End If
        If Not String.IsNullOrEmpty(textValue) Then
            Select Case textCompare
                Case TextCompareTypes.Contains
                    selectorString.Append(String.Format(":contains('{0}')", textValue))
                Case TextCompareTypes.Equals
                    selectorString.Append(String.Format(":textEquals('{0}')", textValue))
                Case TextCompareTypes.Value
                    selectorString.Append(String.Format(":valEquals('{0}')", textValue))
            End Select
        End If
        If Not wrapSelector Then
            selectorString.Replace("'", String.Empty)
        End If
        Return selectorString.ToString()
    End Function

    'returns empty string if the attribute is not found
    Private Function getElementAttribute(ByVal element As XElement, ByVal attribute As String)
        If element.Attribute(attribute) IsNot Nothing Then
            Return element.Attribute(attribute).Value
        Else
            Return ""
        End If
    End Function

    'returns how many elements were found from the jquery statement
    Private Function executeJquerySize(ByVal jquery As String) As Object
        Try
            Dim js As IJavaScriptExecutor = _driver
            Return js.ExecuteScript("return " & jquery & ".size();")
        Catch ex As Exception
            Return 0
        End Try

    End Function

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

Public Class Settings
    Public attribute As String
    Public rank As Integer
End Class

Public Enum TextCompareTypes
    Equals = 0
    Contains = 1
    Value = 2
End Enum
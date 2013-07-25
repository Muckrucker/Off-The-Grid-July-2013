<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_url = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.btn_Filter = New System.Windows.Forms.Button()
        Me.tbResults = New System.Windows.Forms.TextBox()
        Me.tbClassName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_url
        '
        Me.tb_url.Location = New System.Drawing.Point(78, 9)
        Me.tb_url.Name = "tb_url"
        Me.tb_url.Size = New System.Drawing.Size(308, 20)
        Me.tb_url.TabIndex = 0
        Me.tb_url.Text = "http://ptlr38/fundraiser?tab=3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Url:"
        '
        'btn_go
        '
        Me.btn_go.Location = New System.Drawing.Point(392, 9)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(75, 23)
        Me.btn_go.TabIndex = 2
        Me.btn_go.Text = "Go"
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'btn_Filter
        '
        Me.btn_Filter.Location = New System.Drawing.Point(392, 35)
        Me.btn_Filter.Name = "btn_Filter"
        Me.btn_Filter.Size = New System.Drawing.Size(75, 23)
        Me.btn_Filter.TabIndex = 3
        Me.btn_Filter.Text = "Generate"
        Me.btn_Filter.UseVisualStyleBackColor = True
        '
        'tbResults
        '
        Me.tbResults.Location = New System.Drawing.Point(12, 61)
        Me.tbResults.Multiline = True
        Me.tbResults.Name = "tbResults"
        Me.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbResults.Size = New System.Drawing.Size(455, 483)
        Me.tbResults.TabIndex = 5
        '
        'tbClassName
        '
        Me.tbClassName.Location = New System.Drawing.Point(78, 35)
        Me.tbClassName.Name = "tbClassName"
        Me.tbClassName.Size = New System.Drawing.Size(308, 20)
        Me.tbClassName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Classname:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 555)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbClassName)
        Me.Controls.Add(Me.btn_Filter)
        Me.Controls.Add(Me.tbResults)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_url)
        Me.Name = "Form1"
        Me.Text = "Automating Automation: Keyword Class Generation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_url As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents btn_Filter As System.Windows.Forms.Button
    Friend WithEvents tbResults As System.Windows.Forms.TextBox
    Friend WithEvents tbClassName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

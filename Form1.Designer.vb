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
        Me.btn_xsd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_url
        '
        Me.tb_url.Location = New System.Drawing.Point(41, 9)
        Me.tb_url.Name = "tb_url"
        Me.tb_url.Size = New System.Drawing.Size(345, 20)
        Me.tb_url.TabIndex = 0
        Me.tb_url.Text = "http://www.twitter.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Url:"
        '
        'btn_go
        '
        Me.btn_go.Location = New System.Drawing.Point(401, 7)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(75, 23)
        Me.btn_go.TabIndex = 2
        Me.btn_go.Text = "Go"
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'btn_Filter
        '
        Me.btn_Filter.Location = New System.Drawing.Point(546, 5)
        Me.btn_Filter.Name = "btn_Filter"
        Me.btn_Filter.Size = New System.Drawing.Size(75, 23)
        Me.btn_Filter.TabIndex = 3
        Me.btn_Filter.Text = "Filter Elems"
        Me.btn_Filter.UseVisualStyleBackColor = True
        '
        'btn_xsd
        '
        Me.btn_xsd.Location = New System.Drawing.Point(546, 50)
        Me.btn_xsd.Name = "btn_xsd"
        Me.btn_xsd.Size = New System.Drawing.Size(75, 23)
        Me.btn_xsd.TabIndex = 4
        Me.btn_xsd.Text = "XSD gen"
        Me.btn_xsd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 319)
        Me.Controls.Add(Me.btn_xsd)
        Me.Controls.Add(Me.btn_Filter)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_url)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_url As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents btn_Filter As System.Windows.Forms.Button
    Friend WithEvents btn_xsd As System.Windows.Forms.Button

End Class

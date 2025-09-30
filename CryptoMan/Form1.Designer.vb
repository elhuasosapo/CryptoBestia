<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnGenerate = New Button()
        btnVerify = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        txtRounds = New TextBox()
        Label2 = New Label()
        txtHash = New TextBox()
        Label3 = New Label()
        txtStored = New TextBox()
        Label4 = New Label()
        lblResult = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.Black
        btnGenerate.Font = New Font("Cascadia Mono", 14.25F)
        btnGenerate.ForeColor = Color.White
        btnGenerate.Location = New Point(373, 390)
        btnGenerate.Margin = New Padding(4)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(251, 68)
        btnGenerate.TabIndex = 0
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' btnVerify
        ' 
        btnVerify.BackColor = Color.Black
        btnVerify.Font = New Font("Cascadia Mono", 14.25F)
        btnVerify.ForeColor = Color.White
        btnVerify.Location = New Point(373, 465)
        btnVerify.Margin = New Padding(4)
        btnVerify.Name = "btnVerify"
        btnVerify.Size = New Size(251, 68)
        btnVerify.TabIndex = 1
        btnVerify.Text = "Verify"
        btnVerify.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        txtPassword.ForeColor = Color.Black
        txtPassword.Location = New Point(93, 191)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(902, 26)
        txtPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(5, 191)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 3
        Label1.Text = "Password"
        ' 
        ' txtRounds
        ' 
        txtRounds.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        txtRounds.ForeColor = Color.Black
        txtRounds.Location = New Point(93, 235)
        txtRounds.Margin = New Padding(4)
        txtRounds.Name = "txtRounds"
        txtRounds.Size = New Size(902, 26)
        txtRounds.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(21, 235)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 21)
        Label2.TabIndex = 5
        Label2.Text = "Rounds"
        ' 
        ' txtHash
        ' 
        txtHash.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        txtHash.ForeColor = Color.Black
        txtHash.Location = New Point(93, 148)
        txtHash.Margin = New Padding(4)
        txtHash.Name = "txtHash"
        txtHash.Size = New Size(902, 26)
        txtHash.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(40, 148)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 21)
        Label3.TabIndex = 7
        Label3.Text = "Hash"
        ' 
        ' txtStored
        ' 
        txtStored.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        txtStored.ForeColor = Color.Black
        txtStored.Location = New Point(93, 278)
        txtStored.Margin = New Padding(4)
        txtStored.Name = "txtStored"
        txtStored.Size = New Size(902, 26)
        txtStored.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(21, 278)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 21)
        Label4.TabIndex = 9
        Label4.Text = "Stored"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BackColor = Color.Gainsboro
        lblResult.BorderStyle = BorderStyle.FixedSingle
        lblResult.FlatStyle = FlatStyle.Flat
        lblResult.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        lblResult.ForeColor = Color.Black
        lblResult.Location = New Point(93, 330)
        lblResult.Margin = New Padding(4, 0, 4, 0)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(66, 23)
        lblResult.TabIndex = 10
        lblResult.Text = "Result"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(21, 330)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 21)
        Label5.TabIndex = 11
        Label5.Text = "Result"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold)
        Label6.ForeColor = Color.Yellow
        Label6.Location = New Point(373, 19)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(247, 43)
        Label6.TabIndex = 12
        Label6.Text = "CryptoBestia"
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Cascadia Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(15, 472)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(96, 40)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.ForestGreen
        ClientSize = New Size(1008, 561)
        Controls.Add(btnClear)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblResult)
        Controls.Add(Label4)
        Controls.Add(txtStored)
        Controls.Add(Label3)
        Controls.Add(txtHash)
        Controls.Add(Label2)
        Controls.Add(txtRounds)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(btnVerify)
        Controls.Add(btnGenerate)
        Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        MaximumSize = New Size(1024, 600)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CryptoBestia"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnVerify As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRounds As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHash As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStored As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Button

End Class

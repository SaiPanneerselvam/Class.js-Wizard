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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(112, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 20)
        Label1.TabIndex = 0
        Label1.Text = "Click to refresh..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 48.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label2.Location = New Point(2, -4)
        Label2.Name = "Label2"
        Label2.Size = New Size(310, 100)
        Label2.TabIndex = 1
        Label2.Text = "Class.js"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label3.Location = New Point(306, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 35)
        Label3.TabIndex = 2
        Label3.Text = "Wizard"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(79), CByte(79), CByte(79))
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(37, 136)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(337, 200)
        Panel1.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(112, 75)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 20)
        Label9.TabIndex = 8
        Label9.Text = "[undefined]"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(57, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 20)
        Label8.TabIndex = 7
        Label8.Text = "Version:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(79), CByte(79), CByte(79))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(79), CByte(79), CByte(79))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = Color.White
        Button2.Location = New Point(130, 163)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 31)
        Button2.TabIndex = 6
        Button2.Text = "Uninstall"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(79), CByte(79), CByte(79))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(79), CByte(79), CByte(79))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.White
        Button1.Location = New Point(213, 163)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 31)
        Button1.TabIndex = 5
        Button1.Text = "Install/Reinstall"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(112, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 20)
        Label7.TabIndex = 4
        Label7.Text = "[undefined]"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(50, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 20)
        Label6.TabIndex = 1
        Label6.Text = "Installed:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(18, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 0
        Label5.Text = "Latest Version:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(43, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 28)
        Label4.TabIndex = 0
        Label4.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(912, 589)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        ForeColor = Color.White
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MaximumSize = New Size(930, 636)
        MinimizeBox = False
        MinimumSize = New Size(930, 636)
        Name = "Form1"
        Text = "Class.js Wizard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

End Class

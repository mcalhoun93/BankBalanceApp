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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chargebutton = New System.Windows.Forms.RadioButton()
        Me.depositbutton = New System.Windows.Forms.RadioButton()
        Me.checkbutton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.baltextbox = New System.Windows.Forms.TextBox()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.calbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.amounttextbox = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.sumbutton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chargebutton)
        Me.GroupBox1.Controls.Add(Me.depositbutton)
        Me.GroupBox1.Controls.Add(Me.checkbutton)
        Me.GroupBox1.Location = New System.Drawing.Point(198, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 179)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Type"
        '
        'chargebutton
        '
        Me.chargebutton.AutoSize = True
        Me.chargebutton.Location = New System.Drawing.Point(87, 123)
        Me.chargebutton.Name = "chargebutton"
        Me.chargebutton.Size = New System.Drawing.Size(98, 17)
        Me.chargebutton.TabIndex = 2
        Me.chargebutton.TabStop = True
        Me.chargebutton.Text = "Service Charge"
        Me.chargebutton.UseVisualStyleBackColor = True
        '
        'depositbutton
        '
        Me.depositbutton.AutoSize = True
        Me.depositbutton.Location = New System.Drawing.Point(87, 83)
        Me.depositbutton.Name = "depositbutton"
        Me.depositbutton.Size = New System.Drawing.Size(61, 17)
        Me.depositbutton.TabIndex = 1
        Me.depositbutton.TabStop = True
        Me.depositbutton.Text = "Deposit"
        Me.depositbutton.UseVisualStyleBackColor = True
        '
        'checkbutton
        '
        Me.checkbutton.AutoSize = True
        Me.checkbutton.Location = New System.Drawing.Point(87, 41)
        Me.checkbutton.Name = "checkbutton"
        Me.checkbutton.Size = New System.Drawing.Size(56, 17)
        Me.checkbutton.TabIndex = 0
        Me.checkbutton.TabStop = True
        Me.checkbutton.Text = "Check"
        Me.checkbutton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Balance:"
        '
        'baltextbox
        '
        Me.baltextbox.Location = New System.Drawing.Point(88, 164)
        Me.baltextbox.Name = "baltextbox"
        Me.baltextbox.ReadOnly = True
        Me.baltextbox.Size = New System.Drawing.Size(100, 20)
        Me.baltextbox.TabIndex = 16
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(344, 281)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(75, 23)
        Me.exitbutton.TabIndex = 15
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'printbutton
        '
        Me.printbutton.Location = New System.Drawing.Point(238, 281)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(75, 23)
        Me.printbutton.TabIndex = 14
        Me.printbutton.Text = "Print"
        Me.printbutton.UseVisualStyleBackColor = True
        '
        'clearbutton
        '
        Me.clearbutton.Location = New System.Drawing.Point(126, 281)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(75, 23)
        Me.clearbutton.TabIndex = 13
        Me.clearbutton.Text = "Clear"
        Me.clearbutton.UseVisualStyleBackColor = True
        '
        'calbutton
        '
        Me.calbutton.Location = New System.Drawing.Point(23, 281)
        Me.calbutton.Name = "calbutton"
        Me.calbutton.Size = New System.Drawing.Size(75, 23)
        Me.calbutton.TabIndex = 12
        Me.calbutton.Text = "Calculate"
        Me.calbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Input Amount:"
        '
        'amounttextbox
        '
        Me.amounttextbox.Location = New System.Drawing.Point(88, 118)
        Me.amounttextbox.Name = "amounttextbox"
        Me.amounttextbox.Size = New System.Drawing.Size(100, 20)
        Me.amounttextbox.TabIndex = 10
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'sumbutton
        '
        Me.sumbutton.Location = New System.Drawing.Point(180, 326)
        Me.sumbutton.Name = "sumbutton"
        Me.sumbutton.Size = New System.Drawing.Size(75, 23)
        Me.sumbutton.TabIndex = 18
        Me.sumbutton.Text = "Summary"
        Me.sumbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 361)
        Me.Controls.Add(Me.sumbutton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.baltextbox)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.calbutton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.amounttextbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chargebutton As System.Windows.Forms.RadioButton
    Friend WithEvents depositbutton As System.Windows.Forms.RadioButton
    Friend WithEvents checkbutton As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents baltextbox As System.Windows.Forms.TextBox
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents printbutton As System.Windows.Forms.Button
    Friend WithEvents clearbutton As System.Windows.Forms.Button
    Friend WithEvents calbutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents amounttextbox As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents sumbutton As System.Windows.Forms.Button

End Class

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLubeJob = New System.Windows.Forms.Label()
        Me.lblOilChange = New System.Windows.Forms.Label()
        Me.chkLubeJob = New System.Windows.Forms.CheckBox()
        Me.chkOilChange = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTransmissionFlush = New System.Windows.Forms.Label()
        Me.lblRadiatorFlush = New System.Windows.Forms.Label()
        Me.chkTransmissionFlush = New System.Windows.Forms.CheckBox()
        Me.chkRadiatorFlush = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTireRotation = New System.Windows.Forms.Label()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.lblReplaceMuffler = New System.Windows.Forms.Label()
        Me.lblInspection = New System.Windows.Forms.Label()
        Me.chkReplaceMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblLaborPerHour = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLubeJob)
        Me.GroupBox1.Controls.Add(Me.lblOilChange)
        Me.GroupBox1.Controls.Add(Me.chkLubeJob)
        Me.GroupBox1.Controls.Add(Me.chkOilChange)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil && Lube"
        '
        'lblLubeJob
        '
        Me.lblLubeJob.AutoSize = True
        Me.lblLubeJob.Location = New System.Drawing.Point(180, 54)
        Me.lblLubeJob.Name = "lblLubeJob"
        Me.lblLubeJob.Size = New System.Drawing.Size(124, 17)
        Me.lblLubeJob.TabIndex = 3
        Me.lblLubeJob.Text = "Will show ($18.00)"
        Me.lblLubeJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOilChange
        '
        Me.lblOilChange.AutoSize = True
        Me.lblOilChange.Location = New System.Drawing.Point(180, 24)
        Me.lblOilChange.Name = "lblOilChange"
        Me.lblOilChange.Size = New System.Drawing.Size(124, 17)
        Me.lblOilChange.TabIndex = 2
        Me.lblOilChange.Text = "Will show ($26.00)"
        Me.lblOilChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkLubeJob
        '
        Me.chkLubeJob.AutoSize = True
        Me.chkLubeJob.Location = New System.Drawing.Point(30, 52)
        Me.chkLubeJob.Name = "chkLubeJob"
        Me.chkLubeJob.Size = New System.Drawing.Size(89, 21)
        Me.chkLubeJob.TabIndex = 1
        Me.chkLubeJob.Text = "Lube Job"
        Me.ToolTip1.SetToolTip(Me.chkLubeJob, "Click here to choose Lube Job")
        Me.chkLubeJob.UseVisualStyleBackColor = True
        '
        'chkOilChange
        '
        Me.chkOilChange.AutoSize = True
        Me.chkOilChange.Location = New System.Drawing.Point(30, 22)
        Me.chkOilChange.Name = "chkOilChange"
        Me.chkOilChange.Size = New System.Drawing.Size(100, 21)
        Me.chkOilChange.TabIndex = 0
        Me.chkOilChange.Text = "Oil Change"
        Me.ToolTip1.SetToolTip(Me.chkOilChange, "Click here to choose Oil Change")
        Me.chkOilChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTransmissionFlush)
        Me.GroupBox2.Controls.Add(Me.lblRadiatorFlush)
        Me.GroupBox2.Controls.Add(Me.chkTransmissionFlush)
        Me.GroupBox2.Controls.Add(Me.chkRadiatorFlush)
        Me.GroupBox2.Location = New System.Drawing.Point(363, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 84)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'lblTransmissionFlush
        '
        Me.lblTransmissionFlush.AutoSize = True
        Me.lblTransmissionFlush.Location = New System.Drawing.Point(190, 54)
        Me.lblTransmissionFlush.Name = "lblTransmissionFlush"
        Me.lblTransmissionFlush.Size = New System.Drawing.Size(124, 17)
        Me.lblTransmissionFlush.TabIndex = 3
        Me.lblTransmissionFlush.Text = "Will show ($80.00)"
        Me.lblTransmissionFlush.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRadiatorFlush
        '
        Me.lblRadiatorFlush.AutoSize = True
        Me.lblRadiatorFlush.Location = New System.Drawing.Point(190, 24)
        Me.lblRadiatorFlush.Name = "lblRadiatorFlush"
        Me.lblRadiatorFlush.Size = New System.Drawing.Size(124, 17)
        Me.lblRadiatorFlush.TabIndex = 2
        Me.lblRadiatorFlush.Text = "Will show ($30.00)"
        Me.lblRadiatorFlush.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTransmissionFlush
        '
        Me.chkTransmissionFlush.AutoSize = True
        Me.chkTransmissionFlush.Location = New System.Drawing.Point(30, 52)
        Me.chkTransmissionFlush.Name = "chkTransmissionFlush"
        Me.chkTransmissionFlush.Size = New System.Drawing.Size(144, 21)
        Me.chkTransmissionFlush.TabIndex = 1
        Me.chkTransmissionFlush.Text = "Trasmission Flush"
        Me.ToolTip1.SetToolTip(Me.chkTransmissionFlush, "Click here to choose Transmission Flush")
        Me.chkTransmissionFlush.UseVisualStyleBackColor = True
        '
        'chkRadiatorFlush
        '
        Me.chkRadiatorFlush.AutoSize = True
        Me.chkRadiatorFlush.Location = New System.Drawing.Point(30, 22)
        Me.chkRadiatorFlush.Name = "chkRadiatorFlush"
        Me.chkRadiatorFlush.Size = New System.Drawing.Size(122, 21)
        Me.chkRadiatorFlush.TabIndex = 0
        Me.chkRadiatorFlush.Text = "Radiator Flush"
        Me.ToolTip1.SetToolTip(Me.chkRadiatorFlush, "Click here to choose Radiator Flush")
        Me.chkRadiatorFlush.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTireRotation)
        Me.GroupBox3.Controls.Add(Me.chkTireRotation)
        Me.GroupBox3.Controls.Add(Me.lblReplaceMuffler)
        Me.GroupBox3.Controls.Add(Me.lblInspection)
        Me.GroupBox3.Controls.Add(Me.chkReplaceMuffler)
        Me.GroupBox3.Controls.Add(Me.chkInspection)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 119)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc"
        '
        'lblTireRotation
        '
        Me.lblTireRotation.AutoSize = True
        Me.lblTireRotation.Location = New System.Drawing.Point(180, 81)
        Me.lblTireRotation.Name = "lblTireRotation"
        Me.lblTireRotation.Size = New System.Drawing.Size(124, 17)
        Me.lblTireRotation.TabIndex = 5
        Me.lblTireRotation.Text = "Will show ($20.00)"
        Me.lblTireRotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(30, 79)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(112, 21)
        Me.chkTireRotation.TabIndex = 4
        Me.chkTireRotation.Text = "Tire Rotation"
        Me.ToolTip1.SetToolTip(Me.chkTireRotation, "Click here to choose Tire Rotation")
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'lblReplaceMuffler
        '
        Me.lblReplaceMuffler.AutoSize = True
        Me.lblReplaceMuffler.Location = New System.Drawing.Point(181, 54)
        Me.lblReplaceMuffler.Name = "lblReplaceMuffler"
        Me.lblReplaceMuffler.Size = New System.Drawing.Size(132, 17)
        Me.lblReplaceMuffler.TabIndex = 3
        Me.lblReplaceMuffler.Text = "Will show ($100.00)"
        Me.lblReplaceMuffler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInspection
        '
        Me.lblInspection.AutoSize = True
        Me.lblInspection.Location = New System.Drawing.Point(180, 24)
        Me.lblInspection.Name = "lblInspection"
        Me.lblInspection.Size = New System.Drawing.Size(124, 17)
        Me.lblInspection.TabIndex = 2
        Me.lblInspection.Text = "Will show ($15.00)"
        Me.lblInspection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkReplaceMuffler
        '
        Me.chkReplaceMuffler.AutoSize = True
        Me.chkReplaceMuffler.Location = New System.Drawing.Point(30, 52)
        Me.chkReplaceMuffler.Name = "chkReplaceMuffler"
        Me.chkReplaceMuffler.Size = New System.Drawing.Size(129, 21)
        Me.chkReplaceMuffler.TabIndex = 1
        Me.chkReplaceMuffler.Text = "Replace Muffler"
        Me.ToolTip1.SetToolTip(Me.chkReplaceMuffler, "Click here to choose Replace Muffler")
        Me.chkReplaceMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(30, 22)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(94, 21)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "Inspection"
        Me.ToolTip1.SetToolTip(Me.chkInspection, "Click here to choose Inspection")
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblLaborPerHour)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtLabor)
        Me.GroupBox4.Controls.Add(Me.txtParts)
        Me.GroupBox4.Location = New System.Drawing.Point(363, 102)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(349, 119)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'lblLaborPerHour
        '
        Me.lblLaborPerHour.AutoSize = True
        Me.lblLaborPerHour.Location = New System.Drawing.Point(207, 73)
        Me.lblLaborPerHour.Name = "lblLaborPerHour"
        Me.lblLaborPerHour.Size = New System.Drawing.Size(120, 17)
        Me.lblLaborPerHour.TabIndex = 4
        Me.lblLaborPerHour.Text = "($20.00 per hour)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Labor Hours"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Parts"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(102, 70)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 22)
        Me.txtLabor.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtLabor, "Enter the amount of hours worked.")
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(102, 32)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 22)
        Me.txtParts.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtParts, "Enter a number 0 or above based on the order.")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotal)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.lblTax)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.lblParts)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.lblServices)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(26, 228)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(686, 204)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(321, 149)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(101, 25)
        Me.lblTotal.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(189, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Total Fees"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(321, 112)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(101, 25)
        Me.lblTax.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(189, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Tax ( on parts )"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblParts
        '
        Me.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParts.Location = New System.Drawing.Point(321, 79)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(101, 25)
        Me.lblParts.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(189, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Parts"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblServices
        '
        Me.lblServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServices.Location = New System.Drawing.Point(321, 44)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(101, 25)
        Me.lblServices.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(189, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Services && Labor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Location = New System.Drawing.Point(84, 457)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(134, 40)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(294, 457)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(504, 457)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 518)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Michael Kellar Joe's Automotive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOilChange As System.Windows.Forms.Label
    Friend WithEvents chkLubeJob As System.Windows.Forms.CheckBox
    Friend WithEvents chkOilChange As System.Windows.Forms.CheckBox
    Friend WithEvents lblLubeJob As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTransmissionFlush As System.Windows.Forms.Label
    Friend WithEvents lblRadiatorFlush As System.Windows.Forms.Label
    Friend WithEvents chkTransmissionFlush As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadiatorFlush As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblReplaceMuffler As System.Windows.Forms.Label
    Friend WithEvents lblInspection As System.Windows.Forms.Label
    Friend WithEvents chkReplaceMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents lblTireRotation As System.Windows.Forms.Label
    Friend WithEvents chkTireRotation As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLaborPerHour As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblServices As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class

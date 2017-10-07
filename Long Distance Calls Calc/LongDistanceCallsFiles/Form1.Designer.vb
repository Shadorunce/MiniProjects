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
        Me.radDaytime = New System.Windows.Forms.RadioButton()
        Me.radEvening = New System.Windows.Forms.RadioButton()
        Me.radOffPeak = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCharges = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOffPeakRate = New System.Windows.Forms.Label()
        Me.lblEveningRate = New System.Windows.Forms.Label()
        Me.lblDayRate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radDaytime
        '
        Me.radDaytime.AutoSize = True
        Me.radDaytime.Checked = True
        Me.radDaytime.Location = New System.Drawing.Point(6, 46)
        Me.radDaytime.Name = "radDaytime"
        Me.radDaytime.Size = New System.Drawing.Size(271, 21)
        Me.radDaytime.TabIndex = 0
        Me.radDaytime.TabStop = True
        Me.radDaytime.Text = "&Daytime (6:00 A.M. through 5:59 P.M.)"
        Me.radDaytime.UseVisualStyleBackColor = True
        '
        'radEvening
        '
        Me.radEvening.AutoSize = True
        Me.radEvening.Location = New System.Drawing.Point(6, 73)
        Me.radEvening.Name = "radEvening"
        Me.radEvening.Size = New System.Drawing.Size(279, 21)
        Me.radEvening.TabIndex = 1
        Me.radEvening.Text = "&Evening (6:00 P.M. through 11:59 P.M.)"
        Me.radEvening.UseVisualStyleBackColor = True
        '
        'radOffPeak
        '
        Me.radOffPeak.AutoSize = True
        Me.radOffPeak.Location = New System.Drawing.Point(6, 101)
        Me.radOffPeak.Name = "radOffPeak"
        Me.radOffPeak.Size = New System.Drawing.Size(284, 21)
        Me.radOffPeak.TabIndex = 2
        Me.radOffPeak.Text = "&Off-Peak (12:00 A.M. through 5:59 A.M.)"
        Me.radOffPeak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblCharges)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMinutes)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblOffPeakRate)
        Me.GroupBox1.Controls.Add(Me.lblEveningRate)
        Me.GroupBox1.Controls.Add(Me.lblDayRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.radDaytime)
        Me.GroupBox1.Controls.Add(Me.radOffPeak)
        Me.GroupBox1.Controls.Add(Me.radEvening)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 170)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Charges:"
        '
        'lblCharges
        '
        Me.lblCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCharges.Location = New System.Drawing.Point(330, 138)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(76, 19)
        Me.lblCharges.TabIndex = 9
        Me.lblCharges.Text = "Calculate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Minutes Used"
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(119, 137)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(100, 22)
        Me.txtMinutes.TabIndex = 0
        Me.txtMinutes.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Rate Categories"
        '
        'lblOffPeakRate
        '
        Me.lblOffPeakRate.AutoSize = True
        Me.lblOffPeakRate.Location = New System.Drawing.Point(338, 101)
        Me.lblOffPeakRate.Name = "lblOffPeakRate"
        Me.lblOffPeakRate.Size = New System.Drawing.Size(85, 17)
        Me.lblOffPeakRate.TabIndex = 6
        Me.lblOffPeakRate.Text = "Set to $0.05"
        '
        'lblEveningRate
        '
        Me.lblEveningRate.AutoSize = True
        Me.lblEveningRate.Location = New System.Drawing.Point(338, 73)
        Me.lblEveningRate.Name = "lblEveningRate"
        Me.lblEveningRate.Size = New System.Drawing.Size(85, 17)
        Me.lblEveningRate.TabIndex = 5
        Me.lblEveningRate.Text = "Set to $0.12"
        '
        'lblDayRate
        '
        Me.lblDayRate.AutoSize = True
        Me.lblDayRate.Location = New System.Drawing.Point(338, 46)
        Me.lblDayRate.Name = "lblDayRate"
        Me.lblDayRate.Size = New System.Drawing.Size(85, 17)
        Me.lblDayRate.TabIndex = 4
        Me.lblDayRate.Text = "Set to $0.07"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rate per Minute"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(38, 189)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(184, 188)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(316, 188)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 227)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(454, 25)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(365, 20)
        Me.lblStatus.Text = "Enter the information then click Calculate to Continue."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 252)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Michael Kellar Lond-Distance Call Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radDaytime As System.Windows.Forms.RadioButton
    Friend WithEvents radEvening As System.Windows.Forms.RadioButton
    Friend WithEvents radOffPeak As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOffPeakRate As System.Windows.Forms.Label
    Friend WithEvents lblEveningRate As System.Windows.Forms.Label
    Friend WithEvents lblDayRate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCharges As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class

' Written by Michael Kellar
' 10-24-2015
Option Strict On
Option Explicit On

Public Class Form1

    ' Class-level declarations
    Const decOilChange As Decimal = 26D           ' Cost of Oil Change
    Const decLubeJob As Decimal = 18D             ' Cost of Lube Job
    Const decRadiatorFlush As Decimal = 30D       ' Cost of Radiator Flush
    Const decTransmissionFlush As Decimal = 80D   ' Cost of Transmission Flush
    Const decInspection As Decimal = 15D          ' Cost of Inspection
    Const decReplaceMuffler As Decimal = 100D     ' Cost of Replace Muffler
    Const decTireRotation As Decimal = 20D        ' Cost of Tire Rotation
    Const decLaborPerHour As Decimal = 20D        ' Cost of Labor per Hour
    Const decTAX_RATE As Decimal = 0.06D          ' Tax Rate
    Dim decParts As Decimal                       ' Holds the amount for Parts Subtotal
    Dim decLabor As Decimal                       ' Holds the amount for Labor


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Assign values to labels of costs.
        lblOilChange.Text = "(" & decOilChange.ToString("c") & ")"
        lblLubeJob.Text = "(" & decLubeJob.ToString("c") & ")"
        lblRadiatorFlush.Text = "(" & decRadiatorFlush.ToString("c") & ")"
        lblTransmissionFlush.Text = "(" & decTransmissionFlush.ToString("c") & ")"
        lblInspection.Text = "(" & decInspection.ToString("c") & ")"
        lblReplaceMuffler.Text = "(" & decReplaceMuffler.ToString("c") & ")"
        lblTireRotation.Text = "(" & decTireRotation.ToString("c") & ")"
        lblLaborPerHour.Text = "(" & decLaborPerHour.ToString("c") & " per hour)"

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This procedure calculates and displays the totals of an order.
        Dim decSubTotal As Decimal  ' Holds the order subtotal
        Dim decTax As Decimal       ' Holds the sales tax
        Dim decTotal As Decimal     ' Holds the order total

        ' Verifies entered number for parts.
        If Decimal.TryParse(txtParts.Text, decParts) And decParts > -1 Then
        Else
            MessageBox.Show("Please enter a valid number 0 and above for parts field.")
            Exit Sub
        End If

        ' Verifies entered number for labor.
        If Decimal.TryParse(txtLabor.Text, decLabor) And decLabor > -1 Then
        Else
            MessageBox.Show("Please enter a valid number 0 and above for labor field.")
            Exit Sub
        End If

        ' Runs and adds the functions
        decSubTotal = Subtotal(OilLubeCharges(), FlushCharges(), MiscCharges(), OtherCharges())
        decTax = TaxCharges(decParts)
        decTotal = TotalCharges(decSubTotal, decTax)

        ' Displays the summary amounts
        lblServices.Text = decSubTotal.ToString("c")
        lblParts.Text = decParts.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This procedure resets the controls to default values.
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub



    Function OilLubeCharges() As Decimal
        ' This functions returns the cost of the selected Oil and Lube services.
        Dim decOilLubeCharges As Decimal = 0

        If chkOilChange.Checked = True Then
            decOilLubeCharges += decOilChange
        End If

        If chkLubeJob.Checked = True Then
            decOilLubeCharges += decLubeJob
        End If

        Return decOilLubeCharges

    End Function

    Function FlushCharges() As Decimal
        ' This functions returns the cost of the selected Flushes services.
        Dim decFlushCharges As Decimal = 0

        If chkRadiatorFlush.Checked = True Then
            decFlushCharges += decRadiatorFlush
        End If

        If chkTransmissionFlush.Checked = True Then
            decFlushCharges += decTransmissionFlush
        End If

        Return decFlushCharges

    End Function

    Function MiscCharges() As Decimal
        ' This functions returns the cost of the selected Misc services.
        Dim decMiscCharges As Decimal = 0

        If chkInspection.Checked = True Then
            decMiscCharges += decInspection
        End If

        If chkReplaceMuffler.Checked = True Then
            decMiscCharges += decReplaceMuffler
        End If

        If chkTireRotation.Checked = True Then
            decMiscCharges += decTireRotation
        End If

        Return decMiscCharges
    End Function

    Function OtherCharges() As Decimal
        ' This functions returns the cost of the entered Parts and Labor services.
        Return (decLaborPerHour * decLabor) + decParts
    End Function



    Function Subtotal(ByVal decOilAmount As Decimal, ByVal decFlushAmount As Decimal, ByVal decMiscAmount As Decimal, ByVal decOtherAmount As Decimal) As Decimal
        ' This function receives the amounts from the Oil, Flushes, Misc, and Other amounts, and returns the subtotal.
        Return decOilAmount + decFlushAmount + decMiscAmount + decOtherAmount
    End Function

    Function TaxCharges(ByVal decAmount As Decimal) As Decimal
        ' This functions receives the parts amount and returns the amount of sales tax.
        Return decAmount * decTAX_RATE
    End Function

    Function TotalCharges(ByVal SubTotal As Decimal, ByVal Tax As Decimal) As Decimal
        ' This function receives the other amounts and returns the total amount.
        Return SubTotal + Tax
    End Function



    Sub ClearOilLube()
        ' This procedure resets the Oil and Lube selections.
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub

    Sub ClearFlushes()
        ' This procedure resets the Flushes selections.
        chkRadiatorFlush.Checked = False
        chkTransmissionFlush.Checked = False
    End Sub

    Sub ClearMisc()
        ' This procedure resets the Misc selections.
        chkInspection.Checked = False
        chkReplaceMuffler.Checked = False
        chkTireRotation.Checked = False
    End Sub

    Sub ClearOther()
        ' This procedure resets the Other Services information.
        txtParts.Text = String.Empty
        txtLabor.Text = String.Empty
    End Sub

    Sub ClearFees()
        ' This procedure resets the Summary amount information.
        lblServices.Text = String.Empty
        lblParts.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

End Class
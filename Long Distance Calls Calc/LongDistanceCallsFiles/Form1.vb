' Written by Michael Kellar
' 9/30/2015
Option Strict On
Option Explicit On

Public Class Form1

    ' Create the Constant so they're available to Form Load and btnCalculate.
    Const dblDAY_RATE As Double = 0.07          ' Sets Constant for the Day Rate
    Const dblEVENING_RATE As Double = 0.12      ' Sets Constant for the Evening Rate
    Const dblOFF_PEAK_RATE As Double = 0.05     ' Sets Constant for the Off Peak Rate


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Setting the rate labels to show the proper rates based on the coding. 
        ' That way if the rates changes in the future, they only need to be changed in one spot.
        lblDayRate.Text = dblDAY_RATE.ToString("c") ' Displays the dblDAY_RATE into lblDayRate.
        lblEveningRate.Text = dblEVENING_RATE.ToString("c") ' Displays the dblEVENING_RATE into lblEvening.
        lblOffPeakRate.Text = dblOFF_PEAK_RATE.ToString("c") ' Displays the dblOFF_PEAK_RATE into lblOffPeakRate.

    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            ' Check if the minutes are more than 0.
            If CInt(txtMinutes.Text) > 0 Then
                ' Calculate and display the charges based on the radio button selected.
                If radDaytime.Checked = True Then
                    lblCharges.Text = (CInt(txtMinutes.Text) * dblDAY_RATE).ToString("c")
                End If
                If radEvening.Checked = True Then
                    lblCharges.Text = (CInt(txtMinutes.Text) * dblEVENING_RATE).ToString("c")
                End If
                If radOffPeak.Checked = True Then
                    lblCharges.Text = (CInt(txtMinutes.Text) * dblOFF_PEAK_RATE).ToString("c")
                End If
                ' Successful calculation message.
                lblStatus.Text = "Please check the Charges for your amount."
            Else
                ' Error message if Minutes is empty or below 1.
                lblStatus.Text = "Enter a Minute value that is a whole number and is more than 0."
            End If


        Catch
            ' Error message that appears when the Minutes is empty.
            MessageBox.Show("Please ensure that you select the Radio Button that applies, and enter a Minute value that is a whole number and is more than 0.")
        End Try



    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Reset to defaults. Set Radio button back to Daytime. 
        radDaytime.Checked = True
        ' Set Minutes to 0 and Charges cleared.
        txtMinutes.Text = "0"
        lblCharges.Text = "Calculate"
        ' Reset Status Strip
        lblStatus.Text = "Enter the information then click Calculate to Continue."


    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close form.
        Me.Close()
    End Sub






End Class

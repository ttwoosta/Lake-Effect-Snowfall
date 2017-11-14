' Program Name: Lake Effect Snowfall
' Author:       Tu Tong
' Date:         November 14, 2017
' Purpose:      This Lake Effect Snowfall application is written for the cities
'               along the Great Lakes to compute the total snowfall for 
'               the months Of October through April.

' Turn off automatic converion for values
Option Strict On

Public Class frmLakeEffect

    '
    ' Summary:
    '     Indicates which value type of the input message
    Enum InputBoxResult
        Positive = 1
        Negative = -1
        Cancelled = -2
        NonNumeric = -3
    End Enum

    ' Summary:
    '     Returns a InputBoxResult value indicating input message string
    '     can be converted to a number or it's a non-numeric string
    '     or Cancel button clicked.
    ' Parameters:
    '     InputMessage:
    '       Required. string input message
    ' Returns:
    '     Returns a InputBoxResult value indicating input message string 
    '     can be converted To a positive number.
    Function convertToInputBoxResult(InputMessage As String) As InputBoxResult

        If InputMessage = "" Then
            Return InputBoxResult.Cancelled
        End If

        If IsNumeric(InputMessage) Then

            ' Validate that the entered value is a positive number
            If Convert.ToDecimal(InputMessage) > 0 Then
                Return InputBoxResult.Positive
            End If

            Return InputBoxResult.Negative
        End If

        Return InputBoxResult.NonNumeric
    End Function

    Private Sub btnEnterSnowfallAmounts_Click(sender As Object, e As EventArgs) Handles btnEnterSnowfallAmounts.Click, mnuEnterSnowfallAmounts.Click
        ' The btnEnterSnowfallAmount click event handler accepts and displays
        ' up to 7 months of snowfall amounts on its ListBox, and then calculates
        ' and displays the total snowfall amount.

        ' declare and initialize variables
        Dim strSnowfallAmount As String
        Dim decSnowfallAmount As Decimal
        Dim decTotalSnowfallAmount As Decimal = 0D

        ' declare message box constants
        Const cstrInputHeading = "Snowfall Amount"
        Const cstrNormalMessage = "Enter the snowfall amount in inches for "
        Const cstrNonNumericError = "Error - Enter a number for the snowfall amount in inches of "
        Const cstrNegativeError = "Error - Enter a positive number for the snowfall amount of "
        Dim cstrMonths() As String = {"October", "November", "December", "January", "Feburary", "March", "April"}

        ' Declare and initialize variables that
        ' use with the Input Box function call
        Dim strInputMessage As String = cstrNormalMessage
        Dim ipbResult As InputBoxResult

        Const cintMaxNumberOfEntries As Integer = 7
        Dim intNumberOfEntries As Integer = 0

        ' This Do...Until loop allows the user enter the snowfall amount in inches
        ' from October through April. The loop terminates when the user has entered
        ' 7 time values or the user clicks the Cancel button or Close button in the
        ' InputBox dialog
        Do Until intNumberOfEntries >= cintMaxNumberOfEntries

            ' Display the InputBox if the number of entries entered less than 7
            strSnowfallAmount = InputBox(strInputMessage & cstrMonths(intNumberOfEntries), cstrInputHeading, " ")

            ' convert snowfall amount entered to InputBoxResult
            ipbResult = convertToInputBoxResult(strSnowfallAmount)

            Select Case ipbResult
                Case InputBoxResult.Positive
                    ' convert amount entered to decimal value
                    ' add the converted value to the listbox
                    ' accumulate the Total snowfall amount
                    ' update the number of entries

                    decSnowfallAmount = Convert.ToDecimal(strSnowfallAmount)
                    ' the RightToLeft property is True
                    lstSnowfallAmounts.Items.Add(decSnowfallAmount &
                                                 vbTab &
                                                 cstrMonths(intNumberOfEntries))
                    decTotalSnowfallAmount += decSnowfallAmount
                    intNumberOfEntries += 1

                Case InputBoxResult.Negative
                    ' displays a error message 
                    ' when user enter a negative value
                    strInputMessage = cstrNegativeError

                Case InputBoxResult.NonNumeric
                    ' displays an error message
                    ' when user enter a nonnumeric value
                    strInputMessage = cstrNonNumericError

                Case InputBoxResult.Cancelled
                    ' exit Do...Until loop when user click on 
                    ' Cancel Button Or Close() button on the InputBox
                    Exit Do

            End Select

        Loop

        If intNumberOfEntries > 0 Then
            ' Displays the total snowfall amount
            lblTotalSnowfallLabel.Visible = True
            lblTotalSnowfall.Visible = True
            lblTotalSnowfall.Text = decTotalSnowfallAmount.ToString("F") & " inches"

            ' disable enter snowfall amount button and menu item
            btnEnterSnowfallAmounts.Enabled = False
            mnuEnterSnowfallAmounts.Enabled = False
        Else
            ' user did not enter any value
            MsgBox("No snowfall amount entered")

        End If

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The procedure handle event when user click on Clear menu item
        ' It remove all items of the ListBox lstSnowfallAmounts
        ' hide Total Snowfall Amount labels
        ' and enable Enter Snowfall Amount button and menu item
        lstSnowfallAmounts.Items.Clear()
        lblTotalSnowfall.Visible = False
        lblTotalSnowfallLabel.Visible = False

        btnEnterSnowfallAmounts.Enabled = True
        mnuEnterSnowfallAmounts.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Terminate the application
        Close()

    End Sub

End Class

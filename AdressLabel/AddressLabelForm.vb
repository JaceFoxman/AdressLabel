'Jason Permann
'Spring 2025
'RCET2265
'Adress label
'https://github.com/JaceFoxman/AdressLabel.git

Option Compare Text
Option Explicit On
Option Strict On
Public Class AddressLabelForm
    Sub SetDefaults()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        ClearButton.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function UserInput() As Boolean
        Dim valid As Boolean = True
        Dim errorMessage As String

        If FirstNameTextBox.Text = "" Then
            valid = False
            FirstNameTextBox.Focus()
            errorMessage &= "Enter a First Name." & vbNewLine
        End If

        If LastNameTextBox.Text = "" Then
            valid = False
            LastNameTextBox.Focus()
            errorMessage &= "Enter a Last Name." & vbNewLine
        End If

        If StreetAddressTextBox.Text = "" Then
            valid = False
            StreetAddressTextBox.Focus()
            errorMessage &= "Enter a Street Adress." & vbNewLine
        End If

        If CityTextBox.Text = "" Then
            valid = False
            CityTextBox.Focus()
            errorMessage &= "Enter a City." & vbNewLine
        End If

        If StateTextBox.Text = "" Then
            valid = False
            StateTextBox.Focus()
            errorMessage &= "Enter a State." & vbNewLine
        End If

        If IsNumeric(ZipTextBox.Text) = False Then
            ZipTextBox.Focus()
            errorMessage &= "Enter A Numeric Zip Code." & vbNewLine
        End If

        If Not valid Then
            MsgBox(errorMessage, MsgBoxStyle.Exclamation, "User Input Fail")
        End If
        Return valid
    End Function

    Sub FormatDisplayLabel()
        DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine _
        & StreetAddressTextBox.Text & vbNewLine _
        & CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
    End Sub

    Sub Clear()
        DisplayLabel.Text = ""
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        If UserInput() Then
            FormatDisplayLabel()
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class

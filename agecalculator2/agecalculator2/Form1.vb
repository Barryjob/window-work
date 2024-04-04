Public Class AGECALCULATOR
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim today, tomonth, toyear As String
        Today = todaysdate_txt.Text
        tomonth = todaysdate_txt.Text
        toyear = todaysdate_txt.Text

        toyear = Date.Now.Year
        tomonth = Date.Now.Month
        Today = Date.Now.Day
        todaysdate_txt.Text = today.ToString + " / " + tomonth.ToString + " / " + toyear.ToString

        Label5.Text = "Your Age Is :........................"
    End Sub



    Private Sub calculate_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        Dim birthday, birthmonth, birthyear, resultyear, resultmonth, DaysInMonth, resultday As Integer
        Dim today, tomonth, toyear As Integer

        birthday = birthday_txt.Text
        birthmonth = birthmonth_txt.Text
        birthyear = birthyear_txt.Text

        'If (birthmonth < 1) Or (birthmonth > 12) Then
        birthmonth = birthmonth_txt.Text
        'MessageBox.Show("Invalid Input")

        ' End If



        ' If (birthyear < 0) Or (birthyear > Date.Now.Year) Then
        birthyear = birthyear_txt.Text
        'MessageBox.Show("Invalid Input")

        ' End If

        DaysInMonth = System.DateTime.DaysInMonth(birthyear, birthmonth)


       

        If (today > birthday) Then
            resultday = today - birthday
        ElseIf (today = birthday) Then
            resultday = today - birthday

        ElseIf (birthday > today) Then
            resultday = DaysInMonth + today - birthday
        End If




        If (tomonth > birthmonth) And (today > birthday) Then
            resultmonth = tomonth - birthmonth
        ElseIf (tomonth > birthmonth) And (today = birthday) Then
            resultmonth = tomonth - birthmonth

        ElseIf (tomonth > birthmonth) And (today < birthday) Then
            resultmonth = tomonth - 1 - birthmonth


        ElseIf (tomonth = birthmonth) And (birthday > today) Then
            resultmonth = 11

        ElseIf (today > birthday) And (tomonth < birthmonth) Then
            resultmonth = 12 + tomonth - birthmonth

        ElseIf (today = birthday) And (tomonth < birthmonth) Then
            resultmonth = 12 + tomonth - birthmonth

        ElseIf (today < birthday) And (tomonth < birthmonth) Then
            resultmonth = 11 + tomonth - birthmonth



        End If



        If (today > birthday) And (tomonth > birthmonth) And (birthyear < toyear) Then
            resultyear = toyear - birthyear

        ElseIf (today = birthday) And (tomonth > birthmonth) Then
            resultyear = toyear - birthyear
        ElseIf (today < birthday) And (tomonth > birthmonth) Then
            resultyear = toyear - birthyear
        ElseIf (toyear > birthyear) Then
            resultyear = toyear - birthmonth
        ElseIf (today > birthday) And (tomonth = birthmonth) Then
            resultyear = toyear - birthyear
        ElseIf (today = birthday) And (tomonth = birthmonth) Then
            resultyear = toyear - birthyear
        ElseIf (tomonth = birthmonth) And (today < birthday) Then
            resultyear = toyear - 1 - birthyear
        ElseIf (today > birthday) And (tomonth < birthmonth) Then
            resultyear = toyear - 1 - birthyear
        ElseIf (today = birthday) And (tomonth < birthmonth) Then
            resultyear = toyear - 1 - birthyear
        ElseIf (today < birthday) And (tomonth < birthmonth) Then
            resultyear = toyear - 1 - birthyear
            ' Else
            'If birthyear > toyear Then
            'MessageBox.Show("Invalid Invalid")
            ' End If
        End If


        TextBox1.Text = resultday
        TextBox2.Text = resultmonth
        TextBox3.Text = resultyear


    End Sub
End Class

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label1.Text = "X" Then
            Button1.Text = "X"
            Label1.Text = "0"
        Else
            Button1.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button1.Enabled = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label1.Text = "X" Then
            Button2.Text = "X"
            Label1.Text = "0"
        Else
            Button2.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button2.Enabled = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label1.Text = "X" Then
            Button3.Text = "X"
            Label1.Text = "0"
        Else
            Button3.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button3.Enabled = False
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Label1.Text = "X" Then
            Button4.Text = "X"
            Label1.Text = "0"
        Else
            Button4.Text = "0"
            Label1.Text = "X"
        End If
        Button4.Enabled = False
        Call win()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Label1.Text = "X" Then
            Button5.Text = "X"
            Label1.Text = "0"
        Else
            Button5.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button5.Enabled = False
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Label1.Text = "X" Then
            Button6.Text = "X"
            Label1.Text = "0"
        Else
            Button6.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button6.Enabled = False
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Label1.Text = "X" Then
            Button7.Text = "X"
            Label1.Text = "0"
        Else
            Button7.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button7.Enabled = False
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Label1.Text = "X" Then
            Button8.Text = "X"
            Label1.Text = "0"
        Else
            Button8.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button8.Enabled = False
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Label1.Text = "X" Then
            Button9.Text = "X"
            Label1.Text = "0"
        Else
            Button9.Text = "0"
            Label1.Text = "X"
        End If
        Call win()
        Button9.Enabled = False
    End Sub
    Private Sub win()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Label2.Text = "X wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button1.Text = "0" And Button2.Text = "0" And Button3.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button4.Text = "0" And Button5.Text = "0" And Button6.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button7.Text = "0" And Button8.Text = "0" And Button9.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button1.Text = "0" And Button4.Text = "0" And Button7.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button2.Text = "0" And Button5.Text = "0" And Button8.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button3.Text = "0" And Button6.Text = "0" And Button9.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button1.Text = "0" And Button5.Text = "0" And Button9.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
        If Button3.Text = "0" And Button5.Text = "0" And Button7.Text = "0" Then
            Label2.Text = "0 wins"
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Label2.Text = ""
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

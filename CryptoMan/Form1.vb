Imports CryptSharp

Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            Dim pwd As String = txtPassword.Text
            Dim roundsValue As Integer
            Dim opts As New CrypterOptions()

            If Integer.TryParse(txtRounds.Text, roundsValue) AndAlso roundsValue > 0 Then
                opts.Add(CrypterOption.Rounds, roundsValue)
                txtHash.Text = Crypter.Sha256.Crypt(pwd, opts)
            Else
                txtHash.Text = Crypter.Sha256.Crypt(pwd)
            End If
        Catch ex As Exception
            MessageBox.Show("Errore: " & ex.Message)
        End Try
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Try
            Dim pwd As String = txtPassword.Text
            Dim stored As String = txtStored.Text
            Dim matches As Boolean = Crypter.CheckPassword(pwd, stored)
            lblResult.Text = If(matches, "BRAVO! COMBACIA MINCHIA SEI BRAVO!", "NON COMBACIA UN CAZZO!")
            lblResult.ForeColor = If(matches, Drawing.Color.Green, Drawing.Color.Red)
        Catch ex As Exception
            MessageBox.Show("Errore: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        txtRounds.Clear()
        txtHash.Clear()
        txtStored.Clear()

        lblResult.Text = ""
        lblResult.ForeColor = Drawing.Color.Black
    End Sub

End Class

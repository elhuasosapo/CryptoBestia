Imports System
Imports System.Windows.Forms
Imports CryptSharp
' VB.NET WinForms Project - Sha256Crypt Form
' Purpose: Generate and verify sha256-crypt ($5$) hashes compatible with /etc/shadow
' Uses NuGet package: CryptSharpOfficial

' File: Sha256CryptForm.vb

Public Class Sha256CryptForm
    Inherits Form

    Private lblPassword As New Label()
    Private txtPassword As New TextBox()
    Private lblRounds As New Label()
    Private txtRounds As New TextBox()
    Private btnGenerate As New Button()
    Private txtHash As New TextBox()
    Private lblStored As New Label()
    Private txtStored As New TextBox()
    Private btnVerify As New Button()
    Private lblResult As New Label()

    Public Sub New()
        Me.Text = "Sha256-crypt ($5$) - Form"
        Me.Width = 600
        Me.Height = 400

        ' Password input
        lblPassword.Text = "Password in chiaro"
        lblPassword.Top = 20
        lblPassword.Left = 20
        txtPassword.Top = lblPassword.Bottom + 5
        txtPassword.Left = 20
        txtPassword.Width = 400
        txtPassword.PasswordChar = "*"c

        ' Rounds input
        lblRounds.Text = "Rounds (opzionale)"
        lblRounds.Top = txtPassword.Bottom + 15
        lblRounds.Left = 20
        txtRounds.Top = lblRounds.Bottom + 5
        txtRounds.Left = 20
        txtRounds.Width = 200

        ' Generate button
        btnGenerate.Text = "Genera Hash"
        btnGenerate.Top = txtRounds.Bottom + 10
        btnGenerate.Left = 20
        AddHandler btnGenerate.Click, AddressOf OnGenerate

        ' Hash output
        txtHash.Top = btnGenerate.Bottom + 10
        txtHash.Left = 20
        txtHash.Width = 500
        txtHash.Height = 60
        txtHash.Multiline = True

        ' Stored hash input for verification
        lblStored.Text = "Hash da verificare ($5$...)"
        lblStored.Top = txtHash.Bottom + 15
        lblStored.Left = 20
        txtStored.Top = lblStored.Bottom + 5
        txtStored.Left = 20
        txtStored.Width = 500
        txtStored.Height = 60
        txtStored.Multiline = True

        ' Verify button
        btnVerify.Text = "Verifica Hash"
        btnVerify.Top = txtStored.Bottom + 10
        btnVerify.Left = 20
        AddHandler btnVerify.Click, AddressOf OnVerify

        ' Result label
        lblResult.Top = btnVerify.Bottom + 15
        lblResult.Left = 20
        lblResult.Width = 400
        lblResult.Font = New Drawing.Font("Segoe UI", 10, Drawing.FontStyle.Bold)

        ' Add controls
        Me.Controls.Add(lblPassword)
        Me.Controls.Add(txtPassword)
        Me.Controls.Add(lblRounds)
        Me.Controls.Add(txtRounds)
        Me.Controls.Add(btnGenerate)
        Me.Controls.Add(txtHash)
        Me.Controls.Add(lblStored)
        Me.Controls.Add(txtStored)
        Me.Controls.Add(btnVerify)
        Me.Controls.Add(lblResult)
    End Sub

    Private Sub OnGenerate(sender As Object, e As EventArgs)
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

    Private Sub OnVerify(sender As Object, e As EventArgs)
        Try
            Dim pwd As String = txtPassword.Text
            Dim stored As String = txtStored.Text
            Dim matches As Boolean = Crypter.CheckPassword(pwd, stored)
            lblResult.Text = If(matches, "MATCH", "NO MATCH")
            lblResult.ForeColor = If(matches, Drawing.Color.Green, Drawing.Color.Red)
        Catch ex As Exception
            MessageBox.Show("Errore: " & ex.Message)
        End Try
    End Sub
End Class


Public Class FormCancel

    Private Sub FormCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Call frmMenu.majHeure(sender, e)
        ListBoxCancel.Items.Clear()
        Dim c As Commande
        Dim s As String
        For i = 100 To 600 Step 100
            For j = 1 To 16
                c = getCmde(i + j)
                If c.annul Then
                    s = i + j
                    ListBoxCancel.Items.Add(s)
                End If
            Next
        Next
    End Sub

    Private Sub ButtonRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        FormMenuFin.Show()
    End Sub

    Private Sub FormCancel_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text
    End Sub
End Class
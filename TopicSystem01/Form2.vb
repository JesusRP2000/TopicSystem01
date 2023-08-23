Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnigresar_Click(sender As Object, e As EventArgs) Handles btnigresar.Click
        Dim User As String
        Dim contra As String
        User = Txtusuario.Text
        contra = Txtcontraseña.Text
        If User = "Admin" And contra = "12345" Then
            Form3.Show()
        Else
            MsgBox("dsda")



        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles mostrar.CheckedChanged




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
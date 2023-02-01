Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class Form1
    Dim con As New SqlConnection(My.Settings.login2ConnectionString1)
    Dim conexion As conexion = New conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String
        Dim contraseña As String
        usuario = txt_usuario.Text
        contraseña = txt_contraseña.Text
        Dim verificar As String = "Update Usuario set Usuario = Usuario where Usuario = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL='Administrador'"
        If conexion.Verificacion(verificar) Then
            Me.Hide()
            MsgBox("Administrador")
            administrador.Show()
            txt_contraseña.Text = ""
            txt_usuario.Text = ""
        Else
            Dim verificar2 As String = "Update Usuario set Usuario=Usuario where Usuario = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL='Usuario'"
            If conexion.Verificacion(verificar2) Then
                Me.Hide()
                MsgBox("Usuario")
                usuario1.Show()
                txt_contraseña.Text = ""
                txt_usuario.Text = ""

            Else

                Dim verificar3 As String = "Update Usuario set Usuario=Usuario where Usuario= '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL='Secretario'"
                If conexion.Verificacion(verificar3) Then
                    Me.Hide()
                    MsgBox("Secretariado")
                    secretaria.Show()
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""
                Else
                    MsgBox("La contraseña o usuario son incorrectos intentelo nuevamente")
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""
                End If
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class

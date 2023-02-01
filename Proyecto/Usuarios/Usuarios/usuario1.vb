Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class usuario1
    Dim con As New SqlConnection(My.Settings.login2ConnectionString1)
    Dim mensaje, sentencia As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txt_mostrar_Click(sender As Object, e As EventArgs) Handles txt_mostrar.Click
        Dim da As New SqlDataAdapter("Select *from ADMINISTRADOR where ID = '" + txt_id.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
        Me.DataGridView1.Columns("contraseña").Visible = False
    End Sub

    Private Sub usuario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
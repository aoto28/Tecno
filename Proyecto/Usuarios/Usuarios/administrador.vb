Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class administrador
    Dim con As New SqlConnection(My.Settings.login2ConnectionString1)
    Dim mensaje, sentencia As String
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

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "Delete usuario where Usuario = '" + txt_usuario.Text + "'"
        mensaje = "datos eliminados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("select * from usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        sentencia = "Insert into Usuario values('" + txt_usuario.Text + "', '" + txt_contra.Text + "', '" + txt_rol.Text + "')"
        mensaje = "Datos ingresados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txt_contra.Text = ""
        txt_usuario.Text = ""
        txt_rol.Text = ""
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs)
        sentencia = "Update Usuario set Usuario = '" + txt_usuario.Text + "', CONTRASEÑA = '" + txt_contra.Text + "', ROLL = '" + txt_rol.Text + "'"
        mensaje = "Datos actualizados correctamente"
        ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from usuario", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txt_contra.Text = ""
        txt_usuario.Text = ""
        txt_rol.Text = ""
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub txt_mostrar2_Click(sender As Object, e As EventArgs) Handles txt_mostrar2.Click
        Try
            Dim da As New SqlDataAdapter("select * from ADMINISTRADOR", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
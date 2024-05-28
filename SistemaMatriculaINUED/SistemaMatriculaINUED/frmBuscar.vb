Imports System.Data.OleDb
Public Class frmBuscar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jeft.Oledb.4.0; Data SourceD:\2024\SEGUNDO PARCIAL\VisualBasic256\Base de Datos\matriculaINUED(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("Registro Encontrado",, "Buscar")

            Dim query = "Select * from MAESTRO where DNImaestro Like'" & txtBuscar.Text & "%'"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGrafica_Click(sender As Object, e As EventArgs) Handles btnGrafica.Click
        frmGrafica.Show()
    End Sub
End Class
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim DT As New DataTable

    <Obsolete>
    Public Function FillData(ByVal strSQL As String) As System.Data.DataTable
        Dim con As New System.Data.SqlClient.SqlConnection
        con.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings("ConString")
        Dim cmd As System.Data.SqlClient.SqlCommand
        Dim myDA As System.Data.SqlClient.SqlDataAdapter
        Dim myDataSet = New System.Data.DataSet

        cmd = New System.Data.SqlClient.SqlCommand(strSQL, con)
        If con.State = System.Data.ConnectionState.Closed Then con.Open()
        myDA = New System.Data.SqlClient.SqlDataAdapter(cmd)
        myDA.Fill(myDataSet, "table")
        con.Close()
        con.Dispose()
        Return myDataSet.Tables("table")
    End Function

    <Obsolete>
    Public Function excuteSQL(ByVal strSQL) As Integer
        Dim strConnect As String = System.Configuration.ConfigurationSettings.AppSettings("ConString").ToString()
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(strConnect)
        Dim cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand(strSQL, con)
        con.Open()
        Dim kq As Integer = cmd.ExecuteNonQuery()
        con.Close()
        Return kq
    End Function

    <Obsolete>
    Protected Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        'If Page.IsValid Then
        '    ' check for username & password in the database
        '    Dim conn As New SqlConnection("Data Source=localhost\SQLEXPRESS04;Initial Catalog=Test;Integrated Security=true")

        '    ' Get the row corresponding the given username and password
        '    Dim strSQL As String = "Select * From tblTaiKhoan Where TenTaiKhoan='" + txtUsername.Text + "' and MatKhau = '" + txtPassword.Text + "'"
        '    'I recommend not to use * in querys
        '    Dim dsc As New SqlClient.SqlCommand(strSQL, conn)
        '    conn.Open()
        '    Dim dr As SqlDataReader
        '    dr = dsc.ExecuteReader()
        DT = FillData("Select * From tblTaiKhoan Where TenTaiKhoan='" + txtUsername.Text + "' and MatKhau = '" + txtPassword.Text + "'")
        If DT.Rows.Count = 1 Then
            Session("IDTaiKhoan") = DT.Rows(0).Item("IDTaiKhoan").ToString
            Session("TenTaiKhoan") = DT.Rows(0).Item("TenTaiKhoan").ToString
            Response.Redirect("Default.aspx")
        Else
            lbThongbao.Text = "Dang nhap khong thanh cong"
        End If

    End Sub
End Class
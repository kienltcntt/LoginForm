Public Class WebForm3
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
    Protected Sub btnDoiMatKhau_Click(sender As Object, e As EventArgs) Handles btnDoiMatKhau.Click
        DT = FillData("select * from tblTaiKhoan where MatKhau ='" + txtOldpw.Text + "'")
        If (DT.Rows.Count > 0) Then
            FillData("update tblTaiKhoan set MatKhau='" + txtNewPW.Text + "' where TenTaiKhoan='" + Session("TenTaiKhoan").ToString() + "'")
            lblmsg.Text = "Password changed successfully"
            lblmsg.ForeColor = System.Drawing.Color.Green
        Else
            lblmsg.Text = "Invalid current password"
            lblmsg.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbTenTaiKhoan.Text = Session("TenTaiKhoan").ToString
    End Sub
End Class
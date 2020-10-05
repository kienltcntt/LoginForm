<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="QLTK.aspx.vb" Inherits="LoginForm.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 371px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td colspan="2">Quản lý đổi mật khẩu tài khoản :
                <asp:Label ID="lbTenTaiKhoan" runat="server" Text="lbusername"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mật khẩu cũ :</td>
            <td>
                <asp:TextBox ID="txtOldpw" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mật khẩu mới :</td>
            <td>
                <asp:TextBox ID="txtNewPW" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nhập lại mật khẩu :</td>
            <td>
                <asp:TextBox ID="txtReenterpw" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPW" ControlToValidate="txtReenterpw">Password not same</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnDoiMatKhau" runat="server" Text="Đổi mật khẩu" />
            </td>
            <td>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

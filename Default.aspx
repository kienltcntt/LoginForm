<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Default.aspx.vb" Inherits="LoginForm.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbmsg" runat="server" Text="Chào tài khoản :"></asp:Label>
    <asp:Label ID="lbusername" runat="server"></asp:Label>
&nbsp;<br />
    <asp:Button ID="btnLogout" runat="server" Text="Đăng xuất" />
&nbsp;
</asp:Content>

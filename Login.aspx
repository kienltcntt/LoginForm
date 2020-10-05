<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="LoginForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            background-color: darkcyan;
        }
        table {
            text-align: center;
            margin-left: auto;
            margin-right: auto;
            margin-top: 200px;
            border: 2px solid black;
            width: 3px;
            height: 3px;
        }
        input {
            width: 500px;
            padding: 5px;
            font-size: inherit;
            border: 2px solid green;
            margin-bottom: 0px;
            background: #FAF6D9;
            display: block;
        }        
        input:focus {
            background: white;
        }
        h1 {
            text-align: center;
            font-size: 50px;
            color: aquamarine;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Demo</h1>   
            <table class="table">
                <tr>
                    <td colspan="3">

                        Login</td>
                </tr>
                <tr>
                    <td class="hang3">
                        Username:
                    </td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>
                    <td rowspan="3">
                        <img src="https://upload.wikimedia.org/wikipedia/vi/8/80/FPT_New_Logo.png" style="width:150px;height:175px;" />
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
              
                <tr>
                    <td></td>
                    <td style="padding-left: 310px">
                        <asp:Button ID="btnDangnhap" runat="server" Text="Dang Nhap" Width="206px"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        
                        <asp:Label ID="lbThongbao" runat="server" ForeColor="#CC3300"></asp:Label>
                        
                    </td>
                </tr>
            </table>

            </form>

            </body>
</html>

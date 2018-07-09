<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="NewsReleaseSystem.BackDesk.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body
        {
            position: relative;
            width:30%;
            margin-left: 250px;
            text-align: center;
            margin-top: 105px;
            color: #606060;
            font-size: 12px;
        }
        .titleSystemName
        {
	        font-size: 25px;
	        font-weight: bolder;
            margin-left: 10px;
	        color: #009966;
        }
        td
        { 
            line-height:21px;
        }
        .style1
        {
            width: 185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:280px" >
                <tr>
                    <td class="style1 " colspan="3">
                        <div class="titleSystemName">
                            添加管理员账户
                        </div>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style ="height: 50px;">
                        <span >用户姓名</span>:
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="username" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td  style ="height :40px;">
                        <span >用户密码</span>:
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="pwd" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style ="height :60px;" colspan="2">
                        <asp:Button ID="add" runat="server" Text="添加" OnClick="add_Click" Width="74px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="reset" runat="server" Text="取消" OnClick="reset_Click" Width="74px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="margin-left: 20px;">
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

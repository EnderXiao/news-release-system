<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="NewsReleaseSystem.BackDesk.AddNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .txtwid
        {
            width: 344px;
        }
        body
        {
            width: 810px;
            color: #606060;
            font-size: 12px;
            border: solid 1px #6AC0FF;
        }
        .titleSystemName
        {
            float: left;
            margin-left: 350px;
            font-size: 20px;
            font-weight: bolder;
            color: #ffffff;
        }
        .style1
        {
            background-color: #66ccff;
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="810px">
                <tr>
                    <td class="style1 " colspan="3">
                        <div class="titleSystemName">
                            添加新闻
                        </div>
                    </td>
                </tr>
                <tr>
                    <td style="width: 170px; height: 28px; text-align: right;">
                        新闻类别：
                    </td>
                    <td>
                        <asp:DropDownList ID="dlstNewsType" runat="server" AutoPostBack="True" Width="348px">
                            <asp:ListItem>国际新闻</asp:ListItem>
                            <asp:ListItem>国内新闻</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;
                        <asp:Label ID="labTitle" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; width: 170px; height: 28px;">
                        新闻标题：
                    </td>
                    <td>
                        <asp:TextBox ID="txtNewsTitle" runat="server" CssClass="txtwid" MaxLength="15"></asp:TextBox>
                        <span style="text-align: left;">*字数在12字以内</span>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNewsTitle"
                            ErrorMessage="*标题必填" Width="118px"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; width: 170px; height: 28px;">
                        新闻内容：
                    </td>
                    <td>
                        <asp:TextBox ID="txtNewsContent" runat="server" Height="211px" TextMode="MultiLine"
                            CssClass="txtwid"></asp:TextBox>
                    </td>
                    <td style="width: 85px; text-align: left;">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewsContent"
                            ErrorMessage="*内容必填" Width="128px"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td style="width: 383px; height: 26px;">
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="添加" Width="74px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnReset" runat="server" CausesValidation="False" OnClick="btnReset_Click"
                            Text="取消" Width="74px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center;padding-left: 80px;">
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

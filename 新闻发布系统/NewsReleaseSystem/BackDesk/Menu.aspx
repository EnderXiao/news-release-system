<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="NewsReleaseSystem.BackDesk.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .main
        {
            width: 180px;
            color: #606060;
            font-size: 12px;
        }
        .style1
        {
            background-color: #66ccff;
            height: 30px;
        }
        .titleSystemName
        {
            float: left;
            padding-left: 20px;
            font-size: 20px;
            font-weight: bolder;
            color: #ffffff;
        }
    </style>
</head>
<body>
    <div width="100%">
    <form id="form1" runat="server">
        <div class="main">
            <table style="width: 180px;border: solid 1px #6AC0FF;" cellspacing="0" cellpadding="0">
                <tr>
                    <td class="style1 ">
                        <div class="titleSystemName">导航栏</div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TreeView ID="TreeView1" runat="server" NodeIndent="15" Width="155px">
                            <ParentNodeStyle Font-Bold="False" />
                            <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
                            <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px"
                                VerticalPadding="0px" />
                            <Nodes>
                                <asp:TreeNode Text="环球经济" Value="环球经济">
                                    <asp:TreeNode NavigateUrl="AddNews.aspx?id=2" Target="right" Text="添加新闻" Value="添加新闻">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="NewsManage.aspx?id=2" Target="right" Text="管理新闻" Value="管理新闻">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="军事世界" Value="军事世界">
                                    <asp:TreeNode NavigateUrl="AddNews.aspx?id=3" Target="right" Text="添加新闻" Value="添加新闻">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="NewsManage.aspx?id=3" Target="right" Text="管理新闻" Value="管理新闻">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="科学技术" Value="科学技术">
                                    <asp:TreeNode NavigateUrl="AddNews.aspx?id=4" Target="right" Text="添加新闻" Value="添加新闻">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="NewsManage.aspx?id=4" Target="right" Text="管理新闻" Value="管理新闻">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="生活理财" Value="生活理财">
                                    <asp:TreeNode NavigateUrl="AddNews.aspx?id=5" Target="right" Text="添加新闻" Value="添加新闻">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="NewsManage.aspx?id=5" Target="right" Text="管理新闻" Value="管理新闻">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="社会百态" Value="社会百态">
                                    <asp:TreeNode NavigateUrl="AddNews.aspx?id=6" Target="right" Text="添加新闻" Value="添加新闻">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="NewsManage.aspx?id=6" Target="right" Text="管理新闻" Value="管理新闻">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="世界体育" Value="世界体育">
                                    <asp:TreeNode NavigateUrl="AddNews.aspx?id=7" Target="right" Text="添加新闻" Value="添加新闻">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="NewsManage.aspx?id=7" Target="right" Text="管理新闻" Value="管理新闻">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="娱乐综艺" Value="娱乐综艺">
                                    <asp:TreeNode NavigateUrl="AddNews.aspx?id=8" Target="right" Text="添加新闻" Value="添加新闻">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="NewsManage.aspx?id=8" Target="right" Text="管理新闻" Value="管理新闻">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="用户管理" Value="用户管理">
                                    <asp:TreeNode NavigateUrl="~/BackDesk/AddUser.aspx" Target="right" Text="添加用户" Value="添加用户">
                                    </asp:TreeNode>
                                    <asp:TreeNode NavigateUrl="~/BackDesk/UserManage.aspx" Target="right" Text="管理用户" Value="管理用户">
                                    </asp:TreeNode>
                                </asp:TreeNode>
                            </Nodes>
                            <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px"
                                NodeSpacing="0px" VerticalPadding="2px" />
                        </asp:TreeView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    </div>
</body>
</html>

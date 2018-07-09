<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManage.aspx.cs" Inherits="NewsReleaseSystem.BackDesk.UserManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .titleSystemName
        {
	        font-size: 25px;
	        font-weight: bolder;
            margin-left: 10px;
	        color: #009966;
        }
        .style1
        {
            width: 185px;
        }
        .txtwid
        {
            width: 383px;
        }
        body
        {
            position: relative;
            width: 700px;
            margin-left: 80px;
            text-align: center;
            margin-top: 105px;
            color: #606060;
            font-size: 12px;
        }
        /* 未访问前的样式 */
        A:link
        {
	        color: #606060;
	        font-size: 12px;
	        text-decoration: none;
        }
        /* 鼠标激活样式 */
        A:visited
        {
	        color: #606060;
	        font-size: 12px;
	        text-decoration: none;
        }
        /* 鼠标悬停时的样式 */
        A:hover
        {
	        color: #009966;
	        font-size: 12px;
	        text-decoration: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellSpacing="0" cellPadding="0" width="100%" align="center" border="0">
                <tr>
                    <td class="style1 " colspan="3">
                        <div class="titleSystemName">
                            添加管理员账户
                        </div>
                        <br />
                    </td>
                </tr>
			    <tr>
				    <td align="left">
                        <span  style ="float: right;">
						    <asp:HyperLink ID="HyperLink1" runat="server" style="text-align: center" 
                                NavigateUrl="~/BackDesk/Index.aspx" Target="_parent">返回首页</asp:HyperLink>
                        </span>
				    </td> 
			    </tr>
			    <tr>
				    <td>
	                    <asp:GridView ID="gdvUserManage" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            DataKeyNames ="ID"  Width="100%" HorizontalAlign="Center" OnPageIndexChanging="gdvUserManage_PageIndexChanging"
                            OnRowCancelingEdit="gvEditAdmin_RowCancelingEdit" OnRowDeleting="gvEditAdmin_RowDeleting"
                            OnRowEditing="gvEditAdmin_RowEditing" OnRowUpdating="gvEditAdmin_RowUpdating" CellPadding="3" BackColor="White">
					        <HeaderStyle Font-Bold="True"  BackColor="#6AC0FF" ForeColor="White"></HeaderStyle>
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="用户编号" ReadOnly="True" HeaderStyle-HorizontalAlign="Center">
                                    <ItemStyle HorizontalAlign="Center" Width="120px" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Name" HeaderText="用户姓名" HeaderStyle-HorizontalAlign="Center" >
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="PassWord" HeaderText="用户密码" HeaderStyle-HorizontalAlign="Center" >
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:CommandField ShowDeleteButton="True" HeaderText="操作" HeaderStyle-HorizontalAlign="Center">
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle HorizontalAlign="Center" Width="50px" />
                                </asp:CommandField>
                                <asp:CommandField ShowEditButton="True" HeaderText="操作"   
                                    HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:CommandField>
                            </Columns>
                            <FooterStyle BackColor="White" ForeColor="#000066" />
                            <RowStyle ForeColor="#000066" />
                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
				    </td>
			    </tr>
		    </table>
        </div>
    </form>
</body>
</html>

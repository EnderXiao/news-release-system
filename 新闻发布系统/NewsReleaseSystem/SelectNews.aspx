<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="SelectNews.aspx.cs" Inherits="NewsReleaseSystem.SelectNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%">
        <tr style="background-color: #66ccff;">
            <td style="text-align: left; height: 22px; padding-left: 15px">
                <asp:Label ID="lblType" runat="server" Style="font-weight: 700;color: #FFFFFF; font-size: large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="dlstNews" runat="server" CellPadding="3" OnItemCommand="dlstNews_ItemCommand"
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                    GridLines="Both">
                    <ItemTemplate>
                        <table style="font-size: 9pt;">
                            <tr>
                                <td class="dtd2">
                                    &nbsp;&nbsp;<asp:LinkButton ID="LinkButton1" runat="server"><%#DataBinder.Eval(Container.DataItem,"Title") %></asp:LinkButton>
                                </td>
                                <td style="width: 150px">
                                    <%#DataBinder.Eval(Container.DataItem, "IssueDate")%>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/mainMaster.Master" AutoEventWireup="true" CodeBehind="NewsDetail.aspx.cs" Inherits="NewsReleaseSystem.NewsDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">
        <asp:Label ID="labTitle" runat="server"></asp:Label>
    </h1>
    <br/>
    <p style="width:70%;margin:0 auto;">
        <span style="width: 50%;padding-left: 55px;font-size: 14px;line-height: 23.0px;word-break: break-all;">
            <%=GetContent()%>
        </span>
    </p>
    <br/>
</asp:Content>
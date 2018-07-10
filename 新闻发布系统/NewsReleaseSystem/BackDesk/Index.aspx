<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="NewsReleaseSystem.BackDesk.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div style="height: 50px;width: 1000px;margin: 0 auto;">
        <iframe name="top" src="head.html" frameborder="NO" width="100%" border="0" framespacing="0" topmargin="0"
            leftmargin="0" marginheight="0" marginwidth="0" scrolling="no" height="50px;"></iframe>
    </div>
    <div style="width: 1000px;height: 600px;margin: 0 auto;margin-top: 10px;">
        <div style="width: 190px;float: left;">
            <iframe name="menu" src="Menu.aspx" frameborder="NO" width="190px" border="0" framespacing="0" topmargin="0"
                leftmargin="0" marginheight="0" marginwidth="0" scrolling="no" height="590px"></iframe>
        </div>
        <div style="width: 810px;height: 580px;float: left;">
            <iframe name="right" src="Main.aspx" frameborder="NO" width="810px" height="580px" border="0" framespacing="0" topmargin="0"
                leftmargin="0" marginheight="0" marginwidth="0"></iframe>
        </div>
    </div>
</body>
</html>

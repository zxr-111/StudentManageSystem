<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 399px;
            margin-left: 282px;
        }
        .auto-style2 {
            width: 639px;
            height: 366px;
        }
        .auto-style3 {
            width: 286px;
            height: 344px;
            margin-left: 650px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="LabelTitle" class="auto-style1">
            <asp:Label ID="LabelDetailTitle" runat="server" Text="Label"></asp:Label>
        </div>
        <p id="BtnBack">
            <asp:LinkButton ID="BtnBackList" runat="server">LinkButton</asp:LinkButton>
        </p>
        <p id="LabelCourse" class="auto-style2">
            <asp:Label ID="LabelBook" runat="server" Text="Label"></asp:Label>
            <img id="IMGCourse" alt="" class="auto-style3" src="" /></p>
    </form>
</body>
</html>

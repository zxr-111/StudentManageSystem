<%@ Page Language="C#" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 305px;
            margin-left: 360px;
        }
        .auto-style2 {
            width: 458px;
            margin-left: 240px;
        }
        .auto-style3 {
            margin-left: 60px;
        }
        .auto-style4 {
            margin-left: 25px;
        }
        .auto-style5 {
            width: 317px;
            margin-left: 411px;
        }
        .auto-style6 {
            width: 109px;
            margin-left: 20px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="LabelTitle" class="auto-style1">
            <asp:Label ID="LabelTitle" runat="server" Text="Label"></asp:Label>
        </div>
    <p class="auto-style2">
        <asp:DropDownList ID="DDLSearchBook" runat="server" Height="16px" Width="284px">
        </asp:DropDownList>
        <asp:Label ID="LabelSearch" runat="server" Text="Label"></asp:Label>
        </p>
            <asp:ImageButton ID="ImageButton1" runat="server" CssClass="auto-style3" Height="145px" Width="100px" />
&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton3" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton4" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton5" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton6" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton7" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
&nbsp;<p>
            <asp:ImageButton ID="ImageButton8" runat="server" CssClass="auto-style3" Height="145px" Width="100px" />
&nbsp;<asp:ImageButton ID="ImageButton9" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton10" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton11" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton12" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton13" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
            <asp:ImageButton ID="ImageButton14" runat="server" CssClass="auto-style4" Height="145px" Width="100px" />
        </p>
        <p class="auto-style5">
            <asp:DataPager ID="DataPager" runat="server">
                <Fields>
                    <asp:NumericPagerField />
                </Fields>
            </asp:DataPager>
        </p>
        <p class="auto-style6">
            <asp:LinkButton ID="BtnBackPrimary" runat="server">LinkButton</asp:LinkButton>
        </p>
    </form>
    </body>
</html>

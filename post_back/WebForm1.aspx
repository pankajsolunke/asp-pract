<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="post_back.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
        </div>
        <p>
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
        </p>
    </form>
</body>
</html>

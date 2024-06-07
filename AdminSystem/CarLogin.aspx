<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarLogin.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 59px; top: 52px; position: absolute" Text="username"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 58px; top: 105px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtusername" runat="server" style="z-index: 1; left: 191px; top: 53px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtpassword" runat="server" style="z-index: 1; left: 173px; top: 110px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 141px; top: 205px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 248px; top: 211px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#990000" style="z-index: 1; left: 433px; top: 125px; position: absolute"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Do you want to delete it?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 25px; top: 110px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 139px; top: 108px; position: absolute" Text="No" />
    </form>
</body>
</html>

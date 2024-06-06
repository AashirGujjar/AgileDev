﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 121px; top: 104px; position: absolute" Text="Car Maker" width="88px"></asp:Label>
        </div>
        <p>
           &nbsp;</p>
        <asp:TextBox ID="txtMaker" runat="server" style="z-index: 1; left: 334px; top: 99px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 121px; top: 156px; position: absolute" Text="Model" width="88px"></asp:Label>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 334px; top: 149px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 121px; top: 204px; position: absolute; height: 20px; width: 160px" Text="Manufacturing Year"></asp:Label>
        <asp:TextBox ID="txtYear" runat="server" style="z-index: 1; left: 334px; top: 201px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 121px; top: 264px; position: absolute" Text="Color" width="88px"></asp:Label>
        <p>
            <asp:TextBox ID="txtColor" runat="server" style="z-index: 1; left: 334px; top: 263px; position: absolute" width="168px"></asp:TextBox>
            <asp:TextBox ID="txtPurchaseDate" runat="server" style="z-index: 1; left: 334px; top: 382px; position: absolute" width="168px"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 121px; top: 322px; position: absolute" Text="Price" width="88px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 627px; top: 135px; position: absolute; height: 29px" Text="OK" />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 121px; top: 53px; position: absolute">vinNumber</asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 121px; top: 380px; position: absolute" Text="Purchase Date" width="88px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 334px; top: 323px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtvinNum" runat="server" style="z-index: 1; left: 334px; top: 51px; position: absolute" width="168px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 612px; top: 223px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 601px; top: 325px; position: absolute"></asp:Label>
    </form>
</body>
</html>
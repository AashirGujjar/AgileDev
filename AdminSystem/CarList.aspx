<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 715px">
    <form id="form1" runat="server">
        <div style="height: 512px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server"  Text="Add" OnClick="btnAdd_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server"  Text="Update" OnClick="btnUpdate_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server"  Text="Delete" OnClick="btnDelete_Click" />
            <br />
            <br />
            <asp:Button ID="btnMainMenu" runat="server"  style="z-index: 1; left: 623px; top: 35px; position: absolute; width: 96px; bottom: 632px;" Text="Return To Main Menu" OnClick="btnMainMenu_Click" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Enter the Model"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFilter" runat="server" Text="Apply Filter" OnClick="btnFilter_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    &nbsp;<asp:ListBox ID="lstModelList" runat="server" style="z-index: 1; left: 23px; top: 29px; position: absolute; height: 220px; width: 354px"></asp:ListBox>
        <p>
            &nbsp;</p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 651px; top: 111px; position: absolute"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>

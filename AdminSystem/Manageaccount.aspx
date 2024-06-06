<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageAccount.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Manage Account</title>
    <style>
        .container {
            width: 80%;
            margin: auto;
            margin-top: 20px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        table, th, td {
            border: 1px solid black;
        }
        th, td {
            padding: 10px;
            text-align: left;
        }
        th {
            background-color: #f2f2f2;
        }
        .actions {
            margin-top: 20px;
            text-align: right;
        }
    </style>
    <script type="text/javascript">
        function confirmDelete() {
            return confirm("Do you really want to delete your account?");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Manage Account</h2>
            <asp:GridView ID="GridViewAccount" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" 
                OnRowEditing="GridViewAccount_RowEditing" 
                OnRowCancelingEdit="GridViewAccount_RowCancelingEdit" 
                OnRowUpdating="GridViewAccount_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="User Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Password" HeaderText="Password" />
                    <asp:BoundField DataField="Role" HeaderText="Role" ReadOnly="True" />
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
            </asp:GridView>
            <div class="actions">
                <asp:Button ID="btnDeleteAccount" runat="server" Text="Delete My Account" OnClientClick="return confirmDelete();" OnClick="btnDeleteAccount_Click" />
            </div>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manageusers.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Manage Users</title>
   <style>
        .container {
            width: 80%;
            margin: auto;
            text-align: center;
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
            text-align: right;
            margin-top: 20px;
        }
        .actions button {
            margin-left: 10px;
        }
        .logout-button {
            position: absolute;
            top: 10px;
            right: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Manage Users</h1>
            <asp:GridView ID="GridViewUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" 
                CssClass="manage-users-table" 
                OnRowEditing="GridViewUsers_RowEditing" 
                OnRowCancelingEdit="GridViewUsers_RowCancelingEdit" 
                OnRowUpdating="GridViewUsers_RowUpdating" 
                OnRowDeleting="GridViewUsers_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="User ID" ReadOnly="True" />
                    <asp:BoundField DataField="UserName" HeaderText="User Name" />
                    <asp:BoundField DataField="Password" HeaderText="Password" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Role" HeaderText="Role" />
                    <asp:CheckBoxField DataField="IsActive" HeaderText="Active" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            <div class="actions">
               
                <asp:Button ID="btnLogout" runat="server" OnClick="BtnLogout_Click" Text="Logout" CssClass="logout-button" />
            </div>
        </div>
    </form>
</body>
</html>
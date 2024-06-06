<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Admin Dashboard</title>
    <style>
        .container {
            width: 80%;
            margin: auto;
            text-align: center;
            margin-top: 50px;
        }
        .card {
            border: 1px solid #ccc;
            padding: 20px;
            margin: 10px;
            box-shadow: 2px 2px 12px #aaa;
            display: inline-block;
            width: 300px;
            height: 200px;
            vertical-align: top;
        }
        .card h3 {
            margin-top: 0;
        }
        .card button {
            margin-top: 20px;
            padding: 10px 20px;
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
        }
        .card button:hover {
            background-color: #0056b3;
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
            <h1>Welcome, Admin <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label></h1>
            <div class="card">
                <h3>Manage Users</h3>
                <p>View and manage all users.</p>
                <button type="button" onclick="window.location.href='ManageUsers.aspx'">Go to Manage Users</button>
            </div>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="logout-button" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>

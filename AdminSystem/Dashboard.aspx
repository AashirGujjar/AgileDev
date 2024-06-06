<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Dashboard</title>
    <style>
        .logout-button {
            position: absolute;
            top: 10px;
            right: 10px;
        }
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Welcome, <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label></h2>
            <div class="card">
                <h3>Manage Account</h3>
                <p>View and manage your account details.</p>
                <button type="button" onclick="window.location.href='ManageAccount.aspx'">Go to Manage Account</button>
            </div>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="logout-button" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>

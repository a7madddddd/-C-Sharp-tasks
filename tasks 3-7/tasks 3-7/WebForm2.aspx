<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="tasks_3_7.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Result:
     <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label><br /><br />
        </div>
        <div>
            Number 1:
            <asp:TextBox ID="number1" runat="server"></asp:TextBox><br />
            <br />
            Number 2:
            <asp:TextBox ID="number2" runat="server"></asp:TextBox><br />
            <br />
        </div>
        <div class="con">
            <asp:Button Style="width: 200px; height: 100px; background-color: red;" ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
            <asp:Button Style="width: 200px; height: 100px; background-color: red;" ID="Button2" runat="server" Text="-" OnClick="Button2_Click" />
            <asp:Button Style="width: 200px; height: 100px; background-color: red;" ID="Button3" runat="server" Text="*" OnClick="Button3_Click" />
            <asp:Button Style="width: 200px; height: 100px; background-color: red;" ID="Button4" runat="server" Text="/" OnClick="Button4_Click" />
        </div>
        <br />

    </form>
</body>
</html>

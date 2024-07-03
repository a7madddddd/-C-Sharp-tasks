<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebForm1</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            Email: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            ID: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
            Gender: 
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Female" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Male" /><br /><br />
            Courses: 
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C++" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C#" /><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label9" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label12" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label15" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>

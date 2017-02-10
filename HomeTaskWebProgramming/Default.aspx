<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HomeTaskWebProgramming.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('images/blye.jpg'); background-size: cover; cursor: url(cursor/1.cur), pointer">
<form id="form1" runat="server">
    <div align="center">

        <br/>
        <br/>
        <br/>
        <asp:Button ID="Button1" runat="server" BackColor="Red" BorderStyle="Dotted" BorderWidth="5px" Font-Size="XX-Large" ForeColor="Yellow" Height="94px" Text="Log In Page" Width="857px"/>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Enter your namee"></asp:Label>
        :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="221px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter your name" ForeColor="#990000"></asp:RequiredFieldValidator>

    </div>
</form>
</body>
</html>
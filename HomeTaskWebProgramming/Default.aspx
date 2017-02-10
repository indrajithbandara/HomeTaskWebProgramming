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
        <asp:Button ID="Button1" runat="server" BackColor="Red" BorderStyle="Dotted" BorderWidth="5px" Font-Size="XX-Large" style="background-image: url('images/blye.jpg'); background-size: cover; cursor: url(cursor/2.cur), pointer" ForeColor="Yellow" Height="94px" Text="Log In Page" Width="857px"/>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Enter your name"></asp:Label>
        :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="221px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter your name" ForeColor="#990000"></asp:RequiredFieldValidator>

        <br />
&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="LoginButton" runat="server" OnClick="Button2_Click" Text="Login" BackColor="#FFCC99" Font-Size="Large" ForeColor="Yellow" Height="29px" Width="85px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Names="Centaur" Font-Size="XX-Large" ForeColor="White" Text="i140535"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Names="Centaur" Font-Size="XX-Large" ForeColor="White" Text="Hamza Anis "></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Names="Centaur" Font-Size="XX-Large" ForeColor="White" Text="Sir Atif Jilani"></asp:Label>
        <br />
        <br />
        <br />
        <br />

    </div>
</form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="HomeTaskWebProgramming.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
</head>
<body  style="background-image: url('images/21.jpg'); background-size: cover; cursor: url(cursor/1.cur), pointer">
    <form id="form1" runat="server">
    <div>
        <div>
            
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
            
        </div>
    <div>
        <div  style=" width:400px; margin: auto; background-color: #C0C0C0;">
        <asp:Table ID="Table1" runat="server" CssClass="table table-hover" Font-Size="Large" >
         </asp:Table>            
         </div>
        <br />
<%--         <center>--%>
<%--         <asp:Button ID="Button1" runat="server" Text="Client #"  CssClass="btn btn-warning" OnClick="Button1_Click" />--%>
<%--         <asp:Button ID="Button2" runat="server" Text="IP Address"  CssClass="btn btn-success" OnClick="Button2_Click" />--%>
<%--         <asp:Button ID="Button3" runat="server" Text="Status"  CssClass="btn btn-danger" OnClick="Button3_Click" />--%>
<%--         </center>--%>
    </div>
    </div>
        <p align="center">
            <asp:Button ID="Button1" runat="server" Text="Not Active" />
        </p>
    </form>
</body>
</html>

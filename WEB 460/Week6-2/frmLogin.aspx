<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="WEB_460.Week6_2.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="UserID "></asp:Label>
    
        <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password "></asp:Label>
    
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" 
            onclick="btnLogin_Click" />
    
    &nbsp;<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyMobilePage.aspx.cs" Inherits="WEB_460.Week6.DeviceApplication" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name "></asp:Label>
    
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name "></asp:Label>
    
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email "></asp:Label>
    
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label4" runat="server" Text="Phone Number "></asp:Label>
    
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label5" runat="server" Text="Address ID "></asp:Label>
    
        <asp:TextBox ID="txtAddressID" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    
        <br />
        <asp:Button ID="cmdFind" runat="server" Text="Find" onclick="cmdFind_Click" />
    
        <br />
        <asp:Button ID="cmdUpdate" runat="server" Text="Update" 
            onclick="cmdUpdate_Click" />
    
    </div>
    </form>
</body>
</html>

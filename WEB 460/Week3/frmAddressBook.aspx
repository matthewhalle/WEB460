﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAddressBook.aspx.cs" Inherits="WEB_460.Week3.frmAddressBook" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Find Last Name: "></asp:Label>
    
        <asp:TextBox ID="txtFindLastName" runat="server"></asp:TextBox>
        <asp:Button ID="btnFindLastName" runat="server" Text="Find Last Name:" 
            onclick="btnFindLastName_Click" />
        <br />
        <br />
        Search Results ( First record to Match)<br />
        <asp:Label ID="Label2" runat="server" Text="First Name "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        Last Name:
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="E-Mail:    "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Phone Number: "></asp:Label>

        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

        <br />
    </div>
    </form>
</body>
</html>

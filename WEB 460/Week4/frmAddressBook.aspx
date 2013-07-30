<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAddressBook.aspx.cs" Inherits="WEB_460.Week4.frmAddressBook" %>

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
        <asp:Label ID="Label3" runat="server" Text="Email Name "></asp:Label>
    
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    
        <br />
        Phone Number
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
    
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
    
        <br />
        <br />
        <asp:GridView ID="gvAddresses" runat="server" BackColor="White" 
            BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    
        <br />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEmployees.aspx.cs" Inherits="WEB_460.Week5.frmEmployees" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name "></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Age "></asp:Label>
    
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
    
        <br />
        <asp:Label ID="Label3" runat="server" Text="Gender "></asp:Label>
        <asp:DropDownList ID="DropGender" runat="server">
            <asp:ListItem>M</asp:ListItem>
            <asp:ListItem>F</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Salary "></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <br />
    
        <br />
        <asp:Button ID="btnAddEmployee" runat="server" Text="Add Employee" 
            onclick="btnAddEmployee_Click" />
    
        <br />
    
        <br />
        <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvEmployees" runat="server">
        </asp:GridView>
    
        <br />
    
    </div>
    </form>
</body>
</html>

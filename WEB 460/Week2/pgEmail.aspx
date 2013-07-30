<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pgEmail.aspx.cs" Inherits="WEB_460.Week2.pgEmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        From&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FromTextBox" runat="server" Text="halle.matthew@gmail.com" ReadOnly="True"></asp:TextBox>
        <br />
        To&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ToTextBox" runat="server"></asp:TextBox>
        <br />
        Subject
        <asp:TextBox ID="SubjectTextBox" runat="server" ></asp:TextBox>
        <br />
        Message<br />
        <asp:TextBox ID="MessageTextBox" runat="server" Height="227px" Width="446px" 
            TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="SendBtn" runat="server" Text="Send" onclick="SendBtn_Click" />
&nbsp;<asp:Label ID="StatusLbl" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pgConfirm.aspx.cs" Inherits="WEB_460.Week1.pgConfirm1" %>
<%@ PreviousPageType virtualPath = "~/Week1/pgCheckOut.aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="Wraper12">
    <div class="Wraper1">
    <div class="LableName2">Name: </div>
    <asp:Label ID="Namelbl" runat="server" Text=""></asp:Label>
    </div>

    <div class="Wraper1">
    <div class="LableName2">Address: </div>
    <asp:Label ID="Addresslbl" runat="server" Text=""></asp:Label>
    </div>

    <div class="Wraper1">
    <div class="LableName2">Credit Card Type: </div>
    <asp:Label ID="CreditCardTypelbl" runat="server" Text=""></asp:Label>
    </div>

    <div class="Wraper1">
    <div class="LableName2">Credit Card Number: </div>
    <asp:Label ID="CreditCardNumlbl" runat="server" Text=""></asp:Label>
    </div>
    <div class="Wraper7">
        <asp:Button ID="SubmitOrderbtn" runat="server" Text="Submit Order" 
            onclick="SubmitOrderbtn_Click" />
        <asp:Label ID="Statuslbl" runat="server" Text=""></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>

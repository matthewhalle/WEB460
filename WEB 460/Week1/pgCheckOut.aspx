<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pgCheckOut.aspx.cs" Inherits="WEB_460.Week1.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="Wraper">
    <div class="Wraper1">
    <div class="LableName">
    <asp:Label ID="FirstNameLable" runat="server" Text="First Name"></asp:Label>
    </div>
    <div class="TextBoxEntry1">
    <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
    </div>
    </div>

    <div class="Wraper2">
        
    <div class="LableName">
    <asp:Label ID="LastNameLable" runat="server" Text="Last Name"></asp:Label>
    </div>

    <div class="TextBoxEntry1">
    <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
    </div>
    </div>
    
    <div class="Wraper3">
    <div class="LableName">    
    <asp:Label ID="Addresslbl" runat="server" Text="Address Line 1"></asp:Label>
    </div>
    <div class="TextBoxEntry1">
    <asp:TextBox ID="Addresstextbox" runat="server"></asp:TextBox>
    </div>
    </div>

    <div class="Wraper4">
    <div class="LableName">    
    <asp:Label ID="Addresslbl2" runat="server" Text="Address Line 2"></asp:Label>
    </div>
    <div class="TextBoxEntry1">
    <asp:TextBox ID="Addresstextbox2" runat="server"></asp:TextBox>
    </div>
    </div>
    
    <div class="Wraper5">
    <div class="LableName">    
    <asp:Label ID="Citylbl" runat="server" Text="City"></asp:Label>
    </div>
    <div class="TextBoxEntry1">
    <asp:TextBox ID="Citytextbox" runat="server"></asp:TextBox>
    </div>
    </div>

    <div class="Wraper6">
    <div class="LableName">    
    <asp:Label ID="Statelbl" runat="server" Text="State"></asp:Label>
    </div>
    <div class="TextBoxEntry1">
    <asp:TextBox ID="Statetextbox" runat="server"></asp:TextBox>
    </div>
    </div>

    <div class="Wraper7">
    <div class="LableName">    
    <asp:Label ID="PhoneNumlbl" runat="server" Text="Phone Number"></asp:Label>
    </div>
    <div class="TextBoxEntry1">
    <asp:TextBox ID="PhoneNumtextbox" runat="server"></asp:TextBox>
    </div>
    </div>
    
   
    
    </div>
    
    <div class="Wraper8">
        <table style="width: 100%;">
            <tr>
                <td>
                    Payment Method
                    &nbsp;
                </td>
             
            </tr>
            <tr>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem>Visa</asp:ListItem>
                    <asp:ListItem>Master Card</asp:ListItem>
                    <asp:ListItem>Discover</asp:ListItem>
                    </asp:RadioButtonList>
                    &nbsp;
                </td>
              
            </tr>
            <tr>
                <td>
                    Credit Card Number 
                    <asp:TextBox ID="Credittextbox" runat="server"></asp:TextBox>
                    &nbsp;
                </td>
               
            </tr>
        </table>
        <asp:Button ID="Submitbtn" runat="server" Text="Submit" 
            onclick="Submitbtn_Click" PostBackUrl="~/Week1/pgConfirm.aspx" />
        
        
        
    </div>
    </form>
</body>
</html>

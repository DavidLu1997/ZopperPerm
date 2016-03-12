<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPermPage.aspx.cs" Inherits="Web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="stringToPermute" runat="server" MaxLength="10"></asp:TextBox>
        <asp:RadioButton ID="permutationsButton" runat="server" Text="Permutations" />
        <asp:RadioButton ID="combinationsButton" runat="server" Text="Combinations" />
        <asp:Button ID="generateButton" runat="server" Text="Generate" />
        <asp:Label ID="total" runat="server" Text="Total: 0"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="313px" TextMode="MultiLine" Width="453px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>

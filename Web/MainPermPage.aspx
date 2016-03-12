<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPermPage.aspx.cs" Inherits="Web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="stringToPermute" runat="server" MaxLength="10" OnTextChanged="changeK"></asp:TextBox>
        <asp:TextBox ID="kValue" TextMode="Number" runat="server" min="0" max="10" step="1" Width="31px" OnTextChanged="changeKValue"/>
        <asp:RadioButton ID="permutationButton" runat="server" Text="Permutations" GroupName="radio" OnCheckedChanged="updateRadioButtons" />
        <asp:RadioButton ID="combinationButton" runat="server" Text="Combinations" GroupName="radio" OnCheckedChanged="updateRadioButtons" />
        <asp:Button ID="generateButton" runat="server" Text="Generate" OnClick="generateAction" />
        <asp:Label ID="total" runat="server" Text="Total: 0"></asp:Label>
        <br />
        <asp:TextBox ID="mainOutput" runat="server" Height="313px" TextMode="MultiLine" Width="488px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_30_11_2022.WebForm1" %>
<style>
    #Main
    {
        display:flex;
        justify-content:space-evenly;
        width:80%;
        
       
        
    }
    #clacs
    {
        display:flex;
        justify-content:space-evenly;
        height: 300px;
        align-items:center;
    }
    button
    {
        font-size:28px;
        height:40px;
        width:50px;
    }
</style>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
      <div id="Main">
        <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
        <asp:TextBox ID="num1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
        <asp:TextBox ID="num2" runat="server"></asp:TextBox>
          </div>
         
           <div id="clacs">
            <asp:Button ID="Button1" runat="server" Text="+" />
            <asp:Button ID="Button2" runat="server" Text="x" />
            <asp:Button ID="Button3" runat="server" Text="-" />
            <asp:Button ID="Button4" runat="server" Text="÷" />
        </div>
    </form>
   
</body>
</html>

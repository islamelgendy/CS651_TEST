<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS651_TEST.Default" %>

<!DOCTYPE html>

	<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
	<title>CS651-Test1-Question2a</title>
	</head>
	<body>
	<form id="form1" runat="server">
	<div>    
	<asp:Label ID="Label1" runat="server" Text="Enter the number of random numbers to be generated"></asp:Label>
	<asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox>
	<br />
	<asp:Button ID="submitButton" runat="server" Text="Submit" />
	<br />
	<asp:Label ID="Label2" runat="server" Text="The generated numbers" Visible="True"></asp:Label>
	<br />
	<asp:ListBox ID="outputListBox" runat="server" Rows="10" Visible="False">
	</asp:ListBox>
	<br />
	<asp:Label ID="Label3" runat="server" Text="Range of generated numbers" Visible="False"></asp:Label>
	<asp:TextBox ID="rangeTextBox" runat="server" Visible="False"></asp:TextBox>    
	</div>
	</form>
	</body>
	</html>


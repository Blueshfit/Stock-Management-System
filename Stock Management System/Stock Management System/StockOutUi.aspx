<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockOutUi.aspx.cs" Inherits="Stock_Management_System.StockOutUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="companyLabel" runat="server" Text="Company"></asp:Label>
    <asp:DropDownList ID="companyDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="companyDropDownList_SelectedIndexChanged"></asp:DropDownList>
    <br />

    <asp:Label ID="itemLabel" runat="server" Text="Item"></asp:Label>
    <asp:DropDownList ID="itemDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="itemDropDownList_SelectedIndexChanged"></asp:DropDownList>
    <br />

    <asp:Label ID="reOrderLabel" runat="server" Text="Reorder Level"></asp:Label>
	<asp:Label ID="reorderLabelSet" runat="server"></asp:Label>
    <br />

    <asp:Label ID="availableQuantityLabel" runat="server" Text="Available Quantity"></asp:Label>
	<asp:Label ID="availableQuantityLabelSet" runat="server" Text="Label"></asp:Label>
    <br />

    <asp:Label ID="stockOutQuantityLabel" runat="server" Text="Stock Out Quantity"></asp:Label>
    <asp:TextBox ID="stockOutQuantityTextBox" runat="server"></asp:TextBox>
    <br />
	<asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
   
	<br />
    <br />
	<asp:Label ID="messageLabel" runat="server" ></asp:Label>

    <asp:GridView ID="stockOutGridView" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
      
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <br />
	 <asp:Button ID="sellButton" runat="server" Text="Sell" OnClick="sellButton_Click" />
    <asp:Button ID="damageButton" runat="server" Text="Damage" OnClick="damageButton_Click" />
    <asp:Button ID="lostButton" runat="server" Text="Lost" OnClick="lostButton_Click" />
   
</asp:Content>

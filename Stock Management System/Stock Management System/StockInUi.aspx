﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockInUi.aspx.cs" Inherits="Stock_Management_System.StockInUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="companyLabel" runat="server" Text="Company"></asp:Label>
    <asp:DropDownList ID="companyDropDownList" runat="server" OnSelectedIndexChanged="companyDropDownList_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    <br />

    <asp:Label ID="itemLabel" runat="server" Text="Item"></asp:Label>
    <asp:DropDownList ID="itemDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="itemDropDownList_SelectedIndexChanged"></asp:DropDownList>
    <br />

    <asp:Label ID="reOrderLabel" runat="server" Text="Reorder Level"></asp:Label>
	<asp:Label ID="reorderLabelSet" runat="server" ></asp:Label>
    <br />

    <asp:Label ID="availableQuantityLabel" runat="server" Text="Available Quantity"></asp:Label>
	<asp:Label ID="availableQuantityLabelSet" runat="server" Text="Label"></asp:Label>
    <br />

    <asp:Label ID="stockInQuantityLabel" runat="server" Text="Stock In Quantity"></asp:Label>
    <asp:TextBox ID="stockInQuantityTextBox" runat="server"></asp:TextBox>
	<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="stockInQuantityTextBox" ForeColor="Red" runat="server" Display="Dynamic" ErrorMessage="Can not be empty"></asp:RequiredFieldValidator>
	<asp:CompareValidator ID="CompareValidator1" ControlToValidate="stockInQuantityTextBox" Display="Dynamic" Operator="DataTypeCheck" Type="Integer"  ForeColor="Red" runat="server" ErrorMessage="Stock in must be number"></asp:CompareValidator>
    <br />
	<asp:Label ID="messageLabel" runat="server" ></asp:Label>

    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" style="height: 26px" />
</asp:Content>

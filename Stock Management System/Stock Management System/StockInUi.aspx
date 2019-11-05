﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockInUi.aspx.cs" Inherits="Stock_Management_System.StockInUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="companyLabel" runat="server" Text="Company"></asp:Label>
    <asp:DropDownList ID="companyDropDownList" runat="server"></asp:DropDownList>
    <br />

    <asp:Label ID="itemLabel" runat="server" Text="Item"></asp:Label>
    <asp:DropDownList ID="itemDropDownList" runat="server"></asp:DropDownList>
    <br />

    <asp:Label ID="reOrderLabel" runat="server" Text="Reorder Level"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="availableQuantityLabel" runat="server" Text="Available Quantity"></asp:Label>
    <asp:TextBox ID="availableQuantityTextBox" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="stockInQuantityLabel" runat="server" Text="Stock In Quantity"></asp:Label>
    <asp:TextBox ID="stockInQuantityTextBox" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="saveButton" runat="server" Text="Save" />
</asp:Content>

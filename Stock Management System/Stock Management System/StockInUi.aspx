<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockInUi.aspx.cs" Inherits="Stock_Management_System.StockInUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <label for="inputCompany">Company</label>
        <asp:DropDownList ID="ddlCompany" class="form-control" runat="server"></asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="inputItem">Item</label>
        <asp:DropDownList ID="ddlItem" class="form-control" runat="server"></asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="inputReorderLevel">Reorder Level</label>
        <input type="text" class="form-control" id="inputReorderLevel" runat="server" visible="True" />
    </div>

    <div class="form-group">
        <label for="inputAvailableQuantity">Available Quantity</label>
        <input type="text" class="form-control" id="inputAvailableQuantity" runat="server"/>
    </div>

    <div class="form-group">
        <label for="inputStockInQuantity">Stock In Quantity</label>
        <input type="text" class="form-control" id="inputStockInQuantity" runat="server" placeholder="Enter stock in Quantity" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputStockInQuantity" ForeColor="red" ErrorMessage="Quantity Can't be empty"></asp:RequiredFieldValidator>
    </div>

    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />

    <br />
    <asp:Label ID="messageLabel" runat="server"></asp:Label>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemSetupUI.aspx.cs" Inherits="StockManagementSystem.ItemSetupUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Item Setup">
        <div class="form-group row" style="margin-left: auto">
            <label for="inputCategory" class="col-sm-2 col-form-label">Category</label>
            <div class="col-sm-10" >
                <select class="form-control" runat="server" id="inputCategory">
                    <option>1</option>
                    <option>2</option>
                    <option>3</option>
                    <option>4</option>
                    <option>5</option>
                </select>
            </div>
            <br/><br/>
            <label for="inputCompany" class="col-sm-2 col-form-label">Company</label>
            <div class="col-sm-10">
                <select class="form-control" runat="server" id="inputCompany">
                    <option>1</option>
                    <option>2</option>
                    <option>3</option>
                    <option>4</option>
                    <option>5</option>
                </select>
            </div>
            <br/><br/>
            <div class="form-group row">
                <label for="inputItemName" class="col-sm-2 col-form-label">Item name</label>
                <div class="col-sm-10">
                    <input type="text" runat="server" class="form-control" id="inputItemName"/>
                </div>
            </div>
            
            <div class="form-group row">
                <label for="inputReorderLevel" class="col-sm-2 col-form-label">Reorder Level</label>
                <div class="col-sm-10">
                    <input type="text" runat="server" class="form-control" id="inputReorderLevel"/>
                </div>
            </div>
        </div>
        <asp:Button ID="saveButton" runat="server" class="btn btn-primary" Text="Save" />
    </asp:Panel>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemSetupUi.aspx.cs" Inherits="Stock_Management_System.ItemSetupUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	  <asp:Panel ID="Panel1" runat="server" GroupingText="Item Setup">
        <div class="form-group row" style="margin-left: auto">
            <label for="inputCategory" class="col-sm-2 col-form-label">Category</label>
            <div class="col-sm-10" >
				<asp:DropDownList ID="ddlCatagory" runat="server"></asp:DropDownList>
            </div>
            <br/><br/>
            <label for="inputCompany" class="col-sm-2 col-form-label">Company</label>
            <div class="col-sm-10">
				<asp:DropDownList ID="ddlCompany" runat="server"></asp:DropDownList>
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
        <asp:Button ID="saveButton" runat="server" class="btn btn-primary" Text="Save" OnClick="saveButton_Click" />
		  <asp:Label ID="messageLabel" runat="server" ></asp:Label>
    </asp:Panel>
</asp:Content>

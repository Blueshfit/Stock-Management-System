<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewItemBetweenDatesUI.aspx.cs" Inherits="Stock_Management_System.ViewItemBetweenDatesUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
	<link rel="stylesheet" href="/resources/demos/style.css">
	<link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
	<link href="Content/jquery-ui.min.css" rel="stylesheet" />
	<br />
	<div class="form-group row">
    <label for="fromDateTextBox" class="col-sm-2 col-form-label">From Date</label>
    <div class="col-sm-4">
      <input type="date" class="form-control" runat="server" id="fromDateTextBox" >
    </div>
  </div>
	<div class="form-group row">
    <label for="toDateTextBox" class="col-sm-2 col-form-label">To Date</label>
    <div class="col-sm-4">
      <input type="date" class="form-control" runat="server" id="toDateTextBox" >
    </div>
  </div>
	<asp:Label ID="messageLabel" runat="server" ></asp:Label>
	 <div class="col-sm-4">
		 <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
    </div>

	<asp:GridView ID="sellGridView" AutoGenerateColumns="false" runat="server">
		<Columns>
			<asp:TemplateField HeaderText="SL">
				<ItemTemplate>
					  <%#Container.DataItemIndex +1 %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Item">
				<ItemTemplate>
					  <%#Eval("ItemName") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="Quantity">
				<ItemTemplate>
					  <%#Eval("SellDate") %>
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>

	<script src="Scripts/jquery-3.3.1.min.js"></script>
	<script src="Scripts/jquery-ui.min.js"></script>
	<script>
		$(document).ready(function () {
			$("#toDateTextBox").datepicker(),
				$("$fromDateTextBox").datepicker();
		})
	</script>
</asp:Content>

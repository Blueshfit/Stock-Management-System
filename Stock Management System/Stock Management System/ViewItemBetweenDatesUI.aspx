<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewItemBetweenDatesUI.aspx.cs" Inherits="Stock_Management_System.ViewItemBetweenDatesUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
	<link rel="stylesheet" href="/resources/demos/style.css">
	<link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
	<br />
	<div class="form-group row">
    <label for="fromDateTextBox" class="col-sm-2 col-form-label">From Date</label>
    <div class="col-sm-4">
      <input type="date" class="form-control" runat="server" id="fromDateTextBox" >
    </div>
  </div>
	<div class="form-group row">
    <label for="toDateTextBox" class="col-sm-2 col-form-label">From Date</label>
    <div class="col-sm-4">
      <input type="date" class="form-control" runat="server" id="toDateTextBox" >
    </div>
  </div>
	 <div class="col-sm-4">
      <button type="Button" class="btn btn-primary">Search</button>
    </div>
		

	
	
</asp:Content>

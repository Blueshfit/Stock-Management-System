<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogInForm.aspx.cs" Inherits="Stock_Management_System.LogInForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <div class="form-group">
            <label for="userId">Email or User Id</label>
            <input type="text" runat="server" class="form-control" id="userId"  placeholder="Enter / Userid" required/>
        </div>
        <div class="form-group">
            <label for="passwordId">Password</label>
            <input type="password"  class="form-control" id="passwordId" placeholder="Password" runat="server" required/>
        </div>
        <asp:Button class="btn btn-primary" ID="loginButton" runat="server" Text="Button" />
    </form>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompanySetUpUi.aspx.cs" Inherits="Stock_Management_System.CompanySetUpUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Panel ID="Panel1" runat="server" GroupingText="Company Setup">
        <div class="form-group">

            <label for="inputCompanyName">Name</label>
            <br />
            <input type="text" id="inputCompanyName" runat="server" class="form-control" />
            <br />
            <asp:Button ID="saveButton" runat="server" class="btn btn-primary" Text="Save" OnClick="saveButton_Click" />
			<br />
			<asp:Label ID="messageLabel" runat="server" ></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="CompanyId" HeaderText="Id"  SortExpression="CompanyId" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Name" SortExpression="CompanyName" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllCompanies" TypeName="Stock_Management_System.DAL.CompanyGateway" UpdateMethod="UpdateCompany">
                <UpdateParameters>
                    <asp:Parameter Name="companyId" Type="Int32" />
                    <asp:Parameter Name="companyName" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
        </div>

    </asp:Panel>
</asp:Content>

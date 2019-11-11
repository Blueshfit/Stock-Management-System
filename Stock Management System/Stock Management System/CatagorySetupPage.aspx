<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatagorySetupPage.aspx.cs" Inherits="Stock_Management_System.CatagorySetupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <div>
            &nbsp;
        </div>
        <div class="form-group row">
            <label for="catagoryId" class="col-sm-2 col-form-label">Name</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="catagoryId" runat="server" placeholder="Product Catagory" required/>&nbsp;
                <div> <asp:Button ID="catagorySaveButton" runat="server" class="btn btn-primary"  Text="Save" OnClick="catagorySaveButton_Click" /></div>
				<asp:Label ID="messageLabel" runat="server" ></asp:Label>
               
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="CatagoryId" HeaderText="Id" SortExpression="CatagoryId" />
                        <asp:BoundField DataField="CatagoryName" HeaderText="Name" SortExpression="CatagoryName" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCatagories" TypeName="Stock_Management_System.BLL.CatagoryManager" UpdateMethod="UpdateCatagoryName">
                    <UpdateParameters>
                        <asp:Parameter Name="catagoryName" Type="String" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
               
            </div>
        </div>
    </form>


</asp:Content>
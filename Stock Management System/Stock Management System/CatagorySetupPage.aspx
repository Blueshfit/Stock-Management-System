<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatagorySetupPage.aspx.cs" Inherits="Stock_Management_System.CatagorySetupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<form>
        <div>
            &nbsp;
        </div>
        <div class="form-group row">
            <label for="catagoryId" class="col-sm-2 col-form-label">Name</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="catagoryId" runat="server" placeholder="Product Catagory" required>&nbsp;
                <div> <asp:Button ID="catagorySaveButton" runat="server" class="btn btn-primary"  Text="Save" OnClick="catagorySaveButton_Click" /></div>
				<asp:Label ID="messageLabel" runat="server" ></asp:Label>
               
            </div>
        </div>
    </form>
    <asp:GridView ID="catagoryGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"   style="margin-right: 12px" OnRowCommand="catagoryGridView_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="sl#">
                <ItemTemplate>
                    <%#Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <%#Eval("CatagoryName") %>
                </ItemTemplate>
            </asp:TemplateField>
			<asp:ButtonField Text="Edit" CommandName="DoubleClick" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>

</asp:Content>
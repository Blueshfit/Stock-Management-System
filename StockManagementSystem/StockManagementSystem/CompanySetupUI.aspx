<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompanySetupUI.aspx.cs" Inherits="StockManagementSystem.CompanySetupUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Company Setup">
        <div class="form-group">

            <label for="inputCompanyName">Name</label>
            <br />
            <input type="text" id="inputCompanyName" runat="server" class="form-control" />
            <br />
            <asp:Button ID="saveButton" runat="server" class="btn btn-primary" Text="Save" />
        </div>
        <asp:GridView ID="companyGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="SL">
                    <ItemTemplate>
                        <%#Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <%DataItemContainer.DataBind(); %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </asp:Panel>
</asp:Content>

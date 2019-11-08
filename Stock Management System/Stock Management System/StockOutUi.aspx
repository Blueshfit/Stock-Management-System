<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockOutUi.aspx.cs" Inherits="Stock_Management_System.StockOutUi" %>
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
        <input type="text" class="form-control" id="inputReorderLevel" runat="server" placeholder="0" />
    </div>

    <div class="form-group">
        <label for="inputAvailableQuantity">Available Quantity</label>
        <input type="text" class="form-control" id="inputAvailableQuantity" runat="server" placeholder="0" />
    </div>

    <div class="form-group">
        <label for="inputStockOutQuantity">Stock Out Quantity</label>
        <input type="text" class="form-control" id="inputStockOutQuantity" runat="server" placeholder="Enter stock out Quantity" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputStockOutQuantity" ForeColor="red" ErrorMessage="Quantity Can't be empty"></asp:RequiredFieldValidator>
    </div>

    <asp:Button ID="addButton" class="btn btn-primary" runat="server" Text="Add" OnClick="addButton_Click" />
    <br />

    <asp:Label ID="messageLabel" runat="server"></asp:Label>
    <br />

    <asp:GridView ID="companyGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="SL">
                    <ItemTemplate>
                        <%#Container.DataItemIndex +1 %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Item">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("ItemName") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Company">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("CompanyName") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <%--<%DataItemContainer.DataBind(); %>--%>
                        <%#Eval("Quantity") %>
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
    <br />
    <asp:Button ID="sellButton" class="btn btn-primary" runat="server" Text="Sell" OnClick="sellButton_Click" />
&nbsp;<asp:Button ID="damageButton" class="btn btn-danger" runat="server" Text="Damage" />
&nbsp;<asp:Button ID="lostButton" class="btn btn-warning" runat="server" Text="Lost" />

</asp:Content>

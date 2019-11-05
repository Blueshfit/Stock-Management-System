<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchVIewItemsSummaryUI.aspx.cs" Inherits="Stock_Management_System.SearchVIewItemsSummaryUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<table style="width: 100%; height: 118px;">
		<tr>
			<td class="text-right" style="width: 194px">Company</td>
			<td class="text-right" style="width: 254px">
				<asp:DropDownList ID="companyDDL" runat="server">
				</asp:DropDownList>
			</td>
			<td>&nbsp;</td>
		</tr>
		<tr>
			<td class="text-right" style="width: 194px">Catagory</td>
			<td class="text-right" style="width: 254px">
				<asp:DropDownList ID="catagoryDDL" runat="server">
				</asp:DropDownList>
			</td>
			<td>&nbsp;</td>
		</tr>
		<tr>
			<td class="text-right" style="width: 194px">&nbsp;</td>
			<td class="text-right" style="width: 254px">
				<asp:Button ID="searchButton" runat="server" Text="Search" />
			</td>
			<td>&nbsp;</td>
		</tr>
		</table>
		<asp:GridView ID="itemSuumaryGridView" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
			<AlternatingRowStyle BackColor="White" />
			<Columns>
				<asp:TemplateField HeaderText="Sl">
					<ItemTemplate>
		  <%#Container.DataItemIndex+1 %>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Item">
					<ItemTemplate>
						<%#Eval("ItemName") %>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Company">
					<ItemTemplate>
						<%#Eval("ComapnyName") %>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Catagory">
					<ItemTemplate>
						<%#Eval("CatagoryName") %>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Available Quantity">
					<ItemTemplate>
						<%#Eval("Quantity") %>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="Reorder Level">
					<ItemTemplate>
						<%#Eval("ReorderLevel") %>
					</ItemTemplate>
				</asp:TemplateField>
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

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsPage.aspx.cs" Inherits="Import_System.Pages.DetailsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-main">
        <asp:GridView ID="dataTable1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
             BorderColor="#CCCCCC" BackColor="#FFFF66" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" Font-Size="Small" ShowFooter="True" Width="90%" CssClass="gridview-container" >

            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="black" CssClass="GVFixedFooter" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Black" CssClass="GVFixedHeader" />
            <Columns>
                <asp:BoundField DataField="ref_no" HeaderText="Ref No">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" />
                </asp:BoundField>
                <asp:BoundField DataField="log_date" HeaderText="Log Date" >
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="12%" />
                </asp:BoundField>
                <asp:BoundField DataField="con_no"  HeaderText="Con No">
                    <HeaderStyle CssClass="gridViewHeader" HorizontalAlign="Right" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="12%" />
                </asp:BoundField>
                <asp:BoundField DataField="month" HeaderText="Month" >
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left"  Width="12%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="delivery_terms" HeaderText="Delivery Term" >
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left"  Width="12%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="payment_terms" HeaderText="Payment Term">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left"  Width="10%" Font-Bold="True" />
                </asp:BoundField>
            </Columns>
            <RowStyle Height="30px" />
            <FooterStyle BackColor="#E3EAF3" Font-Bold="true" />
            <HeaderStyle BackColor="#E3EAF3" Height="25px" BorderStyle="None" Font-Bold="True" ForeColor="#6E8BA8" />
            <SelectedRowStyle BackColor="#E3EAF3" Font-Bold="True" ForeColor="Black" />
        </asp:GridView>
       
    </div>
</asp:Content>

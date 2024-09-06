<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Import_System.Pages.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .container-main {
            margin-left: -200px;
            margin-right: -300px;
            margin-bottom: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-main">
        <asp:GridView ID="dataTable1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
            BorderColor="#CCCCCC" BackColor="#FFFF66" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" Font-Size="Small" ShowFooter="True" Width="90%" CssClass="gridview-container">

            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="black" CssClass="GVFixedFooter" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Black" CssClass="GVFixedHeader" />
            <Columns>
                <asp:BoundField DataField="con_no" HeaderText="Con No">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="exporter_name" HeaderText="Exporter Name">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="item_des" HeaderText="Item">
                    <HeaderStyle CssClass="gridViewHeader" HorizontalAlign="Right" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="qty" HeaderText="QTY">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ETD" HeaderText="ETD">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ETA" HeaderText="ETA">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="FCL" HeaderText="FCL">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="LCL" HeaderText="LCL">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="transport_mode" HeaderText="Transport Mode">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="actual_clearence_date" HeaderText="Actual Clearance Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
            </Columns>
            <RowStyle Height="30px" />
            <FooterStyle BackColor="#E3EAF3" Font-Bold="true" />
            <HeaderStyle BackColor="#E3EAF3" Height="25px" BorderStyle="None" Font-Bold="True" ForeColor="#6E8BA8" />
            <SelectedRowStyle BackColor="#E3EAF3" Font-Bold="True" ForeColor="Black" />
        </asp:GridView>
    </div>
</asp:Content>

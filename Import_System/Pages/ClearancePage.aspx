<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClearancePage.aspx.cs" Inherits="Import_System.Pages.ClearancePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    .container-main {
        margin-left: -300px;
        margin-right: -300px;
        margin-bottom: 40px;
    }

    .gridview-container {
        width: 90%;
        margin: 0 auto;
        border-collapse: collapse;
        font-family: Arial, sans-serif;
    }

        .gridview-container th, .gridview-container td {
            padding: 10px;
            border: 1px solid #ddd;
            text-align: left;
        }

        .gridview-container thead {
            background-color: #deac0f
        }

            .gridview-container thead th {
                border-bottom: 2px solid #ddd;
                font-weight: bold;
            }

        .gridview-container tbody tr:nth-child(even) {
            background-color: #f1e19d;
        }

        .gridview-container tbody tr:hover {
            background-color: #b6ff00;
        }

    .gridview-footer {
        background-color: #f4f4f4;
        border-top: 2px solid #ddd;
        font-weight: bold;
    }

    .icon {
        width: 24px;
        height: auto;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-main">
    <asp:GridView ID="dataTable1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
        BorderColor="#CCCCCC" BackColor="#ffff66" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" Font-Size="Small" ShowFooter="True" Width="90%" CssClass="gridview-container">

        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="black" CssClass="GVFixedFooter" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Black" CssClass="GVFixedHeader" />
        <Columns>
            <asp:BoundField DataField="ref_no" HeaderText="Ref No">
                <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="4%" />
            </asp:BoundField>
            <asp:BoundField DataField="con_no" HeaderText="Con No">
                <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="4%" />
            </asp:BoundField>
            <asp:BoundField DataField="exporter_name" HeaderText="Exporter Name">
                <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="15%" />
            </asp:BoundField>
            <asp:BoundField DataField="item_des" HeaderText="Item">
                <HeaderStyle CssClass="gridViewHeader" HorizontalAlign="Right" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="15%" />
            </asp:BoundField>
            <asp:BoundField DataField="qty" HeaderText="QTY">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="6%" Font-Bold="True" />
            </asp:BoundField>
            <asp:BoundField DataField="ETD" HeaderText="ETD">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="8%" Font-Bold="True" />
            </asp:BoundField>
            <asp:BoundField DataField="ETA" HeaderText="ETA">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="8%" Font-Bold="True" />
            </asp:BoundField>
            <asp:BoundField DataField="fcl_20ft" HeaderText="FCL-20">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="5%" Font-Bold="True" />
            </asp:BoundField>
            <asp:BoundField DataField="fcl_40ft" HeaderText="FCL-40">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="5%" Font-Bold="True" />
            </asp:BoundField>
            <asp:BoundField DataField="lcl" HeaderText="LCL">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="5%" Font-Bold="True" />
            </asp:BoundField>
            <asp:BoundField DataField="transport_mode" HeaderText="Transport Mode">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="6%" Font-Bold="True" />
            </asp:BoundField>
            <asp:BoundField DataField="actual_clearence_date" HeaderText="Actual Clearance Date">
                <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                <ItemStyle HorizontalAlign="left" Width="8%" Font-Bold="True" />
            </asp:BoundField>
            <%--<asp:ButtonField ButtonType="Image" ImageUrl="https://img.icons8.com/ios-filled/50/fine-print.png" CommandName="Navigate"  ControlStyle-CssClass="icon" />--%>
        </Columns>
        <RowStyle Height="30px" />
        <FooterStyle BackColor="#E3EAF3" Font-Bold="true" />
        <HeaderStyle BackColor="#E3EAF3" Height="25px" BorderStyle="None" Font-Bold="True" ForeColor="#6E8BA8" />
        <SelectedRowStyle BackColor="#E3EAF3" Font-Bold="True" ForeColor="Black" />
    </asp:GridView>
</div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Import_System.Pages.HomePage" %>

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
                border: 1px solid Black;
                text-align: left;
            }

            .gridview-container thead {
                /*background-color: #deac0f*/
            }

                .gridview-container thead th {
                    border-bottom: 2px solid #ddd;
                    font-weight: bold;
                }

            .gridview-container tbody tr:nth-child(even) {
                /*background-color: #f1e19d;*/
            }

            .gridview-container tbody tr:hover {
                /*background-color:darksalmon;*/
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

        .search-container {
            margin-bottom: 10px;
            margin-left: 236px;
        }

        .search-input {
            padding: 5px;
            width: 200px;
        }

        .search-button {
            padding: 5px 10px;
            margin-left: 5px;
        }

        .highlight-green {
            background-color: #0bc9db;
            color: Black; 
        }
        .pending{
            background-color:#f9b478;
            color: Black;
        }
        .clearance{
            background-color:#f7c63f;
        }
        .ongoing{
            background-color:#55e43e;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-main">
        <div class="search-container">
            <asp:TextBox ID="txtSearch" runat="server" CssClass="search-input" placeholder="Search..."></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="search-button" OnClick="btnSearch_Click" />
        </div>
        <asp:GridView ID="dataTable1" runat="server" OnRowCommand="Open_Shipment" AllowSorting="True" AutoGenerateColumns="false"  OnRowDataBound="dataTable1_RowDataBound"
            BorderColor="#CCCCCC"  BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" Font-Size="10px" ShowFooter="True" Width="75%" CssClass="gridview-container">

        <%--    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="black" CssClass="GVFixedFooter" />
            <HeaderStyle BackColor="#6699ff" Font-Bold="True" ForeColor="Black" CssClass="GVFixedHeader" />--%>
            <Columns>
                <asp:BoundField DataField="ref_no" HeaderText="Ref No">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="4%" />
                </asp:BoundField>
                <asp:BoundField DataField="BL_number" HeaderText="BL No" Visible="false">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="4%" />
                </asp:BoundField>
                <asp:BoundField DataField="con_no" HeaderText="Con No">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="exporter_name" HeaderText="Exporter Name">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="15%" />
                </asp:BoundField>
                <asp:BoundField DataField="forwarder" HeaderText="Forwarder">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="4%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="item_des" HeaderText="Item">
                    <HeaderStyle CssClass="gridViewHeader" HorizontalAlign="Right" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="15%" />
                </asp:BoundField>
                <asp:BoundField DataField="qty" HeaderText="QTY">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="5%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="invoice_value" HeaderText="Value" DataFormatString="{0:N}">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="5%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="no_of_containers" HeaderText="No of Containers">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="4%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ETD" HeaderText="ETD" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ETA" HeaderText="ETA" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="false">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="Shipping_line" HeaderText="Shipping Line">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="vessel_flight" HeaderText="Vessel / Flight">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="8%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="lcl" HeaderText="LCL">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="4%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="transport_mode" HeaderText="Transport Mode">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="4%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="actual_clearence_date" HeaderText="Actual Clearance Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="IsCleared" HeaderText="Cleared" Visible="false">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:ButtonField ButtonType="Image" ImageUrl="https://img.icons8.com/ios-filled/50/fine-print.png" CommandName="Navigate" ControlStyle-CssClass="icon" />
            </Columns>
            <RowStyle Height="30px" />
            <FooterStyle BackColor="#999999" Font-Bold="true" />
            <HeaderStyle BackColor="#999999" Height="25px" BorderStyle="None" Font-Size="11px" Font-Bold="True" ForeColor="black" />
            <SelectedRowStyle BackColor="#E3EAF3" Font-Bold="True" ForeColor="Black" />
        </asp:GridView>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsPage.aspx.cs" Inherits="Import_System.Pages.DetailsPage" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-main">
        <asp:GridView ID="dataTable1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
            BorderColor="#CCCCCC" BackColor="#FFFF66" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" Font-Size="10px" ShowFooter="True" CssClass="gridview-container">

            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="black" CssClass="GVFixedFooter" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Black" CssClass="GVFixedHeader" />
            <Columns>
                <asp:BoundField DataField="ref_no" HeaderText="Ref No">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="center" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" />
                </asp:BoundField>
                <asp:BoundField DataField="log_date" HeaderText="Log Date">
                    <FooterStyle CssClass="gridViewHeader" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" />
                </asp:BoundField>
                <asp:BoundField DataField="con_no" HeaderText="Con No">
                    <HeaderStyle CssClass="gridViewHeader" HorizontalAlign="Right" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" />
                </asp:BoundField>
                <asp:BoundField DataField="month" HeaderText="Month">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="delivery_terms" HeaderText="Delivery Term">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="payment_terms" HeaderText="Payment Term">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="exporter_name" HeaderText="Exporter Name">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="forwarder" HeaderText="Forwarder">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="item_des" HeaderText="Item Description">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="proforma_no" HeaderText="Proforma No">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="qty" HeaderText="QTY">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="invoice_value" HeaderText="Invoice Value">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="bank" HeaderText="Bank">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="application" HeaderText="Application">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="payment" HeaderText="Payment">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="delivery_order" HeaderText="Delivery Order">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="freight_value" HeaderText="Freight Value">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="freight_date" HeaderText="Frieght Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="insurance_value" HeaderText="Insurance Value">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="TRCL" HeaderText="TRCL">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="SLSI" HeaderText="SLSI">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="import_license" HeaderText="License">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="invoice" HeaderText="Invoice">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="packing" HeaderText="Packing">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="BL" HeaderText="BL">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="origin" HeaderText="Origin">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="Assessment" HeaderText="Assessment">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="cusdec" HeaderText="CUSDEC">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="import_licence_no" HeaderText="Import Licence No">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="insurance_policy_no" HeaderText="Insurance Policy No">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="LC_TT_no" HeaderText="LC / TT No">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="Invoice_no" HeaderText="Invoice No">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="unit_price" HeaderText="Unit Price">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="BL_number" HeaderText="BL No">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="vessel_flight" HeaderText="Vessel / Flight">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="20%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="estimate_load_date" HeaderText="Est. Load Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ETD" HeaderText="ETD">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="remarks1" HeaderText="Remarks">
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
                <asp:BoundField DataField="docs_received_bank" HeaderText="Doc-Received:Bank">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="original_docs_handover_agent" HeaderText="Org.Docs-Handover:Agent">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="remarks2" HeaderText="Remarks">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="cusdec_date" HeaderText="CUSDEC Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="container_destuff_date" HeaderText="Con. Destuff date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="duty_paid_date" HeaderText="Duty Paid Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="entry_passed_date" HeaderText="Entry Passed Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="remarks3" HeaderText="Remarks">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="fcl_loaded_port_date" HeaderText="FCL-Loaded-Port Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="examination_done_date" HeaderText="Exam Done Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="actual_clearence_date" HeaderText="Actual-Clearence Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="warehouse_release_date" HeaderText="Warehouse-Release:Date">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="remarks4" HeaderText="Remarks">
                    <HeaderStyle HorizontalAlign="Right" CssClass="gridViewHeader" Font-Bold="True" ForeColor="black" />
                    <ItemStyle HorizontalAlign="left" Width="10%" Font-Bold="True" />
                </asp:BoundField>
            </Columns>
            <RowStyle Height="30px" />
            <FooterStyle BackColor="#E3EAF3" Font-Bold="true" />
            <HeaderStyle BackColor="#E3EAF3" Height="25px" BorderStyle="None" Font-Bold="True" ForeColor="#6E8BA8" />
            <SelectedRowStyle BackColor="#E3EAF3" Font-Bold="True" ForeColor="Black" />
        </asp:GridView>

    </div>
</asp:Content>

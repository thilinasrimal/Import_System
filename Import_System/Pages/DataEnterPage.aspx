<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataEnterPage.aspx.cs" Inherits="Import_System.Pages.DataEnterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .main-content {
            margin-left: -10rem;
            margin-right: -10rem;
            display: flex;
            margin-bottom: 10px;
        }

        .tab1 {
            background-color: gray;
            margin-left: 10px;
            margin-right: 10px;
            padding: 5px 5px 5px 5px;
        }

        .tab1-1 {
            display: flex;
        }

        .tab2 {
            background-color: gray;
            margin-left: 10px;
            margin-right: 10px;
            padding: 5px 5px 5px 5px;
        }

        .tab3 {
            background-color: gray;
            margin-left: 10px;
            margin-right: 10px;
            padding: 5px 5px 5px 5px;
        }

        .tab4 {
            background-color: gray;
            margin-left: 10px;
            margin-right: 10px;
            padding: 5px 5px 5px 5px;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            var alertBox = document.getElementById("IsAlert");
            alertBox.style.display = "none"; // Hides the alert
        });
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alert alert-warning" role="alert" id="IsAlert">
        A simple warning alert—check it out!
    </div>
    <div class="main-content">
         <asp:HiddenField ID="hfRefNo" runat="server" />
        <div class="tab1">
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Consignment No</label>
                    <asp:TextBox ID="con_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Month</label>
                    <asp:TextBox ID="month" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Delivery Terms</label>
                    <asp:TextBox ID="delivery_terms" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2" style="width: 120px">
                    <label class="form-label">Payment Terms</label>
                    <asp:TextBox ID="payment_terms" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 mr-2" style="width: 95px">
                    <label class="form-label">Advance</label>
                    <asp:TextBox ID="advance" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 mr-2" style="width: 130px">
                    <label class="form-label">Date</label>
                    <asp:TextBox ID="a_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 mr-2" style="width: 95px">
                    <label class="form-label">Balance</label>
                    <asp:TextBox ID="balance" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 mr-2" style="width: 130px">
                    <label class="form-label">Date</label>
                    <asp:TextBox ID="b_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Exporter Name</label>
                    <asp:TextBox ID="exp_name" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Forwarder</label>
                    <asp:TextBox ID="forwarder" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Insurance Policy No</label>
                    <asp:TextBox ID="insurance_policy_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Item</label>
                    <asp:TextBox ID="item" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3" style="width: 85px">
                    <label class="form-label">Qty</label>
                    <asp:TextBox ID="qty" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Proforma No</label>
                    <asp:TextBox ID="proforma_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Invoice Value</label>
                    <asp:TextBox ID="invoice_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 mr-2" style="width: 140px">
                    <label class="form-label">Invoice No</label>
                    <asp:TextBox ID="invoice_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3" style="width: 140px">
                    <label class="form-label">Unit Price</label>
                    <asp:TextBox ID="unit_price" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2" style="width: 150px">
                    <label class="form-label">Bank</label>
                    
                  
                    <asp:DropDownList ID="bank" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Select a bank" Value=""  Selected="true"></asp:ListItem>
                        <asp:ListItem Text="Amana Bank" Value="Amana Bank"></asp:ListItem>
                        <asp:ListItem Text="Commercial Bank" Value="Commercial Bank"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label mr-2">Application</label>
                    <asp:RadioButtonList ID="IsApplication" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Yes" Value="true"></asp:ListItem>
                        <asp:ListItem Text="No" Value="false"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-1 mr-4">
                    <label class="form-label mr-2">Payment</label>
                    <asp:RadioButtonList ID="IsPayment" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Yes" Value="true"></asp:ListItem>
                        <asp:ListItem Text="No" Value="false"></asp:ListItem>
                    </asp:RadioButtonList>                    
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Freight Date</label>
                    <asp:TextBox ID="freight_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Freight Value</label>
                    <asp:TextBox ID="freight_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Delivery Order Date</label>
                    <asp:TextBox ID="delivery_order_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Delivery Order Value</label>
                    <asp:TextBox ID="delivery_order_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Insurance Value</label>
                    <asp:TextBox ID="insurance_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="tab2">
            <%--TRCL--%>
            <h5 style="font-weight: 600">Approval</h5>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">TRCL No</label>
                    <asp:TextBox ID="trcl_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">TRCL Value</label>
                    <asp:TextBox ID="trcl_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3" style="border-bottom: groove">
                <label class="form-label">TRCL Date</label>
                <asp:TextBox ID="trcl_date" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <%--SLSI--%>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">SLSI No</label>
                    <asp:TextBox ID="slsi_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">SLSI Value</label>
                    <asp:TextBox ID="slsi_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3" style="border-bottom: groove">
                <label class="form-label">SLSI Date</label>
                <asp:TextBox ID="slsi_date" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <%--SSEA--%>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">SSEA No</label>
                    <asp:TextBox ID="ssea_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">SSEA Value</label>
                    <asp:TextBox ID="ssea_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3" style="border-bottom: groove">
                <label class="form-label">SSEA Date</label>
                <asp:TextBox ID="ssea_date" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Import License No</label>
                    <asp:TextBox ID="imp_license_no" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">IMP Value</label>
                    <asp:TextBox ID="imp_value" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3" style="border-bottom: groove">
                <label class="form-label">IMP Date</label>
                <asp:TextBox ID="imp_date" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3" style="border-bottom: groove">
                <asp:CheckBoxList  runat="server" CssClass="form-control">
                    <asp:ListItem  ID="imp_license" Text=" Import License" Value="true"></asp:ListItem>
                    <asp:ListItem  ID="invoice" Text=" Invoice" Value="true"></asp:ListItem>
                    <asp:ListItem  ID="packing" Text=" Packing" Value="true"></asp:ListItem>
                    <asp:ListItem  ID="bl" Text=" BL" Value="true"></asp:ListItem>
                    <asp:ListItem  ID="origin" Text=" Origin" Value="true"></asp:ListItem>
                    <asp:ListItem  ID="assessment" Text=" Assessment" Value="true"></asp:ListItem>
                    <asp:ListItem  ID="cusdec" Text=" CUSDEC" Value="true"></asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <div class="mb-3">
                <label class="form-label">LC/TT No</label>
                <asp:TextBox ID="lc_tt_no" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">BL No</label>
                <asp:TextBox ID="bl_no" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Shipping Line</label>
                <asp:TextBox ID="shipping_line" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Vessel / Flight</label>
                <asp:TextBox ID="vessel_flight" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="tab3">
            <div class="mb-3">
                <label class="form-label">Estimate Load Date</label>
                <asp:TextBox ID="est_load_date" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">ETD</label>
                <asp:TextBox ID="etd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Remark</label>
                <asp:TextBox ID="remark1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">ETA</label>
                <asp:TextBox ID="eta" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">              
                <asp:RadioButtonList runat="server" CssClass="form-control">
                    <asp:ListItem ID="fcl" Text="FCL" Value="true"></asp:ListItem>
                    <asp:ListItem ID="lcl" Text="LCL" Value="true"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="mb-3 mr-2" style="width: 150px">
                <label class="form-label">Trasport Mode</label>
                
                <asp:DropDownList ID="tran_mode" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Select a mode" Value=""  Selected="true"></asp:ListItem>
                    <asp:ListItem Text="Sea" Value="Sea"></asp:ListItem>
                    <asp:ListItem Text="Air" Value="Air"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Document Received - Bank</label>
                    <asp:TextBox ID="doc_bank_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Original Docs Handover - Agent</label>
                    <asp:TextBox ID="ori_doc_agent_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 mr-2">
                <label class="form-label">Remark</label>
                <asp:TextBox ID="remark2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">CUSDEC Date</label>
                    <asp:TextBox ID="cusdec_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Container Destuff - Date</label>
                    <asp:TextBox ID="con_destuff_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Duty Paid Date</label>
                    <asp:TextBox ID="duty_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Entry Passed Date</label>
                    <asp:TextBox ID="entry_passed_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 mr-2">
                <label class="form-label">Remark</label>
                <asp:TextBox ID="remark3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">FCL Loaded at Port - Date</label>
                    <asp:TextBox ID="prt_load_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Examination Done Date</label>
                    <asp:TextBox ID="exam_done_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Actual Clearence - Date</label>
                    <asp:TextBox ID="act_clear_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Warehouse Released - Date</label>
                    <asp:TextBox ID="warehouse_date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 mr-2">
                <label class="form-label">Remark</label>
                <asp:TextBox ID="remark4" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>

    <div class="btn-set">
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Save" OnClick="Save_Button_Click" />
        <asp:Button ID="btn2" runat="server" CssClass="btn btn-secondary" Text="Cancel" OnClick="Cancel_Button_Click" />
    </div>
     <asp:Label ID="lblSuccessMessage" runat="server" ForeColor="Green" Text=""></asp:Label>
    <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red" Text=""></asp:Label>
    <script type="text/javascript">
        $(function () {
            $('#datepicker').datepicker();
        });
    </script>
</asp:Content>

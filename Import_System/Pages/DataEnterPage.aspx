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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="main-content">
        <div class="tab1">
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Consignment No</label>
                    <input type="text" class="form-control" id="con_no">
                </div>
                <div class="mb-3">
                    <label class="form-label">Month</label>
                    <input type="month" class="form-control" id="month">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Delivery Terms</label>
                    <input type="text" class="form-control" id="delivery_terms">
                </div>
                <%--<div class="mb-3">
                    <label class="form-label">Consignment No</label>
                    <input type="text" class="form-control" id="con_no">
                </div>--%>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2" style="width: 120px">
                    <label class="form-label">Payment Terms</label>
                    <input type="text" class="form-control" id="con_no">
                </div>
                <div class="mb-3 mr-2" style="width: 95px">
                    <label class="form-label">Advance</label>
                    <input type="number" class="form-control" id="advance">
                </div>
                <div class="mb-3 mr-2" style="width: 130px">
                    <label class="form-label">Date</label>
                    <input type="date" class="form-control" id="a_date">
                </div>
                <div class="mb-3 mr-2" style="width: 95px">
                    <label class="form-label">Balance</label>
                    <input type="number" class="form-control" id="balance">
                </div>
                <div class="mb-3 mr-2" style="width: 130px">
                    <label class="form-label">Date</label>
                    <input type="date" class="form-control" id="b_date">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Exporter Name</label>
                    <input type="text" class="form-control" id="exp_name">
                </div>
                <div class="mb-3">
                    <label class="form-label">Import Licencse No</label>
                    <input type="text" class="form-control" id="imp_license_no">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Forwarder</label>
                    <input type="text" class="form-control" id="forwarder">
                </div>
                <div class="mb-3">
                    <label class="form-label">Insurance Policy No</label>
                    <input type="text" class="form-control" id="insurance_policy_no">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Item</label>
                    <input type="text" class="form-control" id="item">
                </div>
                <div class="mb-3" style="width: 85px">
                    <label class="form-label">Qty</label>
                    <input type="number" class="form-control" id="qty">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Proforma No</label>
                    <input type="text" class="form-control" id="proforma_no">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Invoice Value</label>
                    <input type="number" class="form-control" id="invoice_value">
                </div>
                <div class="mb-3 mr-2" style="width: 140px">
                    <label class="form-label">Invoice No</label>
                    <input type="text" class="form-control" id="invoice_no">
                </div>
                <div class="mb-3" style="width: 140px">
                    <label class="form-label">Unit Price</label>
                    <input type="number" class="form-control" id="unit_price">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2" style="width: 150px">
                    <label class="form-label">Bank</label>
                    <select class="form-control" id="bank">
                        <option value="" disabled selected>Select a bank</option>
                        <option value="bank1">Amana Bank</option>
                        <option value="bank2">Commercial Bank</option>
                    </select>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label mr-2">Application</label>
                    <input type="radio" id="yes" name="bank" value="yes">
                    <label for="bank1">Yes</label>
                    <input type="radio" id="no" name="bank" value="no">
                    <label for="bank2">No</label>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-1 mr-4">
                    <label class="form-label mr-2">Payment</label>
                    <input type="radio" id="yes" name="bank" value="yes">
                    <label for="bank1">Yes</label>
                    <input type="radio" id="no" name="bank" value="no">
                    <label for="bank2">No</label>
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Freight Date</label>
                    <input type="date" class="form-control" id="freight_date">
                </div>
                <div class="mb-3">
                    <label class="form-label">Freight Value</label>
                    <input type="number" class="form-control" id="freight_value">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Delivery Order Date</label>
                    <input type="date" class="form-control" id="delivery_order_date">
                </div>
                <div class="mb-3">
                    <label class="form-label">Delivery Order Value</label>
                    <input type="number" class="form-control" id="delivery_order_value">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Insurance Value</label>
                    <input type="number" class="form-control" id="insurance_value">
                </div>    
            </div>
        </div>


        <div class="tab2">
            <%--TRCL--%>
            <h5 style="font-weight:600">Approval</h5>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">TRCL No</label>
                    <input type="text" class="form-control" id="trcl_no">
                </div>
                <div class="mb-3">
                    <label class="form-label">TRCL Value</label>
                    <input type="number" class="form-control" id="trcl_value">
                </div>
            </div>
            <div class="mb-3" style="border-bottom:groove">
                <label class="form-label">TRCL Date</label>
                <input type="date" class="form-control" id="trcl_date">
            </div>
            <%--SLSI--%>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">SLSI No</label>
                    <input type="text" class="form-control" id="slsi_no">
                </div>
                <div class="mb-3">
                    <label class="form-label">SLSI Value</label>
                    <input type="number" class="form-control" id="slsi_value">
                </div>
            </div>
            <div class="mb-3" style="border-bottom:groove">
                <label class="form-label">SLSI Date</label>
                <input type="date" class="form-control" id="slsi_date">
            </div>

            <%--SSEA--%>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">SSEA No</label>
                    <input type="text" class="form-control" id="ssea_no">
                </div>
                <div class="mb-3">
                    <label class="form-label">SSEA Value</label>
                    <input type="number" class="form-control" id="ssea_value">
                </div>
            </div>
            <div class="mb-3" style="border-bottom:groove">
                <label class="form-label">SSEA Date</label>
                <input type="date" class="form-control" id="ssea_date">
            </div>

            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Import License No</label>
                    <input type="text" class="form-control" id="imp_license_no">
                </div>
                <div class="mb-3">
                    <label class="form-label">IMP Value</label>
                    <input type="number" class="form-control" id="imp_value">
                </div>
            </div>
            <div class="mb-3" style="border-bottom: groove">
                <label class="form-label">IMP Date</label>
                <input type="date" class="form-control" id="imp_date">
            </div>

            <div class="mb-3" style="border-bottom: groove">
                <label>Import License</label>
                <input type="checkbox" id="imp_license">
                <label>Invoice</label>
                <input type="checkbox" id="invoice">
                <label>Packing</label>
                <input type="checkbox" id="packing">
                <label>BL</label>
                <input type="checkbox" id="bl">
                <label>Origin</label>
                <input type="checkbox" id="origin">
                <label>Assessment</label>
                <input type="checkbox" id="assessment">
                <label>CUSDEC</label>
                <input type="checkbox" id="cusdec">
            </div>
            <div class="mb-3">
                <label class="form-label">LC/TT No</label>
                <input type="text" class="form-control" id="lc_tt_no">
            </div>
            <div class="mb-3">
                <label class="form-label">BL No</label>
                <input type="text" class="form-control" id="bl_no">
            </div>
            <div class="mb-3">
                <label class="form-label">Shipping Line</label>
                <input type="text" class="form-control" id="bl_no">
            </div>
            <div class="mb-3">
                <label class="form-label">Vessel / Flight</label>
                <input type="text" class="form-control" id="vessel_flight">
            </div>
            
        </div>

        <div class="tab3">
            <div class="mb-3">
                <label class="form-label">Estimate Load Date</label>
                <input type="date" class="form-control" id="est_load_date">
            </div>
            <div class="mb-3">
                <label class="form-label">ETD</label>
                <input type="date" class="form-control" id="etd">
            </div>
            <div class="mb-3">
                <label class="form-label">Remark</label>
                <input type="text" class="form-control" id="remark1">
            </div>
            <div class="mb-3">
                <label class="form-label">ETA</label>
                <input type="date" class="form-control" id="eta">
            </div>
            <div class="mb-3">
                <input type="radio" id="yes" name="bank" value="fcl">
                <label >FCL</label>
                <input type="radio" id="no" name="bank" value="lcl">
                <label>LCL</label>
            </div>
            <div class="mb-3 mr-2" style="width: 150px">
                <label class="form-label">Trasport Mode</label>
                <select class="form-control" id="tran_mode">
                    <option value="" disabled selected>Select a mode</option>
                    <option value="bank1">Sea</option>
                    <option value="bank2">Air</option>
                </select>
            </div>
            
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Document Received - Bank</label>
                    <input type="date" class="form-control" id="doc_bank_date">
                </div>
                <div class="mb-3">
                    <label class="form-label">Original Docs Handover - Agent</label>
                    <input type="date" class="form-control" id="ori_doc_agent_date">
                </div>
            </div>


            <div class="mb-3 mr-2">
                <label class="form-label">Remark</label>
                <input type="text" class="form-control" id="remark2">
            </div>


            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">CUSDEC Date</label>
                    <input type="date" class="form-control" id="cusdec_date">
                </div>
                <div class="mb-3">
                    <label class="form-label">Container Destuff - Date</label>
                    <input type="date" class="form-control" id="con_destuff_date">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Duty Paid Date</label>
                    <input type="date" class="form-control" id="duty_date">
                </div>
                <div class="mb-3">
                    <label class="form-label">Entry Passed Date</label>
                    <input type="date" class="form-control" id="entry_passed_date">
                </div>
            </div>

            <div class="mb-3 mr-2">
                <label class="form-label">Remark</label>
                <input type="text" class="form-control" id="remark3">
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">FCL Loaded at Port - Date</label>
                    <input type="date" class="form-control" id="prt_load_date">
                </div>
                <div class="mb-3">
                    <label class="form-label">Examination Done Date</label>
                    <input type="date" class="form-control" id="exam_done_date">
                </div>
            </div>
            <div class="tab1-1">
                <div class="mb-3 mr-2">
                    <label class="form-label">Actual Clearence - Date</label>
                    <input type="date" class="form-control" id="act_clear_date">
                </div>
                <div class="mb-3">
                    <label class="form-label">Warehouse Released - Date</label>
                    <input type="date" class="form-control" id="warehouse_date">
                </div>
            </div>
            <div class="mb-3 mr-2">
                <label class="form-label">Remark</label>
                <input type="text" class="form-control" id="remark4">
            </div>
        </div>

        <%-- <div class="tab4">
            <div class="mb-3">
                <label class="form-label">Consignment No</label>
                <input type="text" class="form-control" id="con_no">
            </div>
            <div class="mb-3">
                <label class="form-label">Consignment No</label>
                <input type="text" class="form-control" id="con_no">
            </div>
            <div class="mb-3">
                <label class="form-label">Consignment No</label>
                <input type="text" class="form-control" id="con_no">
            </div>
        </div>--%>

    </div>

    <div class="btn-set">
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Save" OnClick="Save_Button_Click" />
        <asp:Button ID="btn2" runat="server" CssClass="btn btn-secondary" Text="Cancel" OnClick="Cancel_Button_Click" />
    </div>

    <script type="text/javascript">
        $(function () {
            $('#datepicker').datepicker();
        });
    </script>
</asp:Content>

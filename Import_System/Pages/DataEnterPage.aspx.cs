using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Web.Services.Description;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Newtonsoft.Json;
using System.Data;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;

namespace Import_System.Pages
{
    public partial class DataEnterPage : System.Web.UI.Page
    {


        SqlConnection sqlConnection = new SqlConnection(@"Data Source=192.168.1.8,6789; Initial Catalog=Brantel_Imports;User ID=sa;Password=Etel123;");
        protected void Page_Load(object sender, EventArgs e)
        {
            DataEntry data_entry = new DataEntry();
            string refNo = Request.QueryString["refNo"];
            if (!string.IsNullOrEmpty(refNo))
            {

                int ref_No = Convert.ToInt32(refNo);
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("GetShipmentByConNo", sqlConnection);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@ref_no", ref_No);
                DataTable dt1 = new DataTable();
                sqlDa.Fill(dt1);
                //Button1.Text = "Update";
                hfRefNo.Value = refNo;

                if (refNo != null)
                {
                    updateBtn.Visible = true;
                    Button1.Visible = false;
                }

                con_no.Text = dt1.Rows[0]["con_no"].ToString();
                month.Text = dt1.Rows[0]["month"].ToString();
                delivery_terms.Text = dt1.Rows[0]["delivery_terms"].ToString();
                payment_terms.Text = dt1.Rows[0]["payment_terms"].ToString();
                advance.Text = dt1.Rows[0]["advance_value"].ToString();
                //a_date.Text = DateTime.Parse(dt1.Rows[0]["advance_date"].ToString()).ToString("yyyy-MM-dd");
                string advDateString = dt1.Rows[0]["advance_date"].ToString();
                DateTime advDate;

                if (!string.IsNullOrEmpty(advDateString) && DateTime.TryParse(advDateString, out advDate))
                {
                    a_date.Text = advDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    a_date.Text = ""; // or set to null if needed
                }
                balance.Text = dt1.Rows[0]["balance_value"].ToString();
                //b_date.Text = DateTime.Parse(dt1.Rows[0]["balance_date"].ToString()).ToString("yyyy-MM-dd");
                string balDateString = dt1.Rows[0]["balance_date"].ToString();
                DateTime balDate;

                if (!string.IsNullOrEmpty(balDateString) && DateTime.TryParse(balDateString, out balDate))
                {
                    b_date.Text = balDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    b_date.Text = ""; // or set to null if needed
                }
                exp_name.Text = dt1.Rows[0]["exporter_name"].ToString();
                forwarder.Text = dt1.Rows[0]["forwarder"].ToString();
                insurance_policy_no.Text = dt1.Rows[0]["insurance_policy_no"].ToString();
                item.Text = dt1.Rows[0]["item_des"].ToString();
                qty.Text = dt1.Rows[0]["qty"].ToString();
                proforma_no.Text = dt1.Rows[0]["proforma_no"].ToString();
                invoice_value.Text = dt1.Rows[0]["invoice_value"].ToString();
                invoice_no.Text = dt1.Rows[0]["Invoice_no"].ToString();
                unit_price.Text = dt1.Rows[0]["unit_price"].ToString();
                bank.Text = dt1.Rows[0]["bank"].ToString();
                IsApplication.SelectedValue = Boolean.Parse(dt1.Rows[0]["application"].ToString()).ToString().ToLower();
                IsPayment.SelectedValue = Boolean.Parse(dt1.Rows[0]["payment"].ToString()).ToString().ToLower();
                IsActive.SelectedValue = Boolean.Parse(dt1.Rows[0]["IsActive"].ToString()).ToString().ToLower();
                IsCleared.SelectedValue = Boolean.Parse(dt1.Rows[0]["IsCleared"].ToString()).ToString().ToLower();

                string frightDateString = dt1.Rows[0]["freight_date"].ToString();               
                DateTime frightDate;

                if (!string.IsNullOrEmpty(frightDateString) && DateTime.TryParse(frightDateString, out frightDate))
                {
                    freight_date.Text = frightDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    freight_date.Text = ""; // or set to null if needed
                }

                freight_value.Text = dt1.Rows[0]["freight_value"].ToString();
                //delivery_order_date.Text = DateTime.Parse(dt1.Rows[0]["delivery_order"].ToString()).ToString("yyyy-MM-dd");
                string deliveryDateString = dt1.Rows[0]["delivery_order"].ToString();
                DateTime deliveryDate;

                if (!string.IsNullOrEmpty(deliveryDateString) && DateTime.TryParse(deliveryDateString, out deliveryDate))
                {
                    delivery_order_date.Text = deliveryDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    delivery_order_date.Text = ""; // or set to null if needed
                }

                delivery_order_value.Text = dt1.Rows[0]["delivery_order_value"].ToString();
                insurance_value.Text = dt1.Rows[0]["insurance_value"].ToString();

                trcl_no.Text = dt1.Rows[0]["TRCL_No"].ToString();
                //trcl_date.Text = DateTime.Parse(dt1.Rows[0]["TRCL_Date"].ToString()).ToString("yyyy-MM-dd");
                string trclDateString = dt1.Rows[0]["TRCL_Date"].ToString();
                DateTime trclDate;

                if (!string.IsNullOrEmpty(trclDateString) && DateTime.TryParse(trclDateString, out trclDate))
                {
                    trcl_date.Text = trclDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    trcl_date.Text = ""; // or set to null if needed
                }

                trcl_value.Text = dt1.Rows[0]["TRCL_Value"].ToString();
                slsi_no.Text = dt1.Rows[0]["SLSI_No"].ToString();
                //slsi_date.Text = DateTime.Parse(dt1.Rows[0]["SLSI_Date"].ToString()).ToString("yyyy-MM-dd");
                string slsiDateString = dt1.Rows[0]["SLSI_Date"].ToString();
                DateTime slsiDate;

                if (!string.IsNullOrEmpty(slsiDateString) && DateTime.TryParse(slsiDateString, out slsiDate))
                {
                    slsi_date.Text = slsiDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    slsi_date.Text = ""; // or set to null if needed
                }

                slsi_value.Text = dt1.Rows[0]["SLSI_Value"].ToString();
                ssea_no.Text = dt1.Rows[0]["SSEA_No"].ToString();
                //ssea_date.Text = DateTime.Parse(dt1.Rows[0]["SSEA_Date"].ToString()).ToString("yyyy-MM-dd");
                string sseaDateString = dt1.Rows[0]["SSEA_Date"].ToString();
                DateTime sseaDate;

                if (!string.IsNullOrEmpty(sseaDateString) && DateTime.TryParse(sseaDateString, out sseaDate))
                {
                    ssea_date.Text = sseaDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    ssea_date.Text = ""; // or set to null if needed
                }
                ssea_value.Text = dt1.Rows[0]["SSEA_Value"].ToString();
                imp_license_no.Text = dt1.Rows[0]["import_licence_no"].ToString();
                imp_value.Text = dt1.Rows[0]["Import_license_value"].ToString();
                //imp_date.Text = DateTime.Parse(dt1.Rows[0]["Imp_date"].ToString()).ToString("yyyy-MM-dd");
                string impDateString = dt1.Rows[0]["Imp_date"].ToString();
                DateTime impDate;

                if (!string.IsNullOrEmpty(impDateString) && DateTime.TryParse(impDateString, out impDate))
                {
                    imp_date.Text = impDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    imp_date.Text = ""; // or set to null if needed
                }

                string Import_license = Boolean.Parse(dt1.Rows[0]["import_license"].ToString()).ToString().ToLower();
                if(Import_license == "true")
                {
                    import_license.Checked=true;
                }
                string Invoice = Boolean.Parse(dt1.Rows[0]["invoice"].ToString()).ToString().ToLower();
                if(Invoice == "true")
                {
                    invoice.Checked = true;
                }
                string Packing = Boolean.Parse(dt1.Rows[0]["packing"].ToString()).ToString().ToLower();
                if(Packing == "true")
                {
                    packing.Checked = true;
                }
                string BL = Boolean.Parse(dt1.Rows[0]["BL"].ToString()).ToString().ToLower();
                if(BL == "true")
                {
                    bl.Checked = true;
                }
                string Origin = Boolean.Parse(dt1.Rows[0]["origin"].ToString()).ToString().ToLower();
                if(Origin == "true")
                {
                    origin.Checked = true;
                }
                string Assesment = Boolean.Parse(dt1.Rows[0]["Assessment"].ToString()).ToString().ToLower();
                if(Assesment == "true")
                {
                    assessment.Checked = true;
                }
                string CUSDEC = Boolean.Parse(dt1.Rows[0]["cusdec"].ToString()).ToString().ToLower();
                if(CUSDEC == "true")
                {
                    cusdec.Checked = true;
                }

                lc_tt_no.Text = dt1.Rows[0]["LC_TT_no"].ToString();
                string lcTtPayDateString = dt1.Rows[0]["lc_tt_payment_date"].ToString();
                DateTime lcTtPayDate;

                if (!string.IsNullOrEmpty(lcTtPayDateString) && DateTime.TryParse(lcTtPayDateString, out lcTtPayDate))
                {
                    lc_tt_pay_date.Text = lcTtPayDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    lc_tt_pay_date.Text = ""; // or set to null if needed
                }
                bl_no.Text = dt1.Rows[0]["BL_number"].ToString();
                shipping_line.Text = dt1.Rows[0]["Shipping_line"].ToString();
                vessel_flight.Text = dt1.Rows[0]["vessel_flight"].ToString();
               // est_load_date.Text = DateTime.Parse(dt1.Rows[0]["estimate_load_date"].ToString()).ToString("yyyy-MM-dd");
                string estLoadDateString = dt1.Rows[0]["estimate_load_date"].ToString();
                DateTime estLoadDate;

                if (!string.IsNullOrEmpty(estLoadDateString) && DateTime.TryParse(estLoadDateString, out estLoadDate))
                {
                    est_load_date.Text = estLoadDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    est_load_date.Text = ""; // or set to null if needed
                }

                //etd.Text = DateTime.Parse(dt1.Rows[0]["ETD"].ToString()).ToString("yyyy-MM-dd");
                string etDateString = dt1.Rows[0]["ETD"].ToString();
                DateTime etDate;

                if (!string.IsNullOrEmpty(etDateString) && DateTime.TryParse(etDateString, out etDate))
                {
                    etd.Text = etDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    etd.Text = ""; // or set to null if needed
                }

                remark1.Text = dt1.Rows[0]["remarks1"].ToString();
                //eta.Text = DateTime.Parse(dt1.Rows[0]["ETA"].ToString()).ToString("yyyy-MM-dd");
                string etaDateString = dt1.Rows[0]["ETA"].ToString();
                DateTime etaDate;
                if (!string.IsNullOrEmpty(etaDateString) && DateTime.TryParse(etaDateString, out etaDate))
                {
                    eta.Text = etaDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    eta.Text = ""; // or set to null if needed
                }

                tran_mode.Text = dt1.Rows[0]["transport_mode"].ToString();
                //doc_bank_date.Text = DateTime.Parse(dt1.Rows[0]["docs_received_bank"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                string docBankDateString = dt1.Rows[0]["docs_received_bank"].ToString();
                DateTime docBankDate;
                if (!string.IsNullOrEmpty(docBankDateString) && DateTime.TryParse(docBankDateString, out docBankDate))
                {
                    doc_bank_date.Text = docBankDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    doc_bank_date.Text = ""; // or set to null if needed
                }
                //ori_doc_agent_date.Text = DateTime.Parse(dt1.Rows[0]["original_docs_handover_agent"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                string oriDocAgentDateString = dt1.Rows[0]["original_docs_handover_agent"].ToString();
                DateTime oriDocAgentDate;
                if (!string.IsNullOrEmpty(oriDocAgentDateString) && DateTime.TryParse(oriDocAgentDateString, out oriDocAgentDate))
                {
                    ori_doc_agent_date.Text = oriDocAgentDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    ori_doc_agent_date.Text = ""; // or set to null if needed
                }
                //copy_doc_agent.Text = DateTime.Parse(dt1.Rows[0]["copy_docs_handover_agent"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                string copyDocAgentDateString = dt1.Rows[0]["copy_docs_handover_agent"].ToString();
                DateTime copyDocAgentDate;
                if (!string.IsNullOrEmpty(copyDocAgentDateString) && DateTime.TryParse(copyDocAgentDateString, out copyDocAgentDate))
                {
                    copy_doc_agent.Text = copyDocAgentDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    copy_doc_agent.Text = ""; // or set to null if needed
                }
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();
                //cusdec_date.Text = DateTime.Parse(dt1.Rows[0]["cusdec_date"].ToString()).ToString("yyyy-MM-dd");
                string cusdecDateString = dt1.Rows[0]["cusdec_date"].ToString();
                DateTime cusdecDate;
                if (!string.IsNullOrEmpty(cusdecDateString) && DateTime.TryParse(cusdecDateString, out cusdecDate))
                {
                    cusdec_date.Text = cusdecDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    cusdec_date.Text = ""; // or set to null if needed
                }
                //con_destuff_date.Text = DateTime.Parse(dt1.Rows[0]["container_destuff_date"].ToString()).ToString("yyyy-MM-dd");
                string conDestuffDateString = dt1.Rows[0]["container_destuff_date"].ToString();
                DateTime conDestuffDate;
                if (!string.IsNullOrEmpty(conDestuffDateString) && DateTime.TryParse(conDestuffDateString, out conDestuffDate))
                {
                    con_destuff_date.Text = conDestuffDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    con_destuff_date.Text = ""; // or set to null if needed
                }
                //duty_date.Text = DateTime.Parse(dt1.Rows[0]["duty_paid_date"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                string dutyDateString = dt1.Rows[0]["duty_paid_date"].ToString();
                DateTime dutyDate;
                if (!string.IsNullOrEmpty(dutyDateString) && DateTime.TryParse(dutyDateString, out dutyDate))
                {
                    duty_date.Text = dutyDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    duty_date.Text = ""; // or set to null if needed
                }
                //entry_passed_date.Text = DateTime.Parse(dt1.Rows[0]["entry_passed_date"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                string entryDateString = dt1.Rows[0]["entry_passed_date"].ToString();
                DateTime entryDate;
                if (!string.IsNullOrEmpty(entryDateString) && DateTime.TryParse(entryDateString, out entryDate))
                {
                    entry_passed_date.Text = entryDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    entry_passed_date.Text = ""; // or set to null if needed
                }
                remark3.Text = dt1.Rows[0]["remarks3"].ToString();
                //prt_load_date.Text = DateTime.Parse(dt1.Rows[0]["fcl_loaded_port_date"].ToString()).ToString("yyyy-MM-dd");
                string portLoadDateString = dt1.Rows[0]["fcl_loaded_port_date"].ToString();
                DateTime portLoadDate;
                if (!string.IsNullOrEmpty(portLoadDateString) && DateTime.TryParse(portLoadDateString, out portLoadDate))
                {
                    prt_load_date.Text = portLoadDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    prt_load_date.Text = ""; // or set to null if needed
                }
                //exam_done_date.Text = DateTime.Parse(dt1.Rows[0]["examination_done_date"].ToString()).ToString("yyyy-MM-dd");
                string examDateString = dt1.Rows[0]["examination_done_date"].ToString();
                DateTime examDate;
                if (!string.IsNullOrEmpty(examDateString) && DateTime.TryParse(examDateString, out examDate))
                {
                    exam_done_date.Text = examDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    exam_done_date.Text = ""; // or set to null if needed
                }
                //act_clear_date.Text = DateTime.Parse(dt1.Rows[0]["actual_clearence_date"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                string actClearDateString = dt1.Rows[0]["actual_clearence_date"].ToString();
                DateTime actClearDate;
                if (!string.IsNullOrEmpty(actClearDateString) && DateTime.TryParse(actClearDateString, out actClearDate))
                {
                    act_clear_date.Text = actClearDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    act_clear_date.Text = ""; // or set to null if needed
                }
                //warehouse_date.Text = DateTime.Parse(dt1.Rows[0]["warehouse_release_date"].ToString()).ToString("yyyy-MM-dd");
                string releaseDateString = dt1.Rows[0]["warehouse_release_date"].ToString();
                DateTime releaseDate;
                if (!string.IsNullOrEmpty(releaseDateString) && DateTime.TryParse(releaseDateString, out releaseDate))
                {
                    warehouse_date.Text = releaseDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    warehouse_date.Text = ""; // or set to null if needed
                }
                remark4.Text = dt1.Rows[0]["remarks4"].ToString();


                string shipmentType = dt1.Rows[0]["fcl_20ft"].ToString(); 
                string shipmentType1 = dt1.Rows[0]["fcl_40ft"].ToString(); 
                string shipmentType2 = dt1.Rows[0]["lcl"].ToString();

                if (shipmentType2 == "True")
                {
                    shipmentTypeRadioButtonList.Text = "LCL";
                }
                else if (shipmentType1 == "True")
                {
                    shipmentTypeRadioButtonList.Text = "FCL40ft";
                }
                else if (shipmentType == "True")
                {
                    shipmentTypeRadioButtonList.Text = "FCL20ft";
                }
               

            }

            

            month.Attributes.Add("type", "month");
            a_date.Attributes.Add("type", "date");
            advance.Attributes.Add("type", "number");
            b_date.Attributes.Add("type", "date");
            freight_date.Attributes.Add("type", "date");
            warehouse_date.Attributes.Add("type", "date");
            act_clear_date.Attributes.Add("type", "datetime-local");
            exam_done_date.Attributes.Add("type", "date");
            prt_load_date.Attributes.Add("type", "date");
            entry_passed_date.Attributes.Add("type", "datetime-local");
            duty_date.Attributes.Add("type", "datetime-local");
            con_destuff_date.Attributes.Add("type", "date");
            cusdec_date.Attributes.Add("type", "date");
            ori_doc_agent_date.Attributes.Add("type", "datetime-local");
            doc_bank_date.Attributes.Add("type", "datetime-local");
            
            est_load_date.Attributes.Add("type", "date");
            etd.Attributes.Add("type", "date");
            eta.Attributes.Add("type", "date");
            delivery_order_date.Attributes.Add("type", "date");
            trcl_date.Attributes.Add("type", "date");
            slsi_date.Attributes.Add("type", "date");
            ssea_date.Attributes.Add("type", "date");
            imp_date.Attributes.Add("type", "date");

            lc_tt_pay_date.Attributes.Add("type", "date");
            copy_doc_agent.Attributes.Add("type", "datetime-local");

        }



        protected void Save_Button_Click(object sender, EventArgs e)
        {
           
            DateTime logDate = DateTime.Today; // Log date
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                using (SqlCommand cmd = new SqlCommand("CreateShipment", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ref_no", (hfRefNo.Value == "" ? 0 : Convert.ToInt32(hfRefNo.Value)));
                    cmd.Parameters.AddWithValue("@log_date", logDate);
                    cmd.Parameters.AddWithValue("@con_no", con_no.Text.Trim());
                    cmd.Parameters.AddWithValue("@month", string.IsNullOrWhiteSpace(month.Text) ? (object)DBNull.Value : month.Text.Trim());
                    cmd.Parameters.AddWithValue("@delivery_terms", string.IsNullOrWhiteSpace(delivery_terms.Text) ? (object)DBNull.Value : delivery_terms.Text.Trim());
                    cmd.Parameters.AddWithValue("@payment_terms", string.IsNullOrWhiteSpace(payment_terms.Text) ? (object)DBNull.Value : payment_terms.Text.Trim());
                    cmd.Parameters.AddWithValue("@exporter_name", string.IsNullOrWhiteSpace(exp_name.Text) ? (object)DBNull.Value : exp_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@forwarder", string.IsNullOrWhiteSpace(forwarder.Text) ? (object)DBNull.Value : forwarder.Text.Trim());
                    cmd.Parameters.AddWithValue("@item_des", item.Text.Trim());
                    cmd.Parameters.AddWithValue("@proforma_no", string.IsNullOrWhiteSpace(proforma_no.Text) ? (object)DBNull.Value: proforma_no.Text.Trim());
                    cmd.Parameters.AddWithValue("@qty", qty.Text.Trim());
                    cmd.Parameters.AddWithValue("@invoice_value", string.IsNullOrWhiteSpace(invoice_value.Text) ? (object)DBNull.Value: invoice_value.Text.Trim());
                    cmd.Parameters.AddWithValue("@bank", string.IsNullOrWhiteSpace(bank.Text) ? (object)DBNull.Value : bank.Text.Trim());
                    cmd.Parameters.AddWithValue("@application", IsApplication.SelectedValue);
                    cmd.Parameters.AddWithValue("@payment", IsPayment.SelectedValue);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive.SelectedValue);
                    cmd.Parameters.AddWithValue("@IsCleared", IsCleared.SelectedValue);
                    cmd.Parameters.AddWithValue("@delivery_order", string.IsNullOrWhiteSpace(delivery_order_date.Text) ? (object)DBNull.Value : delivery_order_date.Text);
                    cmd.Parameters.AddWithValue("@freight_value", string.IsNullOrWhiteSpace(freight_value.Text) ? (object)DBNull.Value : freight_value.Text);
                    cmd.Parameters.AddWithValue("@freight_date", string.IsNullOrWhiteSpace(freight_date.Text) ? (object)DBNull.Value : freight_date.Text);
                    cmd.Parameters.AddWithValue("@insurance_value", string.IsNullOrWhiteSpace(insurance_value.Text) ? (object)DBNull.Value : insurance_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_No", string.IsNullOrWhiteSpace(trcl_no.Text) ? (object)DBNull.Value : trcl_no.Text);
                    cmd.Parameters.AddWithValue("@SLSI_No", string.IsNullOrWhiteSpace(slsi_no.Text) ? (object)DBNull.Value: slsi_no.Text);
                    cmd.Parameters.AddWithValue("@import_license", import_license.Checked);
                    cmd.Parameters.AddWithValue("@invoice", invoice.Checked);
                    cmd.Parameters.AddWithValue("@packing", packing.Checked);
                    cmd.Parameters.AddWithValue("@bl", bl.Checked);
                    cmd.Parameters.AddWithValue("@origin", origin.Checked);
                    cmd.Parameters.AddWithValue("@assessment", assessment.Checked);
                    cmd.Parameters.AddWithValue("@cusdec", cusdec.Checked);
                    cmd.Parameters.AddWithValue("@import_licence_no", string.IsNullOrWhiteSpace(imp_license_no.Text) ? (object)DBNull.Value : imp_license_no.Text);
                    cmd.Parameters.AddWithValue("@insurance_policy_no", string.IsNullOrWhiteSpace(insurance_policy_no.Text) ? (object)DBNull.Value : insurance_policy_no.Text);
                    cmd.Parameters.AddWithValue("@LC_TT_no", string.IsNullOrWhiteSpace(lc_tt_no.Text) ? (object)DBNull.Value : lc_tt_no.Text);
                    cmd.Parameters.AddWithValue("@Invoice_no", string.IsNullOrWhiteSpace(invoice_no.Text) ? (object)DBNull.Value : invoice_no.Text);
                    cmd.Parameters.AddWithValue("@unit_price", string.IsNullOrWhiteSpace(unit_price.Text) ? (object)DBNull.Value : unit_price.Text);
                    cmd.Parameters.AddWithValue("@BL_number", string.IsNullOrWhiteSpace(bl_no.Text) ? (object)DBNull.Value : bl_no.Text);
                    cmd.Parameters.AddWithValue("@vessel_flight", string.IsNullOrWhiteSpace(vessel_flight.Text) ? (object)DBNull.Value : vessel_flight.Text);
                    cmd.Parameters.AddWithValue("@estimate_load_date", string.IsNullOrWhiteSpace(est_load_date.Text) ? (object)DBNull.Value : est_load_date.Text);
                    cmd.Parameters.AddWithValue("@ETD", string.IsNullOrWhiteSpace(etd.Text) ? (object)DBNull.Value : etd.Text);
                    cmd.Parameters.AddWithValue("@remarks1", string.IsNullOrWhiteSpace(remark1.Text) ? (object)DBNull.Value : remark1.Text);
                    cmd.Parameters.AddWithValue("@ETA", string.IsNullOrWhiteSpace(eta.Text) ? (object)DBNull.Value : eta.Text);
                    cmd.Parameters.AddWithValue("@transport_mode", tran_mode.SelectedValue);
                    
                    if (string.IsNullOrWhiteSpace(doc_bank_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@docs_received_bank", DBNull.Value);
                    }
                    else
                    {
                        DateTime docBankDate;
                        if (DateTime.TryParse(doc_bank_date.Text, out docBankDate))
                        {
                            cmd.Parameters.AddWithValue("@docs_received_bank", docBankDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }

                    if (string.IsNullOrWhiteSpace(copy_doc_agent.Text))
                    {
                        cmd.Parameters.AddWithValue("@copy_docs_handover_agent", DBNull.Value);
                    }
                    else
                    {
                        DateTime copyDocAgentDate;
                        if (DateTime.TryParse(copy_doc_agent.Text, out copyDocAgentDate))
                        {
                            cmd.Parameters.AddWithValue("@copy_docs_handover_agent", copyDocAgentDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }

                    if (string.IsNullOrWhiteSpace(ori_doc_agent_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@original_docs_handover_agent", DBNull.Value);
                    }
                    else
                    {
                        DateTime oriDocAgentDate;
                        if (DateTime.TryParse(ori_doc_agent_date.Text, out oriDocAgentDate))
                        {
                            cmd.Parameters.AddWithValue("@original_docs_handover_agent", oriDocAgentDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }
                    cmd.Parameters.AddWithValue("@remarks2", string.IsNullOrWhiteSpace(remark2.Text) ? (object)DBNull.Value : remark2.Text);
                    cmd.Parameters.AddWithValue("@cusdec_date", string.IsNullOrWhiteSpace(cusdec_date.Text) ? (object)DBNull.Value : cusdec_date.Text);
                    cmd.Parameters.AddWithValue("@container_destuff_date", string.IsNullOrWhiteSpace(con_destuff_date.Text) ? (object)DBNull.Value : con_destuff_date.Text);
                    if (string.IsNullOrWhiteSpace(duty_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@duty_paid_date", DBNull.Value);
                    }
                    else
                    {
                        DateTime dutyPaidDate;
                        if (DateTime.TryParse(duty_date.Text, out dutyPaidDate))
                        {
                            cmd.Parameters.AddWithValue("@duty_paid_date", dutyPaidDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }
                    
                    if (string.IsNullOrWhiteSpace(entry_passed_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@entry_passed_date", DBNull.Value);
                    }
                    else
                    {
                        DateTime entryPassDate;
                        if (DateTime.TryParse(entry_passed_date.Text, out entryPassDate))
                        {
                            cmd.Parameters.AddWithValue("@entry_passed_date", entryPassDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }
                    cmd.Parameters.AddWithValue("@remarks3", string.IsNullOrWhiteSpace(remark3.Text) ? (object)DBNull.Value : remark3.Text);
                    cmd.Parameters.AddWithValue("@fcl_loaded_port_date", string.IsNullOrWhiteSpace(prt_load_date.Text) ? (object)DBNull.Value : prt_load_date.Text);
                    cmd.Parameters.AddWithValue("@examination_done_date", string.IsNullOrWhiteSpace(exam_done_date.Text) ? (object)DBNull.Value : exam_done_date.Text);
                    
                    if (string.IsNullOrWhiteSpace(act_clear_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@actual_clearence_date", DBNull.Value);
                    }
                    else
                    {
                        DateTime actClearDate;
                        if (DateTime.TryParse(act_clear_date.Text, out actClearDate))
                        {
                            cmd.Parameters.AddWithValue("@actual_clearence_date", actClearDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }
                    cmd.Parameters.AddWithValue("@warehouse_release_date", string.IsNullOrWhiteSpace(warehouse_date.Text) ? (object)DBNull.Value : warehouse_date.Text);
                    cmd.Parameters.AddWithValue("@remarks4", string.IsNullOrWhiteSpace(remark4.Text) ? (object)DBNull.Value : remark4.Text);
                    cmd.Parameters.AddWithValue("@advance_value", string.IsNullOrWhiteSpace(advance.Text) ? (object)DBNull.Value : advance.Text);
                    cmd.Parameters.AddWithValue("@advance_date", string.IsNullOrWhiteSpace(a_date.Text) ? (object)DBNull.Value : a_date.Text);
                    cmd.Parameters.AddWithValue("@balance_value", string.IsNullOrWhiteSpace(balance.Text) ? (object)DBNull.Value : balance.Text);
                    cmd.Parameters.AddWithValue("@balance_date", string.IsNullOrWhiteSpace(b_date.Text) ? (object)DBNull.Value : b_date.Text);
                    cmd.Parameters.AddWithValue("@delivery_order_value", string.IsNullOrWhiteSpace(delivery_order_value.Text) ? (object)DBNull.Value : delivery_order_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_Value", string.IsNullOrWhiteSpace(trcl_value.Text) ? (object)DBNull.Value : trcl_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_Date", string.IsNullOrWhiteSpace(trcl_date.Text) ? (object)DBNull.Value : trcl_date.Text);
                    cmd.Parameters.AddWithValue("@SLSI_Value", string.IsNullOrWhiteSpace(slsi_value.Text) ? (object)DBNull.Value : slsi_value.Text);
                    cmd.Parameters.AddWithValue("@SLSI_Date", string.IsNullOrWhiteSpace(slsi_date.Text) ? (object)DBNull.Value : slsi_date.Text);
                    cmd.Parameters.AddWithValue("@SSEA_No", string.IsNullOrWhiteSpace(ssea_no.Text) ? (object)DBNull.Value : ssea_no.Text);
                    cmd.Parameters.AddWithValue("@SSEA_Value", string.IsNullOrWhiteSpace(ssea_value.Text) ? (object)DBNull.Value : ssea_value.Text);
                    cmd.Parameters.AddWithValue("@SSEA_Date", string.IsNullOrWhiteSpace(ssea_date.Text) ? (object)DBNull.Value : ssea_date.Text);
                    cmd.Parameters.AddWithValue("@Import_license_value", string.IsNullOrWhiteSpace(imp_value.Text) ? (object)DBNull.Value : imp_value.Text);
                    cmd.Parameters.AddWithValue("@Imp_date", string.IsNullOrWhiteSpace(imp_date.Text) ? (object)DBNull.Value : imp_date.Text);
                    cmd.Parameters.AddWithValue("@Shipping_line", string.IsNullOrWhiteSpace(shipping_line.Text) ? (object)DBNull.Value : shipping_line.Text);
                    int fclValue20 = 0;
                    int fclValue40 = 0;
                    int lclValue = 0;
                    if (shipmentTypeRadioButtonList.SelectedValue == "FCL20ft")
                    {
                        fclValue20 = 1;
                    }
                    else if(shipmentTypeRadioButtonList.SelectedValue == "FCL40ft")
                    {
                        fclValue40 = 1;
                    }
                    else if (shipmentTypeRadioButtonList.SelectedValue == "LCL")
                    {
                        lclValue = 1;
                    }
                    cmd.Parameters.AddWithValue("@fcl_20ft", fclValue20);
                    cmd.Parameters.AddWithValue("@fcl_40ft", fclValue40);
                    cmd.Parameters.AddWithValue("@lcl", lclValue);

                    cmd.ExecuteNonQuery();
                }

               
                 string message = "Save successfully!";
                 string script = $"alert('{message}');";
                 ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

                 Clear();
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "An error occurred: " + ex.Message;
            }
            finally
            {
                // Ensure the connection is always closed
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        


        protected void Cancel_Button_Click(object sender, EventArgs e)
        {
            Clear();
            Response.Redirect("HomePage.aspx");

        }

        public void Clear()
        {
            hfRefNo.Value = "";
            con_no.Text = month.Text = delivery_terms.Text = payment_terms.Text = exp_name.Text = forwarder.Text = "";
            advance.Text = a_date.Text = balance.Text = b_date.Text = insurance_policy_no.Text = "";
            item.Text = qty.Text = proforma_no.Text = invoice_value.Text = invoice_no.Text = unit_price.Text = "";
            bank.Text  = freight_date.Text = freight_value.Text = "";
            
            delivery_order_date.Text = delivery_order_value.Text = insurance_value.Text = "";
            trcl_no.Text = trcl_value.Text = trcl_date.Text = "";
            slsi_no.Text = slsi_value.Text = slsi_date.Text = "";
            ssea_no.Text = ssea_value.Text = ssea_date.Text = "";
            imp_license_no.Text = imp_value.Text = imp_date.Text = "";

            import_license.Checked = false;
            invoice.Checked = false;
            packing.Checked = false;
            bl.Checked = false;
            origin.Checked = false;
            assessment.Checked = false;
            cusdec.Checked = false;

            lc_tt_no.Text = lc_tt_pay_date.Text = bl_no.Text = shipping_line.Text = vessel_flight.Text = "";
            est_load_date.Text = etd.Text = eta.Text = remark1.Text = "";
            //Radio Buttons
            shipmentTypeRadioButtonList.SelectedValue = "";
            IsApplication.SelectedValue = "";
            IsPayment.SelectedValue = "";
            IsActive.SelectedValue = "";
            IsCleared.SelectedValue = "";

            tran_mode.SelectedValue = "";
            doc_bank_date.Text = copy_doc_agent.Text = ori_doc_agent_date.Text = remark2.Text = cusdec_date.Text = con_destuff_date.Text = "";
            duty_date.Text = entry_passed_date.Text = remark3.Text = prt_load_date.Text = exam_done_date.Text = act_clear_date.Text = warehouse_date.Text = remark4.Text = "";
            //Response.Redirect("HomePage.aspx");
        }

        protected void UpdateBtnClick(object sender, EventArgs e)
        {

            DateTime logDate = DateTime.Today; // Log date
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                using (SqlCommand cmd = new SqlCommand("UpdateShipment", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ref_no", (hfRefNo.Value == "" ? 0 : Convert.ToInt32(hfRefNo.Value)));
                    cmd.Parameters.AddWithValue("@log_date", logDate);
                    cmd.Parameters.AddWithValue("@con_no", con_no.Text.Trim());

                    cmd.Parameters.AddWithValue("@month", string.IsNullOrWhiteSpace(month.Text) ? (object)DBNull.Value : month.Text.Trim());
                    cmd.Parameters.AddWithValue("@delivery_terms", string.IsNullOrWhiteSpace(delivery_terms.Text) ? (object)DBNull.Value : delivery_terms.Text.Trim());
                    cmd.Parameters.AddWithValue("@payment_terms", string.IsNullOrWhiteSpace(payment_terms.Text) ? (object)DBNull.Value : payment_terms.Text.Trim());
                    cmd.Parameters.AddWithValue("@exporter_name", string.IsNullOrWhiteSpace(exp_name.Text) ? (object)DBNull.Value : exp_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@forwarder", string.IsNullOrWhiteSpace(forwarder.Text) ? (object)DBNull.Value : forwarder.Text.Trim());

                    cmd.Parameters.AddWithValue("@item_des", item.Text.Trim());
                    cmd.Parameters.AddWithValue("@proforma_no", string.IsNullOrWhiteSpace(proforma_no.Text) ? (object)DBNull.Value : proforma_no.Text.Trim());
                    cmd.Parameters.AddWithValue("@qty", qty.Text.Trim());
                    cmd.Parameters.AddWithValue("@invoice_value", string.IsNullOrWhiteSpace(invoice_value.Text) ? (object)DBNull.Value : invoice_value.Text.Trim());
                    cmd.Parameters.AddWithValue("@bank", string.IsNullOrWhiteSpace(bank.Text) ? (object)DBNull.Value : bank.Text.Trim());
                    cmd.Parameters.AddWithValue("@application", IsApplication.SelectedValue);
                    cmd.Parameters.AddWithValue("@payment", IsPayment.SelectedValue);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive.SelectedValue);
                    cmd.Parameters.AddWithValue("@IsCleared", IsCleared.SelectedValue);
                    cmd.Parameters.AddWithValue("@delivery_order", string.IsNullOrWhiteSpace(delivery_order_date.Text) ? (object)DBNull.Value : delivery_order_date.Text);
                    cmd.Parameters.AddWithValue("@freight_value", string.IsNullOrWhiteSpace(freight_value.Text) ? (object)DBNull.Value : freight_value.Text);
                    cmd.Parameters.AddWithValue("@freight_date", string.IsNullOrWhiteSpace(freight_date.Text) ? (object)DBNull.Value : freight_date.Text);
                    cmd.Parameters.AddWithValue("@insurance_value", string.IsNullOrWhiteSpace(insurance_value.Text) ? (object)DBNull.Value : insurance_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_No", string.IsNullOrWhiteSpace(trcl_no.Text) ? (object)DBNull.Value : trcl_no.Text);
                    cmd.Parameters.AddWithValue("@SLSI_No", string.IsNullOrWhiteSpace(slsi_no.Text) ? (object)DBNull.Value : slsi_no.Text);
                    cmd.Parameters.AddWithValue("@import_license", import_license.Checked);
                    cmd.Parameters.AddWithValue("@invoice", invoice.Checked);
                    cmd.Parameters.AddWithValue("@packing", packing.Checked);
                    cmd.Parameters.AddWithValue("@bl", bl.Checked);
                    cmd.Parameters.AddWithValue("@origin", origin.Checked);
                    cmd.Parameters.AddWithValue("@assessment", assessment.Checked);
                    cmd.Parameters.AddWithValue("@cusdec", cusdec.Checked);
                    cmd.Parameters.AddWithValue("@import_licence_no", string.IsNullOrWhiteSpace(imp_license_no.Text) ? (object)DBNull.Value : imp_license_no.Text);
                    cmd.Parameters.AddWithValue("@insurance_policy_no", string.IsNullOrWhiteSpace(insurance_policy_no.Text) ? (object)DBNull.Value : insurance_policy_no.Text);
                    cmd.Parameters.AddWithValue("@LC_TT_no", string.IsNullOrWhiteSpace(lc_tt_no.Text) ? (object)DBNull.Value : lc_tt_no.Text);
                    cmd.Parameters.AddWithValue("@Invoice_no", string.IsNullOrWhiteSpace(invoice_no.Text) ? (object)DBNull.Value : invoice_no.Text);
                    cmd.Parameters.AddWithValue("@unit_price", string.IsNullOrWhiteSpace(unit_price.Text) ? (object)DBNull.Value : unit_price.Text);
                    cmd.Parameters.AddWithValue("@BL_number", string.IsNullOrWhiteSpace(bl_no.Text) ? (object)DBNull.Value : bl_no.Text);
                    cmd.Parameters.AddWithValue("@vessel_flight", string.IsNullOrWhiteSpace(vessel_flight.Text) ? (object)DBNull.Value : vessel_flight.Text);
                    cmd.Parameters.AddWithValue("@estimate_load_date", string.IsNullOrWhiteSpace(est_load_date.Text) ? (object)DBNull.Value : est_load_date.Text);
                    cmd.Parameters.AddWithValue("@ETD", string.IsNullOrWhiteSpace(etd.Text) ? (object)DBNull.Value : etd.Text);
                    cmd.Parameters.AddWithValue("@remarks1", string.IsNullOrWhiteSpace(remark1.Text) ? (object)DBNull.Value : remark1.Text);
                    cmd.Parameters.AddWithValue("@ETA", string.IsNullOrWhiteSpace(eta.Text) ? (object)DBNull.Value : eta.Text);
                    cmd.Parameters.AddWithValue("@transport_mode", tran_mode.SelectedValue);

                    if (string.IsNullOrWhiteSpace(doc_bank_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@docs_received_bank", DBNull.Value);
                    }
                    else
                    {
                        DateTime docBankDate;
                        if (DateTime.TryParse(doc_bank_date.Text, out docBankDate))
                        {
                            cmd.Parameters.AddWithValue("@docs_received_bank", docBankDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }

                    if (string.IsNullOrWhiteSpace(copy_doc_agent.Text))
                    {
                        cmd.Parameters.AddWithValue("@copy_docs_handover_agent", DBNull.Value);
                    }
                    else
                    {
                        DateTime copyDocAgentDate;
                        if (DateTime.TryParse(copy_doc_agent.Text, out copyDocAgentDate))
                        {
                            cmd.Parameters.AddWithValue("@copy_docs_handover_agent", copyDocAgentDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }

                    if (string.IsNullOrWhiteSpace(ori_doc_agent_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@original_docs_handover_agent", DBNull.Value);
                    }
                    else
                    {
                        DateTime oriDocAgentDate;
                        if (DateTime.TryParse(ori_doc_agent_date.Text, out oriDocAgentDate))
                        {
                            cmd.Parameters.AddWithValue("@original_docs_handover_agent", oriDocAgentDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }
                    cmd.Parameters.AddWithValue("@remarks2", string.IsNullOrWhiteSpace(remark2.Text) ? (object)DBNull.Value : remark2.Text);
                    cmd.Parameters.AddWithValue("@cusdec_date", string.IsNullOrWhiteSpace(cusdec_date.Text) ? (object)DBNull.Value : cusdec_date.Text);
                    cmd.Parameters.AddWithValue("@container_destuff_date", string.IsNullOrWhiteSpace(con_destuff_date.Text) ? (object)DBNull.Value : con_destuff_date.Text);
                    if (string.IsNullOrWhiteSpace(duty_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@duty_paid_date", DBNull.Value);
                    }
                    else
                    {
                        DateTime dutyPaidDate;
                        if (DateTime.TryParse(duty_date.Text, out dutyPaidDate))
                        {
                            cmd.Parameters.AddWithValue("@duty_paid_date", dutyPaidDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }

                    if (string.IsNullOrWhiteSpace(entry_passed_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@entry_passed_date", DBNull.Value);
                    }
                    else
                    {
                        DateTime entryPassDate;
                        if (DateTime.TryParse(entry_passed_date.Text, out entryPassDate))
                        {
                            cmd.Parameters.AddWithValue("@entry_passed_date", entryPassDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }
                    cmd.Parameters.AddWithValue("@remarks3", string.IsNullOrWhiteSpace(remark3.Text) ? (object)DBNull.Value : remark3.Text);
                    cmd.Parameters.AddWithValue("@fcl_loaded_port_date", string.IsNullOrWhiteSpace(prt_load_date.Text) ? (object)DBNull.Value : prt_load_date.Text);
                    cmd.Parameters.AddWithValue("@examination_done_date", string.IsNullOrWhiteSpace(exam_done_date.Text) ? (object)DBNull.Value : exam_done_date.Text);

                    if (string.IsNullOrWhiteSpace(act_clear_date.Text))
                    {
                        cmd.Parameters.AddWithValue("@actual_clearence_date", DBNull.Value);
                    }
                    else
                    {
                        DateTime actClearDate;
                        if (DateTime.TryParse(act_clear_date.Text, out actClearDate))
                        {
                            cmd.Parameters.AddWithValue("@actual_clearence_date", actClearDate);
                        }
                        else
                        {
                            throw new FormatException("Invalid date format");
                        }
                    }
                    cmd.Parameters.AddWithValue("@warehouse_release_date", string.IsNullOrWhiteSpace(warehouse_date.Text) ? (object)DBNull.Value : warehouse_date.Text);
                    cmd.Parameters.AddWithValue("@remarks4", string.IsNullOrWhiteSpace(remark4.Text) ? (object)DBNull.Value : remark4.Text);
                    cmd.Parameters.AddWithValue("@advance_value", string.IsNullOrWhiteSpace(advance.Text) ? (object)DBNull.Value : advance.Text);
                    cmd.Parameters.AddWithValue("@advance_date", string.IsNullOrWhiteSpace(a_date.Text) ? (object)DBNull.Value : a_date.Text);
                    cmd.Parameters.AddWithValue("@balance_value", string.IsNullOrWhiteSpace(balance.Text) ? (object)DBNull.Value : balance.Text);
                    cmd.Parameters.AddWithValue("@balance_date", string.IsNullOrWhiteSpace(b_date.Text) ? (object)DBNull.Value : b_date.Text);
                    cmd.Parameters.AddWithValue("@delivery_order_value", string.IsNullOrWhiteSpace(delivery_order_value.Text) ? (object)DBNull.Value : delivery_order_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_Value", string.IsNullOrWhiteSpace(trcl_value.Text) ? (object)DBNull.Value : trcl_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_Date", string.IsNullOrWhiteSpace(trcl_date.Text) ? (object)DBNull.Value : trcl_date.Text);
                    cmd.Parameters.AddWithValue("@SLSI_Value", string.IsNullOrWhiteSpace(slsi_value.Text) ? (object)DBNull.Value : slsi_value.Text);
                    cmd.Parameters.AddWithValue("@SLSI_Date", string.IsNullOrWhiteSpace(slsi_date.Text) ? (object)DBNull.Value : slsi_date.Text);
                    cmd.Parameters.AddWithValue("@SSEA_No", string.IsNullOrWhiteSpace(ssea_no.Text) ? (object)DBNull.Value : ssea_no.Text);
                    cmd.Parameters.AddWithValue("@SSEA_Value", string.IsNullOrWhiteSpace(ssea_value.Text) ? (object)DBNull.Value : ssea_value.Text);
                    cmd.Parameters.AddWithValue("@SSEA_Date", string.IsNullOrWhiteSpace(ssea_date.Text) ? (object)DBNull.Value : ssea_date.Text);
                    cmd.Parameters.AddWithValue("@Import_license_value", string.IsNullOrWhiteSpace(imp_value.Text) ? (object)DBNull.Value : imp_value.Text);
                    cmd.Parameters.AddWithValue("@Imp_date", string.IsNullOrWhiteSpace(imp_date.Text) ? (object)DBNull.Value : imp_date.Text);
                    cmd.Parameters.AddWithValue("@Shipping_line", string.IsNullOrWhiteSpace(shipping_line.Text) ? (object)DBNull.Value : shipping_line.Text);
                    int fclValue20 = 0;
                    int fclValue40 = 0;
                    int lclValue = 0;
                    if (shipmentTypeRadioButtonList.SelectedValue == "FCL20ft")
                    {
                        fclValue20 = 1;
                    }
                    else if (shipmentTypeRadioButtonList.SelectedValue == "FCL40ft")
                    {
                        fclValue40 = 1;
                    }
                    else if (shipmentTypeRadioButtonList.SelectedValue == "LCL")
                    {
                        lclValue = 1;
                    }
                    cmd.Parameters.AddWithValue("@fcl_20ft", fclValue20);
                    cmd.Parameters.AddWithValue("@fcl_40ft", fclValue40);
                    cmd.Parameters.AddWithValue("@lcl", lclValue);

                    cmd.ExecuteNonQuery();

                    string message = "Updated Successfully!";
                    string script = $"alert('{message}');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

                    Clear();

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
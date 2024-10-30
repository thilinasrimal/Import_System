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
                Button1.Text = "Update";
                hfRefNo.Value = refNo;

                con_no.Text = dt1.Rows[0]["con_no"].ToString();
                month.Text = dt1.Rows[0]["month"].ToString();
                delivery_terms.Text = dt1.Rows[0]["delivery_terms"].ToString();
                payment_terms.Text = dt1.Rows[0]["payment_terms"].ToString();
                advance.Text = dt1.Rows[0]["advance_value"].ToString();
                a_date.Text = DateTime.Parse(dt1.Rows[0]["advance_date"].ToString()).ToString("yyyy-MM-dd");
                balance.Text = dt1.Rows[0]["balance_value"].ToString();
                b_date.Text = DateTime.Parse(dt1.Rows[0]["balance_date"].ToString()).ToString("yyyy-MM-dd");
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
                freight_date.Text = DateTime.Parse(dt1.Rows[0]["freight_date"].ToString()).ToString("yyyy-MM-dd");
                freight_value.Text = dt1.Rows[0]["freight_value"].ToString();
                delivery_order_date.Text = DateTime.Parse(dt1.Rows[0]["delivery_order"].ToString()).ToString("yyyy-MM-dd");
                delivery_order_value.Text = dt1.Rows[0]["delivery_order_value"].ToString();
                insurance_value.Text = dt1.Rows[0]["insurance_value"].ToString();

                trcl_no.Text = dt1.Rows[0]["TRCL_No"].ToString();
                trcl_date.Text = DateTime.Parse(dt1.Rows[0]["TRCL_Date"].ToString()).ToString("yyyy-MM-dd");
                trcl_value.Text = dt1.Rows[0]["TRCL_Value"].ToString();
                slsi_no.Text = dt1.Rows[0]["SLSI_No"].ToString();
                slsi_date.Text = DateTime.Parse(dt1.Rows[0]["SLSI_Date"].ToString()).ToString("yyyy-MM-dd");
                slsi_value.Text = dt1.Rows[0]["SLSI_Value"].ToString();
                ssea_no.Text = dt1.Rows[0]["SSEA_No"].ToString();
                ssea_date.Text = DateTime.Parse(dt1.Rows[0]["SSEA_Date"].ToString()).ToString("yyyy-MM-dd");
                ssea_value.Text = dt1.Rows[0]["SSEA_Value"].ToString();
                imp_license_no.Text = dt1.Rows[0]["import_licence_no"].ToString();
                imp_value.Text = dt1.Rows[0]["Import_license_value"].ToString();
                imp_date.Text = DateTime.Parse(dt1.Rows[0]["Imp_date"].ToString()).ToString("yyyy-MM-dd");

                import_license.Text = Boolean.Parse(dt1.Rows[0]["import_license"].ToString()).ToString().ToLower();
                invoice.Text = Boolean.Parse(dt1.Rows[0]["invoice"].ToString()).ToString().ToLower();
                packing.Text = Boolean.Parse(dt1.Rows[0]["packing"].ToString()).ToString().ToLower();
                bl.Text = Boolean.Parse(dt1.Rows[0]["BL"].ToString()).ToString().ToLower();
                origin.Text = Boolean.Parse(dt1.Rows[0]["origin"].ToString()).ToString().ToLower();
                assessment.Text = Boolean.Parse(dt1.Rows[0]["Assessment"].ToString()).ToString().ToLower();
                cusdec.Text = Boolean.Parse(dt1.Rows[0]["cusdec"].ToString()).ToString().ToLower();

                lc_tt_no.Text = dt1.Rows[0]["LC_TT_no"].ToString();
                bl_no.Text = dt1.Rows[0]["BL_number"].ToString();
                shipping_line.Text = dt1.Rows[0]["Shipping_line"].ToString();
                vessel_flight.Text = dt1.Rows[0]["vessel_flight"].ToString();
                est_load_date.Text = DateTime.Parse(dt1.Rows[0]["estimate_load_date"].ToString()).ToString("yyyy-MM-dd");
                etd.Text = DateTime.Parse(dt1.Rows[0]["ETD"].ToString()).ToString("yyyy-MM-dd");
                remark1.Text = dt1.Rows[0]["remarks1"].ToString();
                eta.Text = DateTime.Parse(dt1.Rows[0]["ETA"].ToString()).ToString("yyyy-MM-dd");
                shipmentTypeRadioButtonList.SelectedValue = dt1.Rows[0]["fcl"].ToString();
                shipmentTypeRadioButtonList.SelectedValue = dt1.Rows[0]["lcl"].ToString();
                tran_mode.Text = dt1.Rows[0]["transport_mode"].ToString();
                doc_bank_date.Text = DateTime.Parse(dt1.Rows[0]["docs_received_bank"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                ori_doc_agent_date.Text = DateTime.Parse(dt1.Rows[0]["original_docs_handover_agent"].ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();
                remark2.Text = dt1.Rows[0]["remarks2"].ToString();

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
                    cmd.Parameters.AddWithValue("@proforma_no", proforma_no.Text.Trim());
                    cmd.Parameters.AddWithValue("@qty", qty.Text.Trim());
                    cmd.Parameters.AddWithValue("@invoice_value", invoice_value.Text.Trim());
                    cmd.Parameters.AddWithValue("@bank", bank.Text.Trim());
                    cmd.Parameters.AddWithValue("@application", IsApplication.SelectedValue);
                    cmd.Parameters.AddWithValue("@payment", IsPayment.SelectedValue);
                    cmd.Parameters.AddWithValue("@delivery_order", delivery_order_date.Text);
                    cmd.Parameters.AddWithValue("@freight_value", freight_value.Text);
                    cmd.Parameters.AddWithValue("@freight_date", freight_date.Text);
                    cmd.Parameters.AddWithValue("@insurance_value", insurance_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_No", trcl_no.Text);
                    cmd.Parameters.AddWithValue("@SLSI_No", slsi_no.Text);
                    cmd.Parameters.AddWithValue("@import_license", import_license.Checked);
                    cmd.Parameters.AddWithValue("@invoice", invoice.Checked);
                    cmd.Parameters.AddWithValue("@packing", packing.Checked);
                    cmd.Parameters.AddWithValue("@bl", bl.Checked);
                    cmd.Parameters.AddWithValue("@origin", origin.Checked);
                    cmd.Parameters.AddWithValue("@assessment", assessment.Checked);
                    cmd.Parameters.AddWithValue("@cusdec", cusdec.Checked);
                    cmd.Parameters.AddWithValue("@import_licence_no", imp_license_no.Text);
                    cmd.Parameters.AddWithValue("@insurance_policy_no", insurance_policy_no.Text);
                    cmd.Parameters.AddWithValue("@LC_TT_no", lc_tt_no.Text);
                    cmd.Parameters.AddWithValue("@Invoice_no", invoice_no.Text);
                    cmd.Parameters.AddWithValue("@unit_price", unit_price.Text);
                    cmd.Parameters.AddWithValue("@BL_number", bl_no.Text);
                    cmd.Parameters.AddWithValue("@vessel_flight", vessel_flight.Text);
                    cmd.Parameters.AddWithValue("@estimate_load_date", est_load_date.Text);
                    cmd.Parameters.AddWithValue("@ETD", etd.Text);
                    cmd.Parameters.AddWithValue("@remarks1", remark1.Text);
                    cmd.Parameters.AddWithValue("@ETA", eta.Text);
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
                    cmd.Parameters.AddWithValue("@remarks2", remark2.Text);
                    cmd.Parameters.AddWithValue("@cusdec_date", cusdec_date.Text);
                    cmd.Parameters.AddWithValue("@container_destuff_date", con_destuff_date.Text);
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
                    cmd.Parameters.AddWithValue("@remarks3", remark3.Text);
                    cmd.Parameters.AddWithValue("@fcl_loaded_port_date", prt_load_date.Text);
                    cmd.Parameters.AddWithValue("@examination_done_date", exam_done_date.Text);
                    
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
                    cmd.Parameters.AddWithValue("@warehouse_release_date", warehouse_date.Text);
                    cmd.Parameters.AddWithValue("@remarks4", remark4.Text);
                    cmd.Parameters.AddWithValue("@advance_value", advance.Text);
                    cmd.Parameters.AddWithValue("@advance_date", a_date.Text);
                    cmd.Parameters.AddWithValue("@balance_value", balance.Text);
                    cmd.Parameters.AddWithValue("@balance_date", b_date.Text);
                    cmd.Parameters.AddWithValue("@delivery_order_value", delivery_order_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_Value", trcl_value.Text);
                    cmd.Parameters.AddWithValue("@TRCL_Date", trcl_date.Text);
                    cmd.Parameters.AddWithValue("@SLSI_Value", slsi_value.Text);
                    cmd.Parameters.AddWithValue("@SLSI_Date", slsi_date.Text);
                    cmd.Parameters.AddWithValue("@SSEA_No", ssea_no.Text);
                    cmd.Parameters.AddWithValue("@SSEA_Value", ssea_value.Text);
                    cmd.Parameters.AddWithValue("@SSEA_Date", ssea_date.Text);
                    cmd.Parameters.AddWithValue("@Import_license_value", imp_value.Text);
                    cmd.Parameters.AddWithValue("@Imp_date", imp_date.Text);
                    cmd.Parameters.AddWithValue("@Shipping_line", shipping_line.Text);
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
                    cmd.Parameters.AddWithValue("@[fcl 20ft]", fclValue20);
                    cmd.Parameters.AddWithValue("@fcl 40ft", fclValue40);
                    cmd.Parameters.AddWithValue("@lcl", lclValue);



                    cmd.ExecuteNonQuery();
                }

                string refNo = hfRefNo.Value;
                if (refNo == "")
                {
                    string message = "Save successfully!";
                    string script = $"alert('{message}');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);

                }
                else
                {
                    string message = "Updated Successfully!";
                    string script = $"alert('{message}');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                   

                }

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
            IsApplication.SelectedValue = "0";
            IsPayment.SelectedValue = "0";
            delivery_order_date.Text = delivery_order_value.Text = insurance_value.Text = "";
            trcl_no.Text = trcl_value.Text = trcl_date.Text = "";
            slsi_no.Text = slsi_value.Text = slsi_date.Text = "";
            ssea_no.Text = ssea_value.Text = ssea_date.Text = "";
            imp_license_no.Text = imp_value.Text = imp_date.Text = "";
             
            lc_tt_no.Text = bl_no.Text = shipping_line.Text = vessel_flight.Text = "";
            est_load_date.Text = etd.Text = eta.Text = remark1.Text = "";
            shipmentTypeRadioButtonList.SelectedValue = "0";
            tran_mode.SelectedValue = "";
            doc_bank_date.Text = ori_doc_agent_date.Text = remark2.Text = cusdec_date.Text = con_destuff_date.Text = "";
            duty_date.Text = entry_passed_date.Text = remark3.Text = prt_load_date.Text = exam_done_date.Text = act_clear_date.Text = warehouse_date.Text = remark4.Text = "";

        }
    }
}
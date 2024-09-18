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

namespace Import_System.Pages
{
    public partial class DataEnterPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {

                //DateTime log_date = DateTime.Today;
                //Boolean isValid = Flag(false);
                //if (isValid)
                //{
                //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Successfully Saved');", true);
                //    string sSQL = " INSERT INTO Brantel_Imports.dbo.Import_Shedules (log_date, con_no,month, delivery_terms, payment_terms, exporter_name, forwarder, item_des, proforma_no, qty, invoice_value, bank, application, payment, delivery_order, freight_value, freight_date," +
                //        " insurance_value, TRCL, SLSI, import_license, invoice, packing, BL, origin, Assessment," +
                //        " cusdec, import_licence_no, insurance_policy_no, LC_TT_no, Invoice_no, unit_price, BL_number, vessel_flight, estimate_load_date, ETD, remarks1, ETA, FCL, LCL," +
                //        " transport_mode, docs_received_bank, original_docs_handover_agent, remarks2, cusdec_date, container_destuff_date, " +
                //        "duty_paid_date, entry_passed_date, remarks3, fcl_loaded_port_date, examination_done_date, actual_clearence_date, warehouse_release_date, remarks4) VALUES" +
                //        "( '"+log_date+"', '"+ con_no.Value + "', '"+month.Value+"', '"+delivery_terms.Value +"', '"+payment_terms.Value +"', '"+exporter_name.Value +"', '"+forwarder.Value+"', '"+item_des.Value+"', '"+proforma_no.Value+"', "+qty.Value+", '"+invoice_value.Value+"', '"+bank.Value+"', '"+application.Value+"', '"+payment.Value+"', '"+delivery_date.Value+"', " +
                //        "'"+freight_value.Value+"', '"+freight_date.Value+"', '"+insurance_value.Value+"', '"+TRCL.Value+"', '"+SLSI.Value+"', '"+import_license.Value+"', '"+invoice.Value+"', '"+packing.Value+"','"+bl.Value+"','"+origin.Value+"','"+assessment.Value+"'," +
                //        " '"+cusdec.Value+"','"+import_licence_no.Value+"','"+insurance_policyNo.Value+"','"+lc_tt_no.Value+"','"+invoice_no.Value+"','"+unit_price.Value+"','"+bl_no.Value+"','"+vessle_flight.Value+"','"+est_load_date.Value+"','"+etd.Value+"','"+remark1.Value+"','"+eta.Value+"','"+fcl.Value+"','"+lcl.Value+"'," +
                //        " '"+transport_mode.Value+"','"+doc_received_bank.Value+"','"+original_docs_handover_agent.Value+"','"+remark2.Value+"','"+cusdec_date.Value+"','"+container_destuff_date.Value+"'," +
                //        " '"+duty_paid_date.Value+"','"+entry_passed_date.Value+"','"+remark3.Value+"','"+fcl_loaded_port_date.Value+"','"+examination_done_date.Value+"','"+actual_clearence_date.Value+"','"+warehouse_release_date.Value+"','"+remark4.Value+"');";
                    

                //    Response.Redirect("DetailsPage.aspx");
                //}
                //else
                //{
                //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Can not proceed!');", true);
                //}
                
            }
            catch(Exception ex)
            {

            }
           
            
        }

        public Boolean Flag(Boolean flag)
        {
           
            
            //if(!string.IsNullOrEmpty(con_no.Value) && !string.IsNullOrEmpty(exporter_name.Value))
            //{ 
            //   flag = true;
            //}
            //else
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Some fields are empty!');", true);
            //    flag = false;
            //}

            return flag;
        }

        protected void Cancel_Button_Click(object sender, EventArgs e)
        {

            //con_no.Value = string.Empty;
            //month.Value = string.Empty;
            //delivery_terms.Value = string.Empty;
            //payment_terms.Value = string.Empty;
            //exporter_name.Value = string.Empty;
            //forwarder.Value = string.Empty;
            //item_des.Value = string.Empty;
            //proforma_no.Value = string.Empty;
            //qty.Value = string.Empty;
            //invoice_value.Value = string.Empty;
            //bank.Value = string.Empty;
            //application.Value = string.Empty;
            //payment.Value = string.Empty;
            //delivery_date.Value = string.Empty;
            //freight_value.Value = string.Empty;
            //freight_date.Value = string.Empty;
            //insurance_value.Value = string.Empty;
            //TRCL.Value = string.Empty;
            //SLSI.Value = string.Empty;
            //import_license.Value = string.Empty;
            //invoice.Value = string.Empty;
            //packing.Value = string.Empty;
            //bl.Value = string.Empty;
            //origin.Value = string.Empty;
            //assessment.Value = string.Empty;
            //cusdec.Value = string.Empty;
            //import_licence_no.Value = string.Empty;
            //insurance_policyNo.Value = string.Empty;
            //lc_tt_no.Value = string.Empty;
            //invoice_no.Value = string.Empty;
            //unit_price.Value = string.Empty;
            //bl_no.Value = string.Empty;
            //vessle_flight.Value = string.Empty;
            //est_load_date.Value = string.Empty;
            //etd.Value = string.Empty;
            //remark1.Value = string.Empty;
            //eta.Value = string.Empty;
            //fcl.Value = string.Empty;
            //lcl.Value = string.Empty;
            //transport_mode.Value = string.Empty;
            //doc_received_bank.Value = string.Empty;
            //original_docs_handover_agent.Value = string.Empty;
            //remark2.Value = string.Empty;
            //cusdec_date.Value = string.Empty;
            //container_destuff_date.Value = string.Empty;
            //duty_paid_date.Value = string.Empty;
            //entry_passed_date.Value= string.Empty;
            //remark3.Value = string.Empty;
            //fcl_loaded_port_date.Value = string.Empty;
            //examination_done_date.Value = string.Empty;
            //actual_clearence_date.Value = string.Empty;
            //warehouse_release_date.Value = string.Empty;
            //remark4.Value = string.Empty;

            //Response.Redirect("DetailsPage.aspx");

        }

    }
}
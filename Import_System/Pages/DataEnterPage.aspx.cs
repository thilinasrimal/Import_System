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

namespace Import_System.Pages
{
    public partial class DataEnterPage : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=192.168.1.8,6789; Initial Catalog=Import_Shedules;User ID=sa;Password=Etel123;");
        protected void Page_Load(object sender, EventArgs e)
        {
            month.Attributes.Add("type", "month");
            a_date.Attributes.Add("type", "date");
            advance.Attributes.Add("type", "number");
            b_date.Attributes.Add("type", "date");
            freight_date.Attributes.Add ("type", "date");
            warehouse_date.Attributes.Add ("type", "date");
            act_clear_date.Attributes.Add ("type", "date");
            exam_done_date.Attributes.Add ("type", "date");
            prt_load_date.Attributes.Add ("type", "date");
            entry_passed_date.Attributes.Add ("type", "date");
            duty_date.Attributes.Add ("type", "date");
            con_destuff_date.Attributes.Add ("type", "date");
            cusdec_date.Attributes.Add ("type", "date");
            ori_doc_agent_date.Attributes.Add ("type", "date");
            doc_bank_date.Attributes.Add ("type", "date");
            est_load_date.Attributes.Add ("type", "date");
            etd.Attributes.Add ("type", "date");
            eta.Attributes.Add ("type", "date");
            delivery_order_date.Attributes.Add ("type", "date");
            trcl_date.Attributes.Add ("type", "date");
            slsi_date.Attributes.Add ("type", "date");
            ssea_date.Attributes.Add ("type", "date");
            imp_date.Attributes.Add ("type", "date");
            
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
                    cmd.Parameters.AddWithValue("@con_no",con_no.Text.Trim());
                    //string Month = month.Text.ToString();
                    cmd.Parameters.AddWithValue("@month", month.Text.Trim().ToString());
                    cmd.Parameters.AddWithValue("@delivery_terms", delivery_terms.Text.Trim());


                    cmd.ExecuteNonQuery();
                }

                string refNo = hfRefNo.Value;
                if (refNo == "")
                {
                    lblSuccessMessage.Text = "Saved Successfully";

                }
                else
                {
                    lblSuccessMessage.Text = "Updated Successfully";

                }
            }
            catch (Exception ex)
            {


                Console.WriteLine($"Error: {ex.Message}");
            }
        }

       

        protected void Cancel_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");

        }

    }
}
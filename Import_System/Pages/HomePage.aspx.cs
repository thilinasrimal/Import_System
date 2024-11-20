using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;

namespace Import_System.Pages
{
    public partial class HomePage : System.Web.UI.Page
    {
        public SqlConnection sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;

                string query = "SELECT * FROM Import_Shedules im where im.IsDelete is NULL ORDER by im.con_no ASC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataTable1.DataSource = dataTable;
                            dataTable1.DataBind();
                        }
                    }
                }



            }
            catch (Exception ex)
            {

            }
        }

        protected void dataTable1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void Open_Shipment(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = dataTable1.Rows[rowIndex];

                string refNo = row.Cells[0].Text;
                Console.WriteLine(refNo);

                if (!string.IsNullOrEmpty(refNo))
                {
                    
                    Response.Redirect($"DataEnterPage.aspx?refNo={refNo}", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                
                Console.Error.WriteLine($"Error: {ex.Message}");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            DataTable dt = GetData(searchText);
            dataTable1.DataSource = dt;
            dataTable1.DataBind();
        }
        private DataTable GetData(string searchText)
        {
            
            string search_Text = searchText;            
            DataTable dt = new DataTable();
            
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;

                string query1 = @"SELECT * FROM Import_Shedules is2 WHERE con_no ='" + search_Text + "' or exporter_name LIKE '%" + search_Text + "%' or item_des LIKE '%" + search_Text + "%' or BL_number LIKE '%"+search_Text+"%'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                            dataTable1.DataSource = dt;
                            dataTable1.DataBind();                        
                        }

                    }
                }

            }
            catch (Exception ex)
            {

            }
            return dt;
        }

    }
}
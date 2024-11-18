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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;

                // Define your SQL query
                string query = "SELECT * FROM Import_Shedules where IsDelete is NULL";

                // Create a SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SqlDataAdapter
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a DataTable to hold the data
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the GridView
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
                    //Response.Redirect($"DataEnterPage.aspx?refNo={refNo}");
                    Response.Redirect($"DataEnterPage.aspx?refNo={refNo}", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                // Log the exception or show an error message to the user
                Console.Error.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
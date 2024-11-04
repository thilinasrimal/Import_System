using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Import_System.Pages
{
    public partial class ActivePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;

                // Define your SQL query
                string query = "SELECT * FROM Import_Shedules where IsActive=1";

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
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Import_System.Data;

namespace Import_System.Pages
{
    public partial class DetailsPage : System.Web.UI.Page
    {
        private readonly DbConnect dbcon = new DbConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
               
            }
        }

        private void LoadGridView()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;

                // Define your SQL query
                string query = "SELECT ref_no, log_date, con_no, month, delivery_terms, payment_terms FROM Import_Shedules";

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
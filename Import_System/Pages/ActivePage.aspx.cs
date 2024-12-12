using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Import_System.Pages
{
    public partial class ActivePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;

                string query = "SELECT * FROM Import_Shedules im where im.IsActive=1 and im.IsDelete is NULL ORDER by im.con_no ASC";

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

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command1 = new SqlCommand("GetActiveShipmentsByItem", connection))
                    {
                        command1.CommandType = CommandType.StoredProcedure;
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command1))
                        {
                            DataTable dataTable1 = new DataTable();
                            adapter.Fill(dataTable1);

                            GrTotal.DataSource = dataTable1;
                            GrTotal.DataBind();
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
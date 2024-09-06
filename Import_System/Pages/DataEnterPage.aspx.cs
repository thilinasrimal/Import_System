using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Import_System.Pages
{
    public partial class DataEnterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            //this.btn.Visible = true;
            //this.btn2.Visible = false;
            Response.Redirect("DetailsPage.aspx");
            //Console.WriteLine("add btn");
        }
    }
}
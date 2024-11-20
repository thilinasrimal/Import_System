using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Import_System
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void ToggleButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataEnterPage.aspx");
            
            //Console.WriteLine("add btn");

        }

       
    }
}
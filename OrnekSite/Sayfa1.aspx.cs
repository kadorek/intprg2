using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekSite
{
    public partial class Sayfa1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "dügme";
            Button1.BackColor = System.Drawing.Color.Red;
        }
    }
}
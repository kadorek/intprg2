using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekSite
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            orta.Visible = lise.Visible = uni.Visible = false;
            
        }

        protected void ddlZaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = ddlZaman.SelectedValue;
            switch (secilen)
            {
                case "1":
                    orta.Visible = true;
                    lise.Visible = false;
                    uni.Visible = false;
                    break;
                case "2":
                    orta.Visible = false;
                    lise.Visible = true;
                    uni.Visible = false;
                    break;
                case "3":
                    orta.Visible = false;
                    lise.Visible = false;
                    uni.Visible = true;
                    break;
                default:
                    orta.Visible = lise.Visible = uni.Visible = false;
                    break;
            }
        }
    }
}
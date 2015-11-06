using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekSite.Admin
{
    public partial class YaziEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text.Trim();
            string metin = txtMetin.Text.Trim();
            Data.Yazi y = new Data.Yazi();
            y.Baslik = baslik;
            y.Metin = metin;
            y.AktifMi = true;
            y.EklemeTarihi = DateTime.Now;

            Data.VerilerDataContext db = new Data.VerilerDataContext();
            db.Yazis.InsertOnSubmit(y);
            db.SubmitChanges();

        }
    }
}
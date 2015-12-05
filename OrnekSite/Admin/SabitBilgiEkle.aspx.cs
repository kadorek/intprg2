using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrnekSite.Admin
{
    public partial class SabitBilgiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEkle_ServerClick(object sender,EventArgs e)
        {
            string kod = txtKod.Value;
            string isim = txtIsim.Value;
            string deger = txtDeger.Value;
            bool durum = chkAktifmi.Checked;
            Data.SabitBilgi sb = new Data.SabitBilgi(); //sabit bilgi türünden nesne oluşturduk referans tipli
            sb.Kod = kod; // oluşturulan nesnenin kod özelliğine atandı
            sb.Isim = isim; //  oluşturulan nesnenin isim özelliğine atandı
            sb.Deger = deger;//  oluşturulan nesnenin değer özelliğine atandı
            sb.AktifMi = durum;// oluşturulan nesnenin aktifmi özelliğine atandı

            Data.VerilerDataContext db= new Data.VerilerDataContext();
            db.SabitBilgis.InsertOnSubmit(sb);
            db.SubmitChanges();






        }
    }
}
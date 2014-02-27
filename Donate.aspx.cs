using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDonate_Click(object sender, EventArgs e)
    {
   
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            CommunityAssistEntities2 ca = new CommunityAssistEntities2();

            Donation d = new Donation();
            DateTime now = DateTime.Now;
            decimal amt = decimal.Parse(txtamt.Text);
            d.DonationAmount = amt;
            d.DonationDate = now;
            ca.Donations.Add(d);
            ca.SaveChanges();

            Response.Redirect("ThankYou.aspx");
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Grant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGrant_Click(object sender, EventArgs e)
    {
        try
        {
            CommunityAssistEntities2 ca = new CommunityAssistEntities2();

            ServiceGrant g = new ServiceGrant();
            DateTime now = DateTime.Now;
            decimal amt = decimal.Parse(txtgamt.Text);
            g.GrantAmount = amt;

            g.GrantDate = now;
            ca.ServiceGrants.Add(g);
            ca.SaveChanges();

            Response.Redirect("ThankYou.aspx");
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
}
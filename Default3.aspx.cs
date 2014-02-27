using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["personKey"] != null)
        {
            GetCustomerInfo();
        }
        else
        {
            Response.Redirect("Default2.aspx");
        }
    }

    private void GetCustomerInfo()
    {

        CommunityAssistEntities2 ca = new CommunityAssistEntities2();
        int pk = (int)Session["personkey"];
        var thisP = from p in ca.People
                    where p.PersonKey == pk
                    join g in ca.ServiceGrants on p.PersonKey equals g.PersonKey
                    select new { p.PersonLastName, p.PersonFirstName, p.PersonUsername,g.GrantAllocation };
        GridView1.DataSource = thisP.ToList();
        GridView1.DataBind();
    }
    protected void btnDonate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Donate.aspx");
       
    }

    protected void btnGrant_Click(object sender, EventArgs e)
    {
        Response.Redirect("Grant.aspx");
    }
}
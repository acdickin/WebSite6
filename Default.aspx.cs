using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
             
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            CommunityAssistEntities2 ca = new CommunityAssistEntities2();
             PassCodeGenerator pg = new PassCodeGenerator();
            int passcode = pg.GetPassCode();
            PasswordHash ph = new PasswordHash();
            Person p = new Person();
            p.PersonFirstName = txtfirst.Text;
            p.PersonLastName = txtlast.Text;
            p.PersonUsername = txtemail.Text;
            p.PersonPlainPassword= txtpassword.Text;
            p.Personpasskey = passcode;
            p.PersonUserPassword = ph.HashIt(txtconfirm.Text, passcode.ToString());

           
              ca.People.Add(p);
              ca.SaveChanges();
        
            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }

    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Session["username"]==null))
        {
            hlLogin.Visible = false;
            hlRegister.Visible = false;
            lbFav.Visible = true;
            lbSignOut.Visible = true;

        }
        else
        {
            hlLogin.Visible = true;
            hlRegister.Visible = true;
            lbFav.Visible = false;
            lbSignOut.Visible = false;

        }
    }

    protected void lbSignOut_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        hlLogin.Visible = true;
        hlRegister.Visible = true;
        lbFav.Visible = false;
        lbSignOut.Visible = false;
        Response.Redirect("login.aspx");
    }

    protected void lbFav_Click(object sender, EventArgs e)
    {
        Response.Redirect("wishlist.aspx");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online.Classified.App
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblManageCategory.Visible = lblMyAds.Visible = true;
                lblLogin.Text = "Logout";
                panInfo.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(lblLogin.Text == "Login")
            {
                Response.Redirect("Login.aspx");
                
            }
            else
            {
                Session["user"] = null;
                Response.Redirect("Default.aspx");
            }

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online.Classified.App
{
    public partial class Classified1 : System.Web.UI.Page
    {
        public Online.Classified.DataAccess.Classified classified;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetClassified();
                lblTitle.Text = Request.QueryString["name"].ToString();
            }
        }

        protected void GetClassified()
        {
            classified = new DataAccess.Classified();
            DataTable dt = classified.SelectByCategoryId(int.Parse(Request.QueryString["Id"].ToString()));
            lvClassified.DataSource = dt;
            lvClassified.DataBind();
        }
    }
}
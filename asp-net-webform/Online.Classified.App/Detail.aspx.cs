using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online.Classified.App
{
    public partial class Detail : System.Web.UI.Page
    {
        public Online.Classified.DataAccess.Classified classified;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetClassifiedDetail();
            }
        }
        protected void GetClassifiedDetail()
        {
            classified = new DataAccess.Classified();
            DataTable dt = classified.SelectById(int.Parse(Request.QueryString["Id"].ToString()));
            lvClassified.DataSource = dt;
            lvClassified.DataBind();
        }
    }
}
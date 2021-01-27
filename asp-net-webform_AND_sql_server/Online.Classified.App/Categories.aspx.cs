using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online.Classified.App
{
    public partial class Classified : System.Web.UI.Page
    {
        public Online.Classified.DataAccess.Category category;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCategories();
            }
        }
        protected void GetCategories()
        {
            category = new DataAccess.Category();
            DataTable dt = category.SelectAll();
            lvCategories.DataSource = dt;
            lvCategories.DataBind();
        }
    }
}
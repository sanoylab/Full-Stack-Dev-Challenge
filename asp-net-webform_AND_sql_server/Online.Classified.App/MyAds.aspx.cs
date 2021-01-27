using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online.Classified.App
{
    public partial class MyAds : System.Web.UI.Page
    {
        public Online.Classified.DataAccess.Classified classified;
        public Online.Classified.DataAccess.Category category;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetClassified();
                PopulateCategory();
            }
        }
        protected void PopulateCategory()
        {
            category = new DataAccess.Category();
            DataTable dt = category.SelectAll();
            ddlCategory.DataSource= dt;
            ddlCategory.DataTextField = "Name";
            ddlCategory.DataValueField = "Id";
            ddlCategory.DataBind();
        }
        protected void GetClassified()
        {
            classified = new DataAccess.Classified();
            DataTable dt = classified.SelectAll();
            gvAds.DataSource = dt;
            gvAds.DataBind();
        }
        protected void gvAds_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAds.DataSource = classified.SelectAll();
            gvAds.PageIndex = e.NewPageIndex;
            gvAds.DataBind();
        }
    }
}
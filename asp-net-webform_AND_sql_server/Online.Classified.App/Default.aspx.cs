using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Online.Classified.DataAccess;

namespace Online.Classified.App
{
    public partial class _Default : System.Web.UI.Page
    {
        public Online.Classified.DataAccess.Classified classified;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetRecentClassified(1, lvRecentHome);//Recent Home
                GetRecentClassified(2, lvComputer);//Recent Computer
                GetRecentClassified(3, lvFurniture);//Recent Furniture
                GetRecommended();
            }  
        }
        protected void GetRecentClassified(int Id, ListView listView)
        {
            classified = new DataAccess.Classified();
            DataTable dt = classified.SelectByCategoryId(Id);
            listView.DataSource = dt;
            listView.DataBind();
        }
        protected void GetRecommended()
        {
            classified = new DataAccess.Classified();
            DataTable dt = classified.SelectRecommended();
            lvRecommended.DataSource = dt;
            lvRecommended.DataBind();
        }
    }
}
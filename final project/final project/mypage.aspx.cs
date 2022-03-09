using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace final_project
{
    public partial class mypage : System.Web.UI.Page
    {
        public string[] user = new string[7];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserData"]!=null)
            {
                user = (string[])Session["UserData"];
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
            
        }
        public void UpdateInfo()
        {
            Response.Write("Triggered");
        }
    }
}
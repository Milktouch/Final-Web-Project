using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class Scheduele : System.Web.UI.Page
    {
        public dynamic[,] meetings;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] == null)
            {
                Response.Redirect("Homepage.aspx");
                return;
            }
            if (Request.Form["delete"] != null)
            {
                Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), $"Delete From SchedueleForUser{(int)Session["Id"]} Where Id={Request.Form["Id"]}");
            }
            meetings = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "SchedueleForUser" + (int)Session["Id"], "*", "");

        }
    }
}
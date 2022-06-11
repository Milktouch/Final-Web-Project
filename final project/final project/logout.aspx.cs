using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] == null && (bool)Session["Admin"]==false)
            {
                Response.Redirect("Homepage.aspx");
                return;
            }
            if (Session["Id"] != null)
            {
                var users = (ArrayList)Application["Users"];
                users.RemoveAt(users.IndexOf((int)Session["Id"]));
                Application.Lock();
                Application["Users"] = users;
                Application.UnLock();
            }
            Session.Abandon();
            Response.Redirect("Homepage.aspx");
        }
    }
}
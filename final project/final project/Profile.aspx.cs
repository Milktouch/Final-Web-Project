using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class Profile : System.Web.UI.Page
    {
        public string name = "";
        public string mail = "";
        public dynamic[,] scheduele;
        public bool islooged = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (Session["Id"] != null)
            {
                if (id == Session["Id"].ToString())
                {
                    Response.Redirect("mypage.aspx");
                    return;
                }
                islooged = true;
            }

            if (id == null || id == "")
            {
                Response.Redirect("Homepage.aspx");
                return;
            }
            if (Request.Form["scheduele"] != null)
            {
                string fulldate = Request.Form["date"];
                string[] date = fulldate.Split('-');
                string name = Request.Form["name"];
                string comment = Request.Form["comment"];
                string time = Request.Form["time"];
                Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), $"Insert into SchedueleForUser{(int)Session["Id"]} (LessonName,Year,Month,Day,Hour,Comments) Values('{name}',{date[2]},{date[1]},{date[0]},'{time}','{comment}')");
                Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), $"Insert into SchedueleForUser{id} (LessonName,Year,Month,Day,Hour,Comments) Values('{name}',{date[2]},{date[1]},{date[0]},'{time}','{comment}')");
            }
            
           
            dynamic[,] data = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "Users", "FirstName,Lastname,Email", $"Id={id}");
            name = data[0, 0] +" "+ data[0, 1];
            mail = data[0, 2];
            scheduele = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), $"SchedueleForUser{id}", "Year,Month,Day,Hour", "");
        }
    }
}
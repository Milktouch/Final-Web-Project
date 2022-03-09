using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace final_project
{

    public partial class Site1 : System.Web.UI.MasterPage
    {
        
        public string[] user=new string[7];

        protected void Page_Load(object sender, EventArgs e)
        {
            
            //calling a js function (must be in head and not a seperate file)
            //Page.ClientScript.RegisterStartupScript(this.GetType(),"CallMyFunction","MyFunction()",true);
            if (Session["UserData"]!=null)
            {
                user = (string[])Session["UserData"];
            }
            if (Request.Form["submit"] != null)
            {

                string email = Request.Form["mail"];
                string password = Request.Form["password"];
                string condition = "Email='" + email + "'";
                string whatdata = "password,Id";
                string table = "LoginTable";
                dynamic[,] data = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), table, whatdata, condition);
                if (data[0,0].Equals(password))
                {
                    whatdata = "*";
                    table = $"User{data[0, 1]}";
                    data = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), table, whatdata, condition);
                    for (int i = 0; i < user.Length; i++)
                    {
                        user[i] = data[0, i];
                    }
                    Session["UserData"] = user;
                }

            }
            
        }
        public void SignOut()
        {
            Response.Write("Triggered");
            Session["UserData"] = null;
            user = null;
            Response.Redirect("Homepage.aspx");
        }
    }
}
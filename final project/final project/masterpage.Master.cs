using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Collections;

namespace final_project
{

    public partial class Site1 : System.Web.UI.MasterPage
    {
        public dynamic[,] Users = { { "" } };
        public dynamic[] user=new dynamic[8];
        public string err = "";
        public string mailerr = "";
        public bool Admin = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            err = "";
            Users = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "Users", "FirstName", "");
            if (Session["Admin"] == null)
            {
                Session["Admin"] = false;
            }
            
            Admin = (bool)Session["Admin"];
            
            if (Application["Users"] == null)
            {
                Application["Users"] = new ArrayList();
            }
            if (Session["UserData"]!=null)
            {
                user = (dynamic[])Session["UserData"];
                return;
            }
            if (Request.Form["submit"] != null)
            {

                string email = Request.Form["mail"];
                string password = Request.Form["password"];
                if (email == "admin"&&password=="admin")
                {
                    Session["Admin"] = true;
                    Admin = true;
                    return;
                }
                string condition = "Email='" + email + "'";
                string whatdata = "*";
                string table = "Users";
                dynamic[,] data = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), table, whatdata, condition);

                if (data.GetLength(0)>0)
                {

                    if (data[0, 7].Equals(password))
                    {
                        for (int i = 1; i < user.Length; i++)
                        {
                            user[i] = data[0, i];
                        }
                        Session["UserData"] = user;
                        Session["Id"] = data[0, 0];
                        var users = (ArrayList)Application["Users"];
                        users.Add((int)Session["Id"]);
                        Application["Users"] = users;
                    }
                    else
                    {
                        err = "Password does not match";
                    }

                }
                else
                {
                    err = "a user with that Email does not exist";
                }
            }
            
        }
        
    }
}
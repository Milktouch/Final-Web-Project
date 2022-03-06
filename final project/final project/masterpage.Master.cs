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
        
        public string user;

        protected void Page_Load(object sender, EventArgs e)
        {
            //calling a js function (must be in head and not a seperate file)
            //Page.ClientScript.RegisterStartupScript(this.GetType(),"CallMyFunction","MyFunction()",true);
            
            if (Request.Form["submit"] != null)
            {

                string email = Request.Form["mail"];
                string password = Request.Form["password"];
                string role = Request.Form["role"];
                string condition = "mail='" + email + "'";
                string whatdata = "password,firstname";
                string connstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\BAYAH\ONEDRIVE\DOCUMENTS\DATABASES\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                string table = "UserTable";
                string[,] data = Workingwithsql.MicrosoftSqldata.Getdata(connstr, table, whatdata, condition);
                if (data[0,0].Equals(password))
                {
                    user = data[0, 1];
                }
                
            }
            

        }
    }
}
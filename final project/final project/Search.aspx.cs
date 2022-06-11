using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class Search : System.Web.UI.Page
    {
        public dynamic[,] users;
        protected void Page_Load(object sender, EventArgs e)
        {
            users = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "Users", "Id,FirstName,LastName,Email", "");

        }
    }
}
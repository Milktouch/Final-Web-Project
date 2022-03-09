using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserData"] != null)
            {
                Response.Redirect("Homepage.aspx");
            }
            if (Request.Form["register"] != null)
            {
                string firstname = Request.Form["firstname"];
                string lastname = Request.Form["lastname"];
                string Email = Request.Form["mail"];
                int age = int.Parse(Request.Form["age"]);
                int phonenumber = int.Parse(Request.Form["phoneheader"]+Request.Form["phone"]);
                string city = Request.Form["city"];
                string password = Request.Form["password"];
                Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(),$"INSERT INTO LoginTable (Email,Password) VALUES('{Email}','{password}');");
                dynamic[,] id = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "LoginTable", "Id", $"Email='{Email}' AND Password='{password}'");
                Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), $"CREATE TABLE [dbo].[User{id[0, 0]}]( [Firstname] NVARCHAR(MAX), [Lastname] NVARCHAR(MAX), [Email] NVARCHAR(MAX), [Age] INT, [Phonenumber] INT, [City] NVARCHAR(MAX), [Password] NVARCHAR(MAX))");
                Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), $"INSERT INTO User{id[0, 0]} VALUES('{firstname}','{lastname}','{Email}',{age},{phonenumber},'{city}','{password}')");

            }
        }
    }
}
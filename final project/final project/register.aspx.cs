using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class register : System.Web.UI.Page
    {
        public string error="";
        public string firstname ="";
        public string lastname = "";
        public string Email = "";
        public string age;
        public string phonenumber = "000";
        public string city = "";
        public string password = "";

        protected void Page_Load(object sender, EventArgs e)
        {
             
            error = "";
            if (Session["UserData"] != null)
            {
                Response.Redirect("Homepage.aspx");
            }
            if (Request.Form["register"] != null)
            {
                
                try
                {
                    firstname = Request.Form["firstname"];
                     lastname = Request.Form["lastname"];
                     Email = Request.Form["mail"];
                     age = Request.Form["age"];
                     phonenumber = Request.Form["phoneheader"] + Request.Form["phone"];
                     city = Request.Form["city"];
                     password = Request.Form["password"];
                    bool isexist = Workingwithsql.MicrosoftSqldata.IsExist(connstr.Get(), $"SELECT Id FROM Users WHERE Email='{Email}'");
                    if (isexist)
                    {
                        error = "A user with that Email already exists";
                        return;
                    }
                    else
                    {
                        Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), $"INSERT INTO Users (Email,PassWord,FirstName,LastName,Age,PhoneNumber,City) VALUES('{Email}','{password}','{firstname}','{lastname}',{int.Parse(age)},'{phonenumber}','{city}');");
                        dynamic dbuser = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "Users", "Id", $"Email='{Email}'")[0, 0];
                        Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), $"CREATE TABLE [dbo].[SchedueleForUser{dbuser[0,0]}]([Id] INT IDENTITY (1, 1) NOT NULL,[LessonName] VARCHAR(MAX), [Year] INT, [Month] INT, [Day] INT,[Hour] VARCHAR(10) , [Comments] VARCHAR(MAX), PRIMARY KEY CLUSTERED ([Id] ASC) )");
                        dynamic[] user = new dynamic[dbuser.GetLength(1)];
                        for (int i = 1; i < dbuser.GetLength(1); i++)
                        {
                            user[i] = dbuser[0, i];
                        }
                        Session["UserData"] = user;
                        Session["Id"] = dbuser[0, 0];
                        var users = (ArrayList)Application["Users"];
                        users.Add((int)Session["Id"]);
                        Application["Users"] = users;
                        Response.Redirect("Homepage.aspx");
                    }
                }
                catch(Exception ex)
                {
                    error = "error setting up account";
                }
            }
        }
    }
}
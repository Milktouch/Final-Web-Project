using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Threading;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Net;
using System.Net.Sockets;

namespace final_project
{
    public class AdminSock : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(),e.Data);

        }
    }
    public partial class Admin : System.Web.UI.Page
    {
        //gets a free port to be used in the web socket
        static int FreeTcpPort()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }
        public string Users;
        public int len;
        public string p;
        Thread ws;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["Admin"]==null)
            {
                Response.Redirect("Homepage.aspx");
                return;
            }
            else if (!(bool)Session["Admin"])
             {
                Response.Redirect("Homepage.aspx");
                return;
             }
           
            dynamic[,] usersarr = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "Users", "*", "");
            Users = new JavaScriptSerializer().Serialize(usersarr);
            len = usersarr.GetLength(0);
            p = FreeTcpPort().ToString();
            ws = new Thread(() =>{
                WebSocketServer wssv = new WebSocketServer("ws://localhost:"+p);
                wssv.AddWebSocketService<AdminSock>("/admin");
                wssv.Start();
            });
            ws.Start();
        }
        
    }
}
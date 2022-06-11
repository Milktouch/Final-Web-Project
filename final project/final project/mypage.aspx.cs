using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace final_project
{
    
    public partial class mypage : System.Web.UI.Page
    {
        
        public class MypageSock : WebSocketBehavior
        {
            protected override void OnMessage(MessageEventArgs e)
            {
                Workingwithsql.MicrosoftSqldata.Queryexe(connstr.Get(), e.Data);
                
            }
        }
        static int FreeTcpPort()
        {

            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }
        public int id;
        public int port;
        public dynamic[] user = new dynamic[8];
        Thread ws;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["UserData"]!=null)
            {
                dynamic[,] data = Workingwithsql.MicrosoftSqldata.Getdata(connstr.Get(), "Users", "*", $"Id = {(int)Session["Id"]}");
                for (int i = 1; i < user.Length; i++)
                {
                    user[i] = data[0, i];
                }
                Session["UserData"] = user;
                id = (int)Session["Id"];
                port = FreeTcpPort();
                ws = new Thread(() => {
                    WebSocketServer wssv = new WebSocketServer("ws://localhost:" + port);
                    wssv.AddWebSocketService<MypageSock>("/Mypage");
                    wssv.Start();
                });
                ws.Start();
                
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
            
        }
        
    }
}
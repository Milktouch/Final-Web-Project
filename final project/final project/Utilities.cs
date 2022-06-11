using System;
using System.IO;
using System.Web;
using System.Collections.Generic;
using System.Collections.Specialized;

public static class utilities
{
    public static string GetCon()
    {
        string ConnStr="";
        ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=";
        ConnStr += ("App_Data");
        ConnStr += @"\Database.mdf";
        ConnStr += "; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\final project\final project\App_Data\Database.mdf;Integrated Security=True";
        return ConnStr;
    }
    public static bool IsAjax(this HttpRequest request)
    {
        if (request == null)
        {
            throw new ArgumentNullException("request");
        }
        var context = HttpContext.Current;
        var isCallbackRequest = false;
        if (context != null && context.CurrentHandler != null && context.CurrentHandler is System.Web.UI.Page)
        {
            isCallbackRequest = ((System.Web.UI.Page)context.CurrentHandler).IsCallback;
        }
        return isCallbackRequest || (request["X-Requested-With"] == "XMLHttpRequest") || (request.Headers["X-Requested-With"] == "XMLHttpRequest");
    }
}
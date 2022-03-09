using System;
using System.IO;

public static class connstr
{
    public static string Get()
    {
        string ConnStr="";
        ConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=";
        ConnStr += ("App_Data");
        ConnStr += @"\Database.mdf";
        ConnStr += "; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\final project\final project\App_Data\Database.mdf;Integrated Security=True";
        return ConnStr;
    }
}
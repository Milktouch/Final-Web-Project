using System;
using System.IO;

public static class connstr
{
    
    public static string Get()
    {
        string ConnStr="";
        //string path = Path.GetFullPath(@"final project\final project\App_Data\IlayKDatabase.mdf");
        ConnStr = $@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\final project\final project\App_Data\Database.mdf; Integrated Security = True";
        return ConnStr;
    }
}
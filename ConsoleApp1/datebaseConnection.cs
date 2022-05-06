// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

class datebaseConnection
{
    private string datasource = "WAIANGDESK03";
    private string database = "SampleStore";
    bool r = false;
    //private string username;
    //private string password;
    public string message;
    public SqlConnection conn;

    public datebaseConnection()
    {
        //datasource = ConsoleMessage.ReadLine<string>("Enter server Name");
        //database = ConsoleMessage.ReadLine<string>("Enter Database Name");
        Connection();
        Console.WriteLine(message);
    }
    public void Connection()
    {
        Console.WriteLine("Getting Connection ...");
        string connString = $"Data Source={datasource};Initial Catalog={database};Integrated Security=True";
         conn = new SqlConnection(connString);
        try
        {
            //open connection
            conn.Open();
            
            message = "Connection successful!";
            r = true;

        }
        catch (Exception e)
        {
            r = false;
            message = "Error: " + e.Message;
        }

       
    }


}
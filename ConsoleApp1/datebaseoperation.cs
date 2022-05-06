// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;

class datebaseoperation
{
    public bool t = false;
    datebaseConnection dp = new datebaseConnection();

    public void displayAllRecord()
    {
        try
        {
            string s = new string('_', 80);
            Console.WriteLine(s);
            string sql1 = "SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('production.brands')";
            using (SqlCommand cmd = new SqlCommand(sql1, dp.conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Console.Write(reader.GetString(0) + "\t" + "|");
                }
                Console.WriteLine();
                Console.WriteLine(s);
                reader.Close();
            }
            string sql = "select * from production.brands";
            using (SqlCommand cmd = new SqlCommand(sql, dp.conn))
            {

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {

                    Console.WriteLine($"|{row.ItemArray[0].ToString(),5}|{row.ItemArray[1].ToString(),20}|");


                }
                Console.WriteLine(s);
                t = true;
                Console.ReadKey(t);
            }



        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }



    }
    public void insertRecord(string BrandName)
    {
        try
        {
            string s = new string('_', 80);
            Console.WriteLine(s);
            string sql1 = "INSERT INTO [production].[brands]([brand_name]) values (@name)";
            using (SqlCommand cmd = new SqlCommand(sql1, dp.conn))
            {
                cmd.Parameters.AddWithValue("@Name", BrandName);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("recorder Inserted .");
                Console.WriteLine(rows);
            }


        }

        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }



    }





    public void insertusingsp(string BrandName)
    {
        try
        {
            string s = new string('_', 80);
            Console.WriteLine(s);
            string sql1 = "proc_insert";
            using (SqlCommand cmd = new SqlCommand(sql1, dp.conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BrandName", BrandName);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("recorder Inserted .");
                Console.WriteLine(rows);
            }


            t = true;

            Console.ReadKey(t);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }



    }



}
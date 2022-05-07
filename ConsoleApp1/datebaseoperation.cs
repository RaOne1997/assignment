// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

class datebaseoperation
{
    public bool t = false;
    datebaseConnection dp = new datebaseConnection();
    int ROllNO;
    public bool Start()
    {
        return dp.r;

    }
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


  

    public void addstudent(string Name, string Address, string Email, string Cource_Code,char operation)
    {
        if (operation == 'I')
        {
           

            try
            {
                string s = new string('_', 80);
                Console.WriteLine(s);
                string sql1 = "proc_Add_Student";
                using (SqlCommand cmd = new SqlCommand(sql1, dp.conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Cource_Code", Cource_Code);
                    cmd.Parameters.AddWithValue("@flag", 1);
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
        else  if (operation == 'U')
        {
         
             try
            {
           
                string s = new string('_', 80);
                Console.WriteLine(s);
                string sql1 = "proc_Add_Student";
                using (SqlCommand cmd = new SqlCommand(sql1, dp.conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Cource_Code", Cource_Code);
                    cmd.Parameters.AddWithValue("@flag", 2);
                    cmd.Parameters.AddWithValue("@RollNumber", ROllNO);
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
        Console.ReadLine();
        Console.Clear();
    }



    public void EnterMArks(string Name, string Subject, decimal marks)
    {


            try
            {
                string s = new string('_', 80);
                Console.WriteLine(s);
                string sql1 = "PROC_AddUpdateMarks";
                using (SqlCommand cmd = new SqlCommand(sql1, dp.conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@studentName", Name);
                    cmd.Parameters.AddWithValue("@SubjectName", Subject);
                    cmd.Parameters.AddWithValue("@marks", marks);
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
        



   

    public void Display(string Name = "")
    {
        try
        {

            string s = new string('_', 83);
            Console.WriteLine("\n"+s);
            ConsoleMessage.ShowHeader("|Roll NO       |    Name            | Email                |Address               |");
            ConsoleMessage.ShowHeader(s);

            string sql1 = "Proc_Display";
            using (SqlCommand cmd = new SqlCommand(sql1, dp.conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    ROllNO = int.Parse(row.ItemArray[0].ToString());
                    ConsoleMessage.ShowColumn($"|{row.ItemArray[0].ToString(),12} |{row.ItemArray[1].ToString(),20}" +
                        $"| {row.ItemArray[2].ToString(),20}|{row.ItemArray[3].ToString(),-24}|");


                }

                ConsoleMessage.ShowColumn(s);
                t = true;
                Console.ReadKey(t);
            }   

            t = true;

            Console.ReadKey(t);
        }
        catch (Exception ex)
        {
            t = false;
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
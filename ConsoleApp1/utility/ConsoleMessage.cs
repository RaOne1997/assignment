public class ConsoleMessage
{


    public static void Showerror(string message)
    {
        ConsoleTextColor.SetError();
        Console.WriteLine(message);
        ConsoleTextColor.Reset();
    }



    public static void ShowColumn(string message)
    {
        ConsoleTextColor.SetColumnColor();
        Console.WriteLine(message);
        ConsoleTextColor.Reset();
    }

    public static void ShowWarning(string message)
    {
        ConsoleTextColor.SetWarning();
        Console.WriteLine(message);
        ConsoleTextColor.Reset();
    }
    public static void ShowText(string message)
    {
        Console.WriteLine(message);
    }

    public static void ShowMenu(string message)
    {
        ConsoleTextColor.SetMenuColor();
        Console.WriteLine(message);
        ConsoleTextColor.Reset();
    }


    public static void ShowHeader(string message)
    {
        ConsoleTextColor.SetHeaderColor();
        Console.WriteLine(message);
        ConsoleTextColor.Reset();
    }
    public static T ReadLine<T>(string label)
    {
        do
        {
            Console.Write($"{label}: ");
            var inputText = Console.ReadLine();

            try
            {
                var value = (T)Convert.ChangeType(inputText, typeof(T));
                return value;
            }
            catch (Exception ex)
            {
                Showerror($"\n{ex.Message}");
            }
        } while (true);
    }


}

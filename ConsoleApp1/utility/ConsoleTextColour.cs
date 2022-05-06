//Student student = new Student();
//student.AddstudentRecord();




public class ConsoleTextColor
{
    public static void SetError()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;

    }

    public static void SetWarning()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
    }
    public static void Reset()
    {
        Console.ResetColor();
    }
    public static void SetHighlight()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Cyan;
    }

    public static void SetHeaderColor()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Blue;

    }
    public static void SetMenuColor()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
      
    }

    public static void SetColumnColor()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;

    }
}
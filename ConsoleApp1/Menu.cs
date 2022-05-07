// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Module;

public class Menu
{
    MainMenuItem SelectedMenu;
    public void menus()
    {
        int choice = 0;
        bool value = false;
        datebaseoperation datebaseoperations = new datebaseoperation();
        if (datebaseoperations.Start())
        {

            do
            {
                ShowMenu();

                switch (Heady())
                {

                    case MainMenuItem.Student:
                        Console.Clear();
                        Student studentService = new Student();
                       value = true;    
                        break;
                    case MainMenuItem.Cource:
                        break;
                    case MainMenuItem.Subject:
                        break;
                    case MainMenuItem.Marks:
                        break;
                    case MainMenuItem.Exit:
                        break;
                    default:
                        break;
                        //case MenuItens.AddStudent:
                        //    Console.Clear();
                        //    datebaseoperations.addstudent('I');
                        //    value = true;
                        //    break;
                        //case MenuItens.Addcourse:
                        //    break;
                        //case MenuItens.Addsubject:
                        //    break;
                        //case MenuItens.Entermarksofstudent:

                        //    break;
                        //case MenuItens.EditStudentdata:
                        //    Console.Clear();
                        //    datebaseoperations.addstudent('U');
                        //    value = true;
                        //    break;
                        //case MenuItens.Editcourse:
                        //    break;
                        //case MenuItens.Editsubject:
                        //    break;
                        //case MenuItens.DisplayAllStudent:
                        //    Console.Clear();
                        //    datebaseoperations.Display();
                        //    value = true;
                        //    break;
                        //case MenuItens.Display_Student_With_Marks:
                        //    break;
                        //case MenuItens.exist:
                        //    break;
                }

            } while (value);
        }
        else
        {

            Console.WriteLine("Connection Problem ");

        }


    }
    public void ShowMenu()
    {
        ConsoleMessage.ShowMenu("1.Add Student\n5.Update Student\n8.Display all student");
    }

    MainMenuItem Heady()
    {
        Console.Write("Enter your choise: ");
        var keyInfo = Console.ReadKey(true);

        if (keyInfo.KeyChar is >= '0' and <= '9')
        {

            var asciiOfKeyChar = keyInfo.KeyChar - '0';
            SelectedMenu = (MainMenuItem)asciiOfKeyChar;
        }
        else
            ConsoleMessage.ShowWarning("Please select Proper Selection..............");
        SelectedMenu = keyInfo.Key switch
        {
            ConsoleKey.Escape => MainMenuItem.Exit,
            //ConsoleKey.X => MenuItens.ClearScreen,
            _ => SelectedMenu
        };

        return SelectedMenu;
    }



}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Module
{
    internal class Student : IStudentService
    {
        StudentMenuItens studentMenuItens;

        public Student()
        {
            Console.Clear();
            Start();
            

        }
        public bool Start()
        {

            ShowMenu();
            switch (Heady())
            {
                case StudentMenuItens.AddStudent:

                    var Name = ConsoleMessage.ReadLine<string>("Enter  Name");
                    var Address = ConsoleMessage.ReadLine<string>("Enter Address");
                    var Email = ConsoleMessage.ReadLine<string>("Enter Email");
                    var Cource_code = ConsoleMessage.ReadLine<string>("Enter Cource Code");
                    Stud student = new(Name, Address, Email, Cource_code);
                    Add(student);
                    return true;
                    break;
                case StudentMenuItens.Entermarksofstudent:
                    var Student_name = ConsoleMessage.ReadLine<string>("Enter Student ");
                    var Subject = ConsoleMessage.ReadLine<string>("Enter Email");
                    var Marks = ConsoleMessage.ReadLine<decimal>("Enter Name Number");
                    datebaseoperations.EnterMArks(Student_name, Subject, Marks);
                    return true;
                    break;
                case StudentMenuItens.EditStudentdata:
                    var RollNo = ConsoleMessage.ReadLine<string>("Enter Name Number");
                    datebaseoperations.Display(RollNo);
                    var Name2 = ConsoleMessage.ReadLine<string>("Enter Name ");
                    var Address2 = ConsoleMessage.ReadLine<string>("Enter Address ");
                    var Email2 = ConsoleMessage.ReadLine<string>("Enter Email");
                    var Cource_code2 = ConsoleMessage.ReadLine<string>("Enter Name Number");
                    Stud student1 = new(Name2, Address2, Email2, Cource_code2);
                    Edit(student1);
                    return true;
                    break;
                case StudentMenuItens.DisplayAllStudent:
                    datebaseoperations.Display();
                    return true;
                    break;
                case StudentMenuItens.Display_Student_With_Marks:


                    return true;
                    break;
                case StudentMenuItens.Exit:
                    return true;
                    break;
            }
            return false;

        }

        datebaseoperation datebaseoperations = new datebaseoperation();
        public void Add(Stud s)
        {

            datebaseoperations.addstudent(s.name, s.address, s.email, s.cource_Code, 'I');
        }

        public void Delete(int studentId)
        {

        }

        public void DisplayStudentReport()
        {

        }

        public void Edit(Stud s)
        {


            datebaseoperations.addstudent(s.name, s.address, s.email, s.cource_Code, 'U');
        }


        public void ShowMenu()
        {
            ConsoleMessage.ShowMenu("----------------Student Operation-----------------------");
            ConsoleMessage.ShowMenu("1.Add Student\n2.Enter marks of student\n3.Update Student data");
        }
        StudentMenuItens Heady()
        {
            Console.Write("Enter your choise: ");
            var keyInfo = Console.ReadKey(true);

            if (keyInfo.KeyChar is >= '0' and <= '9')
            {

                var asciiOfKeyChar = keyInfo.KeyChar - '0';
                studentMenuItens = (StudentMenuItens)asciiOfKeyChar;
            }
            else
                ConsoleMessage.ShowWarning("Please select Proper Selection..............");
            studentMenuItens = keyInfo.Key switch
            {
                ConsoleKey.Escape => StudentMenuItens.Exit,
                //ConsoleKey.X => MenuItens.ClearScreen,
                _ => studentMenuItens
            };

            return studentMenuItens;
        }
    }

}

// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;
var choice = 0;
bool value = false;
datebaseoperation datebaseoperations = new datebaseoperation();

do
{

    ConsoleMessage.ShowMenu("1.display record\n2.insert Record");
    choice = ConsoleMessage.ReadLine<int>("Enter Your choice");
    switch (choice)
    {



        case 1:
            Console.Clear();
            datebaseoperations.displayAllRecord();
            value = datebaseoperations.t;

            break;
        case 2:
            var brandName = ConsoleMessage.ReadLine<string>("Enter Brand Name");
            datebaseoperations.insertRecord(brandName);
            break;
        case 3:

            var brandNames = ConsoleMessage.ReadLine<string>("Enter Brand Name");
            datebaseoperations.insertusingsp(brandNames);
            break;
        case 9:
            value = false;
            break;


    }

} while (value);






using System;

namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            
            string Input;
           while(true)
            {
                Console.WriteLine("\n\nPress 1: Add Employee\n" +
                    "Press 2 : search Employee\n" +
                    "Press 3 : Update Employee\n" +
                    "Press 4 : Delete Employee\n" +
                    "Press 5 :  Display by Department Name\n" +
                    "Press 6 : Display by Designation Name\n" +
                    "Press 7 : DisplayEmployee \n" +
                    "Press 8 : Exit");
                int Num = int.Parse(Console.ReadLine());
                switch (Num)
                {
                    case 1:
                        client.AddEmployee();
                        break;
                    case 2:
                        client.SearchEmployee();
                        break;
                    case 3:
                        client.UpdateEmployee();
                        break;
                    case 4:
                        client.Deleteemployee();
                        break;
                    case 5:
                        client.Dept_Name();
                        break;
                    case 6:
                        client.Designation();
                        break;
                    case 7:
                        client.DisplayEmployee();
                        break;
                    case 8:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select Valid Entry");
                        break;


                }
               
            }


           
        }
    }
}


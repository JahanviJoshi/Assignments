using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal class Client
    {
        EmployeeOperation operation = new EmployeeOperation();
        List<EmployeeDetails> Employees = new List<EmployeeDetails>();
        EmployeeDetails emp = new EmployeeDetails();

        public void AddEmployee()
        {
            EmployeeDetails emp = operation.AcceptEmployeeData();
            Employees = operation.AddEmployee(emp);
            operation.PrintEmployees(ref Employees);
        }
        public void UpdateEmployee()
        {

            EmployeeDetails emp = new EmployeeDetails();
            Console.WriteLine("Enter Emp No which you want to update ");
            int empno = Convert.ToInt32(Console.ReadLine());
            
            Employees = operation.UpdateEmployee(emp, empno);

        }
        public void Deleteemployee()
        {

            Console.WriteLine("Enter the number ");
            int empNo = Convert.ToInt32(Console.ReadLine());
            Employees = operation.DeleteEmployee(emp, empNo);
            operation.PrintEmployees(ref Employees);
        }
        public void SearchEmployee()
        {
            Console.WriteLine("Enter the number ");
            int empNo = Convert.ToInt32(Console.ReadLine());
            Employees = operation.SearchEmployee(Employees, empNo);
            operation.PrintEmployees(ref Employees);
        }
        public void DisplayEmployee()
        {
            Console.Write("Display Employee");
            Employees = operation.DisplayEmployee(emp);
            operation.PrintEmployees(ref Employees);
        }
        public void Dept_Name()
        {
            Console.WriteLine("Enter the Department name");
            string deptName = Console.ReadLine();
            operation.Dept_Name(emp, deptName);
            operation.PrintEmployees(ref Employees);
        }
        public void Designation()
        {

            Console.WriteLine("Enter the Department name");
            string designation = Console.ReadLine();
            operation.DesigNation(emp, designation);
            operation.PrintEmployees(ref Employees);
        }

    }
}

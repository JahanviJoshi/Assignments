using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiniProject
{
    internal class EmployeeOperation
    {
        private List<EmployeeDetails> employees;
        public EmployeeOperation()
        {
            employees = new List<EmployeeDetails>();
        }

        public List<EmployeeDetails> UpdateEmployee(EmployeeDetails emp, int empno)
        {


            try
            {
                foreach (EmployeeDetails employee in employees)
                {
                    
                    

                    if (employee._Empno == empno)
                    {
                        Console.WriteLine("Enter EMpName you want to update");
                        employee._EmpName = Console.ReadLine();
                        Console.WriteLine("Enter DeptName you want to update");
                        employee.DeptName = Console.ReadLine();

                        Console.WriteLine("Enter Designation you want to update");
                        employee._Designation = Console.ReadLine();
                        Console.WriteLine("Enter Salary you want to update");
                        employee.Salary = int.Parse(Console.ReadLine());

                        return employees;
                    }
                }
                throw new Exception($"Employee with EmpNo={empno} doesnot exist");

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<EmployeeDetails> DeleteEmployee(EmployeeDetails emp, int empNo)
        {

            try
            {
                foreach (EmployeeDetails employee in employees)
                {
                    if (employee._Empno == empNo)
                    {
                        employees.Remove(employee);
                        return employees;
                    }
                }
                throw new Exception($"Employee with {empNo} doesnot exists");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employees;

        }
        public List<EmployeeDetails> AddEmployee(EmployeeDetails emp)
        {

            employees.Add(emp);


            
            return employees;


        }
        public List<EmployeeDetails> DisplayEmployee(EmployeeDetails emp)
        {

            return employees;
        }
        public List<EmployeeDetails> SearchEmployee(List<EmployeeDetails> emp, int empNo)
        {
            employees = emp;
            try
            {
                foreach (EmployeeDetails employee in employees)
                {
                    if (employee._Empno == empNo)
                    {
                        return employees;

                    }
                }
                throw new Exception($"The Employee No {empNo} is not valid");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employees;
        }
        public void Dept_Name(EmployeeDetails emp, string deptName)
        {

            try
            {
                foreach (EmployeeDetails employee in employees)
                {
                    if (employee.DeptName == deptName)
                    {
                        Console.WriteLine(employee._EmpName);

                    }
                    //throw new Exception($"Employee with deptName = {deptName} is not valid");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void DesigNation(EmployeeDetails emp, string designation)
        {

            try
            {
                foreach (EmployeeDetails employee in employees)
                {
                    if (employee._Designation == designation)
                    {
                        Console.WriteLine(employee._EmpName);
                    }
                }
                throw new Exception($"Employee with Designation={designation} is not valid");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public EmployeeDetails AcceptEmployeeData()
        {
            EmployeeDetails employee = new EmployeeDetails();
            //Validation for Employee Number
            Console.WriteLine("\nEnter Employee Number");
            try { employee._Empno = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            int d = 0;
            do
            {
                try
                {
                    if (employee._Empno >= 0)
                    {
                        d = 0;
                    }
                    else
                    {
                        Console.WriteLine("Please enter correct Employe No.");
                        employee._Empno = Convert.ToInt32(Console.ReadLine());
                        d++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (d > 0);
            Console.WriteLine("Enter Employee Name");
            employee._EmpName = Console.ReadLine();
            //Validation for Employee Name
            Regex re = new Regex("[A-Z][A-Za-z ]+[A-Za-z]$");
            int g = 0;
            do
            {
                if (re.IsMatch(employee._EmpName))
                {
                    g = 0;
                }
                else
                {
                    Console.WriteLine("Please enter correct name");
                    employee._EmpName = Console.ReadLine();
                    g++;
                }
            } while (g > 0);
            Console.WriteLine("Enter Department Name");
            employee.DeptName = Console.ReadLine();
            //Validation for Department
            int c = 0;
            do
            {
                if (employee.DeptName == "IT" || employee.DeptName == "HR" || employee.DeptName == "Admin" || employee.DeptName == "Sales" || employee.DeptName == "Account")//employee.Designation.Equals(designation)
                {
                    c = 0;
                }
                else
                {
                    Console.WriteLine("Please enter correct department");
                    employee.DeptName = Console.ReadLine();
                    c++;
                }
            } while (c > 0);
            Console.WriteLine("Enter Designation");
            employee._Designation = Console.ReadLine();
            //Validation for Designation
            int b = 0;
            do
            {
                if (employee._Designation == "Manager" || employee._Designation == "Engineer" || employee._Designation == "Clerk" || employee._Designation == "Staff" || employee._Designation == "Intern")//employee.Designation.Equals(designation)
                {
                    b = 0;
                }
                else
                {
                    Console.WriteLine("Please enter correct designation");
                    employee._Designation = Console.ReadLine();
                    b++;
                }
            } while (b > 0);
            //validation for Salary
            Console.WriteLine("Enter Salary");
            try { employee.Salary = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            int a = 0;
            do
            {
                try
                {
                    if (employee.Salary <= 0)
                    {
                        Console.WriteLine("Please enter correct salary amount");
                        employee.Salary = Convert.ToInt32(Console.ReadLine());
                        a++;
                    }
                    else
                    {
                        a = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (a > 0);
            return employee;


        }

        public void PrintEmployees(ref List<EmployeeDetails> emp)
        {

            Console.WriteLine("EmpNo \t\t EmpName \t DeptName \t Designation \t Salary");
            foreach (EmployeeDetails employee in emp)
            {
                Console.WriteLine($"{employee._Empno} \t\t {employee._EmpName} \t\t\t {employee.DeptName} \t {employee._Designation} \t {employee.Salary}");
            }

        }


    }
}



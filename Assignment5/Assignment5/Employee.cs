using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public int Salary { get; set; }

        public string Designation { get; set; }

    }

    public class EmployeeCollection : List<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "Adamas", DeptName = "IT", Salary = 10000, Designation = "Director" });
            Add(new Employee() { EmpNo = 2, EmpName = "Baker", DeptName = "CSE", Salary = 20000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 3, EmpName = "Banks", DeptName = "HRD", Salary = 30000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 4, EmpName = "Carter", DeptName = "Sales", Salary = 40000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 5, EmpName = "Cole", DeptName = "Admin", Salary = 50000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 6, EmpName = "Diaz", DeptName = "Account", Salary = 60000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 7, EmpName = "Edwards", DeptName = "IT", Salary = 10000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 8, EmpName = "Fernandez", DeptName = "CSE", Salary = 25000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 9, EmpName = "Jorden", DeptName = "HRD", Salary = 30000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 10, EmpName = "Lee", DeptName = "Sales", Salary = 40000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 11, EmpName = "Martinez", DeptName = "Admin", Salary = 50000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 12, EmpName = "Palmer", DeptName = "Account", Salary = 60000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 13, EmpName = "Micheal", DeptName = "IT", Salary = 10000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 14, EmpName = "Curtis", DeptName = "CSE", Salary = 20000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 15, EmpName = "Thomas", DeptName = "HRD", Salary = 30000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 16, EmpName = "Dorothy", DeptName = "Sales", Salary = 40000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 17, EmpName = "Traci", DeptName = "Admin", Salary = 70000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 18, EmpName = "Mary", DeptName = "Account", Salary = 60000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 19, EmpName = "Esther", DeptName = "IT", Salary = 75000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 20, EmpName = "Linda", DeptName = "CSE", Salary = 25000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 21, EmpName = "Bernice", DeptName = "HRD", Salary = 70000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 22, EmpName = "Sarah", DeptName = "Sales", Salary = 40000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 23, EmpName = "Kevin", DeptName = "Admin", Salary = 50000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 24, EmpName = "Chad", DeptName = "Account", Salary = 60000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 25, EmpName = "Shashta", DeptName = "IT", Salary = 105, Designation = "Staff" });
            Add(new Employee() { EmpNo = 26, EmpName = "Brian", DeptName = "CSE", Salary = 2020, Designation = "Manager" });
            Add(new Employee() { EmpNo = 27, EmpName = "Jose", DeptName = "HRD", Salary = 3000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 28, EmpName = "Ayako", DeptName = "Sales", Salary = 4040, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 29, EmpName = "John", DeptName = "Admin", Salary = 5050, Designation = "Staff" });
            Add(new Employee() { EmpNo = 30, EmpName = "Beverly", DeptName = "Account", Salary = 4673, Designation = "Manager" });
            Add(new Employee() { EmpNo = 31, EmpName = "George", DeptName = "IT", Salary = 10000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 32, EmpName = "Edmond", DeptName = "CSE", Salary = 20000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 33, EmpName = "Aria", DeptName = "HRD", Salary = 30000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 34, EmpName = "Aubrey", DeptName = "Sales", Salary = 40000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 35, EmpName = "Aiden", DeptName = "Admin", Salary = 50000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 36, EmpName = "Elijah", DeptName = "Account", Salary = 60000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 37, EmpName = "Harper", DeptName = "IT", Salary = 10000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 38, EmpName = "Grayson", DeptName = "CSE", Salary = 20000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 39, EmpName = "Caden", DeptName = "HRD", Salary = 30000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 40, EmpName = "Amelia", DeptName = "Sales", Salary = 40000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 41, EmpName = "Ava", DeptName = "Admin", Salary = 50000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 42, EmpName = "Emma", DeptName = "Account", Salary = 60000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 43, EmpName = "charlotte", DeptName = "IT", Salary = 10000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 44, EmpName = "Sally", DeptName = "CSE", Salary = 20000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 45, EmpName = "Melanie", DeptName = "HRD", Salary = 30000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 46, EmpName = "Bob", DeptName = "Sales", Salary = 40000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 47, EmpName = "Karen", DeptName = "Admin", Salary = 50000, Designation = "Engineer" });
            Add(new Employee() { EmpNo = 48, EmpName = "Harry", DeptName = "Account", Salary = 60000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 49, EmpName = "Smith", DeptName = "IT", Salary = 10000, Designation = "Staff" });
            Add(new Employee() { EmpNo = 50, EmpName = "James", DeptName = "CSE", Salary = 20000, Designation = "Director" });


        }
    }
}

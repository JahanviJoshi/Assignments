using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Department
    {
        public int DeptNo { get; set; }

        public string DeptName { get; set; }
        public int Salary { get; set; }


        public string Location { get; set; }

    }

    public class DepartCollection : List<Department>
    {
        public DepartCollection()
        {
            Add(new Department() { DeptNo = 1, DeptName = "IT", Salary = 10000, Location = "USA" });
            Add(new Department() { DeptNo = 2, DeptName = "CSE", Salary = 20000, Location = "Califonia" });
            Add(new Department() { DeptNo = 3, DeptName = "HRD", Salary = 30000, Location = "Shadowmount" });
            Add(new Department() { DeptNo = 4, DeptName = "Sales", Salary = 40000, Location = "Janmount" });
            Add(new Department() { DeptNo = 5, DeptName = "Admin", Salary = 50000, Location = "Fallcliff" });
            Add(new Department() { DeptNo = 6, DeptName = "Account", Salary = 60000, Location = "Redmont" });
            Add(new Department() { DeptNo = 7, DeptName = "IT", Salary = 10000, Location = "Whiteash" });
            Add(new Department() { DeptNo = 8, DeptName = "CSE", Salary = 25000, Location = "Merrowacre" });
            Add(new Department() { DeptNo = 9, DeptName = "HRD", Salary = 30000, Location = "Eastholt" });
            Add(new Department() { DeptNo = 10, DeptName = "Sales", Salary = 40000, Location = "Crystalvale" });
        }
    }
}

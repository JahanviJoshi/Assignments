using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal class EmployeeDetails
    {
        private int Empno;
        public int _Empno
        {
            get { return Empno; } 
            set { Empno = value; } 



        }
        private string Empname;
        public string _EmpName
        {
            get { return Empname; } 
            set { Empname = value; } 
        }
        private string Deptname;
        public string DeptName
        {
            get { return Deptname; }
            set { Deptname = value; }
        }
        private string Designation;
        public string _Designation
        {
            get { return Designation; }
            set { Designation = value; }
        }
        private int _Salary;
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }



    }
}


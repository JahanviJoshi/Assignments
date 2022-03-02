using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisConnect
{
    internal class EmployeeDataAccess : IDataAccess<Employee>
    {
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=SSPI");

        public void Add()
        {
            SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
            DataSet Ds = new DataSet();
            AdEmp.Fill(Ds, "Employee");
            DataRow Dr = Ds.Tables["Employee"].NewRow();
            Console.WriteLine("Enter the Empno");
            Dr["Empno"] = Console.ReadLine();
            Console.WriteLine("Enter the Empname");
            Dr["Empname"] = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            Dr["Salary"] = Console.ReadLine();
            Console.WriteLine("Enter the Designtion");
            Dr["Designation"] = Console.ReadLine();
            Console.WriteLine("Enter the Deptno");
            Dr["Deptno"] = Console.ReadLine();

            Console.WriteLine("Enter the Email");
            Dr["Email"] = Console.ReadLine();


            // 3. Add the Dr in Rows Collection of Employee Table in DataSet
            // Commented to Prevent Exception
            Ds.Tables["Employee"].Rows.Add(Dr);
            SqlCommandBuilder bldr = new SqlCommandBuilder(AdEmp);
            var result = AdEmp.Update(Ds, "Employee");
            if (result == null)
            {
                Console.WriteLine("Add Faild");
            }
            else
            {
                Console.WriteLine("Add Success");
            }
        }

        public void DeleteRecord()
        {
            SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
            DataSet Ds = new DataSet();
            AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdEmp.Fill(Ds, "Employee");

            Console.WriteLine("Enter the id no you need to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            //1. Search Record BAsed on Primary Key
            DataRow DrFind = Ds.Tables["Employee"].Rows.Find(id);
            // 2. Call Delete() method on the searched record
            DrFind.Delete();
            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdEmp);
            var result = AdEmp.Update(Ds, "Employee");
            if (result == null)
            {
                Console.WriteLine("Delete Failed");
            }
            else
            {
                Console.WriteLine("Delete Success");
            }

        }

        public void Read()
        {
            {
                SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
                DataSet Ds = new DataSet();
                //AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                AdEmp.Fill(Ds, "Employee");
                DataRowCollection dataRows = Ds.Tables["Employee"].Rows;
                foreach (DataRow row in dataRows)
                {
                    Console.WriteLine($"{row["Empno"]}     {row["Empname"]}       {row["Salary"]}   {row["Designation"]}    {row["Deptno"]} {row["Email"]}");
                }
            }
        }

        public void Update()
        {
            // 1. Create a Connection
            //SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI");
            // 2. Create Data Adapter with The Select Command (Plain Select Statement) and 
            // the Connection Object
            // This will internally call Conn.Open() to open the connection
            SqlDataAdapter AdEmp = new SqlDataAdapter("Select * from Employee", Conn);
            // 3. Create a DataSet Instance
            DataSet Ds = new DataSet();
            AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdEmp.Fill(Ds, "Employee");
            //4. Search Record BAsed on Primary Key
            Console.WriteLine("Enter the id no for updating");
            int id = Convert.ToInt32(Console.ReadLine());
            DataRow DrFind = Ds.Tables["Employee"].Rows.Find(id);
            // 5. Update its Values
           
            Console.WriteLine("enter Empname");
            DrFind["Empname"] = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            DrFind["Salary"] = Console.ReadLine();
            Console.WriteLine("Enter the Designtion");
            DrFind["Designation"] = Console.ReadLine();
            Console.WriteLine("Enter the Deptno");
            DrFind["Deptno"] = Console.ReadLine();

            Console.WriteLine("Enter the Email");
            DrFind["Email"] = Console.ReadLine();
            // 6. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdEmp);
            var result = AdEmp.Update(Ds, "Employee");
            if (result == null)
            {
                Console.WriteLine("Update Faild");
            }
            else
            {
                Console.WriteLine("Update Success");
            }
        }
    }
}

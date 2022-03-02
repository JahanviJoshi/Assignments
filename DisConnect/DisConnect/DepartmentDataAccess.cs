using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; //SQL Server Provider for Data Access for .NET Apps in ADO.NET
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisConnect
{
    internal class DepartmentDataAccess : IDataAccess<Department>
    {
        SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=SSPI");

        

        public void DeleteRecord()
        {
            // 2. Create Data Adapter with The Select Command (Plain Select Statement) and 
            // the Connection Object
            // This will internally call Conn.Open() to open the connection
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            // 3. Create a DataSet Instance
            DataSet Ds = new DataSet();
            // 3.a. Lets Convert UnTyped DataSet Into the Typed DataSet
            // This will be required to search records based on Primary key
            // using the Find() method of the DaraRowCollection
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdDept.Fill(Ds, "Department");
            
            Console.WriteLine("Enter the id no you need to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            //1. Search Record BAsed on Primary Key
            DataRow DrFind = Ds.Tables["Department"].Rows.Find(id);
            // 2. Call Delete() method on the searched record
            DrFind.Delete();
            // 3. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
            var result =AdDept.Update(Ds, "Department");
            if (result == null)
            {
                Console.WriteLine("Delete Faild");
            }
            else
            {
                Console.WriteLine("Delete Success");
            }
        }


        public void Add()
        {
            // 2. Create Data Adapter with The Select Command (Plain Select Statement) and 
            // the Connection Object
            // This will internally call Conn.Open() to open the connection
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            // 3. Create a DataSet Instance
            DataSet Ds = new DataSet(); //The Miniatuare of Database created in the Client's Memory
            AdDept.Fill(Ds, "Department"); //method to fill received data from DB to DataSet (Table name should be match with sql database)
            DataRow Dr = Ds.Tables["Department"].NewRow(); //Collection of data received from DB Table or created by the Client application
            Console.WriteLine("Enter the Deptno");
            Dr["DeptNo"] = Console.ReadLine();
            Console.WriteLine("Enter the DeptName");
            Dr["DeptName"] = Console.ReadLine();
            Console.WriteLine("Enter the Location");
            Dr["Location"] = Console.ReadLine();
            Console.WriteLine("Enter the Capacity");
            Dr["Capacity"] = Console.ReadLine();


            // 3. Add the Dr in Rows Collection of Department Table in DataSet
            // Commented to Prevent Exception
            Ds.Tables["Department"].Rows.Add(Dr);
            SqlCommandBuilder bldr = new SqlCommandBuilder(AdDept); //To send the Updated data back to Database use 'CommandBuilder' object
            var result = AdDept.Update(Ds, "Department");
            if (result == null)
            {
                Console.WriteLine("Add Faild");
            }
            else
            {
                Console.WriteLine("Add Success");
            }
        }

        public void Read()
        {
            {
                // 2. Create Data Adapter with The Select Command (Plain Select Statement) and 
                // the Connection Object
                // This will internally call Conn.Open() to open the connection
                SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
                // 3. Create a DataSet Instance
                DataSet Ds = new DataSet();
                //AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                AdDept.Fill(Ds, "Department");
                DataRowCollection dataRows = Ds.Tables["Department"].Rows;
                foreach (DataRow row in dataRows)
                {
                    Console.WriteLine($"{row["DeptNo"]}     {row["DeptName"]}       {row["Location"]}       {row["Capacity"]}");
                }
            }
        }

        public void Update()
        {
            
            // 2. Create Data Adapter with The Select Command (Plain Select Statement) and 
            // the Connection Object
            // This will internally call Conn.Open() to open the connection
            SqlDataAdapter AdDept = new SqlDataAdapter("Select * from Department", Conn);
            // 3. Create a DataSet Instance
            DataSet Ds = new DataSet();
            // 3.a. Lets Convert UnTyped DataSet Into the Typed DataSet
            // This will be required to search records based on Primary key
            // using the Find() method of the DaraRowCollection
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // Fill data in DataSet
            // The Name of the Table on Db Server is given to table created 
            // in dataset
            // This will be UnTyped DataSet By Default
            AdDept.Fill(Ds, "Department");
            //4. Search Record BAsed on Primary Key
            Console.WriteLine("Enter the id no for updating");
            int id = Convert.ToInt32(Console.ReadLine());
            DataRow DrFind = Ds.Tables["Department"].Rows.Find(id);
            // 5. Update its Values
            Console.WriteLine("Enter Deptno you need to update");
            Console.WriteLine("enter DeptName");
            DrFind["DeptName"] = Console.ReadLine();
            Console.WriteLine("enter Location");
            DrFind["Location"] = Console.ReadLine();
            Console.WriteLine("enter Capacity");
            DrFind["Capacity"] = Console.ReadLine();
            // 6. Command Build and Update
            SqlCommandBuilder bldr2 = new SqlCommandBuilder(AdDept);
            var result = AdDept.Update(Ds, "Department");
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

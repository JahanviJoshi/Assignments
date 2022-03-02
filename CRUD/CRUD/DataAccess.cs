using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;  //SQL Server Provider for Data Access for .NET Apps in ADO.NET
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class EmployeeDataAccess : IDataAccess<Employee, int>
    {
        SqlConnection Conn;
        SqlCommand Cmd;  //for accessing the sql database/any database for excuting the query
        /// <summary>
        /// Instantite the SqlConnection by passing ConnectionString to
        /// Constructor of the SqlConnection
        /// </summary>
        public EmployeeDataAccess()
        {

            Conn = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=SSPI");
            //SSPI:Used for Windows Authentication for SQL Server

        }

        Employee IDataAccess<Employee, int>.Create(Employee entity)
        {
            Employee employee = new Employee();
            try
            {
               
                Conn.Open();

                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = $"Insert into Employee Values({entity.Empno}, '{entity.Empname}', {entity.Salary},'{entity.Designation}',{entity.Deptno},'{entity.Email}')";
                //used to initializes a new instance of the System.Data.SqlClient.SqlCommand class with the text of the query




                //// Execute the Command Object
                int res = Cmd.ExecuteNonQuery(); //USed to Execute DML Statements (Insert, Update, Delete)
                if (res == 0) // Some Error Occured
                {
                    employee = null;
                }
                else
                {
                    // if successful store the entity into the Employee
                    employee = new Employee();
                     entity = employee;
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
                
            }

            finally // this will be executed irrespective of try or catch block
            {
                // if the Connection is still open then close it
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = new Employee();

            try
            {
               
                Conn.Open();
                // Create paramerized query
                Cmd.CommandText = "Delete From Employee where Empno=@Empno";

                SqlParameter pEmpno = new SqlParameter();
                pEmpno.ParameterName = "@Empno";
                pEmpno.SqlDbType = SqlDbType.Int;
                pEmpno.Direction = ParameterDirection.Input;
                pEmpno.Value = id;



                // Add parameters into the Parameters Collection of the Command object
                Cmd.Parameters.Add(pEmpno);

                // Call the execute method
                int res = Cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    employee = null;
                }
            }
            // for one try there can be multiple catch
            // make sure that the specific catch appears before 
            // the general catch (i.e. Exception class)
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employee;
        }

        public IEnumerable<Employee> GetData()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                // Open
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Select * from Employee";
                SqlDataReader Reader = Cmd.ExecuteReader(); //Execute a select query on DB. This return an instance of SqlDataReader


                // Iterate over the Reader for Department Rows
                while (Reader.Read())
                {
                    // Read each row using the Reader
                    // and add it into the departments list by storing
                    // each column value of the record into the Department object
                    employees.Add(
                          new Employee()
                          {
                              Empno = Convert.ToInt32(Reader["Empno"]),
                              Empname = Reader["Empname"].ToString(),
                              Designation = Reader["Designation"].ToString(),
                              Salary = Convert.ToInt32(Reader["Salary"]),
                              Deptno = Convert.ToInt32(Reader["Deptno"]),
                              Email = Reader["Email"].ToString()
                          }
                        );
                }
                Reader.Close();
                // Close
                Conn.Close();
            }
            catch (SqlException ex)
            {


                throw ex;
            }
            finally // this will be executed irrespective of try or catch block
            {
                // if the Connection is still open the close it
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employees;
        }

       
        public Employee Update(int id, Employee entity)
        {
            Employee employee = new Employee();
            try
            {


                // check if id and the empno value of the entity is same
                if (id == entity.Empno)
                {
                    Conn.Open();
                    // Create paramerized query
                    Cmd.CommandText = "Update Employee Set Empname=@Empname, Salary=@Salary, Designation=@Designation , Email = @Email, Deptno =@Deptno where Empno=@Empno";

                    SqlParameter pEmpno = new SqlParameter();
                    pEmpno.ParameterName = "@Empno";
                    pEmpno.SqlDbType = SqlDbType.Int;
                    pEmpno.Direction = ParameterDirection.Input;
                    pEmpno.Value = id;


                    SqlParameter pEmpname = new SqlParameter();
                    pEmpname.ParameterName = "@Empname";
                    pEmpname.SqlDbType = SqlDbType.VarChar;
                    pEmpname.Size = 200;
                    pEmpname.Direction = ParameterDirection.Input;
                    pEmpname.Value = entity.Empname;

                    SqlParameter pDesignation = new SqlParameter();
                    pDesignation.ParameterName = "@Designation";
                    pDesignation.SqlDbType = SqlDbType.VarChar;
                    pDesignation.Size = 200;
                    pDesignation.Direction = ParameterDirection.Input;
                    pDesignation.Value = entity.Designation;

                    SqlParameter pSalary = new SqlParameter();
                    pSalary.ParameterName = "@Salary";
                    pSalary.SqlDbType = SqlDbType.Int;
                    pSalary.Direction = ParameterDirection.Input;
                    pSalary.Value = entity.Salary;

                    SqlParameter pDeptno = new SqlParameter();
                    pDeptno.ParameterName = "@Deptno";
                    pDeptno.SqlDbType = SqlDbType.Int;
                    pDeptno.Direction = ParameterDirection.Input;
                    pDeptno.Value = entity.Deptno;

                    SqlParameter pEmail = new SqlParameter();
                    pEmail.ParameterName = "@Email";
                    pEmail.SqlDbType = SqlDbType.VarChar;
                    pEmail.Size = 200;
                    pEmail.Direction = ParameterDirection.Input;
                    pEmail.Value = entity.Email;

                    // Add parameters into the Parameters Collection of the Command object
                    Cmd.Parameters.Add(pEmpno);
                    Cmd.Parameters.Add(pEmpname);
                    Cmd.Parameters.Add(pDesignation);
                    Cmd.Parameters.Add(pSalary);
                    Cmd.Parameters.Add(pDeptno);
                    Cmd.Parameters.Add(pEmail);

                    // Call the execute method
                    int res = Cmd.ExecuteNonQuery();

                    if (res == 0)
                    {
                        employee = null;
                    }
                    else
                    {
                        employee = entity;
                    }
                }
                else
                {
                    throw new Exception($"the {id} and {entity.Empno} does not match");
                }
            }
            // for one try there can be multiple catch
            // make sure that the specific catch appears before 
            // the general catch (i.e. Exception class)
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return employee;
        }
    }

       
    }


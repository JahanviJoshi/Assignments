using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment6a
{
    internal class Salaryslip
    {
       
        public void fileCreate(Employee emp, double HRA, double TA, double DA, double gross, double NetSalary, double tax, int MonthlyNetSalary)
        {
            string path = @"C:\Coditas\Salaryslip";
            string filePath = $@"{path} {emp.EmpNo}.txt";
            if (File.Exists(filePath))
            {

                Console.WriteLine($" file {filePath} is already exists");
            }
            

            FileStream F = File.Create(filePath);
            byte[] content = new UTF8Encoding(true).GetBytes(
                           $"-------------------------Salary Slip--------------------------\n" +
                           $"| EmpNo:    {emp.EmpNo}                 EmpName: {emp.EmpName}                |\n" +
                           $"| DeptName: {emp.DeptName}              Designation: {emp.Designation}            |\n" +
                           $"|____________________________________________________________|\n" +
                           $"|Income (Rs.)                  | Deduction (Rs.)             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|Basic Salary: {emp.Salary}            |                             |\n" +
                           $"|HRA: {HRA}                      |                             |\n" +
                           $"|TA: {TA}                      |                             |\n" +
                           $"|DA: {DA}                      |                             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|Gross: {gross}                 |                             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|AnualGross:{NetSalary}            | Tax: {tax}                  |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|NetSalary: {MonthlyNetSalary}              |                             |\n" +
                           $"|------------------------------------------------------------|\n" +
                           $"|NetSalary in Words:{Program.NumberToWords(MonthlyNetSalary)}                                         |\n" +
                           $"--------------------------------------------------------------");


            F.Write(content, 0, content.Length);
            F.Close();
        }



        public void writeData(string filePath, Employee emp, double HRA, double TA, double DA, double gross, double NetSalary, double tax, int MonthlyNetSalary)
        {
            string content = $"-------------------------Salary Slip--------------------------\n" +
                               $"| EmpNo: {emp.EmpNo}            EmpName: {emp.EmpName}       |\n" +
                               $"| DeptName: {emp.DeptName}   Designation: {emp.Designation}  |\n" +
                               $"|____________________________________________________________|\n" +
                               $"|Income (Rs.)                  | Deduction (Rs.)             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|Basic Salary: {emp.Salary}    |                             |\n" +
                               $"|HRA: {HRA}                    |                             |\n" +
                               $"|TA: {TA}                      |                             |\n" +
                               $"|DA: {DA}                      |                             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|Gross: {gross}                |                             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|AnualGross:{NetSalary} | Tax: {tax}                  |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|NetSalary: {MonthlyNetSalary} |                             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|NetSalary in Words:{Program.NumberToWords(MonthlyNetSalary)}                                          |\n" +
                               $"--------------------------------------------------------------";

            File.Create(filePath);
            File.WriteAllText(filePath, content);
           



        }
    
    }
}

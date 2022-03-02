using System;
using System.Collections.Generic;
using System.Linq;

namespace Assigment6a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCollection emp = new EmployeeCollection();

            Calculation(emp);
           
            
          
            
        }

        static void Calculation(IEnumerable<Employee> emps)
        {
            Salaryslip file = new Salaryslip();
            var EmpSalary = from e in emps
                            group e by e.Designation into newGroup
                            select new
                            {
                                Designation = newGroup.Key,
                                Records = newGroup.ToList()
                            };

            foreach (var item in EmpSalary)
            {
                foreach (var record in item.Records)
                {
                    double HRA = 0;
                    double TS = 0;
                    double DA = 0;
                    double Gross = 0;
                    double AnnualGrossSalary = 0;
                    double tax = 0;
                    int NetSalary = 0;
                    if (record.Designation == "Manager")
                    {
                        HRA = (record.Salary * 0.10);
                        TS = (record.Salary * 0.15);
                        DA = (record.Salary * 0.20);

                    }
                    else if (record.Designation == "Director")
                    {
                        HRA = (record.Salary * 0.20);
                        TS = (record.Salary * 0.30);
                        DA = (record.Salary * 0.40);
                    }

                    Gross = record.Salary + HRA + TS + DA;
                    AnnualGrossSalary = Gross * 12;


                    if (AnnualGrossSalary >= 500000 && AnnualGrossSalary <= 1000000)
                    {
                        tax = (Gross * 0.20);
                    }
                    else if (AnnualGrossSalary >= 1000000 && AnnualGrossSalary <= 2000000)
                    {
                        tax = (Gross * 0.25);
                    }
                    else if (AnnualGrossSalary > 2000000)
                    {
                        tax = (Gross * 0.30);
                    }

                    NetSalary = (int)(Gross - tax);

                    file.fileCreate(record, HRA, TS, DA, Gross, AnnualGrossSalary, tax, NetSalary);
                }
            }
        }

        public static string NumberToWords(int number)
        {
            if (number <= 0)
            {
                return "zero";
            }
           

            string words = String.Empty;

            if ((number / 100000) > 0)
            {
                words += NumberToWords(number / 100000) + " lacs ";
                number %= 100000;
            }
            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "and ";
                String[] unit = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                String[] tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                if (number < 20)
                    words += unit[number];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unit[number % 10];
                }
            }
            return words;
        }

    }
}

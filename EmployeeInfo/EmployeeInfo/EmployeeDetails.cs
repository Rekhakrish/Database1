using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    //Class to store Employee Information
    public class Employee
    {

        //properties to store employee information
        //properties to store EmployeeId
        public int EmployeeId { get; set; }

        //properties to store EmployeeName
        public string EmployeeName { get; set; }

        //properties to store How many days employee present
        public int NumberOfDaysPresent { get; set; }

        //properties to store BasicPay
        public double BasicPay { get; set; }

        //properties to store HRA
        public double HRA { get; set; }

        //properties to store OtherAllowances
        public double OtherAllowances { get; set; }

    }
    //class to calculate salary for employee
    public class SalaryHelper
    {
        //calculate gross salary for an employee
        public double CalculateGrossSalary(Employee employee)
        {
            double grossSalary = employee.BasicPay + employee.HRA + employee.OtherAllowances;
            return grossSalary;
        }
        //calculate tax
        public double CalculateTax(Employee employee)
        {
            double tax = 0;
            double annualSalary =  (employee.BasicPay +employee.HRA+employee.OtherAllowances) * 12;
            if (annualSalary <= 500000)
            {
                
                Console.WriteLine("Tax will be zero");
                
            }
            else if (annualSalary > 500000 && annualSalary <= 1000000)
            {
                tax = annualSalary - 500000 * 0.2;
                Console.WriteLine("Tax will be 20%");
            }
            else if (annualSalary > 1000000)
            {
                tax = annualSalary - 500000 * 0.3;
                Console.WriteLine("Tax will be 30%");
            }
            return tax;

        }
        //calculate Netsalary
        public double CalculateNetSalary(Employee employee)
        {
            double grossSalary = CalculateGrossSalary(employee);
            double tax =CalculateTax(employee);
            Console.WriteLine("Deduction From Grosspay and PF-1800 we get Net Salary");
            double netSalary = grossSalary - tax - 1800;
            return netSalary;

        }

        //calculate employee salary
        public class EmployeeDetails
        {
            public static void Main(string[] args)
            {
                //Need to create object for Employee class and get the value
                Employee employee = new Employee();
                Console.WriteLine("Enter Employee Id: ");
                employee.EmployeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                employee.EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter Number of Days Present: ");

                employee.NumberOfDaysPresent = int.Parse(Console.ReadLine());
                if(employee.NumberOfDaysPresent>25)
                {
                    Console.WriteLine("Number of days present should be below 25");
                   
                }
                Console.WriteLine("Enter Basic Pay: ");
                employee.BasicPay = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter HRA: ");
                employee.HRA = double.Parse(Console.ReadLine());
                Console.WriteLine("OtherAllowances: ");
                employee.OtherAllowances = double.Parse(Console.ReadLine());

                //Need to create object for SalaryHelper class and get the value
                SalaryHelper salaryHelper = new SalaryHelper();
                double grossSalary = salaryHelper.CalculateGrossSalary(employee);
                Console.WriteLine("Gross Salary   :" + grossSalary);
              //  double tax = salaryHelper.CalculateTax(employee);
               // Console.WriteLine("Tax  :" + tax);
                double netSalary = salaryHelper.CalculateNetSalary(employee);
                Console.WriteLine("Net Salary   :" + netSalary);
                Console.ReadKey();

            }
        }
    }
}


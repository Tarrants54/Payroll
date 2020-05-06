using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Payroll
{
    class Employee
    //Properties
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal EmpPayRate { get; set; }
        public decimal HoursWorked { get; set; }

        //Constructor
        public Employee(string empId, string empName, decimal empPayRate)
        {
            EmpId = empId;              //Passes in properties and establishes values
            EmpName = empName;
            EmpPayRate = empPayRate;
        }
        public Employee(string empId, string empName, decimal empPayRate,decimal hoursWorked)
        {                               
            EmpId = empId;                      //Another method to capture additional properties to expand the employee instance of the class
            EmpName = empName;
            EmpPayRate = empPayRate;
            HoursWorked = hoursWorked;
        }
        public decimal PayAmount()          //Method to calculate the pay amount
        {
            decimal total;
            total = EmpPayRate * HoursWorked;
            return total;
        }
        public override string ToString()       //Override standatd ToString method and tailored to our class
        {
            string str;
            str = string.Format("Employee ID: {0}, Name: {1}, Pay rate: {2:C}, Hours worked: {3}, Total Pay: {4:C}", EmpId, EmpName, EmpPayRate, HoursWorked, PayAmount());
            return str;
        }
    }
}

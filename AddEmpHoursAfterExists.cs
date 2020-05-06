using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Payroll
{                               //This form shows up if you try to add additional employees after saving
    public partial class AddEmpHoursAfterExists : Form
    {
        public AddEmpHoursAfterExists()
        {
            InitializeComponent();
            
        }
        List<Employee> allEmps = new List<Employee>();      //Creates a new list of Employees
       
        private void nextBtn2_Click(object sender, EventArgs e)
        {
            try
            {                                                               //Create new employee and store values
                Employee emp = new Employee(empId2TxtBox.Text, empName2TxtBox.Text, decimal.Parse(empPayRate2TxtBox.Text), decimal.Parse(empHours2TxtBox.Text));

                allEmps.Add(emp);                                           //Add new employee
                empId2TxtBox.Clear();
                empName2TxtBox.Clear();
                empPayRate2TxtBox.Clear();
                empHours2TxtBox.Clear();
                empId2TxtBox.Focus();
            }
            catch   (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            empId2TxtBox.Clear();               //Clears input
            empName2TxtBox.Clear();
            empPayRate2TxtBox.Clear();
            empHours2TxtBox.Clear();
            empId2TxtBox.Focus();
        }

        private void clsSaveBtn2_Click_1(object sender, EventArgs e)
        {
            {
                StreamWriter sw = File.AppendText("employee.txt");      //Add new formatted employee data to existing file
                try
                {
                    {
                        if (!((string.IsNullOrWhiteSpace(empId2TxtBox.Text)) ||  //Catches errors by not allowing empty txt boxes
                                (string.IsNullOrWhiteSpace(empName2TxtBox.Text)) ||
                                (string.IsNullOrWhiteSpace(empPayRate2TxtBox.Text)) ||
                                string.IsNullOrWhiteSpace(empHours2TxtBox.Text)))
                        {
                            Employee emp1 = new Employee(empId2TxtBox.Text, empName2TxtBox.Text, decimal.Parse(empPayRate2TxtBox.Text), decimal.Parse(empHours2TxtBox.Text));

                            allEmps.Add(emp1);
                                                            //This repeats the above process allowing the data to save even if the user does'nt click next
                            empId2TxtBox.Clear();
                            empName2TxtBox.Clear();
                            empPayRate2TxtBox.Clear();
                            empHours2TxtBox.Clear();
                            empId2TxtBox.Focus();
                        }
                        foreach (Employee emp in allEmps)       //Iterate through each employee added to the list and write the values to the file
                        {
                            sw.WriteLine(emp.EmpId);
                            sw.WriteLine(emp.EmpName);
                            sw.WriteLine(emp.EmpPayRate);
                            sw.WriteLine(emp.HoursWorked);
                        }
                        sw.Close();
                        Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Input.");
                    sw.Close();
                }
            }
        }
        private void AddEmpHoursAfterExists_Load(object sender, EventArgs e)
        {
            empId2TxtBox.Focus();
        }
    }
}

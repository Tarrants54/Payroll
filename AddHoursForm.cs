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
{
    public partial class AddNewEmpHours : Form
    {
        public AddNewEmpHours()
        {
            InitializeComponent();
        }
        List<Employee> allEmps = new List<Employee>();      //Creates a new list of Employees
        private void AddHoursForm_Load(object sender, EventArgs e)      //This occurs when the window is loaded
        {
            if (File.Exists("employee.txt"))        //Checks to see file is already created
            {
                StreamReader sr = new StreamReader("employee.txt");
                string id;
                try
                {                                                           //Opens file to read
                    while ((id = sr.ReadLine()) != null)
                    {
                        Employee emp = new Employee(id, sr.ReadLine(), decimal.Parse(sr.ReadLine()));       //Iterate through the file, store the values and add
                        allEmps.Add(emp);                                                                           //them to the list
                    }
                    //Display first emp
                    if (allEmps.Count > 0)      //If there is some value, display the first element's ID and Name
                    {
                        idLabel.Text = allEmps[0].EmpId;
                        nameLabel.Text = allEmps[0].EmpName;
                    }
                    sr.Close();
                }
                catch (FileNotFoundException)               //Catches exceptions to prevent errors
                {
                    MessageBox.Show("No employees saved!\nSave an employee before entering hours!");
                    sr.Close();
                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input!");
                    sr.Close();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Input!");
                    sr.Close();
                    Close();
                }
            }
            else if (!File.Exists("employee.txt"))      //This populates if the file is not created (no employees)
            {
                MessageBox.Show("Add employees first!");
                Close();
            }
        }

        int count = 1;
        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Add hours entered for employee
                allEmps[count - 1].HoursWorked = decimal.Parse(empHoursTxtBox.Text);
                if (count < allEmps.Count)        //Display next employee until the end of the list
                {
                    idLabel.Text = allEmps[count].EmpId;
                    nameLabel.Text = allEmps[count].EmpName;
                    count++;
                }
                else
                {
                    MessageBox.Show("You entered hours for all employees.");
                    empHoursTxtBox.Clear();
                }
            }
            catch (Exception)
            { MessageBox.Show("Invalid Input!"); }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {                                                               //Clears values
            empHoursTxtBox.Clear();
        }
        private void clsSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = File.CreateText("employee.txt");
                {
                    foreach (Employee emp in allEmps)       //Iterate through each employee added to the list and write the values to the file
                    {
                        sw.WriteLine(emp.EmpId);
                        sw.WriteLine(emp.EmpName);
                        sw.WriteLine(emp.EmpPayRate);
                        sw.WriteLine(emp.HoursWorked);
                    }
                    Close();
                    sw.Close();         //Close stream writer to release resources
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input.");
            }
        }
    }
}
    


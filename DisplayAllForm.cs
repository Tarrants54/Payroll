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
    public partial class DisplayAllForm : Form
    {
        List<Employee> displayAll = new List<Employee>();       //Create list of employees
        public DisplayAllForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();    //Closes window
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print(); //Calls method
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {          
            //Calls and designs print header and event handler

            //Print a custom header
            e.Graphics.DrawString("Employee Pay Day",
                new Font("Courier New", 24, FontStyle.Bold),
                Brushes.Black, 200, 1);
            //Print current Date and time
            e.Graphics.DrawString(DateTime.Now.ToString(),
                new Font("Courier New", 10, FontStyle.Italic),
                Brushes.Black, 220, 150);
            // Print each employee in a loop with custom margins, telling the method when to start printing
            int x = 75, y = 200;
            foreach (Employee emp in displayAll)
            {
                e.Graphics.DrawString(emp.ToString(),
                    new Font("Courier New", 10, FontStyle.Regular),
                    Brushes.Black, x, y);
                y += 15;
            }
        }
        private void DisplayAllForm_Load(object sender, EventArgs e)    //Initiates when the window is loaded
        {
            if (File.Exists("employee.txt"))            //Checks to see if the file exists
            {
                StreamReader sr = new StreamReader("employee.txt"); //Reads employee.txt file
                string empId;
                try
                {
                    while ((empId = sr.ReadLine()) != null)
                    {                                           //Loop thru each line and store values
                        string name = sr.ReadLine();
                        decimal pay = decimal.Parse(sr.ReadLine());
                        decimal hours = decimal.Parse(sr.ReadLine());

                        Employee final = new Employee(empId, name, pay, hours);         //Using these values add a new employee
                        displayAll.Add(final);
                        lbDisplay.Items.Add(final);     //Add each employee to the listbox.
                    }
                    sr.Close();     //Close the stream reader to free up resources
                }
                catch (FileNotFoundException)       //Catches exceptions and displays messages
                {
                    MessageBox.Show("No employees have been entered!");
                    Close();
                    sr.Close();
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("You have to enter all employee hours first!");
                    Close();
                    sr.Close();
                }
            }
        }
    }
}

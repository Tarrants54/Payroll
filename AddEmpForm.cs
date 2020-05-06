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
    public partial class AddEmpForm : Form
    {
        public AddEmpForm()
        {
            InitializeComponent();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {   //Creates a new instance of the employee class with values inside the txt boxes   
                    Employee emp = new Employee(empIdTxtBox.Text, empNameTxtBox.Text, decimal.Parse(empPayTxtBox.Text));
            StreamWriter sw = File.AppendText("employee.txt");  //Opens the file to Write these values to the employee.txt file
                {
                    try
                    { 
                            if (!((string.IsNullOrWhiteSpace(empIdTxtBox.Text)) ||  //Catches errors by not allowing empty txt boxes
                                (string.IsNullOrWhiteSpace(empNameTxtBox.Text)) ||
                                (string.IsNullOrWhiteSpace(empPayTxtBox.Text))))
                            {
                                //Save contents to file
                                sw.WriteLine(emp.EmpId);
                                sw.WriteLine(emp.EmpName);
                                sw.WriteLine(emp.EmpPayRate);
                                //Clear textboxes
                                clearBtn.PerformClick();
                            }
                    }
                    catch (FormatException)         //Catches all other exceptions
                    {
                        sw.Close();
                        MessageBox.Show("Invalid Format!");
                    }
                    catch (Exception)
                    {
                        sw.Close();
                        MessageBox.Show("Invalid Input. Please try again!");
                    }
                }
                sw.Close();         //Closes the stream reader to free up resources and prevent errors
            }  
            catch  (Exception)
            {
                MessageBox.Show("Invalid Input!");
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            empIdTxtBox.Clear();        //Clears all values in text boxes
            empNameTxtBox.Clear();
            empPayTxtBox.Clear();
            empIdTxtBox.Focus();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();   
        }
        private void AddEmpForm_Load(object sender, EventArgs e)        //If the file exists and has data (you added employees, left, and tried to add more employees)
                                                                                //This opens a new form to properly format and store additional employees
        {
            if (File.Exists("employee.txt"))
            {
                StreamReader sr = new StreamReader("employee.txt");
                {
                    if (sr.ReadLine() != null)
                    {
                        sr.Close();
                        NewEmpAlert Alert = new NewEmpAlert();
                        Alert.ShowDialog();
                        Close();
                    }
                }
            }
        }
    }
}

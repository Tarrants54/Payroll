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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void addNewButton_Click(object sender, EventArgs e)
        {
            //Create instance of new form and display
            AddEmpForm addEmpForm = new AddEmpForm();
            addEmpForm.ShowDialog();
        }
        private void addHoursWorkButton_Click(object sender, EventArgs e)
        {
            //Create instance of new form and display
            AddNewEmpHours addHoursForm = new AddNewEmpHours();
            addHoursForm.ShowDialog();
        }
        private void displayAllButton_Click(object sender, EventArgs e)
        {
            //Create instance of new form and display
            DisplayAllForm displayAllForm = new DisplayAllForm();
            displayAllForm.ShowDialog();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close program
            Close();
        }
        private void deleteBtn_Click(object sender, EventArgs e)        //Allows you to delete the employee.txt file to start over or delete all employees
        {
            File.Delete("employee.txt");
        }
    }
}

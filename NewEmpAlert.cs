using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Payroll
{
    public partial class NewEmpAlert : Form
    {
        public NewEmpAlert()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)            //Links pages together, acts as an alert option menu
        {
            AddEmpHoursAfterExists addAfter = new AddEmpHoursAfterExists();
            addAfter.ShowDialog();
            Close();
        }
        private void noButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

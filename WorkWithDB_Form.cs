using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    public partial class WorkWithDB_Form : Form
    {
        public WorkWithDB_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoom_Form Form = new AddRoom_Form();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

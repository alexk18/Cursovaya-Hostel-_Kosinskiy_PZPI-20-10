using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    public partial class AddDuty_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public AddDuty_Form()
        {
            InitializeComponent();
        }

        private void button_ADDDuty_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO Callboard VALUES('{textBox1.Text}','{textBox2.Text}','{dateTimePicker_ColonizeTime.Text}')", connection);
            command.ExecuteReader();
            connection.Close();
        }
    }
}

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
    public partial class AddResident_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public AddResident_Form()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Occupancy < 3", connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                comboBox1.DataSource = table;
                comboBox1.DisplayMember = "Room_number";
                comboBox1.ValueMember = "Room_number";
                comboBox1.SelectedIndex = -1;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddResident_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

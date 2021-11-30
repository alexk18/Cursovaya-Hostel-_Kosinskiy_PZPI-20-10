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

        private void button_ADDRESIDENT_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command1 =
                new SqlCommand(
                    $"SELECT * FROM Resident WHERE IdCodeStudent = {Convert.ToInt32(textBox_IDCodeStudent.Text)}",
                    connection);
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Такий ідентифікатор вже існує",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            { 
                //connection.Open();
                //SqlCommand command = new SqlCommand($"INSERT INTO Resident VALUES({Convert.ToInt32(textBox_IDCodeStudent.Text)},'{textBox_ResidentName.Text}','{textBox_ResidentSurname.Text}',"+
                //                                    $"'{textBox_ResidentMidleName.Text}',{Convert.ToInt32(textBox_Birthday.Text)}," +
                //                                    $"'{textBox_Birthday.Text}','{comboBox_Gender.Text}','{dateTimePicker_ColonizeTime.Value.ToString()}','{textBox_Group.Text}',{Convert.ToInt32(comboBox_Course.Text)}," +
                //                                    $"'{textBox_PhoneNumber}',{Convert.ToInt32(comboBox1.Text)}", connection);
                //command.ExecuteReader();
                //connection.Close();
            }
        }
    }
}

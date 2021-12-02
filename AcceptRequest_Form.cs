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
    public partial class AcceptRequest_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public AcceptRequest_Form()
        {

            InitializeComponent();

        }

        private void AcceptRequest_Form_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand($"SELECT * FROM Request", connection);
            var reader = command.ExecuteReader();
            DataTable dr = new DataTable();
            dr.Load(reader);
            dataGridView1.DataSource = dr;
            connection.Close();
            connection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand command1 = new SqlCommand("SELECT * FROM Request", connection);
            adapter1.SelectCommand = command1;
            adapter1.Fill(table);
            if (table.Rows.Count > 0)
            {
                comboBox_AcceptID.DataSource = table;
                comboBox_AcceptID.DisplayMember = "ID_Request";
                comboBox_AcceptID.ValueMember = "ID_Request";
                comboBox_AcceptID.SelectedIndex = -1;
                comboBox_AcceptID.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            connection.Close();
            InitializeComponent();

        }

        private void button_Accepting_Click(object sender, EventArgs e)
        {
            DateTime DateNow = DateTime.Now;
            DateTime DatePay = DateNow.AddMonths(1);
            string finaldate = DatePay.ToString("yyyy-MM-dd");
            var test = (comboBox_AcceptID.Text);
            connection.Open();
            SqlCommand command = new SqlCommand($"SELECT IdCodeStudent FROM Request WHERE ID_Request = {test}", connection);
            int idStudent =Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            connection.Open();
            SqlCommand command1 = new SqlCommand($"SELECT Sum_request FROM Request WHERE ID_Request = {Convert.ToInt32(comboBox_AcceptID.Text)}", connection);
            double Summa = Convert.ToDouble(command1.ExecuteScalar());
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand($"INSERT INTO Payment VALUES({Convert.ToDecimal(Summa)},{Convert.ToDateTime(finaldate)},{idStudent})", connection);
            command2.ExecuteReader();
            connection.Close();
        }
    }
}

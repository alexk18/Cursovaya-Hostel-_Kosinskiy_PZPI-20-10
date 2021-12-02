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
    public partial class AcceptingRequest_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public AcceptingRequest_Form()
        {
            InitializeComponent();
        }

        private void AcceptingRequest_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSetRequest.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.cursovayaHostelDataSetRequest.Request);

        }

        private void button_Accepting_Click(object sender, EventArgs e)
        {
            DateTime DateNow = DateTime.Now;
            DateTime DatePay = DateNow.AddMonths(1);
            string finaldate = DatePay.ToString("yyyy-MM-dd");
            int test = Convert.ToInt32(comboBox1.Text);
            connection.Open();
            SqlCommand command = new SqlCommand($"SELECT IdCodeStudent FROM Request WHERE ID_Request = {test}", connection);
            int idStudent = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            connection.Open();
            SqlCommand command1 = new SqlCommand($"SELECT Sum_request FROM Request WHERE ID_Request = {test}", connection);
            double Summa = Convert.ToDouble(command1.ExecuteScalar());
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand($"INSERT INTO Payment VALUES({Convert.ToDecimal(Summa)},'{Convert.ToDateTime(finaldate)}',{idStudent})", connection);
            command2.ExecuteReader();
            connection.Close();
            connection.Open();
            SqlCommand command3 = new SqlCommand($"DELETE FROM Request WHERE ID_Request = {test}", connection);
            command3.ExecuteReader();
            connection.Close();
        }
    }
}

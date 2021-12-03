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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    public partial class Update_Payment_Form : Form
    {
        private int IdPayment;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public Update_Payment_Form(int IdPayment)
        {
            this.IdPayment = IdPayment;
            InitializeComponent();
        }

        private void Update_Payment_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSetRequest.Resident". При необходимости она может быть перемещена или удалена.
            this.residentTableAdapter.Fill(this.cursovayaHostelDataSetRequest.Resident);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSetRequest.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.cursovayaHostelDataSetRequest.Payment);
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter($"SELECT * FROM Payment WHERE Operation_id = {IdPayment}", connection);
            DataTable dr = new DataTable();
            command.Fill(dr);
            textBox1.Text = Convert.ToString(dr.Rows[0][0]);
            textBox_UpdateSum.Text = Convert.ToString(dr.Rows[0][1]);
            dateTimePicker_UpdatePaymentTime.Value = Convert.ToDateTime(dr.Rows[0][2]);
            comboBox_UpdateIdCodeStudent.Text = Convert.ToString(dr.Rows[0][3]);
            connection.Close();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            connection.Open();
            SqlCommand command1 = new SqlCommand($"UPDATE Payment SET [Sum] = {Convert.ToDecimal(textBox_UpdateSum.Text)}, Payment_date = '{Convert.ToDateTime(dateTimePicker_UpdatePaymentTime.Value)}' ,IdCodeStudent ={Convert.ToInt32(comboBox_UpdateIdCodeStudent.Text)} WHERE Operation_id = {IdPayment}", connection);
            command1.ExecuteReader();
            ViewDB form = new ViewDB();
            connection.Close();
            form.Show();
            this.Close();
        }
    }
}

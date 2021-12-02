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
    public partial class Payment_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public Payment_Form()
        {
            InitializeComponent();
        }

        private void button_ClosePayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_InfoPay_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox_SearchResident.Text, out int number) == true)
            {
                int idStudent = Convert.ToInt32(comboBox_SearchResident.Text);
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT Room.Standart_cost FROM Room LEFT JOIN Resident ON Resident.Room_number = Room.Room_number WHERE Resident.IdCodeStudent = {idStudent}", connection);
                int standarCost = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                connection.Open();
                SqlCommand command1 = new SqlCommand($"SELECT AVG(ElectricalDevices.Coefficient) FROM ElectricalDevices LEFT JOIN Resident ON Resident.IdCodeStudent = ElectricalDevices.IdCodeStudent WHERE Resident.IdCodeStudent = {idStudent}", connection);
                float avgcoef = Convert.ToSingle(command1.ExecuteScalar());
                Math.Round(avgcoef, 2);
                connection.Close();
                connection.Open();
                SqlCommand command2 = new SqlCommand($"SELECT Payment.Payment_date FROM Payment LEFT JOIN Resident ON Resident.IdCodeStudent = Payment.IdCodeStudent WHERE Resident.IdCodeStudent = {idStudent}", connection);
                var date = command2.ExecuteScalar();
                connection.Close();
                label2.Text = (standarCost * avgcoef).ToString();
                label4.Text = date.ToString();
            }
            else
            {
                MessageBox.Show(
                    "Помилка",
                    "Введіть дані у текстове поле",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.cursovayaHostelDataSet.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Resident". При необходимости она может быть перемещена или удалена.
            this.residentTableAdapter.Fill(this.cursovayaHostelDataSet.Resident);
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            if (Cheking.Checked == true)
            {
                button_AcceptRequest.Visible = true;
                button_AcceptRequest.Enabled = true;
            }
            else
            {
                button_AcceptRequest.Visible = false;
                button_AcceptRequest.Enabled = false;
            }
        }

        private void button_SendRequest_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            connection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO Request VALUES({Convert.ToInt32(comboBox_PaymentRoomNumber.Text)}," +
                                                $"'{textBox_PaymentSUM.Text}','{textBox_PaymentAccept.Text}'," +
                                                $"{Convert.ToInt32(comboBox_PaymentIDResident.Text)})", connection);
            command.ExecuteReader();
            connection.Close();
            MessageBox.Show(
                "Успіх",
                "Заявка відправлена,чекайте підтвердження",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button_AcceptRequest_Click(object sender, EventArgs e)
        {
            AcceptRequest_Form form = new AcceptRequest_Form();
            form.Show();
        }
    }
}

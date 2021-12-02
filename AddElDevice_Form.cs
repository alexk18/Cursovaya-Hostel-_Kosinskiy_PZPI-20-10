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
    public partial class AddElDevice_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public AddElDevice_Form()
        {
            InitializeComponent();
        }

        private void AddElDevice_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Resident". При необходимости она может быть перемещена или удалена.
            this.residentTableAdapter.Fill(this.cursovayaHostelDataSet.Resident);

        }

        private void button_ADDElDevice_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            float test = Convert.ToSingle(textBox_ElCoef.Text);
            connection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO ElectricalDevices VALUES ({Convert.ToInt32(textBox_ElDeviceID.Text)},'{textBox_ELDeviceName.Text}','{textBox_ElPower.Text}'," +
                                                $"{test},{Convert.ToInt32(comboBox_ELDStud.Text)})", connection);
            command.ExecuteReader();
            connection.Close();
            MessageBox.Show(
                "Ви додали девайс",
                "Операція успішна",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}

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
    public partial class UpdateElDevice_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        private int IdElDevice;
        public UpdateElDevice_Form(int IdElDevice)
        {
            this.IdElDevice = IdElDevice;
            InitializeComponent();
        }

        private void UpdateElDevice_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Resident". При необходимости она может быть перемещена или удалена.
            this.residentTableAdapter.Fill(this.cursovayaHostelDataSet.Resident);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.ElectricalDevices". При необходимости она может быть перемещена или удалена.
            this.electricalDevicesTableAdapter.Fill(this.cursovayaHostelDataSet.ElectricalDevices);
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter($"SELECT * FROM ElectricalDevices WHERE Device_Id = {IdElDevice}", connection);
            DataTable dr = new DataTable();
            command.Fill(dr);
            textBox_UpdateElDeviceID.Text = Convert.ToString(dr.Rows[0][0]);
            textBox_UpdateELDeviceName.Text = Convert.ToString(dr.Rows[0][1]);
            textBox_UpdateElPower.Text = Convert.ToString(dr.Rows[0][2]);
            textBox_UpdateElCoef.Text = Convert.ToString(dr.Rows[0][3]);
            comboBox_UpdateELDStud.Text = Convert.ToString(dr.Rows[0][4]);
            connection.Close();
        }

        private void button_UpdateADDElDevice_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            connection.Open();
            SqlCommand command1 = new SqlCommand($"UPDATE ElectricalDevices SET Device_Name ='{textBox_UpdateELDeviceName.Text}', [Power] = '{textBox_UpdateElPower.Text}', Coefficient ={Convert.ToSingle(textBox_UpdateElCoef.Text)} ,IdCodeStudent = {Convert.ToInt32(comboBox_UpdateELDStud.Text)} WHERE Device_Id = {IdElDevice} ", connection);
            command1.ExecuteReader();
            ViewDB form = new ViewDB();
            connection.Close();
            form.Show();
            this.Close();
        }
    }
}

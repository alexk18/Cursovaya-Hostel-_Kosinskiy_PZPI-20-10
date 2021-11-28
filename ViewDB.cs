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
    public partial class ViewDB : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public ViewDB()
        {
            InitializeComponent();
        }

        private void checkBox_Room_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_Room.Checked == true)
            {
                dataGridView1.DataSource = roomBindingSource;
                checkBox_Resident.Enabled = false;
                checkBox_Inventory.Enabled = false;
                checkBox_ElDevice.Enabled = false;
                checkBox_Payment.Enabled = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Resident.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_ElDevice.Enabled = true;
                checkBox_Payment.Enabled = true;
            }
        }

        private void ViewDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.cursovayaHostelDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.ElectricalDevices". При необходимости она может быть перемещена или удалена.
            this.electricalDevicesTableAdapter.Fill(this.cursovayaHostelDataSet.ElectricalDevices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.cursovayaHostelDataSet.Inventory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Resident". При необходимости она может быть перемещена или удалена.
            this.residentTableAdapter.Fill(this.cursovayaHostelDataSet.Resident);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.cursovayaHostelDataSet.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.cursovayaHostelDataSet.Room);

        }

        private void checkBox_Resident_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_Resident.Checked == true)
            {
                dataGridView1.DataSource = residentBindingSource;
                checkBox_Room.Enabled = false;
                checkBox_Inventory.Enabled = false;
                checkBox_ElDevice.Enabled = false;
                checkBox_Payment.Enabled = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_ElDevice.Enabled = true;
                checkBox_Payment.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_Inventory_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Inventory.Checked == true)
            {
                dataGridView1.DataSource = inventoryBindingSource;
                checkBox_Room.Enabled = false;
                checkBox_Resident.Enabled = false;
                checkBox_ElDevice.Enabled = false;
                checkBox_Payment.Enabled = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Resident.Enabled = true;
                checkBox_ElDevice.Enabled = true;
                checkBox_Payment.Enabled = true;
            }
        }

        private void checkBox_ElDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ElDevice.Checked == true)
            {
                dataGridView1.DataSource = electricalDevicesBindingSource;
                checkBox_Room.Enabled = false;
                checkBox_Resident.Enabled = false;
                checkBox_Inventory.Enabled = false;
                checkBox_Payment.Enabled = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Resident.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_Payment.Enabled = true;
            }
        }

        private void checkBox_Payment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Payment.Checked == true)
            {
                dataGridView1.DataSource = paymentBindingSource;
                checkBox_Room.Enabled = false;
                checkBox_Resident.Enabled = false;
                checkBox_Inventory.Enabled = false;
                checkBox_ElDevice.Enabled = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Resident.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_ElDevice.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_number_room.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Room WHERE Room_number = @textBox_number_room",connection);
                command.Parameters.AddWithValue("@textBox_number_room", Convert.ToInt32(textBox_number_room.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
            }
            connection.Close();
        }
    }
    
}

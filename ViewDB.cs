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
                label2.Visible = true;
                label2.Enabled = true;
                label3.Visible = true;
                label3.Enabled = true;
                textBox_Floor_number.Visible = true;
                textBox_Floor_number.Enabled = true;
                textBox_number_room.Visible = true;
                textBox_number_room.Enabled = true;
                button3.Visible = true;
                button3.Enabled = true;
                button2.Visible = true;
                button2.Enabled = true;
                button4.Visible = true;
                button4.Enabled = true;
                checkBox_Male.Visible = true;
                checkBox_Male.Enabled = true;
                checkBox_Female.Visible = true;
                checkBox_Female.Enabled = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Resident.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_ElDevice.Enabled = true;
                checkBox_Payment.Enabled = true;
                label2.Visible = false;
                label2.Enabled = false;
                label3.Visible = false;
                label3.Enabled = false;
                textBox_Floor_number.Visible = false;
                textBox_Floor_number.Enabled = false;
                textBox_number_room.Visible = false;
                textBox_number_room.Enabled = false;
                button3.Visible = false;
                button3.Enabled = false;
                button2.Visible = false;
                button2.Enabled = false;
                button4.Visible = false;
                button4.Enabled = false;
                checkBox_Female.Visible = false;
                checkBox_Female.Enabled = false;
                checkBox_Male.Visible = false;
                checkBox_Male.Enabled = false;
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
                label4.Enabled = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Enabled = true;
                label6.Enabled = true;
                label6.Visible = true;
                textBox_payment_id.Visible = true;
                textBox_payment_id.Enabled = true;
                textBox_payment_date.Visible = true;
                textBox_payment_date.Enabled = true;
                button_payment_Id.Visible = true;
                button_payment_Id.Enabled = true;
                button_payment_date.Visible = true;
                button_payment_date.Enabled = true;
                button_payment_studentId.Visible = true;
                button_payment_studentId.Enabled = true;
                textBox_payment_studentId.Visible = true;
                textBox_payment_studentId.Enabled = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Resident.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_ElDevice.Enabled = true;
                textBox_payment_id.Visible = false;
                textBox_payment_id.Enabled = false;
                textBox_payment_date.Visible = false;
                textBox_payment_date.Enabled = false;
                button_payment_Id.Visible = false;
                button_payment_Id.Enabled = false;
                button_payment_date.Visible = false;
                button_payment_date.Enabled = false;
                button_payment_studentId.Visible = false;
                button_payment_studentId.Enabled = false;
                textBox_payment_studentId.Visible = false;
                textBox_payment_studentId.Enabled = false;
                label4.Enabled = false;
                label4.Visible = false;
                label5.Visible = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label6.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_number_room.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Room_number = @textBox_number_room",connection);
                command.Parameters.AddWithValue("@textBox_number_room", Convert.ToInt32(textBox_number_room.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_number_room.Text = "";
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_Floor_number.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Floor_number = @textBox_Floor_number", connection);
                command.Parameters.AddWithValue("@textBox_Floor_number", Convert.ToInt32(textBox_Floor_number.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_Floor_number.Text = "";
            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string type_room = "";
            if (checkBox_Male.Checked == true && checkBox_Female.Checked == false)
            {
                type_room = "Чоловіча";
                SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Room_type = @type_room", connection);
                command.Parameters.AddWithValue("@type_room", type_room);
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
            }
            else if (checkBox_Male.Checked == false && checkBox_Female.Checked == true)
            {
                type_room = "Жіноча";
                SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Room_type = @type_room", connection);
                command.Parameters.AddWithValue("@type_room", type_room);
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
            }
            else if (checkBox_Male.Checked == true && checkBox_Female.Checked == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Room", connection);
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
            }
            else
            {
                MessageBox.Show(
                    "Помилка",
                    "Оберіть тип кімнати",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            connection.Close();
        }

        private void button_payment_Id_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_payment_id.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Payment WHERE Operation_id = @textBox_payment_id", connection);
                command.Parameters.AddWithValue("@textBox_payment_id", Convert.ToInt32(textBox_payment_id.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_payment_id.Text = "";
            }
            connection.Close();
        }

        private void button_payment_date_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * FROM Payment WHERE Payment_date = @textBox_payment_date", connection);
                command.Parameters.AddWithValue("@textBox_payment_date", textBox_payment_date.Text);
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_payment_date.Text = "";
            connection.Close();
        }

        private void button_payment_studentId_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_payment_studentId.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Payment WHERE IdCodeStudent = @textBox_payment_studentId", connection);
                command.Parameters.AddWithValue("@textBox_payment_studentId", Convert.ToInt32(textBox_payment_studentId.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_payment_studentId.Text = "";
            }
            connection.Close();
        }
    }
    
}

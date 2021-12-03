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
using System.Security.Policy;

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
                roomTableAdapter.Update(cursovayaHostelDataSet);
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
                button_freeRoom.Enabled = true;
                button_freeRoom.Visible = true;
                button_UpdateRoom.Visible = true;
                button_UpdateRoom.Enabled = true;
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
                button_freeRoom.Enabled = false;
                button_freeRoom.Visible = false;
                button_UpdateRoom.Visible = false;
                button_UpdateRoom.Enabled = false;
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
                label_StudentID.Enabled = true;
                label_StudentID.Visible = true;
                button_StudentID.Enabled = true;
                button_StudentID.Visible = true;
                textBox_StudentID.Enabled = true;
                textBox_StudentID.Visible = true;
                label_StudentGroup.Enabled = true;
                label_StudentGroup.Visible = true;
                textBox_StudentGroup.Enabled = true;
                textBox_StudentGroup.Visible = true;
                button_StudentGroup.Enabled = true;
                button_StudentGroup.Visible = true;
                label_StudentBirth.Enabled = true;
                label_StudentBirth.Visible = true;
                textBox_StudentBirth.Visible = true;
                textBox_StudentBirth.Enabled = true;
                button_StudentBirth.Enabled = true;
                button_StudentBirth.Visible = true;
                button_ResidentUpdate.Visible = true;
                button_ResidentUpdate.Enabled = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_ElDevice.Enabled = true;
                checkBox_Payment.Enabled = true;
                label_StudentID.Enabled = false;
                label_StudentID.Visible = false;
                button_StudentID.Enabled = false;
                button_StudentID.Visible = false;
                textBox_StudentID.Enabled = false;
                textBox_StudentID.Visible = false;
                label_StudentGroup.Enabled = false;
                label_StudentGroup.Visible = false;
                textBox_StudentGroup.Enabled = false;
                textBox_StudentGroup.Visible = false;
                button_StudentGroup.Enabled = false;
                button_StudentGroup.Visible = false;
                label_StudentBirth.Enabled = false;
                label_StudentBirth.Visible = false;
                textBox_StudentBirth.Visible = false;
                textBox_StudentBirth.Enabled = false;
                button_StudentBirth.Enabled = false;
                button_StudentBirth.Visible = false;
                button_ResidentUpdate.Visible = false;
                button_ResidentUpdate.Enabled = false;
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
                label_InnventCode.Enabled = true;
                label_InnventCode.Visible = true;
                button_InnventCode.Enabled = true;
                button_InnventCode.Visible = true;
                textBox_InnventCode.Enabled = true;
                textBox_InnventCode.Visible = true;
                label_InvCondition.Visible = true;
                label_InvCondition.Enabled = true;
                textBox_InvCondition.Visible = true;
                textBox_InvCondition.Enabled = true;
                button_InvCondition.Visible = true;
                button_InvCondition.Enabled = true;
                label_InventRoom.Enabled = true;
                label_InventRoom.Visible = true;
                textBox_InventRoom.Enabled = true;
                textBox_InventRoom.Visible = true;
                button_InventRoom.Enabled = true;
                button_InventRoom.Visible = true;
                button_UpdateInventory.Visible = true;
                button_UpdateInventory.Enabled = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Resident.Enabled = true;
                checkBox_ElDevice.Enabled = true;
                checkBox_Payment.Enabled = true;
                label_InnventCode.Enabled = false;
                label_InnventCode.Visible = false;
                button_InnventCode.Enabled = false;
                button_InnventCode.Visible = false;
                textBox_InnventCode.Enabled = false;
                textBox_InnventCode.Visible = false;
                label_InvCondition.Visible = false;
                label_InvCondition.Enabled = false;
                textBox_InvCondition.Visible = false;
                textBox_InvCondition.Enabled = false;
                button_InvCondition.Visible = false;
                button_InvCondition.Enabled = false;
                label_InventRoom.Enabled = false;
                label_InventRoom.Visible = false;
                textBox_InventRoom.Enabled = false;
                textBox_InventRoom.Visible = false;
                button_InventRoom.Enabled = false;
                button_InventRoom.Visible = false;
                button_UpdateInventory.Visible = false;
                button_UpdateInventory.Enabled = false;

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
                label_ElID.Visible = true;
                label_ElID.Enabled = true;
                button_ELID.Enabled = true;
                button_ELID.Visible = true;
                textBox_ElID.Visible = true;
                textBox_ElID.Enabled = true;
                button_ELID.Visible = true;
                button_ELID.Enabled = true;
                label_ElPower.Enabled = true;
                label_ElPower.Visible = true;
                textBox_ElPower.Visible = true;
                textBox_ElPower.Enabled = true;
                button_ELPower.Visible = true;
                button_ELPower.Enabled = true;
                label_ELSTID.Visible = true;
                label_ELSTID.Enabled = true;
                textBox_ELSTID.Enabled = true;
                textBox_ELSTID.Visible = true;
                button_ELSTID.Visible = true;
                button_ELSTID.Enabled = true;
                button_UpdateElDevice.Enabled = true;
                button_UpdateElDevice.Visible = true;
            }
            else
            {
                dataGridView1.DataSource = null;
                checkBox_Room.Enabled = true;
                checkBox_Resident.Enabled = true;
                checkBox_Inventory.Enabled = true;
                checkBox_Payment.Enabled = true;
                label_ElID.Visible = false;
                label_ElID.Enabled = false;
                button_ELID.Enabled = false;
                button_ELID.Visible = false;
                textBox_ElID.Visible = false;
                textBox_ElID.Enabled = false;
                button_ELID.Visible = false;
                button_ELID.Enabled = false;
                label_ElPower.Enabled = false;
                label_ElPower.Visible = false;
                textBox_ElPower.Visible = false;
                textBox_ElPower.Enabled = false;
                button_ELPower.Visible = false;
                button_ELPower.Enabled = false;
                label_ELSTID.Visible = false;
                label_ELSTID.Enabled = false;
                textBox_ELSTID.Enabled = false;
                textBox_ELSTID.Visible = false;
                button_ELSTID.Visible = false;
                button_ELSTID.Enabled = false;
                button_UpdateElDevice.Enabled = false;
                button_UpdateElDevice.Visible = false;
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
                button_UpdatePayment.Enabled = true;
                button_UpdatePayment.Visible= true;
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
                button_UpdatePayment.Enabled = false;
                button_UpdatePayment.Visible = false;
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
                SqlCommand command = new SqlCommand("SELECT * FROM Payment WHERE Operation_id = @textBox_payment_id", connection);
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

        private void button_ELID_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_ElID.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ElectricalDevices WHERE Device_Id = @textBox_ElID", connection);
                command.Parameters.AddWithValue("@textBox_ElID", Convert.ToInt32(textBox_ElID.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_ElID.Text = "";
            }
            connection.Close();
        }

        private void button_ELPower_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM ElectricalDevices WHERE [Power] = @textBox_ElPower", connection);
            command.Parameters.AddWithValue("@textBox_ElPower", textBox_ElPower.Text);
            var reader = command.ExecuteReader();
            DataTable dr = new DataTable();
            dr.Load(reader);
            dataGridView1.DataSource = dr;
            textBox_ElPower.Text = "";
            connection.Close();
        }

        private void label_ELSTID_Click(object sender, EventArgs e)
        {

        }

        private void button_ELSTID_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_ELSTID.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ElectricalDevices WHERE IdCodeStudent =  @textBox_ELSTID", connection);
                command.Parameters.AddWithValue("@textBox_ELSTID", Convert.ToInt32(textBox_ELSTID.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_ELSTID.Text = "";
            }
            connection.Close();
        }

        private void button_InnventCode_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_InnventCode.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Inventory WHERE Furniture_code =  @textBox_InnventCode", connection);
                command.Parameters.AddWithValue("@textBox_InnventCode", Convert.ToInt32(textBox_InnventCode.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_InnventCode.Text = "";
            }
            connection.Close();
        }

        private void textBox_InnventCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_InnventCode_Click(object sender, EventArgs e)
        {

        }

        private void button_InvCondition_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Inventory WHERE Condition = @textBox_InvCondition", connection);
            command.Parameters.AddWithValue("@textBox_InvCondition", textBox_InvCondition.Text);
            var reader = command.ExecuteReader();
            DataTable dr = new DataTable();
            dr.Load(reader);
            dataGridView1.DataSource = dr;
            textBox_InvCondition.Text = "";
            connection.Close();
        }

        private void button_InventRoom_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_InventRoom.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Inventory WHERE Room_number =  @textBox_InventRoom", connection);
                command.Parameters.AddWithValue("@textBox_InventRoom", Convert.ToInt32(textBox_InventRoom.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_InventRoom.Text = "";
            }
            connection.Close();
        }

        private void button_StudentID_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_StudentID.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Resident WHERE IdCodeStudent = @textBox_StudentID", connection);
                command.Parameters.AddWithValue("@textBox_StudentID", Convert.ToInt32(textBox_StudentID.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_StudentID.Text = "";
            }
            connection.Close();
        }

        private void button_StudentGroup_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Resident WHERE Study_group =  @textBox_StudentGroup", connection);
            command.Parameters.AddWithValue("@textBox_StudentGroup", textBox_StudentGroup.Text);
            var reader = command.ExecuteReader();
            DataTable dr = new DataTable();
            dr.Load(reader);
            dataGridView1.DataSource = dr;
            textBox_StudentGroup.Text = "";
            connection.Close();
        }

        private void textBox_StudentGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_StudentGroup_Click(object sender, EventArgs e)
        {

        }

        private void button_StudentBirth_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (int.TryParse(textBox_StudentBirth.Text, out int number) == true)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Resident WHERE Year_birth = @textBox_StudentBirth", connection);
                command.Parameters.AddWithValue("@textBox_StudentBirth", Convert.ToInt32(textBox_StudentBirth.Text));
                var reader = command.ExecuteReader();
                DataTable dr = new DataTable();
                dr.Load(reader);
                dataGridView1.DataSource = dr;
                textBox_StudentBirth.Text = "";
            }
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button_freeRoom_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Occupancy < 3", connection);
            var reader = command.ExecuteReader();
            DataTable dr = new DataTable();
            dr.Load(reader);
            dataGridView1.DataSource = dr;
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteData_Form form = new DeleteData_Form();
            form.Show();
            this.Close();
            checkBox_Room.Checked = false;
            checkBox_Resident.Checked = false;
            checkBox_Inventory.Checked = false;
            checkBox_Payment.Checked = false;
            checkBox_ElDevice.Checked = false;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            
            int idRoom = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            UpdateRoom_Form form1 = new UpdateRoom_Form(idRoom);
            form1.Show();
            Close();

        }

        private void button_ResidentUpdate_Click(object sender, EventArgs e)
        {
            int idResident = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            UpdateResident_Form form = new UpdateResident_Form(idResident);
            form.Show();
            Close();
        }

        private void button_UpdateInventory_Click(object sender, EventArgs e)
        {
            int idFurnitureCode = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            UpdateInventory_Form form = new UpdateInventory_Form(idFurnitureCode);
            form.Show();
            Close();
        }

        private void button_UpdateElDevice_Click(object sender, EventArgs e)
        {
            int idElDevice = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            UpdateElDevice_Form form = new UpdateElDevice_Form(idElDevice) ;
            form.Show();
            Close();
        }

        private void button_UpdatePayment_Click(object sender, EventArgs e)
        {
            int idPayment = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            Update_Payment_Form form = new Update_Payment_Form(idPayment);
            form.Show();
            Close();
        }
    }
    
}

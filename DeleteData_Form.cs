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
    public partial class DeleteData_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public DeleteData_Form()
        {
            InitializeComponent();
        }

        private void textBox_SearchResident_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_SearchNumberRoom.Text != "")
            {
                if (int.TryParse(textBox_SearchNumberRoom.Text, out int number) == true)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Room WHERE Room_number =  @textBox_SearchNumberRoom", connection);
                    command.Parameters.AddWithValue("@textBox_SearchNumberRoom", Convert.ToInt32(textBox_SearchNumberRoom.Text));
                    command.ExecuteReader();
                    connection.Close();
                    roomTableAdapter1.Update(cursovayaHostelDataSet);
                }
                else
                {
                    MessageBox.Show(
                        "Невірні дані,перевірте правильність набору",
                        "Попередження",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                
            }
            if (textBox_SearchResident.Text != "")
            {
                if (int.TryParse(textBox_SearchResident.Text, out int number) == true)
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("SELECT Room.Occupancy FROM Room LEFT OUTER JOIN Resident on  Room.Room_number = Resident.Room_number WHERE IdCodeStudent =  @textBox_SearchResident", connection);
                    command1.Parameters.AddWithValue("@textBox_SearchResident", Convert.ToInt32(textBox_SearchResident.Text));
                    int count = Convert.ToInt32(command1.ExecuteScalar());
                    count = count - 1;
                    connection.Close();
                    connection.Open();
                    SqlCommand command3 = new SqlCommand("SELECT Room.Room_number FROM Room LEFT OUTER JOIN Resident on  Room.Room_number = Resident.Room_number WHERE IdCodeStudent =  @textBox_SearchResident", connection);
                    command3.Parameters.AddWithValue("@textBox_SearchResident", Convert.ToInt32(textBox_SearchResident.Text));
                    int room_number = Convert.ToInt32(command3.ExecuteScalar());
                    connection.Close();
                    connection.Open();
                    SqlCommand command2 = new SqlCommand($"UPDATE Room SET Occupancy = {count} WHERE Room_number = {room_number}", connection);
                    command2.ExecuteReader();
                    connection.Close();
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Resident WHERE IdCodeStudent =  @textBox_SearchResident", connection);
                    command.Parameters.AddWithValue("@textBox_SearchResident", Convert.ToInt32(textBox_SearchResident.Text));
                    command.ExecuteReader();
                    connection.Close();

                }
                else
                {
                    MessageBox.Show(
                        "Невірні дані,перевірте правильність набору",
                        "Попередження",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }

            }
            if (textBox_SearchInventory.Text != "")
            {
                if (int.TryParse(textBox_SearchInventory.Text, out int number) == true)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Inventory WHERE Furniture_code =  @textBox_SearchInventory", connection);
                    command.Parameters.AddWithValue("@textBox_SearchInventory", Convert.ToInt32(textBox_SearchInventory.Text));
                    command.ExecuteReader();
                    connection.Close();
                    roomTableAdapter1.Update(cursovayaHostelDataSet);
                }
                else
                {
                    MessageBox.Show(
                        "Невірні дані,перевірте правильність набору",
                        "Попередження",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }

            }
            if (textBox_SearchElDevice.Text != "")
            {
                if (int.TryParse(textBox_SearchElDevice.Text, out int number) == true)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM ElectricalDevices WHERE Device_Id =  @textBox_SearchElDevice", connection);
                    command.Parameters.AddWithValue("@textBox_SearchElDevice", Convert.ToInt32(textBox_SearchElDevice.Text));
                    command.ExecuteReader();
                    connection.Close();
                    roomTableAdapter1.Update(cursovayaHostelDataSet);
                }
                else
                {
                    MessageBox.Show(
                        "Невірні дані,перевірте правильність набору",
                        "Попередження",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }

            }
            MessageBox.Show(
                "Операція виконана",
                "Успішно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            ViewDB fomr = new ViewDB();
            fomr.Show();
            this.Close();
        }
    }
}

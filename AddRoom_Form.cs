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
    public partial class AddRoom_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public AddRoom_Form()
        {
            InitializeComponent();
        }

        private void AddRoom_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Hostel". При необходимости она может быть перемещена или удалена.
            this.hostelTableAdapter.Fill(this.cursovayaHostelDataSet.Hostel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID_HOSTEL = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            connection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO ROOM VALUES({Convert.ToInt32(textBox_AddRoomNumber.Text)},{textBox_AddRoomFloor.Text},'{comboBox__AddRoomType.Text}',0,{Convert.ToInt32(textBox__AddRoomCost.Text)},{ID_HOSTEL})", connection);
            command.ExecuteReader();
            connection.Close();
            textBox_AddRoomNumber.Text = "";
            textBox_AddRoomFloor.Text = "";
            textBox__AddRoomCost.Text = "";
            MessageBox.Show(
                "Ви додали кімнату",
                "Операція успішна",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

        }
    }
}

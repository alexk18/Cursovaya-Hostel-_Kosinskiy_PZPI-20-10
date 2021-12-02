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
    public partial class UpdateRoom_Form : Form
    { 
        int idRoom;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public UpdateRoom_Form(int idRoom)
        {
            this.idRoom = idRoom;
            InitializeComponent();
        }

        private void UpdateRoom_Form_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter($"SELECT * FROM Room WHERE Room_number = {idRoom}", connection);
            DataTable dr = new DataTable();
            command.Fill(dr);
            textBox_UpdateRoomNumber.Text = Convert.ToString(dr.Rows[0][0]);
            textBox_UpdateRoomFloor.Text = Convert.ToString(dr.Rows[0][1]);
            comboBox__UpdateRoomType.Text = Convert.ToString(dr.Rows[0][2]);
            textBox__UpdateRoomCost.Text = Convert.ToString(dr.Rows[0][4]);
            connection.Close();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.cursovayaHostelDataSet.Room);

        }

        private void button_UpdateNewForm_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand($"UPDATE Room SET Room_number = {Convert.ToInt32(textBox_UpdateRoomNumber.Text)}, Floor_number = {Convert.ToInt32(textBox_UpdateRoomFloor.Text)}, Room_type='{comboBox__UpdateRoomType.Text}', Standart_cost = {Convert.ToInt32(textBox__UpdateRoomCost.Text)} WHERE Room_number = {Convert.ToInt32(textBox_UpdateRoomNumber.Text)}", connection);
            command.ExecuteReader();
            ViewDB form = new ViewDB();
            connection.Close();
            form.Show();
            this.Close();
        }
    }
}

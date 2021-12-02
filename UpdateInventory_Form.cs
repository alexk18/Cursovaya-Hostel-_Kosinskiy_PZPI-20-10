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
   
    public partial class UpdateInventory_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        int furnitureCode;
        public UpdateInventory_Form(int furnitureCode)
        {
            InitializeComponent();
            this.furnitureCode = furnitureCode;
        }

        private void UpdateInventory_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.cursovayaHostelDataSet.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.cursovayaHostelDataSet.Inventory);
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter($"SELECT * FROM Inventory WHERE Furniture_code = {furnitureCode}", connection);
            DataTable dr = new DataTable();
            command.Fill(dr);
            textBox_UpdateFurnitureId.Text = Convert.ToString(dr.Rows[0][0]);
            textBox_UpdateADDTypeFurniture.Text = Convert.ToString(dr.Rows[0][1]);
            comboBox_UpdateAddConditio.Text = Convert.ToString(dr.Rows[0][2]);
            comboBox_UpdateInventRoom.Text = Convert.ToString(dr.Rows[0][3]);
            connection.Close();
        }

        private void button_UpdateADDInventory_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand($"UPDATE Inventory SET Type_furniture = '{textBox_UpdateADDTypeFurniture.Text}' , Condition = '{comboBox_UpdateAddConditio.Text}',  Room_number = {Convert.ToInt32(comboBox_UpdateInventRoom.Text)} WHERE Furniture_code = {furnitureCode}", connection);
            command1.ExecuteReader();
            ViewDB form = new ViewDB();
            connection.Close();
            form.Show();
            this.Close();
        }
    }
}

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
    public partial class InventoryADD_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public InventoryADD_Form()
        {
            InitializeComponent();
        }

        private void InventoryADD_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursovayaHostelDataSet.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.cursovayaHostelDataSet.Room);

        }

        private void button_ADDInventory_Click(object sender, EventArgs e)
        {

            
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Inventory VALUES ('{textBox_ADDTypeFurniture.Text}','{comboBox_AddConditio.Text}','{Convert.ToInt32(comboBox_InventRoom.Text)}')", connection);
                command.ExecuteReader();
                connection.Close();
                textBox_ADDTypeFurniture.Text = "";
                MessageBox.Show(
                    "Ви додали предмет до інвентарю",
                    "Операція успішна",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            
        }
    }
}

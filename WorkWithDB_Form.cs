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
    public partial class WorkWithDB_Form : Form
    {
        
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public WorkWithDB_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoom_Form Form = new AddRoom_Form();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryADD_Form Form = new InventoryADD_Form();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddResident_Form form = new AddResident_Form();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddElDevice_Form form = new AddElDevice_Form();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int floor = Convert.ToInt32(comboBox1.Text);
            connection.Open();
            SqlCommand command = new SqlCommand($"SELECT SUM(Occupancy) FROM Room WHERE Floor_number = {floor} ",connection);
            var sumachelovek= command.ExecuteScalar();
            label3.Text = sumachelovek.ToString();
            connection.Close();

            connection.Open();
            SqlCommand command1 = new SqlCommand($"SELECT SUM(Occupancy) FROM Room WHERE Floor_number = {floor} AND Room_type = 'Чоловіча'", connection);
            int Summa_Male = Convert.ToInt32(command1.ExecuteScalar());
            int Summa_Female = Convert.ToInt32(sumachelovek) - Summa_Male;
            if (Convert.ToInt32(sumachelovek) == 0)
            {
                label4.Text = "0% / 0%";
            }
            else if (Summa_Male == Convert.ToInt32(sumachelovek))
            {
                label4.Text = "100% / 0%";
            }
            else if (Summa_Female == Convert.ToInt32(sumachelovek))
            {
                label4.Text = "0% / 100%";
            }
            else
            {
                double final_statistika = (Summa_Male * 100) / Convert.ToDouble(sumachelovek);
                label4.Text = Math.Round(final_statistika, 2).ToString()
                +"%/" + ((100 - Math.Round(final_statistika, 2)).ToString()) + "%";
            }
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand($"SELECT COUNT(Room_number) FROM Room WHERE Floor_number = {floor} ", connection);
            int sumacomnat = Convert.ToInt32(command2.ExecuteScalar());
            label6.Text = sumacomnat.ToString();
            connection.Close();
        }

        private void WorkWithDB_Form_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button_AddDuty_Click(object sender, EventArgs e)
        {
            AddDuty_Form form = new AddDuty_Form();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Authomatization_Form form = new Authomatization_Form();
            form.Show();
        }
    }
}

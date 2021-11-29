using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    public partial class AuthorizationForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        private Button btn1, btn2,btn3,btn4;
        public AuthorizationForm(Button btn1, Button btn2, Button btn3, Button btn4)
        {
            this.btn1 = btn1;
            this.btn2 = btn2;
            this.btn3 = btn3;
            this.btn4 = btn4;
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand($"SELECT * FROM Account WHERE Login = '{textBox_Login.Text}' AND Password = '{textBox_Password.Text}'", connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                btn1.Enabled = true;
                btn1.Visible = true;
                btn2.Enabled = true;
                btn2.Visible = true;
                btn3.Enabled = false;
                btn3.Visible = false;
                btn4.Enabled = true;
                btn4.Visible = true;
                MessageBox.Show(
                    "Ви війшли до системи",
                    "Ласкаво просимо",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                this.Close();
                Cheking.Checked = true;
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

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}

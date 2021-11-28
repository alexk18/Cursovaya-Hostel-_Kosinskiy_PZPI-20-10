using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    
    public partial class MainForm : Form
    {
        //public bool Checked = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            if (Cheking.Checked == true)
            {
                button_Work.Enabled = true;
                button_Work.Visible = true;
            }
            else if(Cheking.Checked == false)
            {
                button_Work.Enabled = false;
                button_Work.Visible = false;
            }
        }

        private void AccountEnter_Click(object sender, EventArgs e)
        {
            AuthorizationForm AUTFORM = new AuthorizationForm(this.button_Work, this.button_view, this.AccountEnter, this.button_exit);
            AUTFORM.ShowDialog();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Cheking.Checked = false;
            button_Work.Enabled = false;
            button_Work.Visible = false;
            button_view.Enabled = false;
            button_view.Visible = false;
            AccountEnter.Enabled = true;
            AccountEnter.Visible = true;
            button_exit.Visible = false;
            button_exit.Enabled = false;
            MessageBox.Show(
                "Ви вийшли з системи",
                "Повертайтесь ще",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void pictureBox_Dovidka_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.ShowDialog();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            ViewDB ViewDb = new ViewDB();
            ViewDb.Show();
        }
    }
}

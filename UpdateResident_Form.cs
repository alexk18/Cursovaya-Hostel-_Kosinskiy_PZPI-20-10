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
    public partial class UpdateResident_Form : Form
    {
        private int IdResident;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public UpdateResident_Form(int idResident)
        {
            InitializeComponent();
            this.IdResident = idResident;
        }

        private void UpdateResident_Form_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter command = new SqlDataAdapter($"SELECT * FROM Resident WHERE IdCodeStudent = {IdResident}", connection);
            DataTable dr = new DataTable();
            command.Fill(dr);
            textBox_UpdateIDCodeStudent.Text = Convert.ToString(dr.Rows[0][0]);
            textBox_UpdateResidentName.Text = Convert.ToString(dr.Rows[0][1]);
            textBox_UpdateResidentSurname.Text = Convert.ToString(dr.Rows[0][2]);
            textBox_UpdateResidentMidleName.Text = Convert.ToString(dr.Rows[0][3]);
            textBox_UpdateBirthday.Text = Convert.ToString(dr.Rows[0][4]);
            comboBox_UpdateGender.Text = Convert.ToString(dr.Rows[0][5]);
            dateTimePicker_UpdateColonizeTime.Value = (Convert.ToDateTime(dr.Rows[0][6]));
            textBox_UpdateGroup.Text = Convert.ToString(dr.Rows[0][7]);
            comboBox_UpdateCourse.Text = Convert.ToString(dr.Rows[0][8]);
            textBox_UpdatePhoneNumber.Text = Convert.ToString(dr.Rows[0][9]);
            connection.Close();
        }

        private void button_UpdateRESIDENT_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand($"UPDATE Resident SET [Name] = '{textBox_UpdateResidentName.Text}' , Surname = '{textBox_UpdateResidentSurname.Text}', Midle_name='{textBox_UpdateResidentMidleName.Text}', " +
                                                $"Year_birth = {Convert.ToInt32(textBox_UpdateBirthday.Text)}, Gender = '{comboBox_UpdateGender.Text}',Colonize_date = '{Convert.ToDateTime(dateTimePicker_UpdateColonizeTime.Value.ToString("yyyy-MM-dd"))}',Study_group = '{textBox_UpdateGroup.Text}',Course = {Convert.ToInt32(comboBox_UpdateCourse.Text)}," +
                                                $"Mobile_number = '{textBox_UpdatePhoneNumber.Text}' WHERE IdCodeStudent = {IdResident}", connection);
            command1.ExecuteReader();
            ViewDB form = new ViewDB();
            connection.Close();
            form.Show();
            this.Close();
        }
    }
}

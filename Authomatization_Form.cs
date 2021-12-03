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
    
    public partial class Authomatization_Form : Form
    {
        public ResidentList Residentlist = new ResidentList();
        public ResidentList ResidentlistHelper = new ResidentList();
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public Authomatization_Form()
        {
            InitializeComponent();
        }

        private void Authomatization_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_ADDRESIDENTLIST_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command1 =
                new SqlCommand(
                    $"SELECT * FROM Resident WHERE IdCodeStudent = {Convert.ToInt32(textBox_IDCodeStudent.Text)}",
                    connection);
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Такий ідентифікатор вже існує",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                Resident resident = new Resident()
                {
                    ID = Convert.ToInt32(textBox_IDCodeStudent.Text),
                    Name = textBox_ResidentName.Text,
                    Surname = textBox_ResidentSurname.Text,
                    MidleName = textBox_ResidentMidleName.Text,
                    YearBirth = Convert.ToInt32(textBox_Birthday.Text),
                    Gender = comboBox_Gender.Text,
                    Colonize_date = dateTimePicker_ColonizeTime.Value.ToString("yyyy-MM-dd"),
                    Group = textBox_Group.Text,
                    Course = Convert.ToInt32(comboBox_Course.Text),
                    MobilePhone = textBox_PhoneNumber.Text

                };
                Residentlist.Add(resident);
                MessageBox.Show(
                    "Ви додали мешканця до списку",
                    "Операція успішна",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button_Rozseliti_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command1 =
                new SqlCommand($"SELECT * FROM Room WHERE Occupancy < 3", connection);
            var check = command1.ExecuteScalar();
            connection.Close();
            if (check == null)
            {
                MessageBox.Show(
                    "Нема вільніх кімнат",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                for (int i = 0; i < Residentlist.Count; i++)
                {
                    int course = Residentlist[i].Course;
                    int proverkacourse = Residentlist[i].Course;
                    while (1 > 0)
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand($"SELECT Room.Room_number FROM Room LEFT JOIN Resident ON Room.Room_number = Resident.Room_number WHERE Resident.Course = {course} AND Room.Occupancy < 3 AND Resident.Gender = '{Residentlist[i].Gender}'", connection);
                        var proverka = command.ExecuteScalar();
                        connection.Close();
                        if (proverka == null)
                        {
                            course++;
                            if (course == 6) { course = 0; }

                            if (course == proverkacourse)
                            {
                                ResidentlistHelper.Add(Residentlist[i]);
                                break;
                            }

                        }
                        else
                        {
                            connection.Open();
                            SqlCommand command2 = new SqlCommand($"INSERT INTO Resident VALUES ({Residentlist[i].ID},'{Residentlist[i].Name}'," +
                                                                 $"'{Residentlist[i].Surname}','{Residentlist[i].MidleName}'," +
                                                                 $"{Residentlist[i].YearBirth},'{Residentlist[i].Gender}'," +
                                                                 $"'{(Residentlist[i].Colonize_date)}','{Residentlist[i].Group}'," +
                                                                 $"{Convert.ToInt32(Residentlist[i].Course)},'{Residentlist[i].MobilePhone}',{Convert.ToInt32(proverka)})", connection);
                            command2.ExecuteReader();
                            connection.Close();
                            connection.Open();
                            SqlCommand command5 = new SqlCommand($"UPDATE Room SET Occupancy = Occupancy + 1 WHERE Room_number = {Convert.ToInt32(proverka)}", connection);
                            command5.ExecuteReader();
                            connection.Close();
                            break;
                        }
                    }
                }

            }
        }
    }
}

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
using Word = Microsoft.Office.Interop.Word;

namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    public partial class ViewOtchet_Form : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T2K3THA;Initial Catalog=CursovayaHostel;Integrated Security=True");
        public ViewOtchet_Form()
        {
            InitializeComponent();
        }

        private void ViewOtchet_Form_Load(object sender, EventArgs e)
        {
            if (Cheking.Checked == true)
            {
                PrintZvit.Enabled = true;
                PrintZvit.Visible = true;
                button_DutyOtchet.Visible = true;
                button_DutyOtchet.Enabled = true;
            }
            else
            {
                PrintZvit.Enabled = false;
                PrintZvit.Visible = false;
                button_DutyOtchet.Visible = false;
                button_DutyOtchet.Enabled = false;
            }
            connection.Open();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            SqlCommand command = new SqlCommand($"SELECT Resident.[Name], Resident.Surname, Resident.Midle_name, Resident.Course,Resident.Study_group,Resident.Room_number,Payment.Payment_date " +
                                                $"FROM Resident INNER JOIN Payment ON Resident.IdCodeStudent = Payment.IdCodeStudent WHERE Payment.Payment_date < '{Convert.ToDateTime(date)}'", connection);
            var reader = command.ExecuteReader();
            DataTable dr = new DataTable();
            dr.Load(reader);
            dataGridView2.DataSource = dr;
            connection.Close();
            connection.Open();
            SqlCommand command1 = new SqlCommand($"SELECT * FROM Callboard", connection);
            var reader1 = command1.ExecuteReader();
            DataTable dr1 = new DataTable();
            dr1.Load(reader1);
            dataGridView1.DataSource = dr1;
            connection.Close();
        }

        private void button_CloseOtchet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename,string name)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } 
                } 

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

               
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = name;
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                
                oDoc.SaveAs2(filename);

                
            }
        }

        private void PrintZvit_Click(object sender, EventArgs e)
        {
            string zagolovok = "Боржники";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView2, sfd.FileName, zagolovok);
            }
        }

        private void button_DutyOtchet_Click(object sender, EventArgs e)
        {
            string zagolovok = "Чергування вахти";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView1, sfd.FileName, zagolovok);
            }
        }
    }
}

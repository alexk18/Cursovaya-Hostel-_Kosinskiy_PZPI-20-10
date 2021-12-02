
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class ViewOtchet_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PrintZvit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_CloseOtchet = new System.Windows.Forms.Button();
            this.button_DutyOtchet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1173, 390);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Чергування вахти";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1173, 390);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Боржники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PrintZvit
            // 
            this.PrintZvit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.PrintZvit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintZvit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.PrintZvit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintZvit.Location = new System.Drawing.Point(16, 480);
            this.PrintZvit.Name = "PrintZvit";
            this.PrintZvit.Size = new System.Drawing.Size(268, 43);
            this.PrintZvit.TabIndex = 2;
            this.PrintZvit.Text = "Отримати звіти боржників у файлі";
            this.PrintZvit.UseVisualStyleBackColor = false;
            this.PrintZvit.Click += new System.EventHandler(this.PrintZvit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1169, 383);
            this.dataGridView2.TabIndex = 0;
            // 
            // button_CloseOtchet
            // 
            this.button_CloseOtchet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_CloseOtchet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CloseOtchet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_CloseOtchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CloseOtchet.Location = new System.Drawing.Point(918, 480);
            this.button_CloseOtchet.Name = "button_CloseOtchet";
            this.button_CloseOtchet.Size = new System.Drawing.Size(268, 43);
            this.button_CloseOtchet.TabIndex = 3;
            this.button_CloseOtchet.Text = "Повернутися назад";
            this.button_CloseOtchet.UseVisualStyleBackColor = false;
            this.button_CloseOtchet.Click += new System.EventHandler(this.button_CloseOtchet_Click);
            // 
            // button_DutyOtchet
            // 
            this.button_DutyOtchet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_DutyOtchet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DutyOtchet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_DutyOtchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DutyOtchet.Location = new System.Drawing.Point(312, 480);
            this.button_DutyOtchet.Name = "button_DutyOtchet";
            this.button_DutyOtchet.Size = new System.Drawing.Size(268, 43);
            this.button_DutyOtchet.TabIndex = 4;
            this.button_DutyOtchet.Text = "Отримати звіти чергування у файлі";
            this.button_DutyOtchet.UseVisualStyleBackColor = false;
            this.button_DutyOtchet.Click += new System.EventHandler(this.button_DutyOtchet_Click);
            // 
            // ViewOtchet_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1205, 571);
            this.Controls.Add(this.button_DutyOtchet);
            this.Controls.Add(this.button_CloseOtchet);
            this.Controls.Add(this.PrintZvit);
            this.Controls.Add(this.tabControl1);
            this.Name = "ViewOtchet_Form";
            this.Text = "Перегляд звітів";
            this.Load += new System.EventHandler(this.ViewOtchet_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button PrintZvit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_CloseOtchet;
        private System.Windows.Forms.Button button_DutyOtchet;
    }
}
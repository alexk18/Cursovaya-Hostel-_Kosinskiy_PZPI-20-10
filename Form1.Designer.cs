
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AccountEnter = new System.Windows.Forms.Button();
            this.button_ListZvit = new System.Windows.Forms.Button();
            this.button_Oplata = new System.Windows.Forms.Button();
            this.button_Work = new System.Windows.Forms.Button();
            this.button_view = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox_Dovidka = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dovidka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 21);
            this.toolStripStatusLabel1.Text = "Поточна дата: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 21);
            // 
            // AccountEnter
            // 
            this.AccountEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.AccountEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.AccountEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountEnter.Location = new System.Drawing.Point(50, 34);
            this.AccountEnter.Name = "AccountEnter";
            this.AccountEnter.Size = new System.Drawing.Size(144, 43);
            this.AccountEnter.TabIndex = 1;
            this.AccountEnter.Text = "Увійти до системи";
            this.AccountEnter.UseVisualStyleBackColor = false;
            this.AccountEnter.Click += new System.EventHandler(this.AccountEnter_Click);
            // 
            // button_ListZvit
            // 
            this.button_ListZvit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_ListZvit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ListZvit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_ListZvit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ListZvit.Location = new System.Drawing.Point(50, 332);
            this.button_ListZvit.Name = "button_ListZvit";
            this.button_ListZvit.Size = new System.Drawing.Size(144, 43);
            this.button_ListZvit.TabIndex = 2;
            this.button_ListZvit.Text = "Переглянути звіти";
            this.button_ListZvit.UseVisualStyleBackColor = false;
            // 
            // button_Oplata
            // 
            this.button_Oplata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_Oplata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Oplata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_Oplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Oplata.Location = new System.Drawing.Point(233, 332);
            this.button_Oplata.Name = "button_Oplata";
            this.button_Oplata.Size = new System.Drawing.Size(144, 43);
            this.button_Oplata.TabIndex = 3;
            this.button_Oplata.Text = "Здійснити оплату";
            this.button_Oplata.UseVisualStyleBackColor = false;
            // 
            // button_Work
            // 
            this.button_Work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_Work.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Work.Enabled = false;
            this.button_Work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Work.Location = new System.Drawing.Point(415, 332);
            this.button_Work.Name = "button_Work";
            this.button_Work.Size = new System.Drawing.Size(144, 43);
            this.button_Work.TabIndex = 4;
            this.button_Work.Text = "Робота з системою";
            this.button_Work.UseVisualStyleBackColor = false;
            this.button_Work.Visible = false;
            // 
            // button_view
            // 
            this.button_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_view.Enabled = false;
            this.button_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view.Location = new System.Drawing.Point(596, 332);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(144, 43);
            this.button_view.TabIndex = 6;
            this.button_view.Text = "Перегляд даних";
            this.button_view.UseVisualStyleBackColor = false;
            this.button_view.Visible = false;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Enabled = false;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Location = new System.Drawing.Point(50, 34);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(144, 43);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Вийти з облікового запису";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Visible = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox_Dovidka
            // 
            this.pictureBox_Dovidka.BackColor = System.Drawing.Color.Red;
            this.pictureBox_Dovidka.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox_Dovidka.Image = global::Cursovaya_Hostel__Kosinskiy_PZPI_20_10.Properties.Resources.images;
            this.pictureBox_Dovidka.Location = new System.Drawing.Point(689, 13);
            this.pictureBox_Dovidka.Name = "pictureBox_Dovidka";
            this.pictureBox_Dovidka.Size = new System.Drawing.Size(71, 64);
            this.pictureBox_Dovidka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Dovidka.TabIndex = 5;
            this.pictureBox_Dovidka.TabStop = false;
            this.pictureBox_Dovidka.Click += new System.EventHandler(this.pictureBox_Dovidka_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.pictureBox_Dovidka);
            this.Controls.Add(this.button_Work);
            this.Controls.Add(this.button_Oplata);
            this.Controls.Add(this.button_ListZvit);
            this.Controls.Add(this.AccountEnter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_exit);
            this.Name = "MainForm";
            this.Text = "Головна сторінка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dovidka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button AccountEnter;
        private System.Windows.Forms.Button button_ListZvit;
        private System.Windows.Forms.Button button_Oplata;
        private System.Windows.Forms.PictureBox pictureBox_Dovidka;
        private System.Windows.Forms.Button button_view;
        public System.Windows.Forms.Button button_Work;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


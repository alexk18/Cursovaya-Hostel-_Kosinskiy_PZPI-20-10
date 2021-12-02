
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class Payment_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Form));
            this.button_ClosePayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SearchResident = new System.Windows.Forms.ComboBox();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.label_LastPay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_InfoPay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.residentTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.ResidentTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_PaymentIDResident = new System.Windows.Forms.ComboBox();
            this.comboBox_PaymentRoomNumber = new System.Windows.Forms.ComboBox();
            this.textBox_PaymentSUM = new System.Windows.Forms.TextBox();
            this.textBox_PaymentAccept = new System.Windows.Forms.TextBox();
            this.button_SendRequest = new System.Windows.Forms.Button();
            this.residentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.RoomTableAdapter();
            this.button_AcceptRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ClosePayment
            // 
            this.button_ClosePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_ClosePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ClosePayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_ClosePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClosePayment.Location = new System.Drawing.Point(752, 12);
            this.button_ClosePayment.Name = "button_ClosePayment";
            this.button_ClosePayment.Size = new System.Drawing.Size(268, 43);
            this.button_ClosePayment.TabIndex = 4;
            this.button_ClosePayment.Text = "Повернутися назад";
            this.button_ClosePayment.UseVisualStyleBackColor = false;
            this.button_ClosePayment.Click += new System.EventHandler(this.button_ClosePayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть чи оберіть ідентифікаційний код студенту";
            // 
            // comboBox_SearchResident
            // 
            this.comboBox_SearchResident.DataSource = this.residentBindingSource;
            this.comboBox_SearchResident.DisplayMember = "IdCodeStudent";
            this.comboBox_SearchResident.FormattingEnabled = true;
            this.comboBox_SearchResident.Location = new System.Drawing.Point(33, 54);
            this.comboBox_SearchResident.Name = "comboBox_SearchResident";
            this.comboBox_SearchResident.Size = new System.Drawing.Size(252, 21);
            this.comboBox_SearchResident.TabIndex = 6;
            this.comboBox_SearchResident.ValueMember = "IdCodeStudent";
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cursovayaHostelDataSet;
            this.bindingSource1.Position = 0;
            // 
            // cursovayaHostelDataSet
            // 
            this.cursovayaHostelDataSet.DataSetName = "CursovayaHostelDataSet";
            this.cursovayaHostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_LastPay
            // 
            this.label_LastPay.AutoSize = true;
            this.label_LastPay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LastPay.Location = new System.Drawing.Point(30, 124);
            this.label_LastPay.Name = "label_LastPay";
            this.label_LastPay.Size = new System.Drawing.Size(199, 20);
            this.label_LastPay.TabIndex = 7;
            this.label_LastPay.Text = "Необхідна сума до сплати:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(250, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кінець дії платежу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(207, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // button_InfoPay
            // 
            this.button_InfoPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_InfoPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_InfoPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_InfoPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InfoPay.Location = new System.Drawing.Point(330, 45);
            this.button_InfoPay.Name = "button_InfoPay";
            this.button_InfoPay.Size = new System.Drawing.Size(225, 36);
            this.button_InfoPay.TabIndex = 11;
            this.button_InfoPay.Text = "Дізнатися інформацію";
            this.button_InfoPay.UseVisualStyleBackColor = false;
            this.button_InfoPay.Click += new System.EventHandler(this.button_InfoPay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1032, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
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
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(869, 80);
            this.label5.TabIndex = 13;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ідентифікаційний код студенту:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Номер кімнати:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Сума сплати:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(33, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Номер квитанції:";
            // 
            // comboBox_PaymentIDResident
            // 
            this.comboBox_PaymentIDResident.DataSource = this.residentBindingSource1;
            this.comboBox_PaymentIDResident.DisplayMember = "IdCodeStudent";
            this.comboBox_PaymentIDResident.FormattingEnabled = true;
            this.comboBox_PaymentIDResident.Location = new System.Drawing.Point(299, 334);
            this.comboBox_PaymentIDResident.Name = "comboBox_PaymentIDResident";
            this.comboBox_PaymentIDResident.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PaymentIDResident.TabIndex = 18;
            this.comboBox_PaymentIDResident.ValueMember = "IdCodeStudent";
            // 
            // comboBox_PaymentRoomNumber
            // 
            this.comboBox_PaymentRoomNumber.DataSource = this.roomBindingSource;
            this.comboBox_PaymentRoomNumber.DisplayMember = "Room_number";
            this.comboBox_PaymentRoomNumber.FormattingEnabled = true;
            this.comboBox_PaymentRoomNumber.Location = new System.Drawing.Point(299, 375);
            this.comboBox_PaymentRoomNumber.Name = "comboBox_PaymentRoomNumber";
            this.comboBox_PaymentRoomNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PaymentRoomNumber.TabIndex = 19;
            this.comboBox_PaymentRoomNumber.ValueMember = "Room_number";
            // 
            // textBox_PaymentSUM
            // 
            this.textBox_PaymentSUM.Location = new System.Drawing.Point(299, 414);
            this.textBox_PaymentSUM.Name = "textBox_PaymentSUM";
            this.textBox_PaymentSUM.Size = new System.Drawing.Size(121, 20);
            this.textBox_PaymentSUM.TabIndex = 20;
            // 
            // textBox_PaymentAccept
            // 
            this.textBox_PaymentAccept.Location = new System.Drawing.Point(299, 458);
            this.textBox_PaymentAccept.Name = "textBox_PaymentAccept";
            this.textBox_PaymentAccept.Size = new System.Drawing.Size(193, 20);
            this.textBox_PaymentAccept.TabIndex = 21;
            // 
            // button_SendRequest
            // 
            this.button_SendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_SendRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SendRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_SendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SendRequest.Location = new System.Drawing.Point(539, 384);
            this.button_SendRequest.Name = "button_SendRequest";
            this.button_SendRequest.Size = new System.Drawing.Size(225, 36);
            this.button_SendRequest.TabIndex = 22;
            this.button_SendRequest.Text = "Відправити заявку";
            this.button_SendRequest.UseVisualStyleBackColor = false;
            this.button_SendRequest.Click += new System.EventHandler(this.button_SendRequest_Click);
            // 
            // residentBindingSource1
            // 
            this.residentBindingSource1.DataMember = "Resident";
            this.residentBindingSource1.DataSource = this.bindingSource1;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.bindingSource1;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // button_AcceptRequest
            // 
            this.button_AcceptRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_AcceptRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AcceptRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_AcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AcceptRequest.Location = new System.Drawing.Point(752, 101);
            this.button_AcceptRequest.Name = "button_AcceptRequest";
            this.button_AcceptRequest.Size = new System.Drawing.Size(268, 43);
            this.button_AcceptRequest.TabIndex = 23;
            this.button_AcceptRequest.Text = "Перевірити заяви";
            this.button_AcceptRequest.UseVisualStyleBackColor = false;
            this.button_AcceptRequest.Click += new System.EventHandler(this.button_AcceptRequest_Click);
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1032, 555);
            this.Controls.Add(this.button_AcceptRequest);
            this.Controls.Add(this.button_SendRequest);
            this.Controls.Add(this.textBox_PaymentAccept);
            this.Controls.Add(this.textBox_PaymentSUM);
            this.Controls.Add(this.comboBox_PaymentRoomNumber);
            this.Controls.Add(this.comboBox_PaymentIDResident);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_InfoPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_LastPay);
            this.Controls.Add(this.comboBox_SearchResident);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ClosePayment);
            this.Name = "Payment_Form";
            this.Text = "Оплата гуртожитку";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ClosePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SearchResident;
        private System.Windows.Forms.Label label_LastPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_InfoPay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private CursovayaHostelDataSetTableAdapters.ResidentTableAdapter residentTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_PaymentIDResident;
        private System.Windows.Forms.ComboBox comboBox_PaymentRoomNumber;
        private System.Windows.Forms.TextBox textBox_PaymentSUM;
        private System.Windows.Forms.TextBox textBox_PaymentAccept;
        private System.Windows.Forms.Button button_SendRequest;
        private System.Windows.Forms.BindingSource residentBindingSource1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private CursovayaHostelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Button button_AcceptRequest;
    }
}
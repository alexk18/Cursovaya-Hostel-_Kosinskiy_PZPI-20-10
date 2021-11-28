
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class ViewDB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox_Room = new System.Windows.Forms.CheckBox();
            this.checkBox_Resident = new System.Windows.Forms.CheckBox();
            this.checkBox_Inventory = new System.Windows.Forms.CheckBox();
            this.checkBox_ElDevice = new System.Windows.Forms.CheckBox();
            this.checkBox_Payment = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.RoomTableAdapter();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.ResidentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.InventoryTableAdapter();
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.electricalDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electricalDevicesTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.ElectricalDevicesTableAdapter();
            this.bindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.PaymentTableAdapter();
            this.textBox_number_room = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricalDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBox_Room
            // 
            this.checkBox_Room.AutoSize = true;
            this.checkBox_Room.Location = new System.Drawing.Point(643, 463);
            this.checkBox_Room.Name = "checkBox_Room";
            this.checkBox_Room.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Room.TabIndex = 1;
            this.checkBox_Room.Text = "Кімнати";
            this.checkBox_Room.UseVisualStyleBackColor = true;
            this.checkBox_Room.CheckedChanged += new System.EventHandler(this.checkBox_Room_CheckedChanged);
            // 
            // checkBox_Resident
            // 
            this.checkBox_Resident.AutoSize = true;
            this.checkBox_Resident.Location = new System.Drawing.Point(751, 463);
            this.checkBox_Resident.Name = "checkBox_Resident";
            this.checkBox_Resident.Size = new System.Drawing.Size(75, 17);
            this.checkBox_Resident.TabIndex = 2;
            this.checkBox_Resident.Text = "Мешканці";
            this.checkBox_Resident.UseVisualStyleBackColor = true;
            this.checkBox_Resident.CheckedChanged += new System.EventHandler(this.checkBox_Resident_CheckedChanged);
            // 
            // checkBox_Inventory
            // 
            this.checkBox_Inventory.AutoSize = true;
            this.checkBox_Inventory.Location = new System.Drawing.Point(862, 463);
            this.checkBox_Inventory.Name = "checkBox_Inventory";
            this.checkBox_Inventory.Size = new System.Drawing.Size(70, 17);
            this.checkBox_Inventory.TabIndex = 3;
            this.checkBox_Inventory.Text = "Інвентар";
            this.checkBox_Inventory.UseVisualStyleBackColor = true;
            this.checkBox_Inventory.CheckedChanged += new System.EventHandler(this.checkBox_Inventory_CheckedChanged);
            // 
            // checkBox_ElDevice
            // 
            this.checkBox_ElDevice.AutoSize = true;
            this.checkBox_ElDevice.Location = new System.Drawing.Point(963, 463);
            this.checkBox_ElDevice.Name = "checkBox_ElDevice";
            this.checkBox_ElDevice.Size = new System.Drawing.Size(113, 17);
            this.checkBox_ElDevice.TabIndex = 4;
            this.checkBox_ElDevice.Text = "Електро прилади";
            this.checkBox_ElDevice.UseVisualStyleBackColor = true;
            this.checkBox_ElDevice.CheckedChanged += new System.EventHandler(this.checkBox_ElDevice_CheckedChanged);
            // 
            // checkBox_Payment
            // 
            this.checkBox_Payment.AutoSize = true;
            this.checkBox_Payment.Location = new System.Drawing.Point(1096, 463);
            this.checkBox_Payment.Name = "checkBox_Payment";
            this.checkBox_Payment.Size = new System.Drawing.Size(63, 17);
            this.checkBox_Payment.TabIndex = 5;
            this.checkBox_Payment.Text = "Оплати";
            this.checkBox_Payment.UseVisualStyleBackColor = true;
            this.checkBox_Payment.CheckedChanged += new System.EventHandler(this.checkBox_Payment_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оберіть що бажаєте переглянути:";
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
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.roomBindingSource;
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
            // bindingSource3
            // 
            this.bindingSource3.DataSource = this.residentBindingSource;
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.bindingSource1;
            // 
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Повернутися назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataSource = this.inventoryBindingSource;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.bindingSource1;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource5
            // 
            this.bindingSource5.DataSource = this.electricalDevicesBindingSource;
            // 
            // electricalDevicesBindingSource
            // 
            this.electricalDevicesBindingSource.DataMember = "ElectricalDevices";
            this.electricalDevicesBindingSource.DataSource = this.bindingSource1;
            // 
            // electricalDevicesTableAdapter
            // 
            this.electricalDevicesTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource6
            // 
            this.bindingSource6.DataSource = this.paymentBindingSource;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.bindingSource1;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_number_room
            // 
            this.textBox_number_room.Location = new System.Drawing.Point(13, 95);
            this.textBox_number_room.Name = "textBox_number_room";
            this.textBox_number_room.Size = new System.Drawing.Size(281, 20);
            this.textBox_number_room.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введіть номер кімнати:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(47, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отримати інформацію за поверхом";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(47, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Пошук кімнати";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введіть поверх";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(47, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 38);
            this.button4.TabIndex = 14;
            this.button4.Text = "Пошук вільних кімнат";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ViewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1171, 557);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_number_room);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Payment);
            this.Controls.Add(this.checkBox_ElDevice);
            this.Controls.Add(this.checkBox_Inventory);
            this.Controls.Add(this.checkBox_Resident);
            this.Controls.Add(this.checkBox_Room);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDB";
            this.Text = "Перегляд бази даних";
            this.Load += new System.EventHandler(this.ViewDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricalDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox_Room;
        private System.Windows.Forms.CheckBox checkBox_Resident;
        private System.Windows.Forms.CheckBox checkBox_Inventory;
        private System.Windows.Forms.CheckBox checkBox_ElDevice;
        private System.Windows.Forms.CheckBox checkBox_Payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private CursovayaHostelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private CursovayaHostelDataSetTableAdapters.ResidentTableAdapter residentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private CursovayaHostelDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource5;
        private System.Windows.Forms.BindingSource electricalDevicesBindingSource;
        private CursovayaHostelDataSetTableAdapters.ElectricalDevicesTableAdapter electricalDevicesTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource6;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private CursovayaHostelDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.TextBox textBox_number_room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}
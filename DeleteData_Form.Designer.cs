
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class DeleteData_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SearchNumberRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SearchResident = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SearchInventory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SearchElDevice = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.roomTableAdapter1 = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.RoomTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.residentTableAdapter1 = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.ResidentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть необхідні дані та натисніть кнопку видалити";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер кімнати";
            // 
            // textBox_SearchNumberRoom
            // 
            this.textBox_SearchNumberRoom.Location = new System.Drawing.Point(178, 143);
            this.textBox_SearchNumberRoom.Name = "textBox_SearchNumberRoom";
            this.textBox_SearchNumberRoom.Size = new System.Drawing.Size(137, 20);
            this.textBox_SearchNumberRoom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Айді код студенту";
            // 
            // textBox_SearchResident
            // 
            this.textBox_SearchResident.Location = new System.Drawing.Point(178, 213);
            this.textBox_SearchResident.Name = "textBox_SearchResident";
            this.textBox_SearchResident.Size = new System.Drawing.Size(137, 20);
            this.textBox_SearchResident.TabIndex = 4;
            this.textBox_SearchResident.TextChanged += new System.EventHandler(this.textBox_SearchResident_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(425, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Айді код мебелі";
            // 
            // textBox_SearchInventory
            // 
            this.textBox_SearchInventory.Location = new System.Drawing.Point(617, 143);
            this.textBox_SearchInventory.Name = "textBox_SearchInventory";
            this.textBox_SearchInventory.Size = new System.Drawing.Size(137, 20);
            this.textBox_SearchInventory.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(425, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Айді код електро приладу";
            // 
            // textBox_SearchElDevice
            // 
            this.textBox_SearchElDevice.Location = new System.Drawing.Point(617, 206);
            this.textBox_SearchElDevice.Name = "textBox_SearchElDevice";
            this.textBox_SearchElDevice.Size = new System.Drawing.Size(137, 20);
            this.textBox_SearchElDevice.TabIndex = 8;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Location = new System.Drawing.Point(297, 352);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(214, 38);
            this.button_Delete.TabIndex = 58;
            this.button_Delete.Text = "Видалити";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
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
            // residentTableAdapter1
            // 
            this.residentTableAdapter1.ClearBeforeFill = true;
            // 
            // DeleteData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_SearchElDevice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_SearchInventory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_SearchResident);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SearchNumberRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteData_Form";
            this.Text = "Видалення даних";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SearchNumberRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SearchResident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SearchInventory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SearchElDevice;
        private System.Windows.Forms.Button button_Delete;
        private CursovayaHostelDataSetTableAdapters.RoomTableAdapter roomTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private CursovayaHostelDataSetTableAdapters.ResidentTableAdapter residentTableAdapter1;
    }
}
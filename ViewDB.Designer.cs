
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox_Room = new System.Windows.Forms.CheckBox();
            this.checkBox_Resident = new System.Windows.Forms.CheckBox();
            this.checkBox_Inventory = new System.Windows.Forms.CheckBox();
            this.checkBox_ElDevice = new System.Windows.Forms.CheckBox();
            this.checkBox_Payment = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBox_Room
            // 
            this.checkBox_Room.AutoSize = true;
            this.checkBox_Room.Location = new System.Drawing.Point(371, 463);
            this.checkBox_Room.Name = "checkBox_Room";
            this.checkBox_Room.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Room.TabIndex = 1;
            this.checkBox_Room.Text = "Кімнати";
            this.checkBox_Room.UseVisualStyleBackColor = true;
            // 
            // checkBox_Resident
            // 
            this.checkBox_Resident.AutoSize = true;
            this.checkBox_Resident.Location = new System.Drawing.Point(491, 463);
            this.checkBox_Resident.Name = "checkBox_Resident";
            this.checkBox_Resident.Size = new System.Drawing.Size(75, 17);
            this.checkBox_Resident.TabIndex = 2;
            this.checkBox_Resident.Text = "Мешканці";
            this.checkBox_Resident.UseVisualStyleBackColor = true;
            // 
            // checkBox_Inventory
            // 
            this.checkBox_Inventory.AutoSize = true;
            this.checkBox_Inventory.Location = new System.Drawing.Point(592, 463);
            this.checkBox_Inventory.Name = "checkBox_Inventory";
            this.checkBox_Inventory.Size = new System.Drawing.Size(70, 17);
            this.checkBox_Inventory.TabIndex = 3;
            this.checkBox_Inventory.Text = "Інвентар";
            this.checkBox_Inventory.UseVisualStyleBackColor = true;
            // 
            // checkBox_ElDevice
            // 
            this.checkBox_ElDevice.AutoSize = true;
            this.checkBox_ElDevice.Location = new System.Drawing.Point(691, 463);
            this.checkBox_ElDevice.Name = "checkBox_ElDevice";
            this.checkBox_ElDevice.Size = new System.Drawing.Size(113, 17);
            this.checkBox_ElDevice.TabIndex = 4;
            this.checkBox_ElDevice.Text = "Електро прилади";
            this.checkBox_ElDevice.UseVisualStyleBackColor = true;
            // 
            // checkBox_Payment
            // 
            this.checkBox_Payment.AutoSize = true;
            this.checkBox_Payment.Location = new System.Drawing.Point(845, 463);
            this.checkBox_Payment.Name = "checkBox_Payment";
            this.checkBox_Payment.Size = new System.Drawing.Size(63, 17);
            this.checkBox_Payment.TabIndex = 5;
            this.checkBox_Payment.Text = "Оплати";
            this.checkBox_Payment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оберіть що бажаєте переглянути:";
            // 
            // ViewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(920, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Payment);
            this.Controls.Add(this.checkBox_ElDevice);
            this.Controls.Add(this.checkBox_Inventory);
            this.Controls.Add(this.checkBox_Resident);
            this.Controls.Add(this.checkBox_Room);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDB";
            this.Text = "Перегляд бази даних";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class UpdateRoom_Form
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
            this.button_UpdateNewForm = new System.Windows.Forms.Button();
            this.textBox__UpdateRoomCost = new System.Windows.Forms.TextBox();
            this.label__UpdateRoomCost = new System.Windows.Forms.Label();
            this.label__UpdateRoomType = new System.Windows.Forms.Label();
            this.comboBox__UpdateRoomType = new System.Windows.Forms.ComboBox();
            this.textBox_UpdateRoomFloor = new System.Windows.Forms.TextBox();
            this.label_UpdateRoomFloor = new System.Windows.Forms.Label();
            this.label_UpdateRoomNumber = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.RoomTableAdapter();
            this.textBox_UpdateRoomNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_UpdateNewForm
            // 
            this.button_UpdateNewForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_UpdateNewForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_UpdateNewForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateNewForm.Location = new System.Drawing.Point(79, 382);
            this.button_UpdateNewForm.Name = "button_UpdateNewForm";
            this.button_UpdateNewForm.Size = new System.Drawing.Size(190, 33);
            this.button_UpdateNewForm.TabIndex = 21;
            this.button_UpdateNewForm.Text = "Оновити кімнату";
            this.button_UpdateNewForm.UseVisualStyleBackColor = false;
            this.button_UpdateNewForm.Click += new System.EventHandler(this.button_UpdateNewForm_Click);
            // 
            // textBox__UpdateRoomCost
            // 
            this.textBox__UpdateRoomCost.Location = new System.Drawing.Point(56, 296);
            this.textBox__UpdateRoomCost.Name = "textBox__UpdateRoomCost";
            this.textBox__UpdateRoomCost.Size = new System.Drawing.Size(239, 20);
            this.textBox__UpdateRoomCost.TabIndex = 18;
            // 
            // label__UpdateRoomCost
            // 
            this.label__UpdateRoomCost.AutoSize = true;
            this.label__UpdateRoomCost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label__UpdateRoomCost.Location = new System.Drawing.Point(56, 263);
            this.label__UpdateRoomCost.Name = "label__UpdateRoomCost";
            this.label__UpdateRoomCost.Size = new System.Drawing.Size(171, 17);
            this.label__UpdateRoomCost.TabIndex = 17;
            this.label__UpdateRoomCost.Text = "Введіть нову ціну кімнати";
            // 
            // label__UpdateRoomType
            // 
            this.label__UpdateRoomType.AutoSize = true;
            this.label__UpdateRoomType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label__UpdateRoomType.Location = new System.Drawing.Point(53, 185);
            this.label__UpdateRoomType.Name = "label__UpdateRoomType";
            this.label__UpdateRoomType.Size = new System.Drawing.Size(136, 17);
            this.label__UpdateRoomType.TabIndex = 16;
            this.label__UpdateRoomType.Text = "Оберіть тип кімнати";
            // 
            // comboBox__UpdateRoomType
            // 
            this.comboBox__UpdateRoomType.FormattingEnabled = true;
            this.comboBox__UpdateRoomType.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.comboBox__UpdateRoomType.Location = new System.Drawing.Point(56, 225);
            this.comboBox__UpdateRoomType.Name = "comboBox__UpdateRoomType";
            this.comboBox__UpdateRoomType.Size = new System.Drawing.Size(239, 21);
            this.comboBox__UpdateRoomType.TabIndex = 15;
            // 
            // textBox_UpdateRoomFloor
            // 
            this.textBox_UpdateRoomFloor.Location = new System.Drawing.Point(56, 140);
            this.textBox_UpdateRoomFloor.Name = "textBox_UpdateRoomFloor";
            this.textBox_UpdateRoomFloor.Size = new System.Drawing.Size(239, 20);
            this.textBox_UpdateRoomFloor.TabIndex = 14;
            // 
            // label_UpdateRoomFloor
            // 
            this.label_UpdateRoomFloor.AutoSize = true;
            this.label_UpdateRoomFloor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateRoomFloor.Location = new System.Drawing.Point(53, 103);
            this.label_UpdateRoomFloor.Name = "label_UpdateRoomFloor";
            this.label_UpdateRoomFloor.Size = new System.Drawing.Size(156, 17);
            this.label_UpdateRoomFloor.TabIndex = 13;
            this.label_UpdateRoomFloor.Text = "Введіть поверх кімнати";
            // 
            // label_UpdateRoomNumber
            // 
            this.label_UpdateRoomNumber.AutoSize = true;
            this.label_UpdateRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateRoomNumber.Location = new System.Drawing.Point(53, 28);
            this.label_UpdateRoomNumber.Name = "label_UpdateRoomNumber";
            this.label_UpdateRoomNumber.Size = new System.Drawing.Size(104, 17);
            this.label_UpdateRoomNumber.TabIndex = 12;
            this.label_UpdateRoomNumber.Text = "Номер кімнати";
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
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.bindingSource1;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_UpdateRoomNumber
            // 
            this.textBox_UpdateRoomNumber.Location = new System.Drawing.Point(56, 61);
            this.textBox_UpdateRoomNumber.Name = "textBox_UpdateRoomNumber";
            this.textBox_UpdateRoomNumber.ReadOnly = true;
            this.textBox_UpdateRoomNumber.Size = new System.Drawing.Size(239, 20);
            this.textBox_UpdateRoomNumber.TabIndex = 22;
            // 
            // UpdateRoom_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.textBox_UpdateRoomNumber);
            this.Controls.Add(this.button_UpdateNewForm);
            this.Controls.Add(this.textBox__UpdateRoomCost);
            this.Controls.Add(this.label__UpdateRoomCost);
            this.Controls.Add(this.label__UpdateRoomType);
            this.Controls.Add(this.comboBox__UpdateRoomType);
            this.Controls.Add(this.textBox_UpdateRoomFloor);
            this.Controls.Add(this.label_UpdateRoomFloor);
            this.Controls.Add(this.label_UpdateRoomNumber);
            this.Name = "UpdateRoom_Form";
            this.Text = "Оновлення кімнат";
            this.Load += new System.EventHandler(this.UpdateRoom_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_UpdateNewForm;
        private System.Windows.Forms.TextBox textBox__UpdateRoomCost;
        private System.Windows.Forms.Label label__UpdateRoomCost;
        private System.Windows.Forms.Label label__UpdateRoomType;
        private System.Windows.Forms.ComboBox comboBox__UpdateRoomType;
        private System.Windows.Forms.TextBox textBox_UpdateRoomFloor;
        private System.Windows.Forms.Label label_UpdateRoomFloor;
        private System.Windows.Forms.Label label_UpdateRoomNumber;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private CursovayaHostelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.TextBox textBox_UpdateRoomNumber;
    }
}
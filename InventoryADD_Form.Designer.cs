
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class InventoryADD_Form
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
            this.button_ADDInventory = new System.Windows.Forms.Button();
            this.textBox_ADDTypeFurniture = new System.Windows.Forms.TextBox();
            this.label_ADDTypeFurniture = new System.Windows.Forms.Label();
            this.comboBox_AddConditio = new System.Windows.Forms.ComboBox();
            this.label_AddConditio = new System.Windows.Forms.Label();
            this.label_InventRoom = new System.Windows.Forms.Label();
            this.comboBox_InventRoom = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ADDInventory
            // 
            this.button_ADDInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_ADDInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_ADDInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADDInventory.Location = new System.Drawing.Point(61, 365);
            this.button_ADDInventory.Name = "button_ADDInventory";
            this.button_ADDInventory.Size = new System.Drawing.Size(165, 39);
            this.button_ADDInventory.TabIndex = 4;
            this.button_ADDInventory.Text = "Додати";
            this.button_ADDInventory.UseVisualStyleBackColor = false;
            this.button_ADDInventory.Click += new System.EventHandler(this.button_ADDInventory_Click);
            // 
            // textBox_ADDTypeFurniture
            // 
            this.textBox_ADDTypeFurniture.Location = new System.Drawing.Point(38, 67);
            this.textBox_ADDTypeFurniture.Name = "textBox_ADDTypeFurniture";
            this.textBox_ADDTypeFurniture.Size = new System.Drawing.Size(220, 20);
            this.textBox_ADDTypeFurniture.TabIndex = 8;
            // 
            // label_ADDTypeFurniture
            // 
            this.label_ADDTypeFurniture.AutoSize = true;
            this.label_ADDTypeFurniture.Location = new System.Drawing.Point(35, 34);
            this.label_ADDTypeFurniture.Name = "label_ADDTypeFurniture";
            this.label_ADDTypeFurniture.Size = new System.Drawing.Size(102, 13);
            this.label_ADDTypeFurniture.TabIndex = 7;
            this.label_ADDTypeFurniture.Text = "Введіть тип мебелі";
            // 
            // comboBox_AddConditio
            // 
            this.comboBox_AddConditio.FormattingEnabled = true;
            this.comboBox_AddConditio.Items.AddRange(new object[] {
            "Нове",
            "Гарне",
            "Добре",
            "Нормальне",
            "Пошкоджене",
            "Жахливе",
            "Старе"});
            this.comboBox_AddConditio.Location = new System.Drawing.Point(38, 155);
            this.comboBox_AddConditio.Name = "comboBox_AddConditio";
            this.comboBox_AddConditio.Size = new System.Drawing.Size(220, 21);
            this.comboBox_AddConditio.TabIndex = 9;
            // 
            // label_AddConditio
            // 
            this.label_AddConditio.AutoSize = true;
            this.label_AddConditio.Location = new System.Drawing.Point(35, 119);
            this.label_AddConditio.Name = "label_AddConditio";
            this.label_AddConditio.Size = new System.Drawing.Size(109, 13);
            this.label_AddConditio.TabIndex = 10;
            this.label_AddConditio.Text = "Оберіть стан мебелі";
            // 
            // label_InventRoom
            // 
            this.label_InventRoom.AutoSize = true;
            this.label_InventRoom.Location = new System.Drawing.Point(35, 214);
            this.label_InventRoom.Name = "label_InventRoom";
            this.label_InventRoom.Size = new System.Drawing.Size(123, 13);
            this.label_InventRoom.TabIndex = 12;
            this.label_InventRoom.Text = "Оберіть номер кімнати";
            // 
            // comboBox_InventRoom
            // 
            this.comboBox_InventRoom.DataSource = this.roomBindingSource;
            this.comboBox_InventRoom.DisplayMember = "Room_number";
            this.comboBox_InventRoom.FormattingEnabled = true;
            this.comboBox_InventRoom.Location = new System.Drawing.Point(38, 250);
            this.comboBox_InventRoom.Name = "comboBox_InventRoom";
            this.comboBox_InventRoom.Size = new System.Drawing.Size(220, 21);
            this.comboBox_InventRoom.TabIndex = 11;
            this.comboBox_InventRoom.ValueMember = "Room_number";
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
            // InventoryADD_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(303, 513);
            this.Controls.Add(this.label_InventRoom);
            this.Controls.Add(this.comboBox_InventRoom);
            this.Controls.Add(this.label_AddConditio);
            this.Controls.Add(this.comboBox_AddConditio);
            this.Controls.Add(this.textBox_ADDTypeFurniture);
            this.Controls.Add(this.label_ADDTypeFurniture);
            this.Controls.Add(this.button_ADDInventory);
            this.Name = "InventoryADD_Form";
            this.Text = "Додавання інвентарю";
            this.Load += new System.EventHandler(this.InventoryADD_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ADDInventory;
        private System.Windows.Forms.TextBox textBox_ADDTypeFurniture;
        private System.Windows.Forms.Label label_ADDTypeFurniture;
        private System.Windows.Forms.ComboBox comboBox_AddConditio;
        private System.Windows.Forms.Label label_AddConditio;
        private System.Windows.Forms.Label label_InventRoom;
        private System.Windows.Forms.ComboBox comboBox_InventRoom;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private CursovayaHostelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
    }
}
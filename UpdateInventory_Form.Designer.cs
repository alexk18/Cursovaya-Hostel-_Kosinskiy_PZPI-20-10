
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class UpdateInventory_Form
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
            this.label_UpdateInventRoom = new System.Windows.Forms.Label();
            this.comboBox_UpdateInventRoom = new System.Windows.Forms.ComboBox();
            this.label_UpdateAddConditio = new System.Windows.Forms.Label();
            this.comboBox_UpdateAddConditio = new System.Windows.Forms.ComboBox();
            this.textBox_UpdateADDTypeFurniture = new System.Windows.Forms.TextBox();
            this.label_UpdateADDTypeFurniture = new System.Windows.Forms.Label();
            this.button_UpdateADDInventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_UpdateFurnitureId = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.InventoryTableAdapter();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_UpdateInventRoom
            // 
            this.label_UpdateInventRoom.AutoSize = true;
            this.label_UpdateInventRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateInventRoom.Location = new System.Drawing.Point(98, 279);
            this.label_UpdateInventRoom.Name = "label_UpdateInventRoom";
            this.label_UpdateInventRoom.Size = new System.Drawing.Size(155, 17);
            this.label_UpdateInventRoom.TabIndex = 19;
            this.label_UpdateInventRoom.Text = "Оберіть номер кімнати";
            // 
            // comboBox_UpdateInventRoom
            // 
            this.comboBox_UpdateInventRoom.DataSource = this.roomBindingSource;
            this.comboBox_UpdateInventRoom.DisplayMember = "Room_number";
            this.comboBox_UpdateInventRoom.FormattingEnabled = true;
            this.comboBox_UpdateInventRoom.Location = new System.Drawing.Point(101, 315);
            this.comboBox_UpdateInventRoom.Name = "comboBox_UpdateInventRoom";
            this.comboBox_UpdateInventRoom.Size = new System.Drawing.Size(220, 21);
            this.comboBox_UpdateInventRoom.TabIndex = 18;
            this.comboBox_UpdateInventRoom.ValueMember = "Room_number";
            // 
            // label_UpdateAddConditio
            // 
            this.label_UpdateAddConditio.AutoSize = true;
            this.label_UpdateAddConditio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateAddConditio.Location = new System.Drawing.Point(98, 184);
            this.label_UpdateAddConditio.Name = "label_UpdateAddConditio";
            this.label_UpdateAddConditio.Size = new System.Drawing.Size(134, 17);
            this.label_UpdateAddConditio.TabIndex = 17;
            this.label_UpdateAddConditio.Text = "Оберіть стан мебелі";
            // 
            // comboBox_UpdateAddConditio
            // 
            this.comboBox_UpdateAddConditio.FormattingEnabled = true;
            this.comboBox_UpdateAddConditio.Items.AddRange(new object[] {
            "Нове",
            "Гарне",
            "Добре",
            "Нормальне",
            "Пошкоджене",
            "Жахливе",
            "Старе"});
            this.comboBox_UpdateAddConditio.Location = new System.Drawing.Point(101, 220);
            this.comboBox_UpdateAddConditio.Name = "comboBox_UpdateAddConditio";
            this.comboBox_UpdateAddConditio.Size = new System.Drawing.Size(220, 21);
            this.comboBox_UpdateAddConditio.TabIndex = 16;
            // 
            // textBox_UpdateADDTypeFurniture
            // 
            this.textBox_UpdateADDTypeFurniture.Location = new System.Drawing.Point(101, 132);
            this.textBox_UpdateADDTypeFurniture.Name = "textBox_UpdateADDTypeFurniture";
            this.textBox_UpdateADDTypeFurniture.Size = new System.Drawing.Size(220, 20);
            this.textBox_UpdateADDTypeFurniture.TabIndex = 15;
            // 
            // label_UpdateADDTypeFurniture
            // 
            this.label_UpdateADDTypeFurniture.AutoSize = true;
            this.label_UpdateADDTypeFurniture.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateADDTypeFurniture.Location = new System.Drawing.Point(98, 96);
            this.label_UpdateADDTypeFurniture.Name = "label_UpdateADDTypeFurniture";
            this.label_UpdateADDTypeFurniture.Size = new System.Drawing.Size(126, 17);
            this.label_UpdateADDTypeFurniture.TabIndex = 14;
            this.label_UpdateADDTypeFurniture.Text = "Введіть тип мебелі";
            // 
            // button_UpdateADDInventory
            // 
            this.button_UpdateADDInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_UpdateADDInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_UpdateADDInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateADDInventory.Location = new System.Drawing.Point(125, 409);
            this.button_UpdateADDInventory.Name = "button_UpdateADDInventory";
            this.button_UpdateADDInventory.Size = new System.Drawing.Size(165, 39);
            this.button_UpdateADDInventory.TabIndex = 13;
            this.button_UpdateADDInventory.Text = "Оновити";
            this.button_UpdateADDInventory.UseVisualStyleBackColor = false;
            this.button_UpdateADDInventory.Click += new System.EventHandler(this.button_UpdateADDInventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ідентифікатор мебелі";
            // 
            // textBox_UpdateFurnitureId
            // 
            this.textBox_UpdateFurnitureId.Location = new System.Drawing.Point(101, 56);
            this.textBox_UpdateFurnitureId.Name = "textBox_UpdateFurnitureId";
            this.textBox_UpdateFurnitureId.ReadOnly = true;
            this.textBox_UpdateFurnitureId.Size = new System.Drawing.Size(220, 20);
            this.textBox_UpdateFurnitureId.TabIndex = 21;
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
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.bindingSource1;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
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
            // UpdateInventory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(406, 534);
            this.Controls.Add(this.textBox_UpdateFurnitureId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_UpdateInventRoom);
            this.Controls.Add(this.comboBox_UpdateInventRoom);
            this.Controls.Add(this.label_UpdateAddConditio);
            this.Controls.Add(this.comboBox_UpdateAddConditio);
            this.Controls.Add(this.textBox_UpdateADDTypeFurniture);
            this.Controls.Add(this.label_UpdateADDTypeFurniture);
            this.Controls.Add(this.button_UpdateADDInventory);
            this.Name = "UpdateInventory_Form";
            this.Text = "Оновлення інвентарю";
            this.Load += new System.EventHandler(this.UpdateInventory_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UpdateInventRoom;
        private System.Windows.Forms.ComboBox comboBox_UpdateInventRoom;
        private System.Windows.Forms.Label label_UpdateAddConditio;
        private System.Windows.Forms.ComboBox comboBox_UpdateAddConditio;
        private System.Windows.Forms.TextBox textBox_UpdateADDTypeFurniture;
        private System.Windows.Forms.Label label_UpdateADDTypeFurniture;
        private System.Windows.Forms.Button button_UpdateADDInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UpdateFurnitureId;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private CursovayaHostelDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private CursovayaHostelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
    }
}
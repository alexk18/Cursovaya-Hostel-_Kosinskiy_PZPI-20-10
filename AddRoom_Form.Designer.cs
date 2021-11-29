
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class AddRoom_Form
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
            this.textBox_AddRoomNumber = new System.Windows.Forms.TextBox();
            this.label_AddRoomNumber = new System.Windows.Forms.Label();
            this.label_AddRoomFloor = new System.Windows.Forms.Label();
            this.textBox_AddRoomFloor = new System.Windows.Forms.TextBox();
            this.comboBox__AddRoomType = new System.Windows.Forms.ComboBox();
            this.label__AddRoomType = new System.Windows.Forms.Label();
            this.label__AddRoomCost = new System.Windows.Forms.Label();
            this.textBox__AddRoomCost = new System.Windows.Forms.TextBox();
            this.label__AddRoomHostle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.hostelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.HostelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_AddRoomNumber
            // 
            this.textBox_AddRoomNumber.Location = new System.Drawing.Point(34, 75);
            this.textBox_AddRoomNumber.Name = "textBox_AddRoomNumber";
            this.textBox_AddRoomNumber.Size = new System.Drawing.Size(239, 20);
            this.textBox_AddRoomNumber.TabIndex = 0;
            // 
            // label_AddRoomNumber
            // 
            this.label_AddRoomNumber.AutoSize = true;
            this.label_AddRoomNumber.Location = new System.Drawing.Point(34, 56);
            this.label_AddRoomNumber.Name = "label_AddRoomNumber";
            this.label_AddRoomNumber.Size = new System.Drawing.Size(152, 13);
            this.label_AddRoomNumber.TabIndex = 1;
            this.label_AddRoomNumber.Text = "Введіть номер нової кімнати";
            // 
            // label_AddRoomFloor
            // 
            this.label_AddRoomFloor.AutoSize = true;
            this.label_AddRoomFloor.Location = new System.Drawing.Point(34, 117);
            this.label_AddRoomFloor.Name = "label_AddRoomFloor";
            this.label_AddRoomFloor.Size = new System.Drawing.Size(125, 13);
            this.label_AddRoomFloor.TabIndex = 2;
            this.label_AddRoomFloor.Text = "Введіть поверх кімнати";
            // 
            // textBox_AddRoomFloor
            // 
            this.textBox_AddRoomFloor.Location = new System.Drawing.Point(34, 153);
            this.textBox_AddRoomFloor.Name = "textBox_AddRoomFloor";
            this.textBox_AddRoomFloor.Size = new System.Drawing.Size(239, 20);
            this.textBox_AddRoomFloor.TabIndex = 3;
            // 
            // comboBox__AddRoomType
            // 
            this.comboBox__AddRoomType.FormattingEnabled = true;
            this.comboBox__AddRoomType.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.comboBox__AddRoomType.Location = new System.Drawing.Point(34, 218);
            this.comboBox__AddRoomType.Name = "comboBox__AddRoomType";
            this.comboBox__AddRoomType.Size = new System.Drawing.Size(239, 21);
            this.comboBox__AddRoomType.TabIndex = 4;
            // 
            // label__AddRoomType
            // 
            this.label__AddRoomType.AutoSize = true;
            this.label__AddRoomType.Location = new System.Drawing.Point(34, 199);
            this.label__AddRoomType.Name = "label__AddRoomType";
            this.label__AddRoomType.Size = new System.Drawing.Size(108, 13);
            this.label__AddRoomType.TabIndex = 5;
            this.label__AddRoomType.Text = "Оберіть тип кімнати";
            // 
            // label__AddRoomCost
            // 
            this.label__AddRoomCost.AutoSize = true;
            this.label__AddRoomCost.Location = new System.Drawing.Point(37, 277);
            this.label__AddRoomCost.Name = "label__AddRoomCost";
            this.label__AddRoomCost.Size = new System.Drawing.Size(109, 13);
            this.label__AddRoomCost.TabIndex = 6;
            this.label__AddRoomCost.Text = "Введіть ціну кімнати";
            // 
            // textBox__AddRoomCost
            // 
            this.textBox__AddRoomCost.Location = new System.Drawing.Point(34, 309);
            this.textBox__AddRoomCost.Name = "textBox__AddRoomCost";
            this.textBox__AddRoomCost.Size = new System.Drawing.Size(239, 20);
            this.textBox__AddRoomCost.TabIndex = 7;
            // 
            // label__AddRoomHostle
            // 
            this.label__AddRoomHostle.AutoSize = true;
            this.label__AddRoomHostle.Location = new System.Drawing.Point(40, 355);
            this.label__AddRoomHostle.Name = "label__AddRoomHostle";
            this.label__AddRoomHostle.Size = new System.Drawing.Size(107, 13);
            this.label__AddRoomHostle.TabIndex = 8;
            this.label__AddRoomHostle.Text = "Оберіть гуртожиток";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.hostelBindingSource;
            this.comboBox1.DisplayMember = "Id_Hostel";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Id_Hostel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Додати кімнату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // hostelBindingSource
            // 
            this.hostelBindingSource.DataMember = "Hostel";
            this.hostelBindingSource.DataSource = this.bindingSource1;
            // 
            // hostelTableAdapter
            // 
            this.hostelTableAdapter.ClearBeforeFill = true;
            // 
            // AddRoom_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label__AddRoomHostle);
            this.Controls.Add(this.textBox__AddRoomCost);
            this.Controls.Add(this.label__AddRoomCost);
            this.Controls.Add(this.label__AddRoomType);
            this.Controls.Add(this.comboBox__AddRoomType);
            this.Controls.Add(this.textBox_AddRoomFloor);
            this.Controls.Add(this.label_AddRoomFloor);
            this.Controls.Add(this.label_AddRoomNumber);
            this.Controls.Add(this.textBox_AddRoomNumber);
            this.Name = "AddRoom_Form";
            this.Text = "Додавання кімнати";
            this.Load += new System.EventHandler(this.AddRoom_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AddRoomNumber;
        private System.Windows.Forms.Label label_AddRoomNumber;
        private System.Windows.Forms.Label label_AddRoomFloor;
        private System.Windows.Forms.TextBox textBox_AddRoomFloor;
        private System.Windows.Forms.ComboBox comboBox__AddRoomType;
        private System.Windows.Forms.Label label__AddRoomType;
        private System.Windows.Forms.Label label__AddRoomCost;
        private System.Windows.Forms.TextBox textBox__AddRoomCost;
        private System.Windows.Forms.Label label__AddRoomHostle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource hostelBindingSource;
        private CursovayaHostelDataSetTableAdapters.HostelTableAdapter hostelTableAdapter;
    }
}
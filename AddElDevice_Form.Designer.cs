
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class AddElDevice_Form
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
            this.button_ADDElDevice = new System.Windows.Forms.Button();
            this.label_ElDeviceID = new System.Windows.Forms.Label();
            this.textBox_ElDeviceID = new System.Windows.Forms.TextBox();
            this.label_ELDeviceName = new System.Windows.Forms.Label();
            this.textBox_ELDeviceName = new System.Windows.Forms.TextBox();
            this.label_ElPower = new System.Windows.Forms.Label();
            this.textBox_ElPower = new System.Windows.Forms.TextBox();
            this.label_ElCoef = new System.Windows.Forms.Label();
            this.textBox_ElCoef = new System.Windows.Forms.TextBox();
            this.label_ELDStud = new System.Windows.Forms.Label();
            this.comboBox_ELDStud = new System.Windows.Forms.ComboBox();
            this.residentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.ResidentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ADDElDevice
            // 
            this.button_ADDElDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_ADDElDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_ADDElDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADDElDevice.Location = new System.Drawing.Point(96, 485);
            this.button_ADDElDevice.Name = "button_ADDElDevice";
            this.button_ADDElDevice.Size = new System.Drawing.Size(165, 39);
            this.button_ADDElDevice.TabIndex = 5;
            this.button_ADDElDevice.Text = "Додати прилад";
            this.button_ADDElDevice.UseVisualStyleBackColor = false;
            this.button_ADDElDevice.Click += new System.EventHandler(this.button_ADDElDevice_Click);
            // 
            // label_ElDeviceID
            // 
            this.label_ElDeviceID.AutoSize = true;
            this.label_ElDeviceID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ElDeviceID.Location = new System.Drawing.Point(51, 36);
            this.label_ElDeviceID.Name = "label_ElDeviceID";
            this.label_ElDeviceID.Size = new System.Drawing.Size(151, 17);
            this.label_ElDeviceID.TabIndex = 6;
            this.label_ElDeviceID.Text = "Ідентифікатор девайсу";
            // 
            // textBox_ElDeviceID
            // 
            this.textBox_ElDeviceID.Location = new System.Drawing.Point(54, 67);
            this.textBox_ElDeviceID.Name = "textBox_ElDeviceID";
            this.textBox_ElDeviceID.Size = new System.Drawing.Size(257, 20);
            this.textBox_ElDeviceID.TabIndex = 7;
            // 
            // label_ELDeviceName
            // 
            this.label_ELDeviceName.AutoSize = true;
            this.label_ELDeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ELDeviceName.Location = new System.Drawing.Point(54, 109);
            this.label_ELDeviceName.Name = "label_ELDeviceName";
            this.label_ELDeviceName.Size = new System.Drawing.Size(86, 17);
            this.label_ELDeviceName.TabIndex = 8;
            this.label_ELDeviceName.Text = "Ім\'я девайсу";
            // 
            // textBox_ELDeviceName
            // 
            this.textBox_ELDeviceName.Location = new System.Drawing.Point(54, 147);
            this.textBox_ELDeviceName.Name = "textBox_ELDeviceName";
            this.textBox_ELDeviceName.Size = new System.Drawing.Size(257, 20);
            this.textBox_ELDeviceName.TabIndex = 9;
            // 
            // label_ElPower
            // 
            this.label_ElPower.AutoSize = true;
            this.label_ElPower.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ElPower.Location = new System.Drawing.Point(54, 191);
            this.label_ElPower.Name = "label_ElPower";
            this.label_ElPower.Size = new System.Drawing.Size(133, 17);
            this.label_ElPower.TabIndex = 10;
            this.label_ElPower.Text = "Потужність девайсу";
            // 
            // textBox_ElPower
            // 
            this.textBox_ElPower.Location = new System.Drawing.Point(54, 226);
            this.textBox_ElPower.Name = "textBox_ElPower";
            this.textBox_ElPower.Size = new System.Drawing.Size(257, 20);
            this.textBox_ElPower.TabIndex = 11;
            // 
            // label_ElCoef
            // 
            this.label_ElCoef.AutoSize = true;
            this.label_ElCoef.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ElCoef.Location = new System.Drawing.Point(54, 277);
            this.label_ElCoef.Name = "label_ElCoef";
            this.label_ElCoef.Size = new System.Drawing.Size(127, 17);
            this.label_ElCoef.TabIndex = 12;
            this.label_ElCoef.Text = "Коєфіцієнт девайсу";
            // 
            // textBox_ElCoef
            // 
            this.textBox_ElCoef.Location = new System.Drawing.Point(54, 316);
            this.textBox_ElCoef.Name = "textBox_ElCoef";
            this.textBox_ElCoef.Size = new System.Drawing.Size(257, 20);
            this.textBox_ElCoef.TabIndex = 13;
            // 
            // label_ELDStud
            // 
            this.label_ELDStud.AutoSize = true;
            this.label_ELDStud.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ELDStud.Location = new System.Drawing.Point(54, 377);
            this.label_ELDStud.Name = "label_ELDStud";
            this.label_ELDStud.Size = new System.Drawing.Size(113, 17);
            this.label_ELDStud.TabIndex = 14;
            this.label_ELDStud.Text = "Власник девайсу";
            // 
            // comboBox_ELDStud
            // 
            this.comboBox_ELDStud.DataSource = this.residentBindingSource1;
            this.comboBox_ELDStud.DisplayMember = "IdCodeStudent";
            this.comboBox_ELDStud.FormattingEnabled = true;
            this.comboBox_ELDStud.Location = new System.Drawing.Point(57, 412);
            this.comboBox_ELDStud.Name = "comboBox_ELDStud";
            this.comboBox_ELDStud.Size = new System.Drawing.Size(254, 21);
            this.comboBox_ELDStud.TabIndex = 15;
            this.comboBox_ELDStud.ValueMember = "IdCodeStudent";
            // 
            // residentBindingSource1
            // 
            this.residentBindingSource1.DataMember = "Resident";
            this.residentBindingSource1.DataSource = this.bindingSource1;
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
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.bindingSource1;
            // 
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // AddElDevice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(360, 569);
            this.Controls.Add(this.comboBox_ELDStud);
            this.Controls.Add(this.label_ELDStud);
            this.Controls.Add(this.textBox_ElCoef);
            this.Controls.Add(this.label_ElCoef);
            this.Controls.Add(this.textBox_ElPower);
            this.Controls.Add(this.label_ElPower);
            this.Controls.Add(this.textBox_ELDeviceName);
            this.Controls.Add(this.label_ELDeviceName);
            this.Controls.Add(this.textBox_ElDeviceID);
            this.Controls.Add(this.label_ElDeviceID);
            this.Controls.Add(this.button_ADDElDevice);
            this.Name = "AddElDevice_Form";
            this.Text = "Додавання електричних приладів";
            this.Load += new System.EventHandler(this.AddElDevice_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ADDElDevice;
        private System.Windows.Forms.Label label_ElDeviceID;
        private System.Windows.Forms.TextBox textBox_ElDeviceID;
        private System.Windows.Forms.Label label_ELDeviceName;
        private System.Windows.Forms.TextBox textBox_ELDeviceName;
        private System.Windows.Forms.Label label_ElPower;
        private System.Windows.Forms.TextBox textBox_ElPower;
        private System.Windows.Forms.Label label_ElCoef;
        private System.Windows.Forms.TextBox textBox_ElCoef;
        private System.Windows.Forms.Label label_ELDStud;
        private System.Windows.Forms.ComboBox comboBox_ELDStud;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private CursovayaHostelDataSetTableAdapters.ResidentTableAdapter residentTableAdapter;
        private System.Windows.Forms.BindingSource residentBindingSource1;
    }
}

namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class UpdateElDevice_Form
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
            this.comboBox_UpdateELDStud = new System.Windows.Forms.ComboBox();
            this.label_UpdateELDStud = new System.Windows.Forms.Label();
            this.textBox_UpdateElCoef = new System.Windows.Forms.TextBox();
            this.label_UpdateElCoef = new System.Windows.Forms.Label();
            this.textBox_UpdateElPower = new System.Windows.Forms.TextBox();
            this.label_UpdateElPower = new System.Windows.Forms.Label();
            this.textBox_UpdateELDeviceName = new System.Windows.Forms.TextBox();
            this.label_UpdateELDeviceName = new System.Windows.Forms.Label();
            this.textBox_UpdateElDeviceID = new System.Windows.Forms.TextBox();
            this.label_UpdateElDeviceID = new System.Windows.Forms.Label();
            this.button_UpdateADDElDevice = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSet = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSet();
            this.electricalDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electricalDevicesTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.ElectricalDevicesTableAdapter();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetTableAdapters.ResidentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricalDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_UpdateELDStud
            // 
            this.comboBox_UpdateELDStud.DataSource = this.residentBindingSource;
            this.comboBox_UpdateELDStud.DisplayMember = "IdCodeStudent";
            this.comboBox_UpdateELDStud.FormattingEnabled = true;
            this.comboBox_UpdateELDStud.Location = new System.Drawing.Point(31, 421);
            this.comboBox_UpdateELDStud.Name = "comboBox_UpdateELDStud";
            this.comboBox_UpdateELDStud.Size = new System.Drawing.Size(254, 21);
            this.comboBox_UpdateELDStud.TabIndex = 26;
            this.comboBox_UpdateELDStud.ValueMember = "IdCodeStudent";
            // 
            // label_UpdateELDStud
            // 
            this.label_UpdateELDStud.AutoSize = true;
            this.label_UpdateELDStud.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateELDStud.Location = new System.Drawing.Point(28, 386);
            this.label_UpdateELDStud.Name = "label_UpdateELDStud";
            this.label_UpdateELDStud.Size = new System.Drawing.Size(113, 17);
            this.label_UpdateELDStud.TabIndex = 25;
            this.label_UpdateELDStud.Text = "Власник девайсу";
            // 
            // textBox_UpdateElCoef
            // 
            this.textBox_UpdateElCoef.Location = new System.Drawing.Point(28, 325);
            this.textBox_UpdateElCoef.Name = "textBox_UpdateElCoef";
            this.textBox_UpdateElCoef.Size = new System.Drawing.Size(257, 20);
            this.textBox_UpdateElCoef.TabIndex = 24;
            // 
            // label_UpdateElCoef
            // 
            this.label_UpdateElCoef.AutoSize = true;
            this.label_UpdateElCoef.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateElCoef.Location = new System.Drawing.Point(28, 286);
            this.label_UpdateElCoef.Name = "label_UpdateElCoef";
            this.label_UpdateElCoef.Size = new System.Drawing.Size(127, 17);
            this.label_UpdateElCoef.TabIndex = 23;
            this.label_UpdateElCoef.Text = "Коєфіцієнт девайсу";
            // 
            // textBox_UpdateElPower
            // 
            this.textBox_UpdateElPower.Location = new System.Drawing.Point(28, 235);
            this.textBox_UpdateElPower.Name = "textBox_UpdateElPower";
            this.textBox_UpdateElPower.Size = new System.Drawing.Size(257, 20);
            this.textBox_UpdateElPower.TabIndex = 22;
            // 
            // label_UpdateElPower
            // 
            this.label_UpdateElPower.AutoSize = true;
            this.label_UpdateElPower.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateElPower.Location = new System.Drawing.Point(28, 200);
            this.label_UpdateElPower.Name = "label_UpdateElPower";
            this.label_UpdateElPower.Size = new System.Drawing.Size(133, 17);
            this.label_UpdateElPower.TabIndex = 21;
            this.label_UpdateElPower.Text = "Потужність девайсу";
            // 
            // textBox_UpdateELDeviceName
            // 
            this.textBox_UpdateELDeviceName.Location = new System.Drawing.Point(28, 156);
            this.textBox_UpdateELDeviceName.Name = "textBox_UpdateELDeviceName";
            this.textBox_UpdateELDeviceName.Size = new System.Drawing.Size(257, 20);
            this.textBox_UpdateELDeviceName.TabIndex = 20;
            // 
            // label_UpdateELDeviceName
            // 
            this.label_UpdateELDeviceName.AutoSize = true;
            this.label_UpdateELDeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateELDeviceName.Location = new System.Drawing.Point(28, 118);
            this.label_UpdateELDeviceName.Name = "label_UpdateELDeviceName";
            this.label_UpdateELDeviceName.Size = new System.Drawing.Size(86, 17);
            this.label_UpdateELDeviceName.TabIndex = 19;
            this.label_UpdateELDeviceName.Text = "Ім\'я девайсу";
            // 
            // textBox_UpdateElDeviceID
            // 
            this.textBox_UpdateElDeviceID.Location = new System.Drawing.Point(28, 76);
            this.textBox_UpdateElDeviceID.Name = "textBox_UpdateElDeviceID";
            this.textBox_UpdateElDeviceID.Size = new System.Drawing.Size(257, 20);
            this.textBox_UpdateElDeviceID.TabIndex = 18;
            // 
            // label_UpdateElDeviceID
            // 
            this.label_UpdateElDeviceID.AutoSize = true;
            this.label_UpdateElDeviceID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateElDeviceID.Location = new System.Drawing.Point(25, 45);
            this.label_UpdateElDeviceID.Name = "label_UpdateElDeviceID";
            this.label_UpdateElDeviceID.Size = new System.Drawing.Size(151, 17);
            this.label_UpdateElDeviceID.TabIndex = 17;
            this.label_UpdateElDeviceID.Text = "Ідентифікатор девайсу";
            // 
            // button_UpdateADDElDevice
            // 
            this.button_UpdateADDElDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_UpdateADDElDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_UpdateADDElDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateADDElDevice.Location = new System.Drawing.Point(70, 494);
            this.button_UpdateADDElDevice.Name = "button_UpdateADDElDevice";
            this.button_UpdateADDElDevice.Size = new System.Drawing.Size(165, 39);
            this.button_UpdateADDElDevice.TabIndex = 16;
            this.button_UpdateADDElDevice.Text = "Оновити прилад";
            this.button_UpdateADDElDevice.UseVisualStyleBackColor = false;
            this.button_UpdateADDElDevice.Click += new System.EventHandler(this.button_UpdateADDElDevice_Click);
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
            // electricalDevicesBindingSource
            // 
            this.electricalDevicesBindingSource.DataMember = "ElectricalDevices";
            this.electricalDevicesBindingSource.DataSource = this.bindingSource1;
            // 
            // electricalDevicesTableAdapter
            // 
            this.electricalDevicesTableAdapter.ClearBeforeFill = true;
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
            // UpdateElDevice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(319, 559);
            this.Controls.Add(this.comboBox_UpdateELDStud);
            this.Controls.Add(this.label_UpdateELDStud);
            this.Controls.Add(this.textBox_UpdateElCoef);
            this.Controls.Add(this.label_UpdateElCoef);
            this.Controls.Add(this.textBox_UpdateElPower);
            this.Controls.Add(this.label_UpdateElPower);
            this.Controls.Add(this.textBox_UpdateELDeviceName);
            this.Controls.Add(this.label_UpdateELDeviceName);
            this.Controls.Add(this.textBox_UpdateElDeviceID);
            this.Controls.Add(this.label_UpdateElDeviceID);
            this.Controls.Add(this.button_UpdateADDElDevice);
            this.Name = "UpdateElDevice_Form";
            this.Text = "Оновлення єлектроприладів";
            this.Load += new System.EventHandler(this.UpdateElDevice_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricalDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_UpdateELDStud;
        private System.Windows.Forms.Label label_UpdateELDStud;
        private System.Windows.Forms.TextBox textBox_UpdateElCoef;
        private System.Windows.Forms.Label label_UpdateElCoef;
        private System.Windows.Forms.TextBox textBox_UpdateElPower;
        private System.Windows.Forms.Label label_UpdateElPower;
        private System.Windows.Forms.TextBox textBox_UpdateELDeviceName;
        private System.Windows.Forms.Label label_UpdateELDeviceName;
        private System.Windows.Forms.TextBox textBox_UpdateElDeviceID;
        private System.Windows.Forms.Label label_UpdateElDeviceID;
        private System.Windows.Forms.Button button_UpdateADDElDevice;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSet cursovayaHostelDataSet;
        private System.Windows.Forms.BindingSource electricalDevicesBindingSource;
        private CursovayaHostelDataSetTableAdapters.ElectricalDevicesTableAdapter electricalDevicesTableAdapter;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private CursovayaHostelDataSetTableAdapters.ResidentTableAdapter residentTableAdapter;
    }
}
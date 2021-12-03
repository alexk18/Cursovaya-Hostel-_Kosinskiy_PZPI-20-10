
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class Update_Payment_Form
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
            this.button_Update = new System.Windows.Forms.Button();
            this.label_UpdatePaymentTime = new System.Windows.Forms.Label();
            this.dateTimePicker_UpdatePaymentTime = new System.Windows.Forms.DateTimePicker();
            this.textBox_UpdateSum = new System.Windows.Forms.TextBox();
            this.label_UpdateSum = new System.Windows.Forms.Label();
            this.comboBox_UpdateIdCodeStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursovayaHostelDataSetRequest = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetRequest();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetRequestTableAdapters.PaymentTableAdapter();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residentTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetRequestTableAdapters.ResidentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSetRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Location = new System.Drawing.Point(90, 445);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(214, 38);
            this.button_Update.TabIndex = 59;
            this.button_Update.Text = "Оновити";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_UpdatePaymentTime
            // 
            this.label_UpdatePaymentTime.AutoSize = true;
            this.label_UpdatePaymentTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdatePaymentTime.Location = new System.Drawing.Point(87, 232);
            this.label_UpdatePaymentTime.Name = "label_UpdatePaymentTime";
            this.label_UpdatePaymentTime.Size = new System.Drawing.Size(93, 17);
            this.label_UpdatePaymentTime.TabIndex = 74;
            this.label_UpdatePaymentTime.Text = "Дата платежу";
            // 
            // dateTimePicker_UpdatePaymentTime
            // 
            this.dateTimePicker_UpdatePaymentTime.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_UpdatePaymentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_UpdatePaymentTime.Location = new System.Drawing.Point(90, 261);
            this.dateTimePicker_UpdatePaymentTime.Name = "dateTimePicker_UpdatePaymentTime";
            this.dateTimePicker_UpdatePaymentTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_UpdatePaymentTime.TabIndex = 73;
            this.dateTimePicker_UpdatePaymentTime.Value = new System.DateTime(2021, 11, 17, 0, 0, 0, 0);
            // 
            // textBox_UpdateSum
            // 
            this.textBox_UpdateSum.Location = new System.Drawing.Point(84, 194);
            this.textBox_UpdateSum.Name = "textBox_UpdateSum";
            this.textBox_UpdateSum.Size = new System.Drawing.Size(206, 20);
            this.textBox_UpdateSum.TabIndex = 68;
            // 
            // label_UpdateSum
            // 
            this.label_UpdateSum.AutoSize = true;
            this.label_UpdateSum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UpdateSum.Location = new System.Drawing.Point(87, 160);
            this.label_UpdateSum.Name = "label_UpdateSum";
            this.label_UpdateSum.Size = new System.Drawing.Size(40, 17);
            this.label_UpdateSum.TabIndex = 67;
            this.label_UpdateSum.Text = "Сума";
            // 
            // comboBox_UpdateIdCodeStudent
            // 
            this.comboBox_UpdateIdCodeStudent.DataSource = this.residentBindingSource;
            this.comboBox_UpdateIdCodeStudent.DisplayMember = "IdCodeStudent";
            this.comboBox_UpdateIdCodeStudent.FormattingEnabled = true;
            this.comboBox_UpdateIdCodeStudent.Location = new System.Drawing.Point(90, 329);
            this.comboBox_UpdateIdCodeStudent.Name = "comboBox_UpdateIdCodeStudent";
            this.comboBox_UpdateIdCodeStudent.Size = new System.Drawing.Size(200, 21);
            this.comboBox_UpdateIdCodeStudent.TabIndex = 75;
            this.comboBox_UpdateIdCodeStudent.ValueMember = "IdCodeStudent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Айді студенту";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Айді операції";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cursovayaHostelDataSetRequest;
            this.bindingSource1.Position = 0;
            // 
            // cursovayaHostelDataSetRequest
            // 
            this.cursovayaHostelDataSetRequest.DataSetName = "CursovayaHostelDataSetRequest";
            this.cursovayaHostelDataSetRequest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.bindingSource1;
            // 
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // Update_Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(359, 526);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_UpdateIdCodeStudent);
            this.Controls.Add(this.label_UpdatePaymentTime);
            this.Controls.Add(this.dateTimePicker_UpdatePaymentTime);
            this.Controls.Add(this.textBox_UpdateSum);
            this.Controls.Add(this.label_UpdateSum);
            this.Controls.Add(this.button_Update);
            this.Name = "Update_Payment_Form";
            this.Text = "Оновити платежі";
            this.Load += new System.EventHandler(this.Update_Payment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSetRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_UpdatePaymentTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_UpdatePaymentTime;
        private System.Windows.Forms.TextBox textBox_UpdateSum;
        private System.Windows.Forms.Label label_UpdateSum;
        private System.Windows.Forms.ComboBox comboBox_UpdateIdCodeStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CursovayaHostelDataSetRequest cursovayaHostelDataSetRequest;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private CursovayaHostelDataSetRequestTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private CursovayaHostelDataSetRequestTableAdapters.ResidentTableAdapter residentTableAdapter;
    }
}
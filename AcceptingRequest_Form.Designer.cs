
namespace Cursovaya_Hostel__Kosinskiy_PZPI_20_10
{
    partial class AcceptingRequest_Form
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
            this.cursovayaHostelDataSetRequest = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetRequest();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableAdapter = new Cursovaya_Hostel__Kosinskiy_PZPI_20_10.CursovayaHostelDataSetRequestTableAdapters.RequestTableAdapter();
            this.iDRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCodeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Accepting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSetRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRequestDataGridViewTextBoxColumn,
            this.numberroomDataGridViewTextBoxColumn,
            this.sumrequestDataGridViewTextBoxColumn,
            this.numberTransactionDataGridViewTextBoxColumn,
            this.idCodeStudentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(898, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // cursovayaHostelDataSetRequest
            // 
            this.cursovayaHostelDataSetRequest.DataSetName = "CursovayaHostelDataSetRequest";
            this.cursovayaHostelDataSetRequest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.cursovayaHostelDataSetRequest;
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // iDRequestDataGridViewTextBoxColumn
            // 
            this.iDRequestDataGridViewTextBoxColumn.DataPropertyName = "ID_Request";
            this.iDRequestDataGridViewTextBoxColumn.HeaderText = "ID_Request";
            this.iDRequestDataGridViewTextBoxColumn.Name = "iDRequestDataGridViewTextBoxColumn";
            this.iDRequestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberroomDataGridViewTextBoxColumn
            // 
            this.numberroomDataGridViewTextBoxColumn.DataPropertyName = "Number_room";
            this.numberroomDataGridViewTextBoxColumn.HeaderText = "Number_room";
            this.numberroomDataGridViewTextBoxColumn.Name = "numberroomDataGridViewTextBoxColumn";
            // 
            // sumrequestDataGridViewTextBoxColumn
            // 
            this.sumrequestDataGridViewTextBoxColumn.DataPropertyName = "Sum_request";
            this.sumrequestDataGridViewTextBoxColumn.HeaderText = "Sum_request";
            this.sumrequestDataGridViewTextBoxColumn.Name = "sumrequestDataGridViewTextBoxColumn";
            // 
            // numberTransactionDataGridViewTextBoxColumn
            // 
            this.numberTransactionDataGridViewTextBoxColumn.DataPropertyName = "NumberTransaction";
            this.numberTransactionDataGridViewTextBoxColumn.HeaderText = "NumberTransaction";
            this.numberTransactionDataGridViewTextBoxColumn.Name = "numberTransactionDataGridViewTextBoxColumn";
            // 
            // idCodeStudentDataGridViewTextBoxColumn
            // 
            this.idCodeStudentDataGridViewTextBoxColumn.DataPropertyName = "IdCodeStudent";
            this.idCodeStudentDataGridViewTextBoxColumn.HeaderText = "IdCodeStudent";
            this.idCodeStudentDataGridViewTextBoxColumn.Name = "idCodeStudentDataGridViewTextBoxColumn";
            // 
            // button_Accepting
            // 
            this.button_Accepting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(125)))), ((int)(((byte)(121)))));
            this.button_Accepting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Accepting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(121)))), ((int)(((byte)(239)))));
            this.button_Accepting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Accepting.Location = new System.Drawing.Point(380, 448);
            this.button_Accepting.Name = "button_Accepting";
            this.button_Accepting.Size = new System.Drawing.Size(225, 36);
            this.button_Accepting.TabIndex = 24;
            this.button_Accepting.Text = "Підтвердити заявку";
            this.button_Accepting.UseVisualStyleBackColor = false;
            this.button_Accepting.Click += new System.EventHandler(this.button_Accepting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Оберіть номер заяви";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.requestBindingSource1;
            this.comboBox1.DisplayMember = "ID_Request";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "ID_Request";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cursovayaHostelDataSetRequest;
            this.bindingSource1.Position = 0;
            // 
            // requestBindingSource1
            // 
            this.requestBindingSource1.DataMember = "Request";
            this.requestBindingSource1.DataSource = this.bindingSource1;
            // 
            // AcceptingRequest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(934, 550);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Accepting);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AcceptingRequest_Form";
            this.Text = "Прийняття заяв";
            this.Load += new System.EventHandler(this.AcceptingRequest_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursovayaHostelDataSetRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CursovayaHostelDataSetRequest cursovayaHostelDataSetRequest;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private CursovayaHostelDataSetRequestTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumrequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodeStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Accepting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource requestBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
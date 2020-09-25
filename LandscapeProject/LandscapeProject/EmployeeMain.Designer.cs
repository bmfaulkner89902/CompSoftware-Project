namespace LandscapeProject
{
    partial class EmployeeMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAssign = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchSchedule = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoWorkerID = new System.Windows.Forms.RadioButton();
            this.rdoJobID = new System.Windows.Forms.RadioButton();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column5,
            this.Address,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(22, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 210);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "JobID";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Customer";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Job Type";
            this.Column5.Name = "Column5";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Job Length";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Job Start";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(520, 25);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(227, 37);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign Jobs/Request Materials";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Customer Info/Payment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Job,
            this.fd,
            this.Column8,
            this.Column9});
            this.dataGridView2.Location = new System.Drawing.Point(22, 516);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(747, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Worker Schedule";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Worker ID";
            this.Column7.Name = "Column7";
            // 
            // Job
            // 
            this.Job.HeaderText = "JobiD";
            this.Job.Name = "Job";
            // 
            // fd
            // 
            this.fd.HeaderText = "Hours Worked This week";
            this.fd.Name = "fd";
            // 
            // btnSearchSchedule
            // 
            this.btnSearchSchedule.Location = new System.Drawing.Point(520, 476);
            this.btnSearchSchedule.Name = "btnSearchSchedule";
            this.btnSearchSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSchedule.TabIndex = 12;
            this.btnSearchSchedule.Text = "Search";
            this.btnSearchSchedule.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 476);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoJobID);
            this.groupBox1.Controls.Add(this.rdoWorkerID);
            this.groupBox1.Location = new System.Drawing.Point(285, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For";
            // 
            // rdoWorkerID
            // 
            this.rdoWorkerID.AutoSize = true;
            this.rdoWorkerID.Location = new System.Drawing.Point(6, 22);
            this.rdoWorkerID.Name = "rdoWorkerID";
            this.rdoWorkerID.Size = new System.Drawing.Size(85, 21);
            this.rdoWorkerID.TabIndex = 0;
            this.rdoWorkerID.TabStop = true;
            this.rdoWorkerID.Text = "WorkerID";
            this.rdoWorkerID.UseVisualStyleBackColor = true;
            // 
            // rdoJobID
            // 
            this.rdoJobID.AutoSize = true;
            this.rdoJobID.Location = new System.Drawing.Point(6, 43);
            this.rdoJobID.Name = "rdoJobID";
            this.rdoJobID.Size = new System.Drawing.Size(62, 21);
            this.rdoJobID.TabIndex = 1;
            this.rdoJobID.TabStop = true;
            this.rdoJobID.Text = "JobID";
            this.rdoJobID.UseVisualStyleBackColor = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Clock-in";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Clock-Out";
            this.Column9.Name = "Column9";
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn fd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchSchedule;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoJobID;
        private System.Windows.Forms.RadioButton rdoWorkerID;
    }
}


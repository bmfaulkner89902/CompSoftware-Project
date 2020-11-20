namespace LandscapeProject
{
    partial class UserMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxJobAddress = new System.Windows.Forms.TextBox();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvJobInfo = new System.Windows.Forms.DataGridView();
            this.lblTest = new System.Windows.Forms.Label();
            this.tbxJobType = new System.Windows.Forms.TextBox();
            this.dtpBegDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dgvCustJobWorkerInfo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustJobWorkerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(-19, -104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 304);
            this.label1.TabIndex = 2;
            this.label1.Text = "LandscaperZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(488, 197);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(101, 46);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request Job";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Beginning Date:";
            // 
            // tbxJobAddress
            // 
            this.tbxJobAddress.Location = new System.Drawing.Point(238, 180);
            this.tbxJobAddress.Name = "tbxJobAddress";
            this.tbxJobAddress.Size = new System.Drawing.Size(193, 20);
            this.tbxJobAddress.TabIndex = 12;
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserGreeting.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserGreeting.Location = new System.Drawing.Point(23, 93);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(566, 42);
            this.lblUserGreeting.TabIndex = 14;
            this.lblUserGreeting.Text = " ";
            this.lblUserGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(486, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Request a job below: (Guests, request job will redirect you to new user page)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvJobInfo
            // 
            this.dgvJobInfo.AllowUserToAddRows = false;
            this.dgvJobInfo.AllowUserToDeleteRows = false;
            this.dgvJobInfo.AllowUserToResizeRows = false;
            this.dgvJobInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJobInfo.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobInfo.Location = new System.Drawing.Point(23, 308);
            this.dgvJobInfo.MultiSelect = false;
            this.dgvJobInfo.Name = "dgvJobInfo";
            this.dgvJobInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobInfo.Size = new System.Drawing.Size(566, 160);
            this.dgvJobInfo.TabIndex = 16;
            this.dgvJobInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJobInfo_RowHeaderMouseClick);
            // 
            // lblTest
            // 
            this.lblTest.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(23, 251);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(566, 37);
            this.lblTest.TabIndex = 19;
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxJobType
            // 
            this.tbxJobType.Location = new System.Drawing.Point(23, 180);
            this.tbxJobType.Name = "tbxJobType";
            this.tbxJobType.Size = new System.Drawing.Size(193, 20);
            this.tbxJobType.TabIndex = 20;
            // 
            // dtpBegDate
            // 
            this.dtpBegDate.Location = new System.Drawing.Point(23, 223);
            this.dtpBegDate.Name = "dtpBegDate";
            this.dtpBegDate.Size = new System.Drawing.Size(193, 20);
            this.dtpBegDate.TabIndex = 23;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(238, 223);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(193, 20);
            this.dtpEndDate.TabIndex = 24;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(107, 471);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(400, 29);
            this.lblOutput.TabIndex = 25;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(488, 520);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 46);
            this.btnLogOut.TabIndex = 26;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dgvCustJobWorkerInfo
            // 
            this.dgvCustJobWorkerInfo.AllowUserToAddRows = false;
            this.dgvCustJobWorkerInfo.AllowUserToDeleteRows = false;
            this.dgvCustJobWorkerInfo.AllowUserToResizeRows = false;
            this.dgvCustJobWorkerInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustJobWorkerInfo.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustJobWorkerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustJobWorkerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustJobWorkerInfo.Location = new System.Drawing.Point(23, 503);
            this.dgvCustJobWorkerInfo.MultiSelect = false;
            this.dgvCustJobWorkerInfo.Name = "dgvCustJobWorkerInfo";
            this.dgvCustJobWorkerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustJobWorkerInfo.Size = new System.Drawing.Size(415, 64);
            this.dgvCustJobWorkerInfo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(459, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "View payment due and find your Landscaperz contact info by clicking on a job";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(615, 578);
            this.Controls.Add(this.dgvCustJobWorkerInfo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBegDate);
            this.Controls.Add(this.tbxJobType);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.dgvJobInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUserGreeting);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxJobAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMain";
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustJobWorkerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxJobAddress;
        private System.Windows.Forms.Label lblUserGreeting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvJobInfo;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox tbxJobType;
        private System.Windows.Forms.DateTimePicker dtpBegDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvCustJobWorkerInfo;
        private System.Windows.Forms.Label label6;
    }
}
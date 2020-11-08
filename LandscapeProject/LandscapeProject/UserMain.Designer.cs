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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBegDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbxJobAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvJobInfo = new System.Windows.Forms.DataGridView();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.tbxJobType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 112);
            this.label1.TabIndex = 2;
            this.label1.Text = "LandscaperZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(398, 252);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(94, 35);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request Job";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Beginning Date:";
            // 
            // dtpBegDate
            // 
            this.dtpBegDate.Location = new System.Drawing.Point(31, 230);
            this.dtpBegDate.Name = "dtpBegDate";
            this.dtpBegDate.Size = new System.Drawing.Size(165, 20);
            this.dtpBegDate.TabIndex = 10;
            this.dtpBegDate.Value = new System.DateTime(2020, 10, 8, 0, 0, 0, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(250, 230);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(144, 20);
            this.dtpEndDate.TabIndex = 11;
            this.dtpEndDate.Value = new System.DateTime(2020, 10, 8, 0, 0, 0, 0);
            // 
            // tbxJobAddress
            // 
            this.tbxJobAddress.Location = new System.Drawing.Point(250, 170);
            this.tbxJobAddress.Name = "tbxJobAddress";
            this.tbxJobAddress.Size = new System.Drawing.Size(193, 20);
            this.tbxJobAddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(471, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Make a payment or contact a Contractor: (Select current job then click button)";
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserGreeting.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserGreeting.Location = new System.Drawing.Point(9, 95);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(456, 42);
            this.lblUserGreeting.TabIndex = 14;
            this.lblUserGreeting.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(456, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Request a job below: (Guests, request job will redirect you to new user page)";
            // 
            // dgvJobInfo
            // 
            this.dgvJobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobInfo.Location = new System.Drawing.Point(12, 310);
            this.dgvJobInfo.Name = "dgvJobInfo";
            this.dgvJobInfo.Size = new System.Drawing.Size(480, 210);
            this.dgvJobInfo.TabIndex = 16;
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(73, 526);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(106, 34);
            this.btnContact.TabIndex = 17;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(313, 526);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(106, 34);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Make Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTest
            // 
            this.lblTest.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(15, 253);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(379, 37);
            this.lblTest.TabIndex = 19;
            // 
            // tbxJobType
            // 
            this.tbxJobType.Location = new System.Drawing.Point(31, 170);
            this.tbxJobType.Name = "tbxJobType";
            this.tbxJobType.Size = new System.Drawing.Size(193, 20);
            this.tbxJobType.TabIndex = 20;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(504, 562);
            this.Controls.Add(this.tbxJobType);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.dgvJobInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUserGreeting);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxJobAddress);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBegDate);
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
        private System.Windows.Forms.DateTimePicker dtpBegDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox tbxJobAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserGreeting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvJobInfo;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox tbxJobType;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
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
            this.hlpCustomer = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustJobWorkerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(-16, -110);
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
            this.label2.Location = new System.Drawing.Point(234, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(454, 168);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(135, 75);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request Job";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Beginning Date:";
            // 
            // tbxJobAddress
            // 
            this.tbxJobAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxJobAddress.Location = new System.Drawing.Point(238, 168);
            this.tbxJobAddress.Name = "tbxJobAddress";
            this.tbxJobAddress.Size = new System.Drawing.Size(193, 26);
            this.tbxJobAddress.TabIndex = 12;
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserGreeting.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserGreeting.Location = new System.Drawing.Point(23, 84);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(566, 42);
            this.lblUserGreeting.TabIndex = 14;
            this.lblUserGreeting.Text = " ";
            this.lblUserGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(615, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Request a job below: (Guests, request job will redirect you to new user page)";
            // 
            // dgvJobInfo
            // 
            this.dgvJobInfo.AllowUserToAddRows = false;
            this.dgvJobInfo.AllowUserToDeleteRows = false;
            this.dgvJobInfo.AllowUserToResizeRows = false;
            this.dgvJobInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJobInfo.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobInfo.Location = new System.Drawing.Point(23, 329);
            this.dgvJobInfo.MultiSelect = false;
            this.dgvJobInfo.Name = "dgvJobInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJobInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvJobInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobInfo.Size = new System.Drawing.Size(574, 218);
            this.dgvJobInfo.TabIndex = 16;
            this.dgvJobInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJobInfo_RowHeaderMouseClick);
            // 
            // lblTest
            // 
            this.lblTest.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(23, 252);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(566, 53);
            this.lblTest.TabIndex = 19;
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxJobType
            // 
            this.tbxJobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxJobType.Location = new System.Drawing.Point(23, 168);
            this.tbxJobType.Name = "tbxJobType";
            this.tbxJobType.Size = new System.Drawing.Size(193, 26);
            this.tbxJobType.TabIndex = 20;
            // 
            // dtpBegDate
            // 
            this.dtpBegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBegDate.Location = new System.Drawing.Point(23, 217);
            this.dtpBegDate.Name = "dtpBegDate";
            this.dtpBegDate.Size = new System.Drawing.Size(193, 26);
            this.dtpBegDate.TabIndex = 23;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(238, 217);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(193, 26);
            this.dtpEndDate.TabIndex = 24;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(31, 550);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(400, 25);
            this.lblOutput.TabIndex = 25;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(454, 579);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 75);
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
            this.dgvCustJobWorkerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustJobWorkerInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustJobWorkerInfo.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustJobWorkerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustJobWorkerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustJobWorkerInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustJobWorkerInfo.Location = new System.Drawing.Point(23, 578);
            this.dgvCustJobWorkerInfo.MultiSelect = false;
            this.dgvCustJobWorkerInfo.Name = "dgvCustJobWorkerInfo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustJobWorkerInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustJobWorkerInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustJobWorkerInfo.Size = new System.Drawing.Size(416, 75);
            this.dgvCustJobWorkerInfo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(616, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "View payment due and find your Landscaperz contact info by clicking on a row\r\n";
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(623, 665);
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
            this.HelpButton = true;
            this.hlpCustomer.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMain";
            this.hlpCustomer.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMain";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.UserMain_HelpButtonClicked);
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
        private System.Windows.Forms.HelpProvider hlpCustomer;
    }
}
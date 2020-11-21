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
            this.dgvEmpJobInfo = new System.Windows.Forms.DataGridView();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.dgvEmpWorkerSch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchSchedule = new System.Windows.Forms.Button();
            this.txtSearchSchedule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpJobInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpWorkerSch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job Information";
            // 
            // dgvEmpJobInfo
            // 
            this.dgvEmpJobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpJobInfo.Location = new System.Drawing.Point(22, 163);
            this.dgvEmpJobInfo.Name = "dgvEmpJobInfo";
            this.dgvEmpJobInfo.Size = new System.Drawing.Size(747, 210);
            this.dgvEmpJobInfo.TabIndex = 4;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(278, 24);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(227, 37);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign Jobs/Request Materials";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(22, 24);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(222, 37);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Customer Info/Payment";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // dgvEmpWorkerSch
            // 
            this.dgvEmpWorkerSch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpWorkerSch.Location = new System.Drawing.Point(22, 516);
            this.dgvEmpWorkerSch.Name = "dgvEmpWorkerSch";
            this.dgvEmpWorkerSch.Size = new System.Drawing.Size(747, 150);
            this.dgvEmpWorkerSch.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Worker Schedule";
            // 
            // btnSearchSchedule
            // 
            this.btnSearchSchedule.Location = new System.Drawing.Point(690, 475);
            this.btnSearchSchedule.Name = "btnSearchSchedule";
            this.btnSearchSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSchedule.TabIndex = 12;
            this.btnSearchSchedule.Text = "Search";
            this.btnSearchSchedule.UseVisualStyleBackColor = true;
            this.btnSearchSchedule.Click += new System.EventHandler(this.btnSearchSchedule_Click);
            // 
            // txtSearchSchedule
            // 
            this.txtSearchSchedule.Location = new System.Drawing.Point(584, 475);
            this.txtSearchSchedule.Name = "txtSearchSchedule";
            this.txtSearchSchedule.Size = new System.Drawing.Size(100, 23);
            this.txtSearchSchedule.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "WorkerID: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(694, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 731);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchSchedule);
            this.Controls.Add(this.btnSearchSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpWorkerSch);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmpJobInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMain";
            this.Load += new System.EventHandler(this.EmployeeMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpJobInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpWorkerSch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEmpJobInfo;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.DataGridView dgvEmpWorkerSch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchSchedule;
        private System.Windows.Forms.TextBox txtSearchSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
    }
}


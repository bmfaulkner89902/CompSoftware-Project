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
            this.hlpEmployees = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpJobInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpWorkerSch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(275, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job Information";
            // 
            // dgvEmpJobInfo
            // 
            this.dgvEmpJobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpJobInfo.Location = new System.Drawing.Point(25, 204);
            this.dgvEmpJobInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmpJobInfo.Name = "dgvEmpJobInfo";
            this.dgvEmpJobInfo.Size = new System.Drawing.Size(840, 262);
            this.dgvEmpJobInfo.TabIndex = 4;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(337, 30);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(255, 46);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign Jobs/Request Materials";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(25, 30);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(250, 46);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Customer Info";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // dgvEmpWorkerSch
            // 
            this.dgvEmpWorkerSch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpWorkerSch.Location = new System.Drawing.Point(25, 645);
            this.dgvEmpWorkerSch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmpWorkerSch.Name = "dgvEmpWorkerSch";
            this.dgvEmpWorkerSch.Size = new System.Drawing.Size(840, 188);
            this.dgvEmpWorkerSch.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(263, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Worker Schedule";
            // 
            // btnSearchSchedule
            // 
            this.btnSearchSchedule.Location = new System.Drawing.Point(776, 594);
            this.btnSearchSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchSchedule.Name = "btnSearchSchedule";
            this.btnSearchSchedule.Size = new System.Drawing.Size(84, 29);
            this.btnSearchSchedule.TabIndex = 12;
            this.btnSearchSchedule.Text = "Search";
            this.btnSearchSchedule.UseVisualStyleBackColor = true;
            this.btnSearchSchedule.Click += new System.EventHandler(this.btnSearchSchedule_Click);
            // 
            // txtSearchSchedule
            // 
            this.txtSearchSchedule.Location = new System.Drawing.Point(657, 594);
            this.txtSearchSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSchedule.Name = "txtSearchSchedule";
            this.txtSearchSchedule.Size = new System.Drawing.Size(112, 26);
            this.txtSearchSchedule.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "WorkerID: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(781, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 35);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(915, 914);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMain";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.EmployeeMain_HelpButtonClicked);
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
        private System.Windows.Forms.HelpProvider hlpEmployees;
    }
}


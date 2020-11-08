namespace LandscapeProject
{
    partial class EmployeeCustomer
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
            this.dgvEmpCustomer = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.rdoSearchName = new System.Windows.Forms.RadioButton();
            this.rdoSearchID = new System.Windows.Forms.RadioButton();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpCustomer)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Contact/Payment Info";
            // 
            // dgvEmpCustomer
            // 
            this.dgvEmpCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpCustomer.Location = new System.Drawing.Point(60, 152);
            this.dgvEmpCustomer.Name = "dgvEmpCustomer";
            this.dgvEmpCustomer.Size = new System.Drawing.Size(642, 199);
            this.dgvEmpCustomer.TabIndex = 1;

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(294, 113);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search for Customer";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(418, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.rdoSearchName);
            this.grpSearch.Controls.Add(this.rdoSearchID);
            this.grpSearch.Location = new System.Drawing.Point(60, 76);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(110, 70);
            this.grpSearch.TabIndex = 6;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search by";
            // 
            // rdoSearchName
            // 
            this.rdoSearchName.AutoSize = true;
            this.rdoSearchName.Location = new System.Drawing.Point(9, 41);
            this.rdoSearchName.Name = "rdoSearchName";
            this.rdoSearchName.Size = new System.Drawing.Size(100, 17);
            this.rdoSearchName.TabIndex = 1;
            this.rdoSearchName.Text = "Customer Name";
            this.rdoSearchName.UseVisualStyleBackColor = true;
            // 
            // rdoSearchID
            // 
            this.rdoSearchID.AutoSize = true;
            this.rdoSearchID.Checked = true;
            this.rdoSearchID.Location = new System.Drawing.Point(9, 19);
            this.rdoSearchID.Name = "rdoSearchID";
            this.rdoSearchID.Size = new System.Drawing.Size(83, 17);
            this.rdoSearchID.TabIndex = 0;
            this.rdoSearchID.TabStop = true;
            this.rdoSearchID.Text = "Customer ID";
            this.rdoSearchID.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(279, 391);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(145, 23);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Return to Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // EmployeeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvEmpCustomer);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EmployeeCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpCustomer)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rdoSearchName;
        private System.Windows.Forms.RadioButton rdoSearchID;
        private System.Windows.Forms.Button btnMainMenu;
    }
}
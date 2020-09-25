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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.rdoSearchID = new System.Windows.Forms.RadioButton();
            this.rdoSearchName = new System.Windows.Forms.RadioButton();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(60, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CustomerID";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer Name";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Addres";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Customer Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Payment Due";
            this.Column6.Name = "Column6";
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
            this.label2.Location = new System.Drawing.Point(185, 119);
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
            // rdoSearchID
            // 
            this.rdoSearchID.AutoSize = true;
            this.rdoSearchID.Location = new System.Drawing.Point(9, 19);
            this.rdoSearchID.Name = "rdoSearchID";
            this.rdoSearchID.Size = new System.Drawing.Size(83, 17);
            this.rdoSearchID.TabIndex = 0;
            this.rdoSearchID.TabStop = true;
            this.rdoSearchID.Text = "Customer ID";
            this.rdoSearchID.UseVisualStyleBackColor = true;
            // 
            // rdoSearchName
            // 
            this.rdoSearchName.AutoSize = true;
            this.rdoSearchName.Location = new System.Drawing.Point(6, 39);
            this.rdoSearchName.Name = "rdoSearchName";
            this.rdoSearchName.Size = new System.Drawing.Size(100, 17);
            this.rdoSearchName.TabIndex = 1;
            this.rdoSearchName.TabStop = true;
            this.rdoSearchName.Text = "Customer Name";
            this.rdoSearchName.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(279, 391);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(145, 23);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Return to Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // EmployeeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeCustomer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rdoSearchName;
        private System.Windows.Forms.RadioButton rdoSearchID;
        private System.Windows.Forms.Button btnMainMenu;
    }
}
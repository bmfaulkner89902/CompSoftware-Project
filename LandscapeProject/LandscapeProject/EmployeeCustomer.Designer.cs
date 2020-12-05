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
            this.hlpEmpCustomer = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpCustomer)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(217, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Contact Info";
            // 
            // dgvEmpCustomer
            // 
            this.dgvEmpCustomer.AllowUserToAddRows = false;
            this.dgvEmpCustomer.AllowUserToDeleteRows = false;
            this.dgvEmpCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpCustomer.Location = new System.Drawing.Point(98, 234);
            this.dgvEmpCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEmpCustomer.Name = "dgvEmpCustomer";
            this.dgvEmpCustomer.Size = new System.Drawing.Size(743, 306);
            this.dgvEmpCustomer.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(441, 174);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search for Customer";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(627, 171);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Tan;
            this.grpSearch.Controls.Add(this.rdoSearchName);
            this.grpSearch.Controls.Add(this.rdoSearchID);
            this.grpSearch.Location = new System.Drawing.Point(98, 116);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearch.Size = new System.Drawing.Size(165, 108);
            this.grpSearch.TabIndex = 6;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search by";
            // 
            // rdoSearchName
            // 
            this.rdoSearchName.AutoSize = true;
            this.rdoSearchName.Location = new System.Drawing.Point(14, 63);
            this.rdoSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoSearchName.Name = "rdoSearchName";
            this.rdoSearchName.Size = new System.Drawing.Size(142, 24);
            this.rdoSearchName.TabIndex = 1;
            this.rdoSearchName.Text = "Customer Name";
            this.rdoSearchName.UseVisualStyleBackColor = true;
            // 
            // rdoSearchID
            // 
            this.rdoSearchID.AutoSize = true;
            this.rdoSearchID.Checked = true;
            this.rdoSearchID.Location = new System.Drawing.Point(14, 29);
            this.rdoSearchID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoSearchID.Name = "rdoSearchID";
            this.rdoSearchID.Size = new System.Drawing.Size(117, 24);
            this.rdoSearchID.TabIndex = 0;
            this.rdoSearchID.TabStop = true;
            this.rdoSearchID.Text = "Customer ID";
            this.rdoSearchID.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(378, 602);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(218, 35);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Return to Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // EmployeeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(938, 692);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvEmpCustomer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeCustomer";
            this.Text = "Customer Contact";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.EmployeeCustomer_HelpButtonClicked);
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
        private System.Windows.Forms.HelpProvider hlpEmpCustomer;
    }
}
namespace LandscapeProject
{
    partial class LoginScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.linkUserRecover = new System.Windows.Forms.LinkLabel();
            this.btnCustSubmit = new System.Windows.Forms.Button();
            this.tbxCustPassword = new System.Windows.Forms.TextBox();
            this.tbxCustUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.linkEmpRecover = new System.Windows.Forms.LinkLabel();
            this.btnEmpSubmit = new System.Windows.Forms.Button();
            this.tbxEmpPassword = new System.Windows.Forms.TextBox();
            this.tbxEmpUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabOwner = new System.Windows.Forms.TabPage();
            this.linkOwnRecover = new System.Windows.Forms.LinkLabel();
            this.btnOwnerSubmit = new System.Windows.Forms.Button();
            this.tbxOwnPassword = new System.Windows.Forms.TextBox();
            this.tbxOwnUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tabOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tabOwner);
            this.tabControl1.Location = new System.Drawing.Point(-2, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 222);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.LightGreen;
            this.tabUser.Controls.Add(this.btnCreate);
            this.tabUser.Controls.Add(this.btnGuest);
            this.tabUser.Controls.Add(this.linkUserRecover);
            this.tabUser.Controls.Add(this.btnCustSubmit);
            this.tabUser.Controls.Add(this.tbxCustPassword);
            this.tabUser.Controls.Add(this.tbxCustUsername);
            this.tabUser.Controls.Add(this.label3);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(369, 196);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(219, 141);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(75, 141);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(75, 23);
            this.btnGuest.TabIndex = 6;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // linkUserRecover
            // 
            this.linkUserRecover.AutoSize = true;
            this.linkUserRecover.Location = new System.Drawing.Point(129, 87);
            this.linkUserRecover.Name = "linkUserRecover";
            this.linkUserRecover.Size = new System.Drawing.Size(146, 13);
            this.linkUserRecover.TabIndex = 5;
            this.linkUserRecover.TabStop = true;
            this.linkUserRecover.Text = "Forgot username or password";
            this.linkUserRecover.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUserRecover_LinkClicked);
            // 
            // btnCustSubmit
            // 
            this.btnCustSubmit.Location = new System.Drawing.Point(148, 170);
            this.btnCustSubmit.Name = "btnCustSubmit";
            this.btnCustSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCustSubmit.TabIndex = 4;
            this.btnCustSubmit.Text = "Submit";
            this.btnCustSubmit.UseVisualStyleBackColor = true;
            this.btnCustSubmit.Click += new System.EventHandler(this.btnCustSubmit_Click);
            // 
            // tbxCustPassword
            // 
            this.tbxCustPassword.Location = new System.Drawing.Point(175, 64);
            this.tbxCustPassword.Name = "tbxCustPassword";
            this.tbxCustPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxCustPassword.TabIndex = 3;
            // 
            // tbxCustUsername
            // 
            this.tbxCustUsername.Location = new System.Drawing.Point(175, 14);
            this.tbxCustUsername.Name = "tbxCustUsername";
            this.tbxCustUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxCustUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.Color.LightGreen;
            this.tabEmployee.Controls.Add(this.linkEmpRecover);
            this.tabEmployee.Controls.Add(this.btnEmpSubmit);
            this.tabEmployee.Controls.Add(this.tbxEmpPassword);
            this.tabEmployee.Controls.Add(this.tbxEmpUsername);
            this.tabEmployee.Controls.Add(this.label4);
            this.tabEmployee.Controls.Add(this.label5);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(369, 196);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee";
            // 
            // linkEmpRecover
            // 
            this.linkEmpRecover.AutoSize = true;
            this.linkEmpRecover.Location = new System.Drawing.Point(129, 87);
            this.linkEmpRecover.Name = "linkEmpRecover";
            this.linkEmpRecover.Size = new System.Drawing.Size(146, 13);
            this.linkEmpRecover.TabIndex = 11;
            this.linkEmpRecover.TabStop = true;
            this.linkEmpRecover.Text = "Forgot username or password";
            // 
            // btnEmpSubmit
            // 
            this.btnEmpSubmit.Location = new System.Drawing.Point(148, 170);
            this.btnEmpSubmit.Name = "btnEmpSubmit";
            this.btnEmpSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnEmpSubmit.TabIndex = 10;
            this.btnEmpSubmit.Text = "Submit";
            this.btnEmpSubmit.UseVisualStyleBackColor = true;
            this.btnEmpSubmit.Click += new System.EventHandler(this.btnEmpSubmit_Click);
            // 
            // tbxEmpPassword
            // 
            this.tbxEmpPassword.Location = new System.Drawing.Point(175, 64);
            this.tbxEmpPassword.Name = "tbxEmpPassword";
            this.tbxEmpPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxEmpPassword.TabIndex = 9;
            // 
            // tbxEmpUsername
            // 
            this.tbxEmpUsername.Location = new System.Drawing.Point(175, 14);
            this.tbxEmpUsername.Name = "tbxEmpUsername";
            this.tbxEmpUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxEmpUsername.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username:";
            // 
            // tabOwner
            // 
            this.tabOwner.BackColor = System.Drawing.Color.LightGreen;
            this.tabOwner.Controls.Add(this.linkOwnRecover);
            this.tabOwner.Controls.Add(this.btnOwnerSubmit);
            this.tabOwner.Controls.Add(this.tbxOwnPassword);
            this.tabOwner.Controls.Add(this.tbxOwnUsername);
            this.tabOwner.Controls.Add(this.label6);
            this.tabOwner.Controls.Add(this.label7);
            this.tabOwner.Location = new System.Drawing.Point(4, 22);
            this.tabOwner.Name = "tabOwner";
            this.tabOwner.Size = new System.Drawing.Size(369, 196);
            this.tabOwner.TabIndex = 2;
            this.tabOwner.Text = "Owner";
            // 
            // linkOwnRecover
            // 
            this.linkOwnRecover.AutoSize = true;
            this.linkOwnRecover.Location = new System.Drawing.Point(129, 87);
            this.linkOwnRecover.Name = "linkOwnRecover";
            this.linkOwnRecover.Size = new System.Drawing.Size(146, 13);
            this.linkOwnRecover.TabIndex = 11;
            this.linkOwnRecover.TabStop = true;
            this.linkOwnRecover.Text = "Forgot username or password";
            // 
            // btnOwnerSubmit
            // 
            this.btnOwnerSubmit.Location = new System.Drawing.Point(148, 170);
            this.btnOwnerSubmit.Name = "btnOwnerSubmit";
            this.btnOwnerSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnOwnerSubmit.TabIndex = 10;
            this.btnOwnerSubmit.Text = "Submit";
            this.btnOwnerSubmit.UseVisualStyleBackColor = true;
            this.btnOwnerSubmit.Click += new System.EventHandler(this.btnOwnerSubmit_Click);
            // 
            // tbxOwnPassword
            // 
            this.tbxOwnPassword.Location = new System.Drawing.Point(175, 64);
            this.tbxOwnPassword.Name = "tbxOwnPassword";
            this.tbxOwnPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxOwnPassword.TabIndex = 9;
            // 
            // tbxOwnUsername
            // 
            this.tbxOwnUsername.Location = new System.Drawing.Point(175, 14);
            this.tbxOwnUsername.Name = "tbxOwnUsername";
            this.tbxOwnUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxOwnUsername.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Username:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "LandscaperZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(372, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.tabControl1.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.tabOwner.ResumeLayout(false);
            this.tabOwner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.LinkLabel linkUserRecover;
        private System.Windows.Forms.Button btnCustSubmit;
        private System.Windows.Forms.TextBox tbxCustPassword;
        private System.Windows.Forms.TextBox tbxCustUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.LinkLabel linkEmpRecover;
        private System.Windows.Forms.Button btnEmpSubmit;
        private System.Windows.Forms.TextBox tbxEmpPassword;
        private System.Windows.Forms.TextBox tbxEmpUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabOwner;
        private System.Windows.Forms.LinkLabel linkOwnRecover;
        private System.Windows.Forms.Button btnOwnerSubmit;
        private System.Windows.Forms.TextBox tbxOwnPassword;
        private System.Windows.Forms.TextBox tbxOwnUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}
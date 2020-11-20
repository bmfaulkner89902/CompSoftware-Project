namespace LandscapeProject
{
    partial class EmpOwnerAccountRecovery
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmailOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(114, 32);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(114, 6);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your E-mail";
            // 
            // lblEmailOutput
            // 
            this.lblEmailOutput.AutoSize = true;
            this.lblEmailOutput.Location = new System.Drawing.Point(12, 73);
            this.lblEmailOutput.Name = "lblEmailOutput";
            this.lblEmailOutput.Size = new System.Drawing.Size(0, 13);
            this.lblEmailOutput.TabIndex = 6;
            // 
            // EmpOwnerAccountRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 112);
            this.Controls.Add(this.lblEmailOutput);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label1);
            this.Name = "EmpOwnerAccountRecovery";
            this.Text = "Employee Account Recovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmailOutput;
    }
}
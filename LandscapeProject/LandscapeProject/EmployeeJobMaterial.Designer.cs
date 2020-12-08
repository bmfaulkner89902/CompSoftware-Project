﻿namespace LandscapeProject
{
    partial class EmployeeJobMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeJobMaterial));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmWorkers = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgCreateCustomer = new System.Windows.Forms.TabPage();
            this.btnConfirmCustomer = new System.Windows.Forms.Button();
            this.txtCustZip = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustLast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustFirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpgCreateJob = new System.Windows.Forms.TabPage();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.btnConfirmJob = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtJobSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJobType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJobAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJobCustId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpgAssignMaterials = new System.Windows.Forms.TabPage();
            this.txtMaterialDate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnConfirmMaterials = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaterialJobID = new System.Windows.Forms.TextBox();
            this.txtMaterialPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaterialUnit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tpgAssignWorkers = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWorkerJobID = new System.Windows.Forms.TextBox();
            this.cklAssignWorkers = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.hlpEmpJob = new System.Windows.Forms.HelpProvider();
            this.tabControl1.SuspendLayout();
            this.tpgCreateCustomer.SuspendLayout();
            this.tpgCreateJob.SuspendLayout();
            this.tpgAssignMaterials.SuspendLayout();
            this.tpgAssignWorkers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(531, 602);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Exit/Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmWorkers
            // 
            this.btnConfirmWorkers.Location = new System.Drawing.Point(471, 326);
            this.btnConfirmWorkers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmWorkers.Name = "btnConfirmWorkers";
            this.btnConfirmWorkers.Size = new System.Drawing.Size(138, 35);
            this.btnConfirmWorkers.TabIndex = 18;
            this.btnConfirmWorkers.Text = "Confirm";
            this.btnConfirmWorkers.UseVisualStyleBackColor = true;
            this.btnConfirmWorkers.Click += new System.EventHandler(this.btnConfirmWorkers_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgCreateCustomer);
            this.tabControl1.Controls.Add(this.tpgCreateJob);
            this.tabControl1.Controls.Add(this.tpgAssignMaterials);
            this.tabControl1.Controls.Add(this.tpgAssignWorkers);
            this.tabControl1.Location = new System.Drawing.Point(35, 128);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 437);
            this.tabControl1.TabIndex = 33;
            // 
            // tpgCreateCustomer
            // 
            this.tpgCreateCustomer.BackColor = System.Drawing.Color.Tan;
            this.tpgCreateCustomer.Controls.Add(this.btnConfirmCustomer);
            this.tpgCreateCustomer.Controls.Add(this.txtCustZip);
            this.tpgCreateCustomer.Controls.Add(this.label18);
            this.tpgCreateCustomer.Controls.Add(this.txtCustCity);
            this.tpgCreateCustomer.Controls.Add(this.label16);
            this.tpgCreateCustomer.Controls.Add(this.txtCustEmail);
            this.tpgCreateCustomer.Controls.Add(this.label17);
            this.tpgCreateCustomer.Controls.Add(this.txtCustAddress);
            this.tpgCreateCustomer.Controls.Add(this.label15);
            this.tpgCreateCustomer.Controls.Add(this.txtCustLast);
            this.tpgCreateCustomer.Controls.Add(this.label4);
            this.tpgCreateCustomer.Controls.Add(this.txtCustFirst);
            this.tpgCreateCustomer.Controls.Add(this.label3);
            this.tpgCreateCustomer.Location = new System.Drawing.Point(4, 29);
            this.tpgCreateCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgCreateCustomer.Name = "tpgCreateCustomer";
            this.tpgCreateCustomer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgCreateCustomer.Size = new System.Drawing.Size(1080, 404);
            this.tpgCreateCustomer.TabIndex = 0;
            this.tpgCreateCustomer.Text = "Create Customer";
            // 
            // btnConfirmCustomer
            // 
            this.btnConfirmCustomer.Location = new System.Drawing.Point(471, 334);
            this.btnConfirmCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmCustomer.Name = "btnConfirmCustomer";
            this.btnConfirmCustomer.Size = new System.Drawing.Size(138, 35);
            this.btnConfirmCustomer.TabIndex = 53;
            this.btnConfirmCustomer.Text = "Confirm";
            this.btnConfirmCustomer.UseVisualStyleBackColor = true;
            this.btnConfirmCustomer.Click += new System.EventHandler(this.btnConfirmCustomer_Click);
            // 
            // txtCustZip
            // 
            this.txtCustZip.Location = new System.Drawing.Point(891, 254);
            this.txtCustZip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustZip.Name = "txtCustZip";
            this.txtCustZip.Size = new System.Drawing.Size(130, 26);
            this.txtCustZip.TabIndex = 52;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(802, 258);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 51;
            this.label18.Text = "ZipCode";
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(573, 254);
            this.txtCustCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(184, 26);
            this.txtCustCity.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(519, 258);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 20);
            this.label16.TabIndex = 47;
            this.label16.Text = "City";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(154, 254);
            this.txtCustEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(318, 26);
            this.txtCustEmail.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 258);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "Customer Email";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(201, 157);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(820, 26);
            this.txtCustAddress.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 162);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "Customer Address";
            // 
            // txtCustLast
            // 
            this.txtCustLast.Location = new System.Drawing.Point(687, 66);
            this.txtCustLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustLast.Name = "txtCustLast";
            this.txtCustLast.Size = new System.Drawing.Size(184, 26);
            this.txtCustLast.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Customer Last Name";
            // 
            // txtCustFirst
            // 
            this.txtCustFirst.Location = new System.Drawing.Point(315, 66);
            this.txtCustFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustFirst.Name = "txtCustFirst";
            this.txtCustFirst.Size = new System.Drawing.Size(184, 26);
            this.txtCustFirst.TabIndex = 40;
            this.txtCustFirst.TextChanged += new System.EventHandler(this.txtCustFirst_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Customer First Name";
            // 
            // tpgCreateJob
            // 
            this.tpgCreateJob.BackColor = System.Drawing.Color.Tan;
            this.tpgCreateJob.Controls.Add(this.txtPrice);
            this.tpgCreateJob.Controls.Add(this.price);
            this.tpgCreateJob.Controls.Add(this.btnConfirmJob);
            this.tpgCreateJob.Controls.Add(this.label14);
            this.tpgCreateJob.Controls.Add(this.txtEnd);
            this.tpgCreateJob.Controls.Add(this.txtJobSize);
            this.tpgCreateJob.Controls.Add(this.label6);
            this.tpgCreateJob.Controls.Add(this.txtStart);
            this.tpgCreateJob.Controls.Add(this.label7);
            this.tpgCreateJob.Controls.Add(this.txtJobType);
            this.tpgCreateJob.Controls.Add(this.label8);
            this.tpgCreateJob.Controls.Add(this.txtJobAddress);
            this.tpgCreateJob.Controls.Add(this.label5);
            this.tpgCreateJob.Controls.Add(this.txtJobCustId);
            this.tpgCreateJob.Controls.Add(this.label2);
            this.tpgCreateJob.Location = new System.Drawing.Point(4, 29);
            this.tpgCreateJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgCreateJob.Name = "tpgCreateJob";
            this.tpgCreateJob.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgCreateJob.Size = new System.Drawing.Size(1080, 404);
            this.tpgCreateJob.TabIndex = 1;
            this.tpgCreateJob.Text = "Create Job";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(864, 269);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 26);
            this.txtPrice.TabIndex = 51;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(790, 275);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 20);
            this.price.TabIndex = 50;
            this.price.Text = "Price";
            // 
            // btnConfirmJob
            // 
            this.btnConfirmJob.Location = new System.Drawing.Point(471, 337);
            this.btnConfirmJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmJob.Name = "btnConfirmJob";
            this.btnConfirmJob.Size = new System.Drawing.Size(138, 35);
            this.btnConfirmJob.TabIndex = 49;
            this.btnConfirmJob.Text = "Confirm";
            this.btnConfirmJob.UseVisualStyleBackColor = true;
            this.btnConfirmJob.Click += new System.EventHandler(this.btnConfirmJob_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 274);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Job End Date";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(480, 269);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(184, 26);
            this.txtEnd.TabIndex = 47;
            // 
            // txtJobSize
            // 
            this.txtJobSize.Location = new System.Drawing.Point(864, 217);
            this.txtJobSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJobSize.Name = "txtJobSize";
            this.txtJobSize.Size = new System.Drawing.Size(114, 26);
            this.txtJobSize.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Size ";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(480, 217);
            this.txtStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(184, 26);
            this.txtStart.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Job Start Date";
            // 
            // txtJobType
            // 
            this.txtJobType.Location = new System.Drawing.Point(142, 223);
            this.txtJobType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJobType.Name = "txtJobType";
            this.txtJobType.Size = new System.Drawing.Size(148, 26);
            this.txtJobType.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Job Type";
            // 
            // txtJobAddress
            // 
            this.txtJobAddress.Location = new System.Drawing.Point(182, 126);
            this.txtJobAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJobAddress.Name = "txtJobAddress";
            this.txtJobAddress.Size = new System.Drawing.Size(883, 26);
            this.txtJobAddress.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Job Address";
            // 
            // txtJobCustId
            // 
            this.txtJobCustId.Location = new System.Drawing.Point(462, 46);
            this.txtJobCustId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJobCustId.Name = "txtJobCustId";
            this.txtJobCustId.Size = new System.Drawing.Size(148, 26);
            this.txtJobCustId.TabIndex = 34;
            this.txtJobCustId.TextChanged += new System.EventHandler(this.txtJobCustId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "CustomerID";
            // 
            // tpgAssignMaterials
            // 
            this.tpgAssignMaterials.BackColor = System.Drawing.Color.Tan;
            this.tpgAssignMaterials.Controls.Add(this.txtMaterialDate);
            this.tpgAssignMaterials.Controls.Add(this.label19);
            this.tpgAssignMaterials.Controls.Add(this.btnConfirmMaterials);
            this.tpgAssignMaterials.Controls.Add(this.label9);
            this.tpgAssignMaterials.Controls.Add(this.txtMaterialJobID);
            this.tpgAssignMaterials.Controls.Add(this.txtMaterialPrice);
            this.tpgAssignMaterials.Controls.Add(this.label13);
            this.tpgAssignMaterials.Controls.Add(this.txtMaterialUnit);
            this.tpgAssignMaterials.Controls.Add(this.label12);
            this.tpgAssignMaterials.Controls.Add(this.txtMaterialName);
            this.tpgAssignMaterials.Controls.Add(this.label11);
            this.tpgAssignMaterials.Location = new System.Drawing.Point(4, 29);
            this.tpgAssignMaterials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgAssignMaterials.Name = "tpgAssignMaterials";
            this.tpgAssignMaterials.Size = new System.Drawing.Size(1080, 404);
            this.tpgAssignMaterials.TabIndex = 2;
            this.tpgAssignMaterials.Text = "Assign Materials";
            // 
            // txtMaterialDate
            // 
            this.txtMaterialDate.Location = new System.Drawing.Point(520, 175);
            this.txtMaterialDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterialDate.Name = "txtMaterialDate";
            this.txtMaterialDate.Size = new System.Drawing.Size(190, 26);
            this.txtMaterialDate.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(399, 180);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 20);
            this.label19.TabIndex = 49;
            this.label19.Text = "Date Ordered";
            // 
            // btnConfirmMaterials
            // 
            this.btnConfirmMaterials.Location = new System.Drawing.Point(471, 298);
            this.btnConfirmMaterials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmMaterials.Name = "btnConfirmMaterials";
            this.btnConfirmMaterials.Size = new System.Drawing.Size(138, 37);
            this.btnConfirmMaterials.TabIndex = 48;
            this.btnConfirmMaterials.Text = "Confirm";
            this.btnConfirmMaterials.UseVisualStyleBackColor = true;
            this.btnConfirmMaterials.Click += new System.EventHandler(this.btnConfirmMaterials_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Job ID";
            // 
            // txtMaterialJobID
            // 
            this.txtMaterialJobID.Location = new System.Drawing.Point(112, 175);
            this.txtMaterialJobID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterialJobID.Name = "txtMaterialJobID";
            this.txtMaterialJobID.Size = new System.Drawing.Size(148, 26);
            this.txtMaterialJobID.TabIndex = 47;
            // 
            // txtMaterialPrice
            // 
            this.txtMaterialPrice.Location = new System.Drawing.Point(866, 175);
            this.txtMaterialPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterialPrice.Name = "txtMaterialPrice";
            this.txtMaterialPrice.Size = new System.Drawing.Size(148, 26);
            this.txtMaterialPrice.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(818, 180);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Price";
            // 
            // txtMaterialUnit
            // 
            this.txtMaterialUnit.Location = new System.Drawing.Point(866, 109);
            this.txtMaterialUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterialUnit.Name = "txtMaterialUnit";
            this.txtMaterialUnit.Size = new System.Drawing.Size(148, 26);
            this.txtMaterialUnit.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(818, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Unit";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(158, 109);
            this.txtMaterialName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(610, 26);
            this.txtMaterialName.TabIndex = 40;
            this.txtMaterialName.TextChanged += new System.EventHandler(this.txtMaterialName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Material Name";
            // 
            // tpgAssignWorkers
            // 
            this.tpgAssignWorkers.BackColor = System.Drawing.Color.Tan;
            this.tpgAssignWorkers.Controls.Add(this.label10);
            this.tpgAssignWorkers.Controls.Add(this.btnConfirmWorkers);
            this.tpgAssignWorkers.Controls.Add(this.txtWorkerJobID);
            this.tpgAssignWorkers.Controls.Add(this.cklAssignWorkers);
            this.tpgAssignWorkers.Controls.Add(this.label1);
            this.tpgAssignWorkers.Location = new System.Drawing.Point(4, 29);
            this.tpgAssignWorkers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgAssignWorkers.Name = "tpgAssignWorkers";
            this.tpgAssignWorkers.Size = new System.Drawing.Size(1080, 404);
            this.tpgAssignWorkers.TabIndex = 3;
            this.tpgAssignWorkers.Text = "Assign Workers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Job ID";
            // 
            // txtWorkerJobID
            // 
            this.txtWorkerJobID.Location = new System.Drawing.Point(148, 168);
            this.txtWorkerJobID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWorkerJobID.Name = "txtWorkerJobID";
            this.txtWorkerJobID.Size = new System.Drawing.Size(148, 26);
            this.txtWorkerJobID.TabIndex = 35;
            this.txtWorkerJobID.TextChanged += new System.EventHandler(this.txtWorkerJobID_TextChanged);
            // 
            // cklAssignWorkers
            // 
            this.cklAssignWorkers.FormattingEnabled = true;
            this.cklAssignWorkers.Location = new System.Drawing.Point(436, 109);
            this.cklAssignWorkers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cklAssignWorkers.Name = "cklAssignWorkers";
            this.cklAssignWorkers.Size = new System.Drawing.Size(499, 151);
            this.cklAssignWorkers.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Workers";
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdated.Location = new System.Drawing.Point(53, 572);
            this.lblUpdated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(233, 20);
            this.lblUpdated.TabIndex = 35;
            this.lblUpdated.Text = "The changes have been saved. ";
            this.lblUpdated.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkGreen;
            this.label20.Location = new System.Drawing.Point(458, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(284, 55);
            this.label20.TabIndex = 36;
            this.label20.Text = "Create Jobs";
            // 
            // EmployeeJobMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeJobMaterial";
            this.Text = "Create Jobs";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.EmployeeJobMaterial_HelpButtonClicked);
            this.Load += new System.EventHandler(this.EmployeeJobMaterial_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpgCreateCustomer.ResumeLayout(false);
            this.tpgCreateCustomer.PerformLayout();
            this.tpgCreateJob.ResumeLayout(false);
            this.tpgCreateJob.PerformLayout();
            this.tpgAssignMaterials.ResumeLayout(false);
            this.tpgAssignMaterials.PerformLayout();
            this.tpgAssignWorkers.ResumeLayout(false);
            this.tpgAssignWorkers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmWorkers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgCreateCustomer;
        private System.Windows.Forms.TextBox txtCustLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpgCreateJob;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtJobSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJobType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJobAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJobCustId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpgAssignMaterials;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaterialJobID;
        private System.Windows.Forms.TextBox txtMaterialPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaterialUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tpgAssignWorkers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWorkerJobID;
        private System.Windows.Forms.CheckedListBox cklAssignWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustZip;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCustCity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnConfirmCustomer;
        private System.Windows.Forms.Button btnConfirmJob;
        private System.Windows.Forms.Button btnConfirmMaterials;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox txtMaterialDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.HelpProvider hlpEmpJob;
    }
}
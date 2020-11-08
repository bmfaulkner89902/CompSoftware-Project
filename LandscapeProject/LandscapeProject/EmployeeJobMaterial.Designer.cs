namespace LandscapeProject
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
            this.tabControl1.SuspendLayout();
            this.tpgCreateCustomer.SuspendLayout();
            this.tpgCreateJob.SuspendLayout();
            this.tpgAssignMaterials.SuspendLayout();
            this.tpgAssignWorkers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Exit/Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmWorkers
            // 
            this.btnConfirmWorkers.Location = new System.Drawing.Point(264, 212);
            this.btnConfirmWorkers.Name = "btnConfirmWorkers";
            this.btnConfirmWorkers.Size = new System.Drawing.Size(92, 23);
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
            this.tabControl1.Location = new System.Drawing.Point(31, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 284);
            this.tabControl1.TabIndex = 33;
            // 
            // tpgCreateCustomer
            // 
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
            this.tpgCreateCustomer.Location = new System.Drawing.Point(4, 22);
            this.tpgCreateCustomer.Name = "tpgCreateCustomer";
            this.tpgCreateCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCreateCustomer.Size = new System.Drawing.Size(717, 258);
            this.tpgCreateCustomer.TabIndex = 0;
            this.tpgCreateCustomer.Text = "Create Customer";
            this.tpgCreateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnConfirmCustomer
            // 
            this.btnConfirmCustomer.Location = new System.Drawing.Point(291, 217);
            this.btnConfirmCustomer.Name = "btnConfirmCustomer";
            this.btnConfirmCustomer.Size = new System.Drawing.Size(92, 23);
            this.btnConfirmCustomer.TabIndex = 53;
            this.btnConfirmCustomer.Text = "Confirm";
            this.btnConfirmCustomer.UseVisualStyleBackColor = true;
            this.btnConfirmCustomer.Click += new System.EventHandler(this.btnConfirmCustomer_Click);
            // 
            // txtCustZip
            // 
            this.txtCustZip.Location = new System.Drawing.Point(594, 165);
            this.txtCustZip.Name = "txtCustZip";
            this.txtCustZip.Size = new System.Drawing.Size(88, 20);
            this.txtCustZip.TabIndex = 52;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(535, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "ZipCode";
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(382, 165);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(124, 20);
            this.txtCustCity.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "City";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(103, 165);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(213, 20);
            this.txtCustEmail.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Customer Email";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(134, 102);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(548, 20);
            this.txtCustAddress.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Customer Address";
            // 
            // txtCustLast
            // 
            this.txtCustLast.Location = new System.Drawing.Point(458, 43);
            this.txtCustLast.Name = "txtCustLast";
            this.txtCustLast.Size = new System.Drawing.Size(124, 20);
            this.txtCustLast.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Customer Last Name";
            // 
            // txtCustFirst
            // 
            this.txtCustFirst.Location = new System.Drawing.Point(210, 43);
            this.txtCustFirst.Name = "txtCustFirst";
            this.txtCustFirst.Size = new System.Drawing.Size(124, 20);
            this.txtCustFirst.TabIndex = 40;
            this.txtCustFirst.TextChanged += new System.EventHandler(this.txtCustFirst_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Customer First Name";
            // 
            // tpgCreateJob
            // 
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
            this.tpgCreateJob.Location = new System.Drawing.Point(4, 22);
            this.tpgCreateJob.Name = "tpgCreateJob";
            this.tpgCreateJob.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCreateJob.Size = new System.Drawing.Size(717, 258);
            this.tpgCreateJob.TabIndex = 1;
            this.tpgCreateJob.Text = "Create Job";
            this.tpgCreateJob.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(576, 175);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(77, 20);
            this.txtPrice.TabIndex = 51;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(527, 179);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 50;
            this.price.Text = "Price";
            // 
            // btnConfirmJob
            // 
            this.btnConfirmJob.Location = new System.Drawing.Point(312, 219);
            this.btnConfirmJob.Name = "btnConfirmJob";
            this.btnConfirmJob.Size = new System.Drawing.Size(92, 23);
            this.btnConfirmJob.TabIndex = 49;
            this.btnConfirmJob.Text = "Confirm";
            this.btnConfirmJob.UseVisualStyleBackColor = true;
            this.btnConfirmJob.Click += new System.EventHandler(this.btnConfirmJob_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Job End Date";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(320, 175);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(124, 20);
            this.txtEnd.TabIndex = 47;
            // 
            // txtJobSize
            // 
            this.txtJobSize.Location = new System.Drawing.Point(576, 141);
            this.txtJobSize.Name = "txtJobSize";
            this.txtJobSize.Size = new System.Drawing.Size(77, 20);
            this.txtJobSize.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Size ";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(320, 141);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(124, 20);
            this.txtStart.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Job Start Date";
            // 
            // txtJobType
            // 
            this.txtJobType.Location = new System.Drawing.Point(95, 145);
            this.txtJobType.Name = "txtJobType";
            this.txtJobType.Size = new System.Drawing.Size(100, 20);
            this.txtJobType.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Job Type";
            // 
            // txtJobAddress
            // 
            this.txtJobAddress.Location = new System.Drawing.Point(121, 82);
            this.txtJobAddress.Name = "txtJobAddress";
            this.txtJobAddress.Size = new System.Drawing.Size(590, 20);
            this.txtJobAddress.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Job Address";
            // 
            // txtJobCustId
            // 
            this.txtJobCustId.Location = new System.Drawing.Point(308, 30);
            this.txtJobCustId.Name = "txtJobCustId";
            this.txtJobCustId.Size = new System.Drawing.Size(100, 20);
            this.txtJobCustId.TabIndex = 34;
            this.txtJobCustId.TextChanged += new System.EventHandler(this.txtJobCustId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "CustomerID";
            // 
            // tpgAssignMaterials
            // 
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
            this.tpgAssignMaterials.Location = new System.Drawing.Point(4, 22);
            this.tpgAssignMaterials.Name = "tpgAssignMaterials";
            this.tpgAssignMaterials.Size = new System.Drawing.Size(717, 258);
            this.tpgAssignMaterials.TabIndex = 2;
            this.tpgAssignMaterials.Text = "Assign Materials";
            this.tpgAssignMaterials.UseVisualStyleBackColor = true;
            // 
            // txtMaterialDate
            // 
            this.txtMaterialDate.Location = new System.Drawing.Point(347, 114);
            this.txtMaterialDate.Name = "txtMaterialDate";
            this.txtMaterialDate.Size = new System.Drawing.Size(128, 20);
            this.txtMaterialDate.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(266, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Date Ordered";
            // 
            // btnConfirmMaterials
            // 
            this.btnConfirmMaterials.Location = new System.Drawing.Point(291, 194);
            this.btnConfirmMaterials.Name = "btnConfirmMaterials";
            this.btnConfirmMaterials.Size = new System.Drawing.Size(92, 24);
            this.btnConfirmMaterials.TabIndex = 48;
            this.btnConfirmMaterials.Text = "Confirm";
            this.btnConfirmMaterials.UseVisualStyleBackColor = true;
            this.btnConfirmMaterials.Click += new System.EventHandler(this.btnConfirmMaterials_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Job ID";
            // 
            // txtMaterialJobID
            // 
            this.txtMaterialJobID.Location = new System.Drawing.Point(75, 114);
            this.txtMaterialJobID.Name = "txtMaterialJobID";
            this.txtMaterialJobID.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialJobID.TabIndex = 47;
            // 
            // txtMaterialPrice
            // 
            this.txtMaterialPrice.Location = new System.Drawing.Point(577, 114);
            this.txtMaterialPrice.Name = "txtMaterialPrice";
            this.txtMaterialPrice.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialPrice.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Price";
            // 
            // txtMaterialUnit
            // 
            this.txtMaterialUnit.Location = new System.Drawing.Point(577, 71);
            this.txtMaterialUnit.Name = "txtMaterialUnit";
            this.txtMaterialUnit.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialUnit.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Unit";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(105, 71);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(408, 20);
            this.txtMaterialName.TabIndex = 40;
            this.txtMaterialName.TextChanged += new System.EventHandler(this.txtMaterialName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Material Name";
            // 
            // tpgAssignWorkers
            // 
            this.tpgAssignWorkers.Controls.Add(this.label10);
            this.tpgAssignWorkers.Controls.Add(this.btnConfirmWorkers);
            this.tpgAssignWorkers.Controls.Add(this.txtWorkerJobID);
            this.tpgAssignWorkers.Controls.Add(this.cklAssignWorkers);
            this.tpgAssignWorkers.Controls.Add(this.label1);
            this.tpgAssignWorkers.Location = new System.Drawing.Point(4, 22);
            this.tpgAssignWorkers.Name = "tpgAssignWorkers";
            this.tpgAssignWorkers.Size = new System.Drawing.Size(717, 258);
            this.tpgAssignWorkers.TabIndex = 3;
            this.tpgAssignWorkers.Text = "Assign Workers";
            this.tpgAssignWorkers.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Job ID";
            // 
            // txtWorkerJobID
            // 
            this.txtWorkerJobID.Location = new System.Drawing.Point(99, 109);
            this.txtWorkerJobID.Name = "txtWorkerJobID";
            this.txtWorkerJobID.Size = new System.Drawing.Size(100, 20);
            this.txtWorkerJobID.TabIndex = 35;
            this.txtWorkerJobID.TextChanged += new System.EventHandler(this.txtWorkerJobID_TextChanged);
            // 
            // cklAssignWorkers
            // 
            this.cklAssignWorkers.FormattingEnabled = true;
            this.cklAssignWorkers.Location = new System.Drawing.Point(291, 71);
            this.cklAssignWorkers.Name = "cklAssignWorkers";
            this.cklAssignWorkers.Size = new System.Drawing.Size(334, 109);
            this.cklAssignWorkers.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Workers";
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdated.Location = new System.Drawing.Point(43, 300);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(233, 20);
            this.lblUpdated.TabIndex = 35;
            this.lblUpdated.Text = "The changes have been saved. ";
            this.lblUpdated.Visible = false;
            // 
            // EmployeeJobMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Name = "EmployeeJobMaterial";
            this.Text = "EmployeeJobMaterial";
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
    }
}
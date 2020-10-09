namespace LandscapeProject
{
    partial class OwnerMain
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
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpJobs = new System.Windows.Forms.TabPage();
            this.gbxJobAssignWorkers = new System.Windows.Forms.GroupBox();
            this.lbxJobEmployees = new System.Windows.Forms.ListBox();
            this.lbxJobContractors = new System.Windows.Forms.ListBox();
            this.btnApproveJobs = new System.Windows.Forms.Button();
            this.btnEditJobs = new System.Windows.Forms.Button();
            this.btnCancelJobs = new System.Windows.Forms.Button();
            this.btnUpdateJobs = new System.Windows.Forms.Button();
            this.gbxJobMaterials = new System.Windows.Forms.GroupBox();
            this.btnApproveMaterials = new System.Windows.Forms.Button();
            this.btnCancelMaterials = new System.Windows.Forms.Button();
            this.dgvJobMaterials = new System.Windows.Forms.DataGridView();
            this.btnUpdateMaterials = new System.Windows.Forms.Button();
            this.btnEditMaterials = new System.Windows.Forms.Button();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.gbxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerInfoTitle = new System.Windows.Forms.Label();
            this.lblCustomerInfoNew = new System.Windows.Forms.Label();
            this.lblCustomerCategory = new System.Windows.Forms.Label();
            this.cboCustomerCategory = new System.Windows.Forms.ComboBox();
            this.tbxCustomerInfoNew = new System.Windows.Forms.TextBox();
            this.btnCustomerSubmit = new System.Windows.Forms.Button();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.gbxCustomerPayments = new System.Windows.Forms.GroupBox();
            this.btnApproveCustPayments = new System.Windows.Forms.Button();
            this.btnCancelCustPayment = new System.Windows.Forms.Button();
            this.btnUpdateCustPayment = new System.Windows.Forms.Button();
            this.btnEditCustPayment = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tpContractors = new System.Windows.Forms.TabPage();
            this.gbxContractorInf = new System.Windows.Forms.GroupBox();
            this.lblContractorInfoTitle = new System.Windows.Forms.Label();
            this.lblContractorInfoNew = new System.Windows.Forms.Label();
            this.lblContractorCategory = new System.Windows.Forms.Label();
            this.cboContractorCategory = new System.Windows.Forms.ComboBox();
            this.tbxContractorInfoNew = new System.Windows.Forms.TextBox();
            this.btnContractorSubmit = new System.Windows.Forms.Button();
            this.btnContractorCancel = new System.Windows.Forms.Button();
            this.gbxContractorPayments = new System.Windows.Forms.GroupBox();
            this.btnApproveContPayment = new System.Windows.Forms.Button();
            this.btnCancelContPayment = new System.Windows.Forms.Button();
            this.btnUpdateContPayment = new System.Windows.Forms.Button();
            this.btnEditContPayment = new System.Windows.Forms.Button();
            this.dgvContractors = new System.Windows.Forms.DataGridView();
            this.tpEmployees = new System.Windows.Forms.TabPage();
            this.gbxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.lblEmployeeInfoTitle = new System.Windows.Forms.Label();
            this.lblEmployeeInfoNew = new System.Windows.Forms.Label();
            this.lblEmployeeCategory = new System.Windows.Forms.Label();
            this.cboEmployeeCategory = new System.Windows.Forms.ComboBox();
            this.tbxEmployeeInfoNew = new System.Windows.Forms.TextBox();
            this.btnEmployeeSubmit = new System.Windows.Forms.Button();
            this.btnEmployeeCancel = new System.Windows.Forms.Button();
            this.gbxEmployeePayments = new System.Windows.Forms.GroupBox();
            this.btnApproveEmpPayment = new System.Windows.Forms.Button();
            this.btnCancelEmpPayment = new System.Windows.Forms.Button();
            this.btnUpdateEmpPayment = new System.Windows.Forms.Button();
            this.btnEditEmpPayment = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.tpReports = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpJobs.SuspendLayout();
            this.gbxJobAssignWorkers.SuspendLayout();
            this.gbxJobMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobMaterials)).BeginInit();
            this.tpCustomers.SuspendLayout();
            this.gbxCustomerInfo.SuspendLayout();
            this.gbxCustomerPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tpContractors.SuspendLayout();
            this.gbxContractorInf.SuspendLayout();
            this.gbxContractorPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractors)).BeginInit();
            this.tpEmployees.SuspendLayout();
            this.gbxEmployeeInfo.SuspendLayout();
            this.gbxEmployeePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(7, 6);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(1029, 234);
            this.dgvJobs.TabIndex = 1;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpJobs);
            this.tcMain.Controls.Add(this.tpCustomers);
            this.tcMain.Controls.Add(this.tpContractors);
            this.tcMain.Controls.Add(this.tpEmployees);
            this.tcMain.Controls.Add(this.tpReports);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.ShowToolTips = true;
            this.tcMain.Size = new System.Drawing.Size(1052, 655);
            this.tcMain.TabIndex = 2;
            // 
            // tpJobs
            // 
            this.tpJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpJobs.Controls.Add(this.gbxJobAssignWorkers);
            this.tpJobs.Controls.Add(this.gbxJobMaterials);
            this.tpJobs.Controls.Add(this.dgvJobs);
            this.tpJobs.Location = new System.Drawing.Point(4, 29);
            this.tpJobs.Name = "tpJobs";
            this.tpJobs.Padding = new System.Windows.Forms.Padding(3);
            this.tpJobs.Size = new System.Drawing.Size(1044, 622);
            this.tpJobs.TabIndex = 0;
            this.tpJobs.Text = "Jobs";
            this.tpJobs.ToolTipText = "View and Manage Jobs";
            this.tpJobs.UseVisualStyleBackColor = true;
            // 
            // gbxJobAssignWorkers
            // 
            this.gbxJobAssignWorkers.Controls.Add(this.lbxJobEmployees);
            this.gbxJobAssignWorkers.Controls.Add(this.lbxJobContractors);
            this.gbxJobAssignWorkers.Controls.Add(this.btnApproveJobs);
            this.gbxJobAssignWorkers.Controls.Add(this.btnEditJobs);
            this.gbxJobAssignWorkers.Controls.Add(this.btnCancelJobs);
            this.gbxJobAssignWorkers.Controls.Add(this.btnUpdateJobs);
            this.gbxJobAssignWorkers.Location = new System.Drawing.Point(518, 246);
            this.gbxJobAssignWorkers.Name = "gbxJobAssignWorkers";
            this.gbxJobAssignWorkers.Size = new System.Drawing.Size(516, 337);
            this.gbxJobAssignWorkers.TabIndex = 10;
            this.gbxJobAssignWorkers.TabStop = false;
            this.gbxJobAssignWorkers.Text = "Job Contractors/Employees";
            // 
            // lbxJobEmployees
            // 
            this.lbxJobEmployees.FormattingEnabled = true;
            this.lbxJobEmployees.ItemHeight = 20;
            this.lbxJobEmployees.Items.AddRange(new object[] {
            "Employees On Job:"});
            this.lbxJobEmployees.Location = new System.Drawing.Point(264, 26);
            this.lbxJobEmployees.Name = "lbxJobEmployees";
            this.lbxJobEmployees.Size = new System.Drawing.Size(246, 184);
            this.lbxJobEmployees.TabIndex = 13;
            // 
            // lbxJobContractors
            // 
            this.lbxJobContractors.FormattingEnabled = true;
            this.lbxJobContractors.ItemHeight = 20;
            this.lbxJobContractors.Items.AddRange(new object[] {
            "Contractors On Job:"});
            this.lbxJobContractors.Location = new System.Drawing.Point(6, 26);
            this.lbxJobContractors.Name = "lbxJobContractors";
            this.lbxJobContractors.Size = new System.Drawing.Size(246, 184);
            this.lbxJobContractors.TabIndex = 12;
            // 
            // btnApproveJobs
            // 
            this.btnApproveJobs.Location = new System.Drawing.Point(180, 226);
            this.btnApproveJobs.Name = "btnApproveJobs";
            this.btnApproveJobs.Size = new System.Drawing.Size(158, 39);
            this.btnApproveJobs.TabIndex = 9;
            this.btnApproveJobs.Text = "Approve Workers";
            this.btnApproveJobs.UseVisualStyleBackColor = true;
            // 
            // btnEditJobs
            // 
            this.btnEditJobs.Location = new System.Drawing.Point(81, 271);
            this.btnEditJobs.Name = "btnEditJobs";
            this.btnEditJobs.Size = new System.Drawing.Size(114, 39);
            this.btnEditJobs.TabIndex = 6;
            this.btnEditJobs.Text = "Edit";
            this.btnEditJobs.UseVisualStyleBackColor = true;
            // 
            // btnCancelJobs
            // 
            this.btnCancelJobs.Location = new System.Drawing.Point(201, 271);
            this.btnCancelJobs.Name = "btnCancelJobs";
            this.btnCancelJobs.Size = new System.Drawing.Size(114, 39);
            this.btnCancelJobs.TabIndex = 8;
            this.btnCancelJobs.Text = "Cancel Edit";
            this.btnCancelJobs.UseVisualStyleBackColor = true;
            // 
            // btnUpdateJobs
            // 
            this.btnUpdateJobs.Location = new System.Drawing.Point(321, 271);
            this.btnUpdateJobs.Name = "btnUpdateJobs";
            this.btnUpdateJobs.Size = new System.Drawing.Size(114, 39);
            this.btnUpdateJobs.TabIndex = 7;
            this.btnUpdateJobs.Text = "Update";
            this.btnUpdateJobs.UseVisualStyleBackColor = true;
            // 
            // gbxJobMaterials
            // 
            this.gbxJobMaterials.Controls.Add(this.btnApproveMaterials);
            this.gbxJobMaterials.Controls.Add(this.btnCancelMaterials);
            this.gbxJobMaterials.Controls.Add(this.dgvJobMaterials);
            this.gbxJobMaterials.Controls.Add(this.btnUpdateMaterials);
            this.gbxJobMaterials.Controls.Add(this.btnEditMaterials);
            this.gbxJobMaterials.Location = new System.Drawing.Point(8, 246);
            this.gbxJobMaterials.Name = "gbxJobMaterials";
            this.gbxJobMaterials.Size = new System.Drawing.Size(503, 338);
            this.gbxJobMaterials.TabIndex = 2;
            this.gbxJobMaterials.TabStop = false;
            this.gbxJobMaterials.Text = "Job Materials";
            // 
            // btnApproveMaterials
            // 
            this.btnApproveMaterials.Location = new System.Drawing.Point(172, 226);
            this.btnApproveMaterials.Name = "btnApproveMaterials";
            this.btnApproveMaterials.Size = new System.Drawing.Size(158, 39);
            this.btnApproveMaterials.TabIndex = 6;
            this.btnApproveMaterials.Text = "Approve Materials";
            this.btnApproveMaterials.UseVisualStyleBackColor = true;
            // 
            // btnCancelMaterials
            // 
            this.btnCancelMaterials.Location = new System.Drawing.Point(194, 271);
            this.btnCancelMaterials.Name = "btnCancelMaterials";
            this.btnCancelMaterials.Size = new System.Drawing.Size(114, 39);
            this.btnCancelMaterials.TabIndex = 5;
            this.btnCancelMaterials.Text = "Cancel Edit";
            this.btnCancelMaterials.UseVisualStyleBackColor = true;
            // 
            // dgvJobMaterials
            // 
            this.dgvJobMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobMaterials.Location = new System.Drawing.Point(6, 26);
            this.dgvJobMaterials.Name = "dgvJobMaterials";
            this.dgvJobMaterials.RowHeadersWidth = 51;
            this.dgvJobMaterials.RowTemplate.Height = 24;
            this.dgvJobMaterials.Size = new System.Drawing.Size(491, 181);
            this.dgvJobMaterials.TabIndex = 0;
            // 
            // btnUpdateMaterials
            // 
            this.btnUpdateMaterials.Location = new System.Drawing.Point(314, 271);
            this.btnUpdateMaterials.Name = "btnUpdateMaterials";
            this.btnUpdateMaterials.Size = new System.Drawing.Size(114, 39);
            this.btnUpdateMaterials.TabIndex = 4;
            this.btnUpdateMaterials.Text = "Update";
            this.btnUpdateMaterials.UseVisualStyleBackColor = true;
            // 
            // btnEditMaterials
            // 
            this.btnEditMaterials.Location = new System.Drawing.Point(74, 271);
            this.btnEditMaterials.Name = "btnEditMaterials";
            this.btnEditMaterials.Size = new System.Drawing.Size(114, 39);
            this.btnEditMaterials.TabIndex = 3;
            this.btnEditMaterials.Text = "Edit";
            this.btnEditMaterials.UseVisualStyleBackColor = true;
            // 
            // tpCustomers
            // 
            this.tpCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpCustomers.Controls.Add(this.gbxCustomerInfo);
            this.tpCustomers.Controls.Add(this.gbxCustomerPayments);
            this.tpCustomers.Controls.Add(this.dgvCustomers);
            this.tpCustomers.Location = new System.Drawing.Point(4, 29);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomers.Size = new System.Drawing.Size(1044, 622);
            this.tpCustomers.TabIndex = 1;
            this.tpCustomers.Text = "Customers";
            this.tpCustomers.ToolTipText = "View and Manage Customers";
            this.tpCustomers.UseVisualStyleBackColor = true;
            // 
            // gbxCustomerInfo
            // 
            this.gbxCustomerInfo.Controls.Add(this.lblCustomerInfoTitle);
            this.gbxCustomerInfo.Controls.Add(this.lblCustomerInfoNew);
            this.gbxCustomerInfo.Controls.Add(this.lblCustomerCategory);
            this.gbxCustomerInfo.Controls.Add(this.cboCustomerCategory);
            this.gbxCustomerInfo.Controls.Add(this.tbxCustomerInfoNew);
            this.gbxCustomerInfo.Controls.Add(this.btnCustomerSubmit);
            this.gbxCustomerInfo.Controls.Add(this.btnCustomerCancel);
            this.gbxCustomerInfo.Location = new System.Drawing.Point(518, 246);
            this.gbxCustomerInfo.Name = "gbxCustomerInfo";
            this.gbxCustomerInfo.Size = new System.Drawing.Size(516, 337);
            this.gbxCustomerInfo.TabIndex = 11;
            this.gbxCustomerInfo.TabStop = false;
            this.gbxCustomerInfo.Text = "Edit Customer Information";
            // 
            // lblCustomerInfoTitle
            // 
            this.lblCustomerInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfoTitle.Location = new System.Drawing.Point(131, 54);
            this.lblCustomerInfoTitle.Name = "lblCustomerInfoTitle";
            this.lblCustomerInfoTitle.Size = new System.Drawing.Size(254, 24);
            this.lblCustomerInfoTitle.TabIndex = 14;
            this.lblCustomerInfoTitle.Text = "Select a Customer From Above";
            this.lblCustomerInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerInfoNew
            // 
            this.lblCustomerInfoNew.Location = new System.Drawing.Point(73, 177);
            this.lblCustomerInfoNew.Name = "lblCustomerInfoNew";
            this.lblCustomerInfoNew.Size = new System.Drawing.Size(177, 20);
            this.lblCustomerInfoNew.TabIndex = 13;
            this.lblCustomerInfoNew.Text = "Enter new information:";
            this.lblCustomerInfoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerCategory
            // 
            this.lblCustomerCategory.Location = new System.Drawing.Point(50, 123);
            this.lblCustomerCategory.Name = "lblCustomerCategory";
            this.lblCustomerCategory.Size = new System.Drawing.Size(200, 20);
            this.lblCustomerCategory.TabIndex = 12;
            this.lblCustomerCategory.Text = "Select a Category to Edit:";
            this.lblCustomerCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCustomerCategory
            // 
            this.cboCustomerCategory.FormattingEnabled = true;
            this.cboCustomerCategory.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Address",
            "Email",
            "City",
            "ZipCode"});
            this.cboCustomerCategory.Location = new System.Drawing.Point(256, 120);
            this.cboCustomerCategory.Name = "cboCustomerCategory";
            this.cboCustomerCategory.Size = new System.Drawing.Size(210, 28);
            this.cboCustomerCategory.TabIndex = 11;
            // 
            // tbxCustomerInfoNew
            // 
            this.tbxCustomerInfoNew.Location = new System.Drawing.Point(256, 174);
            this.tbxCustomerInfoNew.Name = "tbxCustomerInfoNew";
            this.tbxCustomerInfoNew.Size = new System.Drawing.Size(210, 27);
            this.tbxCustomerInfoNew.TabIndex = 10;
            // 
            // btnCustomerSubmit
            // 
            this.btnCustomerSubmit.Location = new System.Drawing.Point(90, 271);
            this.btnCustomerSubmit.Name = "btnCustomerSubmit";
            this.btnCustomerSubmit.Size = new System.Drawing.Size(158, 39);
            this.btnCustomerSubmit.TabIndex = 9;
            this.btnCustomerSubmit.Text = "Submit Changes";
            this.btnCustomerSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.Location = new System.Drawing.Point(269, 271);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(158, 39);
            this.btnCustomerCancel.TabIndex = 8;
            this.btnCustomerCancel.Text = "Cancel Changes";
            this.btnCustomerCancel.UseVisualStyleBackColor = true;
            // 
            // gbxCustomerPayments
            // 
            this.gbxCustomerPayments.Controls.Add(this.btnApproveCustPayments);
            this.gbxCustomerPayments.Controls.Add(this.btnCancelCustPayment);
            this.gbxCustomerPayments.Controls.Add(this.btnUpdateCustPayment);
            this.gbxCustomerPayments.Controls.Add(this.btnEditCustPayment);
            this.gbxCustomerPayments.Location = new System.Drawing.Point(8, 246);
            this.gbxCustomerPayments.Name = "gbxCustomerPayments";
            this.gbxCustomerPayments.Size = new System.Drawing.Size(503, 338);
            this.gbxCustomerPayments.TabIndex = 3;
            this.gbxCustomerPayments.TabStop = false;
            this.gbxCustomerPayments.Text = "Manage/Issue Payments";
            // 
            // btnApproveCustPayments
            // 
            this.btnApproveCustPayments.Location = new System.Drawing.Point(172, 226);
            this.btnApproveCustPayments.Name = "btnApproveCustPayments";
            this.btnApproveCustPayments.Size = new System.Drawing.Size(158, 39);
            this.btnApproveCustPayments.TabIndex = 6;
            this.btnApproveCustPayments.Text = "Approve Payment";
            this.btnApproveCustPayments.UseVisualStyleBackColor = true;
            // 
            // btnCancelCustPayment
            // 
            this.btnCancelCustPayment.Location = new System.Drawing.Point(194, 271);
            this.btnCancelCustPayment.Name = "btnCancelCustPayment";
            this.btnCancelCustPayment.Size = new System.Drawing.Size(114, 39);
            this.btnCancelCustPayment.TabIndex = 5;
            this.btnCancelCustPayment.Text = "Cancel Edit";
            this.btnCancelCustPayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustPayment
            // 
            this.btnUpdateCustPayment.Location = new System.Drawing.Point(314, 271);
            this.btnUpdateCustPayment.Name = "btnUpdateCustPayment";
            this.btnUpdateCustPayment.Size = new System.Drawing.Size(114, 39);
            this.btnUpdateCustPayment.TabIndex = 4;
            this.btnUpdateCustPayment.Text = "Update";
            this.btnUpdateCustPayment.UseVisualStyleBackColor = true;
            // 
            // btnEditCustPayment
            // 
            this.btnEditCustPayment.Location = new System.Drawing.Point(74, 271);
            this.btnEditCustPayment.Name = "btnEditCustPayment";
            this.btnEditCustPayment.Size = new System.Drawing.Size(114, 39);
            this.btnEditCustPayment.TabIndex = 3;
            this.btnEditCustPayment.Text = "Edit";
            this.btnEditCustPayment.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(7, 6);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1029, 234);
            this.dgvCustomers.TabIndex = 2;
            // 
            // tpContractors
            // 
            this.tpContractors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpContractors.Controls.Add(this.gbxContractorInf);
            this.tpContractors.Controls.Add(this.gbxContractorPayments);
            this.tpContractors.Controls.Add(this.dgvContractors);
            this.tpContractors.Location = new System.Drawing.Point(4, 29);
            this.tpContractors.Name = "tpContractors";
            this.tpContractors.Padding = new System.Windows.Forms.Padding(3);
            this.tpContractors.Size = new System.Drawing.Size(1044, 622);
            this.tpContractors.TabIndex = 2;
            this.tpContractors.Text = "Contractors";
            this.tpContractors.ToolTipText = "Vew and Manage Contractors";
            this.tpContractors.UseVisualStyleBackColor = true;
            // 
            // gbxContractorInf
            // 
            this.gbxContractorInf.Controls.Add(this.lblContractorInfoTitle);
            this.gbxContractorInf.Controls.Add(this.lblContractorInfoNew);
            this.gbxContractorInf.Controls.Add(this.lblContractorCategory);
            this.gbxContractorInf.Controls.Add(this.cboContractorCategory);
            this.gbxContractorInf.Controls.Add(this.tbxContractorInfoNew);
            this.gbxContractorInf.Controls.Add(this.btnContractorSubmit);
            this.gbxContractorInf.Controls.Add(this.btnContractorCancel);
            this.gbxContractorInf.Location = new System.Drawing.Point(518, 246);
            this.gbxContractorInf.Name = "gbxContractorInf";
            this.gbxContractorInf.Size = new System.Drawing.Size(516, 337);
            this.gbxContractorInf.TabIndex = 13;
            this.gbxContractorInf.TabStop = false;
            this.gbxContractorInf.Text = "Edit Contractor Information";
            // 
            // lblContractorInfoTitle
            // 
            this.lblContractorInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorInfoTitle.Location = new System.Drawing.Point(131, 54);
            this.lblContractorInfoTitle.Name = "lblContractorInfoTitle";
            this.lblContractorInfoTitle.Size = new System.Drawing.Size(254, 24);
            this.lblContractorInfoTitle.TabIndex = 14;
            this.lblContractorInfoTitle.Text = "Select a Contractor From Above";
            this.lblContractorInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContractorInfoNew
            // 
            this.lblContractorInfoNew.Location = new System.Drawing.Point(73, 177);
            this.lblContractorInfoNew.Name = "lblContractorInfoNew";
            this.lblContractorInfoNew.Size = new System.Drawing.Size(177, 20);
            this.lblContractorInfoNew.TabIndex = 13;
            this.lblContractorInfoNew.Text = "Enter new information:";
            this.lblContractorInfoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContractorCategory
            // 
            this.lblContractorCategory.Location = new System.Drawing.Point(50, 123);
            this.lblContractorCategory.Name = "lblContractorCategory";
            this.lblContractorCategory.Size = new System.Drawing.Size(200, 20);
            this.lblContractorCategory.TabIndex = 12;
            this.lblContractorCategory.Text = "Select a Category to Edit:";
            this.lblContractorCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboContractorCategory
            // 
            this.cboContractorCategory.FormattingEnabled = true;
            this.cboContractorCategory.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Address",
            "Email",
            "City",
            "ZipCode"});
            this.cboContractorCategory.Location = new System.Drawing.Point(256, 120);
            this.cboContractorCategory.Name = "cboContractorCategory";
            this.cboContractorCategory.Size = new System.Drawing.Size(210, 28);
            this.cboContractorCategory.TabIndex = 11;
            // 
            // tbxContractorInfoNew
            // 
            this.tbxContractorInfoNew.Location = new System.Drawing.Point(256, 174);
            this.tbxContractorInfoNew.Name = "tbxContractorInfoNew";
            this.tbxContractorInfoNew.Size = new System.Drawing.Size(210, 27);
            this.tbxContractorInfoNew.TabIndex = 10;
            // 
            // btnContractorSubmit
            // 
            this.btnContractorSubmit.Location = new System.Drawing.Point(90, 271);
            this.btnContractorSubmit.Name = "btnContractorSubmit";
            this.btnContractorSubmit.Size = new System.Drawing.Size(158, 39);
            this.btnContractorSubmit.TabIndex = 9;
            this.btnContractorSubmit.Text = "Submit Changes";
            this.btnContractorSubmit.UseVisualStyleBackColor = true;
            // 
            // btnContractorCancel
            // 
            this.btnContractorCancel.Location = new System.Drawing.Point(269, 271);
            this.btnContractorCancel.Name = "btnContractorCancel";
            this.btnContractorCancel.Size = new System.Drawing.Size(158, 39);
            this.btnContractorCancel.TabIndex = 8;
            this.btnContractorCancel.Text = "Cancel Changes";
            this.btnContractorCancel.UseVisualStyleBackColor = true;
            // 
            // gbxContractorPayments
            // 
            this.gbxContractorPayments.Controls.Add(this.btnApproveContPayment);
            this.gbxContractorPayments.Controls.Add(this.btnCancelContPayment);
            this.gbxContractorPayments.Controls.Add(this.btnUpdateContPayment);
            this.gbxContractorPayments.Controls.Add(this.btnEditContPayment);
            this.gbxContractorPayments.Location = new System.Drawing.Point(8, 246);
            this.gbxContractorPayments.Name = "gbxContractorPayments";
            this.gbxContractorPayments.Size = new System.Drawing.Size(503, 338);
            this.gbxContractorPayments.TabIndex = 12;
            this.gbxContractorPayments.TabStop = false;
            this.gbxContractorPayments.Text = "Manage/Issue Payments";
            // 
            // btnApproveContPayment
            // 
            this.btnApproveContPayment.Location = new System.Drawing.Point(172, 226);
            this.btnApproveContPayment.Name = "btnApproveContPayment";
            this.btnApproveContPayment.Size = new System.Drawing.Size(158, 39);
            this.btnApproveContPayment.TabIndex = 6;
            this.btnApproveContPayment.Text = "Approve Payment";
            this.btnApproveContPayment.UseVisualStyleBackColor = true;
            // 
            // btnCancelContPayment
            // 
            this.btnCancelContPayment.Location = new System.Drawing.Point(194, 271);
            this.btnCancelContPayment.Name = "btnCancelContPayment";
            this.btnCancelContPayment.Size = new System.Drawing.Size(114, 39);
            this.btnCancelContPayment.TabIndex = 5;
            this.btnCancelContPayment.Text = "Cancel Edit";
            this.btnCancelContPayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateContPayment
            // 
            this.btnUpdateContPayment.Location = new System.Drawing.Point(314, 271);
            this.btnUpdateContPayment.Name = "btnUpdateContPayment";
            this.btnUpdateContPayment.Size = new System.Drawing.Size(114, 39);
            this.btnUpdateContPayment.TabIndex = 4;
            this.btnUpdateContPayment.Text = "Update";
            this.btnUpdateContPayment.UseVisualStyleBackColor = true;
            // 
            // btnEditContPayment
            // 
            this.btnEditContPayment.Location = new System.Drawing.Point(74, 271);
            this.btnEditContPayment.Name = "btnEditContPayment";
            this.btnEditContPayment.Size = new System.Drawing.Size(114, 39);
            this.btnEditContPayment.TabIndex = 3;
            this.btnEditContPayment.Text = "Edit";
            this.btnEditContPayment.UseVisualStyleBackColor = true;
            // 
            // dgvContractors
            // 
            this.dgvContractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractors.Location = new System.Drawing.Point(7, 6);
            this.dgvContractors.Name = "dgvContractors";
            this.dgvContractors.RowHeadersWidth = 51;
            this.dgvContractors.RowTemplate.Height = 24;
            this.dgvContractors.Size = new System.Drawing.Size(1029, 234);
            this.dgvContractors.TabIndex = 2;
            // 
            // tpEmployees
            // 
            this.tpEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpEmployees.Controls.Add(this.gbxEmployeeInfo);
            this.tpEmployees.Controls.Add(this.gbxEmployeePayments);
            this.tpEmployees.Controls.Add(this.dgvEmployees);
            this.tpEmployees.Location = new System.Drawing.Point(4, 29);
            this.tpEmployees.Name = "tpEmployees";
            this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployees.Size = new System.Drawing.Size(1044, 622);
            this.tpEmployees.TabIndex = 3;
            this.tpEmployees.Text = "Employees";
            this.tpEmployees.ToolTipText = "View and Manage Employees";
            this.tpEmployees.UseVisualStyleBackColor = true;
            // 
            // gbxEmployeeInfo
            // 
            this.gbxEmployeeInfo.Controls.Add(this.lblEmployeeInfoTitle);
            this.gbxEmployeeInfo.Controls.Add(this.lblEmployeeInfoNew);
            this.gbxEmployeeInfo.Controls.Add(this.lblEmployeeCategory);
            this.gbxEmployeeInfo.Controls.Add(this.cboEmployeeCategory);
            this.gbxEmployeeInfo.Controls.Add(this.tbxEmployeeInfoNew);
            this.gbxEmployeeInfo.Controls.Add(this.btnEmployeeSubmit);
            this.gbxEmployeeInfo.Controls.Add(this.btnEmployeeCancel);
            this.gbxEmployeeInfo.Location = new System.Drawing.Point(518, 246);
            this.gbxEmployeeInfo.Name = "gbxEmployeeInfo";
            this.gbxEmployeeInfo.Size = new System.Drawing.Size(516, 337);
            this.gbxEmployeeInfo.TabIndex = 15;
            this.gbxEmployeeInfo.TabStop = false;
            this.gbxEmployeeInfo.Text = "Edit Employee Information";
            // 
            // lblEmployeeInfoTitle
            // 
            this.lblEmployeeInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInfoTitle.Location = new System.Drawing.Point(131, 54);
            this.lblEmployeeInfoTitle.Name = "lblEmployeeInfoTitle";
            this.lblEmployeeInfoTitle.Size = new System.Drawing.Size(254, 24);
            this.lblEmployeeInfoTitle.TabIndex = 14;
            this.lblEmployeeInfoTitle.Text = "Select an Employee From Above";
            this.lblEmployeeInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeInfoNew
            // 
            this.lblEmployeeInfoNew.Location = new System.Drawing.Point(73, 177);
            this.lblEmployeeInfoNew.Name = "lblEmployeeInfoNew";
            this.lblEmployeeInfoNew.Size = new System.Drawing.Size(177, 20);
            this.lblEmployeeInfoNew.TabIndex = 13;
            this.lblEmployeeInfoNew.Text = "Enter new information:";
            this.lblEmployeeInfoNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeCategory
            // 
            this.lblEmployeeCategory.Location = new System.Drawing.Point(50, 123);
            this.lblEmployeeCategory.Name = "lblEmployeeCategory";
            this.lblEmployeeCategory.Size = new System.Drawing.Size(200, 20);
            this.lblEmployeeCategory.TabIndex = 12;
            this.lblEmployeeCategory.Text = "Select a Category to Edit:";
            this.lblEmployeeCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEmployeeCategory
            // 
            this.cboEmployeeCategory.FormattingEnabled = true;
            this.cboEmployeeCategory.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Address",
            "Email",
            "City",
            "ZipCode"});
            this.cboEmployeeCategory.Location = new System.Drawing.Point(256, 120);
            this.cboEmployeeCategory.Name = "cboEmployeeCategory";
            this.cboEmployeeCategory.Size = new System.Drawing.Size(210, 28);
            this.cboEmployeeCategory.TabIndex = 11;
            // 
            // tbxEmployeeInfoNew
            // 
            this.tbxEmployeeInfoNew.Location = new System.Drawing.Point(256, 174);
            this.tbxEmployeeInfoNew.Name = "tbxEmployeeInfoNew";
            this.tbxEmployeeInfoNew.Size = new System.Drawing.Size(210, 27);
            this.tbxEmployeeInfoNew.TabIndex = 10;
            // 
            // btnEmployeeSubmit
            // 
            this.btnEmployeeSubmit.Location = new System.Drawing.Point(90, 271);
            this.btnEmployeeSubmit.Name = "btnEmployeeSubmit";
            this.btnEmployeeSubmit.Size = new System.Drawing.Size(158, 39);
            this.btnEmployeeSubmit.TabIndex = 9;
            this.btnEmployeeSubmit.Text = "Submit Changes";
            this.btnEmployeeSubmit.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeCancel
            // 
            this.btnEmployeeCancel.Location = new System.Drawing.Point(269, 271);
            this.btnEmployeeCancel.Name = "btnEmployeeCancel";
            this.btnEmployeeCancel.Size = new System.Drawing.Size(158, 39);
            this.btnEmployeeCancel.TabIndex = 8;
            this.btnEmployeeCancel.Text = "Cancel Changes";
            this.btnEmployeeCancel.UseVisualStyleBackColor = true;
            // 
            // gbxEmployeePayments
            // 
            this.gbxEmployeePayments.Controls.Add(this.btnApproveEmpPayment);
            this.gbxEmployeePayments.Controls.Add(this.btnCancelEmpPayment);
            this.gbxEmployeePayments.Controls.Add(this.btnUpdateEmpPayment);
            this.gbxEmployeePayments.Controls.Add(this.btnEditEmpPayment);
            this.gbxEmployeePayments.Location = new System.Drawing.Point(8, 246);
            this.gbxEmployeePayments.Name = "gbxEmployeePayments";
            this.gbxEmployeePayments.Size = new System.Drawing.Size(503, 338);
            this.gbxEmployeePayments.TabIndex = 14;
            this.gbxEmployeePayments.TabStop = false;
            this.gbxEmployeePayments.Text = "Manage/Issue Payments";
            // 
            // btnApproveEmpPayment
            // 
            this.btnApproveEmpPayment.Location = new System.Drawing.Point(172, 226);
            this.btnApproveEmpPayment.Name = "btnApproveEmpPayment";
            this.btnApproveEmpPayment.Size = new System.Drawing.Size(158, 39);
            this.btnApproveEmpPayment.TabIndex = 6;
            this.btnApproveEmpPayment.Text = "Approve Payment";
            this.btnApproveEmpPayment.UseVisualStyleBackColor = true;
            // 
            // btnCancelEmpPayment
            // 
            this.btnCancelEmpPayment.Location = new System.Drawing.Point(194, 271);
            this.btnCancelEmpPayment.Name = "btnCancelEmpPayment";
            this.btnCancelEmpPayment.Size = new System.Drawing.Size(114, 39);
            this.btnCancelEmpPayment.TabIndex = 5;
            this.btnCancelEmpPayment.Text = "Cancel Edit";
            this.btnCancelEmpPayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmpPayment
            // 
            this.btnUpdateEmpPayment.Location = new System.Drawing.Point(314, 271);
            this.btnUpdateEmpPayment.Name = "btnUpdateEmpPayment";
            this.btnUpdateEmpPayment.Size = new System.Drawing.Size(114, 39);
            this.btnUpdateEmpPayment.TabIndex = 4;
            this.btnUpdateEmpPayment.Text = "Update";
            this.btnUpdateEmpPayment.UseVisualStyleBackColor = true;
            // 
            // btnEditEmpPayment
            // 
            this.btnEditEmpPayment.Location = new System.Drawing.Point(74, 271);
            this.btnEditEmpPayment.Name = "btnEditEmpPayment";
            this.btnEditEmpPayment.Size = new System.Drawing.Size(114, 39);
            this.btnEditEmpPayment.TabIndex = 3;
            this.btnEditEmpPayment.Text = "Edit";
            this.btnEditEmpPayment.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(7, 6);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1029, 234);
            this.dgvEmployees.TabIndex = 2;
            // 
            // tpReports
            // 
            this.tpReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpReports.Location = new System.Drawing.Point(4, 29);
            this.tpReports.Name = "tpReports";
            this.tpReports.Padding = new System.Windows.Forms.Padding(3);
            this.tpReports.Size = new System.Drawing.Size(1044, 622);
            this.tpReports.TabIndex = 4;
            this.tpReports.Text = "Reports";
            this.tpReports.ToolTipText = "View and Manage Reports";
            this.tpReports.UseVisualStyleBackColor = true;
            // 
            // OwnerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 655);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OwnerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerMain";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpJobs.ResumeLayout(false);
            this.gbxJobAssignWorkers.ResumeLayout(false);
            this.gbxJobMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobMaterials)).EndInit();
            this.tpCustomers.ResumeLayout(false);
            this.gbxCustomerInfo.ResumeLayout(false);
            this.gbxCustomerInfo.PerformLayout();
            this.gbxCustomerPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tpContractors.ResumeLayout(false);
            this.gbxContractorInf.ResumeLayout(false);
            this.gbxContractorInf.PerformLayout();
            this.gbxContractorPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractors)).EndInit();
            this.tpEmployees.ResumeLayout(false);
            this.gbxEmployeeInfo.ResumeLayout(false);
            this.gbxEmployeeInfo.PerformLayout();
            this.gbxEmployeePayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpJobs;
        private System.Windows.Forms.TabPage tpCustomers;
        private System.Windows.Forms.TabPage tpContractors;
        private System.Windows.Forms.TabPage tpEmployees;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvContractors;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnCancelMaterials;
        private System.Windows.Forms.Button btnUpdateMaterials;
        private System.Windows.Forms.Button btnEditMaterials;
        private System.Windows.Forms.GroupBox gbxJobMaterials;
        private System.Windows.Forms.DataGridView dgvJobMaterials;
        private System.Windows.Forms.Button btnCancelJobs;
        private System.Windows.Forms.Button btnUpdateJobs;
        private System.Windows.Forms.Button btnEditJobs;
        private System.Windows.Forms.GroupBox gbxJobAssignWorkers;
        private System.Windows.Forms.Button btnApproveJobs;
        private System.Windows.Forms.Button btnApproveMaterials;
        private System.Windows.Forms.ListBox lbxJobEmployees;
        private System.Windows.Forms.ListBox lbxJobContractors;
        private System.Windows.Forms.GroupBox gbxCustomerPayments;
        private System.Windows.Forms.Button btnApproveCustPayments;
        private System.Windows.Forms.Button btnCancelCustPayment;
        private System.Windows.Forms.Button btnUpdateCustPayment;
        private System.Windows.Forms.Button btnEditCustPayment;
        private System.Windows.Forms.GroupBox gbxCustomerInfo;
        private System.Windows.Forms.Label lblCustomerInfoTitle;
        private System.Windows.Forms.Label lblCustomerInfoNew;
        private System.Windows.Forms.Label lblCustomerCategory;
        private System.Windows.Forms.ComboBox cboCustomerCategory;
        private System.Windows.Forms.TextBox tbxCustomerInfoNew;
        private System.Windows.Forms.Button btnCustomerSubmit;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.GroupBox gbxContractorInf;
        private System.Windows.Forms.Label lblContractorInfoTitle;
        private System.Windows.Forms.Label lblContractorInfoNew;
        private System.Windows.Forms.Label lblContractorCategory;
        private System.Windows.Forms.ComboBox cboContractorCategory;
        private System.Windows.Forms.TextBox tbxContractorInfoNew;
        private System.Windows.Forms.Button btnContractorSubmit;
        private System.Windows.Forms.Button btnContractorCancel;
        private System.Windows.Forms.GroupBox gbxContractorPayments;
        private System.Windows.Forms.Button btnApproveContPayment;
        private System.Windows.Forms.Button btnCancelContPayment;
        private System.Windows.Forms.Button btnUpdateContPayment;
        private System.Windows.Forms.Button btnEditContPayment;
        private System.Windows.Forms.GroupBox gbxEmployeeInfo;
        private System.Windows.Forms.Label lblEmployeeInfoTitle;
        private System.Windows.Forms.Label lblEmployeeInfoNew;
        private System.Windows.Forms.Label lblEmployeeCategory;
        private System.Windows.Forms.ComboBox cboEmployeeCategory;
        private System.Windows.Forms.TextBox tbxEmployeeInfoNew;
        private System.Windows.Forms.Button btnEmployeeSubmit;
        private System.Windows.Forms.Button btnEmployeeCancel;
        private System.Windows.Forms.GroupBox gbxEmployeePayments;
        private System.Windows.Forms.Button btnApproveEmpPayment;
        private System.Windows.Forms.Button btnCancelEmpPayment;
        private System.Windows.Forms.Button btnUpdateEmpPayment;
        private System.Windows.Forms.Button btnEditEmpPayment;
    }
}
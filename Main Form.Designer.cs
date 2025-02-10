namespace Inventory_Management_System
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delPrdctBttn = new System.Windows.Forms.Button();
            this.prdctGridView = new System.Windows.Forms.DataGridView();
            this.modPrdctBttn = new System.Windows.Forms.Button();
            this.addPrdctBttn = new System.Windows.Forms.Button();
            this.srchPrdctBttn = new System.Windows.Forms.Button();
            this.prdctSrchTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delPrtBttn = new System.Windows.Forms.Button();
            this.prtGridView = new System.Windows.Forms.DataGridView();
            this.modPrtBttn = new System.Windows.Forms.Button();
            this.addPrtBttn = new System.Windows.Forms.Button();
            this.srchPrtBttn = new System.Windows.Forms.Button();
            this.prtSrchTxtBox = new System.Windows.Forms.TextBox();
            this.exitAppBttn = new System.Windows.Forms.Button();
            this.IMS_Lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdctGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.delPrdctBttn);
            this.groupBox1.Controls.Add(this.prdctGridView);
            this.groupBox1.Controls.Add(this.modPrdctBttn);
            this.groupBox1.Controls.Add(this.addPrdctBttn);
            this.groupBox1.Controls.Add(this.srchPrdctBttn);
            this.groupBox1.Controls.Add(this.prdctSrchTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 297);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Products";
            // 
            // delPrdctBttn
            // 
            this.delPrdctBttn.Location = new System.Drawing.Point(386, 255);
            this.delPrdctBttn.Name = "delPrdctBttn";
            this.delPrdctBttn.Size = new System.Drawing.Size(75, 23);
            this.delPrdctBttn.TabIndex = 19;
            this.delPrdctBttn.Text = "Delete";
            this.delPrdctBttn.UseVisualStyleBackColor = true;
            this.delPrdctBttn.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // prdctGridView
            // 
            this.prdctGridView.AllowUserToAddRows = false;
            this.prdctGridView.AllowUserToDeleteRows = false;
            this.prdctGridView.AllowUserToResizeColumns = false;
            this.prdctGridView.AllowUserToResizeRows = false;
            this.prdctGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prdctGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prdctGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.prdctGridView.Location = new System.Drawing.Point(40, 59);
            this.prdctGridView.MultiSelect = false;
            this.prdctGridView.Name = "prdctGridView";
            this.prdctGridView.RowHeadersVisible = false;
            this.prdctGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prdctGridView.Size = new System.Drawing.Size(400, 171);
            this.prdctGridView.TabIndex = 13;
            // 
            // modPrdctBttn
            // 
            this.modPrdctBttn.Location = new System.Drawing.Point(305, 255);
            this.modPrdctBttn.Name = "modPrdctBttn";
            this.modPrdctBttn.Size = new System.Drawing.Size(75, 23);
            this.modPrdctBttn.TabIndex = 18;
            this.modPrdctBttn.Text = "Modify";
            this.modPrdctBttn.UseVisualStyleBackColor = true;
            this.modPrdctBttn.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // addPrdctBttn
            // 
            this.addPrdctBttn.Location = new System.Drawing.Point(224, 255);
            this.addPrdctBttn.Name = "addPrdctBttn";
            this.addPrdctBttn.Size = new System.Drawing.Size(75, 23);
            this.addPrdctBttn.TabIndex = 17;
            this.addPrdctBttn.Text = "Add";
            this.addPrdctBttn.UseVisualStyleBackColor = true;
            this.addPrdctBttn.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // srchPrdctBttn
            // 
            this.srchPrdctBttn.Location = new System.Drawing.Point(214, 31);
            this.srchPrdctBttn.Name = "srchPrdctBttn";
            this.srchPrdctBttn.Size = new System.Drawing.Size(75, 23);
            this.srchPrdctBttn.TabIndex = 15;
            this.srchPrdctBttn.Text = "Search";
            this.srchPrdctBttn.UseVisualStyleBackColor = true;
            this.srchPrdctBttn.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // prdctSrchTxtBox
            // 
            this.prdctSrchTxtBox.Location = new System.Drawing.Point(284, 33);
            this.prdctSrchTxtBox.Name = "prdctSrchTxtBox";
            this.prdctSrchTxtBox.Size = new System.Drawing.Size(156, 20);
            this.prdctSrchTxtBox.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.delPrtBttn);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.prtGridView);
            this.groupBox2.Controls.Add(this.modPrtBttn);
            this.groupBox2.Controls.Add(this.addPrtBttn);
            this.groupBox2.Controls.Add(this.srchPrtBttn);
            this.groupBox2.Controls.Add(this.prtSrchTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 600);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Parts";
            // 
            // delPrtBttn
            // 
            this.delPrtBttn.Location = new System.Drawing.Point(365, 255);
            this.delPrtBttn.Name = "delPrtBttn";
            this.delPrtBttn.Size = new System.Drawing.Size(75, 23);
            this.delPrtBttn.TabIndex = 19;
            this.delPrtBttn.Text = "Delete";
            this.delPrtBttn.UseVisualStyleBackColor = true;
            this.delPrtBttn.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // prtGridView
            // 
            this.prtGridView.AllowUserToAddRows = false;
            this.prtGridView.AllowUserToDeleteRows = false;
            this.prtGridView.AllowUserToResizeColumns = false;
            this.prtGridView.AllowUserToResizeRows = false;
            this.prtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prtGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.prtGridView.Location = new System.Drawing.Point(40, 58);
            this.prtGridView.MultiSelect = false;
            this.prtGridView.Name = "prtGridView";
            this.prtGridView.RowHeadersVisible = false;
            this.prtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prtGridView.Size = new System.Drawing.Size(400, 171);
            this.prtGridView.TabIndex = 13;
            // 
            // modPrtBttn
            // 
            this.modPrtBttn.Location = new System.Drawing.Point(284, 255);
            this.modPrtBttn.Name = "modPrtBttn";
            this.modPrtBttn.Size = new System.Drawing.Size(75, 23);
            this.modPrtBttn.TabIndex = 18;
            this.modPrtBttn.Text = "Modify";
            this.modPrtBttn.UseVisualStyleBackColor = true;
            this.modPrtBttn.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // addPrtBttn
            // 
            this.addPrtBttn.Location = new System.Drawing.Point(203, 255);
            this.addPrtBttn.Name = "addPrtBttn";
            this.addPrtBttn.Size = new System.Drawing.Size(75, 23);
            this.addPrtBttn.TabIndex = 17;
            this.addPrtBttn.Text = "Add";
            this.addPrtBttn.UseVisualStyleBackColor = true;
            this.addPrtBttn.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // srchPrtBttn
            // 
            this.srchPrtBttn.Location = new System.Drawing.Point(214, 30);
            this.srchPrtBttn.Name = "srchPrtBttn";
            this.srchPrtBttn.Size = new System.Drawing.Size(75, 23);
            this.srchPrtBttn.TabIndex = 15;
            this.srchPrtBttn.Text = "Search";
            this.srchPrtBttn.UseVisualStyleBackColor = true;
            this.srchPrtBttn.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // prtSrchTxtBox
            // 
            this.prtSrchTxtBox.Location = new System.Drawing.Point(284, 32);
            this.prtSrchTxtBox.Name = "prtSrchTxtBox";
            this.prtSrchTxtBox.Size = new System.Drawing.Size(156, 20);
            this.prtSrchTxtBox.TabIndex = 16;
            // 
            // exitAppBttn
            // 
            this.exitAppBttn.Location = new System.Drawing.Point(515, 614);
            this.exitAppBttn.Name = "exitAppBttn";
            this.exitAppBttn.Size = new System.Drawing.Size(75, 23);
            this.exitAppBttn.TabIndex = 21;
            this.exitAppBttn.Text = "Exit";
            this.exitAppBttn.UseVisualStyleBackColor = true;
            this.exitAppBttn.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // IMS_Lbl
            // 
            this.IMS_Lbl.AutoSize = true;
            this.IMS_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IMS_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.IMS_Lbl.Location = new System.Drawing.Point(159, 10);
            this.IMS_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IMS_Lbl.Name = "IMS_Lbl";
            this.IMS_Lbl.Size = new System.Drawing.Size(284, 24);
            this.IMS_Lbl.TabIndex = 22;
            this.IMS_Lbl.Text = "Inventory Management System";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(604, 685);
            this.Controls.Add(this.IMS_Lbl);
            this.Controls.Add(this.exitAppBttn);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Inventory Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdctGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delPrdctBttn;
        private System.Windows.Forms.Button modPrdctBttn;
        private System.Windows.Forms.Button addPrdctBttn;
        private System.Windows.Forms.Button srchPrdctBttn;
        private System.Windows.Forms.TextBox prdctSrchTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delPrtBttn;
        private System.Windows.Forms.Button modPrtBttn;
        private System.Windows.Forms.Button addPrtBttn;
        private System.Windows.Forms.Button srchPrtBttn;
        private System.Windows.Forms.TextBox prtSrchTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitAppBttn;
        public System.Windows.Forms.DataGridView prdctGridView;
        public System.Windows.Forms.DataGridView prtGridView;
        private System.Windows.Forms.Label IMS_Lbl;
    }
}


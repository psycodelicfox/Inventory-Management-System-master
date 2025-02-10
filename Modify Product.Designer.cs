namespace Inventory_Management_System
{
    partial class Modify_Product
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
            this.savePrdctBttn = new System.Windows.Forms.Button();
            this.cancelAddPrdctbttn = new System.Windows.Forms.Button();
            this.PrtAssPrdct_Lbl = new System.Windows.Forms.Label();
            this.delPrtBttn = new System.Windows.Forms.Button();
            this.modAssociatedPrtsGrid = new System.Windows.Forms.DataGridView();
            this.addPrtBttn = new System.Windows.Forms.Button();
            this.srchPrtLstBttn = new System.Windows.Forms.Button();
            this.modPrtSrchTxtBox = new System.Windows.Forms.TextBox();
            this.modPrdctMinTxtBox = new System.Windows.Forms.TextBox();
            this.modPrdctMaxTxtBox = new System.Windows.Forms.TextBox();
            this.modPrdctPriceTxtBox = new System.Windows.Forms.TextBox();
            this.modPrdctInvTxtBox = new System.Windows.Forms.TextBox();
            this.modPrdctNameTxtBox = new System.Windows.Forms.TextBox();
            this.modPrdctIDTxtBox = new System.Windows.Forms.TextBox();
            this.AllPrt_Lbl = new System.Windows.Forms.Label();
            this.modCandidatePrtsGrid = new System.Windows.Forms.DataGridView();
            this.Min_Lbl = new System.Windows.Forms.Label();
            this.Max_Lbl = new System.Windows.Forms.Label();
            this.Price_Lbl = new System.Windows.Forms.Label();
            this.Inv_Lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.ID_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modAssociatedPrtsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modCandidatePrtsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // savePrdctBttn
            // 
            this.savePrdctBttn.Location = new System.Drawing.Point(363, 439);
            this.savePrdctBttn.Name = "savePrdctBttn";
            this.savePrdctBttn.Size = new System.Drawing.Size(75, 23);
            this.savePrdctBttn.TabIndex = 45;
            this.savePrdctBttn.Text = "Save";
            this.savePrdctBttn.UseVisualStyleBackColor = true;
            this.savePrdctBttn.Click += new System.EventHandler(this.SaveNewProductButton_Click);
            // 
            // cancelAddPrdctbttn
            // 
            this.cancelAddPrdctbttn.Location = new System.Drawing.Point(523, 439);
            this.cancelAddPrdctbttn.Name = "cancelAddPrdctbttn";
            this.cancelAddPrdctbttn.Size = new System.Drawing.Size(75, 23);
            this.cancelAddPrdctbttn.TabIndex = 44;
            this.cancelAddPrdctbttn.Text = "Cancel";
            this.cancelAddPrdctbttn.UseVisualStyleBackColor = true;
            this.cancelAddPrdctbttn.Click += new System.EventHandler(this.CancelAddProductbutton_Click);
            // 
            // PrtAssPrdct_Lbl
            // 
            this.PrtAssPrdct_Lbl.AutoSize = true;
            this.PrtAssPrdct_Lbl.Location = new System.Drawing.Point(168, 225);
            this.PrtAssPrdct_Lbl.Name = "PrtAssPrdct_Lbl";
            this.PrtAssPrdct_Lbl.Size = new System.Drawing.Size(167, 13);
            this.PrtAssPrdct_Lbl.TabIndex = 43;
            this.PrtAssPrdct_Lbl.Text = "Parts Associated with this Product";
            // 
            // delPrtBttn
            // 
            this.delPrtBttn.Location = new System.Drawing.Point(539, 366);
            this.delPrtBttn.Name = "delPrtBttn";
            this.delPrtBttn.Size = new System.Drawing.Size(59, 27);
            this.delPrtBttn.TabIndex = 42;
            this.delPrtBttn.Text = "Delete";
            this.delPrtBttn.UseVisualStyleBackColor = true;
            this.delPrtBttn.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // modAssociatedPrtsGrid
            // 
            this.modAssociatedPrtsGrid.AllowUserToAddRows = false;
            this.modAssociatedPrtsGrid.AllowUserToDeleteRows = false;
            this.modAssociatedPrtsGrid.AllowUserToResizeColumns = false;
            this.modAssociatedPrtsGrid.AllowUserToResizeRows = false;
            this.modAssociatedPrtsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modAssociatedPrtsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modAssociatedPrtsGrid.Location = new System.Drawing.Point(171, 241);
            this.modAssociatedPrtsGrid.Name = "modAssociatedPrtsGrid";
            this.modAssociatedPrtsGrid.RowHeadersVisible = false;
            this.modAssociatedPrtsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modAssociatedPrtsGrid.Size = new System.Drawing.Size(426, 119);
            this.modAssociatedPrtsGrid.TabIndex = 41;
            // 
            // addPrtBttn
            // 
            this.addPrtBttn.Location = new System.Drawing.Point(539, 183);
            this.addPrtBttn.Name = "addPrtBttn";
            this.addPrtBttn.Size = new System.Drawing.Size(58, 28);
            this.addPrtBttn.TabIndex = 40;
            this.addPrtBttn.Text = "Add";
            this.addPrtBttn.UseVisualStyleBackColor = true;
            this.addPrtBttn.Click += new System.EventHandler(this.AddPartToItemButton_Click);
            // 
            // srchPrtLstBttn
            // 
            this.srchPrtLstBttn.Location = new System.Drawing.Point(383, 32);
            this.srchPrtLstBttn.Name = "srchPrtLstBttn";
            this.srchPrtLstBttn.Size = new System.Drawing.Size(55, 20);
            this.srchPrtLstBttn.TabIndex = 39;
            this.srchPrtLstBttn.Text = "Search";
            this.srchPrtLstBttn.UseVisualStyleBackColor = true;
            this.srchPrtLstBttn.Click += new System.EventHandler(this.SearchPartListButton_Click);
            // 
            // modPrtSrchTxtBox
            // 
            this.modPrtSrchTxtBox.Location = new System.Drawing.Point(428, 31);
            this.modPrtSrchTxtBox.Name = "modPrtSrchTxtBox";
            this.modPrtSrchTxtBox.Size = new System.Drawing.Size(168, 20);
            this.modPrtSrchTxtBox.TabIndex = 38;
            // 
            // modPrdctMinTxtBox
            // 
            this.modPrdctMinTxtBox.Location = new System.Drawing.Point(54, 321);
            this.modPrdctMinTxtBox.Name = "modPrdctMinTxtBox";
            this.modPrdctMinTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrdctMinTxtBox.TabIndex = 37;
            // 
            // modPrdctMaxTxtBox
            // 
            this.modPrdctMaxTxtBox.Location = new System.Drawing.Point(54, 280);
            this.modPrdctMaxTxtBox.Name = "modPrdctMaxTxtBox";
            this.modPrdctMaxTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrdctMaxTxtBox.TabIndex = 36;
            // 
            // modPrdctPriceTxtBox
            // 
            this.modPrdctPriceTxtBox.Location = new System.Drawing.Point(54, 241);
            this.modPrdctPriceTxtBox.Name = "modPrdctPriceTxtBox";
            this.modPrdctPriceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrdctPriceTxtBox.TabIndex = 35;
            // 
            // modPrdctInvTxtBox
            // 
            this.modPrdctInvTxtBox.Location = new System.Drawing.Point(54, 157);
            this.modPrdctInvTxtBox.Name = "modPrdctInvTxtBox";
            this.modPrdctInvTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrdctInvTxtBox.TabIndex = 34;
            // 
            // modPrdctNameTxtBox
            // 
            this.modPrdctNameTxtBox.Location = new System.Drawing.Point(54, 108);
            this.modPrdctNameTxtBox.Name = "modPrdctNameTxtBox";
            this.modPrdctNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrdctNameTxtBox.TabIndex = 33;
            // 
            // modPrdctIDTxtBox
            // 
            this.modPrdctIDTxtBox.Location = new System.Drawing.Point(54, 58);
            this.modPrdctIDTxtBox.Name = "modPrdctIDTxtBox";
            this.modPrdctIDTxtBox.ReadOnly = true;
            this.modPrdctIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrdctIDTxtBox.TabIndex = 32;
            // 
            // AllPrt_Lbl
            // 
            this.AllPrt_Lbl.AutoSize = true;
            this.AllPrt_Lbl.Location = new System.Drawing.Point(168, 42);
            this.AllPrt_Lbl.Name = "AllPrt_Lbl";
            this.AllPrt_Lbl.Size = new System.Drawing.Size(96, 13);
            this.AllPrt_Lbl.TabIndex = 31;
            this.AllPrt_Lbl.Text = "All Candidate Parts";
            // 
            // modCandidatePrtsGrid
            // 
            this.modCandidatePrtsGrid.AllowUserToAddRows = false;
            this.modCandidatePrtsGrid.AllowUserToDeleteRows = false;
            this.modCandidatePrtsGrid.AllowUserToResizeColumns = false;
            this.modCandidatePrtsGrid.AllowUserToResizeRows = false;
            this.modCandidatePrtsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modCandidatePrtsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modCandidatePrtsGrid.Location = new System.Drawing.Point(170, 58);
            this.modCandidatePrtsGrid.Name = "modCandidatePrtsGrid";
            this.modCandidatePrtsGrid.RowHeadersVisible = false;
            this.modCandidatePrtsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modCandidatePrtsGrid.Size = new System.Drawing.Size(426, 119);
            this.modCandidatePrtsGrid.TabIndex = 30;
            // 
            // Min_Lbl
            // 
            this.Min_Lbl.AutoSize = true;
            this.Min_Lbl.Location = new System.Drawing.Point(28, 324);
            this.Min_Lbl.Name = "Min_Lbl";
            this.Min_Lbl.Size = new System.Drawing.Size(24, 13);
            this.Min_Lbl.TabIndex = 29;
            this.Min_Lbl.Text = "Min";
            // 
            // Max_Lbl
            // 
            this.Max_Lbl.AutoSize = true;
            this.Max_Lbl.Location = new System.Drawing.Point(25, 287);
            this.Max_Lbl.Name = "Max_Lbl";
            this.Max_Lbl.Size = new System.Drawing.Size(27, 13);
            this.Max_Lbl.TabIndex = 28;
            this.Max_Lbl.Text = "Max";
            // 
            // Price_Lbl
            // 
            this.Price_Lbl.AutoSize = true;
            this.Price_Lbl.Location = new System.Drawing.Point(25, 247);
            this.Price_Lbl.Name = "Price_Lbl";
            this.Price_Lbl.Size = new System.Drawing.Size(31, 13);
            this.Price_Lbl.TabIndex = 27;
            this.Price_Lbl.Text = "Price";
            // 
            // Inv_Lbl
            // 
            this.Inv_Lbl.AutoSize = true;
            this.Inv_Lbl.Location = new System.Drawing.Point(5, 160);
            this.Inv_Lbl.Name = "Inv_Lbl";
            this.Inv_Lbl.Size = new System.Drawing.Size(51, 13);
            this.Inv_Lbl.TabIndex = 26;
            this.Inv_Lbl.Text = "Inventory";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Location = new System.Drawing.Point(21, 111);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_Lbl.TabIndex = 25;
            this.Name_Lbl.Text = "Name";
            // 
            // ID_Lbl
            // 
            this.ID_Lbl.AutoSize = true;
            this.ID_Lbl.Location = new System.Drawing.Point(30, 61);
            this.ID_Lbl.Name = "ID_Lbl";
            this.ID_Lbl.Size = new System.Drawing.Size(18, 13);
            this.ID_Lbl.TabIndex = 24;
            this.ID_Lbl.Text = "ID";
            // 
            // Modify_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 477);
            this.Controls.Add(this.savePrdctBttn);
            this.Controls.Add(this.cancelAddPrdctbttn);
            this.Controls.Add(this.PrtAssPrdct_Lbl);
            this.Controls.Add(this.delPrtBttn);
            this.Controls.Add(this.modAssociatedPrtsGrid);
            this.Controls.Add(this.addPrtBttn);
            this.Controls.Add(this.srchPrtLstBttn);
            this.Controls.Add(this.modPrtSrchTxtBox);
            this.Controls.Add(this.modPrdctMinTxtBox);
            this.Controls.Add(this.modPrdctMaxTxtBox);
            this.Controls.Add(this.modPrdctPriceTxtBox);
            this.Controls.Add(this.modPrdctInvTxtBox);
            this.Controls.Add(this.modPrdctNameTxtBox);
            this.Controls.Add(this.modPrdctIDTxtBox);
            this.Controls.Add(this.AllPrt_Lbl);
            this.Controls.Add(this.modCandidatePrtsGrid);
            this.Controls.Add(this.Min_Lbl);
            this.Controls.Add(this.Max_Lbl);
            this.Controls.Add(this.Price_Lbl);
            this.Controls.Add(this.Inv_Lbl);
            this.Controls.Add(this.Name_Lbl);
            this.Controls.Add(this.ID_Lbl);
            this.Name = "Modify_Product";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.modAssociatedPrtsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modCandidatePrtsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savePrdctBttn;
        private System.Windows.Forms.Button cancelAddPrdctbttn;
        private System.Windows.Forms.Label PrtAssPrdct_Lbl;
        private System.Windows.Forms.Button delPrtBttn;
        private System.Windows.Forms.DataGridView modAssociatedPrtsGrid;
        private System.Windows.Forms.Button addPrtBttn;
        private System.Windows.Forms.Button srchPrtLstBttn;
        private System.Windows.Forms.TextBox modPrtSrchTxtBox;
        private System.Windows.Forms.TextBox modPrdctMinTxtBox;
        private System.Windows.Forms.TextBox modPrdctMaxTxtBox;
        private System.Windows.Forms.TextBox modPrdctPriceTxtBox;
        private System.Windows.Forms.TextBox modPrdctInvTxtBox;
        private System.Windows.Forms.TextBox modPrdctNameTxtBox;
        private System.Windows.Forms.TextBox modPrdctIDTxtBox;
        private System.Windows.Forms.Label AllPrt_Lbl;
        private System.Windows.Forms.DataGridView modCandidatePrtsGrid;
        private System.Windows.Forms.Label Min_Lbl;
        private System.Windows.Forms.Label Max_Lbl;
        private System.Windows.Forms.Label Price_Lbl;
        private System.Windows.Forms.Label Inv_Lbl;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.Label ID_Lbl;
    }
}
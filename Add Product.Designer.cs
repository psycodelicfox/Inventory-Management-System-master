namespace Inventory_Management_System
{
    partial class Add_Product
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
            this.ID_lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.Inv_Lbl = new System.Windows.Forms.Label();
            this.price_Lbl = new System.Windows.Forms.Label();
            this.Max_Lbl = new System.Windows.Forms.Label();
            this.Min_Lbl = new System.Windows.Forms.Label();
            this.candidatePrtsGrid = new System.Windows.Forms.DataGridView();
            this.allPrts_Lbl = new System.Windows.Forms.Label();
            this.addPrdctIDTxtBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPrdctPriceTxtBox = new System.Windows.Forms.TextBox();
            this.addPrdctMaxTxtBox = new System.Windows.Forms.TextBox();
            this.addPrdctMinTxtBox = new System.Windows.Forms.TextBox();
            this.srchPrtTxtBox = new System.Windows.Forms.TextBox();
            this.srchPrtListBttn = new System.Windows.Forms.Button();
            this.addPrtBttn = new System.Windows.Forms.Button();
            this.assoPrtsGrid = new System.Windows.Forms.DataGridView();
            this.delPrtBttn = new System.Windows.Forms.Button();
            this.PrtAsso_Lbl = new System.Windows.Forms.Label();
            this.cancelAddPrdctbttn = new System.Windows.Forms.Button();
            this.savePrdctBttn = new System.Windows.Forms.Button();
            this.AddPrdct_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePrtsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assoPrtsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(27, 123);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(18, 13);
            this.ID_lbl.TabIndex = 1;
            this.ID_lbl.Text = "ID";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Location = new System.Drawing.Point(10, 175);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_Lbl.TabIndex = 2;
            this.Name_Lbl.Text = "Name";
            // 
            // Inv_Lbl
            // 
            this.Inv_Lbl.AutoSize = true;
            this.Inv_Lbl.Location = new System.Drawing.Point(-4, 222);
            this.Inv_Lbl.Name = "Inv_Lbl";
            this.Inv_Lbl.Size = new System.Drawing.Size(51, 13);
            this.Inv_Lbl.TabIndex = 3;
            this.Inv_Lbl.Text = "Inventory";
            // 
            // price_Lbl
            // 
            this.price_Lbl.AutoSize = true;
            this.price_Lbl.Location = new System.Drawing.Point(14, 299);
            this.price_Lbl.Name = "price_Lbl";
            this.price_Lbl.Size = new System.Drawing.Size(31, 13);
            this.price_Lbl.TabIndex = 4;
            this.price_Lbl.Text = "Price";
            // 
            // Max_Lbl
            // 
            this.Max_Lbl.AutoSize = true;
            this.Max_Lbl.Location = new System.Drawing.Point(14, 395);
            this.Max_Lbl.Name = "Max_Lbl";
            this.Max_Lbl.Size = new System.Drawing.Size(27, 13);
            this.Max_Lbl.TabIndex = 5;
            this.Max_Lbl.Text = "Max";
            // 
            // Min_Lbl
            // 
            this.Min_Lbl.AutoSize = true;
            this.Min_Lbl.Location = new System.Drawing.Point(14, 349);
            this.Min_Lbl.Name = "Min_Lbl";
            this.Min_Lbl.Size = new System.Drawing.Size(24, 13);
            this.Min_Lbl.TabIndex = 6;
            this.Min_Lbl.Text = "Min";
            // 
            // candidatePrtsGrid
            // 
            this.candidatePrtsGrid.AllowUserToAddRows = false;
            this.candidatePrtsGrid.AllowUserToDeleteRows = false;
            this.candidatePrtsGrid.AllowUserToResizeColumns = false;
            this.candidatePrtsGrid.AllowUserToResizeRows = false;
            this.candidatePrtsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.candidatePrtsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePrtsGrid.Location = new System.Drawing.Point(159, 120);
            this.candidatePrtsGrid.Name = "candidatePrtsGrid";
            this.candidatePrtsGrid.RowHeadersVisible = false;
            this.candidatePrtsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatePrtsGrid.Size = new System.Drawing.Size(426, 119);
            this.candidatePrtsGrid.TabIndex = 7;
            // 
            // allPrts_Lbl
            // 
            this.allPrts_Lbl.AutoSize = true;
            this.allPrts_Lbl.Location = new System.Drawing.Point(156, 94);
            this.allPrts_Lbl.Name = "allPrts_Lbl";
            this.allPrts_Lbl.Size = new System.Drawing.Size(96, 13);
            this.allPrts_Lbl.TabIndex = 8;
            this.allPrts_Lbl.Text = "All Candidate Parts";
            // 
            // addPrdctIDTxtBox
            // 
            this.addPrdctIDTxtBox.Location = new System.Drawing.Point(53, 120);
            this.addPrdctIDTxtBox.Name = "addPrdctIDTxtBox";
            this.addPrdctIDTxtBox.ReadOnly = true;
            this.addPrdctIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.addPrdctIDTxtBox.TabIndex = 9;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(53, 172);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductNameTextBox.TabIndex = 10;
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(53, 219);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductInventoryTextBox.TabIndex = 11;
            // 
            // addPrdctPriceTxtBox
            // 
            this.addPrdctPriceTxtBox.Location = new System.Drawing.Point(53, 296);
            this.addPrdctPriceTxtBox.Name = "addPrdctPriceTxtBox";
            this.addPrdctPriceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.addPrdctPriceTxtBox.TabIndex = 12;
            // 
            // addPrdctMaxTxtBox
            // 
            this.addPrdctMaxTxtBox.Location = new System.Drawing.Point(53, 392);
            this.addPrdctMaxTxtBox.Name = "addPrdctMaxTxtBox";
            this.addPrdctMaxTxtBox.Size = new System.Drawing.Size(100, 20);
            this.addPrdctMaxTxtBox.TabIndex = 13;
            // 
            // addPrdctMinTxtBox
            // 
            this.addPrdctMinTxtBox.Location = new System.Drawing.Point(53, 346);
            this.addPrdctMinTxtBox.Name = "addPrdctMinTxtBox";
            this.addPrdctMinTxtBox.Size = new System.Drawing.Size(100, 20);
            this.addPrdctMinTxtBox.TabIndex = 14;
            // 
            // srchPrtTxtBox
            // 
            this.srchPrtTxtBox.Location = new System.Drawing.Point(417, 90);
            this.srchPrtTxtBox.Name = "srchPrtTxtBox";
            this.srchPrtTxtBox.Size = new System.Drawing.Size(168, 20);
            this.srchPrtTxtBox.TabIndex = 15;
            // 
            // srchPrtListBttn
            // 
            this.srchPrtListBttn.Location = new System.Drawing.Point(365, 90);
            this.srchPrtListBttn.Name = "srchPrtListBttn";
            this.srchPrtListBttn.Size = new System.Drawing.Size(55, 20);
            this.srchPrtListBttn.TabIndex = 16;
            this.srchPrtListBttn.Text = "Search";
            this.srchPrtListBttn.UseVisualStyleBackColor = true;
            this.srchPrtListBttn.Click += new System.EventHandler(this.SearchPartListButton_Click);
            // 
            // addPrtBttn
            // 
            this.addPrtBttn.Location = new System.Drawing.Point(527, 245);
            this.addPrtBttn.Name = "addPrtBttn";
            this.addPrtBttn.Size = new System.Drawing.Size(58, 28);
            this.addPrtBttn.TabIndex = 17;
            this.addPrtBttn.Text = "Add";
            this.addPrtBttn.UseVisualStyleBackColor = true;
            this.addPrtBttn.Click += new System.EventHandler(this.AddPartToItemButton_Click);
            // 
            // assoPrtsGrid
            // 
            this.assoPrtsGrid.AllowUserToAddRows = false;
            this.assoPrtsGrid.AllowUserToDeleteRows = false;
            this.assoPrtsGrid.AllowUserToResizeColumns = false;
            this.assoPrtsGrid.AllowUserToResizeRows = false;
            this.assoPrtsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assoPrtsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assoPrtsGrid.Location = new System.Drawing.Point(159, 293);
            this.assoPrtsGrid.Name = "assoPrtsGrid";
            this.assoPrtsGrid.RowHeadersVisible = false;
            this.assoPrtsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assoPrtsGrid.Size = new System.Drawing.Size(426, 119);
            this.assoPrtsGrid.TabIndex = 18;
            // 
            // delPrtBttn
            // 
            this.delPrtBttn.Location = new System.Drawing.Point(526, 418);
            this.delPrtBttn.Name = "delPrtBttn";
            this.delPrtBttn.Size = new System.Drawing.Size(59, 27);
            this.delPrtBttn.TabIndex = 19;
            this.delPrtBttn.Text = "Delete";
            this.delPrtBttn.UseVisualStyleBackColor = true;
            this.delPrtBttn.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // PrtAsso_Lbl
            // 
            this.PrtAsso_Lbl.AutoSize = true;
            this.PrtAsso_Lbl.Location = new System.Drawing.Point(156, 267);
            this.PrtAsso_Lbl.Name = "PrtAsso_Lbl";
            this.PrtAsso_Lbl.Size = new System.Drawing.Size(167, 13);
            this.PrtAsso_Lbl.TabIndex = 20;
            this.PrtAsso_Lbl.Text = "Parts Associated with this Product";
            // 
            // cancelAddPrdctbttn
            // 
            this.cancelAddPrdctbttn.Location = new System.Drawing.Point(404, 469);
            this.cancelAddPrdctbttn.Name = "cancelAddPrdctbttn";
            this.cancelAddPrdctbttn.Size = new System.Drawing.Size(75, 23);
            this.cancelAddPrdctbttn.TabIndex = 21;
            this.cancelAddPrdctbttn.Text = "Cancel";
            this.cancelAddPrdctbttn.UseVisualStyleBackColor = true;
            this.cancelAddPrdctbttn.Click += new System.EventHandler(this.CancelAddProductbutton_Click);
            // 
            // savePrdctBttn
            // 
            this.savePrdctBttn.Location = new System.Drawing.Point(232, 469);
            this.savePrdctBttn.Name = "savePrdctBttn";
            this.savePrdctBttn.Size = new System.Drawing.Size(75, 23);
            this.savePrdctBttn.TabIndex = 22;
            this.savePrdctBttn.Text = "Save";
            this.savePrdctBttn.UseVisualStyleBackColor = true;
            this.savePrdctBttn.Click += new System.EventHandler(this.SaveNewProductButton_Click);
            // 
            // AddPrdct_Lbl
            // 
            this.AddPrdct_Lbl.AutoSize = true;
            this.AddPrdct_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddPrdct_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrdct_Lbl.Location = new System.Drawing.Point(280, 26);
            this.AddPrdct_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPrdct_Lbl.Name = "AddPrdct_Lbl";
            this.AddPrdct_Lbl.Size = new System.Drawing.Size(122, 24);
            this.AddPrdct_Lbl.TabIndex = 59;
            this.AddPrdct_Lbl.Text = "Add Product";
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 526);
            this.Controls.Add(this.AddPrdct_Lbl);
            this.Controls.Add(this.savePrdctBttn);
            this.Controls.Add(this.cancelAddPrdctbttn);
            this.Controls.Add(this.PrtAsso_Lbl);
            this.Controls.Add(this.delPrtBttn);
            this.Controls.Add(this.assoPrtsGrid);
            this.Controls.Add(this.addPrtBttn);
            this.Controls.Add(this.srchPrtListBttn);
            this.Controls.Add(this.srchPrtTxtBox);
            this.Controls.Add(this.addPrdctMinTxtBox);
            this.Controls.Add(this.addPrdctMaxTxtBox);
            this.Controls.Add(this.addPrdctPriceTxtBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addPrdctIDTxtBox);
            this.Controls.Add(this.allPrts_Lbl);
            this.Controls.Add(this.candidatePrtsGrid);
            this.Controls.Add(this.Min_Lbl);
            this.Controls.Add(this.Max_Lbl);
            this.Controls.Add(this.price_Lbl);
            this.Controls.Add(this.Inv_Lbl);
            this.Controls.Add(this.Name_Lbl);
            this.Controls.Add(this.ID_lbl);
            this.Name = "Add_Product";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.candidatePrtsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assoPrtsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.Label Inv_Lbl;
        private System.Windows.Forms.Label price_Lbl;
        private System.Windows.Forms.Label Max_Lbl;
        private System.Windows.Forms.Label Min_Lbl;
        private System.Windows.Forms.DataGridView candidatePrtsGrid;
        private System.Windows.Forms.Label allPrts_Lbl;
        private System.Windows.Forms.TextBox addPrdctIDTxtBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addPrdctPriceTxtBox;
        private System.Windows.Forms.TextBox addPrdctMaxTxtBox;
        private System.Windows.Forms.TextBox addPrdctMinTxtBox;
        private System.Windows.Forms.TextBox srchPrtTxtBox;
        private System.Windows.Forms.Button srchPrtListBttn;
        private System.Windows.Forms.Button addPrtBttn;
        private System.Windows.Forms.DataGridView assoPrtsGrid;
        private System.Windows.Forms.Button delPrtBttn;
        private System.Windows.Forms.Label PrtAsso_Lbl;
        private System.Windows.Forms.Button cancelAddPrdctbttn;
        private System.Windows.Forms.Button savePrdctBttn;
        private System.Windows.Forms.Label AddPrdct_Lbl;
    }
}
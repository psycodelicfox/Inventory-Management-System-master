namespace Inventory_Management_System
{
    partial class Modify_Part
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
            this.cancelPrtBttn = new System.Windows.Forms.Button();
            this.savePrtBttn = new System.Windows.Forms.Button();
            this.modPrtMacComTxtBox = new System.Windows.Forms.TextBox();
            this.modPrtMinTxtBox = new System.Windows.Forms.TextBox();
            this.modPrtMaxTxtBox = new System.Windows.Forms.TextBox();
            this.modPrtCostTxtBox = new System.Windows.Forms.TextBox();
            this.modPrtInvTxtBox = new System.Windows.Forms.TextBox();
            this.modPrtNameTxtBox = new System.Windows.Forms.TextBox();
            this.modPrtIDTxtBox = new System.Windows.Forms.TextBox();
            this.prtMacComID = new System.Windows.Forms.Label();
            this.Min_Lbl = new System.Windows.Forms.Label();
            this.Max_Lbl = new System.Windows.Forms.Label();
            this.Price_Lbl = new System.Windows.Forms.Label();
            this.Inv_Lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.ID_Lbl = new System.Windows.Forms.Label();
            this.outRadioBttn = new System.Windows.Forms.RadioButton();
            this.inRadioBttn = new System.Windows.Forms.RadioButton();
            this.ModPrt_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelPrtBttn
            // 
            this.cancelPrtBttn.Location = new System.Drawing.Point(109, 362);
            this.cancelPrtBttn.Name = "cancelPrtBttn";
            this.cancelPrtBttn.Size = new System.Drawing.Size(75, 23);
            this.cancelPrtBttn.TabIndex = 38;
            this.cancelPrtBttn.Text = "Cancel";
            this.cancelPrtBttn.UseVisualStyleBackColor = true;
            this.cancelPrtBttn.Click += new System.EventHandler(this.CancelPartCreationButton_Click);
            // 
            // savePrtBttn
            // 
            this.savePrtBttn.Location = new System.Drawing.Point(23, 362);
            this.savePrtBttn.Name = "savePrtBttn";
            this.savePrtBttn.Size = new System.Drawing.Size(75, 23);
            this.savePrtBttn.TabIndex = 37;
            this.savePrtBttn.Text = "Save";
            this.savePrtBttn.UseVisualStyleBackColor = true;
            this.savePrtBttn.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // modPrtMacComTxtBox
            // 
            this.modPrtMacComTxtBox.Location = new System.Drawing.Point(77, 320);
            this.modPrtMacComTxtBox.Name = "modPrtMacComTxtBox";
            this.modPrtMacComTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrtMacComTxtBox.TabIndex = 36;
            // 
            // modPrtMinTxtBox
            // 
            this.modPrtMinTxtBox.Location = new System.Drawing.Point(77, 219);
            this.modPrtMinTxtBox.Name = "modPrtMinTxtBox";
            this.modPrtMinTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrtMinTxtBox.TabIndex = 35;
            // 
            // modPrtMaxTxtBox
            // 
            this.modPrtMaxTxtBox.Location = new System.Drawing.Point(77, 250);
            this.modPrtMaxTxtBox.Name = "modPrtMaxTxtBox";
            this.modPrtMaxTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrtMaxTxtBox.TabIndex = 34;
            // 
            // modPrtCostTxtBox
            // 
            this.modPrtCostTxtBox.Location = new System.Drawing.Point(77, 186);
            this.modPrtCostTxtBox.Name = "modPrtCostTxtBox";
            this.modPrtCostTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrtCostTxtBox.TabIndex = 33;
            // 
            // modPrtInvTxtBox
            // 
            this.modPrtInvTxtBox.Location = new System.Drawing.Point(77, 150);
            this.modPrtInvTxtBox.Name = "modPrtInvTxtBox";
            this.modPrtInvTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrtInvTxtBox.TabIndex = 32;
            // 
            // modPrtNameTxtBox
            // 
            this.modPrtNameTxtBox.Location = new System.Drawing.Point(77, 114);
            this.modPrtNameTxtBox.Name = "modPrtNameTxtBox";
            this.modPrtNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrtNameTxtBox.TabIndex = 31;
            // 
            // modPrtIDTxtBox
            // 
            this.modPrtIDTxtBox.Location = new System.Drawing.Point(77, 80);
            this.modPrtIDTxtBox.Name = "modPrtIDTxtBox";
            this.modPrtIDTxtBox.ReadOnly = true;
            this.modPrtIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.modPrtIDTxtBox.TabIndex = 30;
            // 
            // prtMacComID
            // 
            this.prtMacComID.AutoSize = true;
            this.prtMacComID.Location = new System.Drawing.Point(11, 323);
            this.prtMacComID.Name = "prtMacComID";
            this.prtMacComID.Size = new System.Drawing.Size(62, 13);
            this.prtMacComID.TabIndex = 29;
            this.prtMacComID.Text = "Machine ID";
            // 
            // Min_Lbl
            // 
            this.Min_Lbl.AutoSize = true;
            this.Min_Lbl.Location = new System.Drawing.Point(20, 222);
            this.Min_Lbl.Name = "Min_Lbl";
            this.Min_Lbl.Size = new System.Drawing.Size(24, 13);
            this.Min_Lbl.TabIndex = 28;
            this.Min_Lbl.Text = "Min";
            // 
            // Max_Lbl
            // 
            this.Max_Lbl.AutoSize = true;
            this.Max_Lbl.Location = new System.Drawing.Point(20, 253);
            this.Max_Lbl.Name = "Max_Lbl";
            this.Max_Lbl.Size = new System.Drawing.Size(27, 13);
            this.Max_Lbl.TabIndex = 27;
            this.Max_Lbl.Text = "Max";
            // 
            // Price_Lbl
            // 
            this.Price_Lbl.AutoSize = true;
            this.Price_Lbl.Location = new System.Drawing.Point(11, 189);
            this.Price_Lbl.Name = "Price_Lbl";
            this.Price_Lbl.Size = new System.Drawing.Size(63, 13);
            this.Price_Lbl.TabIndex = 26;
            this.Price_Lbl.Text = "Price / Cost";
            // 
            // Inv_Lbl
            // 
            this.Inv_Lbl.AutoSize = true;
            this.Inv_Lbl.Location = new System.Drawing.Point(11, 153);
            this.Inv_Lbl.Name = "Inv_Lbl";
            this.Inv_Lbl.Size = new System.Drawing.Size(51, 13);
            this.Inv_Lbl.TabIndex = 25;
            this.Inv_Lbl.Text = "Inventory";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Location = new System.Drawing.Point(20, 117);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_Lbl.TabIndex = 24;
            this.Name_Lbl.Text = "Name";
            // 
            // ID_Lbl
            // 
            this.ID_Lbl.AutoSize = true;
            this.ID_Lbl.Location = new System.Drawing.Point(26, 83);
            this.ID_Lbl.Name = "ID_Lbl";
            this.ID_Lbl.Size = new System.Drawing.Size(18, 13);
            this.ID_Lbl.TabIndex = 23;
            this.ID_Lbl.Text = "ID";
            // 
            // outRadioBttn
            // 
            this.outRadioBttn.AutoSize = true;
            this.outRadioBttn.Location = new System.Drawing.Point(97, 283);
            this.outRadioBttn.Name = "outRadioBttn";
            this.outRadioBttn.Size = new System.Drawing.Size(80, 17);
            this.outRadioBttn.TabIndex = 22;
            this.outRadioBttn.TabStop = true;
            this.outRadioBttn.Text = "Outsourced";
            this.outRadioBttn.UseVisualStyleBackColor = true;
            this.outRadioBttn.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // inRadioBttn
            // 
            this.inRadioBttn.AutoSize = true;
            this.inRadioBttn.Location = new System.Drawing.Point(23, 283);
            this.inRadioBttn.Name = "inRadioBttn";
            this.inRadioBttn.Size = new System.Drawing.Size(68, 17);
            this.inRadioBttn.TabIndex = 21;
            this.inRadioBttn.TabStop = true;
            this.inRadioBttn.Text = "In-House";
            this.inRadioBttn.UseVisualStyleBackColor = true;
            this.inRadioBttn.CheckedChanged += new System.EventHandler(this.InhouseRadioButton_CheckedChanged);
            // 
            // ModPrt_Lbl
            // 
            this.ModPrt_Lbl.AutoSize = true;
            this.ModPrt_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ModPrt_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.ModPrt_Lbl.Location = new System.Drawing.Point(50, 22);
            this.ModPrt_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPrt_Lbl.Name = "ModPrt_Lbl";
            this.ModPrt_Lbl.Size = new System.Drawing.Size(113, 24);
            this.ModPrt_Lbl.TabIndex = 39;
            this.ModPrt_Lbl.Text = "Modify Part";
            // 
            // Modify_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 397);
            this.Controls.Add(this.ModPrt_Lbl);
            this.Controls.Add(this.cancelPrtBttn);
            this.Controls.Add(this.savePrtBttn);
            this.Controls.Add(this.modPrtMacComTxtBox);
            this.Controls.Add(this.modPrtMinTxtBox);
            this.Controls.Add(this.modPrtMaxTxtBox);
            this.Controls.Add(this.modPrtCostTxtBox);
            this.Controls.Add(this.modPrtInvTxtBox);
            this.Controls.Add(this.modPrtNameTxtBox);
            this.Controls.Add(this.modPrtIDTxtBox);
            this.Controls.Add(this.prtMacComID);
            this.Controls.Add(this.Min_Lbl);
            this.Controls.Add(this.Max_Lbl);
            this.Controls.Add(this.Price_Lbl);
            this.Controls.Add(this.Inv_Lbl);
            this.Controls.Add(this.Name_Lbl);
            this.Controls.Add(this.ID_Lbl);
            this.Controls.Add(this.outRadioBttn);
            this.Controls.Add(this.inRadioBttn);
            this.Name = "Modify_Part";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelPrtBttn;
        private System.Windows.Forms.Button savePrtBttn;
        private System.Windows.Forms.TextBox modPrtMacComTxtBox;
        private System.Windows.Forms.TextBox modPrtMinTxtBox;
        private System.Windows.Forms.TextBox modPrtMaxTxtBox;
        private System.Windows.Forms.TextBox modPrtCostTxtBox;
        private System.Windows.Forms.TextBox modPrtInvTxtBox;
        private System.Windows.Forms.TextBox modPrtNameTxtBox;
        private System.Windows.Forms.TextBox modPrtIDTxtBox;
        private System.Windows.Forms.Label prtMacComID;
        private System.Windows.Forms.Label Min_Lbl;
        private System.Windows.Forms.Label Max_Lbl;
        private System.Windows.Forms.Label Price_Lbl;
        private System.Windows.Forms.Label Inv_Lbl;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.Label ID_Lbl;
        private System.Windows.Forms.RadioButton outRadioBttn;
        private System.Windows.Forms.RadioButton inRadioBttn;
        private System.Windows.Forms.Label ModPrt_Lbl;
    }
}
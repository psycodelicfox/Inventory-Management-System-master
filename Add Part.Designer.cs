namespace Inventory_Management_System
{
    partial class AddPart
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
            this.inhouseRadioBttn = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioBttn = new System.Windows.Forms.RadioButton();
            this.ID_Lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.Inv_Lbl = new System.Windows.Forms.Label();
            this.Price_Lbl = new System.Windows.Forms.Label();
            this.Max_Lbl = new System.Windows.Forms.Label();
            this.Min_Lbl = new System.Windows.Forms.Label();
            this.MachID_Lbl = new System.Windows.Forms.Label();
            this.prtIDTxtBox = new System.Windows.Forms.TextBox();
            this.prtNmeTxtBox = new System.Windows.Forms.TextBox();
            this.prtInvTxtBox = new System.Windows.Forms.TextBox();
            this.prtCostTxtBox = new System.Windows.Forms.TextBox();
            this.prtMaxTxtBox = new System.Windows.Forms.TextBox();
            this.prtMinTxtBox = new System.Windows.Forms.TextBox();
            this.prtMacComTxtBox = new System.Windows.Forms.TextBox();
            this.savePrtBttn = new System.Windows.Forms.Button();
            this.cancelPrtButton = new System.Windows.Forms.Button();
            this.AddPrtLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inhouseRadioBttn
            // 
            this.inhouseRadioBttn.AutoSize = true;
            this.inhouseRadioBttn.Location = new System.Drawing.Point(21, 284);
            this.inhouseRadioBttn.Name = "inhouseRadioBttn";
            this.inhouseRadioBttn.Size = new System.Drawing.Size(68, 17);
            this.inhouseRadioBttn.TabIndex = 1;
            this.inhouseRadioBttn.TabStop = true;
            this.inhouseRadioBttn.Text = "In-House";
            this.inhouseRadioBttn.UseVisualStyleBackColor = true;
            this.inhouseRadioBttn.CheckedChanged += new System.EventHandler(this.InhouseRadioButton_CheckedChanged);
            // 
            // outsourcedRadioBttn
            // 
            this.outsourcedRadioBttn.AutoSize = true;
            this.outsourcedRadioBttn.Location = new System.Drawing.Point(95, 284);
            this.outsourcedRadioBttn.Name = "outsourcedRadioBttn";
            this.outsourcedRadioBttn.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadioBttn.TabIndex = 2;
            this.outsourcedRadioBttn.TabStop = true;
            this.outsourcedRadioBttn.Text = "Outsourced";
            this.outsourcedRadioBttn.UseVisualStyleBackColor = true;
            this.outsourcedRadioBttn.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // ID_Lbl
            // 
            this.ID_Lbl.AutoSize = true;
            this.ID_Lbl.Location = new System.Drawing.Point(35, 51);
            this.ID_Lbl.Name = "ID_Lbl";
            this.ID_Lbl.Size = new System.Drawing.Size(18, 13);
            this.ID_Lbl.TabIndex = 3;
            this.ID_Lbl.Text = "ID";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Location = new System.Drawing.Point(18, 92);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_Lbl.TabIndex = 4;
            this.Name_Lbl.Text = "Name";
            // 
            // Inv_Lbl
            // 
            this.Inv_Lbl.AutoSize = true;
            this.Inv_Lbl.Location = new System.Drawing.Point(2, 126);
            this.Inv_Lbl.Name = "Inv_Lbl";
            this.Inv_Lbl.Size = new System.Drawing.Size(51, 13);
            this.Inv_Lbl.TabIndex = 5;
            this.Inv_Lbl.Text = "Inventory";
            // 
            // Price_Lbl
            // 
            this.Price_Lbl.AutoSize = true;
            this.Price_Lbl.Location = new System.Drawing.Point(2, 172);
            this.Price_Lbl.Name = "Price_Lbl";
            this.Price_Lbl.Size = new System.Drawing.Size(63, 13);
            this.Price_Lbl.TabIndex = 6;
            this.Price_Lbl.Text = "Price / Cost";
            // 
            // Max_Lbl
            // 
            this.Max_Lbl.AutoSize = true;
            this.Max_Lbl.Location = new System.Drawing.Point(29, 243);
            this.Max_Lbl.Name = "Max_Lbl";
            this.Max_Lbl.Size = new System.Drawing.Size(27, 13);
            this.Max_Lbl.TabIndex = 7;
            this.Max_Lbl.Text = "Max";
            // 
            // Min_Lbl
            // 
            this.Min_Lbl.AutoSize = true;
            this.Min_Lbl.Location = new System.Drawing.Point(29, 205);
            this.Min_Lbl.Name = "Min_Lbl";
            this.Min_Lbl.Size = new System.Drawing.Size(24, 13);
            this.Min_Lbl.TabIndex = 8;
            this.Min_Lbl.Text = "Min";
            // 
            // MachID_Lbl
            // 
            this.MachID_Lbl.AutoSize = true;
            this.MachID_Lbl.Location = new System.Drawing.Point(3, 322);
            this.MachID_Lbl.Name = "MachID_Lbl";
            this.MachID_Lbl.Size = new System.Drawing.Size(62, 13);
            this.MachID_Lbl.TabIndex = 9;
            this.MachID_Lbl.Text = "Machine ID";
            // 
            // prtIDTxtBox
            // 
            this.prtIDTxtBox.Location = new System.Drawing.Point(69, 48);
            this.prtIDTxtBox.Name = "prtIDTxtBox";
            this.prtIDTxtBox.ReadOnly = true;
            this.prtIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.prtIDTxtBox.TabIndex = 10;
            // 
            // prtNmeTxtBox
            // 
            this.prtNmeTxtBox.Location = new System.Drawing.Point(69, 85);
            this.prtNmeTxtBox.Name = "prtNmeTxtBox";
            this.prtNmeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.prtNmeTxtBox.TabIndex = 11;
            // 
            // prtInvTxtBox
            // 
            this.prtInvTxtBox.Location = new System.Drawing.Point(69, 126);
            this.prtInvTxtBox.Name = "prtInvTxtBox";
            this.prtInvTxtBox.Size = new System.Drawing.Size(100, 20);
            this.prtInvTxtBox.TabIndex = 12;
            // 
            // prtCostTxtBox
            // 
            this.prtCostTxtBox.Location = new System.Drawing.Point(69, 169);
            this.prtCostTxtBox.Name = "prtCostTxtBox";
            this.prtCostTxtBox.Size = new System.Drawing.Size(100, 20);
            this.prtCostTxtBox.TabIndex = 13;
            // 
            // prtMaxTxtBox
            // 
            this.prtMaxTxtBox.Location = new System.Drawing.Point(69, 240);
            this.prtMaxTxtBox.Name = "prtMaxTxtBox";
            this.prtMaxTxtBox.Size = new System.Drawing.Size(68, 20);
            this.prtMaxTxtBox.TabIndex = 14;
            // 
            // prtMinTxtBox
            // 
            this.prtMinTxtBox.Location = new System.Drawing.Point(69, 202);
            this.prtMinTxtBox.Name = "prtMinTxtBox";
            this.prtMinTxtBox.Size = new System.Drawing.Size(74, 20);
            this.prtMinTxtBox.TabIndex = 15;
            // 
            // prtMacComTxtBox
            // 
            this.prtMacComTxtBox.Location = new System.Drawing.Point(69, 319);
            this.prtMacComTxtBox.Name = "prtMacComTxtBox";
            this.prtMacComTxtBox.Size = new System.Drawing.Size(100, 20);
            this.prtMacComTxtBox.TabIndex = 16;
            // 
            // savePrtBttn
            // 
            this.savePrtBttn.Location = new System.Drawing.Point(5, 378);
            this.savePrtBttn.Name = "savePrtBttn";
            this.savePrtBttn.Size = new System.Drawing.Size(75, 23);
            this.savePrtBttn.TabIndex = 18;
            this.savePrtBttn.Text = "Save";
            this.savePrtBttn.UseVisualStyleBackColor = true;
            this.savePrtBttn.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // cancelPrtButton
            // 
            this.cancelPrtButton.Location = new System.Drawing.Point(109, 378);
            this.cancelPrtButton.Name = "cancelPrtButton";
            this.cancelPrtButton.Size = new System.Drawing.Size(75, 23);
            this.cancelPrtButton.TabIndex = 19;
            this.cancelPrtButton.Text = "Cancel";
            this.cancelPrtButton.UseVisualStyleBackColor = true;
            this.cancelPrtButton.Click += new System.EventHandler(this.CancelPartCreationButton_Click);
            // 
            // AddPrtLbl
            // 
            this.AddPrtLbl.AutoSize = true;
            this.AddPrtLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddPrtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.AddPrtLbl.Location = new System.Drawing.Point(109, 9);
            this.AddPrtLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPrtLbl.Name = "AddPrtLbl";
            this.AddPrtLbl.Size = new System.Drawing.Size(90, 24);
            this.AddPrtLbl.TabIndex = 20;
            this.AddPrtLbl.Text = "Add Part";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 420);
            this.Controls.Add(this.AddPrtLbl);
            this.Controls.Add(this.cancelPrtButton);
            this.Controls.Add(this.savePrtBttn);
            this.Controls.Add(this.prtMacComTxtBox);
            this.Controls.Add(this.prtMinTxtBox);
            this.Controls.Add(this.prtMaxTxtBox);
            this.Controls.Add(this.prtCostTxtBox);
            this.Controls.Add(this.prtInvTxtBox);
            this.Controls.Add(this.prtNmeTxtBox);
            this.Controls.Add(this.prtIDTxtBox);
            this.Controls.Add(this.MachID_Lbl);
            this.Controls.Add(this.Min_Lbl);
            this.Controls.Add(this.Max_Lbl);
            this.Controls.Add(this.Price_Lbl);
            this.Controls.Add(this.Inv_Lbl);
            this.Controls.Add(this.Name_Lbl);
            this.Controls.Add(this.ID_Lbl);
            this.Controls.Add(this.outsourcedRadioBttn);
            this.Controls.Add(this.inhouseRadioBttn);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inhouseRadioBttn;
        private System.Windows.Forms.RadioButton outsourcedRadioBttn;
        private System.Windows.Forms.Label ID_Lbl;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.Label Inv_Lbl;
        private System.Windows.Forms.Label Price_Lbl;
        private System.Windows.Forms.Label Max_Lbl;
        private System.Windows.Forms.Label Min_Lbl;
        private System.Windows.Forms.Label MachID_Lbl;
        private System.Windows.Forms.TextBox prtIDTxtBox;
        private System.Windows.Forms.TextBox prtNmeTxtBox;
        private System.Windows.Forms.TextBox prtInvTxtBox;
        private System.Windows.Forms.TextBox prtCostTxtBox;
        private System.Windows.Forms.TextBox prtMaxTxtBox;
        private System.Windows.Forms.TextBox prtMinTxtBox;
        private System.Windows.Forms.TextBox prtMacComTxtBox;
        private System.Windows.Forms.Button savePrtBttn;
        private System.Windows.Forms.Button cancelPrtButton;
        private System.Windows.Forms.Label AddPrtLbl;
    }
}
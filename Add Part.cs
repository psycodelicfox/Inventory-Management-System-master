using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class AddPart : Form
    {
        
        public AddPart()
        {
            InitializeComponent();
        }
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            // Initialize variables
            int minStock, maxStock, invInStock;
            decimal price;

            // Validate numeric fields using TryParse
            if (!int.TryParse(prtMinTxtBox.Text, out minStock))
            {
                MessageBox.Show("Min must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(prtMaxTxtBox.Text, out maxStock))
            {
                MessageBox.Show("Max must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(prtInvTxtBox.Text, out invInStock))
            {
                MessageBox.Show("Inventory must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(prtCostTxtBox.Text, out price))
            {
                MessageBox.Show("Price must be a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validation
            if (minStock > maxStock)
            {
                MessageBox.Show("Max must be greater than or equal to Min.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (invInStock < minStock || invInStock > maxStock)
            {
                MessageBox.Show("Inventory must be between Min and Max values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse other input fields
            string name = prtNmeTxtBox.Text;

            // Determine the type of part based on the selected radio button
            if (inhouseRadioBttn.Checked)
            {
                // Validate Machine ID for InHousePart
                if (!int.TryParse(prtMacComTxtBox.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create and add an InHousePart
                InHousePart inPart = new InHousePart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, machineID);
                Inventory.AddPart(inPart);
            }
            else
            {
                // Create and add an OutsourcedPart
                OutsourcedPart outPart = new OutsourcedPart((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, prtMacComTxtBox.Text);
                Inventory.AddPart(outPart);
            }

            // Close the form after saving
            Close();
        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachID_Lbl.Text = "Machine ID";
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachID_Lbl.Text = "Company Name";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

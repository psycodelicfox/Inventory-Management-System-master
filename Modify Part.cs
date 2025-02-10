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
    public partial class Modify_Part : Form
    {
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];

        //load selected data based on if part is inhouse or outsourced.
        public Modify_Part(InHousePart inPart)
        {
            InitializeComponent();
            modPrtIDTxtBox.Text = inPart.PartID.ToString();
            modPrtNameTxtBox.Text = inPart.Name;
            modPrtInvTxtBox.Text = inPart.Inventory.ToString();
            modPrtCostTxtBox.Text = inPart.Price.Substring(1).ToString();
            modPrtMaxTxtBox.Text = inPart.Max.ToString();
            modPrtMinTxtBox.Text = inPart.Min.ToString();
            modPrtMacComTxtBox.Text = inPart.MachineID.ToString();
        }

        public Modify_Part(OutsourcedPart outPart)
        {
            InitializeComponent();
            modPrtIDTxtBox.Text = outPart.PartID.ToString();
            modPrtNameTxtBox.Text = outPart.Name;
            modPrtInvTxtBox.Text = outPart.Inventory.ToString();
            modPrtCostTxtBox.Text = outPart.Price.Substring(1).ToString();
            modPrtMaxTxtBox.Text = outPart.Max.ToString();
            modPrtMinTxtBox.Text = outPart.Min.ToString();
            modPrtMacComTxtBox.Text = outPart.CompName;

            outRadioBttn.Checked = true;
        }
        //override selected part with new data
        private void SavePartButton_Click(object sender, EventArgs e)
        {// Initialize variables
            int minStock, maxStock, invInStock, id;
            decimal price;

            // Validate numeric fields using TryParse
            if (!int.TryParse(modPrtMinTxtBox.Text, out minStock))
            {
                MessageBox.Show("Min must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(modPrtMaxTxtBox.Text, out maxStock))
            {
                MessageBox.Show("Max must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(modPrtInvTxtBox.Text, out invInStock))
            {
                MessageBox.Show("Inventory must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(modPrtCostTxtBox.Text, out price))
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

            // Parse the Part ID
            id = int.Parse(modPrtIDTxtBox.Text);
            string name = modPrtNameTxtBox.Text;

            // Create or update the part based on the radio button selection
            if (inRadioBttn.Checked)
            {
                // Validate Machine ID for InHousePart
                if (!int.TryParse(modPrtMacComTxtBox.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InHousePart inPart = new InHousePart(id, name, invInStock, price, maxStock, minStock, machineID);
                Inventory.UpdatePart(id, inPart);
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, invInStock, price, maxStock, minStock, modPrtMacComTxtBox.Text);
                Inventory.UpdatePart(id, outPart);
            }

            // Close and refresh the main window grid
            Close();
            MainWindow.prtGridView.Update();
            MainWindow.prtGridView.Refresh();
        }
        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            prtMacComID.Text = "Company Name";
        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            prtMacComID.Text = "Machine ID";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

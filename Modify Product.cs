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
    public partial class Modify_Product : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
        public Modify_Product(Product prod)
        {
            InitializeComponent();

            //product fields populated with selected product
            modPrdctIDTxtBox.Text = prod.ProductID.ToString();
            modPrdctNameTxtBox.Text = prod.Name;
            modPrdctInvTxtBox.Text = prod.Inventory.ToString();
            modPrdctPriceTxtBox.Text = prod.Price.Substring(1).ToString();
            modPrdctMaxTxtBox.Text = prod.Max.ToString();
            modPrdctMinTxtBox.Text = prod.Min.ToString();

            //populates top table with all products
            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            modCandidatePrtsGrid.DataSource = topTable;

            //populates bottom table with linked parts
            foreach (Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            modAssociatedPrtsGrid.DataSource = botTable;
        }
        private void CancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveNewProductButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;
            
            try
            {
                min = int.Parse(modPrdctMinTxtBox.Text);
                max = int.Parse(modPrdctMaxTxtBox.Text);
                inventory = int.Parse(modPrdctInvTxtBox.Text);
                price = decimal.Parse(modPrdctPriceTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = int.Parse(modPrdctIDTxtBox.Text);
            string name = modPrdctNameTxtBox.Text;
            inventory = int.Parse(modPrdctInvTxtBox.Text);
            price = decimal.Parse(modPrdctPriceTxtBox.Text);
            min = int.Parse(modPrdctMinTxtBox.Text);
            max = int.Parse(modPrdctMaxTxtBox.Text);

            //prevents user from having higher min than max.
            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }
            //creates new Product and adds it to inventory with parts
            Product product = new Product(id, name, inventory, price, max, min);
            foreach(Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(id, product);
            Close();

            MainWindow.prdctGridView.Update();
            MainWindow.prdctGridView.Refresh();
        }

        private void AddPartToItemButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modCandidatePrtsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void SearchPartListButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(modPrtSrchTxtBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in modCandidatePrtsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                Part part = (Part)modAssociatedPrtsGrid.CurrentRow.DataBoundItem;
                int id = int.Parse(modPrdctIDTxtBox.Text);

                Product product = Inventory.LookupProduct(id);
                product.RemoveAssociatedPart(part.PartID);

                foreach (DataGridViewRow row in modAssociatedPrtsGrid.SelectedRows)
                {
                    modAssociatedPrtsGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
    }
}

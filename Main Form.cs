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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            prtGridView.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            prdctGridView.DataSource = prodTable;
        }


        private void AddPartButton_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

      
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if(prtGridView.CurrentRow.DataBoundItem.GetType() == typeof(Inventory_Management_System.InHousePart))
            {
                InHousePart inHousePart = (InHousePart)prtGridView.CurrentRow.DataBoundItem;
                new Modify_Part(inHousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)prtGridView.CurrentRow.DataBoundItem;
                new Modify_Part(outsourcedPart).ShowDialog();
            }
        }
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (prtGridView.CurrentRow != null)
            {
                Part selectedPart = prtGridView.CurrentRow.DataBoundItem as Part;

                // Check if part is associated with any products
                foreach (Product product in Inventory.Products)
                {
                    if (product.AssociatedParts.Contains(selectedPart))
                    {
                        MessageBox.Show("Cannot delete part associated with a product. Remove it from products first.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show("Do you want to delete this part? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Inventory.DeletePart(selectedPart);
                    prtGridView.DataSource = null;
                    prtGridView.DataSource = Inventory.Parts;
                }
            }
        }

        //checks if text in search box matches id of a part. If it does then it selects the row.
        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            // Validate if input is numeric
            if (int.TryParse(prtSrchTxtBox.Text, out int searchValue))
            {
                Part match = Inventory.LookupPart(searchValue);
                if (match != null)
                {
                    foreach (DataGridViewRow row in prtGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        row.Selected = part.PartID == match.PartID;
                    }
                }
                else
                {
                    MessageBox.Show("Part not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Part ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            
            new Add_Product().ShowDialog();
        }
     
        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)prdctGridView.CurrentRow.DataBoundItem;
            new Modify_Product(selectedProd).ShowDialog();
        }

        //if there is more than one associated part then displays error else it removes row at selected index.
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)prdctGridView.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                    return;
                }
                foreach (DataGridViewRow row in prdctGridView.SelectedRows)
                {
                    prdctGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            // Validate if input is numeric
            if (int.TryParse(prdctSrchTxtBox.Text, out int searchValue))
            {
                Product match = Inventory.LookupProduct(searchValue);
                if (match != null)
                {
                    foreach (DataGridViewRow row in prdctGridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        row.Selected = product.ProductID == match.ProductID;
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Product ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryExpenseTracker
{
    public partial class PurchaseListWindow : Form
    {
        private Application        mainApp;
        private Model.PurchaseList originalPurchaseList = null;
        private bool               isEditing            = false;

        private void ActivateNewListMode()
        {
            tbMarketName.Visible  = true;
            lblMarketName.Visible = false;
            lblGrandTotal.Visible = false;
            btnSaveList.Enabled   = true;

            dgPurchaseList.Columns[3].Visible = false;

            lblDate.Text = DateTime.Now.ToString();
        }

        private void DisplayPurchaseList(Model.PurchaseList purchaseList)
        {
            float grandTotal = 0;

            for(int i=0; i < purchaseList.ProductList.Count; i++)
            {
                Model.Product product   = purchaseList.ProductList[i];
                float productTotalPrice = product.QTY * product.UnitPrice;

                if(dgPurchaseList.Rows.GetRowCount(DataGridViewElementStates.Displayed) - 1 != purchaseList.ProductList.Count)
                    dgPurchaseList.Rows.Add();

                var row = dgPurchaseList.Rows[i];

                row.Cells[0].Value = product.Name;
                row.Cells[1].Value = product.QTY.ToString();
                row.Cells[2].Value = product.UnitPrice.ToString();
                row.Cells[3].Value = productTotalPrice.ToString();

                grandTotal += productTotalPrice;
            }

            lblMarketName.Text = purchaseList.MarketName;
            lblDate.Text       = purchaseList.Date.ToString();
            lblGrandTotal.Text = "Grand Total: " + grandTotal.ToString() + SettingsUtil.GetCurrencySymbol();
        }

        public PurchaseListWindow(Application mainApp, Model.PurchaseList purchaseList = null)
        {
            this.mainApp = mainApp;
            this.mainApp.Hide();

            InitializeComponent();
            MinimumSize = Size;

            if(purchaseList == null) ActivateNewListMode();
            else
            {
                isEditing = true;
                originalPurchaseList = purchaseList;

                btnSaveList.Text   = "Update";
                btnDelete.Visible  = true;

                DisplayPurchaseList(purchaseList);
            }
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            bool exception = false;

            Model.PurchaseList purchaseList = new Model.PurchaseList
            {
                MarketName = isEditing ? originalPurchaseList.MarketName : tbMarketName.Text,
                Date       = isEditing ? originalPurchaseList.Date       : DateTime.Now
            };

            for(int i=0; i < dgPurchaseList.RowCount - 1; i++)
            {
                try
                {
                    var row = dgPurchaseList.Rows[i];

                    Model.Product product = new Model.Product
                    {
                        Name      = row.Cells[0].Value.ToString(),
                        QTY       = Convert.ToUInt32(row.Cells[1].Value),
                        UnitPrice = Convert.ToSingle(row.Cells[2].Value.ToString().Replace('.', ','))
                    };

                    purchaseList.ProductList.Add(product);
                }
                catch(Exception ex)
                {
                    exception = true;
                    MessageBox.Show("An error occured. Please see below for more details:\n"+ex.Message, "Error", MessageBoxButtons.OK);
                    break;
                }
            }

            if(exception) return;

            if(isEditing)
            {
                for(int i=0; i < mainApp.purchaseHistory.History.Count; i++)
                {
                    if(originalPurchaseList == mainApp.purchaseHistory.History[i])
                        mainApp.purchaseHistory.History[i] = purchaseList;

                    originalPurchaseList = purchaseList;
                }
            }
            else mainApp.purchaseHistory.History.Insert(0, purchaseList);
            
            mainApp.purchaseHistory.Save(mainApp.purchaseDataFile);
            MessageBox.Show(isEditing ? "Purchase list has been updated." : "Purchase list has been saved.", "Info", MessageBoxButtons.OK);
            
            if(!isEditing) 
            {
                mainApp.LoadPurchaseData();
                Close();
            } 
            else
            {
                btnSaveList.Enabled = false;
                DisplayPurchaseList(originalPurchaseList);
            }
        }

        private void PurchaseListWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainApp.Show();
        }

        private void dgPurchaseList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveList.Enabled = true;

            // QTY || Unit Price
            if(e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                dgPurchaseList.Rows[e.RowIndex].Cells[3].Value = "-";
                lblGrandTotal.Text = "Grand Total: -";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(isEditing
            && MessageBox.Show("Are you sure to delete this purchase list?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for(int i=0; i < mainApp.purchaseHistory.History.Count; i++)
                {
                    if(originalPurchaseList == mainApp.purchaseHistory.History[i])
                        mainApp.purchaseHistory.History.RemoveAt(i);
                }

                mainApp.purchaseHistory.Save(mainApp.purchaseDataFile);
                mainApp.LoadPurchaseData();

                MessageBox.Show("Purchase list has been deleted.", "Info", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}

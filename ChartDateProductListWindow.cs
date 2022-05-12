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
    public partial class ChartDateProductListWindow : Form
    {
        private Form parent;

        public ChartDateProductListWindow(Form parent, Model.PurchaseList purchaseList)
        {
            this.parent = parent;
            this.parent.Hide();

            InitializeComponent();

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

            lblDate.Text       = purchaseList.Date.ToShortDateString();
            lblGrandTotal.Text = "Grand Total: " + grandTotal.ToString()+"TL";
        }

        private void ChartDateProductListWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
